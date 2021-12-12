Module Module1

    Sub Main()
        Dim str1, str2 As String

        str1 = ""
        str2 = ""

        Console.Write("Enter string to process : ")
        str1 = Console.ReadLine
        If Len(str1) > 2 Then
            If Right(str1, 3) <> "ing" Then
                str2 = str1 & "ing"
            Else
                str2 = str1 & "ly"
            End If
        Else
            str2 = str1
        End If
        Console.Write("String after process is " & str2)
        Console.ReadKey()
    End Sub

End Module
