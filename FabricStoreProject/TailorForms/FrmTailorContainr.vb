Public Class FrmTailorContainr

    Public LastForm = "FrmTailors"


    Private Sub FrmTailorContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Visible Then Exit Sub
        If LastForm = "FrmTailors" Then
            LblInfo_Click(sender, e)
        ElseIf LastForm = "FrmTailorReport" Then
            LblReport_Click(sender, e)
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub LblInfo_Click(sender As Object, e As EventArgs) Handles LblInfo.Click

        If FrmTailors.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmTailors.Name})
        OpenFormPnl(FrmTailors, PnlMain, PnlInfo)

        LastForm = "FrmTailors"

    End Sub

    Private Sub LblReport_Click(sender As Object, e As EventArgs) Handles LblReport.Click

        If FrmTailorReport.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmTailorReport.Name})
        OpenFormPnl(FrmTailorReport, PnlMain, PnlAttachments)

        LastForm = "FrmTailorReport"

    End Sub

End Class