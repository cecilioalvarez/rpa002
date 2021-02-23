Imports System

Module Program
    Sub Main(args As String())

        ' array o lista de notas y el tamaño del array
        Dim notas(3) As Decimal

        notas(0) = 7
        notas(1) = 4
        notas(2) = 8

        For numero As Integer = 0 To 2

            Console.WriteLine(notas(numero))

        Next

        Console.WriteLine("***********************")

        ' recorro todos
        For numero As Integer = 0 To 2
            ' segundo al recorrer comparo las notas y valoro
            If notas(numero) >= 5 Then
                Console.WriteLine(notas(numero))
            End If

        Next



    End Sub
End Module
