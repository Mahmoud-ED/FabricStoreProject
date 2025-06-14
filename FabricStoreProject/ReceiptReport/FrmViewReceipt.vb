Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmViewReceipt
    Private DsReceipt As DataSet
    Public ReceiptID As Integer


    Private Sub FrmViewReceipt_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetData()
    End Sub

    Private Sub GetData()
        If ReceiptID = 0 Then Exit Sub
        Dim sqlcon As New SQLConClass()
        SQLQuery = " SELECT dbo.ReceiptTable.ID, dbo.ReceiptFinanceTypeTable.Name as FinanceName, dbo.ReceiptTable.Num, dbo.ReceiptTable.ReceiptName, dbo.UserView.Name AS UserName, dbo.ReceiptTable.Value, dbo.ReceiptTable.NoteFor AS Nots, 
                      dbo.ReceiptTable.Date , ReceiptTable.IncreaseValue
    FROM     dbo.PaymentTypeTable INNER JOIN
                      dbo.ReceiptTable ON dbo.PaymentTypeTable.ID = dbo.ReceiptTable.PaymentTypeID INNER JOIN
                      dbo.UserView ON dbo.ReceiptTable.UserID = dbo.UserView.ID INNER JOIN
                      dbo.ReceiptFinanceTypeTable ON dbo.ReceiptTable.ReceiptFinanceTypeID = dbo.ReceiptFinanceTypeTable.ID
    WHERE  (dbo.ReceiptTable.EndService IS NULL) and  ReceiptTable.ID= " & ReceiptID
        DsReceipt = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DsReceipt) Then
            Display()
        End If
    End Sub

    Private Sub Display()

        With DsReceipt.Tables(0).Rows(0)
            TxtNum.Text = Format(.Item("Num"), "000000")
            TxtFinanec.Text = .Item("FinanceName")
            TxtNots.Text = .Item("Nots")
            TxtReciptName.Text = .Item("ReceiptName")
            TxtUserName.Text = .Item("UserName")
            TxtValue.Text = Format(.Item("Value"), "0.00")
            LblDate.Text = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DF))
            TxtInsurValue.Text = Format(.Item("IncreaseValue"), "0.00")
        End With

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Clear(GrpInfo)
        ReceiptID = 0
        DsReceipt.Clear()
        Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(5) = False Then
        '    MsgTool("ليس لديك صلاحية الحذف", 0)
        '    Exit Sub
        'End If
        If ReceiptID = 0 Then Exit Sub

        If MsgBox("هل تريد بالتأكيد الإلغاء ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "تأكيد الإلغاء") = MsgBoxResult.Yes Then

            Dim sqlcon As New SQLConClass()


            'SQLQuery = " Update ReceiptTable set EndService =GetDate() where ID=" & ReceiptID
            'Dim ds As DataSet
            Dim Param() As SqlParameter = {
                New SqlParameter("ID", ReceiptID)}
            Save = sqlcon.CMDExecute("DeleteReceipt", 1, Param)
            If Save = 1 Then
                MsgTool("تم إلغاء الايصال بنجاح", 1)
            ElseIf Save = 2 Then
                MsgTool("لايمكن حذف الايصال ,تم اغلاق المناوبة", 0)
            End If
            Clear(GrpInfo)
            ReceiptID = 0
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

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub

        'End If
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

        Price = NoToTxt(DSPrint.Tables(0).Rows(0).Item(2), "دينار", "درهم", True)

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

    Private Sub TxtValue_TextChanged(sender As Object, e As EventArgs) Handles TxtValue.TextChanged
        If TxtValue.Text <> vbNullString Then
            TxtValueLeter.Text = NoToTxt(Val(TxtValue.Text), "دينار", "درهم", True)

        Else
            TxtValueLeter.Text = vbNullString
        End If

    End Sub

    Private Sub FrmViewReceipt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(DsReceipt) Then
            DsReceipt.Clear()
        End If
    End Sub

    Private Sub TxtValue_Click(sender As Object, e As EventArgs) Handles TxtValue.Click

    End Sub
End Class