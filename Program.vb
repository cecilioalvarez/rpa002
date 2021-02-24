Imports System

Module Program
    Sub Main(args As String())
        Dim lista1() As Integer = {5, 6, 7, 8}
        Dim lista2() As Integer = {9, 6, 11, 5}
        Dim lista3(4) As Integer
        'rellenar
        For numero1 As Integer = 0 To lista1.Length - 1

            lista3(numero1) = lista1(numero1) + lista2(numero1)

        Next
        'mostrar
        For numero1 As Integer = 0 To lista1.Length - 1

            Console.WriteLine(lista3(numero1))

        Next

        Console.WriteLine(lista3)

    End Sub

End Module
