Public Class FrmSalesContainer

    Private LastForm As String = "FrmSales"

    Private Sub FrmSalesContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then

            Select Case LastForm
                Case "FrmSalesReport"
                    LblInvoiceReport_Click(LblInvoiceReport, New EventArgs)

                Case "FrmSales"
                    LblInvoice_Click(LblInvoice, New EventArgs)

                Case "FrmCustomerInvoiceReceipt"

                    LblReceipt_Click(sender, New EventArgs)

                Case "FrmCustomerOrders"
                    LblCustomerOrders_Click(sender, New EventArgs)
            End Select

        Else
            FrmPurchasesInvoices.BtnNew_Click(sender, e)
        End If
    End Sub


    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub LblInvoice_Click(sender As Object, e As EventArgs) Handles LblInvoice.Click
        If FrmSales.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmSales.Name})
        OpenFormPnl(FrmSales, PnlMain, PnlInvoice)

        LastForm = "FrmSales"
    End Sub

    Private Sub LblInvoiceReport_Click(sender As Object, e As EventArgs) Handles LblInvoiceReport.Click
        If FrmSalesReport.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmSalesReport.Name})
        OpenFormPnl(FrmSalesReport, PnlMain, PnlInvoReport)

        LastForm = "FrmSalesReport"
    End Sub

    Public Sub LblDebts_Click(sender As Object, e As EventArgs) Handles LblDebts.Click
        If FrmCustomerInvoiceReceipt.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmCustomerInvoiceReceipt.Name})
        OpenFormPnl(FrmCustomerInvoiceReceipt, PnlMain, PnlDebts)

        LastForm = "FrmCustomerInvoiceReceipt"
    End Sub

    Private Sub LblReceipt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblCustomerOrders_Click(sender As Object, e As EventArgs) Handles LblCustomerOrders.Click
        If FrmCustomerOrders.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmCustomerOrders.Name})
        OpenFormPnl(FrmCustomerOrders, PnlMain, PnlCustomerOrders)

        LastForm = "FrmCustomerOrders"
    End Sub
End Class