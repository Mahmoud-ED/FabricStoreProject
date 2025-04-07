Public Class FrmReceiptContainer
    Private LastForm As String = "FrmReceiptReport"

    Private Sub FrmReceiptContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then

            Select Case LastForm
                Case "FrmReceiptReport"
                    LblReceipt_Click(LblReceipt, New EventArgs)

                Case "FrmCashingReport"
                    LblCashing_Click(LblCashing, New EventArgs)
            End Select

        Else
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub LblReceipt_Click(sender As Object, e As EventArgs) Handles LblReceipt.Click
        If FrmReceiptReport.Visible Then Exit Sub
        HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        OpenFormPnl(FrmReceiptReport, PnlMain, PnlReceipt)
        LastForm = "FrmReceiptReport"
    End Sub

    Private Sub LblCashing_Click(sender As Object, e As EventArgs) Handles LblCashing.Click
        If FrmCashingReport.Visible Then Exit Sub
        HideFormsPnl(PnlTop, {Me.Name, FrmMain.Name})
        OpenFormPnl(FrmCashingReport, PnlMain, PnlCashing)
        LastForm = "FrmCashingReport"
    End Sub
End Class