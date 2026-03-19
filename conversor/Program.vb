Imports System

Module Program
    Sub Main(args As String())

        Dim julio As Double
        Dim resultado As Double

        Console.WriteLine("digite um valor")

        julio = Console.ReadLine()
       
       
        resultado = julio / 1024
        Console.writeLine("o valor do gb é " & resultado)

    End Sub
End Module
