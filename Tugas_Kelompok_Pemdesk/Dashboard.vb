Public Class Dashboard


    Public Shared frmPesertaApp As New Peserta()
    Public Shared frmTeamApp As New team()
    Public Shared frmKumiteApp As New KumiteMainControl()
    Public Shared frmKataApp As New KataMainControl()


    Private Sub BukaFormPeserta(sender As Object, e As EventArgs) _
        Handles pnlCompetitors.Click, picCompetitors.Click, lblCompetitors.Click

        ' ==========================================================
        ' GERBANG VALIDASI: CEK STATUS MEMORI FORM PESERTA (ANTI-CRASH)
        ' ==========================================================
        ' Jika variabel frmPesertaApp belum dibuat ATAU sudah pernah ditutup sebelumnya
        If frmPesertaApp Is Nothing OrElse frmPesertaApp.IsDisposed Then

            ' Maka lahirkan kembali objek form Peserta yang segar ke dalam RAM
            frmPesertaApp = New Peserta()

        End If

        ' Tampilkan form Peserta secara independen dan fleksibel (Modeless)
        frmPesertaApp.Show()

    End Sub

    Private Sub pnlKumite_Click(sender As Object, e As EventArgs) _
        Handles pnlKumite.Click, picKumite.Click, lblKumite.Click

        ' ==========================================================
        ' GERBANG VALIDASI: CEK STATUS MEMORI FORM (ANTI-CRASH)
        ' ==========================================================
        ' Jika variabel frmKumiteApp belum ada nilainya (Nothing) 
        ' ATAU sudah pernah ditutup oleh user sebelumnya (IsDisposed)
        If frmKumiteApp Is Nothing OrElse frmKumiteApp.IsDisposed Then

            ' Maka buat ulang pondasi form Kumite yang baru ke dalam memori
            frmKumiteApp = New KumiteMainControl()

        End If

        ' Tampilkan form Kumite dengan aman dan fleksibel (Modeless)
        frmKumiteApp.Show()

    End Sub

    Private Sub btnActivation_Click(sender As Object, e As EventArgs)
        MessageBox.Show(
            "Silakan masukkan 16 digit kode aktivasi Tatami Anda.",
            "Aktivasi Sistem",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Mematikan seluruh proses aplikasi agar file .exe tidak terkunci
        Application.Exit()
    End Sub
End Class