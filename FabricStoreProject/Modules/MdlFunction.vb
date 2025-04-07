Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.ConstrainedExecution
Imports System.Runtime.Remoting.Messaging
Imports System.Runtime.Serialization.Formatters
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports AForge.Video
Imports ZXing

Module MdlFunction

    Public Enum MouseEvent

        Down
        Up
        Move

    End Enum

    Public Enum DTFormat ' DateTimeFormat
        DTF ' DateTimeFormat
        DF ' DateFormat
        TF ' TimeFormat
    End Enum

    Enum MessageStyle 'For Function (MA_MsgBox)
        Info
    End Enum

    Public Sub SetPermission()

        Dim DSUserPermission As DataSet
        Dim SQLCon = New SQLConClass
        SQLQuery = "SELECT * FROM PermissionTable WHERE UserID=" & UserID & " AND OperationID IN (SELECT ID FROM OperationTable)"
        DSUserPermission = SQLCon.SelectData(SQLQuery, 0, Nothing)
        DTUserPermission = DSUserPermission.Tables(0).Copy

    End Sub

    Public Sub SetPermissionProg()

        Dim DSUserPermission As DataSet
        Dim SQLCon = New SQLConClass
        SQLQuery = "SELECT * FROM PermissionTable WHERE UserID=1 AND OperationID IN (SELECT ID FROM OperationTable )"
        DSUserPermission = SQLCon.SelectData(SQLQuery, 0, Nothing)
        DTUserPermission = DSUserPermission.Tables(0).Copy

    End Sub

    Public Sub MsgTool(MSG As String, Style As Boolean)
        If Style = True Then
            Frmmain.StatusStrip1.BackColor = Color.FromArgb(72, 210, 117)
        ElseIf Style = 0 Then
            Frmmain.StatusStrip1.BackColor = Color.FromArgb(255, 128, 128)
        End If

        Frmmain.SSLMessage.Margin = New Padding(((Frmmain.Width - Frmmain.SSLMessage.Width) / 2), 3, 0, 2)
        Frmmain.SSLMessage.Visible = True
        Frmmain.TSLDateTime.Visible = False
        Frmmain.TSLUserName.Visible = False
        Frmmain.SSLMessage.Text = MSG

        Frmmain.Timer1.Tag = 1

    End Sub

    Public Sub OpenFile(FileName As String, Extension As String, FileData As Byte())

        Try
            Dim FullName As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\DentalSystemTempFile_" & FileName & Extension
            File.WriteAllBytes(FullName, FileData)
            Process.Start(FullName)
        Catch ex As Exception
            MsgTool("لا يمكن عرض الملف ، البرنامج المشغل للملف غير متوفر في جهازك", 1)
        End Try

    End Sub

    '----------------------------For Panel-------------------------------------------------------

    Public Sub HideFormsPnl(Pnl As Panel, LstDontClose() As String)

        If Not IsNothing(Pnl) Then
            For Each P As Object In Pnl.Controls
                If TypeOf P Is Panel And P.BackColor = Color.White Then P.BackColor = Color.Transparent
            Next
        End If

        Frmmain.Text = Title

        For Each FF As Form In Application.OpenForms
            If Not IsIn(FF.Name, LstDontClose) Then FF.Visible = False
        Next

    End Sub

    Public Sub OpenFormPnl(F As Form, PnlMain As Panel, Optional P As Panel = Nothing)

        If F.Visible Then Exit Sub  ' إختبار إذا كان الفورم مفتوح
        F.TopLevel = False
        F.Parent = PnlMain
        F.BringToFront()
        F.Visible = True
        F.Size = PnlMain.Size
        F.Dock = DockStyle.Fill
        Frmmain.Text = Title & " - " & F.Text
        If IsNothing(P) Then Exit Sub
        P.BackColor = Color.White

    End Sub

    '------------------------------------------------------------------------------------------------

    Public Sub HideFormsBtn(Container As Object, DontClose() As String)

        ' Get colors
        Dim Dark As Color = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Dim Primary As Color = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
        Dim Light As Color = Settings.GetSettings(ClassSettings.Setting.ColorLight)


        Dim Pnl As Panel = Nothing
        Dim BB As Button = Nothing
        '----------------------------------------------------------- Controls

        Dim Str = DontClose
        For Each C As Control In Container.Controls

            If TypeOf C Is Panel Then
                Pnl = DirectCast(C, Panel)
                HideFormsBtn(Pnl, Str)
            End If

            'If Not IsNothing(Pnl) Then

            If TypeOf C Is Button Then
                BB = DirectCast(C, Button)


                If BB.Tag = "Dark" Then
                    BB.BackColor = Dark
                    BB.ForeColor = Color.White
                ElseIf BB.Tag = "Primary" Then
                    BB.BackColor = Primary
                    BB.ForeColor = Color.White
                ElseIf BB.Tag = "Light" Then
                    BB.BackColor = Light
                    BB.ForeColor = Color.Black
                End If
                BB.Font = New Font("Droid Arabic Kufi", 11, FontStyle.Regular)
            End If


        Next

        Frmmain.Text = Title

        For Each FF As Form In Application.OpenForms
            If Not IsIn(FF.Name, DontClose) Then FF.Visible = False
        Next

    End Sub

    Public Sub OpenFormBtn(F As Form, PnlMain As Panel, Optional B As Button = Nothing)

        ' Get colors
        Dim Dark As Color = Settings.GetSettings(ClassSettings.Setting.ColorDark)
        Dim Primary As Color = Settings.GetSettings(ClassSettings.Setting.ColorPrimary)
        Dim Light As Color = Settings.GetSettings(ClassSettings.Setting.ColorLight)

        If F.Visible Then Exit Sub  ' إختبار إذا كان الفورم مفتوح
        F.TopLevel = False
        F.Parent = PnlMain
        F.BringToFront()
        F.Visible = True
        F.Size = PnlMain.Size
        F.Dock = DockStyle.Fill
        Frmmain.Text = F.Text


        If IsNothing(B) Then Exit Sub
        If B.Tag = "Dark" Then
            B.BackColor = Primary
            B.ForeColor = Color.White
        ElseIf B.Tag = "Primary" Then
            B.BackColor = Dark
            B.ForeColor = Color.White
        ElseIf B.Tag = "Light" Then
            B.BackColor = Primary
            B.ForeColor = Color.White
        End If

        B.Font = New Font("Droid Arabic Kufi", 11, FontStyle.Regular)



    End Sub


    Public Function CheckDGVError(DGV As DataGridView) As Boolean

        Try
            If IsNothing(DGV.CurrentRow) Then
                Return True
            End If
            If DGV.CurrentRow.Index = DGV.Rows.Count Or
               DGV.Item(0, 0).Value = Nothing Or
               DGV.Item(0, DGV.CurrentRow.Index).Value.ToString = vbNullString Or
               DGV.Rows(DGV.CurrentRow.Index).Selected = False Then
                Return True
            End If
        Catch
            Return True
        End Try
        Return False

    End Function

    Public Function IsBinaryDataPicture(Data As Byte()) As Boolean

        Dim PBX As New PictureBox
        Try

            If Data.Length > 0 Then ' Extra code
                Dim MS As New MemoryStream(Data)
                PBX.Image = Image.FromStream(MS)
                Return (True)
            Else
                Return (False)
            End If

        Catch ex As Exception
            Return (False)
        End Try

    End Function

    Public Sub MoveObject(e As MouseEventArgs, M As MouseEvent, Cntrl As Object)

        If e.Button = MouseButtons.Left And M = MouseEvent.Up Then
            SW = False
        ElseIf e.Button = MouseButtons.Left And M = MouseEvent.Down Then
            SW = True
            Pos = e.Location

        Else
            If SW = True Then
                Cntrl.Location = Cntrl.Location + (e.Location - Pos)
                If TypeOf Cntrl Is Form Then If Cntrl.WindowState = FormWindowState.Maximized Then Cntrl.WindowState = FormWindowState.Normal
            End If
        End If

    End Sub

    Public Function GetDateAndTimeFormat(Type As DTFormat) As String

        Dim DateTimeFormat As String

        Select Case Type
            Case DTFormat.DTF
                Dim DateFormat As String = Settings.GetSettings(ClassSettings.Setting.DateFormat)
                Dim TimeFormat As String = Settings.GetSettings(ClassSettings.Setting.TimeFormat)
                DateTimeFormat = DateFormat + " " + TimeFormat
            Case DTFormat.DF
                DateTimeFormat = Settings.GetSettings(ClassSettings.Setting.DateFormat)
            Case DTFormat.TF
                DateTimeFormat = Settings.GetSettings(ClassSettings.Setting.TimeFormat)
        End Select

        Return DateTimeFormat

    End Function

    Public Sub TxtTipClick(Grp As GroupBox, Sender As Object, Form As Form)

        If Not IsNothing(Grp) Then
            For Each C As Control In Grp.Controls
                If (TypeOf C Is TextBox Or TypeOf C Is ComboBox) And Sender.Name.Substring(0, Sender.Name.Length - 1) = C.Name Then
                    C.Focus()
                End If
            Next
        Else
            For Each C As Control In Form.Controls
                If (TypeOf C Is TextBox Or TypeOf C Is ComboBox) And Sender.Name.Substring(0, Sender.Name.Length - 1) = C.Name Then
                    C.Focus()
                End If
            Next
        End If

    End Sub

    Public Function IsPhone(Txt As String, Number As KeyPressEventArgs) As Boolean

        If Number.KeyChar = vbBack Then Return True
        If Not Char.IsNumber(Number.KeyChar) Then Return False
        If Asc(Number.KeyChar) = Keys.Space Then Return False
        If Not Txt.Length < 10 Then Return False

        Select Case Txt.Length

            Case 0
                If Number.KeyChar <> "0" Then Return False

            Case 1
                If Number.KeyChar <> "9" Then Return False

        End Select
        Return True

    End Function

    Public Function IsNumber(Txt As String, KeyChar As Char, Optional Plus As Boolean = False, Optional Dot As Boolean = False) As Boolean

        ' يسمح بطباعة الحرف + إذا كان لحقل الهاتف
        If Char.IsNumber(KeyChar) Or Asc(KeyChar) = Keys.Back Then Return True
        If Not Txt.Contains("+") And Plus And Asc(KeyChar) = 43 Then Return True
        If Txt.Length > 0 And Not Txt.Contains(".") And Dot And Asc(KeyChar) = 46 Then Return True
        Return False

    End Function

    Public Function IsNumberOnly(Txt As String, KeyChar As Char, Optional Plus As Boolean = False, Optional Dot As Boolean = False) As Boolean
        If Char.IsNumber(KeyChar) Or Asc(KeyChar) = Keys.Back Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function LetterOnly(KeyChar) As Boolean

        If Char.IsLetter(KeyChar) Or Asc(KeyChar) = Keys.Back Or Asc(KeyChar) = Keys.Space Then Return True
        Return False

    End Function

    Public Function LetterNumberSymbol(KeyChar) As Boolean

        If Char.IsLetter(KeyChar) Or Asc(KeyChar) = Keys.Back Or Char.IsNumber(KeyChar) Or Asc(KeyChar) = Keys.Delete Or Asc(KeyChar) = Keys.Space Then
            Return True

        ElseIf Asc(KeyChar) = 47 Or Asc(KeyChar) = 95 Or Asc(KeyChar) = 45 Or Asc(KeyChar) = 64 Then '    / 47  _ 95  -45  @64
            Return True
        End If
        Return False

    End Function

    Public Function Price(Txt As String, KeyChar As Char, Optional Plus As Boolean = False, Optional Dot As Boolean = False) As Boolean
        If Char.IsNumber(KeyChar) Or Asc(KeyChar) = Keys.Back Then Return True
        If Txt.Length > 0 And Not Txt.Contains(".") And Dot And Asc(KeyChar) = 46 Then Return True
        Return False
    End Function

    Public Function TeethCounter(TLP As TableLayoutPanel) As Integer

        Dim Chk As CheckBox = Nothing
        Dim Count As Integer = 0

        For Each C As Control In TLP.Controls

            If TypeOf C Is CheckBox Then
                Chk = DirectCast(C, CheckBox)
                If Chk.Checked = True Then
                    Count += 1
                End If
            End If
            ' End If
        Next
        Return Count 
    End Function

    Public Function IsInputEmpty(Container As Object) As Boolean
        Dim Clr As Color = RedColor ' Color.FromArgb(244, 206, 193)
        Dim AutoClr As Color = RedColor ' Color.FromArgb(244, 206, 193)


        '----------------------------------------------------------- Containers
        Dim TLP As TableLayoutPanel = Nothing
        Dim SC As SplitContainer = Nothing
        Dim Grp As GroupBox = Nothing
        Dim Pnl As Panel = Nothing
        '----------------------------------------------------------- Controls
        Dim Cmb As ComboBox = Nothing
        Dim Txt As TextBox = Nothing
        Dim Lbl As Label = Nothing


        For Each C As Control In Container.Controls

            '----------------------------------------------------------- Containers
            If TypeOf C Is Panel Then
                Pnl = DirectCast(C, Panel)
                IsInputEmpty(Pnl)
            End If
            If TypeOf C Is GroupBox Then
                Grp = DirectCast(C, GroupBox)
                IsInputEmpty(Grp)
            End If
            If TypeOf C Is SplitContainer Then
                SC = DirectCast(C, SplitContainer)
                IsInputEmpty(SC)
            End If
            If TypeOf C Is TableLayoutPanel Then
                TLP = DirectCast(C, TableLayoutPanel)
                IsInputEmpty(TLP)
            End If

            '----------------------------------------------------------- Controls
            If TypeOf C Is TextBox Then
                Txt = DirectCast(C, TextBox)

                If Txt.Text.Trim = "" And Txt.Enabled And Val(Txt.Tag) = 0 Then
                    Txt.BackColor = Clr
                    IsDataMissing = True
                ElseIf Val(Txt.Tag) = 10 Then ' TxtPhone
                    If Txt.TextLength < 10 Then
                        Txt.BackColor = Clr
                        IsDataMissing = True
                    End If
                ElseIf Val(Txt.Tag) = 11 And Txt.TextLength > 0 And Txt.TextLength < 10 Then
                    Txt.BackColor = Clr
                    IsDataMissing = True

                ElseIf Val(Txt.Tag) = 5 And Val(Txt.Text) = 0 Then
                    Txt.BackColor = Clr
                    IsDataMissing = True
                End If

            End If

            If TypeOf C Is ComboBox Then
                Cmb = DirectCast(C, ComboBox)
                If Cmb.SelectedIndex = -1 And Cmb.Enabled And Val(Cmb.Tag) = 0 Then
                    Cmb.BackColor = Clr
                    IsDataMissing = True
                End If
            End If

            If TypeOf C Is Label Then
                Lbl = DirectCast(C, Label)
                If Lbl.Tag = "AutoC" And Lbl.Text = "" Then
                    Lbl.BackColor = AutoClr
                    IsDataMissing = True
                End If
            End If

        Next

    End Function

    Public Sub ChangeLanguage(Language As String)

        For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
            If Lng.Culture.DisplayName.ToUpper.StartsWith(Language) Then
                InputLanguage.CurrentInputLanguage = Lng
                Exit For
            End If
        Next

    End Sub

    Public Sub Clear(Container As Object)

        Dim CMB As ComboBox = Nothing
        Dim Pic As PictureBox = Nothing
        Dim Dtp As DateTimePicker = Nothing
        Dim Chk As CheckBox = Nothing
        Dim Lbl As Label = Nothing

        ' When C is a container of these the clear function will loop again but this time inside C
        Dim TLP As TableLayoutPanel = Nothing
        Dim SC As SplitContainer = Nothing
        Dim Grp As GroupBox = Nothing
        Dim Pnl As Panel = Nothing

        For Each C As Control In Container.Controls
            If Val(C.Tag) <> 1 Then '-------------------------------- Controls
                If TypeOf C Is TextBox Then
                    C.Text = vbNullString
                End If
                If TypeOf C Is ComboBox Then
                    CMB = DirectCast(C, ComboBox)
                    CMB.SelectedIndex = -1
                    CMB.Text = ""
                End If
                If TypeOf C Is PictureBox Then
                    Pic = DirectCast(C, PictureBox)
                    Pic.Image = Nothing
                End If
                If TypeOf C Is DateTimePicker Then
                    Dtp = DirectCast(C, DateTimePicker)
                    Dtp.Value = Now
                End If
                If TypeOf C Is CheckBox Then
                    Chk = DirectCast(C, CheckBox)
                    Chk.Checked = False
                End If
                If TypeOf C Is Label Then
                    If C.Tag = "AutoC" Then
                        Lbl = DirectCast(C, Label)
                        Lbl.Text = vbNullString
                    End If

                End If
            End If
            '--------------------------------------------------- Containers
            If TypeOf C Is Panel Then
                Pnl = DirectCast(C, Panel)
                Clear(Pnl)
            End If
            If TypeOf C Is GroupBox Then
                Grp = DirectCast(C, GroupBox)
                Clear(Grp)
            End If
            If TypeOf C Is SplitContainer Then
                SC = DirectCast(C, SplitContainer)
                Clear(SC)
            End If
            If TypeOf C Is TableLayoutPanel Then
                TLP = DirectCast(C, TableLayoutPanel)
                Clear(TLP)
            End If

        Next

    End Sub

    Public Sub SerialNum(DGV As DataGridView)
        For i = 0 To DGV.Rows.Count - 1
            DGV.Item(1, i).Value = i + 1
        Next
    End Sub

    Public Function IsIn(Value As Integer, Param() As Integer) As Boolean

        For Each P In Param
            If Value = P Then Return True
        Next

        Return False

    End Function

    Public Function IsIn(Value As String, Param() As String) As Boolean

        For Each P In Param
            If Value = P Then Return True
        Next

        Return False

    End Function

    Public Function DSHasTables(DS As DataSet, Count As Integer) As Boolean

        If IsNothing(DS) Then Return False
        If DS.Tables.Count = Count Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function DSHasTables(DS As DataSet)

        If IsNothing(DS) Then Return False
        If DS.Tables.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ImageToByte(Pic As PictureBox) As Byte()

        Dim MS As New MemoryStream
        If Not IsNothing(Pic.Image) Then Pic.Image.Save(MS, ImageFormat.Png)
        Return MS.ToArray()

    End Function

    Sub DTDefaultView(Text As String, ByRef DT As DataTable, Column As String)

        Try
            DT.DefaultView.RowFilter = Column & " Like '%" & Text.Trim & "%'"
        Catch ex As Exception
        End Try

    End Sub

    Public Function ByteToImage(Img As Byte()) As Image

        If Img.Length > 0 Then ' Extra code
            Dim MS As New MemoryStream(Img)
            Return Image.FromStream(MS)
        Else
            Return Nothing
        End If

    End Function

    Public Function DShasTablesAndData(DS As DataSet) As Boolean

        If IsNothing(DS) Then Return False
        If DS.Tables.Count > 0 Then
            For Each DT As DataTable In DS.Tables
                If (DT.Rows.Count = 0) Then Return False
            Next
        Else
            Return False
        End If
        Return True

    End Function

    Public Function CheckEmptyInput(G As Object)

        Dim Cmb As ComboBox = Nothing
        For Each C As Control In G.Controls
            If TypeOf C Is TextBox Then
                If C.Text = "" And Val(C.Tag) <> 1 Then
                    Return True
                End If
            End If

            If TypeOf C Is ComboBox Then
                Cmb = DirectCast(C, ComboBox)
                If Cmb.SelectedIndex = -1 And Val(Cmb.Tag) <> 1 Then
                    Return True
                End If
            End If
            Dim Pnl As Panel = Nothing
            For Each P As Control In G.Controls
                If TypeOf C Is TextBox Then
                    If P.Text = "" And Val(P.Tag) <> 1 Then
                        Return True
                    End If

                End If

            Next
        Next
        Return False

    End Function

    Public Sub ClearP(G As Panel)
        Dim Cmb As ComboBox = Nothing
        Dim P As PictureBox = Nothing
        Dim Chk As CheckBox = Nothing
        For Each C As Control In G.Controls
            If TypeOf C Is TextBox Then
                C.Text = ""
            End If

            If TypeOf C Is ComboBox Then
                If C.Tag <> 1 Then
                    Cmb = DirectCast(C, ComboBox)
                    Cmb.SelectedIndex = -1
                End If

            End If

            If TypeOf C Is PictureBox Then
                P = DirectCast(C, PictureBox)
                P.Image = Nothing
            End If

            If TypeOf C Is CheckBox Then
                Chk = DirectCast(C, CheckBox)
                Chk.Checked = False
            End If
        Next


    End Sub

    Public Sub ChangeControlColor(Container As Object)

        ' Containers
        Dim Pnl As Panel = Nothing
        Dim TLP As TableLayoutPanel = Nothing
        Dim SC As SplitContainer = Nothing
        Dim Grp As GroupBox = Nothing
        Dim Clr As Color = SystemColors.Window
        Dim AutoClr As Color = Color.FromArgb(247, 247, 247)
        ' Controls
        ' Controls
        Dim Txt As TextBox = Nothing
        Dim Cmb As ComboBox = Nothing
        Dim Lst As ListBox = Nothing
        Dim Lbl As Label = Nothing
        For Each C As Control In Container.Controls

            '----------------------------------------------- Containers
            If TypeOf C Is TableLayoutPanel Then
                TLP = DirectCast(C, TableLayoutPanel)
                ChangeControlColor(TLP)
            End If

            If TypeOf C Is Panel Then
                Pnl = DirectCast(C, Panel)
                ChangeControlColor(Pnl)
            End If

            If TypeOf C Is SplitContainer Then
                SC = DirectCast(C, SplitContainer)
                ChangeControlColor(SC)
            End If

            If TypeOf C Is GroupBox Then
                Grp = DirectCast(C, GroupBox)
                ChangeControlColor(Grp)
            End If

            '----------------------------------------------- Controls
            If TypeOf C Is TextBox Then
                Txt = DirectCast(C, TextBox)
                Txt.BackColor = Clr
            End If

            If TypeOf C Is ComboBox Then
                Cmb = DirectCast(C, ComboBox)
                Cmb.BackColor = Clr
            End If

            If TypeOf C Is ListBox Then
                Lst = DirectCast(C, ListBox)
                Lst.BackColor = Clr
            End If

            If TypeOf C Is Label Then
                If C.Tag = "AutoC" Or C.Tag = "Auto" Then
                    Lbl = DirectCast(C, Label)
                    Lbl.BackColor = AutoClr
                End If
            End If
        Next

    End Sub



End Module
