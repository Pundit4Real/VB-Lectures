Public Class CALCULATOR
    Private Sub CALCULATOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fnTextBox_TextChanged(sender As Object, e As EventArgs) Handles fnTextBox.TextChanged

    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        fnTextBox.Clear()
        snTextBox.Clear()
        ansTextBox.Clear()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Try
            If String.IsNullOrWhiteSpace(fnTextBox.Text) OrElse Not IsNumeric(fnTextBox.Text) Then
                MessageBox.Show("Please enter a valid number for First Number", "Invalid Input")
                Return
            End If

            If String.IsNullOrWhiteSpace(snTextBox.Text) OrElse Not IsNumeric(snTextBox.Text) Then
                MessageBox.Show("Please enter a valid number for Second Number", "Invalid Input")
                Return
            End If

            ' Both inputs are valid numeric values, so proceed with calculation
            Dim firstNumber As Double = Double.Parse(fnTextBox.Text)
            Dim secondNumber As Double = Double.Parse(snTextBox.Text)
            Dim result As Double = firstNumber + secondNumber

            ' Display the result in ansTextBox
            ansTextBox.Text = result.ToString()
        Catch ex As Exception
            MessageBox()

        End Try

    End Sub


    Private Sub subButton_Click(sender As Object, e As EventArgs) Handles subButton.Click
        Dim firstNumber As Double
        Dim secondNumber As Double
        If Double.TryParse(fnTextBox.Text, firstNumber) AndAlso Double.TryParse(snTextBox.Text, secondNumber) Then
            Dim result As Double = firstNumber - secondNumber
            ansTextBox.Text = result.ToString()
        Else
            MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mulButton_Click(sender As Object, e As EventArgs) Handles mulButton.Click
        Dim firstNumber As Double
        Dim secondNumber As Double
        If Double.TryParse(fnTextBox.Text, firstNumber) AndAlso Double.TryParse(snTextBox.Text, secondNumber) Then
            Dim result As Double = firstNumber * secondNumber
            ansTextBox.Text = result.ToString()
        Else
            MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub divButton_Click(sender As Object, e As EventArgs) Handles divButton.Click
        Dim firstNumber As Double
        Dim secondNumber As Double
        If Double.TryParse(fnTextBox.Text, firstNumber) AndAlso Double.TryParse(snTextBox.Text, secondNumber) Then
            If secondNumber <> 0 Then
                Dim result As Double = firstNumber / secondNumber
                ansTextBox.Text = result.ToString()
            Else
                MessageBox.Show("Cannot divide by zero.", "Division Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
