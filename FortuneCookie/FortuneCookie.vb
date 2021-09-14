
Module FortuneCookie

    Sub Main()

        Dim rndNumber As Integer
            rndNumber = Int((3 * Rnd()) + 1)    'Formula used to determine parameters:  Int((upperbound - lowerbound + 1) * Rnd + lowerbound)
            Console.WriteLine(rndNumber)
            Console.Read()

    End Sub

End Module
