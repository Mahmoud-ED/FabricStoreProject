

Imports System.Data.SqlClient

Public Class FrmEmployeeReceipt
    Private DS, DsSave, DsSearch As DataSet
    Public ReceiptID As Integer
    Private TreasuryValue As Double
    Private BasicValue, ReceiptValue As Double
    Private Show As Boolean


    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmEmployeeReceipt_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        DGV.RowTemplate.Height = DGV.Height - DGV.ColumnHeadersHeight
        If Me.Visible Then
            LblDate.Text = Format(Now.Date, GetDateAndTimeFormat(DTFormat.DF))
            GetData()
            CmbEmployee.Focus()

        Else
            Clear(TableLayoutPanel10)
            DGV.Rows.Clear()
            ReceiptID = 0

            LblValue.BackColor = SystemColors.Window
            LblDate.Text = Format(Now.Date, GetDateAndTimeFormat(DTFormat.DF))
            TLPCheck.Enabled = False
            DGV.Rows.Clear()
            ChangeControlColor(Me)
            Clear(Me)
            Show = False
            If Not IsNothing(DS) Then
                DS.Clear()
            End If
            If Not IsNothing(DsSave) Then
                DsSave.Clear()
            End If

        End If
    End Sub

    Private Sub GetData()

        Dim sqlcon As New SQLConClass()

        SQLQuery = " DECLARE @Num Bigint Select @Num=MAX(Num) +1 From EmployeeReciptTable  
        If @Num IS NULL Set @Num= 1  Select @Num Num"
        SQLQuery &= " Select Name FROM EmployeeReciptFinanceTable "
        SQLQuery &= " Select ID, Name FROM BankTable ORDER BY Name "
        SQLQuery &= " Select ID ,Name From PaymentTypeTable Where ID <> 5 "
        SQLQuery &= " Select ID ,Name From EmployeeTable where EndService is NULL  ORDER BY Name  "
        'SQLQuery &= " Select Top 1 isnull(TotalValue,0) From TreasuryTable Order By ID Desc  "
        SQLQuery &= "SELECT ISNULL(TotalValue,0),ISNULL(TotalValueCard,0) from TreasuryView where ID=(select Max(ID) from TreasuryView )"

        DS = sqlcon.SelectData(SQLQuery, 0, Nothing)

        If DSHasTables(DS) Then
            LblNum.Text = Format(DS.Tables(0).Rows(0).Item(0), "000000")
            LblCashingFinance.Text = DS.Tables(1).Rows(0).Item(0)

            If DS.Tables(5).Rows.Count > 0 Then

                If Not IsDBNull(DS.Tables(5).Rows(0).Item(0)) Then
                    LblTreasuryValue.Text = Format(DS.Tables(5).Rows(0).Item(0), "0.00")
                    LblValueCard.Text = Format(DS.Tables(5).Rows(0).Item(1), "0.00")
                    TreasuryValue = DS.Tables(5).Rows(0).Item(0)
                    BasicValue = DS.Tables(5).Rows(0).Item(0)
                Else
                    LblTreasuryValue.Text = 0
                    LblValueCard.Text = 0
                    TreasuryValue = 0
                    BasicValue = 0
                End If
            Else
                LblTreasuryValue.Text = 0
                LblValueCard.Text = 0
                TreasuryValue = 0
                BasicValue = 0
            End If

            Fillcmb()

        End If
    End Sub

    Private Sub Fillcmb()

        CmbBank.DataSource = DS.Tables(2)
        CmbBank.ValueMember = "ID"
        CmbBank.DisplayMember = "Name"
        CmbBank.SelectedIndex = -1

        CmbPaymentType.DataSource = DS.Tables(3)
        CmbPaymentType.ValueMember = "ID"
        CmbPaymentType.DisplayMember = "Name"
        CmbPaymentType.SelectedValue = 1

        CmbEmployee.DataSource = DS.Tables(4)
        CmbEmployee.ValueMember = "ID"
        CmbEmployee.DisplayMember = "Name"
        CmbEmployee.SelectedIndex = -1

    End Sub

    Private Sub TxtValue_TextChanged(sender As Object, e As EventArgs) Handles TxtValue.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
        LblValue.BackColor = SystemColors.Window

        If TxtValue.Text <> vbNullString Then
            TxtLettersValue.Text = NoToTxt(Val(TxtValue.Text), "دينار", "درهم", True)
        Else
            TxtLettersValue.Text = vbNullString
        End If

        If Val(TxtValue.Text) > 0 Then
            TxtNoteFor.Text = "ايداع إلى الخزينة قيمة  / " & Val(TxtValue.Text)

        Else
            TxtNoteFor.Text = ""
        End If

        'If Not Show Then
        '    Calc()
        'End If
    End Sub

    Private Sub Calc()
        If TxtValue.Text <> vbNullString Then
            TxtLettersValue.Text = NoToTxt(Val(TxtValue.Text), "دينار", "درهم", True)
        Else
            TxtLettersValue.Text = vbNullString
        End If

        If Val(TxtValue.Text) > 0 Then
            TxtNoteFor.Text = "ايداع إلى الخزينة قيمة  / " & Val(TxtValue.Text)

        Else
            TxtNoteFor.Text = ""
        End If

        If Val(TxtValue.Text) <> 0 Then
            If CmbPaymentType.SelectedValue = 1 Then
                LblTreasuryValue.Text = Format(TreasuryValue + Val(TxtValue.Text), "0.00")

            ElseIf CmbPaymentType.SelectedValue > 1 Then
                LblValueCard.Text = Format(TreasuryValue + Val(TxtValue.Text), "0.00")
            End If


        Else

            If CmbPaymentType.SelectedValue = 1 Then
                LblTreasuryValue.Text = Format(TreasuryValue, "0.00")

            ElseIf CmbPaymentType.SelectedValue > 1 Then
                LblValueCard.Text = Format(TreasuryValue, "0.00")
            End If

        End If

    End Sub

    Private Sub TxtValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValue.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
        If Show Then e.Handled = True
    End Sub

    Private Sub TxtCheckNum_TextChanged(sender As Object, e As EventArgs) Handles TxtCheckNum.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBank.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbBank_TextChanged(sender As Object, e As EventArgs) Handles CmbBank.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ReceiptID <> 0 Then Exit Sub

        IsDataMissing = False

        IsInputEmpty(TableLayoutPanel10)

        If IsDataMissing Then
            If Val(TxtValue.Text) = 0 Then
                TxtValue.BackColor = RedColor
                LblValue.BackColor = RedColor
            End If
            MsgTool("يرجى التأكد من البيانات", 0)

            Exit Sub
        End If

        If TLPCheck.Enabled And TxtCheckNum.Text = "" Then
            TxtCheckNum.BackColor = RedColor
        End If

        If TLPCheck.Enabled And CmbBank.SelectedIndex = -1 Then
            CmbBank.BackColor = RedColor
        End If

        If IsDataMissing = True Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        If Val(TxtValue.Text) <= 0 Then Exit Sub

        Dim Sqlcon As New SQLConClass()
        Dim param() As SqlParameter = {
            New SqlParameter("ReceiptID", ReceiptID),            'New SqlParameter("EmployeeID", CmbEmployee.SelectedValue),
            New SqlParameter("Value", Val(TxtValue.Text)),
            New SqlParameter("NoteFor", TxtNoteFor.Text.Trim),
            New SqlParameter("UserID", UserID),
            New SqlParameter("@FID", 1),
            New SqlParameter("PaymentTypeID", CmbPaymentType.SelectedValue),
            New SqlParameter("CheckNUM", TxtCheckNum.Text),
            New SqlParameter("@BankID", IIf(CmbBank.SelectedValue = Nothing, DBNull.Value, CmbBank.SelectedValue))}

        DsSave = Sqlcon.CMDExecuteData("SaveEmployeeReceipt", param)
        If Not DSHasTables(DsSave) Then Exit Sub
        If DsSave.Tables(0).Rows.Count > 0 Then
            LblNum.Text = Format(DsSave.Tables(0).Rows(0).Item(0), "000000")
        End If

        If DsSave.Tables(2).Rows.Count > 0 Then
            LblTreasuryValue.Text = Format(DsSave.Tables(2).Rows(0).Item(0), "0.00")
            LblValueCard.Text = Format(DsSave.Tables(2).Rows(0).Item(1), "0.00")
            TreasuryValue = DsSave.Tables(2).Rows(0).Item(0)
        End If

        BtnRefresh_Click(sender, e)
        FillData(DsSave.Tables(1))
    End Sub

    Private Sub FillData(DT As DataTable)


        DGV.Rows.Clear()
        If DT.Rows.Count > 0 Then
            ReceiptID = DT.Rows(0).Item(0)
            DGV.Rows.Add()
            With DT.Rows(0)
                DGV.Item(0, 0).Value = .Item("ID")
                DGV.Item(1, 0).Value = Format(.Item("NUM"), "000000")
                DGV.Item(2, 0).Value = Format(.Item("Value"), "0.00")
                DGV.Item(3, 0).Value = .Item("EmployeeName")
                DGV.Item(4, 0).Value = .Item("EmployeeReceiptFinanceName")
                DGV.Item(5, 0).Value = .Item("PaymentTypeName")
                DGV.Item(6, 0).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DF))

            End With

            DGV.ClearSelection()
        End If

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ReceiptID = 0 Then Exit Sub

        If MsgBox("هل تريد إلغاء الإيصال ؟ ", vbYesNo + vbQuestion, "تأكيد الإلغاء") = MsgBoxResult.Yes Then
            Dim SQLCon = New SQLConClass
            Dim Param() As SqlParameter = {
                    New SqlParameter("@ID", ReceiptID)}

            Select Case SQLCon.CMDExecute("DeleteEmployeeReceipt", 1, Param)
                Case 1
                    MsgTool("تم إلغاء الإيصال بنجاح", 1)

                Case 5
                    If CmbPaymentType.SelectedValue = 1 Then
                        MsgTool(" لم يتم إلغاء الإيصال ، القيمة في الخزينة نقدي لا تساوي القيمة المطلوبة ", 0)

                    ElseIf CmbPaymentType.SelectedValue > 1 Then
                        MsgTool(" لم يتم إلغاء الإيصال ، القيمة في الخزينة طرق الدفع لا تساوي القيمة المطلوبة ", 0)

                    End If

            End Select

            BtnRefresh_Click(sender, e)
            CmbEmployee.Focus()

        End If

    End Sub

    Public Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Clear(TableLayoutPanel10)
        DGV.Rows.Clear()
        ReceiptID = 0

        LblValue.BackColor = SystemColors.Window
        LblDate.Text = Format(Now.Date, GetDateAndTimeFormat(DTFormat.DF))
        TLPCheck.Enabled = False
        DGV.Rows.Clear()
        ChangeControlColor(Me)
        Clear(Me)
        GetData()
        Show = False
        CmbEmployee.Focus()
    End Sub

    Private Sub CmbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEmployee.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
        If Not IsNothing(CmbEmployee.SelectedValue) Then
            TxtValue.Focus()
        End If
    End Sub

    Private Sub CmbEmployee_TextChanged(sender As Object, e As EventArgs) Handles CmbEmployee.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPaymentType.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
        If CmbPaymentType.SelectedIndex <> 0 And CmbPaymentType.Text <> "" Then
            If Not IsNothing(CmbPaymentType.SelectedValue) Then
                If CmbPaymentType.SelectedValue = 3 Then
                    TLPCheck.Enabled = True
                    TxtCheckNum.Focus()

                Else
                    TLPCheck.Enabled = False
                    TxtCheckNum.Clear()
                    CmbBank.Text = ""
                    CmbBank.SelectedIndex = -1
                    CmbBank.BackColor = SystemColors.Window
                    TxtCheckNum.BackColor = SystemColors.Window

                End If
            End If

        Else
            TLPCheck.Enabled = False
            TxtCheckNum.Clear()
            CmbBank.Text = ""
            CmbBank.SelectedIndex = -1
            CmbBank.BackColor = SystemColors.Window
            TxtCheckNum.BackColor = SystemColors.Window
        End If

    End Sub

    Private Sub CmbPaymentType_TextChanged(sender As Object, e As EventArgs) Handles CmbPaymentType.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbPaymentType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbPaymentType.SelectionChangeCommitted

    End Sub

    Private Sub TxtLettersValue_TextChanged(sender As Object, e As EventArgs) Handles TxtLettersValue.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'If ReceiptID = 0 Then Exit Sub

        'Dim DSPrint = New DataSet
        'Dim SQLCon = New SQLConClass

        'SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT(Date,'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,EmployeeName,NoteFor,CheckNum,PaymentTypeName FROM EmployeeReciptView WHERE ID=" & ReceiptID & " AND EndService IS NULL"
        'SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        'DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        'Dim Check As String
        'Dim CheckNum As String
        'Dim Cash As String
        'Dim Price As String

        'Dim Value = Format(DSPrint.Tables(0).Rows(0).Item(2), "0.00")

        'Dim Denar As String
        'Dim Derham As String
        'Dim PaymentType As String

        'If Value.IndexOf(".") = -1 Then
        '    Denar = Value
        '    Derham = "00"
        'Else
        '    Denar = Value.Substring(0, Value.IndexOf("."))
        '    Derham = Value.Substring(Value.IndexOf(".") + 1, 2)
        'End If


        'If IsDBNull(DSPrint.Tables(0).Rows(0).Item(5)) Or DSPrint.Tables(0).Rows(0).Item(5) = 0 Then
        '    Check = ""
        '    CheckNum = ""
        '    Cash = "✔️"
        '    PaymentType = DSPrint.Tables(0).Rows(0).Item(6)
        'Else
        '    Check = "✔️"
        '    CheckNum = DSPrint.Tables(0).Rows(0).Item(5).ToString
        '    Cash = ""
        '    PaymentType = "نقداً"
        'End If

        'Price = NoToTxt(Val(DSPrint.Tables(0).Rows(0).Item(2)), "دينار", "درهم", True)

        'Dim F As New FrmPrint
        'Dim C As New CRTreasuryReceipt

        'C.SetDataSource(DSPrint.Tables(0))
        'C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        'C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        'C.Subreports(2).SetDataSource(DSPrint.Tables(1))
        'C.Subreports(3).SetDataSource(DSPrint.Tables(1))
        'C.SetParameterValue("Check", Check)
        'C.SetParameterValue("CheckNum", CheckNum)
        'C.SetParameterValue("Cash", Cash)
        'C.SetParameterValue("Price", Price)
        'C.SetParameterValue("Denar", Denar)
        'C.SetParameterValue("Derham", Derham)
        'C.SetParameterValue("PaymentType", PaymentType)
        'F.CrystalReportViewer1.ReportSource = C
        'F.CrystalReportViewer1.Refresh()
        'F.Text = "طباعة"
        'F.CrystalReportViewer1.Zoom(100%)
        'F.WindowState = FormWindowState.Maximized
        'F.Show()


    End Sub

    Private Sub TxtNoteFor_TextChanged(sender As Object, e As EventArgs) Handles TxtNoteFor.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Public Sub SearchReceipt()
        SQLQuery = "SELECT * FROM EmployeeReciptView WHERE  ID= " & ReceiptID

        SQLQuery &= " Select ID, Name FROM BankTable ORDER BY Name "
        SQLQuery &= " Select ID ,Name From PaymentTypeTable  Where ID <> 5 "
        SQLQuery &= " Select ID ,Name From EmployeeTable where EndService is NULL  ORDER BY Name  "
        SQLQuery &= " Select Top 1 TotalValue From TreasuryTable Order By ID Desc  "

        Dim SQLCon = New SQLConClass()
        DsSearch = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DsSearch.Tables.Count > 0 Then

            If DsSearch.Tables(1).Rows.Count > 0 Then
                CmbBank.DataSource = DsSearch.Tables(1)
                CmbBank.ValueMember = "ID"
                CmbBank.DisplayMember = "Name"
                CmbBank.SelectedIndex = -1
            End If


            If DsSearch.Tables(2).Rows.Count > 0 Then
                CmbPaymentType.DataSource = DsSearch.Tables(2)
                CmbPaymentType.ValueMember = "ID"
                CmbPaymentType.DisplayMember = "Name"
                CmbPaymentType.SelectedValue = 1
                CmbEmployee.SelectedValue = DsSearch.Tables(0).Rows(0).Item("PaymentTypeID")
            End If


            If DsSearch.Tables(3).Rows.Count > 0 Then
                CmbEmployee.DataSource = DsSearch.Tables(3)
                CmbEmployee.ValueMember = "ID"
                CmbEmployee.DisplayMember = "Name"
                CmbEmployee.SelectedValue = DsSearch.Tables(0).Rows(0).Item("EmployeeID")
            End If

            Show = True
            If DsSearch.Tables(4).Rows.Count > 0 Then
                If Not IsDBNull(DsSearch.Tables(4).Rows(0).Item(0)) Then
                    LblTreasuryValue.Text = Format(DsSearch.Tables(4).Rows(0).Item(0), "0.00")
                    TreasuryValue = DsSearch.Tables(4).Rows(0).Item(0)
                    BasicValue = DsSearch.Tables(4).Rows(0).Item(0)

                Else
                    LblTreasuryValue.Text = 0
                    TreasuryValue = 0
                    BasicValue = 0
                End If

            Else
                LblTreasuryValue.Text = 0
                TreasuryValue = 0
                BasicValue = 0
            End If


            If DsSearch.Tables(0).Rows.Count > 0 Then
                FillData(DsSearch.Tables(0))
                With DsSearch.Tables(0).Rows(0)
                    LblNum.Text = Format(.Item("NUM"), "000000")
                    LblDate.Text = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DF))
                    CmbEmployee.SelectedValue = .Item("EmployeeID")
                    TxtValue.Text = Format(.Item("Value"), "0.00")
                    ReceiptValue = Format(.Item("Value"), "0.00")
                    LblCashingFinance.Text = .Item("EmployeeReceiptFinanceName")
                    CmbPaymentType.SelectedValue = .Item("PaymentTypeID")
                    If .Item("CheckNum") <> 0 Then
                        TxtCheckNum.Text = .Item("CheckNum")
                        TLPCheck.Enabled = True '  TxtCheckNum.Enabled = True

                    Else
                        TxtCheckNum.Text = ""
                        TLPCheck.Enabled = False ' TxtCheckNum.Enabled = False
                    End If

                    If Not IsDBNull(.Item("BankID")) Then
                        CmbBank.SelectedValue = .Item("BankID")
                        CmbBank.Enabled = True

                    Else
                        CmbBank.SelectedIndex = -1
                        CmbBank.Enabled = False
                    End If
                    TxtNoteFor.Text = .Item("NoteFor")
                End With
            End If

        End If
    End Sub

    Private Sub TxtCheckNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCheckNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

End Class