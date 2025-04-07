Imports System.Data.SqlClient

Public Class FrmMangmentExpenses
    Private DsLoad, Dssave, DSSearch As DataSet
    'Private ExpensesID As Integer
    Private IsLoad As Boolean = True
    Private SearchActive, State As Boolean
    Private LastForm As String = "FrmMain"
    Public ID As Integer

    Private Sub FrmMangmentExpenses_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub FrmMangmentExpenses_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ' BtnRefresh_Click(sender, e)

        If Me.Visible Then
            DTPDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            BasicData()


            'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=1")

            'If Perm(0)(6) = False Then
            '    MsgTool("ليس لديك صلاحية العرض", 0)
            '    Exit Sub
            'End If

            GETFillData()

            If MangExpensesID <> 0 Then
                DisPlay(DsLoad)
            End If

            TxtAmount.Focus()
        Else
            BtnRefresh_Click(sender, e)
            DGVExpensesEmp.Rows.Clear()
            If Not IsNothing(DsLoad) Then
                DsLoad.Clear()
            End If
            If Not IsNothing(Dssave) Then
                Dssave.Clear()
            End If
            If Not IsNothing(DSSearch) Then
                DSSearch.Clear()
            End If
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub BasicData()
        DTPDate.MinDate = Now.Year & "-" & Now.Month & "-" & "1"
        DTPDate.MaxDate = Now.Year & "-" & Now.Month & "-" & Now.Day
        Dim Settings = New ClassSettings
        TxtMonth.Text = Now.Date.Month
        TxtYear.Text = Now.Date.Year
        TxtDay.Text = Now.Day
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Clear(GroupBox1)

        ChangeControlColor(Me)
        Label1.BackColor = Color.White

        MangExpensesID = 0 : State = False
        TxtAmount.Text = ""
        DGVExpensesEmp.ClearSelection()
        TxtYear.Text = Now.Date.Year
        TxtMonth.Text = Now.Date.Month
        DTPDate.Value = Now.Date
        GETFillData()

        TxtAmount.BackColor = SystemColors.Window
        TxtReceiver.BackColor = SystemColors.Window
        CmbExpensesType.BackColor = SystemColors.Window
        TxtReceiver.Text = ""
        TxtAmount.Focus()
    End Sub

    Private Sub GETFillData() 'ادا كانت tru معناها جيب بيانات اللود 

        Dim Settings = New ClassSettings
        LoadData()
        With DsLoad
            TxtSumValue.Text = "0"
            If Not IsDBNull(.Tables(5).Rows(0).Item(0)) Then
                TxtSumValue.Text = Format(.Tables(5).Rows(0).Item(0), "0.000")
            Else
                TxtSumValue.Text = "0"
            End If
        End With
        If DSHasTables(DsLoad) Then
            FillDGV(DsLoad)
        End If
    End Sub

    Private Sub FillCmb(D As DataSet)

        CmbExpensesType.DataSource = D.Tables(1)
        CmbExpensesType.DisplayMember = "Name"
        CmbExpensesType.ValueMember = "ID"
        CmbExpensesType.SelectedIndex = -1

        'TxtUserName.Text = D.Tables(2).Rows(0).Item(1)
        'TxtUserName.Enabled = False
        TxtUserName.Text = UserName
    End Sub

    Private Sub FillDGV(D As DataSet)
        DGVExpensesEmp.Rows.Clear()
        For i = 0 To D.Tables(0).Rows.Count - 1
            With D.Tables(0).Rows(i)
                DGVExpensesEmp.Rows.Add()
                DGVExpensesEmp.Item(0, i).Value = .Item(0) 'ID
                DGVExpensesEmp.Item(1, i).Value = i + 1 'ت
                DGVExpensesEmp.Item(2, i).Value = .Item("Date") 'Date
                DGVExpensesEmp.Item(3, i).Value = .Item("ReceiptName") 'ReceiptName
                DGVExpensesEmp.Item(4, i).Value = .Item("Name") 'Nots
                DGVExpensesEmp.Item(5, i).Value = .Item("Value") 'Value
                DGVExpensesEmp.Item(6, i).Value = .Item("Year") + " - " + .Item("Month") ' year-month
                DGVExpensesEmp.Item(7, i).Value = .Item("State") 'حالة الصرف
            End With
            DGVExpensesEmp.ClearSelection()
        Next
    End Sub

    Private Sub LoadData()
        Dim DateTimeFrom As Date = DTPDate.Value.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTPDate.Value.Date & " " & "23:59".ToString

        Dim sqlCon As New SQLConClass()
        Dim param() As SqlParameter = {
          New SqlParameter("@Year", TxtYear.Text),
           New SqlParameter("@Month", TxtMonth.Text),
           New SqlParameter("@DateTo", DateTimeTo),
           New SqlParameter("@DateFrom", DateTimeFrom),
          New SqlParameter("@UserID", UserID)}
        DsLoad = sqlCon.SelectData("[GetExpensesContent]", 1, param)
        FillCmb(DsLoad)
    End Sub

    Private Sub DisPlay(D As DataSet)
        If MangExpensesID = 0 Then Exit Sub
        Dim ItemRows() As DataRow = D.Tables(0).Select("ID=" & MangExpensesID)
        If ItemRows.Length > 0 Then
            '  DTPDate.Value = ItemRows(0)(6)
            TxtReceiver.Text = ItemRows(0)(3)
            TxtAmount.Text = Format(ItemRows(0)(5), "0.000")
            CmbExpensesType.SelectedValue = ItemRows(0)(7)
            TxtYear.Text = ItemRows(0)(1)
            TxtMonth.Text = ItemRows(0)(2)
            State = ItemRows(0)(8)
        Else
            MsgTool("لايمكن تعديل مصروفات الأشهر الماضية", 0)
        End If
    End Sub

    Public Sub DisPlayFromReport(DFrom As Date, DTo As Date, Y As Integer, M As Integer, U As Integer)
        Dim sqlCon As New SQLConClass()
        Dim DateTimeFrom As Date = DFrom.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTo.Date & " " & "23:59".ToString
        Dim param() As SqlParameter = {
          New SqlParameter("@Year", Y),
           New SqlParameter("@Month", M),
           New SqlParameter("@DateTo", DateTimeTo),
           New SqlParameter("@DateFrom", DateTimeFrom),
          New SqlParameter("@UserID", U)}
        DSSearch = sqlCon.SelectData("[GetExpensesContent]", 1, param)

        For i = 1 To DSSearch.Tables(0).Rows.Count - 1
            If ID = DSSearch.Tables(0).Rows(i).Item(0) Then
                DTPDate.Value = DSSearch.Tables(0).Rows(i).Item(6)
                TxtReceiver.Text = DSSearch.Tables(0).Rows(i).Item(3)
                TxtAmount.Text = DSSearch.Tables(0).Rows(i).Item(5)
                CmbExpensesType.SelectedValue = DSSearch.Tables(0).Rows(i).Item(7)
                TxtYear.Text = DSSearch.Tables(0).Rows(i).Item(1)
                TxtMonth.Text = DSSearch.Tables(0).Rows(i).Item(2)
                State = DSSearch.Tables(0).Rows(i).Item(8)

            End If
        Next

        For i = 1 To DSSearch.Tables(0).Rows.Count - 1
            If ID = DSSearch.Tables(0).Rows(i).Item(0) Then
                DTPDate.Value = DSSearch.Tables(0).Rows(i).Item(6)
                TxtReceiver.Text = DSSearch.Tables(0).Rows(i).Item(3)
                TxtAmount.Text = DSSearch.Tables(0).Rows(i).Item(5)
                CmbExpensesType.SelectedValue = DSSearch.Tables(0).Rows(i).Item(7)
                TxtYear.Text = DSSearch.Tables(0).Rows(i).Item(1)
                TxtMonth.Text = DSSearch.Tables(0).Rows(i).Item(2)
                State = DSSearch.Tables(0).Rows(i).Item(8)

                DGVExpensesEmp.Rows(i).Selected = True
                DGVExpensesEmp.FirstDisplayedScrollingRowIndex = i

            End If
        Next
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If DTPDate.Value <> Now.Date Then
            MsgTool("لا يمكن حفظ أو تعديل مصروف قديم", 0)
            Exit Sub
        End If

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=1")

        'If Perm(0)(3) = False And ID = 0 Then
        '    MsgTool("ليس لديك صلاحية الإضافة", 0)
        '    Exit Sub
        'ElseIf Perm(0)(4) = False And ID <> 0 Then
        '    MsgTool("ليس لديك صلاحية التعديل", 0)
        '    Exit Sub
        'End If

        If State = True Then
            MsgTool("لم يتم التعديل ، لقد تم صرف المبلغ مسبقاً ", 0)
            Exit Sub 'في حالة حدف المصروف وهوا اساسا عاطينه ايصال صرف
        End If
        If TxtAmount.Text = "" Then
            Label1.BackColor = RedColor
        End If
        IsDataMissing = False
        IsInputEmpty(TableLayoutPanel3)

        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            If CmbExpensesType.Text = "" Then
                CmbExpensesType.BackColor = RedColor
            End If
            Exit Sub
        End If

        If Val(TxtAmount.Text) = 0 Or Val(TxtAmount.Text) < 0 Then
            TxtAmount.BackColor = RedColor
            Label1.BackColor = TxtAmount.BackColor
            MsgTool("يرجى التأكد من القيمة ", 0)
            TxtAmount.Focus()
            Exit Sub
        End If
        If CmbExpensesType.Text = "" Then
            MsgTool("يرجى التأكد من البيانات", 0)
            CmbExpensesType.BackColor = RedColor
            Exit Sub
        End If

        ' If TxtReceiver.BackColor <> SystemColors.Window Then TxtReceiver.BackColor = SystemColors.Window

        If CmbExpensesType.Text = "" Then
            CmbExpensesType.Focus()
            Exit Sub
        End If
        Dim ExpensesTypID As Integer
        ExpensesTypID = CmbExpensesType.SelectedValue
        If ExpensesTypID = Nothing Then
            ExpensesTypID = 0
        End If
        Dim DateTimeFrom As Date = DTPDate.Value.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTPDate.Value.Date & " " & "23:59".ToString

        Dim sqlCon As New SQLConClass()
        Dim param() As SqlParameter = {
           New SqlParameter("@ExpensesID", MangExpensesID),
           New SqlParameter("@Date", DTPDate.Value),
           New SqlParameter("@ExpensesTypeTxt", CmbExpensesType.Text.Trim),
           New SqlParameter("@Month", TxtMonth.Text),
           New SqlParameter("@Year", TxtYear.Text),
             New SqlParameter("@DateFrom", DateTimeFrom),
           New SqlParameter("@DateTo", DateTimeTo),
           New SqlParameter("@Amount", Val(TxtAmount.Text)),
           New SqlParameter("@ReciptName", TxtReceiver.Text.Trim),
           New SqlParameter("@ExpensesType", ExpensesTypID),
           New SqlParameter("@UserID", UserID)}

        DsLoad = sqlCon.CMDExecuteData("SaveExpenses", param)
        If DSHasTables(DsLoad) Then
            If Save = 2 Then
                MsgTool("لايمكن التعديل لقد تم صرف ايصال لمصروفات الشهر", 0)
            End If
            FillDGV(DsLoad)
            FillCmb(DsLoad)
            TxtSumValue.Text = "0"
            If Not IsDBNull(DsLoad.Tables(5).Rows(0).Item(0)) Then
                TxtSumValue.Text = Format(DsLoad.Tables(5).Rows(0).Item(0), "0.000")
            Else
                TxtSumValue.Text = "0"
            End If
            Clear(GroupBox1)
            TxtYear.Text = Now.Date.Year
            TxtMonth.Text = Now.Date.Month
            MangExpensesID = 0
            MangExpensesID = DsLoad.Tables(7).Rows(0).Item(0)
            DisPlay(DsLoad)
            MangExpensesID = 0
        End If
        BtnRefresh_Click(sender, e)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        If DTPDate.Value <> Now.Date Then
            MsgTool("لا يمكن حدف مصروف قديم", 0)
            Exit Sub
        End If
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=1")

        'If Perm(0)(5) = False Then
        '    MsgTool("ليس لديك صلاحية الحذف", 0)
        '    Exit Sub
        'End If


        'If State = True Then
        '    MsgTool("لم يتم الحذف ، لقد تم صرف المبلغ مسبقاً ", 0)
        '    Exit Sub 'في حالة حدف المصروف وهوا اساسا عاطينه ايصال صرف
        'End If

        If MangExpensesID = 0 Or MangExpensesID = Nothing Then Exit Sub
        If MsgBox("هل تريد بالتأكيد الحذف ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim DateTimeFrom As Date = DTPDate.Value.Date & " " & "00:00".ToString
            Dim DateTimeTo As Date = DTPDate.Value.Date & " " & "23:59".ToString

            Dim sqlCon As New SQLConClass()
            Dim param() As SqlParameter = {
              New SqlParameter("@ID", MangExpensesID),
              New SqlParameter("@Month", TxtMonth.Text),
              New SqlParameter("@Year", TxtYear.Text),
              New SqlParameter("@DateFrom", DateTimeFrom),
              New SqlParameter("@DateTo", DateTimeTo),
              New SqlParameter("@UserID", UserID)}

            DsLoad = sqlCon.CMDExecuteData("DeletExpenses", param)
            If DSHasTables(DsLoad) Then
                If Save = 1 Then
                    MsgTool("تم الحذف بنجاح", 1)
                End If
                If Save = 2 Then
                    MsgTool("لم يتم الحدف لقد تم اغلاق المناوبة أو المصروف", 0)
                End If
                BtnRefresh.PerformClick()
                If Not IsDBNull(DsLoad.Tables(5).Rows(0).Item(0)) Then
                    TxtSumValue.Text = Format(DsLoad.Tables(5).Rows(0).Item(0), "0.000")
                Else
                    TxtSumValue.Text = "0"
                End If

            End If
        End If

    End Sub

    Private Sub DGVExpensesEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVExpensesEmp.CellContentClick

    End Sub

    Private Sub DGVExpensesEmp_Click(sender As Object, e As EventArgs) Handles DGVExpensesEmp.Click

        If CheckDGVError(DGVExpensesEmp) = True Then Exit Sub
        Dim CR As Integer
        CR = DGVExpensesEmp.CurrentRow.Index
        MangExpensesID = DGVExpensesEmp.Item(0, CR).Value

        DisPlay(DsLoad)

    End Sub

    '---------------------------------احداث-----------------------------------------
    Private Sub Txt_TextChanged(sender As Object, e As EventArgs) Handles TxtReceiver.TabIndexChanged, CmbExpensesType.SelectedIndexChanged, CmbExpensesType.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount.TextChanged
        sender.BackColor = SystemColors.Window
        Label1.BackColor = Color.White

    End Sub

    Private Sub TxtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtRecipt_TextChanged(sender As Object, e As EventArgs) Handles TxtReceiver.TextChanged
        sender.BackColor = SystemColors.Window
        'If TxtReceiver.Text = "" Then LblNote.Visible = True Else LblNote.Visible = False

    End Sub

    Private Sub TxtRecipt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtReceiver.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=1")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        'If DGVExpensesEmp.Rows.Count = 0 Then Exit Sub

        'Dim DateTimeFrom As Date = DTPDate.Value.Date & " " & "00:00".ToString
        'Dim DateTimeTo As Date = DTPDate.Value.Date & " " & "23:59".ToString

        'Dim DSPrint = New DataSet
        'Dim sqlcon As New SQLConClass()
        'Dim Param() As SqlParameter = {
        '    New SqlParameter("@From", DateTimeFrom),
        '    New SqlParameter("@To", DateTimeTo)
        '    }

        'SQLQuery = "SELECT Expr1,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,ReceiptName,Name FROM ClinicExpensesReportView WHERE YEAR(CreatedDate)=" & TxtYear.Text & " AND MONTH(CreatedDate)=" & TxtMonth.Text & " AND DAY(CreatedDate)=" & TxtDay.Text
        'SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        'DSPrint = sqlcon.SelectData(SQLQuery, 0, Param)

        'Dim F As New FrmPrint
        'Dim C As New CRClinicExpensesReports

        'Dim Total As String = DSPrint.Tables(1).Rows(0).Item(0)

        'C.SetDataSource(DSPrint.Tables(0))
        'C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        'C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        'C.SetParameterValue("Title", "مصروفات العيادة بتاريخ   " & Format(DTPDate.Value.Date, GetDateAndTimeFormat(DTFormat.DF)))
        'F.CrystalReportViewer1.ReportSource = C
        'F.CrystalReportViewer1.Refresh()
        'F.Text = "طباعة"
        'F.CrystalReportViewer1.Zoom(100%)
        'F.WindowState = FormWindowState.Maximized
        'F.Show()
    End Sub

    Private Sub DTPDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPDate.ValueChanged
        GETFillData()
        If Not IsDBNull(DsLoad.Tables(5).Rows(0).Item(0)) Then
            TxtSumValue.Text = Format(DsLoad.Tables(5).Rows(0).Item(0), "0.000")
        Else
            TxtSumValue.Text = "0"
        End If
    End Sub

    Private Sub DGVExpensesEmp_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVExpensesEmp.CellFormatting
        If DGVExpensesEmp.Rows(e.RowIndex).Cells(2).Value.ToString <> Nothing Then
            If e.CellStyle.Format = "d" Then
                e.CellStyle.Format = GetDateAndTimeFormat(DTFormat.DF)
            End If
        End If
    End Sub
End Class