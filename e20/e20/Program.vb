Imports System

Module Program

    Sub Main(args As String())

        Dim se, ne, k, ss, sp
        ne = Console.ReadLine()
        ss = 0

        For k = 1 To ne
            se = Console.ReadLine()
            ss = ss + ne
        Next

        sp = ss / ne
        Console.WriteLine(sp)
        Console.ReadLine()
    End Sub
End Module
