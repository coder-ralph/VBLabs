Public Class Form3

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Login As New Login()
        Login.Show()
        'Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub
End Class