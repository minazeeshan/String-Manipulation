Module Module1

    Sub Main()
        Dim Str1, Alpha As String
        Dim i, Num, NumCount, AlphaCount, otherCharCount, countChar, c As Integer
        Dim thisChar, myChar, CharToCount As Char
        Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Num = "0123456789"
        i = 0
        Str1 = ""
        otherCharCount = 0
        thisChar = ""
        myChar = ""
        CharToCount = ""
        NumCount = 0
        AlphaCount = 0
        countChar = 0
        c = 0

        Console.Write("Enter string to count characters of : ")
        Str1 = Console.ReadLine()
        Console.Write("Enter which Character you want to count : ")
        CharToCount = Console.ReadLine()
        For c = 1 To Len(Str1)
            myChar = Mid(Str1, c, 1)
            If myChar = CharToCount Then
                countChar = countChar + 1
            End If
        Next
        Console.WriteLine("The character " & CharToCount & " appeared " & countChar & " number of times")
        For i = 1 To Len(Str1)
            thisChar = Mid(Str1, i, 1)
            If InStr(Alpha, thisChar) <> 0 Then
                AlphaCount = AlphaCount + 1
            ElseIf InStr(Num, thisChar) <> 0 Or thisChar = "0" Then
                NumCount = NumCount + 1
            Else
                otherCharCount = otherCharCount + 1
            End If
        Next
        Console.WriteLine("Number of alphabets in string are " & AlphaCount)
        Console.WriteLine("Number of digits in string are " & NumCount)
        Console.WriteLine("Number of other characters in string are " & otherCharCount)
        Console.ReadKey()

    End Sub

End Module
