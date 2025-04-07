Public Class FrmDeliveryContainr

    Public LastForm = "FrmDeliveryCo"

    Private Sub FrmDeliveryContainr_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Visible Then Exit Sub
        If LastForm = "FrmDeliveryCo" Then
            LblInfo_Click(sender, e)

        ElseIf LastForm = "FrmDeliveryReport" Then
            LblReport_Click(sender, e)

        ElseIf LastForm = "FrmDeliveryOrder" Then
            LblDeliveryOrder_Click(sender, e)
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub LblInfo_Click(sender As Object, e As EventArgs) Handles LblInfo.Click

        If FrmDeliveryCo.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmDeliveryCo.Name})
        OpenFormPnl(FrmDeliveryCo, PnlMain, PnlInfo)

        LastForm = "FrmDeliveryCo"

    End Sub

    Private Sub LblReport_Click(sender As Object, e As EventArgs) Handles LblReport.Click

        If FrmDeliveryReport.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmDeliveryReport.Name})
        OpenFormPnl(FrmDeliveryReport, PnlMain, PnlAttachments)

        LastForm = "FrmDeliveryReport"

    End Sub

    Private Sub LblDeliveryOrder_Click(sender As Object, e As EventArgs) Handles LblDeliveryOrder.Click
        If FrmDeliveryOrder.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmDeliveryOrder.Name})
        OpenFormPnl(FrmDeliveryOrder, PnlMain, PnlDeliveryOrder)

        LastForm = "FrmDeliveryOrder"
    End Sub
End Class