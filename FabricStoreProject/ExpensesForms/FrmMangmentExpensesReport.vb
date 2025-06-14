'100%
Imports System.Data.SqlClient

Public Class FrmMangmentExpensesReport

    Private DsLoad, DSReport, Dssave As DataSet
    Private ExpensesIDForUpdate As Integer
    Private PageSize, PagesCount, RowsCount As Integer
    Private PageNum As Integer = 1
    Private FromPignation As Boolean
    Private IsLoad As Boolean = True
    Private UserIDReport, EmployeUserID As Integer
    Private SearchActive, State As Boolean
    Private LastForm As String = Me.Name
    Private DFrom, DTo As Date
    Private M, Y, U As Integer

    Private Sub FrmMangmentExpensesReport_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub GetCmbData()
        Dim sqlcon As New SQLConClass()
        SQLQuery = " SELECT * FROM UserView WHERE  EndService IS NULL ORDER BY Name"
        'SQLQuery += " Select ID , Name From ExpensesTypeTable ORDER BY Name"

        Dim DS As DataSet
        DS = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DS.Tables(0).Rows.Count = 0 Then Exit Sub
        CmbUserReport.DataSource = DS.Tables(0)
        CmbUserReport.DisplayMember = "Name"
        CmbUserReport.ValueMember = "ID"
        CmbUserReport.SelectedIndex = -1

        'CmbTypeExpenses.DataSource = DS.Tables(1)
        'CmbTypeExpenses.DisplayMember = "Name"
        'CmbTypeExpenses.ValueMember = "ID"
        'CmbTypeExpenses.SelectedIndex = -1

    End Sub

    Private Sub FrmMangmentExpensesReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        BtnRefreshReport_Click(sender, e)
        If Me.Visible = True Then

            GetCmbData()
            DTPFromDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            DTPToDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            CmbYearReport.Items.Clear()
            CmbMonthReport.Items.Clear()
            For i = Now.Date.Year To Now.Date.Year - 5 Step -1
                CmbYearReport.Items.Add(i)
            Next
            For i = 1 To 12 Step +1
                CmbMonthReport.Items.Add(i)
            Next
            CmbYearReport.Enabled = False
            CmbMonthReport.Enabled = False
            ProgressBar1.Value = 0
            NUDPageSize.Value = My.Settings.PageSize
            TxtPagesCount.Text = 1
            TxtCurrentPage.Text = 1

        Else
            DGVExpensesReport.Rows.Clear()
            BtnRefreshReport_Click(sender, e)
            If Not IsNothing(DSReport) Then
                DSReport.Clear()
            End If
            If Not IsNothing(DsLoad) Then
                DsLoad.Clear()
            End If
            If Not IsNothing(Dssave) Then
                Dssave.Clear()
            End If
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    '****************************************************************************
    '------------------Pagination-------------------------------------------
    '****************************************************************************

    Private Sub GetPagesCount()

        If RowsCount = PageSize Then
            PagesCount = 1

        ElseIf RowsCount Mod PageSize = 0 And RowsCount <> 0 Then
            PagesCount = RowsCount / PageSize

        Else
            PagesCount = (RowsCount \ PageSize) + 1
        End If
        TxtPagesCount.Text = PagesCount
        TxtCurrentPage.Text = PageNum

    End Sub

    Private Sub BtnNextPage_Click(sender As Object, e As EventArgs) Handles BtnNextPage.Click
        If Not SearchActive Then Exit Sub
        CheckPageSize()

        If PageNum < PagesCount Then
            PageNum += 1
            TxtCurrentPage.Text = PageNum
        End If
        searech()

    End Sub
    Private Sub BtnPreviousPage_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage.Click
        If Not SearchActive Then Exit Sub

        CheckPageSize()
        If PageNum > 1 Then
            PageNum -= 1
            TxtCurrentPage.Text = PageNum
        Else
            PageNum = 1
            TxtCurrentPage.Text = PageNum

        End If
        searech()

    End Sub
    Private Sub BtnFirstPage_Click(sender As Object, e As EventArgs) Handles BtnFirstPage.Click
        If Not SearchActive Then Exit Sub

        PageNum = 1
        searech()

    End Sub
    Private Sub BtnLastPage_Click(sender As Object, e As EventArgs) Handles BtnLastPage.Click
        If Not SearchActive Then Exit Sub

        CheckPageSize()
        PageNum = PagesCount
        searech()

    End Sub
    Private Sub TxtCurrentPage_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCurrentPage.KeyDown

        If e.KeyCode = Keys.Enter Then
            CheckPageSize()

            If Val(TxtCurrentPage.Text) > Val(TxtPagesCount.Text) Then
                PageNum = TxtPagesCount.Text

            ElseIf Val(TxtCurrentPage.Text) <= 0 Then
                PageNum = 1

            Else
                PageNum = Val(TxtCurrentPage.Text)
            End If
            searech()
        End If

    End Sub
    Private Sub CheckPageSize()

        Dim SPageSize As Integer = My.Settings.PageSize

        If PageSize <> SPageSize Then
            PageNum = 1
            searech() 'عند تغيير حجم الصفحة يجب معرفة عدد الصفحات الجديد PagesCount
        End If

    End Sub

    Private Sub NUDPageSize_ValueChanged(sender As Object, e As EventArgs) Handles NUDPageSize.ValueChanged

        If NUDPageSize.Value <> 0 And My.Settings.PageSize <> NUDPageSize.Value Then
            My.Settings.PageSize = NUDPageSize.Value
            My.Settings.Save()
        End If
        DGVExpensesReport.Rows.Clear()
    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click
        If Not ChkUserReport.Checked And Not ChkReciptName.Checked And Not ChkMonth.Checked And Not ChkDate.Checked Then
            Exit Sub
        End If

        TxtCurrentPage.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

    Private Sub NUDPageSize_TextChanged(sender As Object, e As EventArgs) Handles NUDPageSize.TextChanged

        If NUDPageSize.Value = 0 Then
            NUDPageSize.Value = 1
        Else
            NUDPageSize_ValueChanged(sender, e)
        End If

    End Sub

    '--------------------------------------------------
    Private Sub FillDGVReport(D As DataSet)
        DGVExpensesReport.Rows.Clear()

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = D.Tables(0).Rows.Count

        For i = 0 To D.Tables(0).Rows.Count - 1
            With D.Tables(0).Rows(i)
                DGVExpensesReport.Rows.Add()
                DGVExpensesReport.Item(0, i).Value = .Item(1) 'ID
                DGVExpensesReport.Item(1, i).Value = .Item(0) 'ت
                DGVExpensesReport.Item(2, i).Value = .Item(2) 'UserName
                DGVExpensesReport.Item(3, i).Value = .Item(8) 'Date
                DGVExpensesReport.Item(4, i).Value = .Item(5) 'reiptName
                DGVExpensesReport.Item(5, i).Value = .Item(6) 'Nots
                DGVExpensesReport.Item(6, i).Value = Format(.Item(7), "0.00") 'Value
                DGVExpensesReport.Item(7, i).Value = .Item(3) + " - " + .Item(4) ' year-month
                DGVExpensesReport.Item(8, i).Value = .Item(11)
                DGVExpensesReport.Item(9, i).Value = .Item(10) ' UserID
                If DGVExpensesReport.Item(8, i).Value = True Then
                    DGVExpensesReport.Item(6, i).Style.BackColor = Color.LightGray
                    DGVExpensesReport.Item(6, i).Style.ForeColor = Color.White
                End If
            End With
            ProgressBar1.Value += 1
            DGVExpensesReport.ClearSelection()
        Next
    End Sub
    '---------------------------------------ChkChaing----------------------------------

    Private Sub ChkEmpName_CheckedChanged(sender As Object, e As EventArgs) Handles ChkReciptName.CheckedChanged
        DGVExpensesReport.Rows.Clear()

        If ChkReciptName.Checked Then
            TxtReciptNameReport.Enabled = True
            TxtReciptNameReport.Focus()

        Else
            TxtReciptNameReport.Text = ""
            TxtReciptNameReport.Enabled = False
            TxtReciptNameReport.BackColor = SystemColors.Window
            SearchActive = False
            TxtCurrentPage.Text = 1
            TxtPagesCount.Text = 1
        End If

    End Sub

    Private Sub ChkMonth_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMonth.CheckedChanged
        DGVExpensesReport.Rows.Clear()

        If ChkMonth.Checked Then
            CmbYearReport.Enabled = True
            CmbYearReport.Text = Now.Date.Year
            CmbMonthReport.Enabled = True
            CmbMonthReport.Text = Now.Date.Month

        Else
            TxtReciptNameReport.Text = ""
            TxtReciptNameReport.Enabled = False
            CmbYearReport.Enabled = False
            CmbYearReport.SelectedIndex = -1
            CmbMonthReport.Enabled = False
            CmbMonthReport.SelectedIndex = -1
            SearchActive = False
            TxtCurrentPage.Text = 1
            TxtPagesCount.Text = 1
        End If

    End Sub
    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDate.CheckedChanged
        DGVExpensesReport.Rows.Clear()

        If ChkDate.Checked = True Then
            DTPFromDate.Enabled = True
            DTPToDate.Enabled = True

        Else
            DTPFromDate.Enabled = False
            DTPToDate.Enabled = False
            SearchActive = False
            TxtCurrentPage.Text = 1
            TxtPagesCount.Text = 1
        End If

    End Sub

    Private Sub ChkUserReport_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUserReport.CheckedChanged
        DGVExpensesReport.Rows.Clear()
        If ChkUserReport.Checked Then
            CmbUserReport.Enabled = True
            CmbUserReport.Focus()

        Else
            CmbUserReport.SelectedIndex = -1
            CmbUserReport.Enabled = False
            CmbUserReport.Text = ""
            CmbUserReport.BackColor = SystemColors.Window
            SearchActive = False
            TxtCurrentPage.Text = 1
            TxtPagesCount.Text = 1

        End If
    End Sub
    '-----------------DGVReport2Clik----------------------------

    Private Sub DGVExpensesReport_Click(sender As Object, e As EventArgs) Handles DGVExpensesReport.Click
        If CheckDGVError(DGVExpensesReport) = True Then Exit Sub
        '     DocExpID = DGVReport.Item(0, DGVReport.CurrentRow.Index).Value

        DFrom = DGVExpensesReport.Item(3, DGVExpensesReport.CurrentRow.Index).Value
        DTo = DGVExpensesReport.Item(3, DGVExpensesReport.CurrentRow.Index).Value
        Y = DTo.Year
        M = DTo.Month
        U = DGVExpensesReport.Item(9, DGVExpensesReport.CurrentRow.Index).Value
    End Sub

    Private Sub DGVExpensesReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVExpensesReport.CellContentClick

    End Sub

    Private Sub DGVExpensesReport_DoubleClick(sender As Object, e As EventArgs) Handles DGVExpensesReport.DoubleClick
        'If CheckDGVError(DGVExpensesReport) = True Then Exit Sub
        ''DTPDate.MinDate = Now.Year & "-" & Now.Month & "-" & "1"
        ''DTPDate.MaxDate = Now.Year & "-" & Now.Month & "-" & Now.Day
        'If DFrom >= Now.Year & "-" & Now.Month & "-" & "1" And DFrom <= Now.Year & "-" & Now.Month & "-" & Now.Day Then
        '    Dim CR As Integer
        '    CR = DGVExpensesReport.CurrentRow.Index
        '    FrmMangmentExpenses.ID = DGVExpensesReport.Item(0, CR).Value
        '    FrmMangmentExpensesContainer.LblExpenses_Click(sender, e)
        '    FrmMangmentExpenses.DisPlayFromReport(DFrom, DTo, Y, M, U)
        'End If
    End Sub

    Private Sub BtnPrintReport_Click(sender As Object, e As EventArgs) Handles BtnPrintReport.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=2")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If DGVExpensesReport.Rows.Count = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "SELECT UserName,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,ReceiptName,Name FROM ExpensesReportView WHERE 1=1"
        AppendReportConditions()
        SQLQuery &= " ORDER BY ID DESC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        Dim F As New FrmPrint
        Dim C As New CRExpensesReports

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        C.SetParameterValue("Title", "مصروفات المتجر")
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()

    End Sub

    Private Sub BtnPrintAll_Click(sender As Object, e As EventArgs) Handles BtnPrintAll.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=2")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub

        'End If
        If DGVExpensesReport.Rows.Count = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "SELECT UserName,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,ReceiptName,Name FROM ExpensesReportView WHERE 1=1"
        AppendReportConditions()
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        Dim F As New FrmPrint
        Dim C As New CRExpensesReports

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        C.SetParameterValue("Title", "مصروفات المتجر")
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()
    End Sub

    Private Sub AppendReportConditions()
        If ChkUserReport.Checked And CmbUserReport.SelectedValue <> Nothing Then AppendToQuery(" AND ", " UserID=" & (IIf(IsNothing(CmbUserReport.SelectedValue), 0, CmbUserReport.SelectedValue)))
        If ChkMonth.Checked Then AppendToQuery(" AND ", " [Month]=" & Val(CmbMonthReport.Text) & "  AND [Year]= " & Val(CmbYearReport.Text) & "")
        If ChkReciptName.Checked And TxtReciptNameReport.Text.Trim <> "" Then AppendToQuery(" AND ", " ReceiptName Like '%" & TxtReciptNameReport.Text.Trim & "%'")
        'If ChkExpenses.Checked And Not IsNothing(CmbTypeExpenses.SelectedValue) Then AppendToQuery(" AND ", " ExpensesTypeID=" & (IIf(IsNothing(CmbTypeExpenses.SelectedValue), 0, CmbTypeExpenses.SelectedValue)))
        If ChkDate.Checked Then
            Dim DateTimeFrom As Date = DTPFromDate.Value.Date & " " & "00:00:00".ToString
            Dim DateTimeTo As Date = DTPToDate.Value.Date & " " & "23:59:00".ToString
            AppendToQuery(" AND ", " [Date] BETWEEN '" & DateTimeFrom & "' AND '" & DateTimeTo & "'")
        End If
    End Sub

    'Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles DGVExpensesReport.Click
    '    If ExpensesIDForUpdate = 0 Then Exit Sub
    '    MangExpensesID = ExpensesIDForUpdate
    '    FrmMangmentExpensesContainer.LblExpenses_Click(sender, e)
    'End Sub

    '-----------------Report----------------------------

    Private Sub BtnRefreshReport_Click(sender As Object, e As EventArgs) Handles BtnRefreshReport.Click
        ProgressBar1.Value = 0
        SearchActive = False
        ChangeControlColor(Me)

        TxtSumReportAmont.Text = "0"
        TxtCurrentPage.Text = 1
        TxtPagesCount.Text = 1
        ExpensesIDForUpdate = 0
        Clear(GrpReport)
        SetTextColor()
        DGVExpensesReport.Rows.Clear()
        DGVExpensesReport.DataSource = Nothing
    End Sub

    Private Sub CmbUserReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUserReport.SelectedIndexChanged
        DGVExpensesReport.Rows.Clear()
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub
    Private Sub CmbUserReport_TextChanged(sender As Object, e As EventArgs) Handles CmbUserReport.TextChanged
        DGVExpensesReport.Rows.Clear()
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtReciptNameReport_TextChanged(sender As Object, e As EventArgs) Handles TxtReciptNameReport.TextChanged
        DGVExpensesReport.Rows.Clear()
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub


    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        PageNum = 1
        If ChkUserReport.Checked = False And ChkReciptName.Checked = False And ChkMonth.Checked = False And ChkDate.Checked = False Then
            Exit Sub
        End If
        IsDataMissing = False
        IsInputEmpty(GrpReport)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If
        searech()
        SearchActive = True

    End Sub

    Private Sub CmbYearReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbYearReport.SelectedIndexChanged
        DGVExpensesReport.Rows.Clear()
    End Sub

    Private Sub SetTextColor()
        CmbUserReport.BackColor = SystemColors.Window
        CmbMonthReport.BackColor = SystemColors.Window
        CmbYearReport.BackColor = SystemColors.Window
        TxtReciptNameReport.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbMonthReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMonthReport.SelectedIndexChanged
        DGVExpensesReport.Rows.Clear()
        sender.backColor = SystemColors.Window
    End Sub

    Private Sub searech()
        ProgressBar1.Value = 0
        TxtCurrentPage.Text = PageNum
        PageSize = My.Settings.PageSize

        Dim sqlcon As New SQLConClass()

        SQLQuery = "Select ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت, ExpensesContentTable.ID,
(Select name from UserView where UserView.ID=ExpensesContentTable.UserID ),Convert(Nvarchar(6),Year) ,
Convert(Nvarchar(6),Month), ExpensesContentTable.ReceiptName  ,ExpensesTypeTable.Name   ,Value  ,
ExpensesContentTable.Date  , ExpensesTypeID ,ExpensesContentTable.UserID , State, ExpensesTypeID "
        SQLQuery &= "  From ExpensesContentTable , MonthExpenseTable , ExpensesTypeTable "
        SQLQuery &= " Where ExpensesContentTable.ExpensesID = MonthExpenseTable.ID "
        SQLQuery &= " And ExpensesContentTable.ExpensesTypeID = ExpensesTypeTable.ID "
        SQLQuery &= " And EndService Is NULL   "
        'SQLQuery &= " And State = 0   "

        AppendConditions()
        SQLQuery &= " ORDER BY  ExpensesContentTable.ID DESC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"

        SQLQuery &= "  Select Count(ExpensesContentTable.ID) "
        SQLQuery &= "  From ExpensesContentTable , MonthExpenseTable , ExpensesTypeTable "
        SQLQuery &= " Where ExpensesContentTable.ExpensesID = MonthExpenseTable.ID "
        SQLQuery &= " And ExpensesContentTable.ExpensesTypeID = ExpensesTypeTable.ID "
        SQLQuery &= " And EndService Is NULL    "
        AppendConditions()

        SQLQuery &= "  Select SUM(VALUE) "
        SQLQuery &= "  From ExpensesContentTable , MonthExpenseTable , ExpensesTypeTable "
        SQLQuery &= " Where ExpensesContentTable.ExpensesID = MonthExpenseTable.ID "
        SQLQuery &= " And ExpensesContentTable.ExpensesTypeID = ExpensesTypeTable.ID "
        SQLQuery &= " And EndService Is NULL     "
        AppendConditions()

        Dim Param() As SqlParameter =
            {
             New SqlParameter("@ReceiptName", "%" & TxtReciptNameReport.Text.Trim & "%"),
             New SqlParameter("@Month", Val(CmbMonthReport.Text)),
             New SqlParameter("@Year", Val(CmbYearReport.Text))
            }

        DSReport = sqlcon.SelectData(SQLQuery, 0, Param)

        If DSHasTables(DSReport) Then
            If DSReport.Tables(1).Rows.Count > 0 Then
                RowsCount = DSReport.Tables(1).Rows(0).Item(0)
            End If

            GetPagesCount()
            FillDGVReport(DSReport)
            TxtSumReportAmont.Text = "0"
            If Not IsDBNull(DSReport.Tables(2).Rows(0).Item(0)) Then
                TxtSumReportAmont.Text = Format(DSReport.Tables(2).Rows(0).Item(0), "0.00")
            End If

            If DGVExpensesReport.Rows.Count = 0 Then
                MsgTool("لا توجد مصروفات ", 0)
            End If
        End If
    End Sub

    Private Sub DTPFromDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPFromDate.ValueChanged
        DGVExpensesReport.Rows.Clear()
    End Sub

    Private Sub BtnSaerch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DTPToDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPToDate.ValueChanged
        DGVExpensesReport.Rows.Clear()
    End Sub

    Private Sub AppendConditions()

        If ChkDate.Checked Then
            Dim DateTimeFrom As Date = DTPFromDate.Value.Date & " " & "00:00".ToString
            Dim DateTimeTo As Date = DTPToDate.Value.Date & " " & "23:59".ToString

            AppendToQuery(" And ", " ExpensesContentTable.Date BETWEEN '" & DateTimeFrom & "' AND '" & DateTimeTo & "' ")
        End If

        If ChkReciptName.Checked And TxtReciptNameReport.Text <> "" Then AppendToQuery(" AND ", " ReceiptName Like @ReceiptName")  '%" & TxtReciptNameReport.Text & "%'
        If ChkMonth.Checked Then AppendToQuery(" AND ", "  Month = @Month  And Year= @Year") ' & Val(CmbMonthReport.Text) & & Val(CmbYearReport.Text)
        If ChkUserReport.Checked And CmbUserReport.Text <> "" And CmbUserReport.SelectedValue <> 0 Then AppendToQuery(" AND ", " UserID = " & CmbUserReport.SelectedValue & " ")

    End Sub

    Private Sub AppendToQuery(Oprtr As String, Query As String)

        'Check if last word in the query is "WHERE " with the space at the end
        ' If True and you want to add a condition no need to append " AND " or any operator
        ' But if was False this means this's not the first condition you add so you must add an operator too

        Dim TestString As String = StrReverse(SQLQuery)
        If StrReverse(TestString.Substring(0, 6).ToUpper) = "WHERE " Then
            SQLQuery &= Query
        Else
            SQLQuery &= Oprtr & " " & Query

        End If

    End Sub

    Private Sub DGVExpensesReport_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVExpensesReport.CellFormatting
        If DGVExpensesReport.Rows(e.RowIndex).Cells(3).Value.ToString <> Nothing Then
            If e.CellStyle.Format = "d" Then
                e.CellStyle.Format = GetDateAndTimeFormat(DTFormat.DF)
            End If
        End If
    End Sub

    Private Sub CmbUserReport_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbUserReport.SelectionChangeCommitted
        EmployeeID = CmbUserReport.SelectedValue
    End Sub

    Private Sub CmbYearReport_TextChanged(sender As Object, e As EventArgs) Handles CmbYearReport.TextChanged
        DGVExpensesReport.Rows.Clear()
    End Sub

    Private Sub CmbMonthReport_TextChanged(sender As Object, e As EventArgs) Handles CmbMonthReport.TextChanged
        sender.backColor = SystemColors.Window
        DGVExpensesReport.Rows.Clear()
    End Sub

    Private Sub TxtCurrentPage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCurrentPage.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        End If
    End Sub

    Private Sub CmbTypeExpenses_TextChanged(sender As Object, e As EventArgs)
        sender.backColor = SystemColors.Window
        DGVExpensesReport.Rows.Clear()

    End Sub
End Class