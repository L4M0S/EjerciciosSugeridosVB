Imports System

Module Program
    Sub Main(args As String())
        Dim n As Integer
        Console.Write("Ingrese el Número a Evaluar : ")
        n = CInt(Console.ReadLine)
        If EsPrimo(n) = True Then
            Console.WriteLine("El Número SI es Primo")
        Else
            Console.WriteLine("El Número NO es Primo")
        End If
        Console.ReadLine()
    End Sub
    Function EsPrimo(ByVal n As Integer) As Boolean
        Dim i As Integer
        i = n - 1
        While (i > 1)
            If n Mod i = 0 Then
                EsPrimo = False
                Exit Function
            End If
            i = i - 1
        End While
        EsPrimo = True
    End Function
End Module
