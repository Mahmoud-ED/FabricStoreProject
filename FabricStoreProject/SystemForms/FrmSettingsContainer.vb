Public Class FrmSettingsContainer

    Private Sub FrmLabContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Visible Then
            Exit Sub
        Else
            LblBackupSettings_Click(sender, e)
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub LblBackupSettings_Click(sender As Object, e As EventArgs) Handles LblBackupSettings.Click
        If FrmBackupSettings.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, FrmMain.Name})
        OpenFormPnl(FrmBackupSettings, PnlMain, PnlBackupSettings)
    End Sub

    Private Sub LblCenterInfoSettings_Click(sender As Object, e As EventArgs) Handles LblCenterInfoSettings.Click
        If FrmCenterInfoSettings.Visible Then Exit Sub
        HideFormsPnl(PnlButtons, {Me.Name, FrmMain.Name})
        OpenFormPnl(FrmCenterInfoSettings, PnlMain, PnlCenterInfoSettings)
    End Sub

End Class