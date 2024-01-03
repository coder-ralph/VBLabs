Public Class Form4
    ' Back to Home
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class