Imports Finsoft.PM.Common
Imports System.ComponentModel

Public Class ProductForm
    Private _bindingSource As BindingSource
    Private _template As Data.Product

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentProduct As Data.Product
        Get
            If (_template Is Nothing) Then
                If (KeyID > 0) Then
                    _template = New Data.Product(KeyID)
                Else
                    _template = New Data.Product
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _template
            End If
            Return _template
        End Get
        Set(value As Data.Product)
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

        SetValidateRequiredField(txtProductCode)
        txtProductCode.Properties.MaxLength = 50
        txtProductName.Properties.MaxLength = 500
        memoDescription.Properties.MaxLength = 1000
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentProduct

        txtProductCode.DataBindings.Add("EditValue", _bindingSource, "ProductCode", True, DataSourceUpdateMode.OnPropertyChanged)
        txtProductName.DataBindings.Add("EditValue", _bindingSource, "ProductName", True, DataSourceUpdateMode.OnPropertyChanged)
        memoDescription.DataBindings.Add("EditValue", _bindingSource, "Description", True, DataSourceUpdateMode.OnPropertyChanged)

    End Sub


End Class
