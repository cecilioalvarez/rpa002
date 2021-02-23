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

        Dim guardada As Integer = 0
        ' el array o lista siempre tiene una propiedad de longitud
        For numero As Integer = 0 To nota.Length - 1

            If (nota(numero) > guardada) Then
                guardada = nota(numero)
            End If

        Next
        Console.WriteLine(guardada)







    End Sub
End Module
