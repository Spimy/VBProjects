Imports System

Module Program

    Class Maths
        Public Function Addition(ParamArray nums() As Double) As Double

            Dim sum As Double = 0

            If nums.Length < 1 Then
                Throw New ArgumentNullException
            End If

            For index As Integer = 0 To nums.Length - 1
                sum += nums(index)
            Next

            Return sum

        End Function

        Public Function Subtraction(start As Double, ParamArray nums() As Double) As Double

            If nums.Length < 1 Then
                Throw New ArgumentNullException
            End If

            For index As Integer = 0 To nums.Length - 1
                start -= nums(index)
            Next

            Return start

        End Function

        Public Function Multiplication(start As Double, ParamArray nums() As Double) As Double

            If nums.Length < 1 Then
                Throw New ArgumentNullException
            End If

            For index As Integer = 0 To nums.Length - 1
                start *= nums(index)
            Next

            Return start

        End Function

        Public Function Division(start As Double, ParamArray nums() As Double) As Double

            If nums.Length < 1 Then
                Throw New ArgumentNullException
            End If

            For index As Integer = 0 To nums.Length - 1
                start /= nums(index)
            Next

            Return start

        End Function

        Public Function Power(base As Double, exp As Double) As Double

            Dim ans As Double = base

            For i As Integer = 1 To exp - 1
                ans = ans * base
            Next

            Return ans

        End Function

    End Class

    Sub Main()

        Dim Math As Maths = New Maths()
        Console.WriteLine(Math.Addition(5, 5, 10, 100))
        Console.WriteLine(Math.Subtraction(100, 10, 5, 5))
        Console.WriteLine(Math.Multiplication(5, 5, 10, 100))
        Console.WriteLine(Math.Division(100, 10, 5, 2))
        Console.WriteLine(Math.Power(2, 5))

        Console.ReadKey()

    End Sub
End Module
