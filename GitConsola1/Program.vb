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
        Console.WriteLine("hola amaia")


        For contador = 1 To 10
            Console.WriteLine(contador)
        Next

        For contador = 0 To 10 Step 2
            Console.WriteLine(contador)
        Next

        Console.WriteLine("hola")

        For comensal = 1 To 4 Step 2
            Console.WriteLine(comensal)
            Console.WriteLine("pareja admitida")
            Console.WriteLine("**************")
        Next


    End Sub
End Module

