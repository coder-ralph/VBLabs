Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsRecordSystemDataSet.member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.StudentsRecordSystemDataSet.member)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MemberBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo SaveErr
        MemberBindingSource.EndEdit()
        MemberTableAdapter.Update(StudentsRecordSystemDataSet.member)
        MessageBox.Show("SUCCESSFULLY SAVE!")
SaveErr:
        Exit Sub
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Try
            Me.MemberTableAdapter.Search(Me.StudentsRecordSystemDataSet.member, LASTNAMEToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MemberBindingSource.RemoveCurrent()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class