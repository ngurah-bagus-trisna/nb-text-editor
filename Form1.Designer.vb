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
        navBar = New MenuStrip()
        OpenFolderToolStripMenuItem = New ToolStripMenuItem()
        FileToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SplitContainer1 = New SplitContainer()
        folderView = New TreeView()
        editorText = New RichTextBox()
        TextBox1 = New TextBox()
        navBar.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' navBar
        ' 
        navBar.Items.AddRange(New ToolStripItem() {OpenFolderToolStripMenuItem, FileToolStripMenuItem, SaveAsToolStripMenuItem, SaveToolStripMenuItem})
        navBar.Location = New Point(0, 0)
        navBar.Name = "navBar"
        navBar.Size = New Size(952, 24)
        navBar.TabIndex = 0
        navBar.Text = "MenuStrip1"
        ' 
        ' OpenFolderToolStripMenuItem
        ' 
        OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        OpenFolderToolStripMenuItem.Size = New Size(84, 20)
        OpenFolderToolStripMenuItem.Text = "Open Folder"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(69, 20)
        FileToolStripMenuItem.Text = "Open File"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(59, 20)
        SaveAsToolStripMenuItem.Text = "Save As"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(43, 20)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 24)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(folderView)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(editorText)
        SplitContainer1.Panel2.Controls.Add(TextBox1)
        SplitContainer1.Size = New Size(952, 545)
        SplitContainer1.SplitterDistance = 264
        SplitContainer1.TabIndex = 1
        ' 
        ' folderView
        ' 
        folderView.Dock = DockStyle.Fill
        folderView.Location = New Point(0, 0)
        folderView.Name = "folderView"
        folderView.Size = New Size(264, 545)
        folderView.TabIndex = 0
        ' 
        ' editorText
        ' 
        editorText.AcceptsTab = True
        editorText.Dock = DockStyle.Fill
        editorText.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        editorText.Location = New Point(0, 0)
        editorText.Name = "editorText"
        editorText.Size = New Size(684, 545)
        editorText.TabIndex = 1
        editorText.Text = ""
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(2, 3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(616, 542)
        TextBox1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(952, 569)
        Controls.Add(SplitContainer1)
        Controls.Add(navBar)
        Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = navBar
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "NB Text Editor"
        navBar.ResumeLayout(False)
        navBar.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents navBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents folderView As TreeView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents editorText As RichTextBox

End Class
