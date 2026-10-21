Public Class SplashForm
    Private Sub Splashform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Progress bar settings
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        'Timer settings
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)

        lblLoading.Text = "Loading... " & ProgressBar1.Value & "%"

        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()

            Dim f As New Form1
            Form1.Show()

            Me.Hide()
        End If
    End Sub

End Class