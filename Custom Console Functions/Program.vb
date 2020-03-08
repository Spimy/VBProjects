Imports System
Module Program

    Sub PrintLine(Optional message As Object = "", Optional textColor As ConsoleColor = ConsoleColor.White)
        Console.ForegroundColor = textColor
        Console.WriteLine(message)
    End Sub

    Sub Print(message As String, Optional textColor As ConsoleColor = ConsoleColor.White)
        Console.ForegroundColor = textColor
        Console.Write(message)
    End Sub

    Function Input(Optional message As String = "", Optional textColor As ConsoleColor = ConsoleColor.White) As String
        Print(message, textColor)
        Return Console.ReadLine
    End Function

    Sub Main()

        Dim name As String = Input("What's your name?: ", ConsoleColor.Yellow)
        PrintLine("Hello there " + name + "!", ConsoleColor.Green)

        PrintLine()

        Dim age As Integer

        While age < 1 Or age > 150

            Try
                age = Input("How old are you?: ", ConsoleColor.Yellow)
            Catch ex As InvalidCastException
                PrintLine("You may only enter integers!", ConsoleColor.Red)
                PrintLine()
                Continue While
            End Try

            If age < 1 Or age > 150 Then
                PrintLine("Please enter a valid age!", ConsoleColor.Red)
                PrintLine()
            End If

        End While

        PrintLine("You are now registered as " + name + " of age" + Str(age) + ".", ConsoleColor.Green)

        Console.ReadKey()

    End Sub

End Module
