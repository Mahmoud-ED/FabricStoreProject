Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class FrmService

    Private DS As New DataSet
    Private ServiceID As Integer
    Private CR As Integer = -1


    Private Sub FrmService_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetFillData()
        SetDGVHeader()
        TxtService.Select()
        TxtService.Focus()
    End Sub

    Private Sub GetFillData()
        Dim SQLCon = New SQLConClass
        SQLQuery = "Select ID ,Row_Number() Over(Order By(Select 1)) ت, Name From ServicesTable Order By Name"
        DS = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DS.Tables.Count > 0 Then

            DGV.DataSource = DS.Tables(0)
            DGV.ClearSelection()

        Else
            Dispose()
        End If
    End Sub

    Private Sub SetDGVHeader()
        DGV.Columns(0).Visible = False
        DGV.Columns(1).Width = 40
        DGV.Columns(2).HeaderText = "الخدمة "
    End Sub

    Private Sub PnlTitel_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseDown, LblTitel.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub PnlTitel_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseMove, LblTitel.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Private Sub PnlTitel_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseUp, LblTitel.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If ServiceID <> 0 Then BtnRefresh.PerformClick()

        SaveService()
    End Sub

    Private Sub SaveService()

        IsDataMissing = False

        IsInputEmpty(Pnl)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim Param() As SqlParameter = {
            New SqlParameter("@ID", ServiceID),
             New SqlParameter("@Name", TxtService.Text.Trim)}

        Dim SQLCon = New SQLConClass
        SQLCon.CMDExecute("SaveService", 1, Param)

        GetFillData()
        SelectItem()
    End Sub

    Private Sub SelectItem()
        Dim ItemRows() As DataRow = DS.Tables(0).Select("Name='" & TxtService.Text.Trim & "'")
        If ItemRows.Length > 0 Then
            CR = ItemRows(0)(1) - 1
            DGV.Rows(CR).Selected = True
            DGV.FirstDisplayedScrollingRowIndex = CR
            DisplayData()
        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        If CheckDGVError(DGV) Then Exit Sub

        CR = DGV.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub DisplayData()
        ServiceID = DGV.Item(0, CR).Value
        TxtService.Text = DGV.Item(2, CR).Value
        TxtService.Focus()
    End Sub

    Private Sub TxtBank_TextChanged(sender As Object, e As EventArgs) Handles TxtService.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window

        If ServiceID = 0 Then
            DTDefaultView(TxtService.Text, DS.Tables(0), "Name")
            DGV.ClearSelection()
        End If

    End Sub

    Private Sub TxtService_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtService.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ServiceID = 0 Then
                BtnAdd_Click(sender, e)

            Else
                BtnSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub TxtService_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtService.KeyPress
        e.Handled = Not LetterNumberSymbol(e.KeyChar)
    End Sub

    Private Sub TxtPrice_TextChanged(sender As Object, e As EventArgs)
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPrice_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ChangeControlColor(Pnl)
        CR = -1 : ServiceID = 0 : DGV.ClearSelection()
        TxtService.Clear()

        GetFillData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ServiceID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        SaveService()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ServiceID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        If MsgBox("هل تريد حذف" & vbCrLf & TxtService.Text & " ؟", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim Param() As SqlParameter = {
                New SqlParameter("@ID", ServiceID)}

            Dim SQLCon = New SQLConClass
            Dim SaveState As Integer = SQLCon.CMDExecute("DeleteService", 1, Param)
            Select Case SaveState
                Case 2
                    MsgTool(" لا يمكن حذف بيانات الخدمة ", 0)
            End Select
            BtnRefresh.PerformClick()
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub


End Class