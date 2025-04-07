Public Class FrmSuppleirContainer

    Public LastForm = "FrmSuppleirData"

    Private Sub FrmSuppleirContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Visible Then Exit Sub
        If LastForm = "FrmSuppleirData" Then
            LblInfo_Click(sender, e)
        ElseIf LastForm = "FrmSuppleirReport" Then
            LblReport_Click(sender, e)
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub LblInfo_Click(sender As Object, e As EventArgs) Handles LblInfo.Click
        If FrmSuppleir.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmEmployeesData.Name, FrmSuppleir.Name})
        OpenFormPnl(FrmSuppleir, PnlMain, PnlInfo)

        LastForm = "FrmSuppleirData"
    End Sub

    Private Sub LblReport_Click(sender As Object, e As EventArgs) Handles LblReport.Click
        If FrmSuppleirReport.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmSuppleirReport.Name})
        OpenFormPnl(FrmSuppleirReport, PnlMain, PnlAttachments)

        LastForm = "FrmSuppleirReport"
    End Sub
End Class