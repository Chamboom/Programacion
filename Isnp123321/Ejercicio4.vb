Module Ejercicio4
    Sub Main()

        Dim edad, edad2 As Integer
        Dim poliza, poliza2, alcohol, alcohol2, lentes, lentes2, enfermedad, enfermedad2, total As Decimal

        Console.Write("Que tipo de poliza le gustaria, cobertura amplia (1) o daños a terceros (2): ")
        poliza = Console.ReadLine

        If poliza = 1 Then
            poliza2 = 500
        ElseIf poliza = 2 Then
            poliza2 = 250
        End If

        Console.Write("Cual es su edad: ")
        edad = Console.ReadLine()

        If edad >= 40 Then
            edad2 = (poliza2 * 0.2)

        Else
            edad2 = (poliza2 * 0.1)
        End If

        Console.Write("Consume Alcohol: Seleccione 1 para si, 2 para no: ")
        alcohol = Console.ReadLine()

        If alcohol = 1 Then
            alcohol2 = poliza2 * 0.1
        ElseIf alcohol = 2 Then
            alcohol2 = 0
        End If

        Console.Write("Utiliza Lentes?: Seleccione 1 para si, 2 para no: ")
        lentes = Console.ReadLine()
        If lentes = 1 Then
            lentes2 = poliza2 * 0.05
        ElseIf lentes = 2 Then
            lentes2 = 0
        End If

        Console.Write("Padece alguna enfermedad: Seleccione 1 para si, 2 para no: ")
        enfermedad = Console.ReadLine()
        If enfermedad = 1 Then
            enfermedad2 = poliza2 * 0.05
        ElseIf enfermedad = 2 Then
            enfermedad2 = 0
        End If

        total = poliza2 + edad2 + alcohol2 + lentes2 + enfermedad2

        Console.WriteLine("El total de su poliza es: {0:C2}", total)


        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()


    End Sub
End Module
