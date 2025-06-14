Imports System.Data.SqlClient

Public Class FrmMainSafeReport
    Private PageSize, PagesCount, RowsCount As Integer
    Private PageNum As Integer = 1
    Private DSMain, DSSearch As New DataSet

    Private SearchActive As Boolean ' باش نعرف امتى نسمح للبطم متع البيجينشن امتى يخدموا وامتى لا مرات تجي ترصهم ويجيبو سيليكت وانت مكنت تبحث اصلا

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub
    Private Enum Data
        Search
        Main
    End Enum

    Private Sub FrmMainSafeReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Me.Visible Then
            ' PageNum = 1
            For i = Now.Date.Year To Now.Date.Year - 10 Step -1
                CmbYear.Items.Add(i)
            Next
            ChkDay.Checked = True
            CmbDay.Text = Now.Day
            CmbMonth.Text = Now.Month
            CmbYear.Text = Now.Year
            GetData(Data.Main)
            BtnSearch.PerformClick()
        Else
            ChkUserReport.Checked = False
            CmbUser.Text = ""
            DGVMainSafe.Rows.Clear()
            If Not IsNothing(DSMain) Then
                DSMain.Clear()
            End If
            If Not IsNothing(DSSearch) Then
                DSSearch.Clear()
            End If

        End If


    End Sub

    Private Sub GetData(Type As Data)
        Dim SQLCon = New SQLConClass()

        Select Case Type
            Case Data.Main
                TxtSumValue.Text = "0"

                SQLQuery = " Select   ID , Name From UserTable where EndService IS NULL ORDER BY Name"

                DSMain = SQLCon.SelectData(SQLQuery)

                FillData(Type, DSMain, 1)

            Case Data.Search

                SQLQuery = " select  ROW_NUMBER() OVER (ORDER BY (Select ID)) As ت, *   from TrusryView   where 1=1    "
                If ChkUserReport.Checked = True Then
                    If Not IsNothing(CmbUser.SelectedValue) Then
                        SQLQuery &= " and UserID =" & CmbUser.SelectedValue
                    Else
                        MsgTool("يرجى اختيار الموظف", 0)
                        CmbUser.BackColor = RedColor
                        CmbUser.Focus()
                        Exit Select
                    End If
                End If
                SQLQuery &= " and Month(Date1)= " & CmbMonth.Text
                SQLQuery &= " and Year(Date1)= " & CmbYear.Text

                If ChkDay.Checked = True Then
                    SQLQuery &= " and day(Date1)= " & CmbDay.Text
                End If


                SQLQuery &= " SELECT ISNULL(SUM(Paid),0) FROM TrusryView where 1=1  "
                If ChkUserReport.Checked = True Then
                    If Not IsNothing(CmbUser.SelectedValue) Then
                        SQLQuery &= " and UserID =" & CmbUser.SelectedValue
                    Else
                        MsgTool("يرجى اختيار الموظف", 0)
                        CmbUser.BackColor = RedColor
                        CmbUser.Focus()
                        Exit Select
                    End If
                End If
                SQLQuery &= " and Month(Date1)= " & CmbMonth.Text
                SQLQuery &= " and Year(Date1)= " & CmbYear.Text

                If ChkDay.Checked = True Then
                    SQLQuery &= " and day(Date1)= " & CmbDay.Text
                End If

                DSSearch = SQLCon.SelectData(SQLQuery, 0, Nothing)
                FillData(Type, DSSearch, 3)

        End Select
    End Sub

    Private Sub FillData(Type As Data, DS As DataSet, TCount As Integer)

        If Not DSHasTables(DS) Then Exit Sub

        Select Case Type
            Case Data.Main
                CmbUser.DataSource = DSMain.Tables(0)
                CmbUser.ValueMember = "ID"
                CmbUser.DisplayMember = "Name"
                CmbUser.SelectedIndex = -1

            Case Data.Search

                If DS.Tables(1).Rows.Count > 0 Then
                    TxtSumValue.Text = DS.Tables(1).Rows(0).Item(0)
                End If

                FillDGV(DS.Tables(0))

                DGVMainSafe.ClearSelection()
                If DS.Tables(0).Rows.Count = 0 Then MsgTool("لا توجد نتائج للبحث", 0)

        End Select

    End Sub

    Private Sub FillDGV(T As DataTable)
        DGVMainSafe.Rows.Clear()

        For i = 0 To T.Rows.Count - 1
            With T.Rows(i)

                DGVMainSafe.Rows.Add()
                DGVMainSafe.Item(0, i).Value = .Item("ID")
                DGVMainSafe.Item(1, i).Value = .Item("ت") ' i + 1
                DGVMainSafe.Item(2, i).Value = Format(.Item("Date1"), GetDateAndTimeFormat(DTFormat.DTF))
                DGVMainSafe.Item(3, i).Value = .Item("Name")
                DGVMainSafe.Item(4, i).Value = .Item("Value")
                DGVMainSafe.Item(5, i).Value = .Item("CardValue")
                DGVMainSafe.Item(6, i).Value = .Item("Expenses")
                DGVMainSafe.Item(7, i).Value = .Item("Paid")
                DGVMainSafe.Item(8, i).Value = .Item("UserID")

            End With
        Next
        DGVMainSafe.ClearSelection()
    End Sub


    Private Sub ChkDay_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDay.CheckedChanged
        DGVMainSafe.Rows.Clear()
        TxtSumValue.Text = 0

        If ChkDay.Checked = True Then
            CmbDay.Enabled = True
            CmbDay.Text = Now.Day
        Else
            CmbDay.Text = ""
            CmbDay.Enabled = False
            SearchActive = False
        End If
    End Sub

    Private Sub ChkUserReport_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUserReport.CheckedChanged
        DGVMainSafe.Rows.Clear()
        TxtSumValue.Text = 0

        If ChkUserReport.Checked = True Then
            CmbUser.Enabled = True
        Else
            CmbUser.BackColor = SystemColors.Window
            CmbUser.Enabled = False
            CmbUser.Text = ""
            CmbUser.SelectedIndex = -1
            SearchActive = False
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        SearchActive = False
        ChkDay.Checked = True
        ChkDay_CheckedChanged(sender, e)
        ChkUserReport.Checked = False
        DGVMainSafe.Rows.Clear()

        CmbUser.Text = ""
        CmbUser.SelectedIndex = -1
        CmbUser.Enabled = False
        ' DGVMainSafe.ClearSelection()
        TxtSumValue.Text = "0"
        GetData(Data.Search)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        'TxtPageNum.Text = 1
        If ChkUserReport.Checked = True And IsNothing(CmbUser.SelectedValue) Then
            CmbUser.BackColor = RedColor
            MsgTool("يرجى التأكد من حميع البيانات", 0)
            Exit Sub
        End If

        PageNum = 1
        GetData(Data.Search)
        SearchActive = True
    End Sub

    Private Sub TxtSumValue_TextChanged(sender As Object, e As EventArgs)
        If Val(TxtSumValue.Text) > 0 Then
            TxtSumValue.Text = Format(Val(TxtSumValue.Text), "0.00")

        Else
            TxtSumValue.Text = 0
        End If

    End Sub

    Private Sub CheckPageSize()

        If PageSize <> My.Settings.PageSize Then
            PageNum = 1
            GetData(Data.Search) 'عند تغيير حجم الصفحة يجب معرفة عدد الصفحات الجديد PagesCount
        End If

    End Sub

    Private Sub CmbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUser.SelectedIndexChanged
        DGVMainSafe.Rows.Clear()
        TxtSumValue.Text = 0
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub


    Private Sub BtnPrint_Click(sender As Object, e As EventArgs)
        If DGVMainSafe.Rows.Count = 0 Then Exit Sub

        'Dim DT As New DataTable
        'DT.Columns.AddRange(New DataColumn(8) {New DataColumn("Date", GetType(DateTime)), New DataColumn("Employee", GetType(String)), New DataColumn("ValueCash", GetType(Double)), New DataColumn("ValuePayment", GetType(Double)), New DataColumn("DoctorsExpenses", GetType(Double)), New DataColumn("ClinicExpenses", GetType(Double)), New DataColumn("Minus", GetType(Double)), New DataColumn("Plus", GetType(Double)), New DataColumn("Recieved", GetType(Double))})


        'For i = 0 To DGVMainSafe.Rows.Count - 1
        '    DT.Rows.Add(DGVMainSafe.Item(2, i).Value, DGVMainSafe.Item(3, i).Value, DGVMainSafe.Item(4, i).Value, DGVMainSafe.Item(5, i).Value, DGVMainSafe.Item(6, i).Value, DGVMainSafe.Item(7, i).Value, DGVMainSafe.Item(8, i).Value, DGVMainSafe.Item(9, i).Value, DGVMainSafe.Item(10, i).Value)
        'Next

        'Dim SQLCon = New SQLConClass
        'Dim Param() As SqlParameter = {
        '    New SqlParameter("@SafeReport", DT)
        '    }
        'SQLCon.CMDExecute("PrintSafeReport", 1, Param)

        'Dim DSReport As New DataSet
        'SQLQuery = "SELECT FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Employee,ValueCash,ValuePayment,DoctorsExpenses,ClinicExpenses,Minus,Plus,Recieved FROM PrintSafeReportTable "
        'SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        'DSReport = SQLCon.SelectData(SQLQuery, 0, Nothing)

        'Dim F As New FrmPrint
        'Dim C As New CRSafe

        'C.SetDataSource(DSReport.Tables(0))
        'C.Subreports(0).SetDataSource(DSReport.Tables(1))
        'C.Subreports(1).SetDataSource(DSReport.Tables(1))
        'F.CrystalReportViewer1.ReportSource = C
        'F.CrystalReportViewer1.Refresh()
        'F.Text = "طباعة"
        'F.CrystalReportViewer1.Zoom(100%)
        'F.WindowState = FormWindowState.Maximized
        'F.Show()


    End Sub



    Private Sub CmbDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDay.SelectedIndexChanged
        DGVMainSafe.Rows.Clear()
    End Sub

    Private Sub CmbUser_TextChanged(sender As Object, e As EventArgs) Handles CmbUser.TextChanged
        CmbUser.BackColor = SystemColors.Window
        DGVMainSafe.Rows.Clear()
        TxtSumValue.Text = 0
    End Sub

    Private Sub CmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMonth.SelectedIndexChanged
        DGVMainSafe.Rows.Clear()
    End Sub

    Private Sub TxtPageNum_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        End If
    End Sub

    Private Sub CmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbYear.SelectedIndexChanged
        DGVMainSafe.Rows.Clear()
    End Sub

    Private Sub DGVMainSafe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMainSafe.CellContentClick
        If DGVMainSafe.Rows.Count = 0 Then Exit Sub
        FrmTrusry.TrustyID = DGVMainSafe.Item(0, DGVMainSafe.CurrentRow.Index).Value
        Dim col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If col = "ColShow" Then
            FrmTrusry.ShowDialog()
            GetData(Data.Search)

        ElseIf col = "ColPrint" Then
            Dim SQLCon = New SQLConClass

            Dim DSReport As New DataSet
            SQLQuery = " SELECT *,Format(Date1,'yyyy-MM-dd HH:mm') as Date FROM TrusryView where ID=" & DGVMainSafe.Item(0, DGVMainSafe.CurrentRow.Index).Value

            DSReport = SQLCon.SelectData(SQLQuery, 0, Nothing)

            'Dim F As New FrmPrint
            'Dim C As New CrTrusry

            'C.SetDataSource(DSReport.Tables(0))
            'F.CrystalReportViewer1.ReportSource = C
            'F.CrystalReportViewer1.Refresh()
            'F.Text = "طباعة"
            'F.CrystalReportViewer1.Zoom(100%)
            'F.WindowState = FormWindowState.Maximized
            'F.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmTrusry.ShowDialog()
        BtnSearch.PerformClick()
    End Sub

    Private Sub CmbDay_TextChanged(sender As Object, e As EventArgs) Handles CmbDay.TextChanged
        DGVMainSafe.Rows.Clear()
    End Sub

    Private Sub CmbMonth_TextChanged(sender As Object, e As EventArgs) Handles CmbMonth.TextChanged
        DGVMainSafe.Rows.Clear()
    End Sub

    Private Sub CmbYear_TextChanged(sender As Object, e As EventArgs) Handles CmbYear.TextChanged
        DGVMainSafe.Rows.Clear()
    End Sub
End Class