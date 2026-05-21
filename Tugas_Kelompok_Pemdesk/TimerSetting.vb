' =========================================================
' TIMERSETTING.VB
' =========================================================

Public Class TimerSetting

    Dim totalTime As Double
    Dim frmWait As New FrmWaitingTimer

    Private Sub TimerSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTimer.Text = "0:00.0"

    End Sub

    Private Sub btnStartWaiting_Click(sender As Object, e As EventArgs) Handles btnStartWaiting.Click

        totalTime = (numMinuteWaiting.Value * 60) + numSecondWaiting.Value

        frmWait.Show()

        tmrWaiting.Start()

    End Sub
    Private Sub tmrWaiting_Tick(sender As Object, e As EventArgs) Handles tmrWaiting.Tick

        If totalTime > 0 Then

            totalTime -= 0.1

            Dim menit As Integer = Math.Floor(totalTime / 60)
            Dim detik As Integer = Math.Floor(totalTime Mod 60)
            Dim mili As Integer = (totalTime * 10) Mod 10

            lblTimer.Text =
                menit & ":" &
                detik.ToString("00") &
                "." &
                mili.ToString()

            frmWait.UpdateTimer(lblTimer.Text)

        Else

            tmrWaiting.Stop()

            MessageBox.Show("Waktu Habis!")

        End If

    End Sub


    Private Sub btnStopWaiting_Click(sender As Object, e As EventArgs) Handles btnStopWaiting.Click

        tmrWaiting.Stop()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        tmrWaiting.Stop()

        lblTimer.Text = "0:00.0"

    End Sub

    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click

        lblTimer.Visible = Not lblTimer.Visible

    End Sub

End Class