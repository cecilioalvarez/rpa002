Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("hola")
        Console.WriteLine("hola2")
        Console.WriteLine("hola3")
        Dim contador As Integer

        Console.WriteLine("***************")

        For contador = 1 To 5
            Console.WriteLine("hola")

        Next

        ' mas sencillo de vb.net
        ' bucle va de uno en uno
        For contador = 1 To 10
            Console.WriteLine(contador)
        Next
        ' este otro bucle va de dos en dos
        For contador = 0 To 10 Step 2
            Console.WriteLine(contador)

        Next
    End Sub
End Module
