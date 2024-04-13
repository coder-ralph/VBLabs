Imports System.Data
Imports System.IO

Public Class Form2
    ' Define a DataTable to store your data
    Dim dataTable As New DataTable

    ' Variable to store the index of the selected row for editing
    Dim selectedRowIndex As Integer = -1

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the columns in the DataTable
        InitializeDataTable()

        ' Set the DataTable as the DataSource for the DataGridView
        DataGridView1.DataSource = dataTable

        ' Load data from the file when the form loads
        LoadDataFromFile()
    End Sub

    ' Initialize DataTable columns
    Private Sub InitializeDataTable()
        dataTable.Columns.Add("FirstName", GetType(String))
        dataTable.Columns.Add("MiddleInitial", GetType(String))
        dataTable.Columns.Add("LastName", GetType(String))
        dataTable.Columns.Add("DateOfBirth", GetType(Date))
        dataTable.Columns.Add("Gender", GetType(String))
        dataTable.Columns.Add("Age", GetType(Integer))
        dataTable.Columns.Add("Address", GetType(String))
        dataTable.Columns.Add("ContactNumber", GetType(String))
        dataTable.Columns.Add("LRN", GetType(String))
        dataTable.Columns.Add("YearLevel", GetType(Integer))
        dataTable.Columns.Add("Strand", GetType(String))
        dataTable.Columns.Add("Section", GetType(String))
        dataTable.Columns.Add("Picture", GetType(String))
    End Sub

    ' Load data from file (XML in this case)
    Private Sub LoadDataFromFile()
        ' Check if the file exists
        Dim filePath As String = "StudentData.xml"
        If File.Exists(filePath) Then
            ' Read data from the file
            dataTable.Clear()
            dataTable.ReadXml(filePath)
        End If
    End Sub

    ' Save data to file (XML in this case)
    Private Sub SaveDataToFile()
        ' Save data to the XML file
        Dim filePath As String = "StudentData.xml"
        dataTable.WriteXml(filePath)
    End Sub

    ' Save data to file (Excel in this case)
    ' This method is not needed since we are not saving to Excel anymore

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add a new row to the DataTable
        dataTable.Rows.Add()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Add or update the entered data to the DataTable
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < dataTable.Rows.Count Then
            ' Update the existing row
            UpdateDataRow(selectedRowIndex)
        Else
            ' Add a new row
            AddNewDataRow()
        End If

        ' Clear the TextBoxes after saving
        ClearTextBoxes(Me)

        ' Reset the selected row index
        selectedRowIndex = -1

        MessageBox.Show("SUCCESSFULLY SAVE!")
    End Sub

    ' Print button click event
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Print all data in the DataGridView
        PrintDataGridView()
    End Sub

    ' Method to print all data in the DataGridView
    Private Sub PrintDataGridView()
        ' Check if DataGridView1 is not null before proceeding
        If DataGridView1 IsNot Nothing Then
            ' Create a PrintDocument
            Dim printDoc As New Printing.PrintDocument()

            ' Detach existing event handler to avoid duplication
            RemoveHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

            ' Set up event handlers for printing
            AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

            ' Create a PrintPreviewDialog
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDoc

            ' Show the print preview dialog
            printPreviewDialog.ShowDialog()
        Else
            MessageBox.Show("DataGridView1 is not initialized.")
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Set up font and brush for drawing text
        Dim titleFont As New Font("Century", 25, FontStyle.Bold)
        Dim dataFont As New Font("Century", 18)
        Dim brush As New SolidBrush(Color.Red)

        ' Draw the title ("STUDENT DATA") at the center of the page
        Dim titleSize As SizeF = e.Graphics.MeasureString("STUDENT DATA", titleFont)
        Dim titleX As Single = (e.MarginBounds.Left + e.MarginBounds.Right - titleSize.Width) / 2
        Dim titleY As Single = e.MarginBounds.Top + 20 ' Adjust the vertical position as needed
        e.Graphics.DrawString("STUDENT DATA", titleFont, brush, titleX, titleY)

        ' Draw the student data from DataGridView
        Dim dataX As Single = e.MarginBounds.Left
        Dim dataY As Single = titleY + titleSize.Height + 20 ' Adjust the vertical position as needed

        For Each row As DataGridViewRow In DataGridView1.Rows
            ' Skip rows with no data
            If Not IsRowEmpty(row) Then
                ' Draw each line of student data
                Dim firstName As String = row.Cells("FirstName").Value.ToString()
                Dim middleName As String = row.Cells("MiddleInitial").Value.ToString()
                Dim lastName As String = row.Cells("LastName").Value.ToString()

                ' Check for DBNull before converting to Date
                Dim dateOfBirth As Date
                If row.Cells("DateOfBirth").Value IsNot DBNull.Value AndAlso row.Cells("DateOfBirth").Value IsNot Nothing Then
                    dateOfBirth = CDate(row.Cells("DateOfBirth").Value)
                Else
                    ' Handle DBNull, for example, assign a default date or display "N/A"
                    dateOfBirth = Date.MinValue ' or use another default value
                End If

                Dim gender As String = row.Cells("Gender").Value.ToString()
                Dim age As Integer = CInt(row.Cells("Age").Value)
                Dim address As String = row.Cells("Address").Value.ToString()
                Dim contactNumber As String = row.Cells("ContactNumber").Value.ToString()
                Dim lrn As String = row.Cells("LRN").Value.ToString()
                Dim yearLevel As Integer = CInt(row.Cells("YearLevel").Value)
                Dim strand As String = row.Cells("Strand").Value.ToString()
                Dim section As String = row.Cells("Section").Value.ToString()

                Dim line As String = "FIRSTNAME: " & firstName & Environment.NewLine &
                                     "MIDDLENAME: " & middleName & Environment.NewLine &
                                     "LASTNAME: " & lastName & Environment.NewLine &
                                     "DOB: " & dateOfBirth.ToShortDateString() & Environment.NewLine &
                                     "GENDER: " & gender & Environment.NewLine &
                                     "AGE: " & age.ToString() & Environment.NewLine &
                                     "ADDRESS: " & address & Environment.NewLine &
                                     "CONTACT: " & contactNumber & Environment.NewLine &
                                     "LRN: " & lrn & Environment.NewLine &
                                     "YEAR LEVEL: " & yearLevel.ToString() & Environment.NewLine &
                                     "STRAND: " & strand & Environment.NewLine &
                                     "SECTION: " & section

                e.Graphics.DrawString(line, dataFont, Brushes.Black, dataX, dataY)
                dataY += dataFont.GetHeight() * 16 ' Move down for the next student data, considering 14 lines of data per student
            End If
        Next

        ' Set the HasMorePages property to False since we are printing all content on a single page
        e.HasMorePages = False
    End Sub

    Private Function IsRowEmpty(row As DataGridViewRow) As Boolean
        ' Check if all cells in the row are empty
        For Each cell As DataGridViewCell In row.Cells
            If cell.Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(cell.Value.ToString()) Then
                Return False
            End If
        Next
        Return True
    End Function

    ' Add a new row to the DataTable
    Private Sub AddNewDataRow()
        Dim newRow As DataRow = dataTable.NewRow()
        ' Set data for the new row
        SetDataRowData(newRow)
        ' Add the new row to the DataTable
        dataTable.Rows.Add(newRow)
    End Sub

    ' Update an existing row in the DataTable
    Private Sub UpdateDataRow(rowIndex As Integer)
        Dim existingRow As DataRow = dataTable.Rows(rowIndex)
        ' Update data for the existing row
        SetDataRowData(existingRow)
    End Sub

    ' Set data for a DataRow based on the form controls
    Private Sub SetDataRowData(dataRow As DataRow)
        dataRow("FirstName") = TextBox1.Text
        dataRow("MiddleInitial") = TextBox2.Text
        dataRow("LastName") = TextBox3.Text

        Dim dateOfBirth As Date
        If Date.TryParse(TextBox4.Text, dateOfBirth) Then
            dataRow("DateOfBirth") = dateOfBirth
        Else
            MessageBox.Show("Invalid date format for Date of Birth.")
            Exit Sub
        End If

        dataRow("Gender") = TextBox5.Text

        Dim yearLevel As Integer
        If Integer.TryParse(TextBox10.Text, yearLevel) Then
            dataRow("YearLevel") = yearLevel
        Else
            MessageBox.Show("Invalid format for Year Level. Please enter a valid number.")
            Exit Sub
        End If

        dataRow("Age") = TextBox6.Text
        dataRow("Address") = TextBox7.Text
        dataRow("ContactNumber") = TextBox8.Text
        dataRow("LRN") = TextBox9.Text
        dataRow("Strand") = TextBox11.Text
        dataRow("Section") = TextBox12.Text
        dataRow("Picture") = TextBox13.Text
    End Sub

    ' Helper method to clear TextBoxes on the form
    Private Sub ClearTextBoxes(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If

            If ctrl.HasChildren Then
                ClearTextBoxes(ctrl)
            End If
        Next
    End Sub

    ' Optionally, you can handle DataGridView cell value changes to update the DataTable
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        ' Update the DataTable when a cell value changes
        If selectedRowIndex = -1 Then
            ' If no row is selected, update the current row
            dataTable.Rows(e.RowIndex)(e.ColumnIndex) = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        End If
    End Sub

    ' Optionally, you can handle DataGridView selection changes to update your UI
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' Update your UI based on the selected row, if needed
        If DataGridView1.SelectedCells.Count > 0 Then
            ' Get the index of the selected row
            selectedRowIndex = DataGridView1.SelectedCells(0).OwningRow.Index
            ' Populate the form controls with data from the selected row
            PopulateFormControls(selectedRowIndex)
        End If
    End Sub

    ' Search by Last Name or Section
    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Dim searchValue As String = TextBox14.Text.Trim()

        If searchValue <> "" Then
            ' Search for matching Last Name or Section
            Dim foundRows() As DataRow
            foundRows = dataTable.Select("LastName = '" & searchValue & "' OR Section = '" & searchValue & "'")

            If foundRows.Length > 0 Then
                ' Display or process the found rows
                MessageBox.Show("Student found!")

                ' Get the first found row
                Dim foundRow As DataRow = foundRows(0)

                ' Highlight the corresponding DataGridView row
                HighlightDataGridViewRow(foundRow)

                ' Populate the form controls with the data for editing
                PopulateFormControls(dataTable.Rows.IndexOf(foundRow))
            Else
                MessageBox.Show("Student not found.")

                ' Clear the form controls if no student is found
                ClearFormControls()
            End If
        Else
            MessageBox.Show("Please enter a Last Name or Section to search.")
        End If
    End Sub

    ' Highlight the corresponding DataGridView row
    Private Sub HighlightDataGridViewRow(foundRow As DataRow)
        Dim rowIndex As Integer = dataTable.Rows.IndexOf(foundRow)

        If rowIndex >= 0 AndAlso rowIndex < DataGridView1.Rows.Count Then
            DataGridView1.Rows(rowIndex).Selected = True
            DataGridView1.FirstDisplayedScrollingRowIndex = rowIndex
        End If
    End Sub

    ' Populate the form controls with data from the specified row index
    Private Sub PopulateFormControls(rowIndex As Integer)
        ' Populate the form controls with data from the specified row index
        TextBox1.Text = dataTable.Rows(rowIndex)("FirstName").ToString()
        TextBox2.Text = dataTable.Rows(rowIndex)("MiddleInitial").ToString()
        TextBox3.Text = dataTable.Rows(rowIndex)("LastName").ToString()
        TextBox4.Text = dataTable.Rows(rowIndex)("DateOfBirth").ToString()
        TextBox5.Text = dataTable.Rows(rowIndex)("Gender").ToString()
        TextBox6.Text = dataTable.Rows(rowIndex)("Age").ToString()
        TextBox7.Text = dataTable.Rows(rowIndex)("Address").ToString()
        TextBox8.Text = dataTable.Rows(rowIndex)("ContactNumber").ToString()
        TextBox9.Text = dataTable.Rows(rowIndex)("LRN").ToString()
        TextBox10.Text = dataTable.Rows(rowIndex)("YearLevel").ToString()
        TextBox11.Text = dataTable.Rows(rowIndex)("Strand").ToString()
        TextBox12.Text = dataTable.Rows(rowIndex)("Section").ToString()
        TextBox13.Text = dataTable.Rows(rowIndex)("Picture").ToString()

        ' Update PictureBox if you have a Picture column
        Dim picturePath As String = dataTable.Rows(rowIndex)("Picture").ToString()
        If File.Exists(picturePath) Then
            PictureBox1.Image = Image.FromFile(picturePath)
            PictureBox1.Show()
        Else
            PictureBox1.Hide()
        End If
    End Sub

    ' Clear the form controls
    Private Sub ClearFormControls()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        PictureBox1.Hide()
    End Sub

    ' Upload Picture
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName
            TextBox13.Text = imagePath

            If File.Exists(imagePath) Then
                PictureBox1.Image = Image.FromFile(imagePath)
                PictureBox1.Show()
            Else
                PictureBox1.Hide()
            End If
        End If
    End Sub

    ' Edit/Update button click event
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Check if a row is selected for editing
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < dataTable.Rows.Count Then
            ' Update the existing row
            UpdateDataRow(selectedRowIndex)

            ' Clear the TextBoxes after saving
            ClearTextBoxes(Me)

            ' Reset the selected row index
            selectedRowIndex = -1

            MessageBox.Show("SUCCESSFULLY UPDATED!")
        Else
            MessageBox.Show("Please select a row to edit.")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class