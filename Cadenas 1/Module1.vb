Module Cadenas_1
    Sub Main()

        Dim frase, a, o As String
        a = "a"
        o = "o"

        Console.WriteLine("Ingre una cadena de texto: ")
        frase = Console.ReadLine()

        Console.WriteLine(vbCrLf & "La primer {0} de: {1} se encunetra en la posion : {2} ", a, frase, InStr(1, frase, a, CompareMethod.Text))

        Console.WriteLine("La primer {0} de: {1} se encunetra en la posion : {2} ", o, frase, InStr(1, frase, o, CompareMethod.Text))

        Console.WriteLine("La frase sin cambios:( {0}) -invertida- ( {1})", frase, StrReverse(frase))
    End Sub

End Module
