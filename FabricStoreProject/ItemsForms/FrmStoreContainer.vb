Public Class FrmStoreContainer
    Private LastForm As String = "FrmAddItem"

    Private Sub FrmStoreContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then

            Select Case LastForm
                Case "FrmItemReport"
                    LblItemReport_Click(sender, New EventArgs)

                Case "FrmAddItem"
                    LblItem_Click(sender, New EventArgs)

                Case "FrmStore"

                    LblStore_Click(sender, New EventArgs)

                Case "FrmPreparingClothes"
                    LblMadeClothes_Click(sender, New EventArgs)
                Case "FrmPreparingClothesReport"
                    LblReport_Click(sender, New EventArgs)
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

    Private Sub LblMadeClothes_Click(sender As Object, e As EventArgs) Handles LblMadeClothes.Click
        If FrmPreparingClothes.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmPreparingClothes.Name})
        OpenFormPnl(FrmPreparingClothes, PnlMain, PnlMadeClothes)

        LastForm = "FrmPreparingClothes"
    End Sub

    Private Sub LblReport_Click(sender As Object, e As EventArgs) Handles LblReport.Click
        If FrmPreparingClothesReport.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, Frmmain.Name, FrmPreparingClothesReport.Name})
        OpenFormPnl(FrmPreparingClothesReport, PnlMain, PnlReport)

        LastForm = "FrmPreparingClothesReport"
    End Sub
End Class