Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmSearchInvo
    Public DSData As New DataSet
    Private ID As Integer
    Private PageSize, RowsCount, PagesCount As Integer
    Private SearchActive As Boolean
    Private PageNum As Integer = 1

    Private Sub FrmSearchInvo_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        TxtSearchName.Select()
        NUDPageSize.Value = My.Settings.PageSize
        TxtPagesCount.Text = 1
        TxtCurrentPage.Text = PageNum
    End Sub

    Private Sub FrmSearchInvo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not IsNothing(DSData) Then
            DSData.Clear()
        End If

        Dispose()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        If TxtSearchName.Text.Trim = "" Then
            TxtSearchName.BackColor = RedColor
            MsgTool("يرجى إدخال اسم/ رقم للبحث", 0)
            Exit Sub
        End If


        SearchActive = True
        PageNum = 1
        GetFillData()
    End Sub

    Private Sub PnlMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseDown, LblTitel.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub PnlMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseUp, LblTitel.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub PnlMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseMove, LblTitel.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    '****************************************************************************
    '------------------Pagination-------------------------------------------
    Private Sub GetPagesCount()
        If RowsCount = PageSize Then
            PagesCount = 1

        ElseIf RowsCount Mod PageSize = 0 And RowsCount <> 0 Then
            PagesCount = RowsCount / PageSize

        Else
            PagesCount = (RowsCount \ PageSize) + 1
        End If
        TxtPagesCount.Text = PagesCount
        TxtCurrentPage.Text = PageNum

    End Sub

    Private Sub BtnNextPage_Click(sender As Object, e As EventArgs) Handles BtnNextPage.Click

        If Not SearchActive Then Exit Sub
        CheckPageSize()

        If PageNum < PagesCount Then
            PageNum += 1
        End If

        GetFillData()
    End Sub

    Private Sub BtnPreviousPage_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage.Click

        If Not SearchActive Then Exit Sub
        CheckPageSize()

        If PageNum > 1 Then
            PageNum -= 1
        Else
            PageNum = 1
        End If

        GetFillData()

    End Sub
    Private Sub BtnFirstPage_Click(sender As Object, e As EventArgs) Handles BtnFirstPage.Click

        If Not SearchActive Then Exit Sub

        PageNum = 1
        GetFillData()

    End Sub
    Private Sub BtnLastPage_Click(sender As Object, e As EventArgs) Handles BtnLastPage.Click

        If Not SearchActive Then Exit Sub

        CheckPageSize()
        PageNum = PagesCount
        GetFillData()

    End Sub
    Private Sub TxtCurrentPage_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCurrentPage.KeyDown

        If e.KeyCode = Keys.Enter Then
            CheckPageSize()

            If Val(TxtCurrentPage.Text) > Val(TxtPagesCount.Text) Then
                PageNum = TxtPagesCount.Text
            ElseIf Val(TxtCurrentPage.Text) <= 0 Then
                PageNum = 1
            Else
                PageNum = Val(TxtCurrentPage.Text)
            End If
            GetFillData()
        End If

    End Sub

    Private Sub CheckPageSize()
        Dim SPageSize As Integer = My.Settings.PageSize
        If PageSize <> SPageSize Then
            PageNum = 1
            GetFillData() 'عند تغيير حجم الصفحة يجب معرفة عدد الصفحات الجديد PagesCount
        End If
    End Sub

    Private Sub NUDPageSize_TextChanged(sender As Object, e As EventArgs) Handles NUDPageSize.TextChanged
        If NUDPageSize.Value = 0 Then
            NUDPageSize.Value = 1
        Else
            NUDPageSize_ValueChanged(sender, e)
        End If
    End Sub

    Private Sub NUDPageSize_ValueChanged(sender As Object, e As EventArgs) Handles NUDPageSize.ValueChanged
        Dim SPageSize As Integer = My.Settings.PageSize

        If NUDPageSize.Value <> 0 And SPageSize <> NUDPageSize.Value Then
            My.Settings.PageSize = NUDPageSize.Value
            My.Settings.Save()
        End If
        DGVReport.Rows.Clear()

    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click
        If TxtSearchName.Text.Trim = "" Then Exit Sub

        TxtCurrentPage.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

    '--------------------------------------------------
    '*****************************************************************************

    '--------------------Sub---------------------------------------

    Private Sub GetFillData()

        ID = 0

        TxtCurrentPage.Text = PageNum
        PageSize = My.Settings.PageSize

        Dim numValue As Integer
        If Not Integer.TryParse(TxtSearchName.Text, numValue) Then
            numValue = 0
        End If

        SQLQuery = "Select ID,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS ت,Name ,
                     Num, Date, Phone1 , Phone2 From InvoiceView  WHERE EndService IS NULL AND (Name LIKE '%" & TxtSearchName.Text.Trim & "%' Or Num = " & numValue &
                     "  Or Phone1 LIKE '%" & numValue & "%' Or Phone2 LIKE '%" & numValue & "%') "
        SQLQuery &= "  SELECT COUNT(ID) FROM InvoiceView WHERE EndService IS NULL AND (Name LIKE '%" & TxtSearchName.Text.Trim & "%' Or Num = " & numValue &
                    "  Or Phone1 LIKE '%" & numValue & "%' Or Phone2 LIKE '%" & numValue & "%') "
        SQLQuery &= " ORDER BY (SELECT 1) ASC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY "

        Dim SQLCon = New SQLConClass()
        DSData = SQLCon.SelectData(SQLQuery,, Nothing)

        If Not DSHasTables(DSData) Then
            MsgTool("لاتوجد نتائج مطابقة للبحث", 0)
            Exit Sub
        End If

        RowsCount = DSData.Tables(1).Rows(0).Item(0)
        GetPagesCount()

        DGVReport.Rows.Clear()

        If DSData.Tables(0).Rows.Count = 0 Then
            MsgTool("لاتوجد نتائج مطابقة للبحث", 0)
            TxtSearchName.SelectAll()
            Exit Sub
        End If

        For i = 0 To DSData.Tables(0).Rows.Count - 1
            With DSData.Tables(0).Rows(i)

                DGVReport.Rows.Add()
                DGVReport.Item(0, i).Value = .Item("ID")
                DGVReport.Item(1, i).Value = .Item("ت")
                DGVReport.Item(2, i).Value = Format(.Item("Num"), "000000")
                DGVReport.Item(3, i).Value = .Item("Date")
                DGVReport.Item(4, i).Value = .Item("Name")
                'DGVReport.Item(5, i).Value = .Item("Name")
                If Not .Item("Phone1") = "" Then
                    DGVReport.Item(5, i).Value = .Item("Phone1")
                End If

                If Not .Item("Phone2") = "" Then
                    If DGVReport.Item(5, i).Value = "" Then
                        DGVReport.Item(5, i).Value = .Item("Phone2")

                    Else
                        DGVReport.Item(5, i).Value = DGVReport.Item(5, i).Value & " - " & .Item("Phone2")
                    End If
                End If
            End With
        Next
        DGVReport.ClearSelection()

    End Sub

    '----------------------------------------------------------------

    Private Sub TxtSearchName_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchName.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
        DGVReport.Rows.Clear()
    End Sub

    Private Sub DGVReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVReport.CellContentClick

    End Sub

    Private Sub DGVReport_Click(sender As Object, e As EventArgs) Handles DGVReport.Click

        If CheckDGVError(DGVReport) Then Exit Sub
        ID = DGVReport.Item(0, DGVReport.CurrentRow.Index).Value

    End Sub

    Private Sub DGVReport_DoubleClick(sender As Object, e As EventArgs) Handles DGVReport.DoubleClick

        If ID = 0 Then Exit Sub

        Me.DialogResult = DialogResult.OK
        FrmSales.InvoiceID = ID
        'FrmPatientInfo.LastName = DGVReport.CurrentRow.Cells(2).Value
        ''FrmReceipt.LastName = DGVReport.CurrentRow.Cells(2).Value
        'FrmReservation.LastName = DGVReport.CurrentRow.Cells(2).Value
        'FrmCreateAppointment.LastName = DGVReport.CurrentRow.Cells(2).Value
        'FrmAddToWaitList.LastName = DGVReport.CurrentRow.Cells(2).Value
        Dispose()

    End Sub

    Private Sub TxtCurrentPage_TextChanged(sender As Object, e As EventArgs) Handles TxtCurrentPage.TextChanged

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Dispose()
    End Sub

    Private Sub TxtSearchName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearchName.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then BtnSearch.PerformClick()
    End Sub

    Private Sub TxtCurrentPage_Click(sender As Object, e As EventArgs) Handles TxtCurrentPage.Click
        TxtCurrentPage.SelectAll()
        SelectAllText = True
    End Sub

    Private Sub TxtCurrentPage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCurrentPage.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        End If
    End Sub

End Class