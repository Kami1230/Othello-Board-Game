Public Class Game
    Dim board(5, 5) As Integer
    Dim turn As Integer
    Dim ctr As Integer
    Dim tick As Integer
    Dim BlkCnt As Integer
    Dim WhtCnt As Integer

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        'Fix 1c
        Me.Close()
        'Close game
        Introduction.Show()
        'show page
    End Sub
    Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
        'Reenable the picture boxes
        Pic1a.Enabled = True
        Pic1b.Enabled = True
        Pic1c.Enabled = True
        Pic1d.Enabled = True
        Pic1e.Enabled = True
        Pic1f.Enabled = True
        Pic2a.Enabled = True
        Pic2b.Enabled = True
        Pic2c.Enabled = True
        Pic2d.Enabled = True
        Pic2e.Enabled = True
        Pic2f.Enabled = True
        Pic3a.Enabled = True
        Pic3b.Enabled = True
        Pic3e.Enabled = True
        Pic3f.Enabled = True
        Pic4a.Enabled = True
        Pic4b.Enabled = True
        Pic4e.Enabled = True
        Pic4f.Enabled = True
        Pic5a.Enabled = True
        Pic5b.Enabled = True
        Pic5c.Enabled = True
        Pic5d.Enabled = True
        Pic5e.Enabled = True
        Pic5f.Enabled = True
        Pic6a.Enabled = True
        Pic6b.Enabled = True
        Pic6c.Enabled = True
        Pic6d.Enabled = True
        Pic6e.Enabled = True
        Pic6f.Enabled = True

        'Clear the picture boxes
        Pic1a.Image = Nothing
        Pic1b.Image = Nothing
        Pic1c.Image = Nothing
        Pic1d.Image = Nothing
        Pic1e.Image = Nothing
        Pic1f.Image = Nothing
        Pic2a.Image = Nothing
        Pic2b.Image = Nothing
        Pic2c.Image = Nothing
        Pic2d.Image = Nothing
        Pic2e.Image = Nothing
        Pic2f.Image = Nothing
        Pic3a.Image = Nothing
        Pic3b.Image = Nothing
        Pic3e.Image = Nothing
        Pic3f.Image = Nothing
        Pic4a.Image = Nothing
        Pic4b.Image = Nothing
        Pic4e.Image = Nothing
        Pic4f.Image = Nothing
        Pic5a.Image = Nothing
        Pic5b.Image = Nothing
        Pic5c.Image = Nothing
        Pic5d.Image = Nothing
        Pic5e.Image = Nothing
        Pic5f.Image = Nothing
        Pic6a.Image = Nothing
        Pic6b.Image = Nothing
        Pic6c.Image = Nothing
        Pic6d.Image = Nothing
        Pic6e.Image = Nothing
        Pic6f.Image = Nothing

        Call Start()
    End Sub
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x = 0 To 5
            For y = 0 To 5
                board(x, y) = 0
            Next
        Next
        'fill arrays
        Call Start()
        'Clear label
        LblWin.Text = ""
    End Sub
    Sub Start()
        'Set the center boxes to specific vals
        Pic3c.Image = Image.FromFile("white.jpg")
        Pic3d.Image = Image.FromFile("black.jpg")
        Pic4c.Image = Image.FromFile("black.jpg")
        Pic4d.Image = Image.FromFile("white.jpg")

        board(2, 3) = 1
        board(3, 2) = 1
        board(2, 2) = 2
        board(3, 3) = 2

        turn = 1
    End Sub
    Sub Illegal()
        MsgBox("Invalid Move!")
        'To give an error message
    End Sub
    Sub Count()
        If ctr = 36 Then
            BlkCnt = Val(InputBox("Enter the number of black tiles"))
            WhtCnt = Val(InputBox("Enter the number of white tiles"))
            'manually enter results to add to the fun of the game

            LblWin.Text = "Winner Is… "
            TimerWinner.Enabled = True
            TimerWinner.Interval = 1000
            'Timer for suspence
        End If
        If turn = 1 Then
            LblPly1.Text = "Player 1: Turn"
        ElseIf turn = 2 Then
            LblPly2.Text = "Player 2: Turn"
        End If
    End Sub
    Private Sub TimerWinner_Tick(sender As Object, e As EventArgs) Handles TimerWinner.Tick
        tick = tick + 1
        'To find the winner
        If tick >= 5 Then
            If BlkCnt > WhtCnt Then
                LblWin.Text = "BLACK!!!!!"
            ElseIf BlkCnt < WhtCnt Then
                LblWin.Text = "WHITE!!!!!"
            ElseIf BlkCnt = WhtCnt Then
                LblWin.Text = "Tie!!!!!"
            End If
            TimerWinner.Enabled = False
        End If
    End Sub
    Sub Done()
        'Reenable the picboxes
        Pic1a.Enabled = True
        Pic1b.Enabled = True
        Pic1c.Enabled = True
        Pic1d.Enabled = True
        Pic1e.Enabled = True
        Pic1f.Enabled = True
        Pic2a.Enabled = True
        Pic2b.Enabled = True
        Pic2c.Enabled = True
        Pic2d.Enabled = True
        Pic2e.Enabled = True
        Pic2f.Enabled = True
        Pic3a.Enabled = True
        Pic3b.Enabled = True
        Pic3c.Enabled = True
        Pic3d.Enabled = True
        Pic3e.Enabled = True
        Pic3f.Enabled = True
        Pic4a.Enabled = True
        Pic4b.Enabled = True
        Pic4c.Enabled = True
        Pic4d.Enabled = True
        Pic4e.Enabled = True
        Pic4f.Enabled = True
        Pic5a.Enabled = True
        Pic5b.Enabled = True
        Pic5c.Enabled = True
        Pic5d.Enabled = True
        Pic5e.Enabled = True
        Pic5f.Enabled = True
        Pic6a.Enabled = True
        Pic6b.Enabled = True
        Pic6c.Enabled = True
        Pic6d.Enabled = True
        Pic6e.Enabled = True
        Pic6f.Enabled = True
    End Sub
    Private Sub PicBoxMusic_Click(sender As Object, e As EventArgs) Handles PicBoxMusic.Click
        My.Computer.Audio.Play("Music.wav")
        PicBoxMusic.Visible = False
        PicPause.Visible = True
        'Play music
    End Sub

    Private Sub PicPause_Click(sender As Object, e As EventArgs) Handles PicPause.Click
        My.Computer.Audio.Stop()
        PicPause.Visible = False
        PicBoxMusic.Visible = True
        'pause music
    End Sub
    Private Sub Pic1a_Click(sender As Object, e As EventArgs) Handles Pic1a.Click
        'First find errors
        If board(1, 0) = 0 Or board(0, 1) = 0 Or board(1, 1) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 0) = turn Or board(0, 1) = turn Or board(1, 1) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 0) <> turn And board(0, 2) <> turn And board(2, 2) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(2, 0) = turn And (board(1, 0) <> turn And board(1, 0) <> 0)) Or (board(0, 2) = turn And (board(0, 1) <> turn And board(0, 1) <> 0)) Or (board(2, 2) = turn And (board(1, 1) <> turn And board(1, 1) <> 0)) Then
            'Then flip the similar tiles
            If board(2, 0) = turn And (board(1, 0) <> turn And board(1, 0) <> 0) Then
                board(1, 0) = turn
                If turn = 1 Then
                    Pic2a.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2a.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(0, 2) = turn And (board(0, 1) <> turn And board(0, 1) <> 0) Then
                board(0, 1) = turn
                If turn = 1 Then
                    Pic1b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 2) = turn And (board(1, 1) <> turn And board(1, 1) <> 0) Then
                board(1, 1) = turn
                If turn = 1 Then
                    Pic2b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2b.Image = Image.FromFile(“white.jpg”)
                End If
            Else
                Call Illegal()
                Exit Sub
            End If
        End If

        'Fill the picbox and change turn and add to counter
        If turn = 1 Then
            Pic1a.Image = Image.FromFile(“black.jpg”)
            board(0, 0) = 1
            turn = 2
            ctr += 1
        Else
            Pic1a.Image = Image.FromFile(“white.jpg”)
            board(0, 0) = 2
            turn = 1
            ctr += 1
        End If
        Pic1a.Enabled = False
        Call Count()
    End Sub

    Private Sub Pic2a_Click(sender As Object, e As EventArgs) Handles Pic2a.Click
        If board(0, 0) = 0 And board(1, 1) = 0 And board(2, 1) = 0 And board(0, 1) = 1 And board(2, 0) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 0) = turn And board(1, 1) = turn And board(2, 1) = turn And board(0, 1) = turn And board(2, 0) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 2) <> turn And board(3, 2) <> turn And board(3, 0) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(3, 0) = turn And (board(2, 0) <> turn And board(2, 0) <> 0)) Or (board(1, 2) = turn And (board(1, 1) <> turn And board(1, 1) <> 0)) Or (board(3, 2) = turn And (board(2, 1) <> turn And board(2, 1) <> 0)) Then
            If board(3, 0) = turn And (board(2, 0) <> turn And board(2, 0) <> 0) Then
                board(2, 0) = turn
                If turn = 1 Then
                    Pic3a.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3a.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(1, 2) = turn And (board(1, 1) <> turn And board(1, 1) <> 0) Then
                board(1, 1) = turn
                If turn = 1 Then
                    Pic2b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 2) = turn And (board(2, 1) <> turn And board(2, 1) <> 0) Then
                board(2, 1) = turn
                If turn = 1 Then
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If
        If turn = 1 Then
            Pic2a.Image = Image.FromFile(“black.jpg”)
            board(1, 0) = 1
            turn = 2
            ctr += 1
        Else
            Pic2a.Image = Image.FromFile(“white.jpg”)
            board(1, 0) = 2
            turn = 1
            ctr += 1
        End If
        Pic2a.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic3a_Click(sender As Object, e As EventArgs) Handles Pic3a.Click
        If board(1, 0) = 0 And board(1, 1) = 0 And board(2, 1) = 0 And board(3, 1) = 1 And board(3, 0) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 0) = turn And board(1, 1) = turn And board(2, 1) = turn And board(3, 1) = turn And board(3, 0) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 0) <> turn And board(0, 2) <> turn And board(2, 2) <> turn And board(4, 2) <> turn And board(4, 0) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(0, 0) = turn And (board(1, 0) <> turn And board(1, 0) <> 0)) Or (board(0, 2) = turn And (board(1, 1) <> turn And board(1, 1) <> 0)) Or (board(2, 2) = turn And (board(2, 1) <> turn And board(2, 1) <> 0)) Or (board(4, 2) = turn And (board(3, 1) <> turn And board(3, 1) <> 0)) Or (board(4, 0) = turn And (board(3, 0) <> turn And board(3, 0) <> 0)) Then
            If board(0, 0) = turn And (board(1, 0) <> turn And board(1, 0) <> 0) Then
                board(1, 0) = turn
                If turn = 1 Then
                    Pic3a.Image = Image.FromFile(“black.jpg”)
                    Pic2a.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3a.Image = Image.FromFile(“white.jpg”)
                    Pic2a.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(0, 2) = turn And (board(1, 1) <> turn And board(1, 1) <> 0) Then
                board(1, 1) = turn
                If turn = 1 Then
                    Pic3a.Image = Image.FromFile(“black.jpg”)
                    Pic2b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3a.Image = Image.FromFile(“white.jpg”)
                    Pic2b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 2) = turn And (board(2, 1) <> turn And board(2, 1) <> 0) Then
                board(2, 1) = turn
                If turn = 1 Then
                    Pic3a.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3a.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 2) = turn And (board(3, 1) <> turn And board(3, 1) <> 0) Then
                board(3, 1) = turn
                If turn = 1 Then
                    Pic3a.Image = Image.FromFile(“black.jpg”)
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3a.Image = Image.FromFile(“white.jpg”)
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 0) = turn And (board(3, 0) <> turn And board(3, 0) <> 0) Then
                board(3, 0) = turn
                If turn = 1 Then
                    Pic3a.Image = Image.FromFile(“black.jpg”)
                    Pic4a.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3a.Image = Image.FromFile(“white.jpg”)
                    Pic4a.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If
        If turn = 1 Then
            board(2, 0) = 1
            turn = 2
            ctr += 1
        Else
            board(2, 0) = 2
            turn = 1
            ctr += 1
        End If

        Pic3a.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic4a_Click(sender As Object, e As EventArgs) Handles Pic4a.Click
        If board(2, 0) = 0 And board(2, 1) = 0 And board(3, 1) = 0 And board(4, 1) = 1 And board(4, 0) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 0) = turn And board(2, 1) = turn And board(3, 1) = turn And board(4, 1) = turn And board(4, 0) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 0) <> turn And board(1, 2) <> turn And board(3, 2) <> turn And board(5, 2) <> turn And board(5, 0) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(1, 0) = turn And (board(2, 0) <> turn And board(2, 0) <> 0)) Or (board(1, 2) = turn And (board(2, 1) <> turn And board(2, 1) <> 0)) Or (board(3, 2) = turn And (board(3, 1) <> turn And board(3, 1) <> 0)) Or (board(5, 2) = turn And (board(4, 1) <> turn And board(4, 1) <> 0)) Or (board(5, 0) = turn And (board(4, 0) <> turn And board(4, 0) <> 0)) Then
            If board(1, 0) = turn And (board(2, 0) <> turn And board(2, 0) <> 0) Then
                board(2, 0) = turn
                If turn = 1 Then
                    Pic4a.Image = Image.FromFile(“black.jpg”)
                    Pic3a.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4a.Image = Image.FromFile(“white.jpg”)
                    Pic3a.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(1, 2) = turn And (board(2, 1) <> turn And board(2, 1) <> 0) Then
                board(2, 1) = turn
                If turn = 1 Then
                    Pic4a.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4a.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 2) = turn And (board(3, 1) <> turn And board(3, 1) <> 0) Then
                board(3, 1) = turn
                If turn = 1 Then
                    Pic4a.Image = Image.FromFile(“black.jpg”)
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4a.Image = Image.FromFile(“white.jpg”)
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 2) = turn And (board(4, 1) <> turn And board(4, 1) <> 0) Then
                board(4, 1) = turn
                If turn = 1 Then
                    Pic4a.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4a.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 0) = turn And (board(4, 0) <> turn And board(4, 0) <> 0) Then
                board(4, 0) = turn
                If turn = 1 Then
                    Pic4a.Image = Image.FromFile(“black.jpg”)
                    Pic5a.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4a.Image = Image.FromFile(“white.jpg”)
                    Pic5a.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(3, 0) = 1
            turn = 2
            ctr += 1
        Else
            board(3, 0) = 2
            turn = 1
            ctr += 1
        End If

        Pic4a.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic5a_Click(sender As Object, e As EventArgs) Handles Pic5a.Click
        If board(3, 0) = 0 And board(3, 1) = 0 And board(4, 1) = 0 And board(5, 1) = 1 And board(5, 0) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 0) = turn And board(3, 1) = turn And board(4, 1) = turn And board(5, 1) = turn And board(5, 0) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 0) <> turn And board(2, 2) <> turn And board(4, 2) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(2, 0) = turn And (board(3, 0) <> turn And board(3, 0) <> 0)) Or (board(2, 2) = turn And (board(3, 1) <> turn And board(3, 1) <> 0)) Or (board(4, 2) = turn And (board(4, 1) <> turn And board(4, 1) <> 0)) Then
            If board(2, 0) = turn And (board(3, 0) <> turn And board(3, 0) <> 0) Then
                board(3, 0) = turn
                If turn = 1 Then
                    Pic5a.Image = Image.FromFile(“black.jpg”)
                    Pic4a.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5a.Image = Image.FromFile(“white.jpg”)
                    Pic4a.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 2) = turn And (board(3, 1) <> turn And board(3, 1) <> 0) Then
                board(3, 1) = turn
                If turn = 1 Then
                    Pic5a.Image = Image.FromFile(“black.jpg”)
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5a.Image = Image.FromFile(“white.jpg”)
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 2) = turn And (board(4, 1) <> turn And board(4, 1) <> 0) Then
                board(4, 1) = turn
                If turn = 1 Then
                    Pic5a.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5a.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If


        If turn = 1 Then
            board(4, 0) = 1
            turn = 2
            ctr += 1
        Else
            board(4, 0) = 2
            turn = 1
            ctr += 1
        End If
        Pic5a.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic6a_Click(sender As Object, e As EventArgs) Handles Pic6a.Click
        If board(4, 0) = 0 And board(4, 1) = 0 And board(5, 1) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(4, 0) = turn And board(4, 1) = turn And board(5, 1) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 0) <> turn And board(3, 2) <> turn And board(5, 2) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(3, 0) = turn And (board(4, 0) <> turn And board(4, 0) <> 0)) Or (board(3, 2) = turn And (board(4, 1) <> turn And board(4, 1) <> 0)) Or (board(5, 2) = turn And (board(5, 1) <> turn And board(5, 1))) Then
            If board(3, 0) = turn And (board(4, 0) <> turn And board(4, 0) <> 0) Then
                board(4, 0) = turn
                If turn = 1 Then
                    Pic6a.Image = Image.FromFile(“black.jpg”)
                    Pic5a.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6a.Image = Image.FromFile(“white.jpg”)
                    Pic5a.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 2) = turn And (board(4, 1) <> turn And board(4, 1) <> 0) Then
                board(4, 1) = turn
                If turn = 1 Then
                    Pic6a.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6a.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 2) = turn And (board(5, 1) <> turn And board(5, 1) <> 0) Then
                board(5, 1) = turn
                If turn = 1 Then
                    Pic6a.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6a.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(5, 0) = 1
            turn = 2
            ctr += 1
        Else
            board(5, 0) = 2
            turn = 1
            ctr += 1
        End If
        Pic6a.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic1b_Click(sender As Object, e As EventArgs) Handles Pic1b.Click
        If board(0, 0) = 0 And board(1, 0) = 0 And board(1, 1) = 0 And board(1, 2) = 1 And board(0, 2) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 0) = turn And board(1, 0) = turn And board(1, 1) = turn And board(1, 2) = turn And board(0, 2) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 1) <> turn And board(2, 3) <> turn And board(0, 3) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(2, 1) = turn And (board(1, 1) <> turn And board(1, 1) <> 0)) Or (board(2, 3) = turn And (board(1, 2) <> turn And board(1, 2) <> 0)) Or (board(0, 3) = turn And (board(0, 2) <> turn And board(0, 2) <> 0)) Then
            If board(2, 1) = turn And (board(1, 1) <> turn And board(1, 1) <> 0) Then
                board(1, 1) = turn
                If turn = 1 Then
                    Pic1b.Image = Image.FromFile(“black.jpg”)
                    Pic2b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1b.Image = Image.FromFile(“white.jpg”)
                    Pic2b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 3) = turn And (board(1, 2) <> turn And board(1, 2) <> 0) Then
                board(1, 1) = turn
                If turn = 1 Then
                    Pic1b.Image = Image.FromFile(“black.jpg”)
                    Pic2c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1b.Image = Image.FromFile(“white.jpg”)
                    Pic2c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(0, 3) = turn And (board(0, 2) <> turn And board(0, 2) <> 0) Then
                board(0, 2) = turn
                If turn = 1 Then
                    Pic1b.Image = Image.FromFile(“black.jpg”)
                    Pic1c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1b.Image = Image.FromFile(“white.jpg”)
                    Pic1c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(0, 1) = 1
            turn = 2
            ctr += 1
        Else
            board(0, 1) = 2
            turn = 1
            ctr += 1
        End If
        Pic1b.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic2b_Click(sender As Object, e As EventArgs) Handles Pic2b.Click
        If board(0, 0) = 0 And board(1, 0) = 0 And board(2, 0) = 0 And board(2, 1) = 1 And board(2, 2) = 0 And board(1, 2) = 0 And board(0, 2) = 0 And board(0, 1) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 0) = turn And board(1, 0) = turn And board(2, 0) = turn And board(2, 1) = turn And board(2, 2) = turn And board(1, 2) = turn And board(0, 2) = turn And board(1, 1) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 1) <> turn And board(3, 3) <> turn And board(1, 3) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(3, 1) = turn And (board(2, 1) <> turn And board(2, 1) <> 0)) Or (board(3, 3) = turn And (board(2, 2) <> turn And board(2, 2) <> 0)) Or (board(1, 3) = turn And (board(1, 2) <> turn And board(1, 2) <> 0)) Then
            If board(3, 1) = turn And (board(2, 1) <> turn And board(2, 1) <> 0) Then
                board(2, 1) = turn
                If turn = 1 Then
                    Pic2b.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2b.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 3) = turn And (board(2, 2) <> turn And board(2, 2) <> 0) Then
                board(2, 2) = turn
                If turn = 1 Then
                    Pic2b.Image = Image.FromFile(“black.jpg”)
                    Pic3c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2b.Image = Image.FromFile(“white.jpg”)
                    Pic3c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(1, 3) = turn And (board(1, 2) <> turn And board(1, 2) <> 0) Then
                board(1, 2) = turn
                If turn = 1 Then
                    Pic2b.Image = Image.FromFile(“black.jpg”)
                    Pic2c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2b.Image = Image.FromFile(“white.jpg”)
                    Pic2c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(1, 1) = 1
            turn = 2
            ctr += 1
        Else
            board(1, 1) = 2
            turn = 1
            ctr += 1
        End If
        Pic2b.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic3b_Click(sender As Object, e As EventArgs) Handles Pic3b.Click
        If board(1, 0) = 0 And board(2, 0) = 0 And board(3, 0) = 0 And board(3, 1) = 1 And board(3, 2) = 0 And board(2, 2) = 0 And board(1, 2) = 0 And board(1, 1) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 0) = turn And board(2, 0) = turn And board(3, 0) = turn And board(3, 1) = turn And board(3, 2) = turn And board(2, 2) = turn And board(1, 2) = turn And board(1, 1) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(4, 1) <> turn And board(4, 3) <> turn And board(2, 3) <> turn And board(0, 3) <> turn And board(0, 1) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(4, 1) = turn And (board(3, 1) <> turn And board(3, 1) <> 0)) Or (board(4, 3) = turn And (board(3, 2) <> turn And board(3, 2) <> 0)) Or (board(2, 3) = turn And (board(2, 2) <> turn And board(2, 2) <> 0)) Or (board(0, 3) = turn And (board(1, 2) <> turn And board(1, 2) <> 0)) Or (board(0, 1) = turn And (board(1, 1) <> turn And board(1, 1) <> 0)) Then
            If board(4, 1) = turn And (board(3, 1) <> turn And board(3, 1) <> 0) Then
                board(3, 1) = turn
                If turn = 1 Then
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 3) = turn And (board(3, 2) <> turn And board(3, 2) <> 0) Then
                board(3, 2) = turn
                If turn = 1 Then
                    Pic5d.Image = Image.FromFile(“black.jpg”)
                    Pic4c.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5d.Image = Image.FromFile(“white.jpg”)
                    Pic4c.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 3) = turn And (board(2, 2) <> turn And board(2, 2) <> 0) Then
                board(2, 2) = turn
                If turn = 1 Then
                    Pic3d.Image = Image.FromFile(“black.jpg”)
                    Pic3c.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3d.Image = Image.FromFile(“white.jpg”)
                    Pic3c.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(0, 3) = turn And (board(1, 2) <> turn And board(1, 2) <> 0) Then
                board(1, 2) = turn
                If turn = 1 Then
                    Pic1d.Image = Image.FromFile(“black.jpg”)
                    Pic2c.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1d.Image = Image.FromFile(“white.jpg”)
                    Pic2c.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(0, 1) = turn And (board(1, 1) <> turn And board(1, 1) <> 0) Then
                board(1, 1) = turn
                If turn = 1 Then
                    Pic1b.Image = Image.FromFile(“black.jpg”)
                    Pic2b.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1b.Image = Image.FromFile(“white.jpg”)
                    Pic2b.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic3b.Image = Image.FromFile(“black.jpg”)
            board(2, 1) = 1
            turn = 2
            ctr += 1
        Else
            Pic3b.Image = Image.FromFile(“white.jpg”)
            board(2, 1) = 2
            turn = 1
            ctr += 1
        End If

        Pic3b.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic4b_Click(sender As Object, e As EventArgs) Handles Pic4b.Click
        If board(2, 0) = 0 And board(3, 0) = 0 And board(4, 0) = 0 And board(4, 1) = 1 And board(4, 2) = 0 And board(3, 2) = 0 And board(2, 2) = 0 And board(2, 1) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 0) = turn And board(3, 0) = turn And board(4, 0) = turn And board(4, 1) = turn And board(4, 2) = turn And board(3, 2) = turn And board(2, 2) = turn And board(2, 1) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(5, 1) <> turn And board(5, 3) <> turn And board(3, 3) <> turn And board(1, 3) <> turn And board(1, 1) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(5, 1) = turn And (board(4, 1) <> turn And board(4, 1) <> 0)) Or (board(5, 3) = turn And (board(4, 2) <> turn And board(4, 2) <> 0)) Or (board(3, 3) = turn And (board(3, 2) <> turn And board(3, 2) <> 0)) Or (board(1, 3) = turn And (board(2, 2) <> turn And board(2, 2) <> 0)) Or (board(1, 1) = turn And (board(2, 1) <> turn And board(2, 1) <> 0)) Then
            If board(5, 1) = turn And (board(4, 1) <> turn And board(4, 1) <> 0) Then
                board(4, 1) = turn
                If turn = 1 Then
                    Pic6b.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6b.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 3) = turn And (board(4, 2) <> turn And board(4, 2) <> 0) Then
                board(4, 2) = turn
                If turn = 1 Then
                    Pic6d.Image = Image.FromFile(“black.jpg”)
                    Pic5c.Image = Image.FromFile(“black.jpg”)
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6d.Image = Image.FromFile(“white.jpg”)
                    Pic5c.Image = Image.FromFile(“white.jpg”)
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 3) = turn And (board(3, 2) <> turn And board(3, 2) <> 0) Then
                board(3, 2) = turn
                If turn = 1 Then
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                    Pic4c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                    Pic4c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(1, 3) = turn And (board(2, 2) <> turn And board(2, 2) <> 0) Then
                board(2, 2) = turn
                If turn = 1 Then
                    Pic2d.Image = Image.FromFile(“black.jpg”)
                    Pic3c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2d.Image = Image.FromFile(“white.jpg”)
                    Pic3c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(1, 1) = turn And (board(2, 1) <> turn And board(2, 1) <> 0) Then
                board(2, 1) = turn
                If turn = 1 Then
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic4b.Image = Image.FromFile(“black.jpg”)
            board(3, 1) = 1
            turn = 2
            ctr += 1
        Else
            Pic4b.Image = Image.FromFile(“white.jpg”)
            board(3, 1) = 2
            turn = 1
            ctr += 1
        End If

        Pic4b.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic5b_Click(sender As Object, e As EventArgs) Handles Pic5b.Click
        If board(3, 0) = 0 And board(4, 0) = 0 And board(5, 0) = 0 And board(5, 1) = 1 And board(5, 2) = 0 And board(4, 2) = 0 And board(3, 2) = 0 And board(3, 1) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 0) = turn And board(4, 0) = turn And board(5, 0) = turn And board(5, 1) = turn And board(5, 2) = turn And board(4, 2) = turn And board(3, 2) = turn And board(3, 1) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(4, 3) <> turn And board(2, 3) <> turn And board(2, 1) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(4, 3) = turn And (board(4, 2) <> turn And board(4, 2) <> 0)) Or (board(2, 3) = turn And (board(3, 2) <> turn And board(3, 2) <> 0)) Or (board(2, 1) = turn And (board(3, 1) <> turn And board(3, 1) <> 0)) Then
            If board(4, 3) = turn And (board(4, 2) <> turn And board(4, 2) <> 0) Then
                board(4, 2) = turn
                If turn = 1 Then
                    Pic5d.Image = Image.FromFile(“black.jpg”)
                    Pic5c.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5d.Image = Image.FromFile(“white.jpg”)
                    Pic5c.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 3) = turn And (board(3, 2) <> turn And board(3, 2) <> 0) Then
                board(3, 2) = turn
                If turn = 1 Then
                    Pic3d.Image = Image.FromFile(“black.jpg”)
                    Pic4c.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3d.Image = Image.FromFile(“white.jpg”)
                    Pic4c.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 1) = turn And (board(3, 1) <> turn And board(3, 1) <> 0) Then
                board(3, 1) = turn
                If turn = 1 Then
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(4, 1) = 1
            turn = 2
            ctr += 1
        Else
            board(4, 1) = 2
            turn = 1
            ctr += 1
        End If
        Pic5b.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic6b_Click(sender As Object, e As EventArgs) Handles Pic6b.Click
        If board(4, 0) = 0 And board(5, 0) = 0 And board(5, 2) = 0 And board(4, 2) = 0 And board(4, 1) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(4, 0) = turn And board(5, 0) = turn And board(5, 2) = turn And board(4, 2) = turn And board(4, 1) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 3) <> turn And board(5, 3) <> turn And board(3, 1) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(5, 3) = turn And (board(5, 2) <> turn And board(5, 2) <> 0)) Or (board(3, 3) = turn And (board(4, 2) <> turn And board(4, 2) <> 0)) Or (board(3, 1) = turn And (board(4, 1) <> turn And board(4, 1) <> 0)) Then
            If board(5, 3) = turn And (board(5, 2) <> turn And board(5, 2) <> 0) Then
                board(5, 2) = turn
                If turn = 1 Then
                    Pic6d.Image = Image.FromFile(“black.jpg”)
                    Pic6c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6d.Image = Image.FromFile(“white.jpg”)
                    Pic6c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 3) = turn And (board(4, 2) <> turn And board(4, 2) <> 0) Then
                board(4, 2) = turn
                If turn = 1 Then
                    Pic4d.Image = Image.FromFile(“black.jpg”)
                    Pic5c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4d.Image = Image.FromFile(“white.jpg”)
                    Pic5c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 1) = turn And (board(4, 1) <> turn And board(4, 1) <> 0) Then
                board(4, 1) = turn
                If turn = 1 Then
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic6b.Image = Image.FromFile(“black.jpg”)
            board(5, 1) = 1
            turn = 2
            ctr += 1
        Else
            Pic6b.Image = Image.FromFile(“white.jpg”)
            board(5, 1) = 2
            turn = 1
            ctr += 1
        End If
        Pic6b.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic1c_Click(sender As Object, e As EventArgs) Handles Pic1c.Click
        If board(0, 1) = 0 And board(1, 1) = 0 And board(1, 2) = 0 And board(1, 3) = 1 And board(0, 3) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 1) = turn And board(1, 1) = turn And board(1, 2) = turn And board(1, 3) = turn And board(0, 3) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 2) <> turn And board(2, 4) <> turn And board(0, 4) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(2, 2) = turn And (board(1, 2) <> turn And board(1, 2) <> 0)) Or (board(2, 4) = turn And (board(1, 3) <> turn And board(1, 3) <> 0)) Or (board(0, 4) = turn And (board(0, 3) <> turn And board(0, 3) <> 0)) Then
            If board(2, 2) = turn And (board(1, 2) <> turn And board(1, 2) <> 0) Then
                board(1, 2) = turn
                If turn = 1 Then
                    Pic1c.Image = Image.FromFile(“black.jpg”)
                    Pic2c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1c.Image = Image.FromFile(“white.jpg”)
                    Pic2c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 4) = turn And (board(1, 3) <> turn And board(1, 3) <> 0) Then
                board(1, 3) = turn
                If turn = 1 Then
                    Pic1c.Image = Image.FromFile(“black.jpg”)
                    Pic2d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1c.Image = Image.FromFile(“white.jpg”)
                    Pic2d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(0, 4) = turn And (board(0, 3) <> turn And board(0, 3) <> 0) Then
                board(0, 3) = turn
                If turn = 1 Then
                    Pic1c.Image = Image.FromFile(“black.jpg”)
                    Pic1d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1c.Image = Image.FromFile(“white.jpg”)
                    Pic1d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic1c.Image = Image.FromFile(“black.jpg”)
            board(0, 2) = 1
            turn = 2
            ctr += 1
        Else
            Pic1c.Image = Image.FromFile(“white.jpg”)
            board(0, 2) = 2
            turn = 1
            ctr += 1
        End If
        Pic1c.Enabled = False
        Call Count()
    End Sub

    Private Sub Pic2c_Click(sender As Object, e As EventArgs) Handles Pic2c.Click
        If board(0, 1) = 0 And board(1, 1) = 0 And board(2, 1) = 0 And board(2, 2) = 1 And board(2, 3) = 0 And board(1, 3) = 0 And board(0, 3) = 0 And board(0, 2) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 1) = turn And board(1, 1) = turn And board(2, 1) = turn And board(2, 2) = turn And board(2, 3) = turn And board(1, 3) = turn And board(0, 3) = turn And board(1, 2) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 0) <> turn And board(3, 0) <> turn And board(3, 2) <> turn And board(3, 4) <> turn And board(1, 4) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(1, 0) = turn And (board(1, 1) <> turn And board(1, 1) <> 0)) Or (board(3, 0) = turn And (board(2, 1) <> turn And board(2, 1) <> 0)) Or (board(3, 2) = turn And (board(2, 2) <> turn And board(2, 2) <> 0)) Or (board(3, 4) = turn And (board(2, 3) <> turn And board(2, 3) <> 0)) Or (board(1, 4) = turn And (board(1, 3) <> turn And board(1, 3) <> 0)) Then
            If board(1, 0) = turn And (board(1, 1) <> turn And board(1, 1) <> 0) Then
                board(1, 1) = turn
                If turn = 1 Then
                    Pic2a.Image = Image.FromFile(“black.jpg”)
                    Pic2b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2a.Image = Image.FromFile(“white.jpg”)
                    Pic2b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 0) = turn And (board(2, 1) <> turn And board(2, 1) <> 0) Then
                board(2, 1) = turn
                If turn = 1 Then
                    Pic4a.Image = Image.FromFile(“black.jpg”)
                    Pic3b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4a.Image = Image.FromFile(“white.jpg”)
                    Pic3b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 2) = turn And (board(2, 2) <> turn And board(2, 2) <> 0) Then
                board(2, 2) = turn
                If turn = 1 Then
                    Pic4c.Image = Image.FromFile(“black.jpg”)
                    Pic3c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4c.Image = Image.FromFile(“white.jpg”)
                    Pic3c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 4) = turn And (board(2, 3) <> turn And board(2, 3) <> 0) Then
                board(2, 3) = turn
                If turn = 1 Then
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                    Pic3d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                    Pic3d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(1, 4) = turn And (board(1, 3) <> turn And board(1, 3) <> 0) Then
                board(1, 3) = turn
                If turn = 1 Then
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                    Pic2d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                    Pic2d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic2c.Image = Image.FromFile(“black.jpg”)
            board(1, 2) = 1
            turn = 2
            ctr += 1
        Else
            Pic2c.Image = Image.FromFile(“white.jpg”)
            board(1, 2) = 2
            turn = 1
            ctr += 1
        End If
        Pic2c.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic5c_Click(sender As Object, e As EventArgs) Handles Pic5c.Click
        If board(3, 1) = 0 And board(4, 1) = 0 And board(5, 1) = 0 And board(5, 2) = 1 And board(5, 3) = 0 And board(4, 3) = 0 And board(3, 3) = 0 And board(3, 2) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 1) = turn And board(4, 1) = turn And board(5, 1) = turn And board(5, 2) = turn And board(5, 3) = turn And board(4, 3) = turn And board(3, 3) = turn And board(3, 2) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 0) <> turn And board(4, 0) <> turn And board(2, 2) <> turn And board(2, 4) <> turn And board(4, 4) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(4, 4) = turn And (board(4, 3) <> turn And board(4, 3) <> 0)) Or (board(2, 4) = turn And (board(3, 3) <> turn And board(3, 3) <> 0)) Or (board(4, 0) = turn And (board(4, 1) <> turn And board(4, 1) <> 0)) Or (board(4, 0) = turn And (board(4, 1) <> turn And board(4, 1) <> 0)) Or (board(2, 2) = turn And (board(3, 2) <> turn And board(3, 2) <> 0)) Or (board(2, 0) = turn And (board(3, 1) <> turn And board(3, 1) <> 0)) Then
            If board(2, 0) = turn And (board(3, 1) <> turn And board(3, 1) <> 0) Then
                board(3, 1) = turn
                board(3, 1) = turn
                If turn = 1 Then
                    Pic3a.Image = Image.FromFile(“black.jpg”)
                    Pic4b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3a.Image = Image.FromFile(“white.jpg”)
                    Pic4b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 0) = turn And (board(4, 1) <> turn And board(4, 1) <> 0) Then
                board(4, 1) = turn
                If turn = 1 Then
                    Pic5a.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5a.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 2) = turn And (board(3, 2) <> turn And board(3, 2) <> 0) Then
                board(3, 2) = turn
                If turn = 1 Then
                    Pic3c.Image = Image.FromFile(“black.jpg”)
                    Pic4c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3c.Image = Image.FromFile(“white.jpg”)
                    Pic4c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 4) = turn And (board(3, 3) <> turn And board(3, 3) <> 0) Then
                board(3, 3) = turn
                If turn = 1 Then
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                    Pic4d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                    Pic4d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 4) = turn And (board(4, 3) <> turn And board(4, 3) <> 0) Then
                board(4, 3) = turn
                If turn = 1 Then
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                    Pic5d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                    Pic5d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic5c.Image = Image.FromFile(“black.jpg”)
            board(4, 2) = 1
            turn = 2
            ctr += 1
        Else
            Pic5c.Image = Image.FromFile(“white.jpg”)
            board(4, 2) = 2
            turn = 1
            ctr += 1
        End If

        Pic5c.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic6c_Click(sender As Object, e As EventArgs) Handles Pic6c.Click
        If board(4, 1) = 0 And board(5, 1) = 0 And board(5, 3) = 0 And board(4, 3) = 0 And board(4, 2) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(4, 1) = turn And board(5, 1) = turn And board(5, 3) = turn And board(4, 3) = turn And board(4, 2) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 0) <> turn And board(3, 2) <> turn And board(3, 4) <> turn And board(5, 4) <> turn And board(5, 0) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(5, 0) = turn And (board(5, 1) <> turn And board(5, 1) <> 0)) Or (board(3, 0) = turn And (board(4, 1) <> turn And board(4, 1) <> 0)) Or (board(3, 2) = turn And (board(4, 2) <> turn And board(4, 2) <> 0)) Or (board(3, 4) = turn And (board(4, 3) <> turn And board(4, 3) <> 0)) Or (board(5, 4) = turn And (board(5, 3) <> turn And board(5, 3) <> 0)) Then
            If board(5, 0) = turn And (board(5, 1) <> turn And board(5, 1) <> 0) Then
                board(5, 1) = turn
                board(5, 1) = turn
                If turn = 1 Then
                    Pic6a.Image = Image.FromFile(“black.jpg”)
                    Pic6b.Image = Image.FromFile(“black.jpg”)
                    Pic6c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6a.Image = Image.FromFile(“white.jpg”)
                    Pic6b.Image = Image.FromFile(“white.jpg”)
                    Pic6c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 0) = turn And (board(4, 1) <> turn And board(4, 1) <> 0) Then
                board(4, 1) = turn
                board(4, 1) = turn
                If turn = 1 Then
                    Pic4a.Image = Image.FromFile(“black.jpg”)
                    Pic5b.Image = Image.FromFile(“black.jpg”)
                    Pic6c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4a.Image = Image.FromFile(“white.jpg”)
                    Pic5b.Image = Image.FromFile(“white.jpg”)
                    Pic6c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 2) = turn And (board(4, 2) <> turn And board(4, 2) <> 0) Then
                board(4, 2) = turn
                board(4, 2) = turn
                If turn = 1 Then
                    Pic4c.Image = Image.FromFile(“black.jpg”)
                    Pic5c.Image = Image.FromFile(“black.jpg”)
                    Pic6c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4c.Image = Image.FromFile(“white.jpg”)
                    Pic5c.Image = Image.FromFile(“white.jpg”)
                    Pic6c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 4) = turn And (board(4, 3) <> turn And board(4, 3) <> 0) Then
                board(4, 3) = turn
                board(5, 3) = turn
                If turn = 1 Then
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                    Pic5d.Image = Image.FromFile(“black.jpg”)
                    Pic6c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                    Pic5d.Image = Image.FromFile(“white.jpg”)
                    Pic6c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 4) = turn And (board(5, 3) <> turn And board(5, 3) <> 0) Then
                board(5, 3) = turn
                board(5, 3) = turn
                If turn = 1 Then
                    Pic6e.Image = Image.FromFile(“black.jpg”)
                    Pic6d.Image = Image.FromFile(“black.jpg”)
                    Pic6c.Image = Image.FromFile(“white.jpg”)
                Else
                    Pic6e.Image = Image.FromFile(“white.jpg”)
                    Pic6d.Image = Image.FromFile(“white.jpg”)
                    Pic6c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(5, 2) = 1
            turn = 2
            ctr += 1
        Else
            board(5, 2) = 2
            turn = 1
            ctr += 1
        End If

        Pic6c.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic1d_Click(sender As Object, e As EventArgs) Handles Pic1d.Click
        If board(0, 2) = 0 And board(1, 2) = 0 And board(1, 3) = 0 And board(1, 4) = 0 And board(0, 4) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 2) = turn And board(1, 2) = turn And board(1, 3) = turn And board(1, 4) = turn And board(0, 4) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 1) <> turn And board(2, 3) <> turn And board(2, 5) <> turn And board(0, 5) <> turn And board(0, 1) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(0, 1) = turn And (board(0, 2) <> turn And board(0, 2) <> 0)) Or (board(2, 1) = turn And (board(1, 2) <> turn And board(1, 2) <> 0)) Or (board(2, 3) = turn And (board(1, 3) <> turn And board(1, 3) <> 0)) Or (board(2, 5) = turn And (board(1, 4) <> turn And board(1, 4) <> 0)) Or (board(0, 5) = turn And (board(0, 4) <> turn And board(0, 4) <> 0)) Then
            If board(0, 1) = turn And (board(0, 2) <> turn And board(0, 2) <> 0) Then
                board(0, 2) = turn
                If turn = 1 Then
                    Pic1c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 1) = turn And (board(1, 2) <> turn And board(1, 2) <> 0) Then
                board(1, 2) = turn
                If turn = 1 Then
                    Pic2c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 3) = turn And (board(1, 3) <> turn And board(1, 3) <> 0) Then
                board(1, 3) = turn
                If turn = 1 Then
                    Pic2d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 5) = turn And (board(1, 4) <> turn And board(1, 4) <> 0) Then
                board(1, 4) = turn
                board(1, 4) = turn
                If turn = 1 Then
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(0, 5) = turn And (board(0, 4) <> turn And board(0, 4) <> 0) Then
                board(0, 4) = turn
                board(0, 4) = turn
                If turn = 1 Then
                    Pic1e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic1d.Image = Image.FromFile(“black.jpg”)
            board(0, 3) = 1
            turn = 2
            ctr += 1
        Else
            Pic1d.Image = Image.FromFile(“white.jpg”)
            board(0, 3) = 2
            turn = 1
            ctr += 1
        End If

        Pic1d.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic2d_Click(sender As Object, e As EventArgs) Handles Pic2d.Click
        If board(0, 2) = 0 And board(1, 2) = 0 And board(2, 2) = 0 And board(2, 3) = 0 And board(2, 4) = 0 And board(1, 4) = 0 And board(0, 4) = 0 And board(0, 3) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 2) = turn And board(1, 2) = turn And board(2, 2) = turn And board(2, 3) = turn And board(2, 4) = turn And board(1, 4) = turn And board(0, 4) = turn And board(0, 3) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 1) <> turn And board(3, 3) <> turn And board(3, 5) <> turn And board(1, 5) <> turn And board(1, 1) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(1, 1) = turn And board(1, 2) <> turn And board(1, 2) <> 0) Or (board(3, 3) = turn And (board(2, 3) <> turn And board(2, 3) <> 0)) Or (board(3, 1) = turn And (board(2, 2) <> turn And board(2, 2) <> 0)) Or (board(3, 5) = turn And (board(2, 4) <> turn And board(2, 4) <> 0)) Or (board(1, 5) = turn And (board(1, 4) <> turn And board(1, 4) <> 0)) Then
            If board(1, 1) = turn And board(1, 2) <> turn And board(1, 2) <> 0 Then
                board(1, 2) = turn
                If turn = 1 Then
                    Pic2c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 3) = turn And (board(2, 3) <> turn And board(2, 3) <> 0) Then
                board(2, 3) = turn
                If turn = 1 Then
                    Pic3d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 1) = turn And (board(2, 2) <> turn And board(2, 2) <> 0) Then
                board(2, 2) = turn
                If turn = 1 Then
                    Pic3c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 5) = turn And (board(2, 4) <> turn And board(2, 4) <> 0) Then
                board(2, 4) = turn
                If turn = 1 Then
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(1, 5) = turn And (board(1, 4) <> turn And board(1, 4) <> 0) Then
                board(1, 4) = turn
                If turn = 1 Then
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic2d.Image = Image.FromFile(“black.jpg”)
            board(1, 3) = 1
            turn = 2
            ctr += 1
        Else
            Pic2d.Image = Image.FromFile(“white.jpg”)
            board(1, 3) = 2
            turn = 1
            ctr += 1
        End If


        Pic2d.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic5d_Click(sender As Object, e As EventArgs) Handles Pic5d.Click
        If board(5, 3) = 0 And board(5, 4) = 0 And board(4, 4) = 0 And board(3, 4) = 0 And board(3, 3) = 0 And board(3, 2) = 0 And board(4, 2) = 0 And board(5, 2) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(5, 3) = turn And board(5, 4) = turn And board(4, 4) = turn And board(3, 4) = turn And board(3, 3) = turn And board(3, 2) = turn And board(4, 2) = turn And board(5, 2) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 1) <> turn And board(2, 3) <> turn And board(2, 5) <> turn And board(4, 5) <> turn And board(4, 1) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(4, 1) = turn And board(4, 2) <> turn And board(4, 2) <> 0) Or (board(2, 3) = turn And (board(3, 3) <> turn And board(3, 3) <> 0)) Or (board(2, 1) = turn And (board(3, 2) <> turn And board(3, 2) <> 0)) Or (board(2, 5) = turn And (board(3, 4) <> turn And board(3, 4) <> 0)) Or (board(4, 5) = turn And (board(4, 4) <> turn And board(4, 4) <> 0)) Then
            If board(4, 1) = turn And board(4, 2) <> turn And board(4, 2) <> 0 Then
                board(4, 2) = turn
                If turn = 1 Then
                    Pic5c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 3) = turn And (board(3, 3) <> turn And board(3, 3) <> 0) Then
                board(3, 3) = turn
                If turn = 1 Then
                    Pic4d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 1) = turn And (board(3, 2) <> turn And board(3, 2) <> 0) Then
                board(3, 2) = turn
                If turn = 1 Then
                    Pic4c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 5) = turn And (board(3, 4) <> turn And board(3, 4) <> 0) Then
                board(3, 4) = turn
                If turn = 1 Then
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 5) = turn And (board(4, 4) <> turn And board(4, 4) <> 0) Then
                board(4, 4) = turn
                If turn = 1 Then
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic5d.Image = Image.FromFile(“black.jpg”)
            board(0, 3) = 1
            turn = 2
            ctr += 1
        Else
            Pic5d.Image = Image.FromFile(“white.jpg”)
            board(0, 3) = 2
            turn = 1
            ctr += 1
        End If


        Pic5d.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic6d_Click(sender As Object, e As EventArgs) Handles Pic6d.Click
        If board(4, 3) = 0 And board(4, 4) = 0 And board(4, 2) = 0 And board(5, 2) = 0 And board(5, 4) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(4, 3) = turn And board(4, 4) = turn And board(4, 2) = turn And board(5, 2) = turn And board(5, 4) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(5, 1) <> turn And board(3, 3) <> turn And board(3, 5) <> turn And board(5, 5) <> turn And board(3, 1) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(5, 1) = turn And (board(5, 2) <> turn And board(5, 2) <> 0)) Or (board(3, 3) = turn And (board(4, 3) <> turn And board(4, 3) <> 0)) Or (board(3, 1) = turn And (board(4, 2) <> turn And board(4, 2) <> 0)) Or (board(3, 5) = turn And (board(4, 4) <> turn And board(4, 4) <> 0)) Or (board(5, 5) = turn And (board(5, 4) <> turn And board(5, 4) <> 0)) Then
            If board(5, 1) = turn And (board(5, 2) <> turn And board(5, 2) <> 0) Then
                board(5, 2) = turn
                If turn = 1 Then
                    Pic6c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 3) = turn And (board(4, 3) <> turn And board(4, 3) <> 0) Then
                board(4, 3) = turn
                If turn = 1 Then
                    Pic5d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 1) = turn And (board(4, 2) <> turn And board(4, 2) <> 0) Then
                board(4, 2) = turn
                If turn = 1 Then
                    Pic5c.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5c.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 5) = turn And (board(4, 4) <> turn And board(4, 4) <> 0) Then
                board(4, 4) = turn
                If turn = 1 Then
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 5) = turn And (board(5, 4) <> turn And board(5, 4) <> 0) Then
                board(5, 4) = turn
                If turn = 1 Then
                    Pic6e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic6d.Image = Image.FromFile(“black.jpg”)
            board(0, 3) = 1
            turn = 2
            ctr += 1
        Else
            Pic6d.Image = Image.FromFile(“white.jpg”)
            board(0, 3) = 2
            turn = 1
            ctr += 1
        End If

        Pic6d.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic1e_Click(sender As Object, e As EventArgs) Handles Pic1e.Click
        If board(0, 3) = 0 And board(1, 3) = 0 And board(1, 4) = 0 And board(1, 5) = 0 And board(0, 5) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 3) = turn And board(1, 3) = turn And board(1, 4) = turn And board(1, 5) = turn And board(0, 5) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 2) <> turn And board(2, 2) <> turn And board(2, 4) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(0, 2) = turn And (board(0, 3) <> turn And board(0, 3) <> 0)) Or (board(2, 2) = turn And (board(1, 3) <> turn And board(1, 3) <> 0)) Or (board(2, 4) = turn And (board(1, 4) <> turn And board(1, 4) <> 0)) Then
            If board(0, 2) = turn And (board(0, 3) <> turn And board(0, 3) <> 0) Then
                board(0, 3) = turn
                If turn = 1 Then
                    Pic1d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 2) = turn And (board(1, 3) <> turn And board(1, 3) <> 0) Then
                board(1, 3) = turn
                If turn = 1 Then
                    Pic2d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 4) = turn And (board(1, 4) <> turn And board(1, 4) <> 0) Then
                board(1, 4) = turn
                If turn = 1 Then
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            Pic1d.Image = Image.FromFile(“white.jpg”)
            board(0, 4) = 1
            turn = 2
            ctr += 1
        Else
            Pic1d.Image = Image.FromFile(“white.jpg”)
            board(0, 4) = 2
            turn = 1
            ctr += 1
        End If

        Pic1e.Enabled = False
        Call Count()
    End Sub

    Private Sub Pic2e_Click(sender As Object, e As EventArgs) Handles Pic2e.Click
        If board(0, 3) = 0 And board(1, 3) = 0 And board(2, 3) = 0 And board(2, 4) = 0 And board(2, 5) = 0 And board(1, 5) = 0 And board(0, 5) = 0 And board(0, 4) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 3) = turn And board(1, 3) = turn And board(2, 3) = turn And board(2, 4) = turn And board(2, 5) = turn And board(1, 5) = turn And board(0, 5) = turn And board(0, 4) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 2) <> turn And board(3, 2) <> turn And board(3, 4) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(1, 2) = turn And (board(1, 3) <> turn And board(1, 3) <> 0)) Or (board(3, 2) = turn And (board(2, 3) <> turn And board(2, 3) <> 0)) Or (board(3, 4) = turn And (board(2, 4) <> turn And board(2, 4) <> 0)) Then
            If board(1, 2) = turn And (board(1, 3) <> turn And board(1, 3) <> 0) Then
                board(1, 3) = turn
                If turn = 1 Then
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                    Pic2d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                    Pic2d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 2) = turn And (board(2, 3) <> turn And board(2, 3) <> 0) Then
                board(2, 3) = turn
                If turn = 1 Then
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                    Pic3d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                    Pic3d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 4) = turn And (board(2, 4) <> turn And board(2, 4) <> 0) Then
                board(2, 4) = turn
                If turn = 1 Then
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(1, 4) = 1
            turn = 2
            ctr += 1
        Else
            board(1, 4) = 2
            turn = 1
            ctr += 1
        End If

        Pic2e.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic3e_Click(sender As Object, e As EventArgs) Handles Pic3e.Click
        If board(1, 3) = 0 And board(2, 3) = 0 And board(3, 3) = 0 And board(3, 4) = 0 And board(3, 5) = 0 And board(2, 5) = 0 And board(1, 5) = 0 And board(1, 4) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 3) = turn And board(2, 3) = turn And board(3, 3) = turn And board(3, 4) = turn And board(3, 5) = turn And board(2, 5) = turn And board(1, 5) = turn And board(1, 4) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 2) <> turn And board(2, 2) <> turn And board(4, 2) <> turn And board(4, 4) <> turn And board(4, 0) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(0, 2) = turn And (board(1, 3) <> turn And board(1, 3) <> 0)) Or (board(2, 2) = turn And (board(2, 3) <> turn And board(2, 3) <> 0)) Or (board(4, 2) = turn And (board(3, 3) <> turn And board(3, 3) <> 0)) Or (board(4, 4) = turn And (board(3, 4) <> turn And board(3, 4) <> 0)) Or (board(0, 4) = turn And (board(1, 4) <> turn And board(1, 4) <> 0)) Then
            If board(0, 2) = turn And (board(1, 3) <> turn And board(1, 3) <> 0) Then
                board(1, 3) = turn
                If turn = 1 Then
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                    Pic2d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                    Pic2d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 2) = turn And (board(2, 3) <> turn And board(2, 3) <> 0) Then
                board(2, 3) = turn
                If turn = 1 Then
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                    Pic3d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                    Pic3d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 2) = turn And (board(3, 3) <> turn And board(3, 3) <> 0) Then
                board(3, 3) = turn
                If turn = 1 Then
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                    Pic4d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                    Pic4d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 4) = turn And (board(3, 4) <> turn And board(3, 4) <> 0) Then
                board(3, 4) = turn
                If turn = 1 Then
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(0, 4) = turn And (board(1, 4) <> turn And board(1, 4) <> 0) Then
                board(1, 4) = turn
                If turn = 1 Then
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(2, 4) = 1
            turn = 2
            ctr += 1
        Else
            board(2, 4) = 2
            turn = 1
            ctr += 1
        End If
        Pic3e.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic4e_Click(sender As Object, e As EventArgs) Handles Pic4e.Click
        If board(2, 3) = 0 And board(3, 3) = 0 And board(4, 3) = 0 And board(4, 4) = 0 And board(4, 5) = 0 And board(3, 5) = 0 And board(2, 5) = 0 And board(2, 4) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 3) = turn And board(3, 3) = turn And board(4, 3) = turn And board(4, 4) = turn And board(4, 5) = turn And board(3, 5) = turn And board(2, 5) = turn And board(2, 4) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 4) <> turn And board(1, 2) <> turn And board(3, 2) <> turn And board(5, 2) <> turn And board(5, 4) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(1, 4) = turn And (board(2, 4) <> turn And board(2, 4) <> 0)) Or (board(1, 2) = turn And (board(2, 3) <> turn And board(2, 3) <> 0)) Or (board(3, 2) = turn And (board(3, 3) <> turn And board(3, 3) <> 0)) Or (board(5, 2) = turn And (board(4, 3) <> turn And board(4, 3) <> 0)) Or (board(5, 4) = turn And (board(4, 4) <> turn And board(4, 4) <> 0)) Then
            If board(1, 4) = turn And (board(2, 4) <> turn And board(2, 4) <> 0) Then
                board(2, 4) = turn
                If turn = 1 Then
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(1, 2) = turn And (board(2, 3) <> turn And board(2, 3) <> 0) Then
                board(2, 3) = turn
                If turn = 1 Then
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                    Pic3d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                    Pic3d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 2) = turn And (board(3, 3) <> turn And board(3, 3) <> 0) Then
                board(3, 3) = turn
                If turn = 1 Then
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                    Pic4d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                    Pic4d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 2) = turn And (board(4, 3) <> turn And board(4, 3) <> 0) Then
                board(4, 3) = turn
                If turn = 1 Then
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                    Pic5d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                    Pic5d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 4) = turn And (board(4, 4) <> turn And board(4, 4) <> 0) Then
                board(4, 4) = turn
                If turn = 1 Then
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(3, 4) = 1
            turn = 2
            ctr += 1
        Else
            board(3, 4) = 2
            turn = 1
            ctr += 1
        End If
        Pic4e.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic5e_Click(sender As Object, e As EventArgs) Handles Pic5e.Click
        If board(3, 3) = 0 And board(4, 3) = 0 And board(5, 3) = 0 And board(5, 4) = 0 And board(5, 5) = 0 And board(4, 5) = 0 And board(3, 5) = 0 And board(3, 4) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 3) = turn And board(4, 3) = turn And board(5, 3) = turn And board(5, 4) = turn And board(5, 5) = turn And board(4, 5) = turn And board(3, 5) = turn And board(3, 4) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 4) <> turn And board(2, 2) <> turn And board(4, 2) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(2, 4) = turn And (board(3, 4) <> turn And board(3, 4) <> 0)) Or (board(2, 2) = turn And (board(3, 3) <> turn And board(3, 3) <> 0)) Or (board(4, 2) = turn And (board(4, 3) <> turn And board(4, 3) <> 0)) Then
            If board(2, 4) = turn And (board(3, 4) <> turn And board(3, 4) <> 0) Then
                board(3, 4) = turn
                If turn = 1 Then
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 2) = turn And (board(3, 3) <> turn And board(3, 3) <> 0) Then
                board(3, 3) = turn
                If turn = 1 Then
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                    Pic4d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                    Pic4d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 2) = turn And (board(4, 3) <> turn And board(4, 3) <> 0) Then
                board(4, 3) = turn
                If turn = 1 Then
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                    Pic5d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                    Pic5d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If
        If turn = 1 Then
            board(4, 4) = 1
            turn = 2
            ctr += 1
        Else
            board(4, 4) = 2
            turn = 1
            ctr += 1
        End If
        Pic5e.Enabled = False
        Call Count()
    End Sub

    Private Sub Pic6e_Click(sender As Object, e As EventArgs) Handles Pic6e.Click
        If board(5, 3) = 0 And board(4, 3) = 0 And board(4, 4) = 0 And board(4, 5) = 0 And board(5, 5) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(5, 3) = turn And board(4, 3) = turn And board(4, 4) = turn And board(4, 5) = turn And board(5, 5) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 4) <> turn And board(3, 2) <> turn And board(5, 2) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(3, 4) = turn And (board(4, 4) <> turn And board(4, 4) <> 0)) Or (board(3, 2) = turn And (board(4, 3) <> turn And board(4, 3) <> 0)) Or (board(5, 2) = turn And (board(5, 3) <> turn And board(5, 3) <> 0)) Then
            If board(3, 4) = turn And (board(4, 4) <> turn And board(4, 4) <> 0) Then
                board(4, 4) = turn
                If turn = 1 Then
                    Pic6e.Image = Image.FromFile(“black.jpg”)
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6e.Image = Image.FromFile(“white.jpg”)
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 2) = turn And (board(4, 3) <> turn And board(4, 3) <> 0) Then
                board(4, 3) = turn
                If turn = 1 Then
                    Pic6e.Image = Image.FromFile(“black.jpg”)
                    Pic5d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6e.Image = Image.FromFile(“white.jpg”)
                    Pic5d.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 2) = turn And (board(5, 3) <> turn And board(5, 3) <> 0) Then
                board(5, 3) = turn
                If turn = 1 Then
                    Pic6e.Image = Image.FromFile(“black.jpg”)
                    Pic6d.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6e.Image = Image.FromFile(“white.jpg”)
                    Pic6d.Image = Image.FromFile(“white.jpg”)
                End If
            End If

        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(5, 4) = 1
            turn = 2
            ctr += 1
        Else
            board(5, 4) = 2
            turn = 1
            ctr += 1
        End If
        Pic6e.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic1f_Click(sender As Object, e As EventArgs) Handles Pic1f.Click
        If board(0, 4) = 0 And board(1, 4) = 0 And board(1, 5) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 4) = turn And board(1, 4) = turn And board(1, 5) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 3) <> turn And board(2, 3) <> turn And board(2, 5) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(0, 3) = turn And (board(0, 4) <> turn And board(0, 4) <> 0)) Or (board(2, 3) = turn And (board(1, 4) <> turn And board(1, 4) <> 0)) Or (board(2, 5) = turn And (board(1, 5) <> turn And board(1, 5) <> 0)) Then
            If board(0, 3) = turn And (board(0, 4) <> turn And board(0, 4) <> 0) Then
                board(0, 4) = turn
                If turn = 1 Then
                    Pic1e.Image = Image.FromFile(“black.jpg”)
                    Pic1f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1e.Image = Image.FromFile(“white.jpg”)
                    Pic1f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 3) = turn And (board(1, 4) <> turn And board(1, 4) <> 0) Then
                board(1, 4) = turn
                If turn = 1 Then
                    Pic1f.Image = Image.FromFile(“black.jpg”)
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1f.Image = Image.FromFile(“white.jpg”)
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 5) = turn And (board(1, 5) <> turn And board(1, 5) <> 0) Then
                board(1, 5) = turn
                If turn = 1 Then
                    Pic1f.Image = Image.FromFile(“black.jpg”)
                    Pic2f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1f.Image = Image.FromFile(“white.jpg”)
                    Pic2f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(0, 5) = 1
            turn = 2
            ctr += 1
        Else
            board(0, 5) = 2
            turn = 1
            ctr += 1
        End If
        Pic1f.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic2f_Click(sender As Object, e As EventArgs) Handles Pic2f.Click
        If board(0, 5) = 0 And board(0, 4) = 0 And board(1, 4) = 0 And board(2, 4) = 0 And board(2, 5) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 5) = turn And board(0, 4) = turn And board(1, 4) = turn And board(2, 4) = turn And board(2, 5) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 3) <> turn And board(3, 3) <> turn And board(3, 5) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(1, 3) = turn And (board(1, 4) <> turn And board(1, 4) <> 0)) Or (board(3, 3) = turn And (board(2, 4) <> turn And board(2, 4) <> 0)) Or (board(3, 5) = turn And (board(2, 5) <> turn And board(2, 5) <> 0)) Then
            If board(1, 3) = turn And (board(1, 4) <> turn And board(1, 4) <> 0) Then
                board(1, 4) = turn
                If turn = 1 Then
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                    Pic2f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                    Pic2f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 3) = turn And (board(2, 4) <> turn And board(2, 4) <> 0) Then
                board(2, 4) = turn
                If turn = 1 Then
                    Pic2f.Image = Image.FromFile(“black.jpg”)
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic2f.Image = Image.FromFile(“white.jpg”)
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 5) = turn And (board(2, 5) <> turn And board(2, 5) <> 0) Then
                board(2, 5) = turn
                If turn = 1 Then
                    Pic1f.Image = Image.FromFile(“black.jpg”)
                    Pic3f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic1f.Image = Image.FromFile(“white.jpg”)
                    Pic3f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(1, 5) = 1
            turn = 2
            ctr += 1
        Else
            board(1, 5) = 2
            turn = 1
            ctr += 1
        End If
        Pic2f.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic3f_Click(sender As Object, e As EventArgs) Handles Pic3f.Click
        If board(1, 5) = 0 And board(1, 4) = 0 And board(2, 4) = 0 And board(3, 4) = 0 And board(3, 5) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 5) = turn And board(1, 4) = turn And board(2, 4) = turn And board(3, 4) = turn And board(3, 5) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(0, 5) <> turn And board(0, 3) <> turn And board(2, 3) <> turn And board(4, 3) <> turn And board(4, 5) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(0, 5) = turn And (board(1, 5) <> turn And board(1, 5) <> 0)) Or (board(0, 3) = turn And (board(1, 4) <> turn And board(1, 4) <> 0)) Or (board(2, 3) = turn And (board(2, 4) <> turn And board(2, 4) <> 0)) Or (board(4, 3) = turn And (board(3, 4) <> turn And board(3, 4) <> 0)) Or (board(4, 5) = turn And (board(3, 5) <> turn And board(3, 5) <> 0)) Then
            If board(0, 5) = turn And (board(1, 5) <> turn And board(1, 5) <> 0) Then
                board(1, 5) = turn
                If turn = 1 Then
                    Pic3f.Image = Image.FromFile(“black.jpg”)
                    Pic2f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3f.Image = Image.FromFile(“white.jpg”)
                    Pic2f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(0, 3) = turn And (board(1, 4) <> turn And board(1, 4) <> 0) Then
                board(1, 4) = turn
                If turn = 1 Then
                    Pic3f.Image = Image.FromFile(“black.jpg”)
                    Pic2e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3f.Image = Image.FromFile(“white.jpg”)
                    Pic2e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 3) = turn And (board(2, 4) <> turn And board(2, 4) <> 0) Then
                board(2, 4) = turn
                If turn = 1 Then
                    Pic3f.Image = Image.FromFile(“black.jpg”)
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3f.Image = Image.FromFile(“white.jpg”)
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 3) = turn And (board(3, 4) <> turn And board(3, 4) <> 0) Then
                board(3, 4) = turn
                If turn = 1 Then
                    Pic3f.Image = Image.FromFile(“black.jpg”)
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3f.Image = Image.FromFile(“white.jpg”)
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(4, 5) = turn And (board(3, 5) <> turn And board(3, 5) <> 0) Then
                board(3, 5) = turn
                If turn = 1 Then
                    Pic3f.Image = Image.FromFile(“black.jpg”)
                    Pic4f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic3f.Image = Image.FromFile(“white.jpg”)
                    Pic4f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(2, 5) = 1
            turn = 2
            ctr += 1
        Else
            board(2, 5) = 2
            turn = 1
            ctr += 1
        End If
        Pic3f.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic4f_Click(sender As Object, e As EventArgs) Handles Pic4f.Click
        If board(2, 5) = 0 And board(2, 4) = 0 And board(3, 4) = 0 And board(4, 4) = 0 And board(4, 5) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(2, 5) = turn And board(2, 4) = turn And board(3, 4) = turn And board(4, 4) = turn And board(4, 5) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(1, 5) <> turn And board(1, 3) <> turn And board(3, 3) <> turn And board(5, 3) <> turn And board(5, 5) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(1, 5) = turn And (board(2, 5) <> turn And board(2, 5) <> 0)) Or (board(1, 3) = turn And (board(2, 4) <> turn And board(2, 4) <> 0)) Or (board(3, 3) = turn And (board(3, 4) <> turn And board(3, 4) <> 0)) Or (board(5, 3) = turn And (board(4, 4) <> turn And board(4, 4) <> 0)) Or (board(5, 5) = turn And (board(4, 5) <> turn And board(4, 5) <> 0)) Then
            If board(1, 5) = turn And (board(2, 5) <> turn And board(2, 5) <> 0) Then
                board(2, 5) = turn
                If turn = 1 Then
                    Pic4f.Image = Image.FromFile(“black.jpg”)
                    Pic3f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4f.Image = Image.FromFile(“white.jpg”)
                    Pic3f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(1, 3) = turn And (board(2, 4) <> turn And board(2, 4) <> 0) Then
                board(2, 4) = turn
                If turn = 1 Then
                    Pic4f.Image = Image.FromFile(“black.jpg”)
                    Pic3e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4f.Image = Image.FromFile(“white.jpg”)
                    Pic3e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 3) = turn And (board(3, 4) <> turn And board(3, 4) <> 0) Then
                board(3, 4) = turn
                If turn = 1 Then
                    Pic4f.Image = Image.FromFile(“black.jpg”)
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4f.Image = Image.FromFile(“white.jpg”)
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 3) = turn And (board(4, 4) <> turn And board(4, 4) <> 0) Then
                board(4, 4) = turn
                If turn = 1 Then
                    Pic4f.Image = Image.FromFile(“black.jpg”)
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4f.Image = Image.FromFile(“white.jpg”)
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(5, 5) = turn And (board(4, 5) <> turn And board(4, 5) <> 0) Then
                board(4, 5) = turn
                If turn = 1 Then
                    Pic4f.Image = Image.FromFile(“black.jpg”)
                    Pic5f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic4f.Image = Image.FromFile(“white.jpg”)
                    Pic5f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(3, 5) = 1
            turn = 2
            ctr += 1
        Else
            board(3, 5) = 2
            turn = 1
            ctr += 1
        End If
        Pic4f.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic5f_Click(sender As Object, e As EventArgs) Handles Pic5f.Click
        If board(3, 5) = 0 And board(3, 4) = 0 And board(4, 4) = 0 And board(5, 4) = 0 And board(5, 5) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(3, 5) = turn And board(3, 4) = turn And board(4, 4) = turn And board(5, 4) = turn And board(5, 5) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(4, 3) <> turn And board(2, 3) <> turn And board(2, 5) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(4, 3) = turn And (board(4, 4) <> turn And board(4, 4) <> 0)) Or (board(2, 3) = turn And (board(3, 4) <> turn And board(3, 4) <> 0)) Or (board(2, 5) = turn And (board(3, 5) <> turn And board(3, 5) <> 0)) Then
            If board(4, 3) = turn And (board(4, 4) <> turn And board(4, 4) <> 0) Then
                board(4, 4) = turn
                If turn = 1 Then
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                    Pic5f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                    Pic5f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 3) = turn And (board(3, 4) <> turn And board(3, 4) <> 0) Then
                board(3, 4) = turn
                If turn = 1 Then
                    Pic5f.Image = Image.FromFile(“black.jpg”)
                    Pic4e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5f.Image = Image.FromFile(“white.jpg”)
                    Pic4e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(2, 5) = turn And (board(3, 5) <> turn And board(3, 5) <> 0) Then
                board(3, 5) = turn
                If turn = 1 Then
                    Pic5f.Image = Image.FromFile(“black.jpg”)
                    Pic4f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic5f.Image = Image.FromFile(“white.jpg”)
                    Pic4f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(4, 5) = 1
            turn = 2
            ctr += 1
        Else
            board(4, 5) = 2
            turn = 1
            ctr += 1
        End If
        Pic5f.Enabled = False
        Call Count()
    End Sub
    Private Sub Pic6f_Click(sender As Object, e As EventArgs) Handles Pic6f.Click
        If board(4, 4) = 0 And board(5, 4) = 0 And board(5, 5) = 0 Then
            Call Illegal()
            Exit Sub
        ElseIf board(4, 4) = turn And board(5, 4) = turn And board(5, 5) = turn Then
            Call Illegal()
            Exit Sub
        ElseIf board(5, 3) <> turn And board(3, 3) <> turn And board(3, 5) <> turn Then
            Call Illegal()
            Exit Sub
        ElseIf (board(5, 3) = turn And (board(5, 4) <> turn And board(5, 4) <> 0)) Or (board(3, 3) = turn And (board(4, 4) <> turn And board(4, 4) <> 0)) Or (board(3, 5) = turn And (board(4, 5) <> turn And board(4, 5) <> 0)) Then
            If board(5, 3) = turn And (board(5, 4) <> turn And board(5, 4) <> 0) Then
                board(5, 4) = turn
                If turn = 1 Then
                    Pic6e.Image = Image.FromFile(“black.jpg”)
                    Pic6f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6e.Image = Image.FromFile(“white.jpg”)
                    Pic6f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 3) = turn And (board(4, 4) <> turn And board(4, 4) <> 0) Then
                board(4, 4) = turn
                If turn = 1 Then
                    Pic6f.Image = Image.FromFile(“black.jpg”)
                    Pic5e.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6f.Image = Image.FromFile(“white.jpg”)
                    Pic5e.Image = Image.FromFile(“white.jpg”)
                End If
            End If
            If board(3, 5) = turn And (board(4, 5) <> turn And board(4, 5) <> 0) Then
                board(4, 5) = turn
                If turn = 1 Then
                    Pic6f.Image = Image.FromFile(“black.jpg”)
                    Pic5f.Image = Image.FromFile(“black.jpg”)
                Else
                    Pic6f.Image = Image.FromFile(“white.jpg”)
                    Pic5f.Image = Image.FromFile(“white.jpg”)
                End If
            End If
        Else
            Call Illegal()
            Exit Sub
        End If

        If turn = 1 Then
            board(5, 5) = 1
            turn = 2
            ctr += 1
        Else
            board(5, 5) = 2
            turn = 1
            ctr += 1
        End If
        Pic6f.Enabled = False
        Call Count()
    End Sub
End Class