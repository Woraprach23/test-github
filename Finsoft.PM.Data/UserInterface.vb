Public Class UserInterface
    Inherits MasterFile

    Public Property UserInterfaceID As Integer
    Public Property UiParentID As Integer?
    Public Property UiCode As String
    Public Property UiCaption As String
    Public Property UiTypeID As String
    Public Property UiClassName As String
    Public Property Description As String
    Public Property IsAutoLoad As String

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
        TableName = "UserInterface"
        ParentField = "UiParentID"
        KeyField = "UserInterfaceID"
    End Sub
#End Region
End Class
