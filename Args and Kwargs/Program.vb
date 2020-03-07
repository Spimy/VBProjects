Imports System

Module Program

    Class CustomException
        Inherits Exception
    End Class

    Class EmptyException
        Inherits CustomException
    End Class

    Sub Addition(ParamArray nums() As Integer)

        Dim sum As Integer = 0

        If nums.Length < 1 Then
            Throw New EmptyException
        End If

        For i As Integer = 0 To nums.Length - 1
            sum += nums(i)
        Next

        Console.WriteLine(sum)

    End Sub

    Sub Main()

        Addition()
        Console.ReadKey()

    End Sub
End Module
