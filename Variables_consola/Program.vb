Imports System

Module Program
    Sub Main(args As String())
        Dim nombre As String
        Dim apellido As String
        Dim fecha As Date

        Console.WriteLine("Ingrese su nombre:")
        nombre = Console.ReadLine()
        Console.WriteLine("Ingrese su apellido:")
        apellido = Console.ReadLine()
        Console.WriteLine("Ingrese su fecha de nacimiento (formato: AAAA/MM/DD):")
        fecha = Console.ReadLine()

        Console.WriteLine(nombre & " " & apellido & " " & "nacio el: " & fecha)


    End Sub
End Module