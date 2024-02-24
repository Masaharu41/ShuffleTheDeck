Module Shuffler
    Sub NewGame(ByRef tracker(,) As Boolean)
        Console.Clear()
        ReDim tracker(14, 4)
    End Sub

    Sub DrawBall(ByRef tracker(,) As Boolean)
        Dim currentLetter%, currentNumber%
        ' loop until we get a ball that has not been drawn yet
        ' update tracker marking the ball
        Do
            ' potential endless loop here
            currentNumber = RandomNumberZero(14)
            currentLetter = RandomNumberZero(4)
        Loop While tracker(currentNumber, currentLetter)

        tracker(currentNumber, currentLetter) = True

    End Sub

    Private Function RandomNumberZero(max%) As Integer
        Dim _randomNumber As Integer
        Randomize()
        _randomNumber = CInt(Math.Floor(Rnd() * (max + 1)))
        Return _randomNumber
    End Function

    Sub Display(tracker(,) As Boolean)

        Dim temp(14, 4) As Boolean

        temp = tracker
        Dim header() = {"B", "I", "N", "G", "O"}
        Dim math As Integer
        For Each letter In header
            Console.Write(letter.PadLeft(2).PadRight(4))
        Next
        Console.WriteLine()
        'temp(7, 3) = True
        'temp(3, 4) = True
        For row = 0 To 14
            For column = 0 To 4
                If temp(row, column) Then
                    math = (column * 15) + (row + 1)
                    Console.Write($"{math}")
                Else
                    Console.Write("X")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
