Imports System
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Text.RegularExpressions
Imports System.IO

Public Class Form1
    <DllImport("psapi.dll")>
    Public Shared Function EmptyWorkingSet(ByVal hProcess As IntPtr) As Boolean
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As String = Date.Today.Year.ToString
        lblCopyright.Text = "© " & year & " by Dominick Lee."
        lblVersion.Text = "v" & Application.ProductVersion
        lstOrientations.SelectionMode = SelectionMode.MultiExtended
        txtProjectPath.Text = My.Settings.projectPath
        txtProjectPath.SelectionStart = txtProjectPath.Text.Length
        txtProjectPath.SelectionLength = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("This will terminate all processes related to Android Studio. Be sure to save your project first. Unsaved files may be lost permanently. Do you want to continue?", "Flutter Cleaner - Confirmation", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MsgBox("Operation cancelled")
        ElseIf result = DialogResult.No Then
            MsgBox("Operation cancelled")
        ElseIf result = DialogResult.Yes Then
            killProcess("studio")
            killProcess("studio64")
            killProcess("java")
            killProcess("dart")
            killProcess("chromium")
            killProcess("CefSharp.BrowserSubprocess")
            killProcess("conhost")
            killProcess("cmd")
            killProcess("adb")
            MsgBox("Android Studio processes have been terminated successfully!")
        End If
    End Sub

    Private Sub killProcess(ByVal processName As String)
        Try
            Dim procs As Process() = Process.GetProcessesByName(processName)

            For Each proc As Process In procs
                proc.Kill()
            Next
        Catch ex As Exception
            MsgBox("Failed to terminate " & processName & " processes")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cleanRAM("studio")
        cleanRAM("studio64")
        cleanRAM("java")
        cleanRAM("dart")
        cleanRAM("chromium")
        cleanRAM("conhost")
        MsgBox("RAM has been cleaned successfully!")
    End Sub

    Private Sub cleanRAM(ByVal processName As String)
        Try
            Dim procs As Process() = Process.GetProcessesByName(processName)
            For Each proc As Process In procs
                Dim Result As Boolean = EmptyWorkingSet(proc.Handle)
            Next
        Catch ex As Exception
            MsgBox("Failed to clear RAM for " & processName & "processes")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Environment.Is64BitOperatingSystem = True Then
            Try
                Process.Start("C:\Program Files\Android\Android Studio\bin\studio64.exe")
            Catch ex As Exception
                MsgBox("Failed to launch Android Studio")
            End Try
        Else
            Try
                Process.Start("C:\Program Files\Android\Android Studio\bin\studio.exe")
            Catch ex As Exception
                MsgBox("Failed to launch Android Studio")
            End Try
        End If
    End Sub

    Private Sub btnBrowseProject_Click(sender As Object, e As EventArgs) Handles btnBrowseProject.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath) Then
                txtProjectPath.Text = FolderBrowserDialog1.SelectedPath
                txtProjectPath.SelectionStart = txtProjectPath.Text.Length
                txtProjectPath.SelectionLength = 0
                My.Settings.projectPath = FolderBrowserDialog1.SelectedPath
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub btnGetNames_Click(sender As Object, e As EventArgs) Handles btnGetNames.Click
        If validateAndroidManifests(txtProjectPath.Text) Then
            Dim packageName As String = getPackageName(txtProjectPath.Text)
            txtPackageName.Text = packageName
            Dim appName As String = getAppName(txtProjectPath.Text)
            txtAppName.Text = appName
        Else
            MsgBox("Your project path is invalid. Please ensure the root project path is selected.")
        End If
    End Sub

    Public Function validateAndroidManifests(ByVal projPath As String)
        'Make sure the following exists:
        '{app}/android/app/src/debug/AndroidManifest.xml
        '{app}/android/app/src/main/AndroidManifest.xml
        '{app}/android/app/src/profile/AndroidManifest.xml
        Dim isValid As Boolean = True
        If My.Computer.FileSystem.FileExists(projPath & "/android/app/src/debug/AndroidManifest.xml") <> True Then
            isValid = False
        End If
        If My.Computer.FileSystem.FileExists(projPath & "/android/app/src/main/AndroidManifest.xml") <> True Then
            isValid = False
        End If
        If My.Computer.FileSystem.FileExists(projPath & "/android/app/src/profile/AndroidManifest.xml") <> True Then
            isValid = False
        End If
        Return isValid
    End Function

    Public Function getPackageName(ByVal projPath As String)
        'Gets the package name from the debug
        Dim manifestContent As String = My.Computer.FileSystem.ReadAllText(projPath & "/android/app/src/debug/AndroidManifest.xml", System.Text.Encoding.Default)
        Dim regex As Regex = New Regex("(?:package="")(.*)(?:"")")
        Dim match As Match = regex.Match(manifestContent)
        If match.Success Then
            If match.Groups.Count > 1 Then
                Return match.Groups(1).Value
            End If
        End If
        Return ""
    End Function

    Public Function replacePhraseInFile(ByVal filePath As String, ByVal oldPhrase As String, ByVal newPhrase As String)
        Dim isSuccess As Boolean = False
        Try
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(filePath).Replace(oldPhrase, newPhrase)
            My.Computer.FileSystem.WriteAllText(filePath, fileReader, False, System.Text.Encoding.Default)
            isSuccess = True
        Catch ex As Exception
        End Try
        Return isSuccess
    End Function

    Public Function isValidPackageName(ByVal packageName As String)
        Dim isValid As Boolean = True
        If packageName.Contains(".") <> True Then
            isValid = False
        End If
        If packageName.Contains(" ") Then
            isValid = False
        End If
        If packageName <> LCase$(packageName) Then 'the textbox contains capitals
            isValid = False
        End If
        If packageName.Length < 3 Then
            isValid = False
        End If
        Return isValid
    End Function

    Public Function isValidAppName(ByVal appName As String)
        Dim isValid As Boolean = True
        If appName.Contains(".") Or appName.Contains("$") Or appName.Contains("#") Then
            isValid = False
        End If
        If appName.Length > 35 Or appName.Length < 3 Then
            isValid = False
        End If
        Return isValid
    End Function

    Public Shared Function GetFilesRecursive(ByVal initial As String) As List(Of String)
        ' This list stores the results.
        Dim result As New List(Of String)

        ' This stack stores the directories to process.
        Dim stack As New Stack(Of String)

        ' Add the initial directory
        stack.Push(initial)

        ' Continue processing for each stacked directory
        Do While (stack.Count > 0)
            ' Get top directory string
            Dim dir As String = stack.Pop
            Try
                ' Add all immediate file paths
                result.AddRange(Directory.GetFiles(dir, "*.*"))

                ' Loop through all subdirectories and add them to the stack.
                Dim directoryName As String
                For Each directoryName In Directory.GetDirectories(dir)
                    stack.Push(directoryName)
                Next

            Catch ex As Exception
            End Try
        Loop

        ' Return the list
        Return result
    End Function

    Private Sub changePackageName(ByVal projPath As String, ByVal packageName As String)
        If validateAndroidManifests(projPath) Then
            Dim oldPackName As String = getPackageName(projPath)
            Dim r1 As Boolean = replacePhraseInFile(projPath & "/android/app/src/debug/AndroidManifest.xml", oldPackName, packageName)
            Dim r2 As Boolean = replacePhraseInFile(projPath & "/android/app/src/main/AndroidManifest.xml", oldPackName, packageName)
            Dim r3 As Boolean = replacePhraseInFile(projPath & "/android/app/src/profile/AndroidManifest.xml", oldPackName, packageName)

            Dim oldID As String = "applicationId """ & oldPackName & """"
            Dim newName As String = "applicationId """ & packageName & """"
            Dim r4 As Boolean = replacePhraseInFile(projPath & "/android/app/build.gradle", oldID, newName)

            rebuildMainActivity(projPath, packageName)

            If (r1 = True And r2 = True And r3 = True And r4 = True) Then
                MsgBox("Package name changed successfully!")
            Else
                MsgBox("Failed to change package name. Check file permissions.")
            End If
        Else
            MsgBox("Your project path is invalid. Please ensure the root project path is selected.")
        End If
    End Sub

    Private Sub rebuildMainActivity(ByVal projPath As String, ByVal packageName As String)
        Dim isKotlin As Boolean = False
        If My.Computer.FileSystem.DirectoryExists(projPath & "/android/app/src/main/kotlin/") Then
            isKotlin = True
        End If

        If isKotlin Then
            'Developer uses Kotlin
            Dim kotlinPath As String = projPath & "/android/app/src/main/kotlin"
            Dim filesList = GetFilesRecursive(kotlinPath)
            If filesList.Count > 0 Then
                Dim filePath As String = filesList(0).Replace(kotlinPath, "")
                filePath = filePath.Replace("\", ".")
                filePath = filePath.Replace("MainActivity.kt", "")
                filePath = filePath.Substring(1, filePath.Length - 2)
                'filepath is now the package name
                Dim oldPackName As String = filePath
                Dim newFilePath As String = kotlinPath & "/" & packageName.Replace(".", "/")
                'create MainActivity.kt file in newFilePath
                Dim mainActivityTemplate As String = "package " & packageName & "" & vbNewLine & vbNewLine &
                                    "import io.flutter.embedding.android.FlutterActivity" & vbNewLine & vbNewLine &
                                    "class MainActivity: FlutterActivity() {" & vbNewLine &
                                    "}" & vbNewLine
                Try
                    My.Computer.FileSystem.DeleteDirectory(kotlinPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(newFilePath)
                    My.Computer.FileSystem.WriteAllText(newFilePath & "/MainActivity.kt", mainActivityTemplate, False, System.Text.Encoding.Default)
                Catch ex As Exception
                    MsgBox("Failed to rebuild MainActivity file. Check file permissions.")
                End Try
            End If
        Else
            'Developer uses Java
            Dim javaPath As String = projPath & "/android/app/src/main/java"
            Dim filesList = GetFilesRecursive(javaPath)
            If filesList.Count > 0 Then
                Dim filePath As String = filesList(0).Replace(javaPath, "")
                filePath = filePath.Replace("\", ".")
                filePath = filePath.Replace("MainActivity.java", "")
                filePath = filePath.Substring(1, filePath.Length - 2)
                'filepath is now the package name
                Dim oldPackName As String = filePath
                Dim newFilePath As String = javaPath & "/" & packageName.Replace(".", "/")
                'create MainActivity.java file in newFilePath
                Dim mainActivityTemplate As String = "package " & packageName & "" & vbNewLine & vbNewLine &
                                    "import io.flutter.embedding.android.FlutterActivity;" & vbNewLine & vbNewLine &
                                    "public class MainActivity extends FlutterActivity {" & vbNewLine &
                                    "}" & vbNewLine
                Try
                    My.Computer.FileSystem.DeleteDirectory(javaPath & "/com", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(newFilePath)
                    My.Computer.FileSystem.WriteAllText(newFilePath & "/MainActivity.java", mainActivityTemplate, False, System.Text.Encoding.Default)
                Catch ex As Exception
                    MsgBox("Failed to rebuild MainActivity file. Check file permissions.")
                End Try
            End If
        End If

    End Sub

    Private Sub addInternetPermissions(ByVal projPath As String)
        'Gets the package name from the main. Adds internet permissions
        Try
            Dim manifestContent As String = My.Computer.FileSystem.ReadAllText(projPath & "/android/app/src/main/AndroidManifest.xml", System.Text.Encoding.Default)
            If manifestContent.Contains("android.permission.INTERNET") Then
                Return 'internet permission exists already
            End If
            Dim regex As Regex = New Regex("(package="".*"">)")
            Dim match As Match = regex.Match(manifestContent)
            If match.Success Then
                If match.Groups.Count > 0 Then
                    Dim keyPhrase As String = match.Groups(0).Value
                    Dim insertInd As Integer = manifestContent.IndexOf(keyPhrase) + keyPhrase.Length
                    Dim perm As String = vbNewLine & vbTab & "<uses-permission android:name=""android.permission.INTERNET""/>"
                    Dim newManifestCont As String = manifestContent.Insert(insertInd, perm)
                    My.Computer.FileSystem.WriteAllText(projPath & "/android/app/src/main/AndroidManifest.xml", newManifestCont, False, System.Text.Encoding.Default)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function getAppName(ByVal projPath As String)
        'Gets the package name from the main
        Dim manifestContent As String = My.Computer.FileSystem.ReadAllText(projPath & "/android/app/src/main/AndroidManifest.xml", System.Text.Encoding.Default)
        Dim regex As Regex = New Regex("(?:android:label="")(.*)(?:"")")
        Dim match As Match = regex.Match(manifestContent)
        If match.Success Then
            If match.Groups.Count > 1 Then
                Return match.Groups(1).Value
            End If
        End If
        Return ""
    End Function

    Private Sub changeAppName(ByVal projPath As String, ByVal appName As String)
        'Gets the app name from the main and changes it
        Try
            Dim oldAppName As String = getAppName(projPath)
            Dim manifestContent As String = My.Computer.FileSystem.ReadAllText(projPath & "/android/app/src/main/AndroidManifest.xml", System.Text.Encoding.Default)
            Dim regex As Regex = New Regex("(?:android:label="")(.*)(?:"")")
            Dim replacementStr As String = "android:label=""" & appName & """"
            Dim newManifestContent As String = regex.Replace(manifestContent, replacementStr)
            My.Computer.FileSystem.WriteAllText(projPath & "/android/app/src/main/AndroidManifest.xml", newManifestContent, False, System.Text.Encoding.Default)
            MsgBox("App name changed successfully!")
        Catch ex As Exception
            MsgBox("Failed to change app name. Check file permissions.")
        End Try
    End Sub

    Private Sub btnUpdateNames_Click(sender As Object, e As EventArgs) Handles btnUpdateNames.Click
        If isValidPackageName(txtPackageName.Text) Then
            changePackageName(txtProjectPath.Text, txtPackageName.Text)
            addInternetPermissions(txtProjectPath.Text) 'adds internet permission if not exist
        Else
            MsgBox("Your package name is invalid. Please check and try again.")
        End If

        If isValidAppName(txtAppName.Text) Then
            changeAppName(txtProjectPath.Text, txtAppName.Text)
        Else
            MsgBox("Your app name is invalid. Please check and try again.")
        End If
    End Sub
End Class
