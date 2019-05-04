Imports System

Module Aritmetica
    Sub Main(args As String())
        Dim A, B As Integer
        Dim C, D As Single
        Dim E As Integer
        Dim F As Single

        A = 10
        B = 2
        C = 2.3
        D = 5.3

        E = 0
        F = 0.0

        E = A + B
        Console.WriteLine("Suma de ENTERO con ENTERO: " & A & "+" & B & "=" & E)
        F = B + C
        Console.WriteLine("Suma de ENTERO con FLOTANTE: " & B & "+" & C & "=" & F)
        F = C + D
        Console.WriteLine("Suma de FLOTANTE con FLOTANTE: " & C & "+" & D & "=" & F & vbLf)

        E = A - B
        Console.WriteLine("Resta de FLOTANTE con FLOTANTE: " & A & "-" & B & "=" & E)
        F = B - C
        Console.WriteLine("Resta de FLOTANTE con FLOTANTE: " & B & "-" & C & "=" & F)
        F = C - D
        Console.WriteLine("Resta de FLOTANTE con FLOTANTE: " & C & "-" & D & "=" & F & vbLf)

        E = A / B
        Console.WriteLine("Division de FLOTANTE con FLOTANTE: " & A & "/" & B & "=" & E)
        F = B / C
        Console.WriteLine("Division de FLOTANTE con FLOTANTE: " & B & "/" & C & "=" & F)
        F = C / D
        Console.WriteLine("Division de FLOTANTE con FLOTANTE: " & C & "/" & D & "=" & F & vbLf)

        E = A * B
        Console.WriteLine("Multiplicacion de FLOTANTE con FLOTANTE: " & A & "*" & B & "=" & E)
        F = B * C
        Console.WriteLine("Multiplicacion de FLOTANTE con FLOTANTE: " & B & "*" & C & "=" & F)
        F = C * D
        Console.WriteLine("Multiplicacion de FLOTANTE con FLOTANTE: " & C & "*" & D & "=" & F)
    End Sub
End Module
