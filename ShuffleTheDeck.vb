Module ShuffleTheDeck

    'TODO
    '[] Start Deck
    '[] Draw Card
    '[] Track Card
    '[] Display Card #
    '[] Draw Card 2
    '[] Repeat but no repeat cards can be displayed
    '[] Restart or shuffle at end


    Sub Main()
            Dim userInput As String
            Dim tracker(14, 4) As Boolean ' each letter had 15 unique #
            Dim ballsDrawn As Integer = 0
            Dim message As String = "Hello There!"
        Shuffler.NewGame(tracker)
        Do
                Console.Clear()
            Shuffler.Display(tracker)
            Console.WriteLine(message)
                userInput = Console.ReadLine()
                If userInput = "n" Then
                Shuffler.NewGame(tracker)
            Else
                    If ballsDrawn >= 75 Then
                        message = "All balls have been drawn"
                        Exit Do

                    Else
                    Shuffler.DrawBall(tracker)
                    ballsDrawn += 1
                        message = "Press enter to draw, N for new game, or Q for quit"
                    End If
                End If


            Loop Until userInput = "q"
            Console.WriteLine("Have a Nice Day!")
            Console.Read()
        End Sub


End Module
