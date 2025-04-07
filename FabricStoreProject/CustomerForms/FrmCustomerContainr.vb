Public Class FrmCustomerContainr


    Public LastForm = "FrmCustomers"

    Private Sub FrmCustomerContainr_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Visible Then Exit Sub
        If LastForm = "FrmCustomers" Then
            LblInfo_Click(sender, e)
        ElseIf LastForm = "FrmCustomerReport" Then
            LblReport_Click(sender, e)
        End If

    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub LblInfo_Click(sender As Object, e As EventArgs) Handles LblInfo.Click

        If FrmCustomers.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmCustomers.Name})
        OpenFormPnl(FrmCustomers, PnlMain, PnlInfo)

        LastForm = "FrmCustomers"

    End Sub

    Private Sub LblReport_Click(sender As Object, e As EventArgs) Handles LblReport.Click

        If FrmCustomerReport.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmCustomerReport.Name})
        OpenFormPnl(FrmCustomerReport, PnlMain, PnlAttachments)

        LastForm = "FrmCustomerReport"

    End Sub

End Class