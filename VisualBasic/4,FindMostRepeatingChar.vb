Module Module1

    Sub Main()
        Dim str1 As String
        Dim i, c, high, charCount As Integer
        Dim thisChar, Char2, mostRepeating As Char
        str1 = ""
        c = 0
        i = 0
        thisChar = ""
        Char2 = ""
        high = 0
        mostRepeating = ""

        Console.Write("Enter string to process : ")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        For i = 1 To Len(str1)
            charCount = 1
            thisChar = Mid(str1, i, 1)
            For c = 2 To Len(str1)
                Char2 = Mid(str1, c, 1)
                If Char2 = thisChar Then
                    charCount = charCount + 1
                End If
            Next
            If charCount > high Then
                high = charCount
                mostRepeating = thisChar
            End If
        Next
        Console.WriteLine("Character that appears most number of times is " & mostRepeating)
        Console.ReadKey()
    End Sub

End Module
