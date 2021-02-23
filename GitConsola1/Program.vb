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
'Bucle Nuevo

Imports System

Module Program
    Sub Main(args As String())
        Console.writeline("introduce indice")
        Dim numero As Integer = 0
        Do While numero < 10
            Console.WriteLine(numero)
            numero = numero + 1
        Loop
        'suma de varios elementos
        Dim suma As Decimal
        Dim indice As Integer

        Do While indice < 10
            indice = indice + 1
            suma = indice + suma
        Loop
        Console.WriteLine(suma)

        'forma de hacer paquetes
        Dim notas(3) As Decimal
        notas(0) = 7
        notas(1) = 4
        notas(2) = 3
        Console.WriteLine(notas(0))
        Console.WriteLine(notas(1))
        Console.WriteLine(notas(2))
        'otra forma de hacer paquetes: Dim strings() As String = {"abc", "def", "ghi"}
        'en el strings() no hace falta poner numero
        'aplicar a los pack un bucle for
        Dim paquete(3) As Integer
        paquete(0) = 8
        paquete(1) = 2
        paquete(2) = 1
        For numero As Integer = 0 To 2
            Console.WriteLine(paquete(numero))
        Next
        'imprimir notas aprovadas
        Dim examen(10) As Integer
        examen(0) = 5
        examen(1) = 3
        examen(2) = 2
        examen(3) = 8
        examen(4) = 4
        examen(5) = 6
        examen(6) = 7
        examen(7) = 9
        examen(8) = 2
        examen(9) = 1
        For resultado As Integer = 0 To 10
            If examen(resultado) > 5 Then
                Console.WriteLine("has aprovado " & examen(resultado))
            End If
        Next

    End Sub
End Module
