Imports System

Module Program
    Sub Main(args As String())
        Dim rc, ri, rb, prc, pri, pf
        rc = Console.ReadLine()
        ri = Console.ReadLine()
        rb = Console.ReadLine()
        prc = rc * 4
        pri = ri * -1
        pf = prc + pri
        Console.WriteLine(pf)
        Console.ReadLine()
    End Sub
End Module
