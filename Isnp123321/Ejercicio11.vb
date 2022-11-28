Module Ejercicio11
    Sub Main()
        Dim edad As Double
        Console.Write("Ingrese la edad: ")
        edad = Console.ReadLine()

        If edad < 18 Then

            Console.WriteLine("Falso")
        Else
            Console.Write("Verdadero")
        End If

        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()
    End Sub
End Module
