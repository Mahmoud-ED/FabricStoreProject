Public Class FrmBasicData

    Private LastForm As String = "FrmBank"

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmBasicData_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then

            Select Case LastForm
                Case "FrmBank"
                    LblBank_Click(LblBank, New EventArgs)

                Case "FrmPaymentType"
                    LblPaymentType_Click(LblPaymentType, New EventArgs)

                Case "FrmCountry"
                    LblCountry_Click(LblCountry, New EventArgs)

                Case "FrmServices"
                    LblServices_Click(LblServices, New EventArgs)

                Case "FrmExpensesType"
                    LblExpensesType_Click(LblExpensesType, New EventArgs)
            End Select

        Else
        End If
    End Sub

    Private Sub LblBank_Click(sender As Object, e As EventArgs) Handles LblBank.Click
        If FrmBank.Visible Then Exit Sub
        HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        OpenFormPnl(FrmBank, PnlMain, PnlBank)
        LastForm = "FrmBank"
    End Sub

    Private Sub LblPaymentType_Click(sender As Object, e As EventArgs) Handles LblPaymentType.Click
        If FrmPaymentType.Visible Then Exit Sub
        HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        OpenFormPnl(FrmPaymentType, PnlMain, PnlPaymentType)
        LastForm = "FrmPaymentType"
    End Sub

    Private Sub LblCountry_Click(sender As Object, e As EventArgs) Handles LblCountry.Click
        If FrmCountry.Visible Then Exit Sub
        HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        OpenFormPnl(FrmCountry, PnlMain, PnlCountry)
        LastForm = "FrmCountry"
    End Sub

    Private Sub LblServices_Click(sender As Object, e As EventArgs) Handles LblServices.Click
        'If FrmServices.Visible Then Exit Sub
        'HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        'OpenFormPnl(FrmServices, PnlMain, PnlServices)
        'LastForm = "FrmServices"
    End Sub

    Private Sub LblExpensesType_Click(sender As Object, e As EventArgs) Handles LblExpensesType.Click
        If FrmExpensesType.Visible Then Exit Sub
        HideFormsPnl(PnlTop, {Me.Name, Frmmain.Name})
        OpenFormPnl(FrmExpensesType, PnlMain, PnlExpensesType)
        LastForm = "FrmExpensesType"
    End Sub

End Class