Imports System.Data.SqlClient

Public Class FrmEmployeeCashingReport
    Private DS, DSSearch As New DataSet
    Private ID As Integer = -1
    Private PageSize, PagesCount, RowsCount As Integer
    Private PageNum As Integer = 1
    Private SearchActive As Boolean

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmEmployeeCashingReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ChangeSystemColors(Me)
        If Me.Visible Then
            NUDPageSize.Value = My.Settings.PageSize
            DTPTo.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            DTPFrom.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)

            DTPTo.MinDate = DTPFrom.Value
            DTPFrom.Value = Now
            DTPTo.Value = Now
            TxtPagesCount.Text = 1

            GetData()
            '  BtnSearch_Click(sender, e)

        Else
            BtnNew_Click(sender, e)
            ChangeControlColor(Me)
            If Not IsNothing(DS) Then
                DS.Clear()
            End If

            If Not IsNothing(DSSearch) Then
                DSSearch.Clear()
            End If

        End If
    End Sub

    Public Sub GetData()
        Dim SQLCon = New SQLConClass()

        SQLQuery = " Select ID, Name FROM EmployeeTable  Where EndService IS NULL Order By Name
                     Select ID, Name FROM BankTable   Order By Name
                     Select ID, Name FROM PaymentTypeTable   "
        DS = SQLCon.SelectData(SQLQuery, 0, Nothing)
        FillData()
    End Sub

    Private Sub FillData()
        If DSHasTables(DS) Then
            If DS.Tables(0).Rows.Count > 0 Then
                CmbEmployee.DataSource = DS.Tables(0)
                CmbEmployee.DisplayMember = "Name"
                CmbEmployee.ValueMember = "ID"
                CmbEmployee.SelectedIndex = -1
            End If

            If DS.Tables(1).Rows.Count > 0 Then
                CmbBank.DataSource = DS.Tables(1)
                CmbBank.DisplayMember = "Name"
                CmbBank.ValueMember = "ID"
                CmbBank.SelectedIndex = -1
            End If

            If DS.Tables(2).Rows.Count > 0 Then
                CmbPaymentType.DataSource = DS.Tables(2)
                CmbPaymentType.DisplayMember = "Name"
                CmbPaymentType.ValueMember = "ID"
                CmbPaymentType.SelectedValue = -1
            End If
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If Not RadReceipt.Checked And Not RadCashing.Checked Then
            MsgTool("يرجى اختيار نوع الايصال قبض / صرف ", 0)
            Exit Sub
        End If

        If Not ChkNum.Checked And Not ChkEmployee.Checked And Not ChkDate.Checked And Not ChkPayment.Checked And Not ChkBank.Checked And Not ChkCheck.Checked Then
            MsgTool("يرجى اختيار طريقة بحث ", 0)
            Exit Sub
        End If

        IsDataMissing = False
        If IsInputEmpty(TLPSearch) Then IsDataMissing = True
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        PageNum = 1

        Search()
        SearchActive = True
    End Sub


    Private Sub Search()

        TxtPageNum.Text = PageNum
        PageSize = My.Settings.PageSize


        If RadReceipt.Checked = True Then
            SQLQuery = "SELECT ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت, * FROM EmployeeReciptView WHERE  EndService IS NULL "
            AppendConditions()
            '    SQLQuery += "  And"
            SQLQuery &= " ORDER BY ID DESC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
            SQLQuery &= " SELECT COUNT(ID) FROM EmployeeReciptView WHERE EndService IS NULL  "
            AppendConditions()

        ElseIf RadCashing.Checked Then
            SQLQuery = "SELECT ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت, * FROM EmployeeCashingView WHERE  EndService IS NULL "
            AppendConditions()
            '  SQLQuery += "  And"
            SQLQuery &= " ORDER BY ID DESC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
            SQLQuery &= " SELECT COUNT(ID) FROM EmployeeCashingView WHERE EndService IS NULL  "
            AppendConditions()

        End If

        Dim Param() As SqlParameter =
            {
            New SqlParameter("@Num", "%" & TxtNum.Text.Trim & "%"),
            New SqlParameter("@EmployeeID", CmbEmployee.SelectedValue),
            New SqlParameter("@BankID", CmbBank.SelectedValue),
            New SqlParameter("@Check", "%" & TxtCheck.Text.Trim & "%"),
            New SqlParameter("@PaymentTypeID", CmbPaymentType.SelectedValue)
            }

        Dim SQLCon = New SQLConClass()
        DSSearch = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSSearch.Tables.Count = 2 Then
            If DSSearch.Tables(1).Rows.Count > 0 Then
                RowsCount = DSSearch.Tables(1).Rows(0).Item(0)
            End If

            GetPagesCount()
            FillDGV()
        End If
    End Sub

    Private Sub FillDGV()
        DGVCashing.Rows.Clear()

        If Not DSHasTables(DSSearch) Then Exit Sub
        If DSSearch.Tables(0).Rows.Count = 0 Then
            MsgTool("لا توجد نتائج لهذا البحث", 0)
            Exit Sub
        End If

        For i = 0 To DSSearch.Tables(0).Rows.Count - 1

            With DSSearch.Tables(0).Rows(i)
                DGVCashing.Rows.Add()
                DGVCashing.Item(0, i).Value = .Item("ID") 'ID
                DGVCashing.Item(1, i).Value = .Item("ت")
                DGVCashing.Item(2, i).Value = Format(.Item("NUM"), "000000")
                DGVCashing.Item(3, i).Value = Format(.Item("Value"), "0.00")
                DGVCashing.Item(4, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DF))
                DGVCashing.Item(5, i).Value = .Item("EmployeeName")
                DGVCashing.Item(6, i).Value = .Item("PaymentTypeName")
                DGVCashing.Item(7, i).Value = .Item("NoteFor")

            End With
        Next
        DGVCashing.ClearSelection()

    End Sub

    Private Sub AppendConditions()

        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " Num=" & TxtNum.Text.Trim)
        If ChkPayment.Checked And CmbPaymentType.Text.Trim <> "" And CmbPaymentType.SelectedValue <> Nothing Then AppendToQuery(" AND ", " PaymentTypeID=" & CmbPaymentType.SelectedValue)
        If ChkEmployee.Checked And CmbEmployee.Text.Trim <> "" And CmbEmployee.SelectedValue <> 0 Then AppendToQuery(" AND ", " EmployeeID=" & CmbEmployee.SelectedValue)
        If ChkBank.Checked And CmbBank.Text.Trim <> "" And CmbBank.SelectedValue <> 0 Then AppendToQuery(" AND ", " BankID=" & CmbBank.SelectedValue)
        If ChkCheck.Checked And TxtCheck.Text.Trim <> "" Then AppendToQuery(" AND ", " CheckNum LIKE %" & TxtNum.Text.Trim & "% ")
        If ChkDate.Checked Then AppendToQuery(" AND ", " Date BETWEEN '" & DTPFrom.Value.Date & " " & "00:00".ToString & "' AND '" & DTPTo.Value.Date & " " & "23:59".ToString & "'")

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

    Private Sub ChkNum_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNum.CheckedChanged
        DGVCashing.Rows.Clear()
        If ChkNum.Checked = True Then

            TxtNum.Enabled = True
            TxtNum.Focus()
            TxtNum.BackColor = SystemColors.Window
            ChkEmployee.Checked = False
            ChkDate.Checked = False
            ChkPayment.Checked = False
            ChkBank.Checked = False
            ChkCheck.Checked = False

        Else
            TxtNum.Enabled = False
            TxtNum.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEmployee.CheckedChanged
        DGVCashing.Rows.Clear()
        If ChkEmployee.Checked = True Then

            CmbEmployee.Enabled = True
            CmbEmployee.Focus()
            CmbEmployee.BackColor = SystemColors.Window
            ChkNum.Checked = False

        Else
            CmbEmployee.Enabled = False
            CmbEmployee.SelectedIndex = -1
            CmbEmployee.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDate.CheckedChanged
        DGVCashing.Rows.Clear()
        If ChkDate.Checked = True Then
            DTPFrom.Enabled = True
            DTPTo.Enabled = True
            ChkNum.Checked = False

        Else
            DTPFrom.Enabled = False
            DTPFrom.Value = Now
            DTPTo.Enabled = False
            DTPTo.Value = Now
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkPayment_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPayment.CheckedChanged
        DGVCashing.Rows.Clear()
        If ChkPayment.Checked = True Then

            CmbPaymentType.Enabled = True
            CmbPaymentType.Focus()
            CmbPaymentType.BackColor = SystemColors.Window
            CmbPaymentType.SelectedValue = 1
            ChkNum.Checked = False

        Else
            CmbPaymentType.Enabled = False
            CmbPaymentType.SelectedValue = -1
            CmbPaymentType.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkBank_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBank.CheckedChanged
        DGVCashing.Rows.Clear()
        If ChkBank.Checked = True Then

            CmbBank.Enabled = True
            CmbBank.Focus()
            CmbBank.BackColor = SystemColors.Window
            ChkNum.Checked = False

        Else
            CmbBank.Enabled = False
            CmbBank.SelectedIndex = -1
            CmbBank.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkCkeck_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCheck.CheckedChanged
        DGVCashing.Rows.Clear()
        If ChkCheck.Checked = True Then

            TxtCheck.Enabled = True
            TxtCheck.Focus()
            TxtCheck.BackColor = SystemColors.Window
            ChkNum.Checked = False

        Else
            TxtCheck.Enabled = False
            TxtCheck.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Public Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ChangeControlColor(TLPSearch)
        Clear(TLPSearch)
        DGVCashing.Rows.Clear()
        TxtPagesCount.Text = 1
        TxtPageNum.Text = 1
        SearchActive = False
    End Sub

    '----Pagination
    Private Sub GetPagesCount()
        If RowsCount = PageSize Then
            PagesCount = 1

        ElseIf RowsCount Mod PageSize = 0 And RowsCount <> 0 Then
            PagesCount = RowsCount / PageSize

        Else
            PagesCount = (RowsCount \ PageSize) + 1
        End If

        TxtPagesCount.Text = PagesCount
        TxtPageNum.Text = PageNum
    End Sub

    Private Sub TxtCurrentPage_Click(sender As Object, e As EventArgs) Handles TxtPageNum.Click
        TxtPageNum.SelectAll()
        SelectAllText = True
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
            Search()
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

            Search()
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

        DGVCashing.Rows.Clear()
    End Sub
    '----Pagination

    Private Sub BtnFirstPage_Click(sender As Object, e As EventArgs) Handles BtnFirstPage.Click
        If SearchActive = False Then Exit Sub
        PageNum = 1
        Search()
    End Sub

    Private Sub BtnPreviousPage_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage.Click
        If SearchActive = False Then Exit Sub
        CheckPageSize()
        If PageNum > 1 Then
            PageNum -= 1
        Else
            PageNum = 1
        End If

        Search()
    End Sub

    Private Sub BtnNextPage_Click(sender As Object, e As EventArgs) Handles BtnNextPage.Click
        If SearchActive = False Then Exit Sub
        CheckPageSize()
        If PageNum < PagesCount Then
            PageNum += 1
        End If
        Search()
    End Sub

    Private Sub BtnLastPage_Click(sender As Object, e As EventArgs) Handles BtnLastPage.Click
        If SearchActive = False Then Exit Sub
        CheckPageSize()
        PageNum = PagesCount

        Search()
    End Sub

    Private Sub DGVCashing_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCashing.CellContentClick
        If CheckDGVError(DGVCashing) Then Exit Sub
        ID = DGVCashing.Item(0, DGVCashing.CurrentRow.Index).Value
        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name

        If Col = "ColShow" Then
            If RadReceipt.Checked Then
                FrmTreasuryReceiptsContainer.LblReceipt_Click(sender, e)
                FrmEmployeeReceipt.ReceiptID = ID
                FrmEmployeeReceipt.SearchReceipt()
            End If

            If RadCashing.Checked Then
                FrmTreasuryReceiptsContainer.LblCashing_Click(sender, e)
                FrmEmployeeCashing.CashingID = ID
                FrmEmployeeCashing.SearchCashing()
            End If
        End If

    End Sub

    Private Sub DGVCashing_DoubleClick(sender As Object, e As EventArgs) Handles DGVCashing.DoubleClick
        If CheckDGVError(DGVCashing) Then Exit Sub
        ID = DGVCashing.Item(0, DGVCashing.CurrentRow.Index).Value

        If RadReceipt.Checked Then
            FrmTreasuryReceiptsContainer.LblReceipt_Click(sender, e)
            FrmEmployeeReceipt.ReceiptID = ID
            FrmEmployeeReceipt.SearchReceipt()
        End If

        If RadCashing.Checked Then
            FrmTreasuryReceiptsContainer.LblCashing_Click(sender, e)
            FrmEmployeeCashing.CashingID = ID
            FrmEmployeeCashing.SearchCashing()
        End If

    End Sub

    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles TxtNum.TextChanged
        sender.BackColor = SystemColors.Window
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub CmbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEmployee.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub CmbEmployee_TextChanged(sender As Object, e As EventArgs) Handles CmbEmployee.TextChanged
        sender.BackColor = SystemColors.Window
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub CmbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPaymentType.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub CmbPaymentType_TextChanged(sender As Object, e As EventArgs) Handles CmbPaymentType.TextChanged
        sender.BackColor = SystemColors.Window
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub RadReceipt_CheckedChanged(sender As Object, e As EventArgs) Handles RadReceipt.CheckedChanged
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub RadCashing_CheckedChanged(sender As Object, e As EventArgs) Handles RadCashing.CheckedChanged
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click
        If Not ChkNum.Checked And Not ChkEmployee.Checked And Not ChkDate.Checked And Not ChkPayment.Checked And Not ChkBank.Checked And Not ChkCheck.Checked Then Exit Sub

        TxtPageNum.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

    'Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
    '    If DGVCashing.Rows.Count = 0 Then Exit Sub

    '    Dim DSPrint = New DataSet
    '    Dim SQLCon = New SQLConClass

    '    If RadReceipt.Checked = True Then

    '        SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,EmployeeName,NoteFor FROM EmployeeReciptView WHERE EndService IS NULL"
    '        AppendReportConditions()
    '        SQLQuery &= " ORDER BY ID DESC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
    '        SQLQuery &= " SELECT * FROM CenterMainInfoTable"

    '        Dim Param() As SqlParameter =
    '        {
    '        New SqlParameter("@Num", TxtNum.Text.Trim),
    '        New SqlParameter("@PaymentTypeID", (IIf(IsNothing(CmbPaymentType.SelectedValue), 0, CmbPaymentType.SelectedValue))),
    '        New SqlParameter("@EmployeeID", (IIf(IsNothing(CmbEmployee.SelectedValue), 0, CmbEmployee.SelectedValue))),
    '        New SqlParameter("@BankID", (IIf(IsNothing(CmbBank.SelectedValue), 0, CmbBank.SelectedValue))),
    '        New SqlParameter("@Check", "%" & Val(TxtCheck.Text.Trim) & "%")
    '        }

    '        DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

    '        Dim F As New FrmPrint
    '        Dim C As New CRTreasuryRecieptList

    '        C.SetDataSource(DSPrint.Tables(0))
    '        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
    '        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
    '        F.CrystalReportViewer1.ReportSource = C
    '        F.CrystalReportViewer1.Refresh()
    '        F.Text = "طباعة"
    '        F.CrystalReportViewer1.Zoom(100%)
    '        F.WindowState = FormWindowState.Maximized
    '        F.Show()

    '    ElseIf RadCashing.Checked = True Then

    '        SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,EmployeeName,NoteFor FROM EmployeeCashingView WHERE EndService IS NULL"
    '        AppendReportConditions()
    '        SQLQuery &= " ORDER BY ID DESC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
    '        SQLQuery &= " SELECT * FROM CenterMainInfoTable"

    '        Dim Param() As SqlParameter =
    '        {
    '        New SqlParameter("@Num", TxtNum.Text.Trim),
    '        New SqlParameter("@PaymentTypeID", (IIf(IsNothing(CmbPaymentType.SelectedValue), 0, CmbPaymentType.SelectedValue))),
    '        New SqlParameter("@EmployeeID", (IIf(IsNothing(CmbEmployee.SelectedValue), 0, CmbEmployee.SelectedValue))),
    '        New SqlParameter("@BankID", (IIf(IsNothing(CmbBank.SelectedValue), 0, CmbBank.SelectedValue))),
    '        New SqlParameter("@Check", "%" & Val(TxtCheck.Text.Trim) & "%")
    '        }

    '        DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

    '        Dim F As New FrmPrint
    '        Dim C As New CRTreasuryCashingList

    '        C.SetDataSource(DSPrint.Tables(0))
    '        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
    '        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
    '        F.CrystalReportViewer1.ReportSource = C
    '        F.CrystalReportViewer1.Refresh()
    '        F.Text = "طباعة"
    '        F.CrystalReportViewer1.Zoom(100%)
    '        F.WindowState = FormWindowState.Maximized
    '        F.Show()

    '    End If


    'End Sub

    'Private Sub BtnPrintAll_Click(sender As Object, e As EventArgs) Handles BtnPrintAll.Click
    '    If DGVCashing.Rows.Count = 0 Then Exit Sub

    '    Dim DSPrint = New DataSet
    '    Dim SQLCon = New SQLConClass

    '    If RadReceipt.Checked = True Then

    '        SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,EmployeeName,NoteFor FROM EmployeeReciptView WHERE EndService IS NULL"
    '        AppendReportConditions()
    '        SQLQuery &= " ORDER BY ID DESC"
    '        SQLQuery &= " SELECT * FROM CenterMainInfoTable"

    '        Dim Param() As SqlParameter =
    '        {
    '        New SqlParameter("@Num", TxtNum.Text.Trim),
    '        New SqlParameter("@PaymentTypeID", (IIf(IsNothing(CmbPaymentType.SelectedValue), 0, CmbPaymentType.SelectedValue))),
    '        New SqlParameter("@EmployeeID", (IIf(IsNothing(CmbEmployee.SelectedValue), 0, CmbEmployee.SelectedValue))),
    '        New SqlParameter("@BankID", (IIf(IsNothing(CmbBank.SelectedValue), 0, CmbBank.SelectedValue))),
    '        New SqlParameter("@Check", "%" & Val(TxtCheck.Text.Trim) & "%")
    '        }

    '        DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

    '        Dim F As New FrmPrint
    '        Dim C As New CRTreasuryRecieptList

    '        C.SetDataSource(DSPrint.Tables(0))
    '        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
    '        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
    '        F.CrystalReportViewer1.ReportSource = C
    '        F.CrystalReportViewer1.Refresh()
    '        F.Text = "طباعة"
    '        F.CrystalReportViewer1.Zoom(100%)
    '        F.WindowState = FormWindowState.Maximized
    '        F.Show()

    '    ElseIf RadCashing.Checked = True Then

    '        SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,EmployeeName,NoteFor FROM EmployeeCashingView WHERE EndService IS NULL"
    '        AppendReportConditions()
    '        SQLQuery &= " ORDER BY ID DESC"
    '        SQLQuery &= " SELECT * FROM CenterMainInfoTable"

    '        Dim Param() As SqlParameter =
    '        {
    '        New SqlParameter("@Num", TxtNum.Text.Trim),
    '        New SqlParameter("@PaymentTypeID", (IIf(IsNothing(CmbPaymentType.SelectedValue), 0, CmbPaymentType.SelectedValue))),
    '        New SqlParameter("@EmployeeID", (IIf(IsNothing(CmbEmployee.SelectedValue), 0, CmbEmployee.SelectedValue))),
    '        New SqlParameter("@BankID", (IIf(IsNothing(CmbBank.SelectedValue), 0, CmbBank.SelectedValue))),
    '        New SqlParameter("@Check", "%" & Val(TxtCheck.Text.Trim) & "%")
    '        }

    '        DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

    '        Dim F As New FrmPrint
    '        Dim C As New CRTreasuryCashingList

    '        C.SetDataSource(DSPrint.Tables(0))
    '        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
    '        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
    '        F.CrystalReportViewer1.ReportSource = C
    '        F.CrystalReportViewer1.Refresh()
    '        F.Text = "طباعة"
    '        F.CrystalReportViewer1.Zoom(100%)
    '        F.WindowState = FormWindowState.Maximized
    '        F.Show()

    '    End If

    'End Sub

    Private Sub AppendReportConditions()

        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " Num=@Num")
        If ChkPayment.Checked And CmbPaymentType.Text.Trim <> "" And CmbPaymentType.SelectedValue <> Nothing Then AppendToQuery(" AND ", " PaymentTypeID=@PaymentTypeID")
        If ChkEmployee.Checked And CmbEmployee.Text.Trim <> "" And CmbEmployee.SelectedValue <> Nothing Then AppendToQuery(" AND ", " EmployeeID=@EmployeeID")
        If ChkBank.Checked And CmbBank.Text.Trim <> "" And CmbBank.SelectedValue <> 0 Then AppendToQuery(" AND ", " BankID=@BankID")
        If ChkCheck.Checked And ChkCheck.Text.Trim <> "" Then AppendToQuery(" AND ", " CheckNum LIKE @Check")
        If ChkDate.Checked Then AppendToQuery(" AND ", " Date BETWEEN '" & DTPFrom.Value.Date & " " & "00:00".ToString & "' AND '" & DTPTo.Value.Date & " " & "23:59".ToString & "'")

    End Sub

    Private Sub CmbBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBank.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub CmbBank_TextChanged(sender As Object, e As EventArgs) Handles CmbBank.TextChanged
        sender.BackColor = SystemColors.Window
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub TxtCheck_TextChanged(sender As Object, e As EventArgs) Handles TxtCheck.TextChanged
        sender.BackColor = SystemColors.Window
        DGVCashing.Rows.Clear()
    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtCheck_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCheck.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub
End Class