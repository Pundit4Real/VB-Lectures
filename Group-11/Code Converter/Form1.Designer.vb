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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ToolStripMenuItem1 = New ToolStripMenuItem()
        BrowseToolStripMenuItem = New ToolStripMenuItem()
        PythonToolStripMenuItem = New ToolStripMenuItem()
        CToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        PythonToolStripMenuItem1 = New ToolStripMenuItem()
        CToolStripMenuItem1 = New ToolStripMenuItem()
        CType(FastColoredTextBox1, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FastColoredTextBox1
        ' 
        FastColoredTextBox1.AutoCompleteBracketsList = New Char() {"("c, ")"c, "{"c, "}"c, "["c, "]"c, """"c, """"c, "'"c, "'"c}
        FastColoredTextBox1.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & vbCrLf & "^\s*(case|default)\s*[^:]*(?<range>:)\s*(?<range>[^;]+);"
        FastColoredTextBox1.AutoScrollMinSize = New Size(263, 22)
        FastColoredTextBox1.BackBrush = Nothing
        FastColoredTextBox1.CharHeight = 22
        FastColoredTextBox1.CharWidth = 12
        FastColoredTextBox1.DisabledColor = Color.FromArgb(CByte(100), CByte(180), CByte(180), CByte(180))
        FastColoredTextBox1.Font = New Font("Courier New", 9.75F)
        FastColoredTextBox1.Hotkeys = resources.GetString("FastColoredTextBox1.Hotkeys")
        FastColoredTextBox1.IsReplaceMode = False
        FastColoredTextBox1.Location = New Point(331, 253)
        FastColoredTextBox1.Name = "FastColoredTextBox1"
        FastColoredTextBox1.Paddings = New Padding(0)
        FastColoredTextBox1.SelectionColor = Color.FromArgb(CByte(60), CByte(0), CByte(0), CByte(255))
        FastColoredTextBox1.ServiceColors = CType(resources.GetObject("FastColoredTextBox1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        FastColoredTextBox1.Size = New Size(225, 225)
        FastColoredTextBox1.TabIndex = 4
        FastColoredTextBox1.Text = "FastColoredTextBox1"
        FastColoredTextBox1.Zoom = 100
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, BrowseToolStripMenuItem, PythonToolStripMenuItem, CToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(169, 132)
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {SaveAsToolStripMenuItem, PythonToolStripMenuItem1, CToolStripMenuItem1})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(168, 32)
        ToolStripMenuItem1.Text = "Browse"
        ' 
        ' BrowseToolStripMenuItem
        ' 
        BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        BrowseToolStripMenuItem.Size = New Size(168, 32)
        BrowseToolStripMenuItem.Text = "VB.net file"
        ' 
        ' PythonToolStripMenuItem
        ' 
        PythonToolStripMenuItem.Name = "PythonToolStripMenuItem"
        PythonToolStripMenuItem.Size = New Size(168, 32)
        PythonToolStripMenuItem.Text = "Python file"
        ' 
        ' CToolStripMenuItem
        ' 
        CToolStripMenuItem.Name = "CToolStripMenuItem"
        CToolStripMenuItem.Size = New Size(168, 32)
        CToolStripMenuItem.Text = "C# file"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(270, 34)
        SaveAsToolStripMenuItem.Text = "Save As"
        ' 
        ' PythonToolStripMenuItem1
        ' 
        PythonToolStripMenuItem1.Name = "PythonToolStripMenuItem1"
        PythonToolStripMenuItem1.Size = New Size(270, 34)
        PythonToolStripMenuItem1.Text = "Python"
        ' 
        ' CToolStripMenuItem1
        ' 
        CToolStripMenuItem1.Name = "CToolStripMenuItem1"
        CToolStripMenuItem1.Size = New Size(270, 34)
        CToolStripMenuItem1.Text = "C#"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(930, 579)
        Controls.Add(FastColoredTextBox1)
        Name = "Form1"
        Text = "Code-Converter"
        CType(FastColoredTextBox1, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BrowseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PythonToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PythonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem

End Class
