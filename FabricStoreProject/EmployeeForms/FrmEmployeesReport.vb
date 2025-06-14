Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmEmployeesReport
    Private PageSize, PagesCount, RowsCount As Integer
    Private PageNum As Integer = 1
    Private DSLoadSearch As DataSet
    '------------------FrmEmployeeBaicData-----------------------
    Private DSDisplay As DataSet
    Private CR As Integer

    Private EmpID As Integer
    Private FromSearch, FromLoad As Boolean ' البجنيشن مايجيبش صورة في حالة ما بحثش



    Private Sub FrmEmployeesReport_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub FrmEmployeesReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            DGVEmpReport.Rows.Clear()
            NUDPageSize.Value = My.Settings.PageSize
            ChkAll.Checked = True
            BtnSearch_Click(sender, e)

        Else

            If Not IsNothing(DSLoadSearch) Then
                DSLoadSearch.Clear()
            End If

            If Not IsNothing(DSDisplay) Then
                DSDisplay.Clear()
            End If

        End If

    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub ChkAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAll.CheckedChanged

        DGVEmpReport.Rows.Clear()
        If ChkAll.Checked = True Then
            ChkEmpNameReport.Checked = False : TxtNameReport.Text = ""
            ChkAddress.Checked = False : TxtAddress.Text = ""
            ChkPhone.Checked = False : TxtPhoneReport.Text = ""

            BtnSearch_Click(sender, e)

        Else
            TxtPagesCount.Text = 1
            TxtCurrentPage.Text = 1
            FromSearch = False
        End If

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If Not ChkAll.Checked And Not ChkEmpNameReport.Checked And Not ChkAddress.Checked And Not ChkPhone.Checked Then
            Exit Sub
        End If

        IsDataMissing = False
        IsInputEmpty(TableLayoutPanel1)

        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        PageNum = 1
        Search()
        FromSearch = True
    End Sub

    Private Sub Search()

        ProgressBar1.Value = 0
        TxtCurrentPage.Text = PageNum
        PageSize = My.Settings.PageSize

        SQLQuery = "   Select ROW_NUMBER() OVER (ORDER BY (ID)) As ت, * From EmployeeTable where  EndService IS NULL  "

        AppendConditions()

        SQLQuery &= " ORDER BY ID  OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"

        SQLQuery &= " Select COUNT(EmployeeTable.ID)  From  EmployeeTable where  EndService IS NULL "
        AppendConditions()


        Dim Sqlcon As New SQLConClass()
        DSLoadSearch = Sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DSLoadSearch) Then
            If DSLoadSearch.Tables(1).Rows(0).Item(0) > 0 Then
                RowsCount = DSLoadSearch.Tables(1).Rows(0).Item(0)
            End If

            GetPagesCount()
            FillDGV()

        End If
    End Sub

    Private Sub FillDGV()
        DGVEmpReport.Rows.Clear()

        If DSLoadSearch.Tables(0).Rows.Count = 0 Then
            MsgTool("لا توجد نتائج لهذا البحث", 0)
            Exit Sub
        End If

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = DSLoadSearch.Tables(0).Rows.Count

        For i = 0 To DSLoadSearch.Tables(0).Rows.Count - 1

            With DSLoadSearch.Tables(0).Rows(i)
                DGVEmpReport.Rows.Add()
                DGVEmpReport.Item(0, i).Value = .Item("ID")
                DGVEmpReport.Item(1, i).Value = .Item("ت")
                DGVEmpReport.Item(2, i).Value = .Item("Name")
                DGVEmpReport.Item(4, i).Value = .Item("Address")

                If Not .Item("Phone1") = "" Then
                    DGVEmpReport.Item(3, i).Value = .Item("Phone1")
                End If

                If Not .Item("Phone2") = "" Then
                    If DGVEmpReport.Item(3, i).Value = "" Then
                        DGVEmpReport.Item(3, i).Value = .Item("Phone2")
                    Else
                        DGVEmpReport.Item(3, i).Value = DGVEmpReport.Item(3, i).Value & " - " & .Item("Phone2")
                    End If

                End If

            End With
            ProgressBar1.Value += 1
        Next
        DGVEmpReport.ClearSelection()
    End Sub

    Private Sub FillDGVReport(D As DataSet)
        DGVEmpReport.Rows.Clear()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = D.Tables(0).Rows.Count

        For i = 0 To D.Tables(0).Rows.Count - 1

            With D.Tables(0).Rows(i)
                DGVEmpReport.Rows.Add()
                DGVEmpReport.Item(0, i).Value = .Item("ID")
                DGVEmpReport.Item(1, i).Value = .Item("ت")
                DGVEmpReport.Item(2, i).Value = .Item("Name")
                DGVEmpReport.Item(4, i).Value = .Item("Address")

                If Not .Item("Phone1") = "" Then
                    DGVEmpReport.Item(3, i).Value = .Item("Phone1")
                End If

                If Not .Item("Phone2") = "" Then
                    If DGVEmpReport.Item(3, i).Value = "" Then
                        DGVEmpReport.Item(3, i).Value = .Item("Phone2")
                    Else
                        DGVEmpReport.Item(3, i).Value = DGVEmpReport.Item(3, i).Value & " - " & .Item("Phone2")
                    End If

                End If

            End With
            ProgressBar1.Value += 1
        Next
        DGVEmpReport.ClearSelection()
    End Sub

    Private Sub AppendConditions()

        If ChkEmpNameReport.Checked And TxtNameReport.Text <> "" Then
            AppendToQuery(" AND ", " Name   Like  '%" & TxtNameReport.Text & "%'")

        End If

        If ChkPhone.Checked And TxtPhoneReport.Text.Trim <> "" Then
            AppendToQuery(" And ", " Phone1   Like  '%" & Val(TxtPhoneReport.Text) & "%' or  Phone2 Like '%" & Val(TxtPhoneReport.Text) & "%'")

        End If
        If ChkAddress.Checked Then
            AppendToQuery(" And ", " Address Like '%" & TxtAddress.Text & "%'")

        End If

    End Sub

    Private Sub AppendToQuery(Oprtr As String, Query As String)

        ' Check if last word in the query is "WHERE " with the space at the end
        ' If True and you want to add a condition no need to append " AND " or any operator
        ' But if was False this means this's not the first condition you add so you must add an operator too

        Dim TestString As String = StrReverse(SQLQuery)
        If StrReverse(TestString.Substring(0, 6).ToUpper) = " WHERE " Then
            SQLQuery &= Query
        Else
            SQLQuery &= Oprtr & " " & Query
        End If

    End Sub

    Private Sub BtnRefreshReport_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        TxtCurrentPage.Text = 1
        ChangeControlColor(Me)
        TxtPagesCount.Text = 1
        DGVEmpReport.ClearSelection()
        DGVEmpReport.Rows.Clear()
        Clear(GrpReport)
        ProgressBar1.Value = 0
        TxtCurrentPage.Text = "1"
        TxtPagesCount.Text = "1"
        PageNum = 1
        FromSearch = False
        EmployeReportID = 0
        ChkAll.Checked = True
        BtnSearch.PerformClick()
        ChangeControlColor(GrpReport)
    End Sub
    '------------------------------------CheckBox-----------------------------------------------------
    Private Sub ChkEmpName_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEmpNameReport.CheckedChanged

        DGVEmpReport.Rows.Clear()
        If ChkEmpNameReport.Checked = True Then
            TxtNameReport.Enabled = True
            TxtNameReport.Focus()
            ChkAll.Checked = False

        Else
            TxtNameReport.BackColor = SystemColors.Window
            TxtNameReport.Text = ""
            TxtNameReport.Enabled = False
            TxtCurrentPage.Text = 1
            TxtPagesCount.Text = 1
            FromSearch = False
        End If

    End Sub

    Private Sub ChkAddress_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAddress.CheckedChanged
        DGVEmpReport.Rows.Clear()
        If ChkAddress.Checked = True Then
            TxtAddress.Enabled = True
            TxtAddress.Focus()
            ChkAll.Checked = False

        Else
            TxtAddress.BackColor = SystemColors.Window
            TxtAddress.Text = ""
            TxtAddress.Enabled = False
            TxtCurrentPage.Text = 1
            TxtPagesCount.Text = 1
            FromSearch = False
        End If

    End Sub

    Private Sub ChkPhone_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPhone.CheckedChanged
        DGVEmpReport.Rows.Clear()

        If ChkPhone.Checked = True Then
            ChkAll.Checked = False
            TxtPhoneReport.Enabled = True
            TxtPhoneReport.Focus()

        Else
            TxtPhoneReport.BackColor = SystemColors.Window
            TxtCurrentPage.Text = 1
            TxtPagesCount.Text = 1
            FromSearch = False
            TxtPhoneReport.Text = ""
            TxtPhoneReport.Enabled = False
        End If

    End Sub



    '****************************************************************************
    '------------------Pagination-------------------------------------------
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
        If FromSearch = False Then Exit Sub

        CheckPageSize()
        If PageNum < PagesCount Then
            PageNum += 1

        End If
        Search()
    End Sub

    Private Sub BtnPreviousPage_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage.Click
        If FromSearch = False Then Exit Sub
        CheckPageSize()

        If PageNum > 1 Then
            PageNum -= 1

        Else
            PageNum = 1
        End If
        Search()
    End Sub

    Private Sub BtnFirstPage_Click(sender As Object, e As EventArgs) Handles BtnFirstPage.Click
        If FromSearch = False Then Exit Sub

        PageNum = 1
        Search()
    End Sub

    Private Sub BtnLastPage_Click(sender As Object, e As EventArgs) Handles BtnLastPage.Click
        If FromSearch = False Then Exit Sub

        CheckPageSize()
        PageNum = PagesCount
        Search()
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

            Search()
        End If

    End Sub

    Private Sub CheckPageSize()
        Dim SPageSize As Integer = My.Settings.PageSize

        If PageSize <> SPageSize Then
            PageNum = 1
            Search()
        End If

    End Sub

    Private Sub NumericUpDown1_TextChanged(sender As Object, e As EventArgs) Handles NUDPageSize.TextChanged
        If NUDPageSize.Value = 0 Then
            NUDPageSize.Value = 1
        Else
            NUDPageSize_ValueChanged(sender, e)
        End If
    End Sub

    Private Sub AppendReportConditions()

        If ChkEmpNameReport.Checked And TxtNameReport.Text.Trim <> "" Then AppendToQuery(" AND ", " Name Like @Name")
        If ChkAddress.Checked And TxtAddress.Text.Trim <> "" Then AppendToQuery(" AND ", " Address=@Address")
        If ChkPhone.Checked And TxtPhoneReport.Text.Trim <> "" Then AppendToQuery(" AND ", " ( Phone1 Like @Phone or Phone2 Like Phone)")

    End Sub

    Private Sub TxtNameReport_TextChanged(sender As Object, e As EventArgs) Handles TxtNameReport.TextChanged
        sender.BackColor = SystemColors.Window
        DGVEmpReport.Rows.Clear()
    End Sub

    Private Sub TxtAddress_TextChanged(sender As Object, e As EventArgs) Handles TxtAddress.TextChanged
        sender.BackColor = SystemColors.Window
        DGVEmpReport.Rows.Clear()
    End Sub

    Private Sub TxtPhoneReport_TextChanged(sender As Object, e As EventArgs) Handles TxtPhoneReport.TextChanged
        sender.BackColor = SystemColors.Window
        DGVEmpReport.Rows.Clear()
    End Sub

    Private Sub NUDPageSize_ValueChanged(sender As Object, e As EventArgs) Handles NUDPageSize.ValueChanged
        If NUDPageSize.Value <> 0 And My.Settings.PageSize <> NUDPageSize.Value Then
            My.Settings.PageSize = NUDPageSize.Value
            My.Settings.Save()
        End If

        DGVEmpReport.Rows.Clear()
    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click
        If Not ChkAll.Checked And Not ChkEmpNameReport.Checked And Not ChkAddress.Checked And Not ChkPhone.Checked Then Exit Sub

        TxtCurrentPage.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

    Private Sub BtnPrintAll_Click(sender As Object, e As EventArgs) Handles BtnPrintAll.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=35")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If DGVEmpReport.Rows.Count = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "SELECT Name,Phone1,Phone2,Address FROM EmployeeTable WHERE EndService IS NULL"
        AppendReportConditions()
        SQLQuery &= " ORDER BY ID ASC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        Dim Param() As SqlParameter =
            {
            New SqlParameter("@Name", "%" & TxtNameReport.Text.Trim & "%"),
            New SqlParameter("@Address", TxtAddress.Text),
            New SqlParameter("@Phone", "%" & TxtPhoneReport.Text & "%")}

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

        Dim F As New FrmPrint
        Dim C As New CREmployeeList

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

    Private Sub DGVEmpReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEmpReport.CellContentClick
        If CheckDGVError(DGVEmpReport) = True Then Exit Sub
    End Sub

    Private Sub DGVEmpReport_Click(sender As Object, e As EventArgs) Handles DGVEmpReport.Click
        If CheckDGVError(DGVEmpReport) = True Then Exit Sub
    End Sub

    Private Sub DGVEmpReport_DoubleClick(sender As Object, e As EventArgs) Handles DGVEmpReport.DoubleClick
        If CheckDGVError(DGVEmpReport) Then Exit Sub
        Dim CR As Integer
        CR = DGVEmpReport.CurrentRow.Index
        EmployeReportID = DGVEmpReport.Item(0, CR).Value
        FrmEmployeeContainr.LblInfo_Click(sender, e)
    End Sub

    Private Sub CmbPhoneReport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPagesCount.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPhoneReport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhoneReport.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtEmpNumReport_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtCurrentPage_Click(sender As Object, e As EventArgs) Handles TxtCurrentPage.Click
        TxtCurrentPage.SelectAll()
    End Sub

    Private Sub TxtCurrentPage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCurrentPage.KeyPress

        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        End If

    End Sub

End Class