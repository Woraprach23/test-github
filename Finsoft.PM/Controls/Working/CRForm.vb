Imports Finsoft.PM.Common
Imports System.ComponentModel
Imports System.Collections

Public Class CRForm
    Private _bindingSource As BindingSource
    Private _inst As Data.CR

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentCR As Data.CR
        Get
            If (_inst Is Nothing) Then
                If (KeyID > 0) Then
                    If (EditMode = AppEnums.EditMode.Clone) Then
                        _inst = New Data.CR
                        _inst.Clone(KeyID)
                    Else
                        _inst = New Data.CR(KeyID)
                    End If

                Else
                    _inst = New Data.CR
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _inst
            End If
            Return _inst
        End Get
        Set(value As Data.CR)
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

    Protected Overrides Sub AdditionalIntialize()

        AttachFileGridView1.ParentID = CurrentCR.CRID
        AttachFileGridView1.ParentType = AppEnums.DocType.CR
        AttachFileGridView1.DocType = AppEnums.DocType.CR
        AttachFileGridView1.CurrentFile = CurrentCR.CurrentFiles
        AttachFileGridView1.EditMode = Me.EditMode
        AttachFileGridView1.RegisterGridControl()
        AttachFileGridView1.LoadDataSource()
        'AttachFileGridView1.DataSource = CurrentCR.CurrentFiles.DataSource
    End Sub

    Protected Overrides Sub SetControlValidation()

        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl1)
        controlValidate.SetRequiredFiledCaption(LabelControl9)
        controlValidate.SetRequiredFiledCaption(LabelControl2)
        SetValidateRequiredField(slueClient)
        SetValidateRequiredField(slueProduct)
        SetValidateRequiredField(txtModuleName)

        txtModuleName.Properties.MaxLength = 50
        txtSummary.Properties.MaxLength = 250
        txtDeliveryVersion.Properties.MaxLength = 20
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentCR

        slueClient.DataBindings.Add("EditValue", _bindingSource, "ClientID", True, DataSourceUpdateMode.OnPropertyChanged)
        slueProduct.DataBindings.Add("EditValue", _bindingSource, "ProductID", True, DataSourceUpdateMode.OnPropertyChanged)
        txtModuleName.DataBindings.Add("EditValue", _bindingSource, "ModuleName", True, DataSourceUpdateMode.OnPropertyChanged)
        deOpenDate.DataBindings.Add("EditValue", _bindingSource, "OpenDate", True, DataSourceUpdateMode.OnPropertyChanged)
        txtSummary.DataBindings.Add("EditValue", _bindingSource, "Summary", True, DataSourceUpdateMode.OnPropertyChanged)
        memoDescription.DataBindings.Add("EditValue", _bindingSource, "Detail", True, DataSourceUpdateMode.OnPropertyChanged)
        spEstFSDMandays.DataBindings.Add("EditValue", _bindingSource, "EstFSDMandays", True, DataSourceUpdateMode.OnPropertyChanged)
        spEstDevMandays.DataBindings.Add("EditValue", _bindingSource, "EstDevMandays", True, DataSourceUpdateMode.OnPropertyChanged)
        spEstTestMandays.DataBindings.Add("EditValue", _bindingSource, "EstTestMandays", True, DataSourceUpdateMode.OnPropertyChanged)
        spEstSupportMandays.DataBindings.Add("EditValue", _bindingSource, "EstSupportMandays", True, DataSourceUpdateMode.OnPropertyChanged)
        spFSDManday.DataBindings.Add("EditValue", _bindingSource, "FSDMandays", True, DataSourceUpdateMode.OnPropertyChanged)
        spDevMandays.DataBindings.Add("EditValue", _bindingSource, "DevMandays", True, DataSourceUpdateMode.OnPropertyChanged)
        spTestMandays.DataBindings.Add("EditValue", _bindingSource, "TestMandays", True, DataSourceUpdateMode.OnPropertyChanged)
        spSupportMandays.DataBindings.Add("EditValue", _bindingSource, "SupportMandays", True, DataSourceUpdateMode.OnPropertyChanged)
        'slueJobID.DataBindings.Add("EditValue", _bindingSource,"JobID", True, DataSourceUpdateMode.OnPropertyChanged)
        deFSDDate.DataBindings.Add("EditValue", _bindingSource, "FSDDate", True, DataSourceUpdateMode.OnPropertyChanged)
        deDeliveryDate.DataBindings.Add("EditValue", _bindingSource, "DeliveryDate", True, DataSourceUpdateMode.OnPropertyChanged)
        deSignOffDate.DataBindings.Add("EditValue", _bindingSource, "SignOffDate", True, DataSourceUpdateMode.OnPropertyChanged)
        txtDeliveryVersion.DataBindings.Add("EditValue", _bindingSource, "DeliveryVersion", True, DataSourceUpdateMode.OnPropertyChanged)
        txtPORefNo.DataBindings.Add("EditValue", _bindingSource, "PMO_No", True, DataSourceUpdateMode.OnPropertyChanged)
        txtItemNo.DataBindings.Add("EditValue", _bindingSource, "ItemNo", True, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

    Protected Overrides Function LoadControlDowork(p_arg As Object) As Object
        Dim hashTable As New Hashtable

        Dim client As New Data.Client
        client.LoadDataSource()
        hashTable("client") = client.DataSource

        Dim product As New Data.Product
        product.LoadDataSource()
        hashTable("product") = product.DataSource


        Return hashTable
    End Function

    Protected Overrides Sub LoadControlCompleted(p_Result As Object)
        Dim hashTable As Hashtable = TryCast(p_Result, Hashtable)
        LookupManager.LoadLookUpEdit(slueClient, TryCast(hashTable("client"), DataTable), "ClientID", "ClientCode", Nothing)
        LookupManager.LoadLookUpEdit(slueProduct, TryCast(hashTable("product"), DataTable), "ProductID", "ProductCode", Nothing)
    End Sub

    Private Sub spEstFSDMandays_EditValueChanged(sender As Object, e As EventArgs) Handles spEstFSDMandays.EditValueChanged, spEstTestMandays.EditValueChanged, spEstSupportMandays.EditValueChanged, spEstDevMandays.EditValueChanged
        If (Not _isLoad) Then
            Return
        End If

        spEstTotalMandays.EditValue = CDec(spEstDevMandays.EditValue) + CDec(spEstFSDMandays.EditValue) + CDec(spEstSupportMandays.EditValue) + CDec(spEstTestMandays.EditValue)

    End Sub

    Private Sub spFSDManday_EditValueChanged(sender As Object, e As EventArgs) Handles spFSDManday.EditValueChanged, spTestMandays.EditValueChanged, spSupportMandays.EditValueChanged, spDevMandays.EditValueChanged
        If (Not _isLoad) Then
            Return
        End If
        spTotalMandays.EditValue = CDec(spDevMandays.EditValue) + CDec(spFSDManday.EditValue) + CDec(spSupportMandays.EditValue) + CDec(spTotalMandays.EditValue)
    End Sub
End Class
