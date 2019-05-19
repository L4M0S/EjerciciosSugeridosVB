Imports System
Enum Colores
    Azul
    Rojo
    Verde
End Enum
Module Program
    Sub Main(args As String())
        Dim Numero As Integer
        Dim Color As String
        Console.WriteLine("{0}{1}" + "ELEGIR COLOR")
        Console.WriteLine()
        Console.WriteLine("{0}{1}" + "[0] Color Azul")
        Console.WriteLine("{0}{1}" + "[1] Color Rojo")
        Console.WriteLine("{0}{1}" + "[2] Color Verde")
        Console.WriteLine()
        Console.Write("Ingrese el Número de Color ==> ")
        Numero = CInt(Console.ReadLine)
        If Numero < Colores.Azul Or Numero > Colores.Verde Then
            Console.WriteLine("Color no Válido")
            Exit Sub
        End If
        Console.WriteLine()
        Console.Write("Usted Eligio el color ")
        Select Case Numero
            Case Colores.Azul
                Console.ForegroundColor = ConsoleColor.Blue
                Color = "Azul"
            Case Colores.Rojo
                Console.ForegroundColor = ConsoleColor.Red
                Color = "Rojo"
            Case Colores.Verde
                Console.ForegroundColor = ConsoleColor.Green
                Color = "Verde"
        End Select
        Console.WriteLine(Color)
        Console.ForegroundColor = ConsoleColor.Gray
        Console.ReadLine()

    End Sub
End Module
