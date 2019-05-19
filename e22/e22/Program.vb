Imports System

Module Program
    Sub Main(args As String())
        Dim pn, sn, k, p
        pn = Console.ReadLine()
        sn = Console.ReadLine()
        p = 0
        For k = 1 To sn
            p = p + pn
        Next
        Console.WriteLine(p)
        Console.ReadLine()
    End Sub
End Module
