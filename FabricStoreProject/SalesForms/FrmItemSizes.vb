Imports System.Data.SqlClient
Imports System.Web.Services.Description

Public Class FrmItemSizes
    Private DSSearch As New DataSet


    Public ItemID As Integer

    Private Sub FrmItemSizes_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeSystemColors(Me)
        GetData()
    End Sub
    Private Sub GetData()
        Dim SQLCon = New SQLConClass()

        SQLQuery = " Select ID, Name, ItemStoreNum, Size, Shoulder, Chest, Waist, Sleeve, Height, Armpit, Hip From ItemsView
                    Where EndService IS Null And ItemStoreID= '" & ItemID & "'"

        DSSearch = SQLCon.SelectData(SQLQuery, 0, Nothing)
        CleanSizes()

        If DSHasTables(DSSearch) Then
            If DSSearch.Tables(0).Rows.Count > 0 Then

                With DSSearch.Tables(0).Rows(0)
                    LblOrderData.Text = " مقاسات القطعة " + .Item("ItemStoreNum")
                    If Not IsDBNull(.Item("Size")) Then
                        TxtSize.Text = .Item("Size")
                    End If

                    If Not IsDBNull(.Item("Armpit")) Then
                        TxtArmpit.Text = .Item("Armpit")
                    End If
                    If Not IsDBNull(.Item("Chest")) Then
                        TxtChest.Text = .Item("Chest")
                    End If
                    If Not IsDBNull(.Item("Height")) Then
                        TxtHeight.Text = .Item("Height")
                    End If
                    If Not IsDBNull(.Item("Hip")) Then
                        TxtHip.Text = .Item("Hip")
                    End If
                    If Not IsDBNull(.Item("Shoulder")) Then
                        TxtShoulder.Text = .Item("Shoulder")
                    End If
                    If Not IsDBNull(.Item("Sleeve")) Then
                        TxtSleeve.Text = .Item("Sleeve")
                    End If
                    If Not IsDBNull(.Item("Waist")) Then
                        TxtWaist.Text = .Item("Waist")
                    End If
                End With

            End If

        End If
    End Sub

    Private Sub CleanSizes()
        TxtSize.Text = ""
        TxtHeight.Text = ""
        TxtShoulder.Text = ""
        TxtSleeve.Text = ""
        TxtArmpit.Text = ""
        TxtChest.Text = ""
        TxtWaist.Text = ""
        TxtHip.Text = ""
    End Sub

    Private Sub PnlEditOrder_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseDown, LblOrderData.MouseDown
        MoveObject(e, MouseEvent.Down, Me)
    End Sub

    Private Sub PnlEditOrder_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseMove, LblOrderData.MouseMove
        MoveObject(e, MouseEvent.Move, Me)
    End Sub

    Private Sub PnlEditOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlEditOrder.MouseUp, LblOrderData.MouseUp
        MoveObject(e, MouseEvent.Up, Me)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub TxtSize_TextChanged(sender As Object, e As EventArgs) Handles TxtSize.TextChanged

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
            TxtSleeve.Focus()
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

    Private Sub TxtSleeve_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSleeve.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtSleeve_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSleeve.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtWaist.Focus()
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

    Private Sub TxtArmpit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArmpit.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtArmpit_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtArmpit.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHip.Focus()
        End If
    End Sub

    Private Sub TxtHip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHip.KeyPress
        e.Handled = Not Price(sender.Text, e.KeyChar, False, True)
    End Sub

    Private Sub TxtHip_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtHip.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave_Click(sender, e)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim Size As String = ""
        Dim Armpit As Double = 0
        Dim Chest As Double = 0
        Dim CusHeight As Double = 0
        Dim Hip As Double = 0
        Dim Shoulder As Double = 0
        Dim Sleeve As Double = 0
        Dim Waist As Double = 0


        If TxtSize.Text <> "" Then
            Size = TxtSize.Text.Trim
        End If

        If TxtArmpit.Text <> "" Then
            Armpit = Val(TxtArmpit.Text.Trim)
        End If
        If TxtChest.Text <> "" Then
            Chest = Val(TxtChest.Text.Trim)
        End If
        If TxtHeight.Text <> "" Then
            CusHeight = Val(TxtHeight.Text.Trim)
        End If
        If TxtHip.Text <> "" Then
            Hip = Val(TxtHip.Text.Trim)
        End If
        If TxtShoulder.Text <> "" Then
            Shoulder = Val(TxtShoulder.Text.Trim)
        End If
        If TxtSleeve.Text <> "" Then
            Sleeve = Val(TxtSleeve.Text.Trim)
        End If
        If TxtWaist.Text <> "" Then
            Waist = Val(TxtWaist.Text.Trim)
        End If

        Dim SQLCon = New SQLConClass
        Dim Param() As SqlParameter = {
        New SqlParameter("@ID", ItemID),
        New SqlParameter("@Size", Size),
        New SqlParameter("@Height", CusHeight),
        New SqlParameter("@Shoulder", Shoulder),
        New SqlParameter("@Sleeve", Sleeve),
        New SqlParameter("@Armpit", Armpit),
        New SqlParameter("@Chest", Chest),
        New SqlParameter("@Waist", Waist),
        New SqlParameter("@Hip", Hip)}

        Dim DS As DataSet = SQLCon.CMDExecuteData("EditSize", Param)

        MsgTool("تم تعديل بيانات الطلب  ", 1)

    End Sub

    Private Sub BtnSizeRefresh_Click(sender As Object, e As EventArgs) Handles BtnSizeRefresh.Click
        Clear(TLPOrder)
    End Sub
End Class