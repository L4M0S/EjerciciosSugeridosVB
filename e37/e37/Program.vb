Imports System

Module Program
    Sub Main(args As String())
        Dim NomApe(1, 3) As String
        Dim X1, X2, Y As Integer
        NomApe(0, 0) = "Joel"
        NomApe(0, 1) = "Nahum"
        NomApe(0, 2) = "Krizia"
        NomApe(0, 3) = "Giselle"
        NomApe(1, 0) = "Chuco"
        NomApe(1, 1) = "Chuco"
        NomApe(1, 2) = "Rupay"
        NomApe(1, 3) = "Valverde"
        Console.WriteLine("Los Nombres y Apellidos Son: ")
        Console.WriteLine()
        For X1 = 0 To 0
            For Y = 0 To 3
                Console.Write("{0}{1}", NomApe(X1, Y), " ")
                For X2 = 1 To 1
                    Console.WriteLine(NomApe(X2, Y))
                Next
            Next
        Next
        Console.ReadLine()
    End Sub
End Module
