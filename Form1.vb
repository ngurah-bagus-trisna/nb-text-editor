Public Class Form1
    Dim selectFile As New OpenFileDialog()
    Dim saveAs As New SaveFileDialog()
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles navBar.ItemClicked

    End Sub
    Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem.Click

    End Sub
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

        selectFile.Filter = "All files |*.*"
        selectFile.Title = "Select some files"

        If selectFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.editorText.Text = FileIO.FileSystem.ReadAllText(selectFile.FileName)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If String.IsNullOrEmpty(selectFile.FileName) Then
            MessageBox.Show("Anda belum membuka file. Gunakan Save As untuk menyimpan sebagai file baru.")
            SaveAsToolStripMenuItem_Click(sender, e)
        Else
            Me.editorText.SaveFile(selectFile.FileName, RichTextBoxStreamType.PlainText)
            MessageBox.Show("Save succesfully!")
        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        saveAs.Filter = "All files | *.*"
        saveAs.Title = "Save As New File"

        If saveAs.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.editorText.SaveFile(saveAs.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles editorText.TextChanged

    End Sub


End Class
