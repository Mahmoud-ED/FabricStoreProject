Imports System.Data.SqlClient
Public Class SQLConClass

    Private con As SqlConnection

    Private ServerName, SQLUser, SQLPass, DataBase

    ' ملاحظة الكلاس لن يعرض رسائل بنجاح أو فشل العمليات يجب عرضها يدويا

    Public Sub New()
        GetConnectionSettings()
        con = New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & DataBase & ";Integrated Security=False;User ID=" & SQLUser & ";Password=" & SQLPass & ";")
    End Sub

    Private Sub GetConnectionSettings()

        ServerName = Settings.GetSettings(ClassSettings.Setting.Server)
        SQLUser = Settings.GetSettings(ClassSettings.Setting.SQLLogin)
        SQLPass = Settings.GetSettings(ClassSettings.Setting.SQLPassword)
        DataBase = Settings.GetSettings(ClassSettings.Setting.Database)

    End Sub

    Public Function SelectData(Command As String, Optional Type As Integer = 0, Optional Parameters() As SqlParameter = Nothing) As DataSet

        Dim DA As SqlDataAdapter
        Dim DS As New DataSet
        Dim CMD = New SqlCommand(Command, con)
        If Not IsNothing(Parameters) Then CMD.Parameters.AddRange(Parameters)
        If Type = 1 Then CMD.CommandType = CommandType.StoredProcedure
        Try
            con.Open()
            DA = New SqlDataAdapter(CMD)
            DA.Fill(DS)
            con.Close()
        Catch ex As Exception
            Dim ConTest As SqlConnection = New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=master;Integrated Security=False;User ID=" & SQLUser & ";Password=" & SQLPass & ";")
            Dim DA2 As SqlDataAdapter
            Dim DtTestCon As New DataTable

            Try
                SQLQuery2 = "SELECT * FROM sys.databases WHERE name = '" & DataBase & "'"
                DA2 = New SqlDataAdapter(SQLQuery2, ConTest)
                DA2.Fill(DtTestCon)
                If DtTestCon.Rows.Count = 0 Then
                    ConTest.Close()
                    MsgBox("فشل في الإتصال بقاعدة البيانات", MsgBoxStyle.Critical, "خطأ إتصال")
                Else
                    ConTest.Close()
                    MsgTool("خطأ في تنفيد العملية", 0)
                End If
            Catch ex2 As Exception
                ConTest.Close()
                MsgBox("فشل في الإتصال بقاعدة البيانات", MsgBoxStyle.Critical, "خطأ إتصال")
            End Try
            con.Close()
        End Try
        Return (DS)

    End Function

    Public Function CMDExecute(Command As String, Type As Integer, Optional Parameters() As SqlParameter = Nothing) As Integer

        Dim CMD As New SqlCommand(Command, con)
        Dim SaveState = -1, RowAffected = 0
        Save = -1
        If Not IsNothing(Parameters) Then
            For Each P As SqlParameter In Parameters
                If (P.SqlDbType = SqlDbType.VarBinary) And P.Size = 0 Then P.Value = DBNull.Value
            Next
            CMD.Parameters.AddRange(Parameters)
        End If
        If Type = 1 Then
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.Add("@SaveState", SqlDbType.Int).Direction = ParameterDirection.Output
        End If
        Try
            con.Open()
            RowAffected = CMD.ExecuteNonQuery
            con.Close()

            If Type = 1 Then
                SaveState = Val(CMD.Parameters("@SaveState").Value.ToString())
                Select Case SaveState
                    Case 1
                        MsgTool("تم الحفظ بنجاح", 1)
                    Case 2
                        MsgTool("لم يتم الحفظ ، تكرار في البيانات  ", 0)
                    Case 3
                        MsgTool("تم ارسال البيانات الى سلة المحذوفات ", 1)
                    Case 0
                        MsgTool("لم يتم الحفظ ، خطأ في تنفيذ العملية", 0)
                    Case 6
                        MsgTool("قيمة الايصال أكبر من القيمة في الخزينة", 0)
                End Select
            Else
                SaveState = RowAffected
                Select Case SaveState
                    Case > 0
                        MsgTool("تم الحفظ بنجاح", 1)
                    Case Else
                        MsgTool("لم يتم الحفظ ، تكرار في البيانات  ", 0)
                End Select
            End If
        Catch ex As Exception
            Dim ConTest As SqlConnection = New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=master;Integrated Security=False;User ID=" & SQLUser & ";Password=" & SQLPass & ";")
            Dim DA2 As SqlDataAdapter
            Dim DtTestCon As New DataTable

            Try
                SQLQuery2 = "SELECT * FROM sys.databases WHERE name = '" & DataBase & "'"
                DA2 = New SqlDataAdapter(SQLQuery2, ConTest)
                DA2.Fill(DtTestCon)
                If DtTestCon.Rows.Count = 0 Then
                    ConTest.Close()
                    MsgBox("فشل في الإتصال بقاعدة البيانات", MsgBoxStyle.Critical, "خطأ إتصال")
                Else
                    ConTest.Close()
                    MsgTool("خطأ في تنفيد العملية", 0)
                End If
            Catch ex2 As Exception
                ConTest.Close()
                MsgBox("فشل في الإتصال بقاعدة البيانات", MsgBoxStyle.Critical, "خطأ إتصال")
            End Try
            con.Close()
        End Try
        Return SaveState

    End Function

    Public Function CMDExecuteData(Command As String, Optional Parameter() As SqlParameter = Nothing) As DataSet

        Dim DA As SqlDataAdapter
        Dim DS As New DataSet
        Dim CMD = New SqlCommand(Command, con)
        Save = -1

        If Not IsNothing(Parameter) Then
            For Each P As SqlParameter In Parameter
                If P.SqlDbType = SqlDbType.VarBinary And P.Size = 0 Then P.Value = DBNull.Value
            Next
            CMD.Parameters.AddRange(Parameter)
        End If

        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add("@SaveState", SqlDbType.Int).Direction = ParameterDirection.Output

        Try
            con.Open()
            DA = New SqlDataAdapter(CMD)
            DA.Fill(DS)
            con.Close()
            Save = Val(CMD.Parameters("@SaveState").Value.ToString())
            Select Case Save
                Case 1
                    MsgTool("تم الحفظ بنجاح", 1)
                Case 2
                    MsgTool("لم يتم الحفظ ، تكرار في البيانات  ", 0)
                Case 3
                    MsgTool("تم ارسال البيانات الى سلة المحذوفات ", 1)
                Case 0
                    MsgTool("لم يتم الحفظ ، خطأ في تنفيذ العملية", 0)
                    'Case 6
                    '    MsgTool("قيمة الايصال أكبر من القيمة في الخزينة", 0)
            End Select
        Catch ex As Exception
            con.Close()
            MsgBox("فشل الاتصال بقاعدة البيانات" & vbCrLf & ex.Message, vbCritical + vbMsgBoxRight, "خطأ اتصال")
            'Dim ConTest As SqlConnection = New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=master;Integrated Security=False;User ID=" & SQLUser & ";Password=" & SQLPass & ";")
            'Dim DA2 As SqlDataAdapter
            'Dim DtTestCon As New DataTable

            'Try
            '    SQLQuery2 = "SELECT * FROM sys.databases WHERE name = '" & DataBase & "'"
            '    DA2 = New SqlDataAdapter(SQLQuery2, ConTest)
            '    DA2.Fill(DtTestCon)
            '    If DtTestCon.Rows.Count = 0 Then
            '        ConTest.Close()
            '        MsgBox("فشل في الإتصال بقاعدة البيانات", MsgBoxStyle.Critical, "خطأ إتصال")
            '    Else
            '        ConTest.Close()
            '        MsgTool("خطأ في تنفيد العملية", 0)
            '    End If
            'Catch ex2 As Exception
            '    ConTest.Close()
            '    MsgBox("فشل في الإتصال بقاعدة البيانات", MsgBoxStyle.Critical, "خطأ إتصال")
            'End Try
            con.Close()
        End Try
        Return DS

    End Function

    Public Function TestLogIn(Command As String, Optional Type As Integer = 0, Optional Parameters() As SqlParameter = Nothing) As DataSet

        Dim DA As SqlDataAdapter
        Dim DS As New DataSet
        Dim CMD = New SqlCommand(Command, con)
        If Not IsNothing(Parameters) Then CMD.Parameters.AddRange(Parameters)
        If Type = 1 Then CMD.CommandType = CommandType.StoredProcedure
        Try
            con.Open()
            DA = New SqlDataAdapter(CMD)
            DA.Fill(DS)
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
        Return (DS)

    End Function
End Class
