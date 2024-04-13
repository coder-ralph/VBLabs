Public Class Login

    'Login Form
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+5)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            btnLogin.Visible = True
            ShowStudentRecordSystem()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "12345" Then
            Timer1.Start()
        Else
            MsgBox("WRONG USERNAME OR PASSWORD")
        End If
    End Sub

    Private Sub ShowStudentRecordSystem()
        MsgBox("LOGIN SUCCESS!")
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub ResetForm()
        If Timer1.Enabled Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            btnLogin.Visible = True
        End If
    End Sub

    ' Toggle password visibility
    Private Sub chkShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "•"c ' Replace with the character you want to use for masking the password
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub

End Class