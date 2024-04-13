Public Class Form1
    ' Define variables to store quiz questions and answers
    Dim questions As String()
    Dim answers As String()
    Dim currentQuestionIndex As Integer = 0
    Dim score As Integer = 0

    ' Flag to track whether the check box was checked
    Dim checkboxChecked As Boolean = False

    ' Event handler for when the form is first loaded
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the welcome message
        MessageBox.Show("Welcome to TriviaMaster! 🎮")

        ' Initialize with default questions and answers
        LoadQuestionsByDifficulty("Easy")

        ' Display the first question
        DisplayQuestion()
    End Sub

    ' Function to display the current question
    Private Sub DisplayQuestion()
        ' Display the question text
        lblQuestion.Text = questions(currentQuestionIndex)

        ' Hide Radio Buttons and Check Box
        chkOption.Visible = True

        ' Show TextBox for user input
        txtAnswer.Visible = True
        txtAnswer.Text = ""

        ' Display an image related to the question using Picture Box
        Select Case currentQuestionIndex
            Case 0
                picQuestion.Image = My.Resources.paris
            Case 1
                picQuestion.Image = My.Resources.mars
            Case 2
                picQuestion.Image = My.Resources.bluewhale
            Case 3
                picQuestion.Image = My.Resources.yen
            Case 4
                picQuestion.Image = My.Resources.shakespeare
            Case Else
                ' For Medium, add a set of 5 images
                If radMedium.Checked Then
                    Select Case currentQuestionIndex
                        Case 5
                            picQuestion.Image = My.Resources.madrid
                        Case 6
                            picQuestion.Image = My.Resources.carbondioxide
                        Case 7
                            picQuestion.Image = My.Resources.pacificocean
                        Case 8
                            picQuestion.Image = My.Resources.leonardodavinci
                        Case 9
                            picQuestion.Image = My.Resources.australiandollar
                    End Select
                End If
                ' For Hard, add a set of 9 images
                If radHard.Checked Then
                    Select Case currentQuestionIndex
                        Case 10
                            picQuestion.Image = My.Resources.german
                        Case 11
                            picQuestion.Image = My.Resources.image7_hard
                        Case 12
                            picQuestion.Image = My.Resources.image8_hard
                        Case 13
                            picQuestion.Image = My.Resources.image9_hard
                        Case 14
                            picQuestion.Image = My.Resources.image10_hard
                    End Select
                End If
        End Select

        ' Show the radio buttons for difficulty levels
        radEasy.Visible = True
        radMedium.Visible = True
        radHard.Visible = True

        ' Clear the selected difficulty level
        radEasy.Checked = False
        radMedium.Checked = False
        radHard.Checked = False
    End Sub

    ' Event handler for the TextBox KeyPress event
    Private Sub TxtAnswer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnswer.KeyPress
        ' Check if the pressed key is Enter (ASCII code 13)
        If e.KeyChar = ChrW(13) Then
            ' Get the answer entered in the TextBox
            Dim enteredAnswer As String = txtAnswer.Text.Trim()

            ' Check if the entered answer is correct
            If enteredAnswer = answers(currentQuestionIndex) Then
                MessageBox.Show("Correct!")
                ' Increment the score
                score += 1
            Else
                MessageBox.Show("Incorrect!")
                ' Optionally, you may choose to allow the user to try again or take some other action.
            End If

            ' Move to the next question
            currentQuestionIndex += 1

            ' Check if there are more questions
            If currentQuestionIndex < questions.Length Then
                DisplayQuestion()
            Else
                ' Display the final score
                Dim result As DialogResult = MessageBox.Show("Quiz completed! Your score: " & score.ToString() & vbCrLf & "Try Again?", "Quiz Completed", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    ' Reset the quiz
                    currentQuestionIndex = 0
                    score = 0
                    LoadQuestionsByDifficulty("Easy") ' Reset to default questions for Easy
                    DisplayQuestion()
                Else
                    ' Close the application or take appropriate action
                    Me.Close()
                End If
            End If

            ' Suppress the Enter key press to prevent a new line in the TextBox
            e.Handled = True
        End If
    End Sub

    ' Event handler for the Check box CheckedChanged event
    Private Sub ChkOption_CheckedChanged(sender As Object, e As EventArgs) Handles chkOption.CheckedChanged
        ' Check if the check box was checked
        If chkOption.Checked Then
            ' Display the current score when the check box is checked
            MessageBox.Show("Current Score: " & score.ToString())
        End If
    End Sub

    ' Event handler for the Easy radio button CheckedChanged event
    Private Sub RadEasy_CheckedChanged(sender As Object, e As EventArgs) Handles radEasy.CheckedChanged
        If radEasy.Checked Then
            MessageBox.Show("Easy difficulty selected.")
            ' Load questions for Easy difficulty
            LoadQuestionsByDifficulty("Easy")
        End If
    End Sub

    ' Event handler for the Medium radio button CheckedChanged event
    Private Sub RadMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged
        If radMedium.Checked Then
            MessageBox.Show("Medium difficulty selected.")
            ' Load questions for Medium difficulty
            LoadQuestionsByDifficulty("Medium")
        End If
    End Sub

    ' Event handler for the Hard radio button CheckedChanged event
    Private Sub RadHard_CheckedChanged(sender As Object, e As EventArgs) Handles radHard.CheckedChanged
        If radHard.Checked Then
            MessageBox.Show("Hard difficulty selected.")
            ' Load questions for Hard difficulty
            LoadQuestionsByDifficulty("Hard")
        End If
    End Sub

    ' Function to load questions based on difficulty
    Private Sub LoadQuestionsByDifficulty(difficulty As String)
        ' Reset the current question index
        currentQuestionIndex = 0

        ' Clear existing questions
        questions = New String() {}
        answers = New String() {}

        ' Add questions based on difficulty
        Select Case difficulty
            Case "Easy"
                questions = {"What is the capital of France?", "Which planet is known as the Red Planet?", "What is the largest mammal?", "What is the currency of Japan?", "Who wrote 'Romeo and Juliet'?"}
                answers = {"Paris", "Mars", "Blue Whale", "Yen", "William Shakespeare"}
            Case "Medium"
                questions = {"What is the capital of Spain?", "Which gas do plants absorb?", "What is the largest ocean on Earth?", "Who painted the Mona Lisa?", "What is the currency of Australia?"}
                answers = {"Madrid", "Carbon Dioxide", "Pacific Ocean", "Leonardo da Vinci", "Australian Dollar"}
            Case "Hard"
                questions = {"In which year did World War I begin?", "What is the capital of Mongolia?", "What is the smallest prime number?", "Who developed the theory of relativity?", "What is the currency of Bangladesh?"}
                answers = {"1914", "Ulaanbaatar", "2", "Albert Einstein", "Bangladeshi Taka"}
        End Select

        ' Display the first question
        DisplayQuestion()
    End Sub
End Class
