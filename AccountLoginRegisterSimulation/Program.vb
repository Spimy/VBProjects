Imports System

Module Program

    Dim RegisteredUser As New Dictionary(Of String, String)

    Sub Register()

        Dim username As String = ""
        Dim password As String = ""
        Dim checkpass As String = ""

        Console.Clear()
        Console.WriteLine("-= Register Your Account =-")

        Console.WriteLine()

        Console.Write("Enter your username: ")
        username = Console.ReadLine

        While RegisteredUser.ContainsKey(username)
            Console.Write("Username already exists. Enter your username: ")
            username = Console.ReadLine
        End While

        Console.WriteLine()

        While Len(password) < 8
            Console.Write("Enter your password (must be at least 8 characters): ")
            password = Console.ReadLine
        End While

        Console.WriteLine()

        While checkpass <> password
            Console.Write("ReEnter your password: ")
            checkpass = Console.ReadLine
        End While

        Console.WriteLine()

        RegisteredUser.Add(username, checkpass)
        Console.WriteLine("New username registered!")

        Console.WriteLine("Hit Enter to go back to the menu...")
        Console.ReadKey()
        Menu()

    End Sub

    Sub Login()

        Dim found As Boolean = False
        Dim username As String = ""
        Dim password As String = ""
        Dim account As KeyValuePair(Of String, String)

        Console.Clear()

        If RegisteredUser.Count < 1 Then
            Console.WriteLine("There are currently no user created!")
            Console.WriteLine("Hit Enter to go back to the menu...")
            Console.ReadKey()
            Menu()
        End If

        Console.WriteLine("-= Log Into Your Account =- ")

        For tries As Integer = 1 To 3

            Console.Write("[{0}] Username: ", tries)
            username = Console.ReadLine

            Console.Write("[{0}] Password: ", tries)
            password = Console.ReadLine

            account = New KeyValuePair(Of String, String)(username, password)

            If RegisteredUser.Contains(account) Then
                found = True
                Exit For
            End If

            Console.WriteLine()

        Next

        If Not found Then
            Register()
        Else
            LoggedOnScreen(username)
        End If

    End Sub


    Sub LoggedOnScreen(username As String)

        Console.Clear()
        Console.WriteLine("Hello, {0}!", username)

        Console.WriteLine("Hit enter to log out...")
        Console.ReadKey()

        Menu()

    End Sub

    Sub Menu()

        Dim input As Integer

        Console.Clear()

        Console.WriteLine("-= Register / Login =-")
        Console.WriteLine("1. Register")
        Console.WriteLine("2. Login")
        Console.WriteLine("3. Quit")

        While True
            Console.Write("Option: ")
            Try
                input = Console.ReadLine
                Exit While
            Catch ex As InvalidCastException
                Menu()
            End Try
        End While

        Select Case input
            Case 1 : Register()
            Case 2 : Login()
            Case 3 : Exit Select
            Case Else : Menu()
        End Select

    End Sub


    Sub Main(args As String())
        Menu()
    End Sub
End Module
