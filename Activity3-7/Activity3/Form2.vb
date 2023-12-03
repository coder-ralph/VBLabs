Imports System.Media
Public Class Form2

    ' Declare ColorDialog and FontDialog objects
    Private ColorDialog1 As New ColorDialog()
    Private FontDialog1 As New FontDialog()

    ' Song
    Private soundPlayer As New SoundPlayer(My.Resources.ProgrammersSongWav)
    Private isPlaying As Boolean = False

    ' Activity 6 - Date & Time
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Enabled = True ' Enable the second timer

        'Label1.Text = Date.Now.ToString("dd/MM/yyyy   hh:mm:ss tt")
        'Label1.Text = Date.Now.ToString("ddd, MMM d   hh:mm:ss tt")

        ' Additional code for Timer2
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        Timer1.Interval = 1000 ' Interval in milliseconds (1000 ms = 1 second)

        ' Load and display the GIF image
        LoadAndDisplayGif("programmer.gif") ' Replace with the actual path to your GIF file
    End Sub

    ' New method for Timer1_Tick
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        ' Update Label1 with the current date and time format
        Label1.Text = Date.Now.ToString("ddd, MMM d   hh:mm:ss tt")
    End Sub

    ' Activity 7
    ' Color 
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = Me.BackColor
            .ShowDialog()
            Me.BackColor = .Color
        End With
    End Sub

    ' Font
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .Font = MainMenuStrip.Font
            .ShowDialog()
            MainMenuStrip.Font = .Font
        End With
    End Sub

    ' Load and display the GIF image
    Private Sub LoadAndDisplayGif(ByVal imagePath As String)
        ' Check if the file exists
        If System.IO.File.Exists(imagePath) Then
            ' Load the GIF image into the PictureBox
            Dim gifImage As Image = Image.FromFile(imagePath)

            ' Create a PictureBox control
            Dim pictureBox As New PictureBox()
            pictureBox.Image = gifImage

            ' Set the PictureBox properties
            pictureBox.Location = New Point(10, 30) ' Adjust the location as needed
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize

            ' Add the PictureBox to the form controls
            Me.Controls.Add(pictureBox)
        Else
            'MessageBox.Show("File not found: " & imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Audio
    Private Sub btnSong_Click(sender As Object, e As EventArgs) Handles btnSong.Click
        'My.Computer.Audio.Play(My.Resources.ProgrammersSongWav, AudioPlayMode.Background)
        If isPlaying Then
            ' If audio is currently playing, pause it
            soundPlayer.Stop()
            isPlaying = False
        Else
            ' If audio is not playing, start playing it
            soundPlayer.Play()
            isPlaying = True
        End If
    End Sub
End Class
