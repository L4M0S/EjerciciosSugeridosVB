Imports System
Namespace Cliente
    Public Class Datos
        Public Function Cliente(ByVal Nombre As String, ByVal Apellidos As String) As String
            Return (Apellidos + ", " + Nombre)
        End Function
        Public Function Direccion(ByVal dir As String) As String
            Return dir
        End Function
        Public Function Telefono(ByVal telf As Integer) As String
            Return CStr(telf)
        End Function
        Public Function DNI(ByVal LE As Long) As String
            Return CStr(LE)
        End Function
    End Class
End Namespace

Namespace Cuenta
    Public Class Cuenta
        Public Dinero As Double
        Sub Saldo(ByVal Money As Double)
            Dinero = Money
        End Sub
        Public Function TipoCuenta() As String
            If Dinero < 2500 AndAlso Dinero > 0 Then
                Return ("Cuenta Ahorros")
            ElseIf Dinero >= 2500 Then
                Return ("Cuenta Credito")
            Else
                Return ("Error: No Existe Saldo Negativo")
            End If
        End Function
    End Class
End Namespace
Module Program
    Sub Main(args As String())
        Dim Datos As Cliente.Datos
        Dim DatoCuenta As Cuenta.Cuenta
        Dim Nombre, Apellidos, Direccion As String
        Dim Telefono, DNI As Integer
        Dim Monto As Double
        Datos = New Cliente.Datos
        DatoCuenta = New Cuenta.Cuenta
        Console.WriteLine()
        Console.WriteLine("{0} Nueva Cuenta")
        Console.WriteLine()
        Console.Write("Nombres del Cliente: ")
        Nombre = CStr(Console.ReadLine)
        Console.Write("Apellidos del Cliente: ")
        Apellidos = CStr(Console.ReadLine)
        Console.Write("Dirección del Cliente: ")
        Direccion = CStr(Console.ReadLine)
        Console.Write("Numero de DNI: ")
        DNI = CInt(Console.ReadLine)
        Console.Write("Numero Telefonico: ")
        Telefono = CInt(Console.ReadLine)
        Console.Write("Monto de Cuenta: ")
        Monto = CDbl(Console.ReadLine)
        Console.WriteLine()
        Console.WriteLine("Presione ENTER para ver el Detalle de la Cuenta")
        Console.ReadLine()
        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("{0}*** DETALLE DE CUENTA ***")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Cliente: {0}" + Datos.Cliente(Nombre, Apellidos))
        Console.WriteLine("Dirección: {0}" + Datos.Direccion(Direccion))
        Console.Write("DNI: {0}" + Datos.DNI(DNI))
        Console.WriteLine("{0}Teléfono: {1}" + Datos.Telefono(Telefono))
        DatoCuenta.Saldo(Monto)
        Console.WriteLine("Tipo de Cuenta: {0}" + DatoCuenta.TipoCuenta())
        Console.WriteLine("Saldo de Cuenta: {0}" + DatoCuenta.Dinero)
        Console.ReadLine()
    End Sub
End Module
