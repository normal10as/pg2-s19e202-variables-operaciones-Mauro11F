Imports System


'Crear un proyecto y un módulo llamado “días” 
'utilizando una enumeración para los días 
'de la semana en español, mostrar que día que 
'corresponde al resultado

Module Dias

    Enum SemanaDias

        Domingo = 1

        Lunes

        Martes

        Miercoles

        Jueves

        Viernes

        Sabado

    End Enum

    Sub Main(args As String())

        Console.WriteLine("{0} su valor: {1}", SemanaDias.Domingo.ToString, SemanaDias.Domingo.GetHashCode)

        Console.WriteLine("{0} su valor: {1}", SemanaDias.Lunes.ToString, SemanaDias.Lunes.GetHashCode)

        Console.WriteLine("{0} su valor: {1}", SemanaDias.Martes.ToString, SemanaDias.Martes.GetHashCode)

        Console.WriteLine("{0} su valor: {1}", SemanaDias.Miercoles.ToString, SemanaDias.Miercoles.GetHashCode)

        Console.WriteLine("{0} su valor: {1}", SemanaDias.Jueves.ToString, SemanaDias.Jueves.GetHashCode)

        Console.WriteLine("{0} su valor: {1}", SemanaDias.Viernes.ToString, SemanaDias.Viernes.GetHashCode)

        Console.WriteLine("{0} su valor: {1}", SemanaDias.Sabado.ToString, SemanaDias.Sabado.GetHashCode)

    End Sub

End Module
