<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ButtonNext = New Button()
        TextBox1 = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBoxOptions = New GroupBox()
        Timer1 = New Timer(components)
        LabelTimer = New Label()
        GroupBoxOptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonNext
        ' 
        ButtonNext.BackColor = Color.Lime
        ButtonNext.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonNext.Location = New Point(12, 518)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(545, 79)
        ButtonNext.TabIndex = 0
        ButtonNext.Text = "Next"
        ButtonNext.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(12, 27)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(545, 113)
        TextBox1.TabIndex = 1
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(25, 39)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(146, 29)
        RadioButton1.TabIndex = 2
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(25, 276)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(146, 29)
        RadioButton2.TabIndex = 3
        RadioButton2.TabStop = True
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(25, 206)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(146, 29)
        RadioButton3.TabIndex = 4
        RadioButton3.TabStop = True
        RadioButton3.Text = "RadioButton3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(25, 125)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(146, 29)
        RadioButton4.TabIndex = 5
        RadioButton4.TabStop = True
        RadioButton4.Text = "RadioButton4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxOptions
        ' 
        GroupBoxOptions.Controls.Add(RadioButton1)
        GroupBoxOptions.Controls.Add(RadioButton2)
        GroupBoxOptions.Controls.Add(RadioButton3)
        GroupBoxOptions.Controls.Add(RadioButton4)
        GroupBoxOptions.Location = New Point(37, 146)
        GroupBoxOptions.Name = "GroupBoxOptions"
        GroupBoxOptions.Size = New Size(300, 332)
        GroupBoxOptions.TabIndex = 7
        GroupBoxOptions.TabStop = False
        GroupBoxOptions.Text = "GroupBox1"
        ' 
        ' LabelTimer
        ' 
        LabelTimer.AutoSize = True
        LabelTimer.BackColor = Color.Red
        LabelTimer.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LabelTimer.ForeColor = Color.White
        LabelTimer.Location = New Point(436, 244)
        LabelTimer.Name = "LabelTimer"
        LabelTimer.Size = New Size(68, 28)
        LabelTimer.TabIndex = 8
        LabelTimer.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(592, 631)
        Controls.Add(LabelTimer)
        Controls.Add(GroupBoxOptions)
        Controls.Add(TextBox1)
        Controls.Add(ButtonNext)
        Name = "Form1"
        Text = "Quiz-App"
        GroupBoxOptions.ResumeLayout(False)
        GroupBoxOptions.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonNext As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBoxOptions As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTimer As Label

End Class
