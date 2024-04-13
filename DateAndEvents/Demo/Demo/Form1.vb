Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Date", 100)
        ListView1.Columns.Add("Text", 150)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim selectedDate As String = dateTimePicker1.Value.ToShortDateString()
        Dim enteredText As String = textBox1.Text

        Dim item As ListViewItem = New ListViewItem({selectedDate, enteredText})
        ListView1.Items.Add(item)

        textBox1.Clear()
    End Sub

End Class