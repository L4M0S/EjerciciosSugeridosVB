Imports System

Module Program
    Sub Main(args As String())
        Dim mv, tb
        mv = Console.ReadLine()

        Select Case mv
            Case mv >= 0 And mv < 1000
                tb = (0 * mv) / 100
            Case mv >= 1000 And mv < 5000
                tb = (3 * mv) / 100
            Case mv >= 5000 And mv < 20000
                tb = (5 * mv) / 100
            Case mv >= 20000
                tb = (8 * mv) / 100
        End Select

        Console.WriteLine(tb)
        Console.ReadLine()
    End Sub
End Module
