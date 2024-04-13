Imports System.IO.File
Imports System.IO.FileStream
Imports System.Drawing.Printing
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TarioRecordSystemDataSet.student' table. You can move, or remove it, as needed.
        Me.DataTableAdapter.Fill(Me.SchoolDataSet.data)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo SaveErr
        DataBindingSource.EndEdit()
        DataTableAdapter.Update(SchoolDataSet.data)
        MessageBox.Show("SUCCESSFULLY SAVE!")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        TextBox13.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If (System.IO.File.Exists(TextBox13.Text)) Then
            PictureBox1.Image = Image.FromFile(TextBox13.Text)
        End If
        If TextBox13.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Try
            Me.DataTableAdapter.Search(Me.SchoolDataSet.data, LASTNAMEToolStripTextBox.Text, SECTIONToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DataBindingSource.MovePrevious()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DataBindingSource.MoveNext()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DataBindingSource.MoveFirst()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DataBindingSource.MoveLast()
    End Sub
End Class