Module Module1

    Sub Main()
        Dim a, b, c

        Console.WriteLine("Digite el primer numero")
        a = CInt(Console.ReadLine())
        Console.WriteLine("Digite el segundo numero")
        b = CInt(Console.ReadLine())

        c = a + b

        Console.WriteLine("la suma de " & a & " y " & b & " es " & c)
        Console.ReadLine()

    End Sub

End Module
