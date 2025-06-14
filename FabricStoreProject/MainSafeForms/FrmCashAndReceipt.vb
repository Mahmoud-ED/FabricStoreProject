Public Class FrmCashAndReceipt
    Private PageSize, PagesCount, RowsCount As Integer
    Private PageNum As Integer = 1
    Private SearchActive As Boolean ' باش نعرف امتى نسمح للبطم متع البيجينشن امتى يخدموا وامتى لا مرات تجي ترصهم ويجيبو سيليكت وانت مكنت تبحث اصلا

    Private Enum Data
        Search
        Main
    End Enum

    Private FromChkNum As Boolean 'عندما يفتح تشك بوكس متع رقم الايصال يسكر باقي التشكات بدون مايخليهم يديرو احداث
    Private DSMain, DSSearch As New DataSet

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmCashingReport_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub FrmCashingReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            NUDPageSize.Value = My.Settings.PageSize
            GetData(Data.Main)
            TxtPagesCount.Text = 1
        Else
            If Not IsNothing(DSMain) Then
                DSMain.Clear()
            End If
            If Not IsNothing(DSSearch) Then
                DSSearch.Clear()
            End If
            DGVCashing.Rows.Clear()
        End If
    End Sub

    '-----------------------------------Sub----------------------------------------------------

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

                SQLQuery = " Select ID,Name From UserView where ID <> 1  Order By Name "
                SQLQuery &= " Select ID,Name From CashingFinanceTypeTable Order By Name  "
                SQLQuery &= " Select ID,Name From BankTable Order By Name  "
                SQLQuery &= " Select ID,Name From PaymentTypeTable    "

                DSMain = SQLCon.SelectData(SQLQuery)
                FillData(Type, DSMain, 3)

            Case Data.Search

                SQLQuery = "
SELECT * FROM (
    SELECT 
        ROW_NUMBER() OVER (ORDER BY Date DESC) AS ت,
        ID,
        Num,
        Notes,
        ReceiptName,
        Value,
        Date,
        Name,
        PayName,
        FainName,
        Type
    FROM (
        SELECT 
            dbo.CashingTable.ID,
            dbo.CashingTable.Num,
            dbo.CashingTable.Notes,
            dbo.CashingTable.ReceiptName,
            dbo.CashingTable.Value,
            dbo.CashingTable.Date,
            dbo.UserView.Name,
            dbo.PaymentTypeTable.Name AS PayName,
            dbo.CashingFinanceTypeTable.Name AS FainName,
            'صرف' AS Type
        FROM dbo.CashingTable 
        INNER JOIN dbo.UserView ON dbo.CashingTable.UserID = dbo.UserView.ID 
        INNER JOIN dbo.PaymentTypeTable ON dbo.CashingTable.PaymentTypeID = dbo.PaymentTypeTable.ID 
        INNER JOIN dbo.CashingFinanceTypeTable ON dbo.CashingTable.CashingFinanceTypeID = dbo.CashingFinanceTypeTable.ID
        WHERE dbo.CashingTable.EndService IS NULL and TrusryTypeID=3

        UNION ALL

        SELECT 
            dbo.ReceiptTable.ID,
            dbo.ReceiptTable.Num,
            dbo.ReceiptTable.NoteFor AS Notes,
            dbo.ReceiptTable.ReceiptName,
            dbo.ReceiptTable.Value,
            dbo.ReceiptTable.Date,
            dbo.ReceiptTable.ReceiptName,
            dbo.PaymentTypeTable.Name AS PayName,
            dbo.CashingFinanceTypeTable.Name AS FainName,
            'قبض' AS Type
        FROM dbo.ReceiptTable 
        INNER JOIN dbo.UserView ON dbo.ReceiptTable.UserID = dbo.UserView.ID 
        INNER JOIN dbo.PaymentTypeTable ON dbo.ReceiptTable.PaymentTypeID = dbo.PaymentTypeTable.ID 
        INNER JOIN dbo.CashingFinanceTypeTable ON dbo.ReceiptTable.ReceiptFinanceTypeID = dbo.CashingFinanceTypeTable.ID
        WHERE dbo.ReceiptTable.EndService IS NULL and TrusryTypeID=3
    ) AS CombinedData
) AS FinalData
ORDER BY Date DESC
OFFSET " & PageSize * (PageNum - 1) & " ROWS 
FETCH NEXT " & PageSize & " ROWS ONLY;
"

                SQLQuery &= "
SELECT COUNT(*) FROM (
    SELECT ID FROM dbo.CashingTable WHERE EndService IS NULL and TrusryTypeID=3
    UNION ALL
    SELECT ID FROM dbo.ReceiptTable WHERE EndService IS NULL and TrusryTypeID=3
) AS CountTable;
"
                SQLQuery &= "
SELECT 
    ISNULL((SELECT SUM(Value) FROM ReceiptTable WHERE EndService IS NULL), 0) -
    ISNULL((SELECT SUM(Value) FROM CashingTable WHERE EndService IS NULL), 0) 
    AS خزينة;
"


                DSSearch = SQLCon.SelectData(SQLQuery, 0)
                FillData(Type, DSSearch, 2)

        End Select

    End Sub

    Private Sub AppendConditions()



    End Sub

    Private Sub ChkChecks()
        'If ChkBank.Checked = False And ChkCkeck.Checked = False And ChkDate.Checked = False And ChkNots.Checked = False And ChkNum.Checked = False And ChkPayment.Checked = False And ChkReceipt.Checked = False And ChkUser.Checked = False Then Exit Sub
    End Sub



    Private Sub DGVCashing_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCashing.CellContentClick
        If DGVCashing.Rows.Count = 0 Then Exit Sub

        If DGVCashing.Item(10, DGVCashing.CurrentRow.Index).Value = "صرف" Then

            FrmViewCashing.CashID = DGVCashing.Item(0, DGVCashing.CurrentRow.Index).Value
            Dim col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
            If col = "ColShow" Then
                FrmViewCashing.ShowDialog()
                GetData(Data.Search)
            End If

        Else
            FrmViewReceipt.ReceiptID = DGVCashing.Item(0, DGVCashing.CurrentRow.Index).Value
            Dim col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
            If col = "ColShow" Then
                FrmViewReceipt.ShowDialog()
                GetData(Data.Search)
            End If
        End If


    End Sub

    Private Sub DGVCashing_DoubleClick(sender As Object, e As EventArgs) Handles DGVCashing.DoubleClick
        If DGVCashing.Rows.Count = 0 Then Exit Sub

        If DGVCashing.Item(10, DGVCashing.CurrentRow.Index).Value = "صرف" Then
            FrmViewCashing.CashID = DGVCashing.Item(0, DGVCashing.CurrentRow.Index).Value
            FrmViewCashing.ShowDialog()
            GetData(Data.Search)
        Else
            FrmViewReceipt.ReceiptID = DGVCashing.Item(0, DGVCashing.CurrentRow.Index).Value
            FrmViewReceipt.ShowDialog()
            GetData(Data.Search)
        End If

    End Sub

    Private Sub FillData(Type As Data, DS As DataSet, TCount As Integer)

        Select Case Type
            Case Data.Main

                GetData(Data.Search)
            Case Data.Search

                If DS.Tables(1).Rows.Count > 0 Then
                    RowsCount = DS.Tables(1).Rows(0).Item(0)
                End If

                If DS.Tables(1).Rows.Count > 0 Then
                    LblMain.Text = DS.Tables(2).Rows(0).Item(0)
                End If

                GetPagesCount()

                DGVCashing.Rows.Clear()
                If DS.Tables(0).Rows.Count = 0 Then MsgTool("لا توجد نتائج للبحث", 0)

                For i = 0 To DS.Tables(0).Rows.Count - 1
                    With DS.Tables(0).Rows(i)

                        DGVCashing.Rows.Add()
                        DGVCashing.Item(0, i).Value = .Item("ID")
                        DGVCashing.Item(1, i).Value = .Item("ت") 'i + 1
                        DGVCashing.Item(2, i).Value = Format(.Item("Num"), "000000")
                        DGVCashing.Item(3, i).Value = .Item("Notes")
                        DGVCashing.Item(4, i).Value = .Item("Name")
                        DGVCashing.Item(5, i).Value = Format(.Item("Value"), "0.00")
                        DGVCashing.Item(6, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DTF))
                        DGVCashing.Item(7, i).Value = .Item("ReceiptName")
                        DGVCashing.Item(8, i).Value = .Item("PayName")
                        DGVCashing.Item(9, i).Value = .Item("FainName")
                        DGVCashing.Item(10, i).Value = .Item("Type")
                        Dim نوع As String = DGVCashing.Item(10, i).Value.ToString()

                        If نوع = "قبض" Then
                            DGVCashing.Item(5, i).Style.BackColor = Color.LightGreen
                        ElseIf نوع = "صرف" Then
                            DGVCashing.Item(5, i).Style.BackColor = Color.LightCoral
                        End If

                    End With
                Next
                DGVCashing.ClearSelection()

        End Select

    End Sub



    Private Sub AppendReportConditions()

    End Sub

    Private Sub DGVCashing_Click(sender As Object, e As EventArgs) Handles DGVCashing.Click
        If CheckDGVError(DGVCashing) Then Exit Sub
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

        DGVCashing.Rows.Clear()

    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click

        TxtPageNum.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

End Class