Imports System.Data.SqlClient
Imports System.Web.Services
Imports System.Web.UI.WebControls.WebParts
Imports ZXing.QrCode.Internal

Public Class FrmItemReport

    Private ID As Integer
    Private FromChkNum As Boolean 'عندما يفتح تشك بوكس متع رقم الايصال يسكر باقي التشكات بدون مايخليهم يديرو احداث
    Private DSMain, DSSearch, DSDel As New DataSet
    Private CatID, ItemID As Integer



    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmItemReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then

            ChkAll.Checked = False
            ChkAll.Checked = True
            GetData()

        Else
            If Not IsNothing(DSMain) Then
                DSMain.Clear()
            End If
            If Not IsNothing(DSSearch) Then
                DSSearch.Clear()
            End If
            DGV.Rows.Clear()
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

    Private Sub GetData()

        Dim SQLCon = New SQLConClass()
        SQLQuery = " Select ID,Name, CatID From ItemsTable  Order By Name  "
        SQLQuery += " Select ID,Name From CategoryTable  Order By Name  "
        DSMain = SQLCon.SelectData(SQLQuery, 0, Nothing)
        'FillData(DSMain)
        If DSHasTables(DSMain) Then
            CmbCat.DataSource = DSMain.Tables(1)
            CmbCat.DisplayMember = "Name"
            CmbCat.ValueMember = "ID"
            CmbCat.SelectedIndex = -1
        End If

    End Sub

    Private Sub ChkChecks()
        If ChkName.Checked = False And ChkCat.Checked = False Then Exit Sub
    End Sub

    Private Sub ChkName_CheckedChanged(sender As Object, e As EventArgs) Handles ChkName.CheckedChanged
        If ChkCat.Checked = False Then
            ChkName.Checked = False
            CmbItem.Enabled = False
            CmbItem.SelectedIndex = -1
            Exit Sub
        End If

        If ChkName.Checked Then
            ChkAll.Checked = False
            CmbItem.Enabled = True
            CmbItem.Focus()
            CmbItem.BackColor = SystemColors.Window
        Else
            CmbItem.Enabled = False
            CmbItem.SelectedIndex = -1
        End If
        DGV.Rows.Clear()

        If ChkName.Checked = False And CmbCat.SelectedValue > 0 Then
            Search()
        End If



        'DGV.Rows.Clear()
        'If ChkName.Checked = True Then

        '    CmbItem.Enabled = True
        '    CmbItem.Focus()
        '    FromChkNum = True

        'Else
        '    CmbItem.Enabled = False
        '    CmbItem.Text = ""
        '    TxtPageNum.Text = 1
        '    TxtPagesCount.Text = 1
        '    SearchActive = False
        'End If
    End Sub

    Private Sub FillData(DS As DataSet)

        'CmbCat.DataSource = DS.Tables(1)
        'CmbCat.DisplayMember = "Name"
        'CmbCat.ValueMember = "ID"
        'CmbCat.SelectedIndex = -1

        'DGV.ClearSelection()

    End Sub

    Private Sub CmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCat.SelectedIndexChanged
        'DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window

        If CmbCat.SelectedIndex = -1 Then
            CmbItem.SelectedIndex = -1
        End If

    End Sub

    Private Sub CmbCat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbCat.SelectionChangeCommitted
        CatID = CmbCat.SelectedValue
        Dim Row() As DataRow = DSMain.Tables(0).Select("CatID=" & CatID)
        If Row.Length > 0 Then
            Dim DT As DataTable = Row.CopyToDataTable
            CmbItem.DataSource = DT

            CmbItem.ValueMember = "ID"
            CmbItem.DisplayMember = "Name"
            CmbItem.SelectedIndex = -1

        Else
            CmbItem.DataSource = Nothing
        End If

        Search()
    End Sub

    Private Sub CmbCat_TextChanged(sender As Object, e As EventArgs)
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If DGV.RowCount = 0 Then Exit Sub
        'If Not IsNothing(DGV.Item(0, DGV.CurrentRow.Index).Value) Or Not IsDBNull(DGV.Item(0, DGV.CurrentRow.Index).Value) Then
        '    ID = DGV.Item(0, DGV.CurrentRow.Index).Value

        'Else
        '    Exit Sub
        'End If
        Dim cellValue As Object = DGV.Item(0, DGV.CurrentRow.Index).Value

        ' التحقق مما إذا كانت قيمة الخلية فارغة أو DBNull
        If cellValue Is Nothing OrElse Convert.IsDBNull(cellValue) OrElse String.IsNullOrWhiteSpace(Convert.ToString(cellValue)) Then
            Exit Sub ' الخروج من الإجراء الفرعي الحالي
        Else
            ID = cellValue
        End If

        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If Col = "ColDel" Then

            If MsgBox("هل أنت متأكد من أنك تريد حذف هذا الصنف ؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "تأكيد الحذف") = MsgBoxResult.Yes Then
                Dim SQLCon = New SQLConClass()
                Dim Param() As SqlParameter = {New SqlParameter("@ID", ID)}
                Select Case SQLCon.CMDExecute("DeleteItem", 1, Param)
                    Case 1
                        MsgTool("تم حذف الصنف", 1)
                    Case 2
                        MsgTool("لم يتم الحذف ، الصنف مسجل في فواتير سابقة", 0)
                End Select
                'BtnRefresh.PerformClick()
            End If

        ElseIf Col = "ColShow" Then
            If ID = 0 Then Exit Sub
            FrmItemDetails.ID = ID
            FrmItemDetails.ShowDialog()

        ElseIf Col = "ColEdit" Then
            If ID = 0 Then Exit Sub
            FrmEditQuantity.ID = ID
            FrmEditQuantity.ShowDialog()

        End If

        ChkAll_CheckedChanged(sender, e) ' إعادة تحميل البيانات بعد الحذف أو التعديل

    End Sub

    Private Sub DGVPurchases_Click(sender As Object, e As EventArgs) Handles DGV.Click
        If CheckDGVError(DGV) Then Exit Sub
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        If CheckDGVError(DGV) Then Exit Sub
        Dim CR As Integer
        CR = DGV.CurrentRow.Index
        ID = DGV.Item(0, CR).Value
        FrmItemDetails.ID = ID
        FrmItemDetails.ShowDialog()
    End Sub

    'Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
    '    'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

    '    'If Perm(0)(7) = False Then
    '    '    MsgTool("ليس لديك صلاحية الطباعة", 0)
    '    '    Exit Sub
    '    'End If

    '    If DGV.Rows.Count = 0 Then Exit Sub

    '    Dim DSPrint = New DataSet
    '    Dim SQLCon = New SQLConClass

    '    Dim Param() As SqlParameter =
    '                {New SqlParameter("@Num", Val(TxtNum.Text))}
    '    SQLQuery = " SELECT ID, Name, Num, Color, Country, Category, Price, PurchasePrice, Quantity, Type 
    '                FROM CategoryItemsView WHERE Type=1"
    '    AppendReportConditions()
    '    SQLQuery &= " SELECT * FROM CenterInfoTable"

    '    DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

    '    Dim F As New FrmPrint
    '    Dim C As New CRItemsReports

    '    C.SetDataSource(DSPrint.Tables(0))
    '    C.Subreports(0).SetDataSource(DSPrint.Tables(1))
    '    C.Subreports(1).SetDataSource(DSPrint.Tables(1))
    '    C.SetParameterValue("Title", "قائمة الأصناف")
    '    F.CrystalReportViewer1.ReportSource = C
    '    F.CrystalReportViewer1.Refresh()
    '    F.Text = "طباعة"
    '    F.CrystalReportViewer1.Zoom(100%)
    '    F.WindowState = FormWindowState.Maximized
    '    F.Show()
    'End Sub

    Private Sub BtnSaerch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CmbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbItem.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbItem_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbItem.SelectionChangeCommitted
        If CatID = 0 Then
            MsgTool("يرجى تحديد التصنيف أولاً", 0)
            CmbCat.Focus()

        Else
            ItemID = CmbItem.SelectedValue
            Search()
        End If
    End Sub

    Private Sub Search()
        DGV.Rows.Clear()

        If Not ChkAll.Checked And Not ChkCat.Checked And Not ChkName.Checked Then
            MsgTool("يرجى اختيار طريقة بحث", 0)
            Exit Sub
        End If

        IsDataMissing = False

        If CmbCat.SelectedIndex = -1 And CmbCat.Enabled Then
            CmbCat.BackColor = RedColor
            IsDataMissing = True
        End If

        If CmbItem.SelectedIndex = -1 And CmbItem.Enabled Then
            CmbItem.BackColor = RedColor
            IsDataMissing = True
        End If

        IsInputEmpty(TLPSearch)

        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim catIdForParam As Object
        Dim itemIdForParam As Object

        Dim tempCatID As Integer
        Dim tempItemID As Integer

        If CmbCat.SelectedIndex = -1 Then
            tempCatID = 0
        Else
            Integer.TryParse(CmbCat.SelectedValue?.ToString(), tempCatID)
        End If

        If CmbItem.SelectedIndex = -1 Then
            tempItemID = 0
        Else
            Integer.TryParse(CmbItem.SelectedValue?.ToString(), tempItemID)
        End If

        If tempCatID = 0 Then
            tempItemID = 0
        End If

        If tempCatID = 0 Then
            catIdForParam = DBNull.Value
        Else
            catIdForParam = tempCatID
        End If

        If tempItemID = 0 Then
            itemIdForParam = DBNull.Value
        Else
            itemIdForParam = tempItemID
        End If

        Dim SQLCon = New SQLConClass()
        Dim Param() As SqlParameter = {
        New SqlParameter("@FilterCategoryID", catIdForParam),
        New SqlParameter("@FilterItemStoreID", itemIdForParam)}
        Dim DSSearch As DataSet
        DSSearch = SQLCon.SelectData("SelectItemsGroupedByCategory", 1, Param)

        If DSSearch.Tables(0).Rows.Count > 0 Then
            FillDGV(DSSearch.Tables(0))
        End If
    End Sub

    Private Sub FillDGV(DT As DataTable)
        DGV.Rows.Clear()
        Dim ClassNum As Integer
        For I = 0 To DT.Rows.Count - 1
            With DT.Rows(I)
                DGV.Rows.Add()
                If Val(.Item("CategoryName")) > 0 Then
                    ClassNum = .Item("CategoryName")
                End If
                DGV.Item(0, I).Value = .Item("ItemStoreID")
                DGV.Item(2, I).Value = .Item("ItemStoreNum")
                DGV.Item(3, I).Value = .Item("ItemName")
                DGV.Item(4, I).Value = .Item("Quantity")
                DGV.Item(5, I).Value = .Item("PurchasePrice") ', "0.000").ToString
                DGV.Item(6, I).Value = .Item("Price") ', "0.000").ToString
                DGV.Item(7, I).Value = .Item("ItemCountry")
                DGV.Item(8, I).Value = .Item("ItemProcessedType")
                DGV.Item(9, I).Value = .Item("ItemSize")
                DGV.Item(10, I).Value = .Item("ItemColor")
                DGV.Item(11, I).Value = .Item("Type")

                If Val(.Item("Type")) = 0 Then
                    DGV.Item(3, I).Value = .Item("CategoryName")
                    DGV.Item(2, I).Value = ""
                    DGV.Item(4, I).Value = ""
                    DGV.Item(5, I).Value = ""
                End If
            End With

            DGV.ClearSelection()

        Next
        ReSerialNum(DGV)
    End Sub

    Public Sub ReSerialNum(DGV As DataGridView)
        Dim K As Integer = 1
        For i = 0 To DGV.Rows.Count - 1
            If Not DGV.Item(11, i).Value = "0" Then
                DGV.Item(1, i).Value = K
                K += 1
            End If
        Next
    End Sub

    Private Sub BtnPrintClick(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=147")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If DGV.Rows.Count = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass
        SQLQuery = " Select * From CategoryItemsView Where 1=1 "
        AppendReportConditions()
        SQLQuery &= " Order By Name SELECT * FROM CenterInfoTable"

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        Dim F As New FrmPrint
        Dim C As New CRItemsReport

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        C.SetParameterValue("Title", "قائمة الأصناف")
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()
    End Sub

    Private Sub AppendReportConditions()
        If ChkCat.Checked And CmbCat.Text <> "" And CmbCat.SelectedValue <> 0 Then AppendToQuery(" AND ", " CatID=" & CmbCat.SelectedValue)
        If ChkName.Checked And CmbItem.Text <> "" And CmbItem.SelectedValue <> 0 Then AppendToQuery(" AND ", " ID=" & CmbItem.SelectedValue)
    End Sub


    Private Sub DGV_CellFormatting1(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim buttonColumnName As String = "ColDel"
        Dim formattingAppliedForThisCell As Boolean = False

        Dim FontCell As Font
        FontCell = e.CellStyle.Font
        If DGV.Rows(e.RowIndex).Cells(11).Value = 0 Then
            e.CellStyle.Font = New Font(FontCell.Name, FontCell.Size + 1, FontCell.Style.Regular)
            e.CellStyle.BackColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
            e.CellStyle.SelectionBackColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
            e.CellStyle.ForeColor = Color.White
            e.CellStyle.SelectionForeColor = Color.White


            DGV.Rows(e.RowIndex).Cells("ColDel").Value = ""
            DGV.Rows(e.RowIndex).Cells("ColDel").ReadOnly = True
            DGV.Rows(e.RowIndex).Cells("ColDel").Style.BackColor = DGV.DefaultCellStyle.BackColor
            DGV.Rows(e.RowIndex).Cells("ColDel").Style.ForeColor = DGV.DefaultCellStyle.BackColor
            'e.CellStyle.ForeColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
            'e.CellStyle.SelectionForeColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)

        Else
            DGV.Rows(e.RowIndex).Cells("ColDel").Value = "حذف"
            DGV.Rows(e.RowIndex).Cells("ColDel").ReadOnly = False
            DGV.Rows(e.RowIndex).Cells("ColDel").Style.BackColor = DGV.DefaultCellStyle.BackColor
            DGV.Rows(e.RowIndex).Cells("ColDel").Style.ForeColor = DGV.DefaultCellStyle.ForeColor
        End If

    End Sub


    Private Sub DGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGV.DataError
        Console.WriteLine($"DataGridView DataError: Row={e.RowIndex}, Col={e.ColumnIndex} ({Me.DGV.Columns(e.ColumnIndex).Name})")
        Console.WriteLine($"Context: {e.Context.ToString()}")
        Console.WriteLine($"Exception: {e.Exception.Message}")
        If e.Exception.InnerException IsNot Nothing Then
            Console.WriteLine($"Inner Exception: {e.Exception.InnerException.Message}")
        End If
        ' لمنع ظهور مربع الحوار المزعج، يمكنك ترك هذا السطر.
        ' لكن الهدف هو إصلاح الخطأ الأساسي.
        e.ThrowException = False
    End Sub
    Private Sub ChkAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAll.CheckedChanged
        If ChkAll.Checked Then

            CmbCat.SelectedIndex = -1
            CmbCat.Enabled = False
            ChkCat.Checked = False

            CmbItem.SelectedIndex = -1
            CmbItem.Enabled = False
            ChkName.Checked = False

            Search()

        ElseIf Not ChkAll.Checked And Not ChkCat.Checked And Not ChkName.Checked Then
            DGV.Rows.Clear()
        End If

    End Sub


    Private Sub ChkCat_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCat.CheckedChanged
        If ChkCat.Checked Then
            ChkAll.Checked = False
            CmbCat.Enabled = True
            CmbCat.Focus()
            CmbCat.BackColor = SystemColors.Window

        Else
            CmbCat.Enabled = False
            CmbCat.SelectedIndex = -1
            CmbItem.DataSource = Nothing
            ChkName.Checked = False
        End If
        DGV.Rows.Clear()
    End Sub


End Class