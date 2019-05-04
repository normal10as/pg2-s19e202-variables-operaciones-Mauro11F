Imports System

Module variables_tipos
    Sub Main(args As String())

        Dim NomPer As String
        Dim NumDocu As UInteger
        Dim LugarNaci As String
        Dim FechaNaci As Date = #8/13/2002#
        Dim AltuCorp As UShort
        Dim Argen As Boolean
        Dim TemAmbiente As SByte
        Dim NomCalle As String
        Dim AltuCalle As Integer
        Dim DistanciaCiudad As Integer
        Dim ProfMar As Integer
        Dim Habitantes As UInteger
        Dim PesoProducto As UShort
        Dim MontoProducto As Integer

        NomPer = "Paolo"
        NumDocu = 38687403
        LugarNaci = "Argentina"
        AltuCorp = 232
        Argen = True
        TemAmbiente = 30
        NomCalle = "Poraca13"
        AltuCalle = 250
        DistanciaCiudad = 5834
        ProfMar = 3900
        Habitantes = 44278000
        PesoProducto = 50
        MontoProducto = 500

        Console.WriteLine("Nombre de Persona: " & NomPer)
        Console.WriteLine("Su numero de documento es: " & NumDocu)
        Console.WriteLine("Lugar de nacimiento: " & LugarNaci)
        Console.WriteLine("Altura Corporal: " & AltuCorp)
        Console.WriteLine("Es argentino ? " & Argen)
        Console.WriteLine("Temperatura Ambiente: " & TemAmbiente)
        Console.WriteLine("Nombre de Calle : " & NomCalle)
        Console.WriteLine("Altura de la calle: " & AltuCalle)
        Console.WriteLine("La distancia entre Nueva York y Paris es de: " & DistanciaCiudad & "Km")
        Console.WriteLine("La Profundidad promedio del Mar es de: " & ProfMar)
        Console.WriteLine("El peso de una bolsa de harina es de: " & PesoProducto & "Kg")
        Console.WriteLine("El monto del mismo es de: " & MontoProducto)

    End Sub
End Module
