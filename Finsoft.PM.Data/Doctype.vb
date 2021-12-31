Public Class Doctype
    Inherits MasterFile
    Public Property DoctypeID As Integer
    Public Property Doctype As String
    
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
        TableName = "Doctype"
        KeyField = "DoctypeID"
    End Sub
#End Region

End Class
