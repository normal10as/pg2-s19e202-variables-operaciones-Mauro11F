Imports System
Imports System.DateTime

Imports System.String

Module Reloj

    Sub Main(args As String())

        Console.WriteLine("dia del año: " & Now.DayOfYear)

        Console.WriteLine("mes: " & Now.Month)

        Console.WriteLine("{0} hora/as y {1} minutos ", Now.Hour, Now.Minute)


    End Sub
End Module
