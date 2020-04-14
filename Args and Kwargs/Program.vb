Imports System

Module Program
    
    ' Testing custom Exceptions by inherting the class
    '=================================================
    Class CustomException 
        Inherits Exception
    End Class

    Class EmptyException
        Inherits CustomException
    End Class
    '=================================================

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

        Addition(5, 10, 50, 100)
        Console.ReadKey()

    End Sub
End Module
