Imports System

Module Program
    Sub Main(args As String())
        Dim a, b As Integer
        Console.WriteLine("Divisores Comunes de Dos Números")
        Console.WriteLine()
        Console.Write("Ingrese Primer Número: ")
        a = CInt(Console.ReadLine)
        Console.Write("Ingrese Segundo Número: ")
        b = CInt(Console.ReadLine)
        Console.WriteLine()
        Comunes(a, b)
        Console.ReadLine()
    End Sub
    Sub Comunes(ByVal a As Integer, ByVal b As Integer)
        Dim i As Integer = 1
        While (i <= a And i <= b)
            If a Mod i = 0 AndAlso b Mod i = 0 Then
                Console.WriteLine(i)
            End If
            i = i + 1
        End While
    End Sub
End Module
