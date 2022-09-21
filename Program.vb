Imports System

Module Program
    Sub Main(args As String())

        ' Declare and assign variables
        Dim x As Integer = 7
        Dim y As Integer = x + 3

        ' Output y and break before next segment of program
        Console.WriteLine(y)
        Console.WriteLine()

        ' Demonstrate input
        Console.WriteLine("What is your name?")

        ' Get first name
        Console.Write("Please enter your first name: ")
        Dim myFirstName As String = Console.ReadLine()

        ' Get last name
        Console.Write("Please enter your last name: ")
        Dim myLastName As String = Console.ReadLine()

        ' Greet user
        Console.WriteLine("Hello, " & myFirstName & " " & myLastName & ".")

    End Sub
End Module
