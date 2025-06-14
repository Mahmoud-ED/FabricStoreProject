Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class FrmPreparingClothesReport

    Private ID As Integer
    Private FromChkNum As Boolean 'عندما يفتح تشك بوكس متع رقم الايصال يسكر باقي التشكات بدون مايخليهم يديرو احداث
    Private DSMain, DSSearch, DSDel As New DataSet
    Private CatID, ItemID As Integer



    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmItemReport_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then

            GetData()
            Search()
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
        SQLQuery = " Select ID,Name From TailorsTable  Order By Name  "
        DSMain = SQLCon.SelectData(SQLQuery, 0, Nothing)
        'FillData(DSMain)
        If DSHasTables(DSMain) Then
            CmbTailor.DataSource = DSMain.Tables(0)
            CmbTailor.DisplayMember = "Name"
            CmbTailor.ValueMember = "ID"
            CmbTailor.SelectedIndex = -1
        End If

    End Sub

    Private Sub ChkChecks()
        If ChkDate.Checked = False And ChkTailor.Checked = False Then Exit Sub
    End Sub

    Private Sub ChkName_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTailor.CheckedChanged

        If ChkTailor.Checked Then
            CmbTailor.Enabled = True
            CmbTailor.Focus()
            CmbTailor.BackColor = SystemColors.Window
        Else
            CmbTailor.Enabled = False
            CmbTailor.SelectedIndex = -1
        End If
        DGV.Rows.Clear()

        If ChkTailor.Checked = False And CmbTailor.SelectedValue > 0 Then
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

    Private Sub CmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTailor.SelectedIndexChanged
        'DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window

    End Sub

    Private Sub CmbCat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbTailor.SelectionChangeCommitted
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

        ElseIf Col = "ColEdit" Then
            If ID = 0 Then Exit Sub
            FrmEditQuantity.ID = ID
            FrmEditQuantity.ShowDialog()

        End If

        Search()
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

    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked Then
            DTPFromDate.Enabled = True
            DTPToDate.Enabled = True
        Else
            DTPFromDate.Enabled = False
            DTPToDate.Enabled = False
        End If
    End Sub

    Private Sub DTPFromDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPFromDate.ValueChanged
        Search()
    End Sub

    Private Sub DTPToDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPToDate.ValueChanged
        Search()
    End Sub

    Private Sub Search()
        DGV.Rows.Clear()

        IsDataMissing = False

        If CmbTailor.SelectedIndex = -1 And CmbTailor.Enabled Then
            CmbTailor.BackColor = RedColor
            IsDataMissing = True
        End If


        IsInputEmpty(TLPSearch)

        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If



        Dim SQLCon = New SQLConClass()
        Dim DSSearch As DataSet

        SQLQuery = " Select * from PreparingClothesView where 1=1 "

        If ChkTailor.Checked And Not IsNothing(CmbTailor.SelectedValue) Then
            SQLQuery += " and TailorID=" & CmbTailor.SelectedValue
        End If

        If ChkDate.Checked Then
            Dim DateTimeFrom As Date = DTPFromDate.Value.Date & " " & "00:00".ToString
            Dim DateTimeTo As Date = DTPToDate.Value.Date & " " & "23:59".ToString

            AppendToQuery(" And ", " Date BETWEEN '" & DateTimeFrom & "' AND '" & DateTimeTo & "' ")
        End If


        DSSearch = SQLCon.SelectData(SQLQuery)

        If DSSearch.Tables(0).Rows.Count > 0 Then
            FillDGV(DSSearch.Tables(0))
        End If
    End Sub

    Private Sub FillDGV(DT As DataTable)
        DGV.Rows.Clear()
        For I = 0 To DT.Rows.Count - 1
            With DT.Rows(I)
                DGV.Rows.Add()
                DGV.Item(0, I).Value = .Item("ID")
                DGV.Item(1, I).Value = I + 1
                DGV.Item(2, I).Value = .Item("Name")
                DGV.Item(3, I).Value = .Item("Num")
                DGV.Item(4, I).Value = .Item("Quantity")
                DGV.Item(5, I).Value = .Item("Size")
                DGV.Item(6, I).Value = .Item("TailorPrice") ', "0.00").ToString
                DGV.Item(7, I).Value = .Item("PurchasePrice") ', "0.00").ToString
                DGV.Item(8, I).Value = .Item("SellPrice") ', "0.00").ToString
                DGV.Item(9, I).Value = .Item("TailorName")
            End With

            DGV.ClearSelection()

        Next

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

    Private Sub FrmPreparingClothesReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        DTPToDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
        DTPFromDate.CustomFormat = GetDateAndTimeFormat(DTFormat.DF)
    End Sub
End Class