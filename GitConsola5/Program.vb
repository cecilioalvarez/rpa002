Imports System

Module Program
    Sub Main(args As String())

        'array o lista de notas y el tamaño del array
        Dim notas(3) As Decimal

        notas(0) = 7
        notas(1) = 4
        notas(2) = 8

        'For numero As Integer = 0 To 2
        '    Console.WriteLine(notas(numero))
        'Next


        'Console.WriteLine("*************")
        'For numero As Integer = 0 To 2
        '    'al recorrer comparo las notas y valoro
        '    If notas(numero) >= 5 Then
        '        Console.WriteLine(notas(numero))
        '    End If

        'Next


        Dim nota(3) As Integer
        nota(0) = 3
        nota(1) = 6
        nota(2) = 9
        'Console.WriteLine("los aprobados")
        'For numero As Integer = 0 To 2

        '    If nota(numero) >= 5 Then
        '        Console.WriteLine(nota(numero))
        '    End If


        'Next

        'Dim guardada As Integer = 0
        '' el array o lista siempre tiene una propiedad de longitud
        'For numero As Integer = 0 To nota.Length - 1

        '    If (nota(numero) > guardada) Then
        '        guardada = nota(numero)
        '    End If

        'Next
        'Console.WriteLine(guardada)

        Dim misNotas() As Decimal = {4.5, 2.2, 7.2, 8.4}
        ' guarda la ultima nota que hemos recorrido
        Dim notaGuardada As Decimal = 0.0
        Dim posicion As Integer = 0

        For numero As Integer = 0 To misNotas.Length - 1
            ' nota que esta en la posicion 0 (4,5)
            ' nota pasa a valer 4,5
            'nota pasa a valer 4,5
            'nota pasa a veler 7,2
            'nota pasa a veler 8,4
            If (notaGuardada < misNotas(numero)) Then

                notaGuardada = misNotas(numero)
                posicion = numero
            End If
            Console.WriteLine("la nota mas alta ahora es " & notaGuardada)
            Console.WriteLine(numero)

        Next







    End Sub
End Module
