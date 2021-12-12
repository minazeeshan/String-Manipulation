Module Module1

    Sub Main()
        Dim donutCount As Integer

        donutCount = 0

        Console.Write("Enter Number of Donuts : ")
        donutCount = Console.ReadLine
        If donutCount < 10 Then
            Console.Write("Number of Donuts : " & donutCount)
        Else
            Console.Write("Number of Donuts : many")
        End If
        Console.ReadKey()
    End Sub

End Module
