Imports System

Module Formula
    Sub Main(args As String())
        Dim A, B, C As SByte
        Dim X As Single

        A = 1
        B = 5
        C = 2

        X = 0.0

        Console.WriteLine("Resolviendo sieguiente ecuacion  X = (b^2 - 4*a*c)/(2*a)")

        X = (B ^ 2 - 4 * A * C) / (2 * A)

        Console.WriteLine("El valor de X es: " & X)

    End Sub
End Module
