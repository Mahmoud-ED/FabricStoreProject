Imports System.Data.SqlClient

Public Class FrmCategory
    Private DSCategory As New DataSet
    Private CategoryID As Integer
    Private CR As Integer = -1

    Private Sub FrmCategory_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        '  TxtCategory.Focus()
        BtnRefresh_Click(sender, e)
        'GetFillData()
        'SetDGVHeader()
        TxtCategory.Select()
        TxtCategory.Focus()

    End Sub

    Private Sub GetFillData()
        Dim SQLCon = New SQLConClass
        SQLQuery = "Select ID ,Row_Number() Over(Order By(Select 1)) ت, Name From CategoryTable Order By Name"
        DSCategory = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSCategory.Tables.Count > 0 Then
            DGVCategory.DataSource = DSCategory.Tables(0)
            DGVCategory.ClearSelection()
            SetDGVHeader()

        Else
            Dispose()
        End If
    End Sub

    Private Sub SetDGVHeader()
        DGVCategory.Columns(0).Visible = False
        DGVCategory.Columns(1).Width = 40
        DGVCategory.Columns(2).HeaderText = "التصنيف "
    End Sub

    Private Sub PnlTitel_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseDown, LblTitel.MouseDown
        If e.Button = MouseButtons.Left Then
            SW = True
            Pos = e.Location
        End If
    End Sub

    Private Sub PnlTitel_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseMove, LblTitel.MouseMove
        If SW Then
            Me.Location += e.Location - Pos
        End If
    End Sub

    Private Sub PnlTitel_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTitel.MouseUp, LblTitel.MouseUp
        If e.Button = MouseButtons.Left Then
            SW = False
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If CategoryID <> 0 Then BtnRefresh.PerformClick()

        SaveCategory()
    End Sub

    Private Sub SaveCategory()
        IsDataMissing = False

        IsInputEmpty(PnlCategory)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim Param() As SqlParameter = {
            New SqlParameter("@ID", CategoryID),
             New SqlParameter("@Name", TxtCategory.Text.Trim)}

        Dim SQLCon = New SQLConClass
        SQLCon.CMDExecute("SaveCategory", 1, Param)

        GetFillData()
        SelectItem()
    End Sub

    Private Sub SelectItem()
        Dim ItemRows() As DataRow = DSCategory.Tables(0).Select("Name='" & TxtCategory.Text.Trim & "'")
        If ItemRows.Length > 0 Then
            CR = ItemRows(0)(1) - 1
            DGVCategory.Rows(CR).Selected = True
            DGVCategory.FirstDisplayedScrollingRowIndex = CR
            DisplayData()
        End If
    End Sub

    Private Sub DGVCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DGVCategory_Click(sender As Object, e As EventArgs) Handles DGVCategory.Click
        If CheckDGVError(DGVCategory) Then Exit Sub

        CR = DGVCategory.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub DisplayData()
        CategoryID = DGVCategory.Item(0, CR).Value
        TxtCategory.Text = DGVCategory.Item(2, CR).Value
        TxtCategory.Focus()
    End Sub

    Private Sub TxtCategory_TextChanged(sender As Object, e As EventArgs) Handles TxtCategory.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
        If CategoryID = 0 Then
            DTDefaultView(TxtCategory.Text, DSCategory.Tables(0), "Name")
            DGVCategory.ClearSelection()
        End If
    End Sub

    Private Sub TxtCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CategoryID = 0 Then
                BtnAdd_Click(sender, e)

            Else
                BtnSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub TxtCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCategory.KeyPress
        e.Handled = Not LetterOnly(e.KeyChar)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ChangeControlColor(PnlCategory)
        CR = -1 : CategoryID = 0 : DGVCategory.ClearSelection()
        TxtCategory.Clear()
        GetFillData()
        TxtCategory.Focus()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CategoryID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        SaveCategory()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If CategoryID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        If MsgBox("هل تريد حذف" & vbCrLf & TxtCategory.Text & " ؟", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim Param() As SqlParameter = {
                New SqlParameter("@ID", CategoryID)}

            Dim SQLCon = New SQLConClass
            Dim SaveState As Integer = SQLCon.CMDExecute("DeleteCategory", 1, Param)
            Select Case SaveState
                Case 2
                    MsgTool(" لا يمكن حذف التصنيف ", 0)
            End Select
            BtnRefresh.PerformClick()
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub


End Class