<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeather
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTemperature = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHumidity = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.btnGo)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(371, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter City or place.. "
        '
        'btnGo
        '
        Me.btnGo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGo.Location = New System.Drawing.Point(460, 25)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(194, 82)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Check Weather"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(18, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(410, 55)
        Me.TextBox1.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Teal
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblStatus.Font = New System.Drawing.Font("Lucida Calligraphy", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(594, 234)
        Me.lblStatus.Multiline = True
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.ReadOnly = True
        Me.lblStatus.Size = New System.Drawing.Size(188, 37)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Loading...." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(594, 289)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 95)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblTemperature
        '
        Me.lblTemperature.BackColor = System.Drawing.Color.Teal
        Me.lblTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblTemperature.Font = New System.Drawing.Font("Lucida Calligraphy", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.ForeColor = System.Drawing.Color.White
        Me.lblTemperature.Location = New System.Drawing.Point(371, 417)
        Me.lblTemperature.Multiline = True
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.ReadOnly = True
        Me.lblTemperature.Size = New System.Drawing.Size(393, 58)
        Me.lblTemperature.TabIndex = 3
        Me.lblTemperature.Text = "O"
        Me.lblTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCity
        '
        Me.lblCity.BackColor = System.Drawing.Color.Teal
        Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCity.Font = New System.Drawing.Font("Lucida Calligraphy", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.White
        Me.lblCity.Location = New System.Drawing.Point(371, 542)
        Me.lblCity.Multiline = True
        Me.lblCity.Name = "lblCity"
        Me.lblCity.ReadOnly = True
        Me.lblCity.Size = New System.Drawing.Size(393, 60)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "Loading...."
        Me.lblCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(389, 301)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(131, 98)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Teal
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDescription.Font = New System.Drawing.Font("Lucida Calligraphy", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(371, 481)
        Me.lblDescription.Multiline = True
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.ReadOnly = True
        Me.lblDescription.Size = New System.Drawing.Size(393, 55)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(380, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(841, 52)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Weather App Developed by Group-11"
        '
        'lblHumidity
        '
        Me.lblHumidity.BackColor = System.Drawing.Color.Teal
        Me.lblHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblHumidity.Font = New System.Drawing.Font("Lucida Calligraphy", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumidity.ForeColor = System.Drawing.Color.White
        Me.lblHumidity.Location = New System.Drawing.Point(831, 542)
        Me.lblHumidity.Multiline = True
        Me.lblHumidity.Name = "lblHumidity"
        Me.lblHumidity.ReadOnly = True
        Me.lblHumidity.Size = New System.Drawing.Size(200, 60)
        Me.lblHumidity.TabIndex = 8
        Me.lblHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.Color.Teal
        Me.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDay.Font = New System.Drawing.Font("Lucida Calligraphy", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.White
        Me.lblDay.Location = New System.Drawing.Point(831, 481)
        Me.lblDay.Multiline = True
        Me.lblDay.Name = "lblDay"
        Me.lblDay.ReadOnly = True
        Me.lblDay.Size = New System.Drawing.Size(200, 55)
        Me.lblDay.TabIndex = 9
        Me.lblDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Teal
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblTime.Font = New System.Drawing.Font("Lucida Calligraphy", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(831, 417)
        Me.lblTime.Multiline = True
        Me.lblTime.Name = "lblTime"
        Me.lblTime.ReadOnly = True
        Me.lblTime.Size = New System.Drawing.Size(200, 58)
        Me.lblTime.TabIndex = 10
        Me.lblTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmWeather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Weather_app.My.Resources.Resources.bg3
        Me.ClientSize = New System.Drawing.Size(1196, 660)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblHumidity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmWeather"
        Me.Text = "Weather App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblStatus As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTemperature As TextBox
    Friend WithEvents lblCity As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHumidity As TextBox
    Friend WithEvents lblDay As TextBox
    Friend WithEvents lblTime As TextBox
End Class
