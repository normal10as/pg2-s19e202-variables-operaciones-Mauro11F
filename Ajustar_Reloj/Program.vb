Imports System

Imports System.DateTime

Imports System.String

'Crear un proyecto y un módulo llamado “Ajustar_reloj” 
'que lea separadamente un número de día (1 a 31) y una hora (0 a 24). 
'Con esos valores crea una variable de tipo Date usando el mes y año actual y mostrarla

Module Ajustar_Reloj

    Sub Main(args As String())

        Dim dia, hora As Date

        Console.WriteLine("Ingrese un dia (1 al 31): ")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese una hora (0 al 24): ")
        hora = Console.ReadLine()

        Console.WriteLine("Con el dia ingresado: {0}/{1}/{2}", dia, Now.Month, Now.Year)

        Console.WriteLine("Con la hora ingresada: {0}:{1}:{2}", hora, Now.Minute, Now.Second)


    End Sub
End Module
