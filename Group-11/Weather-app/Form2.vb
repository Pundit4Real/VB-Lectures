Public Class frmWelcome
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnWelcome_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmWelcome_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Draw the background image
        Dim backgroundImage As Image = Image.FromFile("C:\Users\moham\Desktop\L300\1st Sem\VB-357\VB-Lectures\Group-11\Weather-app\images\bg.jpg")
        e.Graphics.DrawImage(backgroundImage, 0, 0, Me.Width, Me.Height)

        ' Draw a semi-transparent overlay
        Using brush As New SolidBrush(Color.FromArgb(90, Color.Black)) ' semi-transparent black
            e.Graphics.FillRectangle(brush, Me.ClientRectangle)
        End Using
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
