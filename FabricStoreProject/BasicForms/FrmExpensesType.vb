Imports System.Data.SqlClient

Public Class FrmExpensesType
    Private DSExpensesType As New DataSet
    Private ExpensesTypeID As Integer
    Private CR As Integer = -1

    Private Sub FrmExpensesType_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        BtnRefresh_Click(sender, e)
        'GetFillData()
        'SetDGVHeader()
        TxtExpensesType.Select()
        TxtExpensesType.Focus()
    End Sub

    Private Sub GetFillData()
        Dim SQLCon = New SQLConClass
        SQLQuery = "Select ID ,Row_Number() Over(Order By(Select 1)) ت, Name From ExpensesTypeTable Order By Name"
        DSExpensesType = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSExpensesType.Tables.Count > 0 Then
            DGVExpensesType.DataSource = DSExpensesType.Tables(0)
            DGVExpensesType.ClearSelection()
            SetDGVHeader()

        Else
            Dispose()
        End If
    End Sub

    Private Sub SetDGVHeader()
        DGVExpensesType.Columns(0).Visible = False
        DGVExpensesType.Columns(1).Width = 40
        DGVExpensesType.Columns(2).HeaderText = "البند "
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
        If ExpensesTypeID <> 0 Then BtnRefresh.PerformClick()

        SaveExpensesType()
    End Sub

    Private Sub SaveExpensesType()

        IsDataMissing = False

        'If TxtExpensesType.Text = vbNullString And TxtExpensesType.Enabled Then
        '    TxtExpensesType.BackColor = Color.FromArgb(244, 206, 193)
        '    IsDataMissing = True
        'End If

        IsInputEmpty(PnlExpensesType)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim Param() As SqlParameter = {
            New SqlParameter("@ID", ExpensesTypeID),
             New SqlParameter("@Name", TxtExpensesType.Text.Trim)}

        Dim SQLCon = New SQLConClass
        SQLCon.CMDExecute("SaveExpensesType", 1, Param)

        GetFillData()
        SelectItem()
    End Sub

    Private Sub SelectItem()
        Dim ItemRows() As DataRow = DSExpensesType.Tables(0).Select("Name='" & TxtExpensesType.Text.Trim & "'")
        If ItemRows.Length > 0 Then
            CR = ItemRows(0)(1) - 1
            DGVExpensesType.Rows(CR).Selected = True
            DGVExpensesType.FirstDisplayedScrollingRowIndex = CR
            DisplayData()
        End If
    End Sub

    Private Sub DGVExpensesType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVExpensesType.CellContentClick

    End Sub

    Private Sub DGVExpensesType_Click(sender As Object, e As EventArgs) Handles DGVExpensesType.Click
        If CheckDGVError(DGVExpensesType) Then Exit Sub

        CR = DGVExpensesType.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub DisplayData()
        ExpensesTypeID = DGVExpensesType.Item(0, CR).Value
        TxtExpensesType.Text = DGVExpensesType.Item(2, CR).Value
        TxtExpensesType.Focus()
    End Sub

    Private Sub TxtExpensesType_TextChanged(sender As Object, e As EventArgs) Handles TxtExpensesType.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window

        If ExpensesTypeID = 0 Then
            DTDefaultView(TxtExpensesType.Text, DSExpensesType.Tables(0), "Name")
            DGVExpensesType.ClearSelection()
        End If
    End Sub

    Private Sub TxtExpensesType_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtExpensesType.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ExpensesTypeID = 0 Then
                BtnAdd_Click(sender, e)

            Else
                BtnSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub TxtExpensesType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtExpensesType.KeyPress
        e.Handled = Not LetterOnly(e.KeyChar)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ChangeControlColor(PnlExpensesType)
        CR = -1 : ExpensesTypeID = 0 : DGVExpensesType.ClearSelection()
        TxtExpensesType.Clear()
        GetFillData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ExpensesTypeID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        SaveExpensesType()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ExpensesTypeID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        If MsgBox("هل تريد حذف" & vbCrLf & TxtExpensesType.Text & " ؟", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim Param() As SqlParameter = {
                New SqlParameter("@ID", ExpensesTypeID)}

            Dim SQLCon = New SQLConClass
            Dim SaveState As Integer = SQLCon.CMDExecute("DeleteExpensesType", 1, Param)
            Select Case SaveState
                Case 2
                    MsgTool(" لا يمكن حذف البند ", 0)
            End Select
            BtnRefresh.PerformClick()
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub

End Class