Imports System.IO

Public Class FileManager
    Public Sub ViewFile(ByVal p_fileID As Integer)
        Dim file = New Data.File(p_fileID)
        ViewFile(file.FileData, file.FileName, file.Extension)
    End Sub

    Public Sub ViewFile(ByVal p_fileData As Byte(), ByVal p_fileName As String, ByVal p_Extension As String)
        Dim saveDialog As New SaveFileDialog()
        saveDialog.FileName = p_fileName
        saveDialog.InitialDirectory = "D:\"
        saveDialog.SupportMultiDottedExtensions = False
        saveDialog.Filter = String.Format("Files (*{0})|*{0}", p_Extension)
        If saveDialog.ShowDialog <> DialogResult.OK Then
            Return
        End If
         
        Using fileStream = File.OpenWrite(saveDialog.FileName)
            Dim buffer = p_fileData
            fileStream.Write(buffer, 0, buffer.Length)
        End Using

        Process.Start(saveDialog.FileName)

    End Sub

End Class
