Imports System.Data.SqlClient

Public Class FrmReceiptReport
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

    Private Sub FrmReceiptReport_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub FrmReceiptReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
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
            DGVRecipt.Rows.Clear()
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

                SQLQuery = " Select ID,Name From UserView where  ID <> 1  Order By Name "
                SQLQuery &= " Select ID,Name From ReceiptFinanceTypeTable  Order By Name  "
                SQLQuery &= " Select ID,Name From BankTable Order By Name "
                SQLQuery &= " Select ID,Name From PaymentTypeTable 
                              Select ID,Name From EmployeeTable  Order By Name   "
                DSMain = SQLCon.SelectData(SQLQuery)
                FillData(Type, DSMain, 3)

            Case Data.Search

                Dim Param() As SqlParameter =
                    {New SqlParameter("@Num", Val(TxtNum.Text)),
                     New SqlParameter("@ReceiptName", "%" & TxtReciptName.Text.Trim & "%"),
                      New SqlParameter("@CheckNum", "%" & Val(TxtCkeck.Text.Trim) & "%")}
                SQLQuery = "SELECT  ROW_NUMBER() OVER (ORDER BY (Date)Desc) As ت, dbo.ReceiptTable.ID, dbo.ReceiptTable.Num, dbo.ReceiptTable.NoteFor 
                AS Nots, dbo.ReceiptTable.ReceiptName, dbo.ReceiptTable.Value, dbo.ReceiptTable.Date,
                dbo.UserView.Name, dbo.PaymentTypeTable.Name AS PayName, dbo.ReceiptFinanceTypeTable.Name 
                AS ReciptTypeName, dbo.ReceiptTable.EndService, dbo.ReceiptTable.EmployeeID, 
                dbo.EmployeeTable.Name AS EmployeeName ,ReceiptTable.IncreaseValue
                FROM  dbo.UserView INNER JOIN
                dbo.ReceiptTable ON dbo.UserView.ID = dbo.ReceiptTable.UserID INNER JOIN
                dbo.PaymentTypeTable ON dbo.ReceiptTable.PaymentTypeID = dbo.PaymentTypeTable.ID 
                INNER JOIN dbo.ReceiptFinanceTypeTable ON dbo.ReceiptTable.ReceiptFinanceTypeID 
                = dbo.ReceiptFinanceTypeTable.ID INNER JOIN
                dbo.EmployeeTable ON dbo.ReceiptTable.EmployeeID = dbo.EmployeeTable.ID
                WHERE (dbo.ReceiptTable.EndService IS NULL) "

                AppendConditions()
                SQLQuery &= " ORDER BY ReceiptTable.Date Desc OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
                SQLQuery &= " SELECT COUNT(ID) FROM ReceiptTable WHERE EndService IS NULL "
                AppendConditions()

                'If ChkNum.Checked And TxtNum.Text.Trim <> "" And ChkReceipt.Checked And TxtReciptName.Text.Trim <> "" And ChkUser.Checked And CmbUserName.SelectedValue <> Nothing And ChkNots.Checked And CmbFinancRecipt.SelectedValue <> Nothing And ChkPayment.Checked And CmbPaymentType.SelectedValue <> Nothing Then
                '    Exit Sub
                'End If

                DSSearch = SQLCon.SelectData(SQLQuery, 0, Param)
                FillData(Type, DSSearch, 2)

        End Select

    End Sub

    Private Sub AppendConditions()

        Dim DateTimeFrom As Date = DTPFrom.Value.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTPTo.Value.Date & " " & "23:59".ToString
        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " ReceiptTable.Num=@Num ")
        If ChkReceipt.Checked And TxtReciptName.Text.Trim <> "" Then AppendToQuery(" AND ", " ReceiptName  LIKE @ReceiptName ")
        If ChkUser.Checked And CmbUserName.SelectedValue <> Nothing Then AppendToQuery(" AND ", "  dbo.ReceiptTable.UserID = " & CmbUserName.SelectedValue)
        If ChkEmp.Checked And CmbEmp.SelectedValue <> Nothing Then AppendToQuery(" AND ", " dbo.ReceiptTable.EmployeeID = " & CmbEmp.SelectedValue)
        If ChkNots.Checked And CmbFinancRecipt.SelectedValue <> Nothing Then AppendToQuery(" AND ", " ReceiptFinanceTypeID = " & CmbFinancRecipt.SelectedValue)
        If ChkPayment.Checked And CmbPaymentType.SelectedValue <> Nothing Then AppendToQuery(" AND ", " PaymentTypeID = " & CmbPaymentType.SelectedValue)
        If ChkBank.Checked And CmbBank.SelectedValue <> Nothing Then AppendToQuery(" AND ", " BankID = " & CmbBank.SelectedValue)
        If ChkCkeck.Checked And TxtCkeck.Text.Trim <> "" Then AppendToQuery(" AND ", " CkeckNum  LIKE @CheckNum ")
        If ChkDate.Checked Then AppendToQuery(" AND ", " Date BETWEEN '" & DateTimeFrom & "' AND '" & DateTimeTo & "' ")


    End Sub

    Private Sub ChkChecks()
        If ChkBank.Checked = False And ChkCkeck.Checked = False And ChkDate.Checked = False And ChkNots.Checked = False And ChkNum.Checked = False And ChkPayment.Checked = False And ChkReceipt.Checked = False And ChkUser.Checked = False And ChkEmp.Checked = False Then Exit Sub
    End Sub

    Private Sub BtnSaerch_Click(sender As Object, e As EventArgs) Handles BtnSaerch.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        DGVRecipt.Rows.Clear()
        ChkChecks()
        If ChkBank.Checked = False And ChkCkeck.Checked = False And ChkDate.Checked = False And ChkNots.Checked = False And ChkNum.Checked = False And ChkPayment.Checked = False And ChkReceipt.Checked = False And ChkUser.Checked = False And ChkEmp.Checked = False Then
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
        DGVRecipt.Rows.Clear()
        TxtReciptName.BackColor = SystemColors.Window
        If ChkNum.Checked = True Then

            TxtNum.Enabled = True
            TxtNum.Focus()
            FromChkNum = True
            ChkUser.Checked = False
            ChkReceipt.Checked = False
            ChkPayment.Checked = False
            ChkNots.Checked = False
            ChkDate.Checked = False
            ChkCkeck.Checked = False
            ChkBank.Checked = False
            ChkEmp.Checked = False

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
        DGVRecipt.Rows.Clear()
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

    Private Sub ChkEmp_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEmp.CheckedChanged
        DGVRecipt.Rows.Clear()
        CmbEmp.BackColor = SystemColors.Window

        If ChkEmp.Checked = True Then
            CmbEmp.Enabled = True
            CmbEmp.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            ' ChangeControlColor(Me)
            CmbEmp.Text = ""
            CmbEmp.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkReceipt_CheckedChanged(sender As Object, e As EventArgs) Handles ChkReceipt.CheckedChanged
        DGVRecipt.Rows.Clear()
        TxtReciptName.BackColor = SystemColors.Window

        If ChkReceipt.Checked = True Then
            TxtReciptName.Enabled = True
            TxtReciptName.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            'ChangeControlColor(Me)
            TxtReciptName.Enabled = False
            TxtReciptName.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkNots_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNots.CheckedChanged
        DGVRecipt.Rows.Clear()
        CmbFinancRecipt.BackColor = SystemColors.Window

        If ChkNots.Checked Then
            CmbFinancRecipt.Enabled = True
            CmbFinancRecipt.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            ' ChangeControlColor(Me)
            CmbFinancRecipt.Enabled = False
            CmbFinancRecipt.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDate.CheckedChanged
        DGVRecipt.Rows.Clear()
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

    Private Sub ChkPayment_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPayment.CheckedChanged
        DGVRecipt.Rows.Clear()
        CmbPaymentType.BackColor = SystemColors.Window
        If ChkPayment.Checked Then
            CmbPaymentType.Enabled = True
            CmbPaymentType.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            'ChangeControlColor(Me)
            CmbPaymentType.Enabled = False
            CmbPaymentType.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkBank_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBank.CheckedChanged
        DGVRecipt.Rows.Clear()
        CmbBank.BackColor = SystemColors.Window

        If ChkBank.Checked Then
            CmbBank.Enabled = True
            CmbBank.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            ' ChangeControlColor(Me)
            CmbBank.Enabled = False
            CmbBank.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkCkeck_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCkeck.CheckedChanged
        DGVRecipt.Rows.Clear()
        TxtCkeck.BackColor = SystemColors.Window

        If ChkCkeck.Checked Then
            TxtCkeck.Enabled = True
            TxtCkeck.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            ' ChangeControlColor(Me)
            TxtCkeck.Enabled = False
            TxtCkeck.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ChangeControlColor(Me)
        DGVRecipt.Rows.Clear()
        ChkBank.Checked = False
        ChkCkeck.Checked = False
        ChkDate.Checked = True
        ChkNots.Checked = False
        ChkNum.Checked = False
        ChkPayment.Checked = False
        ChkReceipt.Checked = False
        ChkUser.Checked = False
        ChkEmp.Checked = False
        SearchActive = False
    End Sub

    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles TxtNum.TextChanged, CmbBank.TextChanged, CmbFinancRecipt.TextChanged, CmbPaymentType.TextChanged, CmbUserName.TextChanged, TxtReciptName.TextChanged
        DGVRecipt.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub DGVRecipt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRecipt.CellContentClick
        If DGVRecipt.Rows.Count = 0 Then Exit Sub
        FrmViewReceipt.ReceiptID = DGVRecipt.Item(0, DGVRecipt.CurrentRow.Index).Value
        Dim col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If col = "ColShow" Then
            FrmViewReceipt.ShowDialog()
            GetData(Data.Search)
        End If
    End Sub
    Private Sub DGVRecipt_DoubleClick(sender As Object, e As EventArgs) Handles DGVRecipt.DoubleClick
        If DGVRecipt.Rows.Count = 0 Then Exit Sub
        FrmViewReceipt.ReceiptID = DGVRecipt.Item(0, DGVRecipt.CurrentRow.Index).Value
        FrmViewReceipt.ShowDialog()
        GetData(Data.Search)
    End Sub

    Private Sub FillData(Type As Data, DS As DataSet, TCount As Integer)

        Select Case Type
            Case Data.Main
                CmbBank.DataSource = DS.Tables(2)
                CmbFinancRecipt.DataSource = DS.Tables(1)
                CmbPaymentType.DataSource = DS.Tables(3)
                CmbUserName.DataSource = DS.Tables(0)
                CmbEmp.DataSource = DS.Tables(4)

                CmbBank.DisplayMember = "Name"
                CmbFinancRecipt.DisplayMember = "Name"
                CmbPaymentType.DisplayMember = "Name"
                CmbUserName.DisplayMember = "Name"
                CmbEmp.DisplayMember = "Name"

                CmbUserName.ValueMember = "ID"
                CmbPaymentType.ValueMember = "ID"
                CmbFinancRecipt.ValueMember = "ID"
                CmbBank.ValueMember = "ID"
                CmbEmp.ValueMember = "ID"

                CmbBank.SelectedIndex = -1
                CmbFinancRecipt.SelectedIndex = -1
                CmbPaymentType.SelectedValue = -1
                CmbUserName.SelectedIndex = -1
                CmbEmp.SelectedIndex = -1

            Case Data.Search
                If DS.Tables(1).Rows.Count > 0 Then
                    RowsCount = DS.Tables(1).Rows(0).Item(0)
                End If
                GetPagesCount()

                DGVRecipt.Rows.Clear()
                If DS.Tables(0).Rows.Count = 0 Then MsgTool("لا توجد نتائج للبحث", 0)

                For i = 0 To DS.Tables(0).Rows.Count - 1
                    With DS.Tables(0).Rows(i)

                        DGVRecipt.Rows.Add()
                        DGVRecipt.Item(0, i).Value = .Item("ID")
                        DGVRecipt.Item(1, i).Value = .Item("ت") 'i + 1
                        DGVRecipt.Item(2, i).Value = Format(.Item("Num"), "000000")
                        DGVRecipt.Item(3, i).Value = .Item("Nots")
                        DGVRecipt.Item(4, i).Value = .Item("ReceiptName")
                        DGVRecipt.Item(5, i).Value = Format(.Item("Value"), "0.000")
                        DGVRecipt.Item(6, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DTF))
                        DGVRecipt.Item(7, i).Value = .Item("Name")
                        DGVRecipt.Item(8, i).Value = .Item("PayName")
                        DGVRecipt.Item(9, i).Value = .Item("ReciptTypeName")
                        DGVRecipt.Item(10, i).Value = .Item("EmployeeName")
                        DGVRecipt.Item(11, i).Value = .Item("IncreaseValue")

                    End With
                Next
                DGVRecipt.ClearSelection()

        End Select

    End Sub

    Private Sub DGVRecipt_Click(sender As Object, e As EventArgs) Handles DGVRecipt.Click
        If CheckDGVError(DGVRecipt) Then Exit Sub
    End Sub

    Private Sub TxtReciptName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtReciptName.KeyPress, CmbUserName.KeyPress, CmbFinancRecipt.KeyPress, CmbPaymentType.KeyPress, CmbBank.KeyPress
        ''If Char.IsNumber(e.KeyChar) = True Then
        ''    e.Handled = True
        ''End If

        'If Char.IsNumber(e.KeyChar) = True Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub DTPFrom_ValueChanged(sender As Object, e As EventArgs) Handles DTPFrom.ValueChanged
        DGVRecipt.Rows.Clear()

    End Sub

    Private Sub DTPTo_ValueChanged(sender As Object, e As EventArgs) Handles DTPTo.ValueChanged
        DGVRecipt.Rows.Clear()

    End Sub

    Private Sub CmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUserName.SelectedIndexChanged
        DGVRecipt.Rows.Clear()

    End Sub

    Private Sub CmbEmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEmp.SelectedIndexChanged
        DGVRecipt.Rows.Clear()
    End Sub

    Private Sub CmbEmp_TextChanged(sender As Object, e As EventArgs) Handles CmbEmp.TextChanged
        DGVRecipt.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbFinancRecipt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFinancRecipt.SelectedIndexChanged
        DGVRecipt.Rows.Clear()

    End Sub

    Private Sub CmbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPaymentType.SelectedIndexChanged
        DGVRecipt.Rows.Clear()

    End Sub

    Private Sub CmbBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBank.SelectedIndexChanged
        DGVRecipt.Rows.Clear()

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
        If ChkReceipt.Checked And TxtReciptName.Text.Trim <> "" Then AppendToQuery(" AND ", " ReceiptName Like @ReceiptName")
        If ChkPayment.Checked And CmbPaymentType.Text.Trim <> "" And CmbPaymentType.SelectedValue <> Nothing Then AppendToQuery(" AND ", " PaymentTypeID=@PaymentTypeID")
        If ChkUser.Checked And CmbUserName.Text.Trim <> "" And CmbUserName.SelectedValue <> 0 Then AppendToQuery(" AND ", " UserID=@UserID")
        If ChkBank.Checked And CmbBank.Text.Trim <> "" And CmbBank.SelectedValue <> 0 Then AppendToQuery(" AND ", " BankID=@BankID")
        If ChkNots.Checked And CmbFinancRecipt.Text.Trim <> "" And CmbFinancRecipt.SelectedValue <> 0 Then AppendToQuery(" AND ", " ReceiptFinanceTypeID=@ReceiptFinanceTypeID")
        If ChkCkeck.Checked And TxtCkeck.Text.Trim <> "" Then AppendToQuery(" AND ", " CkeckNum LIKE @Check")
        If ChkDate.Checked Then AppendToQuery(" AND ", " Date BETWEEN '" & DTPFrom.Value.Date & " " & "00:00".ToString & "' AND '" & DTPTo.Value.Date & " " & "23:59".ToString & "'")

    End Sub

    Private Sub TxtCkeck_TextChanged(sender As Object, e As EventArgs) Handles TxtCkeck.TextChanged
        TxtCkeck.BackColor = SystemColors.Window
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

        DGVRecipt.Rows.Clear()
    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click
        If Not ChkNum.Checked And Not ChkUser.Checked And Not ChkReceipt.Checked And Not ChkNots.Checked And Not ChkDate.Checked And Not ChkPayment.Checked And Not ChkBank.Checked And Not ChkCkeck.Checked And Not ChkEmp.Checked Then Exit Sub

        TxtPageNum.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtCkeck_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCkeck.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub
End Class