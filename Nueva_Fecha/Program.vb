Imports System

Imports System.DateTime

Imports System.String


Module Nueva_Fecha

    Sub Main(args As String())

        Dim fecha As Date
        Dim dias As Byte

        Console.WriteLine("Ingre se una fecha (dd/mm/aa): ")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese numeros de dias: ")
        dias = Console.ReadLine()


        Console.WriteLine("Fecha con dias sumados: " & fecha.AddDays(dias))


    End Sub
End Module
