Imports System
Enum TipoCuenta
    Corriente
    Ahorro
End Enum
Module Program
    Sub Main(args As String())
        Dim Cuenta As TipoCuenta
        Dim Cliente As String
        Dim Saldo As Integer
        Console.Write("Ingrese el Nombre del Cliente: ")
        Cliente = Console.ReadLine
        Console.Write("Ingrese el saldo de su Cuenta: ")
        Saldo = CInt(Console.ReadLine)
        If Saldo < 2500 Then
            Cuenta = TipoCuenta.Ahorro
        Else
            Cuenta = TipoCuenta.Corriente
        End If
        Console.WriteLine()
        Console.WriteLine("{0}{1}" + "*** DETALLE DE CUENTA DEL
CLIENTE ***")
        Console.WriteLine()
        Console.WriteLine("Cliente: {0}", Cliente)
        Console.WriteLine("El tipo de cuenta del cliente es: {0}", Cuenta)
        Console.WriteLine("El saldo de la cuenta del cliente es: {0}", Saldo)
        Console.ReadLine()
    End Sub
End Module
