Public Class Dashboard

    Public Shared frmPesertaApp As New Peserta()
    Public Shared frmTeamApp As New team()

    Private Sub BukaFormPeserta(sender As Object, e As EventArgs) Handles pnlCompetitors.Click, picCompetitors.Click, lblCompetitors.Click
        frmPesertaApp.ShowDialog()
    End Sub


    Private Sub btnActivation_Click(sender As Object, e As EventArgs) Handles btnActivation.Click
        MessageBox.Show("Silakan masukkan 16 digit kode aktivasi Tatami Anda.", "Aktivasi Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub pnlKumite_Click(sender As Object, e As EventArgs) Handles pnlKumite.Click, picKumite.Click, lblKumite.Click
        MessageBox.Show("Modul Kumite belum diimplementasikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class