Imports System

Module Program
    Sub Main(args As String())

        Dim misNotas() As Decimal = {4.5, 2.2, 7.2, 8.4}
        'media sumatorioNEllementos/total
        'conozco el total de elementos
        Console.WriteLine(misNotas.Length)

        Dim sumaTodos As Integer = 0
        '4 iteraciones

        For i As Integer = 0 To misNotas.Length - 1

            'Console.WriteLine(misNotas(i))
            sumaTodos = sumaTodos + misNotas(i)


        Next

        Console.WriteLine(sumaTodos / misNotas.Length)
        Console.WriteLine(Math.Round(sumaTodos / misNotas.Length))

    End Sub
End Module
