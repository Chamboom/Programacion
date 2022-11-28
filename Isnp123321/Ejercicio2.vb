Module Ejercicio2

    Sub Main()

        Console.WriteLine("Determinar si un numero es negativo o positivo")
        Dim numero As Double

        Console.WriteLine("Ingrese numero: ")
        numero = Console.ReadLine()

        If numero > 0 Then
            Console.WriteLine("El numero es positivo")
        ElseIf numero < 0 Then
            Console.WriteLine("El numero es negativo")

        ElseIf numero = 0 Then
            Console.WriteLine("El numero es cero")
        End If

        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()
    End Sub

End Module
