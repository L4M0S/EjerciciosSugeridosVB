Imports System

Module Program
    Sub Main(args As String())
        Dim i, d As Integer
        Dim salir As Integer
        Dim s As Char
        Do

            Console.ForegroundColor = ConsoleColor.DarkGreen
            Console.Write("Ingrese Número de datos del Arreglo: ")
            d = CInt(Console.ReadLine)
            Dim A(d - 1) As Integer
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("Elementos Ingresados: ")
            For i = 0 To d - 1
                Console.Write("A [{0}] = ", i)
                A(i) = CInt(Console.ReadLine)
            Next
            Console.WriteLine("Presione una tecla para ver la lista ingresada")
            Console.ReadLine()
            Console.Clear()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("Lista Ingresada")
            Console.WriteLine()
            For i = 0 To d - 1
                Console.WriteLine("{0} ", A(i))
            Next
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("Presione S para salir, ")
            Console.WriteLine("Presione C para continuar, ")
            Console.WriteLine("(Continuar / Salir) ...")
            s = CChar(Console.ReadLine)
            If s = "s" Or s = "S" Then
                salir = 1
            End If
        Loop While (salir <> 1)

        Console.ReadLine()
    End Sub
End Module
