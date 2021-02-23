Imports System

Module Program
    Sub Main(args As String())

        'array o lista de notas y el tamaño del array
        Dim notas(3) As Decimal

        notas(0) = 3
        notas(1) = 6
        notas(2) = 9
        Console.WriteLine("los aprovados")

        For numero As Integer = 0 To 2
            If notas(numero) >= 5 Then
                Console.WriteLine(notas(numero))
            End If
        Next
        Dim guardada As Integer = 0
        'el array o lista siempre tiene una propiedad de longitud
        For numero As Integer = 0 To notas.Length - 1
            If (notas(numero) > guardada) Then
                guardada = notas(numero)
            End If

        Next
        Console.WriteLine(guardada)

        Dim misnotas() As Decimal = {4.5, 2.2, 7.2, 8.4}
        Dim notaguardada as decimal = 0.0
        Dim posicion As Integer = 0

        For numero As Integer = 0 To misnotas.Length - 1
            If (notaguardada < misnotas(numero)) Then
                notaguardada = misnotas(numero)
                posicion = numero
            End If

        Next
        Console.WriteLine("la nota mas alta es" & notaguardada)
        Console.WriteLine(posicion)


    End Sub
End Module
