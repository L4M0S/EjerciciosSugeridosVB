Imports System

Module Program
    Sub Main(args As String())
        Dim dia, mes, año As Integer
        Console.Write("Ingrese el Día: ")
        dia = CInt(Console.ReadLine)
        Console.Write("Ingrese el Mes: ")
        mes = CInt(Console.ReadLine)
        Console.Write("Ingrese el Año: ")
        año = CInt(Console.ReadLine)
        Console.WriteLine()
        FechaOk(dia, mes, año)
        Console.ReadLine()
    End Sub
    Sub FechaOk(ByVal dia As Integer, ByVal mes As Integer, ByVal año As Integer)
        Dim MaxDia As Integer
        Select Case mes
            Case 1, 3, 5, 7, 10, 12, 8
                MaxDia = 31
            Case 4, 6, 9, 11
                MaxDia = 30
            Case 2
                If año Mod 4 = 0 AndAlso año Mod 100 <> 0 Or año Mod 400 = 0 Then
                    MaxDia = 29
                Else
                    MaxDia = 28
                End If
            Case Else
                Console.WriteLine("Mes Incorrecto")
                Exit Sub
        End Select
        If dia > 0 And dia <= MaxDia And mes > 0 And mes < 13 And año > 0 Then
            Console.WriteLine("La Fecha Es Correcta")
        Else
            Console.WriteLine("La Fecha Es Incorrecta")
        End If
    End Sub
End Module
