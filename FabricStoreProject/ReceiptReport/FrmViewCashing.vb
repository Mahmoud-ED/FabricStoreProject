Imports System.ComponentModel

Public Class FrmViewCashing
    Private DsCashing As DataSet
    Public CashID As Integer


    Private Sub FrmViewCashing_Load(sender As Object, e As EventArgs) Handles Me.Load
        '  DTPDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
        ChangeSystemColors(Me)
        GetData()
    End Sub

    Private Sub GetData()
        If CashID = 0 Then Exit Sub
        Dim sqlcon As New SQLConClass()
        SQLQuery = " SELECT dbo.CashingTable.ID, dbo.CashingFinanceTypeTable.Name AS FinanceName, dbo.CashingTable.Num, dbo.CashingTable.ReceiptName, 
                    dbo.UserView.Name AS UserName, dbo.CashingTable.Value, dbo.CashingTable.Notes ,CashingTable.Date
                    FROM dbo.CashingTable INNER JOIN
                      dbo.PaymentTypeTable ON dbo.CashingTable.PaymentTypeID = dbo.PaymentTypeTable.ID INNER JOIN
                      dbo.UserView ON dbo.CashingTable.UserID = dbo.UserView.ID INNER JOIN
                      dbo.CashingFinanceTypeTable ON dbo.CashingTable.CashingFinanceTypeID = dbo.CashingFinanceTypeTable.ID
                    WHERE  (dbo.CashingTable.EndService IS NULL) And CashingTable.ID= " & CashID
        DsCashing = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DsCashing) Then
            Display()
        End If
    End Sub

    Private Sub Display()

        With DsCashing.Tables(0).Rows(0)
            TxtNum.Text = Format(.Item("Num"), "000000")
            TxtFinanec.Text = .Item("FinanceName")
            TxtNots.Text = .Item("Notes")
            TxtReciptName.Text = .Item("ReceiptName")
            TxtUserName.Text = .Item("UserName")
            TxtValue.Text = Format(.Item("Value"), "0.00")
            LblDate.Text = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DF))

        End With

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Clear(GrpInfo)
        CashID = 0
        DsCashing.Clear()
        Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=32")

        'If Perm(0)(5) = False Then
        '    MsgTool("ليس لديك صلاحية الحذف", 0)
        '    Exit Sub
        'End If
        If MsgBox("هل تريد بالتأكيد الإلغاء ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "تأكيد الإلغاء") = MsgBoxResult.Yes Then

            If CashID = 0 Then Exit Sub
            Dim sqlcon As New SQLConClass()
            SQLQuery = " Update CashingTable set EndService =GetDate() where ID=" & CashID

            Dim ds As DataSet
            ds = sqlcon.SelectData(SQLQuery, 0, Nothing)
            MsgTool("تم إلغاء الايصال بنجاح", 1)
            Clear(GrpInfo)
            CashID = 0
            Me.Dispose()
        End If

    End Sub

    Private Sub PnlTitel_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseDown, LblTitel.MouseDown
        If e.Button = MouseButtons.Left Then
            SW = True
            Pos = e.Location
        End If
    End Sub

    Private Sub PnlTitel_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseMove, LblTitel.MouseMove
        If SW Then
            Me.Location += e.Location - Pos
        End If
    End Sub

    Private Sub PnlTitel_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseUp, LblTitel.MouseUp
        If e.Button = MouseButtons.Left Then
            SW = False
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=32")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If CashID = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT(Date,'" & GetDateAndTimeFormat(DTFormat.DF) &
            "') AS [Date],Value,ReceiptName,Notes,CheckNum,PaymentTypeName FROM CashingView WHERE ID=" & CashID
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        Dim Check As String
        Dim Cash As String
        Dim Price As String

        Dim Value
        If Not IsDBNull(DSPrint.Tables(0).Rows(0).Item(2)) Then
            Value = Format(DSPrint.Tables(0).Rows(0).Item(2), "0.00")
        Else
            Value = 0
        End If

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

    Private Sub TxtValue_TextChanged(sender As Object, e As EventArgs) Handles TxtValue.TextChanged
        If TxtValue.Text <> vbNullString Then
            TxtValueLeter.Text = NoToTxt(Val(TxtValue.Text), "دينار", "درهم", True)

        Else
            TxtValueLeter.Text = vbNullString
        End If

    End Sub

    Private Sub FrmViewCashing_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(DsCashing) Then
            DsCashing.Clear()
        End If
    End Sub
End Class