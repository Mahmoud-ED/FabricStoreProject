Module MdlNumbers
    Function NoToTxt(ByVal TheNo As Double, ByVal MyCur As String, ByVal MySubCur As String, Optional ByVal Dec3Digit As Boolean = False) As String
        '======================
        If Dec3Digit Then
            If TheNo > 999999999999.999 Then Return Nothing
        Else
            If TheNo > 999999999999.99 Then Return Nothing
        End If
        '======================
        If TheNo = 0 Then Return "صفر"
        '======================

        Dim MyNoToTxt As String
        Dim MyNo, GetNo, RdNo, GetTxt, ReMark As String
        Dim My100, My10, My1, My11, My12 As String
        Dim Mybillion, MyMillion As String
        Dim MyThou, MyHun, MyFraction As String
        Dim MyArry1() As String = {"", "واحد", "إثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة"}
        Dim MyArry2() As String = {"", " عشر", "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون"}
        Dim MyArry3() As String = {"", "مئة", "مئتان", "ثلاثمائة", "اربعمائة", "خمسمائة", "ستمائة", "سبعمائة", "ثمانمائة", "تسعمائة"}
        Dim MyAnd As String = " و"

        '======================
        If Dec3Digit Then
            GetNo = Format(TheNo, "000000000000.000")
        Else
            GetNo = Format(TheNo, "000000000000.00")
        End If
        '======================
        For i = 0 To 14 Step 3

            If i < 12 Then
                MyNo = Mid$(GetNo, i + 1, 3)
            Else
                If Dec3Digit Then
                    MyNo = Mid$(GetNo, i + 2, 3)
                Else
                    MyNo = "0" + Mid$(GetNo, i + 2, 3)
                End If
            End If

            If (Mid$(MyNo, 1, 3)) > 0 Then

                RdNo = Mid$(MyNo, 1, 1)
                My100 = MyArry3(RdNo)
                RdNo = Mid$(MyNo, 3, 1)
                My1 = MyArry1(RdNo)
                RdNo = Mid$(MyNo, 2, 1)
                My10 = MyArry2(RdNo)

                If Mid$(MyNo, 2, 2) = 11 Then My11 = "أحد عشر"
                If Mid$(MyNo, 2, 2) = 12 Then My12 = "أثنا عشر"
                If Mid$(MyNo, 2, 2) = 10 Then My10 = "عشرة"

                If ((Mid$(MyNo, 1, 1)) > 0) And ((Mid$(MyNo, 2, 2)) > 0) Then My100 = My100 + MyAnd
                If ((Mid$(MyNo, 3, 1)) > 0) And ((Mid$(MyNo, 2, 1)) > 1) Then My1 = My1 + MyAnd

                GetTxt = My100 + My1 + My10

                If ((Mid$(MyNo, 3, 1)) = 1) And ((Mid$(MyNo, 2, 1)) = 1) Then
                    GetTxt = My100 + My11
                    If ((Mid$(MyNo, 1, 1)) = 0) Then GetTxt = My11
                End If

                If ((Mid$(MyNo, 3, 1)) = 2) And ((Mid$(MyNo, 2, 1)) = 1) Then
                    GetTxt = My100 + My12
                    If ((Mid$(MyNo, 1, 1)) = 0) Then GetTxt = My12
                End If

                If (i = 0) And (GetTxt <> "") Then
                    If ((Mid$(MyNo, 1, 3)) > 10) Then
                        Mybillion = GetTxt + " مليون"
                    Else
                        Mybillion = GetTxt + " مليون"
                        If ((Mid$(MyNo, 1, 3)) = 2) Then Mybillion = " مليون"
                        If ((Mid$(MyNo, 1, 3)) = 2) Then Mybillion = " ملايين"
                    End If
                End If

                If (i = 3) And (GetTxt <> "") Then

                    If ((Mid$(MyNo, 1, 3)) > 10) Then
                        MyMillion = GetTxt + " مليون"
                    Else
                        MyMillion = GetTxt + " ملايين"
                        If ((Mid$(MyNo, 1, 3)) = 1) Then MyMillion = " مليون"
                        If ((Mid$(MyNo, 1, 3)) = 2) Then MyMillion = " اتنان مليون"
                    End If
                End If

                If (i = 6) And (GetTxt <> "") Then
                    If ((Mid$(MyNo, 1, 3)) > 10) Then
                        MyThou = GetTxt + " ألف"
                    Else
                        MyThou = GetTxt + " آلاف"
                        If ((Mid$(MyNo, 3, 1)) = 1) Then MyThou = " ألف"
                        If ((Mid$(MyNo, 3, 1)) = 2) Then MyThou = " ألفين"
                    End If
                End If

                If (i = 9) And (GetTxt <> "") Then MyHun = GetTxt
                If (i = 12) And (GetTxt <> "") Then MyFraction = GetTxt
            End If
        Next

        If (Mybillion <> "") Then
            If (MyMillion <> "") Or (MyThou <> "") Or (MyHun <> "") Then Mybillion = Mybillion + MyAnd
        End If

        If (MyMillion <> "") Then
            If (MyThou <> "") Or (MyHun <> "") Then MyMillion = MyMillion + MyAnd
        End If

        If (MyThou <> "") Then
            If (MyHun <> "") Then MyThou = MyThou + MyAnd
        End If

        If MyFraction <> "" Then
            If (Mybillion <> "") Or (MyMillion <> "") Or (MyThou <> "") Or (MyHun <> "") Then
                MyNoToTxt = ReMark + Mybillion + MyMillion + MyThou + MyHun + " " + MyCur + MyAnd + MyFraction + " " + MySubCur
            Else
                MyNoToTxt = ReMark + MyFraction + " " + MySubCur
            End If
        Else
            MyNoToTxt = ReMark + Mybillion + MyMillion + MyThou + MyHun + " " + MyCur
        End If

        Return MyNoToTxt
    End Function
End Module
