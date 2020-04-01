Imports System

Module Program

    Function Modulo(num As Integer, div As Integer) As Integer

        While num - div >= 0
            num -= div
        End While

        Return num
    End Function

    Sub Main(args As String())
        Console.WriteLine(Modulo(80, 12))
    End Sub
End Module
