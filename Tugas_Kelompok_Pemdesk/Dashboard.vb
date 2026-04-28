Public Class Dashboard


    Public Shared frmPesertaApp As New Peserta()
    Public Shared frmTeamApp As New team()
    Public Shared frmKumiteApp As New KumiteMainControl()


    Private Sub BukaFormPeserta(sender As Object, e As EventArgs) _
        Handles pnlCompetitors.Click, picCompetitors.Click, lblCompetitors.Click
        frmPesertaApp.ShowDialog()

    End Sub

    Private Sub pnlKumite_Click(sender As Object, e As EventArgs) _
        Handles pnlKumite.Click, picKumite.Click, lblKumite.Click
        frmKumiteApp.ShowDialog()

    End Sub

    Private Sub btnActivation_Click(sender As Object, e As EventArgs)
        MessageBox.Show(
            "Silakan masukkan 16 digit kode aktivasi Tatami Anda.",
            "Aktivasi Sistem",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub

End Class