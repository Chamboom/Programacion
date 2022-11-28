Module Ejercicio9
    Sub Main()

        Console.WriteLine("Promedio de notas")
        Dim a, b, c, d, e, f, p As Single

        Console.Write("Ingrese calificacion 1: ")
        a = Console.ReadLine()
        Console.Write("Ingrese calificacion 2: ")
        b = Console.ReadLine()
        Console.Write("Ingrese calificacion 3: ")
        c = Console.ReadLine()
        Console.Write("Ingrese calificacion 4: ")
        d = Console.ReadLine()
        Console.Write("Ingrese calificacion 5: ")
        e = Console.ReadLine()
        Console.Write("Ingrese calificacion 6: ")
        f = Console.ReadLine()
        p = ((a + b + c + d + e + f) / 6)

        Console.WriteLine("Su Promedio es: {0}", p)
        If p >= 6 Then
            Console.WriteLine("Usted aprobó la clase")
        Else
            Console.WriteLine("Usted reprobó la clase")

        End If
        If a >= b And a > c And a > d And a > e And a > f Then
            Console.WriteLine("La nota mayor es: {0}", a)
        End If
        If b > a And b > c And b >= d And b >= e And b >= f Then
            Console.WriteLine("La nota mayor es: {0}", b)
        End If
        If c >= a And c >= b And c >= d And c > e And c > f Then
            Console.WriteLine("La nota mayor es: {0}", c)
        End If
        If d >= a And d >= b And d > c And d >= e And d > f Then
            Console.WriteLine("La nota mayor es: {0}", d)
        End If
        If e >= a And e >= b And e > c And e > d And e >= f Then
            Console.WriteLine("La nota mayor es: {0}", e)
        End If
        If f >= a And f >= b And f >= c And f >= d And f >= e Then
            Console.WriteLine("La nota mayor es: {0}", f)
        End If


        If a <= b And a < c And a < d And a < e And a < f Then
            Console.WriteLine("La nota menor es: {0}", a)
        End If
        If b < a And b < c And b <= d And b <= e And b <= f Then
            Console.WriteLine("La nota menor es: {0}", b)
        End If
        If c <= a And c <= b And c <= d And c <= e And c < f Then
            Console.WriteLine("La nota menor es: {0}", c)
        End If
        If d <= a And d <= b And d < c And d <= e And d < f Then
            Console.WriteLine("La nota menor es: {0}", d)
        End If
        If e <= a And e <= b And e < c And e < d And e <= f Then
            Console.WriteLine("La nota menor es: {0}", e)
        End If
        If f <= a And f <= b And f <= c And f <= d And f < e Then
            Console.WriteLine("La nota menor es: {0}", f)
        End If
        Console.WriteLine("Presione Enter para salir")
        Console.ReadLine()


    End Sub


End Module
