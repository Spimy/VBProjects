Imports System
Module Program

    'Sub PrintLine(Optional message As Object = "", Optional textColor As ConsoleColor = ConsoleColor.White)
    '    Console.ForegroundColor = textColor
    '    Console.WriteLine(message)
    'End Sub

    'Sub Print(message As String, Optional textColor As ConsoleColor = ConsoleColor.White)
    '    Console.ForegroundColor = textColor
    '    Console.Write(message)
    'End Sub

    Sub Print(str As String, ParamArray args() As Object)

        Dim startCount As Integer = 1
        Dim endCount As Integer = -2

        If args.Length > 0 And TypeOf args(0) IsNot ConsoleColor Then startCount = 0
        If args.Length > 0 And TypeOf args(args.Length - 1) IsNot ConsoleColor Then endCount = -1

        If startCount = 1 Then Console.ForegroundColor = args(0)
        If endCount = -2 Then Console.ForegroundColor = args(args.Length - 1)

        Select Case args.Length
            Case 0 : Console.Write(str)
            Case > 0

                For i As Integer = startCount To args.Length + endCount
                    If TypeOf args(i) Is ConsoleColor Then
                        Throw New Exception("Color should not be in middle of ParramArray. It should be at the start or end of the ParamArray.")
                    End If

                    str = str.Replace("{" + (i - startCount).ToString + "}", args(i))
                Next

                Console.Write(str)

        End Select

    End Sub

    Sub PrintLine(ParamArray args() As Object)

        Dim startCount As Integer = 2
        Dim endCount As Integer = -2

        If args.Length = 0 Then
            Console.WriteLine()
        Else

            If args.Length > 1 And TypeOf args(1) IsNot ConsoleColor Then startCount = 1
            If args.Length > 1 And TypeOf args(args.Length - 1) IsNot ConsoleColor Then endCount = -1

            If startCount = 2 Then Console.ForegroundColor = args(1)
            If endCount = -2 Then Console.ForegroundColor = args(args.Length - 1)

            Select Case args.Length
                Case 0 : Console.WriteLine()
                Case 1 : Console.WriteLine(args(0))
                Case > 1

                    If TypeOf args(0) IsNot String Then
                        Throw New Exception("First argument should be a string!")
                    End If

                    For i As Integer = startCount To args.Length + endCount
                        If TypeOf args(i) Is ConsoleColor Then
                            Throw New Exception("Color should not be in middle of ParramArray. It should be at the start or end of the ParamArray.")
                        End If

                        args(0) = args(0).ToString().Replace("{" + (i - startCount).ToString() + "}", args(i))
                    Next

                    Console.WriteLine(args(0))

            End Select

        End If

    End Sub

    Function Input(Optional message As String = "", Optional textColor As ConsoleColor = ConsoleColor.White) As String
        Print(message, textColor)
        Return Console.ReadLine
    End Function

    Sub Main()

        Dim name As String = Input("What's your name?: ", ConsoleColor.Yellow)
        PrintLine("Hello there {0}!", ConsoleColor.Green, name)

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
        PrintLine("You are now registered as {0} of age {1}.", name, age, ConsoleColor.Green)

        PrintLine()

        Print("Your name is {0} at the age of {1}.", name, age, ConsoleColor.DarkCyan)

        Console.ReadKey()

    End Sub

End Module
