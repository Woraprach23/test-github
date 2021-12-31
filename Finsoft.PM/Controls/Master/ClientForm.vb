Imports Finsoft.PM.Common
Imports System.ComponentModel

Public Class ClientForm
    Private _bindingSource As BindingSource
    Private _template As Data.Client

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentClient As Data.Client
        Get
            If (_template Is Nothing) Then
                If (KeyID > 0) Then
                    _template = New Data.Client(KeyID)
                Else
                    _template = New Data.Client
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _template
            End If
            Return _template
        End Get
        Set(value As Data.Client)
            _template = value
        End Set
    End Property

    Public Sub New(ByVal p_editmode As AppEnums.EditMode, ByVal p_id As Integer)
        EditMode = p_editmode
        KeyID = p_id
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
     
    

    Protected Overrides Sub SetControlValidation()
        'lbFeeType
        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl1)
        controlValidate.SetRequiredFiledCaption(LabelControl2)
        controlValidate.SetRequiredFiledCaption(LabelControl3)

        SetValidateRequiredField(txtClientCode)
        txtClientCode.Properties.MaxLength = 50
        txtClientName.Properties.MaxLength = 500 
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentClient

        txtClientCode.DataBindings.Add("EditValue", _bindingSource, "ClientCode", True, DataSourceUpdateMode.OnPropertyChanged)
        txtClientName.DataBindings.Add("EditValue", _bindingSource, "ClientName", True, DataSourceUpdateMode.OnPropertyChanged)
        txtTaxID.DataBindings.Add("EditValue", _bindingSource, "TaxID", True, DataSourceUpdateMode.OnPropertyChanged)

        AddressGridView1.CurrentClient = CurrentClient
        AddressGridView1.EditMode = Me.EditMode
        AddressGridView1.RegisterGridControl()
        AddressGridView1.DataSource = CurrentClient.CurrentAddressList
    End Sub
     
    'Protected Overrides Function LoadControlDowork(p_arg As Object) As Object
    '    ' Return CurrentClient.CurrentAddressList
    'End Function

    'Protected Overrides Sub LoadControlCompleted(p_Result As Object)
    '    'CurrentClient.CurrentAddressList = p_Result
    '    'AddressGridView1.DataSource = CurrentClient.CurrentAddressList
    'End Sub

End Class
