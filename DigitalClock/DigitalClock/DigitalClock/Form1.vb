Public Class Form1
    ' Event handler for the form load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the ComboBox with time format options
        ComboBox1.Items.AddRange({"hh:mm:ss", "h:mm tt", "HH:mm"})
        ComboBox1.SelectedIndex = 0 ' Set the default time format

        ' Start the timer to update the digital clock
        Timer1.Start()

        ' Set up columns for the ListView
        ListView1.View = View.Details
        ListView1.Columns.Add("Date", 170) ' Adjust the column width as needed
        ListView1.Columns.Add("Time", 160)
        'ListView1.Columns.Add("Format", 80)
    End Sub

    ' Event handler for the timer tick event
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the Label with the current time
        Label1.Text = DateTime.Now.ToString(ComboBox1.SelectedItem.ToString())
    End Sub

    ' Event handler for the button click event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the selected date and time from the DateTimePicker
        Dim selectedDateTime As DateTime = DateTimePicker1.Value
        Dim selectedTime As String = selectedDateTime.ToString(ComboBox1.SelectedItem.ToString())

        ' Add the selected date, time, and format to the ListView
        Dim listViewItem As New ListViewItem({selectedDateTime.ToString("ddd, MMM d, yyyy"), selectedTime, ComboBox1.SelectedItem.ToString()})
        ListView1.Items.Add(listViewItem)

        ' Simulate a progress bar update (you can replace this with actual loading logic)
        For i As Integer = 0 To 100
            ProgressBar1.Value = i
            System.Threading.Thread.Sleep(10)
        Next

        ' Reset the progress bar
        ProgressBar1.Value = 0
    End Sub
End Class