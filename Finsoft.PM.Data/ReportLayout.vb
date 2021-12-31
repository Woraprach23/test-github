Public Class ReportLayout
    Inherits MasterFile

    Public Property ReportLayoutID As Integer
    Public Property ReportCode As String
    Public Property ReportName As String
    Public Property ReportTypeID As Integer?
    Public Property XMLString As String
    Public Property Layout As Byte()
    Public Property Remark As String
    Public Property IsActive As Boolean

#Region "Contructor"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal p_ID As Integer)
        MyBase.New(p_ID)
    End Sub
#End Region


    Protected Overrides Sub SetMasterProperties()
        TableName = "ReportLayout"
        KeyField = "ReportLayoutID"
        ParentField = ""
    End Sub

    Public Function GetReportDataReport() As DataTable
        If (String.IsNullOrEmpty(XMLString)) Then
            Return Nothing
        End If
        Dim dataSet = New DataSet
        dataSet.ReadXml(New System.IO.StringReader(XMLString))
        Return dataSet.Tables(0)
    End Function


End Class
