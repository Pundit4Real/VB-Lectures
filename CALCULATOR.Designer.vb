<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CALCULATOR
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fnTextBox = New System.Windows.Forms.TextBox()
        Me.snTextBox = New System.Windows.Forms.TextBox()
        Me.ansTextBox = New System.Windows.Forms.TextBox()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.divButton = New System.Windows.Forms.Button()
        Me.mulButton = New System.Windows.Forms.Button()
        Me.subButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First-Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Answer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "  CALCULATOR "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Second-Number"
        '
        'fnTextBox
        '
        Me.fnTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnTextBox.Location = New System.Drawing.Point(288, 102)
        Me.fnTextBox.Multiline = True
        Me.fnTextBox.Name = "fnTextBox"
        Me.fnTextBox.Size = New System.Drawing.Size(190, 46)
        Me.fnTextBox.TabIndex = 4
        '
        'snTextBox
        '
        Me.snTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.snTextBox.Location = New System.Drawing.Point(288, 204)
        Me.snTextBox.Multiline = True
        Me.snTextBox.Name = "snTextBox"
        Me.snTextBox.Size = New System.Drawing.Size(190, 47)
        Me.snTextBox.TabIndex = 5
        '
        'ansTextBox
        '
        Me.ansTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ansTextBox.Location = New System.Drawing.Point(288, 301)
        Me.ansTextBox.Multiline = True
        Me.ansTextBox.Name = "ansTextBox"
        Me.ansTextBox.ReadOnly = True
        Me.ansTextBox.Size = New System.Drawing.Size(190, 47)
        Me.ansTextBox.TabIndex = 6
        '
        'resetButton
        '
        Me.resetButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetButton.Location = New System.Drawing.Point(136, 432)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(122, 39)
        Me.resetButton.TabIndex = 7
        Me.resetButton.Text = "&RESET"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(467, 432)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(124, 42)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "E&XIT"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.Location = New System.Drawing.Point(648, 94)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(107, 44)
        Me.addButton.TabIndex = 12
        Me.addButton.Text = "&ADD"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'divButton
        '
        Me.divButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divButton.Location = New System.Drawing.Point(648, 348)
        Me.divButton.Name = "divButton"
        Me.divButton.Size = New System.Drawing.Size(107, 44)
        Me.divButton.TabIndex = 13
        Me.divButton.Text = "&DIV"
        Me.divButton.UseVisualStyleBackColor = True
        '
        'mulButton
        '
        Me.mulButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mulButton.Location = New System.Drawing.Point(648, 263)
        Me.mulButton.Name = "mulButton"
        Me.mulButton.Size = New System.Drawing.Size(107, 44)
        Me.mulButton.TabIndex = 14
        Me.mulButton.Text = "&MUL"
        Me.mulButton.UseVisualStyleBackColor = True
        '
        'subButton
        '
        Me.subButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subButton.Location = New System.Drawing.Point(648, 173)
        Me.subButton.Name = "subButton"
        Me.subButton.Size = New System.Drawing.Size(107, 44)
        Me.subButton.TabIndex = 15
        Me.subButton.Text = "&SUB"
        Me.subButton.UseVisualStyleBackColor = True
        '
        'CALCULATOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 573)
        Me.Controls.Add(Me.subButton)
        Me.Controls.Add(Me.mulButton)
        Me.Controls.Add(Me.divButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.ansTextBox)
        Me.Controls.Add(Me.snTextBox)
        Me.Controls.Add(Me.fnTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CALCULATOR"
        Me.Text = "calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fnTextBox As TextBox
    Friend WithEvents snTextBox As TextBox
    Friend WithEvents ansTextBox As TextBox
    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents divButton As Button
    Friend WithEvents mulButton As Button
    Friend WithEvents subButton As Button
End Class
