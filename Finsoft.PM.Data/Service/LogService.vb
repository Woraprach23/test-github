
'Public Class LogService
'    Public Shared Sub InsertError(ByVal p_logID As String, ByVal p_error As String, ByVal p_stack As String)
'        Dim eror As New URSA_CA_LogError
'        eror.URSA_CA_LogID = p_logID
'        eror.ErrorMessage = p_error
'        eror.StackTrace = p_stack
'        eror.DBInsertUpdate()
'    End Sub

'    Public Shared Function Insert(ByVal p_menuID As Integer, _
'                             ByVal p_userID As Integer, _
'                             ByVal p_LogTypeID As Integer, _
'                             ByVal p_transactionID As Integer
'                             ) As Integer

'        Return Insert(p_menuID, p_userID, p_LogTypeID, p_transactionID, False, 0, String.Empty, String.Empty)
'    End Function

'    Public Shared Function Insert(ByVal p_menuID As Integer, _
'                             ByVal p_userID As Integer, _
'                             ByVal p_LogTypeID As Integer, _
'                             ByVal p_CAEventID As Integer, _
'                             ByVal p_isError As Boolean, _
'                             ByVal p_MessageID As Integer,
'                             ByVal p_TargetTypeID As Integer, _
'                             ByVal p_ReferenceID As Integer, _
'                             ByVal errorMessage As String, ByVal stacktrace As String
'                             ) As Integer

'        Dim log As New URSA_CA_Log()
'        log.URSA_CA_MenuID = p_menuID
'        log.UserID = p_userID
'        log.LogTypeID = p_LogTypeID
'        log.ReferenceID = p_ReferenceID
'        log.TargetTypeID = p_TargetTypeID
'        log.IsError = p_isError
'        log.MessageID = p_MessageID
'        log.ErrorMessage = errorMessage
'        log.StackTrace = stacktrace
'        log.DBInsertUpdate()

'        Return log.PrimaryKeyID
'    End Function

'    Public Shared Function Insert(ByVal p_menuID As Integer, _
'                            ByVal p_userID As Integer, _
'                            ByVal p_LogTypeID As Integer, _
'                            ByVal p_CAEventID As Integer, _
'                            ByVal p_isError As Boolean, _
'                            ByVal p_MessageID As Integer,
'                            ByVal errorMessage As String, ByVal stacktrace As String
'                            ) As Integer

'        Dim log As New URSA_CA_Log()
'        log.URSA_CA_MenuID = p_menuID
'        log.UserID = p_userID
'        log.LogTypeID = p_LogTypeID
'        log.IsError = p_isError
'        log.MessageID = p_MessageID
'        log.ErrorMessage = errorMessage
'        log.StackTrace = stacktrace
'        log.DBInsertUpdate()

'        Return log.PrimaryKeyID
'    End Function


'    Public Shared Sub UpdateError(ByVal logID As Integer, ByVal p_messageID As Integer)
'        Dim log As New URSA_CA_Log(logID)
'        log.IsError = True
'        log.MessageID = p_messageID
'        log.DBInsertUpdate()
'    End Sub

'    Public Shared Sub UpdateError(ByVal logID As Integer, ByVal errorMessage As String, ByVal stacktrace As String)
'        Dim log As New URSA_CA_Log(logID)
'        log.IsError = True
'        log.ErrorMessage = errorMessage
'        log.StackTrace = stacktrace
'        log.DBInsertUpdate()
'    End Sub

'    Public Shared Sub Update(ByVal log As URSA_CA_Log)
'        log.DBInsertUpdate()
'    End Sub

'    Public Shared Function InsertDetail(ByVal p_ParentLogID As Integer, _
'                           ByVal p_LogTypeID As Integer, _
'                           ByVal p_transactionID As Integer, _
'                           ByVal p_TargetTypeID As Integer, _
'                           ByVal p_ReferenceID As Integer
'                           ) As Integer


'        Return InsertDetail(p_ParentLogID, p_LogTypeID, p_transactionID, p_TargetTypeID, p_ReferenceID, False, 0, String.Empty, String.Empty)
'    End Function

'    Public Shared Function InsertDetail(ByVal p_ParentLogID As Integer, _
'                             ByVal p_LogTypeID As Integer, _
'                             ByVal p_transactionID As Integer, _
'                             ByVal p_TargetTypeID As Integer, _
'                             ByVal p_ReferenceID As Integer, _
'                             ByVal p_isError As Boolean, _
'                             ByVal p_MessageID As Integer, _
'                             ByVal errorMessage As String, ByVal stacktrace As String
'                             ) As Integer

'        Dim log As New URSA_CA_Log(p_ParentLogID)
'        log.URSA_CA_LogID = 0
'        log.TargetTypeID = p_TargetTypeID
'        log.ReferenceID = p_ReferenceID
'        log.IsError = p_isError
'        log.MessageID = p_MessageID
'        log.ErrorMessage = errorMessage
'        log.StackTrace = stacktrace

'        log.DBInsertUpdate()

'        Return log.PrimaryKeyID
'    End Function

'End Class
 