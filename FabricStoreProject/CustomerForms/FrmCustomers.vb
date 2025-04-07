Imports System.Data.SqlClient

Public Class FrmCustomers


    '  ------------------FrmEmployeeBaicData-----------------------
    Private DSSave, DSLoadBasic, DSDisplay As DataSet
    Private CR As Integer


    Private Name As String
    Private FromSearch As Boolean ' البجنيشن مايجيبش صورة في حالة ما بحثش

    Private Sub FrmCustomers_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Me.Visible = True Then
            GetData()
            TxtName.Focus()
            If CustomerReportID <> 0 Then
                CmbName.SelectedValue = CustomerReportID
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

    Private Sub FrmCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Height = 680
        TxtName.Focus()
        DGVEmp.RowTemplate.Height = DGVEmp.Height - DGVEmp.ColumnHeadersHeight
    End Sub

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=34")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        ChangeControlColor(Me)
        If IsNothing(CmbName.SelectedValue) Then
            MsgTool("يرجى اختيار زبون من شريط البحث", 0)
            CmbName.BackColor = RedColor '
            Exit Sub
        End If

        CustomerReportID = CmbName.SelectedValue
        Name = CmbName.Text.Trim
        TxtName.Text = Name
        DisplayData()
    End Sub

    Private Sub GetData()

        Dim Sqlcon As New SQLConClass()
        SQLQuery = " Select ID,Name from CustomersTable  where EndService IS NULL  "
        DSLoadBasic = Sqlcon.SelectData(SQLQuery, 0, Nothing)
        If DSHasTables(DSLoadBasic) Then
            FillCmb()
        End If

    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        sender.BackColor = SystemColors.Window
        Name = TxtName.Text.Trim
    End Sub

    Private Sub FillCmb()
        CmbName.DataSource = DSLoadBasic.Tables(0)
        CmbName.ValueMember = "ID"
        CmbName.DisplayMember = "Name"
        CmbName.SelectedIndex = -1

    End Sub

    Private Sub DisplayData()

        If CustomerReportID = 0 Then Exit Sub 'Extra code 
        Dim Sqlcon As New SQLConClass()

        SQLQuery = " Select * from CustomersTable Where EndService IS NULL and ID = " & CustomerReportID
        DSDisplay = Sqlcon.SelectData(SQLQuery, 0, Nothing)

        FillDGV()
        Dim ItemRows() As DataRow = DSDisplay.Tables(0).Select("ID=" & CustomerReportID)
        If ItemRows.Length > 0 Then
            CmbName.SelectedValue = ItemRows(0)("ID")
            TxtName.Text = ItemRows(0)("Name")
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

    Private Sub CmbName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbName.SelectedIndexChanged
        sender.BackColor = SystemColors.Window
        CR = 0

        Clear(TableLayoutPanel6)

        DGVEmp.Rows.Clear()
        ChangeControlColor(TableLayoutPanel12)
    End Sub

    '-------------------DGVClik


    Private Sub DGVEmp_Click(sender As Object, e As EventArgs) Handles DGVEmp.Click
        If CheckDGVError(DGVEmp) = True Then Exit Sub
        CustomerReportID = DGVEmp.CurrentRow.Index
        DisplayData()
    End Sub

    Private Sub BtnRefreshBasic_Click(sender As Object, e As EventArgs) Handles BtnRefreshBasic.Click
        CleanData()
        GetData()
    End Sub

    Private Sub CleanData()

        ChangeControlColor(Me)

        CustomerReportID = 0
        Clear(TableLayoutPanel6)
        DGVEmp.Rows.Clear()
        CmbName.Text = ""
        CR = 0

        TxtName.BackColor = SystemColors.Window
        TxtAddress.BackColor = SystemColors.Window
        TxtPhone1.BackColor = SystemColors.Window
        TxtPhone2.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtAddress_TextChanged(sender As Object, e As EventArgs) Handles TxtAddress.TextChanged
        sender.backColor = SystemColors.Window
    End Sub

    Private Sub BtnDeleteBasic_Click(sender As Object, e As EventArgs) Handles BtnDeleteBasic.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=34")

        'If Perm(0)(5) = False Then
        '    MsgTool("ليس لديك صلاحية الحذف", 0)
        '    Exit Sub
        'End If


        If CustomerReportID = 0 Then Exit Sub
        If MsgBox("هل تريد بالتأكيد الحذف ؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "تأكيد الحذف") = MsgBoxResult.Yes Then

            If CustomerReportID = 0 Then Exit Sub
            Dim param() As SqlParameter = {New SqlParameter("ID", CustomerReportID)}
            Dim sqlCon As New SQLConClass()
            Dim s As Integer = sqlCon.CMDExecute("DeleteCustomer", 1, param)
            If s = 1 Then
                MsgTool("تم الحذف بنجاح", 1)

            ElseIf s = 2 Then
                MsgTool("لا يمكن حذف الزبون ، الزبون لديه فواتير", 0)
            End If
            BtnRefreshBasic.PerformClick()

        End If
    End Sub

    Private Sub CmbName_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbName.SelectedValueChanged
        ChangeControlColor(TableLayoutPanel6)
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Asc(e.KeyChar) = Keys.Tab Then
            TxtPhone1.Focus()
        End If
    End Sub

    Private Sub TxtName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtName.KeyDown
        If e.KeyCode = Keys.F1 Then BtnSave.PerformClick()
        If e.KeyCode = Keys.F2 Then BtnRefreshBasic.PerformClick()
        If e.KeyCode = Keys.Tab Then Exit Sub
    End Sub

    Private Sub TxtPhone1_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone1.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPhone1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone1.KeyPress
        e.Handled = Not IsPhone(sender.Text, e)

    End Sub

    Private Sub CmbName_TextChanged(sender As Object, e As EventArgs) Handles CmbName.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub CmbName_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnShow.PerformClick()
        End If
    End Sub

    Private Sub TxtPhone2_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone2.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtPhone2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone2.KeyPress
        e.Handled = Not IsPhone(sender.Text, e)
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
             New SqlParameter("@ID", CustomerReportID),
             New SqlParameter("Name", TxtName.Text),
             New SqlParameter("Address", TxtAddress.Text),
             New SqlParameter("Phone1", TxtPhone1.Text),
             New SqlParameter("Phone2", TxtPhone2.Text)}

        DSSave = Sqlcon.CMDExecuteData("SaveCustomer", param)
        If DSHasTables(DsSave) Then
            If Save = 2 Then
                MsgTool("هذا الإسم مسجل بالفعل", 0)
                TxtName.SelectAll()
                TxtName.Focus()

            ElseIf Save = 1 Then
                MsgTool("تم حفظ بيانات الزبون", 1)
                If DsSave.Tables(0).Rows.Count > 0 Then
                    CmbName.DataSource = DSSave.Tables(0)
                    CmbName.ValueMember = "ID"
                    CmbName.DisplayMember = "Name"
                    CmbName.SelectedValue = DSSave.Tables(1).Rows(0).Item(0)
                    BtnShow_Click(sender, e)
                End If

            End If
            EmployeReportID = DSSave.Tables(1).Rows(0).Item(0)
        End If
    End Sub

End Class