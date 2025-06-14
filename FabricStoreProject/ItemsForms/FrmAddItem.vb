Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.ViewerObjectModel

Public Class FrmAddItem

    Private DS As New DataSet
    Private ID, CategoriesID As Integer
    Private DTItemLst, DTCatLst As New DataTable


    Private Sub FrmAddItem_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            Button2.FlatAppearance.BorderColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
            Button1.FlatAppearance.BorderColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
            GetFillData()
            TxtNum.Focus()
        Else
            BtnRefresh_Click(sender, e)
            TxtDescription.Clear()
            If Not IsNothing(DS) Then
                DS.Clear()
            End If

            If Not IsNothing(DTCatLst) Then
                DTCatLst.Clear()
            End If
            DTItemLst.Clear()
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub GetFillData()

        Dim SQLCon = New SQLConClass()
        SQLQuery = "  SELECT ID, Num, Name, Color, CountryID, Notes , CatID
            FROM ItemsTable WHERE  EndService is NULL   ORDER BY Name
            Select ID,Name From CountryTable  ORDER BY Name 
            Select ID,Name From CategoryTable ORDER BY Name 
            Select ISNull(Max(Num ),0)+1 Num From ItemsTable"
        DS = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSHasTables(DS) Then
            If DS.Tables(3).Rows.Count > 0 Then
                TxtNum.Text = DS.Tables(3).Rows(0).Item("Num")

            Else
                TxtNum.Text = ""
            End If

            DTItemLst.Clear()
            If DS.Tables(0).Rows.Count > 0 Then
                DTItemLst = DS.Tables(0).Copy
            End If

            If DS.Tables(1).Rows.Count > 0 Then
                CmbCounry.DataSource = DS.Tables(1)
                CmbCounry.ValueMember = "ID"
                CmbCounry.DisplayMember = "Name"
                CmbCounry.SelectedIndex = -1

            Else
                CmbCounry.DataSource = Nothing
            End If

            DTCatLst.Clear()
            If DS.Tables(2).Rows.Count > 0 Then
                DTCatLst = DS.Tables(2).Copy
                LstCategories.DataSource = DTCatLst
                LstCategories.DisplayMember = "Name"
                LstCategories.ValueMember = "ID"
                LstCategories.SelectedIndex = -1

                CmbCat.DataSource = DS.Tables(2)
                CmbCat.DisplayMember = "Name"
                CmbCat.ValueMember = "ID"
                CmbCat.SelectedIndex = -1

            Else
                LstCategories.DataSource = Nothing
                CmbCat.DataSource = Nothing
            End If

        End If

    End Sub

    Private Sub LstItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstItem.SelectedIndexChanged

    End Sub

    Private Sub LstItem_Click(sender As Object, e As EventArgs) Handles LstItem.Click
        DGV.Rows.Clear()
        If LstItem.SelectedValue = Nothing Then Exit Sub

        Dim DSService As New DataSet
        Dim SQLCon = New SQLConClass()
        SQLQuery = "SELECT * FROM ItemsView WHERE ID=" & LstItem.SelectedValue
        SQLQuery += " SELECT * FROM ItemsView WHERE ID=" & LstItem.SelectedValue
        DSService = SQLCon.SelectData(SQLQuery, 0, Nothing)
        If Not IsDBNull(DSService.Tables(0).Rows(0).Item(17)) Then
            CategoriesID = DSService.Tables(0).Rows(0).Item(17)
        Else
            CategoriesID = 0
        End If

        If CategoriesID = 0 Then Exit Sub

        Dim ItemRows() As DataRow = DS.Tables(0).Select("ID=" & CategoriesID)
        If DShasTablesAndData(DSService) Then
            With DSService.Tables(0).Rows(0)
                ID = .Item("ID")
                TxtNum.Text = Format(.Item("Num"), "000000")
                TxtName.Text = .Item("Name")
                TxtColor.Text = .Item("Color")
                CmbCounry.SelectedValue = .Item("CountryID")
                CmbCat.SelectedValue = .Item("CatID")
                TxtDescription.Text = .Item("Notes")
                TxtPrice.Text = Format(.Item("Price"), "0.00")
                TxtPurchasPrice.Text = Format(.Item("PurchasePrice"), "0.00")
                TxtQuantity.Text = .Item("Quantity")
            End With

        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=102")

        'If Perm(0)(5) = False Then
        '    MsgTool("ليس لديك صلاحية الحذف", 0)
        '    Exit Sub
        'End If

        If ID = 0 Then Exit Sub

        If MsgBox("هل أنت متأكد من أنك تريد حذف هذا الصنف ؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim SQLCon = New SQLConClass()
            Dim Param() As SqlParameter = {New SqlParameter("@ID", ID)}
            Select Case SQLCon.CMDExecute("DeleteItem", 1, Param)
                Case 1
                    MsgTool("تم حذف الصنف", 1)
                Case 2
                    MsgTool("لم يتم الحذف ، الصنف مسجل في الفواتير السابقة", 0)
            End Select
            BtnRefresh.PerformClick()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=102")

        'If Perm(0)(3) = False And ID = 0 Then
        '    MsgTool("ليس لديك صلاحية الإضافة", 0)
        '    Exit Sub
        'ElseIf Perm(0)(4) = False And ID <> 0 Then
        '    MsgTool("ليس لديك صلاحية التعديل", 0)
        '    Exit Sub
        'End If

        IsDataMissing = False
        If IsInputEmpty(GrpServices) Then IsDataMissing = True
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim param() As SqlParameter =
            {
            New SqlParameter("@ID", ID),
            New SqlParameter("@Num", Val(TxtNum.Text)),
            New SqlParameter("@Name", TxtName.Text.Trim),
            New SqlParameter("@CountryID", CmbCounry.SelectedValue),
            New SqlParameter("@CatID", CmbCat.SelectedValue),
            New SqlParameter("@Note", TxtDescription.Text.Trim),
            New SqlParameter("@Color", TxtColor.Text),
            New SqlParameter("@PurchasPrice", Val(TxtPurchasPrice.Text)),
            New SqlParameter("@Quantity", Val(TxtQuantity.Text)),
            New SqlParameter("@Price", Val(TxtPrice.Text))}

        Dim SQLCon = New SQLConClass()
        Dim DSService As New DataSet
        DSService = SQLCon.CMDExecuteData("SaveItem", param)
        If DSHasTables(DSService) Then
            If DSService.Tables(0).Rows(0).Item(0) <> 0 Then ' 
                'BtnRefresh.PerformClick()
                MsgTool("تم الحفظ بيانات الصنف", 1)
                ID = DSService.Tables(0).Rows(0).Item(0)

                If DSService.Tables(1).Rows.Count > 0 Then
                    Dim ItemRows() As DataRow = DSService.Tables(1).Select("ID=" & ID)
                    If ItemRows.Length > 0 Then
                        DGV.Rows.Add()
                        DGV.Item(0, 0).Value = ItemRows(0)("ID")
                        DGV.Item(1, 0).Value = ItemRows(0)("Num")
                        DGV.Item(2, 0).Value = ItemRows(0)("Name")
                        DGV.Item(3, 0).Value = ItemRows(0)("Category")
                        DGV.Item(4, 0).Value = ItemRows(0)("Color")
                        DGV.Item(5, 0).Value = ItemRows(0)("Country")
                    End If

                    DGV.ClearSelection()
                End If

            Else
                MsgTool("لم يتم الحفظ ، اسم الصنف موجود مسبقاً", 0)
            End If

        End If
        ' BtnRefresh_Click(sender, e)
    End Sub

    Public Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ID = 0
        CategoriesID = 0
        Clear(TableLayoutPanel1)
        ChangeControlColor(Me)
        LstCategories.SelectedIndex = -1
        LstItem.DataSource = Nothing
        DGV.Rows.Clear()
        GetFillData()
    End Sub

    Private Sub TxtDescription_TextChanged(sender As Object, e As EventArgs) Handles TxtDescription.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtColor_TextChanged(sender As Object, e As EventArgs) Handles TxtColor.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCounry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCounry.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCounry_TextChanged(sender As Object, e As EventArgs) Handles CmbCounry.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnAddCountry_Click(sender As Object, e As EventArgs) Handles BtnAddCountry.Click
        FrmCountry.ShowDialog()

        SQLQuery = "SELECT * FROM CountryTable  ORDER BY Name "
        Dim SQLCon = New SQLConClass()
        Dim DSTemp As New DataSet
        DSTemp = SQLCon.SelectData(SQLQuery)
        If Not DSHasTables(DSTemp, 1) Then Exit Sub
        CmbCounry.DataSource = DSTemp.Tables(0)
        CmbCounry.ValueMember = "ID"
        CmbCounry.DisplayMember = "Name"
        CmbCounry.SelectedIndex = -1
    End Sub

    Private Sub TxtPurchasPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtPurchasPrice.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtPrice.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPurchasPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPurchasPrice.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrice.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtNum_TextChanged(sender As Object, e As EventArgs) Handles TxtNum.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtName.Focus()
        End If
    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCounry.Focus()
        End If
    End Sub

    Private Sub CmbCounry_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbCounry.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtColor.Focus()
        End If
    End Sub

    Private Sub TxtColor_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtColor.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDescription.Focus()
        End If
    End Sub

    Private Sub TxtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPurchasPrice.Focus()
        End If
    End Sub

    Private Sub TxtPurchasPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPurchasPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPrice.Focus()
        End If
    End Sub

    Private Sub TxtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCat.Focus()
        End If
    End Sub

    Private Sub PicAddClassification_Click(sender As Object, e As EventArgs) Handles PicAddClassification.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=102")

        'If Perm(0)(3) = False Then
        '    MsgTool("ليس لديك صلاحية الإضافة", 0)
        '    Exit Sub
        'End If

        If CategoriesID <> 0 Then Exit Sub
        If TxtAddCategoreis.Text.Trim = "" Then
            TxtAddCategoreis.BackColor = RedColor
            MsgTool("يرجى إدخال اسم التصنيف", 0)
            Exit Sub
        End If

        Dim Param() As SqlParameter = {
               New SqlParameter("@ID", CategoriesID),
            New SqlParameter("@Name", TxtAddCategoreis.Text.Trim)
            }

        Dim SQLCon = New SQLConClass()
        Dim DSSClassification As New DataSet
        DSSClassification = SQLCon.CMDExecuteData("SaveCategory", Param)
        If Save = 1 Then
            BtnRefresh.PerformClick()
            TxtAddCategoreis.Focus()

        Else
            MsgTool("لم يتم الحفظ ، اسم أو رقم الصنف موجود مسبقاً", 0)
        End If

    End Sub

    Private Sub PicDeleteClassification_Click(sender As Object, e As EventArgs) Handles PicDeleteCategories.Click
        CmsDelClassification_Click(sender, e)
    End Sub

    Private Sub CmsDelClassification_Click(sender As Object, e As EventArgs) Handles CmsDelClassification.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=102")

        'If Perm(0)(5) = False Then
        '    MsgTool("ليس لديك صلاحية الحذف", 0)
        '    Exit Sub
        'End If
        If TxtUpdateCategories.Text.Trim = "" Then
            TxtUpdateCategories.BackColor = RedColor
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        If IsNothing(LstCategories.SelectedValue) Then Exit Sub

        'If MsgBox("هل أنت متأكد من أنك تريد حذف هذا التصنيف ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "تأكيدالحذف") = MsgBoxResult.Yes Then
        If MsgBox("هل تريد حذف" & vbCrLf & LstCategories.Text & " ؟", vbYesNo + vbQuestion, "تأكيد الحذف") = MsgBoxResult.Yes Then
            Dim SQLCon = New SQLConClass()
            Dim Param() As SqlParameter = {New SqlParameter("@ID", LstCategories.SelectedValue)}
            Select Case SQLCon.CMDExecute("DeleteCategory", 1, Param)
                Case 2
                    MsgTool(" لا يمكن حذف التصنيف ", 0)
            End Select
        End If
        BtnRefresh.PerformClick()
    End Sub

    Private Sub LstCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstCategories.SelectedIndexChanged

    End Sub

    Private Sub LstCategories_Click(sender As Object, e As EventArgs) Handles LstCategories.Click
        DGV.Rows.Clear()
        If IsNothing(LstCategories.SelectedValue) Then Exit Sub
        ID = 0
        LstItem.DataSource = Nothing
        Clear(GrpServices)
        TxtDescription.Text = ""
        TxtUpdateCategories.Text = LstCategories.Text
        CmbCat.SelectedValue = LstCategories.SelectedValue
        Dim ItemRows() As DataRow = DS.Tables(0).Select("CatID=" & LstCategories.SelectedValue)
        If ItemRows.Length > 0 Then

            LstItem.DataSource = ItemRows.CopyToDataTable
            LstItem.DisplayMember = "Name"
            LstItem.ValueMember = "ID"
            LstItem.SelectedIndex = -1

        End If
        LstItem.ClearSelected()
        CategoriesID = LstCategories.SelectedValue
    End Sub

    Private Sub PicUpdateClassification_Click(sender As Object, e As EventArgs) Handles PicUpdateCategories.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=102")

        'If Perm(0)(4) = False Then
        '    MsgTool("ليس لديك صلاحية التعديل", 0)
        '    Exit Sub
        'End If
        If TxtUpdateCategories.Text.Trim = "" Then
            TxtUpdateCategories.BackColor = RedColor
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        If CategoriesID = 0 Then Exit Sub
        Dim Param() As SqlParameter = {
              New SqlParameter("@ID", LstCategories.SelectedValue),
           New SqlParameter("@Name", TxtUpdateCategories.Text.Trim)
           }

        Dim SQLCon = New SQLConClass()
        Dim DSSUpdateClassification As New DataSet
        DSSUpdateClassification = SQLCon.CMDExecuteData("SaveCategory", Param)
        BtnRefresh.PerformClick()
        TxtAddCategoreis.Focus()

    End Sub

    Private Sub TxtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQuantity.KeyPress
        e.Handled = Not IsNumberOnly(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub CmbCat_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbCat.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtQuantity.Focus()
        End If
    End Sub

    Private Sub TxtQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave_Click(sender, e)
        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantity.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCat_TextChanged(sender As Object, e As EventArgs) Handles CmbCat.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCat.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
    End Sub
End Class