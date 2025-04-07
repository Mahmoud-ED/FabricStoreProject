Imports System.Data.SqlClient

Public Class FrmSuppleir
    Private DS As DataSet

    Public ID As Integer = 0


    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmStors_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            GetData()
            TxtSupplerName.Focus()
            If SuppleirReportID <> 0 Then
                CmbSuppleir.SelectedValue = SuppleirReportID
                BtnShow.PerformClick()
            End If

        Else
            If Not IsNothing(DS) Then
                DS.Clear()
            End If
            Clear(TLPData)
            CmbSuppleir.Text = ""
            ChangeControlColor(Me)
        End If
    End Sub

    Private Sub GetData()
        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=98")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        Dim sqlcon As New SQLConClass()
        SQLQuery = " Select * from SuppliersTable where EndService IS NUll "

        DS = sqlcon.SelectData(SQLQuery, 0, Nothing)
        If Not DSHasTables(DS) Then Exit Sub
        Fillcmb(DS.Tables(0))
    End Sub

    Private Sub Fillcmb(T As DataTable)
        CmbSuppleir.DataSource = T
        CmbSuppleir.DisplayMember = "Name"
        CmbSuppleir.ValueMember = "ID"
        CmbSuppleir.SelectedIndex = -1
    End Sub

    Private Sub FillDGV(T As DataTable)

        DGVSuppleir.Rows.Clear()
        For i = 0 To T.Rows.Count - 1
            With T.Rows(i)
                DGVSuppleir.Rows.Add()
                DGVSuppleir.Item(0, i).Value = .Item("ID")
                DGVSuppleir.Item(1, i).Value = .Item("Name")
                DGVSuppleir.Item(2, i).Value = .Item("Address")

                If Not .Item("Phone1") = "" Then
                    DGVSuppleir.Item(3, i).Value = .Item("Phone1")
                End If

                If Not .Item("Phone2") = "" Then
                    If DGVSuppleir.Item(3, i).Value = "" Then
                        DGVSuppleir.Item(3, i).Value = .Item("Phone2")

                    Else
                        DGVSuppleir.Item(3, i).Value = DGVSuppleir.Item(3, i).Value & " - " & .Item("Phone2")
                    End If
                End If

            End With
            DGVSuppleir.ClearSelection()
        Next
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=98")

        'If Perm(0)(6) = False Then
        '    MsgTool("ليس لديك صلاحية العرض", 0)
        '    Exit Sub
        'End If

        If IsNothing(CmbSuppleir.SelectedValue) Then
            CmbSuppleir.BackColor = RedColor
            MsgTool(" يرجى اختيار مورد لعرض بياناته ", 0)
            Exit Sub
        End If
        ID = CmbSuppleir.SelectedValue
        Display(ID)
    End Sub

    Private Sub Display(ID As Integer)
        Dim ItemRow() As DataRow = DS.Tables(0).Select("ID=" & CmbSuppleir.SelectedValue)
        TxtSupplerName.Text = ItemRow(0)("Name")
        TxtAddress.Text = ItemRow(0)("Address").ToString
        TxtPhone1.Text = ItemRow(0)("Phone1")
        TxtPhone2.Text = ItemRow(0)("Phone2")

        With ItemRow
            DGVSuppleir.Rows.Add()
            DGVSuppleir.Item(0, 0).Value = ItemRow(0)("ID")
            DGVSuppleir.Item(1, 0).Value = ItemRow(0)("Name")
            DGVSuppleir.Item(2, 0).Value = ItemRow(0)("Address")

            If Not ItemRow(0)("Phone1") = "" Then
                DGVSuppleir.Item(3, 0).Value = ItemRow(0)("Phone1")
            End If

            If Not ItemRow(0)("Phone2") = "" Then
                If DGVSuppleir.Item(3, 0).Value = "" Then
                    DGVSuppleir.Item(3, 0).Value = ItemRow(0)("Phone2")

                Else
                    DGVSuppleir.Item(3, 0).Value = DGVSuppleir.Item(3, 0).Value & " - " & ItemRow(0)("Phone2")
                End If
            End If

        End With
        DGVSuppleir.ClearSelection()
    End Sub

    Public Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Clear(TLPData)
        CmbSuppleir.SelectedIndex = -1
        ID = 0
        DGVSuppleir.Rows.Clear()
        ChangeControlColor(Me)
        GetData()
    End Sub

    Private Sub TxtSupplerName_TextChanged(sender As Object, e As EventArgs) Handles TxtSupplerName.TextChanged, CmbSuppleir.TextChanged
        sender.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtSupplerName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPhone1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone1.KeyPress
        e.Handled = Not IsPhone(sender.Text, e)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=98")

        'If Perm(0)(5) = False Then
        '    MsgTool("ليس لديك صلاحية الحذف", 0)
        '    Exit Sub
        'End If

        If ID = 0 Then Exit Sub
        If MsgBox("هل أنت متأكد من أنك تريد حذف هذا المورد ؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "تأكيد الحذف") Then

            Dim sqlcon As New SQLConClass()
            Dim Param() As SqlParameter = {
            New SqlParameter("ID", ID)}
            DS = sqlcon.CMDExecuteData("DeleteSuppleir", Param)
            Clear(TLPData)
            CmbSuppleir.Text = ""
            If Save = 1 Then
                MsgTool("تم الحذف بنجاح", 1)

            Else
                MsgTool(" لايمكن الحذف راجع حسابات المورد", 0)
            End If
        End If
        BtnNew.PerformClick()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=98")

        'If Perm(0)(3) = False And ID = 0 Then
        '    MsgTool("ليس لديك صلاحية الإضافة", 0)
        '    Exit Sub
        'ElseIf Perm(0)(4) = False And ID <> 0 Then
        '    MsgTool("ليس لديك صلاحية التعديل", 0)
        '    Exit Sub
        'End If

        IsDataMissing = False
        IsInputEmpty(TLPData)

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
            New SqlParameter("ID", ID),
            New SqlParameter("Name", TxtSupplerName.Text.Trim),
            New SqlParameter("@Phone1", TxtPhone1.Text),
            New SqlParameter("@Phone2", TxtPhone2.Text),
            New SqlParameter("Address", TxtAddress.Text.Trim)}
        DS = Sqlcon.CMDExecuteData("SaveSuppler", param)
        If Not DSHasTables(DS) Then Exit Sub
        If Save = 1 Then
            MsgTool("تم حفظ البيانات بنجاح", 1)
        End If
        Fillcmb(DS.Tables(0))
        CmbSuppleir.SelectedValue = DS.Tables(1).Rows(0).Item(0)
        BtnShow.PerformClick()
        FillDGV(DS.Tables(1))
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) 

        'Dim Perm() As DataRow = DTUserPermission.Select("OperationID=98")

        'If Perm(0)(7) = False Then
        '    MsgTool("ليس لديك صلاحية الطباعة", 0)
        '    Exit Sub
        'End If

        'If ID = 0 Then
        '    Exit Sub
        'End If


        'Dim DSPrint = New DataSet
        'Dim SQLCon = New SQLConClass

        'SQLQuery = "SELECT * FROM SuppliersView WHERE ID=" & ID
        'SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        'DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        'Dim F As New FrmPrint
        'Dim C As New CRSuppliers

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

    Private Sub TxtPhone1_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone1.TextChanged, TxtPhone2.TextChanged, TxtSupplerName.TextChanged, TxtAddress.TextChanged
        sender.backColor = SystemColors.Window
    End Sub

    Private Sub DGVSuppleir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSuppleir.CellContentClick
    End Sub

    Private Sub DGVSuppler_Click(sender As Object, e As EventArgs) Handles DGVSuppleir.Click
        If CheckDGVError(DGVSuppleir) Then Exit Sub
        Dim CR As Integer
        CR = DGVSuppleir.CurrentRow.Index
        CmbSuppleir.SelectedValue = DGVSuppleir.Item(0, CR).Value
        If IsNothing(CmbSuppleir.SelectedValue) Then Exit Sub
        BtnShow.PerformClick()
    End Sub


    Private Sub TxtPhone2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone2.KeyPress
        e.Handled = Not IsPhone(sender.Text, e)
    End Sub

    Private Sub CmbSuppleir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSuppleir.SelectedIndexChanged
        ClearData()
    End Sub

    Private Sub ClearData()
        Clear(TLPData)
        DGVSuppleir.Rows.Clear()
    End Sub

    Private Sub CmbSuppleir_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbSuppleir.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnShow.PerformClick()
        End If
    End Sub
End Class