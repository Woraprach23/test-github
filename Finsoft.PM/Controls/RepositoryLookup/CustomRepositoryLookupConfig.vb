Imports Finsoft.PM.Common

Public Class CustomRepositoryLookupConfig
    Private _dataSource As Object
    Private _keyField As String = "ConfigValue"
    Private _DisplayField As String = "ConfigName"
    Sub New(ByVal _dataSource As Object)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Loadcontrol(_dataSource)
    End Sub


    Sub New(ByVal _dataSource As Object, ByVal p_keyField As String, p_displayField As String)
        _keyField = p_keyField
        _DisplayField = p_displayField
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Loadcontrol(_dataSource)
    End Sub


    Sub New(ByVal p_configGroup As AppEnums.ConfigGroup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Loadcontrol(p_configGroup)
    End Sub

    Private Sub Loadcontrol(ByVal p_configGroup As AppEnums.ConfigGroup)
        Dim service As New Data.ConfigService
        Dim ds = Data.ConfigService.GetConfigData(CInt(p_configGroup))
        Loadcontrol(ds)
    End Sub

    Private Sub Loadcontrol(ByVal _dataSource As Object)
        Dim source As New DevExpress.XtraEditors.Controls.LookUpColumnInfoCollection
        Dim col As New DevExpress.XtraEditors.Controls.LookUpColumnInfo
        col.FieldName = _keyField
        col.Caption = _DisplayField
        source.Add(col)
        AssignColumns(source)
        Me.DataSource = _dataSource
        Me.ValueMember = _keyField
        Me.DisplayMember = _DisplayField
        Me.NullText = String.Empty
    End Sub
End Class
