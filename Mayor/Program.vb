Imports System
Imports System.Math


Module Mayor

    Sub Main(args As String())

        Dim Numero1, Numero2, Numero3 As Decimal

        Numero1 = 34
        Numero2 = -12.56
        Numero3 = 34.0045

        Console.WriteLine("El numero mayor de estos tres numeros: " & Numero1 & " ; " & Numero2 & " ; " & Numero3)

        Numero1 = Max(Numero1, Numero2)
        Numero1 = Max(Numero1, Numero3)

        Console.WriteLine("es: " & Numero1)

    End Sub
End Module
