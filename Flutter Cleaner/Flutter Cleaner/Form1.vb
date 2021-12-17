Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As String = Date.Today.Year.ToString
        lblCopyright.Text = "© " & year & " by Dominick Lee."
        lblVersion.Text = "v" & Application.ProductVersion

    End Sub

    Private Sub txtProjectPath_TextChanged(sender As Object, e As EventArgs) Handles txtProjectPath.TextChanged
        txtProjectPath2.Text = txtProjectPath.Text
    End Sub

    Private Sub txtProjectPath2_TextChanged(sender As Object, e As EventArgs) Handles txtProjectPath2.TextChanged
        txtProjectPath.Text = txtProjectPath2.Text
    End Sub
End Class
