Module Ejercicio8
    Sub Main()
        Console.Write("Ingrese depósito mensual: ")
        Dim dM As Double = Convert.ToDouble(Console.ReadLine())
        Dim dA As Single = dM * 12
        Console.Write("Ingrese la cantidad de años: ")
        Dim cA As Double = Convert.ToDouble(Console.ReadLine())
        Dim interes As Double = 0.15
        For i = 1 To cA
            Dim aumento = dA * interes
            dA += aumento
            Console.WriteLine("Año {0} inversión final: {1}", i, dA)
        Next
        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()
    End Sub
End Module
