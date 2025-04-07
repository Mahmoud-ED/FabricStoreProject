Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.ViewerObjectModel

Public Class FrmAddItem

    Private DS As New DataSet
    Private ID As Integer
    Private DTItemLst As New DataTable

    Private Sub FrmAddItem_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            Button2.FlatAppearance.BorderColor = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
            GetFillData()

        Else
            BtnRefresh_Click(sender, e)
            TxtDescription.Clear()
            If Not IsNothing(DS) Then
                DS.Clear()
            End If

            DTItemLst.Clear()
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Public Sub GetFillData()

        Dim SQLCon = New SQLConClass()
        SQLQuery = "  SELECT ID, Num, Name, Color, CountryID, Notes 
            FROM ItemsTable WHERE  EndService is NULL   ORDER BY Name
            Select ID,Name From CountryTable   ORDER BY Name "
        DS = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSHasTables(DS) Then
            DTItemLst.Clear()
            DTItemLst = DS.Tables(0).Copy

            LstItem.DataSource = DTItemLst
            LstItem.DisplayMember = "Name"
            LstItem.ValueMember = "ID"
            LstItem.SelectedIndex = -1

            CmbCounry.DataSource = DS.Tables(1)
            CmbCounry.ValueMember = "ID"
            CmbCounry.DisplayMember = "Name"
            CmbCounry.SelectedIndex = -1
        End If

    End Sub

    Private Sub LstItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstItem.SelectedIndexChanged

    End Sub

    Private Sub LstItem_Click(sender As Object, e As EventArgs) Handles LstItem.Click
        If LstItem.SelectedValue = Nothing Then Exit Sub

        Dim DSService As New DataSet
        Dim SQLCon = New SQLConClass()
        SQLQuery = "SELECT * FROM ItemsView WHERE ID=" & LstItem.SelectedValue
        DSService = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DShasTablesAndData(DSService) Then
            With DSService.Tables(0).Rows(0)
                ID = .Item("ID")
                TxtNum.Text = Format(.Item("Num"), "000000")
                TxtName.Text = .Item("Name")
                TxtColor.Text = .Item("Color")
                CmbCounry.SelectedValue = .Item("CountryID")
                TxtDescription.Text = .Item("Notes")
                TxtPrice.Text = .Item("Price")
                TxtPurchasPrice.Text = .Item("PurchasePrice")
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
            New SqlParameter("@Note", TxtDescription.Text.Trim),
            New SqlParameter("@Color", TxtColor.Text),
            New SqlParameter("@PurchasPrice", Val(TxtPurchasPrice.Text)),
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
                        DGV.Item(3, 0).Value = ItemRows(0)("Color")
                        DGV.Item(4, 0).Value = ItemRows(0)("Country")
                    End If

                    DGV.ClearSelection()
                End If

            Else
                MsgTool("لم يتم الحفظ ، اسم الصنف موجود مسبقاً", 0)
            End If

        End If

    End Sub


    Public Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ID = 0
        Clear(TableLayoutPanel1)
        ChangeControlColor(Me)
        LstItem.SelectedIndex = -1
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
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrice.KeyPress
        e.Handled = Not IsNumber(sender.Text, e.KeyChar, False, True)
    End Sub


End Class