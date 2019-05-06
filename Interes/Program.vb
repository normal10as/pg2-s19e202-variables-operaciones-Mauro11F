Imports System

Module Interes

    Sub Main(args As String())

        Dim I, m, r, t As Single
        Console.WriteLine("Calculo de intereses" & vbCrLf)

        Console.WriteLine("Ingrese monto: m")
        m = Console.ReadLine()
        Console.WriteLine("Ingrese interes: r")
        r = Console.ReadLine()
        Console.WriteLine("Ingrese el tiempo: t")
        t = Console.ReadLine()


        I = (m * r * t) / (360 * 100)

        Console.WriteLine(vbCrLf & "Los intereses producidos son: " & I)


    End Sub
End Module
