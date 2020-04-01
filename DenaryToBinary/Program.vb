Imports System
Module Program

    Function ReverseString(str As String) As String

        Dim revString As String = ""
        Dim character As Char

        For index As Integer = 0 To Len(str) - 1
            character = Mid(str, Len(str) - index, 1)
            revString += character
        Next

        Return revString

    End Function

    Function Binary(num As Integer) As String

        Dim bin As String = ""

        While num <> 0
            If num Mod 2 = 1 Then bin += "1" Else bin += "0"
            num \= 2
        End While

        While Len(bin) <> 8
            bin += "0"
        End While

        bin = ReverseString(bin)

        Return bin

    End Function

    Sub Main(args() As String)

        For i As Integer = 1 To 255
            Console.WriteLine("{0} : {1}", i, Binary(i))
        Next

        Console.ReadKey()
    End Sub
End Module
