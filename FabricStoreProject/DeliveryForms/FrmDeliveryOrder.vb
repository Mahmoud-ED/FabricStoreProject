Imports System.Data.SqlClient
Imports System.Web.Services
Imports System.Web.Services.Description

Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports ZXing ' مكتبة إنشاء الباركود
Imports ZXing.Common ' لمزيد من خيارات ZXing


Public Class FrmDeliveryOrder

    Private PageSize, PagesCount, RowsCount, OrderID As Integer
    Private PageNum As Integer = 1
    Private SearchActive As Boolean

    Private FromChkNum As Boolean
    Private DSMain, DSSearch, DSEdit, DSDel As New DataSet
    Private DTDelivery, DTCity As New DataTable
    Private Enum Data
        Search
        Main
    End Enum

    Private Sub FrmDeliveryOrder_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
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
            DGV.Rows.Clear()
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
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
                SQLQuery &= " Select ID,Name From DeliveryTable  Order By Name  "
                SQLQuery &= " Select * From CityTable  Order By Name  "

                DSMain = SQLCon.SelectData(SQLQuery)
                FillData(Type, DSMain, 4)

            Case Data.Search

                Dim Param() As SqlParameter =
                    {New SqlParameter("@InvoiceNum", Val(TxtNum.Text))}
                SQLQuery = "SELECT  ROW_NUMBER() OVER (ORDER BY (InvoiceDate)Desc) As ت, * From DeliveryOrderView 
                            WHERE InvoiceEndService IS NULL And OrderEndService IS NULL"

                AppendConditions()
                SQLQuery &= " ORDER BY DeliveryOrderView.InvoiceDate Desc OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
                SQLQuery &= " SELECT COUNT(ID) FROM DeliveryOrderView WHERE InvoiceEndService IS NULL And OrderEndService IS NULL "
                AppendConditions()

                DSSearch = SQLCon.SelectData(SQLQuery, 0, Param)
                FillData(Type, DSSearch, 2)

        End Select

    End Sub

    Private Sub FillData(Type As Data, DS As DataSet, TCount As Integer)

        Select Case Type
            Case Data.Main
                CmbUserName.DataSource = DS.Tables(0)
                CmbUserName.DisplayMember = "Name"
                CmbUserName.ValueMember = "ID"
                CmbUserName.SelectedIndex = -1

                CmbDelivery.DataSource = DS.Tables(1)
                CmbDelivery.DisplayMember = "Name"
                CmbDelivery.ValueMember = "ID"
                CmbDelivery.SelectedIndex = -1

                'DTDelivery = DS.Tables(1).Copy
                'CmbDeliveryOrder.DataSource = DTDelivery
                'CmbDeliveryOrder.DisplayMember = "Name"
                'CmbDeliveryOrder.ValueMember = "ID"
                'CmbDeliveryOrder.SelectedIndex = -1

                CmbCity.DataSource = DS.Tables(2)
                CmbCity.DisplayMember = "Name"
                CmbCity.ValueMember = "ID"
                CmbCity.SelectedIndex = -1

                'DTCity = DS.Tables(2).Copy
                'CmbCityOrder.DataSource = DTCity
                'CmbCityOrder.DisplayMember = "Name"
                'CmbCityOrder.ValueMember = "ID"
                'CmbCityOrder.SelectedIndex = -1

            Case Data.Search
                If DS.Tables(1).Rows.Count > 0 Then
                    RowsCount = DS.Tables(1).Rows(0).Item(0)
                End If
                GetPagesCount()

                DGV.Rows.Clear()
                If DS.Tables(0).Rows.Count = 0 Then MsgTool("لا توجد نتائج للبحث", 0)

                For i = 0 To DS.Tables(0).Rows.Count - 1
                    With DS.Tables(0).Rows(i)

                        DGV.Rows.Add()
                        DGV.Item(0, i).Value = .Item("ID")
                        DGV.Item(1, i).Value = .Item("ت") 'i + 1
                        DGV.Item(2, i).Value = .Item("Num")
                        DGV.Item(3, i).Value = Format(.Item("InvoiceDate"), GetDateAndTimeFormat(DTFormat.DTF))
                        DGV.Item(4, i).Value = .Item("DeliveryName")
                        DGV.Item(5, i).Value = .Item("CustomerName")
                        DGV.Item(6, i).Value = .Item("CityName")
                        DGV.Item(7, i).Value = .Item("Phone")
                        DGV.Item(8, i).Value = Format(.Item("Total"), "0.00")
                        DGV.Item(9, i).Value = Format(.Item("Price"), "0.00")
                        DGV.Item(10, i).Value = Format(.Item("DeliveryTotal"), "0.00")

                        If IsDBNull(.Item("RegDate")) Then
                            DGV.Item(11, i).Value = "-"
                        Else
                            DGV.Item(11, i).Value = Format(.Item("RegDate"), GetDateAndTimeFormat(DTFormat.DTF))
                        End If

                        If IsDBNull(.Item("DeliveryDate")) Then
                            DGV.Item(12, i).Value = "-"
                        Else

                            DGV.Item(12, i).Value = Format(.Item("DeliveryDate"), GetDateAndTimeFormat(DTFormat.DTF))
                        End If
                        DGV.Item(13, i).Value = .Item("CityID")
                        DGV.Item(14, i).Value = .Item("DeliveryID")
                        DGV.Item(15, i).Value = .Item("Address")

                    End With
                Next
                DGV.ClearSelection()

        End Select

    End Sub

    Private Sub AppendConditions()

        Dim DateTimeFrom As Date = DTPFrom.Value.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTPTo.Value.Date & " " & "23:59".ToString
        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " DeliveryOrderView.Num=@InvoiceNum ")
        If ChkUser.Checked And CmbUserName.SelectedValue <> Nothing Then AppendToQuery(" AND ", "  dbo.DeliveryOrderView.UserID = " & CmbUserName.SelectedValue)
        If ChkDelivery.Checked And CmbDelivery.SelectedValue <> Nothing Then AppendToQuery(" AND ", " dbo.DeliveryOrderView.DeliveryID = " & CmbDelivery.SelectedValue)
        If ChkCity.Checked And CmbCity.SelectedValue <> Nothing Then AppendToQuery(" AND ", " dbo.DeliveryOrderView.CityID = " & CmbCity.SelectedValue)
        If ChkDate.Checked Then AppendToQuery(" AND ", " InvoiceDate BETWEEN '" & DateTimeFrom & "' AND '" & DateTimeTo & "' ")
        If ChkOrder.Checked Then
            If RadReady.Checked Then
                AppendToQuery(" AND ", " dbo.DeliveryOrderView.DeliveryDate IS NOT NULL")
            End If

            If RadOrder.Checked Then
                AppendToQuery(" AND ", " dbo.DeliveryOrderView.DeliveryDate IS NULL")
            End If
        End If
    End Sub

    Private Sub ChkChecks()
        If ChkDate.Checked = False And ChkNum.Checked = False And ChkUser.Checked = False And ChkDelivery.Checked = False And ChkCity.Checked = False And ChkOrder.Checked = False Then Exit Sub
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        DGV.Rows.Clear()
        ChkChecks()
        If ChkDate.Checked = False And ChkNum.Checked = False And ChkUser.Checked = False And ChkDelivery.Checked = False And ChkCity.Checked = False And ChkOrder.Checked = False Then
            MsgTool("يرجى اختيار طريقة بحث", 0)
            Exit Sub
        End If
        If ChkOrder.Checked And RadOrder.Checked = False And RadReady.Checked = False Then
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
        DGV.Rows.Clear()
        If ChkNum.Checked = True Then

            TxtNum.Enabled = True
            TxtNum.Focus()
            FromChkNum = True
            ChkUser.Checked = False
            ChkDate.Checked = False
            ChkDelivery.Checked = False
            ChkCity.Checked = False
            ChkOrder.Checked = False

        Else
            'ChkDate.Checked = True
            TxtNum.Enabled = False
            TxtNum.Text = ""
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If

    End Sub

    Private Sub ChkUser_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUser.CheckedChanged
        DGV.Rows.Clear()
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

    Private Sub ChkDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDelivery.CheckedChanged
        DGV.Rows.Clear()
        CmbDelivery.BackColor = SystemColors.Window

        If ChkDelivery.Checked = True Then
            CmbDelivery.Enabled = True
            CmbDelivery.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            CmbDelivery.Text = ""
            CmbDelivery.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkCity_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCity.CheckedChanged
        DGV.Rows.Clear()
        CmbCity.BackColor = SystemColors.Window

        If ChkCity.Checked = True Then
            CmbCity.Enabled = True
            CmbCity.Focus()
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            CmbCity.Text = ""
            CmbCity.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub ChkDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDate.CheckedChanged
        DGV.Rows.Clear()
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

    Private Sub RadReady_CheckedChanged(sender As Object, e As EventArgs) Handles RadReady.CheckedChanged
        DGV.Rows.Clear()
    End Sub

    Private Sub RadOrder_CheckedChanged(sender As Object, e As EventArgs) Handles RadOrder.CheckedChanged
        DGV.Rows.Clear()
    End Sub

    Private Sub ChkOrder_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOrder.CheckedChanged
        DGV.Rows.Clear()

        If ChkOrder.Checked = True Then
            RadOrder.Enabled = True
            RadReady.Enabled = True
            If ChkNum.Checked = True Then ChkNum.Checked = False

        Else
            RadOrder.Enabled = False
            RadReady.Enabled = False
            TxtPageNum.Text = 1
            TxtPagesCount.Text = 1
            SearchActive = False
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ChangeControlColor(Me)
        DGV.Rows.Clear()
        ChkDate.Checked = True
        ChkDelivery.Checked = False
        ChkCity.Checked = False
        ChkNum.Checked = False
        ChkOrder.Checked = False
        ChkUser.Checked = False
        SearchActive = False
    End Sub


    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If DGV.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub

        OrderID = Convert.ToInt32(DGV.Item(0, e.RowIndex).Value)
        FrmDeliveryOrderData.OrderID = OrderID

        Dim ColName As String = DGV.Columns(e.ColumnIndex).Name

        If ColName = "ColEdit" Then
            FrmDeliveryOrderData.ShowDialog()

        ElseIf ColName = "ColDel" Then
            If vbYes = MsgBox("هل تريد إلغاء طلب توصيل فاتورة رقم " & vbCrLf & "( " & Format(DGV.Item(2, e.RowIndex).Value, "000000") & " )  ", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الإلغاء") Then
                Dim SQLCon = New SQLConClass
                Dim Param() As SqlParameter = {New SqlParameter("@ID", OrderID)}

                DSDel = SQLCon.CMDExecuteData("DeleteDeliveryInvo", Param)
                If Save = 1 Then
                    MsgTool("تمت إلغاء طلب التوصيل", 1)
                    BtnSearch_Click(sender, e)
                End If
            End If

        ElseIf ColName = "ColPrint" Then
            Dim DSPrint = New DataSet
            Dim SQLCon = New SQLConClass

            SQLQuery = "  SELECT   Format(Num,'000000') AS Num, InvoiceDate, DeliveryName, CustomerName, CityName, Address, Phone, Total, Price,
                     DeliveryTotal, RegDate, DeliveryDate  From DeliveryOrderView WHERE InvoiceEndService IS NULL And OrderEndService IS NULL And ID=@ID"
            SQLQuery &= " SELECT * FROM CenterInfoTable"

            Dim Param() As SqlParameter = {New SqlParameter("@ID", OrderID)}

            DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

            Dim F As New FrmPrint
            Dim C As New CRDeliveryOrderBarCode

            C.SetDataSource(DSPrint.Tables(0))
            C.Subreports(0).SetDataSource(DSPrint.Tables(1))
            C.Subreports(1).SetDataSource(DSPrint.Tables(1))
            F.CrystalReportViewer1.ReportSource = C
            F.CrystalReportViewer1.Refresh()
            F.Text = "طباعة"
            F.CrystalReportViewer1.Zoom(100%)
            F.WindowState = FormWindowState.Maximized
            F.Show()
        End If
    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        If CheckDGVError(DGV) Then Exit Sub
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        If DGV.RowCount = 0 OrElse DGV.CurrentRow Is Nothing Then Exit Sub

        OrderID = Convert.ToInt32(DGV.CurrentRow.Cells(0).Value)
        FrmDeliveryOrderData.OrderID = OrderID
        FrmDeliveryOrderData.ShowDialog()

    End Sub

    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles TxtNum.TextChanged, CmbUserName.TextChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub DTPFrom_ValueChanged(sender As Object, e As EventArgs) Handles DTPFrom.ValueChanged
        DGV.Rows.Clear()
    End Sub

    Private Sub DTPTo_ValueChanged(sender As Object, e As EventArgs) Handles DTPTo.ValueChanged
        DGV.Rows.Clear()
    End Sub

    Private Sub CmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUserName.SelectedIndexChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDelivery.SelectedIndexChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbDelivery_TextChanged(sender As Object, e As EventArgs) Handles CmbDelivery.TextChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCity.SelectedIndexChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCity_TextChanged(sender As Object, e As EventArgs) Handles CmbCity.TextChanged
        DGV.Rows.Clear()
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPhone_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsPhone(sender.Text, e)
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If DGV.Rows.Count = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "  SELECT   Format(Num,'000000') AS Num, InvoiceDate, DeliveryName, CustomerName, CityName, Address, Phone, Total, Price,
                     DeliveryTotal, RegDate, DeliveryDate  From DeliveryOrderView WHERE InvoiceEndService IS NULL And OrderEndService IS NULL"
        AppendReportConditions()
        SQLQuery &= " ORDER BY DeliveryOrderView.InvoiceDate Desc OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        Dim Param() As SqlParameter = {New SqlParameter("@InvoiceNum", Val(TxtNum.Text))}

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

        Dim F As New FrmPrint
        Dim C As New CRDeliveryOrder

        '*******
        '    If DSPrint IsNot Nothing AndAlso DSPrint.Tables.Count > 0 AndAlso DSPrint.Tables(0).Rows.Count > 0 Then
        '        Dim dtForBarcode As DataTable = DSPrint.Tables(0)

        '        ' 1. أضف عمودًا جديدًا للـ DataTable ليحمل صورة الباركود
        '        If Not dtForBarcode.Columns.Contains("BarcodeImage") Then
        '        dtForBarcode.Columns.Add("BarcodeImage", GetType(Byte()))
        '    End If

        '    ' 2. إعداد كاتب الباركود
        '    Dim barcodeWriter As New BarcodeWriter()
        '    barcodeWriter.Format = BarcodeFormat.CODE_128 ' اختر نوع الباركود (مثال: CODE_128, QR_CODE, EAN_13)
        '    barcodeWriter.Options = New EncodingOptions() With {
        '    .Height = 80,       ' ارتفاع الباركود بالبكسل
        '    .Width = 250,      ' عرض الباركود بالبكسل
        '    .Margin = 5,        ' الهامش حول الباركود
        '    .PureBarcode = False, ' إذا كانت False، سيعرض النص تحت الباركود (لـ CODE_128 مثلاً)
        '    .NoPadding = True
        '}
        '    ' يمكنك تعديل هذه الخيارات لتناسب احتياجاتك

        '    ' 3. المرور على كل صف لإنشاء الباركود
        '    For Each row As DataRow In dtForBarcode.Rows
        '        Dim dataToEncode As String = ""
        '        ' استخراج البيانات من العمود "Num" (أو أي عمود آخر تريده)
        '        If row("Num") IsNot DBNull.Value AndAlso row("Num") IsNot Nothing Then
        '            dataToEncode = row("Num").ToString()
        '        End If

        '        If Not String.IsNullOrEmpty(dataToEncode) Then
        '            Try
        '                ' إنشاء صورة الباركود
        '                Using barcodeBitmap As Bitmap = barcodeWriter.Write(dataToEncode)
        '                    ' تحويل الصورة إلى مصفوفة بايت
        '                    Using ms As New MemoryStream()
        '                        barcodeBitmap.Save(ms, ImageFormat.Png) ' يمكنك استخدام Png, Jpeg, Bmp
        '                        row("BarcodeImage") = ms.ToArray()
        '                    End Using
        '                End Using ' سيتم التخلص من barcodeBitmap تلقائيًا هنا
        '            Catch ex As Exception
        '                ' في حالة حدوث خطأ، يمكنك تسجيله أو وضع قيمة فارغة
        '                Console.WriteLine($"خطأ في إنشاء باركود للبيانات '{dataToEncode}': {ex.Message}")
        '                row("BarcodeImage") = DBNull.Value
        '            End Try
        '        Else
        '            ' إذا كانت البيانات فارغة، ضع قيمة فارغة للباركود
        '            row("BarcodeImage") = DBNull.Value
        '        End If
        '    Next
        '    ' الآن DataTable (dtForBarcode أو DSPrint.Tables(0)) يحتوي على عمود "BarcodeImage"
        '    Else
        '    ' لا توجد بيانات في الجدول لمعالجة الباركود
        '    Console.WriteLine("لا توجد بيانات في DSPrint.Tables(0) لإنشاء باركود.")
        '    End If


        '*******

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()
    End Sub

    Private Sub BtnPrintAll_Click(sender As Object, e As EventArgs) Handles BtnPrintAll.Click
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=31")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        If DGV.Rows.Count = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "  SELECT   Format(Num,'000000') AS Num, InvoiceDate, DeliveryName, CustomerName, CityName, Address, Phone, Total, Price,
                     DeliveryTotal, RegDate, DeliveryDate  From DeliveryOrderView WHERE InvoiceEndService IS NULL And OrderEndService IS NULL"
        AppendReportConditions()
        SQLQuery &= " SELECT * FROM CenterInfoTable"

        Dim Param() As SqlParameter = {New SqlParameter("@InvoiceNum", Val(TxtNum.Text))}

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Param)

        Dim F As New FrmPrint
        Dim C As New CRDeliveryOrder

        C.SetDataSource(DSPrint.Tables(0))
        C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        C.Subreports(1).SetDataSource(DSPrint.Tables(1))
        F.CrystalReportViewer1.ReportSource = C
        F.CrystalReportViewer1.Refresh()
        F.Text = "طباعة"
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()
    End Sub

    Private Sub AppendReportConditions()

        Dim DateTimeFrom As Date = DTPFrom.Value.Date & " " & "00:00".ToString
        Dim DateTimeTo As Date = DTPTo.Value.Date & " " & "23:59".ToString
        If ChkNum.Checked And TxtNum.Text.Trim <> "" Then AppendToQuery(" AND ", " DeliveryOrderView.Num=@InvoiceNum ")
        If ChkUser.Checked And CmbUserName.SelectedValue <> Nothing Then AppendToQuery(" AND ", "  dbo.DeliveryOrderView.UserID = " & CmbUserName.SelectedValue)
        If ChkDelivery.Checked And CmbDelivery.SelectedValue <> Nothing Then AppendToQuery(" AND ", " dbo.DeliveryOrderView.DeliveryID = " & CmbDelivery.SelectedValue)
        If ChkCity.Checked And CmbCity.SelectedValue <> Nothing Then AppendToQuery(" AND ", " dbo.DeliveryOrderView.CityID = " & CmbCity.SelectedValue)
        If ChkDate.Checked Then AppendToQuery(" AND ", " InvoiceDate BETWEEN '" & DateTimeFrom & "' AND '" & DateTimeTo & "' ")
        If ChkOrder.Checked Then
            If RadReady.Checked Then
                AppendToQuery(" AND ", " dbo.DeliveryOrderView.DeliveryDate IS NOT NULL")
            End If

            If RadOrder.Checked Then
                AppendToQuery(" AND ", " dbo.DeliveryOrderView.DeliveryDate IS NULL")
            End If
        End If
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

    Private Sub TxtDeliveryPrice_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtDeliveryPrice_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub
    Private Sub CheckPageSize()

        If PageSize <> My.Settings.PageSize Then
            PageNum = 1
            GetData(Data.Search)
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

        DGV.Rows.Clear()
    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click
        If Not ChkNum.Checked And Not ChkUser.Checked And Not ChkDate.Checked And Not ChkDelivery.Checked And Not ChkCity.Checked And Not ChkOrder.Checked Then Exit Sub
        TxtPageNum.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

End Class