Public Class Form1

    'Activity 3
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+5)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Button1.Visible = False
            Cancel.Visible = True
            ShowForm2()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ResetForm()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "12345" Then
            Timer1.Start()
        Else
            MsgBox("WRONG USERNAME OR PASSWORD")
        End If
    End Sub

    Private Sub ShowForm2()
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub ResetForm()
        If Timer1.Enabled Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            Button1.Visible = True
            Cancel.Visible = True
        End If
    End Sub
End Class
