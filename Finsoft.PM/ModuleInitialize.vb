Imports System.Globalization
Imports System.Threading

Public Module ModuleInitialize

    Sub InitialAppSettings()

        DevExpress.UserSkins.BonusSkins.Register()
        Application.EnableVisualStyles()

        Dim culture = CultureInfo.CreateSpecificCulture("en-GB")
        Thread.CurrentThread.CurrentCulture = culture
        Thread.CurrentThread.CurrentUICulture = culture

        DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Tahoma", 11)
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Style"

        Common.ApplicationMeta.IPAddress = GetIPAddress()
        Common.ApplicationMeta.ComputerName = GetComputerName()

        Data.DBProc.SetConnectionString(My.Settings.DBServer, My.Settings.DBAuthentication, My.Settings.DBName, My.Settings.DBUsername, My.Settings.DBPassword)
    End Sub

    Public Function TestConnectionString() As Boolean
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(Data.DBProc.DBConnectionString)
            conn.Open()
            conn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("DB Connection failed.")
            Return False
        End Try
    End Function

 
    Public Function GetIPAddress() As String
        Dim strHostName As String

        Dim strIPAddress As String


        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        Return strIPAddress
    End Function

    Public Function GetComputerName() As String
        Return My.Computer.Name
    End Function
 
End Module
