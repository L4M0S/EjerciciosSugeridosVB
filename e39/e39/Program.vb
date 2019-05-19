Imports System

Module Program
    Sub Main(args As String())
        MostrarEmpleado(32, 25000.0)
        Console.ReadLine()
    End Sub
    Sub MostrarEmpleado(ByVal Edad As Integer, ByVal Salario As Double)
        Console.WriteLine("El Empleado Tiene {0}{1}", Edad, " años")
        Console.WriteLine("El Empleado Gana $ {0}", Salario)
    End Sub

End Module
