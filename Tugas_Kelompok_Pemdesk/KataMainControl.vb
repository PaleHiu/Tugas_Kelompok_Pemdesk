Public Class KataMainControl

    ' ==============================================================================
    ' 0. DEKLARASI VARIABEL & PROPERTI GLOBAL
    ' ==============================================================================
    Private frmLogActivity As FormLogActivity = Nothing

    ' ==============================================================================
    ' 1. KONSTRUKTOR (INITIALIZATION)
    ' ==============================================================================

    ''' <summary>
    ''' Konstruktor utama untuk inisialisasi komponen Form dan UI Scoring.
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        InitializeScoringUI()
    End Sub

    ' ==============================================================================
    ' 2. FUNGSI HELPER & KONFIGURASI UI (MANAJEMEN MODE & JURI)
    ' ==============================================================================

    ''' <summary>
    ''' Mengatur nilai default awal saat aplikasi pertama kali dimuat.
    ''' </summary>
    Private Sub InitializeScoringUI()
        RbScoreType.Checked = True
        Rb7Judge.Checked = True ' Menjamin 7 Judge sebagai default

        ToggleScoringMode()
        UpdateJudgeCountUI()
    End Sub

    ''' <summary>
    ''' Mengatur visibilitas dan efek visual panel berdasarkan mode penilaian (Skor/Bendera).
    ''' </summary>
    Private Sub ToggleScoringMode()
        Me.SuspendLayout()
        Try
            If RbScoreType.Checked Then
                ' ── MODE SCORE (Angka) ──────────────────────────────────
                PnlPointInputsAka.Visible = True
                PnlPointInputsAo.Visible = True
                PnlFlagInputsAka.Visible = False
                PnlFlagInputsAo.Visible = False

                ' Efek Visual Tombol Mode
                RbScoreType.ForeColor = Color.FromArgb(0, 80, 180)
                RbScoreType.Font = New Font(RbScoreType.Font, FontStyle.Bold)
                RbFlagSystem.ForeColor = Color.Gray
                RbFlagSystem.Font = New Font(RbFlagSystem.Font, FontStyle.Regular)

            ElseIf RbFlagSystem.Checked Then
                ' ── MODE FLAG (Bendera) ─────────────────────────────────
                PnlPointInputsAka.Visible = False
                PnlPointInputsAo.Visible = False
                PnlFlagInputsAka.Visible = True
                PnlFlagInputsAo.Visible = True

                ' Efek Visual Tombol Mode
                RbScoreType.ForeColor = Color.Gray
                RbScoreType.Font = New Font(RbScoreType.Font, FontStyle.Regular)
                RbFlagSystem.ForeColor = Color.FromArgb(0, 80, 180)
                RbFlagSystem.Font = New Font(RbFlagSystem.Font, FontStyle.Bold)
            End If
        Finally
            Me.ResumeLayout()
        End Try
    End Sub

    ''' <summary>
    ''' Mengatur visibilitas panel juri (3, 5, atau 7 juri) serta mereset data juri yang disembunyikan.
    ''' </summary>
    Private Sub UpdateJudgeCountUI()
        Me.SuspendLayout()
        Try
            Dim totalJudge As Integer = 7
            If Rb3Judge.Checked Then totalJudge = 3
            If Rb5Judge.Checked Then totalJudge = 5

            Dim showJ45 As Boolean = (totalJudge >= 5)
            Dim showJ67 As Boolean = (totalJudge = 7)

            ' ── VISIBILITAS: PANEL SCORING (ANGKA) ──────────────────────────────
            NumAkaJ4.Visible = showJ45 : LblAkaJ4.Visible = showJ45
            NumAkaJ5.Visible = showJ45 : LblAkaJ5.Visible = showJ45
            NumAkaJ6.Visible = showJ67 : LblAkaJ6.Visible = showJ67
            NumAkaJ7.Visible = showJ67 : LblAkaJ7.Visible = showJ67

            NumAoJ4.Visible = showJ45 : LblAoJ4.Visible = showJ45
            NumAoJ5.Visible = showJ45 : LblAoJ5.Visible = showJ45
            NumAoJ6.Visible = showJ67 : LblAoJ6.Visible = showJ67
            NumAoJ7.Visible = showJ67 : LblAoJ7.Visible = showJ67

            ' ── VISIBILITAS: PANEL FLAG BENDERA ──────────────────────────────────
            PnlFlagAka4.Visible = showJ45
            PnlFlagAka5.Visible = showJ45
            PnlFlagAka6.Visible = showJ67
            PnlFlagAka7.Visible = showJ67

            PnlFlagAo4.Visible = showJ45
            PnlFlagAo5.Visible = showJ45
            PnlFlagAo6.Visible = showJ67
            PnlFlagAo7.Visible = showJ67

            ' ── VISIBILITAS: LEFT BAR (STATUS LOGIN JURI) ────────────────────────
            PnlJ4.Visible = showJ45
            PnlJ5.Visible = showJ45
            PnlJ6.Visible = showJ67
            PnlJ7.Visible = showJ67

            ' ── RESET DATA JURI YANG DISEMBUNYIKAN ───────────────────────────────
            If Not showJ45 Then
                NumAkaJ4.Value = 0 : NumAkaJ5.Value = 0
                NumAoJ4.Value = 0 : NumAoJ5.Value = 0
            End If
            If Not showJ67 Then
                NumAkaJ6.Value = 0 : NumAkaJ7.Value = 0
                NumAoJ6.Value = 0 : NumAoJ7.Value = 0
            End If

            ' ── VISUAL FEEDBACK (Warna Radio Button Jumlah Juri) ─────────────────
            Rb3Judge.Font = New Font(Rb3Judge.Font, FontStyle.Regular)
            Rb5Judge.Font = New Font(Rb5Judge.Font, FontStyle.Regular)
            Rb7Judge.Font = New Font(Rb7Judge.Font, FontStyle.Regular)
            Rb3Judge.ForeColor = Color.Gray : Rb5Judge.ForeColor = Color.Gray : Rb7Judge.ForeColor = Color.Gray

            If totalJudge = 3 Then
                Rb3Judge.Font = New Font(Rb3Judge.Font, FontStyle.Bold)
                Rb3Judge.ForeColor = Color.FromArgb(0, 80, 180)
            ElseIf totalJudge = 5 Then
                Rb5Judge.Font = New Font(Rb5Judge.Font, FontStyle.Bold)
                Rb5Judge.ForeColor = Color.FromArgb(0, 80, 180)
            ElseIf totalJudge = 7 Then
                Rb7Judge.Font = New Font(Rb7Judge.Font, FontStyle.Bold)
                Rb7Judge.ForeColor = Color.FromArgb(0, 80, 180)
            End If
        Finally
            Me.ResumeLayout()
        End Try
    End Sub

    ' ==============================================================================
    ' 3. LOGIKA SISTEM BENDERA (FLAG SYSTEM ENGINE)
    ' ==============================================================================

    ''' <summary>
    ''' Mendapatkan total jumlah juri yang saat ini sedang aktif dipilih.
    ''' </summary>
    Private Function GetActiveJudgeCount() As Integer
        If Rb3Judge.Checked Then Return 3
        If Rb5Judge.Checked Then Return 5
        Return 7
    End Function

    ''' <summary>
    ''' Mengatur efek visual panel bendera juri. Warna teks dan bendera dipertahankan asli (Default),
    ''' hanya warna background yang berubah menjadi warna pudar tim saat aktif agar tetap kontras.
    ''' </summary>
    Private Sub HighlightFlag(pnl As Panel, isActive As Boolean, isAka As Boolean)
        If pnl Is Nothing Then Exit Sub

        ' 1. Definisikan Spektrum Warna Default Komponen
        Dim flagColor As Color = If(isAka, Color.Red, Color.Blue)

        ' Warna Background dibuat pudar/soft saat aktif agar tulisan di dalamnya tetap kontras tinggi
        Dim activeBackColor As Color = If(isAka, Color.FromArgb(255, 215, 215), Color.FromArgb(215, 230, 255))
        Dim inactiveBackColor As Color = Color.White

        ' 2. Atur Warna Background Panel
        If isActive Then
            pnl.BackColor = activeBackColor
        Else
            pnl.BackColor = inactiveBackColor
        End If

        ' 3. Atur Konten Label di Dalam Panel (Tetap Menggunakan Warna Default)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Label Then
                ctrl.Visible = True
                If ctrl.Text = "⚑" Then
                    ctrl.ForeColor = flagColor ' Selalu warna tim asli (Merah / Biru)
                Else
                    ctrl.ForeColor = Color.Black ' Angka skor tetap hitam untuk legibilitas maksimal
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' Memproses perubahan seluruh visual bendera juri (1-7) untuk tim AKA dan AO sekaligus memperbarui total skor.
    ''' </summary>
    Private Sub ProcessFlagVisuals(akaScore As Integer, aoScore As Integer)
        ' Tim AKA (Sisi Merah)
        HighlightFlag(PnlFlagAka1, akaScore >= 1, True)
        HighlightFlag(PnlFlagAka2, akaScore >= 2, True)
        HighlightFlag(PnlFlagAka3, akaScore >= 3, True)
        HighlightFlag(PnlFlagAka4, akaScore >= 4, True)
        HighlightFlag(PnlFlagAka5, akaScore >= 5, True)
        HighlightFlag(PnlFlagAka6, akaScore >= 6, True)
        HighlightFlag(PnlFlagAka7, akaScore >= 7, True)

        ' Tim AO (Sisi Biru)
        HighlightFlag(PnlFlagAo1, aoScore >= 1, False)
        HighlightFlag(PnlFlagAo2, aoScore >= 2, False)
        HighlightFlag(PnlFlagAo3, aoScore >= 3, False)
        HighlightFlag(PnlFlagAo4, aoScore >= 4, False)
        HighlightFlag(PnlFlagAo5, aoScore >= 5, False)
        HighlightFlag(PnlFlagAo6, aoScore >= 6, False)
        HighlightFlag(PnlFlagAo7, aoScore >= 7, False)

        ' Sinkronisasi Nilai ke Output Numeric Kontrol
        TotalScoreAKA.Value = akaScore
        TotalScoreAO.Value = aoScore
    End Sub

    ' ==============================================================================
    ' 4. EVENT HANDLERS: INTERAKSI INPUT & KLIK KOMPONEN UI
    ' ==============================================================================

    ''' <summary>
    ''' Event handler saat panel bendera tim AKA diklik oleh pengguna.
    ''' </summary>
    Private Sub FlagAka_PanelClick(sender As Object, e As EventArgs) Handles PnlFlagAka1.Click, PnlFlagAka2.Click, PnlFlagAka3.Click, PnlFlagAka4.Click, PnlFlagAka5.Click, PnlFlagAka6.Click, PnlFlagAka7.Click
        Dim clickedPanel = CType(sender, Panel)
        Dim score As Integer = 0

        ' Ekstraksi nilai skor angka dari komponen label di dalam panel (Menggunakan TryParse agar aman dari crash)
        For Each ctrl As Control In clickedPanel.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Text <> "⚑" Then
                Integer.TryParse(ctrl.Text, score)
            End If
        Next

        Dim currentAkaScore As Integer = TotalScoreAKA.Value
        Dim total = GetActiveJudgeCount()

        If score > total Then Exit Sub

        ' Mekanisme toggle reset jika skor yang sama diklik ulang, atau kalkulasi otomatis sistem Zero-Sum
        If score = currentAkaScore Then
            ProcessFlagVisuals(0, 0)
        Else
            ProcessFlagVisuals(score, total - score)
        End If
    End Sub

    ''' <summary>
    ''' Event handler saat panel bendera tim AO diklik oleh pengguna.
    ''' </summary>
    Private Sub FlagAo_PanelClick(sender As Object, e As EventArgs) Handles PnlFlagAo1.Click, PnlFlagAo2.Click, PnlFlagAo3.Click, PnlFlagAo4.Click, PnlFlagAo5.Click, PnlFlagAo6.Click, PnlFlagAo7.Click
        Dim clickedPanel = CType(sender, Panel)
        Dim score As Integer = 0

        ' Ekstraksi nilai skor angka dari komponen label di dalam panel (Menggunakan TryParse agar aman dari crash)
        For Each ctrl As Control In clickedPanel.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Text <> "⚑" Then
                Integer.TryParse(ctrl.Text, score)
            End If
        Next

        Dim currentAoScore As Integer = TotalScoreAO.Value
        Dim total = GetActiveJudgeCount()

        If score > total Then Exit Sub

        ' Mekanisme toggle reset jika skor yang sama diklik ulang, atau kalkulasi otomatis sistem Zero-Sum
        If score = currentAoScore Then
            ProcessFlagVisuals(0, 0)
        Else
            ProcessFlagVisuals(total - score, score)
        End If
    End Sub

    ''' <summary>
    ''' Menangani pemanggilan Form Log Aktivitas secara tunggal (Singleton-lite).
    ''' </summary>
    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        If frmLogActivity Is Nothing OrElse frmLogActivity.IsDisposed Then
            frmLogActivity = New FormLogActivity()
        End If

        frmLogActivity.Show()
        frmLogActivity.BringToFront()
    End Sub

    ''' <summary>
    ''' Event handler perubahan pilihan ke Mode Score (Angka).
    ''' </summary>
    Private Sub RbScoreType_CheckedChanged(sender As Object, e As EventArgs) Handles RbScoreType.CheckedChanged
        If RbScoreType.Checked Then ToggleScoringMode()
    End Sub

    ''' <summary>
    ''' Event handler perubahan pilihan ke Mode Flag (Bendera).
    ''' </summary>
    Private Sub RbFlagSystem_CheckedChanged(sender As Object, e As EventArgs) Handles RbFlagSystem.CheckedChanged
        If RbFlagSystem.Checked Then ToggleScoringMode()
    End Sub

    ''' <summary>
    ''' Event ketika opsi total juri diubah menjadi 3 orang.
    ''' </summary>
    Private Sub Rb3Judge_CheckedChanged(sender As Object, e As EventArgs) Handles Rb3Judge.CheckedChanged
        If Rb3Judge.Checked Then
            ResetScoresOnly()
            UpdateJudgeCountUI()
        End If
    End Sub

    ''' <summary>
    ''' Event ketika opsi total juri diubah menjadi 5 orang.
    ''' </summary>
    Private Sub Rb5Judge_CheckedChanged(sender As Object, e As EventArgs) Handles Rb5Judge.CheckedChanged
        If Rb5Judge.Checked Then
            ResetScoresOnly()
            UpdateJudgeCountUI()
        End If
    End Sub

    ''' <summary>
    ''' Event ketika opsi total juri diubah menjadi 7 orang.
    ''' </summary>
    Private Sub Rb7Judge_CheckedChanged(sender As Object, e As EventArgs) Handles Rb7Judge.CheckedChanged
        If Rb7Judge.Checked Then
            ResetScoresOnly()
            UpdateJudgeCountUI()
        End If
    End Sub

    ' ==============================================================================
    ' 5. MASTER RESET DATA & SCORE MANAJEMEN
    ' ==============================================================================

    ''' <summary>
    ''' Menangani tombol reset skor untuk tim AKA.
    ''' </summary>
    Private Sub BtnResetScoreAka_Click(sender As Object, e As EventArgs) Handles BtnResetScoreAka.Click
        If RbFlagSystem.Checked Then
            ProcessFlagVisuals(0, 0)
        Else
            NumAkaJ1.Value = 0 : NumAkaJ2.Value = 0 : NumAkaJ3.Value = 0
            NumAkaJ4.Value = 0 : NumAkaJ5.Value = 0 : NumAkaJ6.Value = 0 : NumAkaJ7.Value = 0
            TotalScoreAKA.Value = 0
        End If
    End Sub

    ''' <summary>
    ''' Menangani tombol reset skor untuk tim AO.
    ''' </summary>
    Private Sub BtnResetScoreAo_Click(sender As Object, e As EventArgs) Handles BtnResetScoreAo.Click
        If RbFlagSystem.Checked Then
            ProcessFlagVisuals(0, 0)
        Else
            NumAoJ1.Value = 0 : NumAoJ2.Value = 0 : NumAoJ3.Value = 0
            NumAoJ4.Value = 0 : NumAoJ5.Value = 0 : NumAoJ6.Value = 0 : NumAoJ7.Value = 0
            TotalScoreAO.Value = 0
        End If
    End Sub

    ''' <summary>
    ''' Fungsi utilitas internal untuk membersihkan seluruh nilai input juri secara serentak.
    ''' </summary>
    Private Sub ResetScoresOnly()
        If RbFlagSystem.Checked Then
            ProcessFlagVisuals(0, 0)
        Else
            NumAkaJ1.Value = 0 : NumAkaJ2.Value = 0 : NumAkaJ3.Value = 0
            NumAkaJ4.Value = 0 : NumAkaJ5.Value = 0 : NumAkaJ6.Value = 0 : NumAkaJ7.Value = 0

            NumAoJ1.Value = 0 : NumAoJ2.Value = 0 : NumAoJ3.Value = 0
            NumAoJ4.Value = 0 : NumAoJ5.Value = 0 : NumAoJ6.Value = 0 : NumAoJ7.Value = 0

            TotalScoreAKA.Value = 0
            TotalScoreAO.Value = 0
        End If
    End Sub

End Class