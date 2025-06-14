Imports System.Data.SqlClient

Public Class FrmPreparingClothes

    Private DS, DSDel, DsSave, DSMaterial As DataSet
    Private DT, DTMat, DTCustomerSize As DataTable
    Private IDPrint, QuantityS, ItemStoreID As Integer
    Private PurchasePrice As Double
    Private Operation As String
    Private CR As Integer = -1
    Private ItemSize As String


    Private TailorID, ServiceID, InvoNum As Integer
    Private TailorPrice, Armpit, Chest, CusHeight, Hip, Shoulder, Sleeve, Waist, InvoTotal As Double
    Private bsItems As New BindingSource()


    Private Sub FrmPreparingClothes_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            GetData()

            TxtMaterialNum.Select()
            TxtMaterialNum.Focus()

        Else
            ChangeControlColor(Me)
            BtnClean.PerformClick()
            DGV.Rows.Clear()
            Clear(Me)
            If Not IsNothing(DS) Then
                DS.Clear()
            End If

        End If
    End Sub

    Private Sub SetDGVHeader()
        DGVItems.Columns(0).Width = 55
        DGVItems.Columns(0).HeaderText = "ت"
        DGVItems.Columns(1).Visible = False
        DGVItems.Columns(2).HeaderText = "الاسم "
        DGVItems.Columns(3).HeaderText = "الكمية"
        DGVItems.Columns(4).HeaderText = "السعر"
        DGVItems.Columns(5).HeaderText = "PurchasePrice"
        DGVItems.Columns(5).Visible = False
        DGVItems.Columns(6).HeaderText = "رقم الصنف"
        DGVItems.Columns(7).HeaderText = "CatID"
        DGVItems.Columns(7).Visible = False
        DGVItems.Columns(8).HeaderText = "اللون"
        DGVItems.Columns(9).HeaderText = "الصنع"
    End Sub



    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub GetData()
        Dim sqlcon As New SQLConClass()
        SQLQuery = " Select * From ServicesTable  "
        SQLQuery += " Select  ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت, ItemStoreID, Name, Quantity, Price, PurchasePrice, Num, CatID, Color, Country
                    From ItemsView Where EndService IS Null And Type = 1  "
        SQLQuery += " Select * From TailorsTable where EndService IS NULL order by Name  "

        DS = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DS) Then
            FillCmb()
        End If

    End Sub

    Private Sub FillCmb()

        CmbService.DataSource = DS.Tables(0)
        CmbService.DisplayMember = "Name"
        CmbService.ValueMember = "ID"
        CmbService.SelectedIndex = -1


        If DS.Tables(1).Rows.Count > 0 Then
            CmbMaterial.DataSource = DS.Tables(1)
            CmbMaterial.DisplayMember = "Name"
            CmbMaterial.ValueMember = "ItemStoreID"
            CmbMaterial.SelectedIndex = -1

            If DTMat IsNot Nothing Then
                DTMat.Dispose()
            End If
            DTMat = DS.Tables(1).Copy

            bsItems.DataSource = DTMat
            DGVItems.DataSource = bsItems
            DGVItems.ClearSelection()
            SetDGVHeader()

        Else
            CmbMaterial.DataSource = Nothing
            CmbMaterial.SelectedIndex = -1
            CmbMaterial.Text = ""

            If DTMat IsNot Nothing Then
                DTMat.Clear()
            End If
            DGVItems.DataSource = bsItems
            bsItems.DataSource = Nothing
            DGVItems.DataSource = Nothing

            If DTMat IsNot Nothing Then
                DTMat.Dispose()
            End If
        End If



        CmbTailor.DataSource = DS.Tables(2)
        CmbTailor.DisplayMember = "Name"
        CmbTailor.ValueMember = "ID"
        CmbTailor.SelectedIndex = -1

    End Sub

    Private Sub CmbMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMaterial.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbMaterial_TextChanged(sender As Object, e As EventArgs) Handles CmbMaterial.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbMaterial_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbMaterial.SelectionChangeCommitted

        If CmbMaterial.SelectedValue Is Nothing Or CmbMaterial.SelectedValue = -1 Then Exit Sub
        Dim sqlcon As New SQLConClass
        Dim ItemRow() As DataRow = DS.Tables(1).Select("ItemStoreID=" & CmbMaterial.SelectedValue)

        If ItemRow.Length = 0 Then Exit Sub

        TxtMaterialNum.Text = Format(ItemRow(0)("Num"), "000000")
        TxtSellPrice.Text = Format(ItemRow(0)("Price"), "0.00")
        TxtQuantityS.Text = ItemRow(0)("Quantity")
        QuantityS = 0
        PurchasePrice = 0
        QuantityS = ItemRow(0)("Quantity")
        PurchasePrice = ItemRow(0)("PurchasePrice")
        TxtQuantity.Text = ""

        For i = 0 To DGVItems.Rows.Count - 1
            If TxtMaterialNum.Text.Trim = DTMat.Rows(i).Item(6) Then
                DGVItems.Rows(i).Selected = True
                DGVItems.FirstDisplayedScrollingRowIndex = i
            End If
        Next
    End Sub

    Private Sub DGVItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVItems.CellContentClick

    End Sub

    Private Sub DGVItems_Click(sender As Object, e As EventArgs) Handles DGVItems.Click
        If CheckDGVError(DGVItems) Then Exit Sub

        CR = DGVItems.CurrentRow.Index
        CmbMaterial.SelectedValue = DGVItems.Item(1, CR).Value
        CmbMaterial_SelectionChangeCommitted(sender, e)

    End Sub


    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        'If IsNothing(CmbCat.SelectedValue) Then Exit Sub

        If Val(TxtMaterialNum.Text) = 0 Or TxtMaterialNum.Text = "" Then
            TxtMaterialNum.BackColor = RedColor
            Exit Sub
        End If

        Dim sqlcon As New SQLConClass()
        SQLQuery = " Select  ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت, ItemStoreID, Name, Quantity, Price, PurchasePrice, Num, CatID, Color, Country
                    From ItemsView Where EndService IS Null And Type = 1  "

        DSMaterial = sqlcon.SelectData(SQLQuery, 0, Nothing)

        If DSHasTables(DSMaterial) Then
            Dim ItemRow() As DataRow = DSMaterial.Tables(0).Select("Num='" & TxtMaterialNum.Text.Trim & "'")
            If ItemRow.Length = 0 Then
                MsgTool("الصنف غير موجود", 0)
                CmbMaterial.Text = ""
                CmbMaterial.SelectedIndex = -1
                TxtSellPrice.Clear()
                TxtQuantityS.Text = ""
                DGVItems.ClearSelection()
                Exit Sub
            End If

            For i As Integer = 0 To CmbMaterial.Items.Count - 1
                If CType(CmbMaterial.Items(i), DataRowView)("ItemStoreID") = ItemRow(0)("ItemStoreID") Then
                    CmbMaterial.SelectedIndex = i
                    Exit For
                End If
            Next

            UpdateFieldsForSelectedItem()
        End If

    End Sub

    Private Sub UpdateFieldsForSelectedItem()
        If CmbMaterial.SelectedValue Is Nothing Then Exit Sub

        Dim SelectedItem As DataRowView = CType(CmbMaterial.SelectedItem, DataRowView)
        Dim sqlcon As New SQLConClass()
        SQLQuery = " Select  ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت, ItemStoreID, Name, Quantity, Price, PurchasePrice, Num, CatID, Color, Country
                    From ItemsView Where EndService IS Null And Type = 1  "

        DSMaterial = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DSMaterial) Then
            Dim ItemRow() As DataRow = DS.Tables(1).Select("ItemStoreID=" & SelectedItem("ItemStoreID"))

            If ItemRow.Length = 0 Then Exit Sub

            TxtMaterialNum.Text = Format(ItemRow(0)("Num"), "000000")
            TxtSellPrice.Text = Format(ItemRow(0)("Price"), "0.00")
            TxtQuantityS.Text = ItemRow(0)("Quantity")
            QuantityS = 0
            PurchasePrice = 0
            QuantityS = ItemRow(0)("Quantity")
            PurchasePrice = ItemRow(0)("PurchasePrice")
            TxtQuantity.Text = ""

            For i = 0 To DGVItems.Rows.Count - 1
                If TxtMaterialNum.Text.Trim = DTMat.Rows(i).Item(6) Then
                    DGVItems.Rows(i).Selected = True
                    DGVItems.FirstDisplayedScrollingRowIndex = i
                End If
            Next
        End If

    End Sub

    Private Sub TxtSellPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtSellPrice.TextChanged
        sender.BackColor = SystemColors.Window
        If Val(TxtSellPrice.Text) <= 0 Then TxtSellPrice.Text = ""
        If Val(TxtQuantity.Text) > 0 Then
        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantity.TextChanged
        sender.BackColor = SystemColors.Window

        If Val(TxtQuantity.Text) <= 0 Then
            TxtQuantity.Text = ""
            TxtQuantityS.Text = QuantityS
        End If

        If Val(TxtQuantityS.Text) = 0 Then
            TxtQuantity.Text = ""
            MsgTool("نفذت الكمية من المخزن", 0)
            Exit Sub
        End If

        If Val(TxtQuantity.Text) > Val(TxtQuantityS.Text) Then
            TxtQuantity.Text = ""
            MsgTool("الكمية أكبر من الموجودة في المخزن", 0)
            Exit Sub
        End If

        TxtQuantityS.Text = Val(TxtQuantityS.Text) - Val(TxtQuantity.Text)
        If TxtTailorPrice.Text = "" Then
            If Val(TxtSellPrice.Text) > 0 Then
                InvoTotal = Val(TxtQuantity.Text) * Val(TxtSellPrice.Text)
            End If

        Else
            If Val(TxtSellPrice.Text) > 0 Then
                InvoTotal = Val(TxtQuantity.Text) * (Val(TxtSellPrice.Text) + Val(TxtTailorPrice.Text))
            End If
        End If

    End Sub

    Private Sub TxtTailorPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtTailorPrice.TextChanged
        sender.BackColor = SystemColors.Window

        If TxtTailorPrice.Text = "" Then
            If Val(TxtSellPrice.Text) > 0 Then
                InvoTotal = Val(TxtQuantity.Text) * Val(TxtSellPrice.Text)
            End If

        Else
            If Val(TxtSellPrice.Text) > 0 Then
                InvoTotal = Val(TxtQuantity.Text) * ((Val(TxtSellPrice.Text) + Val(TxtTailorPrice.Text)))
            End If
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        IsDataMissing = False
        IsInputEmpty(TLPData)
        IsInputEmpty(TLPOrder)

        If IsDataMissing = True Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If


        If Val(TxtQuantity.Text) <= 0 Then Exit Sub
        If Not IsNumeric(TxtQuantity.Text) OrElse Val(TxtQuantity.Text) <= 0 Then
            MsgTool("يرجى ادخال كمية صحيحة", 0)
            Exit Sub
        End If
        Dim Cr As Integer

        Dim SQLCon = New SQLConClass
        Dim DSInvoContent As New DataSet
        Dim Param() As SqlParameter = {
            New SqlParameter("@ItemStoreID", CmbMaterial.SelectedValue),
            New SqlParameter("@TailorID", 1),
            New SqlParameter("@SellPrice", Val(TxtSellPrice.Text)),
            New SqlParameter("@PurchasePrice", PurchasePrice),
            New SqlParameter("@Quantity", Val(TxtQuantity.Text)),
            New SqlParameter("@ServiceID", CmbService.SelectedValue),
            New SqlParameter("@TailorPrice", Val(TxtTailorPrice.Text)),
            New SqlParameter("@Size", TxtSize.Text.Trim),
            New SqlParameter("@Height", TxtHeight.Text.Trim),
            New SqlParameter("@Shoulder", TxtShoulder.Text.Trim),
            New SqlParameter("@Sleeve", TxtSleeve.Text.Trim),
            New SqlParameter("@Armpit", TxtArmpit.Text.Trim),
            New SqlParameter("@Chest", TxtChest.Text.Trim),
            New SqlParameter("@Waist", TxtWaist.Text.Trim),
            New SqlParameter("@Hip", TxtHip.Text.Trim)}
        DSInvoContent = SQLCon.CMDExecuteData("SaveMadeClothes", Param)

        If Not DSHasTables(DSInvoContent) Then Exit Sub
        If Save = 1 Then
            MsgTool("تم حفظ الصنف بنجاح", 1)

            FillDGV(DSInvoContent.Tables(0))
        End If
    End Sub

    Private Sub FillDGV(DT As DataTable)
        DGV.Rows.Clear()
        IDPrint = DT.Rows(0).Item("ID")
        For i = 0 To DT.Rows.Count - 1
            With DT.Rows(i)

                DGV.Rows.Add()
                DGV.Item(0, i).Value = .Item("ID")
                DGV.Item(1, i).Value = .Item("ItemStoreNum")
                DGV.Item(2, i).Value = .Item("Name")
                DGV.Item(3, i).Value = .Item("Category")
                DGV.Item(4, i).Value = .Item("Size")
                DGV.Item(5, i).Value = .Item("Quantity")

            End With
        Next
        DGV.ClearSelection()
    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        ChangeControlColor(Me)
        Clear(TLPData)
        Clear(TableLayoutPanel3)
        Clear(TLPOrder)

        DGV.Rows.Clear()

        IDPrint = 0

        'CmbMaterial.DataSource = Nothing
        CmbMaterial.Text = ""
        CmbMaterial.SelectedIndex = -1

        CmbTailor.Text = ""
        CmbTailor.SelectedIndex = -1

        TxtQuantityS.Text = ""
        ChangeControlColor(Me)
        DGVItems.DataSource = Nothing
        GetData()

    End Sub

    Private Sub TxtTotalMaterial_Click(sender As Object, e As EventArgs)
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtMaterialNum_TextChanged(sender As Object, e As EventArgs) Handles TxtMaterialNum.TextChanged
        sender.BackColor = SystemColors.Window
        If TxtMaterialNum.Text.Trim = vbNullString Then ClearMaterial()
    End Sub

    Private Sub TxtMaterialNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMaterialNum.KeyPress
        'e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtMaterialNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtMaterialNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub ClearMaterial()
        TxtSellPrice.Text = ""
        TxtQuantity.Text = ""
        TxtQuantityS.Text = ""
        CmbMaterial.Text = ""
        CmbMaterial.SelectedIndex = -1
        'CmbMaterial.DataSource = Nothing
    End Sub

    Private Sub CmbService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbService.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbService_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbService.SelectionChangeCommitted
        Dim DT As DataTable = DS.Tables(0)
        'If IsNothing(CmbService.SelectedValue) Then Exit Sub

        'Dim rows() As DataRow = DT.Select("ID = " & CmbService.SelectedValue)
        'If rows.Length > 0 Then
        '    TxtTailorPrice.Text = rows(0)("Price").ToString()
        'Else
        '    TxtTailorPrice.Text = 0
        'End If
    End Sub

    Private Sub CmbService_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbService.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTailorPrice.Focus()
        End If
    End Sub

    Private Sub TxtTailorPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTailorPrice.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtTailorPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTailorPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSize.Focus()
        End If
    End Sub

    Private Sub TxtSize_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSize.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHeight.Focus()
        End If
    End Sub

    Private Sub TxtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHeight.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtHeight_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtHeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtShoulder.Focus()
        End If
    End Sub

    Private Sub TxtShoulder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtShoulder.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtShoulder_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtShoulder.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtChest.Focus()
        End If
    End Sub

    Private Sub TxtSleeve_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSleeve.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub


    Private Sub TxtSleeve_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSleeve.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtWaist.Focus()
        End If
    End Sub

    Private Sub TxtArmpit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArmpit.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtArmpit_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArmpit.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHip.Focus()
        End If
    End Sub

    Private Sub TxtChest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtChest.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtChest_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtChest.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSleeve.Focus()
        End If
    End Sub

    Private Sub TxtWaist_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtWaist.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtWaist_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtWaist.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtArmpit.Focus()
        End If
    End Sub

    Private Sub TxtHip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHip.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtHip_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtHip.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub CmbService_TextChanged(sender As Object, e As EventArgs) Handles CmbService.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtSize_TextChanged(sender As Object, e As EventArgs) Handles TxtSize.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

        Dim searchBox As TextBox = TryCast(sender, TextBox)
        If searchBox Is Nothing Then Exit Sub

        searchBox.BackColor = SystemColors.Window

        Dim searchText As String = searchBox.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            ResetFilter()
            Exit Sub
        End If

        If bsItems Is Nothing OrElse bsItems.DataSource Is Nothing Then
            Exit Sub
        End If

        ' معالجة نص البحث لجعله آمناً للاستعلام
        Dim safeSearchText As String = SanitizeSearchText(searchText)

        ' بناء تعبير التصفية
        Dim filterExpression As String = BuildFilterExpression(safeSearchText, searchText)

        ' تطبيق التصفية
        ApplyFilter(filterExpression)

        ' إعادة ترقيم الصفوف
        RenumberGridRows()

    End Sub

    Private Function SanitizeSearchText(searchText As String) As String
        ' معالجة الأحرف الخاصة لمنع أخطاء SQL
        Return searchText.Replace("'", "''") _
                        .Replace("[", "[[]") _
                        .Replace("%", "[%]") _
                        .Replace("*", "[*]")
    End Function

    Private Function BuildFilterExpression(safeText As String, originalText As String) As String
        ' البحث في حقل الاسم (Name) باستخدام LIKE للبحث الجزئي
        Dim nameFilter As String = $"[Name] LIKE '%{safeText}%'"

        ' إذا كان النص رقماً، نبحث في الحقل الرقمي (Num) بالمطابقة التامة
        If IsNumeric(originalText) Then
            Return $"{nameFilter} OR [Num] = '{safeText}'"
        End If

        Return nameFilter
    End Function

    Private Sub ApplyFilter(filterExpression As String)
        Try
            bsItems.Filter = filterExpression
        Catch ex As Exception
            ' في حالة فشل التصفية نعيد الضبط
            bsItems.Filter = ""
        End Try

        DGVItems.ClearSelection()
    End Sub

    Private Sub ResetFilter()
        If bsItems IsNot Nothing Then
            bsItems.Filter = ""
        End If
        DGVItems.ClearSelection()
        RenumberGridRows()
    End Sub

    Private Sub RenumberGridRows()
        For i As Integer = 0 To DGVItems.Rows.Count - 1
            DGVItems.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

End Class