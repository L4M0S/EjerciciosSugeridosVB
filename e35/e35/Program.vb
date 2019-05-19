Imports System

Module Program
    Sub Main(args As String())
        Dim ArrayBidimensional(3, 3) As Integer
        Dim X, Y, Num As Integer
        For X = 0 To 3
            For Y = 0 To 3
                Num = Y + 1
                If X = 1 Then
                    Num += 4
                ElseIf X = 2 Then
                    Num += 8
                ElseIf X = 3 Then
                    Num += 12
                End If
                ArrayBidimensional(X, Y) = Num
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("Array Bidimensional 4 x 4")
        Console.WriteLine()
        For X = 0 To 3
            For Y = 0 To 3
                Console.WriteLine("Indice [{0}{1}{2}{3}{4}", X, "][", Y, "] = ",
ArrayBidimensional(X, Y))
            Next
        Next
        Console.ReadLine()
    End Sub
End Module
