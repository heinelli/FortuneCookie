'Elliot Heiner
'RCET0265
'Fall 2021
'Fortune Cookie
'https://github.com/heinelli/FortuneCookie.git

Option Strict On
Option Explicit On
Module FortuneCookie

    Sub Main()

        Dim rndNumber As Single

        Randomize()
        'Random number algorithm is based on computer clock.

        rndNumber = Int((8 * Rnd()) + 1)
        'Formula used to determine parameters:  Int((upperbound - lowerbound + 1) * Rnd + lowerbound)

        If rndNumber = 2 Or rndNumber = 7 Then
            Console.WriteLine("Allow compassion to guide your decisions.")
        ElseIf rndNumber = 1 Or rndNumber = 5 Then
            Console.WriteLine("Never let a problem to be solved become more 
important than a person to be loved.")
        ElseIf rndNumber = 4 Or rndNumber = 6 Then
            Console.WriteLine("Get some exercise!")
        ElseIf rndNumber = 3 Or rndNumber = 8 Then
            Console.WriteLine("The past is to be learned from but not lived in")
        End If
        'One of four quotes is displayed based on random number.

        Console.Read()
    End Sub

End Module
