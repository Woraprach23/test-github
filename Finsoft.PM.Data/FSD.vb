Public Class FSD
    Inherits MasterFile

    Public Property FSDID As Integer
    Public Property ClientID As Integer
    Public Property ProductID As Integer
    Public Property FSDNo As String
    Public Property FSDDate As Date?
    Public Property FSDSignOffDate As Date?
    Public Property FSDName As String
    Public Property FSDDetail As String
    Public Property QuotationID As Integer

    Public Property ClientCode As String
    Public Property ProductCode As String
     
    'CR List


#Region "Members"
    Private _file As File
    Public Property CurrentFiles As File
        Get
            If (_file Is Nothing) Then
                _file = New File
                _file.DocTypeID = DataEnums.DocType.FSD
                _file.ReferenceID = FSDID
                _file.ReferenceTypeID = DataEnums.DocType.Contract
                '_file.LoadDataSourceByReferenceID(_file.ReferenceTypeID, _file.ReferenceID)
            End If
            Return _file
        End Get
        Set(value As File)
            _file = value
        End Set
    End Property

    'Private _cr As CR
    'Public Property CurrentCR As CR
    '    Get
    '        If (_cr Is Nothing) Then
    '            _cr = New CR
    '            _cr.FSDID = FSDID 
    '        End If
    '        Return _cr
    '    End Get
    '    Set(value As CR)
    '        _cr = value
    '    End Set
    'End Property

    Private _crList As List(Of CR)
    Public Property CurrentCRList As List(Of CR)
        Get
            If (_crList Is Nothing) Then
                If (FSDID > 0) Then
                    Dim cr = New CR
                    cr.LoadDataSource("FSDID", FSDID)
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
        TableName = "FSD"
        KeyField = "FSDID"
    End Sub
#End Region


    Public Overrides Sub DBInsertUpdate()

        Dim isnew = FSDID <= 0
        MyBase.DBInsertUpdate()

        If (isnew) Then
            Dim crList = CurrentCRList ' CurrentCR.DataSource.ToList(Of CR)()
            For Each CR In crList
                CR.LastUpdatedBy = CreatedBy
                CR.FSDID = FSDID
                CR.DBInsertUpdate()
            Next

            CurrentFiles.DBInsertUpdateTable(DataEnums.DocType.FSD, FSDID, CreatedBy)
            
        End If
    End Sub

    Public Function GetDataSet() As DataSet
        '1 Load Data Table
        '1.1 FSD
        LoadDataSource()
        Dim mater As DataTable = DataSource
        '2.2 CR
        Dim cr As New CR
        cr.LoadDataSource(KeyField, -99)
        Dim detail1 As DataTable = cr.DataSource

        '2.3 Files
        Dim file As New File
        file.LoadDataSourceByReferenceID(DataEnums.DocType.FSD, -99)
        Dim detail2 As DataTable = file.DataSource

        '2 Create Dataset
        Dim ds As New DataSet
        ds.Tables.Add(mater)
        ds.Tables.Add(detail1)
        ds.Tables.Add(detail2)
          

        'Set up a master-detail relationship between the DataTables 
        Dim keyColumn As DataColumn = mater.Columns(KeyField)
        Dim foreignKeyColumn As DataColumn = detail1.Columns(KeyField)
        Dim foreignKeyColumn2 As DataColumn = detail2.Columns("ReferenceID")
         
        ds.Relations.Add("FSD_CR", keyColumn, foreignKeyColumn)
        ds.Relations.Add("FSD_File", keyColumn, foreignKeyColumn2)

        Return ds
    End Function
End Class
     
 