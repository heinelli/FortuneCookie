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
        rndNumber = Int((3 * Rnd()) + 1)    'Formula used to determine parameters:  Int((upperbound - lowerbound + 1) * Rnd + lowerbound)

            If rndNumber = 1 Then
                Console.WriteLine("Allow compassion to guide your decisions.")
            ElseIf rndNumber = 2 Then
                Console.WriteLine("Never let a problem to be solved become more important than a person to be loved.")
            ElseIf rndNumber = 3 Then
                Console.WriteLine("Get some exercise!")
            End If
            Console.Read()

    End Sub

End Module
