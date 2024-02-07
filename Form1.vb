Imports System.Data.Common

Public Class Form1
    Dim selectFile As New OpenFileDialog()
    Dim selectFolder As New FolderBrowserDialog()
    Dim saveAs As New SaveFileDialog()
    Private updating As Boolean = False
    Private totalLines As Integer = 0

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLineNumbers()

        AddHandler editorText.TextChanged, AddressOf RichTextBox_TextChanged
        AddHandler editorText.TextChanged, AddressOf RichTextBox_VScroll
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs)
        UpdateLineNumbers()
    End Sub

    Private Sub RichTextBox_VScroll(sender As Object, e As EventArgs)
        If Not updating Then
            updating = True
            rtbNumber.ScrollToCaret()
            editorText.ScrollToCaret()
            updating = False
        End If
    End Sub

    Private Sub UpdateLineNumbers()
        ' Menghitung total baris pada RichTextBox isi teks
        totalLines = editorText.Lines.Length

        ' Memperbarui teks Line Numbers
        Dim lineNumberText As String = ""
        For i As Integer = 1 To totalLines
            lineNumberText &= i.ToString() & vbCrLf
        Next

        ' Menetapkan teks Line Numbers ke RichTextBox Line Numbers
        rtbNumber.Text = lineNumberText

        ' Menetapkan tinggi Line Numbers agar sesuai dengan RichTextBox isi teks

        ' Menetapkan posisi Line Numbers di sebelah kiri RichTextBox isi teks
        rtbNumber.Left = 0
        rtbNumber.Top = 0
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
