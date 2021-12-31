Public Class DataConverter
 
#Region "convert data to DB"
        Public Shared Function cvToDB(ByVal p_value As Object) As Object
            If (IsNothing(p_value)) Then
                Return DBNull.Value
            End If
            Return p_value
        End Function
#End Region

#Region "convert data from DB"
        Public Shared Function cvDBNull(ByVal p_value As Object) As Object
            If (IsDBNull(p_value)) Then
                Return Nothing
            End If
            Return p_value
        End Function

        Public Shared Function cvDate(ByVal p_value As Object) As DateTime
            If (IsDBNull(p_value)) Then
                Return Nothing
            End If
            Return CDate(p_value)
        End Function
        Public Shared Function cvStr(ByVal p_value As Object) As String
            If (IsDBNull(p_value)) Then
                Return Nothing
            End If
            Return CStr(p_value)
        End Function

        Public Shared Function cvInt(ByVal p_value As Object) As Integer
            If (IsDBNull(p_value)) Then
                Return Nothing
            End If
            Return CInt(p_value)
        End Function

        Public Shared Function cvBool(ByVal p_value As Object) As Boolean
            If (IsDBNull(p_value)) Then
                Return Nothing
            End If
            Return CBool(p_value)
        End Function

        Public Shared Function cvDec(ByVal p_value As Object) As Decimal
            If (IsDBNull(p_value)) Then
                Return Nothing
            End If
            Return CDec(p_value)
        End Function

#End Region

#Region "Get SQL String"
    Public Shared Function GetSQLString(ByVal p_data As Decimal) As String
        If (p_data = Nothing) Then
            Return "0"
        End If
        Return String.Format("{0}", p_data.ToString.Trim)
    End Function


    Public Shared Function GetSQLString(ByVal p_data As String) As String
        If (String.IsNullOrEmpty(p_data)) Then
            Return String.Empty
        End If
        Return String.Format("'{0}'", p_data.ToString.Trim)
    End Function

    Public Shared Function GetSQLString(ByVal p_data As Integer) As String
        If (p_data = Nothing) Then
            Return "0"
        End If
        Return String.Format("{0}", p_data.ToString.Trim)
    End Function

    Public Shared Function GetSQLString(ByVal p_data As Boolean) As String
        Return String.Format("'{0}'", p_data.ToString)
    End Function

    Public Shared Function GetSQLString(ByVal p_data As DateTime) As String
        If (p_data = Nothing Or p_data >= DateTime.MaxValue Or p_data <= DateTime.MinValue) Then
            Return String.Empty
        End If


        Return String.Format("'{0}'", p_data.ToString("yyyy-MM-dd"), New System.Globalization.CultureInfo("en-US")) 'String.Format("'{0}'", p_data.ToString("dd/MM/yyyy :")) 'p_data.ToString("dd/MM/yyyy")
    End Function

#End Region

#Region "ConvertStringToDB"
    Public Shared Function ConvertStringToDB(ByVal p_data As String) As String
        If (IsDBNull(p_data) Or p_data = Nothing) Then
            Return String.Empty
        End If
        Return p_data.ToString.Trim
    End Function

    Public Shared Function ConvertStringToDB(ByVal p_data As Decimal) As String
        If (IsDBNull(p_data) Or p_data = Nothing) Then
            Return String.Empty
        End If
        Return String.Format("{0}", p_data.ToString.Trim)
    End Function

    Public Shared Function ConvertStringToDB(ByVal p_data As Integer) As String
        If (IsDBNull(p_data) Or p_data = Nothing) Then
            Return String.Empty
        End If
        Return String.Format("{0}", p_data.ToString.Trim)
    End Function

    Public Shared Function ConvertStringToDB(ByVal p_data As Boolean) As String
        Return p_data.ToString
    End Function

    Public Shared Function ConvertStringToDB(ByVal p_data As DateTime) As String
        If (IsDBNull(p_data) Or p_data = Nothing) Then
            Return String.Empty
        End If

        If p_data <= DateTime.MinValue Or p_data >= DateTime.MaxValue Then
            Return String.Empty
        End If

        Return p_data.ToString("dd-MM-yyyy", New Globalization.CultureInfo("en-US"))
    End Function
#End Region

End Class
