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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtPackageName = New System.Windows.Forms.TextBox()
        Me.lblPackageName = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.txtAppName = New System.Windows.Forms.TextBox()
        Me.lblProjectPath = New System.Windows.Forms.Label()
        Me.txtProjectPath = New System.Windows.Forms.TextBox()
        Me.btnBrowseProject = New System.Windows.Forms.Button()
        Me.btnUpdateNames = New System.Windows.Forms.Button()
        Me.btnBrowseProject2 = New System.Windows.Forms.Button()
        Me.txtProjectPath2 = New System.Windows.Forms.TextBox()
        Me.lblProjectPath2 = New System.Windows.Forms.Label()
        Me.lblOrientations = New System.Windows.Forms.Label()
        Me.lstOrientations = New System.Windows.Forms.ListBox()
        Me.btnGetNames = New System.Windows.Forms.Button()
        Me.btnGetOrientations = New System.Windows.Forms.Button()
        Me.btnSetOrientations = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 237)
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
        Me.TabPage1.Size = New System.Drawing.Size(332, 211)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Memory Issue"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnGetNames)
        Me.TabPage2.Controls.Add(Me.btnUpdateNames)
        Me.TabPage2.Controls.Add(Me.btnBrowseProject)
        Me.TabPage2.Controls.Add(Me.txtProjectPath)
        Me.TabPage2.Controls.Add(Me.lblProjectPath)
        Me.TabPage2.Controls.Add(Me.lblAppName)
        Me.TabPage2.Controls.Add(Me.txtAppName)
        Me.TabPage2.Controls.Add(Me.lblPackageName)
        Me.TabPage2.Controls.Add(Me.txtPackageName)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(332, 211)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rename App"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnGetOrientations)
        Me.TabPage3.Controls.Add(Me.btnSetOrientations)
        Me.TabPage3.Controls.Add(Me.lstOrientations)
        Me.TabPage3.Controls.Add(Me.btnBrowseProject2)
        Me.TabPage3.Controls.Add(Me.txtProjectPath2)
        Me.TabPage3.Controls.Add(Me.lblProjectPath2)
        Me.TabPage3.Controls.Add(Me.lblOrientations)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(332, 211)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "App Orientation"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.ForeColor = System.Drawing.Color.Gray
        Me.lblCopyright.Location = New System.Drawing.Point(11, 259)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(101, 13)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "© by Dominick Lee."
        '
        'lblVersion
        '
        Me.lblVersion.ForeColor = System.Drawing.Color.Gray
        Me.lblVersion.Location = New System.Drawing.Point(251, 259)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(101, 13)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "v"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(88, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 25)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Boost RAM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(88, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 25)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Restart Android Studio"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtPackageName
        '
        Me.txtPackageName.Location = New System.Drawing.Point(106, 45)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Size = New System.Drawing.Size(210, 21)
        Me.txtPackageName.TabIndex = 0
        '
        'lblPackageName
        '
        Me.lblPackageName.AutoSize = True
        Me.lblPackageName.Location = New System.Drawing.Point(5, 48)
        Me.lblPackageName.Name = "lblPackageName"
        Me.lblPackageName.Size = New System.Drawing.Size(95, 15)
        Me.lblPackageName.TabIndex = 1
        Me.lblPackageName.Text = "Package Name:"
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Location = New System.Drawing.Point(32, 80)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(68, 15)
        Me.lblAppName.TabIndex = 3
        Me.lblAppName.Text = "App Name:"
        '
        'txtAppName
        '
        Me.txtAppName.Location = New System.Drawing.Point(106, 77)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Size = New System.Drawing.Size(210, 21)
        Me.txtAppName.TabIndex = 2
        '
        'lblProjectPath
        '
        Me.lblProjectPath.AutoSize = True
        Me.lblProjectPath.Location = New System.Drawing.Point(24, 16)
        Me.lblProjectPath.Name = "lblProjectPath"
        Me.lblProjectPath.Size = New System.Drawing.Size(76, 15)
        Me.lblProjectPath.TabIndex = 4
        Me.lblProjectPath.Text = "Project Path:"
        '
        'txtProjectPath
        '
        Me.txtProjectPath.Location = New System.Drawing.Point(106, 13)
        Me.txtProjectPath.Name = "txtProjectPath"
        Me.txtProjectPath.Size = New System.Drawing.Size(133, 21)
        Me.txtProjectPath.TabIndex = 3
        '
        'btnBrowseProject
        '
        Me.btnBrowseProject.Location = New System.Drawing.Point(245, 12)
        Me.btnBrowseProject.Name = "btnBrowseProject"
        Me.btnBrowseProject.Size = New System.Drawing.Size(71, 23)
        Me.btnBrowseProject.TabIndex = 3
        Me.btnBrowseProject.Text = "Browse"
        Me.btnBrowseProject.UseVisualStyleBackColor = True
        '
        'btnUpdateNames
        '
        Me.btnUpdateNames.Location = New System.Drawing.Point(206, 110)
        Me.btnUpdateNames.Name = "btnUpdateNames"
        Me.btnUpdateNames.Size = New System.Drawing.Size(110, 25)
        Me.btnUpdateNames.TabIndex = 4
        Me.btnUpdateNames.Text = "Update Names"
        Me.btnUpdateNames.UseVisualStyleBackColor = True
        '
        'btnBrowseProject2
        '
        Me.btnBrowseProject2.Location = New System.Drawing.Point(245, 12)
        Me.btnBrowseProject2.Name = "btnBrowseProject2"
        Me.btnBrowseProject2.Size = New System.Drawing.Size(71, 23)
        Me.btnBrowseProject2.TabIndex = 8
        Me.btnBrowseProject2.Text = "Browse"
        Me.btnBrowseProject2.UseVisualStyleBackColor = True
        '
        'txtProjectPath2
        '
        Me.txtProjectPath2.Location = New System.Drawing.Point(106, 13)
        Me.txtProjectPath2.Name = "txtProjectPath2"
        Me.txtProjectPath2.Size = New System.Drawing.Size(133, 21)
        Me.txtProjectPath2.TabIndex = 9
        '
        'lblProjectPath2
        '
        Me.lblProjectPath2.AutoSize = True
        Me.lblProjectPath2.Location = New System.Drawing.Point(24, 16)
        Me.lblProjectPath2.Name = "lblProjectPath2"
        Me.lblProjectPath2.Size = New System.Drawing.Size(76, 15)
        Me.lblProjectPath2.TabIndex = 12
        Me.lblProjectPath2.Text = "Project Path:"
        '
        'lblOrientations
        '
        Me.lblOrientations.AutoSize = True
        Me.lblOrientations.Location = New System.Drawing.Point(24, 48)
        Me.lblOrientations.Name = "lblOrientations"
        Me.lblOrientations.Size = New System.Drawing.Size(76, 15)
        Me.lblOrientations.TabIndex = 6
        Me.lblOrientations.Text = "Orientations:"
        '
        'lstOrientations
        '
        Me.lstOrientations.FormattingEnabled = True
        Me.lstOrientations.ItemHeight = 15
        Me.lstOrientations.Location = New System.Drawing.Point(106, 48)
        Me.lstOrientations.Name = "lstOrientations"
        Me.lstOrientations.Size = New System.Drawing.Size(210, 94)
        Me.lstOrientations.TabIndex = 13
        '
        'btnGetNames
        '
        Me.btnGetNames.Location = New System.Drawing.Point(100, 110)
        Me.btnGetNames.Name = "btnGetNames"
        Me.btnGetNames.Size = New System.Drawing.Size(100, 25)
        Me.btnGetNames.TabIndex = 5
        Me.btnGetNames.Text = "Get Names"
        Me.btnGetNames.UseVisualStyleBackColor = True
        '
        'btnGetOrientations
        '
        Me.btnGetOrientations.Location = New System.Drawing.Point(100, 152)
        Me.btnGetOrientations.Name = "btnGetOrientations"
        Me.btnGetOrientations.Size = New System.Drawing.Size(100, 25)
        Me.btnGetOrientations.TabIndex = 15
        Me.btnGetOrientations.Text = "Get Settings"
        Me.btnGetOrientations.UseVisualStyleBackColor = True
        '
        'btnSetOrientations
        '
        Me.btnSetOrientations.Location = New System.Drawing.Point(206, 152)
        Me.btnSetOrientations.Name = "btnSetOrientations"
        Me.btnSetOrientations.Size = New System.Drawing.Size(110, 25)
        Me.btnSetOrientations.TabIndex = 14
        Me.btnSetOrientations.Text = "Set Settings"
        Me.btnSetOrientations.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 276)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.TabControl1)
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
    Friend WithEvents btnBrowseProject2 As Button
    Friend WithEvents txtProjectPath2 As TextBox
    Friend WithEvents lblProjectPath2 As Label
    Friend WithEvents lblOrientations As Label
    Friend WithEvents lstOrientations As ListBox
    Friend WithEvents btnGetNames As Button
    Friend WithEvents btnGetOrientations As Button
    Friend WithEvents btnSetOrientations As Button
End Class
