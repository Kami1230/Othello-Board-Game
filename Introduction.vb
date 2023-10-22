Public Class Introduction
    'Chikanma Okoisor                                          'Lauren Huschke
    Private Sub BtnGame_Click(sender As Object, e As EventArgs) Handles BtnGame.Click
        Me.Close()
        Game.Show()
    End Sub

    Private Sub PicPlay_Click(sender As Object, e As EventArgs) Handles PicPlay.Click
        My.Computer.Audio.Play("Music.wav")
        PicPlay.Visible = False
        PicPause.Visible = True
    End Sub

    Private Sub PicPause_Click(sender As Object, e As EventArgs) Handles PicPause.Click
        My.Computer.Audio.Stop()
        PicPause.Visible = False
        PicPlay.Visible = True
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        End
    End Sub
End Class