Imports System

Module Resto_Divison

    Sub Main(args As String())

        Dim Valor1, Valor2 As Integer

        Valor1 = Valor2 = 0

        Console.WriteLine("Resto de un valor dividido por 2: " & vbCrLf)
        Console.WriteLine("Ingre un numero entero: ")
        Valor1 = Console.ReadLine()


        Valor2 = Valor1 Mod 2


        Console.WriteLine("El resto de la siguiente operacion: " & Valor1 & "/" & 2 & " es: " & Valor2 & vbCrLf)



    End Sub
End Module
