Imports System.ComponentModel
Imports Finsoft.PM.Common
Imports System.Collections

Public Class JobForm
    Private _bindingSource As BindingSource
    Private _value As Data.Job

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentJob As Data.Job
        Get
            If (_value Is Nothing) Then
                If (KeyID > 0) Then
                    _value = New Data.Job(KeyID)
                Else
                    _value = New Data.Job
                End If
            End If
            If (_masterFile Is Nothing) Then
                _masterFile = _value
            End If
            Return _value
        End Get
        Set(value As Data.Job)
            _value = value
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
        xPageDocuments.PageVisible = False
        xPageDetail.PageVisible = False

        CrGridView1.ParentID = CurrentJob.JobID
        CrGridView1.ParentType = AppEnums.DocType.Job
        CrGridView1.EditMode = IIf(Me.EditMode = AppEnums.EditMode.Add, AppEnums.EditMode.View, Me.EditMode)
        CrGridView1.RegisterGridControl()
        If (EditMode <> AppEnums.EditMode.Add) Then
            CrGridView1.CurrentClientProduct = New Data.ClientProduct
            CrGridView1.CurrentClientProduct.ClientID = CurrentJob.ClientID
            CrGridView1.CurrentClientProduct.ClientCode = CurrentJob.ClientCode
            CrGridView1.CurrentClientProduct.ProductID = CurrentJob.ProductID
            CrGridView1.CurrentClientProduct.ProductCode = CurrentJob.ProductCode
            CrGridView1.LoadDataSource()
        Else
            CurrentJob.TotalMandays = CurrentJob.CurrentCRList.Select(Function(a) a.TotalMandays).Sum()
            CrGridView1.DataSource = CurrentJob.CurrentCRList

        End If

    End Sub

    Protected Overrides Sub SetControlValidation()
        Dim controlValidate As New ControlValidator
        controlValidate.SetRequiredFiledCaption(LabelControl9)
        controlValidate.SetRequiredFiledCaption(LabelControl2)
        SetValidateRequiredField(txtJobName)
    End Sub

    Protected Overrides Sub BindingControls()
        _bindingSource = New BindingSource()
        _bindingSource.DataSource = CurrentJob

        'slueClient.DataBindings.Add("EditValue", _bindingSource, "ClientID", True, DataSourceUpdateMode.OnPropertyChanged)
        'slueProduct.DataBindings.Add("EditValue", _bindingSource, "ProductID", True, DataSourceUpdateMode.OnPropertyChanged)
        txtClientCode.DataBindings.Add("EditValue", _bindingSource, "ClientCode", True, DataSourceUpdateMode.OnPropertyChanged)
        txtProductCode.DataBindings.Add("EditValue", _bindingSource, "ProductCode", True, DataSourceUpdateMode.OnPropertyChanged)

        txtJobName.DataBindings.Add("EditValue", _bindingSource, "JobName", True, DataSourceUpdateMode.OnPropertyChanged)
        txtFSDNo.DataBindings.Add("EditValue", _bindingSource, "JobNo", True, DataSourceUpdateMode.OnPropertyChanged)
        deStatementOfworkDate.DataBindings.Add("EditValue", _bindingSource, "StatementOfworkDate", True, DataSourceUpdateMode.OnPropertyChanged)
        speAmount.DataBindings.Add("EditValue", _bindingSource, "Amount", True, DataSourceUpdateMode.OnPropertyChanged)
        speTotalMandays.DataBindings.Add("EditValue", _bindingSource, "TotalMandays", True, DataSourceUpdateMode.OnPropertyChanged)

        txtPMO_NO.DataBindings.Add("EditValue", _bindingSource, "PMO_NO", True, DataSourceUpdateMode.OnPropertyChanged)
        txtPO_NO.DataBindings.Add("EditValue", _bindingSource, "PO_NO", True, DataSourceUpdateMode.OnPropertyChanged)
        txtInvoiceNo.DataBindings.Add("EditValue", _bindingSource, "InvoiceNo", True, DataSourceUpdateMode.OnPropertyChanged)
        txtQuatationNo.DataBindings.Add("EditValue", _bindingSource, "QuotationNo", True, DataSourceUpdateMode.OnPropertyChanged)
        txtContractNo.DataBindings.Add("EditValue", _bindingSource, "ContractNo", True, DataSourceUpdateMode.OnPropertyChanged)
          
    End Sub
     

    Public Overrides Function ValidateControl() As Boolean
        If (Not MyBase.ValidateControl()) Then
            Return False
        End If

        If (CrGridView1.CurrentGridView.RowCount = 0) Then
            MessageManager.ShowError("CR item is required.", btnSave.Text)
            xPageCR.Focus()
            Return False
        End If
        Return True
    End Function
     
    Private Sub btnViewQuatation_Click(sender As Object, e As EventArgs) Handles btnViewQuatation.Click
        Dim form As New QuotationForm(AppEnums.EditMode.View, CurrentJob.QuotationID)
        Dim text = String.Format("{0} - {1}", form.Text, AppEnums.EditMode.View)
        form.Text = text
        form.ShowDialog
    End Sub
 
End Class

