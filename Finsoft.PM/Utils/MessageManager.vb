Imports System.Windows.Forms
Imports Finsoft.PM.Common

Public Class MessageManager

#Region "message box"
    Shared Function ComfirmDelete(ByVal field As String) As Boolean
        Return Comfirmation(String.Format("Confirm to delete {0}?", field), "Confirmation")
    End Function

    Shared Function Comfirmation(ByVal p_messageCode As AppEnums.MessageCode) As Boolean
        Dim confirmText = Data.ConfigService.GetMessageText(p_messageCode)
        Return Comfirmation(confirmText, "Confirmation")
    End Function

    Shared Function Comfirmation(ByVal confirmText As String) As Boolean
        Return Comfirmation(confirmText, "Confirmation")
    End Function

    Shared Function Comfirmation(ByVal confirmText As String, ByVal caption As String) As Boolean
        Return MessageBox.Show(confirmText, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK
    End Function

    Shared Sub Warning(ByVal p_messageCode As AppEnums.MessageCode)
        Dim text = Data.ConfigService.GetConfigDisplayText(AppEnums.ConfigGroup.MessageCode, p_messageCode)
        Warning(text, "Warning")
    End Sub

    Shared Sub Warning(ByVal p_messageCode As String)
        Warning(p_messageCode, "Warning")
    End Sub
     
    Shared Sub ShowError(ByVal p_messageID As Integer, ByVal p_caption As String)
        Dim text = Data.ConfigService.GetMessageText(p_messageID)
        MessageBox.Show(text, p_caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub

    Shared Sub ShowError(ByVal p_message As String, ByVal p_caption As String)
        MessageBox.Show(p_message, p_caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub

    Shared Sub Warning(ByVal warningText As String, ByVal caption As String)
        MessageBox.Show(warningText, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    End Sub

    Shared Sub Complete(ByVal p_logType As AppEnums.LogType, ByVal caption As String)
        Dim config = Data.ConfigService.GetConfig(Data.DataEnums.ConfigGroup.LogType, CInt(p_logType))
        Dim message = String.Format("{0} successfully.", config.ConfigName)
        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Shared Sub Complete(ByVal p_messageCode As AppEnums.MessageCode, ByVal caption As String)
        Dim text = Data.ConfigService.GetMessageText(p_messageCode)
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Shared Sub Complete(ByVal message As String, ByVal caption As String)
        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
     
    Shared Sub ProcessError(ByRef sender As Object, ByVal ex As Exception, ByVal p_isThrownException As Boolean, ByVal p_message As String, ByVal caption As String, ByVal p_logID As Integer)
        Dim errorText As String = p_message

        If Not (String.IsNullOrEmpty(errorText) Or errorText = ex.Message) Then
            errorText += vbNewLine + ex.Message
        Else
            errorText = ex.Message
        End If
        If (ex.InnerException IsNot Nothing) Then
            errorText += " InnerException : " + ex.InnerException.Message
        End If
        LogManager.LogError(0, errorText, ex.StackTrace)
        MessageBox.Show(errorText, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
    End Sub

#End Region

    Public Shared Sub DisplayMessage(ByVal p_message As String, ByVal p_caption As String, ByVal p_type As AppEnums.ResultType)
        If (p_type = AppEnums.ResultType.Success) Then
            MessageManager.Complete(p_message, p_caption)
        ElseIf (p_type = AppEnums.ResultType.Waring) Then
            MessageManager.Warning(p_message, p_caption)
        Else
            MessageManager.ShowError(p_message, p_caption)
        End If
    End Sub

End Class
