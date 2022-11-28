Module Ejercicio1

    Sub Main()

        Dim edad As Integer

        Console.WriteLine("Cual es su edad: ")
        edad = Console.ReadLine()

        If edad >= 18 Then
            Console.WriteLine("Usted es mayor de edad y puede entrar")

        Else
            Console.WriteLine("Usted es menor de edad y no puede entrar")
        End If

        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()
    End Sub

End Module
