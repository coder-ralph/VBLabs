<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsRecordSystemDataSet = New Activity3_9.StudentsRecordSystemDataSet()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPANYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BLOGSITEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LASTNAMEToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.LASTNAMEToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MemberTableAdapter = New Activity3_9.StudentsRecordSystemDataSetTableAdapters.memberTableAdapter()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsRecordSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(536, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(860, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Company"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Blog Site"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(536, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contact"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "LASTNAME", True))
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(34, 135)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 38)
        Me.TextBox1.TabIndex = 7
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "member"
        Me.MemberBindingSource.DataSource = Me.StudentsRecordSystemDataSet
        '
        'StudentsRecordSystemDataSet
        '
        Me.StudentsRecordSystemDataSet.DataSetName = "StudentsRecordSystemDataSet"
        Me.StudentsRecordSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "FIRSTNAME", True))
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(278, 135)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(230, 38)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "ADDRESS", True))
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(540, 135)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(282, 38)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "AGE", True))
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(864, 135)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(170, 38)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "COMPANY", True))
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(34, 220)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(230, 38)
        Me.TextBox5.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(154, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 43)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(445, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 43)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(719, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 43)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.AGEDataGridViewTextBoxColumn, Me.COMPANYDataGridViewTextBoxColumn, Me.BLOGSITEDataGridViewTextBoxColumn, Me.CONTACTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MemberBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(120, 396)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(838, 273)
        Me.DataGridView1.TabIndex = 18
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'AGEDataGridViewTextBoxColumn
        '
        Me.AGEDataGridViewTextBoxColumn.DataPropertyName = "AGE"
        Me.AGEDataGridViewTextBoxColumn.HeaderText = "AGE"
        Me.AGEDataGridViewTextBoxColumn.Name = "AGEDataGridViewTextBoxColumn"
        '
        'COMPANYDataGridViewTextBoxColumn
        '
        Me.COMPANYDataGridViewTextBoxColumn.DataPropertyName = "COMPANY"
        Me.COMPANYDataGridViewTextBoxColumn.HeaderText = "COMPANY"
        Me.COMPANYDataGridViewTextBoxColumn.Name = "COMPANYDataGridViewTextBoxColumn"
        '
        'BLOGSITEDataGridViewTextBoxColumn
        '
        Me.BLOGSITEDataGridViewTextBoxColumn.DataPropertyName = "BLOGSITE"
        Me.BLOGSITEDataGridViewTextBoxColumn.HeaderText = "BLOGSITE"
        Me.BLOGSITEDataGridViewTextBoxColumn.Name = "BLOGSITEDataGridViewTextBoxColumn"
        '
        'CONTACTDataGridViewTextBoxColumn
        '
        Me.CONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.HeaderText = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.Name = "CONTACTDataGridViewTextBoxColumn"
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LASTNAMEToolStripLabel, Me.LASTNAMEToolStripTextBox, Me.SearchToolStripButton})
        Me.SearchToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Size = New System.Drawing.Size(1071, 27)
        Me.SearchToolStrip.TabIndex = 20
        Me.SearchToolStrip.Text = "SearchToolStrip"
        '
        'LASTNAMEToolStripLabel
        '
        Me.LASTNAMEToolStripLabel.Name = "LASTNAMEToolStripLabel"
        Me.LASTNAMEToolStripLabel.Size = New System.Drawing.Size(87, 24)
        Me.LASTNAMEToolStripLabel.Text = "LASTNAME:"
        '
        'LASTNAMEToolStripTextBox
        '
        Me.LASTNAMEToolStripTextBox.Name = "LASTNAMEToolStripTextBox"
        Me.LASTNAMEToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(57, 24)
        Me.SearchToolStripButton.Text = "Search"
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "BLOGSITE", True))
        Me.TextBox6.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(278, 220)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(230, 38)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "CONTACT", True))
        Me.TextBox7.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(540, 220)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(230, 38)
        Me.TextBox7.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(963, 38)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 33)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "HOME"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 29)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Fill out the details:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1071, 681)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.SearchToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Record System"
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsRecordSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StudentsRecordSystemDataSet As Activity3_9.StudentsRecordSystemDataSet
    Friend WithEvents MemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemberTableAdapter As Activity3_9.StudentsRecordSystemDataSetTableAdapters.memberTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AGEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMPANYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BLOGSITEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTACTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SearchToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents LASTNAMEToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LASTNAMEToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
