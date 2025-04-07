Imports Microsoft.VisualBasic.ApplicationServices
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmUserManagement
    Private CurrentUserID, EmpID As Integer
    Private DSUser, DSBasicData, DSSearch, DSRestore, DSPermission As New DataSet
    Private DTEmp, DTUser, DTOp As New DataTable
    Public IDSearch As Integer

    Private CR As Integer = -1




    Private Sub FrmUsers_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            GetData()
            LblUserData_Click(sender, e)

        Else
            DSBasicData.Tables.Clear()
            DTUser.Clear()
            DTEmp.Clear()
            Clear(TLP)
            CurrentUserID = 0
            EmpID = 0
            LblActive.Text = ""
            LblEmpName.Text = ""
        End If
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub GetData()
        Dim SQLCon = New SQLConClass
        SQLQuery = "Select EmployeeTable.ID,Name  From EmployeeTable  Where EmployeeTable.EndService Is NULL 
                    And EmployeeTable.ID Not In(Select ISNULL(EmployeeID, 0) EmpID From UserTable )  Order By Name
                    Select ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت,* From UserView  
                    Select * From OperationTable"

        DSBasicData = SQLCon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DSBasicData) Then
            FillData(DSBasicData)
        End If
    End Sub

    Private Sub FillData(DS As DataSet)
        DTUser.Rows.Clear()
        DTEmp.Rows.Clear()

        If DS.Tables(0).Rows.Count > 0 Then
            DTEmp.Rows.Clear()
            DTEmp = DS.Tables(0).Copy
            CmbEmp.DataSource = DTEmp
            CmbEmp.DisplayMember = "Name"
            CmbEmp.ValueMember = "ID"
            CmbEmp.SelectedIndex = -1

        Else
            CmbEmp.DataSource = Nothing
        End If

        If DS.Tables(2).Rows.Count > 0 Then
            DTOp = DS.Tables(2).Copy
            CmbOperation.DataSource = DTOp
            CmbOperation.DisplayMember = "OperationName"
            CmbOperation.ValueMember = "ID"
            CmbOperation.SelectedIndex = -1

        Else
            CmbOperation.DataSource = Nothing
        End If

        If DS.Tables(1).Rows.Count > 0 Then
            DTUser.Rows.Clear()
            DTUser = DS.Tables(1).Copy
            CmbUser.DataSource = DTUser
            CmbUser.DisplayMember = "Name"
            CmbUser.ValueMember = "ID"
            CmbUser.SelectedIndex = -1

            FillDGV(DS.Tables(1))

        Else
            CmbUser.DataSource = Nothing
        End If
        ClearData()
    End Sub

    Private Sub ClearData()
        Clear(TLP)
        CurrentUserID = 0
        CmbUser.Focus()
        LblActive.Text = ""
        LblEmpName.Text = ""
    End Sub

    Private Sub BtnLockedOut_Click(sender As Object, e As EventArgs) Handles BtnLockedOut.Click
        If CurrentUserID = 0 Then
            MsgTool("يرجى اختيار مستخدم", 0)
            Exit Sub
        End If
        If CurrentUserID = 1 Or CurrentUserID = UserID Then
            MsgTool("لا يمكن ايقاف هذا المستخدم", 0)
            Exit Sub
        End If

        Dim SQLCon = New SQLConClass
        If LblActive.Text = "فعّال" Then

            SQLQuery = "Update UserTable Set LockedOut='TRUE' Where ID=" & CurrentUserID
            Dim SaveState As Integer = SQLCon.CMDExecute(SQLQuery, 0, Nothing)
            Select Case SaveState
                Case > 0
                    MsgTool("تم الحفظ بنجاح", 1)
                    LblActive.Text = "موقوف"

                    BtnLockedOut.Text = "تفعيل"

                Case Else
                    MsgTool("لم يتم الحفظ، خطأ في البيانات", 0)
            End Select

        Else
            SQLQuery = "Update UserTable Set LockedOut='False' Where ID=" & CurrentUserID
            Dim SaveState As Integer = SQLCon.CMDExecute(SQLQuery, 0, Nothing)
            Select Case SaveState
                Case > 0
                    MsgTool("تم الحفظ بنجاح", 1)
                    LblActive.Text = "فعّال"

                    BtnLockedOut.Text = "ايقاف"
                Case Else
                    MsgTool("لم يتم الحفظ، خطأ في البيانات", 0)
            End Select

        End If
        GetData()

    End Sub

    Private Sub CmbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUser.SelectedIndexChanged
        sender.backcolor = SystemColors.Window
    End Sub

    Private Sub CmbUser_TextChanged(sender As Object, e As EventArgs) Handles CmbUser.TextChanged
        sender.backcolor = SystemColors.Window
    End Sub

    Private Sub CmbUser_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbUser.SelectionChangeCommitted
        If IsNothing(CmbUser.SelectedValue) Then Exit Sub

        CurrentUserID = CmbUser.SelectedValue

        FillUserData()
    End Sub

    Private Sub FillUserData()
        Dim Row() As DataRow = DTUser.Select("ID=" & CurrentUserID)
        If Row.Length > 0 Then
            LblEmpName.Text = Row(0)(3)
            TxtPassword.Text = Row(0)(4)

            If IsDBNull(Row(0)(5)) Then
                BtnDelete.Text = "حذف"
                BtnDelete.Image = My.Resources.close

            Else
                BtnDelete.Text = "استعادة"
                'BtnDelete.Image = My.Resources.Recovery
            End If

            If Row(0)(6) <> 0 Then
                LblActive.Text = "موقوف"
                BtnLockedOut.Text = "تفعيل"

            Else
                LblActive.Text = "فعّال"
                BtnLockedOut.Text = "ايقاف"
            End If


            'Permissions

            CmbOperation.Enabled = True

            Clear(TLPpermission)
            ChkAdmin.Checked = False
            ChkSelectAll.Checked = False

            Dim SQLCon = New SQLConClass

            SQLQuery = " Select * From PermissionTable  WHERE UserID = " & CurrentUserID
            DSPermission = SQLCon.SelectData(SQLQuery, 0, Nothing)
            If DSHasTables(DSPermission) Then
                If DSPermission.Tables(0).Rows.Count > 0 Then
                    Dim PermissionRows() As DataRow = DSPermission.Tables(0).Select("InsertP=0 Or UpdateP=0 Or DeleteP=0 Or PrintP=0")
                    If PermissionRows.Length = 0 Then
                        ChkAdmin.Checked = True
                    End If

                End If
            End If

        End If

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Clear(TLP)
        CmbUser.SelectedIndex = -1
        CmbUser.Text = ""
        TableLayoutPanel4.Enabled = False

        PnlSelectEmp.Top = (Me.Height - PnlSelectEmp.Height) / 2
        PnlSelectEmp.Left = (Me.Width - PnlSelectEmp.Width) / 2
        PnlSelectEmp.BringToFront()
        PnlSelectEmp.Visible = True

        CmbEmp.Focus()
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If CurrentUserID = 0 And EmpID = 0 Then
            Exit Sub
        End If

        IsDataMissing = False

        IsInputEmpty(TLPData)
        If IsDataMissing Then
            MsgTool("الرجاء التأكد من البيانات", 0)
            Exit Sub
        End If

        Dim SQLCon = New SQLConClass
        Dim Param() As SqlParameter = {
                New SqlParameter("@ID", CurrentUserID),
         New SqlParameter("@EmpID", EmpID),
          New SqlParameter("@Password", TxtPassword.Text.Trim)}
        DSUser = SQLCon.CMDExecuteData("SaveUser", Param)

        If Save = 1 Then
            MsgTool("تم حفظ بيانات المستخدم ( " & LblEmpName.Text & " )", 1)

        ElseIf Save = 2 Then
            MsgTool("لم يتم الحفظ, المستخدم مسجل مسبقاً", 0)
            Exit Sub
        End If
        GetData()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If CmbEmp.SelectedIndex <> -1 Then
            PnlSelectEmp.Visible = False

            TableLayoutPanel4.Enabled = True

            Dim UserRows() As DataRow = DTEmp.Select("ID=" & CmbEmp.SelectedValue)
            LblEmpName.Text = UserRows(0)(1)
            EmpID = UserRows(0)(0)

            CmbEmp.SelectedIndex = -1

            CmbUser.SelectedIndex = -1
            CmbUser.Text = ""
            CurrentUserID = 0
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        PnlSelectEmp.Visible = False

        TableLayoutPanel4.Enabled = True
        BtnRefresh_Click(sender, e)
    End Sub

    Public Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Clear(TLP)
        CurrentUserID = 0
        EmpID = 0
        LblActive.Text = ""
        CmbUser.Focus()
        CmbUser.SelectedIndex = -1
        CmbUser.Text = ""
        GetData()

        ClearTLPermission()
    End Sub

    Private Sub ClearTLPermission()
        ChkAdmin.Checked = False
        ChkAll.Checked = False
        ChkInsert.Checked = False
        ChkUpdate.Checked = False
        ChkDelete.Checked = False
        ChkPrint.Checked = False

        If CurrentUserID = 0 Then
            CmbOperation.SelectedIndex = -1
            CmbOperation.Text = ""
            CmbOperation.Enabled = False
        End If

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If CurrentUserID = 0 Then
            MsgBox("الرجاء اختيار اسم من القائمة", vbMsgBoxRight + vbExclamation, "تنبيه ")
            Exit Sub
        End If

        If CurrentUserID = UserID Then
            MsgTool("لا يمكن حذف المستخدم الحالي للمنظومة", 0)
            Exit Sub
        End If

        If BtnDelete.Text = "حذف" Then
            If vbYes = MsgBox("هل تريد حذف سجل المستخدم " & vbCrLf & CmbUser.Text & " ؟", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الحذف") Then
                Dim SQLCon = New SQLConClass
                Dim Param() As SqlParameter = {
                    New SqlParameter("@ID", CurrentUserID)}

                DSUser = SQLCon.CMDExecuteData("DeleteUser", Param)

                If Save = 1 Then
                    MsgTool("تم حذف المستخدم ", 1)

                ElseIf Save = 2 Then
                    MsgTool("لا يمكن حذف المستخدم", 0)
                End If

            End If

        ElseIf BtnDelete.Text = "استعادة" Then
            If vbYes = MsgBox("هل تريد استعادة المستخدم " & vbCrLf & CmbUser.Text & " ؟", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الاستعادة") Then
                Dim DSRestore As DataSet
                Dim SQLCon = New SQLConClass

                SQLQuery = "Update UserTable Set EndService = NULL Where ID = " & CurrentUserID

                DSRestore = SQLCon.SelectData(SQLQuery, 0, Nothing)
                If Save = 1 Then
                    MsgTool("تمت استعادة المستخدم ", 1)

                ElseIf Save = 2 Then
                    MsgTool("لا يمكن استعادة المستخدم", 0)
                End If
            End If
        End If

        BtnRefresh_Click(sender, e)
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        sender.backcolor = SystemColors.Window
    End Sub

    Private Sub DGVUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUser.CellContentClick
        If DGVUser.RowCount = 0 Then Exit Sub

        IDSearch = DGVUser.Item(0, DGVUser.CurrentRow.Index).Value

        If IDSearch = UserID Then
            MsgTool("لا يمكن ايقاف أو حذف المستخدم الحالي", 0)
            Exit Sub
        End If

        Dim Col = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If Col = "ColDelete" Then
            If Not IsDBNull(DGVUser.Item(6, DGVUser.CurrentRow.Index).Value) Then

                If vbYes = MsgBox("هل تريد استعادة المستخدم " & vbCrLf & "( " & DGVUser.Item(2, DGVUser.CurrentRow.Index).Value & " ) ؟", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الاستعادة") Then
                    Dim DSRestore As DataSet
                    Dim SQLCon = New SQLConClass

                    SQLQuery = "Update UserTable Set EndService = NULL Where ID = " & IDSearch

                    DSRestore = SQLCon.SelectData(SQLQuery, 0, Nothing)
                    If Save = 1 Then
                        MsgTool("تمت استعادة المستخدم ", 1)

                    ElseIf Save = 2 Then
                        MsgTool("لا يمكن استعادة المستخدم", 0)
                    End If
                End If

            Else
                If vbYes = MsgBox("هل تريد حذف المستخدم " & vbCrLf & "( " & DGVUser.Item(2, DGVUser.CurrentRow.Index).Value & " ) بشكل مؤقت ؟ ", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الحذف") Then
                    Dim SQLCon = New SQLConClass
                    Dim Param() As SqlParameter = {
                    New SqlParameter("@ID", IDSearch)}

                    DSUser = SQLCon.CMDExecuteData("DeleteUser", Param)
                    If Save = 1 Then
                        MsgTool("تمت حذف المستخدم بشكل مؤقت", 1)

                    ElseIf Save = 2 Then
                        MsgTool("لا يمكن حذف المستخدم", 0)
                    End If
                End If
            End If

        ElseIf Col = "ColDel" Then


            If vbYes = MsgBox("هل تريد حذف المستخدم  " & vbCrLf & "( " & DGVUser.Item(2, DGVUser.CurrentRow.Index).Value & " ) بشكل نهائي ؟ ", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الحذف") Then
                Dim DSRestore As DataSet
                Dim SQLCon = New SQLConClass

                SQLQuery = "Delete From UserTable Where ID = " & IDSearch

                DSRestore = SQLCon.SelectData(SQLQuery, 0, Nothing)
                If Save = 1 Then
                    MsgTool("تمت حذف المستخدم ", 1)

                ElseIf Save = 2 Then
                    MsgTool("لا يمكن حذف المستخدم", 0)
                End If
            End If

        ElseIf Col = "ColRestore" Then

            If DGVUser.Item(9, DGVUser.CurrentRow.Index).Value Then
                If vbYes = MsgBox("هل تريد تفعيل المستخدم " & vbCrLf & "( " & DGVUser.Item(2, DGVUser.CurrentRow.Index).Value & " ) ؟", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد التفعيل") Then
                    Dim DSRestore As DataSet
                    Dim SQLCon = New SQLConClass

                    SQLQuery = "Update UserTable Set LockedOut='False' Where ID=" & IDSearch

                    DSRestore = SQLCon.SelectData(SQLQuery, 0, Nothing)
                    If Save = 1 Then
                        MsgTool("تمت تفعيل المستخدم ", 1)

                    ElseIf Save = 2 Then
                        MsgTool("لا يمكن تفعيل المستخدم", 0)
                    End If
                End If

            Else
                If vbYes = MsgBox("هل تريد ايقاف المستخدم " & vbCrLf & "( " & DGVUser.Item(2, DGVUser.CurrentRow.Index).Value & " ) ؟", vbMsgBoxRight + vbYesNo + vbQuestion, "تأكيد الايقاف") Then
                    Dim DSRestore As DataSet
                    Dim SQLCon = New SQLConClass

                    SQLQuery = "Update UserTable Set LockedOut='True' Where ID=" & IDSearch

                    DSRestore = SQLCon.SelectData(SQLQuery, 0, Nothing)
                    If Save = 1 Then
                        MsgTool("تمت ايقاف المستخدم ", 1)

                    ElseIf Save = 2 Then
                        MsgTool("لا يمكن ايقاف المستخدم", 0)
                    End If
                End If
            End If

        End If

        BtnRefreshSearch_Click(sender, e)

    End Sub

    Private Sub DGVUser_Click(sender As Object, e As EventArgs) Handles DGVUser.Click
        If DGVUser.RowCount = 0 Then Exit Sub

        IDSearch = DGVUser.Item(0, DGVUser.CurrentRow.Index).Value
        CmbUser.SelectedValue = IDSearch
        CmbUser_SelectionChangeCommitted(Nothing, Nothing)
        Display()
    End Sub

    Private Sub Display()

        Dim Row() As DataRow = DTUser.Select("ID=" & IDSearch)
        If Row.Length > 0 Then
            CmbUser.SelectedValue = Row(0)(0)

            CurrentUserID = Row(0)(0)
            LblEmpName.Text = Row(0)(2)
        End If

    End Sub


    '----Permission-----------------------------------------------------------------------------------
    Private Sub BtnSavePermission_Click(sender As Object, e As EventArgs) Handles BtnSavePermission.Click
        If CurrentUserID = 0 Then
            MsgTool("يرجى اختيار مستخدم أولاً", 0)
            CmbUser.BackColor = Color.FromArgb(244, 206, 193)
            Exit Sub
        End If

        Dim SelectedOperation As Integer = CmbOperation.SelectedValue
        If ChkAdmin.Checked Then
            SQLQuery = " Update PermissionTable Set InsertP=1, UpdateP=1, DeleteP=1, PrintP=1 Where UserID=" & CurrentUserID

        Else
            If CmbOperation.SelectedIndex = -1 Then
                MsgTool("الرجاء تحديد العملية من القائمة", 0)
                CmbOperation.BackColor = Color.FromArgb(244, 206, 193)
                Exit Sub
            End If

            SQLQuery = "Update PermissionTable Set InsertP='" & ChkInsert.Checked & "' ,UpdateP='" & ChkUpdate.Checked &
                "', DeleteP='" & ChkDelete.Checked & "' ,PrintP='" & ChkPrint.Checked &
                "' Where UserID=" & CurrentUserID & " And OperationID=" & CmbOperation.SelectedValue
        End If

        Dim SQLCon = New SQLConClass
        Dim SaveState As Integer = SQLCon.CMDExecute(SQLQuery, 0, Nothing)

        Select Case SaveState
            Case > 0
                MsgTool("تم الحفظ بنجاح", 1)

            Case Else
                MsgTool("لم يتم الحفظ، خطأ في البيانات", 0)
        End Select
    End Sub

    Private Sub ChkAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAdmin.CheckedChanged
        If ChkAdmin.Checked Then
            CmbOperation.Enabled = False
            ChkSelectAll.Checked = True

        Else
            CmbOperation.Enabled = True
            ChkSelectAll.Checked = False
        End If
        CmbOperation.SelectedIndex = -1
        CmbOperation.Text = ""
    End Sub

    Private Sub ChkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSelectAll.CheckedChanged
        If ChkSelectAll.Checked Then
            For Each C As CheckBox In TLPChks.Controls
                If C.Name <> "ChkSelectAll" Then
                    C.Checked = True
                    C.Enabled = False
                End If
            Next

        Else
            For Each C As CheckBox In TLPChks.Controls
                If C.Name <> "ChkSelectAll" Then
                    C.Checked = False
                    C.Enabled = True
                End If
            Next
        End If

        ChkSingleOperation()
    End Sub

    Private Sub ChkSingleOperation()
        If CmbOperation.SelectedValue = 1 Or CmbOperation.SelectedValue = 2 Or CmbOperation.SelectedValue = 3 Or
            CmbOperation.SelectedValue = 4 Then
            For Each C As CheckBox In TLPChks.Controls
                If C.Name = "ChkSelectAll" Then
                    C.Text = "منح الصلاحية"

                Else
                    C.Enabled = False
                End If
            Next

        End If

    End Sub

    Private Sub CmbOperation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOperation.SelectedIndexChanged
        sender.backcolor = SystemColors.Window
    End Sub

    Private Sub CmbOperation_TextChanged(sender As Object, e As EventArgs) Handles CmbOperation.TextChanged
        sender.backcolor = SystemColors.Window
    End Sub

    Private Sub CmbOperation_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbOperation.SelectionChangeCommitted
        For Each C As CheckBox In TLPChks.Controls
            C.Checked = False
            C.Enabled = True
        Next
        ChkSelectAll.Text = "تحديد الكل"

        If CurrentUserID = 0 Then
            MsgTool("يرجى اختيار مستخدم أولاً", 0)
            CmbOperation.SelectedIndex = -1
            CmbOperation.Text = ""
            Exit Sub
        End If

        Dim PermissionRows() As DataRow = DSPermission.Tables(0).Select("OperationID=" & CmbOperation.SelectedValue & " And UserID=" & CurrentUserID)
        If PermissionRows.Length > 0 Then
            ChkInsert.Checked = PermissionRows(0)(3)
            ChkUpdate.Checked = PermissionRows(0)(4)
            ChkDelete.Checked = PermissionRows(0)(5)
            ChkPrint.Checked = PermissionRows(0)(6)
        End If

        ChkSingleOperation()
        If ChkInsert.Checked And ChkUpdate.Checked And ChkDelete.Checked And ChkPrint.Checked Then
            ChkSelectAll.Checked = True

        Else
            ChkSelectAll.Checked = False
        End If

    End Sub
    '----Permission-----------------------------------------------------------------------------------



    '----------Search-------------------------------------------------

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If Not ChkAll.Checked And Not ChkDel.Checked And Not ChkNotDel.Checked And Not ChkName.Checked And Not ChkState.Checked Then
            MsgTool("يرجى اختيار طريقة بحث", 0)
            Exit Sub
        End If

        If ChkState.Checked And Not RadActive.Checked And Not RadNotActive.Checked Then
            MsgTool("يرجى تحديد حالة المستخدم", 0)
            Exit Sub
        End If

        IsDataMissing = False
        IsInputEmpty(TLPSearchOption)
        If IsDataMissing Then
            MsgTool("يرجى التأكد من البيانات", 0)
            Exit Sub
        End If

        GetSearchData()
    End Sub

    Private Sub GetSearchData()
        Dim SQLCon = New SQLConClass()

        If Not ChkAll.Checked And Not ChkDel.Checked And Not ChkNotDel.Checked And Not ChkName.Checked And Not ChkState.Checked Then
            Exit Sub
        End If

        SQLQuery = "Select  ROW_NUMBER() OVER (ORDER BY (Select 1)) As ت,* From  UserView WHERE "
        AppendConditions()


        DSSearch = SQLCon.SelectData(SQLQuery, 0, Nothing)

        If DSSearch.Tables.Count = 1 Then

            FillDGV(DSSearch.Tables(0))
        End If
    End Sub

    Private Sub FillDGV(DT As DataTable)
        DGVUser.SuspendLayout() ' إيقاف التحديثات لتجنب الترميش
        DGVUser.Rows.Clear()

        If DT.Rows.Count > 0 Then
            For I = 0 To DT.Rows.Count - 1
                With DT.Rows(I)
                    DGVUser.Rows.Add()
                    DGVUser.Item(0, I).Value = .Item("ID") ' ID
                    DGVUser.Item(1, I).Value = .Item("ت") ' ت
                    DGVUser.Item(2, I).Value = .Item("Name")  'Name
                    DGVUser.Item(3, I).Value = If(.Item("LockedOut"), "موقوف", "فعًال") 'State
                    DGVUser.Item(4, I).Value = If(IsDBNull(.Item("EndService")), "غير محذوف", "محذوف") 'EndService
                    DGVUser.Item(6, I).Value = .Item("EndService")  'EndService
                    DGVUser.Item(9, I).Value = .Item("LockedOut")  'LockedOut

                    ' تحديث نص زر التفعيل بعد التأكد من أن العمود هو زر
                    Dim btnCell As DataGridViewButtonCell = CType(DGVUser.Rows(I).Cells(5), DataGridViewButtonCell)
                    btnCell.Value = If(.Item("LockedOut"), "تفعيل", "إيقاف")

                    ' تحديث نص زر الاستعادة بعد التأكد من أن العمود هو زر
                    Dim btnCellDel As DataGridViewButtonCell = CType(DGVUser.Rows(I).Cells(7), DataGridViewButtonCell)
                    Dim isDel As Boolean = Not IsDBNull(.Item("EndService"))
                    btnCellDel.Value = If(isDel, "استعادة", "حذف")
                End With
            Next
        End If

        DGVUser.ResumeLayout() ' استئناف التحديثات
        DGVUser.ClearSelection()
        DGVUser.Refresh() ' تحديث العرض لضمان تغيير النصوص
    End Sub

    Private Sub AppendConditions()
        If ChkAll.Checked Then AppendToQuery(" AND ", " 1=1 ")
        If ChkName.Checked Then AppendToQuery(" AND ", " Name Like '%" & TxtName.Text.Trim & "%' ")

        If ChkDel.Checked Then
            AppendToQuery(" AND ", " EndService IS Not NULL And ID<>1 ")
        End If

        If ChkNotDel.Checked Then
            AppendToQuery(" AND ", " EndService IS NULL ")
        End If

        If ChkState.Checked Then AppendToQuery(" AND ", " LockedOut='" & RadNotActive.Checked & "' ")
    End Sub

    Private Sub AppendToQuery(Oprtr As String, Query As String)

        Dim TestString As String = StrReverse(SQLQuery)
        If StrReverse(TestString.Substring(0, 6).ToUpper) = "WHERE " Then
            SQLQuery &= Query
        Else
            SQLQuery &= Oprtr & " " & Query
        End If

    End Sub

    Private Sub BtnRefreshSearch_Click(sender As Object, e As EventArgs) Handles BtnRefreshSearch.Click
        ChkAll.Checked = True
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub ChkAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAll.CheckedChanged
        DGVUser.Rows.Clear()

        If ChkAll.Checked Then
            ChkName.Checked = False
            ChkDel.Checked = False
            ChkNotDel.Checked = False
            ChkState.Checked = False

        End If
    End Sub

    Private Sub ChkDel_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDel.CheckedChanged
        DGVUser.Rows.Clear()

        If ChkDel.Checked Then
            ChkAll.Checked = False
        End If
    End Sub

    Private Sub ChkNotDel_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNotDel.CheckedChanged
        DGVUser.Rows.Clear()

        If ChkNotDel.Checked Then
            ChkAll.Checked = False
        End If
    End Sub

    Private Sub ChkName_CheckedChanged(sender As Object, e As EventArgs) Handles ChkName.CheckedChanged
        DGVUser.Rows.Clear()

        If ChkName.Checked Then
            TxtName.Enabled = True
            TxtName.Focus()
            ChkAll.Checked = False

        Else
            TxtName.Enabled = False
            TxtName.Text = ""
            TxtName.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub ChkState_CheckedChanged(sender As Object, e As EventArgs) Handles ChkState.CheckedChanged
        DGVUser.Rows.Clear()

        If ChkState.Checked Then
            RadActive.Enabled = True
            RadNotActive.Enabled = True
            ChkAll.Checked = False

        Else
            RadActive.Enabled = False
            RadActive.Checked = False
            RadNotActive.Enabled = False
            RadNotActive.Checked = False
        End If
    End Sub

    Private Sub RadActive_CheckedChanged(sender As Object, e As EventArgs) Handles RadActive.CheckedChanged
        DGVUser.Rows.Clear()
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        PnlSelectEmp.Visible = False
        TableLayoutPanel4.Enabled = True
    End Sub

    Private Sub RadNotActive_CheckedChanged(sender As Object, e As EventArgs) Handles RadNotActive.CheckedChanged
        DGVUser.Rows.Clear()
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub LblUserData_Click(sender As Object, e As EventArgs) Handles LblUserData.Click
        PnlUser.BringToFront()

        LblShadow1.Visible = True
        LblShadow2.Visible = False

        PicShowPassword.BringToFront()

    End Sub

    Private Sub LblUserReport_Click(sender As Object, e As EventArgs) Handles LblUserReport.Click
        PnlReport.BringToFront()

        LblShadow2.Visible = True
        LblShadow1.Visible = False

        ChkAll.Checked = True
        BtnSearch_Click(sender, e)

    End Sub

    Private Sub BtnResetPassword_Click_1(sender As Object, e As EventArgs) Handles BtnResetPassword.Click
        TxtPassword.Text = "0000"
    End Sub


    '----------Search-------------------------------------------------


    Private Sub PnlTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseDown
        If e.Button = MouseButtons.Left Then
            SW = True
            Pos = e.Location
        End If
    End Sub

    Private Sub PnlTitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseMove
        If SW Then
            PnlSelectEmp.Location += e.Location - Pos
        End If
    End Sub

    Private Sub PnlTitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseUp
        If e.Button = MouseButtons.Left Then
            SW = False
        End If
    End Sub

    Private Sub FrmUsers_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub DGVUser_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVUser.CellFormatting
        If DGVUser.Rows(e.RowIndex).Cells(4).Value = "محذوف" Then
            e.CellStyle.BackColor = Color.FromArgb(244, 206, 193)
            e.CellStyle.SelectionBackColor = Color.FromArgb(244, 206, 193)
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.SelectionForeColor = Color.Black
        End If

    End Sub

    Private Sub PicShowPassword_MouseMove(sender As Object, e As MouseEventArgs) Handles PicShowPassword.MouseMove
        TxtPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub PicShowPassword_MouseLeave(sender As Object, e As EventArgs) Handles PicShowPassword.MouseLeave
        TxtPassword.UseSystemPasswordChar = True
    End Sub
End Class