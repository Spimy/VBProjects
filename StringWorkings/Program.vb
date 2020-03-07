Imports System

Module Program

    Function IsLetter(character As Char) As Boolean

        Dim ascii As Integer = Asc(character)

        If ascii >= 65 And ascii <= 90 Then ' Check if character is letter (upper case)
            Return True
        ElseIf ascii >= (65 + 32) And ascii <= (90 + 32) Then ' Check if character is letter (lower case)
            Return True
        End If

        Return False ' Character is not a letter

    End Function

    Function IsDigit(character As Char) As Boolean

        Dim ascii As Integer = Asc(character)

        If ascii >= 48 And ascii <= 56 Then
            Return True
        End If

        Return False ' Character is not a digit

    End Function

    Function IsVowel(character As Char) As Boolean

        Select Case character
            Case "a", "e", "i", "o", "u" : Return True ' Vowel if lower case characters match
            Case "A", "E", "I", "O", "U" : Return True ' Vowel if upper case characters match
            Case Else : Exit Select ' Exit the select case if the characters don't match anything
        End Select

        Return False ' Means the character is a consonant

    End Function

    Sub Main()

        Dim input As String

        Console.WriteLine("=====================================================")
        Console.WriteLine("This program will (these are not menu options):")
        Console.WriteLine("1. Reverse the string input")
        Console.WriteLine("2. Count the number of vowels in the string input")
        Console.WriteLine("3. Count the number of consonants in the string input")
        Console.WriteLine("4. Count the number of words in the string input")
        Console.WriteLine("- Written by Spimy")
        Console.WriteLine("=====================================================")

        Console.WriteLine() ' Write an empty line just for some spacing

        Do
            Console.Write("Input String (w/ Full Stop): ")
            input = Console.ReadLine
        Loop Until Right(input, 1) = "." ' Makes sure the input ends with a period

        Console.WriteLine("Processing...") ' Not needed but just to be fancy
        Console.WriteLine() ' Write an empty line just for some spacing

        Dim index As Integer
        Dim position As Integer
        Dim character As Char

        Dim revString As String = ""
        Dim numVowel As Integer = 0
        Dim numConsonant As Integer = 0
        Dim numWord As Integer = 0

        For index = 0 To Len(input) - 1

            position = Len(input) - index ' Get character position in reverse
            character = Mid(input, position, 1) ' Get the character in specified position

            If IsLetter(character) Then ' Check if character is vowel or consonant only if it is a letter
                If IsVowel(character) Then ' Check if the character is a vowel
                    numVowel += 1 ' Increase vowel count by 1
                Else
                    numConsonant += 1 ' Increase consonant count by 1
                End If
            Else
                ' If not a letter or digit i.e. a separator is involved, there is a new word
                If Not IsDigit(character) Then ' Make sure a number also counts as a word
                    numWord += 1 ' Increase word count by 1
                End If
            End If

            revString += character ' Form the reverse string starting from last character in the loop

        Next

        Console.WriteLine("String {0} in Reverse: {1}", input, revString)
        Console.WriteLine("Number of Vowels: {0}", numVowel)
        Console.WriteLine("Number of Consonants: {0}", numConsonant)
        Console.WriteLine("Number of Words: {0}", numWord)

        Console.ReadKey()

    End Sub

End Module
