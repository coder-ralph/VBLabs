Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1

    ' Event handler for the form load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ComboBox
        ComboBox1.Items.Add("Austin Reaves")
        ComboBox1.Items.Add("Luka Dončić")
        ComboBox1.Items.Add("Kyle Kuzma")

        ' Add event handler for the ListBox1's parent control scroll event
        AddHandler Me.Scroll, AddressOf ListBoxContainer_Scroll
    End Sub

    ' Event handler for the ComboBox1 selection change
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Display the selected item in ListBox1
        If ComboBox1.SelectedIndex <> -1 Then
            ListBox1.Items.Add(ComboBox1.SelectedItem.ToString())
        End If
    End Sub

    ' Event handler for the TrackBar1 scroll event
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ' Change the back color of ListBox based on the scroll position
        If TrackBar1.Value > 50 Then
            ' Scrolling to the right (dark mode)
            ListBox1.BackColor = Color.Black
            ListBox1.ForeColor = Color.White
        Else
            ' Scrolling to the left (light mode)
            ListBox1.BackColor = SystemColors.Control
            ListBox1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    ' Event handler for the ListBox1's parent control scroll event
    Private Sub ListBoxContainer_Scroll(sender As Object, e As ScrollEventArgs)
        ' Change the back color of ListBox based on the scroll position
        If e.NewValue > e.OldValue Then
            ' Scrolling down (dark mode)
            ListBox1.BackColor = Color.Black
            ListBox1.ForeColor = Color.White
        Else
            ' Scrolling up (light mode)
            ListBox1.BackColor = SystemColors.Control
            ListBox1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    ' Event handler for the ListBox1 selection change
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Display the selected item in MessageBox
        If ListBox1.SelectedIndex <> -1 Then
            ' Call the DisplayImage function to change the PictureBox image
            DisplayImage(ListBox1.SelectedIndex)
        End If
    End Sub

    ' Function to display an image based on the selected index
    Private Sub DisplayImage(selectedIndex As Integer)
        ' You should replace this with the actual code to display an image.
        ' For demonstration purposes, I'll change the image based on the selected index.
        Select Case selectedIndex
            Case 0
                PictureBox1.Image = My.Resources.reaves ' Replace Image1 with your image resource
            Case 1
                PictureBox1.Image = My.Resources.luka ' Replace Image2 with your image resource
            Case 2
                PictureBox1.Image = My.Resources.kuzma ' Replace Image3 with your image resource
            Case Else
                PictureBox1.Image = Nothing
        End Select
    End Sub

    ' Event handler for RadioButton1 checked change
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            MessageBox.Show("You're correct! Awesome!")
        End If
    End Sub

    ' Event handler for RadioButton2 checked change
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            MessageBox.Show("You're correct! Awesome!")
        End If
    End Sub

    ' Event handler for RadioButton3 checked change
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            MessageBox.Show("You're correct! Awesome!")
        End If
    End Sub
End Class
