<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.resetButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextButton = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'resetButton
        '
        Me.resetButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetButton.Location = New System.Drawing.Point(98, 387)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(117, 45)
        Me.resetButton.TabIndex = 0
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(542, 387)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(107, 45)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'loginButton
        '
        Me.loginButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.Location = New System.Drawing.Point(325, 387)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(102, 45)
        Me.loginButton.TabIndex = 2
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(353, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 38)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "  LOGIN  "
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBox.Location = New System.Drawing.Point(360, 168)
        Me.usernameTextBox.Multiline = True
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(196, 49)
        Me.usernameTextBox.TabIndex = 6
        Me.usernameTextBox.Text = "dsds"
        '
        'passwordTextButton
        '
        Me.passwordTextButton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextButton.Location = New System.Drawing.Point(360, 271)
        Me.passwordTextButton.Multiline = True
        Me.passwordTextButton.Name = "passwordTextButton"
        Me.passwordTextButton.Size = New System.Drawing.Size(196, 53)
        Me.passwordTextButton.TabIndex = 7
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 534)
        Me.Controls.Add(Me.passwordTextButton)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents loginButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextButton As TextBox
End Class
