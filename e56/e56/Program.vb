Imports System
Public Class Cuadrado
    Dim Lado As Double
    Public Sub Inicio(ByVal L As Double)
        Lado = L
    End Sub
    Public Function Area() As Double
        Return Lado * Lado
    End Function
    Public Function Perimetro() As Double
        Return 4 * Lado
    End Function
End Class
Module Program
    Sub Main(args As String())
        Dim X As Cuadrado
        Dim L As Double = 5.0
        X = New Cuadrado
        X.Inicio(L)
        Console.WriteLine("El área del cuadrado es: {0}", X.Area)
        Console.WriteLine("El perimetro del cuadrado es: {0}", X.Perimetro)
        Console.ReadLine()
    End Sub
End Module
