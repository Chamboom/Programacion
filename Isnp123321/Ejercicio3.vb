Module Ejercicio3

    Sub Main()

        Dim monto, total, descuento As Double


        Console.WriteLine("Ingrese el monto de compra: ")
        monto = Console.ReadLine()

        If monto >= 1000 Then

            total = monto - (monto * 0.3)
            descuento = monto * 0.3
            Console.WriteLine("El monto ingresado es: {0:C2}", monto)
            Console.WriteLine("El descuento es: 30%")
            Console.WriteLine("Usted ahorro: {0:C2}", descuento)
            Console.WriteLine("El total a pagar es: {0:C2}", total)


        ElseIf monto >= 500 And monto < 1000 Then

            total = monto - (monto * 0.2)
            descuento = monto * 0.2
            Console.WriteLine("El monto in gresado es: {0:C2}", monto)
            Console.WriteLine("El descuento es: 20%")
            Console.WriteLine("Usted ahorro: {0:C2}", descuento)
            Console.WriteLine("El total a pagar es: {0:C2}", total)


        ElseIf monto >= 250 And monto < 5000 Then

            total = monto - (monto * 0.1)
            descuento = monto * 0.1
            Console.WriteLine("El monto ingresado es: {0:C2}", monto)
            Console.WriteLine("El descuento es: 10%")
            Console.WriteLine("Usted ahorro: {0:C2}", descuento)
            Console.WriteLine("Usted ahorro: {0:C2}", descuento)
            Console.WriteLine("El total a pagar es: {0:C2}", total)


        Else

            total = monto - (monto * 0.05)
            descuento = monto * 0.05
            Console.WriteLine("El monto a pagar es: {0:C2}", monto)
            Console.WriteLine("El descuento es: 5%")
            Console.WriteLine("Usted ahorro: {0:C2}", descuento)
            Console.WriteLine("El total a pagar es: {0:C2}", total)



        End If

        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()
    End Sub

End Module
