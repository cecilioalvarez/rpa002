Module Program_007
	Sub Main(args As String())

		Dim notas() As Decimal = {2, 4, 6, 8, 7, 10}


		Dim notaAlta As Integer = 0
		Dim contador As Integer = 0

		For contador To notas.Length - 1

			If notaAlta < notas(contador) Then
				notaAlta = notas(contador)
			End If

		Next
		Console.WriteLine("la nota mas alta es " & notaAlta)

	End Sub
End Module
