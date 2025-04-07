
Imports System.Data.SqlClient


Public Class FrmEmployeesData

    '------------------FrmShowEmpData-----------------------

    Private DsSave As DataSet
    '  ------------------FrmEmployeeBaicData-----------------------
    Private DSLoadBasic, DSDisplay As DataSet
    Private CR As Integer


    Private EmployeName As String
    Private FromSearch As Boolean ' البجنيشن مايجيبش صورة في حالة ما بحثش

    Private Sub FrmEmployeesData_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Me.Visible = True Then
            GetData()
            TxtEmployeeName.Focus()
            If EmployeReportID <> 0 Then
                CmbEmpName.SelectedValue = EmployeReportID
                BtnShow.PerformClick()
            End If

        Else
            CleanData()
            If Not IsNothing(DSLoadBasic) Then
                DSLoadBasic.Clear()
            End If
            If Not IsNothing(DSDisplay) Then
                DSDisplay.Clear()
            End If

        End If

    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmEmployeesData_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Height = 680
        TxtEmployeeName.Focus()
        DGVEmp.RowTemplate.Height = DGVEmp.Height - DGVEmp.ColumnHeadersHeight


    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=34")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        ChangeControlColor(Me)
        If IsNothing(CmbEmpName.SelectedValue) Then
            MsgTool("يرجى اختيار موظف من شريط البحث", 0)
            CmbEmpName.BackColor = RedColor '
            Exit Sub
        End If

        EmployeReportID = CmbEmpName.SelectedValue
        EmployeName = CmbEmpName.Text.Trim
        TxtEmployeeName.Text = EmployeName
        DisplayData()
    End Sub

    Private Sub GetData()

        Dim Sqlcon As New SQLConClass()
        SQLQuery = " Select ID,Name from EmployeeTable  where EndService IS NULL  "
        DSLoadBasic = Sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DSLoadBasic) Then
            FillCmb()
        End If

    End Sub

    Private Sub FillCmb()
        CmbEmpName.DataSource = DSLoadBasic.Tables(0)
        CmbEmpName.ValueMember = "ID"
        CmbEmpName.DisplayMember = "Name"
        CmbEmpName.SelectedIndex = -1

    End Sub

    Private Sub DisplayData()

        If EmployeReportID = 0 Then Exit Sub 'Extra code 
        Dim Sqlcon As New SQLConClass()

        SQLQuery = " Select * from EmployeeTable Where EndService IS NULL and ID = " & EmployeReportID
        DSDisplay = Sqlcon.SelectData(SQLQuery, 0, Nothing)

        FillDGV()
        Dim ItemRows() As DataRow = DSDisplay.Tables(0).Select("ID=" & EmployeReportID)
        If ItemRows.Length > 0 Then
            CmbEmpName.SelectedValue = ItemRows(0)("ID")
            TxtEmployeeName.Text = ItemRows(0)("Name")
            TxtAddress.Text = ItemRows(0)("Address")
            TxtPhone1.Text = ItemRows(0)("Phone1")
            TxtPhone2.Text = ItemRows(0)("Phone2")
        End If

    End Sub

    Private Sub FillDGV()

        DGVEmp.Rows.Clear()
        For i = 0 To DSDisplay.Tables(0).Rows.Count - 1
            With DSDisplay.Tables(0).Rows(i)
                DGVEmp.Rows.Add()
                DGVEmp.Item(0, i).Value = .Item("ID")
                DGVEmp.Item(1, i).Value = .Item("Name")
                DGVEmp.Item(2, i).Value = .Item("Address")

                If Not .Item("Phone1") = "" Then
                    DGVEmp.Item(3, i).Value = .Item("Phone1")
                End If

                If Not .Item("Phone2") = "" Then
                    If DGVEmp.Item(3, i).Value = "" Then
                        DGVEmp.Item(3, i).Value = .Item("Phone2")

                    Else
                        DGVEmp.Item(3, i).Value = DGVEmp.Item(3, i).Value & " - " & .Item("Phone2")
                    End If
                End If

            End With
            DGVEmp.ClearSelection()
        Next
    End Sub

    '-------------------DGVClik


    Private Sub DGVEmp_Click(sender As Object, e As EventArgs) Handles DGVEmp.Click
        If CheckDGVError(DGVEmp) = True Then Exit Sub
        EmployeReportID = DGVEmp.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub TxtEmployeeName_TextChanged(sender As Object, e As EventArgs) Handles TxtEmployeeName.TextChanged
        sender.BackColor = SystemColors.Window
        EmployeName = TxtEmployeeName.Text.Trim
    End Sub

    Private Sub BtnRefreshBasic_Click(sender As Object, e As EventArgs) Handles BtnRefreshBasic.Click
        CleanData()
        GetData()
    End Sub

    Private Sub CleanData()

        ChangeControlColor(Me)

        EmployeReportID = 0
        Clear(TableLayoutPanel6)
        DGVEmp.Rows.Clear()
        CmbEmpName.Text = ""
        CR = 0

        TxtEmployeeName.BackColor = SystemColors.Window
        TxtAddress.BackColor = SystemColors.Window
        TxtPhone1.BackColor = SystemColors.Window
        TxtPhone2.BackColor = SystemColors.Window
    End Sub

    Private Sub BtnDeleteBasic_Click(sender As Object, e As EventArgs) Handles BtnDeleteBasic.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=34")

        'If Perm(0)(5) = False Then
        '    MsgTool("ليس لديك صلاحية الحذف", 0)
        '    Exit Sub
        'End If


        If EmployeReportID = 0 Then Exit Sub
        If MsgBox("هل تريد بالتأكيد الحذف ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "تأكيد الحذف") = MsgBoxResult.Yes Then

            If EmployeReportID = 0 Then Exit Sub
            Dim param() As SqlParameter = {New SqlParameter("ID", EmployeReportID)}
            Dim sqlCon As New SQLConClass()
            Dim s As Integer = sqlCon.CMDExecute("DeleteEmployee", 1, param)
            If s = 1 Then
                MsgTool("تم الحذف بنجاح", 1)

            ElseIf s = 2 Then
                MsgTool("لا يمكن حذف الموظف ، الموظف لديه سجلات", 0)
            End If
            BtnRefreshBasic.PerformClick()

        End If
    End Sub

    Private Sub CmbEmpName_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbEmpName.SelectedValueChanged

        ChangeControlColor(TableLayoutPanel6)

        'TxtEmployeeName.BackColor = SystemColors.Window
        'TxtIDNum.BackColor = SystemColors.Window
        'TxtPassportNum.BackColor = SystemColors.Window
        'TxtPhone1.BackColor = SystemColors.Window
        'TxtPhone2.BackColor = SystemColors.Window
        'TxtSalaryValue.BackColor = SystemColors.Window
        'CmbNationality.BackColor = SystemColors.Window
        'CmbPeriod.BackColor = SystemColors.Window

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=34")

        'If Perm(0)(3) = False And EmployeReportID = 0 Then
        '    MsgTool("ليس لديك صلاحية الإضافة", 0)
        '    Exit Sub
        'ElseIf Perm(0)(4) = False And EmployeReportID <> 0 Then
        '    MsgTool("ليس لديك صلاحية التعديل", 0)
        '    Exit Sub
        'End If

        IsDataMissing = False
        IsInputEmpty(TableLayoutPanel6)

        If TxtPhone1.Text.Length <> 10 Then
            TxtPhone1.BackColor = RedColor
            MsgTool("يرجى اختيار رقم هاتف صحيح", 0)
            Exit Sub
        End If

        Dim PhoneNum As String
        PhoneNum = TxtPhone1.Text.Substring(0, 2)

        If PhoneNum <> "09" Then
            MsgTool("يرجى التأكد من الرقم الهاتف", 0)
            TxtPhone1.BackColor = RedColor
            Exit Sub
        End If

        If TxtPhone2.Text.Length <> 10 Then
            TxtPhone2.BackColor = RedColor
            MsgTool("يرجى اختيار رقم هاتف صحيح", 0)
            Exit Sub
        End If
        PhoneNum = TxtPhone2.Text.Substring(0, 2)

        If PhoneNum <> "09" Then
            MsgTool("يرجى التأكد من الرقم الهاتف", 0)
            TxtPhone2.BackColor = RedColor
            Exit Sub
        End If


        Dim Sqlcon As New SQLConClass()
        Dim param() As SqlParameter = {
             New SqlParameter("@ID", EmployeReportID),
             New SqlParameter("Name", EmployeName),
             New SqlParameter("Address", TxtAddress.Text),
             New SqlParameter("Phone1", TxtPhone1.Text),
             New SqlParameter("Phone2", TxtPhone2.Text)}

        DsSave = Sqlcon.CMDExecuteData("SaveEmploye", param)
        If DSHasTables(DsSave) Then
            If Save = 2 Then
                MsgTool("هذا الإسم مسجل بالفعل", 0)
                TxtEmployeeName.SelectAll()
                TxtEmployeeName.Focus()

            ElseIf Save = 1 Then
                MsgTool("تم حفظ بيانات الموظف", 1)
                If DsSave.Tables(0).Rows.Count > 0 Then
                    CmbEmpName.DataSource = DsSave.Tables(0)
                    CmbEmpName.ValueMember = "ID"
                    CmbEmpName.DisplayMember = "Name"
                    CmbEmpName.SelectedValue = DsSave.Tables(0).Rows(0).Item(0)
                    BtnShow_Click(sender, e)
                End If

            End If
            EmployeReportID = DsSave.Tables(0).Rows(0).Item(0)
        End If
    End Sub


    Public Function IsIDNum(Txt As String, Number As KeyPressEventArgs) As Boolean

        If Asc(Number.KeyChar) = Keys.Space Then Return False
        If Number.KeyChar = vbBack Then Return True
        If Not Txt.Length < 13 Then Return False

        Return True

    End Function

    Private Sub TxtEmployeeName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmployeeName.KeyPress
        If Asc(e.KeyChar) = Keys.Tab Then
            TxtPhone1.Focus()
        End If
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmEmployes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then BtnSave.PerformClick()
        If e.KeyCode = Keys.F2 Then BtnRefreshBasic.PerformClick()
        If e.KeyCode = Keys.Tab Then Exit Sub
    End Sub

    Private Sub TxtPhone1_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone1.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPhone1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone1.KeyPress
        e.Handled = Not IsPhone(sender.Text, e)

    End Sub

    Private Sub CmbEmpName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEmpName.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
        CR = 0

        Clear(TableLayoutPanel6)

        DGVEmp.Rows.Clear()
        ChangeControlColor(TableLayoutPanel12)

    End Sub

    Private Sub CmbEmpName_TextChanged(sender As Object, e As EventArgs) Handles CmbEmpName.TextChanged
        If sender.BackColor <> SystemColors.Window Then sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbEmpName_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbEmpName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnShow.PerformClick()
        End If
    End Sub

    Private CrJob As Integer = -1


    Private Sub TxtPhone2_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone2.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone2.KeyPress
        e.Handled = Not IsPhone(sender.Text, e)
    End Sub

End Class