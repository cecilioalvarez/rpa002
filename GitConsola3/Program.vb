Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("introudce un numero")
        Dim numero As Integer = Console.ReadLine()
        For i As Integer = 0 To 10

            Console.WriteLine(numero & "x" & i & "=" & (i * numero))

        Next


    End Sub
End Module
