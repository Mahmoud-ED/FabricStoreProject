Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.Remoting.Channels
Imports System.Xml
Imports Leadtools.Codecs

Module MdlSystemColors


    ' This Sub will get the colors from SettingsProject and change the color of all controls in the container
    Public Sub ChangeSystemColors(Container)

        ' Get colors
        Dim Dark As Color = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Dim Primary As Color = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
        Dim Light As Color = Settings.GetSettings(ClassSettings.Setting.ColorLight)

        ' Declare controls types
        Dim Btn As Button = Nothing
        Dim Pnl As Panel = Nothing
        Dim TLP As TableLayoutPanel = Nothing
        Dim SC As SplitContainer = Nothing
        Dim Grp As GroupBox = Nothing
        Dim Lbl As Label = Nothing
        Dim SS As StatusStrip = Nothing
        Dim DGV As DataGridView = Nothing
        Dim Pic As PictureBox = Nothing
        Dim TC As TabControl = Nothing
        Dim TP As TabPage = Nothing
        Dim Frm As Form = Nothing


        ' Loop on all the controls in the container to change their colors
        If Container.tag = "Dark" Then
            Container.backcolor = Dark
        End If

        For Each C As Control In Container.Controls

            If TypeOf C Is Button Then '--------------------------- Button
                Btn = DirectCast(C, Button)
                ' Set an action for Mouse(Enter + Leave) event
                ' But make sure you don't want to give a diffrent color for mouse over and down
                If Btn.FlatAppearance.MouseDownBackColor <> Color.Transparent And Btn.FlatAppearance.MouseOverBackColor <> Color.Transparent Then
                    AddHandler Btn.MouseDown, AddressOf MouseOverORDownOnButton
                    AddHandler Btn.MouseEnter, AddressOf MouseOverORDownOnButton
                    AddHandler Btn.MouseLeave, AddressOf MouseLeave
                End If

                If Btn.Tag = "Dark" Then
                    Btn.BackColor = Dark
                    Btn.ForeColor = Color.White
                    Btn.FlatAppearance.MouseOverBackColor = Primary
                    Btn.FlatAppearance.MouseDownBackColor = Dark
                    Btn.Cursor = Cursors.Hand

                ElseIf Btn.Tag = "Primary" Then
                    Btn.BackColor = Primary
                    Btn.ForeColor = Color.White
                    Btn.FlatAppearance.MouseOverBackColor = Dark
                    Btn.FlatAppearance.MouseDownBackColor = Primary
                    Btn.Cursor = Cursors.Hand

                ElseIf Btn.Tag = "Light" Then
                    Btn.BackColor = Light
                    Btn.ForeColor = Color.Black
                    Btn.FlatAppearance.MouseOverBackColor = Primary
                    Btn.FlatAppearance.MouseDownBackColor = Light
                    Btn.Cursor = Cursors.Hand

                End If
            End If

            If TypeOf C Is Label Then '--------------------------- Label
                Lbl = DirectCast(C, Label)
                If Lbl.Tag = "Auto" Then
                    Lbl.BackColor = Color.FromArgb(247, 247, 247)
                ElseIf Lbl.Tag = "AutoC" Then
                    Lbl.BackColor = Color.FromArgb(247, 247, 247)
                ElseIf Lbl.Tag = "Dark" Then
                    Lbl.BackColor = Dark
                    Lbl.ForeColor = Color.White
                ElseIf Lbl.Tag = "Primary" Then
                    Lbl.BackColor = Primary
                    Lbl.ForeColor = Color.White
                ElseIf Lbl.Tag = "Light" Then
                    Lbl.BackColor = Light
                    Lbl.ForeColor = Color.Black
                End If
            End If

            If TypeOf C Is Panel Then '--------------------------- Panel
                Pnl = DirectCast(C, Panel)
                If Val(Pnl.Tag) = 0 Then
                    If Pnl.Tag = "Dark" Then
                        Pnl.BackColor = Dark
                    ElseIf Pnl.Tag = "Primary" Then
                        Pnl.BackColor = Primary
                    ElseIf Pnl.Tag = "Light" Then
                        Pnl.BackColor = Light
                    ElseIf Pnl.Tag = "Background" Then
                        Pnl.BackColor = SystemColors.Control
                    End If
                    If Pnl.Controls.Count > 0 Then ChangeSystemColors(Pnl)
                End If

            End If

            If TypeOf C Is TableLayoutPanel Then '--------------------------- TableLayoutPanel
                TLP = DirectCast(C, TableLayoutPanel)
                If TLP.Tag = "Dark" Then
                    TLP.BackColor = Dark
                ElseIf TLP.Tag = "Primary" Then
                    TLP.BackColor = Primary
                ElseIf TLP.Tag = "Light" Then
                    TLP.BackColor = Light
                End If
                If TLP.Controls.Count > 0 Then ChangeSystemColors(TLP)
            End If

            If TypeOf C Is SplitContainer Then '--------------------------- SplitContainer
                SC = DirectCast(C, SplitContainer)
                If SC.Tag = "Dark" Then
                    SC.BackColor = Dark
                ElseIf SC.Tag = "Primary" Then
                    SC.BackColor = Primary
                ElseIf SC.Tag = "Light" Then
                    SC.BackColor = Light
                End If
                If SC.Controls.Count > 0 Then ChangeSystemColors(SC)
            End If

            If TypeOf C Is GroupBox Then '--------------------------- GroupBox
                Grp = DirectCast(C, GroupBox)
                If Grp.Tag = "Dark" Then
                    Grp.BackColor = Dark
                ElseIf Grp.Tag = "Primary" Then
                    Grp.BackColor = Primary
                ElseIf Grp.Tag = "Light" Then
                    Grp.BackColor = Light
                Else
                    Grp.BackColor = SystemColors.Control
                End If
                If Grp.Controls.Count > 0 Then ChangeSystemColors(Grp)
            End If

            If TypeOf C Is StatusStrip Then '--------------------------- StatusStrip
                SS = DirectCast(C, StatusStrip)
                If SS.Tag = "Dark" Then
                    SS.BackColor = Dark
                ElseIf SS.Tag = "Primary" Then
                    SS.BackColor = Primary
                ElseIf SS.Tag = "Light" Then
                    SS.BackColor = Light
                End If
                If SS.Controls.Count > 0 Then ChangeSystemColors(SS)
            End If

            If TypeOf C Is TabControl Then '--------------------------- TabControl
                TC = DirectCast(C, TabControl)
                If TC.Tag = "Dark" Then
                    TC.BackColor = Dark
                ElseIf TC.Tag = "Primary" Then
                    TC.BackColor = Primary
                ElseIf TC.Tag = "Light" Then
                    TC.BackColor = Light
                End If
                If TC.Controls.Count > 0 Then ChangeSystemColors(TC)
            End If

            If TypeOf C Is TabPage Then '--------------------------- TabPage
                TP = DirectCast(C, TabPage)
                If TP.Tag = "Dark" Then
                    TP.BackColor = Dark
                ElseIf TP.Tag = "Primary" Then
                    TP.BackColor = Primary
                ElseIf TP.Tag = "Light" Then
                    TP.BackColor = Light
                End If
                If TP.Controls.Count > 0 Then ChangeSystemColors(TP)
            End If

            'If TypeOf C Is Form Then '--------------------------- Form
            '    Frm = DirectCast(C, Form)
            '    If Frm.Tag.ToString = "Dark" Then
            '        Frm.BackColor = Dark
            '    ElseIf Frm.Tag.ToString = "Primary" Then
            '        Frm.BackColor = Primary
            '    ElseIf Frm.Tag.ToString = "Light" Then
            '        Frm.BackColor = Light
            '    End If
            '    If Frm.Controls.Count > 0 Then ChangeSystemColors(Frm)
            'End If


            'If TypeOf C Is GroupBox Then '--------------------------- GroupBox
            '    Grp = DirectCast(C, GroupBox)
            '    Grp.BackColor = SystemColors.Control
            'End If


            If TypeOf C Is DataGridView Then '--------------------------- DataGridView
                DGV = DirectCast(C, DataGridView)

                ' Common Settings
                If Not IsNothing(DGV.Tag) Then
                    If DGV.Tag.ToString.Length > 0 Then
                        DGV.EnableHeadersVisualStyles = False
                        DGV.RowTemplate.Height = 30
                        DGV.RowTemplate.DividerHeight = 2
                        DGV.DefaultCellStyle.Font = New Font("Droid Arabic Kufi", 10.8)
                        DGV.ScrollBars = ScrollBars.Both
                        DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                    End If
                End If


                If DGV.Tag = "Dark-SelectionVisible" Then
                    DGV.DefaultCellStyle.BackColor = Color.White
                    DGV.DefaultCellStyle.ForeColor = Color.Black
                    DGV.DefaultCellStyle.SelectionBackColor = Light
                    DGV.DefaultCellStyle.SelectionForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.BackColor = Dark
                    DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Dark
                    DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
                    DGV.GridColor = SystemColors.ControlDark
                    DGV.BackgroundColor = Color.White
                    Dim BCol As DataGridViewButtonColumn = Nothing
                    For Each Col In DGV.Columns
                        If TypeOf Col Is DataGridViewButtonColumn Then
                            BCol = DirectCast(Col, DataGridViewButtonColumn)
                            BCol.FlatStyle = FlatStyle.Flat
                            BCol.DefaultCellStyle.BackColor = Primary
                            BCol.DefaultCellStyle.SelectionBackColor = Primary
                            BCol.DefaultCellStyle.ForeColor = Color.White
                            BCol.DefaultCellStyle.SelectionForeColor = Color.White
                        End If
                    Next
                ElseIf DGV.Tag = "Primary-SelectionVisible" Then
                    DGV.DefaultCellStyle.BackColor = Color.White
                    DGV.DefaultCellStyle.ForeColor = Color.Black
                    DGV.DefaultCellStyle.SelectionBackColor = Light
                    DGV.DefaultCellStyle.SelectionForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.BackColor = Primary
                    DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Primary
                    DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
                    DGV.GridColor = SystemColors.ControlDark
                    DGV.BackgroundColor = Color.White
                    Dim BCol As DataGridViewButtonColumn = Nothing
                    For Each Col In DGV.Columns
                        If TypeOf Col Is DataGridViewButtonColumn Then
                            BCol = DirectCast(Col, DataGridViewButtonColumn)
                            BCol.FlatStyle = FlatStyle.Flat
                            BCol.DefaultCellStyle.BackColor = Dark
                            BCol.DefaultCellStyle.SelectionBackColor = Dark
                            BCol.DefaultCellStyle.ForeColor = Color.White
                            BCol.DefaultCellStyle.SelectionForeColor = Color.White
                            BCol.HeaderCell.Style.BackColor = Color.White
                            BCol.HeaderCell.Style.SelectionBackColor = Color.White
                        End If
                    Next
                ElseIf DGV.Tag = "Light-SelectionVisible" Then
                    DGV.DefaultCellStyle.BackColor = Color.White
                    DGV.DefaultCellStyle.ForeColor = Color.Black
                    DGV.DefaultCellStyle.SelectionBackColor = Primary
                    DGV.DefaultCellStyle.SelectionForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.BackColor = Light
                    DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Light
                    DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
                    DGV.GridColor = SystemColors.ControlDark
                    DGV.BackgroundColor = Color.White
                    Dim BCol As DataGridViewButtonColumn = Nothing
                    For Each Col In DGV.Columns
                        If TypeOf Col Is DataGridViewButtonColumn Then
                            BCol = DirectCast(Col, DataGridViewButtonColumn)
                            BCol.FlatStyle = FlatStyle.Flat
                            BCol.DefaultCellStyle.BackColor = Dark
                            BCol.DefaultCellStyle.SelectionBackColor = Dark
                            BCol.DefaultCellStyle.ForeColor = Color.White
                            BCol.DefaultCellStyle.SelectionForeColor = Color.White
                            BCol.HeaderCell.Style.BackColor = Color.White
                            BCol.HeaderCell.Style.SelectionBackColor = Color.White
                        End If
                    Next
                ElseIf DGV.Tag = "Dark-SelectionNotVisible" Then
                    DGV.DefaultCellStyle.BackColor = Color.White
                    DGV.DefaultCellStyle.ForeColor = Color.Black
                    DGV.DefaultCellStyle.SelectionBackColor = Color.Transparent
                    DGV.DefaultCellStyle.SelectionForeColor = Color.Transparent
                    DGV.ColumnHeadersDefaultCellStyle.BackColor = Dark
                    DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Dark
                    DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
                    DGV.GridColor = Light
                    DGV.BackgroundColor = Color.White
                ElseIf DGV.Tag = "Primary-SelectionNotVisible" Then
                    DGV.DefaultCellStyle.BackColor = Color.White
                    DGV.DefaultCellStyle.ForeColor = Color.Black
                    DGV.DefaultCellStyle.SelectionBackColor = Color.Transparent
                    DGV.DefaultCellStyle.SelectionForeColor = Color.Transparent
                    DGV.ColumnHeadersDefaultCellStyle.BackColor = Primary
                    DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Primary
                    DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
                    DGV.GridColor = Light
                    DGV.BackgroundColor = Color.White
                ElseIf DGV.Tag = "Light-SelectionNotVisible" Then
                    DGV.DefaultCellStyle.BackColor = Color.White
                    DGV.DefaultCellStyle.ForeColor = Color.Black
                    DGV.DefaultCellStyle.SelectionBackColor = Color.Transparent
                    DGV.DefaultCellStyle.SelectionForeColor = Color.Transparent
                    DGV.ColumnHeadersDefaultCellStyle.BackColor = Light
                    DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Light
                    DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
                    DGV.GridColor = Primary
                    DGV.BackgroundColor = Color.White
                ElseIf DGV.Tag = "Dark-Card" Then
                    DGV.DefaultCellStyle.BackColor = Dark
                    DGV.DefaultCellStyle.ForeColor = Color.White
                    DGV.DefaultCellStyle.SelectionBackColor = Dark
                    DGV.DefaultCellStyle.SelectionForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.BackColor = Dark
                    DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Dark
                    DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
                    DGV.BackgroundColor = Dark
                    DGV.GridColor = Color.White
                ElseIf DGV.Tag = "Primary-Card" Then
                    DGV.DefaultCellStyle.BackColor = Primary
                    DGV.DefaultCellStyle.ForeColor = Color.White
                    DGV.DefaultCellStyle.SelectionBackColor = Primary
                    DGV.DefaultCellStyle.SelectionForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.BackColor = Primary
                    DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Primary
                    DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
                    DGV.BackgroundColor = Primary
                    DGV.GridColor = Color.White
                ElseIf DGV.Tag = "Light-Card" Then
                    DGV.DefaultCellStyle.BackColor = Light
                    DGV.DefaultCellStyle.ForeColor = Color.Black
                    DGV.DefaultCellStyle.SelectionBackColor = Light
                    DGV.DefaultCellStyle.SelectionForeColor = Color.Black
                    DGV.ColumnHeadersDefaultCellStyle.BackColor = Light
                    DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
                    DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Light
                    DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black
                    DGV.BackgroundColor = Light
                    DGV.GridColor = Color.White
                End If
            End If

            If TypeOf C Is PictureBox Then '--------------------------- PictureBox
                Pic = DirectCast(C, PictureBox)
                If Pic.Tag = "Dark" Then
                    Pic.BackColor = Dark
                ElseIf Pic.Tag = "Primary" Then
                    Pic.BackColor = Primary
                ElseIf Pic.Tag = "Light" Then
                    Pic.BackColor = Light
                End If
            End If
        Next
        ' Note: DGV option NotVisible the label row backcolor is the save DGV.GridColor
        ' you change the grid to any color and the label row will change with it

    End Sub

    Private Sub MouseOverORDownOnButton(sender As Button, e As EventArgs)

        If sender.Tag = "Dark" Then
            sender.ForeColor = Color.White
        ElseIf sender.Tag = "Primary" Then
            sender.ForeColor = Color.White
        ElseIf sender.Tag = "Light" Then
            sender.ForeColor = Color.White
        End If

    End Sub

    Private Sub MouseLeave(sender As Button, e As EventArgs)

        If sender.Tag = "Dark" Then
            sender.ForeColor = Color.White
        ElseIf sender.Tag = "Primary" Then
            sender.ForeColor = Color.White
        ElseIf sender.Tag = "Light" Then
            sender.ForeColor = Color.Black
        End If

    End Sub

    ' Set StatusStrip BackColor to default after MsgTool disappear
    Public Sub ResetStatusStripBackColor(SS As StatusStrip)

        ' Get colors
        Dim Dark As Color = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Dim Primary As Color = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
        Dim Light As Color = Settings.GetSettings(ClassSettings.Setting.ColorLight)

        ' Change color
        If SS.Tag = "Dark" Then
            SS.BackColor = Dark
        ElseIf SS.Tag = "Primary" Then
            SS.BackColor = Primary
        ElseIf SS.Tag = "Light" Then
            SS.BackColor = Light
        End If

    End Sub

    ' choose a good ForeColor for a label row
    Public Function GetDGVLabelRowForeColor(DGVTag As String) As Color

        ' Note: for now this function is useless maybe it will be important in the future

        ' Get colors
        Dim Dark As Color = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Dim Primary As Color = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
        Dim Light As Color = Settings.GetSettings(ClassSettings.Setting.ColorLight)

        If DGVTag = "Dark-SelectionNotVisible" Then
            Return Color.White
        ElseIf DGVTag = "Primary-SelectionNotVisible" Then
            Return Color.White
        ElseIf DGVTag = "Light-SelectionNotVisible" Then
            Return Color.White
        End If

    End Function

End Module
