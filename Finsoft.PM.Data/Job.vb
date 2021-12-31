Public Class Job
    Inherits MasterFile

#Region "Members"
    Public Property JobID As Integer
    Public Property JobNo As String
    Public Property ClientID As Integer
    Public Property ProductID As Integer 
    Public Property JobName As String 
    Public Property StatementOfworkDate As Date?
    Public Property Amount As Decimal?
    Public Property TotalMandays As Decimal?
    Public Property PO_NO As String
    Public Property PMO_NO As String 
    Public Property QuotationID As Integer

    'Join 

    Public Property ClientCode As String
    Public Property ProductCode As String
    Public Property QuotationNo As String
    Public Property QuotationDate As Date?
    Public Property InvoiceNo As String
    Public Property ContractNo As String
      
    'CR List
    Private _crList As List(Of CR)
    Public Property CurrentCRList As List(Of CR)
        Get
            If (_crList Is Nothing) Then
                If (JobID > 0) Then
                    Dim cr = New CR
                    cr.LoadDataSource("JobID", JobID)
                    _crList = cr.DataSource.ToList(Of CR)()
                End If

            End If
            Return _crList
        End Get
        Set(value As List(Of CR))
            _crList = value
        End Set
    End Property
#End Region
     
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
        TableName = "Job"
        KeyField = "JobID"
        ParentField = "QuotationID"
    End Sub
#End Region

    Public Overrides Sub DBInsertUpdate()

        Dim isnew = PrimaryKeyID <= 0
        MyBase.DBInsertUpdate()

        If (isnew) Then
            Dim crList = CurrentCRList ' CurrentCR.DataSource.ToList(Of CR)()
            For Each CR In crList
                CR.LastUpdatedBy = CreatedBy
                CR.JobID = JobID
                CR.DBInsertUpdate()
            Next
            'CurrentFiles.DBInsertUpdateTable(DataEnums.DocType., JobID, CreatedBy)
        End If
    End Sub

    Public Function GetDataSet() As DataSet

        LoadDataSource()
        Dim mater As DataTable = DataSource

        Dim cr As New CR
        cr.LoadDataSource(KeyField, -99)
        Dim detailTxType As DataTable = cr.DataSource
        Dim ds As New DataSet
        ds.Tables.Add(mater)
        ds.Tables.Add(detailTxType)

        'Set up a master-detail relationship between the DataTables 
        Dim keyColumn As DataColumn = mater.Columns(KeyField)
        Dim foreignKeyColumn As DataColumn = detailTxType.Columns(KeyField)

        ds.Relations.Add("Job_CR", keyColumn, foreignKeyColumn)
         
        Return ds
    End Function

    Public Function GetListBySelectedIDs(ByVal p_dt As DataTable, ByVal p_arrID As List(Of Integer)) As List(Of Job)
        Dim list = p_dt.ToList(Of Job)()
        Return list.Where(Function(a) p_arrID.Contains(a.JobID)).ToList
    End Function

    Public Sub LoadDataSourceByClientProductID(ByVal p_clientID As Integer, ByVal p_productID As Integer)
        Dim dic As New Dictionary(Of String, Object)
        dic.Add("ClientID", p_clientID)
        dic.Add("ProductID", p_productID)
        LoadDataSource(dic)
    End Sub

End Class
