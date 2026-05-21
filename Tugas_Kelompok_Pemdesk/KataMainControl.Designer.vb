<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KataMainControl
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    ' ============================================================
    ' DEKLARASI FIELD — wajib Friend WithEvents agar Designer
    ' bisa melihat dan mengedit tiap komponen secara individual
    ' ============================================================

    ' ── LEFT BAR ─────────────────────────────────────────────
    Friend WithEvents PnlLeftBar As System.Windows.Forms.Panel
    Friend WithEvents LblJudgeStatusTitle As System.Windows.Forms.Label
    Friend WithEvents PnlJ1 As System.Windows.Forms.Panel
    Friend WithEvents LblJ1 As System.Windows.Forms.Label
    Friend WithEvents BtnJ1Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ1Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ2 As System.Windows.Forms.Panel
    Friend WithEvents LblJ2 As System.Windows.Forms.Label
    Friend WithEvents BtnJ2Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ2Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ3 As System.Windows.Forms.Panel
    Friend WithEvents LblJ3 As System.Windows.Forms.Label
    Friend WithEvents BtnJ3Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ3Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ4 As System.Windows.Forms.Panel
    Friend WithEvents LblJ4 As System.Windows.Forms.Label
    Friend WithEvents BtnJ4Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ4Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ5 As System.Windows.Forms.Panel
    Friend WithEvents LblJ5 As System.Windows.Forms.Label
    Friend WithEvents BtnJ5Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ5Scoring As System.Windows.Forms.Button
    Friend WithEvents BtnQRCode As System.Windows.Forms.Button

    ' ── TOP BAR ──────────────────────────────────────────────
    Friend WithEvents PnlTopBar As System.Windows.Forms.Panel
    Friend WithEvents BtnNextMatch As System.Windows.Forms.Button
    Friend WithEvents TxtAkaSearchDisplay As System.Windows.Forms.TextBox
    Friend WithEvents BtnAkaIconSearch As System.Windows.Forms.Button
    Friend WithEvents LblVS As System.Windows.Forms.Label
    Friend WithEvents BtnAoIconSearch As System.Windows.Forms.Button
    Friend WithEvents TxtAoSearchDisplay As System.Windows.Forms.TextBox
    Friend WithEvents BtnSwapNextMatch As System.Windows.Forms.Button
    Friend WithEvents BtnLoadNextMatch As System.Windows.Forms.Button

    ' ── FOOTER ───────────────────────────────────────────────
    Friend WithEvents PnlFooter As System.Windows.Forms.Panel
    Friend WithEvents LblServer As System.Windows.Forms.Label
    Friend WithEvents CmbServer As System.Windows.Forms.ComboBox
    Friend WithEvents BtnEditServer As System.Windows.Forms.Button
    Friend WithEvents LblApiInfo As System.Windows.Forms.Label
    Friend WithEvents LblApiTimer As System.Windows.Forms.Label
    Friend WithEvents NumApiTimer As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblApiTimerSuffix As System.Windows.Forms.Label
    Friend WithEvents BtnAssignTask As System.Windows.Forms.Button
    Friend WithEvents BtnLogActivity As System.Windows.Forms.Button
    Friend WithEvents BtnShortcut As System.Windows.Forms.Button
    Friend WithEvents BtnSettings As System.Windows.Forms.Button
    Friend WithEvents BtnMonitor As System.Windows.Forms.Button
    Friend WithEvents BtnAudio As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateScore As System.Windows.Forms.Button
    Friend WithEvents BtnShowScore As System.Windows.Forms.Button
    Friend WithEvents BtnResetMatch As System.Windows.Forms.Button
    Friend WithEvents BtnSaveMatchResult As System.Windows.Forms.Button

    ' ── RIGHT BAR ────────────────────────────────────────────
    Friend WithEvents PnlRightBar As System.Windows.Forms.Panel
    Friend WithEvents LblScoringType As System.Windows.Forms.Label
    Friend WithEvents RbScoreType As System.Windows.Forms.RadioButton
    Friend WithEvents LblRules As System.Windows.Forms.Label
    Friend WithEvents CmbRules As System.Windows.Forms.ComboBox
    Friend WithEvents LblMode As System.Windows.Forms.Label
    Friend WithEvents CmbMode As System.Windows.Forms.ComboBox
    Friend WithEvents BtnManualOnline As System.Windows.Forms.Button
    Friend WithEvents RbFlagSystem As System.Windows.Forms.RadioButton
    Friend WithEvents PicFlagRed As System.Windows.Forms.PictureBox
    Friend WithEvents PicFlagBlue As System.Windows.Forms.PictureBox
    Friend WithEvents LblJudge As System.Windows.Forms.Label
    Friend WithEvents Rb5Judge As System.Windows.Forms.RadioButton
    Friend WithEvents Rb7Judge As System.Windows.Forms.RadioButton
    Friend WithEvents Rb3Judge As System.Windows.Forms.RadioButton
    Friend WithEvents TabMatchDetail As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDetail As System.Windows.Forms.TabPage
    Friend WithEvents TxtMatchDetail As System.Windows.Forms.TextBox
    Friend WithEvents TabPageLogo As System.Windows.Forms.TabPage
    Friend WithEvents BtnMatchDetailR As System.Windows.Forms.Button
    Friend WithEvents BtnMatchDetailMinus As System.Windows.Forms.Button
    Friend WithEvents BtnMatchDetailPlus As System.Windows.Forms.Button
    Friend WithEvents LblTextAlign As System.Windows.Forms.Label
    Friend WithEvents CmbTextAlign As System.Windows.Forms.ComboBox
    Friend WithEvents ChkDetailScore As System.Windows.Forms.CheckBox
    Friend WithEvents BtnDetailScorePlus As System.Windows.Forms.Button
    Friend WithEvents LblTatami As System.Windows.Forms.Label
    Friend WithEvents NumTatamiId As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblTimerDisplayMain As System.Windows.Forms.Label
    Friend WithEvents GrpScoreboardSelect As System.Windows.Forms.GroupBox
    Friend WithEvents RbComp1 As System.Windows.Forms.RadioButton
    Friend WithEvents RbComp2 As System.Windows.Forms.RadioButton
    Friend WithEvents RbAllComp As System.Windows.Forms.RadioButton
    Friend WithEvents LblShortcutHint As System.Windows.Forms.Label
    Friend WithEvents BtnScoreboardIcon As System.Windows.Forms.Button
    Friend WithEvents BtnStartScoreboard As System.Windows.Forms.Button
    Friend WithEvents GrpTimerSetting As System.Windows.Forms.GroupBox
    Friend WithEvents LblWaiting As System.Windows.Forms.Label
    Friend WithEvents NumWaitMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblWaitColon As System.Windows.Forms.Label
    Friend WithEvents NumWaitSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblPerformance As System.Windows.Forms.Label
    Friend WithEvents NumPerfMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblPerfColon As System.Windows.Forms.Label
    Friend WithEvents NumPerfSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnStartWaitingTimer As System.Windows.Forms.Button
    Friend WithEvents BtnEyeTimer As System.Windows.Forms.Button
    Friend WithEvents BtnGearTimer As System.Windows.Forms.Button
    Friend WithEvents BtnStartTimer As System.Windows.Forms.Button

    ' ── CENTER WORKSPACE ─────────────────────────────────────
    Friend WithEvents PnlMainWorkspace As System.Windows.Forms.Panel

    ' ── AKA PANEL ────────────────────────────────────────────
    Friend WithEvents PnlAka As System.Windows.Forms.Panel
    Friend WithEvents LblAkaHeader As System.Windows.Forms.Label
    Friend WithEvents LblAkaName As System.Windows.Forms.Label
    Friend WithEvents BtnAkaUpdateInfo As System.Windows.Forms.Button
    Friend WithEvents BtnAkaExtraIcon As System.Windows.Forms.Button
    Friend WithEvents TxtAkaNameMain As System.Windows.Forms.TextBox
    Friend WithEvents LblAkaTeam As System.Windows.Forms.Label
    Friend WithEvents BtnAkaSwap As System.Windows.Forms.Button
    Friend WithEvents BtnAkaSearch As System.Windows.Forms.Button
    Friend WithEvents TxtAkaTeam1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtAkaTeam2 As System.Windows.Forms.TextBox
    Friend WithEvents LblAkaKata As System.Windows.Forms.Label
    Friend WithEvents CmbAkaKata As System.Windows.Forms.ComboBox
    Friend WithEvents LblAkaDisqualification As System.Windows.Forms.Label
    Friend WithEvents BtnKikenAka As System.Windows.Forms.Button
    Friend WithEvents PicAkaCircle As System.Windows.Forms.PictureBox
    Friend WithEvents PicAkaAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents LblAkaWinnerStatus As System.Windows.Forms.Label

    ' ── CENTER SCORE PANEL ───────────────────────────────────
    Friend WithEvents PnlCenterScore As System.Windows.Forms.Panel
    Friend WithEvents LblJudgeScoreTitle As System.Windows.Forms.Label
    Friend WithEvents PnlPointInputsAka As System.Windows.Forms.Panel
    Friend WithEvents LblAkaJ1 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ2 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ3 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ4 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ5 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents PnlPointInputsAo As System.Windows.Forms.Panel
    Friend WithEvents LblAoJ1 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ2 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ3 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ4 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ5 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblTotalScoreAkaTitle As System.Windows.Forms.Label
    Friend WithEvents BtnResetScoreAka As System.Windows.Forms.Button
    Friend WithEvents LblTotalScoreAoTitle As System.Windows.Forms.Label
    Friend WithEvents BtnResetScoreAo As System.Windows.Forms.Button

    ' ── AO PANEL ─────────────────────────────────────────────
    Friend WithEvents PnlAo As System.Windows.Forms.Panel
    Friend WithEvents LblAoHeader As System.Windows.Forms.Label
    Friend WithEvents LblAoName As System.Windows.Forms.Label
    Friend WithEvents BtnAoUpdateInfo As System.Windows.Forms.Button
    Friend WithEvents BtnAoExtraIcon As System.Windows.Forms.Button
    Friend WithEvents TxtAoNameMain As System.Windows.Forms.TextBox
    Friend WithEvents LblAoTeam As System.Windows.Forms.Label
    Friend WithEvents BtnAoSwap As System.Windows.Forms.Button
    Friend WithEvents BtnAoSearch As System.Windows.Forms.Button
    Friend WithEvents TxtAoTeam1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtAoTeam2 As System.Windows.Forms.TextBox
    Friend WithEvents LblAoKata As System.Windows.Forms.Label
    Friend WithEvents CmbAoKata As System.Windows.Forms.ComboBox
    Friend WithEvents LblAoDisqualification As System.Windows.Forms.Label
    Friend WithEvents BtnKikenAo As System.Windows.Forms.Button
    Friend WithEvents PicAoCircle As System.Windows.Forms.PictureBox
    Friend WithEvents PicAoAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents LblAoWinnerStatus As System.Windows.Forms.Label

    ' ============================================================
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PnlLeftBar = New Panel()
        BtnQRCode = New Button()
        PnlJ5 = New Panel()
        BtnJ5Scoring = New Button()
        BtnJ5Login = New Button()
        LblJ5 = New Label()
        PnlJ4 = New Panel()
        BtnJ4Scoring = New Button()
        BtnJ4Login = New Button()
        LblJ4 = New Label()
        PnlJ3 = New Panel()
        BtnJ3Scoring = New Button()
        BtnJ3Login = New Button()
        LblJ3 = New Label()
        PnlJ2 = New Panel()
        BtnJ2Scoring = New Button()
        BtnJ2Login = New Button()
        LblJ2 = New Label()
        PnlJ1 = New Panel()
        BtnJ1Scoring = New Button()
        BtnJ1Login = New Button()
        LblJ1 = New Label()
        LblJudgeStatusTitle = New Label()
        PnlTopBar = New Panel()
        BtnLoadNextMatch = New Button()
        BtnSwapNextMatch = New Button()
        TxtAoSearchDisplay = New TextBox()
        BtnAoIconSearch = New Button()
        LblVS = New Label()
        BtnAkaIconSearch = New Button()
        TxtAkaSearchDisplay = New TextBox()
        BtnNextMatch = New Button()
        PnlFooter = New Panel()
        BtnSaveMatchResult = New Button()
        BtnResetMatch = New Button()
        BtnShowScore = New Button()
        BtnUpdateScore = New Button()
        BtnAudio = New Button()
        BtnMonitor = New Button()
        BtnSettings = New Button()
        BtnShortcut = New Button()
        BtnLogActivity = New Button()
        BtnAssignTask = New Button()
        LblApiTimerSuffix = New Label()
        NumApiTimer = New NumericUpDown()
        LblApiTimer = New Label()
        LblApiInfo = New Label()
        BtnEditServer = New Button()
        CmbServer = New ComboBox()
        LblServer = New Label()
        PnlRightBar = New Panel()
        BtnStartTimer = New Button()
        BtnGearTimer = New Button()
        BtnEyeTimer = New Button()
        BtnStartWaitingTimer = New Button()
        GrpTimerSetting = New GroupBox()
        NumPerfSec = New NumericUpDown()
        LblPerfColon = New Label()
        NumPerfMin = New NumericUpDown()
        LblPerformance = New Label()
        NumWaitSec = New NumericUpDown()
        LblWaitColon = New Label()
        NumWaitMin = New NumericUpDown()
        LblWaiting = New Label()
        BtnStartScoreboard = New Button()
        BtnScoreboardIcon = New Button()
        GrpScoreboardSelect = New GroupBox()
        BtnSelectPlayer = New Button()
        LblShortcutHint = New Label()
        RbComp2 = New RadioButton()
        RbAllComp = New RadioButton()
        RbComp1 = New RadioButton()
        LblTimerDisplayMain = New Label()
        NumTatamiId = New NumericUpDown()
        LblTatami = New Label()
        BtnDetailScorePlus = New Button()
        ChkDetailScore = New CheckBox()
        CmbTextAlign = New ComboBox()
        LblTextAlign = New Label()
        BtnMatchDetailPlus = New Button()
        BtnMatchDetailMinus = New Button()
        BtnMatchDetailR = New Button()
        TabMatchDetail = New TabControl()
        TabPageDetail = New TabPage()
        TxtMatchDetail = New TextBox()
        TabPageLogo = New TabPage()
        Rb3Judge = New RadioButton()
        Rb7Judge = New RadioButton()
        Rb5Judge = New RadioButton()
        LblJudge = New Label()
        PicFlagBlue = New PictureBox()
        PicFlagRed = New PictureBox()
        RbFlagSystem = New RadioButton()
        BtnManualOnline = New Button()
        CmbMode = New ComboBox()
        LblMode = New Label()
        CmbRules = New ComboBox()
        LblRules = New Label()
        RbScoreType = New RadioButton()
        LblScoringType = New Label()
        PnlMainWorkspace = New Panel()
        PnlCenterScore = New Panel()
        TotalScoreAO = New NumericUpDown()
        TotalScoreAKA = New NumericUpDown()
        BtnResetScoreAka = New Button()
        BtnResetScoreAo = New Button()
        PnlPointInputsAo = New Panel()
        NumAoJ5 = New NumericUpDown()
        LblAoJ5 = New Label()
        NumAoJ4 = New NumericUpDown()
        LblAoJ4 = New Label()
        NumAoJ3 = New NumericUpDown()
        LblAoJ3 = New Label()
        NumAoJ2 = New NumericUpDown()
        LblAoJ2 = New Label()
        NumAoJ1 = New NumericUpDown()
        LblAoJ1 = New Label()
        PnlPointInputsAka = New Panel()
        NumAkaJ5 = New NumericUpDown()
        LblAkaJ5 = New Label()
        NumAkaJ4 = New NumericUpDown()
        LblAkaJ4 = New Label()
        NumAkaJ3 = New NumericUpDown()
        LblAkaJ3 = New Label()
        NumAkaJ2 = New NumericUpDown()
        LblAkaJ2 = New Label()
        NumAkaJ1 = New NumericUpDown()
        LblAkaJ1 = New Label()
        LblTotalScoreAkaTitle = New Label()
        LblTotalScoreAoTitle = New Label()
        LblJudgeScoreTitle = New Label()
        PnlAo = New Panel()
        LblAoWinnerStatus = New Label()
        PicAoAvatar = New PictureBox()
        PicAoCircle = New PictureBox()
        BtnKikenAo = New Button()
        LblAoDisqualification = New Label()
        CmbAoKata = New ComboBox()
        LblAoKata = New Label()
        TxtAoTeam2 = New TextBox()
        TxtAoTeam1 = New TextBox()
        BtnAoSearch = New Button()
        BtnAoSwap = New Button()
        LblAoTeam = New Label()
        TxtAoNameMain = New TextBox()
        BtnAoExtraIcon = New Button()
        BtnAoUpdateInfo = New Button()
        LblAoName = New Label()
        LblAoHeader = New Label()
        PnlAka = New Panel()
        LblAkaWinnerStatus = New Label()
        PicAkaAvatar = New PictureBox()
        PicAkaCircle = New PictureBox()
        BtnKikenAka = New Button()
        LblAkaDisqualification = New Label()
        CmbAkaKata = New ComboBox()
        LblAkaKata = New Label()
        TxtAkaTeam2 = New TextBox()
        TxtAkaTeam1 = New TextBox()
        BtnAkaSearch = New Button()
        BtnAkaSwap = New Button()
        LblAkaTeam = New Label()
        TxtAkaNameMain = New TextBox()
        BtnAkaExtraIcon = New Button()
        BtnAkaUpdateInfo = New Button()
        LblAkaName = New Label()
        LblAkaHeader = New Label()
        PnlLeftBar.SuspendLayout()
        PnlJ5.SuspendLayout()
        PnlJ4.SuspendLayout()
        PnlJ3.SuspendLayout()
        PnlJ2.SuspendLayout()
        PnlJ1.SuspendLayout()
        PnlTopBar.SuspendLayout()
        PnlFooter.SuspendLayout()
        CType(NumApiTimer, ComponentModel.ISupportInitialize).BeginInit()
        PnlRightBar.SuspendLayout()
        GrpTimerSetting.SuspendLayout()
        CType(NumPerfSec, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumPerfMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumWaitSec, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumWaitMin, ComponentModel.ISupportInitialize).BeginInit()
        GrpScoreboardSelect.SuspendLayout()
        CType(NumTatamiId, ComponentModel.ISupportInitialize).BeginInit()
        TabMatchDetail.SuspendLayout()
        TabPageDetail.SuspendLayout()
        CType(PicFlagBlue, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicFlagRed, ComponentModel.ISupportInitialize).BeginInit()
        PnlMainWorkspace.SuspendLayout()
        PnlCenterScore.SuspendLayout()
        CType(TotalScoreAO, ComponentModel.ISupportInitialize).BeginInit()
        CType(TotalScoreAKA, ComponentModel.ISupportInitialize).BeginInit()
        PnlPointInputsAo.SuspendLayout()
        CType(NumAoJ5, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ1, ComponentModel.ISupportInitialize).BeginInit()
        PnlPointInputsAka.SuspendLayout()
        CType(NumAkaJ5, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ1, ComponentModel.ISupportInitialize).BeginInit()
        PnlAo.SuspendLayout()
        CType(PicAoAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicAoCircle, ComponentModel.ISupportInitialize).BeginInit()
        PnlAka.SuspendLayout()
        CType(PicAkaAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicAkaCircle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlLeftBar
        ' 
        PnlLeftBar.BackColor = Color.FromArgb(CByte(18), CByte(22), CByte(44))
        PnlLeftBar.Controls.Add(BtnQRCode)
        PnlLeftBar.Controls.Add(PnlJ5)
        PnlLeftBar.Controls.Add(PnlJ4)
        PnlLeftBar.Controls.Add(PnlJ3)
        PnlLeftBar.Controls.Add(PnlJ2)
        PnlLeftBar.Controls.Add(PnlJ1)
        PnlLeftBar.Controls.Add(LblJudgeStatusTitle)
        PnlLeftBar.Dock = DockStyle.Left
        PnlLeftBar.Location = New Point(0, 40)
        PnlLeftBar.Name = "PnlLeftBar"
        PnlLeftBar.Size = New Size(65, 724)
        PnlLeftBar.TabIndex = 0
        ' 
        ' BtnQRCode
        ' 
        BtnQRCode.BackColor = Color.FromArgb(CByte(40), CByte(45), CByte(70))
        BtnQRCode.FlatAppearance.BorderColor = Color.FromArgb(CByte(70), CByte(75), CByte(100))
        BtnQRCode.FlatStyle = FlatStyle.Flat
        BtnQRCode.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        BtnQRCode.ForeColor = Color.White
        BtnQRCode.Location = New Point(5, 418)
        BtnQRCode.Name = "BtnQRCode"
        BtnQRCode.Size = New Size(55, 44)
        BtnQRCode.TabIndex = 6
        BtnQRCode.Text = "QR" & vbCrLf & "Code"
        BtnQRCode.UseVisualStyleBackColor = False
        ' 
        ' PnlJ5
        ' 
        PnlJ5.BackColor = Color.Transparent
        PnlJ5.Controls.Add(BtnJ5Scoring)
        PnlJ5.Controls.Add(BtnJ5Login)
        PnlJ5.Controls.Add(LblJ5)
        PnlJ5.Location = New Point(0, 336)
        PnlJ5.Name = "PnlJ5"
        PnlJ5.Size = New Size(65, 70)
        PnlJ5.TabIndex = 5
        ' 
        ' BtnJ5Scoring
        ' 
        BtnJ5Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ5Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ5Scoring.FlatStyle = FlatStyle.Flat
        BtnJ5Scoring.Font = New Font("Segoe UI", 7.5F)
        BtnJ5Scoring.ForeColor = Color.White
        BtnJ5Scoring.Location = New Point(5, 44)
        BtnJ5Scoring.Name = "BtnJ5Scoring"
        BtnJ5Scoring.Size = New Size(55, 22)
        BtnJ5Scoring.TabIndex = 2
        BtnJ5Scoring.Text = "Scoring"
        BtnJ5Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ5Login
        ' 
        BtnJ5Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ5Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ5Login.FlatStyle = FlatStyle.Flat
        BtnJ5Login.Font = New Font("Segoe UI", 7.5F)
        BtnJ5Login.ForeColor = Color.White
        BtnJ5Login.Location = New Point(5, 20)
        BtnJ5Login.Name = "BtnJ5Login"
        BtnJ5Login.Size = New Size(55, 22)
        BtnJ5Login.TabIndex = 1
        BtnJ5Login.Text = "Login"
        BtnJ5Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ5
        ' 
        LblJ5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ5.ForeColor = Color.White
        LblJ5.Location = New Point(0, 0)
        LblJ5.Name = "LblJ5"
        LblJ5.Size = New Size(65, 18)
        LblJ5.TabIndex = 0
        LblJ5.Text = "J5"
        LblJ5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlJ4
        ' 
        PnlJ4.BackColor = Color.Transparent
        PnlJ4.Controls.Add(BtnJ4Scoring)
        PnlJ4.Controls.Add(BtnJ4Login)
        PnlJ4.Controls.Add(LblJ4)
        PnlJ4.Location = New Point(0, 262)
        PnlJ4.Name = "PnlJ4"
        PnlJ4.Size = New Size(65, 70)
        PnlJ4.TabIndex = 4
        ' 
        ' BtnJ4Scoring
        ' 
        BtnJ4Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ4Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ4Scoring.FlatStyle = FlatStyle.Flat
        BtnJ4Scoring.Font = New Font("Segoe UI", 7.5F)
        BtnJ4Scoring.ForeColor = Color.White
        BtnJ4Scoring.Location = New Point(5, 44)
        BtnJ4Scoring.Name = "BtnJ4Scoring"
        BtnJ4Scoring.Size = New Size(55, 22)
        BtnJ4Scoring.TabIndex = 2
        BtnJ4Scoring.Text = "Scoring"
        BtnJ4Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ4Login
        ' 
        BtnJ4Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ4Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ4Login.FlatStyle = FlatStyle.Flat
        BtnJ4Login.Font = New Font("Segoe UI", 7.5F)
        BtnJ4Login.ForeColor = Color.White
        BtnJ4Login.Location = New Point(5, 20)
        BtnJ4Login.Name = "BtnJ4Login"
        BtnJ4Login.Size = New Size(55, 22)
        BtnJ4Login.TabIndex = 1
        BtnJ4Login.Text = "Login"
        BtnJ4Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ4
        ' 
        LblJ4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ4.ForeColor = Color.White
        LblJ4.Location = New Point(0, 0)
        LblJ4.Name = "LblJ4"
        LblJ4.Size = New Size(65, 18)
        LblJ4.TabIndex = 0
        LblJ4.Text = "J4"
        LblJ4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlJ3
        ' 
        PnlJ3.BackColor = Color.Transparent
        PnlJ3.Controls.Add(BtnJ3Scoring)
        PnlJ3.Controls.Add(BtnJ3Login)
        PnlJ3.Controls.Add(LblJ3)
        PnlJ3.Location = New Point(0, 188)
        PnlJ3.Name = "PnlJ3"
        PnlJ3.Size = New Size(65, 70)
        PnlJ3.TabIndex = 3
        ' 
        ' BtnJ3Scoring
        ' 
        BtnJ3Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ3Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ3Scoring.FlatStyle = FlatStyle.Flat
        BtnJ3Scoring.Font = New Font("Segoe UI", 7.5F)
        BtnJ3Scoring.ForeColor = Color.White
        BtnJ3Scoring.Location = New Point(5, 44)
        BtnJ3Scoring.Name = "BtnJ3Scoring"
        BtnJ3Scoring.Size = New Size(55, 22)
        BtnJ3Scoring.TabIndex = 2
        BtnJ3Scoring.Text = "Scoring"
        BtnJ3Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ3Login
        ' 
        BtnJ3Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ3Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ3Login.FlatStyle = FlatStyle.Flat
        BtnJ3Login.Font = New Font("Segoe UI", 7.5F)
        BtnJ3Login.ForeColor = Color.White
        BtnJ3Login.Location = New Point(5, 20)
        BtnJ3Login.Name = "BtnJ3Login"
        BtnJ3Login.Size = New Size(55, 22)
        BtnJ3Login.TabIndex = 1
        BtnJ3Login.Text = "Login"
        BtnJ3Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ3
        ' 
        LblJ3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ3.ForeColor = Color.White
        LblJ3.Location = New Point(0, 0)
        LblJ3.Name = "LblJ3"
        LblJ3.Size = New Size(65, 18)
        LblJ3.TabIndex = 0
        LblJ3.Text = "J3"
        LblJ3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlJ2
        ' 
        PnlJ2.BackColor = Color.Transparent
        PnlJ2.Controls.Add(BtnJ2Scoring)
        PnlJ2.Controls.Add(BtnJ2Login)
        PnlJ2.Controls.Add(LblJ2)
        PnlJ2.Location = New Point(0, 114)
        PnlJ2.Name = "PnlJ2"
        PnlJ2.Size = New Size(65, 70)
        PnlJ2.TabIndex = 2
        ' 
        ' BtnJ2Scoring
        ' 
        BtnJ2Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ2Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ2Scoring.FlatStyle = FlatStyle.Flat
        BtnJ2Scoring.Font = New Font("Segoe UI", 7.5F)
        BtnJ2Scoring.ForeColor = Color.White
        BtnJ2Scoring.Location = New Point(5, 44)
        BtnJ2Scoring.Name = "BtnJ2Scoring"
        BtnJ2Scoring.Size = New Size(55, 22)
        BtnJ2Scoring.TabIndex = 2
        BtnJ2Scoring.Text = "Scoring"
        BtnJ2Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ2Login
        ' 
        BtnJ2Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ2Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ2Login.FlatStyle = FlatStyle.Flat
        BtnJ2Login.Font = New Font("Segoe UI", 7.5F)
        BtnJ2Login.ForeColor = Color.White
        BtnJ2Login.Location = New Point(5, 20)
        BtnJ2Login.Name = "BtnJ2Login"
        BtnJ2Login.Size = New Size(55, 22)
        BtnJ2Login.TabIndex = 1
        BtnJ2Login.Text = "Login"
        BtnJ2Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ2
        ' 
        LblJ2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ2.ForeColor = Color.White
        LblJ2.Location = New Point(0, 0)
        LblJ2.Name = "LblJ2"
        LblJ2.Size = New Size(65, 18)
        LblJ2.TabIndex = 0
        LblJ2.Text = "J2"
        LblJ2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlJ1
        ' 
        PnlJ1.BackColor = Color.Transparent
        PnlJ1.Controls.Add(BtnJ1Scoring)
        PnlJ1.Controls.Add(BtnJ1Login)
        PnlJ1.Controls.Add(LblJ1)
        PnlJ1.Location = New Point(0, 40)
        PnlJ1.Name = "PnlJ1"
        PnlJ1.Size = New Size(65, 70)
        PnlJ1.TabIndex = 1
        ' 
        ' BtnJ1Scoring
        ' 
        BtnJ1Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ1Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ1Scoring.FlatStyle = FlatStyle.Flat
        BtnJ1Scoring.Font = New Font("Segoe UI", 7.5F)
        BtnJ1Scoring.ForeColor = Color.White
        BtnJ1Scoring.Location = New Point(5, 44)
        BtnJ1Scoring.Name = "BtnJ1Scoring"
        BtnJ1Scoring.Size = New Size(55, 22)
        BtnJ1Scoring.TabIndex = 2
        BtnJ1Scoring.Text = "Scoring"
        BtnJ1Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ1Login
        ' 
        BtnJ1Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ1Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ1Login.FlatStyle = FlatStyle.Flat
        BtnJ1Login.Font = New Font("Segoe UI", 7.5F)
        BtnJ1Login.ForeColor = Color.White
        BtnJ1Login.Location = New Point(5, 20)
        BtnJ1Login.Name = "BtnJ1Login"
        BtnJ1Login.Size = New Size(55, 22)
        BtnJ1Login.TabIndex = 1
        BtnJ1Login.Text = "Login"
        BtnJ1Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ1
        ' 
        LblJ1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ1.ForeColor = Color.White
        LblJ1.Location = New Point(0, 0)
        LblJ1.Name = "LblJ1"
        LblJ1.Size = New Size(65, 18)
        LblJ1.TabIndex = 0
        LblJ1.Text = "J1"
        LblJ1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblJudgeStatusTitle
        ' 
        LblJudgeStatusTitle.BackColor = Color.Transparent
        LblJudgeStatusTitle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        LblJudgeStatusTitle.ForeColor = Color.White
        LblJudgeStatusTitle.Location = New Point(0, 3)
        LblJudgeStatusTitle.Name = "LblJudgeStatusTitle"
        LblJudgeStatusTitle.Size = New Size(65, 34)
        LblJudgeStatusTitle.TabIndex = 0
        LblJudgeStatusTitle.Text = "Judge" & vbCrLf & "Status"
        LblJudgeStatusTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlTopBar
        ' 
        PnlTopBar.BackColor = Color.White
        PnlTopBar.BorderStyle = BorderStyle.FixedSingle
        PnlTopBar.Controls.Add(BtnLoadNextMatch)
        PnlTopBar.Controls.Add(BtnSwapNextMatch)
        PnlTopBar.Controls.Add(TxtAoSearchDisplay)
        PnlTopBar.Controls.Add(BtnAoIconSearch)
        PnlTopBar.Controls.Add(LblVS)
        PnlTopBar.Controls.Add(BtnAkaIconSearch)
        PnlTopBar.Controls.Add(TxtAkaSearchDisplay)
        PnlTopBar.Controls.Add(BtnNextMatch)
        PnlTopBar.Dock = DockStyle.Top
        PnlTopBar.Location = New Point(0, 0)
        PnlTopBar.Name = "PnlTopBar"
        PnlTopBar.Size = New Size(1352, 40)
        PnlTopBar.TabIndex = 1
        ' 
        ' BtnLoadNextMatch
        ' 
        BtnLoadNextMatch.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(0))
        BtnLoadNextMatch.FlatAppearance.BorderSize = 0
        BtnLoadNextMatch.FlatStyle = FlatStyle.Flat
        BtnLoadNextMatch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnLoadNextMatch.Location = New Point(890, 3)
        BtnLoadNextMatch.Name = "BtnLoadNextMatch"
        BtnLoadNextMatch.Size = New Size(138, 30)
        BtnLoadNextMatch.TabIndex = 7
        BtnLoadNextMatch.Text = "Load Next Match"
        BtnLoadNextMatch.UseVisualStyleBackColor = False
        ' 
        ' BtnSwapNextMatch
        ' 
        BtnSwapNextMatch.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(100))
        BtnSwapNextMatch.FlatAppearance.BorderColor = Color.Gray
        BtnSwapNextMatch.FlatStyle = FlatStyle.Flat
        BtnSwapNextMatch.Font = New Font("Segoe UI", 9.0F)
        BtnSwapNextMatch.ForeColor = Color.White
        BtnSwapNextMatch.Location = New Point(855, 6)
        BtnSwapNextMatch.Name = "BtnSwapNextMatch"
        BtnSwapNextMatch.Size = New Size(28, 26)
        BtnSwapNextMatch.TabIndex = 6
        BtnSwapNextMatch.Text = "⇄"
        BtnSwapNextMatch.UseVisualStyleBackColor = False
        ' 
        ' TxtAoSearchDisplay
        ' 
        TxtAoSearchDisplay.BackColor = Color.White
        TxtAoSearchDisplay.BorderStyle = BorderStyle.FixedSingle
        TxtAoSearchDisplay.Font = New Font("Segoe UI", 9.0F)
        TxtAoSearchDisplay.Location = New Point(661, 6)
        TxtAoSearchDisplay.Name = "TxtAoSearchDisplay"
        TxtAoSearchDisplay.Size = New Size(190, 23)
        TxtAoSearchDisplay.TabIndex = 5
        ' 
        ' BtnAoIconSearch
        ' 
        BtnAoIconSearch.BackColor = Color.WhiteSmoke
        BtnAoIconSearch.FlatAppearance.BorderColor = Color.LightGray
        BtnAoIconSearch.FlatStyle = FlatStyle.Flat
        BtnAoIconSearch.Font = New Font("Segoe UI", 8.0F)
        BtnAoIconSearch.Location = New Point(630, 6)
        BtnAoIconSearch.Name = "BtnAoIconSearch"
        BtnAoIconSearch.Size = New Size(28, 26)
        BtnAoIconSearch.TabIndex = 4
        BtnAoIconSearch.Text = "▼"
        BtnAoIconSearch.UseVisualStyleBackColor = False
        ' 
        ' LblVS
        ' 
        LblVS.AutoSize = True
        LblVS.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        LblVS.Location = New Point(603, 8)
        LblVS.Name = "LblVS"
        LblVS.Size = New Size(27, 20)
        LblVS.TabIndex = 3
        LblVS.Text = "VS"
        ' 
        ' BtnAkaIconSearch
        ' 
        BtnAkaIconSearch.BackColor = Color.WhiteSmoke
        BtnAkaIconSearch.FlatAppearance.BorderColor = Color.LightGray
        BtnAkaIconSearch.FlatStyle = FlatStyle.Flat
        BtnAkaIconSearch.Font = New Font("Segoe UI", 8.0F)
        BtnAkaIconSearch.Location = New Point(569, 6)
        BtnAkaIconSearch.Name = "BtnAkaIconSearch"
        BtnAkaIconSearch.Size = New Size(28, 26)
        BtnAkaIconSearch.TabIndex = 2
        BtnAkaIconSearch.Text = "▼"
        BtnAkaIconSearch.UseVisualStyleBackColor = False
        ' 
        ' TxtAkaSearchDisplay
        ' 
        TxtAkaSearchDisplay.BackColor = Color.White
        TxtAkaSearchDisplay.BorderStyle = BorderStyle.FixedSingle
        TxtAkaSearchDisplay.Font = New Font("Segoe UI", 9.0F)
        TxtAkaSearchDisplay.Location = New Point(376, 6)
        TxtAkaSearchDisplay.Name = "TxtAkaSearchDisplay"
        TxtAkaSearchDisplay.Size = New Size(190, 23)
        TxtAkaSearchDisplay.TabIndex = 1
        ' 
        ' BtnNextMatch
        ' 
        BtnNextMatch.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(0))
        BtnNextMatch.FlatAppearance.BorderSize = 0
        BtnNextMatch.FlatStyle = FlatStyle.Flat
        BtnNextMatch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnNextMatch.Location = New Point(269, 3)
        BtnNextMatch.Name = "BtnNextMatch"
        BtnNextMatch.Size = New Size(100, 30)
        BtnNextMatch.TabIndex = 0
        BtnNextMatch.Text = "Next Match"
        BtnNextMatch.UseVisualStyleBackColor = False
        ' 
        ' PnlFooter
        ' 
        PnlFooter.BackColor = Color.White
        PnlFooter.BorderStyle = BorderStyle.FixedSingle
        PnlFooter.Controls.Add(BtnSaveMatchResult)
        PnlFooter.Controls.Add(BtnResetMatch)
        PnlFooter.Controls.Add(BtnShowScore)
        PnlFooter.Controls.Add(BtnUpdateScore)
        PnlFooter.Controls.Add(BtnAudio)
        PnlFooter.Controls.Add(BtnMonitor)
        PnlFooter.Controls.Add(BtnSettings)
        PnlFooter.Controls.Add(BtnShortcut)
        PnlFooter.Controls.Add(BtnLogActivity)
        PnlFooter.Controls.Add(BtnAssignTask)
        PnlFooter.Controls.Add(LblApiTimerSuffix)
        PnlFooter.Controls.Add(NumApiTimer)
        PnlFooter.Controls.Add(LblApiTimer)
        PnlFooter.Controls.Add(LblApiInfo)
        PnlFooter.Controls.Add(BtnEditServer)
        PnlFooter.Controls.Add(CmbServer)
        PnlFooter.Controls.Add(LblServer)
        PnlFooter.Dock = DockStyle.Bottom
        PnlFooter.Location = New Point(65, 719)
        PnlFooter.Name = "PnlFooter"
        PnlFooter.Size = New Size(1287, 45)
        PnlFooter.TabIndex = 2
        ' 
        ' BtnSaveMatchResult
        ' 
        BtnSaveMatchResult.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        BtnSaveMatchResult.FlatAppearance.BorderSize = 0
        BtnSaveMatchResult.FlatStyle = FlatStyle.Flat
        BtnSaveMatchResult.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnSaveMatchResult.ForeColor = Color.White
        BtnSaveMatchResult.Location = New Point(1168, 7)
        BtnSaveMatchResult.Name = "BtnSaveMatchResult"
        BtnSaveMatchResult.Size = New Size(106, 30)
        BtnSaveMatchResult.TabIndex = 16
        BtnSaveMatchResult.Text = "Save Match Result"
        BtnSaveMatchResult.UseVisualStyleBackColor = False
        ' 
        ' BtnResetMatch
        ' 
        BtnResetMatch.BackColor = Color.WhiteSmoke
        BtnResetMatch.FlatAppearance.BorderColor = Color.LightGray
        BtnResetMatch.FlatStyle = FlatStyle.Flat
        BtnResetMatch.Font = New Font("Segoe UI", 7.5F)
        BtnResetMatch.Location = New Point(1107, 7)
        BtnResetMatch.Name = "BtnResetMatch"
        BtnResetMatch.Size = New Size(58, 30)
        BtnResetMatch.TabIndex = 15
        BtnResetMatch.Text = "Reset" & vbCrLf & "Match"
        BtnResetMatch.UseVisualStyleBackColor = False
        ' 
        ' BtnShowScore
        ' 
        BtnShowScore.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        BtnShowScore.FlatAppearance.BorderSize = 0
        BtnShowScore.FlatStyle = FlatStyle.Flat
        BtnShowScore.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnShowScore.ForeColor = Color.White
        BtnShowScore.Location = New Point(993, 7)
        BtnShowScore.Name = "BtnShowScore"
        BtnShowScore.Size = New Size(110, 30)
        BtnShowScore.TabIndex = 14
        BtnShowScore.Text = "Show Score ▶"
        BtnShowScore.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdateScore
        ' 
        BtnUpdateScore.BackColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        BtnUpdateScore.Enabled = False
        BtnUpdateScore.FlatAppearance.BorderSize = 0
        BtnUpdateScore.FlatStyle = FlatStyle.Flat
        BtnUpdateScore.Font = New Font("Segoe UI", 7.5F)
        BtnUpdateScore.ForeColor = Color.White
        BtnUpdateScore.Location = New Point(932, 7)
        BtnUpdateScore.Name = "BtnUpdateScore"
        BtnUpdateScore.Size = New Size(58, 30)
        BtnUpdateScore.TabIndex = 13
        BtnUpdateScore.Text = "Update" & vbCrLf & "Score"
        BtnUpdateScore.UseVisualStyleBackColor = False
        ' 
        ' BtnAudio
        ' 
        BtnAudio.BackColor = Color.WhiteSmoke
        BtnAudio.FlatAppearance.BorderColor = Color.LightGray
        BtnAudio.FlatStyle = FlatStyle.Flat
        BtnAudio.Font = New Font("Segoe UI", 9.0F)
        BtnAudio.Location = New Point(895, 7)
        BtnAudio.Name = "BtnAudio"
        BtnAudio.Size = New Size(34, 30)
        BtnAudio.TabIndex = 12
        BtnAudio.Text = "🔊"
        BtnAudio.UseVisualStyleBackColor = False
        ' 
        ' BtnMonitor
        ' 
        BtnMonitor.BackColor = Color.WhiteSmoke
        BtnMonitor.FlatAppearance.BorderColor = Color.LightGray
        BtnMonitor.FlatStyle = FlatStyle.Flat
        BtnMonitor.Font = New Font("Segoe UI", 9.0F)
        BtnMonitor.Location = New Point(857, 7)
        BtnMonitor.Name = "BtnMonitor"
        BtnMonitor.Size = New Size(34, 30)
        BtnMonitor.TabIndex = 11
        BtnMonitor.Text = "🖥"
        BtnMonitor.UseVisualStyleBackColor = False
        ' 
        ' BtnSettings
        ' 
        BtnSettings.BackColor = Color.WhiteSmoke
        BtnSettings.FlatAppearance.BorderColor = Color.LightGray
        BtnSettings.FlatStyle = FlatStyle.Flat
        BtnSettings.Font = New Font("Segoe UI", 8.5F)
        BtnSettings.Location = New Point(773, 7)
        BtnSettings.Name = "BtnSettings"
        BtnSettings.Size = New Size(80, 30)
        BtnSettings.TabIndex = 10
        BtnSettings.Text = "Settings"
        BtnSettings.UseVisualStyleBackColor = False
        ' 
        ' BtnShortcut
        ' 
        BtnShortcut.BackColor = Color.WhiteSmoke
        BtnShortcut.FlatAppearance.BorderColor = Color.LightGray
        BtnShortcut.FlatStyle = FlatStyle.Flat
        BtnShortcut.Font = New Font("Segoe UI", 8.5F)
        BtnShortcut.Location = New Point(679, 7)
        BtnShortcut.Name = "BtnShortcut"
        BtnShortcut.Size = New Size(90, 30)
        BtnShortcut.TabIndex = 9
        BtnShortcut.Text = "Shortcut"
        BtnShortcut.UseVisualStyleBackColor = False
        ' 
        ' BtnLogActivity
        ' 
        BtnLogActivity.BackColor = Color.WhiteSmoke
        BtnLogActivity.FlatAppearance.BorderColor = Color.LightGray
        BtnLogActivity.FlatStyle = FlatStyle.Flat
        BtnLogActivity.Font = New Font("Segoe UI", 8.5F)
        BtnLogActivity.Location = New Point(585, 7)
        BtnLogActivity.Name = "BtnLogActivity"
        BtnLogActivity.Size = New Size(90, 30)
        BtnLogActivity.TabIndex = 8
        BtnLogActivity.Text = "Log Activity"
        BtnLogActivity.UseVisualStyleBackColor = False
        ' 
        ' BtnAssignTask
        ' 
        BtnAssignTask.BackColor = Color.FromArgb(CByte(0), CByte(188), CByte(212))
        BtnAssignTask.FlatAppearance.BorderSize = 0
        BtnAssignTask.FlatStyle = FlatStyle.Flat
        BtnAssignTask.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnAssignTask.ForeColor = Color.White
        BtnAssignTask.Location = New Point(416, 7)
        BtnAssignTask.Name = "BtnAssignTask"
        BtnAssignTask.Size = New Size(165, 30)
        BtnAssignTask.TabIndex = 7
        BtnAssignTask.Text = "Assign Task to Judges"
        BtnAssignTask.UseVisualStyleBackColor = False
        ' 
        ' LblApiTimerSuffix
        ' 
        LblApiTimerSuffix.AutoSize = True
        LblApiTimerSuffix.Font = New Font("Segoe UI", 9.0F)
        LblApiTimerSuffix.Location = New Point(398, 14)
        LblApiTimerSuffix.Name = "LblApiTimerSuffix"
        LblApiTimerSuffix.Size = New Size(12, 15)
        LblApiTimerSuffix.TabIndex = 6
        LblApiTimerSuffix.Text = "s"
        ' 
        ' NumApiTimer
        ' 
        NumApiTimer.Font = New Font("Segoe UI", 9.0F)
        NumApiTimer.Location = New Point(350, 10)
        NumApiTimer.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        NumApiTimer.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumApiTimer.Name = "NumApiTimer"
        NumApiTimer.Size = New Size(46, 23)
        NumApiTimer.TabIndex = 5
        NumApiTimer.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' LblApiTimer
        ' 
        LblApiTimer.AutoSize = True
        LblApiTimer.BackColor = Color.LightYellow
        LblApiTimer.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        LblApiTimer.Location = New Point(282, 15)
        LblApiTimer.Name = "LblApiTimer"
        LblApiTimer.Size = New Size(51, 12)
        LblApiTimer.TabIndex = 4
        LblApiTimer.Text = "API Timer"
        ' 
        ' LblApiInfo
        ' 
        LblApiInfo.AutoSize = True
        LblApiInfo.Font = New Font("Segoe UI", 7.5F)
        LblApiInfo.ForeColor = Color.Gray
        LblApiInfo.Location = New Point(6, 30)
        LblApiInfo.Name = "LblApiInfo"
        LblApiInfo.Size = New Size(41, 12)
        LblApiInfo.TabIndex = 3
        LblApiInfo.Text = "API Info"
        ' 
        ' BtnEditServer
        ' 
        BtnEditServer.BackColor = Color.WhiteSmoke
        BtnEditServer.FlatAppearance.BorderColor = Color.LightGray
        BtnEditServer.FlatStyle = FlatStyle.Flat
        BtnEditServer.Font = New Font("Segoe UI", 8.0F)
        BtnEditServer.Location = New Point(238, 10)
        BtnEditServer.Name = "BtnEditServer"
        BtnEditServer.Size = New Size(38, 24)
        BtnEditServer.TabIndex = 2
        BtnEditServer.Text = "Edit"
        BtnEditServer.UseVisualStyleBackColor = False
        ' 
        ' CmbServer
        ' 
        CmbServer.Font = New Font("Segoe UI", 8.5F)
        CmbServer.Items.AddRange(New Object() {"https://kata.yabinya.com"})
        CmbServer.Location = New Point(50, 10)
        CmbServer.Name = "CmbServer"
        CmbServer.Size = New Size(185, 21)
        CmbServer.TabIndex = 1
        CmbServer.Text = "https://kata.yabinya.com"
        ' 
        ' LblServer
        ' 
        LblServer.AutoSize = True
        LblServer.Font = New Font("Segoe UI", 8.5F)
        LblServer.Location = New Point(6, 14)
        LblServer.Name = "LblServer"
        LblServer.Size = New Size(39, 15)
        LblServer.TabIndex = 0
        LblServer.Text = "Server"
        ' 
        ' PnlRightBar
        ' 
        PnlRightBar.AutoScroll = True
        PnlRightBar.BackColor = Color.White
        PnlRightBar.BorderStyle = BorderStyle.FixedSingle
        PnlRightBar.Controls.Add(BtnStartTimer)
        PnlRightBar.Controls.Add(BtnGearTimer)
        PnlRightBar.Controls.Add(BtnEyeTimer)
        PnlRightBar.Controls.Add(BtnStartWaitingTimer)
        PnlRightBar.Controls.Add(GrpTimerSetting)
        PnlRightBar.Controls.Add(BtnStartScoreboard)
        PnlRightBar.Controls.Add(BtnScoreboardIcon)
        PnlRightBar.Controls.Add(GrpScoreboardSelect)
        PnlRightBar.Controls.Add(LblTimerDisplayMain)
        PnlRightBar.Controls.Add(NumTatamiId)
        PnlRightBar.Controls.Add(LblTatami)
        PnlRightBar.Controls.Add(BtnDetailScorePlus)
        PnlRightBar.Controls.Add(ChkDetailScore)
        PnlRightBar.Controls.Add(CmbTextAlign)
        PnlRightBar.Controls.Add(LblTextAlign)
        PnlRightBar.Controls.Add(BtnMatchDetailPlus)
        PnlRightBar.Controls.Add(BtnMatchDetailMinus)
        PnlRightBar.Controls.Add(BtnMatchDetailR)
        PnlRightBar.Controls.Add(TabMatchDetail)
        PnlRightBar.Controls.Add(Rb3Judge)
        PnlRightBar.Controls.Add(Rb7Judge)
        PnlRightBar.Controls.Add(Rb5Judge)
        PnlRightBar.Controls.Add(LblJudge)
        PnlRightBar.Controls.Add(PicFlagBlue)
        PnlRightBar.Controls.Add(PicFlagRed)
        PnlRightBar.Controls.Add(RbFlagSystem)
        PnlRightBar.Controls.Add(BtnManualOnline)
        PnlRightBar.Controls.Add(CmbMode)
        PnlRightBar.Controls.Add(LblMode)
        PnlRightBar.Controls.Add(CmbRules)
        PnlRightBar.Controls.Add(LblRules)
        PnlRightBar.Controls.Add(RbScoreType)
        PnlRightBar.Controls.Add(LblScoringType)
        PnlRightBar.Dock = DockStyle.Right
        PnlRightBar.Location = New Point(1142, 40)
        PnlRightBar.Name = "PnlRightBar"
        PnlRightBar.Size = New Size(210, 679)
        PnlRightBar.TabIndex = 3
        ' 
        ' BtnStartTimer
        ' 
        BtnStartTimer.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        BtnStartTimer.FlatAppearance.BorderSize = 0
        BtnStartTimer.FlatStyle = FlatStyle.Flat
        BtnStartTimer.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnStartTimer.ForeColor = Color.White
        BtnStartTimer.Location = New Point(71, 644)
        BtnStartTimer.Name = "BtnStartTimer"
        BtnStartTimer.Size = New Size(132, 28)
        BtnStartTimer.TabIndex = 32
        BtnStartTimer.Text = "Start Timer  ▶"
        BtnStartTimer.UseVisualStyleBackColor = False
        ' 
        ' BtnGearTimer
        ' 
        BtnGearTimer.BackColor = Color.WhiteSmoke
        BtnGearTimer.FlatAppearance.BorderColor = Color.LightGray
        BtnGearTimer.FlatStyle = FlatStyle.Flat
        BtnGearTimer.Font = New Font("Segoe UI", 9.0F)
        BtnGearTimer.Location = New Point(39, 644)
        BtnGearTimer.Name = "BtnGearTimer"
        BtnGearTimer.Size = New Size(28, 28)
        BtnGearTimer.TabIndex = 31
        BtnGearTimer.Text = "⚙"
        BtnGearTimer.UseVisualStyleBackColor = False
        ' 
        ' BtnEyeTimer
        ' 
        BtnEyeTimer.BackColor = Color.WhiteSmoke
        BtnEyeTimer.FlatAppearance.BorderColor = Color.LightGray
        BtnEyeTimer.FlatStyle = FlatStyle.Flat
        BtnEyeTimer.Font = New Font("Segoe UI", 9.0F)
        BtnEyeTimer.Location = New Point(7, 644)
        BtnEyeTimer.Name = "BtnEyeTimer"
        BtnEyeTimer.Size = New Size(28, 28)
        BtnEyeTimer.TabIndex = 30
        BtnEyeTimer.Text = "👁"
        BtnEyeTimer.UseVisualStyleBackColor = False
        ' 
        ' BtnStartWaitingTimer
        ' 
        BtnStartWaitingTimer.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(128))
        BtnStartWaitingTimer.FlatAppearance.BorderSize = 0
        BtnStartWaitingTimer.FlatStyle = FlatStyle.Flat
        BtnStartWaitingTimer.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnStartWaitingTimer.Location = New Point(7, 612)
        BtnStartWaitingTimer.Name = "BtnStartWaitingTimer"
        BtnStartWaitingTimer.Size = New Size(196, 28)
        BtnStartWaitingTimer.TabIndex = 29
        BtnStartWaitingTimer.Text = "Start Waiting Timer"
        BtnStartWaitingTimer.UseVisualStyleBackColor = False
        ' 
        ' GrpTimerSetting
        ' 
        GrpTimerSetting.Controls.Add(NumPerfSec)
        GrpTimerSetting.Controls.Add(LblPerfColon)
        GrpTimerSetting.Controls.Add(NumPerfMin)
        GrpTimerSetting.Controls.Add(LblPerformance)
        GrpTimerSetting.Controls.Add(NumWaitSec)
        GrpTimerSetting.Controls.Add(LblWaitColon)
        GrpTimerSetting.Controls.Add(NumWaitMin)
        GrpTimerSetting.Controls.Add(LblWaiting)
        GrpTimerSetting.Font = New Font("Segoe UI", 7.5F)
        GrpTimerSetting.Location = New Point(6, 532)
        GrpTimerSetting.Name = "GrpTimerSetting"
        GrpTimerSetting.Size = New Size(196, 74)
        GrpTimerSetting.TabIndex = 28
        GrpTimerSetting.TabStop = False
        GrpTimerSetting.Text = "Timer Setting (minute:second)"
        ' 
        ' NumPerfSec
        ' 
        NumPerfSec.Font = New Font("Segoe UI", 8.5F)
        NumPerfSec.Location = New Point(133, 42)
        NumPerfSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumPerfSec.Name = "NumPerfSec"
        NumPerfSec.Size = New Size(42, 23)
        NumPerfSec.TabIndex = 7
        ' 
        ' LblPerfColon
        ' 
        LblPerfColon.AutoSize = True
        LblPerfColon.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblPerfColon.Location = New Point(124, 45)
        LblPerfColon.Name = "LblPerfColon"
        LblPerfColon.Size = New Size(10, 15)
        LblPerfColon.TabIndex = 6
        LblPerfColon.Text = ":"
        ' 
        ' NumPerfMin
        ' 
        NumPerfMin.Font = New Font("Segoe UI", 8.5F)
        NumPerfMin.Location = New Point(80, 42)
        NumPerfMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumPerfMin.Name = "NumPerfMin"
        NumPerfMin.Size = New Size(42, 23)
        NumPerfMin.TabIndex = 5
        NumPerfMin.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' LblPerformance
        ' 
        LblPerformance.AutoSize = True
        LblPerformance.Font = New Font("Segoe UI", 8.0F)
        LblPerformance.Location = New Point(6, 46)
        LblPerformance.Name = "LblPerformance"
        LblPerformance.Size = New Size(71, 13)
        LblPerformance.TabIndex = 4
        LblPerformance.Text = "Performance"
        ' 
        ' NumWaitSec
        ' 
        NumWaitSec.Font = New Font("Segoe UI", 8.5F)
        NumWaitSec.Location = New Point(118, 16)
        NumWaitSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumWaitSec.Name = "NumWaitSec"
        NumWaitSec.Size = New Size(42, 23)
        NumWaitSec.TabIndex = 3
        NumWaitSec.Value = New Decimal(New Integer() {35, 0, 0, 0})
        ' 
        ' LblWaitColon
        ' 
        LblWaitColon.AutoSize = True
        LblWaitColon.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblWaitColon.Location = New Point(109, 19)
        LblWaitColon.Name = "LblWaitColon"
        LblWaitColon.Size = New Size(10, 15)
        LblWaitColon.TabIndex = 2
        LblWaitColon.Text = ":"
        ' 
        ' NumWaitMin
        ' 
        NumWaitMin.Font = New Font("Segoe UI", 8.5F)
        NumWaitMin.Location = New Point(65, 16)
        NumWaitMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumWaitMin.Name = "NumWaitMin"
        NumWaitMin.Size = New Size(42, 23)
        NumWaitMin.TabIndex = 1
        ' 
        ' LblWaiting
        ' 
        LblWaiting.AutoSize = True
        LblWaiting.Font = New Font("Segoe UI", 8.0F)
        LblWaiting.Location = New Point(6, 20)
        LblWaiting.Name = "LblWaiting"
        LblWaiting.Size = New Size(48, 13)
        LblWaiting.TabIndex = 0
        LblWaiting.Text = "Waiting"
        ' 
        ' BtnStartScoreboard
        ' 
        BtnStartScoreboard.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        BtnStartScoreboard.FlatAppearance.BorderSize = 0
        BtnStartScoreboard.FlatStyle = FlatStyle.Flat
        BtnStartScoreboard.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnStartScoreboard.ForeColor = Color.White
        BtnStartScoreboard.Location = New Point(40, 496)
        BtnStartScoreboard.Name = "BtnStartScoreboard"
        BtnStartScoreboard.Size = New Size(162, 30)
        BtnStartScoreboard.TabIndex = 27
        BtnStartScoreboard.Text = "Start Scoreboard"
        BtnStartScoreboard.UseVisualStyleBackColor = False
        ' 
        ' BtnScoreboardIcon
        ' 
        BtnScoreboardIcon.BackColor = Color.WhiteSmoke
        BtnScoreboardIcon.FlatAppearance.BorderColor = Color.LightGray
        BtnScoreboardIcon.FlatStyle = FlatStyle.Flat
        BtnScoreboardIcon.Font = New Font("Segoe UI", 9.0F)
        BtnScoreboardIcon.Location = New Point(6, 496)
        BtnScoreboardIcon.Name = "BtnScoreboardIcon"
        BtnScoreboardIcon.Size = New Size(30, 30)
        BtnScoreboardIcon.TabIndex = 26
        BtnScoreboardIcon.Text = "⛶"
        BtnScoreboardIcon.UseVisualStyleBackColor = False
        ' 
        ' GrpScoreboardSelect
        ' 
        GrpScoreboardSelect.BackColor = Color.FromArgb(CByte(220), CByte(245), CByte(220))
        GrpScoreboardSelect.Controls.Add(BtnSelectPlayer)
        GrpScoreboardSelect.Controls.Add(LblShortcutHint)
        GrpScoreboardSelect.Controls.Add(RbComp2)
        GrpScoreboardSelect.Controls.Add(RbAllComp)
        GrpScoreboardSelect.Controls.Add(RbComp1)
        GrpScoreboardSelect.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        GrpScoreboardSelect.Location = New Point(6, 392)
        GrpScoreboardSelect.Name = "GrpScoreboardSelect"
        GrpScoreboardSelect.Size = New Size(196, 98)
        GrpScoreboardSelect.TabIndex = 25
        GrpScoreboardSelect.TabStop = False
        ' 
        ' BtnSelectPlayer
        ' 
        BtnSelectPlayer.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        BtnSelectPlayer.FlatAppearance.BorderSize = 0
        BtnSelectPlayer.FlatStyle = FlatStyle.Flat
        BtnSelectPlayer.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnSelectPlayer.ForeColor = Color.White
        BtnSelectPlayer.Location = New Point(2, 9)
        BtnSelectPlayer.Name = "BtnSelectPlayer"
        BtnSelectPlayer.Size = New Size(189, 30)
        BtnSelectPlayer.TabIndex = 28
        BtnSelectPlayer.Text = "Select Player On Scoreboard"
        BtnSelectPlayer.UseVisualStyleBackColor = False
        ' 
        ' LblShortcutHint
        ' 
        LblShortcutHint.Font = New Font("Segoe UI", 7.0F)
        LblShortcutHint.ForeColor = Color.Gray
        LblShortcutHint.Location = New Point(100, 64)
        LblShortcutHint.Name = "LblShortcutHint"
        LblShortcutHint.Size = New Size(88, 26)
        LblShortcutHint.TabIndex = 3
        LblShortcutHint.Text = "Shortcut:" & vbCrLf & "Ctrl + 1/2/3"
        ' 
        ' RbComp2
        ' 
        RbComp2.AutoSize = True
        RbComp2.Font = New Font("Segoe UI", 8.0F)
        RbComp2.Location = New Point(6, 66)
        RbComp2.Name = "RbComp2"
        RbComp2.Size = New Size(92, 17)
        RbComp2.TabIndex = 2
        RbComp2.Text = "Competitor 2"
        ' 
        ' RbAllComp
        ' 
        RbAllComp.AutoSize = True
        RbAllComp.Font = New Font("Segoe UI", 8.0F)
        RbAllComp.Location = New Point(100, 46)
        RbAllComp.Name = "RbAllComp"
        RbAllComp.Size = New Size(99, 17)
        RbAllComp.TabIndex = 1
        RbAllComp.Text = "All Competitor"
        ' 
        ' RbComp1
        ' 
        RbComp1.AutoSize = True
        RbComp1.Checked = True
        RbComp1.Font = New Font("Segoe UI", 8.0F)
        RbComp1.ForeColor = Color.FromArgb(CByte(0), CByte(100), CByte(200))
        RbComp1.Location = New Point(6, 46)
        RbComp1.Name = "RbComp1"
        RbComp1.Size = New Size(92, 17)
        RbComp1.TabIndex = 0
        RbComp1.TabStop = True
        RbComp1.Text = "Competitor 1"
        ' 
        ' LblTimerDisplayMain
        ' 
        LblTimerDisplayMain.BackColor = Color.White
        LblTimerDisplayMain.BorderStyle = BorderStyle.FixedSingle
        LblTimerDisplayMain.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblTimerDisplayMain.Location = New Point(108, 356)
        LblTimerDisplayMain.Name = "LblTimerDisplayMain"
        LblTimerDisplayMain.Size = New Size(78, 30)
        LblTimerDisplayMain.TabIndex = 24
        LblTimerDisplayMain.Text = "05:00"
        LblTimerDisplayMain.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumTatamiId
        ' 
        NumTatamiId.Font = New Font("Segoe UI", 9.0F)
        NumTatamiId.Location = New Point(58, 360)
        NumTatamiId.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        NumTatamiId.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumTatamiId.Name = "NumTatamiId"
        NumTatamiId.Size = New Size(46, 23)
        NumTatamiId.TabIndex = 23
        NumTatamiId.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' LblTatami
        ' 
        LblTatami.AutoSize = True
        LblTatami.Font = New Font("Segoe UI", 8.0F)
        LblTatami.Location = New Point(8, 364)
        LblTatami.Name = "LblTatami"
        LblTatami.Size = New Size(39, 13)
        LblTatami.TabIndex = 22
        LblTatami.Text = "Tatami"
        ' 
        ' BtnDetailScorePlus
        ' 
        BtnDetailScorePlus.BackColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        BtnDetailScorePlus.FlatAppearance.BorderColor = Color.LightGray
        BtnDetailScorePlus.FlatStyle = FlatStyle.Flat
        BtnDetailScorePlus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnDetailScorePlus.ForeColor = Color.White
        BtnDetailScorePlus.Location = New Point(180, 334)
        BtnDetailScorePlus.Name = "BtnDetailScorePlus"
        BtnDetailScorePlus.Size = New Size(22, 22)
        BtnDetailScorePlus.TabIndex = 21
        BtnDetailScorePlus.Text = "+"
        BtnDetailScorePlus.UseVisualStyleBackColor = False
        ' 
        ' ChkDetailScore
        ' 
        ChkDetailScore.AutoSize = True
        ChkDetailScore.Checked = True
        ChkDetailScore.CheckState = CheckState.Checked
        ChkDetailScore.Font = New Font("Segoe UI", 7.5F)
        ChkDetailScore.Location = New Point(6, 338)
        ChkDetailScore.Name = "ChkDetailScore"
        ChkDetailScore.Size = New Size(143, 16)
        ChkDetailScore.TabIndex = 20
        ChkDetailScore.Text = "Detail Score on Scoreboard"
        ' 
        ' CmbTextAlign
        ' 
        CmbTextAlign.DropDownStyle = ComboBoxStyle.DropDownList
        CmbTextAlign.Font = New Font("Segoe UI", 8.0F)
        CmbTextAlign.Items.AddRange(New Object() {"Center", "Left", "Right"})
        CmbTextAlign.Location = New Point(75, 310)
        CmbTextAlign.Name = "CmbTextAlign"
        CmbTextAlign.Size = New Size(90, 21)
        CmbTextAlign.TabIndex = 19
        ' 
        ' LblTextAlign
        ' 
        LblTextAlign.AutoSize = True
        LblTextAlign.Font = New Font("Segoe UI", 8.0F)
        LblTextAlign.Location = New Point(8, 314)
        LblTextAlign.Name = "LblTextAlign"
        LblTextAlign.Size = New Size(56, 13)
        LblTextAlign.TabIndex = 18
        LblTextAlign.Text = "Text Align"
        ' 
        ' BtnMatchDetailPlus
        ' 
        BtnMatchDetailPlus.BackColor = Color.WhiteSmoke
        BtnMatchDetailPlus.FlatAppearance.BorderColor = Color.LightGray
        BtnMatchDetailPlus.FlatStyle = FlatStyle.Flat
        BtnMatchDetailPlus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnMatchDetailPlus.Location = New Point(186, 236)
        BtnMatchDetailPlus.Name = "BtnMatchDetailPlus"
        BtnMatchDetailPlus.Size = New Size(18, 18)
        BtnMatchDetailPlus.TabIndex = 17
        BtnMatchDetailPlus.Text = "+"
        BtnMatchDetailPlus.UseVisualStyleBackColor = False
        ' 
        ' BtnMatchDetailMinus
        ' 
        BtnMatchDetailMinus.BackColor = Color.WhiteSmoke
        BtnMatchDetailMinus.FlatAppearance.BorderColor = Color.LightGray
        BtnMatchDetailMinus.FlatStyle = FlatStyle.Flat
        BtnMatchDetailMinus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnMatchDetailMinus.Location = New Point(186, 216)
        BtnMatchDetailMinus.Name = "BtnMatchDetailMinus"
        BtnMatchDetailMinus.Size = New Size(18, 18)
        BtnMatchDetailMinus.TabIndex = 16
        BtnMatchDetailMinus.Text = "-"
        BtnMatchDetailMinus.UseVisualStyleBackColor = False
        ' 
        ' BtnMatchDetailR
        ' 
        BtnMatchDetailR.BackColor = Color.WhiteSmoke
        BtnMatchDetailR.FlatAppearance.BorderColor = Color.LightGray
        BtnMatchDetailR.FlatStyle = FlatStyle.Flat
        BtnMatchDetailR.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        BtnMatchDetailR.Location = New Point(186, 196)
        BtnMatchDetailR.Name = "BtnMatchDetailR"
        BtnMatchDetailR.Size = New Size(18, 18)
        BtnMatchDetailR.TabIndex = 15
        BtnMatchDetailR.Text = "R"
        BtnMatchDetailR.UseVisualStyleBackColor = False
        ' 
        ' TabMatchDetail
        ' 
        TabMatchDetail.Controls.Add(TabPageDetail)
        TabMatchDetail.Controls.Add(TabPageLogo)
        TabMatchDetail.Font = New Font("Segoe UI", 8.0F)
        TabMatchDetail.Location = New Point(6, 196)
        TabMatchDetail.Name = "TabMatchDetail"
        TabMatchDetail.SelectedIndex = 0
        TabMatchDetail.Size = New Size(180, 110)
        TabMatchDetail.TabIndex = 14
        ' 
        ' TabPageDetail
        ' 
        TabPageDetail.Controls.Add(TxtMatchDetail)
        TabPageDetail.Location = New Point(4, 22)
        TabPageDetail.Name = "TabPageDetail"
        TabPageDetail.Padding = New Padding(2)
        TabPageDetail.Size = New Size(172, 84)
        TabPageDetail.TabIndex = 0
        TabPageDetail.Text = "Match Detail"
        ' 
        ' TxtMatchDetail
        ' 
        TxtMatchDetail.Dock = DockStyle.Fill
        TxtMatchDetail.Font = New Font("Segoe UI", 8.0F)
        TxtMatchDetail.Location = New Point(2, 2)
        TxtMatchDetail.Multiline = True
        TxtMatchDetail.Name = "TxtMatchDetail"
        TxtMatchDetail.ScrollBars = ScrollBars.Vertical
        TxtMatchDetail.Size = New Size(168, 80)
        TxtMatchDetail.TabIndex = 0
        TxtMatchDetail.Text = "KATA Category Detail"
        ' 
        ' TabPageLogo
        ' 
        TabPageLogo.Location = New Point(4, 22)
        TabPageLogo.Name = "TabPageLogo"
        TabPageLogo.Size = New Size(172, 84)
        TabPageLogo.TabIndex = 1
        TabPageLogo.Text = "Match Logo"
        ' 
        ' Rb3Judge
        ' 
        Rb3Judge.AutoSize = True
        Rb3Judge.Font = New Font("Segoe UI", 8.0F)
        Rb3Judge.Location = New Point(132, 174)
        Rb3Judge.Name = "Rb3Judge"
        Rb3Judge.Size = New Size(65, 17)
        Rb3Judge.TabIndex = 13
        Rb3Judge.Text = "3 Judge"
        ' 
        ' Rb7Judge
        ' 
        Rb7Judge.AutoSize = True
        Rb7Judge.Font = New Font("Segoe UI", 8.0F)
        Rb7Judge.Location = New Point(70, 174)
        Rb7Judge.Name = "Rb7Judge"
        Rb7Judge.Size = New Size(65, 17)
        Rb7Judge.TabIndex = 12
        Rb7Judge.Text = "7 Judge"
        ' 
        ' Rb5Judge
        ' 
        Rb5Judge.AutoSize = True
        Rb5Judge.Checked = True
        Rb5Judge.Font = New Font("Segoe UI", 8.0F)
        Rb5Judge.Location = New Point(8, 174)
        Rb5Judge.Name = "Rb5Judge"
        Rb5Judge.Size = New Size(65, 17)
        Rb5Judge.TabIndex = 11
        Rb5Judge.TabStop = True
        Rb5Judge.Text = "5 Judge"
        ' 
        ' LblJudge
        ' 
        LblJudge.AutoSize = True
        LblJudge.Font = New Font("Segoe UI", 8.0F)
        LblJudge.Location = New Point(8, 158)
        LblJudge.Name = "LblJudge"
        LblJudge.Size = New Size(38, 13)
        LblJudge.TabIndex = 10
        LblJudge.Text = "Judge"
        ' 
        ' PicFlagBlue
        ' 
        PicFlagBlue.BackColor = Color.FromArgb(CByte(30), CByte(80), CByte(200))
        PicFlagBlue.BorderStyle = BorderStyle.FixedSingle
        PicFlagBlue.Location = New Point(128, 135)
        PicFlagBlue.Name = "PicFlagBlue"
        PicFlagBlue.Size = New Size(22, 16)
        PicFlagBlue.TabIndex = 9
        PicFlagBlue.TabStop = False
        ' 
        ' PicFlagRed
        ' 
        PicFlagRed.BackColor = Color.Red
        PicFlagRed.BorderStyle = BorderStyle.FixedSingle
        PicFlagRed.Location = New Point(102, 135)
        PicFlagRed.Name = "PicFlagRed"
        PicFlagRed.Size = New Size(22, 16)
        PicFlagRed.TabIndex = 8
        PicFlagRed.TabStop = False
        ' 
        ' RbFlagSystem
        ' 
        RbFlagSystem.AutoSize = True
        RbFlagSystem.Font = New Font("Segoe UI", 8.5F)
        RbFlagSystem.Location = New Point(8, 134)
        RbFlagSystem.Name = "RbFlagSystem"
        RbFlagSystem.Size = New Size(88, 19)
        RbFlagSystem.TabIndex = 7
        RbFlagSystem.Text = "Flag System"
        ' 
        ' BtnManualOnline
        ' 
        BtnManualOnline.BackColor = Color.WhiteSmoke
        BtnManualOnline.FlatAppearance.BorderColor = Color.LightGray
        BtnManualOnline.FlatStyle = FlatStyle.Flat
        BtnManualOnline.Font = New Font("Segoe UI", 7.0F)
        BtnManualOnline.Location = New Point(122, 106)
        BtnManualOnline.Name = "BtnManualOnline"
        BtnManualOnline.Size = New Size(80, 22)
        BtnManualOnline.TabIndex = 6
        BtnManualOnline.Text = "Manual | Online"
        BtnManualOnline.UseVisualStyleBackColor = False
        ' 
        ' CmbMode
        ' 
        CmbMode.DropDownStyle = ComboBoxStyle.DropDownList
        CmbMode.Font = New Font("Segoe UI", 8.0F)
        CmbMode.Items.AddRange(New Object() {"Online"})
        CmbMode.Location = New Point(8, 106)
        CmbMode.Name = "CmbMode"
        CmbMode.Size = New Size(110, 21)
        CmbMode.TabIndex = 5
        ' 
        ' LblMode
        ' 
        LblMode.AutoSize = True
        LblMode.Font = New Font("Segoe UI", 8.0F)
        LblMode.Location = New Point(8, 90)
        LblMode.Name = "LblMode"
        LblMode.Size = New Size(37, 13)
        LblMode.TabIndex = 4
        LblMode.Text = "Mode"
        ' 
        ' CmbRules
        ' 
        CmbRules.DropDownStyle = ComboBoxStyle.DropDownList
        CmbRules.Font = New Font("Segoe UI", 8.0F)
        CmbRules.Items.AddRange(New Object() {"Score → Voting (2026)"})
        CmbRules.Location = New Point(8, 62)
        CmbRules.Name = "CmbRules"
        CmbRules.Size = New Size(194, 21)
        CmbRules.TabIndex = 3
        ' 
        ' LblRules
        ' 
        LblRules.AutoSize = True
        LblRules.Font = New Font("Segoe UI", 8.0F)
        LblRules.Location = New Point(8, 46)
        LblRules.Name = "LblRules"
        LblRules.Size = New Size(35, 13)
        LblRules.TabIndex = 2
        LblRules.Text = "Rules"
        ' 
        ' RbScoreType
        ' 
        RbScoreType.AutoSize = True
        RbScoreType.Checked = True
        RbScoreType.Font = New Font("Segoe UI", 8.5F)
        RbScoreType.Location = New Point(8, 22)
        RbScoreType.Name = "RbScoreType"
        RbScoreType.Size = New Size(54, 19)
        RbScoreType.TabIndex = 1
        RbScoreType.TabStop = True
        RbScoreType.Text = "Score"
        ' 
        ' LblScoringType
        ' 
        LblScoringType.AutoSize = True
        LblScoringType.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblScoringType.Location = New Point(6, 6)
        LblScoringType.Name = "LblScoringType"
        LblScoringType.Size = New Size(78, 15)
        LblScoringType.TabIndex = 0
        LblScoringType.Text = "Scoring Type"
        ' 
        ' PnlMainWorkspace
        ' 
        PnlMainWorkspace.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        PnlMainWorkspace.Controls.Add(PnlCenterScore)
        PnlMainWorkspace.Controls.Add(PnlAo)
        PnlMainWorkspace.Controls.Add(PnlAka)
        PnlMainWorkspace.Dock = DockStyle.Fill
        PnlMainWorkspace.Location = New Point(65, 40)
        PnlMainWorkspace.Name = "PnlMainWorkspace"
        PnlMainWorkspace.Size = New Size(1077, 679)
        PnlMainWorkspace.TabIndex = 4
        ' 
        ' PnlCenterScore
        ' 
        PnlCenterScore.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        PnlCenterScore.Controls.Add(TotalScoreAO)
        PnlCenterScore.Controls.Add(TotalScoreAKA)
        PnlCenterScore.Controls.Add(BtnResetScoreAka)
        PnlCenterScore.Controls.Add(BtnResetScoreAo)
        PnlCenterScore.Controls.Add(PnlPointInputsAo)
        PnlCenterScore.Controls.Add(PnlPointInputsAka)
        PnlCenterScore.Controls.Add(LblTotalScoreAkaTitle)
        PnlCenterScore.Controls.Add(LblTotalScoreAoTitle)
        PnlCenterScore.Controls.Add(LblJudgeScoreTitle)
        PnlCenterScore.Dock = DockStyle.Fill
        PnlCenterScore.Location = New Point(235, 0)
        PnlCenterScore.Name = "PnlCenterScore"
        PnlCenterScore.Padding = New Padding(6)
        PnlCenterScore.Size = New Size(607, 679)
        PnlCenterScore.TabIndex = 2
        ' 
        ' TotalScoreAO
        ' 
        TotalScoreAO.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TotalScoreAO.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        TotalScoreAO.Location = New Point(341, 446)
        TotalScoreAO.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        TotalScoreAO.Name = "TotalScoreAO"
        TotalScoreAO.RightToLeft = RightToLeft.No
        TotalScoreAO.Size = New Size(178, 71)
        TotalScoreAO.TabIndex = 11
        TotalScoreAO.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalScoreAKA
        ' 
        TotalScoreAKA.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TotalScoreAKA.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        TotalScoreAKA.Location = New Point(84, 447)
        TotalScoreAKA.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        TotalScoreAKA.Name = "TotalScoreAKA"
        TotalScoreAKA.RightToLeft = RightToLeft.No
        TotalScoreAKA.Size = New Size(178, 71)
        TotalScoreAKA.TabIndex = 10
        TotalScoreAKA.TextAlign = HorizontalAlignment.Center
        TotalScoreAKA.UpDownAlign = LeftRightAlignment.Left
        ' 
        ' BtnResetScoreAka
        ' 
        BtnResetScoreAka.BackColor = Color.WhiteSmoke
        BtnResetScoreAka.FlatAppearance.BorderColor = Color.LightGray
        BtnResetScoreAka.FlatStyle = FlatStyle.Popup
        BtnResetScoreAka.Font = New Font("Segoe UI", 12.0F)
        BtnResetScoreAka.Location = New Point(84, 524)
        BtnResetScoreAka.Name = "BtnResetScoreAka"
        BtnResetScoreAka.Size = New Size(178, 31)
        BtnResetScoreAka.TabIndex = 4
        BtnResetScoreAka.Text = "Reset Score"
        BtnResetScoreAka.UseVisualStyleBackColor = False
        ' 
        ' BtnResetScoreAo
        ' 
        BtnResetScoreAo.BackColor = Color.WhiteSmoke
        BtnResetScoreAo.FlatAppearance.BorderColor = Color.LightGray
        BtnResetScoreAo.FlatStyle = FlatStyle.Popup
        BtnResetScoreAo.Font = New Font("Segoe UI", 12.0F)
        BtnResetScoreAo.Location = New Point(341, 523)
        BtnResetScoreAo.Name = "BtnResetScoreAo"
        BtnResetScoreAo.Size = New Size(178, 32)
        BtnResetScoreAo.TabIndex = 4
        BtnResetScoreAo.Text = "Reset Score"
        BtnResetScoreAo.UseVisualStyleBackColor = False
        ' 
        ' PnlPointInputsAo
        ' 
        PnlPointInputsAo.BackColor = Color.White
        PnlPointInputsAo.BorderStyle = BorderStyle.FixedSingle
        PnlPointInputsAo.Controls.Add(NumAoJ5)
        PnlPointInputsAo.Controls.Add(LblAoJ5)
        PnlPointInputsAo.Controls.Add(NumAoJ4)
        PnlPointInputsAo.Controls.Add(LblAoJ4)
        PnlPointInputsAo.Controls.Add(NumAoJ3)
        PnlPointInputsAo.Controls.Add(LblAoJ3)
        PnlPointInputsAo.Controls.Add(NumAoJ2)
        PnlPointInputsAo.Controls.Add(LblAoJ2)
        PnlPointInputsAo.Controls.Add(NumAoJ1)
        PnlPointInputsAo.Controls.Add(LblAoJ1)
        PnlPointInputsAo.Location = New Point(341, 59)
        PnlPointInputsAo.Name = "PnlPointInputsAo"
        PnlPointInputsAo.Size = New Size(178, 340)
        PnlPointInputsAo.TabIndex = 2
        ' 
        ' NumAoJ5
        ' 
        NumAoJ5.DecimalPlaces = 1
        NumAoJ5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ5.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ5.Location = New Point(13, 183)
        NumAoJ5.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ5.Name = "NumAoJ5"
        NumAoJ5.Size = New Size(94, 35)
        NumAoJ5.TabIndex = 8
        NumAoJ5.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ5
        ' 
        LblAoJ5.BorderStyle = BorderStyle.FixedSingle
        LblAoJ5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ5.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ5.Location = New Point(113, 183)
        LblAoJ5.Name = "LblAoJ5"
        LblAoJ5.Size = New Size(50, 35)
        LblAoJ5.TabIndex = 9
        LblAoJ5.Text = "J5"
        LblAoJ5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ4
        ' 
        NumAoJ4.DecimalPlaces = 1
        NumAoJ4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ4.Location = New Point(13, 138)
        NumAoJ4.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ4.Name = "NumAoJ4"
        NumAoJ4.Size = New Size(94, 35)
        NumAoJ4.TabIndex = 6
        NumAoJ4.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ4
        ' 
        LblAoJ4.BorderStyle = BorderStyle.FixedSingle
        LblAoJ4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ4.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ4.Location = New Point(113, 141)
        LblAoJ4.Name = "LblAoJ4"
        LblAoJ4.Size = New Size(50, 35)
        LblAoJ4.TabIndex = 7
        LblAoJ4.Text = "J4"
        LblAoJ4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ3
        ' 
        NumAoJ3.DecimalPlaces = 1
        NumAoJ3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ3.Location = New Point(13, 97)
        NumAoJ3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ3.Name = "NumAoJ3"
        NumAoJ3.Size = New Size(94, 35)
        NumAoJ3.TabIndex = 4
        NumAoJ3.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ3
        ' 
        LblAoJ3.BorderStyle = BorderStyle.FixedSingle
        LblAoJ3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ3.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ3.Location = New Point(113, 100)
        LblAoJ3.Name = "LblAoJ3"
        LblAoJ3.Size = New Size(50, 35)
        LblAoJ3.TabIndex = 5
        LblAoJ3.Text = "J3"
        LblAoJ3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ2
        ' 
        NumAoJ2.DecimalPlaces = 1
        NumAoJ2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ2.Location = New Point(13, 57)
        NumAoJ2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ2.Name = "NumAoJ2"
        NumAoJ2.Size = New Size(94, 35)
        NumAoJ2.TabIndex = 2
        NumAoJ2.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ2
        ' 
        LblAoJ2.BorderStyle = BorderStyle.FixedSingle
        LblAoJ2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ2.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ2.Location = New Point(113, 58)
        LblAoJ2.Name = "LblAoJ2"
        LblAoJ2.Size = New Size(50, 35)
        LblAoJ2.TabIndex = 3
        LblAoJ2.Text = "J2"
        LblAoJ2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ1
        ' 
        NumAoJ1.DecimalPlaces = 1
        NumAoJ1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ1.Location = New Point(13, 16)
        NumAoJ1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ1.Name = "NumAoJ1"
        NumAoJ1.Size = New Size(94, 35)
        NumAoJ1.TabIndex = 0
        NumAoJ1.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ1
        ' 
        LblAoJ1.BorderStyle = BorderStyle.FixedSingle
        LblAoJ1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ1.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ1.Location = New Point(113, 17)
        LblAoJ1.Name = "LblAoJ1"
        LblAoJ1.Size = New Size(50, 35)
        LblAoJ1.TabIndex = 1
        LblAoJ1.Text = "J1"
        LblAoJ1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlPointInputsAka
        ' 
        PnlPointInputsAka.Anchor = AnchorStyles.None
        PnlPointInputsAka.BackColor = Color.White
        PnlPointInputsAka.BorderStyle = BorderStyle.FixedSingle
        PnlPointInputsAka.Controls.Add(NumAkaJ5)
        PnlPointInputsAka.Controls.Add(LblAkaJ5)
        PnlPointInputsAka.Controls.Add(NumAkaJ4)
        PnlPointInputsAka.Controls.Add(LblAkaJ4)
        PnlPointInputsAka.Controls.Add(NumAkaJ3)
        PnlPointInputsAka.Controls.Add(LblAkaJ3)
        PnlPointInputsAka.Controls.Add(NumAkaJ2)
        PnlPointInputsAka.Controls.Add(LblAkaJ2)
        PnlPointInputsAka.Controls.Add(NumAkaJ1)
        PnlPointInputsAka.Controls.Add(LblAkaJ1)
        PnlPointInputsAka.Location = New Point(84, 59)
        PnlPointInputsAka.Name = "PnlPointInputsAka"
        PnlPointInputsAka.RightToLeft = RightToLeft.No
        PnlPointInputsAka.Size = New Size(178, 340)
        PnlPointInputsAka.TabIndex = 2
        ' 
        ' NumAkaJ5
        ' 
        NumAkaJ5.DecimalPlaces = 1
        NumAkaJ5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NumAkaJ5.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ5.Location = New Point(67, 183)
        NumAkaJ5.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ5.Name = "NumAkaJ5"
        NumAkaJ5.RightToLeft = RightToLeft.No
        NumAkaJ5.Size = New Size(94, 35)
        NumAkaJ5.TabIndex = 9
        NumAkaJ5.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ5
        ' 
        LblAkaJ5.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ5.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ5.Location = New Point(11, 183)
        LblAkaJ5.Name = "LblAkaJ5"
        LblAkaJ5.Size = New Size(50, 35)
        LblAkaJ5.TabIndex = 8
        LblAkaJ5.Text = "J5"
        LblAkaJ5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ4
        ' 
        NumAkaJ4.DecimalPlaces = 1
        NumAkaJ4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ4.Location = New Point(67, 141)
        NumAkaJ4.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ4.Name = "NumAkaJ4"
        NumAkaJ4.Size = New Size(94, 35)
        NumAkaJ4.TabIndex = 7
        NumAkaJ4.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ4
        ' 
        LblAkaJ4.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ4.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ4.Location = New Point(11, 141)
        LblAkaJ4.Name = "LblAkaJ4"
        LblAkaJ4.Size = New Size(50, 35)
        LblAkaJ4.TabIndex = 6
        LblAkaJ4.Text = "J4"
        LblAkaJ4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ3
        ' 
        NumAkaJ3.DecimalPlaces = 1
        NumAkaJ3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ3.Location = New Point(67, 100)
        NumAkaJ3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ3.Name = "NumAkaJ3"
        NumAkaJ3.Size = New Size(94, 35)
        NumAkaJ3.TabIndex = 5
        NumAkaJ3.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ3
        ' 
        LblAkaJ3.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ3.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ3.Location = New Point(11, 100)
        LblAkaJ3.Name = "LblAkaJ3"
        LblAkaJ3.Size = New Size(50, 35)
        LblAkaJ3.TabIndex = 4
        LblAkaJ3.Text = "J3"
        LblAkaJ3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ2
        ' 
        NumAkaJ2.DecimalPlaces = 1
        NumAkaJ2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ2.Location = New Point(67, 57)
        NumAkaJ2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ2.Name = "NumAkaJ2"
        NumAkaJ2.Size = New Size(94, 35)
        NumAkaJ2.TabIndex = 3
        NumAkaJ2.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ2
        ' 
        LblAkaJ2.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ2.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ2.Location = New Point(11, 57)
        LblAkaJ2.Name = "LblAkaJ2"
        LblAkaJ2.Size = New Size(50, 35)
        LblAkaJ2.TabIndex = 2
        LblAkaJ2.Text = "J2"
        LblAkaJ2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ1
        ' 
        NumAkaJ1.DecimalPlaces = 1
        NumAkaJ1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ1.Location = New Point(67, 16)
        NumAkaJ1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ1.Name = "NumAkaJ1"
        NumAkaJ1.Size = New Size(94, 35)
        NumAkaJ1.TabIndex = 1
        NumAkaJ1.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ1
        ' 
        LblAkaJ1.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ1.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ1.Location = New Point(11, 16)
        LblAkaJ1.Name = "LblAkaJ1"
        LblAkaJ1.Size = New Size(50, 35)
        LblAkaJ1.TabIndex = 0
        LblAkaJ1.Text = "J1"
        LblAkaJ1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTotalScoreAkaTitle
        ' 
        LblTotalScoreAkaTitle.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LblTotalScoreAkaTitle.BorderStyle = BorderStyle.Fixed3D
        LblTotalScoreAkaTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblTotalScoreAkaTitle.ForeColor = Color.White
        LblTotalScoreAkaTitle.Location = New Point(84, 402)
        LblTotalScoreAkaTitle.Name = "LblTotalScoreAkaTitle"
        LblTotalScoreAkaTitle.Size = New Size(178, 41)
        LblTotalScoreAkaTitle.TabIndex = 0
        LblTotalScoreAkaTitle.Text = "Total Score"
        LblTotalScoreAkaTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTotalScoreAoTitle
        ' 
        LblTotalScoreAoTitle.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LblTotalScoreAoTitle.BorderStyle = BorderStyle.Fixed3D
        LblTotalScoreAoTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblTotalScoreAoTitle.ForeColor = Color.White
        LblTotalScoreAoTitle.Location = New Point(341, 402)
        LblTotalScoreAoTitle.Name = "LblTotalScoreAoTitle"
        LblTotalScoreAoTitle.Size = New Size(178, 41)
        LblTotalScoreAoTitle.TabIndex = 0
        LblTotalScoreAoTitle.Text = "Total Score"
        LblTotalScoreAoTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblJudgeScoreTitle
        ' 
        LblJudgeScoreTitle.Dock = DockStyle.Top
        LblJudgeScoreTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblJudgeScoreTitle.Location = New Point(6, 6)
        LblJudgeScoreTitle.Name = "LblJudgeScoreTitle"
        LblJudgeScoreTitle.Size = New Size(595, 48)
        LblJudgeScoreTitle.TabIndex = 0
        LblJudgeScoreTitle.Text = "Judge Score"
        LblJudgeScoreTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlAo
        ' 
        PnlAo.BackColor = Color.White
        PnlAo.BorderStyle = BorderStyle.FixedSingle
        PnlAo.Controls.Add(LblAoWinnerStatus)
        PnlAo.Controls.Add(PicAoAvatar)
        PnlAo.Controls.Add(PicAoCircle)
        PnlAo.Controls.Add(BtnKikenAo)
        PnlAo.Controls.Add(LblAoDisqualification)
        PnlAo.Controls.Add(CmbAoKata)
        PnlAo.Controls.Add(LblAoKata)
        PnlAo.Controls.Add(TxtAoTeam2)
        PnlAo.Controls.Add(TxtAoTeam1)
        PnlAo.Controls.Add(BtnAoSearch)
        PnlAo.Controls.Add(BtnAoSwap)
        PnlAo.Controls.Add(LblAoTeam)
        PnlAo.Controls.Add(TxtAoNameMain)
        PnlAo.Controls.Add(BtnAoExtraIcon)
        PnlAo.Controls.Add(BtnAoUpdateInfo)
        PnlAo.Controls.Add(LblAoName)
        PnlAo.Controls.Add(LblAoHeader)
        PnlAo.Dock = DockStyle.Right
        PnlAo.Location = New Point(842, 0)
        PnlAo.Name = "PnlAo"
        PnlAo.Size = New Size(235, 679)
        PnlAo.TabIndex = 1
        ' 
        ' LblAoWinnerStatus
        ' 
        LblAoWinnerStatus.AutoSize = True
        LblAoWinnerStatus.Font = New Font("Segoe UI", 8.0F)
        LblAoWinnerStatus.ForeColor = Color.Gray
        LblAoWinnerStatus.Location = New Point(6, 281)
        LblAoWinnerStatus.Name = "LblAoWinnerStatus"
        LblAoWinnerStatus.Size = New Size(92, 13)
        LblAoWinnerStatus.TabIndex = 16
        LblAoWinnerStatus.Text = "Show Winner  ▶"
        ' 
        ' PicAoAvatar
        ' 
        PicAoAvatar.BackColor = Color.White
        PicAoAvatar.BorderStyle = BorderStyle.FixedSingle
        PicAoAvatar.Location = New Point(62, 218)
        PicAoAvatar.Name = "PicAoAvatar"
        PicAoAvatar.Size = New Size(52, 52)
        PicAoAvatar.SizeMode = PictureBoxSizeMode.Zoom
        PicAoAvatar.TabIndex = 15
        PicAoAvatar.TabStop = False
        ' 
        ' PicAoCircle
        ' 
        PicAoCircle.BackColor = Color.White
        PicAoCircle.BorderStyle = BorderStyle.FixedSingle
        PicAoCircle.Location = New Point(6, 218)
        PicAoCircle.Name = "PicAoCircle"
        PicAoCircle.Size = New Size(52, 52)
        PicAoCircle.SizeMode = PictureBoxSizeMode.Zoom
        PicAoCircle.TabIndex = 14
        PicAoCircle.TabStop = False
        ' 
        ' BtnKikenAo
        ' 
        BtnKikenAo.BackColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        BtnKikenAo.FlatAppearance.BorderSize = 0
        BtnKikenAo.FlatStyle = FlatStyle.Flat
        BtnKikenAo.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnKikenAo.ForeColor = Color.White
        BtnKikenAo.Location = New Point(150, 236)
        BtnKikenAo.Name = "BtnKikenAo"
        BtnKikenAo.Size = New Size(60, 26)
        BtnKikenAo.TabIndex = 13
        BtnKikenAo.Text = "Kiken"
        BtnKikenAo.UseVisualStyleBackColor = False
        ' 
        ' LblAoDisqualification
        ' 
        LblAoDisqualification.AutoSize = True
        LblAoDisqualification.Font = New Font("Segoe UI", 7.5F)
        LblAoDisqualification.Location = New Point(139, 217)
        LblAoDisqualification.Name = "LblAoDisqualification"
        LblAoDisqualification.Size = New Size(71, 12)
        LblAoDisqualification.TabIndex = 12
        LblAoDisqualification.Text = "Disqualification"
        ' 
        ' CmbAoKata
        ' 
        CmbAoKata.DropDownStyle = ComboBoxStyle.DropDownList
        CmbAoKata.Font = New Font("Segoe UI", 9.0F)
        CmbAoKata.Location = New Point(6, 184)
        CmbAoKata.Name = "CmbAoKata"
        CmbAoKata.Size = New Size(218, 23)
        CmbAoKata.TabIndex = 11
        ' 
        ' LblAoKata
        ' 
        LblAoKata.AutoSize = True
        LblAoKata.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblAoKata.Location = New Point(6, 168)
        LblAoKata.Name = "LblAoKata"
        LblAoKata.Size = New Size(36, 15)
        LblAoKata.TabIndex = 10
        LblAoKata.Text = "KATA"
        ' 
        ' TxtAoTeam2
        ' 
        TxtAoTeam2.BorderStyle = BorderStyle.FixedSingle
        TxtAoTeam2.Font = New Font("Segoe UI", 9.0F)
        TxtAoTeam2.Location = New Point(6, 136)
        TxtAoTeam2.Name = "TxtAoTeam2"
        TxtAoTeam2.Size = New Size(218, 23)
        TxtAoTeam2.TabIndex = 9
        TxtAoTeam2.Text = "KKI"
        ' 
        ' TxtAoTeam1
        ' 
        TxtAoTeam1.BorderStyle = BorderStyle.FixedSingle
        TxtAoTeam1.Font = New Font("Segoe UI", 9.0F)
        TxtAoTeam1.Location = New Point(6, 110)
        TxtAoTeam1.Name = "TxtAoTeam1"
        TxtAoTeam1.Size = New Size(218, 23)
        TxtAoTeam1.TabIndex = 8
        TxtAoTeam1.Text = "Harimau Putih"
        ' 
        ' BtnAoSearch
        ' 
        BtnAoSearch.BackColor = Color.WhiteSmoke
        BtnAoSearch.FlatAppearance.BorderColor = Color.LightGray
        BtnAoSearch.FlatStyle = FlatStyle.Flat
        BtnAoSearch.Font = New Font("Segoe UI", 8.5F)
        BtnAoSearch.Location = New Point(194, 85)
        BtnAoSearch.Name = "BtnAoSearch"
        BtnAoSearch.Size = New Size(24, 22)
        BtnAoSearch.TabIndex = 7
        BtnAoSearch.Text = "🔍"
        BtnAoSearch.UseVisualStyleBackColor = False
        ' 
        ' BtnAoSwap
        ' 
        BtnAoSwap.BackColor = Color.WhiteSmoke
        BtnAoSwap.FlatAppearance.BorderColor = Color.LightGray
        BtnAoSwap.FlatStyle = FlatStyle.Flat
        BtnAoSwap.Font = New Font("Segoe UI", 9.0F)
        BtnAoSwap.Location = New Point(166, 85)
        BtnAoSwap.Name = "BtnAoSwap"
        BtnAoSwap.Size = New Size(24, 22)
        BtnAoSwap.TabIndex = 6
        BtnAoSwap.Text = "⇅"
        BtnAoSwap.UseVisualStyleBackColor = False
        ' 
        ' LblAoTeam
        ' 
        LblAoTeam.AutoSize = True
        LblAoTeam.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        LblAoTeam.Location = New Point(6, 88)
        LblAoTeam.Name = "LblAoTeam"
        LblAoTeam.Size = New Size(95, 13)
        LblAoTeam.TabIndex = 5
        LblAoTeam.Text = "Team | Team Info"
        ' 
        ' TxtAoNameMain
        ' 
        TxtAoNameMain.BorderStyle = BorderStyle.FixedSingle
        TxtAoNameMain.Font = New Font("Segoe UI", 9.0F)
        TxtAoNameMain.Location = New Point(6, 58)
        TxtAoNameMain.Name = "TxtAoNameMain"
        TxtAoNameMain.Size = New Size(218, 23)
        TxtAoNameMain.TabIndex = 4
        TxtAoNameMain.Text = "Siti Aminah"
        ' 
        ' BtnAoExtraIcon
        ' 
        BtnAoExtraIcon.BackColor = Color.WhiteSmoke
        BtnAoExtraIcon.FlatAppearance.BorderColor = Color.LightGray
        BtnAoExtraIcon.FlatStyle = FlatStyle.Flat
        BtnAoExtraIcon.Font = New Font("Segoe UI", 9.0F)
        BtnAoExtraIcon.Location = New Point(184, 34)
        BtnAoExtraIcon.Name = "BtnAoExtraIcon"
        BtnAoExtraIcon.Size = New Size(22, 22)
        BtnAoExtraIcon.TabIndex = 3
        BtnAoExtraIcon.Text = "↕"
        BtnAoExtraIcon.UseVisualStyleBackColor = False
        ' 
        ' BtnAoUpdateInfo
        ' 
        BtnAoUpdateInfo.BackColor = Color.WhiteSmoke
        BtnAoUpdateInfo.FlatAppearance.BorderColor = Color.LightGray
        BtnAoUpdateInfo.FlatStyle = FlatStyle.Flat
        BtnAoUpdateInfo.Font = New Font("Segoe UI", 7.5F)
        BtnAoUpdateInfo.Location = New Point(80, 34)
        BtnAoUpdateInfo.Name = "BtnAoUpdateInfo"
        BtnAoUpdateInfo.Size = New Size(100, 22)
        BtnAoUpdateInfo.TabIndex = 2
        BtnAoUpdateInfo.Text = "⊕ Update Info"
        BtnAoUpdateInfo.UseVisualStyleBackColor = False
        ' 
        ' LblAoName
        ' 
        LblAoName.AutoSize = True
        LblAoName.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblAoName.Location = New Point(6, 38)
        LblAoName.Name = "LblAoName"
        LblAoName.Size = New Size(40, 15)
        LblAoName.TabIndex = 1
        LblAoName.Text = "Name"
        ' 
        ' LblAoHeader
        ' 
        LblAoHeader.BackColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoHeader.Dock = DockStyle.Top
        LblAoHeader.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAoHeader.ForeColor = Color.White
        LblAoHeader.Location = New Point(0, 0)
        LblAoHeader.Name = "LblAoHeader"
        LblAoHeader.Size = New Size(233, 30)
        LblAoHeader.TabIndex = 0
        LblAoHeader.Text = "AO"
        LblAoHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlAka
        ' 
        PnlAka.BackColor = Color.White
        PnlAka.BorderStyle = BorderStyle.FixedSingle
        PnlAka.Controls.Add(LblAkaWinnerStatus)
        PnlAka.Controls.Add(PicAkaAvatar)
        PnlAka.Controls.Add(PicAkaCircle)
        PnlAka.Controls.Add(BtnKikenAka)
        PnlAka.Controls.Add(LblAkaDisqualification)
        PnlAka.Controls.Add(CmbAkaKata)
        PnlAka.Controls.Add(LblAkaKata)
        PnlAka.Controls.Add(TxtAkaTeam2)
        PnlAka.Controls.Add(TxtAkaTeam1)
        PnlAka.Controls.Add(BtnAkaSearch)
        PnlAka.Controls.Add(BtnAkaSwap)
        PnlAka.Controls.Add(LblAkaTeam)
        PnlAka.Controls.Add(TxtAkaNameMain)
        PnlAka.Controls.Add(BtnAkaExtraIcon)
        PnlAka.Controls.Add(BtnAkaUpdateInfo)
        PnlAka.Controls.Add(LblAkaName)
        PnlAka.Controls.Add(LblAkaHeader)
        PnlAka.Dock = DockStyle.Left
        PnlAka.Location = New Point(0, 0)
        PnlAka.Name = "PnlAka"
        PnlAka.Size = New Size(235, 679)
        PnlAka.TabIndex = 0
        ' 
        ' LblAkaWinnerStatus
        ' 
        LblAkaWinnerStatus.AutoSize = True
        LblAkaWinnerStatus.Font = New Font("Segoe UI", 8.0F)
        LblAkaWinnerStatus.ForeColor = Color.Gray
        LblAkaWinnerStatus.Location = New Point(126, 281)
        LblAkaWinnerStatus.Name = "LblAkaWinnerStatus"
        LblAkaWinnerStatus.Size = New Size(92, 13)
        LblAkaWinnerStatus.TabIndex = 16
        LblAkaWinnerStatus.Text = "Show Winner  ▶"
        ' 
        ' PicAkaAvatar
        ' 
        PicAkaAvatar.BackColor = Color.White
        PicAkaAvatar.BorderStyle = BorderStyle.FixedSingle
        PicAkaAvatar.Location = New Point(166, 218)
        PicAkaAvatar.Name = "PicAkaAvatar"
        PicAkaAvatar.Size = New Size(52, 52)
        PicAkaAvatar.SizeMode = PictureBoxSizeMode.Zoom
        PicAkaAvatar.TabIndex = 15
        PicAkaAvatar.TabStop = False
        ' 
        ' PicAkaCircle
        ' 
        PicAkaCircle.BackColor = Color.White
        PicAkaCircle.BorderStyle = BorderStyle.FixedSingle
        PicAkaCircle.Location = New Point(108, 218)
        PicAkaCircle.Name = "PicAkaCircle"
        PicAkaCircle.Size = New Size(52, 52)
        PicAkaCircle.SizeMode = PictureBoxSizeMode.Zoom
        PicAkaCircle.TabIndex = 14
        PicAkaCircle.TabStop = False
        ' 
        ' BtnKikenAka
        ' 
        BtnKikenAka.BackColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        BtnKikenAka.FlatAppearance.BorderSize = 0
        BtnKikenAka.FlatStyle = FlatStyle.Flat
        BtnKikenAka.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnKikenAka.ForeColor = Color.White
        BtnKikenAka.Location = New Point(6, 236)
        BtnKikenAka.Name = "BtnKikenAka"
        BtnKikenAka.Size = New Size(60, 26)
        BtnKikenAka.TabIndex = 13
        BtnKikenAka.Text = "Kiken"
        BtnKikenAka.UseVisualStyleBackColor = False
        ' 
        ' LblAkaDisqualification
        ' 
        LblAkaDisqualification.AutoSize = True
        LblAkaDisqualification.Font = New Font("Segoe UI", 7.5F)
        LblAkaDisqualification.Location = New Point(6, 218)
        LblAkaDisqualification.Name = "LblAkaDisqualification"
        LblAkaDisqualification.Size = New Size(71, 12)
        LblAkaDisqualification.TabIndex = 12
        LblAkaDisqualification.Text = "Disqualification"
        ' 
        ' CmbAkaKata
        ' 
        CmbAkaKata.DropDownStyle = ComboBoxStyle.DropDownList
        CmbAkaKata.Font = New Font("Segoe UI", 9.0F)
        CmbAkaKata.Location = New Point(6, 184)
        CmbAkaKata.Name = "CmbAkaKata"
        CmbAkaKata.Size = New Size(218, 23)
        CmbAkaKata.TabIndex = 11
        ' 
        ' LblAkaKata
        ' 
        LblAkaKata.AutoSize = True
        LblAkaKata.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblAkaKata.Location = New Point(6, 168)
        LblAkaKata.Name = "LblAkaKata"
        LblAkaKata.Size = New Size(36, 15)
        LblAkaKata.TabIndex = 10
        LblAkaKata.Text = "KATA"
        ' 
        ' TxtAkaTeam2
        ' 
        TxtAkaTeam2.BorderStyle = BorderStyle.FixedSingle
        TxtAkaTeam2.Font = New Font("Segoe UI", 9.0F)
        TxtAkaTeam2.Location = New Point(6, 136)
        TxtAkaTeam2.Name = "TxtAkaTeam2"
        TxtAkaTeam2.Size = New Size(218, 23)
        TxtAkaTeam2.TabIndex = 9
        TxtAkaTeam2.Text = "BKC"
        ' 
        ' TxtAkaTeam1
        ' 
        TxtAkaTeam1.BorderStyle = BorderStyle.FixedSingle
        TxtAkaTeam1.Font = New Font("Segoe UI", 9.0F)
        TxtAkaTeam1.Location = New Point(6, 110)
        TxtAkaTeam1.Name = "TxtAkaTeam1"
        TxtAkaTeam1.Size = New Size(218, 23)
        TxtAkaTeam1.TabIndex = 8
        TxtAkaTeam1.Text = "Garuda Sakti"
        ' 
        ' BtnAkaSearch
        ' 
        BtnAkaSearch.BackColor = Color.WhiteSmoke
        BtnAkaSearch.FlatAppearance.BorderColor = Color.LightGray
        BtnAkaSearch.FlatStyle = FlatStyle.Flat
        BtnAkaSearch.Font = New Font("Segoe UI", 8.5F)
        BtnAkaSearch.Location = New Point(194, 85)
        BtnAkaSearch.Name = "BtnAkaSearch"
        BtnAkaSearch.Size = New Size(24, 22)
        BtnAkaSearch.TabIndex = 7
        BtnAkaSearch.Text = "🔍"
        BtnAkaSearch.UseVisualStyleBackColor = False
        ' 
        ' BtnAkaSwap
        ' 
        BtnAkaSwap.BackColor = Color.WhiteSmoke
        BtnAkaSwap.FlatAppearance.BorderColor = Color.LightGray
        BtnAkaSwap.FlatStyle = FlatStyle.Flat
        BtnAkaSwap.Font = New Font("Segoe UI", 9.0F)
        BtnAkaSwap.Location = New Point(166, 85)
        BtnAkaSwap.Name = "BtnAkaSwap"
        BtnAkaSwap.Size = New Size(24, 22)
        BtnAkaSwap.TabIndex = 6
        BtnAkaSwap.Text = "⇅"
        BtnAkaSwap.UseVisualStyleBackColor = False
        ' 
        ' LblAkaTeam
        ' 
        LblAkaTeam.AutoSize = True
        LblAkaTeam.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        LblAkaTeam.Location = New Point(6, 88)
        LblAkaTeam.Name = "LblAkaTeam"
        LblAkaTeam.Size = New Size(95, 13)
        LblAkaTeam.TabIndex = 5
        LblAkaTeam.Text = "Team | Team Info"
        ' 
        ' TxtAkaNameMain
        ' 
        TxtAkaNameMain.BorderStyle = BorderStyle.FixedSingle
        TxtAkaNameMain.Font = New Font("Segoe UI", 9.0F)
        TxtAkaNameMain.Location = New Point(6, 58)
        TxtAkaNameMain.Name = "TxtAkaNameMain"
        TxtAkaNameMain.Size = New Size(218, 23)
        TxtAkaNameMain.TabIndex = 4
        TxtAkaNameMain.Text = "Rizka Amelia"
        ' 
        ' BtnAkaExtraIcon
        ' 
        BtnAkaExtraIcon.BackColor = Color.WhiteSmoke
        BtnAkaExtraIcon.FlatAppearance.BorderColor = Color.LightGray
        BtnAkaExtraIcon.FlatStyle = FlatStyle.Flat
        BtnAkaExtraIcon.Font = New Font("Segoe UI", 9.0F)
        BtnAkaExtraIcon.Location = New Point(184, 34)
        BtnAkaExtraIcon.Name = "BtnAkaExtraIcon"
        BtnAkaExtraIcon.Size = New Size(22, 22)
        BtnAkaExtraIcon.TabIndex = 3
        BtnAkaExtraIcon.Text = "↕"
        BtnAkaExtraIcon.UseVisualStyleBackColor = False
        ' 
        ' BtnAkaUpdateInfo
        ' 
        BtnAkaUpdateInfo.BackColor = Color.WhiteSmoke
        BtnAkaUpdateInfo.FlatAppearance.BorderColor = Color.LightGray
        BtnAkaUpdateInfo.FlatStyle = FlatStyle.Flat
        BtnAkaUpdateInfo.Font = New Font("Segoe UI", 7.5F)
        BtnAkaUpdateInfo.Location = New Point(80, 34)
        BtnAkaUpdateInfo.Name = "BtnAkaUpdateInfo"
        BtnAkaUpdateInfo.Size = New Size(100, 22)
        BtnAkaUpdateInfo.TabIndex = 2
        BtnAkaUpdateInfo.Text = "⊕ Update Info"
        BtnAkaUpdateInfo.UseVisualStyleBackColor = False
        ' 
        ' LblAkaName
        ' 
        LblAkaName.AutoSize = True
        LblAkaName.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblAkaName.Location = New Point(6, 38)
        LblAkaName.Name = "LblAkaName"
        LblAkaName.Size = New Size(40, 15)
        LblAkaName.TabIndex = 1
        LblAkaName.Text = "Name"
        ' 
        ' LblAkaHeader
        ' 
        LblAkaHeader.BackColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaHeader.Dock = DockStyle.Top
        LblAkaHeader.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAkaHeader.ForeColor = Color.White
        LblAkaHeader.Location = New Point(0, 0)
        LblAkaHeader.Name = "LblAkaHeader"
        LblAkaHeader.Size = New Size(233, 30)
        LblAkaHeader.TabIndex = 0
        LblAkaHeader.Text = "AKA"
        LblAkaHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' KataMainControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1352, 764)
        Controls.Add(PnlMainWorkspace)
        Controls.Add(PnlRightBar)
        Controls.Add(PnlFooter)
        Controls.Add(PnlLeftBar)
        Controls.Add(PnlTopBar)
        Font = New Font("Segoe UI", 9.0F)
        MinimumSize = New Size(1100, 680)
        Name = "KataMainControl"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KATA Main Control"
        PnlLeftBar.ResumeLayout(False)
        PnlJ5.ResumeLayout(False)
        PnlJ4.ResumeLayout(False)
        PnlJ3.ResumeLayout(False)
        PnlJ2.ResumeLayout(False)
        PnlJ1.ResumeLayout(False)
        PnlTopBar.ResumeLayout(False)
        PnlTopBar.PerformLayout()
        PnlFooter.ResumeLayout(False)
        PnlFooter.PerformLayout()
        CType(NumApiTimer, ComponentModel.ISupportInitialize).EndInit()
        PnlRightBar.ResumeLayout(False)
        PnlRightBar.PerformLayout()
        GrpTimerSetting.ResumeLayout(False)
        GrpTimerSetting.PerformLayout()
        CType(NumPerfSec, ComponentModel.ISupportInitialize).EndInit()
        CType(NumPerfMin, ComponentModel.ISupportInitialize).EndInit()
        CType(NumWaitSec, ComponentModel.ISupportInitialize).EndInit()
        CType(NumWaitMin, ComponentModel.ISupportInitialize).EndInit()
        GrpScoreboardSelect.ResumeLayout(False)
        GrpScoreboardSelect.PerformLayout()
        CType(NumTatamiId, ComponentModel.ISupportInitialize).EndInit()
        TabMatchDetail.ResumeLayout(False)
        TabPageDetail.ResumeLayout(False)
        TabPageDetail.PerformLayout()
        CType(PicFlagBlue, ComponentModel.ISupportInitialize).EndInit()
        CType(PicFlagRed, ComponentModel.ISupportInitialize).EndInit()
        PnlMainWorkspace.ResumeLayout(False)
        PnlCenterScore.ResumeLayout(False)
        CType(TotalScoreAO, ComponentModel.ISupportInitialize).EndInit()
        CType(TotalScoreAKA, ComponentModel.ISupportInitialize).EndInit()
        PnlPointInputsAo.ResumeLayout(False)
        CType(NumAoJ5, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ1, ComponentModel.ISupportInitialize).EndInit()
        PnlPointInputsAka.ResumeLayout(False)
        CType(NumAkaJ5, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ1, ComponentModel.ISupportInitialize).EndInit()
        PnlAo.ResumeLayout(False)
        PnlAo.PerformLayout()
        CType(PicAoAvatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PicAoCircle, ComponentModel.ISupportInitialize).EndInit()
        PnlAka.ResumeLayout(False)
        PnlAka.PerformLayout()
        CType(PicAkaAvatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PicAkaCircle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents TotalScoreAKA As NumericUpDown
    Friend WithEvents TotalScoreAO As NumericUpDown
    Friend WithEvents BtnSelectPlayer As Button

End Class