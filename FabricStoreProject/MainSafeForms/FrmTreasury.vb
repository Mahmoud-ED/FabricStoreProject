
Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class FrmTreasury
    Private DsMain, DSSearch As DataSet
    Private PageSize, PagesCount, RowsCount As Integer
    Private PageNum As Integer = 1

    Private PageSize1, PagesCount1, RowsCount1 As Integer
    Private PageNum1 As Integer = 1

    Private PageSize2, PagesCount2, RowsCount2 As Integer
    Private PageNum2 As Integer = 1
    Private Enum Data
        Search
        Main
    End Enum

    Public Sub ChangeColor()
        ChangeSystemColors(Me)
    End Sub

    Private Sub FrmTreasury_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            CmbYear.Text = Now.Year
            CmbMonth.Text = Now.Month
            NUDPageSize.Value = My.Settings.SizeOfPage
            NUDPageSize1.Value = My.Settings.SizeOfPage
            NUDPageSize2.Value = My.Settings.SizeOfPage
            ChkDay.Checked = True
            CmbDay.Enabled = True
            CmbDay.Text = Now.Day
            PageNum = 1
            PageNum1 = 1
            PageNum2 = 1

            GetData(Data.Main)
            'TxtPagesCount.Text = 1
            'TxtPageCount1.Text = 1
            'TxtPageCount2.Text = 1

        End If

    End Sub

    Private Sub GetData(Type As Data)

        Dim SQLCon = New SQLConClass()
        'PageNum = 1
        'PageNum1 = 1
        TxtPageNum.Text = PageNum
        PageSize = My.Settings.SizeOfPage

        TxtPageNum1.Text = PageNum1
        PageSize1 = My.Settings.SizeOfPage


        TxtPageNum2.Text = PageNum2
        PageSize2 = My.Settings.SizeOfPage

        Select Case Type
            Case Data.Main

                SQLQuery = " SELECT ROW_NUMBER() OVER (ORDER BY (Date ) Desc)  As ت,* from TreasuryView "
                SQLQuery &= " where Year(Date)=Year(GetDate()) and Month(Date)=Month(GetDate()) and Day(Date)=Day(GetDate()) and PaymentType=1 "
                SQLQuery &= " ORDER BY TreasuryView.Date Desc OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY" '++


                SQLQuery &= " SELECT ISNULL(TotalValue,0),ISNULL(TotalValueCard,0) from TreasuryView where ID=(select Max(ID) from TreasuryView )  "

                SQLQuery &= " SELECT COUNT(ID) FROM TreasuryView  "
                SQLQuery &= " where Year(Date)=Year(GetDate()) and Month(Date)=Month(GetDate()) and PaymentType=1  "

                SQLQuery &= " SELECT ROW_NUMBER() OVER (ORDER BY (Date ) Desc)  As ت,* from TreasuryView "
                SQLQuery &= " where Year(Date)=Year(GetDate()) and Month(Date)=Month(GetDate()) and Day(Date)=Day(GetDate()) and PaymentType<>1 "
                SQLQuery &= " ORDER BY TreasuryView.Date Desc OFFSET " & PageSize1 * (PageNum1 - 1) & " ROWS FETCH NEXT " & PageSize1 & " ROWS ONLY"

                SQLQuery &= " SELECT COUNT(ID) FROM TreasuryView  "
                SQLQuery &= " where Year(Date)=Year(GetDate()) and Month(Date)=Month(GetDate()) and PaymentType<>1  "


                DsMain = SQLCon.SelectData(SQLQuery)
                'GetPagesCount()
                'GetPagesCount1()
                'GetPagesCount2()

                If DsMain.Tables(2).Rows.Count > 0 Then
                    RowsCount = DsMain.Tables(2).Rows(0).Item(0)
                End If
                GetPagesCount()
                FillData(Type, DsMain, 3)

                If DsMain.Tables(4).Rows.Count > 0 Then
                    RowsCount1 = DsMain.Tables(4).Rows(0).Item(0)
                End If
                GetPagesCount1()
                FillData1(Type, DsMain, 3)



            Case Data.Search

                'If PageNum = 0 Then
                '    PageNum = 1
                'End If
                SQLQuery = "SELECT ROW_NUMBER() OVER (ORDER BY (Date ) Desc)  As ت,* from TreasuryView   where PaymentType=1 "
                SQLQuery &= " and Year(Date)=" & CmbYear.Text & " and Month(Date)=" & CmbMonth.Text & "  "
                AppendConditions()
                SQLQuery &= " ORDER BY TreasuryView.Date Desc OFFSET " & PageSize * (PageNum - 1) & " ROWS FETCH NEXT " & PageSize & " ROWS ONLY"

                SQLQuery &= " SELECT isnull(TotalValue,0),ISNULL(TotalValueCard,0) from TreasuryView where  ID =(Select Max(ID) from TreasuryView) "


                SQLQuery &= " SELECT COUNT(ID) FROM TreasuryView  where PaymentType=1 "
                SQLQuery &= " and Year(Date)=" & CmbYear.Text & " and Month(Date)=" & CmbMonth.Text & "  "
                AppendConditions()


                SQLQuery &= " SELECT ROW_NUMBER() OVER (ORDER BY (Date ) Desc)  As ت,* from TreasuryView   where PaymentType<>1 "
                SQLQuery &= " and Year(Date)=" & CmbYear.Text & " and Month(Date)=" & CmbMonth.Text & "  "
                AppendConditions()
                SQLQuery &= " ORDER BY TreasuryView.Date Desc OFFSET " & PageSize1 * (PageNum1 - 1) & " ROWS FETCH NEXT " & PageSize1 & " ROWS ONLY"

                SQLQuery &= " SELECT COUNT(ID) FROM TreasuryView  where PaymentType<>1 "
                SQLQuery &= " and Year(Date)=" & CmbYear.Text & " and Month(Date)=" & CmbMonth.Text & "  "
                AppendConditions()




                DSSearch = SQLCon.SelectData(SQLQuery)
                'GetPagesCount()
                'GetPagesCount1()
                'GetPagesCount2()

                If DSSearch.Tables(2).Rows.Count > 0 Then
                    RowsCount = DSSearch.Tables(2).Rows(0).Item(0)
                End If
                GetPagesCount()
                FillData(Type, DSSearch, 2)

                If DSSearch.Tables(4).Rows.Count > 0 Then
                    RowsCount1 = DSSearch.Tables(4).Rows(0).Item(0)
                End If
                GetPagesCount1()
                FillData1(Type, DSSearch, 3)


                'GetPagesCount2()
                'FillData2(Type, DSSearch, 3)

        End Select
    End Sub

    Private Sub AppendConditions()
        If ChkDay.Checked And CmbDay.Text.Trim <> "" Then AppendToQuery(" AND ", " Day(Date)=" & CmbDay.Text)
    End Sub

    Private Sub AppendToQuery(Oprtr As String, Query As String)

        ' Check if last word in the query is "WHERE " with the space at the end
        ' If True and you want to add a condition no need to append " AND " or any operator
        ' But if was False this means this's not the first condition you add so you must add an operator too

        Dim TestString As String = StrReverse(SQLQuery)
        If StrReverse(TestString.Substring(0, 6).ToUpper) = "WHERE " Then
            SQLQuery &= Query
        Else
            SQLQuery &= Oprtr & " " & Query
        End If

    End Sub

    Private Sub FillData(Type As Data, DS As DataSet, TCount As Integer)

        'If DS.Tables(2).Rows.Count > 0 Then
        '    RowsCount = DS.Tables(2).Rows(0).Item(0)
        'End If

        DGV.Rows.Clear()

        For i = 0 To DS.Tables(0).Rows.Count - 1
            With DS.Tables(0).Rows(i)

                DGV.Rows.Add()
                DGV.Item(0, i).Value = .Item("ID")
                DGV.Item(1, i).Value = .Item("ت") 'i + 1
                DGV.Item(2, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DTF))
                DGV.Item(3, i).Value = Format(.Item("TotalValue"), "0.000")
                DGV.Item(4, i).Value = Format(.Item("Amont"), "0.000")
                If .Item("Type") = 0 Then
                    DGV.Item(5, i).Value = "سحب"
                ElseIf .Item("Type") = 1 Then
                    DGV.Item(5, i).Value = "ايداع"
                End If

                If .Item("Type") = 0 Then
                    DGV.Item(4, i).Style.BackColor = Color.LightSalmon
                    DGV.Item(4, i).Style.ForeColor = Color.White
                ElseIf .Item("Type") = 1 Then
                    DGV.Item(4, i).Style.BackColor = Color.LightGreen
                    DGV.Item(4, i).Style.ForeColor = Color.White
                End If
                DGV.Item(6, i).Value = .Item("FinaceName")
                If Not IsDBNull(.Item("T")) Then
                    DGV.Item(7, i).Value = .Item("T") + "-" + Format(.Item("NUM"), "0000").ToString
                Else
                    If Not IsDBNull(.Item("NUM")) Then
                        DGV.Item(7, i).Value = Format(.Item("NUM"), "000000")
                    Else
                        DGV.Item(7, i).Value = ""
                    End If
                End If
                DGV.Item(8, i).Value = .Item("ProcNum")
                DGV.Item(9, i).Value = .Item("UserName")
                DGV.Item(10, i).Value = .Item("PaymentName")

            End With
        Next
        DGV.ClearSelection()


        If DS.Tables(1).Rows.Count > 0 Then
            TxtValue.Text = Format(DS.Tables(1).Rows(0).Item(0), "0.000")
            TxtValueCard.Text = Format(DS.Tables(1).Rows(0).Item(1), "0.000")

        Else
            TxtValue.Text = "0.000"
            TxtValueCard.Text = "0.000"
        End If

    End Sub

    Private Sub FillData1(Type As Data, DS As DataSet, TCount As Integer)

        'If DS.Tables(4).Rows.Count > 0 Then
        '    RowsCount1 = DS.Tables(4).Rows(0).Item(0)
        'End If
        ' GetPagesCount1()

        DGVOther.Rows.Clear()

        For i = 0 To DS.Tables(3).Rows.Count - 1
            With DS.Tables(3).Rows(i)

                DGVOther.Rows.Add()
                DGVOther.Item(0, i).Value = .Item("ID")
                DGVOther.Item(1, i).Value = .Item("ت") 'i + 1
                DGVOther.Item(2, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DTF))
                DGVOther.Item(3, i).Value = Format(.Item("TotalValueCard"), "0.000")
                DGVOther.Item(4, i).Value = Format(.Item("Amont"), "0.000")
                If .Item("Type") = 0 Then
                    DGVOther.Item(5, i).Value = "سحب"
                ElseIf .Item("Type") = 1 Then
                    DGVOther.Item(5, i).Value = "ايداع"
                End If

                If .Item("Type") = 0 Then
                    DGVOther.Item(4, i).Style.BackColor = Color.LightSalmon
                    DGVOther.Item(4, i).Style.ForeColor = Color.White
                ElseIf .Item("Type") = 1 Then
                    DGVOther.Item(4, i).Style.BackColor = Color.LightGreen
                    DGVOther.Item(4, i).Style.ForeColor = Color.White
                End If
                DGVOther.Item(6, i).Value = .Item("FinaceName")
                If Not IsDBNull(.Item("T")) Then
                    DGVOther.Item(7, i).Value = .Item("T") + "-" + Format(.Item("NUM"), "0000").ToString
                Else
                    If Not IsDBNull(.Item("NUM")) Then
                        DGVOther.Item(7, i).Value = Format(.Item("NUM"), "000000")
                    Else
                        DGVOther.Item(7, i).Value = ""
                    End If
                End If
                DGVOther.Item(8, i).Value = .Item("ProcNum")
                DGVOther.Item(9, i).Value = .Item("UserName")
                DGVOther.Item(10, i).Value = .Item("PaymentName")

            End With
        Next
        DGVOther.ClearSelection()

    End Sub



    Private Sub FillData2(Type As Data, DS As DataSet, TCount As Integer)

        'If DS.Tables(6).Rows.Count > 0 Then
        '    RowsCount2 = DS.Tables(6).Rows(0).Item(0)
        'End If
        ' GetPagesCount1()

        'DGVImaging.Rows.Clear()
        'TxtTotalImaging.Text = 0
        'For i = 0 To DS.Tables(5).Rows.Count - 1
        '    With DS.Tables(5).Rows(i)

        '        DGVImaging.Rows.Add()
        '        DGVImaging.Item(0, i).Value = .Item("ID")
        '        DGVImaging.Item(1, i).Value = .Item("ت") 'i + 1
        '        DGVImaging.Item(2, i).Value = Format(.Item("Date"), GetDateAndTimeFormat(DTFormat.DTF))
        '        DGVImaging.Item(3, i).Value = Format(.Item("Value"), "0.000")
        '        TxtTotalImaging.Text = Val(TxtTotalImaging.Text) + .Item("Value")
        '        DGVImaging.Item(3, i).Style.BackColor = Color.LightGreen
        '        DGVImaging.Item(3, i).Style.ForeColor = Color.White
        '        DGVImaging.Item(4, i).Value = .Item("FinancName")
        '        DGVImaging.Item(5, i).Value = Format(.Item("NUM"), "000000")
        '        DGVImaging.Item(6, i).Value = .Item("UserName")
        '        DGVImaging.Item(7, i).Value = .Item("PaymentName")

        '    End With
        'Next
        'DGVImaging.ClearSelection()


    End Sub


    '****************************************************************************
    '------------------Pagination-------------------------------------------
    Private Sub GetPagesCount()
        If RowsCount = PageSize Then
            PagesCount = 1

        ElseIf RowsCount Mod PageSize = 0 And RowsCount <> 0 Then
            PagesCount = RowsCount / PageSize

        Else
            PagesCount = (RowsCount \ PageSize) + 1
        End If
        TxtPagesCount.Text = PagesCount
        TxtPageNum.Text = PageNum

    End Sub

    Private Sub BtnNextPage_Click(sender As Object, e As EventArgs) Handles BtnNextPage.Click

        CheckPageSize()

        If PageNum < PagesCount Then
            PageNum += 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnPreviousPage_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage.Click

        CheckPageSize()

        If PageNum > 1 Then
            PageNum -= 1
        Else
            PageNum = 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnFirstPage_Click(sender As Object, e As EventArgs) Handles BtnFirstPage.Click

        PageNum = 1
        GetData(Data.Search)

    End Sub

    Private Sub BtnLastPage_Click(sender As Object, e As EventArgs) Handles BtnLastPage.Click

        CheckPageSize()
        CheckPageSize1()
        PageNum = PagesCount

        GetData(Data.Search)

    End Sub

    Private Sub TxtPageNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPageNum.KeyDown

        If e.KeyCode = Keys.Enter Then
            CheckPageSize()

            If Val(TxtPageNum.Text) > Val(TxtPagesCount.Text) Then
                PageNum = TxtPagesCount.Text

            ElseIf Val(TxtPageNum.Text) <= 0 Then
                PageNum = 1

            Else
                PageNum = Val(TxtPageNum.Text)
            End If
            GetData(Data.Search)
        End If

    End Sub

    Private Sub TxtPageNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPageNum.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        End If
    End Sub

    Private Sub CheckPageSize()

        If PageSize <> My.Settings.SizeOfPage Then
            PageNum = 1
            GetData(Data.Search) 'عند تغيير حجم الصفحة يجب معرفة عدد الصفحات الجديد PagesCount
        End If

    End Sub

    Private Sub NUDPageSize_TextChanged(sender As Object, e As EventArgs) Handles NUDPageSize.TextChanged

        If NUDPageSize.Value = 0 Or Val(NUDPageSize.Value) = 0 Then
            NUDPageSize.Value = 1
        Else
            NUDPageSize_ValueChanged(sender, e)
        End If

    End Sub

    Private Sub NUDPageSize_ValueChanged(sender As Object, e As EventArgs) Handles NUDPageSize.ValueChanged

        Dim SPageSize As Integer = My.Settings.SizeOfPage

        If NUDPageSize.Value <> 0 And SPageSize <> NUDPageSize.Value Then
            My.Settings.SizeOfPage = NUDPageSize.Value
            My.Settings.Save()
        End If

        DGV.Rows.Clear()

    End Sub

    Private Sub NUDPageSize_LostFocus(sender As Object, e As EventArgs) Handles NUDPageSize.LostFocus
        If Val(NUDPageSize.Value) = 0 Then
            NUDPageSize.Value = 1
        End If
    End Sub

    Private Sub BtnRefreshPage_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage.Click
        TxtPageNum.Text = 1
        BtnFirstPage_Click(sender, e)
    End Sub

    '****************************************************************************
    '------------------Pagination-------------------------------------------
    Private Sub GetPagesCount1()
        If RowsCount1 = PageSize1 Then
            PagesCount1 = 1

        ElseIf RowsCount1 Mod PageSize1 = 0 And RowsCount1 <> 0 Then
            PagesCount1 = RowsCount1 / PageSize1

        Else
            PagesCount1 = (RowsCount1 \ PageSize1) + 1
        End If
        TxtPageCount1.Text = PagesCount1

    End Sub

    Private Sub BtnNextPage1_Click(sender As Object, e As EventArgs) Handles BtnNextPage1.Click

        CheckPageSize1()

        If PageNum1 < PagesCount1 Then
            PageNum1 += 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnPreviousPage1_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage1.Click

        CheckPageSize1()

        If PageNum1 > 1 Then
            PageNum1 -= 1
        Else
            PageNum1 = 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnFirstPage1_Click(sender As Object, e As EventArgs) Handles BtnFirstPage1.Click

        PageNum1 = 1
        GetData(Data.Search)

    End Sub

    Private Sub BtnLastPage1_Click(sender As Object, e As EventArgs) Handles BtnLastPage1.Click

        CheckPageSize1()
        PageNum1 = PagesCount1
        GetData(Data.Search)

    End Sub

    Private Sub TxtPageNum1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPageNum1.KeyDown

        If e.KeyCode = Keys.Enter Then
            CheckPageSize1()

            If Val(TxtPageNum1.Text) > Val(TxtPageCount1.Text) Then
                PageNum1 = TxtPageCount1.Text

            ElseIf Val(TxtPageNum1.Text) <= 0 Then
                PageNum1 = 1

            Else
                PageNum1 = Val(TxtPageNum1.Text)
            End If
            GetData(Data.Search)
        End If

    End Sub

    Private Sub TxtPageNum1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPageNum1.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        End If
    End Sub

    Private Sub CheckPageSize1()

        If PageSize1 <> My.Settings.SizeOfPage Then
            PageNum1 = 1
            GetData(Data.Search) 'عند تغيير حجم الصفحة يجب معرفة عدد الصفحات الجديد PagesCount
        End If

    End Sub

    Private Sub NUDPageSize1_TextChanged(sender As Object, e As EventArgs) Handles NUDPageSize1.TextChanged

        If NUDPageSize1.Value = 0 Then
            NUDPageSize1.Value = 1
        Else
            NUDPageSize1_ValueChanged(sender, e)
        End If

    End Sub

    Private Sub NUDPageSize1_ValueChanged(sender As Object, e As EventArgs) Handles NUDPageSize1.ValueChanged

        Dim SPageSize1 As Integer = My.Settings.SizeOfPage

        If NUDPageSize1.Value <> 0 And SPageSize1 <> NUDPageSize1.Value Then
            My.Settings.SizeOfPage = NUDPageSize1.Value
            My.Settings.Save()
        End If

        DGVOther.Rows.Clear()

    End Sub

    Private Sub BtnRefreshPage1_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage1.Click
        TxtPageNum1.Text = 1
        BtnFirstPage1_Click(sender, e)
    End Sub
    '-------------------------------------------------------------------










    '****************************************************************************
    '------------------Pagination-------------------------------------------
    Private Sub GetPagesCount2()
        If RowsCount2 = PageSize2 Then
            PagesCount2 = 1

        ElseIf RowsCount2 Mod PageSize2 = 0 And RowsCount2 <> 0 Then
            PagesCount2 = RowsCount2 / PageSize2

        Else
            PagesCount2 = (RowsCount2 \ PageSize2) + 1
        End If
        TxtPageCount2.Text = PagesCount2
        TxtPageNum2.Text = PageNum2

    End Sub

    Private Sub BtnNextPage2_Click(sender As Object, e As EventArgs) Handles BtnNextPage2.Click

        CheckPageSize2()

        If PageNum2 < PagesCount2 Then
            PageNum2 += 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnPreviousPage2_Click(sender As Object, e As EventArgs) Handles BtnPreviousPage2.Click

        CheckPageSize2()

        If PageNum2 > 1 Then
            PageNum2 -= 1
        Else
            PageNum2 = 1
        End If

        GetData(Data.Search)

    End Sub

    Private Sub BtnFirstPage2_Click(sender As Object, e As EventArgs) Handles BtnFirstPage2.Click

        PageNum2 = 1
        GetData(Data.Search)

    End Sub

    Private Sub BtnLastPage2_Click(sender As Object, e As EventArgs) Handles BtnLastPage2.Click

        CheckPageSize2()
        PageNum2 = PagesCount2

        GetData(Data.Search)

    End Sub

    Private Sub TxtPageNum2_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPageNum2.KeyDown

        If e.KeyCode = Keys.Enter Then
            CheckPageSize2()

            If Val(TxtPageNum2.Text) > Val(TxtPageCount2.Text) Then
                PageNum2 = TxtPageCount2.Text

            ElseIf Val(TxtPageNum2.Text) <= 0 Then
                PageNum2 = 1

            Else
                PageNum2 = Val(TxtPageNum2.Text)
            End If
            GetData(Data.Search)
        End If

    End Sub

    Private Sub TxtPageNum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPageNum2.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Back Then
            e.Handled = False
        End If
    End Sub

    Private Sub CheckPageSize2()

        If PageSize2 <> My.Settings.SizeOfPage Then
            PageNum2 = 1
            GetData(Data.Search) 'عند تغيير حجم الصفحة يجب معرفة عدد الصفحات الجديد PagesCount
        End If

    End Sub

    Private Sub NUDPageSize2_TextChanged(sender As Object, e As EventArgs) Handles NUDPageSize2.TextChanged

        If NUDPageSize2.Value = 0 Then
            NUDPageSize2.Value = 1
        Else
            NUDPageSize2_ValueChanged(sender, e)
        End If

    End Sub

    Private Sub NUDPageSize2_ValueChanged(sender As Object, e As EventArgs) Handles NUDPageSize2.ValueChanged

        Dim SPageSize As Integer = My.Settings.SizeOfPage

        If NUDPageSize2.Value <> 0 And SPageSize <> NUDPageSize2.Value Then
            My.Settings.SizeOfPage = NUDPageSize2.Value
            My.Settings.Save()
        End If

        DGVImaging.Rows.Clear()

    End Sub


    Private Sub BtnRefreshPage2_Click(sender As Object, e As EventArgs) Handles BtnRefreshPage2.Click
        TxtPageNum2.Text = 1
        BtnFirstPage2_Click(sender, e)
    End Sub



















    '------------------------------

    Private Sub ChkDay_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDay.CheckedChanged
        DGV.Rows.Clear()

        If ChkDay.Checked = True Then
            CmbDay.Enabled = True
            CmbDay.Text = Now.Day
        Else
            CmbDay.Enabled = False
            CmbDay.SelectedIndex = -1
        End If
    End Sub

    Private Sub TxtPageNum_TextChanged(sender As Object, e As EventArgs) Handles TxtPageNum.TextChanged

    End Sub

    Private Sub TxtValue_TextChanged(sender As Object, e As EventArgs) Handles TxtValue.TextChanged
        If TxtValue.Text <> vbNullString Then
            If Val(TxtValue.Text) >= 0 Then
                TxtMonyCharCash.Text = NoToTxt(Val(TxtValue.Text), "دينار", "درهم", True)
            Else
                TxtMonyCharCash.Text = NoToTxt(Val(TxtValue.Text) * -1, "دينار", "درهم", True)
                TxtMonyCharCash.Text = " سالب " + TxtMonyCharCash.Text
            End If

        Else
            TxtMonyCharCash.Text = vbNullString
        End If
    End Sub
    Private Sub TxtValue_Click(sender As Object, e As EventArgs) Handles TxtValue.Click

    End Sub


    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If DGV.Rows.Count = 0 And DGVOther.Rows.Count = 0 Then Exit Sub

        Dim DSPrint = New DataSet
        Dim SQLCon = New SQLConClass

        SQLQuery = "SELECT FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DTF) & "') AS [Date],TotalValue,Amont,FinaceName,[Type],FORMAT(NUM,'000000') AS NUM,ProcNUM,UserName,PaymentName,T,TreasuryType FROM TreasuryView WHERE YEAR([Date])=" & CmbYear.Text.Trim & " AND MONTH([Date])=" & CmbMonth.Text.Trim
        AppendReportConditions()
        SQLQuery &= " ORDER BY [Date] DESC"
        SQLQuery &= " SELECT FORMAT([Date],'" & GetDateAndTimeFormat(DTFormat.DTF) & "') AS [Date],Value,FinancName,FORMAT(Num,'000000') AS Num,UserName,PaymentName FROM TreasuryImagingView WHERE YEAR([Date])=" & CmbYear.Text.Trim & " AND MONTH([Date])=" & CmbMonth.Text.Trim
        AppendReportConditions()
        SQLQuery &= " ORDER BY ID DESC"
        SQLQuery &= " SELECT * FROM CenterMainInfoTable"

        DSPrint = SQLCon.SelectData(SQLQuery, 0, Nothing)

        'Dim F As New FrmPrint
        'Dim C As New CRTreasury

        'C.SetDataSource(DSPrint.Tables(0))
        'C.Subreports(0).SetDataSource(DSPrint.Tables(1))
        'C.Subreports(1).SetDataSource(DSPrint.Tables(2))
        'C.Subreports(2).SetDataSource(DSPrint.Tables(2))
        'If ChkDay.Checked = True Then
        '    C.SetParameterValue("Day", Format(Val(CmbDay.Text.Trim), "00").ToString)
        'Else
        '    C.SetParameterValue("Day", "")
        'End If
        'C.SetParameterValue("Month", Format(Val(CmbMonth.Text.Trim), "00").ToString)
        'C.SetParameterValue("Year", CmbYear.Text.Trim)
        'C.SetParameterValue("Total", TxtValue.Text.Trim)
        'C.SetParameterValue("TotalChar", TxtMonyCharCash.Text.Trim)
        'F.CrystalReportViewer1.ReportSource = C
        'F.CrystalReportViewer1.Refresh()
        'F.Text = "طباعة"
        'F.CrystalReportViewer1.Zoom(100%)
        'F.WindowState = FormWindowState.Maximized
        'F.Show()

    End Sub

    Private Sub TxtValueCard_Click(sender As Object, e As EventArgs) Handles TxtValueCard.Click

    End Sub

    Private Sub AppendReportConditions()
        If ChkDay.Checked And CmbDay.Text.Trim <> "" Then AppendToQuery(" AND ", " DAY([Date])=" & CmbDay.Text.Trim)
    End Sub

    Private Sub TxtTotalImaging_Click(sender As Object, e As EventArgs) Handles TxtTotalImaging.Click

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        PageNum = 1
        PageNum1 = 1
        PageNum2 = 1

        GetData(Data.Search)
    End Sub

    Private Sub FrmTreasury_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbYear.Items.Clear()
        For i = Now.Date.Year To Now.Date.Year - 10 Step -1
            CmbYear.Items.Add(i)
        Next
    End Sub

    Private Sub CmbDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDay.SelectedIndexChanged

    End Sub

    Private Sub CmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMonth.SelectedIndexChanged

    End Sub

    Private Sub LblCash_Click(sender As Object, e As EventArgs) Handles LblCash.Click
        TabControl1.SelectTab(0)
        PnlCash.BackColor = Color.White
        PnlOther.BackColor = PnlDrawer.BackColor
    End Sub

    Private Sub LblOther_Click(sender As Object, e As EventArgs) Handles LblOther.Click
        TabControl1.SelectTab(1)
        PnlCash.BackColor = PnlDrawer.BackColor
        PnlOther.BackColor = Color.White
    End Sub
    Private Sub LblImaging_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(2)
        PnlCash.BackColor = PnlDrawer.BackColor
        PnlOther.BackColor = PnlDrawer.BackColor
    End Sub

    Private Sub TxtPageNum_Click(sender As Object, e As EventArgs) Handles TxtPageNum.Click
        TxtPageNum.SelectAll()
        SelectAllText = True
    End Sub

    Private Sub TxtValueCard_TextChanged(sender As Object, e As EventArgs) Handles TxtValueCard.TextChanged
        If TxtValueCard.Text <> vbNullString Then
            If Val(TxtValueCard.Text) >= 0 Then
                TxtMonyCharCard.Text = NoToTxt(Val(TxtValueCard.Text), "دينار", "درهم", True)
            Else
                TxtMonyCharCard.Text = NoToTxt(Val(TxtValueCard.Text) * -1, "دينار", "درهم", True)
                TxtMonyCharCard.Text = " سالب " + TxtMonyCharCard.Text
            End If

        Else
            TxtMonyCharCard.Text = vbNullString
        End If
    End Sub

    Private Sub TxtTotalImaging_TextAlignChanged(sender As Object, e As EventArgs) Handles TxtTotalImaging.TextAlignChanged

    End Sub

    Private Sub TxtTotalImaging_TextChanged(sender As Object, e As EventArgs) Handles TxtTotalImaging.TextChanged
        If TxtTotalImaging.Text <> vbNullString Then
            If Val(TxtTotalImaging.Text) >= 0 Then
                TxtMonyCharImaging.Text = NoToTxt(Val(TxtTotalImaging.Text), "دينار", "درهم", True)
            Else
                TxtMonyCharImaging.Text = NoToTxt(Val(TxtTotalImaging.Text) * -1, "دينار", "درهم", True)
                TxtMonyCharImaging.Text = " سالب " + TxtMonyCharImaging.Text
            End If

        Else
            TxtMonyCharImaging.Text = vbNullString
        End If
    End Sub


End Class