Imports System.Data.SqlClient

Public Class FrmBank
    Private DSBank As New DataSet
    Private BankID As Integer
    Private CR As Integer = -1

    Private Sub FrmBank_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetFillData()
        SetDGVHeader()
        TxtBank.Select()
        TxtBank.Focus()
    End Sub

    Private Sub GetFillData()
        Dim SQLCon = New SQLConClass
        SQLQuery = "Select ID ,Row_Number() Over(Order By(Select 1)) ت, Name, AccountNumber From BankTable Order By Name"
        DSBank = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSBank.Tables.Count > 0 Then

            DGVBank.DataSource = DSBank.Tables(0)
            DGVBank.ClearSelection()

        Else
            Dispose()
        End If
    End Sub

    Private Sub SetDGVHeader()
        DGVBank.Columns(0).Visible = False
        DGVBank.Columns(1).Width = 40
        DGVBank.Columns(2).HeaderText = "المصرف "
        DGVBank.Columns(3).HeaderText = "رقم الحساب "
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
        If BankID <> 0 Then BtnRefresh.PerformClick()

        SaveBank()
    End Sub

    Private Sub SaveBank()

        IsDataMissing = False

        IsInputEmpty(PnlBank)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim Param() As SqlParameter = {
            New SqlParameter("@ID", BankID),
             New SqlParameter("@Name", TxtBank.Text.Trim),
             New SqlParameter("@AccountNumber", TxtAccountNumber.Text.Trim)}

        Dim SQLCon = New SQLConClass
        SQLCon.CMDExecute("SaveBank", 1, Param)

        GetFillData()
        SelectItem()
    End Sub

    Private Sub SelectItem()
        Dim ItemRows() As DataRow = DSBank.Tables(0).Select("Name='" & TxtBank.Text.Trim & "'")
        If ItemRows.Length > 0 Then
            CR = ItemRows(0)(1) - 1
            DGVBank.Rows(CR).Selected = True
            DGVBank.FirstDisplayedScrollingRowIndex = CR
            DisplayData()
        End If
    End Sub

    Private Sub DGVBank_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBank.CellContentClick

    End Sub

    Private Sub DGVBank_Click(sender As Object, e As EventArgs) Handles DGVBank.Click
        If CheckDGVError(DGVBank) Then Exit Sub

        CR = DGVBank.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub DisplayData()
        BankID = DGVBank.Item(0, CR).Value
        TxtBank.Text = DGVBank.Item(2, CR).Value
        TxtAccountNumber.Text = DGVBank.Item(3, CR).Value
        TxtBank.Focus()
    End Sub

    Private Sub TxtBank_TextChanged(sender As Object, e As EventArgs) Handles TxtBank.TextChanged
        sender.BackColor = SystemColors.Window

        If BankID = 0 Then
            DTDefaultView(TxtBank.Text, DSBank.Tables(0), "Name")
            DGVBank.ClearSelection()
        End If

    End Sub

    Private Sub TxtBank_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBank.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAccountNumber.Focus()
        End If
    End Sub

    Private Sub TxtBank_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBank.KeyPress
        e.Handled = Not LetterNumberSymbol(e.KeyChar)
    End Sub

    Private Sub TxtAccountNumber_TextChanged(sender As Object, e As EventArgs) Handles TxtAccountNumber.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtAccountNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAccountNumber.KeyPress
        e.Handled = Not IsNumberOnly(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtAccountNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAccountNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            If BankID = 0 Then
                BtnAdd_Click(sender, e)

            Else
                BtnSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ChangeControlColor(PnlBank)
        CR = -1 : BankID = 0 : DGVBank.ClearSelection()
        TxtBank.Clear()
        TxtAccountNumber.Clear()

        GetFillData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If BankID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        SaveBank()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If BankID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        If MsgBox("هل تريد حذف" & vbCrLf & TxtBank.Text & " ؟", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim Param() As SqlParameter = {
                New SqlParameter("@ID", BankID)}

            Dim SQLCon = New SQLConClass
            Dim SaveState As Integer = SQLCon.CMDExecute("DeleteBank", 1, Param)
            Select Case SaveState
                Case 2
                    MsgTool(" لا يمكن حذف بيانات المصرف ", 0)
            End Select
            BtnRefresh.PerformClick()
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub


End Class