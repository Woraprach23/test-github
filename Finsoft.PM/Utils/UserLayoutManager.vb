Imports System.IO

Public Class UserLayoutManager
  
    Public Sub SaveLayout(ByVal crtParent As Control, ByVal crt As Control, ByVal p_userID As Integer, ByVal p_menuName As String)
        For Each Control In crt.Controls
            If Control.GetType() = GetType(DevExpress.XtraGrid.GridControl) Then
                Dim grid As DevExpress.XtraGrid.GridControl = Control
                For Each View As DevExpress.XtraGrid.Views.Base.BaseView In grid.ViewCollection
                    If (Not View.IsVisible) Then
                        Continue For
                    End If
                    If Not (View.PostEditor() And View.UpdateCurrentRow()) Then

                    End If
                    If (Not String.IsNullOrEmpty(p_menuName)) Then
                        p_menuName += "_"
                    End If
                    Dim controlName As String = p_menuName + crtParent.Name & "_" & grid.Name & "_" & View.Name
                    SaveLayoutTODB(View, p_userID, controlName)
                Next
            Else
                SaveLayout(crtParent, Control, p_userID, p_menuName)
            End If
        Next
    End Sub

    Public Sub RestoreLayout(ByVal crtParent As Control, ByVal crt As Control, ByVal p_userID As Integer, ByVal p_menuName As String)
        For Each Control In crt.Controls
            If Control.GetType() = GetType(DevExpress.XtraGrid.GridControl) Then
                Dim grid As DevExpress.XtraGrid.GridControl = Control

                For Each View As DevExpress.XtraGrid.Views.Base.BaseView In grid.ViewCollection
                    If View.Tag = "NotSave" Then
                        Continue For
                    End If
                    If (Not String.IsNullOrEmpty(p_menuName)) Then
                        p_menuName += "_"
                    End If

                    Dim controlName = p_menuName + crtParent.Name & "_" & grid.Name & "_" & View.Name
                    RestoreLayoutFromDB(View, p_userID, controlName)
                Next
            Else
                RestoreLayout(crtParent, Control, p_userID, p_menuName)
            End If
        Next
    End Sub

    Private Sub SaveLayoutTODB(ByRef p_view As DevExpress.XtraGrid.Views.Base.BaseView, ByVal p_userID As Integer, ByVal p_controlName As String)
        Dim str As New System.IO.MemoryStream()
        p_view.SaveLayoutToStream(str)
        str.Seek(0, System.IO.SeekOrigin.Begin)
        Dim reader As New StreamReader(str)
        Dim text As String = reader.ReadToEnd()

        Dim userControl = New Data.UserLayout(p_userID, p_controlName)
        userControl.LayoutString = text
        userControl.DBInsertUpdate()
    End Sub


    Private Sub RestoreLayoutFromDB(ByRef p_baseview As DevExpress.XtraGrid.Views.Base.BaseView, ByVal p_userID As Integer, ByVal p_gridName As String)
        Dim userControl As New Data.UserLayout(p_userID, p_gridName)
        If (String.IsNullOrEmpty(userControl.LayoutString)) Then
            Return
        End If

        Dim text = userControl.LayoutString  'GET THE REQUIRED STRING FROM THE DATABASE';
        Dim byteArray = System.Text.Encoding.ASCII.GetBytes(text)
        Dim stream As MemoryStream = New MemoryStream(byteArray)
        p_baseview.RestoreLayoutFromStream(stream)

    End Sub
End Class
