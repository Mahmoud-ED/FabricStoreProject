Imports System.Data.SqlClient

Public Class FrmSalesReport

    Private PageSize, PagesCount, RowsCount, SellID As Integer
    Private PageNum As Integer = 1
    Private SearchActive As Boolean

    Private FromChkNum As Boolean
    Private DSMain, DSSearch, DSDel As New DataSet


    Private Enum Data
        Search
        Main
    End Enum

    Private Sub FrmSalesReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
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
                SQLQuery &= " Select ID,Name From CustomersTable  where EndService IS Null  Order By Name  "

                DSMain = SQLCon.SelectData(SQLQuery)
                FillData(Type, DSMain, 2)

            Case Data.Search

                Dim Param() As SqlParameter =
                    {New SqlParameter("@Num", Val(TxtNum.Text))}
                SQLQuery = "SELECT  ROW_NUMBER() OVER (ORDER BY (Date)Desc) As ت, * From CustomerInvoiceView  WHERE 1=1 "

                AppendConditions()
                SQLQuery &= " ORDER BY CustomerInvoiceView.Date Desc OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
                SQLQuery &= " SELECT COUNT(CustomerID) FROM CustomerInvoiceView  WHERE 1=1  "
                AppendConditions()

                DSSearch = SQLCon.SelectData(SQLQuery, 0, Param)
                FillData(Type, DSSearch, 2)

        End Select

    End Sub

    Private Sub AppendConditions()

        Dim DateTimeFrom As Date = DTPFrom.Value.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTPTo.Value.Date & " " & "23:59".ToString
        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " CustomerInvoiceView.Num=@Num ")
        If ChkUser.Checked And CmbUserName.SelectedValue <> Nothing Then AppendToQuery(" AND ", "  CustomerInvoiceView.UserID = " & CmbUserName.SelectedValue)
        If ChkCustomer.Checked And CmbCustomer.SelectedValue <> Nothing Then AppendToQuery(" AND ", " CustomerInvoiceView.CustomerID = " & CmbCustomer.SelectedValue)
        If ChkDate.Checked Then AppendToQuery(" AND ", " Date BETWEEN '" & DateTimeFrom & "' AND '" & DateTimeTo & "' ")
    End Sub

    Private Sub ChkChecks()
        If ChkDate.Checked = False And ChkNum.Checked = False And ChkUser.Checked = False And ChkCustomer.Checked = False Then Exit Sub
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSaerch.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        DGV.Rows.Clear()
        ChkChecks()
        If ChkDate.Checked = False And ChkNum.Checked = False And ChkUser.Checked = False And ChkCustomer.Checked = False Then
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

        Else
            ' ChangeControlColor(Me)
            ChkDate.Checked = True
            TxtNum.Enabled = False
            TxtNum.Text = ""
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

        Else
            CmbCustomer.Text = ""
            CmbCustomer.Enabled = False
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

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ChangeControlColor(Me)
        DGV.Rows.Clear()
        ChkDate.Checked = True
        ChkNum.Checked = False
        ChkUser.Checked = False
        ChkCustomer.Checked = False
        SearchActive = False
    End Sub

    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles TxtNum.TextChanged, CmbUserName.TextChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch_Click(sender, e)
        End If
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
                        DGV.Item(0, i).Value = .Item("InvoiceID")
                        DGV.Item(1, i).Value = .Item("ت") 'i + 1
                        DGV.Item(2, i).Value = Format(.Item("Num"), "000000")
                        DGV.Item(3, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DTF))
                        DGV.Item(4, i).Value = .Item("CustomerName")
                        DGV.Item(5, i).Value = Format(.Item("Total"), "0.00")
                        DGV.Item(6, i).Value = Format(.Item("TotalReceipts"), "0.00")
                        DGV.Item(7, i).Value = Format(.Item("RemainingAmount"), "0.00")

                    End With
                Next
                DGV.ClearSelection()

        End Select

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

    End Sub

    Private Sub CmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCustomer.SelectedIndexChanged
        DGV.Rows.Clear()
    End Sub

    Private Sub CmbCustomer_TextChanged(sender As Object, e As EventArgs) Handles CmbCustomer.TextChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If DGV.Rows.Count = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "SELECT FORMAT(Num,'000000') AS Num, Date, Name, [User],Total FROM InvoiceView  WHERE EndService IS NULL "
        AppendReportConditions()
        SQLQuery &= " ORDER BY ID DESC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        Dim Param() As SqlParameter =
            {
            New SqlParameter("@Num", TxtNum.Text.Trim)}

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

        Dim F As New FrmPrint
        Dim C As New CRSellInvoiceReports

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()
    End Sub

    Private Sub BtnPrintAll_Click(sender As Object, e As EventArgs) Handles BtnPrintAll.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If DGV.Rows.Count = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "SELECT FORMAT(Num,'000000') AS Num, Date, Name, [User],Total FROM InvoiceView  WHERE EndService IS NULL "
        AppendReportConditions()
        SQLQuery &= " ORDER BY ID DESC  "
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        Dim Param() As SqlParameter =
            {
            New SqlParameter("@Num", TxtNum.Text.Trim)}

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

        Dim F As New FrmPrint
        Dim C As New CRPurchasesInvoiceReports

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()
    End Sub

    Private Sub AppendReportConditions()

        Dim DateTimeFrom As Date = DTPFrom.Value.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTPTo.Value.Date & " " & "23:59".ToString
        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " Num=@Num")
        If ChkUser.Checked And CmbUserName.Text.Trim <> "" And CmbUserName.SelectedValue <> 0 Then AppendToQuery(" AND ", " UserID=" & CmbUserName.SelectedValue)
        If ChkCustomer.Checked And CmbCustomer.Text.Trim <> "" And CmbCustomer.SelectedValue <> 0 Then AppendToQuery(" AND ", " CustomerID=" & CmbCustomer.SelectedValue)
        If ChkDate.Checked Then AppendToQuery(" AND ", " Date BETWEEN '" & DTPFrom.Value.Date & " " & "00:00".ToString & "' AND '" & DTPTo.Value.Date & " " & "23:59".ToString & "'")

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

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If DGV.RowCount = 0 Then Exit Sub

        SellID = DGV.Item(0, DGV.CurrentRow.Index).Value

        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If Col = "ColDel" Then

            If vbYes = MsgBox("هل تريد حذف الفاتورة رقم  " & vbCrLf & "( " & DGV.Item(2, DGV.CurrentRow.Index).Value & " ) ؟", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الحذف") Then
                Dim SQLCon = New SQLConClass
                Dim Param() As SqlParameter = {
                    New SqlParameter("@ID", SellID)}

                DSDel = SQLCon.CMDExecuteData("DeleteSales", Param)

                If Save = 1 Then
                    MsgTool("تم حذف الفاتورة ", 1)
                    'FrmSales.InvoiceID = 0

                ElseIf Save = 2 Then
                    MsgTool("لا يمكن حذف الفاتورة", 0)
                End If
            End If

        ElseIf Col = "ColShow" Then
            If SellID = 0 Then Exit Sub
            FrmSellInvoiceContents.SellID = SellID
            FrmSellInvoiceContents.ShowDialog()

        End If

        BtnSearch_Click(sender, e)

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
        If Not ChkNum.Checked And Not ChkUser.Checked And Not ChkDate.Checked And Not ChkCustomer.Checked Then Exit Sub

        TxtPageNum.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        If DGV.RowCount = 0 Then Exit Sub

        FrmSales.InvoiceID = DGV.Item(0, DGV.CurrentRow.Index).Value
        FrmSalesContainer.LblInvoice_Click(sender, e)


    End Sub

End Class