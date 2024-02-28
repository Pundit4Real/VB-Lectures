Public Class Question1
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        If RadioButton2.Checked Then
            MessageBox.Show("Your answer is correct")
            sum = sum + 1
        Else
            MessageBox.Show("In correct Answer,try again")
        End If
        MessageBox.Show($"Your Scores is: { sum }")

    End Sub

End Class
