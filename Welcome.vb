Public Class Welcome
    'Chikanma Okoisor                                          'Lauren Huschke
    Dim ctr As Integer
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerWelcome.Enabled = True
        TimerWelcome.Interval = 1000

        My.Computer.Audio.Play("Music.wav")
    End Sub

    Private Sub TimerWelcome_Tick(sender As Object, e As EventArgs) Handles TimerWelcome.Tick
        ctr = ctr + 1
        If ctr >= 5 Then
            Me.Hide()
            Introduction.Show()
            TimerWelcome.Enabled = False
        End If
    End Sub
End Class
