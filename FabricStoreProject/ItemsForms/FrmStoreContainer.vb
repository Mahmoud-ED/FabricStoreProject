Public Class FrmStoreContainer
    Private LastForm As String = "FrmPurchasesInvoices"

    Private Sub FrmStoreContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then

            Select Case LastForm
                Case "FrmPurchasesReport"
                    LblItemReport_Click(sender, New EventArgs)

                Case "FrmAddItem"
                    LblStore_Click(sender, New EventArgs)

                Case "FrmSupplierInvoiceCashing"

                    LblStore_Click(sender, New EventArgs)
            End Select

        Else
            FrmAddItem.BtnRefresh_Click(sender, e)
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub LblItem_Click(sender As Object, e As EventArgs) Handles LblItem.Click
        If FrmAddItem.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmAddItem.Name})
        OpenFormPnl(FrmAddItem, PnlMain, PnlItem)

        LastForm = "FrmAddItem"
    End Sub

    Private Sub LblItemReport_Click(sender As Object, e As EventArgs) Handles LblItemReport.Click
        If FrmItemReport.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmItemReport.Name})
        OpenFormPnl(FrmItemReport, PnlMain, PnlItemReport)

        LastForm = "FrmItemReport"
    End Sub

    Private Sub LblStore_Click(sender As Object, e As EventArgs) Handles LblStore.Click
        If FrmStore.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmStore.Name})
        OpenFormPnl(FrmStore, PnlMain, PnlStore)

        LastForm = "FrmStore"
    End Sub
End Class