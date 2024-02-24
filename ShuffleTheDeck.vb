'Owen Fujii
'RCET 2265
'Spring 2024
'Shuffle The Deck
'https://github.com/Masaharu41/ShuffleTheDeck.git

Option Explicit On
Option Strict On
Module ShuffleTheDeck

    'TODO
    '[*] Start Deck
    '[*] Draw Card
    '[*] Track Card
    '[] Display Card #
    '[] Draw Card 2
    '[*] Repeat but no repeat cards can be displayed
    '[] Restart or shuffle at end

    Sub Main()
        'For i = 0 To 254
        '    Console.WriteLine($"{i} = {Chr(i)}")
        'Next
        'Console.Read()
        Dim userInput As String
        Dim tracker(12, 3) As Boolean ' each letter had 15 unique #
        Dim cardsDrawn As Integer = 0
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
                If cardsDrawn >= 52 Then
                    message = "All balls have been drawn"
                    Exit Do

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
