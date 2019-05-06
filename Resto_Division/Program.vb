Imports System

Module Resto_Divison

    Sub Main(args As String())

        Dim Valor1, Valor2, Valor3 As Integer

        Valor1 = Valor2 = Valor3 = 0

        Console.WriteLine("Quiere saber el resto de un numero?" & vbCrLf)
        Console.WriteLine("Ingre un numero entero: ")
        Valor1 = Console.ReadLine()
        Console.WriteLine("Ingrese por cuanto quiere dividirlo: ")
        Valor2 = Console.ReadLine()


        Valor3 = Valor1 Mod Valor2


        Console.WriteLine("El resto de la siguiente operacion: " & Valor1 & "/" & Valor2 & " es: " & Valor3 & vbCrLf)



    End Sub
End Module
