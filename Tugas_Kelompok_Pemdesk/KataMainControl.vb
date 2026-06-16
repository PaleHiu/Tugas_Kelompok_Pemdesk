Public Class KataMainControl

    ' ==============================================================================
    ' 0. DEKLARASI VARIABEL & PROPERTI GLOBAL
    ' ==============================================================================
    Private frmLogActivity As FormLogActivity = Nothing

    Public Shared KataNameFontName As String = "Microsoft Sans Serif"
    Public Shared KataNameIsBold As Boolean = True
    Public Shared KataNameColor As System.Drawing.Color = System.Drawing.Color.LightGreen

    Public Shared KataDetailFontName As String = "Microsoft Sans Serif"
    Public Shared KataDetailIsBold As Boolean = True
    Public Shared KataDetailColor As System.Drawing.Color = System.Drawing.Color.Yellow

    Public Shared KataTimerFontName As String = "Microsoft Sans Serif"
    Public Shared KataTimerIsBold As Boolean = True
    Public Shared KataTimerColor As System.Drawing.Color = System.Drawing.Color.Red
    Private originalXCoords As New Dictionary(Of Control, Integer)
    Private originalCenterWidth As Integer = 342
    Private WithEvents WaitTimer As New System.Windows.Forms.Timer()
    Private WaitTimeRemaining As Integer ' Untuk menyimpan total detik yang tersisa
    Private IsWaitTimerRunning As Boolean = False
    ' ==============================================================================
    ' 1. KONSTRUKTOR (INITIALIZATION)
    ' ==============================================================================
    Public Sub New()
        InitializeComponent()

        InitializeScoringUI()
        WaitTimer.Interval = 1000
        ApplyKataMatchDetailStyle(KataDetailFontName, KataDetailIsBold, KataDetailColor)

        ' 1. MATIKAN SEMUA DOCKING BAWAAN
        PnlAka.Dock = DockStyle.None
        PnlAo.Dock = DockStyle.None
        PnlCenterScore.Dock = DockStyle.None

        ' 2. KUNCI PANEL AKA DAN AO DI PINGGIR, PANEL TENGAH SEBAGAI KARET
        PnlAka.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PnlAo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PnlCenterScore.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

        ' 3. AMANKAN TOMBOL BAWAH
        If BtnSettings IsNot Nothing Then BtnSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        If BtnShortcut IsNot Nothing Then BtnShortcut.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left

        ' 4. KUNCI MATI SUMBU Y DAN REKAM POSISI X ASLI
        If PnlCenterScore IsNot Nothing Then
            originalCenterWidth = PnlCenterScore.Width

            ' Aktifkan Scrollbar jika layar ditarik terlalu sempit (Standar Aplikasi Profesional)
            PnlCenterScore.AutoScroll = True

            For Each ctrl As Control In PnlCenterScore.Controls
                ' KUNCI MATI: Semua kotak dipaksa menempel ke atas. 
                ' Mereka tidak akan pernah bisa melayang menimpa "JUDGE SCORE" atau didorong menimpa "DISQUALIFICATION" lagi!
                ctrl.Anchor = AnchorStyles.Top Or AnchorStyles.Left

                ' Rekam posisi X asli (hasil drag & drop-mu) ke dalam memori
                originalXCoords(ctrl) = ctrl.Left
            Next
        End If

        Me.MinimumSize = New Size(1400, 800)
        ' Form should capture keyboard for global shortcuts
        Me.KeyPreview = True
    End Sub

    Private Sub KataMainControl_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If Not FromKeyboardShortcutKata.IsShortcutEnabled Then Exit Sub

            Dim strShortcut As String = ""
            If e.Control Then strShortcut &= "Control+"
            If e.Shift Then strShortcut &= "Shift+"
            If e.Alt Then strShortcut &= "Alt+"
            strShortcut &= e.KeyCode.ToString()

            For Each pair In FromKeyboardShortcutKata.ShortcutMap
                Dim actionName As String = pair.Key
                Dim combo As String = pair.Value
                If String.Equals(combo, strShortcut, StringComparison.OrdinalIgnoreCase) Then
                    ProcessShortcutAction(actionName)
                    e.SuppressKeyPress = True
                    e.Handled = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            ' ignore
        End Try
    End Sub

    Private Sub ProcessShortcutAction(actionName As String)
        Try
            Select Case actionName
                Case "Start-Close Scoreboard"
                    If BtnStartScoreboard IsNot Nothing Then BtnStartScoreboard.PerformClick()
                Case "Timer Waiting Start-Stop"
                    If BtnStartWaitingTimer IsNot Nothing Then BtnStartWaitingTimer.PerformClick()
                Case "Match Timer Start-Stop"
                    If BtnStartTimer IsNot Nothing Then BtnStartTimer.PerformClick()
                Case "Match Timer Reset"
                    ' Try to invoke gear timer (as reset) if available
                    If BtnGearTimer IsNot Nothing Then BtnGearTimer.PerformClick()
                Case "Next Match"
                    If BtnNextMatch IsNot Nothing Then BtnNextMatch.PerformClick()
                Case "Save Match Result"
                    If BtnSaveMatchResult IsNot Nothing Then BtnSaveMatchResult.PerformClick()
                Case "Show Winner"
                    CheckWinner(TotalScoreAKA.Value, TotalScoreAO.Value)
                Case "Show Score to Scoreboard"
                    If BtnShowScore IsNot Nothing Then BtnShowScore.PerformClick()
                Case "Assign Task to Judges"
                    If BtnAssignTask IsNot Nothing Then BtnAssignTask.PerformClick()
                Case "Hide-Show KATA Timer"
                    If BtnEyeTimer IsNot Nothing Then BtnEyeTimer.PerformClick()
                Case "Show Competitor 1 (AKA)"
                    If RbComp1 IsNot Nothing Then RbComp1.Checked = True
                    If BtnSelectPlayer IsNot Nothing Then BtnSelectPlayer.PerformClick()
                Case "Show Competitor 2 (AO)"
                    If RbComp2 IsNot Nothing Then RbComp2.Checked = True
                    If BtnSelectPlayer IsNot Nothing Then BtnSelectPlayer.PerformClick()
                Case "Show All Competitor"
                    If RbAllComp IsNot Nothing Then RbAllComp.Checked = True
                    If BtnSelectPlayer IsNot Nothing Then BtnSelectPlayer.PerformClick()
                Case "AKA - Yuko(1)"
                    If TotalScoreAKA IsNot Nothing Then TotalScoreAKA.Value = Math.Min(TotalScoreAKA.Maximum, TotalScoreAKA.Value + 1)
                    CheckWinner(TotalScoreAKA.Value, TotalScoreAO.Value)
                Case "AKA - Wazaari(2)"
                    If TotalScoreAKA IsNot Nothing Then TotalScoreAKA.Value = Math.Min(TotalScoreAKA.Maximum, TotalScoreAKA.Value + 2)
                    CheckWinner(TotalScoreAKA.Value, TotalScoreAO.Value)
                Case "AKA - Ippon(3)"
                    If TotalScoreAKA IsNot Nothing Then TotalScoreAKA.Value = Math.Min(TotalScoreAKA.Maximum, TotalScoreAKA.Value + 3)
                    CheckWinner(TotalScoreAKA.Value, TotalScoreAO.Value)
                Case "AKA - SENSHU"
                    ApplyPenaltyAndDeclareWinner(BtnKikenAka, "AO")
                Case "AO - Yuko(1)"
                    If TotalScoreAO IsNot Nothing Then TotalScoreAO.Value = Math.Min(TotalScoreAO.Maximum, TotalScoreAO.Value + 1)
                    CheckWinner(TotalScoreAKA.Value, TotalScoreAO.Value)
                Case "AO - Wazaari(2)"
                    If TotalScoreAO IsNot Nothing Then TotalScoreAO.Value = Math.Min(TotalScoreAO.Maximum, TotalScoreAO.Value + 2)
                    CheckWinner(TotalScoreAKA.Value, TotalScoreAO.Value)
                Case "AO - Ippon(3)"
                    If TotalScoreAO IsNot Nothing Then TotalScoreAO.Value = Math.Min(TotalScoreAO.Maximum, TotalScoreAO.Value + 3)
                    CheckWinner(TotalScoreAKA.Value, TotalScoreAO.Value)
                Case "AO - SENSHU"
                    ApplyPenaltyAndDeclareWinner(BtnKikenAo, "AKA")
                Case Else
                    ' Unknown action: no-op
            End Select
        Catch ex As Exception
            ' ignore
        End Try
    End Sub

    ' ==============================================================================
    ' 2. FUNGSI HELPER UI & CUSTOM STYLE 
    ' ==============================================================================
    Private Sub CheckWinner(AkaScore As Integer, AoScore As Integer)
        ' Kondisi Awal / Reset (0 - 0) -> Sembunyikan (Hide) kedua label winner
        If AkaScore = 0 AndAlso AoScore = 0 Then
            LblAkaWinner.Visible = False
            LblAoWinner.Visible = False
            Exit Sub
        End If

        ' Logika Hide / Show secara default tanpa mengubah kosmetik warna/font
        If AkaScore > AoScore Then
            LblAkaWinner.Text = "WINNER"
            LblAkaWinner.Visible = True
            LblAoWinner.Visible = False
        ElseIf AoScore > AkaScore Then
            LblAkaWinner.Visible = False
            LblAoWinner.Text = "WINNER"
            LblAoWinner.Visible = True
        Else
            LblAkaWinner.Text = "DRAW"
            LblAkaWinner.Visible = True
            LblAoWinner.Text = "DRAW"
            LblAoWinner.Visible = True
        End If
    End Sub

    Private Sub InitializeScoringUI()
        RbScoreType.Checked = True
        Rb7Judge.Checked = True

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
                PnlPointInputsAka.Visible = True
                PnlPointInputsAo.Visible = True
                PnlFlagInputsAka.Visible = False
                PnlFlagInputsAo.Visible = False

                RbScoreType.ForeColor = Color.FromArgb(0, 80, 180)
                RbScoreType.Font = New Font(RbScoreType.Font, FontStyle.Bold)
                RbFlagSystem.ForeColor = Color.Gray
                RbFlagSystem.Font = New Font(RbFlagSystem.Font, FontStyle.Regular)

            ElseIf RbFlagSystem.Checked Then
                PnlPointInputsAka.Visible = False
                PnlPointInputsAo.Visible = False
                PnlFlagInputsAka.Visible = True
                PnlFlagInputsAo.Visible = True

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

            NumAkaJ4.Visible = showJ45 : LblAkaJ4.Visible = showJ45
            NumAkaJ5.Visible = showJ45 : LblAkaJ5.Visible = showJ45
            NumAkaJ6.Visible = showJ67 : LblAkaJ6.Visible = showJ67
            NumAkaJ7.Visible = showJ67 : LblAkaJ7.Visible = showJ67

            NumAoJ4.Visible = showJ45 : LblAoJ4.Visible = showJ45
            NumAoJ5.Visible = showJ45 : LblAoJ5.Visible = showJ45
            NumAoJ6.Visible = showJ67 : LblAoJ6.Visible = showJ67
            NumAoJ7.Visible = showJ67 : LblAoJ7.Visible = showJ67

            PnlFlagAka4.Visible = showJ45 : PnlFlagAka5.Visible = showJ45
            PnlFlagAka6.Visible = showJ67 : PnlFlagAka7.Visible = showJ67
            PnlFlagAo4.Visible = showJ45 : PnlFlagAo5.Visible = showJ45
            PnlFlagAo6.Visible = showJ67 : PnlFlagAo7.Visible = showJ67

            PnlJ4.Visible = showJ45 : PnlJ5.Visible = showJ45
            PnlJ6.Visible = showJ67 : PnlJ7.Visible = showJ67

            If Not showJ45 Then
                NumAkaJ4.Value = 0 : NumAkaJ5.Value = 0
                NumAoJ4.Value = 0 : NumAoJ5.Value = 0
            End If
            If Not showJ67 Then
                NumAkaJ6.Value = 0 : NumAkaJ7.Value = 0
                NumAoJ6.Value = 0 : NumAoJ7.Value = 0
            End If

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

        Dim flagColor = If(isAka, Color.Red, Color.Blue)
        Dim activeBackColor = If(isAka, Color.FromArgb(255, 215, 215), Color.FromArgb(215, 230, 255))

        pnl.BackColor = If(isActive, activeBackColor, Color.White)

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
        HighlightFlag(PnlFlagAka1, akaScore >= 1, True)
        HighlightFlag(PnlFlagAka2, akaScore >= 2, True)
        HighlightFlag(PnlFlagAka3, akaScore >= 3, True)
        HighlightFlag(PnlFlagAka4, akaScore >= 4, True)
        HighlightFlag(PnlFlagAka5, akaScore >= 5, True)
        HighlightFlag(PnlFlagAka6, akaScore >= 6, True)
        HighlightFlag(PnlFlagAka7, akaScore >= 7, True)

        HighlightFlag(PnlFlagAo1, aoScore >= 1, False)
        HighlightFlag(PnlFlagAo2, aoScore >= 2, False)
        HighlightFlag(PnlFlagAo3, aoScore >= 3, False)
        HighlightFlag(PnlFlagAo4, aoScore >= 4, False)
        HighlightFlag(PnlFlagAo5, aoScore >= 5, False)
        HighlightFlag(PnlFlagAo6, aoScore >= 6, False)
        HighlightFlag(PnlFlagAo7, aoScore >= 7, False)

        TotalScoreAKA.Value = akaScore
        TotalScoreAO.Value = aoScore

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

    ' ==============================================================================
    ' [LOG ACTIVITY] BUKA JENDELA LOG GLOBAL
    ' ==============================================================================
    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        ActivityLogger.InitializeLogger()
        ActivityLogger.SharedLogForm.Show()
        ActivityLogger.SharedLogForm.BringToFront()
    End Sub

    Private Sub RbScoreType_CheckedChanged(sender As Object, e As EventArgs) Handles RbScoreType.CheckedChanged
        If RbScoreType.Checked Then
            ToggleScoringMode()
            ResetAllScores()
        End If
    End Sub

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
        ProcessFlagVisuals(0, 0)

        NumAkaJ1.Value = 0 : NumAkaJ2.Value = 0 : NumAkaJ3.Value = 0
        NumAkaJ4.Value = 0 : NumAkaJ5.Value = 0 : NumAkaJ6.Value = 0 : NumAkaJ7.Value = 0

        NumAoJ1.Value = 0 : NumAoJ2.Value = 0 : NumAoJ3.Value = 0
        NumAoJ4.Value = 0 : NumAoJ5.Value = 0 : NumAoJ6.Value = 0 : NumAoJ7.Value = 0

        TotalScoreAKA.Value = 0
        TotalScoreAO.Value = 0

        ResetPenaltyLabels()
        CheckWinner(0, 0)
        ActivityLogger.LogKataAction("Reset Papan Skor", "Semua poin & penalti diatur ulang ke 0", LblTimerDisplayMain.Text)
    End Sub

    ' ==============================================================================
    ' [PENALTY SYSTEM] LOGIKA PENALTI DENGAN FITUR TOGGLE (ON/OFF)
    ' ==============================================================================

    Private Sub ResetPenaltyLabels()
        ' Kembalikan semua background ke warna putih (mengikuti warna UI awal)
        BtnKikenAka.BackColor = Color.White
        BtnDiskualifikasiAka.BackColor = Color.White
        BtnKikenAo.BackColor = Color.White
        BtnDiskualifikasiAo.BackColor = Color.White
    End Sub

    Private Sub ApplyPenaltyAndDeclareWinner(clickedCtrl As Control, winningTeam As String)
        ' 1. FITUR TOGGLE OFF (BATALKAN PENALTI)
        ' Jika tombol yang diklik sudah aktif (Kuning), maka batalkan penalti
        If clickedCtrl.BackColor = Color.Yellow Then
            ' Reset warna tombol kembali putih
            ResetPenaltyLabels()

            ' Kembalikan status pemenang murni berdasarkan skor angka saat ini 
            ' (Mencegah bug di mana label winner hilang padahal poinnya lebih tinggi)
            CheckWinner(CInt(TotalScoreAKA.Value), CInt(TotalScoreAO.Value))
            ActivityLogger.LogKataAction($"Batal Penalti {clickedCtrl.Text}", "Keputusan penalti dianulir", LblTimerDisplayMain.Text)
            ' Hentikan eksekusi kode di sini agar tidak memproses baris di bawahnya
            Exit Sub
        End If

        ' 2. FITUR TOGGLE ON (AKTIFKAN PENALTI)
        ' Pastikan tombol penalti yang lain bersih/putih dulu
        ResetPenaltyLabels()

        ' Beri highlight Kuning pada tombol yang baru saja diklik
        clickedCtrl.BackColor = Color.Yellow

        ' Deklarasikan pemenang mutlak karena lawan terkena penalti (Disqualification/Kiken)
        If winningTeam = "AKA" Then
            LblAkaWinner.Text = "WINNER"
            LblAkaWinner.Visible = True
            LblAoWinner.Visible = False
        ElseIf winningTeam = "AO" Then
            LblAoWinner.Text = "WINNER"
            LblAoWinner.Visible = True
            LblAkaWinner.Visible = False
        End If
        ActivityLogger.LogKataAction($"Penalti {clickedCtrl.Text}", $"Tim lawan menerima penalti. {winningTeam} WIN.", LblTimerDisplayMain.Text)
    End Sub

    ' ==============================================================================
    ' [PENALTY SYSTEM] EVENT CLICK PENALTI (KIKEN & DISKUALIFIKASI)
    ' ==============================================================================
    Private Sub BtnKikenAka_Click(sender As Object, e As EventArgs) Handles BtnKikenAka.Click
        ApplyPenaltyAndDeclareWinner(BtnKikenAka, "AO")
    End Sub

    Private Sub BtnDiskualifikasiAka_Click(sender As Object, e As EventArgs) Handles BtnDiskualifikasiAka.Click
        ApplyPenaltyAndDeclareWinner(BtnDiskualifikasiAka, "AO")
    End Sub

    Private Sub BtnKikenAo_Click(sender As Object, e As EventArgs) Handles BtnKikenAo.Click
        ApplyPenaltyAndDeclareWinner(BtnKikenAo, "AKA")
    End Sub

    Private Sub BtnDiskualifikasiAo_Click(sender As Object, e As EventArgs) Handles BtnDiskualifikasiAo.Click
        ApplyPenaltyAndDeclareWinner(BtnDiskualifikasiAo, "AKA")
    End Sub

    Private Sub TxtMatchDetail_TextChanged(sender As Object, e As EventArgs) Handles TxtMatchDetail.TextChanged
    End Sub

    Private Sub LblTextAlign_Click(sender As Object, e As EventArgs) Handles LblTextAlign.Click
    End Sub


    ' ==============================================================================
    ' [PENALTY SYSTEM] HOVER EFFECT UNTUK TOMBOL KIKEN & DISKUALIFIKASI
    ' ==============================================================================

    ' Saat Mouse masuk ke area tombol (Hover)
    Private Sub Penalty_MouseEnter(sender As Object, e As EventArgs) Handles BtnKikenAka.MouseEnter, BtnDiskualifikasiAka.MouseEnter, BtnKikenAo.MouseEnter, BtnDiskualifikasiAo.MouseEnter
        Dim ctrl As Control = CType(sender, Control)

        ' Ubah warna menjadi abu-abu muda hanya jika tombol sedang TIDAK aktif (bukan kuning)
        If ctrl.BackColor <> Color.Yellow Then
            ctrl.BackColor = Color.WhiteSmoke
            ctrl.Cursor = Cursors.Hand ' Mengubah kursor panah menjadi ikon jari/tangan
        End If
    End Sub

    ' Saat Mouse keluar dari area tombol (Leave)
    Private Sub Penalty_MouseLeave(sender As Object, e As EventArgs) Handles BtnKikenAka.MouseLeave, BtnDiskualifikasiAka.MouseLeave, BtnKikenAo.MouseLeave, BtnDiskualifikasiAo.MouseLeave
        Dim ctrl As Control = CType(sender, Control)

        ' Kembalikan ke warna asli (Putih) hanya jika tombol sedang TIDAK aktif (bukan kuning)
        If ctrl.BackColor <> Color.Yellow Then
            ctrl.BackColor = Color.White
        End If
    End Sub

    ' ==============================================================================
    ' [UI/UX ENHANCEMENT] FUNGSI HILANGKAN JEJAK FOKUS SAAT KLIK AREA KOSONG
    ' ==============================================================================
    Private Sub ClearFocus_Click(sender As Object, e As EventArgs) Handles Me.Click,
        PnlMainWorkspace.Click, PnlCenterScore.Click, PnlAka.Click, PnlAo.Click,
        PnlRightBar.Click, PnlLeftBar.Click, PnlTopBar.Click, PnlFooter.Click

        ' Mengembalikan nilai fokus ke 0 (default/kosong)
        ' Ini akan menghilangkan garis kotak putus-putus atau sorotan biru pada tombol terakhir yang diklik
        Me.ActiveControl = Nothing
    End Sub

    ' ==============================================================================
    ' [UI/UX ENHANCEMENT] HOVER EFFECT UNTUK TOMBOL RESET SCORE
    ' ==============================================================================

    ' Saat Mouse masuk ke area tombol Reset Score
    Private Sub BtnResetScore_MouseEnter(sender As Object, e As EventArgs) Handles BtnResetScoreAka.MouseEnter, BtnResetScoreAo.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.LightGray ' Memberikan highlight abu-abu
        btn.Cursor = Cursors.Hand       ' Mengubah kursor menjadi ikon tangan
    End Sub

    ' Saat Mouse keluar dari area tombol Reset Score
    Private Sub BtnResetScore_MouseLeave(sender As Object, e As EventArgs) Handles BtnResetScoreAka.MouseLeave, BtnResetScoreAo.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.WhiteSmoke ' Mengembalikan ke warna putih pudar aslinya
    End Sub

    ' ==============================================================================
    ' [UI/UX ENHANCEMENT] HOVER EFFECT UNTUK TEKS SHOW WINNER
    ' ==============================================================================

    ' Saat Mouse masuk ke area teks Show Winner
    Private Sub LblShowWinner_MouseEnter(sender As Object, e As EventArgs) Handles LblAkaWinnerStatus.MouseEnter, LblAoWinnerStatus.MouseEnter
        Dim lbl As Label = CType(sender, Label)
        lbl.ForeColor = Color.Black     ' Teks menjadi hitam pekat agar terlihat menyala
        lbl.Cursor = Cursors.Hand       ' Mengubah kursor menjadi ikon tangan
    End Sub

    ' Saat Mouse keluar dari area teks Show Winner
    Private Sub LblShowWinner_MouseLeave(sender As Object, e As EventArgs) Handles LblAkaWinnerStatus.MouseLeave, LblAoWinnerStatus.MouseLeave
        Dim lbl As Label = CType(sender, Label)
        lbl.ForeColor = Color.Gray      ' Mengembalikan teks ke warna abu-abu aslinya
    End Sub

    ' ==============================================================================
    ' [SHOW WINNER POP-UP] 1. FUNGSI KLIK UNTUK TIM AKA (MERAH)
    ' ==============================================================================
    Private Sub LblAkaWinnerStatus_Click(sender As Object, e As EventArgs) Handles LblAkaWinnerStatus.Click
        ' 1. Ambil teks langsung dari kotak inputan UI
        Dim namaPeserta As String = TxtAkaNameMain.Text.Trim()
        Dim namaTim As String = TxtAkaTeam1.Text.Trim()

        ' 2. Validasi ringan: Jika kosong, tampilkan strip (-) agar desain form tidak aneh
        If String.IsNullOrEmpty(namaPeserta) Then namaPeserta = "-"
        If String.IsNullOrEmpty(namaTim) Then namaTim = "-"

        ' 3. Memanggil WinnerForm (True = Merah/AKA)
        Dim frmWinner As New WinnerForm(True, namaPeserta, namaTim)
        frmWinner.Show()
    End Sub

    ' ==============================================================================
    ' [SHOW WINNER POP-UP] 2. FUNGSI KLIK UNTUK TIM AO (BIRU)
    ' ==============================================================================
    Private Sub LblAoWinnerStatus_Click(sender As Object, e As EventArgs) Handles LblAoWinnerStatus.Click
        ' 1. Ambil teks langsung dari kotak inputan UI
        Dim namaPeserta As String = TxtAoNameMain.Text.Trim()
        Dim namaTim As String = TxtAoTeam1.Text.Trim()

        ' 2. Validasi ringan: Jika kosong, tampilkan strip (-) agar desain form tidak aneh
        If String.IsNullOrEmpty(namaPeserta) Then namaPeserta = "-"
        If String.IsNullOrEmpty(namaTim) Then namaTim = "-"

        ' 3. Memanggil WinnerForm (False = Biru/AO)
        Dim frmWinner As New WinnerForm(False, namaPeserta, namaTim)
        frmWinner.Show()
    End Sub

    Public Sub ApplyKataMatchDetailStyle(fontName As String, isBold As Boolean, textColor As System.Drawing.Color)
        Try
            Dim style As FontStyle = If(isBold, FontStyle.Bold, FontStyle.Regular)

            ' Tes visual ke Judge Status
            If LblJudgeStatusTitle IsNot Nothing Then
                LblJudgeStatusTitle.Font = New Font(fontName, LblJudgeStatusTitle.Font.Size, style)
                LblJudgeStatusTitle.ForeColor = textColor
                LblJudgeStatusTitle.Refresh()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ApplyKataNameStyle(fontName As String, isBold As Boolean, textColor As System.Drawing.Color)
        Try
            Dim style As FontStyle = If(isBold, FontStyle.Bold, FontStyle.Regular)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ApplyKataTimerStyle(fontName As String, isBold As Boolean, textColor As System.Drawing.Color)
        Try
            Dim style As FontStyle = If(isBold, FontStyle.Bold, FontStyle.Regular)
        Catch ex As Exception
        End Try
    End Sub

    ' ==============================================================================
    ' [WAITING TIMER] 1. FUNGSI TOMBOL START/STOP
    ' ==============================================================================
    Private Sub BtnStartWaitingTimer_Click(sender As Object, e As EventArgs) Handles BtnStartWaitingTimer.Click
        If Not IsWaitTimerRunning Then
            ' Ambil nilai dari inputan kotak Waiting (Menit dan Detik)
            Dim menit As Integer = Convert.ToInt32(NumWaitMin.Value)
            Dim detik As Integer = Convert.ToInt32(NumWaitSec.Value)
            WaitTimeRemaining = (menit * 60) + detik

            ' Cegah timer berjalan jika nilainya 0
            If WaitTimeRemaining > 0 Then
                IsWaitTimerRunning = True
                WaitTimer.Start()

                ' Ubah tombol menjadi mode Stop sebagai indikator
                BtnStartWaitingTimer.Text = "Stop Waiting Timer"
                BtnStartWaitingTimer.BackColor = Color.LightCoral
                BtnStartWaitingTimer.ForeColor = Color.White

                UpdateWaitTimerDisplay()
            Else
                MessageBox.Show("Silakan atur waktu Waiting terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ' Logika jika tombol diklik untuk me-STOp timer yang sedang berjalan
            StopWaitingTimer()
        End If
    End Sub

    ' ==============================================================================
    ' [WAITING TIMER] 2. LOGIKA HITUNG MUNDUR (TICK EVENT)
    ' ==============================================================================
    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        If WaitTimeRemaining > 0 Then
            WaitTimeRemaining -= 1
            UpdateWaitTimerDisplay()
        Else
            ' Waktu habis
            StopWaitingTimer()
            ' Opsional: Tampilkan alert kedip atau suara jika diperlukan
            LblTimerDisplayMain.Text = "00:00 00"
        End If
    End Sub

    ' ==============================================================================
    ' [WAITING TIMER] 3. UPDATE TAMPILAN KE LAYAR UTAMA
    ' ==============================================================================
    Private Sub UpdateWaitTimerDisplay()
        ' Kalkulasi ulang sisa detik menjadi format Menit dan Detik
        Dim m As Integer = WaitTimeRemaining \ 60
        Dim s As Integer = WaitTimeRemaining Mod 60

        ' Timpa LblTimerDisplayMain dengan format digital "MM:SS 00"
        LblTimerDisplayMain.Text = String.Format("{0:00}:{1:00} 00", m, s)
    End Sub

    ' ==============================================================================
    ' [WAITING TIMER] 4. FUNGSI HELPER UNTUK RESET TOMBOL
    ' ==============================================================================
    Private Sub StopWaitingTimer()
        WaitTimer.Stop()
        IsWaitTimerRunning = False

        ' Kembalikan warna dan teks tombol ke bentuk asli
        BtnStartWaitingTimer.Text = "Start Waiting Timer"
        BtnStartWaitingTimer.BackColor = Color.FromArgb(255, 228, 196) ' Warna BurlyWood/Peach asli
        BtnStartWaitingTimer.ForeColor = Color.Black
    End Sub








    ' Fungsi ini otomatis terbuat saat kamu double-click tombol Setting
    Private Sub BtnSettingKata_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Try
            Dim frmSetting As New FrmScoreboardSetting()
            frmSetting.ShowDialog(Me)

        Catch ex As Exception
            MessageBox.Show("Gagal membuka menu Setting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fungsi ini otomatis terbuat saat kamu double-click tombol Shortcut
    Private Sub BtnShortcutKata_Click(sender As Object, e As EventArgs) Handles BtnShortcut.Click
        Try
            Dim frmShortcut As New FromKeyboardShortcutKata()
            frmShortcut.ShowDialog(Me)

        Catch ex As Exception
            MessageBox.Show("Gagal membuka menu Shortcut: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PnlCenterScore_Resize(sender As Object, e As EventArgs) Handles PnlCenterScore.Resize
        If originalXCoords.Count > 0 AndAlso PnlCenterScore IsNot Nothing Then

            Dim currentCenter As Integer = PnlCenterScore.Width \ 2
            Dim originalCenter As Integer = originalCenterWidth \ 2

            ' Geser semua kotak-kotak kecil secara serentak ke tengah layar
            For Each ctrl As Control In PnlCenterScore.Controls
                If originalXCoords.ContainsKey(ctrl) Then
                    Dim originalX As Integer = originalXCoords(ctrl)
                    Dim offsetFromCenter As Integer = originalX - originalCenter

                    ' Hanya geser sumbu X (Kiri-Kanan). Sumbu Y (Atas-Bawah) dibiarkan aman!
                    ctrl.Left = currentCenter + offsetFromCenter
                End If
            Next
        End If
    End Sub

    Private Sub BtnQRCode_Click(sender As Object, e As EventArgs) Handles BtnQRCode.Click
        Try
            ' 1. Buat objek form QR Code yang baru
            Dim frmQR As New FormQRGenerated()

            ' 2. Tampilkan sebagai Dialog agar user fokus dan mencegah form terbuka ganda
            frmQR.ShowDialog(Me)

        Catch ex As Exception
            MessageBox.Show("Gagal membuka menu QR Code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSelectLogo_Click(sender As Object, e As EventArgs) Handles BtnSelectLogo.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp"
            ofd.Title = "Pilih Gambar Logo/Profil"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim bytes As Byte() = System.IO.File.ReadAllBytes(ofd.FileName)
                Dim ms As New IO.MemoryStream(bytes)
                PicPreviewLogo.Image = Image.FromStream(ms)
            End If
        End Using
    End Sub

    Private Sub BtnRemoveLogo_Click(sender As Object, e As EventArgs) Handles BtnRemoveLogo.Click
        PicPreviewLogo.Image = Nothing
    End Sub

    ' =====================================================================================
    ' ===========  C. SCORING SETTING — PENGEMBANGAN (FOKUS SAAT INI: MODE MANUAL)  =======
    ' Alur Manual: Mode "Manual" mengaktifkan input juri. Klik label juri (J1..J7) membuka
    ' jendela pemilih skor (0 + 5.0..10.0). Nilai terpilih mengisi spinner juri, lalu
    ' Total Score dihitung otomatis (trimmed-sum: buang 1 nilai tertinggi & 1 terendah).
    ' Mode "Online" (juri input sendiri via QR/server) hanya menonaktifkan input - menyusul.
    ' =====================================================================================
    Private isInitializing As Boolean = True

    Private Function JudgeNumsAll() As NumericUpDown()
        Return New NumericUpDown() {NumAkaJ1, NumAkaJ2, NumAkaJ3, NumAkaJ4, NumAkaJ5, NumAkaJ6, NumAkaJ7,
                                    NumAoJ1, NumAoJ2, NumAoJ3, NumAoJ4, NumAoJ5, NumAoJ6, NumAoJ7}
    End Function

    Private Function JudgeLabelsAll() As Label()
        Return New Label() {LblAkaJ1, LblAkaJ2, LblAkaJ3, LblAkaJ4, LblAkaJ5, LblAkaJ6, LblAkaJ7,
                            LblAoJ1, LblAoJ2, LblAoJ3, LblAoJ4, LblAoJ5, LblAoJ6, LblAoJ7}
    End Function

    Private Sub KataMainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitializing = True
        Try
            ' Rules: Voting (default) / Elimination
            If CmbRules IsNot Nothing Then
                CmbRules.DropDownStyle = ComboBoxStyle.DropDownList
                CmbRules.Items.Clear()
                CmbRules.Items.AddRange(New Object() {"Score -> Voting (2026)", "Score -> Elimination"})
                CmbRules.SelectedIndex = 0
            End If

            ' Mode: untuk sekarang fokus MANUAL (Online menyusul/lewat server)
            If CmbMode IsNot Nothing Then
                CmbMode.DropDownStyle = ComboBoxStyle.DropDownList
                CmbMode.Items.Clear()
                CmbMode.Items.AddRange(New Object() {"Manual", "Online"})
                CmbMode.SelectedItem = "Manual"
            End If

            ' Total Score tampil dengan 1 desimal (mis. 6.0)
            If TotalScoreAKA IsNot Nothing Then TotalScoreAKA.DecimalPlaces = 1
            If TotalScoreAO IsNot Nothing Then TotalScoreAO.DecimalPlaces = 1

            ApplyMode()
        Catch
        Finally
            isInitializing = False
        End Try
        RecalcTotals()
    End Sub

    ' ---------- MODE ONLINE / MANUAL ----------
    Private Function IsManualMode() As Boolean
        If CmbMode Is Nothing OrElse CmbMode.SelectedItem Is Nothing Then Return True
        Return CmbMode.SelectedItem.ToString() = "Manual"
    End Function

    Private Sub ApplyMode()
        Dim manual As Boolean = IsManualMode()
        ' Manual: operator yang mengisi -> input juri ENABLE.
        ' Online: juri mengisi via QR/server -> input juri DISABLE.
        For Each num As NumericUpDown In JudgeNumsAll()
            If num IsNot Nothing Then num.Enabled = manual
        Next
        For Each lb As Label In JudgeLabelsAll()
            If lb IsNot Nothing Then lb.Cursor = If(manual, Cursors.Hand, Cursors.Default)
        Next
    End Sub

    Private Sub CmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMode.SelectedIndexChanged
        If isInitializing Then Return
        ApplyMode()
    End Sub

    ' Tombol "Manual | Online" = toggle cepat antar mode
    Private Sub BtnManualOnline_Click(sender As Object, e As EventArgs) Handles BtnManualOnline.Click
        If CmbMode Is Nothing Then Return
        CmbMode.SelectedItem = If(IsManualMode(), "Online", "Manual")
    End Sub

    ' ---------- RULES (Voting / Elimination) ----------
    Private Sub CmbRules_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRules.SelectedIndexChanged
        If isInitializing Then Return
        RecalcTotals()
    End Sub

    ' ---------- KLIK LABEL JURI -> JENDELA PEMILIH SKOR (hanya mode Manual) ----------
    Private Sub JudgeLabel_Click(sender As Object, e As EventArgs) _
        Handles LblAkaJ1.Click, LblAkaJ2.Click, LblAkaJ3.Click, LblAkaJ4.Click, LblAkaJ5.Click, LblAkaJ6.Click, LblAkaJ7.Click,
                LblAoJ1.Click, LblAoJ2.Click, LblAoJ3.Click, LblAoJ4.Click, LblAoJ5.Click, LblAoJ6.Click, LblAoJ7.Click
        If RbScoreType Is Nothing OrElse Not RbScoreType.Checked Then Return   ' hanya tipe Score
        If Not IsManualMode() Then Return                                       ' hanya mode Manual

        Dim lbl As Label = TryCast(sender, Label)
        If lbl Is Nothing Then Return

        Dim numName As String = lbl.Name.Replace("Lbl", "Num")                  ' LblAkaJ3 -> NumAkaJ3
        Dim found() As Control = Me.Controls.Find(numName, True)
        If found Is Nothing OrElse found.Length = 0 Then Return
        Dim num As NumericUpDown = TryCast(found(0), NumericUpDown)
        If num Is Nothing OrElse Not num.Visible Then Return

        Using picker As New KataScorePicker(lbl.Text, num.Value)
            If picker.ShowDialog(Me) = DialogResult.OK AndAlso picker.SelectedValue.HasValue Then
                Dim v As Decimal = picker.SelectedValue.Value
                If v < num.Minimum Then v = num.Minimum
                If v > num.Maximum Then v = num.Maximum
                num.Value = v   ' memicu RecalcTotals lewat ValueChanged
            End If
        End Using
    End Sub

    ' ---------- HITUNG TOTAL SKOR OTOMATIS ----------
    Private Sub JudgeScore_ValueChanged(sender As Object, e As EventArgs) _
        Handles NumAkaJ1.ValueChanged, NumAkaJ2.ValueChanged, NumAkaJ3.ValueChanged, NumAkaJ4.ValueChanged, NumAkaJ5.ValueChanged, NumAkaJ6.ValueChanged, NumAkaJ7.ValueChanged,
                NumAoJ1.ValueChanged, NumAoJ2.ValueChanged, NumAoJ3.ValueChanged, NumAoJ4.ValueChanged, NumAoJ5.ValueChanged, NumAoJ6.ValueChanged, NumAoJ7.ValueChanged
        If isInitializing Then Return
        RecalcTotals()
    End Sub

    Private Sub JudgeCount_Changed(sender As Object, e As EventArgs) _
        Handles Rb3Judge.CheckedChanged, Rb5Judge.CheckedChanged, Rb7Judge.CheckedChanged
        If isInitializing Then Return
        RecalcTotals()
    End Sub

    Private Function GetJudgeValues(isAka As Boolean) As Decimal()
        Dim n As Integer = GetActiveJudgeCount()
        Dim src() As NumericUpDown = If(isAka,
            New NumericUpDown() {NumAkaJ1, NumAkaJ2, NumAkaJ3, NumAkaJ4, NumAkaJ5, NumAkaJ6, NumAkaJ7},
            New NumericUpDown() {NumAoJ1, NumAoJ2, NumAoJ3, NumAoJ4, NumAoJ5, NumAoJ6, NumAoJ7})
        Dim vals(n - 1) As Decimal
        For i As Integer = 0 To n - 1
            vals(i) = If(src(i) IsNot Nothing, src(i).Value, 0D)
        Next
        Return vals
    End Function

    ' Total = jumlah nilai juri SETELAH membuang 1 nilai tertinggi & 1 terendah.
    ' (3 juri -> sisa 1 nilai tengah; 5 juri -> 3; 7 juri -> 5.)
    Private Function TrimmedTotal(vals As Decimal()) As Decimal
        If vals Is Nothing OrElse vals.Length = 0 Then Return 0D
        Dim total As Decimal = 0D
        Dim mn As Decimal = vals(0)
        Dim mx As Decimal = vals(0)
        For Each v As Decimal In vals
            total += v
            If v < mn Then mn = v
            If v > mx Then mx = v
        Next
        If vals.Length <= 2 Then Return total
        Return total - mn - mx   ' buang satu min & satu max (aman walau ada nilai kembar)
    End Function

    Private Sub RecalcTotals()
        ' Flag System ditangani ProcessFlagVisuals; di sini khusus tipe Score.
        If RbScoreType Is Nothing OrElse Not RbScoreType.Checked Then Return
        Dim akaTotal As Decimal = TrimmedTotal(GetJudgeValues(True))
        Dim aoTotal As Decimal = TrimmedTotal(GetJudgeValues(False))
        If TotalScoreAKA IsNot Nothing Then TotalScoreAKA.Value = Math.Min(TotalScoreAKA.Maximum, akaTotal)
        If TotalScoreAO IsNot Nothing Then TotalScoreAO.Value = Math.Min(TotalScoreAO.Maximum, aoTotal)
        UpdateScoreWinnerLabels(akaTotal, aoTotal)
    End Sub

    Private Sub UpdateScoreWinnerLabels(akaVal As Decimal, aoVal As Decimal)
        If LblAkaWinner Is Nothing OrElse LblAoWinner Is Nothing Then Return
        If akaVal = 0D AndAlso aoVal = 0D Then
            LblAkaWinner.Visible = False
            LblAoWinner.Visible = False
        ElseIf akaVal > aoVal Then
            LblAkaWinner.Text = "WINNER" : LblAkaWinner.Visible = True : LblAoWinner.Visible = False
        ElseIf aoVal > akaVal Then
            LblAoWinner.Text = "WINNER" : LblAoWinner.Visible = True : LblAkaWinner.Visible = False
        Else
            LblAkaWinner.Text = "DRAW" : LblAoWinner.Text = "DRAW"
            LblAkaWinner.Visible = True : LblAoWinner.Visible = True
        End If
    End Sub

    ' =====================================================================================
    ' =================  NEXT MATCH BAR (jiplakan dari KumiteMainControl)  =================
    ' Ikon 👤 / tombol Next Match  -> buka ListOfCompetitor untuk memilih peserta.
    ' Hasil pilihan masuk ke antrean Next* + ditampilkan di kotak preview atas.
    ' Load Next Match            -> commit antrean ke Team Info AKA/AO (+sinkron scoreboard).
    ' Swap ⇄                     -> tukar antrean AKA <-> AO.
    ' =====================================================================================
    Public targetSide As String = ""
    Public NextAkaName As String = "", NextAkaTeam As String = "", NextAkaInfo As String = ""
    Public NextAoName As String = "", NextAoTeam As String = "", NextAoInfo As String = ""

    ' Ikon 👤 AKA (top bar) -> pilih peserta Next Match sisi AKA
    Private Sub BtnAkaIconSearch_Click(sender As Object, e As EventArgs) Handles BtnAkaIconSearch.Click
        OpenCompetitorList("AKA")
    End Sub

    ' Ikon 👤 AO (top bar) -> pilih peserta Next Match sisi AO
    Private Sub BtnAoIconSearch_Click(sender As Object, e As EventArgs) Handles BtnAoIconSearch.Click
        OpenCompetitorList("AO")
    End Sub

    ' Tombol "Next Match" -> mulai memilih peserta berikutnya (default sisi AKA dulu)
    Private Sub BtnNextMatch_Click(sender As Object, e As EventArgs) Handles BtnNextMatch.Click
        OpenCompetitorList("AKA")
    End Sub

    Private Sub OpenCompetitorList(side As String)
        targetSide = side
        Try
            Dim frm As New ListOfCompetitor()
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal memanggil form ListOfCompetitor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Dipanggil balik oleh ListOfCompetitor saat user menekan "Select"
    Public Sub SetCompetitorData(nama As String, team As String, info As String)
        If targetSide = "AO" Then
            NextAoName = nama : NextAoTeam = team : NextAoInfo = info
            If TxtAoSearchDisplay IsNot Nothing Then TxtAoSearchDisplay.Text = nama & " | " & team
        Else
            NextAkaName = nama : NextAkaTeam = team : NextAkaInfo = info
            If TxtAkaSearchDisplay IsNot Nothing Then TxtAkaSearchDisplay.Text = nama & " | " & team
        End If
    End Sub

    ' Dipanggil balik oleh ListOfTeam saat user memilih tim
    Public Sub UpdateTeamData(team As String, info As String)
        If targetSide = "AO" Then
            NextAoTeam = team : NextAoInfo = info
            If NextAoName <> "" AndAlso TxtAoSearchDisplay IsNot Nothing Then TxtAoSearchDisplay.Text = NextAoName & " | " & team
        Else
            NextAkaTeam = team : NextAkaInfo = info
            If NextAkaName <> "" AndAlso TxtAkaSearchDisplay IsNot Nothing Then TxtAkaSearchDisplay.Text = NextAkaName & " | " & team
        End If
    End Sub

    ' Load Next Match -> pindahkan antrean ke panel Team Info.
    ' Jika antrean masih kosong, langsung buka ListOfCompetitor (biar tombolnya tidak "mati").
    Private Sub BtnLoadNextMatch_Click(sender As Object, e As EventArgs) Handles BtnLoadNextMatch.Click
        If NextAkaName = "" AndAlso NextAoName = "" Then
            OpenCompetitorList("AKA")
            Return
        End If

        If NextAkaName <> "" Then
            TxtAkaNameMain.Text = NextAkaName
            TxtAkaTeam1.Text = NextAkaTeam
            TxtAkaTeam2.Text = NextAkaInfo
            LoadMatchImages(NextAkaName, NextAkaTeam, PicAkaCircle, PicAkaAvatar)
        End If
        If NextAoName <> "" Then
            TxtAoNameMain.Text = NextAoName
            TxtAoTeam1.Text = NextAoTeam
            TxtAoTeam2.Text = NextAoInfo
            LoadMatchImages(NextAoName, NextAoTeam, PicAoCircle, PicAoAvatar)
        End If

        SyncScoreboardProfile()
        MessageBox.Show("Data pertandingan berhasil di-load!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Swap ⇄ -> tukar antrean Next Match AKA <-> AO (termasuk teks preview)
    Private Sub BtnSwapNextMatch_Click(sender As Object, e As EventArgs) Handles BtnSwapNextMatch.Click
        Dim tN As String = NextAkaName : NextAkaName = NextAoName : NextAoName = tN
        Dim tT As String = NextAkaTeam : NextAkaTeam = NextAoTeam : NextAoTeam = tT
        Dim tI As String = NextAkaInfo : NextAkaInfo = NextAoInfo : NextAoInfo = tI
        If TxtAkaSearchDisplay IsNot Nothing AndAlso TxtAoSearchDisplay IsNot Nothing Then
            Dim tmp As String = TxtAkaSearchDisplay.Text
            TxtAkaSearchDisplay.Text = TxtAoSearchDisplay.Text
            TxtAoSearchDisplay.Text = tmp
        End If
    End Sub

    ' Sinkron nama AKA/AO ke Scoreboard bila sedang terbuka (aman bila belum ada scoreboard).
    Private Sub SyncScoreboardProfile()
        Dim sb As Form = Nothing
        For Each f As Form In Application.OpenForms
            If f.GetType().Name = "ScoreBoard" Then
                sb = f
                Exit For
            End If
        Next
        If sb Is Nothing Then Return
        SetScoreboardLabel(sb, "LblAkaName", TxtAkaNameMain.Text)
        SetScoreboardLabel(sb, "LblAoName", TxtAoNameMain.Text)
    End Sub

    Private Sub SetScoreboardLabel(f As Form, ctrlName As String, value As String)
        Dim found() As Control = f.Controls.Find(ctrlName, True)
        If found IsNot Nothing AndAlso found.Length > 0 Then found(0).Text = value
    End Sub

    ' ---- Pemuat gambar peserta & logo tim dari database (jiplakan dari KumiteMainControl) ----
    Private Sub LoadMatchImages(nama As String, namaTeam As String, boxComp As PictureBox, boxTeam As PictureBox)
        ' Paksa gambar pas-proporsional & background putih
        boxComp.SizeMode = PictureBoxSizeMode.Zoom
        boxTeam.SizeMode = PictureBoxSizeMode.Zoom
        boxComp.BackColor = Color.White
        boxTeam.BackColor = Color.White
        boxComp.Image = Nothing
        boxTeam.Image = Nothing

        Try
            Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                conn.Open()

                ' Foto peserta di tabel competitor
                Try
                    Dim qComp As String = "SELECT pict_path FROM competitor WHERE name = @n AND team = @t LIMIT 1"
                    Using cmdComp As New System.Data.SQLite.SQLiteCommand(qComp, conn)
                        cmdComp.Parameters.AddWithValue("@n", nama)
                        cmdComp.Parameters.AddWithValue("@t", namaTeam)
                        Dim result = cmdComp.ExecuteScalar()
                        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                            boxComp.Image = LoadSafeImage(result.ToString())
                        End If
                    End Using
                Catch ex As Exception
                End Try

                ' Logo tim di tabel team_lengkap
                Try
                    Dim qTeam As String = "SELECT pict_path FROM team_lengkap WHERE nama_team = @nt LIMIT 1"
                    Using cmdTeam As New System.Data.SQLite.SQLiteCommand(qTeam, conn)
                        cmdTeam.Parameters.AddWithValue("@nt", namaTeam)
                        Dim result = cmdTeam.ExecuteScalar()
                        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                            boxTeam.Image = GetSafeTeamImage(result.ToString())
                        End If
                    End Using
                Catch ex As Exception
                End Try
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Function LoadSafeImage(path As String) As Image
        Try
            If String.IsNullOrWhiteSpace(path) OrElse path.Trim() = "No Image" Then
                Return Nothing
            End If
            path = path.Trim()
            If System.IO.File.Exists(path) Then
                Dim bytes As Byte() = System.IO.File.ReadAllBytes(path)
                Using ms As New IO.MemoryStream(bytes)
                    Return Image.FromStream(ms)
                End Using
            End If
        Catch ex As Exception
        End Try
        Return Nothing
    End Function

    Private Function GetSafeTeamImage(pathOrFlag As String) As Image
        Try
            If String.IsNullOrWhiteSpace(pathOrFlag) OrElse pathOrFlag.Trim() = "No Image" Then
                Return Nothing
            End If
            pathOrFlag = pathOrFlag.Trim()

            If pathOrFlag.StartsWith("Flag: ") Then
                Dim countryName As String = pathOrFlag.Replace("Flag: ", "").Trim()
                Dim flagPathPNG As String = IO.Path.Combine(Application.StartupPath, countryName & "_Flag.png")
                Dim flagPathJPG As String = IO.Path.Combine(Application.StartupPath, countryName & "_Flag.jpg")

                Dim finalPath As String = ""
                If System.IO.File.Exists(flagPathPNG) Then finalPath = flagPathPNG
                If System.IO.File.Exists(flagPathJPG) Then finalPath = flagPathJPG

                If finalPath <> "" Then
                    Dim bytes As Byte() = System.IO.File.ReadAllBytes(finalPath)
                    Dim ms As New IO.MemoryStream(bytes)
                    Return Image.FromStream(ms)
                Else
                    Dim bmp As New Bitmap(100, 60)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        g.Clear(Color.LightGray)
                        g.DrawRectangle(Pens.Black, 0, 0, 99, 59)
                        g.DrawString(countryName, New Font("Segoe UI", 8, FontStyle.Bold), Brushes.Black, New PointF(5, 20))
                    End Using
                    Return bmp
                End If
            ElseIf System.IO.File.Exists(pathOrFlag) Then
                Dim bytes As Byte() = System.IO.File.ReadAllBytes(pathOrFlag)
                Dim ms As New IO.MemoryStream(bytes)
                Return Image.FromStream(ms)
            End If
        Catch ex As Exception
        End Try

        Return Nothing
    End Function

End Class

' =====================================================================================
' JENDELA PEMILIH SKOR MANUAL (sesuai guide "J? Score": tombol 0 + 5.0 .. 10.0)
' Dibuat sepenuhnya lewat kode sehingga tidak perlu menambah file .Designer terpisah.
' =====================================================================================
Friend Class KataScorePicker
    Inherits System.Windows.Forms.Form

    Public SelectedValue As Decimal? = Nothing

    Public Sub New(judgeTitle As String, currentValue As Decimal)
        Me.Text = judgeTitle & " Score"
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.StartPosition = FormStartPosition.CenterParent
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowInTaskbar = False
        Me.AutoScaleMode = AutoScaleMode.None

        Const cols As Integer = 10
        Const rows As Integer = 6
        Const cellW As Integer = 64
        Const cellH As Integer = 46
        Const pad As Integer = 10

        Dim tlp As New TableLayoutPanel()
        tlp.ColumnCount = cols
        tlp.RowCount = rows
        tlp.Dock = DockStyle.Fill
        tlp.Padding = New Padding(pad)
        For i As Integer = 0 To cols - 1
            tlp.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, cellW))
        Next
        For i As Integer = 0 To rows - 1
            tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, cellH))
        Next

        ' Baris 5..9 dengan pecahan .0 .. .9
        Dim baseVals() As Integer = {5, 6, 7, 8, 9}
        For r As Integer = 0 To 4
            For c As Integer = 0 To 9
                Dim v As Decimal = CDec(baseVals(r)) + (CDec(c) * 0.1D)
                tlp.Controls.Add(MakeBtn(v, currentValue, False), c, r)
            Next
        Next
        ' Baris terakhir: 10 di kiri, 0 (merah) di kanan
        tlp.Controls.Add(MakeBtn(10D, currentValue, False), 0, 5)
        tlp.Controls.Add(MakeBtn(0D, currentValue, True), 9, 5)

        Me.Controls.Add(tlp)
        Me.ClientSize = New Size(cols * cellW + pad * 2, rows * cellH + pad * 2)
    End Sub

    Private Function MakeBtn(v As Decimal, current As Decimal, isZero As Boolean) As Button
        Dim b As New Button()
        b.Tag = v
        b.Dock = DockStyle.Fill
        b.Margin = New Padding(2)
        b.FlatStyle = FlatStyle.Flat
        b.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        b.Text = If(v = Math.Truncate(v), CInt(v).ToString(), v.ToString("0.0"))
        If isZero Then
            b.BackColor = Color.Red
            b.ForeColor = Color.White
        ElseIf v = current Then
            b.BackColor = Color.FromArgb(50, 130, 246)
            b.ForeColor = Color.White
        Else
            b.BackColor = Color.White
        End If
        AddHandler b.Click, AddressOf Btn_Click
        Return b
    End Function

    Private Sub Btn_Click(sender As Object, e As EventArgs)
        SelectedValue = CDec(CType(sender, Button).Tag)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class