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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        File1ToolStripMenuItem = New ToolStripMenuItem()
        File2ToolStripMenuItem = New ToolStripMenuItem()
        File3ToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        View1ToolStripMenuItem = New ToolStripMenuItem()
        View2ToolStripMenuItem = New ToolStripMenuItem()
        View3ToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        Edit1ToolStripMenuItem = New ToolStripMenuItem()
        Edit2ToolStripMenuItem = New ToolStripMenuItem()
        Edit3ToolStripMenuItem = New ToolStripMenuItem()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ViewToolStripMenuItem, EditToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(861, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {File1ToolStripMenuItem, File2ToolStripMenuItem, File3ToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' File1ToolStripMenuItem
        ' 
        File1ToolStripMenuItem.Name = "File1ToolStripMenuItem"
        File1ToolStripMenuItem.Size = New Size(270, 34)
        File1ToolStripMenuItem.Text = "open"
        ' 
        ' File2ToolStripMenuItem
        ' 
        File2ToolStripMenuItem.Name = "File2ToolStripMenuItem"
        File2ToolStripMenuItem.Size = New Size(270, 34)
        File2ToolStripMenuItem.Text = "add"
        ' 
        ' File3ToolStripMenuItem
        ' 
        File3ToolStripMenuItem.Name = "File3ToolStripMenuItem"
        File3ToolStripMenuItem.Size = New Size(270, 34)
        File3ToolStripMenuItem.Text = "save"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {View1ToolStripMenuItem, View2ToolStripMenuItem, View3ToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(65, 29)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' View1ToolStripMenuItem
        ' 
        View1ToolStripMenuItem.Name = "View1ToolStripMenuItem"
        View1ToolStripMenuItem.Size = New Size(270, 34)
        View1ToolStripMenuItem.Text = "view1"
        ' 
        ' View2ToolStripMenuItem
        ' 
        View2ToolStripMenuItem.Name = "View2ToolStripMenuItem"
        View2ToolStripMenuItem.Size = New Size(270, 34)
        View2ToolStripMenuItem.Text = "view2"
        ' 
        ' View3ToolStripMenuItem
        ' 
        View3ToolStripMenuItem.Name = "View3ToolStripMenuItem"
        View3ToolStripMenuItem.Size = New Size(270, 34)
        View3ToolStripMenuItem.Text = "view3"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Edit1ToolStripMenuItem, Edit2ToolStripMenuItem, Edit3ToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(58, 29)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' Edit1ToolStripMenuItem
        ' 
        Edit1ToolStripMenuItem.Name = "Edit1ToolStripMenuItem"
        Edit1ToolStripMenuItem.Size = New Size(270, 34)
        Edit1ToolStripMenuItem.Text = "edit1"
        ' 
        ' Edit2ToolStripMenuItem
        ' 
        Edit2ToolStripMenuItem.Name = "Edit2ToolStripMenuItem"
        Edit2ToolStripMenuItem.Size = New Size(270, 34)
        Edit2ToolStripMenuItem.Text = "edit2"
        ' 
        ' Edit3ToolStripMenuItem
        ' 
        Edit3ToolStripMenuItem.Name = "Edit3ToolStripMenuItem"
        Edit3ToolStripMenuItem.Size = New Size(270, 34)
        Edit3ToolStripMenuItem.Text = "edit3"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 567)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents File1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents File2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents File3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents View1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents View2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents View3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Edit1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Edit2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Edit3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip

End Class
