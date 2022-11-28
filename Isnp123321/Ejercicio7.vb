Module Ejercicio7
    Sub Main()
        Console.Write("Ingrese ahorro mensual: ")
        Dim ahorro As Double = Convert.ToDouble(Console.ReadLine())
        Dim meses = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        Dim total As Double = ahorro

        For Each mesActual As String In meses
            Console.WriteLine("{0} ${1}", mesActual, total)
            total += ahorro
        Next
        Console.WriteLine("Total de ahorro en el año: {0:C}", total * 6)

        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()

    End Sub

End Module
