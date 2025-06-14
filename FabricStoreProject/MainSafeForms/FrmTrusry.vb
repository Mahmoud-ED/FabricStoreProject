Imports System.Data.SqlClient

Public Class FrmTrusry
    Public TrustyID As Integer

    Private Sub FrmTrusry_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        DTPDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
        GetData()
    End Sub


    Private Sub GetData()

        Dim sqlcon As New SQLConClass

        If TrustyID = 0 Then
            SQLQuery = " select ISNULL(Max(NUM),0)+1 from TrusryTable  "

            SQLQuery += " select * from ReceiptView where TrusryTypeID=1 order by Date Desc "
            SQLQuery += " select * from CashingView where TrusryTypeID=1   order by Date Desc "
            SQLQuery += " select ISNULL(SUM(Value),0) from ReceiptView where TrusryTypeID=1  and PaymentTypeID =1   "
            SQLQuery += " select ISNULL(SUM(Value),0) from ReceiptView where TrusryTypeID=1  and PaymentTypeID <>1   "
        Else
            SQLQuery = " select * from TrusryView where ID=  " & TrustyID
            SQLQuery += " select * from ReceiptView where ID in (select ReceiptID from TrusryReceiptTable where TrusryID=" & TrustyID & " ) order by Date Desc "
            SQLQuery += " select * from CashingView where  ID in (select CashingID from TrusryCashingTable where TrusryID=" & TrustyID & " )   order by Date Desc "
            SQLQuery += " select ISNULL(SUM(Value),0) from ReceiptView where ID in (select ReceiptID from TrusryReceiptTable where TrusryID=" & TrustyID & " )  and PaymentTypeID =1   "
            SQLQuery += " select ISNULL(SUM(Value),0) from ReceiptView where ID in (select ReceiptID from TrusryReceiptTable where TrusryID=" & TrustyID & " )  and PaymentTypeID <>1   "

        End If
        Dim Ds As DataSet
        Ds = sqlcon.SelectData(SQLQuery)
        If DSHasTables(Ds) Then

            If TrustyID = 0 Then
                LblNUM.Text = Ds.Tables(0).Rows(0).Item(0)
                FillDGVReceipt(Ds.Tables(1))
                FillDGVCashing(Ds.Tables(2))
                LblCash.Text = Ds.Tables(3).Rows(0).Item(0)
                LblCard.Text = Ds.Tables(4).Rows(0).Item(0)
                TxtNots.Text = ""
                LblTotal.Text = Val(LblCash.Text) - Val(TxtCashing.Text)
                TxtPaid.Text = Val(LblTotal.Text)
                lblUser.Text = UserName
            End If

            If TrustyID <> 0 Then

                LblNUM.Text = Ds.Tables(0).Rows(0).Item("NUM")
                FillDGVReceipt(Ds.Tables(1))
                FillDGVCashing(Ds.Tables(2))
                LblCash.Text = Ds.Tables(0).Rows(0).Item("Value")
                LblCard.Text = Ds.Tables(0).Rows(0).Item("CardValue")
                LblTotal.Text = Val(LblCash.Text) - Val(TxtCashing.Text)
                TxtPaid.Text = Ds.Tables(0).Rows(0).Item("Paid")
                TxtCashing.Text = Ds.Tables(0).Rows(0).Item("Expenses")
                lblUser.Text = Ds.Tables(0).Rows(0).Item("Name").ToString
                TxtNots.Text = Ds.Tables(0).Rows(0).Item("Nots")
                DTPDate.Value = Ds.Tables(0).Rows(0).Item("Date1")
            End If
        End If

    End Sub
    Private Sub FillDGVCashing(Dt As DataTable)
        DGVCashing.Rows.Clear()
        TxtCashing.Text = "0.0"
        For i = 0 To Dt.Rows.Count - 1
            With Dt.Rows(i)
                DGVCashing.Rows.Add()
                DGVCashing.Item(0, i).Value = .Item("ID")
                DGVCashing.Item(1, i).Value = i + 1
                DGVCashing.Item(2, i).Value = .Item("FinanceType")
                DGVCashing.Item(3, i).Value = Format(.Item("NUM"), "00000")
                DGVCashing.Item(4, i).Value = .Item("Value")
                DGVCashing.Item(5, i).Value = .Item("PaymentTypeName")
                DGVCashing.Item(6, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DTF))
                DGVCashing.Item(7, i).Value = .Item("ReceiptName")
                DGVCashing.Item(8, i).Value = .Item("Notes")
                TxtCashing.Text = Val(TxtCashing.Text) + .Item("Value")
            End With
        Next
        DGVCashing.ClearSelection()
    End Sub


    Private Sub FillDGVReceipt(Dt As DataTable)
        DGVInvoice.Rows.Clear()
        LblReceipt.Text = "0.0"
        For i = 0 To Dt.Rows.Count - 1
            With Dt.Rows(i)
                DGVInvoice.Rows.Add()
                DGVInvoice.Item(0, i).Value = .Item("ID")
                DGVInvoice.Item(2, i).Value = i + 1
                DGVInvoice.Item(3, i).Value = Format(.Item("NUM"), "00000")
                DGVInvoice.Item(4, i).Value = .Item("Value")
                DGVInvoice.Item(5, i).Value = .Item("PaymentType")
                DGVInvoice.Item(6, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DTF))
                'DGVInvoice.Item(7, i).Value = .Item("UserName")
                DGVInvoice.Item(8, i).Value = .Item("NoteFor")
                LblReceipt.Text = Val(LblReceipt.Text) + .Item("Value")
            End With
        Next
        DGVInvoice.ClearSelection()
    End Sub

    Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
        Dim param() As SqlParameter = {
            New SqlParameter("TrustyID", TrustyID),
            New SqlParameter("UserID", UserID),
            New SqlParameter("Date", DTPDate.Value),
            New SqlParameter("Nots", TxtNots.Text.Trim),
            New SqlParameter("Cash", Val(LblCash.Text)),
            New SqlParameter("Card", Val(LblCard.Text)),
            New SqlParameter("Expenses", Val(TxtCashing.Text)),
            New SqlParameter("Paid", Val(TxtPaid.Text))
        }
        Dim sqlcon As New SQLConClass
        Dim Ds As DataSet

        Ds = sqlcon.CMDExecuteData("CloseTrusry", param)
        MsgBox("تم ترحيل المبلغ الى الخزينة الرئيسية", MsgBoxStyle.OkOnly, "اشعار")
        Dim SQLCon1 = New SQLConClass

        Dim DSReport As New DataSet
        SQLQuery = " SELECT *,Format(Date1,'yyyy-MM-dd HH:mm') as Date FROM TrusryView where ID=" & Ds.Tables(0).Rows(0).Item(0)

        DSReport = SQLCon1.SelectData(SQLQuery, 0, Nothing)

        Dim F As New FrmPrint
        'Dim C As New CrTrusry

        'C.SetDataSource(DSReport.Tables(0))
        'F.CrystalReportViewer1.ReportSource = C
        'F.CrystalReportViewer1.Refresh()
        'F.Text = "طباعة"
        'F.CrystalReportViewer1.Zoom(100%)
        'F.WindowState = FormWindowState.Maximized
        'F.Show()
        'Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
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

End Class