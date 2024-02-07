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
        FileToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SplitContainer1 = New SplitContainer()
        labelNumber = New Label()
        editorText = New RichTextBox()
        statusFile = New StatusStrip()
        statusLabel = New ToolStripStatusLabel()
        TextBox1 = New TextBox()
        navBar.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        statusFile.SuspendLayout()
        SuspendLayout()
        ' 
        ' navBar
        ' 
        navBar.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, SaveAsToolStripMenuItem, SaveToolStripMenuItem})
        navBar.Location = New Point(0, 0)
        navBar.Name = "navBar"
        navBar.Size = New Size(952, 24)
        navBar.TabIndex = 0
        navBar.Text = "MenuStrip1"
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
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.Location = New Point(0, 24)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(labelNumber)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(editorText)
        SplitContainer1.Panel2.Controls.Add(statusFile)
        SplitContainer1.Panel2.Controls.Add(TextBox1)
        SplitContainer1.Size = New Size(952, 545)
        SplitContainer1.SplitterDistance = 28
        SplitContainer1.TabIndex = 1
        ' 
        ' labelNumber
        ' 
        labelNumber.BackColor = SystemColors.ScrollBar
        labelNumber.Dock = DockStyle.Left
        labelNumber.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelNumber.Location = New Point(0, 0)
        labelNumber.Name = "labelNumber"
        labelNumber.Size = New Size(28, 545)
        labelNumber.TabIndex = 0
        labelNumber.Text = "1"
        ' 
        ' editorText
        ' 
        editorText.AcceptsTab = True
        editorText.BorderStyle = BorderStyle.None
        editorText.Dock = DockStyle.Fill
        editorText.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        editorText.Location = New Point(0, 0)
        editorText.Name = "editorText"
        editorText.RightToLeft = RightToLeft.No
        editorText.ScrollBars = RichTextBoxScrollBars.Vertical
        editorText.Size = New Size(920, 523)
        editorText.TabIndex = 1
        editorText.Text = " "
        ' 
        ' statusFile
        ' 
        statusFile.Items.AddRange(New ToolStripItem() {statusLabel})
        statusFile.Location = New Point(0, 523)
        statusFile.Name = "statusFile"
        statusFile.Size = New Size(920, 22)
        statusFile.TabIndex = 2
        ' 
        ' statusLabel
        ' 
        statusLabel.Name = "statusLabel"
        statusLabel.Size = New Size(119, 17)
        statusLabel.Text = "ToolStripStatusLabel1"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
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
        statusFile.ResumeLayout(False)
        statusFile.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents navBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents editorText As RichTextBox
    Friend WithEvents labelNumber As Label
    Friend WithEvents statusFile As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel

End Class
