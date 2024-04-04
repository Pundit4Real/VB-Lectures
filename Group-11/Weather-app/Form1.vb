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
        Dim apiKey As String = "e71699e2d5cce841d280b062fe9d5570" ' Replace this with your OpenWeatherMap API key
        Dim apiUrl As String = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric"

        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString(apiUrl)

            Dim data As JObject = JObject.Parse(response)
            Dim temperature As Double = data("main")("temp").ToObject(Of Double)()
            Dim description As String = data("weather")(0)("description").ToString()
            Dim cityName As String = data("name").ToString()
            Dim weatherIcon As String = data("weather")(0)("icon").ToString() ' Get weather icon code
            Dim humidity As Integer = data("main")("humidity").ToObject(Of Integer)()
            Dim timestamp As Integer = data("dt").ToObject(Of Integer)()
            Dim observationTime As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(timestamp)
            Dim observationTimeLocal As DateTime = observationTime.LocalDateTime

            lblTemperature.Text = $"Temperature: {temperature}°C"
            lblDescription.Text = $"Description: {description}"
            lblCity.Text = $"City: {cityName}"
            lblHumidity.Text = $"Humidity: {humidity}%"
            lblDay.Text = $"Day: {observationTimeLocal.DayOfWeek}, {observationTimeLocal.ToString("dd/MM/yyyy")}"
            lblTime.Text = $"Time: {observationTimeLocal.ToString("HH:mm:ss")}"

            ' Display weather icon
            Dim iconUrl As String = $"http://openweathermap.org/img/wn/{weatherIcon}.png"
            PictureBox1.Load(iconUrl)

            ' Set background color for PictureBox based on weather conditions
            PictureBox1.BackColor = GetIconBackgroundColor(weatherIcon)

            ' Hide lblStatus
            lblStatus.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error fetching weather information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Clear weather information
            lblTemperature.Text = ""
            lblDescription.Text = ""
            lblCity.Text = ""
            lblHumidity.Text = ""
            lblDay.Text = ""
            lblTime.Text = ""
            PictureBox1.Image = Nothing
            PictureBox1.BackColor = Color.White ' Set default background color
            lblStatus.Visible = True
        End Try
    End Sub

    Private Function GetIconBackgroundColor(weatherIcon As String) As Color
        ' Convert weather icon code to specific weather conditions
        Select Case weatherIcon
            Case "01d", "01n" ' Clear sky
                Return Color.FromArgb(255, 204, 0) ' Yellow
            Case "02d", "02n" ' Few clouds
                Return Color.LightSkyBlue
            Case "03d", "03n" ' Scattered clouds
                Return Color.LightGray
            Case "04d", "04n" ' Broken clouds
                Return Color.Gray
            Case "09d", "09n", "10d", "10n" ' Rain
                Return Color.RoyalBlue
            Case "11d", "11n" ' Thunderstorm
                Return Color.DarkBlue
            Case "13d", "13n" ' Snow
                Return Color.White
            Case "50d", "50n" ' Mist, fog
                Return Color.LightGray
            Case Else ' Default color
                Return Color.Black
        End Select
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Add code to handle PictureBox click event here, if needed
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Input Validation: Allow only alphabetic characters
        If Not System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text, "^[a-zA-Z\s]+$") Then
            MessageBox.Show("Please enter a valid city or town name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub lblCity_TextChanged(sender As Object, e As EventArgs) Handles lblCity.TextChanged
        ' Add code to handle lblCity text change event here, if needed
    End Sub

    Private Sub lblTemperature_TextChanged(sender As Object, e As EventArgs) Handles lblTemperature.TextChanged
        ' Add code to handle lblTemperature text change event here, if needed
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ' Add code to handle WebBrowser document completed event here, if needed
    End Sub

    Private Sub lblStatus_TextChanged(sender As Object, e As EventArgs) Handles lblStatus.TextChanged
        ' Add code to handle lblStatus text change event here, if needed
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        ' Add code to handle GroupBox1 enter event here, if needed
    End Sub
End Class
