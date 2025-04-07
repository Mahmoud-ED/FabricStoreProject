Public Class FrmPurchasesContainer

    Private LastForm As String = "FrmPurchasesInvoices"

    Private Sub FrmPurchasesContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then

            Select Case LastForm
                Case "FrmPurchasesReport"
                    LblInvoiceReport_Click(LblInvoiceReport, New EventArgs)

                Case "FrmPurchasesInvoices"
                    LblInvoice_Click(LblInvoice, New EventArgs)

                Case "FrmSupplierInvoiceCashing"

                    LblCashing_Click(sender, New EventArgs)
            End Select

        Else
            FrmPurchasesInvoices.BtnNew_Click(sender, e)
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub LblInvoice_Click(sender As Object, e As EventArgs) Handles LblInvoice.Click
        If FrmPurchasesInvoices.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmPurchasesInvoices.Name})
        OpenFormPnl(FrmPurchasesInvoices, PnlMain, PnlInvoice)

        LastForm = "FrmPurchasesInvoices"
    End Sub

    Private Sub LblInvoiceReport_Click(sender As Object, e As EventArgs) Handles LblInvoiceReport.Click
        If FrmPurchasesReport.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmPurchasesReport.Name})
        OpenFormPnl(FrmPurchasesReport, PnlMain, PnlInvoReport)

        LastForm = "FrmPurchasesReport"
    End Sub

    Private Sub LblCashing_Click(sender As Object, e As EventArgs) Handles LblCashing.Click
        If FrmSupplierInvoiceCashing.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmSupplierInvoiceCashing.Name})
        OpenFormPnl(FrmSupplierInvoiceCashing, PnlMain, PnlCashing)

        LastForm = "FrmSupplierInvoiceCashing"
    End Sub
End Class