Imports Finsoft.PM.Data

Public Class ConfigService

    Public Shared Function Config(ByVal p_configGroupID As Integer) As DataTable
        Dim strProc As String = "dbo.Config_List"
        Dim dic As New Dictionary(Of String, Object)
        dic.Add("ConfigGroupID", p_configGroupID)
        Return DBProc.GetDataTableByProc_Params(strProc, dic)
    End Function

    Public Shared Function GetConfigList(ByVal p_group As Integer) As List(Of Config)
        Dim dt = ConfigService.GetConfigData(p_group)
        Dim list = dt.ToList(Of Config)()
        Return list
    End Function

    Public Shared Function GetConfigDisplayText(ByVal p_configGroupID As Integer, ByVal p_configValue As Integer) As String
        Dim config As New Config()
        config.LoadData("ConfigGroupID", p_configGroupID, "ConfigValue", p_configValue)
        Return config.ConfigName
    End Function

    Public Shared Function GetConfigData(ByVal p_configGroupID As Integer) As DataTable
        Dim config As New Config()
        config.LoadDataSource(p_configGroupID)
        Return config.DataSource
    End Function

 
    Public Shared Function GetMessageText(ByVal value As Integer) As String
        Return GetConfigDisplayText(DataEnums.ConfigGroup.MessageCode, value)
    End Function

    Public Shared Function GetLogTypeName(ByVal value As Integer) As String
        Dim config As New Config()
        config.LoadData("ConfigGroupID", CInt(DataEnums.ConfigGroup.LogType), "ConfigValue", CInt(value))
        Return config.ConfigName
    End Function

    Public Shared Function GetConfig(ByVal p_ConfigGroup As DataEnums.ConfigGroup, ByVal p_value As Integer) As Config
        Dim config As New Config()
        config.LoadData("ConfigGroupID", p_ConfigGroup, "ConfigValue", p_value)
        Return config
    End Function
End Class

Public Class ConfigHasTableService

    Private _hashtable As New Hashtable
    Public Function GetConfigList(ByVal p_group As Integer) As List(Of Config)
        If (_hashtable(p_group) Is Nothing) Then
            Dim dt = ConfigService.GetConfigData(p_group)
            Dim list = dt.ToList(Of Config)()
            _hashtable(p_group) = list
            Return list
        Else
            Dim list = DirectCast(_hashtable(p_group), List(Of Config))
            Return list
        End If
    End Function

    Public Function GetConfig(ByVal p_group As Integer, ByVal p_value As Integer) As Config
        Dim list = GetConfigList(p_group)
        Dim item = list.Find(Function(a) a.ConfigValue = p_value)
        Return item
    End Function

    Public Function GetDisplay(ByVal p_group As Integer, ByVal p_value As Integer) As String
        Dim list = GetConfigList(p_group)
        Dim item = list.Find(Function(a) a.ConfigValue = p_value)
        Return item.ConfigName
    End Function


End Class


