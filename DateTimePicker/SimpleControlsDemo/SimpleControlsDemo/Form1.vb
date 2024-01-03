Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the default date for the Date Time Picker
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        ' Ensure the Date Time Picker is always visible
        DateTimePicker1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Make the TextBox read-only
        TextBox1.ReadOnly = True

        ' Set the text of TextBox1 to the selected date and time
        TextBox1.Text = "Selected Date and Time: " & DateTimePicker1.Value.ToString()

        ' You can add more code here to perform other actions when the button is clicked
    End Sub

    ' Add a TextBox as the fifth tool
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Perform actions when the text in the TextBox changes
    End Sub
End Class
