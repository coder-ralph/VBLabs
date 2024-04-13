Public Class Form1

    ' Event handler for the form load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add items to ListBox1
        ListBox1.Items.Add("Luffy")
        ListBox1.Items.Add("Ichigo")
        ListBox1.Items.Add("Goku")

        ' Add columns to the ListView
        ListView1.Columns.Add("One Piece")
        'ListView1.Columns.Add("Dragon Ball")

        ' Add items to the ListView (Format: Row 1, Col 2)
        ' Row 1, Col 1", "Row 1, Col 2
        ' Row 2, Col 1", "Row 2, Col 2
        ' Row 3, Col 1", "Row 3, Col 2
        Dim item1 As New ListViewItem({"Zoro"})
        Dim item2 As New ListViewItem({"Sanji"})
        Dim item3 As New ListViewItem({"Nami"})
        ListView1.Items.AddRange({item1, item2, item3})

        ' Set initial state of CheckBox1
        CheckBox1.Checked = False

        ' Add event handler for the ListBox1's parent control scroll event
        AddHandler Me.Scroll, AddressOf ListBoxContainer_Scroll
    End Sub

    ' Event handler for the ListBox1 selection change
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Display the selected item in MessageBox
        If ListBox1.SelectedIndex <> -1 Then
            MessageBox.Show("Selected character: " & ListBox1.SelectedItem.ToString())
            DisplayImage(ListBox1.SelectedIndex) ' Call a function to display the image based on the selected index
        End If
    End Sub

    ' Event handler for the CheckBox1 check state change
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Enable or disable ListBox1 based on the check state of CheckBox1
        ListBox1.Enabled = CheckBox1.Checked
    End Sub

    ' Event handler for the ListView1 item click event
    Private Sub ListView1_ItemClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        ' Add the selected item from ListView to ListBox1
        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        ListBox1.Items.Add(selectedItem.Text)
    End Sub

    ' Event handler for the ListBox1's parent control scroll event
    Private Sub ListBoxContainer_Scroll(sender As Object, e As ScrollEventArgs)
        ' Change the back color of ListBox based on the scroll position
        If e.NewValue > e.OldValue Then
            ' Scrolling down (dark mode)
            ListBox1.BackColor = Color.DarkGray
            ListBox1.ForeColor = Color.White
        Else
            ' Scrolling up (light mode)
            ListBox1.BackColor = SystemColors.Control
            ListBox1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    ' Function to display an image based on the selected index
    Private Sub DisplayImage(selectedIndex As Integer)
        ' You should replace this with the actual code to display an image.
        ' For demonstration purposes, I'll change the image based on the selected index.
        Select Case selectedIndex
            Case 0
                PictureBox1.Image = My.Resources.luffy ' Replace Image1 with your image resource
            Case 1
                PictureBox1.Image = My.Resources.ichigo ' Replace Image2 with your image resource
            Case 2
                PictureBox1.Image = My.Resources.goku ' Replace Image3 with your image resource
            Case 3
                PictureBox1.Image = My.Resources.zoro ' Replace Image3 with your image resource
            Case 4
                PictureBox1.Image = My.Resources.sanji ' Replace Image3 with your image resource
            Case 5
                PictureBox1.Image = My.Resources.nami ' Replace Image3 with your image resource
            Case Else
                PictureBox1.Image = Nothing
        End Select
    End Sub

End Class