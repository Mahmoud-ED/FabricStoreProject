Imports System.Data.SqlClient
Public Class FrmCountry
    Private DSCountry As New DataSet
    Private CountryID As Integer
    Private CR As Integer = -1

    Private Sub FrmCountry_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub FrmCountry_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ChangeSystemColors(Me)
        BtnRefresh_Click(sender, e)
        TxtCountry.Select()
        TxtCountry.Focus()
    End Sub

    Private Sub GetFillData()
        Dim SQLCon = New SQLConClass
        SQLQuery = "Select ID ,Row_Number() Over(Order By(Select 1)) ت, Name From CountryTable Order By Name"
        DSCountry = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSCountry.Tables.Count > 0 Then
            DGVCountry.DataSource = DSCountry.Tables(0)
            DGVCountry.ClearSelection()
            SetDGVHeader()

        Else
            Dispose()
        End If
    End Sub

    Private Sub SetDGVHeader()
        DGVCountry.Columns(0).Visible = False
        DGVCountry.Columns(1).Width = 55
        DGVCountry.Columns(2).HeaderText = "البلد "
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
        If CountryID <> 0 Then BtnRefresh.PerformClick()

        SaveCountry()
    End Sub

    Private Sub SaveCountry()

        IsDataMissing = False

        IsInputEmpty(PnlCountry)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim Param() As SqlParameter = {
            New SqlParameter("@ID", CountryID),
             New SqlParameter("@Name", TxtCountry.Text.Trim)}

        Dim SQLCon = New SQLConClass
        SQLCon.CMDExecute("SaveCountry", 1, Param)

        GetFillData()
        SelectItem()
    End Sub

    Private Sub SelectItem()
        Dim ItemRows() As DataRow = DSCountry.Tables(0).Select("Name='" & TxtCountry.Text.Trim & "'")
        If ItemRows.Length > 0 Then
            CR = ItemRows(0)(1) - 1
            DGVCountry.Rows(CR).Selected = True
            DGVCountry.FirstDisplayedScrollingRowIndex = CR
            DisplayData()
        End If
    End Sub

    Private Sub DGVCountry_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCountry.CellContentClick

    End Sub

    Private Sub DGVCountry_Click(sender As Object, e As EventArgs) Handles DGVCountry.Click
        If CheckDGVError(DGVCountry) Then Exit Sub

        CR = DGVCountry.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub DisplayData()
        CountryID = DGVCountry.Item(0, CR).Value
        TxtCountry.Text = DGVCountry.Item(2, CR).Value
        TxtCountry.Focus()
    End Sub

    Private Sub TxtCountry_TextChanged(sender As Object, e As EventArgs) Handles TxtCountry.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window

        If CountryID = 0 Then
            DTDefaultView(TxtCountry.Text, DSCountry.Tables(0), "Name")
            DGVCountry.ClearSelection()
        End If
    End Sub

    Private Sub TxtCountry_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CountryID = 0 Then
                BtnAdd_Click(sender, e)

            Else
                BtnSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub TxtCountry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCountry.KeyPress
        e.Handled = Not LetterOnly(e.KeyChar)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ChangeControlColor(PnlCountry)
        CR = -1 : CountryID = 0 : DGVCountry.ClearSelection()
        TxtCountry.Clear()

        GetFillData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CountryID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        SaveCountry()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If CountryID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        If MsgBox("هل تريد حذف" & vbCrLf & TxtCountry.Text & " ؟", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim Param() As SqlParameter = {
                New SqlParameter("@ID", CountryID)}

            Dim SQLCon = New SQLConClass
            Dim SaveState As Integer = SQLCon.CMDExecute("DeleteCountry", 1, Param)
            Select Case SaveState
                Case 2
                    MsgTool(" لا يمكن حذف بيانات البلد ", 0)
            End Select
            BtnRefresh.PerformClick()
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub


End Class