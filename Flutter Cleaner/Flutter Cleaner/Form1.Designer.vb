<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnGetNames = New System.Windows.Forms.Button()
        Me.btnUpdateNames = New System.Windows.Forms.Button()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.txtAppName = New System.Windows.Forms.TextBox()
        Me.lblPackageName = New System.Windows.Forms.Label()
        Me.txtPackageName = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnGetOrientations = New System.Windows.Forms.Button()
        Me.btnSetOrientations = New System.Windows.Forms.Button()
        Me.lstOrientations = New System.Windows.Forms.ListBox()
        Me.lblOrientations = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblMinSDK = New System.Windows.Forms.Label()
        Me.txtMinSDK = New System.Windows.Forms.TextBox()
        Me.chkMinify = New System.Windows.Forms.CheckBox()
        Me.chkShrinkResources = New System.Windows.Forms.CheckBox()
        Me.btnPrepReleaseConfig = New System.Windows.Forms.Button()
        Me.lblSigningDesc = New System.Windows.Forms.Label()
        Me.btnBrowseProject = New System.Windows.Forms.Button()
        Me.txtProjectPath = New System.Windows.Forms.TextBox()
        Me.lblProjectPath = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 221)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(332, 195)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Memory Issue"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(88, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 25)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Start Android Studio"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(88, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 25)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Boost RAM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close Flutter Processes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnGetNames)
        Me.TabPage2.Controls.Add(Me.btnUpdateNames)
        Me.TabPage2.Controls.Add(Me.lblAppName)
        Me.TabPage2.Controls.Add(Me.txtAppName)
        Me.TabPage2.Controls.Add(Me.lblPackageName)
        Me.TabPage2.Controls.Add(Me.txtPackageName)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(332, 195)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rename App"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnGetNames
        '
        Me.btnGetNames.Location = New System.Drawing.Point(100, 80)
        Me.btnGetNames.Name = "btnGetNames"
        Me.btnGetNames.Size = New System.Drawing.Size(100, 25)
        Me.btnGetNames.TabIndex = 5
        Me.btnGetNames.Text = "Get Names"
        Me.btnGetNames.UseVisualStyleBackColor = True
        '
        'btnUpdateNames
        '
        Me.btnUpdateNames.Location = New System.Drawing.Point(206, 80)
        Me.btnUpdateNames.Name = "btnUpdateNames"
        Me.btnUpdateNames.Size = New System.Drawing.Size(110, 25)
        Me.btnUpdateNames.TabIndex = 4
        Me.btnUpdateNames.Text = "Update Names"
        Me.btnUpdateNames.UseVisualStyleBackColor = True
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Location = New System.Drawing.Point(32, 50)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(68, 15)
        Me.lblAppName.TabIndex = 3
        Me.lblAppName.Text = "App Name:"
        '
        'txtAppName
        '
        Me.txtAppName.Location = New System.Drawing.Point(106, 47)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Size = New System.Drawing.Size(210, 21)
        Me.txtAppName.TabIndex = 2
        '
        'lblPackageName
        '
        Me.lblPackageName.AutoSize = True
        Me.lblPackageName.Location = New System.Drawing.Point(5, 18)
        Me.lblPackageName.Name = "lblPackageName"
        Me.lblPackageName.Size = New System.Drawing.Size(95, 15)
        Me.lblPackageName.TabIndex = 1
        Me.lblPackageName.Text = "Package Name:"
        '
        'txtPackageName
        '
        Me.txtPackageName.Location = New System.Drawing.Point(106, 15)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Size = New System.Drawing.Size(210, 21)
        Me.txtPackageName.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnGetOrientations)
        Me.TabPage3.Controls.Add(Me.btnSetOrientations)
        Me.TabPage3.Controls.Add(Me.lstOrientations)
        Me.TabPage3.Controls.Add(Me.lblOrientations)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(332, 195)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "App Orientation"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnGetOrientations
        '
        Me.btnGetOrientations.Location = New System.Drawing.Point(100, 117)
        Me.btnGetOrientations.Name = "btnGetOrientations"
        Me.btnGetOrientations.Size = New System.Drawing.Size(100, 25)
        Me.btnGetOrientations.TabIndex = 15
        Me.btnGetOrientations.Text = "Get Settings"
        Me.btnGetOrientations.UseVisualStyleBackColor = True
        '
        'btnSetOrientations
        '
        Me.btnSetOrientations.Location = New System.Drawing.Point(206, 117)
        Me.btnSetOrientations.Name = "btnSetOrientations"
        Me.btnSetOrientations.Size = New System.Drawing.Size(110, 25)
        Me.btnSetOrientations.TabIndex = 14
        Me.btnSetOrientations.Text = "Set Settings"
        Me.btnSetOrientations.UseVisualStyleBackColor = True
        '
        'lstOrientations
        '
        Me.lstOrientations.FormattingEnabled = True
        Me.lstOrientations.ItemHeight = 15
        Me.lstOrientations.Items.AddRange(New Object() {"portraitUp", "landscapeLeft", "landscapeRight", "portraitDown"})
        Me.lstOrientations.Location = New System.Drawing.Point(106, 13)
        Me.lstOrientations.Name = "lstOrientations"
        Me.lstOrientations.Size = New System.Drawing.Size(210, 94)
        Me.lstOrientations.TabIndex = 13
        '
        'lblOrientations
        '
        Me.lblOrientations.AutoSize = True
        Me.lblOrientations.Location = New System.Drawing.Point(24, 13)
        Me.lblOrientations.Name = "lblOrientations"
        Me.lblOrientations.Size = New System.Drawing.Size(76, 15)
        Me.lblOrientations.TabIndex = 6
        Me.lblOrientations.Text = "Orientations:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lblMinSDK)
        Me.TabPage4.Controls.Add(Me.txtMinSDK)
        Me.TabPage4.Controls.Add(Me.chkMinify)
        Me.TabPage4.Controls.Add(Me.chkShrinkResources)
        Me.TabPage4.Controls.Add(Me.btnPrepReleaseConfig)
        Me.TabPage4.Controls.Add(Me.lblSigningDesc)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(332, 195)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Android Signing"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblMinSDK
        '
        Me.lblMinSDK.AutoSize = True
        Me.lblMinSDK.Location = New System.Drawing.Point(70, 84)
        Me.lblMinSDK.Name = "lblMinSDK"
        Me.lblMinSDK.Size = New System.Drawing.Size(90, 13)
        Me.lblMinSDK.TabIndex = 9
        Me.lblMinSDK.Text = "Min SDK Version:"
        '
        'txtMinSDK
        '
        Me.txtMinSDK.Location = New System.Drawing.Point(166, 81)
        Me.txtMinSDK.Name = "txtMinSDK"
        Me.txtMinSDK.Size = New System.Drawing.Size(100, 20)
        Me.txtMinSDK.TabIndex = 8
        Me.txtMinSDK.Text = "20"
        '
        'chkMinify
        '
        Me.chkMinify.AutoSize = True
        Me.chkMinify.Location = New System.Drawing.Point(181, 118)
        Me.chkMinify.Name = "chkMinify"
        Me.chkMinify.Size = New System.Drawing.Size(95, 17)
        Me.chkMinify.TabIndex = 7
        Me.chkMinify.Text = "Minify Enabled"
        Me.chkMinify.UseVisualStyleBackColor = True
        '
        'chkShrinkResources
        '
        Me.chkShrinkResources.AutoSize = True
        Me.chkShrinkResources.Location = New System.Drawing.Point(66, 118)
        Me.chkShrinkResources.Name = "chkShrinkResources"
        Me.chkShrinkResources.Size = New System.Drawing.Size(110, 17)
        Me.chkShrinkResources.TabIndex = 6
        Me.chkShrinkResources.Text = "Shrink Resources"
        Me.chkShrinkResources.UseVisualStyleBackColor = True
        '
        'btnPrepReleaseConfig
        '
        Me.btnPrepReleaseConfig.Location = New System.Drawing.Point(66, 153)
        Me.btnPrepReleaseConfig.Name = "btnPrepReleaseConfig"
        Me.btnPrepReleaseConfig.Size = New System.Drawing.Size(200, 26)
        Me.btnPrepReleaseConfig.TabIndex = 3
        Me.btnPrepReleaseConfig.Text = "Prepare Release Build Config"
        Me.btnPrepReleaseConfig.UseVisualStyleBackColor = True
        '
        'lblSigningDesc
        '
        Me.lblSigningDesc.Location = New System.Drawing.Point(12, 15)
        Me.lblSigningDesc.Name = "lblSigningDesc"
        Me.lblSigningDesc.Size = New System.Drawing.Size(308, 59)
        Me.lblSigningDesc.TabIndex = 5
        Me.lblSigningDesc.Text = resources.GetString("lblSigningDesc.Text")
        '
        'btnBrowseProject
        '
        Me.btnBrowseProject.Location = New System.Drawing.Point(281, 12)
        Me.btnBrowseProject.Name = "btnBrowseProject"
        Me.btnBrowseProject.Size = New System.Drawing.Size(71, 23)
        Me.btnBrowseProject.TabIndex = 3
        Me.btnBrowseProject.Text = "Browse"
        Me.btnBrowseProject.UseVisualStyleBackColor = True
        '
        'txtProjectPath
        '
        Me.txtProjectPath.Location = New System.Drawing.Point(93, 14)
        Me.txtProjectPath.Name = "txtProjectPath"
        Me.txtProjectPath.Size = New System.Drawing.Size(182, 20)
        Me.txtProjectPath.TabIndex = 3
        '
        'lblProjectPath
        '
        Me.lblProjectPath.AutoSize = True
        Me.lblProjectPath.Location = New System.Drawing.Point(11, 17)
        Me.lblProjectPath.Name = "lblProjectPath"
        Me.lblProjectPath.Size = New System.Drawing.Size(68, 13)
        Me.lblProjectPath.TabIndex = 4
        Me.lblProjectPath.Text = "Project Path:"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.ForeColor = System.Drawing.Color.Gray
        Me.lblCopyright.Location = New System.Drawing.Point(11, 275)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(101, 13)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "© by Dominick Lee."
        '
        'lblVersion
        '
        Me.lblVersion.ForeColor = System.Drawing.Color.Gray
        Me.lblVersion.Location = New System.Drawing.Point(251, 275)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(101, 13)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "v"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 291)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.btnBrowseProject)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtProjectPath)
        Me.Controls.Add(Me.lblProjectPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flutter Cleaner"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblAppName As Label
    Friend WithEvents txtAppName As TextBox
    Friend WithEvents lblPackageName As Label
    Friend WithEvents txtPackageName As TextBox
    Friend WithEvents txtProjectPath As TextBox
    Friend WithEvents lblProjectPath As Label
    Friend WithEvents btnBrowseProject As Button
    Friend WithEvents btnUpdateNames As Button
    Friend WithEvents lblOrientations As Label
    Friend WithEvents lstOrientations As ListBox
    Friend WithEvents btnGetNames As Button
    Friend WithEvents btnGetOrientations As Button
    Friend WithEvents btnSetOrientations As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lblSigningDesc As Label
    Friend WithEvents btnPrepReleaseConfig As Button
    Friend WithEvents chkMinify As CheckBox
    Friend WithEvents chkShrinkResources As CheckBox
    Friend WithEvents lblMinSDK As Label
    Friend WithEvents txtMinSDK As TextBox
End Class
