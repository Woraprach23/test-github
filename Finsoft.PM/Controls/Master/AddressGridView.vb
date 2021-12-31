Imports System.ComponentModel
Imports Finsoft.PM.Common

Friend Class AddressGridView

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property CurrentClient As Data.Client

    Public Overrides Sub RegisterGridControl()
        KeyFieldName = "AddressID"
        CurrentGridControl = GridControlClient
        CurrentGridView = GridViewClient
    End Sub

    Public Overrides Sub ShowForm(p_EditMode As Common.AppEnums.EditMode, p_id As Integer)
        CurrentClient.SelectAddress(p_id)

        Dim form As New AddressForm(p_EditMode, p_id)
        form.CurrentValue = CurrentClient.CurrentAddress
        If (form.ShowDialog = DialogResult.OK) Then
            CurrentClient.UpdateAddress(form.CurrentValue, ApplicationMeta.LoginUserID)
            DataSource = CurrentClient.CurrentAddressList 
        End If
    End Sub


    Protected Overrides Function DeleteRow(p_id As Integer) As Boolean
        Dim obj As New Data.Address
        obj.DBDelete(p_id)
        Return True

    End Function

End Class
