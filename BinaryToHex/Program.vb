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

    Function Binary(num As Integer, Optional bits As Integer = 4) As String

        Dim bin As String = ""

        While num > 0
            If num Mod 2 = 1 Then bin += "1" Else bin += "0"
            num \= 2
        End While

        If Len(bin) > bits Then
            Throw New Exception("Number too big to be represented using " + Str(bits) + " bits!")
        End If

        While Len(bin) < bits
            bin += "0"
        End While

        Return ReverseString(bin)

    End Function

    Function Hexadecimal(bin As String) As String

        Dim hex As String = ""
        Dim hexTable As Dictionary(Of String, String) = New Dictionary(Of String, String)
        Dim i As Integer

        Dim binSections As List(Of String) = New List(Of String)

        For i = 0 To 15
            If i < 10 Then
                hexTable.Add(Binary(i, 4), Str(i))
            Else
                hexTable.Add(Binary(i, 4), Chr(i + 55))
            End If
        Next

        Dim currentBin As String = ""

        For i = 1 To Len(bin)

            currentBin += Mid(bin, i, 1)

            If Len(currentBin) = 4 Then
                binSections.Add(currentBin)
                currentBin = ""
            End If

        Next

        For i = 0 To binSections.Count - 1
            hex += hexTable.Item(binSections.Item(i))
        Next

        Return String.Join("", hex.Split(" "))

    End Function

    Sub Main(args As String())

        For i As Integer = 0 To 255
            Console.WriteLine("({0}) {1} : {2}", i, Binary(i, 8), Hexadecimal(Binary(i, 8)))
        Next

    End Sub
End Module
