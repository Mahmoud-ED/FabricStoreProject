Imports System.Data.SqlClient

Public Class FrmFinanceType
    Private DSFinanceType As New DataSet
    Private FinanceTypeID As Integer
    Private CR As Integer = -1

    Private Sub FrmFinanceType_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetFillData()
        SetDGVHeader()
        TxtFinanceType.Select()
        TxtFinanceType.Focus()
    End Sub

    Private Sub GetFillData()
        Dim SQLCon = New SQLConClass
        SQLQuery = "Select ID ,Row_Number() Over(Order By(Select 1)) ت, Name,  Description From FinanceTypeTable Order By Name"
        DSFinanceType = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSFinanceType.Tables.Count > 0 Then
            DGVFinanceType.DataSource = DSFinanceType.Tables(0)
            DGVFinanceType.ClearSelection()

        Else
            Dispose()
        End If
    End Sub

    Private Sub SetDGVHeader()
        DGVFinanceType.Columns(0).Visible = False
        DGVFinanceType.Columns(1).Width = 40
        DGVFinanceType.Columns(2).HeaderText = "البند "
        DGVFinanceType.Columns(3).HeaderText = "الوصف "
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
        If FinanceTypeID <> 0 Then BtnRefresh.PerformClick()

        SaveFinanceType()
    End Sub

    Private Sub SaveFinanceType()

        IsDataMissing = False

        'If TxtFinanceType.Text = vbNullString And TxtFinanceType.Enabled Then
        '    TxtFinanceType.BackColor = Color.FromArgb(244, 206, 193)
        '    IsDataMissing = True
        'End If

        'If TxtDescription.Text = vbNullString And TxtDescription.Enabled Then
        '    TxtDescription.BackColor = Color.FromArgb(244, 206, 193)
        '    IsDataMissing = True
        'End If

        IsInputEmpty(PnlFinanceType)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim Param() As SqlParameter = {
            New SqlParameter("@ID", FinanceTypeID),
             New SqlParameter("@Name", TxtFinanceType.Text.Trim),
             New SqlParameter("@Description", TxtDescription.Text.Trim)}

        Dim SQLCon = New SQLConClass
        SQLCon.CMDExecute("SaveFinanceType", 1, Param)

        GetFillData()
        SelectItem()
    End Sub

    Private Sub SelectItem()
        Dim ItemRows() As DataRow = DSFinanceType.Tables(0).Select("Name='" & TxtFinanceType.Text.Trim & "'")
        If ItemRows.Length > 0 Then
            CR = ItemRows(0)(1) - 1
            DGVFinanceType.Rows(CR).Selected = True
            DGVFinanceType.FirstDisplayedScrollingRowIndex = CR
            DisplayData()
        End If
    End Sub

    Private Sub DGVFinanceType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVFinanceType.CellContentClick

    End Sub

    Private Sub DGVFinanceType_Click(sender As Object, e As EventArgs) Handles DGVFinanceType.Click
        If CheckDGVError(DGVFinanceType) Then Exit Sub

        CR = DGVFinanceType.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub DisplayData()
        FinanceTypeID = DGVFinanceType.Item(0, CR).Value
        TxtFinanceType.Text = DGVFinanceType.Item(2, CR).Value
        TxtDescription.Text = DGVFinanceType.Item(3, CR).Value
        TxtFinanceType.Focus()
    End Sub

    Private Sub TxtFinanceType_TextChanged(sender As Object, e As EventArgs) Handles TxtFinanceType.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window

        If FinanceTypeID = 0 Then
            DTDefaultView(TxtFinanceType.Text, DSFinanceType.Tables(0), "Name")
            DGVFinanceType.ClearSelection()
        End If
    End Sub

    Private Sub TxtFinanceType_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFinanceType.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDescription.Focus()
        End If
    End Sub

    Private Sub TxtDescription_TextChanged(sender As Object, e As EventArgs) Handles TxtDescription.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            If FinanceTypeID = 0 Then
                BtnAdd_Click(sender, e)

            Else
                BtnSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ChangeControlColor(PnlFinanceType)
        CR = -1 : FinanceTypeID = 0 : DGVFinanceType.ClearSelection()
        TxtFinanceType.Clear()
        TxtDescription.Clear()
        GetFillData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If FinanceTypeID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        SaveFinanceType()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If FinanceTypeID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        If MsgBox("هل تريد حذف" & vbCrLf & TxtFinanceType.Text & " ؟", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim Param() As SqlParameter = {
                New SqlParameter("@ID", FinanceTypeID)}

            Dim SQLCon = New SQLConClass
            Dim SaveState As Integer = SQLCon.CMDExecute("DeleteFinanceType", 1, Param)
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