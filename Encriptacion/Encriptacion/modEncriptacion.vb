Module modEncriptacion
    Function Encriptar(ByVal Strg, ByVal Password)
        Dim i As Integer, j As Integer

        Dim s As String
        Dim b As String

        Dim A1 As Integer, A2 As Integer, A3 As Integer, P
        j = 1
        For i = 1 To Len(Password)
            P = P & Asc(Mid(Password, i, 1))
        Next

        For i = 1 To Len(Strg)
            A1 = Asc(Mid(P, j, 1))
            j = j + 1 : If j > Len(P) Then j = 1
            A2 = Asc(Mid(Strg, i, 1))
            A3 = A1 Xor A2
            b = Hex(A3)
            If Len(b) < 2 Then b = "0" + b
            s = s + b
        Next
        Encriptar = s
    End Function

    Function DesEncriptar(ByVal Strg, ByVal Password)
        Dim i, j As Integer
        Dim b As String

        Dim s As Char

        Dim A1, A2, A3 As Integer
        Dim P As String
        j = 1
        For i = 1 To Len(Password)
            P = P & Asc(Mid(Password, i, 1))
        Next
        For i = 1 To Len(Strg) Step 2
            A1 = Asc(Mid(P, j, 1))
            j = j + 1 : If j > Len(P) Then j = 1
            b = Mid(Strg, i, 2)
            A3 = Val("&H" + b)
            A2 = A3 Xor A1
            s = s + Chr(A2)
        Next
        DesEncriptar = s
    End Function

End Module
