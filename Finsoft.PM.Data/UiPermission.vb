Public Class UIPermission
    Inherits MasterFile
#Region "Const"
    Public Const c_TableName As String = "UIPermission"
    Public Const c_KeyField As String = "UIPermissionID"
    Public Const c_ParentField As String = "UserRoleID"
#End Region

#Region "Member & Property"
    Private _UIPermissionID As Integer
    Public Property UIPermissionID As Integer
        Get
            Return _UIPermissionID
        End Get
        Set(value As Integer)
            _PrimaryKeyID = value
            If _UIPermissionID = value Then
                Return
            End If
            _UIPermissionID = value
            NotIFyPropertyChanged("UIPermissionID")
        End Set
    End Property
    Private _UserRoleID As Integer
    Public Property UserRoleID As Integer
        Get
            Return _UserRoleID
        End Get
        Set(value As Integer)
            If _UserRoleID = value Then
                Return
            End If
            _UserRoleID = value
            NotIFyPropertyChanged("UserRoleID")
        End Set
    End Property
    Private _UserInterfaceID As Integer
    Public Property UserInterfaceID As Integer
        Get
            Return _UserInterfaceID
        End Get
        Set(value As Integer)
            If _UserInterfaceID = value Then
                Return
            End If
            _UserInterfaceID = value
            NotIFyPropertyChanged("UserInterfaceID")
        End Set
    End Property
    Private _PermissionTypeID As Integer
    Public Property PermissionTypeID As Integer
        Get
            Return _PermissionTypeID
        End Get
        Set(value As Integer)
            If _PermissionTypeID = value Then
                Return
            End If
            _PermissionTypeID = value
            NotIFyPropertyChanged("PermissionTypeID")
        End Set
    End Property

#End Region
#Region "Constructor"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal p_UIPermissionID As Integer)
        MyBase.New(p_UIPermissionID)
    End Sub
#End Region


#Region "Must Inherit Method"
    Protected Overrides Sub SetMasterProperties()
        _TableName = c_TableName
        _KeyField = c_KeyField
        _ParentField = c_ParentField
    End Sub


    Public Overrides Function ValidateData() As Integer
        If UserInterfaceID <= 0 Or UserRoleID <= 0 Then
            Return 3
        End If
                 Return String.Empty
    End Function
#End Region


#Region "data table"
    Public Function GetPermission(ByVal p_userInterfaceID As Integer) As Integer
        Dim rows() As DataRow = DataSource.Select(String.Format("UserInterfaceID = {0}", p_userInterfaceID))
        If rows.Length > 0 Then
            Return CInt(rows(0)("PermissionTypeID"))
        End If
        Return 0
    End Function

    Public Function GetPermission(ByVal p_uiClassName As String) As Integer
        Dim rows As DataRow = SelectRowByClassName(p_uiClassName)
        If rows IsNot Nothing Then
            Return rows("PermissionTypeID")
        End If
        Return 0
    End Function

    Public Function GetIDByClassName(ByVal p_uiClassName As String) As Integer
        Dim rows As DataRow = SelectRowByClassName(p_uiClassName)
        If rows IsNot Nothing Then
            Return rows("UserInterfaceID")
        End If
        Return 0
    End Function

    Public Function IsNCR(ByVal p_UserInterfaceID As Integer) As Boolean
        Dim rows As DataRow = SelectRowByUserInterfaceID(p_UserInterfaceID)
        If rows IsNot Nothing Then
            Return CBool(rows("IsNCR"))
        End If
        Return False
    End Function

    Public Function SelectRowByClassName(ByVal p_uiClassName As String) As DataRow
        If DataSource Is Nothing Then

        End If
        Dim rows() As DataRow = DataSource.Select(String.Format("UiClassName = '{0}'", p_uiClassName))
        If rows.Length > 0 Then
            Return rows(0)
        End If
        Return Nothing
    End Function

    Public Function SelectRowByUserInterfaceID(ByVal p_UserInterfaceID As Integer) As DataRow
        If DataSource Is Nothing Then

        End If
        Dim rows() As DataRow = DataSource.Select(String.Format("UserInterfaceID = {0}", p_UserInterfaceID))
        If rows.Length > 0 Then
            Return rows(0)
        End If
        Return Nothing
    End Function

#End Region
End Class