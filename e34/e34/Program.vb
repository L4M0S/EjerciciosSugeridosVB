Imports System

Module Program
    Sub Main(args As String())
        Dim ArrayUnidimensional(3) As Integer
        Dim X, Num As Integer
        For X = 0 To 3
            Num = X + 1
            ArrayUnidimensional(X) = Num
        Next
        Console.WriteLine()
        Console.WriteLine("Array Unidimensional 4")
        Console.WriteLine()
        For X = 0 To 3
            Console.WriteLine("Indice [{0}{1}{2}", X, "] = ", ArrayUnidimensional(X))
        Next
        Console.ReadLine()
    End Sub
End Module
