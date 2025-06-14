Imports System.Data.SqlClient

Public Class FrmDeliveryInvoiceCashing
    Private DS, DsSave As DataSet
    Private CashingID As Integer

    Private Sub FrmDeliveryInvoiceCashing_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            DTPDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            DGVInvoice.RowTemplate.Height = DGVInvoice.Height - DGVInvoice.ColumnHeadersHeight
            ChkCheck.Enabled = False
            GetData()
            If EmployeeID <> 0 Then
                CmbEmployee.SelectedValue = EmployeeID
            End If

        Else
            If Not IsNothing(DS) Then
                DS.Clear()
            End If
            If Not IsNothing(DsSave) Then
                DsSave.Clear()
            End If
            Clear(TableLayoutPanel10)
            Clear(TableLayoutPanel4)
            Clear(TableLayoutPanel5)
            DGVInvoice.Rows.Clear()
            TxtRest.Text = ""
            LblValue.BackColor = Color.White
            ChangeControlColor(Me)

        End If
    End Sub

    Private Sub FrmDeliveryInvoiceCashing_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Clear(TableLayoutPanel10)
        Clear(TableLayoutPanel4)
        Clear(TableLayoutPanel5)
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub GetData()

        Dim sqlcon As New SQLConClass()

        SQLQuery = " Select DeliveryOrderView.DeliveryID ID ,DeliveryOrderView.DeliveryName Name , COALESCE(SUM(DeliveryOrderView.Price),0) Total 
                    From DeliveryOrderView, InvoceTable Where InvoceTable.ID= DeliveryOrderView.InvoiceID
                    And DeliveryOrderView.InvoiceID In(Select InvoiceID from InvoceTable) 
                    GROUP BY DeliveryOrderView.InvoiceID, DeliveryOrderView.DeliveryName,DeliveryID ORDER BY DeliveryOrderView.DeliveryName   " 'SupplierID
        If Not IsNothing(CmbDelivery.SelectedValue) Then
            SQLQuery &= " where DeliveryID=" & CmbDelivery.SelectedValue
        End If
        SQLQuery &= " SELECT ID, Name FROM BankTable ORDER BY Name "
        SQLQuery &= " Select DeliveryTable.ID, DeliveryTable.Name, COALESCE(SUM(CashingTable.Value),0) Value
                    From DeliveryTable LEFT JOIN deliveryCashingTable ON DeliveryTable.ID = deliveryCashingTable.DeliveryID
                    LEFT JOIN  CashingTable ON CashingTable.ID = deliveryCashingTable.CashingID
                    Where CashingTable.EndService IS NULL
                    GROUP BY DeliveryTable.ID, DeliveryTable.Name "

        If Not IsNothing(CmbDelivery.SelectedValue) Then
            SQLQuery &= " And DeliveryID = " & CmbDelivery.SelectedValue
        End If
        SQLQuery &= " DECLARE @Num BigInt Select @Num=ISNULL( MAX(Num),0) +1 From CashingTable  Select @Num Num"
        SQLQuery &= " Select ID , Name From PaymentTypeTable "
        SQLQuery &= " Select ID ,Name from EmployeeTable where EndService is NULL AND ID IN (SELECT EmployeeID From UserTable )  ORDER BY Name "
        DS = sqlcon.SelectData(SQLQuery, 0, Nothing)
        LblNum.Text = Format(DS.Tables(3).Rows(0).Item(0), "000000")
        If DSHasTables(DS) Then
            Fillcmb()
        End If
    End Sub

    Private Sub Fillcmb()

        CmbDelivery.DataSource = DS.Tables(0)
        CmbDelivery.ValueMember = "ID"
        CmbDelivery.DisplayMember = "Name"
        CmbDelivery.SelectedIndex = -1

        CmbBank.DataSource = DS.Tables(1)
        CmbBank.ValueMember = "ID"
        CmbBank.DisplayMember = "Name"
        CmbBank.SelectedIndex = -1

        CmbPaymentType.DataSource = DS.Tables(4)
        CmbPaymentType.DisplayMember = "Name"
        CmbPaymentType.ValueMember = "ID"
        CmbPaymentType.SelectedValue = 1

        If DS.Tables(5).Rows.Count > 0 Then
            CmbEmployee.DataSource = DS.Tables(5)
            CmbEmployee.DisplayMember = "Name"
            CmbEmployee.ValueMember = "ID"
            CmbEmployee.SelectedIndex = -1
            If EmployeeID <> 0 Then
                CmbEmployee.SelectedValue = EmployeeID
            End If
        End If

    End Sub

    Private Sub FillData()
        If IsNothing(CmbDelivery.SelectedValue) Then Exit Sub
        TxtValueRecipted.Text = ""
        TxtValue.Text = ""
        TxtRest.Text = ""
        TxtSpusedValue.Text = ""

        Dim ItemRow() As DataRow = DS.Tables(0).Select("ID=" & CmbDelivery.SelectedValue)

        If ItemRow.Length > 0 Then
            TxtSpusedValue.Text = Format(ItemRow(0)("Total"), "0.00")

        Else
            TxtSpusedValue.Text = "0.00"
        End If

        Dim SelectedRow() As DataRow = DS.Tables(2).Select("ID=" & CmbDelivery.SelectedValue)

        If SelectedRow.Length > 0 Then
            Dim DT As DataTable = SelectedRow.CopyToDataTable

            With DT.Rows(0)
                'If Not IsDBNull(DT.Rows(0).Item("Value")) Then
                TxtValueRecipted.Text = Format(DT.Rows(0).Item("Value"), "0.00") 'Value
                'Else
                '    TxtValueRecipted.Text = "0.00"
                'End If

                TxtRest.Text = (Val(TxtSpusedValue.Text) - Val(TxtValueRecipted.Text)).ToString
            End With
        Else
            'TxtSpusedValue.Text = "0.00"
            TxtValueRecipted.Text = "0.00"
            TxtRest.Text = Format(TxtSpusedValue.Text, "0.00")
        End If

    End Sub

    Private Sub CmbDelivery_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbDelivery.SelectionChangeCommitted
        FillData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CashingID <> 0 Then
            MsgTool("تم حفظ الفاتورة", 1)
            Exit Sub
        End If

        IsDataMissing = False
        IsInputEmpty(TableLayoutPanel1)
        IsInputEmpty(TableLayoutPanel10)
        If IsDataMissing Then
            If Val(TxtValue.Text) = 0 Then
                LblValue.BackColor = RedColor
            End If
            MsgTool("يرجى التأكد من البيانات", 0)

            If TxtSpusedValue.Text = "" Then
                LblSpusedValue.BackColor = TxtSpusedValue.BackColor
            End If
            If TxtValueRecipted.Text = "" Then
                LblValueRecipted.BackColor = TxtValueRecipted.BackColor
            End If
            If TxtRest.Text = "" Then
                LblRest.BackColor = TxtRest.BackColor
            End If

            Exit Sub
        End If


        If Val(TxtValue.Text) <= 0 Then Exit Sub
        If Val(TxtSpusedValue.Text) < 0 Then Exit Sub

        If Val(TxtValue.Text) > (Val(TxtRest.Text)) Then
            MsgTool("القيمة المدخلة أكبر من القيمة المستحقة", 0)
            TxtValue.Clear()
            TxtValue.Focus()
            Exit Sub
        End If

        Dim BankID As Integer
        BankID = CmbBank.SelectedValue
        If CmbBank.SelectedValue = Nothing Then BankID = 0
        Dim EmployeeID As Integer
        EmployeeID = CmbEmployee.SelectedValue
        If CmbEmployee.SelectedValue = Nothing Then EmployeeID = 0

        Dim Sqlcon As New SQLConClass()
        Dim param() As SqlParameter = {
            New SqlParameter("@DeliveryID", CmbDelivery.SelectedValue),
            New SqlParameter("@Value", Val(TxtValue.Text)),
            New SqlParameter("@UserID", UserID),
            New SqlParameter("@EmployeeID", EmployeeID),
            New SqlParameter("@PayTypeID", CmbPaymentType.SelectedValue),
            New SqlParameter("@ReceiptName", TxtRecipient.Text.Trim),
            New SqlParameter("@Notes", TxtNoteFor.Text.Trim),
            New SqlParameter("@CheckNUM", IIf(ChkCheck.Checked = True, Val(TxtCheckNum.Text.Trim), DBNull.Value)),
            New SqlParameter("@BankID", CmbBank.SelectedValue),
            New SqlParameter("@Date", DTPDate.Value)}

        DsSave = Sqlcon.CMDExecuteData("SaveDeliveryInvoiceCashing", param)
        If Not DSHasTables(DsSave) Then Exit Sub
        FillDGV()

        If Save = 1 Then
            If DsSave.Tables(0).Rows.Count > 0 Then
                CashingID = DsSave.Tables(0).Rows(0).Item(0)
            End If
        End If
    End Sub

    Private Sub TxtRest_TextChanged(sender As Object, e As EventArgs) Handles TxtRest.TextChanged
        If TxtRest.Tag = "AutoC" Then
            TxtRest.Text = Format(Val(TxtSpusedValue.Text) - Val(TxtValueRecipted.Text), "0.00")
        End If
    End Sub

    Public Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TxtRest.Tag = ""
        DTPDate.Value = Now.Date
        ChkCheck.Checked = False
        CmbEmployee.Text = ""
        DGVInvoice.Rows.Clear()
        ChangeControlColor(Me)
        LblValue.BackColor = TxtValue.BackColor
        LblValue.BackColor = SystemColors.Window
        Clear(Me)
        GetData()
        CashingID = 0

        TxtRest.Text = ""
        TxtRest.Tag = "AutoC"
        ChangeControlColor(Me)

    End Sub

    Private Sub FillDGV()
        DGVInvoice.Rows.Clear()
        DGVInvoice.Rows.Add()
        DGVInvoice.Item(0, 0).Value = DGVInvoice.Rows.Count + 1
        DGVInvoice.Item(1, 0).Value = CmbDelivery.Text
        DGVInvoice.Item(2, 0).Value = TxtSpusedValue.Text
        DGVInvoice.Item(3, 0).Value = Format(Val(TxtValueRecipted.Text) + Val(TxtValue.Text), "0.00")
        DGVInvoice.Item(4, 0).Value = Format(Val(TxtSpusedValue.Text) - (Val(TxtValueRecipted.Text) + Val(TxtValue.Text)), "0.00")
        DGVInvoice.ClearSelection()
    End Sub

    Private Sub CmbPaymentType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbPaymentType.KeyPress, CmbDelivery.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtValue_TextChanged(sender As Object, e As EventArgs) Handles TxtValue.TextChanged
        sender.BackColor = SystemColors.Window
        LblValue.BackColor = TxtValue.BackColor

        If TxtValue.Text <> vbNullString Then
            TxtLettersValue.Text = NoToTxt(Val(TxtValue.Text), "دينار", "درهم", True)

        Else
            TxtLettersValue.Text = vbNullString
        End If

        If TxtValue.Text <> "" Then
            If Val(TxtValue.Text) = (Val(TxtSpusedValue.Text) - Val(TxtValueRecipted.Text)) Then
                TxtNoteFor.Text = "دفعة نهائية للشركة (" & CmbDelivery.Text & ") "
            Else
                TxtNoteFor.Text = "دفعة على الحساب " & "للشركة ( " & CmbDelivery.Text & " ) , الباقي " & Val(TxtSpusedValue.Text) - (Val(TxtValueRecipted.Text) + Val(TxtValue.Text))
            End If
        End If

    End Sub

    Private Sub CmbPaymentType_TextChanged(sender As Object, e As EventArgs) Handles CmbPaymentType.TextChanged, CmbBank.TextChanged, TxtValue.TextChanged, TxtCheckNum.TextChanged, CmbEmployee.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbDelivery_TextChanged(sender As Object, e As EventArgs) Handles CmbDelivery.TextChanged
        sender.BackColor = SystemColors.Window
        If IsNothing(CmbDelivery.SelectedValue) Then
            Clean()
            Exit Sub
        End If
        TxtRecipient.Text = CmbDelivery.Text

    End Sub

    Private Sub Clean()
        TxtNoteFor.Text = ""
        TxtCheckNum.Text = ""
        TxtLettersValue.Text = ""
        TxtRecipient.Text = ""
        TxtRest.Text = ""
        TxtSpusedValue.Text = ""
        TxtValue.Text = ""
        TxtValueRecipted.Text = ""
        CmbBank.Text = ""
        CmbEmployee.Text = ""
        CmbPaymentType.Text = ""
    End Sub

    Private Sub ChkCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCheck.CheckedChanged
        If ChkCheck.Checked = True Then
            TLPCheck.Enabled = True

        Else
            CmbPaymentType.SelectedValue = 1
            ChkCheck.Enabled = False
            TLPCheck.Enabled = False
            CmbBank.Text = ""
            TxtCheckNum.Text = ""
            CmbBank.BackColor = SystemColors.Window
            TxtCheckNum.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub TxtCheckNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCheckNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If CashingID = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT(Date,'" & GetDateAndTimeFormat(DTFormat.DF) &
            "') AS [Date],Value,ReceiptName,Notes,CheckNum,PaymentTypeName FROM CashingView WHERE ID=" & CashingID
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        Dim Check As String
        Dim Cash As String
        Dim Price As String

        Dim Value = Format(DSPrint.Tables(0).Rows(0).Item(2), "0.00")

        Dim Denar As String
        Dim Derham As String
        Dim PaymentType As String

        If Value.IndexOf(".") = -1 Then
            Denar = Value
            Derham = "00"
        Else
            Denar = Value.Substring(0, Value.IndexOf("."))
            Derham = Value.Substring(Value.IndexOf(".") + 1, 2)
        End If


        If IsDBNull(DSPrint.Tables(0).Rows(0).Item(5)) Then
            Check = ""
            Cash = "✔️"
            PaymentType = DSPrint.Tables(0).Rows(0).Item(6)
        Else
            Check = "✔️"
            Cash = ""
            PaymentType = "نقداً"
        End If

        Price = NoToTxt(DSPrint.Tables(0).Rows(0).Item(2), "دينار", "درهم", True)

        Dim F As New FrmPrint
        Dim C As New CRCashing

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        C.Subreports(2).SetDataSource(DSPrint.Tables(1))
        C.Subreports(3).SetDataSource(DSPrint.Tables(1))
        C.SetParameterValue("Check", Check)
        C.SetParameterValue("Cash", Cash)
        C.SetParameterValue("Price", Price)
        C.SetParameterValue("Denar", Denar)
        C.SetParameterValue("Derham", Derham)
        C.SetParameterValue("PaymentType", PaymentType)
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()

    End Sub

    Private Sub TxtRecipient_TextChanged(sender As Object, e As EventArgs) Handles TxtRecipient.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtLettersValue_TextChanged(sender As Object, e As EventArgs) Handles TxtLettersValue.TextChanged, TxtSpusedValue.TextChanged, TxtValueRecipted.TextChanged, TxtRest.TextChanged
        sender.BackColor = SystemColors.Window
        LblRest.BackColor = TxtRest.BackColor
        LblSpusedValue.BackColor = TxtSpusedValue.BackColor
        LblValueRecipted.BackColor = TxtValueRecipted.BackColor
    End Sub

    Private Sub TxtNoteFor_TextChanged(sender As Object, e As EventArgs) Handles TxtNoteFor.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPaymentType.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBank.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbPaymentType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbPaymentType.SelectionChangeCommitted

        If CmbPaymentType.SelectedValue = 3 Then
            ChkCheck.Checked = True
            ChkCheck.Enabled = True
        Else
            ChkCheck.Checked = False
            ChkCheck.Enabled = False
        End If
    End Sub

    Private Sub CmbDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDelivery.SelectedIndexChanged

    End Sub

    Private Sub TxtValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValue.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

End Class