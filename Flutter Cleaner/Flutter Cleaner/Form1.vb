Imports System
Imports System.Runtime.InteropServices
Imports System.Diagnostics

Public Class Form1
    <DllImport("psapi.dll")>
    Public Shared Function EmptyWorkingSet(ByVal hProcess As IntPtr) As Boolean
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As String = Date.Today.Year.ToString
        lblCopyright.Text = "© " & year & " by Dominick Lee."
        lblVersion.Text = "v" & Application.ProductVersion
        lstOrientations.SelectionMode = SelectionMode.MultiExtended
    End Sub

    Private Sub txtProjectPath_TextChanged(sender As Object, e As EventArgs) Handles txtProjectPath.TextChanged
        txtProjectPath2.Text = txtProjectPath.Text
        txtProjectPath2.SelectionStart = txtProjectPath2.Text.Length
        txtProjectPath2.SelectionLength = 0
    End Sub

    Private Sub txtProjectPath2_TextChanged(sender As Object, e As EventArgs) Handles txtProjectPath2.TextChanged
        txtProjectPath.Text = txtProjectPath2.Text
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
            MsgBox("Failed to terminate " & processName & "processes")
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
            End If
        End If
    End Sub

    Private Sub btnBrowseProject2_Click(sender As Object, e As EventArgs) Handles btnBrowseProject2.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog1.SelectedPath) Then
                txtProjectPath2.Text = FolderBrowserDialog1.SelectedPath
                txtProjectPath2.SelectionStart = txtProjectPath2.Text.Length
                txtProjectPath2.SelectionLength = 0
            End If
        End If
    End Sub
End Class
