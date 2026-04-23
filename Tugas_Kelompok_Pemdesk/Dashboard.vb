Public Class Dashboard

    ' === TAMBAHKAN DUA BARIS INI UNTUK MENYIMPAN MEMORI FORM ===
    Public Shared frmPesertaApp As New Peserta()
    Public Shared frmTeamApp As New team()

    ' Ubah fungsi kliknya menjadi seperti ini:
    Private Sub BukaFormPeserta(sender As Object, e As EventArgs) Handles pnlCompetitors.Click, picCompetitors.Click, lblCompetitors.Click
        ' Menampilkan form yang tersimpan di memori, BUKAN membuat baru
        frmPesertaApp.ShowDialog()
    End Sub

    ' Fungsi tambahan untuk tombol aktivasi agar interaktif
    Private Sub btnActivation_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Silakan masukkan 16 digit kode aktivasi Tatami Anda.", "Aktivasi Sistem", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Tambahan interaksi untuk menu lain (Bisa disesuaikan nanti)
    Private Sub pnlKumite_Click(sender As Object, e As EventArgs) Handles pnlKumite.Click, picKumite.Click, lblKumite.Click
        MessageBox.Show("Modul Kumite belum diimplementasikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class