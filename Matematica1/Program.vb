Imports System
Imports System.Math

'Crear un proyecto y un módulo llamado “Matematica1” 
'para ingresar un número por teclado y mostrar:    su 
'valor absoluto,   el resultado de elevarlo a la décima 
'potencia raíz cuadrada



Module Matematica_1

    Sub Main(args As String())

        Dim Valor1, Valor2 As Single
        Dim Valor10 As Single = 10
        Valor1 = Valor2 = 0

        Console.WriteLine("Ingrese un valor: ")
        Valor1 = Console.ReadLine()

        Valor2 = Abs(Valor1)
        Console.WriteLine("El valor absoluto del numero ingresado es: " & Valor2 & vbCrLf)

        Valor2 = Pow(Valor1, Valor10)
        Console.WriteLine("El resultado de elevarlo a decima potencia es: " & Valor2 & vbCrLf)

        Valor2 = Sqrt(Valor1)
        Console.WriteLine("Y el resultado de su raiz cuarada es: " & Valor2 & vbCrLf)

    End Sub
End Module
