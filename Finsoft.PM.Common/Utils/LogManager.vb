
Public Class LogManager
     
    Public Shared Function InsertLog(ByVal p_userLogType As Integer) As Integer
        Return InsertLog(p_userLogType, String.Empty)
    End Function
 
    Public Shared Function InsertLog(ByVal p_userLogType As Integer, ByVal p_logError As String) As Integer
        'Dim userID As Integer = ApplicationMeta.LoginUserID
        'Dim menuID As Integer = ApplicationMeta.CurrentMenuCode
        'Dim logID = URSA.Data.CorporateAction.LogService.Insert(menuID, userID, p_userLogType, 0)
        'Return logID
        Return 0
    End Function

    Public Shared Sub LogError(ByVal p_logID As Integer, ByVal p_messageID As Integer)
        'URSA.Data.CorporateAction.LogService.UpdateError(p_logID, p_messageID)
    End Sub

    Public Shared Sub LogError(ByVal p_logID As Integer, ByVal p_errorMessage As String, ByVal stacktrace As String)
        ' URSA.Data.CorporateAction.LogService.UpdateError(p_logID, p_errorMessage, stacktrace)
    End Sub

    Public Shared Sub UpdateLog(ByVal p_logID As Integer, p_transactionID As Integer, ByVal p_refID As Integer, ByVal p_refTypeID As Integer)
        'Dim log As New URSA.Data.CorporateAction.URSA_CA_Log(p_logID)
        'log.ReferenceID = p_refID
        'log.TargetTypeID = p_refTypeID
        'log.DBInsertUpdate()
    End Sub

End Class
