Imports System

Module Program1
    Sub Main(args As String())

        Dim lista() As Decimal = {3, 8, 9.5, 7, 10}
        Dim posiciones(lista.Length - 1) As Boolean
        Dim haysuspensos As Boolean = False

        For i = 0 To posiciones.Length - 1
            If posiciones(i) Then
                Console.WriteLine(lista(i))
            End If
        Next

        For i = 0 To lista.Length - 1
            If lista(i) < 5 Then
                haysuspensos = True
                posiciones = i
            End If
        Next
        If haysuspensos Then
            Console.WriteLine("hay suspensos" & (lista(posiciones))
        End If

    End Sub
End Module
