Imports System

Module Program
    Sub Main(args As String())
        Dim e1, e2, de

        e1 = Console.ReadLine()
        e2 = Console.ReadLine()

        If e1 > e2 Then
            Console.WriteLine("primero mayor por: ")
            de = e1 - e2
        Else
            Console.WriteLine("segundo mayor por: ")
            de = e2 - e1
        End If
        Console.WriteLine(de)

        Console.ReadLine()
    End Sub
End Module
