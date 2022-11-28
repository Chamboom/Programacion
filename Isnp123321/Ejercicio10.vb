Module Ejercicio10
    Sub Main()
        Dim nombres(4) As String
        Dim horas(4) As Integer
        Dim salariohora(4) As Double

        Dim contador = 0

        While contador < 5
            Console.Write("Nombre del empleado {0}: ", contador)
            nombres(contador) = Console.ReadLine()

            Console.Write("Horas del empleado {0}: ", contador)
            horas(contador) = Console.ReadLine()

            Console.Write("Salario por hora {0}: ", contador)
            salariohora(contador) = Console.ReadLine()

            Console.WriteLine("Salario semanal: {0:C2} " &, horas(contador) * salariohora(contador))
            contador = contador + 1

        End While



        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()
    End Sub
End Module
