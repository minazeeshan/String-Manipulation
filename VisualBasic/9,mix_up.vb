Module Module1

    Sub Main()
        Dim a, b, aFirst2, bFirst2, FinalString As String

        a = ""
        b = ""
        aFirst2 = ""
        bFirst2 = ""
        FinalString = ""

        Console.Write("Enter first string : ")
        a = Console.ReadLine
        Console.Write("Enter second string : ")
        b = Console.ReadLine
        If Len(a) > 1 And Len(b) > 1 Then
            aFirst2 = Left(a, 2)
            bFirst2 = Left(b, 2)
            a = bFirst2 & Right(a, Len(a) - 2)
            b = aFirst2 & Right(b, Len(b) - 2)
            FinalString = a & " " & b
            Console.Write("Both strings merged after process : " & FinalString)
        Else
            Console.Write("Strings input not of sufficient length")
        End If
        Console.ReadKey()

    End Sub

End Module
