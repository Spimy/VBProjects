Imports System

Module Program

    Function isBit(chr As Char) As Boolean ' Check if the character is 0 or 1 and nothing else

        If chr = "1" Or chr = "0" Then
            Return True
        End If

        Return False

    End Function

    Function ReverseString(str As String) As String

        Dim revString As String = ""
        Dim character As Char

        For i As Integer = 0 To Len(str) - 1
            character = Mid(str, Len(str) - i, 1)
            revString += character
        Next

        Return revString

    End Function

    Function Denary(binary As String) As Integer

        Dim character As Char
        Dim binPos_results As New List(Of Integer)

        binary = ReverseString(binary)

        For i As Integer = 1 To Len(binary)

            character = Mid(binary, i, 1)
            If Not isBit(character) Then Throw New Exception("String entered not a binary!")
            If character = "1" Then binPos_results.Add(2 ^ (i - 1))

        Next

        Return binPos_results.Sum()

    End Function

    ' Taken from my Denary to Binary project to test binary to denary
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

    Sub Main(args As String())

        Dim bin As String

        For i As Integer = 0 To 255
            bin = Binary(i)
            Console.WriteLine("{0} -> {1}", bin, Denary(bin))
        Next

        Console.ReadKey()

    End Sub
End Module
