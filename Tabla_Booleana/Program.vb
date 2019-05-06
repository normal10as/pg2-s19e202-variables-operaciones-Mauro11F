Imports System

Module Tabla_booleana

    Sub Main(args As String())

        Dim V, F As Boolean

        V = True
        F = False

        Console.WriteLine("Tablas de Verdad")
        Console.WriteLine("V = TRUE; F = FALSE" & vbCrLf)

        Console.WriteLine(".....Operador AND......")
        Console.WriteLine(".......................")
        Console.WriteLine("V AND V = " & (V And V))
        Console.WriteLine("V AND F = " & (V And F))
        Console.WriteLine("F AND V = " & (F And V))
        Console.WriteLine("F AND F = " & (F And F) & vbCrLf)

        Console.WriteLine(".....Operador NOT......")
        Console.WriteLine(".......................")
        Console.WriteLine("NOT V = " & (Not V))
        Console.WriteLine("NOT F = " & (Not F) & vbCrLf)

        Console.WriteLine(".....Operador OR......")
        Console.WriteLine(".......................")
        Console.WriteLine("V OR V = " & (V Or V))
        Console.WriteLine("V OR F = " & (V Or F))
        Console.WriteLine("F OR V = " & (F Or V))
        Console.WriteLine("F OR F = " & (F Or F) & vbCrLf)

        Console.WriteLine(".....Operador XOR......")
        Console.WriteLine(".......................")
        Console.WriteLine("V XOR V = " & (V Xor V))
        Console.WriteLine("V XOR F = " & (V Xor F))
        Console.WriteLine("F XOR V = " & (F Xor V))
        Console.WriteLine("F XOR F = " & (F Xor F) & vbCrLf)



    End Sub
End Module
