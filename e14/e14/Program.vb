Imports System

Module Program
    Sub Main(args As String())
        Dim ne, er
        ne = Console.ReadLine()
        Select Case ne
            Case 1
                er = "I"
            Case 2
                er = "II"
            Case 3
                er = "III"
            Case 4
                er = "IV"
            Case 5
                er = "V"
            Case 6
                er = "VI"
            Case 7
                er = "VII"
            Case 8
                er = "VIII"
            Case 9
                er = "IX"
            Case 10
                er = "X"
        End Select
        Console.WriteLine(er)
        Console.ReadLine()
    End Sub
End Module
