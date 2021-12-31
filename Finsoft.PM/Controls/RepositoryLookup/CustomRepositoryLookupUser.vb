Imports DevExpress.XtraEditors.Registrator

<UserRepositoryItem("RegisterCustomEdit")> _
Public Class CustomRepositoryLookupUser

    Private _dataSource As DataTable
    Sub New(ByVal p_dataSource As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        _dataSource = p_dataSource
        ' Add any initialization after the InitializeComponent() call.
        Loadcontrol()
    End Sub


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Loadcontrol()
    End Sub

    Public Sub Loadcontrol()
        If (_dataSource Is Nothing) Then
            Dim user As New Data.User
            user.LoadDataSource()
            _dataSource = user.DataSource
        End If
        LookupManager.LoadLookUpEdit(Me, _dataSource, "UserID", "FullName", False, 0, String.Empty)
    End Sub

End Class
