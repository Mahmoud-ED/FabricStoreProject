Public Class FrmMangmentExpensesContainer

    Private LastForm As String = "FrmManagementExpenses"

    Private Sub FrmExpensesContainer_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Visible Then

            Select Case LastForm
                Case "FrmManagementExpenses"
                    LblExpenses_Click(LblExpenses, New EventArgs)

                Case "FrmManagementExpensesReport"
                    LblExpensesReport_Click(LblExpensesReport, New EventArgs)

            End Select

        End If

    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub LblExpenses_Click(sender As Object, e As EventArgs) Handles LblExpenses.Click

        If FrmMangmentExpenses.Visible Then Exit Sub
        HideFormsPnl(PnlTop, {Me.Name, FrmMain.Name})
        OpenFormPnl(FrmMangmentExpenses, PnlMain, PnlExpenses)
        LastForm = "FrmManagementExpenses"

    End Sub

    Private Sub LblExpensesReport_Click(sender As Object, e As EventArgs) Handles LblExpensesReport.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=2")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        If FrmMangmentExpensesReport.Visible Then Exit Sub
        HideFormsPnl(PnlTop, {Me.Name, FrmMain.Name})
        OpenFormPnl(FrmMangmentExpensesReport, PnlMain, PnlExpensesReport)
        LastForm = "FrmManagementExpensesReport"

    End Sub

End Class