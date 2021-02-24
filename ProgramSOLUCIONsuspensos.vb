Imports System

Module Program1
    Sub Main(args As String())

        Dim lista() As Decimal = {3, 4, 2, 8, 9.5, 7, 10}
        'array con posiciones booleanas
        Dim posiciones(lista.Length - 1) As Boolean

        For i = 0 To lista.Length - 1
            'la nota es un suspenso
            If lista(i) < 5 Then
                'en la posicion i que tengo un false pon true
                posiciones(i) = True
            End If
        Next
        Dim numerosuspensos As Integer

        For i = 0 To posiciones.Length - 1
            If posiciones(i) Then
                numerosuspensos = numerosuspensos + 1
                Console.WriteLine(lista(i))
            End If
        Next
        Console.WriteLine("han suspendido" & numerosuspensos)
        End If

    End Sub
End Module
