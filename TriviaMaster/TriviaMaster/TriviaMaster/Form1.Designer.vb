<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.chkOption = New System.Windows.Forms.CheckBox()
        Me.picQuestion = New System.Windows.Forms.PictureBox()
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.Gold
        Me.lblQuestion.Location = New System.Drawing.Point(73, 653)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(150, 28)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Questions!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(308, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(409, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "🎮 Trivia Master 🎮"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(188, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(664, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Guess answers, solve picture clues, and put your knowledge to the test!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(183, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = " Select the difficulty level:"
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEasy.ForeColor = System.Drawing.Color.Coral
        Me.radEasy.Location = New System.Drawing.Point(446, 126)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(63, 20)
        Me.radEasy.TabIndex = 5
        Me.radEasy.TabStop = True
        Me.radEasy.Text = "Easy"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMedium.ForeColor = System.Drawing.Color.Coral
        Me.radMedium.Location = New System.Drawing.Point(537, 126)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(85, 20)
        Me.radMedium.TabIndex = 6
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHard.ForeColor = System.Drawing.Color.Coral
        Me.radHard.Location = New System.Drawing.Point(644, 126)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(63, 20)
        Me.radHard.TabIndex = 7
        Me.radHard.TabStop = True
        Me.radHard.Text = "Hard"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(398, 705)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Enter your answer"
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.Coral
        Me.txtAnswer.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtAnswer.Location = New System.Drawing.Point(319, 733)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(342, 37)
        Me.txtAnswer.TabIndex = 9
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkOption
        '
        Me.chkOption.AutoSize = True
        Me.chkOption.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOption.ForeColor = System.Drawing.Color.Gold
        Me.chkOption.Location = New System.Drawing.Point(321, 776)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Size = New System.Drawing.Size(299, 20)
        Me.chkOption.TabIndex = 10
        Me.chkOption.Text = "Check the box to reveal your quiz score."
        Me.chkOption.UseVisualStyleBackColor = True
        '
        'picQuestion
        '
        Me.picQuestion.Image = Global.TriviaMaster.My.Resources.Resources.bangladeshitaka
        Me.picQuestion.Location = New System.Drawing.Point(76, 168)
        Me.picQuestion.Name = "picQuestion"
        Me.picQuestion.Size = New System.Drawing.Size(883, 472)
        Me.picQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQuestion.TabIndex = 2
        Me.picQuestion.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1033, 815)
        Me.Controls.Add(Me.chkOption)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.radHard)
        Me.Controls.Add(Me.radMedium)
        Me.Controls.Add(Me.radEasy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picQuestion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "Form1"
        Me.Text = "Trivia Master"
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picQuestion As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents radEasy As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radHard As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents chkOption As CheckBox
End Class
