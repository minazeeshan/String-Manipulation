Module Module1

    Sub Main()
        Dim Str1, Alphabets As String
        Dim thisChar As Char
        Dim i As Integer
        Dim isAlphabet As Boolean

        Str1 = ""
        Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ."
        thisChar = ""
        i = 0
        isAlphabet = True

        Console.Write("Enter string to check alphabets from : ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)
        For i = 1 To Len(Str1)
            thisChar = Mid(Str1, i, 1)
            If InStr(Alphabets, thisChar) = 0 Then
                isAlphabet = False
                Exit For
            End If
        Next
        If isAlphabet = True Then
            Console.Write("String has all alphabets")
        Else
            Console.Write("String does not have all alphabets")
        End If
        Console.ReadKey()
    End Sub

End Module
