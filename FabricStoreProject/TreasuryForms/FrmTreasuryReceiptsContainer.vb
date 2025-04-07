Public Class FrmTreasuryReceiptsContainer

    Private LastForm As String = "FrmReceipt"


    Private Sub FrmTreasuryReceiptsContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then

            Select Case LastForm
                Case "FrmReceipt"
                    LblReceipt_Click(LblReceipt, New EventArgs)
                Case "FrmCashing"
                    LblCashing_Click(LblCashing, New EventArgs)
                Case "FrmReports"
                    LblReports_Click(LblReports, New EventArgs)
            End Select

        Else
            FrmEmployeeReceipt.BtnRefresh_Click(sender, e)
            FrmEmployeeCashing.BtnRefresh_Click(sender, e)
            FrmEmployeeCashingReport.BtnNew_Click(sender, e)

        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub LblReceipt_Click(sender As Object, e As EventArgs) Handles LblReceipt.Click
        HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        OpenFormPnl(FrmEmployeeReceipt, PnlMain, PnlReceipt)
        LastForm = "FrmReceipt"
    End Sub

    Public Sub LblCashing_Click(sender As Object, e As EventArgs) Handles LblCashing.Click
        HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        OpenFormPnl(FrmEmployeeCashing, PnlMain, PnlCashing)
        LastForm = "FrmCashing"
    End Sub

    Private Sub LblReports_Click(sender As Object, e As EventArgs) Handles LblReports.Click

        'HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        'OpenFormPnl(FrmTreasuryReceiptReport, PnlMain, PnlReports)
        'LastForm = "FrmReports"


        HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        OpenFormPnl(FrmEmployeeCashingReport, PnlMain, PnlReports)

        LastForm = "FrmReports"


    End Sub
End Class