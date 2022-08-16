Module Module1

    Sub Main()
        Dim ser

        Console.WriteLine("Escribe un ser vivo o vegetal")
        ser = CStr(Console.ReadLine())

        If ser = "gato" Or ser = "cerdo" Or ser = "perro" Then
            Console.WriteLine("Es un animal")
        ElseIf ser = "frijol" Or ser = "alberja" Or ser = "garbanzo" Then
            Console.WriteLine("es un vegetal")
        Else
            Console.WriteLine("No es ninguno")
        End If

        Console.ReadKey()

    End Sub

End Module
