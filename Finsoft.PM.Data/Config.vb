Public Class Config
    Inherits MasterFile
    Public Property ConfigID As Integer
    Public Property ConfigGroupID As Integer?
    Public Property ConfigGroupName As String
    Public Property ConfigValue As Integer?
    Public Property ConfigCode As String
    Public Property ConfigName As String
    Public Property ConfigDisplayText As String
    Public Property Remark As String
    Public Property SequenceNo As Integer?
    Public Property BackColor As String
    Public Property ForeColor As String
    Public Property IsRowColor As Boolean
    Public Property ForeColor_Row As String
    Public Property BackColor_Row As String
#Region "Contructor"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal p_ID As Integer)
        MyBase.New(p_ID)
    End Sub
#End Region

#Region "Protected Overrides"
    Protected Overrides Sub SetMasterProperties()
        TableName = "Config"
        KeyField = "ConfigID"
    End Sub
#End Region

End Class
