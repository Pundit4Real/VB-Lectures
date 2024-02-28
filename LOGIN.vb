Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        usernameTextBox.Clear()
        passwordTextButton.Clear()
    End Sub

    Private Sub loginButton_Click_1(sender As Object, e As EventArgs) Handles loginButton.Click
        If (usernameTextBox.Text = "MOALI" And passwordTextButton.Text = "12345") Then
            Me.Hide()
            CALCULATOR.Show()
        Else
            MessageBox.Show("Wrong username or password", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("do you want to exist", "Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (DialogResult = DialogResult.Yes) Then
            Application.ExitThread()

            End
        End If
    End Sub
End Class