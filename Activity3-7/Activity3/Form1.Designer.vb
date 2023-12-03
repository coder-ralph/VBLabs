<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(618, 277)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 35)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(618, 367)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(237, 35)
        Me.TextBox2.TabIndex = 4
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(618, 412)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(237, 10)
        Me.ProgressBar1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Location = New System.Drawing.Point(618, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.Red
        Me.Cancel.Location = New System.Drawing.Point(755, 468)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 37)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(614, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(664, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 31)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Welcome 👋"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(614, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(672, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Please login here"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Activity3.My.Resources.Resources.login
        Me.PictureBox2.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(566, 561)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Activity3.My.Resources.Resources.ccslogo_transparent
        Me.PictureBox1.Location = New System.Drawing.Point(660, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(995, 559)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Login Form"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
