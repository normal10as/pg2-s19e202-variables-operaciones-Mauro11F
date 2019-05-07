Imports System
Imports System.Math


Module Redondeo

    Sub Main(args As String())

        Dim A As Single = 0

        Console.WriteLine("Ingrese un numero: ")
        A = Console.ReadLine()

        Console.WriteLine("Metodo Ceiling (Redondea siempre hacia arriba): " & Ceiling(A))

        Console.WriteLine("Metodo Round (Redondea hacia el valor mas sercano): " & Round(A))

        Console.WriteLine("Metodo Floor (Redondea siempre hacia abajo): " & Floor(A))

    End Sub
End Module
