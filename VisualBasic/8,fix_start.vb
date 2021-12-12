Module Module1

    Sub Main()
        Dim s, str2 As String
        Dim thisChar, FirstChar As Char
        Dim i As Integer

        s = ""
        i = 0
        thisChar = ""
        str2 = ""
        FirstChar = ""

        Console.Write("Enter string to process : ")
        s = Console.ReadLine
        s = LCase(s)
        FirstChar = Left(s, 1)
        str2 = Left(s, 1)
        For i = 2 To Len(s)
            thisChar = Mid(s, i, 1)
            If thisChar = FirstChar Then
                str2 = str2 & "*"
            Else
                str2 = str2 & thisChar
            End If
        Next
        Console.Write("String after process is " & str2)
        Console.ReadKey()
    End Sub

End Module
