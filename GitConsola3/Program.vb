Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("introudce un numero")
        'leer el dato por la consola
        'Dim numero As Integer = Console.ReadLine()
        'For i As Integer = 0 To 10
        '    ' le uso en este bloque para generar la  multiplicacion
        '    Console.WriteLine(numero & "x" & i & "=" & (i * numero))

        'Next
        Dim indice As Integer = 0
        ' un bucle while 

        Do While indice < 10
            Console.WriteLine(indice)
            indice = indice + 1
        Loop

        Dim indice2 As Integer = 0

        ' es que este siempre se ejecuta la primera vez al menos
        Do
            Console.WriteLine("hola")
            ' incrementamos el indice 
            indice2 = indice2 + 1
            'hasta que el indice sea mayor 10
        Loop Until indice2 > 10


    End Sub
End Module
