Imports System

Module suma_promedio

    Sub Main(args As String())

        Dim a, b, c, d As Integer
        Dim x As Single

        a = b = c = d = 0
        x = 0

        Console.WriteLine("Ingrese un Numero entero: ")
        a = Console.ReadLine()

        Console.WriteLine("Ingrese un Numero entero: ")
        b = Console.ReadLine()

        Console.WriteLine("Ingrese un Numero entero: ")
        c = Console.ReadLine()

        Console.WriteLine("Ingrese un Numero entero: ")
        d = Console.ReadLine()

        a = a + b + c + d
        x = a / 4

        Console.WriteLine("La sumatoria de los numeros es: " & a)
        Console.WriteLine("El promedio de dichos numeros es igual a: " & x)

    End Sub
End Module
