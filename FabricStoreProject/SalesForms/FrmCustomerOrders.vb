Imports System.Data.SqlClient

Public Class FrmCustomerOrders


    Private PageSize, PagesCount, RowsCount, OrderID As Integer
    Private PageNum As Integer = 1
    Private SearchActive As Boolean
    Private Operation As String

    Private FromChkNum As Boolean
    Private DSMain, DSSearch, DSEdit As New DataSet
    Private DTTailor, DTService As New DataTable



    Private Enum Data
        Search
        Main
    End Enum

    Private Sub FrmCustomerOrders_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            NUDPageSize.Value = My.Settings.PageSize
            DTPFrom.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            DTPTo.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            DTPFrom.Value = Now.Date
            DTPTo.Value = Now.Date
            GetData(Data.Main)
            TxtPagesCount.Text = 1

        Else
            If Not IsNothing(DSMain) Then
                DSMain.Clear()
            End If
            If Not IsNothing(DSSearch) Then
                DSSearch.Clear()
            End If
            DGV.Rows.Clear()
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub


    Private Sub AppendToQuery(Oprtr As String, Query As String)

        ' Check if last word in the query is "WHERE " with the space at the end
        ' If True and you want to add a condition no need to append " AND " or any operator
        ' But if was False this means this's not the first condition you add so you must add an operator too

        Dim TestString As String = StrReverse(SQLQuery)
        If StrReverse(TestString.Substring(0, 6).ToUpper) = "WHERE " Then
            SQLQuery &= Query
        Else
            SQLQuery &= Oprtr & " " & Query
        End If

    End Sub

    Private Sub GetData(Type As Data)

        Dim SQLCon = New SQLConClass()
        TxtPageNum.Text = PageNum
        PageSize = My.Settings.PageSize
        Select Case Type
            Case Data.Main

                SQLQuery = " Select ID,Name From UserView where  ID <> 1  Order By Name "
                SQLQuery &= " Select ID,Name From CustomersTable  Order By Name  "
                SQLQuery &= " Select ID,Name From TailorsTable  Order By Name  "
                SQLQuery &= " Select * From ServicesTable  Order By Name  "

                DSMain = SQLCon.SelectData(SQLQuery)
                FillData(Type, DSMain, 4)

            Case Data.Search

                Dim Param() As SqlParameter =
                    {New SqlParameter("@InvoiceNum", Val(TxtNum.Text)),
                    New SqlParameter("@OrderNum", Val(TxtOrderNum.Text))}
                SQLQuery = "SELECT  ROW_NUMBER() OVER (ORDER BY (InvoiceDate)Desc) As ت, * From CustomerOrdersView 
                            WHERE InvoiceEndService IS NULL And OrderEndService IS NULL"

                AppendConditions()
                SQLQuery &= " ORDER BY CustomerOrdersView.InvoiceDate Desc OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
                SQLQuery &= " SELECT COUNT(ID) FROM CustomerOrdersView WHERE InvoiceEndService IS NULL And OrderEndService IS NULL "
                AppendConditions()

                DSSearch = SQLCon.SelectData(SQLQuery, 0, Param)
                FillData(Type, DSSearch, 2)

        End Select

    End Sub

    Private Sub FillData(Type As Data, DS As DataSet, TCount As Integer)

        Select Case Type
            Case Data.Main
                CmbUserName.DataSource = DS.Tables(0)
                CmbUserName.DisplayMember = "Name"
                CmbUserName.ValueMember = "ID"
                CmbUserName.SelectedIndex = -1

                CmbCustomer.DataSource = DS.Tables(1)
                CmbCustomer.DisplayMember = "Name"
                CmbCustomer.ValueMember = "ID"
                CmbCustomer.SelectedIndex = -1

                CmbTailor.DataSource = DS.Tables(2)
                CmbTailor.DisplayMember = "Name"
                CmbTailor.ValueMember = "ID"
                CmbTailor.SelectedIndex = -1

                DTTailor = DS.Tables(2).Copy
                CmbTailorOrder.DataSource = DTTailor
                CmbTailorOrder.DisplayMember = "Name"
                CmbTailorOrder.ValueMember = "ID"
                CmbTailorOrder.SelectedIndex = -1

                CmbService.DataSource = DS.Tables(3)
                CmbService.DisplayMember = "Name"
                CmbService.ValueMember = "ID"
                CmbService.SelectedIndex = -1

                DTService = DS.Tables(3).Copy
                CmbServiceOrder.DataSource = DTService
                CmbServiceOrder.DisplayMember = "Name"
                CmbServiceOrder.ValueMember = "ID"
                CmbServiceOrder.SelectedIndex = -1

            Case Data.Search
                If DS.Tables(1).Rows.Count > 0 Then
                    RowsCount = DS.Tables(1).Rows(0).Item(0)
                End If
                GetPagesCount()

                DGV.Rows.Clear()
                If DS.Tables(0).Rows.Count = 0 Then MsgTool("لا توجد نتائج للبحث", 0)

                For i = 0 To DS.Tables(0).Rows.Count - 1
                    With DS.Tables(0).Rows(i)

                        DGV.Rows.Add()
                        DGV.Item(0, i).Value = .Item("ID")
                        DGV.Item(1, i).Value = .Item("ت") 'i + 1
                        DGV.Item(2, i).Value = .Item("OrderNum")
                        DGV.Item(3, i).Value = .Item("ItemName")
                        DGV.Item(4, i).Value = .Item("ServiceName")
                        DGV.Item(5, i).Value = .Item("Size")
                        DGV.Item(6, i).Value = .Item("TailorIName")
                        DGV.Item(7, i).Value = Format(.Item("SellPrice"), "0.000")
                        DGV.Item(8, i).Value = .Item("Quantity")
                        DGV.Item(9, i).Value = Format(.Item("Quantity") * .Item("SellPrice"), "0.000")
                        DGV.Item(10, i).Value = Format(.Item("InvoiceNum"), "000000")
                        DGV.Item(11, i).Value = Format(.Item("InvoiceDate"), GetDateAndTimeFormat(DTFormat.DTF))
                        If .Item("Place") = "1" Then
                            DGV.Item(12, i).Value = "في المخزن"

                        ElseIf .Item("Place") = "2" Then
                            DGV.Item(12, i).Value = "تحت التجهيز"

                        ElseIf .Item("Place") = "3" Then
                            DGV.Item(12, i).Value = "جاهز"

                        ElseIf .Item("Place") = "4" Then
                            DGV.Item(12, i).Value = "تم البيع"

                        End If

                        DGV.Item(13, i).Value = .Item("CustomerName")
                        If IsDBNull(.Item("DeliveryDate")) Then
                            DGV.Item(14, i).Value = "-"
                        Else

                            DGV.Item(14, i).Value = Format(.Item("DeliveryDate"), GetDateAndTimeFormat(DTFormat.DTF))
                        End If
                        DGV.Item(15, i).Value = .Item("CustomerID")
                        DGV.Item(16, i).Value = .Item("ServiceID")
                        DGV.Item(17, i).Value = .Item("TailorID")
                        DGV.Item(18, i).Value = .Item("Place")

                    End With
                Next
                DGV.ClearSelection()

        End Select

    End Sub

    Private Sub AppendConditions()

        Dim DateTimeFrom As Date = DTPFrom.Value.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTPTo.Value.Date & " " & "23:59".ToString
        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " CustomerOrdersView.InvoiceNum=@InvoiceNum ")
        If ChkOrderNum.Checked And TxtOrderNum.Text.Trim <> "" Then AppendToQuery(" AND ", " CustomerOrdersView.OrderNum=@OrderNum ")
        If ChkUser.Checked And CmbUserName.SelectedValue <> Nothing Then AppendToQuery(" AND ", "  dbo.CustomerOrdersView.UserID = " & CmbUserName.SelectedValue)
        If ChkCustomer.Checked And CmbCustomer.SelectedValue <> Nothing Then AppendToQuery(" AND ", " dbo.CustomerOrdersView.CustomerID = " & CmbCustomer.SelectedValue)
        If ChkTailor.Checked And CmbTailor.SelectedValue <> Nothing Then AppendToQuery(" AND ", " dbo.CustomerOrdersView.TailorID = " & CmbTailor.SelectedValue)
        If ChkService.Checked And CmbService.SelectedValue <> Nothing Then AppendToQuery(" AND ", " dbo.CustomerOrdersView.ServiceID = " & CmbService.SelectedValue)
        If ChkDate.Checked Then AppendToQuery(" AND ", " InvoiceDate BETWEEN '" & DateTimeFrom & "' AND '" & DateTimeTo & "' ")
        If ChkOrder.Checked Then
            If RadReady.Checked Then
                AppendToQuery(" AND ", " dbo.CustomerOrdersView.DeliveryDate IS NOT NULL")
            End If

            If RadOrder.Checked Then
                AppendToQuery(" AND ", " dbo.CustomerOrdersView.DeliveryDate IS NULL")
            End If
        End If
    End Sub

    Private Sub ChkChecks()
        If ChkDate.Checked = False And ChkNum.Checked = False And ChkOrderNum.Checked = False And ChkUser.Checked = False And ChkCustomer.Checked = False And ChkTailor.Checked = False And ChkService.Checked = False And ChkOrder.Checked = False Then Exit Sub
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        DGV.Rows.Clear()
        ChkChecks()
        If ChkDate.Checked = False And ChkNum.Checked = False And ChkOrderNum.Checked = False And ChkUser.Checked = False And ChkCustomer.Checked = False And ChkTailor.Checked = False And ChkService.Checked = False And ChkOrder.Checked = False Then
            MsgTool("يرجى اختيار طريقة بحث", 0)
            Exit Sub
        End If
        If ChkOrder.Checked And RadOrder.Checked = False And RadReady.Checked = False Then
            MsgTool("يرجى اختيار طريقة بحث", 0)
            Exit Sub
        End If

        IsDataMissing = False
        IsInputEmpty(TableLayoutPanel4)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        PageNum = 1
        GetData(Data.Search)
        SearchActive = True

    End Sub

    Private Sub ChkNum_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNum.CheckedChanged
        DGV.Rows.Clear()
        If ChkNum.Checked = True Then

            TxtNum.Enabled = True
            TxtNum.Focus()
            FromChkNum = True
            ChkUser.Checked = False
            ChkDate.Checked = False
            ChkCustomer.Checked = False
            ChkTailor.Checked = False
            ChkService.Checked = False
            ChkOrder.Checked = False
            ChkOrderNum.Checked = False

        Else
            'ChkDate.Checked = True
            TxtNum.Enabled = False
            TxtNum.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If

    End Sub

    Private Sub ChkOrderNum_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOrderNum.CheckedChanged
        DGV.Rows.Clear()
        If ChkOrderNum.Checked = True Then

            TxtOrderNum.Enabled = True
            TxtOrderNum.Focus()
            'FromChkNum = True
            ChkUser.Checked = False
            ChkDate.Checked = False
            ChkCustomer.Checked = False
            ChkTailor.Checked = False
            ChkService.Checked = False
            ChkOrder.Checked = False
            ChkNum.Checked = False

        Else
            'ChkDate.Checked = True
            TxtOrderNum.Enabled = False
            TxtOrderNum.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If

    End Sub

    Private Sub ChkUser_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUser.CheckedChanged
        DGV.Rows.Clear()
        CmbUserName.BackColor = SystemColors.Window

        If ChkUser.Checked = True Then
            CmbUserName.Enabled = True
            CmbUserName.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False
            If ChkOrderNum.Checked = True Then ChkOrderNum.Checked = False

        Else
            '   ChangeControlColor(Me)
            CmbUserName.Text = ""
            CmbUserName.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCustomer.CheckedChanged
        DGV.Rows.Clear()
        CmbCustomer.BackColor = SystemColors.Window

        If ChkCustomer.Checked = True Then
            CmbCustomer.Enabled = True
            CmbCustomer.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False
            If ChkOrderNum.Checked = True Then ChkOrderNum.Checked = False

        Else
            CmbCustomer.Text = ""
            CmbCustomer.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkTailor_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTailor.CheckedChanged
        DGV.Rows.Clear()
        CmbTailor.BackColor = SystemColors.Window

        If ChkTailor.Checked = True Then
            CmbTailor.Enabled = True
            CmbTailor.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False
            If ChkOrderNum.Checked = True Then ChkOrderNum.Checked = False

        Else
            CmbTailor.Text = ""
            CmbTailor.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkService_CheckedChanged(sender As Object, e As EventArgs) Handles ChkService.CheckedChanged
        DGV.Rows.Clear()
        CmbService.BackColor = SystemColors.Window

        If ChkService.Checked = True Then
            CmbService.Enabled = True
            CmbService.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False
            If ChkOrderNum.Checked = True Then ChkOrderNum.Checked = False

        Else
            CmbService.Text = ""
            CmbService.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDate.CheckedChanged
        DGV.Rows.Clear()
        If ChkDate.Checked = True Then
            DTPFrom.Enabled = True
            DTPTo.Enabled = True
            If ChkNum.Checked = True Then ChkNum.Checked = False
            If ChkOrderNum.Checked = True Then ChkOrderNum.Checked = False

        Else
            DTPFrom.Enabled = True
            DTPTo.Enabled = True
            DTPFrom.Value = Now.Date
            DTPTo.Value = Now.Date
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub RadReady_CheckedChanged(sender As Object, e As EventArgs) Handles RadReady.CheckedChanged
        DGV.Rows.Clear()
    End Sub

    Private Sub RadOrder_CheckedChanged(sender As Object, e As EventArgs) Handles RadOrder.CheckedChanged
        DGV.Rows.Clear()
    End Sub

    Private Sub ChkOrder_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOrder.CheckedChanged
        DGV.Rows.Clear()

        If ChkOrder.Checked = True Then
            RadOrder.Enabled = True
            RadReady.Enabled = True
            If ChkNum.Checked = True Then ChkNum.Checked = False
            If ChkOrderNum.Checked = True Then ChkOrderNum.Checked = False

        Else
            RadOrder.Enabled = False
            RadReady.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ChangeControlColor(Me)
        DGV.Rows.Clear()
        ChkDate.Checked = True
        ChkOrderNum.Checked = False
        ChkCustomer.Checked = False
        ChkTailor.Checked = False
        ChkService.Checked = False
        ChkNum.Checked = False
        ChkOrder.Checked = False
        ChkUser.Checked = False
        SearchActive = False
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Operation = "Send"
        EditOrder()
    End Sub

    Private Sub BtnReceive_Click(sender As Object, e As EventArgs) Handles BtnReceive.Click
        Operation = "Receive"
        EditOrder()
    End Sub

    Private Sub BtnSell_Click(sender As Object, e As EventArgs) Handles BtnSell.Click
        Operation = "Sell"
        EditOrder()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Operation = "Edit"
        EditOrder()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        TLPOrderDetails.Visible = False
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If DGV.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub

        If DGV.Item(18, e.RowIndex).Value = 4 Then Exit Sub

        OrderID = Convert.ToInt32(DGV.Item(0, e.RowIndex).Value)

        TxtSize.Text = DGV.Item(5, e.RowIndex).Value
        TxtTailorPrice.Text = DGV.Item(7, e.RowIndex).Value

        If Not IsNothing(DGV.Item(16, e.RowIndex)) Then
            CmbServiceOrder.SelectedValue = DGV.Item(16, e.RowIndex).Value
        End If

        If Not IsNothing(DGV.Item(17, e.RowIndex)) Then
            CmbTailorOrder.SelectedValue = DGV.Item(17, e.RowIndex).Value
        End If


        Dim ColName As String = DGV.Columns(e.ColumnIndex).Name

        If ColName = "ColEdit" Then
            If DGV.Item(18, e.RowIndex).Value = 1 Then
                BtnSend.Enabled = True
                BtnReceive.Enabled = False
                BtnSell.Enabled = False

            ElseIf DGV.Item(18, e.RowIndex).Value = 2 Then
                BtnSend.Enabled = False
                BtnReceive.Enabled = True
                BtnSell.Enabled = False

            ElseIf DGV.Item(18, e.RowIndex).Value = 3 Then
                BtnSend.Enabled = False
                BtnReceive.Enabled = False
                BtnSell.Enabled = True
            End If

            If DGV.Item(18, e.RowIndex).Value = 1 Then
                LblOrderData.Enabled = True
                LblOrderData_Click(sender, e)

            ElseIf DGV.Item(18, e.RowIndex).Value = 4 Then
                MsgTool("تم تسليم الطلب للزبون", 0)
                Exit Sub

            Else
                LblOrderData.Enabled = False
                LblOrderState_Click(sender, e)
            End If

            TLPOrderDetails.Visible = True
            'TLPOrderDetails.BringToFront()

            'EditOrder()
        End If
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        If DGV.RowCount = 0 OrElse DGV.CurrentRow Is Nothing Then Exit Sub

        OrderID = Convert.ToInt32(DGV.CurrentRow.Cells(0).Value)
        If DGV.CurrentRow.Cells(18).Value = 1 Then
            BtnSend.Enabled = True
            BtnReceive.Enabled = False
            BtnSell.Enabled = False

        ElseIf DGV.CurrentRow.Cells(18).Value = 2 Then
            BtnSend.Enabled = False
            BtnReceive.Enabled = True
            BtnSell.Enabled = False

        ElseIf DGV.CurrentRow.Cells(18).Value = 3 Then
            BtnSend.Enabled = False
            BtnReceive.Enabled = False
            BtnSell.Enabled = True
        End If

        LblOrderData_Click(sender, e)
        If DGV.CurrentRow.Cells(18).Value = 1 Then
            LblOrderData.Enabled = True
            LblOrderData_Click(sender, e)

        ElseIf DGV.CurrentRow.Cells(18).Value = 4 Then
            MsgTool("تم تسليم الطلب للزبون", 0)
            Exit Sub

        Else
            LblOrderData.Enabled = False
            LblOrderState_Click(sender, e)
        End If
        TLPOrderDetails.Visible = True

        'EditOrder()
    End Sub

    Private Sub LblOrderData_Click(sender As Object, e As EventArgs) Handles LblOrderData.Click
        PnlData.BringToFront()
        PnlOrderState.Visible = False
        PnlOrderData.Visible = True
    End Sub

    Private Sub LblOrderState_Click(sender As Object, e As EventArgs) Handles LblOrderState.Click
        PnlState.BringToFront()
        PnlOrderData.Visible = False
        PnlOrderState.Visible = True
    End Sub

    Private Sub CmbServiceOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServiceOrder.SelectedIndexChanged

    End Sub

    Private Sub CmbServiceOrder_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbServiceOrder.SelectionChangeCommitted
        Dim DT As DataTable = DTService
        If IsNothing(CmbServiceOrder.SelectedValue) Then Exit Sub

        Dim rows() As DataRow = DT.Select("ID = " & CmbServiceOrder.SelectedValue)
        If rows.Length > 0 Then
            TxtTailorPrice.Text = rows(0)("Price").ToString()
        Else
            TxtTailorPrice.Text = 0
        End If
    End Sub

    Private Sub EditOrder()
        Dim TailorID As Integer = 0
        Dim ServiceID As Integer = 0
        Dim TailorPrice As Double = 0
        Dim Size As String = ""

        If Not IsNothing(CmbTailorOrder.SelectedValue) Then
            TailorID = CmbTailorOrder.SelectedValue
        End If

        If Not IsNothing(CmbServiceOrder.SelectedValue) Then
            ServiceID = CmbServiceOrder.SelectedValue
        End If

        If TxtSize.Text <> "" Then
            Size = TxtSize.Text.Trim
        End If
        TailorPrice = Val(TxtTailorPrice.Text)

        If (TailorID = 0 Or ServiceID = 0 Or TailorPrice = 0 Or Size = "") And Operation = "Edit" Then
            MsgTool("يرجى تكملة بيانات الطلب أولاً", 0)
            Exit Sub
        End If

        If (TailorID = 0 Or ServiceID = 0 Or TailorPrice = 0 Or Size = "") And Operation = "Send" Then
            MsgTool("يرجى تكملة بيانات الطلب أولاً", 0)
            Exit Sub
        End If

        If OrderID <= 0 Then Exit Sub
        Dim SQLCon = New SQLConClass
        Dim Param() As SqlParameter = {
        New SqlParameter("@ID", OrderID),
        New SqlParameter("@Operation", Operation),
        New SqlParameter("@TailorID", TailorID),
        New SqlParameter("@ServiceID", ServiceID),
        New SqlParameter("@Price", TailorPrice),
        New SqlParameter("@Size", Size)}

        Dim DS As DataSet = SQLCon.CMDExecuteData("EditOrder", Param)
        Select Case Operation
            Case = "Edit"
                MsgTool("تم تعديل بيانات الطلب  ", 1)

            Case = "Send"
                MsgTool("تم ارسال الطلب للخياط  (" & CmbTailorOrder.Text & " ) ", 1)

            Case = "Receive"
                MsgTool("تم استلام الطلب من الخياط ", 1)

            Case = "Sell"
                MsgTool("تم تسليم الطلب للزبون ", 1)


        End Select
        BtnSearch.PerformClick()
        TLPOrderDetails.Visible = False
        Clear(TLPOrder)
    End Sub

    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles TxtNum.TextChanged, CmbUserName.TextChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtOrderNum_TextChanged(sender As Object, e As EventArgs) Handles TxtOrderNum.TextChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        If CheckDGVError(DGV) Then Exit Sub
    End Sub

    Private Sub DTPFrom_ValueChanged(sender As Object, e As EventArgs) Handles DTPFrom.ValueChanged
        DGV.Rows.Clear()
    End Sub

    Private Sub DTPTo_ValueChanged(sender As Object, e As EventArgs) Handles DTPTo.ValueChanged
        DGV.Rows.Clear()
    End Sub

    Private Sub CmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUserName.SelectedIndexChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCustomer.SelectedIndexChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCustomer_TextChanged(sender As Object, e As EventArgs) Handles CmbCustomer.TextChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbTailor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTailor.SelectedIndexChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbTailor_TextChanged(sender As Object, e As EventArgs) Handles CmbTailor.TextChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        'If DGVRecipt.Rows.Count = 0 Then Exit Sub

        'Dim DSPrint = New DataSet
        'Dim SQLCon = New SQLConClass

        'SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,ReceiptName,NoteFor FROM ReceiptView WHERE EndService IS NULL"
        'AppendReportConditions()
        'SQLQuery &= " ORDER BY ID DESC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
        'SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        'Dim Param() As SqlParameter =
        '    {
        '    New SqlParameter("@Num", TxtNum.Text.Trim),
        '    New SqlParameter("@ReceiptName", "%" & TxtReciptName.Text.Trim & "%"),
        '    New SqlParameter("@PaymentTypeID", (IIf(IsNothing(CmbPaymentType.SelectedValue), 0, CmbPaymentType.SelectedValue))),
        '    New SqlParameter("@UserID", (IIf(IsNothing(CmbUserName.SelectedValue), 0, CmbUserName.SelectedValue))),
        '    New SqlParameter("@BankID", (IIf(IsNothing(CmbBank.SelectedValue), 0, CmbBank.SelectedValue))),
        '    New SqlParameter("@ReceiptFinanceTypeID", (IIf(IsNothing(CmbFinancRecipt.SelectedValue), 0, CmbFinancRecipt.SelectedValue))),
        '    New SqlParameter("@Check", "%" & Val(TxtCkeck.Text.Trim) & "%")
        '    }

        'DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

        'Dim F As New FrmPrint
        'Dim C As New CRRecieptList

        'C.SetDataSource(DSPrint.Tables(0))
        'C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        'C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        'F.CrystalReportViewer1.ReportSource = C
        'F.CrystalReportViewer1.Refresh()
        'F.Text = "طباعة"
        'F.CrystalReportViewer1.Zoom(100%)
        'F.WindowState = FormWindowState.Maximized
        'F.Show()
    End Sub

    Private Sub BtnPrintAll_Click(sender As Object, e As EventArgs) Handles BtnPrintAll.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        'If DGVRecipt.Rows.Count = 0 Then Exit Sub

        'Dim DSPrint = New DataSet
        'Dim SQLCon = New SQLConClass

        'SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,ReceiptName,NoteFor FROM ReceiptView WHERE EndService IS NULL"
        'AppendReportConditions()
        'SQLQuery &= " ORDER BY ID DESC"
        'SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        'Dim Param() As SqlParameter =
        '    {
        '    New SqlParameter("@Num", TxtNum.Text.Trim),
        '    New SqlParameter("@ReceiptName", "%" & TxtReciptName.Text.Trim & "%"),
        '    New SqlParameter("@PaymentTypeID", (IIf(IsNothing(CmbPaymentType.SelectedValue), 0, CmbPaymentType.SelectedValue))),
        '    New SqlParameter("@UserID", (IIf(IsNothing(CmbUserName.SelectedValue), 0, CmbUserName.SelectedValue))),
        '    New SqlParameter("@BankID", (IIf(IsNothing(CmbBank.SelectedValue), 0, CmbBank.SelectedValue))),
        '    New SqlParameter("@ReceiptFinanceTypeID", (IIf(IsNothing(CmbFinancRecipt.SelectedValue), 0, CmbFinancRecipt.SelectedValue))),
        '    New SqlParameter("@Check", "%" & Val(TxtCkeck.Text.Trim) & "%")
        '    }

        'DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

        'Dim F As New FrmPrint
        'Dim C As New CRRecieptList

        'C.SetDataSource(DSPrint.Tables(0))
        'C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        'C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        'F.CrystalReportViewer1.ReportSource = C
        'F.CrystalReportViewer1.Refresh()
        'F.Text = "طباعة"
        'F.CrystalReportViewer1.Zoom(100%)
        'F.WindowState = FormWindowState.Maximized
        'F.Show()
    End Sub

    Private Sub AppendReportConditions()

        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " InvoiceNum=@Num")
        If ChkOrderNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " OrderNum=@Num")
        If ChkUser.Checked And CmbUserName.Text.Trim <> "" And CmbUserName.SelectedValue <> 0 Then AppendToQuery(" AND ", " UserID=@UserID")
        If ChkCustomer.Checked And CmbCustomer.Text.Trim <> "" And CmbCustomer.SelectedValue <> 0 Then AppendToQuery(" AND ", " CustomerID=@CustomerID")
        If ChkDate.Checked Then AppendToQuery(" AND ", " Date BETWEEN '" & DTPFrom.Value.Date & " " & "00:00".ToString & "' AND '" & DTPTo.Value.Date & " " & "23:59".ToString & "'")

    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    '****************************************************************************
    '------------------Pagination-------------------------------------------
    Private Sub GetPagesCount()
        PageSize = NUDPageSize.Value
        If RowsCount = PageSize Then
            PagesCount = 1

        ElseIf RowsCount Mod PageSize = 0 And RowsCount <> 0 Then
            PagesCount = RowsCount / PageSize

        Else
            PagesCount = (RowsCount \ PageSize) + 1
        End If
        TxtPagesCount.Text = PagesCount

    End Sub

    Private Sub BtnNextPage_Click(sender As Object, e As EventArgs) Handles BtnNextPage.Click

        If Not SearchActive Then Exit Sub

        CheckPageSize()

        If PageNum < PagesCount Then
            PageNum += 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnPreviousPage_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage.Click

        If Not SearchActive Then Exit Sub

        CheckPageSize()

        If PageNum > 1 Then
            PageNum -= 1
        Else
            PageNum = 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnFirstPage_Click(sender As Object, e As EventArgs) Handles BtnFirstPage.Click

        If Not SearchActive Then Exit Sub
        PageNum = 1
        GetData(Data.Search)

    End Sub

    Private Sub BtnLastPage_Click(sender As Object, e As EventArgs) Handles BtnLastPage.Click

        If Not SearchActive Then Exit Sub

        CheckPageSize()
        PageNum = PagesCount
        GetData(Data.Search)

    End Sub

    Private Sub TxtPageNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPageNum.KeyDown

        If e.KeyCode = Keys.Enter Then
            CheckPageSize()

            If Val(TxtPageNum.Text) > Val(TxtPagesCount.Text) Then
                PageNum = TxtPagesCount.Text

            ElseIf Val(TxtPageNum.Text) <= 0 Then
                PageNum = 1

            Else
                PageNum = Val(TxtPageNum.Text)
            End If
            GetData(Data.Search)
        End If

    End Sub

    Private Sub TxtPageNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPageNum.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        End If
    End Sub

    Private Sub CheckPageSize()

        If PageSize <> My.Settings.PageSize Then
            PageNum = 1
            GetData(Data.Search)
        End If

    End Sub

    Private Sub NUDPageSize_TextChanged(sender As Object, e As EventArgs) Handles NUDPageSize.TextChanged

        If NUDPageSize.Value = 0 Then
            NUDPageSize.Value = 1
        Else
            NUDPageSize_ValueChanged(sender, e)
        End If

    End Sub

    Private Sub NUDPageSize_ValueChanged(sender As Object, e As EventArgs) Handles NUDPageSize.ValueChanged

        Dim SPageSize As Integer = My.Settings.PageSize

        If NUDPageSize.Value <> 0 And SPageSize <> NUDPageSize.Value Then
            My.Settings.PageSize = NUDPageSize.Value
            My.Settings.Save()
        End If

        DGV.Rows.Clear()
    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click
        If Not ChkNum.Checked And Not ChkOrderNum.Checked And Not ChkUser.Checked And Not ChkDate.Checked And Not ChkCustomer.Checked And Not ChkTailor.Checked And Not ChkService.Checked And Not ChkOrder.Checked Then Exit Sub
        TxtPageNum.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

    Private Sub PnlEditOrder_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseDown
        MoveObject(e, MouseEvent.Down, TLPOrderDetails)
    End Sub

    Private Sub PnlEditOrder_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseMove
        MoveObject(e, MouseEvent.Move, TLPOrderDetails)
    End Sub

    Private Sub PnlEditOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseUp
        MoveObject(e, MouseEvent.Up, TLPOrderDetails)
    End Sub

End Class