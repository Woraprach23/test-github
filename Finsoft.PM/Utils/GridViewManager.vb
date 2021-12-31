Imports System.IO
Imports Finsoft.PM.Common

Public Class GridViewManager
    Public Sub SetGridAppearance(ByRef p_grdView As DevExpress.XtraGrid.Views.Grid.GridView)
        p_grdView.OptionsBehavior.Editable = False
        p_grdView.GridControl.UseEmbeddedNavigator = False
        p_grdView.OptionsBehavior.AutoPopulateColumns = False
        p_grdView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        'p_grdView.Appearance.SelectedRow.BackColor = AppConst.c_GridViewStyle_SelectedRow_BackColor
        p_grdView.Appearance.SelectedRow.Options.UseBackColor = True
        p_grdView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        'p_grdView.Appearance.FocusedRow.BackColor = AppConst.c_GridViewStyle_SelectedRow_BackColor
        p_grdView.Appearance.FocusedRow.Options.UseBackColor = True

        'p_grdView.OptionsView.ShowGroupPanel = False
        'p_grdView.OptionsPrint.AutoWidth = False


        If (p_grdView.OptionsView.AllowCellMerge) Then
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In p_grdView.Columns
                col.OptionsColumn.AllowMerge = True
            Next
        End If

    End Sub

    Public Sub ExportFile(ByVal gridview As DevExpress.XtraGrid.Views.Base.BaseView, ByVal p_objectName As String, ByVal p_loginUser As String)
        If gridview Is Nothing Then
            Return
        End If

        If gridview.GridControl Is Nothing Then
            Return
        End If

        Dim p_fileName As String = String.Empty
        p_fileName = String.Format("{0}_{1}_{2}", p_objectName, ApplicationMeta.ServerDate.ToString("ddMMyyyy"), p_loginUser)

        Dim saveDialog As New SaveFileDialog()
        saveDialog.FileName = p_fileName
        saveDialog.InitialDirectory = "c:\"
        saveDialog.Filter = "Exel Files (*.xlsx)|*.xlsx|Exel Files (2003-2007) (*.xls)|*.xls|PDF Files (*.pdf)|*.pdf|Document Files (*.docx;*.doc)|*.docx;*.doc|Rich Text Files (*.rtf)|*.rtf" ' "Office Files (*.xlsx;*.xls;)|*.xlsx;*.xls"
        If saveDialog.ShowDialog <> DialogResult.OK Then
            Return
        End If

        Dim strFullPath As String = saveDialog.FileName
        ' Dim path2 = Path.GetDirectoryName(strFullPath)

        If saveDialog.CheckFileExists() Then
            If (MessageBox.Show("Do you want to replace from the existing file?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
                Try
                    System.IO.File.Delete(strFullPath)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Delete file", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return
                End Try
            Else
                Return
            End If
        End If

        gridview.OptionsPrint.ShowPrintExportProgress = True

        Dim startIndex As Integer = strFullPath.IndexOf(".") + 1 'strFullPath.IndexOf(p_fileName) + p_fileName.Length + 1
        Dim endIndex As Integer = strFullPath.Length - startIndex
        Dim p_extension As String = strFullPath.Substring(startIndex, endIndex)

        Select Case p_extension
            Case "xls"
                gridview.ExportToXls(strFullPath)
            Case "xlsx"
                gridview.ExportToXlsx(strFullPath)

            Case "pdf"
                gridview.ExportToPdf(strFullPath)
            Case "csv"
                gridview.ExportToCsv(strFullPath)
            Case "txt"
                gridview.ExportToText(strFullPath)
            Case "Rtf"
                gridview.ExportToRtf(strFullPath)
        End Select

        If MessageManager.Comfirmation("File export successfully. Would you like to open file?") Then
            System.Diagnostics.Process.Start(strFullPath)
        End If

    End Sub


    Public Sub AddColumn(ByVal p_grid As DevExpress.XtraGrid.Views.Grid.GridView, _
                         ByVal p_fieldName As String, _
                         ByVal p_caption As String, _
                         ByVal p_visibleIndex As Integer, _
                         ByVal p_formatType As DevExpress.Utils.FormatType, _
                         ByVal p_format As String, _
                         ByVal p_editable As Boolean)

        If (p_grid.Columns(p_fieldName) IsNot Nothing) Then
            Return
        End If

        Dim col As New DevExpress.XtraGrid.Columns.GridColumn
        col.FieldName = p_fieldName
        col.Caption = p_caption
        col.VisibleIndex = p_visibleIndex

        col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        If (p_formatType <> DevExpress.Utils.FormatType.None) Then
            col.DisplayFormat.FormatType = p_formatType
            If (p_formatType = DevExpress.Utils.FormatType.Numeric) Then
                col.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.HorzAlignment.Far
            End If
        End If

        p_grid.Columns.Add(col)

    End Sub
    'Public Shared Sub SaveLayout(ByRef p_grid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal p_moduleID As Integer, ByVal p_menuID As Integer, ByVal p_gridName As String)
    '    Dim str As New System.IO.MemoryStream()
    '    p_grid.SaveLayoutToStream(str)
    '    str.Seek(0, System.IO.SeekOrigin.Begin)
    '    Dim reader As New StreamReader(str)
    '    Dim text As String = reader.ReadToEnd()
    'End Sub

    'Public Shared Sub LoadLayout(ByRef p_grid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal p_moduleID As Integer, ByVal p_menuID As Integer, ByVal p_gridName As String)
    '    Dim text = ""  'GET THE REQUIRED STRING FROM THE DATABASE';
    '    Dim byteArray = System.Text.Encoding.ASCII.GetBytes(text)
    '    Dim stream As MemoryStream = New MemoryStream(byteArray)
    '    p_grid.RestoreLayoutFromStream(stream)
    'End Sub
End Class
