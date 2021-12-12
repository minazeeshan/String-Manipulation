Module Module1

    Sub Main()
        Dim before, after, str1, str2 As String
        Dim notPos, badPos As Integer

        before = ""
        str1 = ""
        after = ""
        notPos = 0
        badPos = 0
        str2 = ""

        Console.Write("Enter string to process : ")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        notPos = InStr(str1, "not")
        badPos = InStr(str1, "bad")
        If notPos < badPos Then
            before = Left(str1, notPos - 1)
            after = Right(str1, Len(str1) - (badPos + 2))
            str2 = before & "good" & after
        End If
        Console.Write("String after process is : " & str2)
        Console.ReadKey()
    End Sub

End Module
