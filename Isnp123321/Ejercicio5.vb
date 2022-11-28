Module Ejercicio5
    Sub Main()
        Dim N, S, R As Integer

        Console.WriteLine("Este programa calcula la suma de los números naturales desde 1 hasta N: ")
        Console.Write("Cual es el numero N? ")
        N = Console.ReadLine()
        S = 1
        R = 0

        Do While S <= N
            R = R + S
            S = S + 1
        Loop

        Console.WriteLine("La suma de los números naturales desde 1 hasta N es: {0} ", R)

        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()
    End Sub

End Module
