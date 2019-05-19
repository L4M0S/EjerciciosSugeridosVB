Imports System

Module Program
    Sub Main(args As String())
        Dim n, m As Integer
        Console.Write("¿Que Tabla de Multiplicar Desea? : ")
        n = CInt(Console.ReadLine)
        Console.Write("¿Cuantos Números Desea Ver? : ")
        m = CInt(Console.ReadLine)
        Console.WriteLine()
        TablaMult(n, m)
        Console.ReadLine()
    End Sub
    Sub TablaMult(ByVal n As Integer, ByVal m As Integer)
        Dim i As Integer
        Console.WriteLine("Tabla de Multiplicar del {0}", n)
        Console.WriteLine()
        For i = 1 To m
            Console.WriteLine("{0}{1}{2}{3}{4}", i, " x ", n, " = ", i * n)
        Next
    End Sub
End Module
