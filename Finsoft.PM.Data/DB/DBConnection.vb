Imports System.Configuration
Imports System.Data.SqlClient

Public Class DBConnection
    Public Shared URSAConnectionString As String = ""
    Public Shared ReadOnly Property MainConnectionString As String
        Get
           Return URSAConnectionString
        End Get
    End Property
 
End Class
