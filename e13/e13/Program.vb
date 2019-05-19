Imports System

Module Program
    Sub Main(args As String())
        Dim l1, l2, l3, tt
        l1 = Console.ReadLine()
        l2 = Console.ReadLine()
        l3 = Console.ReadLine()

        If l1 <> l2 And l2 <> l3 And l3 <> l1 Then
            tt = "escaleno"
        Else
            If l1 = l2 And l2 = l3 Then
                tt = "equilatero"
            Else
                tt = "isosceles"
            End If
        End If
        Console.WriteLine(tt)
        Console.ReadLine()
    End Sub
End Module
