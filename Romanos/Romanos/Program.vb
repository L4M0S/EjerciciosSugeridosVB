Imports System

Module Program
    Sub Main(args As String())
        Dim N, u, d, c, m As Integer
        Dim Unidad() As String = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"}
        Dim Decena() As String = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"}
        Dim Centena() As String = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"}
        Dim Millar() As String = {"", "M", "MM", "MMM", "IV", "V", "VI", "VII", "VIII", "IX"}

        N = Console.ReadLine()
        u = N Mod 10
        d = Math.Floor(N / 10) Mod 10
        c = Math.Floor(N / 100) Mod 10
        m = Math.Floor(N / 1000) Mod 10

        If (N >= 1000) Then
            Console.WriteLine(Millar(m) + Centena(c) + Decena(d) + Unidad(u))
        Else
            If (N >= 100) Then
                Console.WriteLine(Centena(c) + Decena(d) + Unidad(u))
            Else
                If (N >= 10) Then
                    Console.WriteLine(Decena(d) + Unidad(u))
                Else
                    Console.WriteLine(Unidad(N))
                End If
            End If
        End If

        Console.ReadLine()
    End Sub
End Module
