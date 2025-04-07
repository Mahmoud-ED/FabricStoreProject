Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports CrystalDecisions.CrystalReports.ViewerObjectModel

Public Class FrmPurchasesInvoices
    Private DS As DataSet
    Private IDPrint As Integer

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmPurchasesInvoices_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            GetData()
            TxtUserName.Text = UserName
            TxtMaterialNum.Select()
            TxtMaterialNum.Focus()

        Else
            ChangeControlColor(Me)
            BtnClean.PerformClick()
            CmbSupplier.Text = ""
            DGVInvoContent.Rows.Clear()
            TxtTotal.Text = ""
            Clear(Me)
            If Not IsNothing(DS) Then
                DS.Clear()
            End If

        End If

    End Sub

    Private Sub GetData()
        Dim sqlcon As New SQLConClass()
        SQLQuery = "  Select  ID,Name from UserView where EndService IS Null "
        SQLQuery &= "  Select ID,Name From SuppliersTable  "
        SQLQuery &= " Select *  from ItemsView where EndService IS NUll"
        SQLQuery &= " Select ISNull(Max(Num ),0)+1 Num from PurchasesTable  "

        DS = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DS) Then
            If DS.Tables(3).Rows.Count > 0 Then
                TxtInvoNum.Text = Format(DS.Tables(3).Rows(0).Item(0), "000000")
            Else
                TxtInvoNum.Text = "000001"
            End If
        End If
        FillCmb()

    End Sub

    Private Sub FillCmb()
        CmbMaterial.DataSource = DS.Tables(2)
        CmbMaterial.DisplayMember = "Name"
        CmbMaterial.ValueMember = "ItemStoreID"
        CmbMaterial.SelectedIndex = -1

        CmbSupplier.DataSource = DS.Tables(1)
        CmbSupplier.DisplayMember = "Name"
        CmbSupplier.ValueMember = "ID"
        CmbSupplier.SelectedIndex = -1

    End Sub
    '------ Material Num
    Private Sub TxtMaterialNum_TextChanged(sender As Object, e As EventArgs) Handles TxtMaterialNum.TextChanged
        TxtMaterialNum.BackColor = SystemColors.Window
        If TxtMaterialNum.Text.Trim = vbNullString Then ClearMaterial()
    End Sub

    Private Sub ClearMaterial()
        TxtPurchasPrice.Text = ""
        TxtQuantity.Text = ""
        TxtTotalMaterial.Text = ""
        CmbMaterial.DataSource = Nothing
    End Sub

    Private Sub TxtMaterialNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMaterialNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtMaterialNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtMaterialNum.KeyDown
        If Val(TxtInvoNum.Text) = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            Dim ItemRow() As DataRow = DS.Tables(2).Select("Num=" & Val(TxtMaterialNum.Text))
            If ItemRow.Length = 0 Then Exit Sub
            CmbMaterial.Text = ""
            CmbMaterial.SelectedValue = ItemRow(0)("ID")
            CmbMaterial_SelectionChangeCommitted(CmbMaterial, New EventArgs)
        End If
    End Sub
    Private Sub TxtPurchasPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtPurchasPrice.TextChanged
        TxtPurchasPrice.BackColor = SystemColors.Window
        If Val(TxtPurchasPrice.Text) <= 0 Then TxtPurchasPrice.Text = ""
        If Val(TxtQuantity.Text) > 0 Then
            TxtTotalMaterial.Text = Val(TxtQuantity.Text) * Val(TxtPurchasPrice.Text)
        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantity.TextChanged
        TxtQuantity.BackColor = SystemColors.Window
        If Val(TxtQuantity.Text) <= 0 Then TxtQuantity.Text = ""
        If Val(TxtPurchasPrice.Text) > 0 Then
            TxtTotalMaterial.Text = Val(TxtQuantity.Text) * Val(TxtPurchasPrice.Text)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        IsDataMissing = False
        IsInputEmpty(TLPData)
        If IsDataMissing = True Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        If Val(TxtQuantity.Text) <= 0 Then Exit Sub
        If Not IsNumeric(TxtQuantity.Text) OrElse Val(TxtQuantity.Text) <= 0 Then
            MsgTool("يرجى ادخال كمية صحيحة", 0)
            Exit Sub
        End If
        Dim Cr As Integer
        Dim ISInDGV As Boolean = False ' ادا كان موجود يدير ترو 

        '----------------------------------------------------------------------------------
        'البحث عن الصنف هل موجود في DGV مسبقا
        For Each Row As DataGridViewRow In DGVInvoContent.Rows
            If Val(TxtMaterialNum.Text.Trim) = Val(Row.Cells(1).Value) Then
                ISInDGV = True
                Row.Cells(4).Value = Val(TxtQuantity.Text)
                Row.Cells(3).Value = Format(Val(TxtPurchasPrice.Text), "0.000") 'سعر الشراء يتعدل 
                Row.Cells(5).Value = Format(Row.Cells(4).Value * Row.Cells(3).Value, "0.000") 'الاجمالي يتعدل
                Row.Cells(6).Value = CmbMaterial.SelectedValue
                Row.Cells(8).Value = TxtCountry.Text
                Row.Selected = True
                DGVInvoContent.FirstDisplayedScrollingRowIndex = (Row.Index)
                Cr = Row.Index

                GetTotal()
                Exit Sub
            End If

        Next
        '   ******************************************************************---------------------
        ' اضافة صف جديد بكمية مبدئية 1 

        If ISInDGV = False Then
            DGVInvoContent.Rows.Add(DGVInvoContent.Rows.Count + 1,
                                    Val(TxtMaterialNum.Text),
                                    CmbMaterial.Text,
                                    Format(Val(TxtPurchasPrice.Text), "0.000"),
                                    Val(TxtQuantity.Text),
                                    Val(TxtTotalMaterial.Text),
                                    CmbMaterial.SelectedValue,
                                    0,
                                    TxtCountry.Text.Trim)
        End If
        Cr = DGVInvoContent.Rows.Count - 1
        DGVInvoContent.Rows(Cr).Selected = True
        DGVInvoContent.FirstDisplayedScrollingRowIndex = (Cr)
        GetTotal()
        DGVInvoContent.ClearSelection()
    End Sub

    Private Sub GetTotal()
        Dim Total As Double = 0
        TxtTotal.Text = "0.000"
        For Each Row As DataGridViewRow In DGVInvoContent.Rows
            Total += Val(Row.Cells(5).Value)
        Next
        TxtTotal.Text = Format(Total, "0.000")
    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        Clear(TLPData)
        ChangeControlColor(Me)
        DGVInvoContent.ClearSelection()

        GetData()

    End Sub

    Private Sub TxtTotalMaterial_TextChanged(sender As Object, e As EventArgs) Handles TxtTotalMaterial.TextChanged
        TxtTotalMaterial.BackColor = SystemColors.Window
    End Sub

    Public Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ChangeControlColor(Me)
        Clear(TLPData)
        BtnClean.PerformClick()
        CmbSupplier.Text = ""
        DGVInvoContent.Rows.Clear()
        TxtTotal.Text = ""
        GetData()
        IDPrint = 0
    End Sub

    Private Sub DGVInvoContent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInvoContent.CellContentClick
        If CheckDGVError(DGVInvoContent) Then Exit Sub
        If DGVInvoContent.Rows.Count = 0 Then Exit Sub
        Dim CR As Integer
        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If Col = "Del" Then
            CR = DGVInvoContent.CurrentRow.Index
            DGVInvoContent.Rows.Remove(DGVInvoContent.Rows(CR))
            GetTotal()
            BtnClean_Click(sender, e)

        ElseIf Col = "Edith" Then
            'Clear(TLPData)
            CR = DGVInvoContent.CurrentRow.Index
            displaY(CR)
        End If
    End Sub

    Private Sub displaY(CR As Integer)
        With DGVInvoContent
            If .Rows(CR).Cells(1).Value Is Nothing Then
                Exit Sub
            End If

            If .Rows(CR).Cells(6).Value Is Nothing Then
                Exit Sub
            End If

            TxtMaterialNum.Text = .Item(1, CR).Value.ToString
            CmbMaterial.SelectedValue = .Item(6, CR).Value
            CmbMaterial.Refresh()
            If CmbMaterial.SelectedIndex = -1 Then
                CmbMaterial.SelectedIndex = CmbMaterial.SelectedIndex = CmbMaterial.FindStringExact(.Item(2, CR).Value.ToString)
            End If
            CmbMaterial_SelectionChangeCommitted(CmbMaterial, New EventArgs)

            TxtQuantity.Text = .Item(4, CR).Value
            TxtPurchasPrice.Text = .Item(3, CR).Value
            TxtCountry.Text = .Item(8, CR).Value
            GetTotal()

        End With
    End Sub

    Private Sub DGVInvoContent_Click(sender As Object, e As EventArgs) Handles DGVInvoContent.Click
        If CheckDGVError(DGVInvoContent) Then Exit Sub
        If DGVInvoContent.Rows.Count = 0 OrElse DGVInvoContent.CurrentRow Is Nothing Then Exit Sub
        Dim CR As Integer = DGVInvoContent.CurrentRow.Index
        If DGVInvoContent.Rows(CR).Cells(1).Value Is Nothing Then
            Exit Sub
        End If
        displaY(CR)
    End Sub

    Private Sub DGVInvoContent_DoubleClick(sender As Object, e As EventArgs) Handles DGVInvoContent.DoubleClick
        If CheckDGVError(DGVInvoContent) Then Exit Sub
        If DGVInvoContent.Rows.Count = 0 Then Exit Sub
        Dim CR As Integer

        Clear(TLPData)
        CR = DGVInvoContent.CurrentRow.Index
        displaY(CR)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'If IDPrint <> 0 Then
        '    MsgTool("تم حفظ الفاتورة", 1)
        '    Exit Sub
        'End If

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=99")

        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية الإضافة", 0)
        '    Exit Sub
        'End If

        If DGVInvoContent.Rows.Count = 0 Then Exit Sub
        IsDataMissing = False
        If IsNothing(CmbSupplier.SelectedValue) Then
            CmbSupplier.BackColor = RedColor
            MsgTool("يرجى التأكد من المورد   ", 0)
            Exit Sub
        End If
        Dim DT As New DataTable
        DT.Columns.AddRange(New DataColumn(3) {New DataColumn("Quantity", GetType(Double)), New DataColumn("ItemStoreID", GetType(Integer)),
                            New DataColumn("PurchasePrice", GetType(Double)), New DataColumn("Total", GetType(Double))})

        For Each Row As DataGridViewRow In DGVInvoContent.Rows
            DT.Rows.Add(Row.Cells(4).Value, Row.Cells(6).Value, Row.Cells(3).Value, Row.Cells(5).Value)
        Next
        Dim SQLCon = New SQLConClass
        Dim DSInvo As New DataSet
        Dim Param() As SqlParameter = {
            New SqlParameter("@Total", Val(TxtTotal.Text)),
            New SqlParameter("@SupplierID", CmbSupplier.SelectedValue),
            New SqlParameter("@PurchaseInvoData", DT),
            New SqlParameter("@UserID", UserID)
        }
        DSInvo = SQLCon.CMDExecuteData("SavePurchaseInvoice", Param)

        If Not DSHasTables(DSInvo) Then Exit Sub
        If Save = 1 Then
            MsgTool("تم حفظ الفاتورة بنجاح", 1)
            IDPrint = DSInvo.Tables(1).Rows(0).Item(0)

            Dim CashingForm As New FrmSupplierInvoiceCashing

            CashingForm.ShowDialog()
        End If
    End Sub

    Private Sub CmbSupplier_TextChanged(sender As Object, e As EventArgs) Handles CmbSupplier.TextChanged
        CmbSupplier.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPriceSale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPurchasPrice.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        If Val(TxtMaterialNum.Text) = 0 Or TxtMaterialNum.Text = "" Then
            TxtMaterialNum.BackColor = RedColor
            Exit Sub
        End If

        Dim ItemRow() As DataRow = DS.Tables(2).Select("Num=" & Val(TxtMaterialNum.Text))
        If ItemRow.Length = 0 Then
            MsgTool("الصنف غير موجود", 0)
            Exit Sub
        End If


        For i As Integer = 0 To CmbMaterial.Items.Count - 1
            If CType(CmbMaterial.Items(i), DataRowView)("ID") = ItemRow(0)("ID") Then
                CmbMaterial.SelectedIndex = i
                Exit For
            End If
        Next

        UpdateFieldsForSelectedItem()
    End Sub

    Private Sub UpdateFieldsForSelectedItem()
        If CmbMaterial.SelectedValue Is Nothing Then Exit Sub

        Dim SelectedItem As DataRowView = CType(CmbMaterial.SelectedItem, DataRowView)

        Dim ItemRow() As DataRow = DS.Tables(2).Select("ItemStoreID=" & SelectedItem("ItemStoreID"))

        If ItemRow.Length = 0 Then Exit Sub

        TxtMaterialNum.Text = Format(ItemRow(0)("Num"), "000000")
        TxtCountry.Text = ItemRow(0)("Country")
        TxtPurchasPrice.Text = Format(ItemRow(0)("PurchasePrice"), "0.000")
    End Sub

    '------CMbMaterial

    Private Sub CmbMaterial_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbMaterial.SelectionChangeCommitted
        If IsNothing(CmbMaterial.SelectedValue) Then Exit Sub
        Dim ItemRow() As DataRow = DS.Tables(2).Select("ItemStoreID=" & CmbMaterial.SelectedValue)

        If ItemRow.Length = 0 Then Exit Sub

        TxtMaterialNum.Text = Format(ItemRow(0)("Num"), "000000")
        TxtCountry.Text = ItemRow(0)("Country")
        TxtPurchasPrice.Text = Format(ItemRow(0)("PurchasePrice"), "0.000")

    End Sub


    Private Sub TxtInvoNum_TextChanged(sender As Object, e As EventArgs) Handles TxtInvoNum.TextChanged
        'If Not TxtInvoNum.BackColor = SystemColors.Window Then TxtInvoNum.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbMaterial_TextChanged(sender As Object, e As EventArgs) Handles CmbMaterial.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnSearch_TextChanged(sender As Object, e As EventArgs) Handles BtnSearch.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtUnitName_TextChanged(sender As Object, e As EventArgs)
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbStore_SelectedIndexChanged(sender As Object, e As EventArgs)
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub DGVInvoContent_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVInvoContent.CellFormatting
        If e.ColumnIndex = 13 Then
            e.CellStyle.ForeColor = Color.White
            e.CellStyle.SelectionForeColor = Color.White
        End If

        If e.ColumnIndex = 14 Then
            e.CellStyle.BackColor = RedColor
            e.CellStyle.SelectionBackColor = RedColor
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.SelectionForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=99")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        'If IDPrint = 0 Then Exit Sub

        'Dim DSPrint = New DataSet
        'Dim SQLCon = New SQLConClass

        'If Settings.GetSettings(SettingsProject.ClassSettings.Setting.ServiceLang) = "AR" Then

        '    SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,Name,UserName,Total FROM MaterialInvoiceView WHERE ID=" & IDPrint
        '    SQLQuery &= " SELECT * FROM MaterialInvoiceContentView WHERE ID=" & IDPrint
        '    SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        '    DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        '    Dim F As New FrmPrint
        '    Dim C As New CRMaterialArInvoice

        '    C.SetDataSource(DSPrint.Tables(1))
        '    C.Subreports(0).SetDataSource(DSPrint.Tables(2))
        '    C.Subreports(1).SetDataSource(DSPrint.Tables(2))
        '    C.SetParameterValue("InvoNum", DSPrint.Tables(0).Rows(0).Item(0))
        '    C.SetParameterValue("Name", DSPrint.Tables(0).Rows(0).Item(1))
        '    C.SetParameterValue("UserName", DSPrint.Tables(0).Rows(0).Item(2))
        '    C.SetParameterValue("Total", DSPrint.Tables(0).Rows(0).Item(3))
        '    F.CrystalReportViewer1.ReportSource = C
        '    F.CrystalReportViewer1.Refresh()
        '    F.Text = "طباعة"
        '    F.CrystalReportViewer1.Zoom(100%)
        '    F.WindowState = FormWindowState.Maximized
        '    F.Show()

        'ElseIf Settings.GetSettings(SettingsProject.ClassSettings.Setting.ServiceLang) = "EN" Then

        '    SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,Name,UserName,Total FROM MaterialInvoiceView WHERE ID=" & IDPrint
        '    SQLQuery &= " SELECT * FROM MaterialInvoiceContentView WHERE ID=" & IDPrint
        '    SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        '    DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        '    Dim F As New FrmPrint
        '    Dim C As New CRMaterialEnInvoice

        '    C.SetDataSource(DSPrint.Tables(1))
        '    C.Subreports(0).SetDataSource(DSPrint.Tables(2))
        '    C.Subreports(1).SetDataSource(DSPrint.Tables(2))
        '    C.SetParameterValue("InvoNum", DSPrint.Tables(0).Rows(0).Item(0))
        '    C.SetParameterValue("Name", DSPrint.Tables(0).Rows(0).Item(1))
        '    C.SetParameterValue("UserName", DSPrint.Tables(0).Rows(0).Item(2))
        '    C.SetParameterValue("Total", DSPrint.Tables(0).Rows(0).Item(3))
        '    F.CrystalReportViewer1.ReportSource = C
        '    F.CrystalReportViewer1.Refresh()
        '    F.Text = "طباعة"
        '    F.CrystalReportViewer1.Zoom(100%)
        '    F.WindowState = FormWindowState.Maximized
        '    F.Show()

        'End If

    End Sub

    Private Sub CmbMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMaterial.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSupplier.SelectedIndexChanged
        CmbSupplier.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQuantity.KeyPress
        e.Handled = Not IsNumberOnly(sender.Text, e.KeyChar, False, True)
    End Sub
End Class