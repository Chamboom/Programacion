Module Ejercicio6
    Sub Main()
        Dim X, M, I As Integer

        Console.WriteLine("Este programa calcula la tabla de multiplicar de X número ")
        Console.Write("Cual es el numero X? ")
        X = Console.ReadLine()
        I = 0


        Do While I < 10
            I = I + 1
            M = X * I

            Console.WriteLine("                           {0}", M)
        Loop


        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()
    End Sub

End Module
