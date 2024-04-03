Public Class Form1
    ' Array of questions
    Dim questions() As String = {"200 - 173 = ?", "100 + 1000 = ?", "300 x 50 = ?", "400 / 10 = ?", "100 - 100 = ?"}

    ' Array of options
    Dim options(,) As String = {{"100", "123", "27", "28", "27"},
                                {"1100", "500", "900", "2000", "1100"},
                                {"1700", "15000", "20000", "30000", "15000"},
                                {"4", "4000", "400", "40", "40"},
                                {"0", "1", "90", "100", "0"}}

    Dim index As Integer = 0
    Dim correct As Integer = 0
    Dim quizCompleted As Boolean = False ' Flag to track if all questions are answered
    Dim timerDuration As Integer = 60 ' Time limit for answering each question in seconds
    Dim remainingTime As Integer = 0 ' Remaining time for the current question

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start the quiz when the form loads
        DisplayNextQuestion()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        ' Check if the quiz has finished
        If quizCompleted Then
            ' Display the final score
            DisplayFinalScore()
        ElseIf index < questions.Length Then
            ' Display the next question
            DisplayNextQuestion()
        End If
    End Sub

    Private Sub RadioButton_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click
        ' Check the selected answer
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)
        CheckAnswer(radioButton)
    End Sub

    Private Sub DisplayNextQuestion()
        ' Reset the timer
        remainingTime = timerDuration
        Timer1.Start()

        ' Clear the selection of all radio buttons
        ResetRadioButtons()

        ' Display the next question
        TextBox1.Text = questions(index)
        RadioButton1.Text = options(index, 0)
        RadioButton2.Text = options(index, 1)
        RadioButton3.Text = options(index, 2)
        RadioButton4.Text = options(index, 3)
        EnableRadioButtons(True)
        index += 1 ' Move to the next question

        ' Check if all questions are answered
        If index = questions.Length Then
            quizCompleted = True
        End If
    End Sub

    Private Sub CheckAnswer(selectedRadioButton As RadioButton)
        ' Stop the timer
        Timer1.Stop()

        ' Check the selected answer
        If selectedRadioButton.Text.Equals(options(index - 1, 4)) Then
            correct += 1
            selectedRadioButton.BackColor = Color.Green
        Else
            selectedRadioButton.BackColor = Color.Red
        End If
        EnableRadioButtons(False)

        ' Check if all questions are answered
        If index = questions.Length Then
            quizCompleted = True
        End If
    End Sub

    Private Sub DisplayFinalScore()
        ' Display the final score
        TextBox1.Text &= vbCrLf & "Your Final Score: " & correct & " / " & questions.Length
        ButtonNext.Text = "Restart The Quiz"
        ' Reset variables to restart the quiz
        index = 0
        correct = 0
        quizCompleted = False
    End Sub

    Private Sub EnableRadioButtons(enable As Boolean)
        ' Enable or disable radio buttons
        For Each control As Control In GroupBoxOptions.Controls
            If TypeOf control Is RadioButton Then
                control.Enabled = enable
            End If
        Next
    End Sub

    Private Sub ResetRadioButtons()
        ' Reset the text and selection of all radio buttons
        For Each control As Control In GroupBoxOptions.Controls
            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)
                ' Clear the selection
                radioButton.Checked = False
                ' Reset the background color
                radioButton.BackColor = SystemColors.Control
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the remaining time
        remainingTime -= 1
        ' Display the remaining time
        LabelTimer.Text = "Time Left: " & remainingTime.ToString() & " seconds"

        ' Check if time is up
        If remainingTime <= 0 Then
            Timer1.Stop()
            ' Disable radio buttons and move to the next question
            EnableRadioButtons(False)
            DisplayNextQuestion()
        End If

        ' Check if all questions are answered and stop the timer
        If quizCompleted Then
            Timer1.Stop()
        End If
    End Sub
End Class
