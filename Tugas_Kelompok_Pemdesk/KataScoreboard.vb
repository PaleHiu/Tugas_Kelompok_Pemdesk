Public Class KataScoreboard

    Private Sub KataScoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup UI State (Tampilan Fullscreen & Hitam)
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.Black

        ' Memastikan form bisa mendeteksi tekanan tombol keyboard
        Me.KeyPreview = True

        ' --- Set Nilai Default Sementara (Opsional) ---
        ' Anda bisa menghapus ini nanti jika ingin di-set langsung dari mode Design
        lblAkaScore.Text = "0"
        lblAoScore.Text = "0"
        lblAkaCompetitorName.Text = "-"
        lblAoCompetitorName.Text = "-"
        lblAkaTeamName.Text = "-"
        lblAoTeamName.Text = "-"
    End Sub

    ' Fitur untuk menutup form menggunakan tombol ESC (Escape)
    Private Sub KataScoreboard_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class