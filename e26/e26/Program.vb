Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c
        a = 0
        b = 1
        c = a + b
        Console.WriteLine(a)
        Console.WriteLine(b)

        While c < 100000
            Console.WriteLine(c)
            a = b
            b = c
            c = a + b
        End While
        Console.ReadLine()
    End Sub
End Module
