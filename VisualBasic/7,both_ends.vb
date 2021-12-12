Module Module1

    Sub Main()
        Dim s, Last2, First2, Str As String

        s = ""
        Last2 = ""
        First2 = ""
        Str = ""

        Console.Write("Enter String to Process : ")
        s = Console.ReadLine
        First2 = Left(s, 2)
        Last2 = Right(s, 2)
        Str = First2 & Last2
        If Len(s) < 2 Then
            Console.Write("String is not of sufficient length : " & s)
        Else
            Console.Write("String after process is " & Str)
        End If
        Console.ReadKey()
    End Sub

End Module
