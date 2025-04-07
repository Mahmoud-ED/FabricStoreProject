Imports System.Data.SqlClient

Public Class FrmCity
    Private DSCity As New DataSet
    Private CityID As Integer
    Private CR As Integer = -1

    Private Sub FrmCity_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub FrmCity_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ChangeSystemColors(Me)
        BtnRefresh_Click(sender, e)
        TxtCity.Select()
        TxtCity.Focus()
    End Sub

    Private Sub GetFillData()
        Dim SQLCon = New SQLConClass
        SQLQuery = "Select ID ,Row_Number() Over(Order By(Select 1)) ت, Name From CityTable Order By Name"
        DSCity = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSCity.Tables.Count > 0 Then
            DGVCity.DataSource = DSCity.Tables(0)
            DGVCity.ClearSelection()
            SetDGVHeader()

        Else
            Dispose()
        End If
    End Sub

    Private Sub SetDGVHeader()
        DGVCity.Columns(0).Visible = False
        DGVCity.Columns(1).Width = 55
        DGVCity.Columns(2).HeaderText = "المدينة "
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
        If CityID <> 0 Then BtnRefresh.PerformClick()

        SaveCity()
    End Sub

    Private Sub SaveCity()

        IsDataMissing = False

        IsInputEmpty(PnlCountry)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim Param() As SqlParameter = {
            New SqlParameter("@ID", CityID),
             New SqlParameter("@Name", TxtCity.Text.Trim)}

        Dim SQLCon = New SQLConClass
        SQLCon.CMDExecute("SaveCity", 1, Param)

        GetFillData()
        SelectItem()
    End Sub

    Private Sub SelectItem()
        Dim ItemRows() As DataRow = DSCity.Tables(0).Select("Name='" & TxtCity.Text.Trim & "'")
        If ItemRows.Length > 0 Then
            CR = ItemRows(0)(1) - 1
            DGVCity.Rows(CR).Selected = True
            DGVCity.FirstDisplayedScrollingRowIndex = CR
            DisplayData()
        End If
    End Sub

    Private Sub DGVCity_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCity.CellContentClick

    End Sub

    Private Sub DGVCity_Click(sender As Object, e As EventArgs) Handles DGVCity.Click
        If CheckDGVError(DGVCity) Then Exit Sub

        CR = DGVCity.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub DisplayData()
        CityID = DGVCity.Item(0, CR).Value
        TxtCity.Text = DGVCity.Item(2, CR).Value
        TxtCity.Focus()
    End Sub

    Private Sub TxtCity_TextChanged(sender As Object, e As EventArgs) Handles TxtCity.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window

        If CityID = 0 Then
            DTDefaultView(TxtCity.Text, DSCity.Tables(0), "Name")
            DGVCity.ClearSelection()
        End If
    End Sub

    Private Sub TxtCity_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CityID = 0 Then
                BtnAdd_Click(sender, e)

            Else
                BtnSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub TxtCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCity.KeyPress
        e.Handled = Not LetterOnly(e.KeyChar)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ChangeControlColor(PnlCountry)
        CR = -1 : CityID = 0 : DGVCity.ClearSelection()
        TxtCity.Clear()

        GetFillData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CityID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        SaveCity()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If CityID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        If MsgBox("هل تريد حذف" & vbCrLf & TxtCity.Text & " ؟", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim Param() As SqlParameter = {
                New SqlParameter("@ID", CityID)}

            Dim SQLCon = New SQLConClass
            Dim SaveState As Integer = SQLCon.CMDExecute("DeleteCity", 1, Param)
            Select Case SaveState
                Case 2
                    MsgTool(" لا يمكن حذف بيانات المدينة ", 0)
            End Select
            BtnRefresh.PerformClick()
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub


End Class