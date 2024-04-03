Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class frmWeather
    Private Sub frmWeather_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowWelcomeScreen()
    End Sub

    Private Sub ShowWelcomeScreen()
        ' Display a welcome message to the user
        Dim welcomeForm As New frmWelcome()
        welcomeForm.ShowDialog()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        UpdateWeather()
    End Sub

    Private Sub UpdateWeather()
        Dim city As String = TextBox1.Text
        Dim apiKey As String = "e71699e2d5cce841d280b062fe9d5570"
        Dim apiUrl As String = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric"

        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString(apiUrl)

            Dim data As JObject = JObject.Parse(response)
            Dim temperature As Double = data("main")("temp").ToObject(Of Double)()
            Dim description As String = data("weather")(0)("description").ToString()
            Dim cityName As String = data("name").ToString()
            Dim weatherIcon As String = data("weather")(0)("icon").ToString() ' Get weather icon code

            lblTemparature.Text = $"Temperature: {temperature}°C"
            lblDescription.Text = $"Description: {description}"
            lblCity.Text = $"City: {cityName}"

            ' Display weather icon
            Dim iconUrl As String = $"http://openweathermap.org/img/wn/{weatherIcon}.png"
            PictureBox1.Load(iconUrl)
            PictureBox1.BackColor = Color.Transparent ' Set background color to transparent

            ' Hide lblStatus
            lblStatus.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error fetching weather information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Clear weather information
            lblTemparature.Text = ""
            lblDescription.Text = ""
            lblCity.Text = ""
            PictureBox1.Image = Nothing
            lblStatus.Visible = True
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Add code to handle PictureBox click event here, if needed
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Input Validation: Allow only alphabetic characters
        If Not System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text, "^[a-zA-Z\s]+$") Then
            MessageBox.Show("Please enter only alphabetic characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub lblCity_TextChanged(sender As Object, e As EventArgs) Handles lblCity.TextChanged
        ' Add code to handle lblCity text change event here, if needed
    End Sub

    Private Sub lblTemparature_TextChanged(sender As Object, e As EventArgs) Handles lblTemparature.TextChanged
        ' Add code to handle lblTemparature text change event here, if needed
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ' Add code to handle WebBrowser document completed event here, if needed
    End Sub

    Private Sub lblStatus_TextChanged(sender As Object, e As EventArgs) Handles lblStatus.TextChanged

    End Sub
End Class
