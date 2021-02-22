Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("hola")
        Console.WriteLine("hola2")
        Console.WriteLine("hola3")
        Dim contador As Integer

        Console.WriteLine("***************")

        For contador = 1 To 5
            Console.WriteLine("hola")

        Next


        For contador = 1 To 10
            Console.WriteLine(contador)
        Next

        Console.WriteLine("rama de sergio")
Imports System

Module Program
    Sub Main(args As String())
        For contador = 1 To 5
            Console.WriteLine("hola")
        Next

        For contador = 1 To 10
            Console.WriteLine(contador)
        Next
        For contador = 0 To 10 Step 2
            Console.WriteLine(contador)
        Next
        'tabla de multiclicar del 7
        For numero1 = 1 To 10

        Next
        Console.WriteLine(numero1 * 7)

        'sumar 10 primeros numeros
        For suma = 0 To 9
            Console.WriteLine(suma + 1)
        Next

        'sumar numeros pares
        Dim sumapar As Integer = 2
        For numeropar As Integer = 0 To 10
            sumapar = sumapar + numeropar
        Next
        Console.WriteLine(sumapar)
                    'tabla de multiclicar con cualquier numero
        Dim numero As Decimal = Console.ReadLine()
        For multiclicacion = 1 To 10
            Console.WriteLine("multiclicación " & multiclicacion & "= " & numero * multiclicacion)

End Module

    End Sub
End Module
