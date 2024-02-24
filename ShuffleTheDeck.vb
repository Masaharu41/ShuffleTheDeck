'Owen Fujii
'RCET 2265
'Spring 2024
'Shuffle The Deck
'https://github.com/Masaharu41/ShuffleTheDeck.git

Option Explicit On
Option Strict On
Option Compare Text
Module ShuffleTheDeck

    'TODO
    '[*] Start Deck
    '[*] Draw Card
    '[*] Track Card
    '[*] Display Card #
    '[*] Draw Card 2
    '[*] Repeat but no repeat cards can be displayed
    '[*] Restart or shuffle at end

    Sub Main()
        Dim userInput As String
        Dim tracker(12, 3) As Boolean ' each letter had 15 unique #
        Dim cardsDrawn As Integer = 0
        Dim message As String = "Hello There! Press Enter To Draw Your First Card!"
        Shuffler.NewGame(tracker)
        Do
            Console.Clear()
            Console.WriteLine("Shuffle The Deck!")
            Shuffler.Display(tracker)
            Console.WriteLine(message)
            userInput = Console.ReadLine()
            If userInput = "n" Then
                Shuffler.NewGame(tracker)
                cardsDrawn = 0
            Else
                If cardsDrawn >= 52 Then
                    message = "All cards have been drawn"
                    Shuffler.NewGame(tracker)
                    cardsDrawn = 0
                Else
                    Shuffler.DrawCard(tracker)
                    cardsDrawn += 1
                    message = "Press enter to draw, N for new game, or Q for quit"
                End If
            End If


        Loop Until userInput = "q"
        Console.WriteLine("Have a Nice Day!")
        Console.Read()
    End Sub


End Module
