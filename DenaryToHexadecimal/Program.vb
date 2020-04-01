Imports System

Module Program

    Function Hexadecimal(num As Integer) As String

        Dim hexTable As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
        Dim hex As String = ""

        For i As Integer = 0 To 15
            If i < 10 Then
                hexTable.Add(i, Str(i))
            Else
                hexTable.Add(i, Chr(i + 55))
            End If
        Next

        If num = 0 Then
            Return "0"
        End If

        While num > 0
            hex += hexTable.Item(num Mod 16)
            num \= 16
        End While

        Return String.Join("", hex.Split(" "))

    End Function

    Sub Main(args As String())
        For i As Integer = 0 To 255
            Console.WriteLine("{0} : {1}", i, Hexadecimal(i))
        Next
    End Sub
End Module
