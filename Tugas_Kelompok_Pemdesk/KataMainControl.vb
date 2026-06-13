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

    ' ==============================================================================
    ' 1. KONSTRUKTOR (INITIALIZATION)
    ' ==============================================================================
    Public Sub New()
        InitializeComponent()

        InitializeScoringUI()
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

    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        If frmLogActivity Is Nothing OrElse frmLogActivity.IsDisposed Then
            frmLogActivity = New FormLogActivity()
        End If
        frmLogActivity.Show()
        frmLogActivity.BringToFront()
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
    End Sub

    ' ==============================================================================
    ' 8. LOGIKA PENALTI (KIKEN & DISKUALIFIKASI) - SUPPORT LABEL/BUTTON
    ' ==============================================================================

    Private Sub ResetPenaltyLabels()
        ' Tetap pakai nama yang ada di properties UI lu
        BtnKikenAka.BackColor = SystemColors.Control
        BtnDiskualifikasiAka.BackColor = SystemColors.Control
        BtnKikenAo.BackColor = SystemColors.Control
        BtnDiskualifikasiAo.BackColor = SystemColors.Control
    End Sub

    ' Pakai "As Control" supaya mau nerima Label ataupun Button tanpa error convert
    Private Sub ApplyPenaltyAndDeclareWinner(clickedCtrl As Control, winningTeam As String)
        ResetPenaltyLabels()
        clickedCtrl.BackColor = Color.Yellow

        If winningTeam = "AKA" Then
            LblAkaWinner.Text = "WINNER"
            LblAkaWinner.Visible = True
            LblAoWinner.Visible = False
        ElseIf winningTeam = "AO" Then
            LblAoWinner.Text = "WINNER"
            LblAoWinner.Visible = True
            LblAkaWinner.Visible = False
        End If
    End Sub

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

    Private Sub LblAoWinnerStatus_Click(sender As Object, e As EventArgs) Handles LblAoWinnerStatus.Click
        ShowWinnerWindow(False)
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

    ' =====================================================================================
    ' ============  PENGEMBANGAN FUNGSI KATA MAIN CONTROL (BERDASARKAN GUIDE)  =============
    ' Pola di-mirror dari KumiteMainControl yang sudah jadi + Guide Jendela KATA.
    ' =====================================================================================

    ' ---------- STATE / FIELD ----------
    Private frmScoreboard As ScoreBoard = Nothing

    Private WithEvents matchTimer As New Timer() With {.Interval = 100}   ' Performance timer (0.1 dtk)
    Private totalTenths As Integer = 0
    Private isSyncingPerf As Boolean = False

    Private WithEvents waitTimer As New Timer() With {.Interval = 1000}   ' Waiting timer (1 dtk)

    Private audioMuted As Boolean = False
    Private scoreboardTimerVisible As Boolean = True
    Private scoreboardMaximized As Boolean = False
    Private currentScreenIndex As Integer = 0

    ' Untuk pemilihan kompetitor (dipakai bersama ListOfCompetitor / ListOfTeam)
    Public targetSide As String = ""
    Public NextAkaName As String = "", NextAkaTeam As String = "", NextAkaInfo As String = ""
    Public NextAoName As String = "", NextAoTeam As String = "", NextAoInfo As String = ""

    Private isInitializing As Boolean = False

    ' ---------- LOAD: inisialisasi combo, mode, total skor, timer ----------
    Private Sub KataMainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitializing = True
        Try
            ' Rules: Voting (default) / Elimination
            If CmbRules IsNot Nothing Then
                CmbRules.Items.Clear()
                CmbRules.Items.AddRange({"Score -> Voting (2026)", "Score -> Elimination"})
                CmbRules.SelectedIndex = 0
            End If
            ' Mode: Online (default) / Manual
            If CmbMode IsNot Nothing Then
                CmbMode.Items.Clear()
                CmbMode.Items.AddRange({"Online", "Manual"})
                CmbMode.SelectedIndex = 0
            End If
            ' Text Align
            If CmbTextAlign IsNot Nothing Then
                CmbTextAlign.Items.Clear()
                CmbTextAlign.Items.AddRange({"Left", "Center", "Right"})
                CmbTextAlign.SelectedIndex = 1
            End If
            ' Server
            If CmbServer IsNot Nothing Then
                CmbServer.Items.Clear()
                CmbServer.Items.AddRange({"https://kata.yabinya.com", "own server (http://192.168.1.4)"})
                CmbServer.SelectedIndex = 0
            End If
            ' Daftar nama KATA (contoh WKF; bisa ditambah/ubah sesuai kebutuhan)
            Dim kataList = {"", "Heian Shodan", "Heian Nidan", "Heian Sandan", "Heian Yondan", "Heian Godan",
                            "Bassai Dai", "Bassai Sho", "Kanku Dai", "Kanku Sho", "Empi", "Jion", "Jitte",
                            "Hangetsu", "Gankaku", "Tekki Shodan", "Unsu", "Sochin", "Nijushiho", "Gojushiho Dai"}
            If CmbAkaKata IsNot Nothing Then CmbAkaKata.Items.Clear() : CmbAkaKata.Items.AddRange(kataList)
            If CmbAoKata IsNot Nothing Then CmbAoKata.Items.Clear() : CmbAoKata.Items.AddRange(kataList)

            ' Total Score mendukung pecahan (mis. 6.0) untuk mode Voting/Elimination
            ConfigureTotalBox(TotalScoreAKA)
            ConfigureTotalBox(TotalScoreAO)

            ' BtnEditServer awalnya nonaktif (server default = aplikasi)
            If BtnEditServer IsNot Nothing Then BtnEditServer.Enabled = False

            ApplyMode()              ' set enable/disable judge input sesuai mode
            UpdateShowWinnerAvailability()
            PerfTimeFromInputs()
            UpdatePerfTimerDisplay()
        Catch
        Finally
            isInitializing = False
        End Try
    End Sub

    Private Sub ConfigureTotalBox(n As NumericUpDown)
        If n Is Nothing Then Return
        n.DecimalPlaces = 1
        n.Increment = 0.1D
        n.Maximum = 999D
        n.Minimum = 0D
    End Sub

    ' =====================================================================================
    ' 1) SCOREBOARD : Start/Close, Maximize, Monitor
    ' =====================================================================================
    Private Sub BtnStartScoreboard_Click(sender As Object, e As EventArgs) Handles BtnStartScoreboard.Click
        Try
            If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then
                frmScoreboard = New ScoreBoard()
                frmScoreboard.Show()
                BtnStartScoreboard.Text = "Close Scoreboard"
                SyncScoreboardProfile()
                SyncScoreboardPoints()
                SyncScoreboardTimer()
                SyncTatami()
                ApplySelectPlayerVisibility()
            Else
                ' Tombol berfungsi sebagai toggle: tutup scoreboard
                frmScoreboard.Close()
                frmScoreboard = Nothing
                BtnStartScoreboard.Text = "Start Scoreboard"
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membuka Scoreboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Tombol ikon ⛶ : maksimalkan / kecilkan jendela scoreboard
    Private Sub BtnScoreboardIcon_Click(sender As Object, e As EventArgs) Handles BtnScoreboardIcon.Click
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then
            BtnStartScoreboard_Click(sender, e)
            Return
        End If
        scoreboardMaximized = Not scoreboardMaximized
        frmScoreboard.WindowState = If(scoreboardMaximized, FormWindowState.Maximized, FormWindowState.Normal)
        frmScoreboard.BringToFront()
    End Sub

    ' Tombol Monitor 🖥 : pindahkan scoreboard ke layar berikutnya (multi-monitor)
    Private Sub BtnMonitor_Click(sender As Object, e As EventArgs) Handles BtnMonitor.Click
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then
            MessageBox.Show("Buka Scoreboard terlebih dahulu (Start Scoreboard).", "Monitor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim screens = Screen.AllScreens
        If screens.Length <= 1 Then
            MessageBox.Show("Hanya terdeteksi satu layar.", "Monitor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        currentScreenIndex = (currentScreenIndex + 1) Mod screens.Length
        Dim wa = screens(currentScreenIndex).WorkingArea
        frmScoreboard.StartPosition = FormStartPosition.Manual
        frmScoreboard.Location = New Point(wa.Left, wa.Top)
        frmScoreboard.BringToFront()
    End Sub

    ' =====================================================================================
    ' 2) TIMER : Performance (match) + Waiting + reset (gear) + show/hide (eye)
    ' =====================================================================================
    Private Sub PerfTimeFromInputs()
        If NumPerfMin Is Nothing OrElse NumPerfSec Is Nothing Then Return
        totalTenths = (CInt(NumPerfMin.Value) * 600) + (CInt(NumPerfSec.Value) * 10)
    End Sub

    Private Function FormatTenths(t As Integer) As String
        Dim mins As Integer = t \ 600
        Dim secs As Integer = (t Mod 600) \ 10
        Dim te As Integer = t Mod 10
        Return String.Format("{0}:{1:00}.{2}", mins, secs, te)
    End Function

    Private Sub UpdatePerfTimerDisplay()
        If LblTimerDisplayMain IsNot Nothing Then LblTimerDisplayMain.Text = FormatTenths(totalTenths)
        isSyncingPerf = True
        If NumPerfMin IsNot Nothing Then NumPerfMin.Value = totalTenths \ 600
        If NumPerfSec IsNot Nothing Then NumPerfSec.Value = (totalTenths Mod 600) \ 10
        isSyncingPerf = False
        SyncScoreboardTimer()
    End Sub

    Private Sub NumPerf_ValueChanged(sender As Object, e As EventArgs) Handles NumPerfMin.ValueChanged, NumPerfSec.ValueChanged
        If isSyncingPerf OrElse isInitializing Then Return
        PerfTimeFromInputs()
        UpdatePerfTimerDisplay()
    End Sub

    Private Sub BtnStartTimer_Click(sender As Object, e As EventArgs) Handles BtnStartTimer.Click
        If matchTimer.Enabled Then
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer  ⏱"
        Else
            If totalTenths <= 0 Then PerfTimeFromInputs()
            If totalTenths <= 0 Then
                MessageBox.Show("Atur durasi Performance terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            matchTimer.Start()
            BtnStartTimer.Text = "Stop Timer  ⏱"
        End If
    End Sub

    Private Sub matchTimer_Tick(sender As Object, e As EventArgs) Handles matchTimer.Tick
        If totalTenths > 0 Then
            totalTenths -= 1
            UpdatePerfTimerDisplay()
        Else
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer  ⏱"
            UpdatePerfTimerDisplay()
            If Not audioMuted Then AudioController.PlaySound("End of Timer")
            MessageBox.Show("Waktu Performance habis!", "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Gear ⚙ = reset performance timer
    Private Sub BtnGearTimer_Click(sender As Object, e As EventArgs) Handles BtnGearTimer.Click
        matchTimer.Stop()
        BtnStartTimer.Text = "Start Timer  ⏱"
        PerfTimeFromInputs()
        UpdatePerfTimerDisplay()
    End Sub

    ' Eye 👁 = tampilkan / sembunyikan timer di Scoreboard
    Private Sub BtnEyeTimer_Click(sender As Object, e As EventArgs) Handles BtnEyeTimer.Click
        scoreboardTimerVisible = Not scoreboardTimerVisible
        BtnEyeTimer.Text = If(scoreboardTimerVisible, "👁", "🚫")
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            If frmScoreboard.LblTimerMain IsNot Nothing Then frmScoreboard.LblTimerMain.Visible = scoreboardTimerVisible
            If frmScoreboard.LblTimerMilli IsNot Nothing Then frmScoreboard.LblTimerMilli.Visible = scoreboardTimerVisible
        End If
    End Sub

    Private Sub BtnStartWaitingTimer_Click(sender As Object, e As EventArgs) Handles BtnStartWaitingTimer.Click
        If waitTimer.Enabled Then
            waitTimer.Stop()
            BtnStartWaitingTimer.Text = "Start Waiting Timer"
        Else
            If NumWaitMin.Value = 0 AndAlso NumWaitSec.Value = 0 Then
                MessageBox.Show("Atur waktu Waiting terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            waitTimer.Start()
            BtnStartWaitingTimer.Text = "Stop Waiting Timer"
        End If
    End Sub

    Private Sub waitTimer_Tick(sender As Object, e As EventArgs) Handles waitTimer.Tick
        Dim mins As Integer = CInt(NumWaitMin.Value)
        Dim secs As Integer = CInt(NumWaitSec.Value)
        If secs > 0 Then
            secs -= 1
        ElseIf mins > 0 Then
            mins -= 1 : secs = 59
        Else
            waitTimer.Stop()
            BtnStartWaitingTimer.Text = "Start Waiting Timer"
            If Not audioMuted Then AudioController.PlaySound("Manual Alert")
            MessageBox.Show("Waktu tunggu (Waiting) habis!", "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        NumWaitMin.Value = mins
        NumWaitSec.Value = secs
    End Sub

    ' =====================================================================================
    ' 3) JUDGE SCORE : kalkulasi Total (Voting / Elimination) + Mode Online/Manual
    ' =====================================================================================
    Private Function GetJudgeValues(isAka As Boolean) As List(Of Decimal)
        Dim n As Integer = GetActiveJudgeCount()
        Dim src() As NumericUpDown
        If isAka Then
            src = {NumAkaJ1, NumAkaJ2, NumAkaJ3, NumAkaJ4, NumAkaJ5, NumAkaJ6, NumAkaJ7}
        Else
            src = {NumAoJ1, NumAoJ2, NumAoJ3, NumAoJ4, NumAoJ5, NumAoJ6, NumAoJ7}
        End If
        Dim vals As New List(Of Decimal)
        For i As Integer = 0 To n - 1
            If src(i) IsNot Nothing Then vals.Add(src(i).Value)
        Next
        Return vals
    End Function

    ' Total = jumlah nilai juri SETELAH membuang nilai tertinggi & terendah
    ' (sistem trimmed-sum khas KATA). Untuk 3 juri -> tersisa 1 nilai tengah.
    Private Function TrimmedTotal(vals As List(Of Decimal)) As Decimal
        If vals Is Nothing OrElse vals.Count = 0 Then Return 0D
        If vals.Count <= 2 Then
            Dim s0 As Decimal = 0 : For Each v In vals : s0 += v : Next : Return s0
        End If
        Dim sorted = vals.OrderBy(Function(x) x).ToList()
        Dim total As Decimal = 0
        For i As Integer = 1 To sorted.Count - 2   ' buang index 0 (terendah) & terakhir (tertinggi)
            total += sorted(i)
        Next
        Return total
    End Function

    Private Sub RecalcJudgeTotals()
        If RbScoreType Is Nothing OrElse Not RbScoreType.Checked Then Return  ' hanya untuk mode Score
        Dim akaTotal As Decimal = TrimmedTotal(GetJudgeValues(True))
        Dim aoTotal As Decimal = TrimmedTotal(GetJudgeValues(False))
        If TotalScoreAKA IsNot Nothing Then TotalScoreAKA.Value = Math.Min(TotalScoreAKA.Maximum, akaTotal)
        If TotalScoreAO IsNot Nothing Then TotalScoreAO.Value = Math.Min(TotalScoreAO.Maximum, aoTotal)
        UpdateScoreWinner(akaTotal, aoTotal)
        SyncScoreboardPoints()
    End Sub

    Private Sub JudgeScore_ValueChanged(sender As Object, e As EventArgs) _
        Handles NumAkaJ1.ValueChanged, NumAkaJ2.ValueChanged, NumAkaJ3.ValueChanged, NumAkaJ4.ValueChanged, NumAkaJ5.ValueChanged, NumAkaJ6.ValueChanged, NumAkaJ7.ValueChanged,
                NumAoJ1.ValueChanged, NumAoJ2.ValueChanged, NumAoJ3.ValueChanged, NumAoJ4.ValueChanged, NumAoJ5.ValueChanged, NumAoJ6.ValueChanged, NumAoJ7.ValueChanged
        If isInitializing Then Return
        RecalcJudgeTotals()
    End Sub

    Private Sub UpdateScoreWinner(akaVal As Decimal, aoVal As Decimal)
        If akaVal = 0 AndAlso aoVal = 0 Then
            LblAkaWinner.Visible = False : LblAoWinner.Visible = False
        ElseIf akaVal > aoVal Then
            LblAkaWinner.Text = "WINNER" : LblAkaWinner.Visible = True : LblAoWinner.Visible = False
        ElseIf aoVal > akaVal Then
            LblAoWinner.Text = "WINNER" : LblAoWinner.Visible = True : LblAkaWinner.Visible = False
        Else
            LblAkaWinner.Text = "DRAW" : LblAoWinner.Text = "DRAW"
            LblAkaWinner.Visible = True : LblAoWinner.Visible = True
        End If
        UpdateShowWinnerAvailability()
    End Sub

    ' Mode Online (juri isi sendiri lewat QR) -> input juri DISABLE.
    ' Mode Manual (operator yang isi) -> input juri ENABLE.
    Private Sub ApplyMode()
        Dim manual As Boolean = (CmbMode IsNot Nothing AndAlso CmbMode.SelectedIndex = 1)
        SetJudgeInputEnabled(manual)
    End Sub

    Private Sub SetJudgeInputEnabled(en As Boolean)
        For Each n In {NumAkaJ1, NumAkaJ2, NumAkaJ3, NumAkaJ4, NumAkaJ5, NumAkaJ6, NumAkaJ7,
                       NumAoJ1, NumAoJ2, NumAoJ3, NumAoJ4, NumAoJ5, NumAoJ6, NumAoJ7}
            If n IsNot Nothing Then n.Enabled = en
        Next
    End Sub

    Private Sub CmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMode.SelectedIndexChanged
        If isInitializing Then Return
        ApplyMode()
    End Sub

    ' Tombol "Manual | Online" = toggle cepat antar mode
    Private Sub BtnManualOnline_Click(sender As Object, e As EventArgs) Handles BtnManualOnline.Click
        If CmbMode Is Nothing Then Return
        CmbMode.SelectedIndex = If(CmbMode.SelectedIndex = 0, 1, 0)
    End Sub

    Private Sub CmbRules_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRules.SelectedIndexChanged
        If isInitializing Then Return
        RecalcJudgeTotals()
    End Sub

    Private Sub CmbServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServer.SelectedIndexChanged
        If isInitializing Then Return
        ' Server "own" -> izinkan Edit; server aplikasi -> Edit dimatikan
        If BtnEditServer IsNot Nothing Then BtnEditServer.Enabled = (CmbServer.SelectedIndex = 1)
    End Sub

    Private Sub BtnEditServer_Click(sender As Object, e As EventArgs) Handles BtnEditServer.Click
        Dim cur As String = If(CmbServer IsNot Nothing AndAlso CmbServer.SelectedItem IsNot Nothing, CmbServer.SelectedItem.ToString(), "")
        MessageBox.Show("Edit alamat server di sini." & vbCrLf & "Server aktif: " & cur, "Server", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' =====================================================================================
    ' 4) MATCH DETAIL & LOGO + TATAMI + TEXT ALIGN + UKURAN TEKS
    ' =====================================================================================
    ' Tombol upload ⬆ (BtnDetailScorePlus) : kirim detail pertandingan ke Scoreboard
    Private Sub BtnDetailScorePlus_Click(sender As Object, e As EventArgs) Handles BtnDetailScorePlus.Click
        SyncScoreboardProfile()
        MessageBox.Show("Information updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnMatchDetailPlus_Click(sender As Object, e As EventArgs) Handles BtnMatchDetailPlus.Click
        AdjustDetailFont(1.0F)
    End Sub
    Private Sub BtnMatchDetailMinus_Click(sender As Object, e As EventArgs) Handles BtnMatchDetailMinus.Click
        AdjustDetailFont(-1.0F)
    End Sub
    Private Sub BtnMatchDetailR_Click(sender As Object, e As EventArgs) Handles BtnMatchDetailR.Click
        If TxtMatchDetail IsNot Nothing Then TxtMatchDetail.Font = New Font(TxtMatchDetail.Font.FontFamily, 9.0F, TxtMatchDetail.Font.Style)
    End Sub
    Private Sub AdjustDetailFont(delta As Single)
        If TxtMatchDetail Is Nothing Then Return
        Dim newSize As Single = Math.Max(6.0F, Math.Min(48.0F, TxtMatchDetail.Font.Size + delta))
        TxtMatchDetail.Font = New Font(TxtMatchDetail.Font.FontFamily, newSize, TxtMatchDetail.Font.Style)
    End Sub

    Private Sub CmbTextAlign_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTextAlign.SelectedIndexChanged
        If isInitializing OrElse TxtMatchDetail Is Nothing Then Return
        Select Case CmbTextAlign.SelectedIndex
            Case 0 : TxtMatchDetail.TextAlign = HorizontalAlignment.Left
            Case 2 : TxtMatchDetail.TextAlign = HorizontalAlignment.Right
            Case Else : TxtMatchDetail.TextAlign = HorizontalAlignment.Center
        End Select
    End Sub

    Private Sub NumTatamiId_ValueChanged(sender As Object, e As EventArgs) Handles NumTatamiId.ValueChanged
        SyncTatami()
    End Sub

    Private Sub SyncTatami()
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed AndAlso frmScoreboard.LblTatamiNum IsNot Nothing Then
            frmScoreboard.LblTatamiNum.Text = NumTatamiId.Value.ToString()
        End If
    End Sub

    Private Sub ChkDetailScore_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDetailScore.CheckedChanged
        ' Penanda apakah detail skor ikut tampil di scoreboard (disinkronkan saat show score)
        SyncScoreboardPoints()
    End Sub

    ' =====================================================================================
    ' 5) SELECT PLAYER ON SCOREBOARD
    ' =====================================================================================
    Private Sub BtnSelectPlayer_Click(sender As Object, e As EventArgs) Handles BtnSelectPlayer.Click
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then BtnStartScoreboard_Click(sender, e)
        ApplySelectPlayerVisibility()
        SyncScoreboardProfile()
        SyncScoreboardPoints()
    End Sub

    Private Sub ApplySelectPlayerVisibility()
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then Return
        Dim showAka As Boolean = (RbAllComp IsNot Nothing AndAlso RbAllComp.Checked) OrElse (RbComp1 IsNot Nothing AndAlso RbComp1.Checked)
        Dim showAo As Boolean = (RbAllComp IsNot Nothing AndAlso RbAllComp.Checked) OrElse (RbComp2 IsNot Nothing AndAlso RbComp2.Checked)
        With frmScoreboard
            If .LblAkaName IsNot Nothing Then .LblAkaName.Visible = showAka
            If .LblAkaScore IsNot Nothing Then .LblAkaScore.Visible = showAka
            If .LblAoName IsNot Nothing Then .LblAoName.Visible = showAo
            If .LblAoScore IsNot Nothing Then .LblAoScore.Visible = showAo
        End With
    End Sub

    ' =====================================================================================
    ' 6) TEAM INFO : Update Info, pilih kompetitor (👤 / 🔍), Swap, Show Winner
    ' =====================================================================================
    Private Sub BtnAkaUpdateInfo_Click(sender As Object, e As EventArgs) Handles BtnAkaUpdateInfo.Click
        SyncScoreboardProfile()
        MessageBox.Show("Information updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub BtnAoUpdateInfo_Click(sender As Object, e As EventArgs) Handles BtnAoUpdateInfo.Click
        SyncScoreboardProfile()
        MessageBox.Show("Information updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Pemilihan kompetitor untuk match yang SEDANG berlangsung (Team Info)
    Private Sub BtnAkaExtraIcon_Click(sender As Object, e As EventArgs) Handles BtnAkaExtraIcon.Click, BtnAkaSearch.Click
        OpenCompetitorPicker("AKA")
    End Sub
    Private Sub BtnAoExtraIcon_Click(sender As Object, e As EventArgs) Handles BtnAoExtraIcon.Click, BtnAoSearch.Click
        OpenCompetitorPicker("AO")
    End Sub

    ' Pemilihan kompetitor untuk NEXT MATCH (di top bar)
    Private Sub BtnAkaIconSearch_Click(sender As Object, e As EventArgs) Handles BtnAkaIconSearch.Click
        OpenCompetitorPicker("NEXT_AKA")
    End Sub
    Private Sub BtnAoIconSearch_Click(sender As Object, e As EventArgs) Handles BtnAoIconSearch.Click
        OpenCompetitorPicker("NEXT_AO")
    End Sub

    Private Sub OpenCompetitorPicker(side As String)
        targetSide = side
        Try
            Dim frm As New ListOfCompetitor()
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka ListOfCompetitor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Dipanggil balik oleh ListOfCompetitor.BtnSelect_Click
    Public Sub SetCompetitorData(nama As String, team As String, info As String)
        Select Case targetSide
            Case "AKA"
                If TxtAkaNameMain IsNot Nothing Then TxtAkaNameMain.Text = nama
                If TxtAkaTeam1 IsNot Nothing Then TxtAkaTeam1.Text = team
                If TxtAkaTeam2 IsNot Nothing Then TxtAkaTeam2.Text = info
            Case "AO"
                If TxtAoNameMain IsNot Nothing Then TxtAoNameMain.Text = nama
                If TxtAoTeam1 IsNot Nothing Then TxtAoTeam1.Text = team
                If TxtAoTeam2 IsNot Nothing Then TxtAoTeam2.Text = info
            Case "NEXT_AKA"
                NextAkaName = nama : NextAkaTeam = team : NextAkaInfo = info
                If TxtAkaSearchDisplay IsNot Nothing Then TxtAkaSearchDisplay.Text = nama & " | " & team
            Case "NEXT_AO"
                NextAoName = nama : NextAoTeam = team : NextAoInfo = info
                If TxtAoSearchDisplay IsNot Nothing Then TxtAoSearchDisplay.Text = nama & " | " & team
        End Select
        UpdateShowWinnerAvailability()
    End Sub

    ' Dipanggil balik oleh ListOfTeam.PilihTim
    Public Sub UpdateTeamData(team As String, info As String)
        Select Case targetSide
            Case "AKA", "NEXT_AKA"
                If TxtAkaTeam1 IsNot Nothing Then TxtAkaTeam1.Text = team
                If TxtAkaTeam2 IsNot Nothing Then TxtAkaTeam2.Text = info
            Case "AO", "NEXT_AO"
                If TxtAoTeam1 IsNot Nothing Then TxtAoTeam1.Text = team
                If TxtAoTeam2 IsNot Nothing Then TxtAoTeam2.Text = info
        End Select
    End Sub

    ' Swap (⇅) : tukar data Team Info antara AKA <-> AO
    Private Sub BtnAkaSwap_Click(sender As Object, e As EventArgs) Handles BtnAkaSwap.Click, BtnAoSwap.Click
        SwapCurrentTeamInfo()
    End Sub
    Private Sub SwapCurrentTeamInfo()
        SwapText(TxtAkaNameMain, TxtAoNameMain)
        SwapText(TxtAkaTeam1, TxtAoTeam1)
        SwapText(TxtAkaTeam2, TxtAoTeam2)
        SyncScoreboardProfile()
    End Sub
    Private Sub SwapText(a As TextBox, b As TextBox)
        If a Is Nothing OrElse b Is Nothing Then Return
        Dim tmp As String = a.Text : a.Text = b.Text : b.Text = tmp
    End Sub

    ' Show Winner ▶ (AKA). (AO ditangani LblAoWinnerStatus_Click di atas.)
    Private Sub LblAkaWinnerStatus_Click(sender As Object, e As EventArgs) Handles LblAkaWinnerStatus.Click
        ShowWinnerWindow(True)
    End Sub

    Private Sub ShowWinnerWindow(isAka As Boolean)
        Dim nm As String = If(isAka, TxtAkaNameMain?.Text, TxtAoNameMain?.Text)
        Dim tm As String = If(isAka, TxtAkaTeam1?.Text, TxtAoTeam1?.Text)
        If String.IsNullOrWhiteSpace(nm) Then nm = If(isAka, "AKA COMPETITOR", "AO COMPETITOR")
        If String.IsNullOrWhiteSpace(tm) Then tm = If(isAka, "CONTINGENT AKA", "CONTINGENT AO")
        Try
            Dim w As New WinnerForm(isAka, nm, tm)
            w.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka WinnerForm: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Show Winner hanya aktif bila ada selisih skor ATAU lawan kena Kiken/Diskualifikasi
    Private Sub UpdateShowWinnerAvailability()
        Dim aka As Decimal = If(TotalScoreAKA IsNot Nothing, TotalScoreAKA.Value, 0D)
        Dim ao As Decimal = If(TotalScoreAO IsNot Nothing, TotalScoreAO.Value, 0D)
        Dim akaPenalty As Boolean = (BtnKikenAo.BackColor = Color.Yellow OrElse BtnDiskualifikasiAo.BackColor = Color.Yellow)
        Dim aoPenalty As Boolean = (BtnKikenAka.BackColor = Color.Yellow OrElse BtnDiskualifikasiAka.BackColor = Color.Yellow)
        If LblAkaWinnerStatus IsNot Nothing Then LblAkaWinnerStatus.Enabled = (aka > ao) OrElse akaPenalty
        If LblAoWinnerStatus IsNot Nothing Then LblAoWinnerStatus.Enabled = (ao > aka) OrElse aoPenalty
    End Sub

    ' =====================================================================================
    ' 7) NEXT MATCH : Load Next Match, Swap next, Next Match
    ' =====================================================================================
    Private Sub BtnLoadNextMatch_Click(sender As Object, e As EventArgs) Handles BtnLoadNextMatch.Click
        If NextAkaName <> "" Then
            If TxtAkaNameMain IsNot Nothing Then TxtAkaNameMain.Text = NextAkaName
            If TxtAkaTeam1 IsNot Nothing Then TxtAkaTeam1.Text = NextAkaTeam
            If TxtAkaTeam2 IsNot Nothing Then TxtAkaTeam2.Text = NextAkaInfo
        End If
        If NextAoName <> "" Then
            If TxtAoNameMain IsNot Nothing Then TxtAoNameMain.Text = NextAoName
            If TxtAoTeam1 IsNot Nothing Then TxtAoTeam1.Text = NextAoTeam
            If TxtAoTeam2 IsNot Nothing Then TxtAoTeam2.Text = NextAoInfo
        End If
        SyncScoreboardProfile()
        MessageBox.Show("Data pertandingan berhasil di-load!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnSwapNextMatch_Click(sender As Object, e As EventArgs) Handles BtnSwapNextMatch.Click
        Dim n = NextAkaName : NextAkaName = NextAoName : NextAoName = n
        Dim t = NextAkaTeam : NextAkaTeam = NextAoTeam : NextAoTeam = t
        Dim i = NextAkaInfo : NextAkaInfo = NextAoInfo : NextAoInfo = i
        SwapText(TxtAkaSearchDisplay, TxtAoSearchDisplay)
    End Sub

    Private Sub BtnNextMatch_Click(sender As Object, e As EventArgs) Handles BtnNextMatch.Click
        ' Siapkan pasangan berikutnya: bersihkan kolom Next Match agar siap diisi ulang
        NextAkaName = "" : NextAkaTeam = "" : NextAkaInfo = ""
        NextAoName = "" : NextAoTeam = "" : NextAoInfo = ""
        If TxtAkaSearchDisplay IsNot Nothing Then TxtAkaSearchDisplay.Clear()
        If TxtAoSearchDisplay IsNot Nothing Then TxtAoSearchDisplay.Clear()
    End Sub

    ' =====================================================================================
    ' 8) FOOTER : Show Score, Update Score, Reset Match, Save Result, Audio, Assign Task
    ' =====================================================================================
    Private Sub BtnShowScore_Click(sender As Object, e As EventArgs) Handles BtnShowScore.Click
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then BtnStartScoreboard_Click(sender, e)
        SyncScoreboardProfile()
        SyncScoreboardPoints()
        SyncScoreboardTimer()
        If Not audioMuted Then AudioController.PlaySound("Get Point")
    End Sub

    Private Sub BtnUpdateScore_Click(sender As Object, e As EventArgs) Handles BtnUpdateScore.Click
        RecalcJudgeTotals()
        SyncScoreboardPoints()
    End Sub

    Private Sub BtnResetMatch_Click(sender As Object, e As EventArgs) Handles BtnResetMatch.Click
        ResetAllScores()
        matchTimer.Stop() : BtnStartTimer.Text = "Start Timer  ⏱"
        PerfTimeFromInputs() : UpdatePerfTimerDisplay()
        waitTimer.Stop() : BtnStartWaitingTimer.Text = "Start Waiting Timer"
        UpdateShowWinnerAvailability()
        SyncScoreboardPoints()
    End Sub

    ' Save Match Result / Set Winner (Tie-Break) -> jendela Hantei
    Private Sub BtnSaveMatchResult_Click(sender As Object, e As EventArgs) Handles BtnSaveMatchResult.Click
        Try
            Dim h As New HanteiForm()
            h.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka Hantei/Hasil: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAudio_Click(sender As Object, e As EventArgs) Handles BtnAudio.Click
        audioMuted = Not audioMuted
        BtnAudio.Text = If(audioMuted, "🔇", "🔊")
    End Sub

    Private Sub BtnAssignTask_Click(sender As Object, e As EventArgs) Handles BtnAssignTask.Click
        ' Penugasan juri dilakukan via server (mode Online). Tanpa server, beri info.
        MessageBox.Show("Assign Task to Judges: fitur ini menugaskan juri melalui server (mode Online)." & vbCrLf &
                        "Sambungkan server terlebih dahulu (lihat tombol Server / QR Code).",
                        "Assign Task to Judges", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' =====================================================================================
    ' 9) JUDGE STATUS (kiri) : tombol Login / Scoring sebagai indikator status
    ' =====================================================================================
    Private Sub JudgeLogin_Click(sender As Object, e As EventArgs) _
        Handles BtnJ1Login.Click, BtnJ2Login.Click, BtnJ3Login.Click, BtnJ4Login.Click, BtnJ5Login.Click, BtnJ6Login.Click, BtnJ7Login.Click
        ToggleStatusButton(CType(sender, Button), Color.LimeGreen)
    End Sub
    Private Sub JudgeScoring_Click(sender As Object, e As EventArgs) _
        Handles BtnJ1Scoring.Click, BtnJ2Scoring.Click, BtnJ3Scoring.Click, BtnJ4Scoring.Click, BtnJ5Scoring.Click, BtnJ6Scoring.Click, BtnJ7Scoring.Click
        ToggleStatusButton(CType(sender, Button), Color.Gold)
    End Sub
    Private Sub ToggleStatusButton(b As Button, activeColor As Color)
        If b Is Nothing Then Return
        If b.BackColor = activeColor Then
            b.BackColor = SystemColors.Control
        Else
            b.BackColor = activeColor
        End If
    End Sub

    ' =====================================================================================
    ' 10) SYNC HELPERS -> ScoreBoard
    ' =====================================================================================
    Public Sub SyncScoreboardProfile()
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then Return
        With frmScoreboard
            If .LblAkaName IsNot Nothing AndAlso TxtAkaNameMain IsNot Nothing Then .LblAkaName.Text = TxtAkaNameMain.Text
            If .LblAoName IsNot Nothing AndAlso TxtAoNameMain IsNot Nothing Then .LblAoName.Text = TxtAoNameMain.Text
            If .LblMatchDesc IsNot Nothing AndAlso TxtMatchDetail IsNot Nothing Then .LblMatchDesc.Text = TxtMatchDetail.Text
        End With
        SyncTatami()
    End Sub

    Public Sub SyncScoreboardPoints()
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then Return
        If frmScoreboard.LblAkaScore IsNot Nothing AndAlso TotalScoreAKA IsNot Nothing Then frmScoreboard.LblAkaScore.Text = TotalScoreAKA.Value.ToString()
        If frmScoreboard.LblAoScore IsNot Nothing AndAlso TotalScoreAO IsNot Nothing Then frmScoreboard.LblAoScore.Text = TotalScoreAO.Value.ToString()
    End Sub

    Public Sub SyncScoreboardTimer()
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then Return
        If frmScoreboard.LblTimerMain IsNot Nothing AndAlso LblTimerDisplayMain IsNot Nothing Then
            frmScoreboard.LblTimerMain.Text = LblTimerDisplayMain.Text
        End If
    End Sub
End Class