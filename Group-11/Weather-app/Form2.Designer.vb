<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnWelcome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClose.Font = New System.Drawing.Font("Castellar", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(649, 685)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(778, 93)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Proceed To G-11 Weather-App"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnWelcome
        '
        Me.btnWelcome.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnWelcome.BackgroundImage = Global.Weather_app.My.Resources.Resources.bg
        Me.btnWelcome.Font = New System.Drawing.Font("Goudy Stout", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWelcome.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnWelcome.Location = New System.Drawing.Point(293, -5)
        Me.btnWelcome.Name = "btnWelcome"
        Me.btnWelcome.Size = New System.Drawing.Size(1210, 254)
        Me.btnWelcome.TabIndex = 0
        Me.btnWelcome.Text = "Welcome to G-11 Weather-App"
        Me.btnWelcome.UseVisualStyleBackColor = False
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Weather_app.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(1112, 768)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnWelcome)
        Me.Name = "frmWelcome"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents btnWelcome As Button
End Class
