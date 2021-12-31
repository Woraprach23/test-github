Imports System.Collections

Public Class ConfigHasTableService

    Private _hashtable As New Hashtable
    'Public Function GetConfigList(ByVal p_group As Integer) As List(Of URSA_CA_Config)
    '    If (_hashtable(p_group) Is Nothing) Then
    '        Dim dt = ConfigService.GetConfigData(p_group)
    '        Dim list = dt.ToList(Of URSA_CA_Config)()
    '        _hashtable(p_group) = list
    '        Return list
    '    Else
    '        Dim list = DirectCast(_hashtable(p_group), List(Of URSA_CA_Config))
    '        Return list
    '    End If
    'End Function

    'Public Function GetConfig(ByVal p_group As Integer, ByVal p_value As Integer) As URSA_CA_Config
    '    Dim list = GetConfigList(p_group)
    '    Dim item = list.Find(Function(a) a.ConfigValue = p_value)
    '    Return item
    'End Function

    'Public Function GetDisplay(ByVal p_group As Integer, ByVal p_value As Integer) As String
    '    Dim list = GetConfigList(p_group)
    '    Dim item = list.Find(Function(a) a.ConfigValue = p_value)
    '    Return item.ConfigName
    'End Function


End Class
