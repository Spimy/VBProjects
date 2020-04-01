Imports System

Module Program
    Sub Main(args As String())

        Dim money As Integer = -1
        Dim currencies As List(Of Integer) = New List(Of Integer)({500, 200, 100})

        While money Mod 100 <> 0 Or money > 10000
            Console.WriteLine()
            Console.Write("Amount to Withdraw: ")
            money = Console.ReadLine
        End While

        Dim amount As Integer

        For Each currency As Integer In currencies
            amount = money \ currency
            money -= amount * currency
            Console.WriteLine("{0} ${1} bills", amount, currency)
        Next

        Console.ReadKey()

    End Sub
End Module
