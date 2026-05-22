Public Class KataMainControl

    ' ==============================================================================
    ' 0. DEKLARASI VARIABEL & PROPERTI GLOBAL
    ' ==============================================================================
    Private frmLogActivity As FormLogActivity = Nothing

    Public Shared KataDetailFontName As String = "Microsoft Sans Serif"
    Public Shared KataDetailIsBold As Boolean = True
    Public Shared KataDetailColor As Color = Color.Yellow

    ' ==============================================================================
    ' 1. KONSTRUKTOR (INITIALIZATION)
    ' ==============================================================================
    Public Sub New()
        InitializeComponent()

        ' Memanggil inisialisasi awal
        InitializeScoringUI()
        ApplyKataMatchDetailStyle(KataDetailFontName, KataDetailIsBold, KataDetailColor)
    End Sub

    ' ==============================================================================
    ' 2. FUNGSI HELPER UI & CUSTOM STYLE (MEMPERTAHANKAN KODE ASLI)
    ' ==============================================================================

    Public Sub ApplyKataMatchDetailStyle(fontName As String, isBold As Boolean, textColor As System.Drawing.Color)
        Try
            Dim style As FontStyle = If(isBold, FontStyle.Bold, FontStyle.Regular)

            If LblJudgeStatusTitle IsNot Nothing Then
                LblJudgeStatusTitle.Font = New Font(fontName, LblJudgeStatusTitle.Font.Size, style)
                LblJudgeStatusTitle.ForeColor = textColor
                LblJudgeStatusTitle.Refresh()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub CheckWinner(AkaScore As Integer, AoScore As Integer)
        ' Menampilkan label WINNER berdasarkan skor tertinggi
        If AkaScore > AoScore Then
            LblAkaWinnerStatus.Text = "WINNER"
            LblAoWinnerStatus.Text = ""
        ElseIf AoScore > AkaScore Then
            LblAoWinnerStatus.Text = "WINNER"
            LblAkaWinnerStatus.Text = ""
        Else
            LblAoWinnerStatus.Text = ""
            LblAkaWinnerStatus.Text = ""
        End If
    End Sub

    Private Sub InitializeScoringUI()
        RbScoreType.Checked = True
        Rb7Judge.Checked = True ' Menjamin 7 Judge sebagai default

        ToggleScoringMode()
        UpdateJudgeCountUI()
    End Sub

    ' ==============================================================================
    ' 3. MANAJEMEN MODE (SCORE VS FLAG) & VISIBILITAS JURI
    ' ==============================================================================

    Private Sub ToggleScoringMode()
        Me.SuspendLayout()
        Try
            If RbScoreType.Checked Then
                ' ── MODE SCORE (Angka) ──
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
                ' ── MODE FLAG (Bendera) ──
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

    Private Sub UpdateJudgeCountUI()
        Me.SuspendLayout()
        Try
            Dim totalJudge As Integer = If(Rb3Judge.Checked, 3, If(Rb5Judge.Checked, 5, 7))
            Dim showJ45 As Boolean = (totalJudge >= 5)
            Dim showJ67 As Boolean = (totalJudge = 7)

            ' ── VISIBILITAS: PANEL SCORING (ANGKA) ──
            NumAkaJ4.Visible = showJ45 : LblAkaJ4.Visible = showJ45
            NumAkaJ5.Visible = showJ45 : LblAkaJ5.Visible = showJ45
            NumAkaJ6.Visible = showJ67 : LblAkaJ6.Visible = showJ67
            NumAkaJ7.Visible = showJ67 : LblAkaJ7.Visible = showJ67

            NumAoJ4.Visible = showJ45 : LblAoJ4.Visible = showJ45
            NumAoJ5.Visible = showJ45 : LblAoJ5.Visible = showJ45
            NumAoJ6.Visible = showJ67 : LblAoJ6.Visible = showJ67
            NumAoJ7.Visible = showJ67 : LblAoJ7.Visible = showJ67

            ' ── VISIBILITAS: PANEL FLAG BENDERA ──
            PnlFlagAka4.Visible = showJ45 : PnlFlagAka5.Visible = showJ45
            PnlFlagAka6.Visible = showJ67 : PnlFlagAka7.Visible = showJ67
            PnlFlagAo4.Visible = showJ45 : PnlFlagAo5.Visible = showJ45
            PnlFlagAo6.Visible = showJ67 : PnlFlagAo7.Visible = showJ67

            ' ── VISIBILITAS: LEFT BAR (STATUS LOGIN JURI) ──
            PnlJ4.Visible = showJ45 : PnlJ5.Visible = showJ45
            PnlJ6.Visible = showJ67 : PnlJ7.Visible = showJ67

            ' ── RESET DATA JURI YANG DISEMBUNYIKAN ──
            If Not showJ45 Then
                NumAkaJ4.Value = 0 : NumAkaJ5.Value = 0
                NumAoJ4.Value = 0 : NumAoJ5.Value = 0
            End If
            If Not showJ67 Then
                NumAkaJ6.Value = 0 : NumAkaJ7.Value = 0
                NumAoJ6.Value = 0 : NumAoJ7.Value = 0
            End If

            ' ── VISUAL FEEDBACK (Warna Radio Button Jumlah Juri) ──
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

    Private Function GetActiveJudgeCount() As Integer
        If Rb3Judge.Checked Then Return 3
        If Rb5Judge.Checked Then Return 5
        Return 7
    End Function

    ' ==============================================================================
    ' 4. LOGIKA VISUAL SISTEM BENDERA PADA PANEL UI
    ' ==============================================================================

    Private Sub HighlightFlag(pnl As Panel, isActive As Boolean, isAka As Boolean)
        If pnl Is Nothing Then Exit Sub

        Dim flagColor As Color = If(isAka, Color.Red, Color.Blue)
        Dim activeBackColor As Color = If(isAka, Color.FromArgb(255, 215, 215), Color.FromArgb(215, 230, 255))

        ' Merubah warna Background panel jika aktif
        pnl.BackColor = If(isActive, activeBackColor, Color.White)

        ' Memastikan teks & Ikon mempertahankan warna defaultnya
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Label Then
                ctrl.Visible = True
                If ctrl.Text = "⚑" Then
                    ctrl.ForeColor = flagColor
                Else
                    ctrl.ForeColor = Color.Black
                End If
            End If
        Next
    End Sub

    Private Sub ProcessFlagVisuals(akaScore As Integer, aoScore As Integer)
        ' Tim AKA
        HighlightFlag(PnlFlagAka1, akaScore >= 1, True)
        HighlightFlag(PnlFlagAka2, akaScore >= 2, True)
        HighlightFlag(PnlFlagAka3, akaScore >= 3, True)
        HighlightFlag(PnlFlagAka4, akaScore >= 4, True)
        HighlightFlag(PnlFlagAka5, akaScore >= 5, True)
        HighlightFlag(PnlFlagAka6, akaScore >= 6, True)
        HighlightFlag(PnlFlagAka7, akaScore >= 7, True)

        ' Tim AO
        HighlightFlag(PnlFlagAo1, aoScore >= 1, False)
        HighlightFlag(PnlFlagAo2, aoScore >= 2, False)
        HighlightFlag(PnlFlagAo3, aoScore >= 3, False)
        HighlightFlag(PnlFlagAo4, aoScore >= 4, False)
        HighlightFlag(PnlFlagAo5, aoScore >= 5, False)
        HighlightFlag(PnlFlagAo6, aoScore >= 6, False)
        HighlightFlag(PnlFlagAo7, aoScore >= 7, False)

        ' Update Angka Papan Skor
        TotalScoreAKA.Value = akaScore
        TotalScoreAO.Value = aoScore

        ' Eksekusi Logika Pengecekan Pemenang Asli Milik Anda
        CheckWinner(akaScore, aoScore)
    End Sub

    ' ==============================================================================
    ' 5. EVENT HANDLERS: KLIK PANEL BENDERA
    ' ==============================================================================

    Private Sub FlagAka_PanelClick(sender As Object, e As EventArgs) Handles PnlFlagAka1.Click, PnlFlagAka2.Click, PnlFlagAka3.Click, PnlFlagAka4.Click, PnlFlagAka5.Click, PnlFlagAka6.Click, PnlFlagAka7.Click
        Dim clickedPanel = CType(sender, Panel)
        Dim score As Integer = 0

        For Each ctrl As Control In clickedPanel.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Text <> "⚑" Then Integer.TryParse(ctrl.Text, score)
        Next

        Dim currentAkaScore As Integer = TotalScoreAKA.Value
        Dim total = GetActiveJudgeCount()

        If score > total Then Exit Sub

        If score = currentAkaScore Then
            ProcessFlagVisuals(0, 0)
        Else
            ProcessFlagVisuals(score, total - score)
        End If
    End Sub

    Private Sub FlagAo_PanelClick(sender As Object, e As EventArgs) Handles PnlFlagAo1.Click, PnlFlagAo2.Click, PnlFlagAo3.Click, PnlFlagAo4.Click, PnlFlagAo5.Click, PnlFlagAo6.Click, PnlFlagAo7.Click
        Dim clickedPanel = CType(sender, Panel)
        Dim score As Integer = 0

        For Each ctrl As Control In clickedPanel.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Text <> "⚑" Then Integer.TryParse(ctrl.Text, score)
        Next

        Dim currentAoScore As Integer = TotalScoreAO.Value
        Dim total = GetActiveJudgeCount()

        If score > total Then Exit Sub

        If score = currentAoScore Then
            ProcessFlagVisuals(0, 0)
        Else
            ProcessFlagVisuals(total - score, score)
        End If
    End Sub

    ' ==============================================================================
    ' 6. EVENT HANDLERS: INTERAKSI TOMBOL LAINNYA
    ' ==============================================================================

    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        If frmLogActivity Is Nothing OrElse frmLogActivity.IsDisposed Then
            frmLogActivity = New FormLogActivity()
        End If
        frmLogActivity.Show()
        frmLogActivity.BringToFront()
    End Sub

    ' FITUR BARU: Otomatis Reset Saat Berpindah Mode Scoring
    Private Sub RbScoreType_CheckedChanged(sender As Object, e As EventArgs) Handles RbScoreType.CheckedChanged
        If RbScoreType.Checked Then
            ToggleScoringMode()
            ResetAllScores()
        End If
    End Sub

    ' FITUR BARU: Otomatis Reset Saat Berpindah Mode Scoring
    Private Sub RbFlagSystem_CheckedChanged(sender As Object, e As EventArgs) Handles RbFlagSystem.CheckedChanged
        If RbFlagSystem.Checked Then
            ToggleScoringMode()
            ResetAllScores()
        End If
    End Sub

    Private Sub Rb3Judge_CheckedChanged(sender As Object, e As EventArgs) Handles Rb3Judge.CheckedChanged
        If Rb3Judge.Checked Then
            ResetAllScores()
            UpdateJudgeCountUI()
        End If
    End Sub

    Private Sub Rb5Judge_CheckedChanged(sender As Object, e As EventArgs) Handles Rb5Judge.CheckedChanged
        If Rb5Judge.Checked Then
            ResetAllScores()
            UpdateJudgeCountUI()
        End If
    End Sub

    Private Sub Rb7Judge_CheckedChanged(sender As Object, e As EventArgs) Handles Rb7Judge.CheckedChanged
        If Rb7Judge.Checked Then
            ResetAllScores()
            UpdateJudgeCountUI()
        End If
    End Sub

    Private Sub BtnResetScoreAka_Click(sender As Object, e As EventArgs) Handles BtnResetScoreAka.Click
        ResetAllScores()
    End Sub

    Private Sub BtnResetScoreAo_Click(sender As Object, e As EventArgs) Handles BtnResetScoreAo.Click
        ResetAllScores()
    End Sub

    ' ==============================================================================
    ' 7. MASTER RESET DATA SCORING
    ' ==============================================================================

    Private Sub ResetAllScores()
        ' Kita buat reset ALL tanpa syarat If/Else. 
        ' Jadi angka dan bendera dua-duanya dihapus bersih ke 0 tanpa peduli mode apa yang sedang aktif!

        ' 1. Reset visual bendera
        ProcessFlagVisuals(0, 0)

        ' 2. Reset angka Numeric Up/Down
        NumAkaJ1.Value = 0 : NumAkaJ2.Value = 0 : NumAkaJ3.Value = 0
        NumAkaJ4.Value = 0 : NumAkaJ5.Value = 0 : NumAkaJ6.Value = 0 : NumAkaJ7.Value = 0

        NumAoJ1.Value = 0 : NumAoJ2.Value = 0 : NumAoJ3.Value = 0
        NumAoJ4.Value = 0 : NumAoJ5.Value = 0 : NumAoJ6.Value = 0 : NumAoJ7.Value = 0

        ' 3. Reset total papan bawah
        TotalScoreAKA.Value = 0
        TotalScoreAO.Value = 0

        ' 4. Hapus tulisan WINNER
        CheckWinner(0, 0)
    End Sub

End Class