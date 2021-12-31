Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Xml

Public MustInherit Class MasterFile
    Implements System.ComponentModel.INotifyPropertyChanged

#Region "Event"
    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
#End Region
     
    ''' <summary>
    ''' Common variable for all Master file class
    ''' </summary>
    ''' 
#Region "Protected"
    Protected pt_PrimaryKeyID As Integer
    Protected _isChanged As Boolean
    Protected _isLoad As Boolean
    Protected _isNew As Boolean = False

    'Protected Const c_ERROR_STRING_DUPLICATED_VALUE As String = "{0} is duplicated."
    'Protected Const c_ERROR_STRING_EMPTY As String = "{0} cannot be empty."
    'Protected Const c_ERROR_PLEASE_SELECT As String = "Please select {0}."
    'Public Property Status As Integer

    Protected _keyField As String
    Protected _tableName As String
    Protected _parentField As String

    Protected _primaryKeyID As Integer = 0
    Protected _parentID As Object = 0
    Protected _DB_OUTPUT_VALUE As Integer = 0

    Protected _errorField As String
    Protected _errorText As String
    Protected _dataSource As DataTable
    Protected _CreatedBy As Integer
    Protected _CreatedDate As DateTime
    Protected _lastUpdatedBy As Integer
    Protected _lastUpdatedLogID As Integer
    Protected _lastUpdated As DateTime

#End Region

#Region "Property"

    Public Property IsEditable As Boolean

    Public Property PrimaryKeyID As Integer
        Get
            Return _primaryKeyID
        End Get
        Set(ByVal value As Integer)
            _primaryKeyID = value
            SetKeyValue(_keyField, _primaryKeyID)
        End Set
    End Property

    Public Property ParentID As Object
        Get
            Return _parentID
        End Get
        Set(ByVal value As Object)
            _parentID = value
            If Not String.IsNullOrEmpty(_parentField) Then
                SetKeyValue(_parentField, _parentID)
            End If
        End Set
    End Property

    Public Property DB_OUTPUT_VALUE As Integer
        Get
            Return _DB_OUTPUT_VALUE
        End Get
        Set(ByVal value As Integer)
            _DB_OUTPUT_VALUE = value
        End Set
    End Property

    Public Property TableName As String
        Get
            Return _tableName
        End Get
        Set(ByVal value As String)
            _tableName = value
        End Set
    End Property

    Public Property KeyField As String
        Get
            Return _keyField
        End Get
        Set(ByVal value As String)
            _keyField = value
        End Set
    End Property

    Public Property ParentField As String
        Get
            Return _parentField
        End Get
        Set(ByVal value As String)
            _parentField = value
        End Set
    End Property

    Public Property ErrorField As String
        Get
            Return _errorField
        End Get
        Set(ByVal value As String)
            _errorField = value
        End Set
    End Property

    Public Property LastUpdatedBy As Integer
        Get
            Return _lastUpdatedBy
        End Get
        Set(value As Integer)
            If (value <> _lastUpdatedBy) Then
                _lastUpdatedBy = value
            End If
        End Set
    End Property

    Public Property LastUpdatedLogID As Integer
        Get
            Return _lastUpdatedLogID
        End Get
        Set(value As Integer)
            If (value <> _lastUpdatedLogID) Then
                _lastUpdatedLogID = value
            End If
        End Set
    End Property

    Public Property LastUpdated As DateTime
        Get
            Return _lastUpdated
        End Get
        Set(value As DateTime)
            If (value <> _lastUpdated) Then
                _lastUpdated = value
            End If
        End Set
    End Property

    Public Property CreatedBy As Integer
        Get
            Return _CreatedBy
        End Get
        Set(value As Integer)
            If (value <> _CreatedBy) Then
                _CreatedBy = value
            End If
        End Set
    End Property

    Public Property CreatedDate As DateTime
        Get
            Return _CreatedDate
        End Get
        Set(value As DateTime)
            If (value <> _CreatedDate) Then
                _CreatedDate = value
            End If
        End Set
    End Property

    Public Property DataSource As DataTable
        Get
            Return _dataSource
        End Get
        Set(value As DataTable)
            _dataSource = value
        End Set
    End Property

    Public Property IsPropertiesChanged As Boolean
        Get
            Return _isChanged
        End Get
        Set(value As Boolean)
            _isChanged = value
        End Set
    End Property

    Protected _isUseListProceToLoad As Boolean = True
    'Public Property CreatedLogID As Integer
     
#End Region

#Region "Construction"
    Public Sub New()
        SetDefault()
        SetMasterProperties()
        _isChanged = False
        _isLoad = True
    End Sub

    Public Sub New(ByVal p_Key As Integer)
        PrimaryKeyID = p_Key
        SetMasterProperties()
        If (p_Key > 0) Then
            LoadData(KeyField, p_Key)
        Else
            SetDefault()
        End If

        _isChanged = False
        _isLoad = True
    End Sub
#End Region

#Region "NotifyPropertyChanged"
    Protected Sub NotifyPropertyChanged(propertyName As String)
        _isChanged = True
        RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
    End Sub

    Public Function GetProperties() As PropertyInfo()
        Return Me.GetType().GetProperties()
    End Function
#End Region

#Region "DB Load"
    Public Overridable Sub LoadData(ByVal p_KeyID As Object)
        If (p_KeyID > 0) Then
            LoadData(KeyField, p_KeyID)
        End If
    End Sub

    Public Overridable Sub LoadData(ByVal p_Field As String, ByVal p_Value As Object)
        Dim dic As New Dictionary(Of String, Object)
        dic.Add(p_Field, p_Value)
        Me.LoadData(dic)
    End Sub

    Public Overridable Sub LoadData(ByVal p_Field1 As String, ByVal p_Value1 As Object, ByVal p_Field2 As String, ByVal p_Value2 As Object)
        Dim dic As New Dictionary(Of String, Object)
        dic.Add(p_Field1, p_Value1)
        dic.Add(p_Field2, p_Value2)
        Me.LoadData(dic)
    End Sub

    Public Overridable Sub LoadData(ByVal p_orderDic As System.Collections.Generic.Dictionary(Of String, Object))
        Dim conn As New SqlConnection(DBProc.DBConnectionString)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader = Nothing

        If (_isUseListProceToLoad) Then
            cmd.CommandText = String.Format("dbo.{0}_List", _tableName)
        Else
            cmd.CommandText = String.Format("dbo.{0}_Load", _tableName)
        End If

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        cmd.CommandTimeout = 3000
        cmd.Parameters.Clear()

        For Each key As String In p_orderDic.Keys
            cmd.Parameters.AddWithValue("@" & key, p_orderDic(key))
        Next

        conn.Open()
        reader = cmd.ExecuteReader
        reader.Read()

        If (reader.HasRows) Then
            reader.ToProperties(Me)
        Else
            SetDefault()
        End If
        reader.Close()
        conn.Close()

        _isChanged = False
        _isLoad = True
    End Sub
    Public Overridable Sub LoadData(ByVal p_con As SqlClient.SqlConnection, ByVal p_tran As SqlClient.SqlTransaction, ByVal p_Value As Object, ByVal p_FieldName As String)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader = Nothing

        cmd.CommandText = String.Format("dbo.{0}_Load", _tableName)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = p_con
        cmd.Transaction = p_tran
        cmd.CommandTimeout = 3000
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@" & p_FieldName, p_Value)


        reader = cmd.ExecuteReader
        reader.Read()

        If (reader.HasRows) Then
            reader.ToProperties(Me)
        Else
            SetDefault()
        End If
        reader.Close()
        cmd.Dispose()

        _isChanged = False
        _isLoad = True
    End Sub

    Public Overridable Sub LoadData(ByVal p_con As SqlClient.SqlConnection, ByVal p_tran As SqlClient.SqlTransaction, ByVal p_Value As Object)
        LoadData(p_con, p_tran, p_Value, KeyField)
    End Sub

    Public Overridable Sub LoadDataFromMaster(ByVal p_KeyID As Object)
        Dim conn As New SqlConnection(DBProc.DBConnectionString)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader = Nothing

        cmd.CommandText = String.Format("SELECT TOP 1 * FROM dbo.{0} WITH (NOLOCK) WHERE {1} = {2}", TableName, KeyField, p_KeyID)
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandTimeout = 3000
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@" & KeyField, p_KeyID)
        conn.Open()
        reader = cmd.ExecuteReader
        reader.Read()

        If (reader.HasRows) Then
            reader.ToProperties(Me)
        Else
            SetDefault()
        End If

        reader.Close()
        cmd.Dispose()

    End Sub

    Public Overridable Sub LoadDataFromMaster(ByVal p_con As SqlConnection, ByVal p_tran As SqlTransaction, ByVal p_KeyID As Object)
        'Dim conn As New SqlConnection(DBProc.DBConnectionString)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader = Nothing

        cmd.CommandText = String.Format("SELECT TOP 1 * FROM dbo.{0} WITH (NOLOCK) WHERE {1} = {2}", TableName, KeyField, p_KeyID)
        cmd.CommandType = CommandType.Text
        cmd.Connection = p_con
        cmd.Transaction = p_tran
        cmd.CommandTimeout = 3000
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@" & KeyField, p_KeyID)
        'conn.Open()
        reader = cmd.ExecuteReader
        reader.Read()

        If (reader.HasRows) Then
            reader.ToProperties(Me)
        Else
            SetDefault()
        End If

        reader.Close()
        cmd.Dispose()

    End Sub
#End Region

#Region "DB Update/Insert/Delete"

    Public Overridable Sub DBUpdate()

        Dim conn As SqlConnection = Nothing
        Dim tran As SqlTransaction = Nothing
        Dim cmd As SqlCommand = Nothing
        Try
            conn = New SqlConnection(DBProc.DBConnectionString)
            conn.Open()
            tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted)

            cmd = New SqlCommand

            cmd.Connection = conn
            cmd.Transaction = tran
            cmd.CommandText = String.Format("dbo.{0}_InsertUpdate", _tableName)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()

            SetParameters(cmd)

            cmd.ExecuteNonQuery()

            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Public Overridable Sub DBInsertUpdate()
        Dim conn As SqlConnection = Nothing
        Dim tran As SqlTransaction = Nothing

        Try
            conn = New SqlConnection(DBProc.DBConnectionString)
            conn.Open()
            tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted)

            DBInsertUpdate(conn, tran)

            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            Throw ex
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Public Overridable Sub DBInsertUpdate(ByRef p_conn As SqlConnection, ByRef p_tran As SqlTransaction)
        Dim cmd As SqlCommand = Nothing
        cmd = New SqlCommand

        cmd.Connection = p_conn
        cmd.Transaction = p_tran
        cmd.CommandText = String.Format("dbo.{0}_InsertUpdate", _tableName)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
        cmd.CommandTimeout = 600

        SetParameters(cmd)

        cmd.ExecuteNonQuery()

        cmd.Dispose()

        If Not String.IsNullOrEmpty(KeyField) Then
            If (Not cmd.Parameters("@" & _keyField).Value Is DBNull.Value) Then
                PrimaryKeyID = CInt(cmd.Parameters("@" & _keyField).Value)
            End If
        End If

    End Sub

    'Public Sub DBDelete()
    '    DBDelete(KeyField, PrimaryKeyID)
    'End Sub

    Public Sub DBDelete(ByVal p_id As Integer)
        DBDelete(KeyField, p_id)
    End Sub

    Public Sub DBDelete(ByVal p_keyField As String, ByVal p_keyValue As Object)

        Dim conn As SqlConnection = Nothing
        Dim tran As SqlTransaction = Nothing

        Try
            conn = New SqlConnection(DBProc.DBConnectionString)
            conn.Open()
            tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted)

            DBDelete(conn, tran, p_keyField, p_keyValue)

            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            Throw ex
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub


    Public Sub DBDelete(ByRef p_conn As SqlConnection, ByRef p_tran As SqlTransaction, ByVal p_keyValue As Object)
        DBDelete(p_conn, p_tran, KeyField, p_keyValue)
    End Sub
    Public Sub DBDelete(ByRef p_conn As SqlConnection, ByRef p_tran As SqlTransaction, ByVal p_keyField As String, ByVal p_keyValue As Object)
        Dim Result As Boolean = False

        Dim cmd As New SqlCommand

        cmd.Connection = p_conn
        cmd.Transaction = p_tran
        cmd.CommandText = String.Format("dbo.{0}_Delete", _tableName)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@" & p_keyField, p_keyValue)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        

    End Sub

#End Region

#Region "Public Method"

    Public Function IsDuplicatedValue(ByVal p_FieldName As String, ByVal p_Value As Object, ByVal p_KeyValue As Integer) As Boolean
        If (String.IsNullOrEmpty(p_Value)) Then Return False
        Dim format As String = "{0} = {1} AND {2} <> {3}"

        Dim str As String = String.Format(format, p_FieldName, DataConverter.GetSQLString(p_Value), KeyField, DataConverter.GetSQLString(p_KeyValue))

        Dim str2 As String = String.Format("SELECT top 1 {0} FROM dbo.{1} WITH (NOLOCK) WHERE {2}", KeyField, TableName, str)
        If (Not String.IsNullOrEmpty(ParentField) And ParentID > 0) Then
            str2 += String.Format(" AND {0} = {1}", ParentField, ParentID)
        End If

        Dim obj As Object = DBProc.ExecuteScalar(str2)

        If (obj IsNot Nothing) Then
            Return True
        End If
        Return False
    End Function

    'Public Function IsDuplicatedValue(ByVal p_FieldName As String, ByVal p_Value As Object, ByVal p_Field2 As String, ByVal p_Value2 As Object, ByVal p_KeyValue As Integer) As Boolean
    '    If (String.IsNullOrEmpty(p_Value)) Then Return False

    '    Dim format As String = "{0} = {1} AND {2} = {3} AND {4} <> {5}"

    '    Dim str As String = String.Format(format, p_FieldName, DataConverter.GetSQLString(p_Value), p_Field2, DataConverter.GetSQLString(p_Value2), KeyField, DataConverter.GetSQLString(p_KeyValue))
    '    Dim obj As Object = DBProc.ExecuteScalarByProc_GetValueByConditionString(TableName, KeyField, str)
    '    If (obj IsNot Nothing) Then
    '        Return True
    '    End If
    '    Return False
    'End Function

    'Public Function IsDuplicatedValue(ByVal p_FieldName As String, ByVal p_Value As Object, ByVal p_Field1 As String, ByVal p_Value1 As Object, ByVal p_Field2 As String, ByVal p_Value2 As Object, ByVal p_KeyValue As Integer) As Boolean
    '    If (String.IsNullOrEmpty(p_Value1)) Then Return False

    '    Dim format As String = "{0} = {1} AND {2} = {3} AND {4}={5} AND {6} <> {7}"

    '    Dim str As String = String.Format(format, p_FieldName, DataConverter.GetSQLString(p_Value), p_Field1, DataConverter.GetSQLString(p_Value1), p_Field2, DataConverter.GetSQLString(p_Value2), KeyField, DataConverter.GetSQLString(p_KeyValue))
    '    Dim obj As Object = DBProc.ExecuteScalarByProc_GetValueByConditionString(TableName, KeyField, str)
    '    If (obj IsNot Nothing) Then
    '        Return True
    '    End If
    '    Return False
    'End Function

    Public Function TableIsDuplicatedValue(ByVal p_FieldName As String, ByVal p_Value As Object, ByVal p_KeyValue As Integer) As Boolean
        If (String.IsNullOrEmpty(p_Value)) Then Return False
        Dim format As String = "{0} = {1} AND {2} <> {3}"

        Dim str As String = String.Format(format, p_FieldName, DataConverter.GetSQLString(p_Value), KeyField, DataConverter.GetSQLString(p_KeyValue))

        If (Not String.IsNullOrEmpty(ParentField) And ParentID <> 0) Then
            str += String.Format(" AND {0} = {1}", ParentField, ParentID)
        End If

        Return TableIsDuplicatedValue(str)
    End Function

    Public Function TableIsDuplicatedValue(ByVal p_FieldName As String, ByVal p_Value As Object, ByVal p_Field2 As String, ByVal p_Value2 As Object, ByVal p_KeyValue As Integer) As Boolean
        If (String.IsNullOrEmpty(p_Value)) Then Return False

        Dim format As String = "{0} = {1} AND {2} = {3} AND {4} <> {5}"

        Dim str As String = String.Format(format, p_FieldName, DataConverter.GetSQLString(p_Value), p_Field2, DataConverter.GetSQLString(p_Value2), KeyField, DataConverter.GetSQLString(p_KeyValue))
        Return TableIsDuplicatedValue(str)
    End Function

    Public Function TableIsDuplicatedValue(ByVal p_FieldName As String, ByVal p_Value As Object, ByVal p_Field1 As String, ByVal p_Value1 As Object, ByVal p_Field2 As String, ByVal p_Value2 As Object, ByVal p_KeyValue As Integer) As Boolean
        If (String.IsNullOrEmpty(p_Value1)) Then Return False

        Dim format As String = "{0} = {1} AND {2} = {3} AND {4}={5} AND {6} <> {7}"
        Dim str As String = String.Format(format, p_FieldName, DataConverter.GetSQLString(p_Value), p_Field1, DataConverter.GetSQLString(p_Value1), p_Field2, DataConverter.GetSQLString(p_Value2), KeyField, DataConverter.GetSQLString(p_KeyValue))
        Return TableIsDuplicatedValue(str)
    End Function

    Private Function TableIsDuplicatedValue(ByVal p_strFilter As String) As Boolean
        Dim duplicatedRow() As DataRow = DataSource.Select(p_strFilter)
        Return duplicatedRow.Length > 0
    End Function
#End Region

    ''' <summary>
    ''' Copy Data from SqlDataReader to Properties
    ''' </summary>
    Protected Sub Mapping(ByRef p_sdr As SqlDataReader)
        p_sdr.ToProperties(Me)
    End Sub

    ''' <summary>
    ''' Copy Data from DataRow to Properties
    ''' </summary>
    Public Sub Mapping(ByRef p_sdr As DataRow)
        p_sdr.ToProperties(Me)
    End Sub

    ''' <summary>
    ''' Copy Data from Properties to DataRow
    ''' </summary>
    Public Sub LoadDataClassToRow(ByRef p_DaraRow As DataRow)
        p_DaraRow.ToCollection(Me)
    End Sub

    ''' <summary>
    ''' SetParameters  to SqlCommand from Properties
    ''' </summary>
    Protected Overridable Sub SetParameters(ByRef p_cmd As SqlCommand)
        p_cmd.SetParameters(Me)
    End Sub

    ' <summary>
    ' SetValue To Property By FieldName and Value
    ' </summary>
    Public Sub SetValue(ByVal p_field As String, ByVal p_value As Object)
        SetKeyValue(p_field, p_value)
    End Sub

    Public Sub CopyValue(ByVal p_source As Object)
        Me.CopyValues(p_source, Nothing)
    End Sub

    ' <summary>
    ' SetValue To Property By FieldName and Value
    ' </summary>
    Public Sub CopyValue(ByVal p_source As MasterFile)
        Me.CopyValues(p_source, Nothing)
    End Sub

    Public Sub CopyValue(ByVal p_source As MasterFile, ByVal strReservedFieldName As String())
        Me.CopyValues(p_source, strReservedFieldName)
    End Sub



#Region "Must Inherit Method"
    Protected MustOverride Sub SetMasterProperties()
#End Region
     
    Public Overridable Function ValidateData() As Integer
        Return 0
    End Function

    Public Overridable Function ValidateDelete() As Integer
        Return 0
    End Function

    Protected Overridable Sub SetDefault()
        Dim pClass As List(Of Reflection.PropertyInfo) = Me.GetProperties().ToList()
        For Each propInfo As Reflection.PropertyInfo In pClass
            If propInfo.CanWrite And propInfo.MemberType = MemberTypes.Property And propInfo.Name.IndexOf("Current") < 0 And propInfo.Name <> "TableName" And propInfo.Name <> "KeyField" And propInfo.Name <> "ParentField" And propInfo.Name <> "DataSource" Then
                propInfo.SetValue(Me, Nothing, Nothing)
            End If
        Next
    End Sub

    Public Shared Function cvToSQLString(ByVal p_propValue As Object) As String
        If (TypeOf (p_propValue) Is String) Then
            If p_propValue Is Nothing Then
                Return "''"
            ElseIf p_propValue.Contains("'") Then
                p_propValue = p_propValue.Replace("'", "''")
            End If
            Return "'" & p_propValue.Trim() & "'"
        ElseIf (TypeOf (p_propValue) Is Integer OrElse TypeOf (p_propValue) Is Decimal) Then
            If (p_propValue Is Nothing) Then
                Return "0"
            End If
            Return p_propValue.ToString
        ElseIf (TypeOf (p_propValue) Is Date) Then
            Dim date1 As Date = CDate(p_propValue) 
            Return "'" & date1.ToString("yyyy-MM-dd") & "'"

        ElseIf (TypeOf (p_propValue) Is Boolean) Then
            Return "'" & p_propValue.ToString & "'"
        End If
        Return p_propValue.ToString
    End Function

   
End Class
