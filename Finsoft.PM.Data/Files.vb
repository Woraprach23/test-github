Public Class File
    Inherits MasterFile


    Public Property FileID As Integer
    Public Property ReferenceID As Integer
    Public Property ReferenceTypeID As Integer
    Public Property DocTypeID As Integer
    Public Property FileName As String
    Public Property ContentType As String
    Public Property FileData As Byte()
    Public Property Extension As String
    Public Property FileSize As Integer


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
        TableName = "Files"
        KeyField = "FileID"
    End Sub

    Public Overrides Function ValidateData() As Integer

        Dim config = ConfigService.GetConfig(DataEnums.ConfigGroup.FileConfig, DataEnums.FileConfig.AttachFileMaxSize)
        If (config IsNot Nothing) Then
            Dim maxFileSize = CInt(config.ConfigDisplayText) * 1024
            If (FileSize > maxFilesize) Then
                Return CInt(DataEnums.MessageCode.M0016)
            End If
        End If

        Return 0
    End Function
#End Region

    Public Sub LoadDataSourceByReferenceID(ByVal p_refTypeID As Integer, ByVal p_refID As Integer)
        Dim dic As New Dictionary(Of String, Object)
        dic.Add("ReferenceTypeID", p_refTypeID)
        dic.Add("ReferenceID", p_refID) 
        LoadDataSource(dic)
    End Sub

    'Public Sub LoadDataSourceByReferenceID(ByVal p_refTypeID As Integer, ByVal p_refID As Integer, ByVal p_docType As Integer)
    '    Dim dic As New Dictionary(Of String, Object)
    '    dic.Add("ReferenceTypeID", p_refTypeID)
    '    dic.Add("ReferenceID", p_refID)
    '    dic.Add("DocTypeID", p_docType)
    '    LoadDataSource(dic)
    'End Sub

    Public Sub DBInsertUpdateTable(ByVal p_refType As Integer, ByVal p_refID As Integer, ByVal p_userID As Integer)
        Dim fileList = DataSource.ToList(Of File)()
        For Each file In fileList
            file.ReferenceID = p_refID
            file.ReferenceTypeID = p_refType
            file.CreatedBy = p_userID
            file.DBInsertUpdate()
        Next
    End Sub
End Class
