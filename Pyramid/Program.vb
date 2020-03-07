Imports System

Module Program

    Sub Pyramid(symbol As Char, lines As Integer, Optional inverse As Boolean = False)

        If Not inverse Then

            For i As Integer = 1 To lines
                Console.WriteLine(StrDup(lines - i, " ") + StrDup(i - 1, symbol) + StrDup(i, symbol))
            Next

        Else

            For i As Integer = lines To 1 Step -1
                Console.WriteLine(StrDup(lines - i, " ") + StrDup(i - 1, symbol) + StrDup(i, symbol))
            Next

        End If

    End Sub

    Sub Diamond(symbol As Char, lines As Integer)

        Pyramid(symbol, lines / 2, False)
        Pyramid(symbol, lines / 2, True)

    End Sub

    Sub Pyradmid2(symbol As Char, lines As Integer)

        For i As Integer = 1 To lines

            For j As Integer = 1 To lines - i
                Console.Write(" ")
            Next

            For j As Integer = 1 To i
                Console.Write(symbol)
            Next

            For j As Integer = 1 To i - 1
                Console.Write(symbol)
            Next

            Console.WriteLine()

        Next

    End Sub

    Sub Main()

        Pyramid("*", 20, True)
        Pyramid("*", 20, False)

        Diamond("*", 30)

        Pyradmid2("*", 20)
        Console.ReadKey()

    End Sub

End Module
