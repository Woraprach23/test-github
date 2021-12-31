Public Class CRAddForm
    Private _clientProduct As Data.ClientProduct 
    Private _crIDs As List(Of Integer)
    Private _parentType As Common.AppEnums.DocType = Common.AppEnums.DocType.None
    Private _parentID As Integer

    Sub New(ByVal p_parentType As Common.AppEnums.DocType, ByVal p_parentID As Integer, p_clientProduct As Data.ClientProduct, ByVal p_crIDs As List(Of Integer))
        _parentType = p_parentType
        _clientProduct = p_clientProduct
        _crIDs = p_crIDs
        _parentID = p_parentID
        EditMode = Common.AppEnums.EditMode.Add
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Protected Overrides Sub AdditionalIntialize()
        CrGridView1.IsAddForm = True
        CrGridView1.ParentType = _parentType
        CrGridView1.ParentID = _parentID 
        CrGridView1.EditMode = Common.AppEnums.EditMode.Add
        CrGridView1.ShowCaption = True
        CrGridView1.ShowAddPanel = False
        CrGridView1.CurrentClientProduct = _clientProduct
        CrGridView1.RegisterGridControl()
        CrGridView1.RowFilter = GetRowFilter()
        CrGridView1.ShowCaption = False
        CrGridView1.LoadDataSource()

        txtClientCode.Text = _clientProduct.ClientCode
        txtPructionCode.Text = _clientProduct.ProductCode
    End Sub

    Private Function GetRowFilter() As String
        Dim filter = String.Format("CRID NOT IN ({0})", String.Join(",", _crIDs))
        Return filter
    End Function

    Public Overrides Function ValidateControl() As Boolean
        If (Not MyBase.ValidateControl()) Then
            Return False
        End If

        If (CrGridView1.CheckGridViewUnselect) Then
            Return False
        End If
  
        If (_parentType = Common.AppEnums.DocType.FSD) Then
            Return CrGridView1.IsNotDuplicatingFSD()
        Else
            Return CrGridView1.IsNotDuplicatingJob()
        End If

        Return True
    End Function

    Protected Overrides Function ProcessSave() As Boolean
  
        Dim index As Integer = 0
        Dim cr As Data.CR = Nothing
        Dim selectKeys = CrGridView1.GetSelectedKeys
        For Each key In selectKeys
            cr = New Data.CR(key)
            If (_parentType = Common.AppEnums.DocType.FSD) Then
                cr.FSDID = _parentID
            Else
                cr.JobID = _parentID
            End If
            cr.LastUpdatedBy = Common.ApplicationMeta.LoginUserID
            cr.DBInsertUpdate()
        Next
         
        Return True
         
    End Function

End Class
