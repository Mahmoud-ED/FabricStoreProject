Imports System.Data.SqlClient

Public Class FrmPaymentType
    Private DSPaymentType As New DataSet
    Private PaymentTypeID As Integer
    Private CR As Integer = -1

    Private Sub FrmPaymentType_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetFillData()
        SetDGVHeader()
        TxtPaymentType.Select()
        TxtPaymentType.Focus()
    End Sub

    Private Sub GetFillData()
        Dim SQLCon = New SQLConClass
        SQLQuery = "Select ID ,Row_Number() Over(Order By(Select 1)) ت, Name,  [Percent] From PaymentTypeTable "
        DSPaymentType = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSPaymentType.Tables.Count > 0 Then

            DGVPaymentType.DataSource = DSPaymentType.Tables(0)
            DGVPaymentType.ClearSelection()

        Else
            Dispose()
        End If
    End Sub

    Private Sub SetDGVHeader()
        DGVPaymentType.Columns(0).Visible = False
        DGVPaymentType.Columns(1).Width = 40
        DGVPaymentType.Columns(2).HeaderText = "النوع "
        DGVPaymentType.Columns(3).HeaderText = "النسبة "
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
        If PaymentTypeID <> 0 Then BtnRefresh.PerformClick()

        SavePaymentType()
    End Sub

    Private Sub SavePaymentType()
        IsDataMissing = False

        IsInputEmpty(PnlPaymentType)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim Param() As SqlParameter = {
            New SqlParameter("@ID", PaymentTypeID),
             New SqlParameter("@Name", TxtPaymentType.Text.Trim),
             New SqlParameter("@Percent", TxtPercent.Text.Trim)}

        Dim SQLCon = New SQLConClass
        SQLCon.CMDExecute("SavePaymentType", 1, Param)

        GetFillData()
        'SelectItem()
    End Sub

    Private Sub SelectItem()
        Dim ItemRows() As DataRow = DSPaymentType.Tables(0).Select("Name='" & TxtPaymentType.Text.Trim & "'")
        If ItemRows.Length > 0 Then
            CR = ItemRows(0)(1) - 1
            DGVPaymentType.Rows(CR).Selected = True
            DGVPaymentType.FirstDisplayedScrollingRowIndex = CR
            DisplayData()
        End If
    End Sub

    Private Sub DGVPaymentType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPaymentType.CellContentClick

    End Sub

    Private Sub DGVPaymentType_Click(sender As Object, e As EventArgs) Handles DGVPaymentType.Click
        If CheckDGVError(DGVPaymentType) Then Exit Sub

        CR = DGVPaymentType.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub DisplayData()
        PaymentTypeID = DGVPaymentType.Item(0, CR).Value
        TxtPaymentType.Text = DGVPaymentType.Item(2, CR).Value
        If PaymentTypeID = 1 Or PaymentTypeID = 2 Or PaymentTypeID = 3 Or PaymentTypeID = 4 Then
            TxtPaymentType.ReadOnly = True

        Else
            TxtPaymentType.ReadOnly = False
        End If

        TxtPercent.Text = DGVPaymentType.Item(3, CR).Value
        TxtPaymentType.Focus()
    End Sub

    Private Sub TxtPaymentType_TextChanged(sender As Object, e As EventArgs) Handles TxtPaymentType.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window

        If PaymentTypeID = 0 Then
            DTDefaultView(TxtPaymentType.Text, DSPaymentType.Tables(0), "Name")
            DGVPaymentType.ClearSelection()
        End If
    End Sub

    Private Sub TxtPaymentType_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPaymentType.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPercent.Focus()
        End If
    End Sub

    Private Sub TxtPaymentType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPaymentType.KeyPress
        e.Handled = Not LetterNumberSymbol(e.KeyChar)
    End Sub

    Private Sub TxtPercent_TextChanged(sender As Object, e As EventArgs) Handles TxtPercent.TextChanged
        If Val(TxtPercent.Text) > 100 Then TxtPercent.Text = 100
        If TxtPercent.Text.Contains(".") Then TxtPercent.MaxLength = 6 Else TxtPercent.MaxLength = 3

        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPercent.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtPercent_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPercent.KeyDown
        If e.KeyCode = Keys.Enter Then
            If PaymentTypeID = 0 Then
                BtnAdd_Click(sender, e)

            Else
                BtnSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ChangeControlColor(PnlPaymentType)
        CR = -1 : PaymentTypeID = 0 : DGVPaymentType.ClearSelection()
        TxtPaymentType.ReadOnly = False
        TxtPaymentType.Clear()
        TxtPercent.Clear()
        GetFillData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If PaymentTypeID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        SavePaymentType()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If PaymentTypeID = 0 Then
            MsgTool("الرجاء اختيار اسم من القائمة", 0)
            Exit Sub
        End If

        If PaymentTypeID = 1 Or PaymentTypeID = 2 Or PaymentTypeID = 3 Or PaymentTypeID = 4 Or PaymentTypeID = 5 Then
            MsgTool("لا يمكن حذف  نوع الدفع", 0)
            Exit Sub
        End If

        If MsgBox("هل تريد حذف" & vbCrLf & TxtPaymentType.Text & " ؟", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim Param() As SqlParameter = {
                New SqlParameter("@ID", PaymentTypeID)}

            Dim SQLCon = New SQLConClass
            Dim SaveState As Integer = SQLCon.CMDExecute("DeletePaymentType", 1, Param)
            Select Case SaveState
                Case 2
                    MsgTool(" لا يمكن حذف نوع الدفع ", 0)
            End Select
            BtnRefresh.PerformClick()
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub


End Class