Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmReceipt

    Private DS, DSPrice, DSReceipt, DSSearch, DSReceiptNum As New DataSet
    Public ReceiptID, PaymentTypeID, InvoiceID, PatientID, CIDSearch As Integer
    Public LastName As String
    Private Const BorderSize As Integer = 10
    Private MeTop As Rectangle = New Rectangle(0, 0, Me.Width, BorderSize)
    Private MeBottom As Rectangle = New Rectangle(0, Me.ClientSize.Height - BorderSize, Me.ClientSize.Width, BorderSize)
    Private MeLeft As Rectangle = New Rectangle(0, 0, BorderSize, Me.ClientSize.Height)
    Private MeRight As Rectangle = New Rectangle(Me.ClientSize.Width - BorderSize, 0, BorderSize, Me.ClientSize.Height)

    Private MeTopLeft As Rectangle = New Rectangle(0, 0, BorderSize, BorderSize)
    Private MeTopRight As Rectangle = New Rectangle(Me.ClientSize.Width - BorderSize, 0, BorderSize, BorderSize)
    Private MeBottomLeft As Rectangle = New Rectangle(0, Me.ClientSize.Height - BorderSize, BorderSize, BorderSize)
    Private MeBottomRight As Rectangle = New Rectangle(Me.ClientSize.Width - BorderSize, Me.ClientSize.Height - BorderSize, BorderSize, BorderSize)


    Private Sub FrmReceipt1_Load(sender As Object, e As EventArgs) Handles Me.Load
        DTPReceiptDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)

        DGVReceipt.RowTemplate.Height = DGVReceipt.Height - DGVReceipt.ColumnHeadersHeight
        If Not Me.Modal Then Exit Sub

        Me.SetStyle(ControlStyles.ResizeRedraw, True) ' Not Important you can stop this line
        ' you can even set it to False nothing will change about how resize work

        ChangeSystemColors(Me)
        ClearData()
        GetData()
        TxtUserName.Text = UserName
    End Sub

    Private Sub GetEmployee()

        SQLQuery = "Select ID ,Name from EmployeeTable where EndService is NULL AND ID IN (SELECT EmployeeID From UserTable ) ORDER BY Name "

        Dim SQLCon = New SQLConClass()
        Dim DSEmp As DataSet
        DSEmp = SQLCon.SelectData(SQLQuery)
        If DSEmp.Tables.Count > 0 Then
            CmbTrusry.DataSource = DSEmp.Tables(0)
            CmbTrusry.ValueMember = "ID"
            CmbTrusry.DisplayMember = "Name"

            If EmployeeID <> 0 Then
                CmbTrusry.SelectedValue = EmployeeID

            Else
                CmbTrusry.SelectedValue = -1
            End If
        End If
    End Sub

    Private Sub FrmReceipt1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

    End Sub

    Private Sub FrmReceipt1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(DS) Then
            DS.Clear()
        End If
        If Not IsNothing(DSPrice) Then
            DSPrice.Clear()
        End If
        If Not IsNothing(DSReceipt) Then
            DSReceipt.Clear()
        End If
        If Not IsNothing(DSSearch) Then
            DSSearch.Clear()
        End If
        If Not IsNothing(DSReceiptNum) Then
            DSReceiptNum.Clear()
        End If

        Dispose()
    End Sub

    Private Sub FrmReceipt1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not Me.Modal Then Exit Sub

        If Me.Height < 600 Then Me.Height = 600
        If Me.Width < 800 Then Me.Width = 800

        If WindowState = FormWindowState.Maximized Then
            BtnMax.Image = My.Resources.maximize_16
            ' If you didn't understadn stop code line 19 and 23 you will get it
        Else
            BtnMax.Image = My.Resources.Normal_16
        End If

        MeTop = New Rectangle(0, 0, Me.Width, BorderSize)
        MeBottom = New Rectangle(0, Me.ClientSize.Height - BorderSize, Me.ClientSize.Width, BorderSize)
        MeLeft = New Rectangle(0, 0, BorderSize, Me.ClientSize.Height)
        MeRight = New Rectangle(Me.ClientSize.Width - BorderSize, 0, BorderSize, Me.ClientSize.Height)

        MeTopLeft = New Rectangle(0, 0, BorderSize, BorderSize)
        MeTopRight = New Rectangle(Me.ClientSize.Width - BorderSize, 0, BorderSize, BorderSize)
        MeBottomLeft = New Rectangle(0, Me.ClientSize.Height - BorderSize, BorderSize, BorderSize)
        MeBottomRight = New Rectangle(Me.ClientSize.Width - BorderSize, Me.ClientSize.Height - BorderSize, BorderSize, BorderSize)

        LblTitle.Left = (PnlMenu.Width - LblTitle.Width) / 2
        SSLMessage.Margin = New Padding(((Me.Width - SSLMessage.Width) / 2), 3, 0, 2)

    End Sub

    Private Sub ClearData()
        BtnRefresh.PerformClick()
    End Sub

    Private Sub GetData()
        If CIDSearch = 0 Then Exit Sub

        SQLQuery = " SELECT * FROM PaymentTypeTable "
        SQLQuery &= " EXEC GetUnpaidInvoices  @CustomerID = " & CIDSearch
        SQLQuery &= " Select * From BankTable Order By Name"
        SQLQuery &= " Select ID ,Name from TrusryTypeTable  "
        SQLQuery &= " DECLARE @Num BigInt Select @Num=ISNULL(MAX(Num),0) +1 From ReceiptTable  Select @Num Num "
        SQLQuery &= "  Select ID, Name  From CustomersTable Where  ID = " & CIDSearch
        If ReceiptID <> 0 Then
            SQLQuery += "	Select * From ReceiptView Where ID =" & ReceiptID
        End If
        Dim SQLCon = New SQLConClass()

        DS = SQLCon.SelectData(SQLQuery)
        If DS.Tables.Count > 0 Then
            FillData()
        End If
    End Sub

    Private Sub FillData()

        If DS.Tables(0).Rows.Count > 0 Then
            CmbPaymentType.DataSource = DS.Tables(0)
            CmbPaymentType.ValueMember = "ID"
            CmbPaymentType.DisplayMember = "Name"
            CmbPaymentType.SelectedValue = 1

        Else
            CmbPaymentType.DataSource = Nothing
        End If

        Dim Row() As DataRow = DS.Tables(0).Select("ID=" & CmbPaymentType.SelectedValue)
        If Row.Length > 0 Then
            TxtPercent.Text = Row(0)("Percent")

        Else
            TxtPercent.Text = 0

        End If

        If DS.Tables(5).Rows.Count > 0 Then
            TxtName.Text = DS.Tables(5).Rows(0).Item("Name")

        Else
            TxtName.Text = ""
        End If

        If DS.Tables(1).Rows.Count > 0 Then
            CmbInvoice.DataSource = DS.Tables(1)
            CmbInvoice.ValueMember = "ID"

            CmbInvoice.DisplayMember = "Num"

            CmbInvoice.SelectedIndex = -1

            CmbInvoice.DropDownHeight = 200

        Else
            CmbInvoice.DataSource = Nothing
            TxtPrice.Text = ""
            TxtPayment.Text = ""
            TxtRest.Text = ""
            CmbInvoice.DropDownHeight = 40
        End If

        If DS.Tables(2).Rows.Count > 0 Then
            CmbBank.DataSource = DS.Tables(2)
            CmbBank.ValueMember = "ID"
            CmbBank.DisplayMember = "Name"
            CmbBank.SelectedIndex = -1

        Else
            CmbBank.DataSource = Nothing
        End If

        If DS.Tables(3).Rows.Count > 0 Then
            CmbTrusry.DataSource = DS.Tables(3)
            CmbTrusry.ValueMember = "ID"
            CmbTrusry.DisplayMember = "Name"
            If EmployeeID <> 0 Then
                CmbTrusry.SelectedValue = EmployeeID

            Else
                CmbTrusry.SelectedValue = -1
            End If
        Else
            CmbTrusry.DataSource = Nothing
        End If

        CmbInvoice.Select()
        LblReceiptNum.Text = Format(DS.Tables(4).Rows(0).Item("Num"), "000000")


        If ReceiptID <> 0 Then
            FillDGV(DS.Tables(6))
        End If
    End Sub

    Private Sub PnlMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseDown, LblTitle.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub PnlMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseMove, LblTitle.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Private Sub PnlMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseUp, LblTitle.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub PnlMenu_DoubleClick(sender As Object, e As EventArgs) Handles PnlMenu.DoubleClick
        BtnMax.PerformClick()
    End Sub

    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles BtnMax.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub CmbInvoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbInvoice.SelectedIndexChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbInvoice_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbInvoice.SelectionChangeCommitted
        InvoiceID = CmbInvoice.SelectedValue
        'Dim Row() As DataRow = DS.Tables(1).Select("ID=" & InvoiceID)
        'If Row.Length > 0 Then  ' هدا زايد بيدير خطأ 


        SQLQuery = "Exec GetInvoiceDetails @InvoiceID = " & InvoiceID

            Dim SQLCon = New SQLConClass()

            DSPrice = SQLCon.SelectData(SQLQuery)
            If DSPrice.Tables(0).Rows.Count > 0 Then
            TxtPrice.Text = Format(DSPrice.Tables(0).Rows(0).Item("TotalInvoice"), "0.00")
            TxtPayment.Text = Format(DSPrice.Tables(0).Rows(0).Item("TotalReceipts"), "0.00")
            TxtRest.Text = Format(DSPrice.Tables(0).Rows(0).Item("Remaining"), "0.00")

        End If
            TxtReceiptValue.Text = TxtRest.Text

        'End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReceiptID = 0
        NewReceipt()
        DGVReceipt.Rows.Clear()
        GetData()
        ChangeControlColor(PnlCenter)
    End Sub

    Private Sub NewReceipt()
        InvoiceID = 0 : TreatmentID = 0 : PaymentTypeID = 0

        Clear(PnlReceiptValue)
        Clear(TLPFinancial)
        Clear(TLPTreatment)
        'Clear(PnlFinalValue)
        ' Clear(PnlPaymentType)
        Clear(GrpRecieptData)
        Clear(TLPUser)
        'Clear(PnlChkPrint)
        'Clear(TLPReciept)
        'Clear(PnlReceiptNum)
        'Clear(PnlReceiptDate)

        DTPReceiptDate.Value = Now

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If InvoiceID = 0 Then
            MsgToolReceipt("يجب اختيار فاتورة أولاً", 0)
            Exit Sub
        End If

        IsDataMissing = False
        If IsInputEmpty(PnlCenter) Then IsDataMissing = True

        If IsDataMissing Then
            MsgToolReceipt("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        If Val(TxtReceiptValue.Text) > Val(TxtRest.Text) Then
            MsgToolReceipt("القيمة المدخلة أكبر من القيمة المستحقة", 0)
            TxtReceiptValue.Clear()
            TxtReceiptValue.Focus()
            TxtValueChr.Text = ""
            Exit Sub
        End If

        Dim BankID, CheckNum As Integer

        If Val(TxtReceiptValue.Text) <= 0 Then
            MsgToolReceipt("يرجى التأكد من القيمة", 0)
            TxtReceiptValue.Focus()
            Exit Sub
        End If

        If CmbBank.SelectedIndex = -1 Then
            BankID = 0
            CheckNum = 0

        Else
            BankID = CmbBank.SelectedValue
            CheckNum = Val(TxtCheckNum.Text)
        End If

        Dim Param() As SqlParameter = {
            New SqlParameter("@InvoiceID", InvoiceID),
            New SqlParameter("@ID", ReceiptID),
            New SqlParameter("@Num", LblReceiptNum.Text),
            New SqlParameter("@Date", DTPReceiptDate.Value),
            New SqlParameter("@Value", TxtReceiptValue.Text.Trim),
            New SqlParameter("@IncreaseValue", TxtIncreaseValue.Text.Trim),
            New SqlParameter("@TrusryTypeID", CmbTrusry.SelectedValue),
            New SqlParameter("@ReceiptName", TxtName.Text.Trim),
            New SqlParameter("@PaymentTypeID", CmbPaymentType.SelectedValue),
            New SqlParameter("@BankID", CmbBank.SelectedValue),
            New SqlParameter("@CheckNum", CheckNum),
            New SqlParameter("@NoteFor", TxtNoteFor.Text.Trim),
            New SqlParameter("@UserID", UserID)}

        Dim SQLCon = New SQLConClass

        DSReceipt = SQLCon.CMDExecuteData("SaveReceipt", Param)

        If Save = 1 Then
            MsgToolReceipt("تم حفظ الايصال بنجاح", 1)
            ReceiptID = DSReceipt.Tables(0).Rows(0).Item(0)
            'FillDGV(DSReceipt.Tables(0))
            'If ChkPrint.Checked Then
            '    BtnPrint_Click(sender, e)
            'End If
            NewReceipt()
            GetData()

        End If

    End Sub

    Private Sub FillDGV(DT As DataTable)
        DGVReceipt.Rows.Clear()
        For i = 0 To DT.Rows.Count - 1
            With DT.Rows(i)
                DGVReceipt.Rows.Add()
                ReceiptID = .Item("ID")
                DGVReceipt.Item(0, i).Value = .Item("ID")
                DGVReceipt.Item(1, i).Value = Format(.Item("Num"), "000000")
                DGVReceipt.Item(2, i).Value = Format(.Item("Value"), "0.00")
                DGVReceipt.Item(3, i).Value = .Item("ReceiptName")
                DGVReceipt.Item(4, i).Value = .Item("InvoiceNum")
                DGVReceipt.Item(5, i).Value = .Item("PaymentType")
                DGVReceipt.Item(6, i).Value = .Item("Date")
            End With
        Next
    End Sub

    Private Sub TxtPercent_TextChanged(sender As Object, e As EventArgs) Handles TxtPercent.TextChanged
        If Val(TxtPrice.Text) > 0 Then
            TxtIncreaseValue.Text = Format(Val(TxtReceiptValue.Text) * (Val(TxtPercent.Text) / 100), "0.00")
        End If
    End Sub

    Private Sub CmbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPaymentType.SelectedIndexChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window

        If CmbPaymentType.SelectedIndex = 0 Or CmbPaymentType.Text = Nothing Then TxtPercent.Text = 0
        TxtReceiptValue_TextChanged(sender, e)
    End Sub

    Private Sub CmbPaymentType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbPaymentType.SelectionChangeCommitted
        PaymentTypeID = CmbPaymentType.SelectedValue

        Dim Row() As DataRow = DS.Tables(0).Select("ID=" & PaymentTypeID)
        If Row.Length > 0 Then
            If Row(0)("Percent") > 0 Then
                MsgBox("هذه الطريقة يترتب عليها زيادة على السعر بنسبة : " + " %" + Row(0)("Percent").ToString, vbExclamation, "رسالة تنبيه")
            End If

            TxtPercent.Text = Row(0)("Percent")

        Else
            TxtPercent.Text = 0
        End If

        'If PaymentTypeID = 1 Then
        '    TxtPercent.Enabled = False

        'Else
        '    TxtPercent.Enabled = True
        'End If
    End Sub

    Private Sub CmbPaymentType_TextChanged(sender As Object, e As EventArgs) Handles CmbPaymentType.TextChanged
        If CmbPaymentType.Text = "صك" Then
            'TLPCheck.Enabled = True
            CmbBank.Enabled = True
            TxtCheckNum.Enabled = True
        Else
            'TLPCheck.Enabled = False
            'Clear(TLPCheck)
            CmbBank.Enabled = False
            TxtCheckNum.Enabled = False
            CmbBank.SelectedIndex = -1
            CmbBank.Text = ""
            TxtCheckNum.Enabled = False
            TxtCheckNum.Clear()

            TxtCheckNum.BackColor = SystemColors.Window
        End If

    End Sub

    Private Sub TxtDoctor_TextChanged(sender As Object, e As EventArgs)
        sender.BackColor = Gray
    End Sub

    Private Sub TxtDoctor_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ReceiptID = 0 Then Exit Sub

        If MsgBox("هل تريد إلغاء ايصال رقم " & vbCrLf & LblReceiptNum.Text & " ؟ ", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim Param() As SqlParameter = {
                    New SqlParameter("@ID", ReceiptID)}

            Dim SQLCon = New SQLConClass
            Dim SaveState As Integer = SQLCon.CMDExecute("DeleteReceipt", 1, Param)
            Select Case SaveState
                Case 1
                    MsgToolReceipt(" تم إلغاء الايصال بنجاح ", 1)
            End Select
            BtnRefresh.PerformClick()
        End If
    End Sub

    Private Sub TxtFinalPrice_Click(sender As Object, e As EventArgs) Handles TxtFinalPrice.Click

    End Sub

    Private Sub TxtNoteFor_TextChanged(sender As Object, e As EventArgs) Handles TxtNoteFor.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtValueChr_TextChanged(sender As Object, e As EventArgs) Handles TxtValueChr.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtCheckNum_TextChanged(sender As Object, e As EventArgs) Handles TxtCheckNum.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtCheckNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCheckNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, 0)
    End Sub

    Private Sub LblReceiptNum_TextChanged(sender As Object, e As EventArgs) Handles LblReceiptNum.TextChanged
        LblReceiptNum.Text = Format(Val(LblReceiptNum.Text), "000000")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If ReceiptID = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT(Date,'" & GetDateAndTimeFormat(DTFormat.DF) &
            "') AS [Date],Value,ReceiptName,NoteFor,CkeckNum,PaymentType FROM ReceiptView WHERE ID=" & ReceiptID & " AND EndService IS NULL"
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

        Price = TxtValueChr.Text.Trim()
        Price = NoToTxt(Val(DSPrint.Tables(0).Rows(0).Item(2)), "دينار", "درهم", True)

        Dim F As New FrmPrint
        Dim C As New CRReceipt

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

    Private Sub CmbBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBank.SelectedIndexChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbEmpName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTrusry.SelectedIndexChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbEmpName_TextChanged(sender As Object, e As EventArgs) Handles CmbTrusry.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtReceiptValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtReceiptValue.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtReceiptValue_TextChanged(sender As Object, e As EventArgs) Handles TxtReceiptValue.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window

        'If Val(TxtReceiptValue.Text) > Val(TxtRest.Text) Then 
        '    ' MsgToolReceipt("القيمة المدخلة أكبر من القيمة المستحقة", 0)
        '    TxtReceiptValue.Clear()
        '    TxtReceiptValue.Focus()
        '    TxtValueChr.Text = ""
        '    Exit Sub

        'Else

        If TxtReceiptValue.Text <> vbNullString Then
            TxtValueChr.Text = NoToTxt(Val(TxtReceiptValue.Text), "دينار", "درهم", True)

        Else
            TxtValueChr.Text = vbNullString
        End If

        TxtFinalPrice.Text = Format(Val(TxtReceiptValue.Text) + (Val(TxtReceiptValue.Text) * (Val(TxtPercent.Text) / 100)), "0.00")
        TxtIncreaseValue.Text = Format(Val(TxtFinalPrice.Text) - Val(TxtReceiptValue.Text), "0.00")

        If Val(TxtIncreaseValue.Text) > 0 Then
            TxtIncreaseValue.Visible = True
            PnlIncreaseValue.Visible = True
            ' LblIncreaseValue.Visible = True
            'TxtFinalPrice.Visible = True
            ' LblFinalPrice.Visible = True

        Else
            TxtIncreaseValue.Visible = False
            PnlIncreaseValue.Visible = False
            ' LblIncreaseValue.Visible = False
            'TxtFinalPrice.Visible = False
            ' LblFinalPrice.Visible = False
        End If
        If Val(TxtRest.Text) = Val(TxtReceiptValue.Text) Then
            TxtNoteFor.Text = " دفعة نهائية لغرض تسديد قيمة فاتورة رقم / " & CmbInvoice.Text

        Else
            TxtNoteFor.Text = "دفعة على الحساب. الباقي / " & Val(TxtRest.Text) - Val(TxtReceiptValue.Text) & "  لغرض تسديد قيمة فاتورة رقم / " & CmbInvoice.Text
        End If

        'End If
    End Sub

    Public Sub MsgToolReceipt(MSG As String, Style As Boolean)
        If Style = True Then
            StatusStrip1.BackColor = Color.FromArgb(72, 210, 117)
        ElseIf Style = 0 Then
            StatusStrip1.BackColor = Color.FromArgb(255, 128, 128)
        End If
        SSLMessage.Margin = New Padding(((Me.Width - SSLMessage.Width) / 2), 3, 0, 2)

        SSLMessage.Text = MSG
        SSLMessage.Visible = True

        Timer1.Tag = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Tag >= 1 Then
            Timer1.Tag = Timer1.Tag + 1
        End If
        If Timer1.Tag = 5 Then
            Timer1.Tag = 0
            SSLMessage.Visible = False
            ResetStatusStripBackColor(StatusStrip1)
        End If
    End Sub

    '===========IsEmpty
    Private Function IsEmpty(Container() As Object) As Boolean
        Dim Clr As Color = RedColor ' Color.FromArgb(244, 206, 193)
        For Each C In Container ' Check if it was not a container
            If TypeOf C IsNot GroupBox And TypeOf C IsNot Panel And
                TypeOf C IsNot TableLayoutPanel And
                TypeOf C IsNot SplitterPanel Then Return True
        Next

        Dim IsDataMissing As Boolean

        For Each Cont In Container '---------------------------2---------------------------------------

            Dim Cmb As ComboBox = Nothing
            Dim Txt As TextBox = Nothing
            For Each C As Control In Cont.Controls '----------------------------1---------------------------

                If TypeOf C Is TextBox Then
                    Txt = DirectCast(C, TextBox)

                    If Txt.Text.Trim = "" And Txt.Enabled And Val(Txt.Tag = 0) Then
                        Txt.BackColor = Clr
                        IsDataMissing = True

                    ElseIf Val(Txt.Tag = 10) Then ' TxtPhone
                        If Txt.TextLength < 10 And Txt.TextLength > 0 Then
                            Txt.BackColor = Clr
                            IsDataMissing = True
                        End If
                    End If

                End If

                If TypeOf C Is ComboBox Then
                    Cmb = DirectCast(C, ComboBox)
                    If Cmb.SelectedIndex = -1 And Cmb.Enabled And Val(Cmb.Tag = 0) Then
                        Cmb.BackColor = Clr
                        IsDataMissing = True
                    End If
                End If

            Next '----------------------------------------1------------------------------------------------

        Next '--------------------------------------2---------------------------------------

        Return IsDataMissing

    End Function

    Private Sub DGVReceipt_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVReceipt.CellFormatting
        If DGVReceipt.Rows(e.RowIndex).Cells(6).Value <> Nothing Then
            If e.CellStyle.Format = "d" Then
                e.CellStyle.Format = GetDateAndTimeFormat(DTFormat.DF)
            End If
        End If
    End Sub

    Private Sub CmbInvoice_TextChanged(sender As Object, e As EventArgs) Handles CmbInvoice.TextChanged
        If Val(TxtRest.Text) = Val(TxtReceiptValue.Text) Then
            TxtNoteFor.Text = "دفعة نهائية لغرض تسديد قيمة فاتورة رقم  / " & CmbInvoice.Text

        Else
            TxtNoteFor.Text = "دفعة على الحساب. الباقي / " & Val(TxtRest.Text) - Val(TxtReceiptValue.Text) & " لغرض  تسديد قيمة فاتورة رقم / " & CmbInvoice.Text
        End If
    End Sub
End Class


