Imports System

Module Program
    Sub Main(args As String())
        'Dim numero As Integer

        'For numero1 As Integer = 1 To 10
        '    Console.WriteLine(numero1 * 7)

        'Next

        'Dim numero As Integer = 0
        'numero = numero + 1
        'numero = numero + 2
        'numero = numero + 3
        'Console.WriteLine(numero)
        Dim bolsa As Integer = 0


        For numero As Integer = 0 To 10
            bolsa = bolsa + numero
            Console.WriteLine("la bolsa con iteracion: " & numero & " contiene " & bolsa)
        Next
        Console.WriteLine(bolsa)




    End Sub
End Module
