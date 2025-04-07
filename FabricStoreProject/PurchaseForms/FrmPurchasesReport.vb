Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FrmPurchasesReport

    Private PageSize, PagesCount, RowsCount, PurchaseID As Integer
    Private PageNum As Integer = 1
    Private SearchActive As Boolean ' باش نعرف امتى نسمح للبطم متع البيجينشن امتى يخدموا وامتى لا مرات تجي ترصهم ويجيبو سيليكت وانت مكنت تبحث اصلا

    Private Enum Data
        Search
        Main
    End Enum

    Private FromChkNum As Boolean 'عندما يفتح تشك بوكس متع رقم الايصال يسكر باقي التشكات بدون مايخليهم يديرو احداث
    Private DSMain, DSSearch, DSDel As New DataSet


    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmPurchasesReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            NUDPageSize.Value = My.Settings.PageSize
            DTPFrom.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            DTPTo.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
            DTPFrom.Value = Now.Date
            DTPTo.Value = Now.Date
            GetData(Data.Main)
            TxtPagesCount.Text = 1

        Else
            If Not IsNothing(DSMain) Then
                DSMain.Clear()
            End If
            If Not IsNothing(DSSearch) Then
                DSSearch.Clear()
            End If
            DGVPurchases.Rows.Clear()
        End If
    End Sub

    Private Sub AppendToQuery(Oprtr As String, Query As String)

        ' Check if last word in the query is "WHERE " with the space at the end
        ' If True and you want to add a condition no need to append " AND " or any operator
        ' But if was False this means this's not the first condition you add so you must add an operator too

        Dim TestString As String = StrReverse(SQLQuery)
        If StrReverse(TestString.Substring(0, 6).ToUpper) = "WHERE " Then
            SQLQuery &= Query
        Else
            SQLQuery &= Oprtr & " " & Query
        End If

    End Sub

    Private Sub GetData(Type As Data)

        Dim SQLCon = New SQLConClass()
        TxtPageNum.Text = PageNum
        PageSize = My.Settings.PageSize
        Select Case Type
            Case Data.Main

                SQLQuery = " Select ID,Name From UserView where  ID <> 1  Order By Name "
                SQLQuery &= " Select ID,Name From EmployeeTable  Order By Name  "
                SQLQuery &= " Select ID,Name From SuppliersTable  Order By Name  "

                DSMain = SQLCon.SelectData(SQLQuery)
                FillData(Type, DSMain, 3)

            Case Data.Search

                Dim Param() As SqlParameter =
                    {New SqlParameter("@Num", Val(TxtNum.Text))}
                SQLQuery = "SELECT  ROW_NUMBER() OVER (ORDER BY (Date)Desc) As ت, * From PurchasesView WHERE EndService IS NULL "

                AppendConditions()
                SQLQuery &= " ORDER BY PurchasesView.Date Desc OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
                SQLQuery &= " SELECT COUNT(ID) FROM PurchasesView WHERE EndService IS NULL "
                AppendConditions()

                DSSearch = SQLCon.SelectData(SQLQuery, 0, Param)
                FillData(Type, DSSearch, 2)

        End Select

    End Sub

    Private Sub AppendConditions()

        Dim DateTimeFrom As Date = DTPFrom.Value.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTPTo.Value.Date & " " & "23:59".ToString
        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " PurchasesView.Num=@Num ")
        If ChkUser.Checked And CmbUserName.SelectedValue <> Nothing Then AppendToQuery(" AND ", "  dbo.PurchasesView.UserID = " & CmbUserName.SelectedValue)
        If ChkSupplier.Checked And CmbSupplier.SelectedValue <> Nothing Then AppendToQuery(" AND ", " dbo.PurchasesView.SupplierID = " & CmbSupplier.SelectedValue)
        If ChkDate.Checked Then AppendToQuery(" AND ", " Date BETWEEN '" & DateTimeFrom & "' AND '" & DateTimeTo & "' ")
    End Sub

    Private Sub ChkChecks()
        If ChkDate.Checked = False And ChkNum.Checked = False And ChkUser.Checked = False And ChkSupplier.Checked = False Then Exit Sub
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSaerch.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        DGVPurchases.Rows.Clear()
        ChkChecks()
        If ChkDate.Checked = False And ChkNum.Checked = False And ChkUser.Checked = False And ChkSupplier.Checked = False Then
            MsgTool("يرجى اختيار طريقة بحث", 0)
            Exit Sub
        End If

        IsDataMissing = False
        IsInputEmpty(TableLayoutPanel4)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        PageNum = 1
        GetData(Data.Search)
        SearchActive = True

    End Sub

    Private Sub ChkNum_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNum.CheckedChanged
        DGVPurchases.Rows.Clear()
        If ChkNum.Checked = True Then

            TxtNum.Enabled = True
            TxtNum.Focus()
            FromChkNum = True
            ChkUser.Checked = False
            ChkDate.Checked = False
            ChkSupplier.Checked = False

        Else
            ' ChangeControlColor(Me)
            ChkDate.Checked = True
            TxtNum.Enabled = False
            TxtNum.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If

    End Sub

    Private Sub ChkUser_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUser.CheckedChanged
        DGVPurchases.Rows.Clear()
        CmbUserName.BackColor = SystemColors.Window

        If ChkUser.Checked = True Then
            CmbUserName.Enabled = True
            CmbUserName.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            '   ChangeControlColor(Me)
            CmbUserName.Text = ""
            CmbUserName.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkSupplier_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSupplier.CheckedChanged
        DGVPurchases.Rows.Clear()
        CmbSupplier.BackColor = SystemColors.Window

        If ChkSupplier.Checked = True Then
            CmbSupplier.Enabled = True
            CmbSupplier.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            CmbSupplier.Text = ""
            CmbSupplier.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDate.CheckedChanged
        DGVPurchases.Rows.Clear()
        If ChkDate.Checked = True Then
            DTPFrom.Enabled = True
            DTPTo.Enabled = True
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            DTPFrom.Enabled = True
            DTPTo.Enabled = True
            DTPFrom.Value = Now.Date
            DTPTo.Value = Now.Date
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ChangeControlColor(Me)
        DGVPurchases.Rows.Clear()
        ChkDate.Checked = True
        ChkNum.Checked = False
        ChkUser.Checked = False
        ChkSupplier.Checked = False
        SearchActive = False
    End Sub

    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles TxtNum.TextChanged, CmbUserName.TextChanged
        DGVPurchases.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub FillData(Type As Data, DS As DataSet, TCount As Integer)

        Select Case Type
            Case Data.Main
                CmbUserName.DataSource = DS.Tables(0)
                CmbUserName.DisplayMember = "Name"
                CmbUserName.ValueMember = "ID"
                CmbUserName.SelectedIndex = -1

                CmbSupplier.DataSource = DS.Tables(2)
                CmbSupplier.DisplayMember = "Name"
                CmbSupplier.ValueMember = "ID"
                CmbSupplier.SelectedIndex = -1

            Case Data.Search
                If DS.Tables(1).Rows.Count > 0 Then
                    RowsCount = DS.Tables(1).Rows(0).Item(0)
                End If
                GetPagesCount()

                DGVPurchases.Rows.Clear()
                If DS.Tables(0).Rows.Count = 0 Then MsgTool("لا توجد نتائج للبحث", 0)

                For i = 0 To DS.Tables(0).Rows.Count - 1
                    With DS.Tables(0).Rows(i)

                        DGVPurchases.Rows.Add()
                        DGVPurchases.Item(0, i).Value = .Item("ID")
                        DGVPurchases.Item(1, i).Value = .Item("ت") 'i + 1
                        DGVPurchases.Item(2, i).Value = Format(.Item("Num"), "000000")
                        DGVPurchases.Item(3, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DTF))
                        DGVPurchases.Item(4, i).Value = Format(.Item("Total"), "0.000")
                        DGVPurchases.Item(5, i).Value = .Item("Name")

                    End With
                Next
                DGVPurchases.ClearSelection()

        End Select

    End Sub

    Private Sub DGVPurchases_Click(sender As Object, e As EventArgs) Handles DGVPurchases.Click
        If CheckDGVError(DGVPurchases) Then Exit Sub
    End Sub

    Private Sub DTPFrom_ValueChanged(sender As Object, e As EventArgs) Handles DTPFrom.ValueChanged
        DGVPurchases.Rows.Clear()
    End Sub

    Private Sub DTPTo_ValueChanged(sender As Object, e As EventArgs) Handles DTPTo.ValueChanged
        DGVPurchases.Rows.Clear()
    End Sub

    Private Sub CmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUserName.SelectedIndexChanged
        DGVPurchases.Rows.Clear()

    End Sub

    Private Sub CmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSupplier.SelectedIndexChanged
        DGVPurchases.Rows.Clear()
    End Sub

    Private Sub CmbSupplier_TextChanged(sender As Object, e As EventArgs) Handles CmbSupplier.TextChanged
        DGVPurchases.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        'If DGVRecipt.Rows.Count = 0 Then Exit Sub

        'Dim DSPrint = New DataSet
        'Dim SQLCon = New SQLConClass

        'SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,ReceiptName,NoteFor FROM ReceiptView WHERE EndService IS NULL"
        'AppendReportConditions()
        'SQLQuery &= " ORDER BY ID DESC OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
        'SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        'Dim Param() As SqlParameter =
        '    {
        '    New SqlParameter("@Num", TxtNum.Text.Trim),
        '    New SqlParameter("@ReceiptName", "%" & TxtReciptName.Text.Trim & "%"),
        '    New SqlParameter("@PaymentTypeID", (IIf(IsNothing(CmbPaymentType.SelectedValue), 0, CmbPaymentType.SelectedValue))),
        '    New SqlParameter("@UserID", (IIf(IsNothing(CmbUserName.SelectedValue), 0, CmbUserName.SelectedValue))),
        '    New SqlParameter("@BankID", (IIf(IsNothing(CmbBank.SelectedValue), 0, CmbBank.SelectedValue))),
        '    New SqlParameter("@ReceiptFinanceTypeID", (IIf(IsNothing(CmbFinancRecipt.SelectedValue), 0, CmbFinancRecipt.SelectedValue))),
        '    New SqlParameter("@Check", "%" & Val(TxtCkeck.Text.Trim) & "%")
        '    }

        'DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

        'Dim F As New FrmPrint
        'Dim C As New CRRecieptList

        'C.SetDataSource(DSPrint.Tables(0))
        'C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        'C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        'F.CrystalReportViewer1.ReportSource = C
        'F.CrystalReportViewer1.Refresh()
        'F.Text = "طباعة"
        'F.CrystalReportViewer1.Zoom(100%)
        'F.WindowState = FormWindowState.Maximized
        'F.Show()
    End Sub

    Private Sub BtnPrintAll_Click(sender As Object, e As EventArgs) Handles BtnPrintAll.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        'If DGVRecipt.Rows.Count = 0 Then Exit Sub

        'Dim DSPrint = New DataSet
        'Dim SQLCon = New SQLConClass

        'SQLQuery = "SELECT FORMAT(Num,'000000') AS Num,FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DF) & "') AS [Date],Value,ReceiptName,NoteFor FROM ReceiptView WHERE EndService IS NULL"
        'AppendReportConditions()
        'SQLQuery &= " ORDER BY ID DESC"
        'SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        'Dim Param() As SqlParameter =
        '    {
        '    New SqlParameter("@Num", TxtNum.Text.Trim),
        '    New SqlParameter("@ReceiptName", "%" & TxtReciptName.Text.Trim & "%"),
        '    New SqlParameter("@PaymentTypeID", (IIf(IsNothing(CmbPaymentType.SelectedValue), 0, CmbPaymentType.SelectedValue))),
        '    New SqlParameter("@UserID", (IIf(IsNothing(CmbUserName.SelectedValue), 0, CmbUserName.SelectedValue))),
        '    New SqlParameter("@BankID", (IIf(IsNothing(CmbBank.SelectedValue), 0, CmbBank.SelectedValue))),
        '    New SqlParameter("@ReceiptFinanceTypeID", (IIf(IsNothing(CmbFinancRecipt.SelectedValue), 0, CmbFinancRecipt.SelectedValue))),
        '    New SqlParameter("@Check", "%" & Val(TxtCkeck.Text.Trim) & "%")
        '    }

        'DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

        'Dim F As New FrmPrint
        'Dim C As New CRRecieptList

        'C.SetDataSource(DSPrint.Tables(0))
        'C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        'C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        'F.CrystalReportViewer1.ReportSource = C
        'F.CrystalReportViewer1.Refresh()
        'F.Text = "طباعة"
        'F.CrystalReportViewer1.Zoom(100%)
        'F.WindowState = FormWindowState.Maximized
        'F.Show()
    End Sub

    Private Sub AppendReportConditions()

        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " Num=@Num")
        If ChkUser.Checked And CmbUserName.Text.Trim <> "" And CmbUserName.SelectedValue <> 0 Then AppendToQuery(" AND ", " UserID=@UserID")
        If ChkSupplier.Checked And CmbSupplier.Text.Trim <> "" And CmbSupplier.SelectedValue <> 0 Then AppendToQuery(" AND ", " SupplierID=@SupplierID")
        If ChkDate.Checked Then AppendToQuery(" AND ", " Date BETWEEN '" & DTPFrom.Value.Date & " " & "00:00".ToString & "' AND '" & DTPTo.Value.Date & " " & "23:59".ToString & "'")

    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    '****************************************************************************
    '------------------Pagination-------------------------------------------
    Private Sub GetPagesCount()
        PageSize = NUDPageSize.Value
        If RowsCount = PageSize Then
            PagesCount = 1

        ElseIf RowsCount Mod PageSize = 0 And RowsCount <> 0 Then
            PagesCount = RowsCount / PageSize

        Else
            PagesCount = (RowsCount \ PageSize) + 1
        End If
        TxtPagesCount.Text = PagesCount

    End Sub

    Private Sub BtnNextPage_Click(sender As Object, e As EventArgs) Handles BtnNextPage.Click

        If Not SearchActive Then Exit Sub

        CheckPageSize()

        If PageNum < PagesCount Then
            PageNum += 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnPreviousPage_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage.Click

        If Not SearchActive Then Exit Sub

        CheckPageSize()

        If PageNum > 1 Then
            PageNum -= 1
        Else
            PageNum = 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnFirstPage_Click(sender As Object, e As EventArgs) Handles BtnFirstPage.Click

        If Not SearchActive Then Exit Sub
        PageNum = 1
        GetData(Data.Search)

    End Sub

    Private Sub BtnLastPage_Click(sender As Object, e As EventArgs) Handles BtnLastPage.Click

        If Not SearchActive Then Exit Sub

        CheckPageSize()
        PageNum = PagesCount
        GetData(Data.Search)

    End Sub

    Private Sub TxtPageNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPageNum.KeyDown

        If e.KeyCode = Keys.Enter Then
            CheckPageSize()

            If Val(TxtPageNum.Text) > Val(TxtPagesCount.Text) Then
                PageNum = TxtPagesCount.Text

            ElseIf Val(TxtPageNum.Text) <= 0 Then
                PageNum = 1

            Else
                PageNum = Val(TxtPageNum.Text)
            End If
            GetData(Data.Search)
        End If

    End Sub

    Private Sub TxtPageNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPageNum.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        End If
    End Sub

    Private Sub CheckPageSize()

        If PageSize <> My.Settings.PageSize Then
            PageNum = 1
            GetData(Data.Search) 'عند تغيير حجم الصفحة يجب معرفة عدد الصفحات الجديد PagesCount
        End If

    End Sub

    Private Sub DGVPurchases_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPurchases.CellContentClick
        If DGVPurchases.RowCount = 0 Then Exit Sub

        PurchaseID = DGVPurchases.Item(0, DGVPurchases.CurrentRow.Index).Value

        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If Col = "ColDel" Then

            If vbYes = MsgBox("هل تريد حذف الفاتورة رقم  " & vbCrLf & "( " & DGVPurchases.Item(2, DGVPurchases.CurrentRow.Index).Value & " ) ؟", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الحذف") Then
                Dim SQLCon = New SQLConClass
                Dim Param() As SqlParameter = {
                    New SqlParameter("@ID", PurchaseID)}

                DSDel = SQLCon.CMDExecuteData("DeletePurchase", Param)

                If Save = 1 Then
                    MsgTool("تم حذف الفاتورة ", 1)

                ElseIf Save = 2 Then
                    MsgTool("لا يمكن حذف الفاتورة", 0)
                End If
            End If

        ElseIf Col = "ColShow" Then
            If PurchaseID = 0 Then Exit Sub
            FrmPurchaseInvoiceContents.PurchasesID = PurchaseID
            FrmPurchaseInvoiceContents.ShowDialog()

        End If

        BtnNew_Click(sender, e)

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

        DGVPurchases.Rows.Clear()
    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click
        If Not ChkNum.Checked And Not ChkUser.Checked And Not ChkDate.Checked And Not ChkSupplier.Checked Then Exit Sub

        TxtPageNum.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

End Class