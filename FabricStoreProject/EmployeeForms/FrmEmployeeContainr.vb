Public Class FrmEmployeeContainr

    Public LastForm = "FrmEmployeesData"

    Private Sub FrmInfoContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Visible Then Exit Sub
        If LastForm = "FrmEmployeesData" Then
            LblInfo_Click(sender, e)
        ElseIf LastForm = "FrmEmployeesReport" Then
            LblReport_Click(sender, e)
        End If

    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub LblInfo_Click(sender As Object, e As EventArgs) Handles LblInfo.Click

        If FrmEmployeesData.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmEmployeesData.Name})
        OpenFormPnl(FrmEmployeesData, PnlMain, PnlInfo)

        LastForm = "FrmEmployeesData"

    End Sub
    Private Sub LblReport_Click(sender As Object, e As EventArgs) Handles LblReport.Click

        If FrmEmployeesReport.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmEmployeesReport.Name})
        OpenFormPnl(FrmEmployeesReport, PnlMain, PnlAttachments)

        LastForm = "FrmEmployeesReport"

    End Sub

End Class