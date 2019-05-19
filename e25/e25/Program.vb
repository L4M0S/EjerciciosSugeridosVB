Imports System

Module Program
    Sub Main(args As String())
        Dim l, semaf As String

        semaf = "V"
        While semaf = "V"
            l = Console.ReadLine()
            Select Case l
                Case "A" Or "a"
                    semaf = "R"
                Case "E" Or "e"
                    semaf = "R"
                Case "I" Or "i"
                    semaf = "R"
                Case "O" Or "o"
                    semaf = "R"
                Case "U" Or "u"
                    semaf = "R"
                Case Else
                    semaf = "V"
            End Select
        End While
        Console.ReadLine()
    End Sub
End Module
