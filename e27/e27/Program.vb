Imports System

Module Program
    Sub Main(args As String())
        Dim n1%, n2%, r
        Dim op As String
        n1 = Console.ReadLine()
        n2 = Console.ReadLine()
        op = Console.ReadLine()
        Select Case op
            Case "+"
                r = n1 + n2
            Case "-"
                r = n1 - n2
            Case "*"
                r = n1 * n2
            Case "^"
                r = n1 ^ n2
            Case Else
                r = 0
        End Select
        Console.WriteLine(r)
        Console.ReadLine()
    End Sub
End Module
