Imports System.ComponentModel
Imports Finsoft.PM.Common

Public Class AddressForm
    Private _bindingSource As BindingSource
    Private _inst As Data.Address

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentValue As Data.Address
        Get
            If (_inst Is Nothing) Then
                If (KeyID > 0) Then
                    _inst = New Data.Address(KeyID)
                Else
                    _inst = New Data.Address
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _inst
            End If
            Return _inst
        End Get
        Set(value As Data.Address)
            _inst = value
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

        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl1)
        SetValidateRequiredField(txtAddress1)

        txtAddress1.Properties.MaxLength = 50
        txtAddress2.Properties.MaxLength = 50
        txtAddress3.Properties.MaxLength = 50
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentValue

        txtAddress1.DataBindings.Add("EditValue", _bindingSource, "Address1", True, DataSourceUpdateMode.OnPropertyChanged)
        txtAddress2.DataBindings.Add("EditValue", _bindingSource, "Address2", True, DataSourceUpdateMode.OnPropertyChanged)
        txtAddress3.DataBindings.Add("EditValue", _bindingSource, "Address3", True, DataSourceUpdateMode.OnPropertyChanged)

    End Sub


    Protected Overrides Function ProcessSave() As Boolean
        If (CurrentValue.ClientID > 0) Then
            Return MyBase.ProcessSave()
        End If

        Return CustomValidateData()
    End Function


End Class
