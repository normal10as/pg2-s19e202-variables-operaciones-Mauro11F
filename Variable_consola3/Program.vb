Imports System

Module concatenacion
    Sub Main(args As String())
        Dim NombreEmpre As String
        Dim NombreCalle As String
        Dim AltuCalle As Integer
        Dim FechaIni As Date = #1990/04/28#

        NombreEmpre = "Y BUENO"
        NombreCalle = "Arriba16"
        AltuCalle = 234

        Console.WriteLine("Primera Forma (IMPLICITAMENTE)")
        Console.WriteLine(NombreEmpre & " " & NombreCalle & " " & AltuCalle & " " & FechaIni & vbLf) 'vblf es para salto de linea (\n)
        Console.WriteLine("Segunda Forma (EXPLICITAMENTE)")
        Console.WriteLine(NombreEmpre + " " + NombreCalle + " " + Convert.ToString(AltuCalle) + " " + Convert.ToString(FechaIni))

    End Sub
End Module
