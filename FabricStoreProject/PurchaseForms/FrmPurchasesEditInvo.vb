Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmPurchasesEditInvo

    Private CR As Integer = -1
    Private Ds As DataSet
    Public PurchasesID, ID As Integer




    Private Sub FrmPurchasesEditInvo_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetData()
    End Sub

    Private Sub FrmPurchasesEditInvo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(Ds) Then
            Ds.Clear()
        End If

        TxtSumValue.Text = "0"
        TxtName.Text = ""
        TxtPurchasPrice.Text = ""
        TxtQuantity.Text = ""
        Dispose()
    End Sub

    Private Sub GetData()
        If PurchasesID = 0 Then Exit Sub
        Dim sqlcon As New SQLConClass()
        SQLQuery = " SELECT *  FROM PurchaseContentsView where PurchasesID=" & PurchasesID
        SQLQuery &= " Select ID, Total, Num, Name, [User]  From PurchasesView where ID=" & PurchasesID
        Ds = sqlcon.SelectData(SQLQuery)
        If DSHasTables(Ds) Then
            FillDGV()
            TxtSupplier.Text = Ds.Tables(1).Rows(0).Item("Name")
            If Val(Ds.Tables(1).Rows(0).Item("Total")) > 0 Then
                TxtSumValue.Text = Format(Ds.Tables(1).Rows(0).Item("Total"), "0.00")

            Else
                TxtSumValue.Text = "0"
            End If

            TxtInvoNum.Text = Format(Ds.Tables(1).Rows(0).Item("Num"), "000000")
            LblTitel.Text = " محتويات الفاتورة رقم - " + TxtInvoNum.Text
        End If
    End Sub

    Private Sub FillDGV()
        DGVInvoContent.Rows.Clear()
        For i = 0 To Ds.Tables(0).Rows.Count - 1
            With Ds.Tables(0).Rows(i)

                DGVInvoContent.Rows.Add()

                DGVInvoContent.Item(0, i).Value = .Item("ID")
                DGVInvoContent.Item(1, i).Value = i + 1
                DGVInvoContent.Item(2, i).Value = Format(.Item("itemNum"), "000000")
                DGVInvoContent.Item(3, i).Value = .Item("Name")
                DGVInvoContent.Item(4, i).Value = Format(.Item("Price"), "0.00")
                DGVInvoContent.Item(5, i).Value = .Item("Quantity")
                DGVInvoContent.Item(6, i).Value = Format(.Item("Total"), "0.00")

            End With
        Next
        DGVInvoContent.ClearSelection()
    End Sub

    Private Sub DGVInvoContent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInvoContent.CellContentClick

    End Sub

    Private Sub DGVInvoContent_Click(sender As Object, e As EventArgs) Handles DGVInvoContent.Click
        If CheckDGVError(DGVInvoContent) Then Exit Sub
        If DGVInvoContent.Rows.Count = 0 OrElse DGVInvoContent.CurrentRow Is Nothing Then Exit Sub

        CR = DGVInvoContent.CurrentRow.Index

        If DGVInvoContent.Rows(CR).Cells(1).Value Is Nothing Then
            Exit Sub
        End If
        displaY(CR)
    End Sub

    Private Sub displaY(CR As Integer)
        With DGVInvoContent
            ID = .Item(0, CR).Value
            TxtName.Text = .Item(3, CR).Value
            TxtQuantity.Text = .Item(5, CR).Value
            TxtPurchasPrice.Text = .Item(4, CR).Value

        End With
    End Sub

    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
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

    Private Sub TxtPurchasPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtPurchasPrice.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPurchasPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPurchasPrice.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantity.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQuantity.KeyPress
        e.Handled = Not IsNumberOnly(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        IsDataMissing = False
        IsInputEmpty(TLPData)

        If IsDataMissing = True Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim SQLCon = New SQLConClass
        Dim DSInvo As New DataSet
        Dim Param() As SqlParameter = {
            New SqlParameter("@Price", Val(TxtPurchasPrice.Text)),
            New SqlParameter("@Quantity", Val(TxtQuantity.Text)),
            New SqlParameter("@ID", ID),
            New SqlParameter("@InvoID", PurchasesID)
        }
        DSInvo = SQLCon.CMDExecuteData("EditPurchaseInvoice", Param)

        FrmPurchasesEditInvo_Load(sender, e)
    End Sub

    Private Sub TxtPurchasPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPurchasPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtQuantity.Focus()
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=99")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If PurchasesID = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = " SELECT ID, FORMAT(Num,'000000') AS Num, Date, Name, [User],Total FROM PurchasesView  WHERE ID=" & PurchasesID
        SQLQuery &= " Select * From PurchaseContentsView Where PurchasesID=" & PurchasesID
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        Dim F As New FrmPrint
        Dim C As New CRPurchasesInvoice

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(2))
        C.Subreports(2).SetDataSource(DSPrint.Tables(2))
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()

    End Sub

    Private Sub TxtQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave_Click(sender, e)
        End If
    End Sub
End Class