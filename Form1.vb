Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim selectFile As New OpenFileDialog()
    Dim selectFolder As New FolderBrowserDialog()
    Dim saveAs As New SaveFileDialog()


    Private Sub rtbMain_Scroll(sender As Object, e As EventArgs) Handles editorText.VScroll
        UpdateLineNumbers()
    End Sub

    Private Sub rtbMain_TextChanged(sender As Object, e As EventArgs) Handles editorText.TextChanged
        UpdateLineNumbers()
    End Sub

    Private Sub UpdateLineNumbers()
        labelNumber.Text = ""
        Dim firstVisibleLine As Integer = editorText.GetLineFromCharIndex(editorText.GetCharIndexFromPosition(New Point(0, 0)))

        ' Mendapatkan jumlah baris aktual dari RichTextBox
        Dim lineCount As Integer = editorText.Lines.Length

        For i As Integer = firstVisibleLine To firstVisibleLine + editorText.ClientSize.Height \ editorText.Font.Height
            ' Mengecek apakah index baris melebihi jumlah baris aktual
            If i < lineCount Then
                labelNumber.Text &= i + 1 & vbCrLf
            Else
                Exit For
            End If
        Next
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
            MessageBox.Show("Anda belum membuka file!. Gunakan Save As untuk menyimpan sebagai file baru!", "Warning!")
            SaveAsToolStripMenuItem_Click(sender, e)
        Else
            Me.editorText.SaveFile(selectFile.FileName, RichTextBoxStreamType.PlainText)
            MessageBox.Show("Save succesfully!", "Save")
        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        saveAs.Filter = "All files | *.*"
        saveAs.Title = "Save As New File"

        If saveAs.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.editorText.SaveFile(saveAs.FileName, RichTextBoxStreamType.PlainText)
            MessageBox.Show("Save succesfully!", "Save")
        End If

    End Sub


End Class
