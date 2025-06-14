Imports System.Data.SqlClient
Imports System.Net.NetworkInformation
Imports System.Web.Services.Description
Imports System.Windows.Forms.AxHost
Imports Microsoft.VisualBasic.ApplicationServices
Imports ZXing
Imports System.Drawing.Printing

Public Class FrmSales

    Private DS, DSDel, DsSave, DsMaterial, DSService As DataSet
    Private DT, DTMat, DTCustomerSize As DataTable
    Private IDPrint, QuantityS, ItemStoreID, CustomerID, OrderID As Integer
    Private PurchasePrice As Double
    Private Operation As String
    Private CR As Integer = -1

    Public InvoiceID, customerSizeID As Integer

    Private TailorID, ServiceID, InvoNum, ItemType As Integer
    Dim TailorPrice, Armpit, Chest, CusHeight, Hip, Shoulder, Sleeve, Waist, InvoTotal As Double
    Dim ItemSize, Type As String
    Private bsItems As New BindingSource()


    Private Sub FrmSales_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            GetData()

            TxtUserName.Text = UserName
            TxtMaterialNum.Select()
            TxtMaterialNum.Focus()

            PnlInvo.Top = (Me.Height - PnlInvo.Height) / 2
            PnlInvo.Left = (Me.Width - PnlInvo.Width) / 2.0
            PnlInvo.Visible = False

            PnlTailor.Top = (Me.Height - PnlTailor.Height) / 2
            PnlTailor.Left = (Me.Width - PnlTailor.Width) / 2.0
            PnlTailor.Visible = False

            PnlDelivery.Top = (Me.Height - PnlDelivery.Height) / 2
            PnlDelivery.Left = (Me.Width - PnlDelivery.Width) / 2.0
            PnlDelivery.Visible = False

        Else
            ChangeControlColor(Me)
            BtnClean.PerformClick()
            CmbCustomer.Text = ""
            DGVInvoContent.Rows.Clear()
            Clear(Me)
            If Not IsNothing(DS) Then
                DS.Clear()
            End If
            InvoiceID = 0

            Clear(TLPData)
            Clear(TLPDeliveryData)
            Clear(TLPOrder)
            TxtTotal.Text = ""
            TxtSavedInvoNum.Text = ""
            IDPrint = 0
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub GetData()
        Dim sqlcon As New SQLConClass()
        SQLQuery = "  Select  ID,Name From UserView where EndService IS Null "
        SQLQuery &= "  Select ID,Name From CustomersTable   where EndService IS Null  "
        SQLQuery &= " Select ISNull(Max(Num ),0)+1 Num From InvoceTable    
                      Select * From TailorsTable where EndService IS NUll  Order By Name
                      Select * From ServicesTable 
                      Select * From DeliveryTable 
                      Select * From CityTable "
        SQLQuery += " Select  ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت, ItemStoreID, ItemStoreNum , Name, Quantity, Price, CASE 
                        WHEN Type = 1 THEN 'قماش'
                        WHEN Type = 2 THEN 'ملابس'
                        END AS Type, Size, PurchasePrice, CatID, Type ItemType
                       From ItemsView Where EndService IS Null And ItemStoreID not in(Select ItemStoreID From TailorContentTable)"
        If InvoiceID <> 0 Then
            SQLQuery += " select * From invoiceView where ID= " & InvoiceID
            SQLQuery += " select * From SaleContentsView where InvoceID= " & InvoiceID
            SQLQuery += " select * From DeliveryOrderTable where InvoiceID= " & InvoiceID 'هني جيبي متع الديلفري واعرضيها
            SQLQuery += "  Select * From CustomerSizesTable Where CustomerID = (Select CustomerID From InvoiceView Where ID =" & InvoiceID & ")"
        End If
        DS = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DS) Then
            If DS.Tables(2).Rows.Count > 0 Then
                TxtInvoNum.Text = Format(DS.Tables(2).Rows(0).Item(0), "000000")
            Else
                TxtInvoNum.Text = "00001"
            End If
            InvoNum = TxtInvoNum.Text
            FillCmb()

            If InvoiceID <> 0 Then

                IDPrint = InvoiceID
                FillDGV(DS.Tables(9))
                TxtSavedInvoNum.Text = DS.Tables(8).Rows(0).Item(1)
                TxtTotal.Text = Format(DS.Tables(8).Rows(0).Item(5), "0.00")
                CustomerID = DS.Tables(8).Rows(0).Item("CustomerID")

                LblCustomerName.Text = DS.Tables(8).Rows(0).Item("Name")
                CleanSizes()
                If DS.Tables(11).Rows.Count > 0 Then
                    DTCustomerSize = DS.Tables(11).Copy
                    FillCustomerSizes(DTCustomerSize)

                Else
                    CmbSizeName.DataSource = Nothing
                    CmbSizeName.Text = ""
                End If


                If DS.Tables(10).Rows.Count > 0 Then
                    OrderID = DS.Tables(10).Rows(0).Item("ID")
                    CmbDelivery.SelectedValue = DS.Tables(10).Rows(0).Item("DeliveryID")
                    CmbCity.SelectedValue = DS.Tables(10).Rows(0).Item("CityID")
                    TxtAddress.Text = DS.Tables(10).Rows(0).Item("Address")
                    TxtDeliveryPrice.Text = DS.Tables(10).Rows(0).Item("Price")
                    TxtPhone.Text = DS.Tables(10).Rows(0).Item("Phone")

                Else
                    OrderID = 0
                    CmbDelivery.SelectedValue = -1
                    CmbCity.SelectedValue = -1
                    TxtAddress.Text = ""
                    TxtDeliveryPrice.Text = ""
                    TxtPhone.Text = ""
                End If
                'هني اعرضي بيانات التوصيل لو فيه صفوف 
            End If
        End If

    End Sub

    Private Sub FillCustomerSizes(DT As DataTable)
        If DT.Rows.Count > 0 Then
            CmbSizeName.DataSource = DT
            CmbSizeName.DisplayMember = "Name"
            CmbSizeName.ValueMember = "ID"
            CmbSizeName.SelectedIndex = -1

        Else
            CmbSizeName.DataSource = Nothing
            CmbSizeName.Text = ""
        End If
    End Sub

    Private Sub FillCmb()

        If DS.Tables(7).Rows.Count > 0 Then
            CmbMaterial.DataSource = DS.Tables(7)
            CmbMaterial.DisplayMember = "Name"
            CmbMaterial.ValueMember = "ItemStoreID"
            CmbMaterial.SelectedIndex = -1

            If DTMat IsNot Nothing Then
                DTMat.Dispose()
            End If

            DTMat = DS.Tables(7).Copy

            bsItems.DataSource = DTMat
            DGVItems.DataSource = bsItems
            DGVItems.ClearSelection()
            SetDGVHeader()

        Else
            CmbMaterial.DataSource = Nothing
            CmbMaterial.ValueMember = ""
            CmbMaterial.DisplayMember = ""
            CmbMaterial.SelectedIndex = -1
            CmbMaterial.Text = ""

            If DTMat IsNot Nothing Then
                DTMat.Clear()
            End If
            DGVItems.DataSource = bsItems
            bsItems.DataSource = Nothing
            DGVItems.DataSource = Nothing
            'If IsNothing(DTMat) Then
            '    DTMat.Dispose()
            'End If
        End If

        CmbCustomer.DataSource = DS.Tables(1)
        CmbCustomer.DisplayMember = "Name"
        CmbCustomer.ValueMember = "ID"
        'CmbCustomer.SelectedIndex = -1

        CmbTailor.DataSource = DS.Tables(3)
        CmbTailor.DisplayMember = "Name"
        CmbTailor.ValueMember = "ID"
        CmbTailor.SelectedIndex = -1

        'CmbService.DataSource = DS.Tables(4)
        'CmbService.DisplayMember = "Name"
        'CmbService.ValueMember = "ID"
        'CmbService.SelectedIndex = -1

        CmbDelivery.DataSource = DS.Tables(5)
        CmbDelivery.DisplayMember = "Name"
        CmbDelivery.ValueMember = "ID"
        CmbDelivery.SelectedIndex = -1

        CmbCity.DataSource = DS.Tables(6)
        CmbCity.DisplayMember = "Name"
        CmbCity.ValueMember = "ID"
        CmbCity.SelectedIndex = -1
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        PnlInvo.Visible = False
        TxtMaterialNum.Focus()
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
        If IsInputEmpty(TlpInvoData) Then IsDataMissing = True
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
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
        LblCustomerName.Text = CmbCustomer.Text
        PnlInvo.Visible = False

        CleanSizes()
        If DSInvo.Tables(1).Rows.Count > 0 Then
            DTCustomerSize = DSInvo.Tables(1).Copy
            FillCustomerSizes(DTCustomerSize)

        Else
            CmbSizeName.DataSource = Nothing
            CmbSizeName.Text = ""
        End If
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        TLPCustomer.Top = (Me.Height - TLPCustomer.Height) / 2
        TLPCustomer.Left = (Me.Width - TLPCustomer.Width) / 2.0
        TLPCustomer.Visible = True
        TLPCustomer.BringToFront()
        TxtNameCustomer.Focus()
    End Sub

    Private Sub CmbMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMaterial.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbMaterial_TextChanged(sender As Object, e As EventArgs) Handles CmbMaterial.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbMaterial_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbMaterial.SelectionChangeCommitted
        TxtQuantityS.Text = ""
        ItemType = 0
        DGVItems.ClearSelection()

        If CmbMaterial.SelectedValue Is Nothing Or CmbMaterial.SelectedValue = -1 Then Exit Sub
        Dim ItemRow() As DataRow = DS.Tables(7).Select("ItemStoreID=" & CmbMaterial.SelectedValue)

        If ItemRow.Length = 0 Then Exit Sub

        TxtMaterialNum.Text = ItemRow(0)("ItemStoreNum")
        TxtSellPrice.Text = Format(ItemRow(0)("Price"), "0.00")
        LblType.Text = ItemRow(0)("Type")
        TxtQuantityS.Text = ItemRow(0)("Quantity")
        QuantityS = 0
        PurchasePrice = 0
        QuantityS = ItemRow(0)("Quantity")
        PurchasePrice = ItemRow(0)("PurchasePrice")
        TxtQuantity.Text = ""
        ItemType = ItemRow(0)("ItemType")

        For i = 0 To DGVItems.Rows.Count - 1
            If TxtMaterialNum.Text.Trim = DTMat.Rows(i).Item(2) Then
                DGVItems.Rows(i).Selected = True
                DGVItems.FirstDisplayedScrollingRowIndex = i
            End If
        Next
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        'If IsNothing(CmbCat.SelectedValue) Then Exit Sub

        If Val(TxtMaterialNum.Text) = 0 Or TxtMaterialNum.Text = "" Then
            TxtMaterialNum.BackColor = RedColor
            Exit Sub
        End If

        Dim sqlcon As New SQLConClass()
        SQLQuery = " Select  ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت, ItemStoreID, ItemStoreNum , Name, Quantity, Price, CASE 
                        WHEN Type = 1 THEN 'قماش'
                        WHEN Type = 2 THEN 'ملابس'
                        END AS Type, Size, PurchasePrice, CatID, Type ItemType
                       From ItemsView Where EndService IS Null And ItemStoreID not in(Select ItemStoreID From TailorContentTable)"

        DsMaterial = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DsMaterial) Then

            Dim ItemRow() As DataRow = DsMaterial.Tables(0).Select("ItemStoreNum='" & TxtMaterialNum.Text.Trim & "'")
            If ItemRow.Length = 0 Then
                MsgTool("الصنف غير موجود", 0)
                CmbMaterial.Text = ""
                TxtSellPrice.Clear()
                LblType.Text = ""
                TxtQuantityS.Text = ""
                DGVItems.ClearSelection()
                Exit Sub
            End If

            For i As Integer = 0 To CmbMaterial.Items.Count - 1
                If CType(CmbMaterial.Items(i), DataRowView)("ItemStoreID") = ItemRow(0)("ItemStoreID") Then
                    CmbMaterial.SelectedIndex = i
                    ItemType = ItemRow(0)("ItemType")
                    Exit For
                End If
            Next

            UpdateFieldsForSelectedItem()
        End If
    End Sub

    Private Sub UpdateFieldsForSelectedItem()
        TxtQuantityS.Text = ""
        If CmbMaterial.SelectedValue Is Nothing Then Exit Sub

        Dim SelectedItem As DataRowView = CType(CmbMaterial.SelectedItem, DataRowView)
        Dim sqlcon As New SQLConClass()
        SQLQuery = " Select  ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت, ItemStoreID, ItemStoreNum , Name, Quantity, Price, CASE 
                        WHEN Type = 1 THEN 'قماش'
                        WHEN Type = 2 THEN 'ملابس'
                        END AS Type, Size, PurchasePrice, CatID, Type ItemType
                       From ItemsView Where EndService IS Null And ItemStoreID not in(Select ItemStoreID From TailorContentTable)"

        DsMaterial = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DsMaterial) Then
            Dim ItemRow() As DataRow = DsMaterial.Tables(0).Select("ItemStoreID=" & SelectedItem("ItemStoreID"))

            If ItemRow.Length = 0 Then Exit Sub

            TxtMaterialNum.Text = ItemRow(0)("ItemStoreNum")
            TxtSellPrice.Text = Format(ItemRow(0)("Price"), "0.00")
            LblType.Text = ItemRow(0)("Type")
            TxtQuantityS.Text = ItemRow(0)("Quantity")
            QuantityS = 0
            PurchasePrice = 0
            QuantityS = ItemRow(0)("Quantity")
            PurchasePrice = ItemRow(0)("PurchasePrice")
            TxtQuantity.Text = ""
            For i = 0 To DGVItems.Rows.Count - 1
                If TxtMaterialNum.Text.Trim = DTMat.Rows(i).Item(2) Then
                    DGVItems.Rows(i).Selected = True
                    DGVItems.FirstDisplayedScrollingRowIndex = i
                End If
            Next
        End If
    End Sub

    Private Sub TxtSellPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtSellPrice.TextChanged
        sender.BackColor = SystemColors.Window
        If Val(TxtSellPrice.Text) <= 0 Then TxtSellPrice.Text = ""
        If Val(TxtQuantity.Text) > 0 Then
            'TxtTotalMaterial.Text = Val(TxtQuantity.Text) * Val(TxtSellPrice.Text)
        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantity.TextChanged
        sender.BackColor = SystemColors.Window

        If Val(TxtQuantity.Text) <= 0 Then
            TxtQuantity.Text = ""
            TxtQuantityS.Text = QuantityS
        End If

        If Val(TxtQuantityS.Text) = 0 And InvoiceID <> 0 Then
            TxtQuantity.Text = ""
            MsgTool("نفذت الكمية من المخزن", 0)
            Exit Sub
        End If

        If Val(TxtQuantity.Text) > Val(TxtQuantityS.Text) Then
            TxtQuantity.Text = ""
            MsgTool("الكمية أكبر من الموجودة في المخزن", 0)
            Exit Sub
        End If

        TxtQuantityS.Text = Val(TxtQuantityS.Text) - Val(TxtQuantity.Text)
        If TxtTailorPrice.Text = "" Then
            If Val(TxtSellPrice.Text) > 0 Then
                InvoTotal = Val(TxtQuantity.Text) * Val(TxtSellPrice.Text)
            End If

        Else
            If Val(TxtSellPrice.Text) > 0 Then
                InvoTotal = Val(TxtQuantity.Text) * (Val(TxtSellPrice.Text) + Val(TxtTailorPrice.Text))
            End If
        End If

    End Sub

    Private Sub TxtTailorPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtTailorPrice.TextChanged
        If TxtTailorPrice.Text = "" Then
            If Val(TxtSellPrice.Text) > 0 Then
                InvoTotal = Val(TxtQuantity.Text) * Val(TxtSellPrice.Text)
            End If

        Else
            If Val(TxtSellPrice.Text) > 0 Then
                InvoTotal = Val(TxtQuantity.Text) * ((Val(TxtSellPrice.Text) + Val(TxtTailorPrice.Text)))
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
                Row.Cells(3).Value = Format(Val(TxtSellPrice.Text), "0.00") 'سعر البيع يتعدل 
                Row.Cells(5).Value = Format(Row.Cells(4).Value * Row.Cells(3).Value, "0.00") 'الاجمالي يتعدل
                Row.Cells(6).Value = CmbMaterial.SelectedValue
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
            DGVInvoContent.Rows.Add(DGVInvoContent.Rows.Count + 1,'0
                                    Val(TxtMaterialNum.Text),'1
                                    CmbMaterial.Text,'2
                                    Format(Val(TxtSellPrice.Text), "0.00"),'3
                                    Val(TxtQuantity.Text),'4
                                    Format(Val(InvoTotal), "0.00"),'5
                                    CmbMaterial.SelectedValue,'6
                                    0,'7
                                    0,'8
                                    TxtQuantityS.Text) ',
            'TxtCountry.Text.Trim)
        End If
        Cr = DGVInvoContent.Rows.Count - 1
        DGVInvoContent.Rows(Cr).Selected = True
        DGVInvoContent.FirstDisplayedScrollingRowIndex = (Cr)
        GetTotal()
        DGVInvoContent.ClearSelection()

        GetOrderTailorData()
        Dim SQLCon = New SQLConClass
        Dim DSInvoContent As New DataSet
        Dim Param() As SqlParameter = {
            New SqlParameter("@InvoID", InvoiceID),
            New SqlParameter("@customerSizeID", customerSizeID),
            New SqlParameter("@ItemStoreID", CmbMaterial.SelectedValue),
            New SqlParameter("@Total", InvoTotal),
            New SqlParameter("@SellPrice", Val(TxtSellPrice.Text)),
            New SqlParameter("@TailorPrice", TailorPrice),
            New SqlParameter("@PurchasePrice", PurchasePrice),
            New SqlParameter("@Quantity", Val(TxtQuantity.Text)),
            New SqlParameter("@TailorID", TailorID),
            New SqlParameter("@ServiceID", ServiceID),
            New SqlParameter("@Size", ItemSize),
            New SqlParameter("@Type", Type),
            New SqlParameter("@Height", CusHeight),
            New SqlParameter("@Shoulder", Shoulder),
            New SqlParameter("@Sleeve", Sleeve),
            New SqlParameter("@Armpit", Armpit),
            New SqlParameter("@Chest", Chest),
            New SqlParameter("@Waist", Waist),
            New SqlParameter("@Hip", Hip),
            New SqlParameter("@ChkCustomer", ChkCustomer.Checked),
            New SqlParameter("@ItemType", ItemType)}
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
        TxtMaterialNum.Focus()
    End Sub

    Private Sub GetOrderTailorData()
        If RadReady.Checked Then
            Type = "Ready"

        Else
            Type = "Order"
        End If

        TailorID = 0
        ServiceID = 0
        TailorPrice = 0
        ItemSize = ""
        'Type = ""
        Armpit = 0
        Chest = 0
        CusHeight = 0
        Hip = 0
        Shoulder = 0
        Sleeve = 0
        Waist = 0

        If Not IsNothing(CmbTailor.SelectedValue) Then
            TailorID = CmbTailor.SelectedValue
        End If

        If Not IsNothing(CmbService.SelectedValue) Then
            ServiceID = CmbService.SelectedValue
            TailorPrice = Val(TxtTailorPrice.Text)
        End If

        If TxtSize.Text <> "" Then
            ItemSize = TxtSize.Text.Trim
        End If

        If TxtArmpit.Text <> "" Then
            Armpit = Val(TxtArmpit.Text.Trim)
        End If
        If TxtChest.Text <> "" Then
            Chest = Val(TxtChest.Text.Trim)
        End If
        If TxtHeight.Text <> "" Then
            CusHeight = Val(TxtHeight.Text.Trim)
        End If
        If TxtHip.Text <> "" Then
            Hip = Val(TxtHip.Text.Trim)
        End If
        If TxtShoulder.Text <> "" Then
            Shoulder = Val(TxtShoulder.Text.Trim)
        End If
        If TxtSleeve.Text <> "" Then
            Sleeve = Val(TxtSleeve.Text.Trim)
        End If
        If TxtWaist.Text <> "" Then
            Waist = Val(TxtWaist.Text.Trim)
        End If
    End Sub

    Private Sub FillDGV(DT As DataTable)
        DGVInvoContent.Rows.Clear()
        For i = 0 To DT.Rows.Count - 1
            With DT.Rows(i)

                DGVInvoContent.Rows.Add()
                DGVInvoContent.Item(0, i).Value = i + 1
                DGVInvoContent.Item(1, i).Value = .Item("INum")
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
        TxtTotal.Text = "0.00"
        For Each Row As DataGridViewRow In DGVInvoContent.Rows
            Total += Val(Row.Cells(5).Value)
        Next
        TxtTotal.Text = Format(Total, "0.00")
    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        Clear(TLPData)
        Clear(TLPOrder)
        'CmbMaterial.DataSource = Nothing
        CmbMaterial.Text = ""
        ItemType = 0
        TxtName.Clear()
        TxtQuantityS.Text = ""
        ChangeControlColor(Me)
        DGVInvoContent.ClearSelection()
        DGVItems.ClearSelection()
        'DGVItems.DataSource = Nothing
        GetData()
        TxtMaterialNum.Focus()
    End Sub

    Private Sub TxtTotalMaterial_Click(sender As Object, e As EventArgs)
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ChangeControlColor(Me)
        Clear(TLPData)
        Clear(TLPDeliveryData)
        Clear(TLPOrder)
        InvoiceID = 0
        BtnClean.PerformClick()
        CmbCustomer.Text = ""
        DGVInvoContent.Rows.Clear()
        TxtTotal.Text = ""
        TxtSavedInvoNum.Text = ""

        GetData()
        IDPrint = 0
        TxtMaterialNum.Focus()

    End Sub

    Private Sub TxtMaterialNum_TextChanged(sender As Object, e As EventArgs) Handles TxtMaterialNum.TextChanged
        sender.BackColor = SystemColors.Window
        If TxtMaterialNum.Text.Trim = vbNullString Then ClearMaterial()
    End Sub

    Private Sub TxtMaterialNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMaterialNum.KeyPress
        'e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtMaterialNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtMaterialNum.KeyDown

        If e.KeyCode = Keys.Enter Then
            BtnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub ClearMaterial()
        TxtSellPrice.Text = ""
        LblType.Text = ""
        TxtQuantity.Text = ""
        'TxtTotalMaterial.Text = ""
        CmbMaterial.Text = ""
        CmbMaterial.SelectedIndex = -1
        DGVItems.ClearSelection()
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

        Else
            BtnTailor.Enabled = False
        End If
    End Sub

    Private Sub RadReady_CheckedChanged(sender As Object, e As EventArgs) Handles RadReady.CheckedChanged
        If RadReady.Checked Then
            BtnTailor.Enabled = False

        Else
            BtnTailor.Enabled = True
        End If
    End Sub

    Private Sub CmbTailor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTailor.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbTailor_TextChanged(sender As Object, e As EventArgs) Handles CmbTailor.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbTailor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbTailor.SelectionChangeCommitted
        If IsNothing(CmbTailor.SelectedValue) Then Exit Sub
        CmbService.DataSource = Nothing
        CmbService.Text = ""
        TxtTailorPrice.Text = ""

        Dim SQLCon = New SQLConClass()
        SQLQuery = " Select * From TailorServicesView Where TailorID = " & CmbTailor.SelectedValue

        DSService = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSService.Tables(0).Rows.Count > 0 Then
            CmbService.DataSource = DSService.Tables(0)
            CmbService.DisplayMember = "ServiceName"
            CmbService.ValueMember = "ID"
            CmbService.SelectedIndex = -1

        Else
            CmbService.DataSource = Nothing
            CmbService.SelectedIndex = -1
            CmbService.Text = ""

        End If
    End Sub

    Private Sub TxtSize_TextChanged(sender As Object, e As EventArgs) Handles TxtSize.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnInvoData_Click(sender As Object, e As EventArgs) Handles BtnInvoData.Click
        'Clear(TlpInvoData)
        TxtInvoNum.Text = InvoNum
        PnlInvo.Top = (Me.Height - PnlInvo.Height) / 2
        PnlInvo.Left = (Me.Width - PnlInvo.Width) / 2.0
        PnlInvo.Visible = True
        PnlInvo.BringToFront()

    End Sub

    Private Sub BtnTailor_Click(sender As Object, e As EventArgs) Handles BtnTailor.Click
        If InvoiceID = 0 Then
            MsgTool("لا يوجد فاتورة", 0)
            Exit Sub
        End If

        'Clear(TLPOrder)
        PnlTailor.Top = (Me.Height - PnlTailor.Height) / 2
        PnlTailor.Left = (Me.Width - PnlTailor.Width) / 2.0
        PnlTailor.BringToFront()
        PnlTailor.Visible = True

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

        PnlDelivery.Top = (Me.Height - PnlDelivery.Height) / 2
        PnlDelivery.Left = (Me.Width - PnlDelivery.Width) / 2.0
        PnlDelivery.Visible = True
        PnlDelivery.BringToFront()
        TxtMaterialNum.Focus()

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

        ElseIf Col = "ColPrint" Then
            Try
                ' النص الذي سيتم تحويله إلى باركود
                Dim barcodeText As String = DGVInvoContent.Item(1, CR).Value  ' مثال نص الباركود
                Dim itemName As String = DGVInvoContent.Item(2, CR).Value
                Dim itemPrice As String = DGVInvoContent.Item(3, CR).Value + " د.ل"

                Dim CompanyName As String = My.Settings.CompanyArabicName

                ' إنشاء مولد الباركود
                Dim barcodeWriter As New BarcodeWriter()
                barcodeWriter.Format = BarcodeFormat.CODE_128
                barcodeWriter.Options = New ZXing.Common.EncodingOptions With {
               .Height = 100,  ' ارتفاع الباركود
               .Width = 300,   ' عرض الباركود
               .Margin = 2
           }

                ' توليد صورة الباركود
                Dim barcodeImage As Bitmap = barcodeWriter.Write(barcodeText)

                ' إنشاء صورة جديدة تجمع بين الباركود والنصوص
                Dim combinedImage As New Bitmap(300, 150) ' ضبط حجم الصورة الجديدة
                Using g As Graphics = Graphics.FromImage(combinedImage)
                    g.Clear(Color.White) ' خلفية بيضاء

                    ' رسم الباركود
                    g.DrawImage(barcodeImage, New Point(0, 0))

                    ' إعداد الخطوط للنصوص
                    Dim font As New Font("Arial", 18, FontStyle.Bold)
                    Dim brush As New SolidBrush(Color.Black)

                    ' رسم النص أسفل الباركود
                    g.DrawString(itemName, font, brush, New PointF(10, 100)) ' اسم الصنف
                    g.DrawString(itemPrice, font, brush, New PointF(10, 125)) ' سعر الصنف
                    'If ChkCompanyName.Checked Then
                    ' حساب موضع النص بحيث يكون في منتصف العرض
                    Dim companyNameSize As SizeF = g.MeasureString(CompanyName, font)
                        Dim companyNameX As Single = combinedImage.Width - companyNameSize.Width - 10 ' الحافة اليمنى مع مسافة 10 بكسل
                        Dim companyNameY As Single = combinedImage.Height - companyNameSize.Height - 10 ' الحافة السفلية مع مسافة 10 بكسل

                        ' رسم اسم الشركة في منتصف الصورة
                        g.DrawString(CompanyName, font, brush, New PointF(companyNameX, companyNameY))
                    'End If
                End Using

                ' عرض الصورة النهائية في PictureBox
                PicBarcode.Image = combinedImage

            Catch ex As Exception
                MessageBox.Show("حدث خطأ: " & ex.Message)
            End Try




            Dim DT As DataTable

            Dim F As New FrmPrint
            Dim C As New CrBarcode
            'Dim DT As DataTable
            Dim DSPrint As DataSet

            Dim param() As SqlParameter = {
             New SqlParameter("barcode", Format(DGVInvoContent.Item(1, CR).Value, "*00000*")),
                New SqlParameter("@FrameType", DGVInvoContent.Item(2, CR).Value),
                New SqlParameter("@BarcodeImage", ImageToByte(PicBarcode)),
                New SqlParameter("Price", DGVInvoContent.Item(3, CR).Value)
                 }
            param(2).SqlDbType = SqlDbType.VarBinary

            Dim sqlcon = New SQLConClass()

            DSPrint = sqlcon.CMDExecuteData("SaveBarcode", param)
            DT = DSPrint.Tables(0).Copy

            C.SetDataSource(DT)
            F.CrystalReportViewer1.ReportSource = C
            ''تحديث التقرير
            F.CrystalReportViewer1.Refresh()

            'تغيير عنوان فورم الطباع
            F.Text = "طباعة باركود "
            F.CrystalReportViewer1.Zoom(100%)
            F.WindowState = FormWindowState.Maximized
            F.Show()
            DSPrint.Clear()
        End If
        Operation = ""

    End Sub

    Private Sub BtnCloseDelivery_Click(sender As Object, e As EventArgs) Handles BtnCloseDelivery.Click
        ChangeControlColor(TLPDeliveryData)
        PnlDelivery.Visible = False
        TxtMaterialNum.Focus()
    End Sub

    Private Sub BtnCloseTailor_Click(sender As Object, e As EventArgs) Handles BtnCloseTailor.Click
        ChangeControlColor(TLPOrder)
        PnlTailor.Visible = False
        TxtMaterialNum.Focus()
    End Sub

    Private Sub BtnSaveTailor_Click(sender As Object, e As EventArgs) Handles BtnSaveTailor.Click
        'IsDataMissing = False
        'IsInputEmpty(TLPOrder)

        If TxtSizeName.Text = "" Then
            TxtSizeName.Focus()
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If
        Dim SizeNameID As Integer
        If CmbSizeName.SelectedValue Is Nothing Or CmbSizeName.SelectedValue = -1 Then
            SizeNameID = 0
            'Exit Sub

        Else
            SizeNameID = CmbSizeName.SelectedValue
        End If

        If vbYes = MsgBox("هل تريد حفظ المقاس للزبون ", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الحفظ") Then
            Dim SQLCon = New SQLConClass
            Dim DSCustomerSize As New DataSet
            Dim Param() As SqlParameter = {
                New SqlParameter("@CustomerID", CustomerID),
                New SqlParameter("@SizeNameID", SizeNameID),
                New SqlParameter("@SizeName", TxtSizeName.Text.Trim),
                New SqlParameter("@Height", TxtHeight.Text.Trim),
                New SqlParameter("@Shoulder", TxtShoulder.Text.Trim),
                New SqlParameter("@Sleeve", TxtSleeve.Text.Trim),
                New SqlParameter("@Armpit", TxtArmpit.Text.Trim),
                New SqlParameter("@Chest", TxtChest.Text.Trim),
                New SqlParameter("@Waist", TxtWaist.Text.Trim),
                New SqlParameter("@Hip", TxtHip.Text.Trim)}
            DSCustomerSize = SQLCon.CMDExecuteData("AddCustomerSize", Param)

            If Save = 1 Then
                MsgTool("تم حفظ المقاس للزبون " & LblCustomerName.Text, 1)
                'CleanSizes()
                If DSCustomerSize.Tables(0).Rows.Count > 0 Then
                    DTCustomerSize = DSCustomerSize.Tables(0).Copy
                    FillCustomerSizes(DTCustomerSize)
                    customerSizeID = DSCustomerSize.Tables(1).Rows(0).Item(0)
                Else
                    CmbSizeName.DataSource = Nothing
                    CmbSizeName.Text = ""
                End If
            End If

        End If
        PnlTailor.Visible = False
    End Sub

    Private Sub BtnSaveDelivery_Click(sender As Object, e As EventArgs) Handles BtnSaveDelivery.Click
        If DS.Tables(10).Rows.Count > 0 Then
            If IsDBNull(DS.Tables(10).Rows(0).Item("CloseDate")) Then
                EditOrder()
                PnlDelivery.Visible = False
                Exit Sub

            Else
                MsgTool(" لا يمكن التعديل, تم تسليم الطلب للزبون ", 0)
                PnlDelivery.Visible = False
                Exit Sub
            End If
        End If


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
        Select Case Save
            Case = 1
                MsgTool("تم تسجيل الطلب  ", 1)

            Case = 2
                MsgTool("الفاتورة مسجلة طلب توصيل مسبقاً", 0)


        End Select
        PnlDelivery.Visible = False
    End Sub

    Private Sub EditOrder()
        Dim OperationOrder As String = "Edit"
        Dim DeliveryID As Integer = 0
        Dim CityID As Integer = 0
        Dim DeliveryPrice As Double = 0
        Dim Address As String = ""
        Dim Phone As String = ""

        If Not IsNothing(CmbDelivery.SelectedValue) Then
            DeliveryID = CmbDelivery.SelectedValue
        End If

        If Not IsNothing(CmbCity.SelectedValue) Then
            CityID = CmbCity.SelectedValue
        End If

        If TxtAddress.Text <> "" Then
            Address = TxtAddress.Text.Trim
        End If
        DeliveryPrice = Val(TxtDeliveryPrice.Text)

        Phone = TxtPhone.Text.Trim

        If DeliveryID = 0 Or CityID = 0 Or DeliveryPrice = 0 Or Address = "" Or Phone = "" Then
            MsgTool("يرجى تكملة بيانات الطلب أولاً", 0)
            Exit Sub
        End If



        If OrderID <= 0 Then Exit Sub
        Dim SQLCon = New SQLConClass
        Dim Param() As SqlParameter = {
        New SqlParameter("@ID", OrderID),
        New SqlParameter("@Operation", OperationOrder),
        New SqlParameter("@DeliveryID", DeliveryID),
        New SqlParameter("@CityID", CityID),
        New SqlParameter("@DeliveryPrice", DeliveryPrice),
        New SqlParameter("@Phone", Phone),
        New SqlParameter("@Address", Address)}

        Dim DS As DataSet = SQLCon.CMDExecuteData("EditDeliveryOrder", Param)
        Select Case Operation
            Case = "Edit"
                MsgTool("تم تعديل بيانات الطلب  ", 1)

        End Select
    End Sub

    Private Sub EditInvo()
        'GetOrderTailorData()

        Dim SQLCon = New SQLConClass
        Dim DSInvoContent As New DataSet
        Dim Param() As SqlParameter = {
            New SqlParameter("@InvoID", InvoiceID),
            New SqlParameter("@ItemStoreID", DGVInvoContent.Item(6, CR).Value),            'New SqlParameter("@Total", DGVInvoContent.Item(5, CR).Value),
            New SqlParameter("@SellPrice", DGVInvoContent.Item(3, CR).Value),            'New SqlParameter("@PurchasePrice", DGVInvoContent.Item(7, CR).Value),
            New SqlParameter("@Quantity", 1),
            New SqlParameter("@Operation", Operation)}
        DSInvoContent = SQLCon.CMDExecuteData("EditSaleInvoiceContents", Param)


        If Not DSHasTables(DSInvoContent) Then Exit Sub
        If Save = 1 Then
            MsgTool("تم حفظ الفاتورة بنجاح", 1)

            Clear(TLPData)
            CmbMaterial.DataSource = Nothing
            CmbMaterial.Text = ""

            ChangeControlColor(Me)
            DGVInvoContent.ClearSelection()


            FillDGV(DSInvoContent.Tables(0))
            GetTotal()
            GetData()
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
        TxtMaterialNum.Focus()
    End Sub

    Private Sub CmbService_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbService.SelectionChangeCommitted
        Dim DT As DataTable = DSService.Tables(0)
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

    Private Sub TxtHeight_TextChanged(sender As Object, e As EventArgs) Handles TxtHeight.TextChanged

    End Sub

    Private Sub CmbDelivery_TextChanged(sender As Object, e As EventArgs) Handles CmbDelivery.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=99")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If IDPrint = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = " Select ID, FORMAT(Num,'000000') AS Num, Date, Name, [User],Total, Phone1, Phone2 FROM InvoiceView  WHERE ID=" & IDPrint
        SQLQuery &= " Select * From InvoiceContentView Where InvoiceID=" & IDPrint
        SQLQuery &= " Select * FROM CenterInfoTable"
        SQLQuery += " Select Address, Phone, Price, CityName, DeliveryName From DeliveryOrderView where InvoiceID= " & IDPrint

        Dim Address As String = ""
        Dim Phone As String = ""
        Dim Price As String = ""
        Dim CityName As String = ""
        Dim DeliveryName As String = ""

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSPrint.Tables(3).Rows.Count > 0 Then
            Address = DSPrint.Tables(3).Rows(0).Item("Address")
            Phone = DSPrint.Tables(3).Rows(0).Item("Phone")
            Price = DSPrint.Tables(3).Rows(0).Item("Price")
            CityName = DSPrint.Tables(3).Rows(0).Item("CityName")
            DeliveryName = DSPrint.Tables(3).Rows(0).Item("DeliveryName")
        End If
        Dim F As New FrmPrint
        Dim C As New CRSalesInvoice

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(2))
        C.Subreports(2).SetDataSource(DSPrint.Tables(2))
        C.SetParameterValue("Address", Address)
        C.SetParameterValue("Phone", Phone)
        C.SetParameterValue("Price", Price)
        C.SetParameterValue("CityName", CityName)
        C.SetParameterValue("DeliveryName", DeliveryName)
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()

    End Sub

    Private Sub BtnCloseCustomer_Click(sender As Object, e As EventArgs) Handles BtnCloseCustomer.Click
        Clear(TLPCustomerData)
        'TLPCustomer.Visible = False
        TLPCustomer.Visible = False
        ChangeControlColor(TLPCustomerData)
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

    Private Sub DGVInvoContent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInvoContent.CellClick

    End Sub
    Private Sub DGVItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVItems.CellContentClick

    End Sub

    Private Sub DGVItems_Click(sender As Object, e As EventArgs) Handles DGVItems.Click
        If CheckDGVError(DGVItems) Then Exit Sub

        CR = DGVItems.CurrentRow.Index
        CmbMaterial.SelectedValue = DGVItems.Item(1, CR).Value
        CmbMaterial_SelectionChangeCommitted(sender, e)

    End Sub

    Private Sub DGVItems_DoubleClick(sender As Object, e As EventArgs) Handles DGVItems.DoubleClick
        If DGVItems.RowCount = 0 OrElse DGVItems.CurrentRow Is Nothing Then Exit Sub
        Dim ItemID As Integer
        If Convert.ToInt32(DGVItems.CurrentRow.Cells(10).Value) = 2 Then
            ItemID = Convert.ToInt32(DGVItems.CurrentRow.Cells(1).Value)
            FrmItemSizes.ItemID = ItemID
            FrmItemSizes.ShowDialog()
        End If

    End Sub

    Private Sub TxtCountry_TextChanged(sender As Object, e As EventArgs)
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnSearchInvo_Click(sender As Object, e As EventArgs) Handles BtnSearchInvo.Click
        FrmSearchInvo.ShowDialog()
        GetData()
        TxtMaterialNum.Focus()
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

    Private Sub CmbTailor_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbTailor.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbService.Focus()
        End If
    End Sub

    Private Sub CmbService_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbService.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSize.Focus()
        End If
    End Sub

    Private Sub CmbCat_SelectedIndexChanged(sender As Object, e As EventArgs)
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCat_TextChanged(sender As Object, e As EventArgs)
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnSizeRefresh_Click(sender As Object, e As EventArgs) Handles BtnSizeRefresh.Click
        Clear(TLPOrder)
    End Sub

    Private Sub CmbSizeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSizeName.SelectedIndexChanged

    End Sub

    Private Sub CmbSizeName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbSizeName.SelectionChangeCommitted
        CleanSizes()
        If CmbSizeName.SelectedValue Is Nothing Or CmbSizeName.SelectedValue = -1 Then Exit Sub

        Dim ItemRow() As DataRow = DTCustomerSize.Select("ID=" & CmbSizeName.SelectedValue)

        If ItemRow.Length = 0 Then Exit Sub

        If Not IsDBNull(ItemRow(0)("Name")) Then TxtSizeName.Text = ItemRow(0)("Name")
        If Not IsDBNull(ItemRow(0)("Height")) Then TxtHeight.Text = ItemRow(0)("Height")
        If Not IsDBNull(ItemRow(0)("Shoulder")) Then TxtShoulder.Text = ItemRow(0)("Shoulder")
        If Not IsDBNull(ItemRow(0)("Sleeve")) Then TxtSleeve.Text = ItemRow(0)("Sleeve")
        If Not IsDBNull(ItemRow(0)("Armpit")) Then TxtArmpit.Text = ItemRow(0)("Armpit")
        If Not IsDBNull(ItemRow(0)("Chest")) Then TxtChest.Text = ItemRow(0)("Chest")
        If Not IsDBNull(ItemRow(0)("Waist")) Then TxtWaist.Text = ItemRow(0)("Waist")
        If Not IsDBNull(ItemRow(0)("Hip")) Then TxtHip.Text = ItemRow(0)("Hip")
    End Sub

    Private Sub CleanSizes()
        TxtSizeName.Text = ""
        TxtHeight.Text = ""
        TxtShoulder.Text = ""
        TxtSleeve.Text = ""
        TxtArmpit.Text = ""
        TxtChest.Text = ""
        TxtWaist.Text = ""
        TxtHip.Text = ""
    End Sub

    Private Sub SetDGVHeader()
        DGVItems.Columns(0).Width = 55
        DGVItems.Columns(0).HeaderText = "ت"
        DGVItems.Columns(1).Visible = False
        DGVItems.Columns(2).HeaderText = "رقم القطعة"
        DGVItems.Columns(3).HeaderText = "الاسم "
        DGVItems.Columns(4).HeaderText = "الكمية"
        DGVItems.Columns(5).HeaderText = "السعر"
        DGVItems.Columns(6).HeaderText = "النوع"
        DGVItems.Columns(7).HeaderText = "المقاس"
        DGVItems.Columns(8).HeaderText = "PurchasePrice"
        DGVItems.Columns(9).HeaderText = "CatID"
        DGVItems.Columns(10).HeaderText = "ItemType"
        'DGVItems.Columns(5).Visible = False
        'DGVItems.Columns(7).Visible = False
        'DGVItems.Columns(6).Visible = False
        DGVItems.Columns(8).Visible = False
        DGVItems.Columns(9).Visible = False
        DGVItems.Columns(10).Visible = False
        'DGVItems.Columns(10).HeaderText = "ItemType"

    End Sub

    Private Sub TxtSizeName_TextChanged(sender As Object, e As EventArgs) Handles TxtSizeName.TextChanged

    End Sub

    Private Sub TxtSize_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSize.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTailorPrice.Focus()
        End If
    End Sub

    Private Sub TxtTailorPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTailorPrice.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtTailorPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTailorPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbSizeName.Focus()
        End If
    End Sub

    Private Sub CmbSizeName_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbSizeName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSizeName.Focus()
        End If
    End Sub

    Private Sub TxtSizeName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSizeName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHeight.Focus()
        End If
    End Sub

    Private Sub TxtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHeight.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtHeight_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtHeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtShoulder.Focus()
        End If
    End Sub

    Private Sub TxtShoulder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtShoulder.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtShoulder_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtShoulder.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSleeve.Focus()
        End If
    End Sub

    Private Sub BtnBarcode_Click(sender As Object, e As EventArgs) Handles BtnBarcode.Click
        Try
            ' النص الذي سيتم تحويله إلى باركود
            Dim barcodeText As String = TxtSavedInvoNum.Text    ' مثال نص الباركود
            Dim itemName As String = TxtNameCustomer.Text
            Dim itemPrice As String = ""

            Dim CompanyName As String = My.Settings.CompanyArabicName

            ' إنشاء مولد الباركود
            Dim barcodeWriter As New BarcodeWriter()
            barcodeWriter.Format = BarcodeFormat.CODE_128
            barcodeWriter.Options = New ZXing.Common.EncodingOptions With {
           .Height = 100,  ' ارتفاع الباركود
           .Width = 300,   ' عرض الباركود
           .Margin = 2
       }

            ' توليد صورة الباركود
            Dim barcodeImage As Bitmap = barcodeWriter.Write(barcodeText)

            ' إنشاء صورة جديدة تجمع بين الباركود والنصوص
            Dim combinedImage As New Bitmap(300, 150) ' ضبط حجم الصورة الجديدة
            Using g As Graphics = Graphics.FromImage(combinedImage)
                g.Clear(Color.White) ' خلفية بيضاء

                ' رسم الباركود
                g.DrawImage(barcodeImage, New Point(0, 0))

                ' إعداد الخطوط للنصوص
                Dim font As New Font("Arial", 18, FontStyle.Bold)
                Dim brush As New SolidBrush(Color.Black)

                ' رسم النص أسفل الباركود
                g.DrawString(itemName, font, brush, New PointF(10, 100)) ' اسم الصنف
                g.DrawString(itemPrice, font, brush, New PointF(10, 125)) ' سعر الصنف
                'If ChkCompanyName.Checked Then
                ' حساب موضع النص بحيث يكون في منتصف العرض
                Dim companyNameSize As SizeF = g.MeasureString(CompanyName, font)
                Dim companyNameX As Single = combinedImage.Width - companyNameSize.Width - 10 ' الحافة اليمنى مع مسافة 10 بكسل
                Dim companyNameY As Single = combinedImage.Height - companyNameSize.Height - 10 ' الحافة السفلية مع مسافة 10 بكسل

                ' رسم اسم الشركة في منتصف الصورة
                g.DrawString(CompanyName, font, brush, New PointF(companyNameX, companyNameY))
                'End If
            End Using

            ' عرض الصورة النهائية في PictureBox
            PicBarcode.Image = combinedImage

        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try




        Dim DT As DataTable

        Dim F As New FrmPrint
        Dim C As New CrBarcode
        'Dim DT As DataTable
        Dim DSPrint As DataSet

        Dim param() As SqlParameter = {
            New SqlParameter("barcode", Format(TxtSavedInvoNum.Text, "*00000*")),
            New SqlParameter("@FrameType", CmbCustomer.Text),
            New SqlParameter("@BarcodeImage", ImageToByte(PicBarcode)),
            New SqlParameter("Price", "")
             }
        param(2).SqlDbType = SqlDbType.VarBinary

        Dim sqlcon = New SQLConClass()

        DSPrint = sqlcon.CMDExecuteData("SaveBarcode", param)
        DT = DSPrint.Tables(0).Copy

        C.SetDataSource(DT)
        F.CrystalReportViewer1.ReportSource = C
        ''تحديث التقرير
        F.CrystalReportViewer1.Refresh()

        'تغيير عنوان فورم الطباع
        F.Text = "طباعة باركود "
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()
        DSPrint.Clear()
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

        Dim searchBox As TextBox = TryCast(sender, TextBox)
        If searchBox Is Nothing Then Exit Sub

        searchBox.BackColor = SystemColors.Window

        Dim searchText As String = searchBox.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            ResetFilter()
            Exit Sub
        End If

        If bsItems Is Nothing OrElse bsItems.DataSource Is Nothing Then
            Exit Sub
        End If

        ' معالجة نص البحث لجعله آمناً للاستعلام
        Dim safeSearchText As String = SanitizeSearchText(searchText)

        ' بناء تعبير التصفية
        Dim filterExpression As String = BuildFilterExpression(safeSearchText, searchText)

        ' تطبيق التصفية
        ApplyFilter(filterExpression)

        ' إعادة ترقيم الصفوف
        RenumberGridRows()

    End Sub

    Private Function SanitizeSearchText(searchText As String) As String
        ' معالجة الأحرف الخاصة لمنع أخطاء SQL
        Return searchText.Replace("'", "''") _
                        .Replace("[", "[[]") _
                        .Replace("%", "[%]") _
                        .Replace("*", "[*]")
    End Function

    Private Function BuildFilterExpression(safeText As String, originalText As String) As String
        ' البحث في حقل الاسم (Name) باستخدام LIKE للبحث الجزئي
        Dim nameFilter As String = $"[Name] LIKE '%{safeText}%'"

        ' إذا كان النص رقماً، نبحث في الحقل الرقمي (Num) بالمطابقة التامة
        If IsNumeric(originalText) Then
            Return $"{nameFilter} OR [ItemStoreNum] = '{safeText}'"
        End If

        Return nameFilter
    End Function

    Private Sub ApplyFilter(filterExpression As String)
        Try
            bsItems.Filter = filterExpression
        Catch ex As Exception
            ' في حالة فشل التصفية نعيد الضبط
            bsItems.Filter = ""
        End Try

        DGVItems.ClearSelection()
    End Sub

    Private Sub ResetFilter()
        If bsItems IsNot Nothing Then
            bsItems.Filter = ""
        End If
        DGVItems.ClearSelection()
        RenumberGridRows()
    End Sub

    Private Sub RenumberGridRows()
        For i As Integer = 0 To DGVItems.Rows.Count - 1
            DGVItems.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub


    Private Sub TxtSleeve_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSleeve.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtSleeve_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSleeve.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtArmpit.Focus()
        End If
    End Sub

    Private Sub TxtArmpit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArmpit.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtArmpit_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArmpit.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtChest.Focus()
        End If
    End Sub

    Private Sub TxtChest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtChest.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtChest_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtChest.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtWaist.Focus()
        End If
    End Sub

    Private Sub TxtWaist_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtWaist.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtWaist_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtWaist.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHip.Focus()
        End If
    End Sub

    Private Sub TxtHip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHip.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtHip_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtHip.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSaveTailor_Click(sender, e)
        End If
    End Sub

    Private Sub TxtNameCustomer_TextChanged(sender As Object, e As EventArgs) Handles TxtNameCustomer.TextChanged

    End Sub

    Private Sub TxtNameCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNameCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPhoneCustomer.Focus()
        End If
    End Sub

    Private Sub TxtPhoneCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPhoneCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAddressCustomer.Focus()
        End If
    End Sub

    Private Sub TxtAddressCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAddressCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSaveCustomer_Click(sender, e)
        End If
    End Sub

    Private Sub Panel4_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel4.MouseDown, LblOrderData.MouseDown
        MoveObject(e, MouseEvent.Down, PnlTailor)
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove, LblOrderData.MouseMove
        MoveObject(e, MouseEvent.Move, PnlTailor)
    End Sub

    Private Sub Panel4_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel4.MouseUp, LblOrderData.MouseUp
        MoveObject(e, MouseEvent.Up, PnlTailor)
    End Sub

    Private Sub PnlMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseDown, Label34.MouseDown
        MoveObject(e, MouseEvent.Down, PnlInvo)
    End Sub

    Private Sub PnlMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseMove, Label34.MouseMove
        MoveObject(e, MouseEvent.Move, PnlInvo)
    End Sub

    Private Sub PnlMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseUp, Label34.MouseUp
        MoveObject(e, MouseEvent.Up, PnlInvo)
    End Sub

    Private Sub Panel7_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel7.MouseDown, Label33.MouseDown
        MoveObject(e, MouseEvent.Down, PnlDelivery)
    End Sub

    Private Sub Panel7_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel7.MouseMove, Label33.MouseMove
        MoveObject(e, MouseEvent.Move, PnlDelivery)
    End Sub

    Private Sub Panel7_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel7.MouseUp, Label33.MouseUp
        MoveObject(e, MouseEvent.Up, PnlDelivery)
    End Sub

    Private Sub TxtName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtMaterialNum.Text = TxtName.Text.Trim
            TxtMaterialNum_KeyDown(sender, e)
        End If
    End Sub

End Class