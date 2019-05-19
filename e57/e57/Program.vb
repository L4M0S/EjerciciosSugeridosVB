Imports System
Structure Triangulo
    Dim a, b, c, p, h As Double
    Sub TrianRec(ByVal d As Double, ByVal e As Double)
        a = d
        b = e
    End Sub
    Sub TrianNor(ByVal d As Double, ByVal e As Double, ByVal f As Double)
        a = d
        b = e
        c = f
    End Sub
    Function AreaTrianRec() As Double
        Return (a * b) / 2
    End Function
    Function AreaTrianNor() As Double
        p = (a + b + c) / 2
        Return Math.Sqrt(p * (p - a) * (p - b) * (p - c))
    End Function
    Function PeriTrianRec() As Double
        h = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
        Return h + a + b
    End Function
    Function PeriTrianNor() As Double
        Return a + b + c
    End Function
End Structure
Module Program
    Sub Main(args As String())
        Dim Rec, Nor As Triangulo
        Dim n, a, b, c As Double
        Call Menu()
        Console.Write("Elija una Opción ==> ")
        n = CDbl(Console.ReadLine)
        Console.WriteLine()
        While n <> 3
            Select Case n
                Case 1
                    Console.Write("Ingrese la altura: ")
                    a = CDbl(Console.ReadLine)

                    Console.Write("Ingrese la base: ")
                    b = CDbl(Console.ReadLine)
                    Rec.TrianRec(a, b)
                    Console.WriteLine("El área del triangulo es: {0}", Rec.AreaTrianRec)
                    Console.WriteLine("El paremitro del triangulo es: {0}",
Rec.PeriTrianRec)
                Case 2
                    Console.Write("Ingrese el primer lado: ")
                    a = CDbl(Console.ReadLine)
                    Console.Write("Ingrese el segundo lado: ")
                    b = CDbl(Console.ReadLine)
                    Console.Write("Ingrese el tercer lado: ")
                    c = CDbl(Console.ReadLine)
                    Nor.TrianNor(a, b, c)
                    Console.WriteLine("El área del triangulo es: {0}", Rec.AreaTrianNor)
                    Console.WriteLine("El paremitro del triangulo es: {0}",
Rec.PeriTrianNor)
                Case Else
                    Console.WriteLine("Opción no Válida")
            End Select
            Console.ReadLine()
            Console.Clear()
            Call Menu()
            Console.Write("Elija una Opción ==> ")
            n = CDbl(Console.ReadLine)
            Console.WriteLine()
        End While
        Console.WriteLine("Fin del Programa")
        Console.ReadLine()
    End Sub

    Sub Menu()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("{0} MENÚ DE OPCIONES")
        Console.WriteLine()
        Console.WriteLine("{0} [1] Halla el área y el perímetro de un triangulo
rectangulo")
        Console.WriteLine("{0} [2] Halla el área y el perímetro de un triangulo
normal")
        Console.WriteLine("{0} [3] Salir")
        Console.WriteLine()
    End Sub
End Module
