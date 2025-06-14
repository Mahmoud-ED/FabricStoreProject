Public Class FrmSupplierInvoiceCashingShow
    Private Sub FrmSupplierInvoiceCashingShow_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

    End Sub

    Private Sub FrmSupplierInvoiceCashingShow_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If FrmSupplierInvoiceCashing.Visible Then Exit Sub
        FrmSupplierInvoiceCashing.Visible = True
        FrmSupplierInvoiceCashing.TopLevel = False
        FrmSupplierInvoiceCashing.Parent = PnlMain
        FrmSupplierInvoiceCashing.Dock = DockStyle.Fill

        OpenFormPnl(FrmSupplierInvoiceCashing, PnlMain)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub PnlMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseDown, LblTitle.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub PnlMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseMove, LblTitle.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Private Sub PnlMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseUp, LblTitle.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub PnlMenu_DoubleClick(sender As Object, e As EventArgs) Handles PnlMenu.DoubleClick
        'BtnMax.PerformClick()
    End Sub

    'Private Sub BtnMax_Click(sender As Object, e As EventArgs)
    '    If WindowState = FormWindowState.Maximized Then
    '        WindowState = FormWindowState.Normal
    '    Else
    '        WindowState = FormWindowState.Maximized
    '    End If
    'End Sub

End Class