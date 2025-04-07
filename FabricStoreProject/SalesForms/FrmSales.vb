Imports System.Data.SqlClient
Imports System.Web.Services.Description
Imports System.Windows.Forms.AxHost
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FrmSales

    Private DS, DSDel, DsSave As DataSet
    Private IDPrint, QuantityS, ItemStoreID, CustomerID As Integer
    Private PurchasePrice As Double
    Private Operation As String
    Private CR As Integer = -1
    Private TailorID As Integer

    Public InvoiceID As Integer


    Private Sub FrmSales_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            GetData()
            TxtUserName.Text = UserName
            TxtMaterialNum.Select()
            TxtMaterialNum.Focus()

            TLPInvo.Top = (Me.Height - TLPInvo.Height) / 2
            TLPInvo.Left = (Me.Width - TLPInvo.Width) / 2.0
            TLPInvo.Visible = False
            'FLPInvo.BringToFront()

            TLPTailor.Top = (Me.Height - TLPTailor.Height) / 2
            TLPTailor.Left = (Me.Width - TLPTailor.Width) / 2.0
            TLPTailor.SendToBack()

            TLPDelivery.Top = (Me.Height - TLPDelivery.Height) / 2
            TLPDelivery.Left = (Me.Width - TLPDelivery.Width) / 2.0
            TLPDelivery.SendToBack()

        Else
            ChangeControlColor(Me)
            BtnClean.PerformClick()
            CmbCustomer.Text = ""
            DGVInvoContent.Rows.Clear()
            Clear(Me)
            If Not IsNothing(DS) Then
                DS.Clear()
            End If

        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub GetData()
        Dim sqlcon As New SQLConClass()
        SQLQuery = "  Select  ID,Name from UserView where EndService IS Null "
        SQLQuery &= "  Select ID,Name From CustomersTable  "
        SQLQuery &= " Select *  from ItemsView where EndService IS NUll And Type =1"
        SQLQuery &= " Select ISNull(Max(Num ),0)+1 Num from InvoceTable    
                      Select * From TailorsTable where EndService IS NUll 
                      Select * From ServicesTable 
                      Select * From DeliveryTable 
                      Select * From CityTable "
        If InvoiceID <> 0 Then
            SQLQuery += " select * from invoiceView where ID= " & InvoiceID
            SQLQuery += " select * from SaleContentsView where InvoceID= " & InvoiceID
        End If
        DS = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DS) Then
            If DS.Tables(3).Rows.Count > 0 Then
                TxtInvoNum.Text = Format(DS.Tables(3).Rows(0).Item(0), "000000")
            Else
                TxtInvoNum.Text = "00001"
            End If
            FillCmb()

            If InvoiceID <> 0 Then
                FillDGV(DS.Tables(9))
            End If
        End If

    End Sub

    Private Sub FillCmb()
        CmbMaterial.DataSource = DS.Tables(2)
        CmbMaterial.DisplayMember = "Name"
        CmbMaterial.ValueMember = "ItemStoreID"
        CmbMaterial.SelectedIndex = -1

        CmbCustomer.DataSource = DS.Tables(1)
        CmbCustomer.DisplayMember = "Name"
        CmbCustomer.ValueMember = "ID"
        'CmbCustomer.SelectedIndex = -1

        CmbTailor.DataSource = DS.Tables(4)
        CmbTailor.DisplayMember = "Name"
        CmbTailor.ValueMember = "ID"
        CmbTailor.SelectedIndex = -1

        CmbService.DataSource = DS.Tables(5)
        CmbService.DisplayMember = "Name"
        CmbService.ValueMember = "ID"
        CmbService.SelectedIndex = -1

        CmbDelivery.DataSource = DS.Tables(6)
        CmbDelivery.DisplayMember = "Name"
        CmbDelivery.ValueMember = "ID"
        CmbDelivery.SelectedIndex = -1

        CmbCity.DataSource = DS.Tables(7)
        CmbCity.DisplayMember = "Name"
        CmbCity.ValueMember = "ID"
        CmbCity.SelectedIndex = -1
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        TLPInvo.Visible = False
    End Sub

    Private Sub BtnSaveInvo_Click(sender As Object, e As EventArgs) Handles BtnSaveInvo.Click
        'If IDPrint <> 0 Then
        '    MsgTool("تم حفظ الفاتورة", 1)
        '    Exit Sub
        'End If

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=99")

        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية الإضافة", 0)
        '    Exit Sub
        'End If

        IsDataMissing = False
        If IsNothing(CmbCustomer.SelectedValue) Then
            CmbCustomer.BackColor = RedColor
            MsgTool("يرجى اختيار زبون ", 0)
            Exit Sub
        End If

        Dim SQLCon = New SQLConClass
        Dim DSInvo As New DataSet
        Dim Param() As SqlParameter = {
            New SqlParameter("@InvoNum", TxtInvoNum.Text.Trim),
            New SqlParameter("@CustomerID", CmbCustomer.SelectedValue),
            New SqlParameter("@UserID", UserID)
        }
        DSInvo = SQLCon.CMDExecuteData("SaveSaleInvoice", Param)


        If Not DSHasTables(DSInvo) Then Exit Sub
        If Save = 1 Then
            MsgTool("تم فتح فاتورة جديدة", 1)
            TxtSavedInvoNum.Text = DSInvo.Tables(0).Rows(0).Item("Num")
            IDPrint = DSInvo.Tables(0).Rows(0).Item("ID")
            InvoiceID = DSInvo.Tables(0).Rows(0).Item("ID")

        End If

        CustomerID = CmbCustomer.SelectedValue
        TLPInvo.SendToBack()
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        TLPCustomer.Visible = True
        TLPCustomer.BringToFront()
    End Sub

    Private Sub CmbMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMaterial.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbMaterial_TextChanged(sender As Object, e As EventArgs) Handles CmbMaterial.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbMaterial_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbMaterial.SelectionChangeCommitted

        If CmbMaterial.SelectedValue Is Nothing Or CmbMaterial.SelectedValue = -1 Then Exit Sub
        Dim sqlcon As New SQLConClass
        SQLQuery = " Select *  From ItemsView where EndService IS NUll and ItemStoreID=" & CmbMaterial.SelectedValue
        Dim DsMaterial As DataSet
        DsMaterial = sqlcon.SelectData(SQLQuery)
        Dim ItemRow() As DataRow = DsMaterial.Tables(0).Select("ItemStoreID=" & CmbMaterial.SelectedValue)

        If ItemRow.Length = 0 Then Exit Sub

        TxtMaterialNum.Text = Format(ItemRow(0)("Num"), "000000")
        TxtCountry.Text = ItemRow(0)("Country")
        TxtSellPrice.Text = Format(ItemRow(0)("Price"), "0.000")
        TxtQuantityS.Text = ItemRow(0)("Quantity")
        QuantityS = 0
        PurchasePrice = 0
        QuantityS = ItemRow(0)("Quantity")
        PurchasePrice = ItemRow(0)("PurchasePrice")
        TxtQuantity.Text = ""
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
        TxtSellPrice.Text = Format(ItemRow(0)("Price"), "0.000")
        TxtQuantityS.Text = ItemRow(0)("Quantity")
        QuantityS = 0
        PurchasePrice = 0
        QuantityS = ItemRow(0)("Quantity")
        PurchasePrice = ItemRow(0)("PurchasePrice")
        TxtQuantity.Text = ""
    End Sub

    Private Sub TxtSellPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtSellPrice.TextChanged
        sender.BackColor = SystemColors.Window
        If Val(TxtSellPrice.Text) <= 0 Then TxtSellPrice.Text = ""
        If Val(TxtQuantity.Text) > 0 Then
            TxtTotalMaterial.Text = Val(TxtQuantity.Text) * Val(TxtSellPrice.Text)
        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantity.TextChanged
        sender.BackColor = SystemColors.Window

        If Val(TxtQuantity.Text) <= 0 Then
            TxtQuantity.Text = ""
            TxtQuantityS.Text = QuantityS
        End If

        If Val(TxtQuantity.Text) > Val(TxtQuantityS.Text) Then
            TxtQuantity.Text = ""
            MsgTool("الكمية أكبر من الموجودة في المخزن", 0)
            Exit Sub
        End If

        TxtQuantityS.Text = Val(TxtQuantityS.Text) - Val(TxtQuantity.Text)
        If TxtTailorPrice.Text = "" Then
            If Val(TxtSellPrice.Text) > 0 Then
                TxtTotalMaterial.Text = Format(Val(TxtQuantity.Text) * Val(TxtSellPrice.Text), "0.000")
            End If

        Else
            If Val(TxtSellPrice.Text) > 0 Then
                TxtTotalMaterial.Text = Format(Val(TxtQuantity.Text) * (Val(TxtSellPrice.Text) + Val(TxtTailorPrice.Text)), "0.000")
            End If
        End If

    End Sub

    Private Sub TxtTailorPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtTailorPrice.TextChanged
        If TxtTailorPrice.Text = "" Then
            If Val(TxtSellPrice.Text) > 0 Then
                TxtTotalMaterial.Text = Format(Val(TxtQuantity.Text) * Val(TxtSellPrice.Text), "0.000")
            End If

        Else
            If Val(TxtSellPrice.Text) > 0 Then
                TxtTotalMaterial.Text = Format(Val(TxtQuantity.Text) * (Val(TxtSellPrice.Text) + Val(TxtTailorPrice.Text)), "0.000")
            End If
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtSavedInvoNum.Text = "" Then
            MsgTool("يرجى فتح فاتورة أولاً", 0)
            Exit Sub
        End If

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
                Row.Cells(4).Value += Val(TxtQuantity.Text)
                Row.Cells(3).Value = Format(Val(TxtSellPrice.Text), "0.000") 'سعر البيع يتعدل 
                Row.Cells(5).Value = Format(Row.Cells(4).Value * Row.Cells(3).Value, "0.000") 'الاجمالي يتعدل
                Row.Cells(6).Value = CmbMaterial.SelectedValue
                Row.Cells(8).Value = TxtCountry.Text
                Row.Cells(9).Value = TxtQuantityS.Text
                Row.Selected = True
                DGVInvoContent.FirstDisplayedScrollingRowIndex = (Row.Index)
                Cr = Row.Index

                GetTotal()
            End If

        Next
        '   ******************************************************************---------------------
        ' اضافة صف جديد بكمية مبدئية 1 

        If ISInDGV = False Then
            DGVInvoContent.Rows.Add(DGVInvoContent.Rows.Count + 1,
                                    Val(TxtMaterialNum.Text),
                                    CmbMaterial.Text,
                                    Format(Val(TxtSellPrice.Text), "0.000"),
                                    Val(TxtQuantity.Text),
                                    Format(Val(TxtTotalMaterial.Text), "0.000"),
                                    CmbMaterial.SelectedValue,
                                    0,
                                    TxtCountry.Text.Trim)
        End If
        Cr = DGVInvoContent.Rows.Count - 1
        DGVInvoContent.Rows(Cr).Selected = True
        DGVInvoContent.FirstDisplayedScrollingRowIndex = (Cr)
        GetTotal()
        DGVInvoContent.ClearSelection()
        TailorID = 0
        Dim ServiceID As Integer = 0
        Dim TailorPrice As Integer = 0
        Dim Size As String = ""
        Dim Type As String
        If Not IsNothing(CmbTailor.SelectedValue) Then
            TailorID = CmbTailor.SelectedValue
        End If

        If Not IsNothing(CmbService.SelectedValue) Then
            ServiceID = CmbService.SelectedValue
            TailorPrice = Val(TxtTailorPrice.Text)
        End If

        If TxtSize.Text <> "" Then
            Size = TxtSize.Text.Trim
        End If
        If RadReady.Checked Then
            Type = "Ready"

        Else
            Type = "Order"
        End If
        Dim SQLCon = New SQLConClass
        Dim DSInvoContent As New DataSet
        Dim Param() As SqlParameter = {
            New SqlParameter("@InvoID", InvoiceID),
            New SqlParameter("@ItemStoreID", CmbMaterial.SelectedValue),
            New SqlParameter("@Total", Val(TxtTotalMaterial.Text)),
            New SqlParameter("@SellPrice", Val(TxtSellPrice.Text)),
            New SqlParameter("@TailorPrice", TailorPrice),
            New SqlParameter("@PurchasePrice", PurchasePrice),
            New SqlParameter("@Quantity", Val(TxtQuantity.Text)),
            New SqlParameter("@TailorID", TailorID),
            New SqlParameter("@ServiceID", ServiceID),
            New SqlParameter("@Size", Size),
            New SqlParameter("@Type", Type)}
        DSInvoContent = SQLCon.CMDExecuteData("SaveSaleInvoiceContents", Param)


        If Not DSHasTables(DSInvoContent) Then Exit Sub
        If Save = 1 Then
            MsgTool("تم حفظ الفاتورة بنجاح", 1)

            BtnClean_Click(sender, e)
            FillDGV(DSInvoContent.Tables(0))
            GetTotal()
            'Dim CashingForm As New FrmSupplierInvoiceCashing

            'CashingForm.ShowDialog()
        End If
    End Sub

    Private Sub FillDGV(DT As DataTable)
        DGVInvoContent.Rows.Clear()
        For i = 0 To DT.Rows.Count - 1
            With DT.Rows(i)

                DGVInvoContent.Rows.Add()
                DGVInvoContent.Item(0, i).Value = i + 1
                DGVInvoContent.Item(1, i).Value = .Item("Num")
                DGVInvoContent.Item(2, i).Value = .Item("Name")
                DGVInvoContent.Item(3, i).Value = Format(.Item("Price"), "0.00")
                DGVInvoContent.Item(4, i).Value = .Item("Quantity")
                DGVInvoContent.Item(5, i).Value = Format(.Item("Total"), "0.00")
                DGVInvoContent.Item(6, i).Value = .Item("ItemStoreID")
                DGVInvoContent.Item(7, i).Value = .Item("PurchasePrice")
                DGVInvoContent.Item(8, i).Value = .Item("Country")
                DGVInvoContent.Item(9, i).Value = .Item("QuantityS")
                If .Item("Type") = 1 Then
                    DGVInvoContent.Item(10, i).Value = "قماش"

                Else
                    DGVInvoContent.Item(10, i).Value = "ملابس"
                End If

            End With
        Next
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
        Clear(TLPOrder)

        ChangeControlColor(Me)
        DGVInvoContent.ClearSelection()

        GetData()

    End Sub

    Private Sub TxtTotalMaterial_Click(sender As Object, e As EventArgs) Handles TxtTotalMaterial.Click
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ChangeControlColor(Me)
        Clear(TLPData)
        DGVInvoContent.Rows.Clear()
        BtnClean.PerformClick()
        CmbCustomer.Text = ""
        DGVInvoContent.Rows.Clear()
        TxtTotal.Text = ""
        TxtSavedInvoNum.Text = ""
        InvoiceID = 0
        GetData()
        IDPrint = 0

        'FLPInvo.BringToFront()
    End Sub

    Private Sub TxtMaterialNum_TextChanged(sender As Object, e As EventArgs) Handles TxtMaterialNum.TextChanged
        TxtMaterialNum.BackColor = SystemColors.Window
        If TxtMaterialNum.Text.Trim = vbNullString Then ClearMaterial()
    End Sub

    Private Sub TxtMaterialNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMaterialNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtMaterialNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtMaterialNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub ClearMaterial()
        TxtSellPrice.Text = ""
        TxtQuantity.Text = ""
        TxtTotalMaterial.Text = ""
        CmbMaterial.DataSource = Nothing
    End Sub

    Private Sub CmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCustomer.SelectedIndexChanged

    End Sub

    Private Sub CmbCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSaveInvo_Click(sender, e)
        End If
    End Sub

    Private Sub TxtSellPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSellPrice.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub RadOrder_CheckedChanged(sender As Object, e As EventArgs) Handles RadOrder.CheckedChanged
        If RadOrder.Checked Then
            BtnTailor.Enabled = True
            TLPTailor.Visible = True
        Else
            BtnTailor.Enabled = False
            TLPTailor.Visible = False
        End If
    End Sub

    Private Sub RadReady_CheckedChanged(sender As Object, e As EventArgs) Handles RadReady.CheckedChanged
        If RadReady.Checked Then
            BtnTailor.Enabled = False
            TLPTailor.Visible = False
        Else
            BtnTailor.Enabled = True
            TLPTailor.Visible = True
        End If
    End Sub

    Private Sub CmbTailor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTailor.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbTailor_TextChanged(sender As Object, e As EventArgs) Handles CmbTailor.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtSize_TextChanged(sender As Object, e As EventArgs) Handles TxtSize.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnInvoData_Click(sender As Object, e As EventArgs) Handles BtnInvoData.Click
        TLPInvo.Visible = True
        'If TLPInvo.Visible = True Then
        TLPInvo.BringToFront()
        'Else
        '    TLPInvo.SendToBack()
        'End If
    End Sub

    Private Sub BtnTailor_Click(sender As Object, e As EventArgs) Handles BtnTailor.Click
        'TLPTailor.Visible = Not TLPTailor.Visible
        'If FLPTailor.Visible = True Then
        TLPTailor.BringToFront()
        'Else
        '    FLPTailor.SendToBack()
        'End If
    End Sub

    Private Sub BtnDelivery_Click(sender As Object, e As EventArgs) Handles BtnDelivery.Click
        If InvoiceID = 0 Then
            MsgTool("لا يوجد فاتورة", 0)
            Exit Sub
        End If

        If DGVInvoContent.RowCount = 0 Then
            MsgTool("الفاتورة فارغة", 0)
            Exit Sub
        End If

        'TLPDelivery.Visible = Not TLPDelivery.Visible
        'If TLPDelivery.Visible = True Then
        TLPDelivery.Visible = True
        TLPDelivery.BringToFront()
        'Else
        '    TLPDelivery.SendToBack()
        'End If
    End Sub

    Private Sub CmbService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbService.SelectedIndexChanged

    End Sub

    Private Sub DGVInvoContent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInvoContent.CellContentClick
        If CheckDGVError(DGVInvoContent) Then Exit Sub
        If DGVInvoContent.Rows.Count = 0 Then Exit Sub
        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name

        CR = DGVInvoContent.CurrentRow.Index

        Dim Quantity As Integer = Convert.ToInt32(DGVInvoContent.Item(4, CR).Value)
        Dim QuantityS As Integer = Convert.ToInt32(DGVInvoContent.Item(9, CR).Value)

        If Col = "Del" Then

            ItemStoreID = DGVInvoContent.Item(6, CR).Value
            If vbYes = MsgBox("هل تريد حذف الصنف " & vbCrLf & "( " & DGVInvoContent.Item(2, CR).Value & " ) من الفاتورة ؟ ", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الحذف") Then
                Dim SQLCon = New SQLConClass
                Dim Param() As SqlParameter = {
                New SqlParameter("@ID", ItemStoreID),
                New SqlParameter("@IDInvo", InvoiceID)}

                DSDel = SQLCon.CMDExecuteData("DeleteItemInvo", Param)
                If Save = 1 Then
                    MsgTool("تمت حذف الصنف", 1)
                    BtnClean_Click(sender, e)
                    FillDGV(DSDel.Tables(0))
                    GetTotal()
                End If
            End If

        ElseIf Col = "ColIncrease" Then
            If QuantityS >= 1 Then
                Operation = "Inc"
                EditInvo()

            Else
                MsgTool("الكمية نفذت من المخزن", 0)
            End If


        ElseIf Col = "ColDecrease" Then 'And Quantity > 1

            If Quantity > 1 Then
                Operation = "Dec"
                EditInvo()

            Else
                If vbYes = MsgBox("هل تريد حذف الصنف " & vbCrLf & "( " & DGVInvoContent.Item(2, CR).Value & " ) من الفاتورة ؟ ", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الحذف") Then
                    Operation = "Dec"
                    EditInvo()
                End If

            End If
        End If
        Operation = ""

    End Sub

    Private Sub BtnCloseDelivery_Click(sender As Object, e As EventArgs) Handles BtnCloseDelivery.Click
        ChangeControlColor(TLPDeliveryData)
        TLPDelivery.SendToBack()
    End Sub

    Private Sub BtnCloseTailor_Click(sender As Object, e As EventArgs) Handles BtnCloseTailor.Click
        ChangeControlColor(TLPOrder)
        TLPTailor.SendToBack()
    End Sub

    Private Sub BtnSaveTailor_Click(sender As Object, e As EventArgs) Handles BtnSaveTailor.Click
        'IsDataMissing = False
        'IsInputEmpty(TLPOrder)

        'If IsDataMissing = True Then
        '    MsgTool("يرجى التأكد من البيانات", 0)
        '    Exit Sub
        'End If
        TLPTailor.SendToBack()
    End Sub

    Private Sub BtnSaveDelivery_Click(sender As Object, e As EventArgs) Handles BtnSaveDelivery.Click
        IsDataMissing = False
        IsInputEmpty(TLPDeliveryData)

        If IsDataMissing = True Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim SQLCon = New SQLConClass
        Dim DSInvo As New DataSet
        Dim Param() As SqlParameter = {
            New SqlParameter("@InvoiceID", InvoiceID),
            New SqlParameter("@CityID", CmbCity.SelectedValue),
            New SqlParameter("@Address", TxtAddress.Text.Trim),
            New SqlParameter("@Phone", TxtPhone.Text.Trim),
            New SqlParameter("@DeliveryID", CmbDelivery.SelectedValue),
            New SqlParameter("@DeliveryPrice", TxtDeliveryPrice.Text.Trim),
            New SqlParameter("@UserID", UserID)
        }
        DSInvo = SQLCon.CMDExecuteData("SaveDeliveryInvoice", Param)

        TLPDelivery.SendToBack()
    End Sub

    Private Sub EditInvo()
        Dim SQLCon = New SQLConClass
        Dim DSInvoContent As New DataSet
        Dim Param() As SqlParameter = {
            New SqlParameter("@InvoID", InvoiceID),
            New SqlParameter("@ItemStoreID", DGVInvoContent.Item(6, CR).Value),
            New SqlParameter("@Total", DGVInvoContent.Item(5, CR).Value),
            New SqlParameter("@SellPrice", DGVInvoContent.Item(3, CR).Value),
            New SqlParameter("@PurchasePrice", DGVInvoContent.Item(7, CR).Value),
            New SqlParameter("@Quantity", 1),
            New SqlParameter("@Operation", Operation)
        }
        DSInvoContent = SQLCon.CMDExecuteData("EditSaleInvoiceContents", Param)


        If Not DSHasTables(DSInvoContent) Then Exit Sub
        If Save = 1 Then
            MsgTool("تم حفظ الفاتورة بنجاح", 1)

            Clear(TLPData)
            ChangeControlColor(Me)
            DGVInvoContent.ClearSelection()


            FillDGV(DSInvoContent.Tables(0))
            GetTotal()

            'Dim CashingForm As New FrmSupplierInvoiceCashing

            'CashingForm.ShowDialog()
        End If
    End Sub

    Private Sub TxtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQuantity.KeyPress
        e.Handled = Not IsNumberOnly(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub BtnReceipt_Click(sender As Object, e As EventArgs) Handles BtnReceipt.Click
        If InvoiceID = 0 Then
            MsgTool("لا يوجد فاتورة", 0)
            Exit Sub
        End If

        FrmReceipt.CIDSearch = CustomerID
        'FrmSalesContainer.LblReceipt_Click(sender, e)
        FrmReceipt.ShowDialog()

        'FrmCustomerInvoiceReceipt.CustomerID = CustomerID
        'FrmCustomerInvoiceReceipt.ShowDialog()
    End Sub

    Private Sub CmbService_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbService.SelectionChangeCommitted
        Dim DT As DataTable = DS.Tables(5)
        If IsNothing(CmbService.SelectedValue) Then Exit Sub

        Dim rows() As DataRow = DT.Select("ID = " & CmbService.SelectedValue)
        If rows.Length > 0 Then
            TxtTailorPrice.Text = rows(0)("Price").ToString()
        Else
            TxtTailorPrice.Text = 0
        End If
    End Sub

    Private Sub CmbDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDelivery.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbDelivery_TextChanged(sender As Object, e As EventArgs) Handles CmbDelivery.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

    End Sub

    Private Sub BtnCloseCustomer_Click(sender As Object, e As EventArgs) Handles BtnCloseCustomer.Click
        TLPCustomer.Visible = False
    End Sub

    Private Sub TxtInvoNum_TextChanged(sender As Object, e As EventArgs) Handles TxtInvoNum.TextChanged

    End Sub

    Private Sub TxtInvoNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtInvoNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone.TextChanged

    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress
        e.Handled = Not IsPhone(sender.Text, e)
    End Sub

    Private Sub BtnSaveCustomer_Click(sender As Object, e As EventArgs) Handles BtnSaveCustomer.Click
        IsDataMissing = False
        IsInputEmpty(TLPCustomerData)

        If TxtPhoneCustomer.Text.Length <> 10 Then
            TxtPhoneCustomer.BackColor = RedColor
            MsgTool("يرجى اختيار رقم هاتف صحيح", 0)
            Exit Sub
        End If

        Dim PhoneNum As String
        PhoneNum = TxtPhoneCustomer.Text.Substring(0, 2)

        If PhoneNum <> "09" Then
            MsgTool("يرجى التأكد من الرقم الهاتف", 0)
            TxtPhoneCustomer.BackColor = RedColor
            Exit Sub
        End If

        Dim Sqlcon As New SQLConClass()
        Dim param() As SqlParameter = {
             New SqlParameter("@ID", CustomerReportID),
             New SqlParameter("@Name", TxtNameCustomer.Text),
             New SqlParameter("@Address", TxtAddress.Text),
             New SqlParameter("@Phone1", TxtPhoneCustomer.Text),
             New SqlParameter("@Phone2", TxtPhoneCustomer.Text)}

        DsSave = Sqlcon.CMDExecuteData("SaveCustomer", param)
        If DSHasTables(DsSave) Then
            If Save = 2 Then
                MsgTool("هذا الإسم مسجل بالفعل", 0)
                TxtNameCustomer.SelectAll()
                TxtNameCustomer.Focus()

            ElseIf Save = 1 Then
                MsgTool("تم حفظ بيانات الزبون", 1)
                If DsSave.Tables(0).Rows.Count > 0 Then
                    CmbCustomer.DataSource = DsSave.Tables(0)
                    CmbCustomer.ValueMember = "ID"
                    CmbCustomer.DisplayMember = "Name"
                    CmbCustomer.SelectedValue = DsSave.Tables(1).Rows(0).Item(0)

                    Clear(TLPCustomerData)
                    TLPCustomer.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub CmbCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCity.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCity_TextChanged(sender As Object, e As EventArgs) Handles CmbCity.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtAddress_TextChanged(sender As Object, e As EventArgs) Handles TxtAddress.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtDeliveryPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtDeliveryPrice.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

End Class