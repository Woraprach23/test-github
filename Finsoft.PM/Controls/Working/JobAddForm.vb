Public Class JobAddForm
    Private _clientProduct As Data.ClientProduct
    Private _ids As List(Of Integer)
    Private _parentType As Common.AppEnums.DocType = Common.AppEnums.DocType.Job
    Private _quotationID As Integer

    Sub New(ByVal p_QuotationID As Integer, p_clientProduct As Data.ClientProduct, ByVal p_IDs As List(Of Integer))
        _clientProduct = p_clientProduct
        _ids = p_IDs
        _quotationID = p_QuotationID
        EditMode = Common.AppEnums.EditMode.Add
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Protected Overrides Sub AdditionalIntialize()
        JobGridView1.IsAddForm = True
        JobGridView1.QuotationID = _quotationID
        JobGridView1.EditMode = Common.AppEnums.EditMode.Add
        JobGridView1.ShowCaption = True
        JobGridView1.ShowAddPanel = False
        JobGridView1.CurrentClientProduct = _clientProduct
        JobGridView1.RegisterGridControl()
        JobGridView1.RowFilter = GetRowFilter()
        JobGridView1.ShowCaption = False
        JobGridView1.LoadDataSource()

        txtClientCode.Text = _clientProduct.ClientCode
        txtPructionCode.Text = _clientProduct.ProductCode
    End Sub

    Private Function GetRowFilter() As String
        Dim filter = String.Format("JobID NOT IN ({0})", String.Join(",", _ids))
        Return filter
    End Function

    Public Overrides Function ValidateControl() As Boolean
        If (Not MyBase.ValidateControl()) Then
            Return False
        End If

        If (JobGridView1.CheckGridViewUnselect) Then
            Return False
        End If

        Return JobGridView1.IsNotDuplicatingQuotation()

        Return True
    End Function

    Protected Overrides Function ProcessSave() As Boolean

        Dim index As Integer = 0
        Dim job As Data.Job = Nothing
        Dim selectKeys = JobGridView1.GetSelectedKeys
        For Each key In selectKeys
            job = New Data.Job(key)
            job.QuotationID = _quotationID
            job.LastUpdatedBy = Common.ApplicationMeta.LoginUserID
            job.DBInsertUpdate()
        Next

        Return True

    End Function
End Class
