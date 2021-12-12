Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim thisChar, selectedChar, desiredChar As Char
        Dim i As Integer

        Str1 = ""
        Str2 = ""
        thisChar = ""
        selectedChar = ""
        desiredChar = ""
        i = 0

        Console.Write("Enter String to process : ")
        Str1 = Console.ReadLine
        Console.Write("Enter string to remove : ")
        selectedChar = Console.ReadLine
        Console.Write("Enter string to replace it with : ")
        desiredChar = Console.ReadLine
        For i = 1 To Len(Str1)
            thisChar = Mid(Str1, i, 1)
            If thisChar = selectedChar Then
                Str2 = Str2 & desiredChar
            Else
                Str2 = Str2 & thisChar
            End If
        Next
        Console.Write("String after replacing selected character with another is : " & Str2)
        Console.ReadKey()
    End Sub

End Module
