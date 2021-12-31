Imports System.Data
Imports System.Collections
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class DBProc

    Private Shared _dbsource As String
    Private Shared _dbname As String
    Private Shared _dbUser As String
    Private Shared _dbPassword As String

    'Private Shared _timeOut As Integer
    Public Shared TimeoutConfig As Integer = 40000
     
    Public Shared Function SetConnectionString(ByVal DBServer As String, ByVal DBAuthentication As String, ByVal DBName As String, ByVal DBUsername As String, ByVal DBPassword As String) As Boolean

        Dim ConStr As String = String.Empty
        'Dim TempCon As String = pt_strConnection
        If DBAuthentication = "SQL Authentication" Then
            'ConStr = "metadata=res://*/Connector.URSAModel.csdl|res://*/Connector.URSAModel.ssdl|res://*/Connector.URSAModel.msl;provider=System.Data.SqlClient;provider connection string=""data source=" & DBServer & ";initial catalog=" & DBName & ";persist security info=True;user id=" & DBUsername & ";password=" & DBPassword & ";MultipleActiveResultSets=True;App=EntityFramework"""
            ConStr = "Data Source=" & DBServer & ";Initial Catalog=" & DBName & ";user id=" & DBUsername & ";password=" & DBPassword & ""
        Else
            'ConStr = "metadata=res://*/Connector.URSAModel.csdl|res://*/Connector.URSAModel.ssdl|res://*/Connector.URSAModel.msl;provider=System.Data.SqlClient;provider connection string=""data source=" & DBServer & ";initial catalog=" & DBName & ";integrated security=SSPI;MultipleActiveResultSets=True;Trusted_Connection=Yes;App=EntityFramework"""
            ConStr = "Data Source=" & DBServer & ";Initial Catalog=" & DBName & ";Integrated Security=True"
        End If

        Try
            DBConnection.URSAConnectionString = ConStr
            Return CheckConnection(ConStr) 
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function
     
    Public Shared ReadOnly Property DBConnectionString As String
        Get
            Return DBConnection.MainConnectionString
        End Get
    End Property

    Public Shared Function ServerDate() As DateTime
        Dim datetime As DateTime = Data.DBProc.ExecuteScalar("SELECT GETDATE()")
        Return datetime
    End Function

    Public Shared Function GetDataTableBySql(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Dim conn As SqlConnection = Nothing
        Dim comm As SqlCommand
        Dim da As SqlDataAdapter

        Try
            conn = New SqlConnection(DBConnectionString)
            conn.Open()

            comm = New SqlCommand(sql, conn)
            comm.CommandTimeout = TimeoutConfig
            da = New SqlDataAdapter(comm)

            da.Fill(dt)

        Catch ex As Exception
            Return Nothing
            Throw ex
        Finally
            conn.Close()
            conn.Dispose()
        End Try

        Return dt
    End Function

    Public Shared Function CheckConnection(ByVal dbConn As String) As Boolean
        Dim dt As New DataTable
        Dim conn As SqlConnection = Nothing
        Try
            conn = New SqlConnection(dbConn)
            conn.Open()
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return True
    End Function

    Public Shared Function GetDataByTableName(ByVal p_tableName As String) As DataTable
        Dim strQuery As String = String.Format("SELECT * FROM dbo.{0} WITH (NOLOCK)", p_tableName)
        Return GetDataTableBySql(strQuery)
    End Function

    Public Shared Function GetDataTableByProc(ByVal p_procName As String) As DataTable
        If (p_procName Is Nothing) Then
            Return Nothing
        End If

        Dim conn As SqlConnection = Nothing

        Try
            Dim dt As New DataTable
            conn = New SqlConnection(DBConnectionString)
            Dim cmd As New SqlCommand
 
            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.CommandTimeout = TimeoutConfig
            conn.Open()
            Dim adp As SqlDataAdapter = New SqlDataAdapter(cmd)
            adp.Fill(dt)

            Return dt
        Catch ex As Exception 
            Throw ex
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Function


    Public Shared Function GetDataTableByProc_Params(ByVal p_conn As SqlConnection, ByVal p_trann As SqlTransaction, ByVal p_procName As String, ByVal p_params() As SqlParameter, ByVal p_timeout As Integer) As DataTable

        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Try
            Dim dt As New DataTable

            If p_conn Is Nothing Then
                p_conn = New SqlConnection(DBConnection.MainConnectionString)
            End If

            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = p_conn

            If p_trann IsNot Nothing Then
                cmd.Transaction = p_trann
            End If


            If p_timeout >= 0 Then
                cmd.CommandTimeout = p_timeout
            Else
                cmd.CommandTimeout = TimeoutConfig
            End If

            cmd.Parameters.Clear()
            cmd.Parameters.AddRange(p_params)

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            Return Nothing
            Throw ex
        Finally
            da.Dispose()
            cmd.Dispose()
        End Try
    End Function

    Public Shared Function GetDataTableByProc_Params(ByVal p_procName As String, ByVal p_params() As SqlParameter) As DataTable
        Return GetDataTableByProc_Params(Nothing, Nothing, p_procName, p_params, 0)
    End Function

    Public Shared Function GetDataTableByProc_Params(ByVal p_procName As String, ByVal p_dict As Dictionary(Of String, Object)) As DataTable
        Dim sqlparams(p_dict.Count - 1) As SqlParameter
        Dim index As Integer = 0
        For Each pair As KeyValuePair(Of String, Object) In p_dict
            Dim param As New SqlParameter("@" + pair.Key, pair.Value)
            sqlparams(index) = param
            index += 1
        Next

        Return GetDataTableByProc_Params(Nothing, Nothing, p_procName, sqlparams, 600)
    End Function

    Public Shared Function GetDataTableByProc_Params(ByVal p_procName As String, ByVal p_dict As Dictionary(Of String, Object), ByVal p_timeout As Integer) As DataTable
        Dim sqlparams(p_dict.Count - 1) As SqlParameter
        Dim index As Integer = 0
        For Each pair As KeyValuePair(Of String, Object) In p_dict
            Dim param As New SqlParameter("@" + pair.Key, pair.Value)
            sqlparams(index) = param
            index += 1
        Next

        Return GetDataTableByProc_Params(Nothing, Nothing, p_procName, sqlparams, 0)
    End Function

    Public Shared Function GetDataTableByProc_Params(ByVal p_procName As String, ByVal p_paramName As String, ByVal p_Value As Object, ByVal p_dataType As System.Data.SqlDbType, ByVal p_Size As Int32) As DataTable
        Dim sqlparams(0) As SqlParameter
        Dim param As SqlParameter
        If (p_Size <> Nothing) Then
            param = New SqlParameter(p_paramName, p_dataType, p_Size)
        Else
            param = New SqlParameter(p_paramName, p_dataType)
        End If
        param.Value = p_Value
        sqlparams(0) = param
        Return GetDataTableByProc_Params(p_procName, sqlparams)
    End Function

    Public Shared Function ExecuteScalarByProc_Params(ByVal p_procName As String, ByVal p_paramName As String, ByVal p_Value As Object, ByVal p_dataType As System.Data.SqlDbType, ByVal p_Size As Int32) As Object
        Dim conn As SqlConnection = Nothing
        Dim cmd As New SqlCommand
        Try
            conn = New SqlConnection(DBConnectionString)

            Dim objResult As Object = Nothing

            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.CommandTimeout = TimeoutConfig
            cmd.Parameters.Add(p_paramName, p_dataType, p_Size)
            cmd.Parameters(0).Value = p_Value

            conn.Open()
            objResult = cmd.ExecuteScalar()

            conn.Close()
            cmd.Dispose()
            conn.Dispose()

            Return objResult
        Catch ex As Exception
            Return Nothing
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
    End Function

    ''
    Public Shared Function ExecuteScalarByProc_Params(ByVal p_procName As String, ByVal p_params() As SqlParameter) As Object
        Return ExecuteScalarByProc_Params(p_procName, p_params, Nothing)
    End Function

    Public Shared Function ExecuteScalarByProc_Params(ByVal p_procName As String, ByVal p_params() As SqlParameter, ByVal p_timeout As Integer?) As Object
        Dim conn As SqlConnection = Nothing
        Dim cmd As New SqlCommand
        Try

            conn = New SqlConnection(DBConnectionString)

            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            cmd.Parameters.AddRange(p_params)

            If (p_timeout.HasValue) Then
                'The time in seconds to wait for the command to execute. The default is 30 seconds.
                cmd.CommandTimeout = p_timeout
            Else
                cmd.CommandTimeout = TimeoutConfig
            End If

            conn.Open()
            Dim objResult As Object = cmd.ExecuteScalar()

            Return objResult
        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
            cmd.Dispose()
            conn.Dispose()
        End Try
    End Function

    Public Shared Function ExecuteScalarByProc_Params(ByVal p_procName As String, ByVal p_dict As Dictionary(Of String, Object), ByVal p_timeout As Integer?) As Object
        Dim sqlparams(p_dict.Count - 1) As SqlParameter
        Dim index As Integer = 0
        For Each pair As KeyValuePair(Of String, Object) In p_dict
            Dim param As New SqlParameter("@" + pair.Key, pair.Value)
            sqlparams(index) = param
            index += 1
        Next

        Return ExecuteScalarByProc_Params(p_procName, sqlparams, p_timeout)
    End Function

    Public Shared Function ExecuteScalarByProc_Params(ByVal p_procName As String, ByVal p_dict As Dictionary(Of String, Object)) As Object
        Return ExecuteScalarByProc_Params(p_procName, p_dict, Nothing)
    End Function

    Public Shared Function ExecuteScalarByProc_Params(ByVal p_procName As String, ByVal p_dict As Dictionary(Of String, Object), ByVal p_conn As SqlClient.SqlConnection, ByVal p_tran As SqlClient.SqlTransaction) As Object
        Dim sqlparams(p_dict.Count - 1) As SqlParameter
        Dim index As Integer = 0
        For Each pair As KeyValuePair(Of String, Object) In p_dict
            Dim param As New SqlParameter("@" + pair.Key, pair.Value)
            sqlparams(index) = param
            index += 1
        Next
        Dim isNewConnection As Boolean = False
        Dim hasTranScrop As Boolean = False
        Dim cmd As New SqlCommand
        Try
            If (p_conn Is Nothing) Then
                p_conn = New SqlConnection(DBConnectionString)
                p_conn.Open()
                isNewConnection = True
            End If

            cmd.CommandTimeout = TimeoutConfig
            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = p_conn

            If (p_tran IsNot Nothing) Then
                cmd.Transaction = p_tran
                hasTranScrop = True
            End If


            cmd.Parameters.AddRange(sqlparams)
            Dim objResult As Object = cmd.ExecuteScalar()
            Return objResult
        Catch ex As Exception
            Throw ex
        Finally
            ' conn.Close()
            If (isNewConnection) Then
                p_conn.Close()
            End If
            cmd.Dispose()
            If (isNewConnection) Then
                p_conn.Dispose()
            End If

        End Try
    End Function

    Public Shared Function ExecuteScalarByProc_NoParams(ByVal p_procName As String) As Object
        Dim conn As SqlConnection = Nothing
        Dim cmd As New SqlCommand
        Try
            conn = New SqlConnection(DBConnectionString)


            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn

            conn.Open()
            Dim objResult As Object = cmd.ExecuteScalar()


            Return objResult
        Catch ex As Exception
            Return Nothing
            Throw ex
        Finally
            conn.Close()
            cmd.Dispose()
            conn.Dispose()

        End Try
    End Function


    'Public Shared Sub ExecuteNonQuery(ByVal p_procName As String, ByVal p_dict As Dictionary(Of String, Object))

    'End Sub
    Public Shared Sub ExecuteNonQuery(ByVal p_procName As String, ByVal p_dict As Dictionary(Of String, Object))
        Dim sqlparams(p_dict.Count - 1) As SqlParameter
        Dim index As Integer = 0
        For Each pair As KeyValuePair(Of String, Object) In p_dict
            Dim param As New SqlParameter("@" + pair.Key, pair.Value)
            sqlparams(index) = param
            index += 1
        Next

        ExecuteNonQuery(p_procName, sqlparams)
    End Sub

    Public Shared Sub ExecuteNonQuery(ByVal p_procName As String, ByVal p_params() As SqlParameter)
        Dim conn As SqlConnection = Nothing
        Dim cmd As New SqlCommand
        Try
            conn = New SqlConnection(DBConnectionString)
            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.Parameters.Clear()
            cmd.Parameters.AddRange(p_params)
            cmd.CommandTimeout = TimeoutConfig
            conn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
            cmd.Dispose()
            conn.Dispose()
        End Try
    End Sub

    Public Shared Sub ExecuteNonQuery(ByVal p_procName As String, ByVal p_dict As Dictionary(Of String, Object), ByVal p_isUseTransaction As Boolean, ByVal p_timeout As Integer)
        Dim sqlparams(p_dict.Count - 1) As SqlParameter
        Dim index As Integer = 0
        For Each pair As KeyValuePair(Of String, Object) In p_dict
            Dim param As New SqlParameter("@" + pair.Key, pair.Value)
            sqlparams(index) = param
            index += 1
        Next
        ExecuteNonQuery(p_procName, sqlparams, p_isUseTransaction, p_timeout)
    End Sub

    Public Shared Sub ExecuteNonQuery(ByVal p_procName As String, ByVal p_params() As SqlParameter, ByVal p_isUseTransaction As Boolean, ByVal p_timeout As Integer)
        Dim conn As SqlConnection = Nothing
        Dim cmd As New SqlCommand
        Dim tran As SqlTransaction = Nothing
        Try
            conn = New SqlConnection(DBConnectionString)
            conn.Open()
            If (p_isUseTransaction) Then
                tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted)
            End If

            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = conn
            cmd.Transaction = tran

            If p_timeout >= 0 Then
                cmd.CommandTimeout = p_timeout
            Else
                cmd.CommandTimeout = TimeoutConfig
            End If

            cmd.Parameters.Clear()
            cmd.Parameters.AddRange(p_params)

            cmd.ExecuteNonQuery()

            If (p_isUseTransaction) Then
                tran.Commit()
            End If

        Catch ex As Exception
            If (p_isUseTransaction) Then
                tran.Rollback()
            End If

            Throw ex
        Finally
            conn.Close()
            cmd.Dispose()
            conn.Dispose()
        End Try
    End Sub

    Public Shared Sub ExecuteNonQuery(ByVal p_procName As String, ByVal p_params() As SqlParameter, ByVal p_conn As SqlClient.SqlConnection, ByVal p_tran As SqlClient.SqlTransaction, ByVal p_timeout As Integer?)
        ' Dim conn As SqlConnection = Nothing
        Dim newConnection As Boolean
        Dim cmd As New SqlCommand
        Try
            If (p_conn Is Nothing) Then
                p_conn = New SqlConnection(DBConnectionString)
                p_conn.Open()
                newConnection = True
            End If

            If (p_timeout.HasValue) Then
                cmd.CommandTimeout = p_timeout.Value
            Else
                cmd.CommandTimeout = TimeoutConfig
            End If

            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = p_conn
            cmd.Transaction = p_tran

            cmd.Parameters.AddRange(p_params)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            If (newConnection) Then
                p_conn.Close()
            End If
            '  
            cmd.Dispose()
            If (newConnection) Then
                p_conn.Dispose()
            End If
        End Try
    End Sub

    Public Shared Sub ExecuteNonQuery(ByVal p_procName As String, ByVal p_dict As Dictionary(Of String, Object), ByVal p_conn As SqlClient.SqlConnection, ByVal p_tran As SqlClient.SqlTransaction, ByVal p_timeout As Integer?)
        Dim sqlparams(p_dict.Count - 1) As SqlParameter
        Dim index As Integer = 0
        For Each pair As KeyValuePair(Of String, Object) In p_dict
            Dim param As New SqlParameter("@" + pair.Key, pair.Value)
            sqlparams(index) = param
            index += 1
        Next
        ExecuteNonQuery(p_procName, sqlparams, p_conn, p_tran, p_timeout)
    End Sub

#Region "Query string"


    ''' <summary>
    ''' Execute sql command which return dataset or data table
    ''' </summary>
    ''' TODO: Add Exception handling !!?? check if no data then dataset is nothing, null or empty ?
    Public Shared Function ExecuteDataset(ByVal strSql As String) As DataSet
        'Dim conn1 As New SqlConnection(pt_strConnection)
        Dim da1 As New SqlDataAdapter(strSql, DBConnectionString)
        'Dim da1 As New SqlDataAdapter(strSql, conn1)
        Dim ds1 As New DataSet()
        da1.Fill(ds1)
        da1.Dispose()
        da1 = Nothing
        'conn1.Close()
        'conn1.Dispose()
        Return ds1
    End Function

    ''' <summary>
    ''' Execute sql command that doesn't return value
    ''' </summary>
    Protected Shared Sub ExecuteNonQuery(ByVal strSql As String)
        Dim conn1 As New SqlConnection(DBConnectionString)
        Dim cmd1 As New SqlCommand(strSql, conn1)
        conn1.Open()

        cmd1.ExecuteNonQuery()
        conn1.Close()
        cmd1.Dispose()
        conn1.Dispose()
    End Sub

    '2014-05-06 minmin
    Protected Shared Sub ExecuteProcNonQuery(ByVal strProcName As String)
        Dim conn1 As New SqlConnection(DBConnectionString)
        Dim cmd1 As New SqlCommand(strProcName, conn1)
        cmd1.CommandType = CommandType.StoredProcedure
        conn1.Open()

        cmd1.ExecuteNonQuery()
        conn1.Close()
        cmd1.Dispose()
        conn1.Dispose()
    End Sub


    Protected Shared Sub ExecuteNonQuery(ByVal strSql As String, ByVal useTransaction As Boolean)
        If useTransaction = False Then
            ExecuteNonQuery(strSql)
            Exit Sub
        End If
        Dim conn1 As New SqlConnection(DBConnectionString)
        conn1.Open()
        Dim tran1 As SqlTransaction = conn1.BeginTransaction(IsolationLevel.ReadUncommitted)
        Dim cmd1 As New SqlCommand(strSql, conn1, tran1)
        Try
            cmd1.ExecuteNonQuery()
            tran1.Commit()
        Catch MasterFileDBexception As Exception
            tran1.Rollback()
            Throw MasterFileDBexception
        Finally
            conn1.Close()
            cmd1.Dispose()
            conn1.Dispose()
            tran1.Dispose()
        End Try
    End Sub

    '2010-04-09,MINTRA
    Protected Shared Sub ExecuteNonQuery(ByVal conn As SqlConnection, ByVal tran As SqlTransaction, ByVal strSQL As String)
        Dim cmd1 As New SqlCommand(strSQL, conn, tran)
        cmd1.ExecuteNonQuery()
    End Sub

    ''' <summary>
    ''' Execute sql command that return single value
    ''' </summary>
    Public Shared Function ExecuteScalar(ByVal strSql As String) As Object

        Dim conn As SqlConnection = Nothing
        Dim cmd As New SqlCommand
        Try
            conn = New SqlConnection(DBConnectionString)
            Dim objResult As Object = Nothing

            cmd.CommandText = strSql
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            conn.Open()
            objResult = cmd.ExecuteScalar()


            Return objResult
        Catch ex As Exception
            Return Nothing
            Throw ex
        Finally

            conn.Close()
            cmd.Dispose()
            conn.Dispose()
        End Try
    End Function

#End Region

    ''From P'Rod 2015-08-25
    'Public Shared Function ExecuteComm(ByVal sql As String) As Integer
    '    Dim conn As New SqlConnection
    '    Dim comm As New SqlCommand
    '    Dim rows As Integer
    '    Try

    '        conn = New SqlConnection(DBConnectionString)
    '        conn.Open()

    '        comm = New SqlCommand(sql, conn)
    '        comm.CommandTimeout = 0
    '        rows = comm.ExecuteNonQuery()

    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        comm.Dispose()
    '        conn.Close()
    '        conn.Dispose()
    '    End Try
    '    Return rows
    'End Function

    Public Shared Function GetDataSetByProc_Params(ByVal p_procName As String, ByVal p_dict As System.Collections.Generic.Dictionary(Of String, Object), ByVal p_dsName As String, ByVal p_keyName As String, ByVal p_TableName() As String, ByVal p_RelationName() As String) As DataSet

        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter
        Dim p_conn As SqlConnection = Nothing
        'Dim p_trann As New SqlTransaction

        Try
            Dim ds As New DataSet(p_dsName)

            If p_conn Is Nothing Then
                p_conn = New SqlConnection(DBConnectionString)
                p_conn.Open()       '2015-11-23 Mintra Sn. 
            End If

            'boonrod new code 19.10.2015 ช่วยให้ Run Store ที่มีความซับซ้อนได้เร็วขึ้น
            cmd.CommandText = "set arithabort on;"
            cmd.CommandType = CommandType.Text
            cmd.Connection = p_conn
            'cmd.Connection.Open() '2015-11-23 Mintra Sn. If "p_conn" (SqlConnection) was opended then it cannot call this method again.
            cmd.ExecuteNonQuery()
            '############################################################

            cmd.CommandText = p_procName
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = p_conn

            cmd.CommandTimeout = TimeoutConfig

            cmd.Parameters.Clear()

            Dim sqlparams(p_dict.Count - 1) As SqlParameter
            Dim index As Integer = 0
            For Each pair As KeyValuePair(Of String, Object) In p_dict
                Dim param As New SqlParameter("@" + pair.Key, pair.Value)
                sqlparams(index) = param
                index += 1
            Next

            cmd.Parameters.AddRange(sqlparams)

            da = New SqlDataAdapter(cmd)

            'fill the dataset
            ds.Clear()
            da.Fill(ds)

            If (Not String.IsNullOrEmpty(p_keyName)) Then
                Dim colParent As DataColumn()
                For index3 As Integer = 0 To p_TableName.Length - 1
                    ds.Tables(index3).TableName = p_TableName(index3)
                    Dim col As DataColumn() = New DataColumn() {ds.Tables(index3).Columns(p_keyName)}

                    If index3 = 0 Then
                        Dim pkColumns(1) As DataColumn
                        pkColumns(0) = ds.Tables(index3).Columns(p_keyName)
                        ds.Tables(index3).PrimaryKey = pkColumns
                        colParent = col
                    Else
                        If p_RelationName IsNot Nothing Then
                            Dim relation1 As DataRelation
                            relation1 = New DataRelation(p_RelationName(index3 - 1), colParent, col)
                            ds.Relations.Add(relation1)
                        End If
                    End If
                Next
            End If

            Return ds
        Catch ex As Exception
            Return Nothing
            Throw ex
        Finally
            cmd.Dispose()
        End Try
    End Function
End Class

