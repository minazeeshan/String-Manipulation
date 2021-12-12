Module Module1

    Sub Main()
        Dim i, aCount, eCount, iCount, oCount, uCount As Integer
        Dim Str1 As String
        Dim thisChar As Char

        Str1 = ""
        thisChar = ""
        aCount = 0
        eCount = 0
        iCount = 0
        oCount = 0
        uCount = 0
        i = 0

        Console.Write("Enter string to enter vowels separately of : ")
        Str1 = Console.ReadLine()
        Str1 = LCase(Str1)
        For i = 1 To Len(Str1)
            thisChar = Mid(Str1, i, 1)
            If thisChar = "a" Then
                aCount = aCount + 1
            ElseIf thisChar = "e" Then
                eCount = eCount + 1
            ElseIf thisChar = "i" Then
                iCount = iCount + 1
            ElseIf thisChar = "o" Then
                oCount = oCount + 1
            ElseIf thisChar = "u" Then
                uCount = uCount + 1
            End If
        Next
        Console.WriteLine("Total number of 'a's in string is " & aCount)
        Console.WriteLine("Total number of 'e's in string is " & eCount)
        Console.WriteLine("Total number of 'i's in string is " & iCount)
        Console.WriteLine("Total number of 'o's in string is " & oCount)
        Console.WriteLine("Total number of 'u's in string is " & uCount)
        Console.ReadKey()
    End Sub

End Module
