Public Class KataMainControl
    Dim frmWait As New FrmWaitingTimer
    Dim totalTime As Double

    ' Konstruktor bawaan (wajib ada untuk merender Form)
    Public Sub New()

        ' Panggilan ini diwajibkan oleh desainer Windows Forms untuk membangun UI
        ' yang ada di dalam file KataMainControl.Design.vb
        InitializeComponent()

        ' (Logika, Timer, Database, dan Event Click dikosongkan sementara 
        ' agar kita bisa fokus melihat hasil render UI terlebih dahulu)

    End Sub

    Private Sub PnlCenterScore_Paint(sender As Object, e As PaintEventArgs) Handles PnlCenterScore.Paint

    End Sub

    Private Sub PnlAka_Paint(sender As Object, e As PaintEventArgs) Handles PnlAka.Paint

    End Sub

    Private Sub BtnKikenAka_Click(sender As Object, e As EventArgs) Handles BtnKikenAka.Click

    End Sub

    Private Sub LblAoDisqualification_Click(sender As Object, e As EventArgs) Handles LblAoDisqualification.Click

    End Sub

    Private Sub BtnKikenAo_Click(sender As Object, e As EventArgs) Handles BtnKikenAo.Click

    End Sub

    Private Sub BtnDetailScorePlus_Click(sender As Object, e As EventArgs) Handles BtnDetailScorePlus.Click

    End Sub

    Private Sub LblBigTotalAka_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblBigTotalAo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumAkaJ5_ValueChanged(sender As Object, e As EventArgs) Handles NumAkaJ5.ValueChanged

    End Sub

    Private Sub LblAkaJ2_Click(sender As Object, e As EventArgs) Handles LblAkaJ2.Click

    End Sub

    Private Sub LblAkaJ4_Click(sender As Object, e As EventArgs) Handles LblAkaJ4.Click

    End Sub

    Private Sub NumAoJ4_ValueChanged(sender As Object, e As EventArgs) Handles NumAoJ4.ValueChanged

    End Sub

    Private Sub TotalScoreAKA_ValueChanged(sender As Object, e As EventArgs) Handles TotalScoreAKA.ValueChanged

    End Sub

    Private Sub GrpScoreboardSelect_Enter(sender As Object, e As EventArgs) Handles GrpScoreboardSelect.Enter

    End Sub

    Private Sub PicAkaCircle_Click(sender As Object, e As EventArgs) Handles PicAkaCircle.Click

    End Sub

    Private Sub LblAkaWinnerStatus_Click(sender As Object, e As EventArgs) Handles LblAkaWinnerStatus.Click

    End Sub

    Private Sub BtnStartWaitingTimer_Click(sender As Object, e As EventArgs) Handles BtnStartWaitingTimer.Click

        totalTime = (NumWaitMin.Value * 60) + NumWaitSec.Value

        frmWait.Show()

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If totalTime > 0 Then

            totalTime -= 0.1

            Dim menit As Integer = Math.Floor(totalTime / 60)
            Dim detik As Integer = Math.Floor(totalTime Mod 60)
            Dim mili As Integer = (totalTime * 10) Mod 10

            LblTimerDisplayMain.Text =
            menit & ":" &
            detik.ToString("00") &
            "." &
            mili.ToString()

            frmWait.UpdateTimer(LblTimerDisplayMain.Text)

        Else

            Timer1.Stop()

            frmWait.Hide()

            MessageBox.Show("Waktu Habis!")

        End If

    End Sub

End Class