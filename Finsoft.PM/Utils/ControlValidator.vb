Public Class ControlValidator
   
    
    Public Sub SetControlProperty(ByRef ctrl As Control, ByVal p_isEnable As Boolean?)

        If TypeOf (ctrl) Is DevExpress.XtraEditors.BaseEdit Then
            Dim baseedit As DevExpress.XtraEditors.BaseEdit = ctrl
 
            If (p_isEnable.HasValue And Not baseedit.Properties.ReadOnly) Then
                baseedit.Properties.ReadOnly = Not p_isEnable.Value
            End If
 
            baseedit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
            baseedit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromName("#F0EAD6")
 
            If Not (TypeOf (baseedit) Is DevExpress.XtraEditors.CheckEdit) Then
                If (Not baseedit.Enabled Or baseedit.ReadOnly) Then
                    baseedit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
                    baseedit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
                End If
            End If

        End If

        If TypeOf (ctrl) Is DevExpress.XtraEditors.SpinEdit Then
            Dim spinEdit As DevExpress.XtraEditors.SpinEdit = ctrl

            Dim display As String = "{0:###,###,###,###,###,###,###,###,##0.####################}"
            Dim editmark As String = "N6"
            If (spinEdit.Tag Is Nothing) Then
                If (spinEdit.Name.IndexOf("Rate") >= 0) Then
                    spinEdit.Tag = "N16"
                ElseIf (spinEdit.Name.IndexOf("Unit") >= 0) Then
                    spinEdit.Tag = "N6"
                ElseIf (spinEdit.Name.IndexOf("Amount") >= 0) Then
                    spinEdit.Tag = "N2"
                End If
            End If

            If (spinEdit.Tag IsNot Nothing) Then
                If (spinEdit.Tag.ToString() = "Amount" Or spinEdit.Tag.ToString() = "N2") Then
                    display = "{0:N2}"
                    editmark = "N2"
                ElseIf (spinEdit.Tag.ToString() = "N0") Then
                    display = "N0"
                    editmark = "N0"
                ElseIf (spinEdit.Tag.ToString() = "N6") Then
                    display = "{0:###,###,###,###,###,###,###,###,##0.####################}"
                    editmark = "N6"
                ElseIf (spinEdit.Tag.ToString() = "N16") Then
                    display = "{0:###,###,###,###,###,###,###,###,##0.####################}"
                    editmark = "N16"
                ElseIf (spinEdit.Tag.ToString() = "N1") Then
                    display = "{0:###,##0.#}"
                    editmark = "N1"
                End If
            End If


            If editmark = "N0" Then
                spinEdit.Properties.IsFloatValue = False
            End If

            spinEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True '2020Q4
            spinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            spinEdit.Properties.Mask.EditMask = editmark
            spinEdit.Properties.AllowMouseWheel = False
            spinEdit.Properties.Mask.UseMaskAsDisplayFormat = False
            spinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            spinEdit.Properties.DisplayFormat.FormatString = display
            spinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            spinEdit.Properties.EditFormat.FormatString = editmark
            spinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            If (spinEdit.Properties.Buttons.VisibleCount > 0) Then
                spinEdit.Properties.Buttons(0).Visible = False
            End If
        ElseIf TypeOf (ctrl) Is DevExpress.XtraEditors.DateEdit Then
            Dim dateEdit As DevExpress.XtraEditors.DateEdit = ctrl
            Dim display As String = "dd/MM/yyyy"
            dateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
            dateEdit.Properties.Mask.EditMask = display
            dateEdit.Properties.AllowMouseWheel = False
            dateEdit.Properties.Mask.UseMaskAsDisplayFormat = False
            dateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dateEdit.Properties.DisplayFormat.FormatString = display
            dateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dateEdit.Properties.EditFormat.FormatString = display
            dateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard

        ElseIf TypeOf (ctrl) Is DevExpress.XtraEditors.TextEdit Then

            Dim text As DevExpress.XtraEditors.TextEdit = ctrl
            text.Properties.NullText = String.Empty
        End If

            If ctrl.HasChildren Then
                For Each child As Control In ctrl.Controls
                    SetControlProperty(child, p_isEnable)
                Next
            End If
    End Sub

    Public Sub SetRequiredFiledCaption(ByRef p_control As DevExpress.XtraEditors.LabelControl)
        p_control.AllowHtmlString = True
        p_control.Text = p_control.Text.Replace("*", String.Empty)
        p_control.Text = String.Format("{0}<color=red>*</color>", p_control.Text) 
    End Sub

    Public Sub ClearRequiredFiledCaption(ByRef p_control As DevExpress.XtraEditors.LabelControl)
        p_control.Text = p_control.Text.Replace("*", String.Empty)
    End Sub
 
     
End Class
