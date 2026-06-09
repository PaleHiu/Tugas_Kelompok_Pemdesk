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

    Private Sub LblDiskualifikasiAo_Click(sender As Object, e As EventArgs) Handles BtnDiskualifikasiAo.Click
        ApplyPenaltyAndDeclareWinner(BtnDiskualifikasiAo, "AKA")
    End Sub

    Private Sub TxtMatchDetail_TextChanged(sender As Object, e As EventArgs) Handles TxtMatchDetail.TextChanged
    End Sub

    Private Sub LblTextAlign_Click(sender As Object, e As EventArgs) Handles LblTextAlign.Click
    End Sub

    Private Sub LblAoWinnerStatus_Click(sender As Object, e As EventArgs) Handles LblAoWinnerStatus.Click
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

End Class