
Imports System.Data.SqlClient

Public Class FrmMangmentExpenses
    Private DsLoad, Dssave, DSSearch As DataSet

    Private IsLoad As Boolean = True
    Private SearchActive, State As Boolean
    Private LastForm As String = "FrmMain"
    Public ID As Integer
    Private CashingID, ExpensesID As Integer
    Private Sub FrmMangmentExpenses_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub FrmMangmentExpenses_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Me.Visible Then
            DTPDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            BasicData()
            GETFillData()

            If CashingID <> 0 Then
                DisPlay(DsLoad)
            End If

            TxtAmount.Focus()
        Else
            DGVExpenses.Rows.Clear()
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

    Private Sub GETFillData()
        Dim DateFrom As DateTime = DTPDate.Value.Date.AddHours(0).AddMinutes(0).AddSeconds(0)
        Dim DateTo As DateTime = DTPDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59)

        Dim sqlcon As New SQLConClass()
        Dim param() As SqlParameter = {
                    New SqlParameter("@DateFrom", DateFrom),
                    New SqlParameter("@DateTo", DateTo)
                }
        SQLQuery = " select * from PaymentTypeTable Order By ID  "
        SQLQuery += " select * from ExpensesView where  Date Between @DateFrom  and @DateTo Order by Date Desc "
        'SQLQuery += " select * from CashingFinanceTypeTable "
        SQLQuery += " select * from TrusryTypeTable  "

        DsLoad = sqlcon.SelectData(SQLQuery, 0, param)
        FillData()
    End Sub

    Private Sub FillData()
        CmbPaymentType.DataSource = DsLoad.Tables(0)
        CmbPaymentType.ValueMember = "ID"
        CmbPaymentType.DisplayMember = "Name"
        CmbPaymentType.SelectedValue = 1

        'CmbFinacic.DataSource = DsLoad.Tables(2)
        'CmbFinacic.ValueMember = "ID"
        'CmbFinacic.DisplayMember = "Name"
        'CmbFinacic.SelectedValue = 2

        CmbTrusry.DataSource = DsLoad.Tables(2)
        CmbTrusry.ValueMember = "ID"
        CmbTrusry.DisplayMember = "Name"
        CmbTrusry.SelectedIndex = 0

        LblMangment.Text = ""

        FillDGVMangemnt(DsLoad.Tables(1))
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub BasicData()
        DTPDate.MaxDate = Now.Year & "-" & Now.Month & "-" & Now.Day
        TxtMonth.Text = Now.Date.Month
        TxtYear.Text = Now.Date.Year
        TxtDay.Text = Now.Day
        TxtUserName.Text = UserName
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Clear(GroupBox1)

        ChangeControlColor(Me)
        Label1.BackColor = Color.White
        CashingID = 0
        DGVExpenses.ClearSelection()
        BasicData()
        GETFillData()
        TxtAmount.Focus()
    End Sub

    Private Sub FillCmb(D As DataSet)

        CmbPaymentType.DataSource = D.Tables(1)
        CmbPaymentType.DisplayMember = "Name"
        CmbPaymentType.ValueMember = "ID"
        CmbPaymentType.SelectedIndex = -1

        LblMangment.Text = ""

        FillDGVMangemnt(D.Tables(1))
    End Sub

    Private Sub FillDGVMangemnt(D As DataTable)
        DGVExpenses.Rows.Clear()
        For i = 0 To D.Rows.Count - 1
            With D.Rows(i)
                DGVExpenses.Rows.Add()
                DGVExpenses.Item(0, i).Value = .Item("CashingID") 'ID
                DGVExpenses.Item(1, i).Value = i + 1 'ت
                DGVExpenses.Item(2, i).Value = .Item("Value")
                If .Item("CashingFinanceTypeID") = 2 Then
                    LblMangment.Text = Val(LblMangment.Text) + .Item("Value")
                End If
                DGVExpenses.Item(3, i).Value = .Item("PaymentTypeName")
                DGVExpenses.Item(4, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.TF))
                DGVExpenses.Item(5, i).Value = .Item("Nots")
                DGVExpenses.Item(6, i).Value = .Item("FinanceType")
                DGVExpenses.Item(7, i).Value = .Item("PaymentTypeID")
                DGVExpenses.Item(8, i).Value = .Item("ID")
                DGVExpenses.Item(9, i).Value = .Item("Type")
                'DGVExpenses.Item(10, i).Value = .Item("CashingFinanceTypeID")
            End With
            DGVExpenses.ClearSelection()
        Next
    End Sub


    Private Sub LoadData()
        Dim DateTimeFrom As Date = DTPDate.Value.Date.ToShortDateString
        Dim DateTimeTo As Date = DTPDate.Value.Date.ToShortDateString

        Dim sqlCon As New SQLConClass()
        Dim param() As SqlParameter = {
           New SqlParameter("@DateTo", DateTimeTo),
           New SqlParameter("@DateFrom", DateTimeFrom)}
        DsLoad = sqlCon.SelectData("[GetExpensesContent]", 1, param)
        FillCmb(DsLoad)
    End Sub

    Private Sub DisPlay(D As DataSet)
        If CashingID = 0 Then Exit Sub
        Dim ItemRows() As DataRow = D.Tables(0).Select("ID=" & CashingID)
        If ItemRows.Length > 0 Then
            TxtNots.Text = ItemRows(0)("Nots")
            TxtAmount.Text = Format(ItemRows(0)("Value"), "0.00")
            CmbPaymentType.SelectedValue = ItemRows(0)("PaymentID")
            TxtYear.Text = ItemRows(0)("Year")
            TxtMonth.Text = ItemRows(0)("Month")
            CmbTrusry.SelectedValue = ItemRows(0)("Type")
        End If
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click


        If TxtAmount.Text = "" Then
            Label1.BackColor = RedColor
            Exit Sub
        End If
        IsDataMissing = False
        IsInputEmpty(TableLayoutPanel3)

        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            If CmbPaymentType.Text = "" Then
                CmbPaymentType.BackColor = RedColor
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
        If IsNothing(CmbPaymentType.SelectedValue) Then
            MsgTool("يرجى التأكد من البيانات", 0)
            CmbPaymentType.BackColor = RedColor
            Exit Sub
        End If

        If CmbPaymentType.Text = "" Then
            CmbPaymentType.Focus()
            Exit Sub
        End If
        Dim DateFrom As String = DTPDate.Value.Date.ToShortDateString + " 00:00 "
        Dim DateTo As String = DTPDate.Value.Date.ToShortDateString + " 23:59 "
        Dim sqlCon As New SQLConClass()
        Dim param() As SqlParameter = {
           New SqlParameter("@ID", CashingID),
           New SqlParameter("@DateFrom", DateFrom),
           New SqlParameter("@DateTo", DateTo),
           New SqlParameter("@PaymentTypeID", CmbPaymentType.SelectedValue),
           New SqlParameter("@FincicID", 5),
           New SqlParameter("@Value", Val(TxtAmount.Text)),
           New SqlParameter("@Nots", TxtNots.Text.Trim),
           New SqlParameter("@Type", CmbTrusry.SelectedValue),
           New SqlParameter("@UserID", UserID)}

        DsLoad = sqlCon.CMDExecuteData("SaveExpenses", param)
        If DSHasTables(DsLoad) Then
            Clear(GroupBox1)
            TxtYear.Text = Now.Date.Year
            TxtMonth.Text = Now.Date.Month
            CashingID = 0
        End If
        BtnRefresh_Click(sender, e)
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        If (CashingID = 0 Or CashingID = Nothing) And (ExpensesID = 0 Or ExpensesID = Nothing) Then Exit Sub
        If MsgBox("هل تريد بالتأكيد الحذف ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "تأكيد الحذف") = MsgBoxResult.Yes Then

            Dim sqlCon As New SQLConClass()
            Dim param() As SqlParameter = {
              New SqlParameter("@ID", CashingID),
              New SqlParameter("@ExpensesID", ExpensesID),
              New SqlParameter("@UserID", UserID)}

            Dim DsDelete As DataSet
            SQLQuery = " Update CashingTable Set EndService = GetDate() where ID=@ID"
            SQLQuery += " DELETE fROM ExpensesTable where ID=@ExpensesID "
            SQLQuery += " select * from ExpensesView where Date Between '" & DTPDate.Value.Date + " 00:00' " & " and '" & DTPDate.Value.Date + " 23:59' Order by Date Desc "
            DsDelete = sqlCon.SelectData(SQLQuery, 0, param)

            If DSHasTables(DsDelete) Then
                MsgTool("تم الحذف بنجاح", 1)
                BtnRefresh.PerformClick()
            End If
        End If

    End Sub

    Private Sub DGVExpensesEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVExpenses.CellContentClick

    End Sub

    Private Sub DGVExpensesEmp_Click(sender As Object, e As EventArgs) Handles DGVExpenses.Click
        If CheckDGVError(DGVExpenses) = True Then Exit Sub
        Dim CR As Integer
        CR = DGVExpenses.CurrentRow.Index
        CashingID = DGVExpenses.Item(0, CR).Value
        ExpensesID = DGVExpenses.Item(8, CR).Value
        TxtAmount.Text = DGVExpenses.Item(2, CR).Value
        TxtNots.Text = DGVExpenses.Item(5, CR).Value
        CmbPaymentType.SelectedValue = DGVExpenses.Item(7, CR).Value
        'CmbFinacic.SelectedValue = DGVExpenses.Item(10, CR).Value
        CmbTrusry.SelectedValue = DGVExpenses.Item(9, CR).Value

    End Sub

    '---------------------------------احداث-----------------------------------------
    Private Sub Txt_TextChanged(sender As Object, e As EventArgs) Handles TxtNots.TabIndexChanged, CmbPaymentType.SelectedIndexChanged, CmbPaymentType.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
        Label1.BackColor = Color.White

    End Sub

    Private Sub TxtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)

    End Sub

    Private Sub P1_Paint(sender As Object, e As PaintEventArgs) Handles P1.Paint

    End Sub

    Private Sub TxtNots_TextChanged(sender As Object, e As EventArgs) Handles TxtNots.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
        'If TxtReceiver.Text = "" Then LblNote.Visible = True Else LblNote.Visible = False

    End Sub


    Private Sub BtnPrint_Click(sender As Object, e As EventArgs)

        'Dim  As DataRow = DTUserPermission.Select("OperationID=1")

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

    Private Sub LblNote_Click(sender As Object, e As EventArgs)
        TxtNots.Select()
    End Sub

    Private Sub DTPDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPDate.ValueChanged
        TxtAmount.Text = "" : TxtNots.Text = "" : CmbPaymentType.SelectedIndex = -1
        GETFillData()
    End Sub



End Class