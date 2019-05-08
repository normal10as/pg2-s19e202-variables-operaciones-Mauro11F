Module Refrase

    Sub Main()

        Dim cadena As String = "Aunque la cadena sea de oro, sirve para lo mismo."
        Dim texto1, texto2 As String


        Console.WriteLine("Ingrese una palabra: ")
        texto2 = Console.ReadLine()
        Console.WriteLine("Por cual de estas quiere sustituir?: " & cadena)
        texto1 = Console.ReadLine()


        Console.WriteLine("Su nueva cadena: " & Replace(cadena, texto1, texto2))

    End Sub

End Module
