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
    ' DEKLARASI FIELD
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
    Friend WithEvents PnlJ6 As System.Windows.Forms.Panel
    Friend WithEvents LblJ6 As System.Windows.Forms.Label
    Friend WithEvents BtnJ6Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ6Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ7 As System.Windows.Forms.Panel
    Friend WithEvents LblJ7 As System.Windows.Forms.Label
    Friend WithEvents BtnJ7Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ7Scoring As System.Windows.Forms.Button
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
    Friend WithEvents Rb5Judge As System.Windows.Forms.RadioButton
    Friend WithEvents Rb7Judge As System.Windows.Forms.RadioButton
    Friend WithEvents Rb3Judge As System.Windows.Forms.RadioButton
    Friend WithEvents TabMatchDetail As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDetail As System.Windows.Forms.TabPage
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
    Friend WithEvents GrpScoreboardSelect As System.Windows.Forms.Panel
    Friend WithEvents BtnSelectPlayer As System.Windows.Forms.Button
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
    Friend WithEvents BtnDiskualifikasiAka As System.Windows.Forms.Label
    Friend WithEvents BtnKikenAka As System.Windows.Forms.Button
    Friend WithEvents PicAkaCircle As System.Windows.Forms.PictureBox
    Friend WithEvents PicAkaAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents LblAkaWinnerStatus As System.Windows.Forms.Label

    ' ── CENTER SCORE PANEL ───────────────────────────────────
    Friend WithEvents PnlCenterScore As System.Windows.Forms.Panel
    Friend WithEvents LblJudgeScoreTitle As System.Windows.Forms.Label

    ' SCORING MODE (NUMBER)
    Friend WithEvents PnlPointInputsAka As System.Windows.Forms.Panel
    Friend WithEvents NumAkaJ1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ1 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ2 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ3 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ4 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ5 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ6 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ7 As System.Windows.Forms.Label

    Friend WithEvents PnlPointInputsAo As System.Windows.Forms.Panel
    Friend WithEvents NumAoJ1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ1 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ2 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ3 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ4 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ5 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ6 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ7 As System.Windows.Forms.Label

    ' FLAG SYSTEM MODE
    Friend WithEvents PnlFlagInputsAka As System.Windows.Forms.Panel
    Friend WithEvents PnlFlagInputsAo As System.Windows.Forms.Panel

    Friend WithEvents LblTotalScoreAkaTitle As System.Windows.Forms.Label
    Friend WithEvents BtnResetScoreAka As System.Windows.Forms.Button
    Friend WithEvents LblTotalScoreAoTitle As System.Windows.Forms.Label
    Friend WithEvents BtnResetScoreAo As System.Windows.Forms.Button
    Friend WithEvents TotalScoreAKA As System.Windows.Forms.NumericUpDown
    Friend WithEvents TotalScoreAO As System.Windows.Forms.NumericUpDown

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
    Friend WithEvents BtnDiskualifikasiAo As System.Windows.Forms.Label
    Friend WithEvents BtnKikenAo As System.Windows.Forms.Button
    Friend WithEvents PicAoCircle As System.Windows.Forms.PictureBox
    Friend WithEvents PicAoAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents LblAoWinnerStatus As System.Windows.Forms.Label

    ' ============================================================
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TabPageDetail As TabPage
        TxtMatchDetail = New TextBox()
        LblTextAlign = New Label()
        CmbTextAlign = New ComboBox()
        BtnMatchDetailPlus = New Button()
        BtnMatchDetailMinus = New Button()
        BtnMatchDetailR = New Button()
        PnlLeftBar = New Panel()
        BtnQRCode = New Button()
        PnlJ7 = New Panel()
        BtnJ7Scoring = New Button()
        BtnJ7Login = New Button()
        LblJ7 = New Label()
        PnlJ6 = New Panel()
        BtnJ6Scoring = New Button()
        BtnJ6Login = New Button()
        LblJ6 = New Label()
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
        LblApiInfo = New Label()
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
        BtnEditServer = New Button()
        CmbServer = New ComboBox()
        LblServer = New Label()
        PnlRightBar = New Panel()
        PnlJudge = New Panel()
        LblJudge = New Label()
        Rb7Judge = New RadioButton()
        Rb5Judge = New RadioButton()
        Rb3Judge = New RadioButton()
        PicFlagRed = New Label()
        PicFlagBlue = New Label()
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
        GrpScoreboardSelect = New Panel()
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
        TabMatchDetail = New TabControl()
        TabPageLogo = New TabPage()
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
        NumAoJ7 = New NumericUpDown()
        LblAoJ7 = New Label()
        NumAoJ6 = New NumericUpDown()
        LblAoJ6 = New Label()
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
        NumAkaJ7 = New NumericUpDown()
        LblAkaJ7 = New Label()
        NumAkaJ6 = New NumericUpDown()
        LblAkaJ6 = New Label()
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
        PnlFlagInputsAka = New Panel()
        PnlFlagAka7 = New Panel()
        Label25 = New Label()
        Label26 = New Label()
        PnlFlagAka6 = New Panel()
        Label23 = New Label()
        Label24 = New Label()
        PnlFlagAka5 = New Panel()
        Label21 = New Label()
        Label22 = New Label()
        PnlFlagAka4 = New Panel()
        Label19 = New Label()
        Label20 = New Label()
        PnlFlagAka3 = New Panel()
        Label17 = New Label()
        Label18 = New Label()
        PnlFlagAka2 = New Panel()
        Label15 = New Label()
        Label16 = New Label()
        PnlFlagAka1 = New Panel()
        Label13 = New Label()
        Label14 = New Label()
        PnlFlagInputsAo = New Panel()
        PnlFlagAo1 = New Panel()
        Label11 = New Label()
        Label12 = New Label()
        PnlFlagAo2 = New Panel()
        Label9 = New Label()
        Label10 = New Label()
        PnlFlagAo3 = New Panel()
        Label7 = New Label()
        Label8 = New Label()
        PnlFlagAo4 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        PnlFlagAo5 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        PnlFlagAo6 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        PnlFlagAo7 = New Panel()
        PicFlagAo7 = New Label()
        LblFlagAo7 = New Label()
        LblTotalScoreAkaTitle = New Label()
        LblTotalScoreAoTitle = New Label()
        LblJudgeScoreTitle = New Label()
        PnlAo = New Panel()
        LblAoWinner = New Label()
        LblAoWinnerStatus = New Label()
        PicAoAvatar = New PictureBox()
        PicAoCircle = New PictureBox()
        BtnKikenAo = New Button()
        BtnDiskualifikasiAo = New Label()
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
        LblAkaWinner = New Label()
        LblAkaWinnerStatus = New Label()
        PicAkaAvatar = New PictureBox()
        PicAkaCircle = New PictureBox()
        BtnKikenAka = New Button()
        BtnDiskualifikasiAka = New Label()
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
        TabPageDetail = New TabPage()
        TabPageDetail.SuspendLayout()
        PnlLeftBar.SuspendLayout()
        PnlJ7.SuspendLayout()
        PnlJ6.SuspendLayout()
        PnlJ5.SuspendLayout()
        PnlJ4.SuspendLayout()
        PnlJ3.SuspendLayout()
        PnlJ2.SuspendLayout()
        PnlJ1.SuspendLayout()
        PnlTopBar.SuspendLayout()
        PnlFooter.SuspendLayout()
        CType(NumApiTimer, ComponentModel.ISupportInitialize).BeginInit()
        PnlRightBar.SuspendLayout()
        PnlJudge.SuspendLayout()
        GrpTimerSetting.SuspendLayout()
        CType(NumPerfSec, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumPerfMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumWaitSec, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumWaitMin, ComponentModel.ISupportInitialize).BeginInit()
        GrpScoreboardSelect.SuspendLayout()
        CType(NumTatamiId, ComponentModel.ISupportInitialize).BeginInit()
        TabMatchDetail.SuspendLayout()
        PnlMainWorkspace.SuspendLayout()
        PnlCenterScore.SuspendLayout()
        CType(TotalScoreAO, ComponentModel.ISupportInitialize).BeginInit()
        CType(TotalScoreAKA, ComponentModel.ISupportInitialize).BeginInit()
        PnlPointInputsAo.SuspendLayout()
        CType(NumAoJ7, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ6, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ5, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ1, ComponentModel.ISupportInitialize).BeginInit()
        PnlPointInputsAka.SuspendLayout()
        CType(NumAkaJ7, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ6, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ5, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ1, ComponentModel.ISupportInitialize).BeginInit()
        PnlFlagInputsAka.SuspendLayout()
        PnlFlagAka7.SuspendLayout()
        PnlFlagAka6.SuspendLayout()
        PnlFlagAka5.SuspendLayout()
        PnlFlagAka4.SuspendLayout()
        PnlFlagAka3.SuspendLayout()
        PnlFlagAka2.SuspendLayout()
        PnlFlagAka1.SuspendLayout()
        PnlFlagInputsAo.SuspendLayout()
        PnlFlagAo1.SuspendLayout()
        PnlFlagAo2.SuspendLayout()
        PnlFlagAo3.SuspendLayout()
        PnlFlagAo4.SuspendLayout()
        PnlFlagAo5.SuspendLayout()
        PnlFlagAo6.SuspendLayout()
        PnlFlagAo7.SuspendLayout()
        PnlAo.SuspendLayout()
        CType(PicAoAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicAoCircle, ComponentModel.ISupportInitialize).BeginInit()
        PnlAka.SuspendLayout()
        CType(PicAkaAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicAkaCircle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabPageDetail
        ' 
        TabPageDetail.Controls.Add(TxtMatchDetail)
        TabPageDetail.Controls.Add(LblTextAlign)
        TabPageDetail.Controls.Add(CmbTextAlign)
        TabPageDetail.Controls.Add(BtnMatchDetailPlus)
        TabPageDetail.Controls.Add(BtnMatchDetailMinus)
        TabPageDetail.Controls.Add(BtnMatchDetailR)
        TabPageDetail.Location = New Point(4, 22)
        TabPageDetail.Name = "TabPageDetail"
        TabPageDetail.Padding = New Padding(2)
        TabPageDetail.Size = New Size(214, 94)
        TabPageDetail.TabIndex = 0
        TabPageDetail.Text = "Match Detail"
        ' 
        ' TxtMatchDetail
        ' 
        TxtMatchDetail.Font = New Font("Segoe UI", 8F)
        TxtMatchDetail.Location = New Point(2, 2)
        TxtMatchDetail.Multiline = True
        TxtMatchDetail.Name = "TxtMatchDetail"
        TxtMatchDetail.ScrollBars = ScrollBars.Vertical
        TxtMatchDetail.Size = New Size(169, 68)
        TxtMatchDetail.TabIndex = 0
        TxtMatchDetail.Text = "KATA Category Detail"
        ' 
        ' LblTextAlign
        ' 
        LblTextAlign.AutoSize = True
        LblTextAlign.Font = New Font("Segoe UI", 8F)
        LblTextAlign.Location = New Point(14, 73)
        LblTextAlign.Name = "LblTextAlign"
        LblTextAlign.Size = New Size(56, 13)
        LblTextAlign.TabIndex = 18
        LblTextAlign.Text = "Text Align"
        ' 
        ' CmbTextAlign
        ' 
        CmbTextAlign.DropDownStyle = ComboBoxStyle.DropDownList
        CmbTextAlign.Font = New Font("Segoe UI", 8F)
        CmbTextAlign.Items.AddRange(New Object() {"Center", "Left", "Right"})
        CmbTextAlign.Location = New Point(79, 69)
        CmbTextAlign.Name = "CmbTextAlign"
        CmbTextAlign.Size = New Size(90, 21)
        CmbTextAlign.TabIndex = 19
        ' 
        ' BtnMatchDetailPlus
        ' 
        BtnMatchDetailPlus.BackColor = Color.WhiteSmoke
        BtnMatchDetailPlus.FlatAppearance.BorderColor = Color.LightGray
        BtnMatchDetailPlus.FlatStyle = FlatStyle.Flat
        BtnMatchDetailPlus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnMatchDetailPlus.Location = New Point(177, 63)
        BtnMatchDetailPlus.Name = "BtnMatchDetailPlus"
        BtnMatchDetailPlus.Size = New Size(30, 30)
        BtnMatchDetailPlus.TabIndex = 17
        BtnMatchDetailPlus.Text = "+"
        BtnMatchDetailPlus.UseVisualStyleBackColor = False
        ' 
        ' BtnMatchDetailMinus
        ' 
        BtnMatchDetailMinus.BackColor = Color.WhiteSmoke
        BtnMatchDetailMinus.FlatAppearance.BorderColor = Color.LightGray
        BtnMatchDetailMinus.FlatStyle = FlatStyle.Flat
        BtnMatchDetailMinus.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnMatchDetailMinus.Location = New Point(177, 32)
        BtnMatchDetailMinus.Name = "BtnMatchDetailMinus"
        BtnMatchDetailMinus.Size = New Size(30, 30)
        BtnMatchDetailMinus.TabIndex = 16
        BtnMatchDetailMinus.Text = "-"
        BtnMatchDetailMinus.UseVisualStyleBackColor = False
        ' 
        ' BtnMatchDetailR
        ' 
        BtnMatchDetailR.BackColor = Color.WhiteSmoke
        BtnMatchDetailR.FlatAppearance.BorderColor = Color.LightGray
        BtnMatchDetailR.FlatStyle = FlatStyle.Flat
        BtnMatchDetailR.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnMatchDetailR.Location = New Point(177, 2)
        BtnMatchDetailR.Name = "BtnMatchDetailR"
        BtnMatchDetailR.Size = New Size(30, 30)
        BtnMatchDetailR.TabIndex = 15
        BtnMatchDetailR.Text = "R"
        BtnMatchDetailR.UseVisualStyleBackColor = False
        ' 
        ' PnlLeftBar
        ' 
        PnlLeftBar.BackColor = Color.FromArgb(CByte(18), CByte(22), CByte(44))
        PnlLeftBar.Controls.Add(BtnQRCode)
        PnlLeftBar.Controls.Add(PnlJ7)
        PnlLeftBar.Controls.Add(PnlJ6)
        PnlLeftBar.Controls.Add(PnlJ5)
        PnlLeftBar.Controls.Add(PnlJ4)
        PnlLeftBar.Controls.Add(PnlJ3)
        PnlLeftBar.Controls.Add(PnlJ2)
        PnlLeftBar.Controls.Add(PnlJ1)
        PnlLeftBar.Controls.Add(LblJudgeStatusTitle)
        PnlLeftBar.Controls.Add(LblApiInfo)
        PnlLeftBar.Dock = DockStyle.Left
        PnlLeftBar.Location = New Point(0, 40)
        PnlLeftBar.Name = "PnlLeftBar"
        PnlLeftBar.Size = New Size(65, 681)
        PnlLeftBar.TabIndex = 0
        ' 
        ' BtnQRCode
        ' 
        BtnQRCode.BackColor = Color.White
        BtnQRCode.FlatAppearance.BorderColor = Color.LightGray
        BtnQRCode.FlatStyle = FlatStyle.Flat
        BtnQRCode.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        BtnQRCode.ForeColor = Color.Black
        BtnQRCode.Location = New Point(5, 525)
        BtnQRCode.Name = "BtnQRCode"
        BtnQRCode.Size = New Size(55, 40)
        BtnQRCode.TabIndex = 8
        BtnQRCode.Text = "QR" & vbCrLf & "Code"
        BtnQRCode.UseVisualStyleBackColor = False
        ' 
        ' PnlJ7
        ' 
        PnlJ7.BackColor = Color.Transparent
        PnlJ7.Controls.Add(BtnJ7Scoring)
        PnlJ7.Controls.Add(BtnJ7Login)
        PnlJ7.Controls.Add(LblJ7)
        PnlJ7.Location = New Point(5, 455)
        PnlJ7.Name = "PnlJ7"
        PnlJ7.Size = New Size(55, 60)
        PnlJ7.TabIndex = 7
        ' 
        ' BtnJ7Scoring
        ' 
        BtnJ7Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ7Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ7Scoring.FlatStyle = FlatStyle.Flat
        BtnJ7Scoring.Font = New Font("Segoe UI", 7F)
        BtnJ7Scoring.ForeColor = Color.White
        BtnJ7Scoring.Location = New Point(0, 38)
        BtnJ7Scoring.Name = "BtnJ7Scoring"
        BtnJ7Scoring.Size = New Size(55, 20)
        BtnJ7Scoring.TabIndex = 2
        BtnJ7Scoring.Text = "Scoring"
        BtnJ7Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ7Login
        ' 
        BtnJ7Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ7Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ7Login.FlatStyle = FlatStyle.Flat
        BtnJ7Login.Font = New Font("Segoe UI", 7F)
        BtnJ7Login.ForeColor = Color.White
        BtnJ7Login.Location = New Point(0, 16)
        BtnJ7Login.Name = "BtnJ7Login"
        BtnJ7Login.Size = New Size(55, 20)
        BtnJ7Login.TabIndex = 1
        BtnJ7Login.Text = "Login"
        BtnJ7Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ7
        ' 
        LblJ7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblJ7.ForeColor = Color.White
        LblJ7.Location = New Point(0, 0)
        LblJ7.Name = "LblJ7"
        LblJ7.Size = New Size(55, 15)
        LblJ7.TabIndex = 0
        LblJ7.Text = "J7"
        LblJ7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlJ6
        ' 
        PnlJ6.BackColor = Color.Transparent
        PnlJ6.Controls.Add(BtnJ6Scoring)
        PnlJ6.Controls.Add(BtnJ6Login)
        PnlJ6.Controls.Add(LblJ6)
        PnlJ6.Location = New Point(5, 385)
        PnlJ6.Name = "PnlJ6"
        PnlJ6.Size = New Size(55, 60)
        PnlJ6.TabIndex = 6
        ' 
        ' BtnJ6Scoring
        ' 
        BtnJ6Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ6Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ6Scoring.FlatStyle = FlatStyle.Flat
        BtnJ6Scoring.Font = New Font("Segoe UI", 7F)
        BtnJ6Scoring.ForeColor = Color.White
        BtnJ6Scoring.Location = New Point(0, 38)
        BtnJ6Scoring.Name = "BtnJ6Scoring"
        BtnJ6Scoring.Size = New Size(55, 20)
        BtnJ6Scoring.TabIndex = 2
        BtnJ6Scoring.Text = "Scoring"
        BtnJ6Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ6Login
        ' 
        BtnJ6Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ6Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ6Login.FlatStyle = FlatStyle.Flat
        BtnJ6Login.Font = New Font("Segoe UI", 7F)
        BtnJ6Login.ForeColor = Color.White
        BtnJ6Login.Location = New Point(0, 16)
        BtnJ6Login.Name = "BtnJ6Login"
        BtnJ6Login.Size = New Size(55, 20)
        BtnJ6Login.TabIndex = 1
        BtnJ6Login.Text = "Login"
        BtnJ6Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ6
        ' 
        LblJ6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblJ6.ForeColor = Color.White
        LblJ6.Location = New Point(0, 0)
        LblJ6.Name = "LblJ6"
        LblJ6.Size = New Size(55, 15)
        LblJ6.TabIndex = 0
        LblJ6.Text = "J6"
        LblJ6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlJ5
        ' 
        PnlJ5.BackColor = Color.Transparent
        PnlJ5.Controls.Add(BtnJ5Scoring)
        PnlJ5.Controls.Add(BtnJ5Login)
        PnlJ5.Controls.Add(LblJ5)
        PnlJ5.Location = New Point(5, 315)
        PnlJ5.Name = "PnlJ5"
        PnlJ5.Size = New Size(55, 60)
        PnlJ5.TabIndex = 5
        ' 
        ' BtnJ5Scoring
        ' 
        BtnJ5Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ5Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ5Scoring.FlatStyle = FlatStyle.Flat
        BtnJ5Scoring.Font = New Font("Segoe UI", 7F)
        BtnJ5Scoring.ForeColor = Color.White
        BtnJ5Scoring.Location = New Point(0, 38)
        BtnJ5Scoring.Name = "BtnJ5Scoring"
        BtnJ5Scoring.Size = New Size(55, 20)
        BtnJ5Scoring.TabIndex = 2
        BtnJ5Scoring.Text = "Scoring"
        BtnJ5Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ5Login
        ' 
        BtnJ5Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ5Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ5Login.FlatStyle = FlatStyle.Flat
        BtnJ5Login.Font = New Font("Segoe UI", 7F)
        BtnJ5Login.ForeColor = Color.White
        BtnJ5Login.Location = New Point(0, 16)
        BtnJ5Login.Name = "BtnJ5Login"
        BtnJ5Login.Size = New Size(55, 20)
        BtnJ5Login.TabIndex = 1
        BtnJ5Login.Text = "Login"
        BtnJ5Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ5
        ' 
        LblJ5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblJ5.ForeColor = Color.White
        LblJ5.Location = New Point(0, 0)
        LblJ5.Name = "LblJ5"
        LblJ5.Size = New Size(55, 15)
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
        PnlJ4.Location = New Point(5, 245)
        PnlJ4.Name = "PnlJ4"
        PnlJ4.Size = New Size(55, 60)
        PnlJ4.TabIndex = 4
        ' 
        ' BtnJ4Scoring
        ' 
        BtnJ4Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ4Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ4Scoring.FlatStyle = FlatStyle.Flat
        BtnJ4Scoring.Font = New Font("Segoe UI", 7F)
        BtnJ4Scoring.ForeColor = Color.White
        BtnJ4Scoring.Location = New Point(0, 38)
        BtnJ4Scoring.Name = "BtnJ4Scoring"
        BtnJ4Scoring.Size = New Size(55, 20)
        BtnJ4Scoring.TabIndex = 2
        BtnJ4Scoring.Text = "Scoring"
        BtnJ4Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ4Login
        ' 
        BtnJ4Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ4Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ4Login.FlatStyle = FlatStyle.Flat
        BtnJ4Login.Font = New Font("Segoe UI", 7F)
        BtnJ4Login.ForeColor = Color.White
        BtnJ4Login.Location = New Point(0, 16)
        BtnJ4Login.Name = "BtnJ4Login"
        BtnJ4Login.Size = New Size(55, 20)
        BtnJ4Login.TabIndex = 1
        BtnJ4Login.Text = "Login"
        BtnJ4Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ4
        ' 
        LblJ4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblJ4.ForeColor = Color.White
        LblJ4.Location = New Point(0, 0)
        LblJ4.Name = "LblJ4"
        LblJ4.Size = New Size(55, 15)
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
        PnlJ3.Location = New Point(5, 175)
        PnlJ3.Name = "PnlJ3"
        PnlJ3.Size = New Size(55, 60)
        PnlJ3.TabIndex = 3
        ' 
        ' BtnJ3Scoring
        ' 
        BtnJ3Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ3Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ3Scoring.FlatStyle = FlatStyle.Flat
        BtnJ3Scoring.Font = New Font("Segoe UI", 7F)
        BtnJ3Scoring.ForeColor = Color.White
        BtnJ3Scoring.Location = New Point(0, 38)
        BtnJ3Scoring.Name = "BtnJ3Scoring"
        BtnJ3Scoring.Size = New Size(55, 20)
        BtnJ3Scoring.TabIndex = 2
        BtnJ3Scoring.Text = "Scoring"
        BtnJ3Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ3Login
        ' 
        BtnJ3Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ3Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ3Login.FlatStyle = FlatStyle.Flat
        BtnJ3Login.Font = New Font("Segoe UI", 7F)
        BtnJ3Login.ForeColor = Color.White
        BtnJ3Login.Location = New Point(0, 16)
        BtnJ3Login.Name = "BtnJ3Login"
        BtnJ3Login.Size = New Size(55, 20)
        BtnJ3Login.TabIndex = 1
        BtnJ3Login.Text = "Login"
        BtnJ3Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ3
        ' 
        LblJ3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblJ3.ForeColor = Color.White
        LblJ3.Location = New Point(0, 0)
        LblJ3.Name = "LblJ3"
        LblJ3.Size = New Size(55, 15)
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
        PnlJ2.Location = New Point(5, 105)
        PnlJ2.Name = "PnlJ2"
        PnlJ2.Size = New Size(55, 60)
        PnlJ2.TabIndex = 2
        ' 
        ' BtnJ2Scoring
        ' 
        BtnJ2Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ2Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ2Scoring.FlatStyle = FlatStyle.Flat
        BtnJ2Scoring.Font = New Font("Segoe UI", 7F)
        BtnJ2Scoring.ForeColor = Color.White
        BtnJ2Scoring.Location = New Point(0, 38)
        BtnJ2Scoring.Name = "BtnJ2Scoring"
        BtnJ2Scoring.Size = New Size(55, 20)
        BtnJ2Scoring.TabIndex = 2
        BtnJ2Scoring.Text = "Scoring"
        BtnJ2Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ2Login
        ' 
        BtnJ2Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ2Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ2Login.FlatStyle = FlatStyle.Flat
        BtnJ2Login.Font = New Font("Segoe UI", 7F)
        BtnJ2Login.ForeColor = Color.White
        BtnJ2Login.Location = New Point(0, 16)
        BtnJ2Login.Name = "BtnJ2Login"
        BtnJ2Login.Size = New Size(55, 20)
        BtnJ2Login.TabIndex = 1
        BtnJ2Login.Text = "Login"
        BtnJ2Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ2
        ' 
        LblJ2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblJ2.ForeColor = Color.White
        LblJ2.Location = New Point(0, 0)
        LblJ2.Name = "LblJ2"
        LblJ2.Size = New Size(55, 15)
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
        PnlJ1.Location = New Point(5, 35)
        PnlJ1.Name = "PnlJ1"
        PnlJ1.Size = New Size(55, 60)
        PnlJ1.TabIndex = 1
        ' 
        ' BtnJ1Scoring
        ' 
        BtnJ1Scoring.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ1Scoring.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ1Scoring.FlatStyle = FlatStyle.Flat
        BtnJ1Scoring.Font = New Font("Segoe UI", 7F)
        BtnJ1Scoring.ForeColor = Color.White
        BtnJ1Scoring.Location = New Point(0, 38)
        BtnJ1Scoring.Name = "BtnJ1Scoring"
        BtnJ1Scoring.Size = New Size(55, 20)
        BtnJ1Scoring.TabIndex = 2
        BtnJ1Scoring.Text = "Scoring"
        BtnJ1Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnJ1Login
        ' 
        BtnJ1Login.BackColor = Color.FromArgb(CByte(50), CByte(55), CByte(80))
        BtnJ1Login.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(85), CByte(110))
        BtnJ1Login.FlatStyle = FlatStyle.Flat
        BtnJ1Login.Font = New Font("Segoe UI", 7F)
        BtnJ1Login.ForeColor = Color.White
        BtnJ1Login.Location = New Point(0, 16)
        BtnJ1Login.Name = "BtnJ1Login"
        BtnJ1Login.Size = New Size(55, 20)
        BtnJ1Login.TabIndex = 1
        BtnJ1Login.Text = "Login"
        BtnJ1Login.UseVisualStyleBackColor = False
        ' 
        ' LblJ1
        ' 
        LblJ1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblJ1.ForeColor = Color.White
        LblJ1.Location = New Point(0, 0)
        LblJ1.Name = "LblJ1"
        LblJ1.Size = New Size(55, 15)
        LblJ1.TabIndex = 0
        LblJ1.Text = "J1"
        LblJ1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblJudgeStatusTitle
        ' 
        LblJudgeStatusTitle.BackColor = Color.Transparent
        LblJudgeStatusTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LblJudgeStatusTitle.ForeColor = Color.White
        LblJudgeStatusTitle.Location = New Point(0, 3)
        LblJudgeStatusTitle.Name = "LblJudgeStatusTitle"
        LblJudgeStatusTitle.Size = New Size(65, 30)
        LblJudgeStatusTitle.TabIndex = 0
        LblJudgeStatusTitle.Text = "Judge" & vbCrLf & "Status"
        LblJudgeStatusTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblApiInfo
        ' 
        LblApiInfo.AutoSize = True
        LblApiInfo.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        LblApiInfo.ForeColor = Color.Chartreuse
        LblApiInfo.Location = New Point(4, 649)
        LblApiInfo.Name = "LblApiInfo"
        LblApiInfo.Size = New Size(58, 17)
        LblApiInfo.TabIndex = 3
        LblApiInfo.Text = "API Info"
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
        PnlTopBar.Size = New Size(1264, 40)
        PnlTopBar.TabIndex = 1
        ' 
        ' BtnLoadNextMatch
        ' 
        BtnLoadNextMatch.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(0))
        BtnLoadNextMatch.FlatAppearance.BorderSize = 0
        BtnLoadNextMatch.FlatStyle = FlatStyle.Flat
        BtnLoadNextMatch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnLoadNextMatch.Location = New Point(830, 4)
        BtnLoadNextMatch.Name = "BtnLoadNextMatch"
        BtnLoadNextMatch.Size = New Size(125, 30)
        BtnLoadNextMatch.TabIndex = 7
        BtnLoadNextMatch.Text = "Load Next Match"
        BtnLoadNextMatch.UseVisualStyleBackColor = False
        ' 
        ' BtnSwapNextMatch
        ' 
        BtnSwapNextMatch.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(100))
        BtnSwapNextMatch.FlatAppearance.BorderColor = Color.Gray
        BtnSwapNextMatch.FlatStyle = FlatStyle.Flat
        BtnSwapNextMatch.Font = New Font("Segoe UI", 9F)
        BtnSwapNextMatch.ForeColor = Color.White
        BtnSwapNextMatch.Location = New Point(795, 6)
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
        TxtAoSearchDisplay.Font = New Font("Segoe UI", 9F)
        TxtAoSearchDisplay.Location = New Point(610, 8)
        TxtAoSearchDisplay.Name = "TxtAoSearchDisplay"
        TxtAoSearchDisplay.Size = New Size(180, 23)
        TxtAoSearchDisplay.TabIndex = 5
        ' 
        ' BtnAoIconSearch
        ' 
        BtnAoIconSearch.BackColor = Color.WhiteSmoke
        BtnAoIconSearch.FlatAppearance.BorderColor = Color.LightGray
        BtnAoIconSearch.FlatStyle = FlatStyle.Flat
        BtnAoIconSearch.Font = New Font("Segoe UI", 8F)
        BtnAoIconSearch.Location = New Point(580, 6)
        BtnAoIconSearch.Name = "BtnAoIconSearch"
        BtnAoIconSearch.Size = New Size(28, 26)
        BtnAoIconSearch.TabIndex = 4
        BtnAoIconSearch.Text = "👤"
        BtnAoIconSearch.UseVisualStyleBackColor = False
        ' 
        ' LblVS
        ' 
        LblVS.AutoSize = True
        LblVS.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(0))
        LblVS.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        LblVS.Location = New Point(545, 8)
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
        BtnAkaIconSearch.Font = New Font("Segoe UI", 8F)
        BtnAkaIconSearch.Location = New Point(510, 6)
        BtnAkaIconSearch.Name = "BtnAkaIconSearch"
        BtnAkaIconSearch.Size = New Size(28, 26)
        BtnAkaIconSearch.TabIndex = 2
        BtnAkaIconSearch.Text = "👤"
        BtnAkaIconSearch.UseVisualStyleBackColor = False
        ' 
        ' TxtAkaSearchDisplay
        ' 
        TxtAkaSearchDisplay.BackColor = Color.White
        TxtAkaSearchDisplay.BorderStyle = BorderStyle.FixedSingle
        TxtAkaSearchDisplay.Font = New Font("Segoe UI", 9F)
        TxtAkaSearchDisplay.Location = New Point(325, 8)
        TxtAkaSearchDisplay.Name = "TxtAkaSearchDisplay"
        TxtAkaSearchDisplay.Size = New Size(180, 23)
        TxtAkaSearchDisplay.TabIndex = 1
        ' 
        ' BtnNextMatch
        ' 
        BtnNextMatch.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(0))
        BtnNextMatch.FlatAppearance.BorderSize = 0
        BtnNextMatch.FlatStyle = FlatStyle.Flat
        BtnNextMatch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnNextMatch.Location = New Point(220, 4)
        BtnNextMatch.Name = "BtnNextMatch"
        BtnNextMatch.Size = New Size(100, 30)
        BtnNextMatch.TabIndex = 0
        BtnNextMatch.Text = "Next Match"
        BtnNextMatch.UseVisualStyleBackColor = False
        ' 
        ' PnlFooter
        ' 
        PnlFooter.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
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
        PnlFooter.Dock = DockStyle.Bottom
        PnlFooter.Location = New Point(65, 676)
        PnlFooter.Name = "PnlFooter"
        PnlFooter.Size = New Size(1199, 45)
        PnlFooter.TabIndex = 2
        ' 
        ' BtnSaveMatchResult
        ' 
        BtnSaveMatchResult.BackColor = Color.White
        BtnSaveMatchResult.FlatAppearance.BorderSize = 0
        BtnSaveMatchResult.FlatStyle = FlatStyle.Flat
        BtnSaveMatchResult.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnSaveMatchResult.ForeColor = Color.Black
        BtnSaveMatchResult.Location = New Point(1055, 7)
        BtnSaveMatchResult.Name = "BtnSaveMatchResult"
        BtnSaveMatchResult.Size = New Size(135, 30)
        BtnSaveMatchResult.TabIndex = 16
        BtnSaveMatchResult.Text = "Save Match Result 💾"
        BtnSaveMatchResult.UseVisualStyleBackColor = False
        ' 
        ' BtnResetMatch
        ' 
        BtnResetMatch.BackColor = Color.White
        BtnResetMatch.FlatAppearance.BorderColor = Color.LightGray
        BtnResetMatch.FlatStyle = FlatStyle.Flat
        BtnResetMatch.Font = New Font("Segoe UI", 7.5F)
        BtnResetMatch.Location = New Point(979, 3)
        BtnResetMatch.Name = "BtnResetMatch"
        BtnResetMatch.Size = New Size(70, 37)
        BtnResetMatch.TabIndex = 15
        BtnResetMatch.Text = "Reset" & vbCrLf & "Match"
        BtnResetMatch.UseVisualStyleBackColor = False
        ' 
        ' BtnShowScore
        ' 
        BtnShowScore.BackColor = Color.White
        BtnShowScore.FlatAppearance.BorderSize = 0
        BtnShowScore.FlatStyle = FlatStyle.Flat
        BtnShowScore.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnShowScore.ForeColor = Color.Black
        BtnShowScore.Location = New Point(731, 7)
        BtnShowScore.Name = "BtnShowScore"
        BtnShowScore.Size = New Size(110, 30)
        BtnShowScore.TabIndex = 14
        BtnShowScore.Text = "Show Score ⬆"
        BtnShowScore.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdateScore
        ' 
        BtnUpdateScore.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        BtnUpdateScore.Enabled = False
        BtnUpdateScore.FlatAppearance.BorderSize = 0
        BtnUpdateScore.FlatStyle = FlatStyle.Flat
        BtnUpdateScore.Font = New Font("Segoe UI", 7.5F)
        BtnUpdateScore.ForeColor = Color.Gray
        BtnUpdateScore.Location = New Point(616, 5)
        BtnUpdateScore.Name = "BtnUpdateScore"
        BtnUpdateScore.Size = New Size(109, 33)
        BtnUpdateScore.TabIndex = 13
        BtnUpdateScore.Text = "Update" & vbCrLf & "Score"
        BtnUpdateScore.UseVisualStyleBackColor = False
        ' 
        ' BtnAudio
        ' 
        BtnAudio.BackColor = Color.White
        BtnAudio.FlatAppearance.BorderColor = Color.LightGray
        BtnAudio.FlatStyle = FlatStyle.Flat
        BtnAudio.Font = New Font("Segoe UI", 9F)
        BtnAudio.Location = New Point(575, 7)
        BtnAudio.Name = "BtnAudio"
        BtnAudio.Size = New Size(34, 30)
        BtnAudio.TabIndex = 12
        BtnAudio.Text = "🔊"
        BtnAudio.UseVisualStyleBackColor = False
        ' 
        ' BtnMonitor
        ' 
        BtnMonitor.BackColor = Color.White
        BtnMonitor.FlatAppearance.BorderColor = Color.LightGray
        BtnMonitor.FlatStyle = FlatStyle.Flat
        BtnMonitor.Font = New Font("Segoe UI", 9F)
        BtnMonitor.Location = New Point(534, 7)
        BtnMonitor.Name = "BtnMonitor"
        BtnMonitor.Size = New Size(34, 30)
        BtnMonitor.TabIndex = 11
        BtnMonitor.Text = "🖥"
        BtnMonitor.UseVisualStyleBackColor = False
        ' 
        ' BtnSettings
        ' 
        BtnSettings.BackColor = Color.White
        BtnSettings.FlatAppearance.BorderColor = Color.LightGray
        BtnSettings.FlatStyle = FlatStyle.Flat
        BtnSettings.Font = New Font("Segoe UI", 8.5F)
        BtnSettings.Location = New Point(444, 7)
        BtnSettings.Name = "BtnSettings"
        BtnSettings.Size = New Size(84, 30)
        BtnSettings.TabIndex = 10
        BtnSettings.Text = "Settings ⚙"
        BtnSettings.UseVisualStyleBackColor = False
        ' 
        ' BtnShortcut
        ' 
        BtnShortcut.BackColor = Color.White
        BtnShortcut.FlatAppearance.BorderColor = Color.LightGray
        BtnShortcut.FlatStyle = FlatStyle.Flat
        BtnShortcut.Font = New Font("Segoe UI", 8.5F)
        BtnShortcut.Location = New Point(348, 7)
        BtnShortcut.Name = "BtnShortcut"
        BtnShortcut.Size = New Size(89, 30)
        BtnShortcut.TabIndex = 9
        BtnShortcut.Text = "Shortcut ⌨"
        BtnShortcut.UseVisualStyleBackColor = False
        ' 
        ' BtnLogActivity
        ' 
        BtnLogActivity.BackColor = Color.White
        BtnLogActivity.FlatAppearance.BorderColor = Color.LightGray
        BtnLogActivity.FlatStyle = FlatStyle.Flat
        BtnLogActivity.Font = New Font("Segoe UI", 8.5F)
        BtnLogActivity.Location = New Point(253, 7)
        BtnLogActivity.Name = "BtnLogActivity"
        BtnLogActivity.Size = New Size(89, 30)
        BtnLogActivity.TabIndex = 8
        BtnLogActivity.Text = "Log Activity"
        BtnLogActivity.UseVisualStyleBackColor = False
        ' 
        ' BtnAssignTask
        ' 
        BtnAssignTask.BackColor = Color.FromArgb(CByte(135), CByte(206), CByte(250))
        BtnAssignTask.FlatAppearance.BorderSize = 0
        BtnAssignTask.FlatStyle = FlatStyle.Flat
        BtnAssignTask.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnAssignTask.ForeColor = Color.Black
        BtnAssignTask.Location = New Point(78, 7)
        BtnAssignTask.Name = "BtnAssignTask"
        BtnAssignTask.Size = New Size(169, 30)
        BtnAssignTask.TabIndex = 7
        BtnAssignTask.Text = "Assign Task to Judges 👨‍💼"
        BtnAssignTask.UseVisualStyleBackColor = False
        ' 
        ' LblApiTimerSuffix
        ' 
        LblApiTimerSuffix.AutoSize = True
        LblApiTimerSuffix.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblApiTimerSuffix.ForeColor = Color.Yellow
        LblApiTimerSuffix.Location = New Point(60, 21)
        LblApiTimerSuffix.Name = "LblApiTimerSuffix"
        LblApiTimerSuffix.Size = New Size(12, 15)
        LblApiTimerSuffix.TabIndex = 6
        LblApiTimerSuffix.Text = "s"
        ' 
        ' NumApiTimer
        ' 
        NumApiTimer.Font = New Font("Segoe UI", 9F)
        NumApiTimer.Location = New Point(10, 17)
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
        LblApiTimer.BackColor = Color.Transparent
        LblApiTimer.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblApiTimer.ForeColor = Color.Yellow
        LblApiTimer.Location = New Point(6, 0)
        LblApiTimer.Name = "LblApiTimer"
        LblApiTimer.Size = New Size(62, 15)
        LblApiTimer.TabIndex = 4
        LblApiTimer.Text = "API Timer"
        ' 
        ' BtnEditServer
        ' 
        BtnEditServer.BackColor = Color.White
        BtnEditServer.FlatAppearance.BorderColor = Color.LightGray
        BtnEditServer.FlatStyle = FlatStyle.Flat
        BtnEditServer.Font = New Font("Segoe UI", 8F)
        BtnEditServer.Location = New Point(205, 605)
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
        CmbServer.Location = New Point(45, 606)
        CmbServer.Name = "CmbServer"
        CmbServer.Size = New Size(154, 21)
        CmbServer.TabIndex = 1
        ' 
        ' LblServer
        ' 
        LblServer.AutoSize = True
        LblServer.Font = New Font("Segoe UI", 8.5F)
        LblServer.ForeColor = Color.Black
        LblServer.Location = New Point(5, 608)
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
        PnlRightBar.Controls.Add(PnlJudge)
        PnlRightBar.Controls.Add(PicFlagRed)
        PnlRightBar.Controls.Add(PicFlagBlue)
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
        PnlRightBar.Controls.Add(TabMatchDetail)
        PnlRightBar.Controls.Add(RbFlagSystem)
        PnlRightBar.Controls.Add(BtnManualOnline)
        PnlRightBar.Controls.Add(CmbMode)
        PnlRightBar.Controls.Add(LblMode)
        PnlRightBar.Controls.Add(CmbRules)
        PnlRightBar.Controls.Add(LblRules)
        PnlRightBar.Controls.Add(RbScoreType)
        PnlRightBar.Controls.Add(LblScoringType)
        PnlRightBar.Dock = DockStyle.Right
        PnlRightBar.Location = New Point(1034, 40)
        PnlRightBar.Name = "PnlRightBar"
        PnlRightBar.Size = New Size(230, 636)
        PnlRightBar.TabIndex = 3
        ' 
        ' PnlJudge
        ' 
        PnlJudge.BackColor = Color.Transparent
        PnlJudge.Controls.Add(LblJudge)
        PnlJudge.Controls.Add(Rb7Judge)
        PnlJudge.Controls.Add(Rb5Judge)
        PnlJudge.Controls.Add(Rb3Judge)
        PnlJudge.Location = New Point(4, 135)
        PnlJudge.Name = "PnlJudge"
        PnlJudge.Size = New Size(222, 41)
        PnlJudge.TabIndex = 34
        ' 
        ' LblJudge
        ' 
        LblJudge.AutoSize = True
        LblJudge.Font = New Font("Segoe UI", 8.5F)
        LblJudge.Location = New Point(3, 2)
        LblJudge.Name = "LblJudge"
        LblJudge.Size = New Size(38, 15)
        LblJudge.TabIndex = 33
        LblJudge.Text = "Judge"
        ' 
        ' Rb7Judge
        ' 
        Rb7Judge.AutoSize = True
        Rb7Judge.Checked = True
        Rb7Judge.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Rb7Judge.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(180))
        Rb7Judge.Location = New Point(73, 20)
        Rb7Judge.Name = "Rb7Judge"
        Rb7Judge.Size = New Size(66, 17)
        Rb7Judge.TabIndex = 12
        Rb7Judge.TabStop = True
        Rb7Judge.Text = "7 Judge"
        ' 
        ' Rb5Judge
        ' 
        Rb5Judge.AutoSize = True
        Rb5Judge.Font = New Font("Segoe UI", 8F)
        Rb5Judge.Location = New Point(3, 20)
        Rb5Judge.Name = "Rb5Judge"
        Rb5Judge.Size = New Size(65, 17)
        Rb5Judge.TabIndex = 11
        Rb5Judge.Text = "5 Judge"
        ' 
        ' Rb3Judge
        ' 
        Rb3Judge.AutoSize = True
        Rb3Judge.Font = New Font("Segoe UI", 8F)
        Rb3Judge.Location = New Point(143, 20)
        Rb3Judge.Name = "Rb3Judge"
        Rb3Judge.Size = New Size(65, 17)
        Rb3Judge.TabIndex = 13
        Rb3Judge.Text = "3 Judge"
        ' 
        ' PicFlagRed
        ' 
        PicFlagRed.AutoSize = True
        PicFlagRed.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PicFlagRed.ForeColor = Color.Red
        PicFlagRed.Location = New Point(98, 100)
        PicFlagRed.Name = "PicFlagRed"
        PicFlagRed.Size = New Size(38, 40)
        PicFlagRed.TabIndex = 22
        PicFlagRed.Text = "⚑"
        ' 
        ' PicFlagBlue
        ' 
        PicFlagBlue.AutoSize = True
        PicFlagBlue.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PicFlagBlue.ForeColor = Color.Blue
        PicFlagBlue.Location = New Point(129, 100)
        PicFlagBlue.Name = "PicFlagBlue"
        PicFlagBlue.Size = New Size(38, 40)
        PicFlagBlue.TabIndex = 21
        PicFlagBlue.Text = "⚑"
        ' 
        ' BtnStartTimer
        ' 
        BtnStartTimer.BackColor = Color.WhiteSmoke
        BtnStartTimer.FlatAppearance.BorderColor = Color.LightGray
        BtnStartTimer.FlatStyle = FlatStyle.Flat
        BtnStartTimer.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnStartTimer.ForeColor = Color.Black
        BtnStartTimer.Location = New Point(80, 595)
        BtnStartTimer.Name = "BtnStartTimer"
        BtnStartTimer.Size = New Size(140, 28)
        BtnStartTimer.TabIndex = 32
        BtnStartTimer.Text = "Start Timer  ⏱"
        BtnStartTimer.UseVisualStyleBackColor = False
        ' 
        ' BtnGearTimer
        ' 
        BtnGearTimer.BackColor = Color.WhiteSmoke
        BtnGearTimer.FlatAppearance.BorderColor = Color.LightGray
        BtnGearTimer.FlatStyle = FlatStyle.Flat
        BtnGearTimer.Font = New Font("Segoe UI", 9F)
        BtnGearTimer.Location = New Point(45, 595)
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
        BtnEyeTimer.Font = New Font("Segoe UI", 9F)
        BtnEyeTimer.Location = New Point(10, 595)
        BtnEyeTimer.Name = "BtnEyeTimer"
        BtnEyeTimer.Size = New Size(28, 28)
        BtnEyeTimer.TabIndex = 30
        BtnEyeTimer.Text = "👁"
        BtnEyeTimer.UseVisualStyleBackColor = False
        ' 
        ' BtnStartWaitingTimer
        ' 
        BtnStartWaitingTimer.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(196))
        BtnStartWaitingTimer.FlatAppearance.BorderColor = Color.BurlyWood
        BtnStartWaitingTimer.FlatStyle = FlatStyle.Flat
        BtnStartWaitingTimer.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnStartWaitingTimer.Location = New Point(10, 560)
        BtnStartWaitingTimer.Name = "BtnStartWaitingTimer"
        BtnStartWaitingTimer.Size = New Size(210, 30)
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
        GrpTimerSetting.Location = New Point(10, 485)
        GrpTimerSetting.Name = "GrpTimerSetting"
        GrpTimerSetting.Size = New Size(210, 70)
        GrpTimerSetting.TabIndex = 28
        GrpTimerSetting.TabStop = False
        GrpTimerSetting.Text = "Timer Setting (minute:second)"
        ' 
        ' NumPerfSec
        ' 
        NumPerfSec.Font = New Font("Segoe UI", 8.5F)
        NumPerfSec.Location = New Point(133, 40)
        NumPerfSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumPerfSec.Name = "NumPerfSec"
        NumPerfSec.Size = New Size(42, 23)
        NumPerfSec.TabIndex = 7
        ' 
        ' LblPerfColon
        ' 
        LblPerfColon.AutoSize = True
        LblPerfColon.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblPerfColon.Location = New Point(124, 43)
        LblPerfColon.Name = "LblPerfColon"
        LblPerfColon.Size = New Size(10, 15)
        LblPerfColon.TabIndex = 6
        LblPerfColon.Text = ":"
        ' 
        ' NumPerfMin
        ' 
        NumPerfMin.Font = New Font("Segoe UI", 8.5F)
        NumPerfMin.Location = New Point(80, 40)
        NumPerfMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumPerfMin.Name = "NumPerfMin"
        NumPerfMin.Size = New Size(42, 23)
        NumPerfMin.TabIndex = 5
        NumPerfMin.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' LblPerformance
        ' 
        LblPerformance.AutoSize = True
        LblPerformance.Font = New Font("Segoe UI", 8F)
        LblPerformance.Location = New Point(6, 44)
        LblPerformance.Name = "LblPerformance"
        LblPerformance.Size = New Size(71, 13)
        LblPerformance.TabIndex = 4
        LblPerformance.Text = "Performance"
        ' 
        ' NumWaitSec
        ' 
        NumWaitSec.Font = New Font("Segoe UI", 8.5F)
        NumWaitSec.Location = New Point(133, 15)
        NumWaitSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumWaitSec.Name = "NumWaitSec"
        NumWaitSec.Size = New Size(42, 23)
        NumWaitSec.TabIndex = 3
        NumWaitSec.Value = New Decimal(New Integer() {35, 0, 0, 0})
        ' 
        ' LblWaitColon
        ' 
        LblWaitColon.AutoSize = True
        LblWaitColon.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblWaitColon.Location = New Point(124, 18)
        LblWaitColon.Name = "LblWaitColon"
        LblWaitColon.Size = New Size(10, 15)
        LblWaitColon.TabIndex = 2
        LblWaitColon.Text = ":"
        ' 
        ' NumWaitMin
        ' 
        NumWaitMin.Font = New Font("Segoe UI", 8.5F)
        NumWaitMin.Location = New Point(80, 15)
        NumWaitMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumWaitMin.Name = "NumWaitMin"
        NumWaitMin.Size = New Size(42, 23)
        NumWaitMin.TabIndex = 1
        ' 
        ' LblWaiting
        ' 
        LblWaiting.AutoSize = True
        LblWaiting.Font = New Font("Segoe UI", 8F)
        LblWaiting.Location = New Point(6, 19)
        LblWaiting.Name = "LblWaiting"
        LblWaiting.Size = New Size(48, 13)
        LblWaiting.TabIndex = 0
        LblWaiting.Text = "Waiting"
        ' 
        ' BtnStartScoreboard
        ' 
        BtnStartScoreboard.BackColor = Color.FromArgb(CByte(120), CByte(250), CByte(180))
        BtnStartScoreboard.FlatAppearance.BorderColor = Color.LightGray
        BtnStartScoreboard.FlatStyle = FlatStyle.Flat
        BtnStartScoreboard.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnStartScoreboard.ForeColor = Color.Black
        BtnStartScoreboard.Location = New Point(45, 445)
        BtnStartScoreboard.Name = "BtnStartScoreboard"
        BtnStartScoreboard.Size = New Size(175, 30)
        BtnStartScoreboard.TabIndex = 27
        BtnStartScoreboard.Text = "Start Scoreboard"
        BtnStartScoreboard.UseVisualStyleBackColor = False
        ' 
        ' BtnScoreboardIcon
        ' 
        BtnScoreboardIcon.BackColor = Color.WhiteSmoke
        BtnScoreboardIcon.FlatAppearance.BorderColor = Color.LightGray
        BtnScoreboardIcon.FlatStyle = FlatStyle.Flat
        BtnScoreboardIcon.Font = New Font("Segoe UI", 9F)
        BtnScoreboardIcon.Location = New Point(10, 445)
        BtnScoreboardIcon.Name = "BtnScoreboardIcon"
        BtnScoreboardIcon.Size = New Size(30, 30)
        BtnScoreboardIcon.TabIndex = 26
        BtnScoreboardIcon.Text = "⛶"
        BtnScoreboardIcon.UseVisualStyleBackColor = False
        ' 
        ' GrpScoreboardSelect
        ' 
        GrpScoreboardSelect.BackColor = Color.FromArgb(CByte(230), CByte(255), CByte(240))
        GrpScoreboardSelect.BorderStyle = BorderStyle.FixedSingle
        GrpScoreboardSelect.Controls.Add(BtnSelectPlayer)
        GrpScoreboardSelect.Controls.Add(LblShortcutHint)
        GrpScoreboardSelect.Controls.Add(RbComp2)
        GrpScoreboardSelect.Controls.Add(RbAllComp)
        GrpScoreboardSelect.Controls.Add(RbComp1)
        GrpScoreboardSelect.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        GrpScoreboardSelect.Location = New Point(10, 352)
        GrpScoreboardSelect.Name = "GrpScoreboardSelect"
        GrpScoreboardSelect.Size = New Size(210, 90)
        GrpScoreboardSelect.TabIndex = 25
        ' 
        ' BtnSelectPlayer
        ' 
        BtnSelectPlayer.BackColor = Color.FromArgb(CByte(100), CByte(250), CByte(180))
        BtnSelectPlayer.FlatAppearance.BorderSize = 0
        BtnSelectPlayer.FlatStyle = FlatStyle.Flat
        BtnSelectPlayer.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        BtnSelectPlayer.ForeColor = Color.Black
        BtnSelectPlayer.Location = New Point(0, 0)
        BtnSelectPlayer.Name = "BtnSelectPlayer"
        BtnSelectPlayer.Size = New Size(210, 25)
        BtnSelectPlayer.TabIndex = 28
        BtnSelectPlayer.Text = "Select Player On Scoreboard"
        BtnSelectPlayer.UseVisualStyleBackColor = False
        ' 
        ' LblShortcutHint
        ' 
        LblShortcutHint.Font = New Font("Segoe UI", 7F)
        LblShortcutHint.ForeColor = Color.Gray
        LblShortcutHint.Location = New Point(100, 60)
        LblShortcutHint.Name = "LblShortcutHint"
        LblShortcutHint.Size = New Size(95, 26)
        LblShortcutHint.TabIndex = 3
        LblShortcutHint.Text = "Shortcut:" & vbCrLf & "Ctrl + 1/2/3"
        LblShortcutHint.TextAlign = ContentAlignment.TopCenter
        ' 
        ' RbComp2
        ' 
        RbComp2.AutoSize = True
        RbComp2.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        RbComp2.ForeColor = Color.Navy
        RbComp2.Location = New Point(5, 60)
        RbComp2.Name = "RbComp2"
        RbComp2.Size = New Size(93, 17)
        RbComp2.TabIndex = 2
        RbComp2.Text = "Competitor 2"
        ' 
        ' RbAllComp
        ' 
        RbAllComp.AutoSize = True
        RbAllComp.Font = New Font("Segoe UI", 8F)
        RbAllComp.Location = New Point(100, 40)
        RbAllComp.Name = "RbAllComp"
        RbAllComp.Size = New Size(99, 17)
        RbAllComp.TabIndex = 1
        RbAllComp.Text = "All Competitor"
        ' 
        ' RbComp1
        ' 
        RbComp1.AutoSize = True
        RbComp1.Checked = True
        RbComp1.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        RbComp1.ForeColor = Color.Red
        RbComp1.Location = New Point(5, 40)
        RbComp1.Name = "RbComp1"
        RbComp1.Size = New Size(93, 17)
        RbComp1.TabIndex = 0
        RbComp1.TabStop = True
        RbComp1.Text = "Competitor 1"
        ' 
        ' LblTimerDisplayMain
        ' 
        LblTimerDisplayMain.BackColor = Color.White
        LblTimerDisplayMain.BorderStyle = BorderStyle.FixedSingle
        LblTimerDisplayMain.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        LblTimerDisplayMain.Location = New Point(118, 317)
        LblTimerDisplayMain.Name = "LblTimerDisplayMain"
        LblTimerDisplayMain.Size = New Size(80, 30)
        LblTimerDisplayMain.TabIndex = 24
        LblTimerDisplayMain.Text = "05:00 00"
        LblTimerDisplayMain.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumTatamiId
        ' 
        NumTatamiId.Font = New Font("Segoe UI", 9F)
        NumTatamiId.Location = New Point(60, 320)
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
        LblTatami.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTatami.Location = New Point(9, 324)
        LblTatami.Name = "LblTatami"
        LblTatami.Size = New Size(44, 15)
        LblTatami.TabIndex = 22
        LblTatami.Text = "Tatami"
        ' 
        ' BtnDetailScorePlus
        ' 
        BtnDetailScorePlus.BackColor = Color.LightGray
        BtnDetailScorePlus.FlatAppearance.BorderColor = Color.DarkGray
        BtnDetailScorePlus.FlatStyle = FlatStyle.Flat
        BtnDetailScorePlus.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        BtnDetailScorePlus.ForeColor = Color.White
        BtnDetailScorePlus.Location = New Point(198, 304)
        BtnDetailScorePlus.Name = "BtnDetailScorePlus"
        BtnDetailScorePlus.Size = New Size(24, 22)
        BtnDetailScorePlus.TabIndex = 21
        BtnDetailScorePlus.Text = "⬆"
        BtnDetailScorePlus.UseVisualStyleBackColor = False
        ' 
        ' ChkDetailScore
        ' 
        ChkDetailScore.AutoSize = True
        ChkDetailScore.Checked = True
        ChkDetailScore.CheckState = CheckState.Checked
        ChkDetailScore.Font = New Font("Segoe UI", 7.5F)
        ChkDetailScore.ForeColor = Color.Gray
        ChkDetailScore.Location = New Point(10, 300)
        ChkDetailScore.Name = "ChkDetailScore"
        ChkDetailScore.Size = New Size(143, 16)
        ChkDetailScore.TabIndex = 20
        ChkDetailScore.Text = "Detail Score on Scoreboard"
        ' 
        ' TabMatchDetail
        ' 
        TabMatchDetail.Controls.Add(TabPageDetail)
        TabMatchDetail.Controls.Add(TabPageLogo)
        TabMatchDetail.Font = New Font("Segoe UI", 8F)
        TabMatchDetail.Location = New Point(4, 180)
        TabMatchDetail.Name = "TabMatchDetail"
        TabMatchDetail.SelectedIndex = 0
        TabMatchDetail.Size = New Size(222, 120)
        TabMatchDetail.TabIndex = 14
        ' 
        ' TabPageLogo
        ' 
        TabPageLogo.Location = New Point(4, 22)
        TabPageLogo.Name = "TabPageLogo"
        TabPageLogo.Size = New Size(214, 94)
        TabPageLogo.TabIndex = 1
        TabPageLogo.Text = "Match Logo"
        ' 
        ' RbFlagSystem
        ' 
        RbFlagSystem.AutoSize = True
        RbFlagSystem.Font = New Font("Segoe UI", 8.5F)
        RbFlagSystem.Location = New Point(10, 110)
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
        BtnManualOnline.Font = New Font("Segoe UI", 7F)
        BtnManualOnline.ForeColor = Color.FromArgb(CByte(0), CByte(120), CByte(120))
        BtnManualOnline.Location = New Point(135, 77)
        BtnManualOnline.Name = "BtnManualOnline"
        BtnManualOnline.Size = New Size(90, 22)
        BtnManualOnline.TabIndex = 6
        BtnManualOnline.Text = "Manual | Online"
        BtnManualOnline.UseVisualStyleBackColor = False
        ' 
        ' CmbMode
        ' 
        CmbMode.DropDownStyle = ComboBoxStyle.DropDownList
        CmbMode.Font = New Font("Segoe UI", 8F)
        CmbMode.Items.AddRange(New Object() {"Online"})
        CmbMode.Location = New Point(50, 78)
        CmbMode.Name = "CmbMode"
        CmbMode.Size = New Size(80, 21)
        CmbMode.TabIndex = 5
        ' 
        ' LblMode
        ' 
        LblMode.AutoSize = True
        LblMode.Font = New Font("Segoe UI", 8F)
        LblMode.Location = New Point(10, 80)
        LblMode.Name = "LblMode"
        LblMode.Size = New Size(37, 13)
        LblMode.TabIndex = 4
        LblMode.Text = "Mode"
        ' 
        ' CmbRules
        ' 
        CmbRules.DropDownStyle = ComboBoxStyle.DropDownList
        CmbRules.Font = New Font("Segoe UI", 8F)
        CmbRules.Items.AddRange(New Object() {"Score → Voting (2026)"})
        CmbRules.Location = New Point(50, 52)
        CmbRules.Name = "CmbRules"
        CmbRules.Size = New Size(175, 21)
        CmbRules.TabIndex = 3
        ' 
        ' LblRules
        ' 
        LblRules.AutoSize = True
        LblRules.Font = New Font("Segoe UI", 8F)
        LblRules.Location = New Point(10, 55)
        LblRules.Name = "LblRules"
        LblRules.Size = New Size(35, 13)
        LblRules.TabIndex = 2
        LblRules.Text = "Rules"
        ' 
        ' RbScoreType
        ' 
        RbScoreType.AutoSize = True
        RbScoreType.Checked = True
        RbScoreType.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        RbScoreType.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(180))
        RbScoreType.Location = New Point(10, 30)
        RbScoreType.Name = "RbScoreType"
        RbScoreType.Size = New Size(57, 19)
        RbScoreType.TabIndex = 1
        RbScoreType.TabStop = True
        RbScoreType.Text = "Score"
        ' 
        ' LblScoringType
        ' 
        LblScoringType.AutoSize = True
        LblScoringType.Font = New Font("Segoe UI", 8.5F)
        LblScoringType.Location = New Point(5, 7)
        LblScoringType.Name = "LblScoringType"
        LblScoringType.Size = New Size(75, 15)
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
        PnlMainWorkspace.Size = New Size(969, 636)
        PnlMainWorkspace.TabIndex = 4
        ' 
        ' PnlCenterScore
        ' 
        PnlCenterScore.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        PnlCenterScore.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        PnlCenterScore.Controls.Add(TotalScoreAO)
        PnlCenterScore.Controls.Add(TotalScoreAKA)
        PnlCenterScore.Controls.Add(BtnResetScoreAka)
        PnlCenterScore.Controls.Add(BtnResetScoreAo)
        PnlCenterScore.Controls.Add(PnlPointInputsAo)
        PnlCenterScore.Controls.Add(PnlPointInputsAka)
        PnlCenterScore.Controls.Add(PnlFlagInputsAka)
        PnlCenterScore.Controls.Add(PnlFlagInputsAo)
        PnlCenterScore.Controls.Add(LblTotalScoreAkaTitle)
        PnlCenterScore.Controls.Add(LblTotalScoreAoTitle)
        PnlCenterScore.Controls.Add(LblJudgeScoreTitle)
        PnlCenterScore.Location = New Point(334, 0)
        PnlCenterScore.Name = "PnlCenterScore"
        PnlCenterScore.Size = New Size(299, 636)
        PnlCenterScore.TabIndex = 2
        ' 
        ' TotalScoreAO
        ' 
        TotalScoreAO.DecimalPlaces = 1
        TotalScoreAO.Font = New Font("Segoe UI", 36F, FontStyle.Bold)
        TotalScoreAO.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        TotalScoreAO.Location = New Point(153, 519)
        TotalScoreAO.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        TotalScoreAO.Name = "TotalScoreAO"
        TotalScoreAO.RightToLeft = RightToLeft.No
        TotalScoreAO.Size = New Size(140, 71)
        TotalScoreAO.TabIndex = 11
        TotalScoreAO.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalScoreAKA
        ' 
        TotalScoreAKA.DecimalPlaces = 1
        TotalScoreAKA.Font = New Font("Segoe UI", 36F, FontStyle.Bold)
        TotalScoreAKA.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        TotalScoreAKA.Location = New Point(4, 519)
        TotalScoreAKA.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        TotalScoreAKA.Name = "TotalScoreAKA"
        TotalScoreAKA.RightToLeft = RightToLeft.No
        TotalScoreAKA.Size = New Size(140, 71)
        TotalScoreAKA.TabIndex = 10
        TotalScoreAKA.TextAlign = HorizontalAlignment.Center
        TotalScoreAKA.UpDownAlign = LeftRightAlignment.Left
        ' 
        ' BtnResetScoreAka
        ' 
        BtnResetScoreAka.BackColor = Color.WhiteSmoke
        BtnResetScoreAka.FlatAppearance.BorderColor = Color.LightGray
        BtnResetScoreAka.FlatStyle = FlatStyle.Popup
        BtnResetScoreAka.Font = New Font("Segoe UI", 10F)
        BtnResetScoreAka.Location = New Point(4, 596)
        BtnResetScoreAka.Name = "BtnResetScoreAka"
        BtnResetScoreAka.Size = New Size(140, 30)
        BtnResetScoreAka.TabIndex = 4
        BtnResetScoreAka.Text = "Reset Score"
        BtnResetScoreAka.UseVisualStyleBackColor = False
        ' 
        ' BtnResetScoreAo
        ' 
        BtnResetScoreAo.BackColor = Color.WhiteSmoke
        BtnResetScoreAo.FlatAppearance.BorderColor = Color.LightGray
        BtnResetScoreAo.FlatStyle = FlatStyle.Popup
        BtnResetScoreAo.Font = New Font("Segoe UI", 10F)
        BtnResetScoreAo.Location = New Point(153, 596)
        BtnResetScoreAo.Name = "BtnResetScoreAo"
        BtnResetScoreAo.Size = New Size(140, 30)
        BtnResetScoreAo.TabIndex = 4
        BtnResetScoreAo.Text = "Reset Score"
        BtnResetScoreAo.UseVisualStyleBackColor = False
        ' 
        ' PnlPointInputsAo
        ' 
        PnlPointInputsAo.BackColor = Color.White
        PnlPointInputsAo.BorderStyle = BorderStyle.FixedSingle
        PnlPointInputsAo.Controls.Add(NumAoJ7)
        PnlPointInputsAo.Controls.Add(LblAoJ7)
        PnlPointInputsAo.Controls.Add(NumAoJ6)
        PnlPointInputsAo.Controls.Add(LblAoJ6)
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
        PnlPointInputsAo.Location = New Point(153, 45)
        PnlPointInputsAo.Name = "PnlPointInputsAo"
        PnlPointInputsAo.Size = New Size(140, 345)
        PnlPointInputsAo.TabIndex = 2
        ' 
        ' NumAoJ7
        ' 
        NumAoJ7.DecimalPlaces = 1
        NumAoJ7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ7.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ7.Location = New Point(10, 280)
        NumAoJ7.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ7.Name = "NumAoJ7"
        NumAoJ7.Size = New Size(75, 35)
        NumAoJ7.TabIndex = 12
        NumAoJ7.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ7
        ' 
        LblAoJ7.BorderStyle = BorderStyle.FixedSingle
        LblAoJ7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ7.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ7.Location = New Point(90, 280)
        LblAoJ7.Name = "LblAoJ7"
        LblAoJ7.Size = New Size(40, 35)
        LblAoJ7.TabIndex = 13
        LblAoJ7.Text = "J7"
        LblAoJ7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ6
        ' 
        NumAoJ6.DecimalPlaces = 1
        NumAoJ6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ6.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ6.Location = New Point(10, 235)
        NumAoJ6.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ6.Name = "NumAoJ6"
        NumAoJ6.Size = New Size(75, 35)
        NumAoJ6.TabIndex = 10
        NumAoJ6.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ6
        ' 
        LblAoJ6.BorderStyle = BorderStyle.FixedSingle
        LblAoJ6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ6.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ6.Location = New Point(90, 235)
        LblAoJ6.Name = "LblAoJ6"
        LblAoJ6.Size = New Size(40, 35)
        LblAoJ6.TabIndex = 11
        LblAoJ6.Text = "J6"
        LblAoJ6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ5
        ' 
        NumAoJ5.DecimalPlaces = 1
        NumAoJ5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ5.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ5.Location = New Point(10, 190)
        NumAoJ5.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ5.Name = "NumAoJ5"
        NumAoJ5.Size = New Size(75, 35)
        NumAoJ5.TabIndex = 8
        NumAoJ5.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ5
        ' 
        LblAoJ5.BorderStyle = BorderStyle.FixedSingle
        LblAoJ5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ5.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ5.Location = New Point(90, 190)
        LblAoJ5.Name = "LblAoJ5"
        LblAoJ5.Size = New Size(40, 35)
        LblAoJ5.TabIndex = 9
        LblAoJ5.Text = "J5"
        LblAoJ5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ4
        ' 
        NumAoJ4.DecimalPlaces = 1
        NumAoJ4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ4.Location = New Point(10, 145)
        NumAoJ4.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ4.Name = "NumAoJ4"
        NumAoJ4.Size = New Size(75, 35)
        NumAoJ4.TabIndex = 6
        NumAoJ4.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ4
        ' 
        LblAoJ4.BorderStyle = BorderStyle.FixedSingle
        LblAoJ4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ4.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ4.Location = New Point(90, 145)
        LblAoJ4.Name = "LblAoJ4"
        LblAoJ4.Size = New Size(40, 35)
        LblAoJ4.TabIndex = 7
        LblAoJ4.Text = "J4"
        LblAoJ4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ3
        ' 
        NumAoJ3.DecimalPlaces = 1
        NumAoJ3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ3.Location = New Point(10, 100)
        NumAoJ3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ3.Name = "NumAoJ3"
        NumAoJ3.Size = New Size(75, 35)
        NumAoJ3.TabIndex = 4
        NumAoJ3.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ3
        ' 
        LblAoJ3.BorderStyle = BorderStyle.FixedSingle
        LblAoJ3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ3.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ3.Location = New Point(90, 100)
        LblAoJ3.Name = "LblAoJ3"
        LblAoJ3.Size = New Size(40, 35)
        LblAoJ3.TabIndex = 5
        LblAoJ3.Text = "J3"
        LblAoJ3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ2
        ' 
        NumAoJ2.DecimalPlaces = 1
        NumAoJ2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ2.Location = New Point(10, 55)
        NumAoJ2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ2.Name = "NumAoJ2"
        NumAoJ2.Size = New Size(75, 35)
        NumAoJ2.TabIndex = 2
        NumAoJ2.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ2
        ' 
        LblAoJ2.BorderStyle = BorderStyle.FixedSingle
        LblAoJ2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ2.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ2.Location = New Point(90, 55)
        LblAoJ2.Name = "LblAoJ2"
        LblAoJ2.Size = New Size(40, 35)
        LblAoJ2.TabIndex = 3
        LblAoJ2.Text = "J2"
        LblAoJ2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoJ1
        ' 
        NumAoJ1.DecimalPlaces = 1
        NumAoJ1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAoJ1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAoJ1.Location = New Point(10, 10)
        NumAoJ1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAoJ1.Name = "NumAoJ1"
        NumAoJ1.Size = New Size(75, 35)
        NumAoJ1.TabIndex = 0
        NumAoJ1.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAoJ1
        ' 
        LblAoJ1.BorderStyle = BorderStyle.FixedSingle
        LblAoJ1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAoJ1.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(220))
        LblAoJ1.Location = New Point(90, 10)
        LblAoJ1.Name = "LblAoJ1"
        LblAoJ1.Size = New Size(40, 35)
        LblAoJ1.TabIndex = 1
        LblAoJ1.Text = "J1"
        LblAoJ1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlPointInputsAka
        ' 
        PnlPointInputsAka.Anchor = AnchorStyles.None
        PnlPointInputsAka.BackColor = Color.White
        PnlPointInputsAka.BorderStyle = BorderStyle.FixedSingle
        PnlPointInputsAka.Controls.Add(NumAkaJ7)
        PnlPointInputsAka.Controls.Add(LblAkaJ7)
        PnlPointInputsAka.Controls.Add(NumAkaJ6)
        PnlPointInputsAka.Controls.Add(LblAkaJ6)
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
        PnlPointInputsAka.Location = New Point(5, 45)
        PnlPointInputsAka.Name = "PnlPointInputsAka"
        PnlPointInputsAka.RightToLeft = RightToLeft.No
        PnlPointInputsAka.Size = New Size(140, 345)
        PnlPointInputsAka.TabIndex = 2
        ' 
        ' NumAkaJ7
        ' 
        NumAkaJ7.DecimalPlaces = 1
        NumAkaJ7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ7.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ7.Location = New Point(55, 280)
        NumAkaJ7.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ7.Name = "NumAkaJ7"
        NumAkaJ7.RightToLeft = RightToLeft.No
        NumAkaJ7.Size = New Size(75, 35)
        NumAkaJ7.TabIndex = 13
        NumAkaJ7.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ7
        ' 
        LblAkaJ7.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ7.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ7.Location = New Point(10, 280)
        LblAkaJ7.Name = "LblAkaJ7"
        LblAkaJ7.Size = New Size(40, 35)
        LblAkaJ7.TabIndex = 12
        LblAkaJ7.Text = "J7"
        LblAkaJ7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ6
        ' 
        NumAkaJ6.DecimalPlaces = 1
        NumAkaJ6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ6.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ6.Location = New Point(55, 235)
        NumAkaJ6.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ6.Name = "NumAkaJ6"
        NumAkaJ6.RightToLeft = RightToLeft.No
        NumAkaJ6.Size = New Size(75, 35)
        NumAkaJ6.TabIndex = 11
        NumAkaJ6.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ6
        ' 
        LblAkaJ6.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ6.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ6.Location = New Point(10, 235)
        LblAkaJ6.Name = "LblAkaJ6"
        LblAkaJ6.Size = New Size(40, 35)
        LblAkaJ6.TabIndex = 10
        LblAkaJ6.Text = "J6"
        LblAkaJ6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ5
        ' 
        NumAkaJ5.DecimalPlaces = 1
        NumAkaJ5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ5.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ5.Location = New Point(55, 190)
        NumAkaJ5.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ5.Name = "NumAkaJ5"
        NumAkaJ5.RightToLeft = RightToLeft.No
        NumAkaJ5.Size = New Size(75, 35)
        NumAkaJ5.TabIndex = 9
        NumAkaJ5.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ5
        ' 
        LblAkaJ5.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ5.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ5.Location = New Point(10, 190)
        LblAkaJ5.Name = "LblAkaJ5"
        LblAkaJ5.Size = New Size(40, 35)
        LblAkaJ5.TabIndex = 8
        LblAkaJ5.Text = "J5"
        LblAkaJ5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ4
        ' 
        NumAkaJ4.DecimalPlaces = 1
        NumAkaJ4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ4.Location = New Point(55, 145)
        NumAkaJ4.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ4.Name = "NumAkaJ4"
        NumAkaJ4.Size = New Size(75, 35)
        NumAkaJ4.TabIndex = 7
        NumAkaJ4.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ4
        ' 
        LblAkaJ4.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ4.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ4.Location = New Point(10, 145)
        LblAkaJ4.Name = "LblAkaJ4"
        LblAkaJ4.Size = New Size(40, 35)
        LblAkaJ4.TabIndex = 6
        LblAkaJ4.Text = "J4"
        LblAkaJ4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ3
        ' 
        NumAkaJ3.DecimalPlaces = 1
        NumAkaJ3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ3.Location = New Point(55, 100)
        NumAkaJ3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ3.Name = "NumAkaJ3"
        NumAkaJ3.Size = New Size(75, 35)
        NumAkaJ3.TabIndex = 5
        NumAkaJ3.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ3
        ' 
        LblAkaJ3.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ3.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ3.Location = New Point(10, 100)
        LblAkaJ3.Name = "LblAkaJ3"
        LblAkaJ3.Size = New Size(40, 35)
        LblAkaJ3.TabIndex = 4
        LblAkaJ3.Text = "J3"
        LblAkaJ3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ2
        ' 
        NumAkaJ2.DecimalPlaces = 1
        NumAkaJ2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ2.Location = New Point(55, 55)
        NumAkaJ2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ2.Name = "NumAkaJ2"
        NumAkaJ2.Size = New Size(75, 35)
        NumAkaJ2.TabIndex = 3
        NumAkaJ2.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ2
        ' 
        LblAkaJ2.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ2.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ2.Location = New Point(10, 55)
        LblAkaJ2.Name = "LblAkaJ2"
        LblAkaJ2.Size = New Size(40, 35)
        LblAkaJ2.TabIndex = 2
        LblAkaJ2.Text = "J2"
        LblAkaJ2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaJ1
        ' 
        NumAkaJ1.DecimalPlaces = 1
        NumAkaJ1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        NumAkaJ1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumAkaJ1.Location = New Point(55, 10)
        NumAkaJ1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumAkaJ1.Name = "NumAkaJ1"
        NumAkaJ1.Size = New Size(75, 35)
        NumAkaJ1.TabIndex = 1
        NumAkaJ1.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAkaJ1
        ' 
        LblAkaJ1.BorderStyle = BorderStyle.FixedSingle
        LblAkaJ1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblAkaJ1.ForeColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaJ1.Location = New Point(10, 10)
        LblAkaJ1.Name = "LblAkaJ1"
        LblAkaJ1.Size = New Size(40, 35)
        LblAkaJ1.TabIndex = 0
        LblAkaJ1.Text = "J1"
        LblAkaJ1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagInputsAka
        ' 
        PnlFlagInputsAka.Anchor = AnchorStyles.None
        PnlFlagInputsAka.BackColor = Color.White
        PnlFlagInputsAka.BorderStyle = BorderStyle.FixedSingle
        PnlFlagInputsAka.Controls.Add(PnlFlagAka7)
        PnlFlagInputsAka.Controls.Add(PnlFlagAka6)
        PnlFlagInputsAka.Controls.Add(PnlFlagAka5)
        PnlFlagInputsAka.Controls.Add(PnlFlagAka4)
        PnlFlagInputsAka.Controls.Add(PnlFlagAka3)
        PnlFlagInputsAka.Controls.Add(PnlFlagAka2)
        PnlFlagInputsAka.Controls.Add(PnlFlagAka1)
        PnlFlagInputsAka.Location = New Point(5, 45)
        PnlFlagInputsAka.Name = "PnlFlagInputsAka"
        PnlFlagInputsAka.Size = New Size(140, 425)
        PnlFlagInputsAka.TabIndex = 20
        PnlFlagInputsAka.Visible = False
        ' 
        ' PnlFlagAka7
        ' 
        PnlFlagAka7.BackgroundImageLayout = ImageLayout.None
        PnlFlagAka7.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAka7.Controls.Add(Label25)
        PnlFlagAka7.Controls.Add(Label26)
        PnlFlagAka7.Cursor = Cursors.Hand
        PnlFlagAka7.Location = New Point(8, 10)
        PnlFlagAka7.Name = "PnlFlagAka7"
        PnlFlagAka7.RightToLeft = RightToLeft.No
        PnlFlagAka7.Size = New Size(120, 51)
        PnlFlagAka7.TabIndex = 27
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Enabled = False
        Label25.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = Color.Red
        Label25.Location = New Point(11, 4)
        Label25.Name = "Label25"
        Label25.Size = New Size(38, 40)
        Label25.TabIndex = 20
        Label25.Text = "⚑"
        ' 
        ' Label26
        ' 
        Label26.Enabled = False
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label26.Location = New Point(48, 6)
        Label26.Name = "Label26"
        Label26.Size = New Size(64, 39)
        Label26.TabIndex = 0
        Label26.Text = "7"
        Label26.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAka6
        ' 
        PnlFlagAka6.BackgroundImageLayout = ImageLayout.None
        PnlFlagAka6.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAka6.Controls.Add(Label23)
        PnlFlagAka6.Controls.Add(Label24)
        PnlFlagAka6.Cursor = Cursors.Hand
        PnlFlagAka6.Location = New Point(8, 67)
        PnlFlagAka6.Name = "PnlFlagAka6"
        PnlFlagAka6.RightToLeft = RightToLeft.No
        PnlFlagAka6.Size = New Size(120, 51)
        PnlFlagAka6.TabIndex = 27
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Enabled = False
        Label23.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.Red
        Label23.Location = New Point(11, 4)
        Label23.Name = "Label23"
        Label23.Size = New Size(38, 40)
        Label23.TabIndex = 20
        Label23.Text = "⚑"
        ' 
        ' Label24
        ' 
        Label24.Enabled = False
        Label24.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label24.Location = New Point(48, 6)
        Label24.Name = "Label24"
        Label24.Size = New Size(64, 39)
        Label24.TabIndex = 0
        Label24.Text = "6"
        Label24.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAka5
        ' 
        PnlFlagAka5.BackgroundImageLayout = ImageLayout.None
        PnlFlagAka5.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAka5.Controls.Add(Label21)
        PnlFlagAka5.Controls.Add(Label22)
        PnlFlagAka5.Cursor = Cursors.Hand
        PnlFlagAka5.Location = New Point(8, 124)
        PnlFlagAka5.Name = "PnlFlagAka5"
        PnlFlagAka5.RightToLeft = RightToLeft.No
        PnlFlagAka5.Size = New Size(120, 51)
        PnlFlagAka5.TabIndex = 27
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Enabled = False
        Label21.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Red
        Label21.Location = New Point(11, 4)
        Label21.Name = "Label21"
        Label21.Size = New Size(38, 40)
        Label21.TabIndex = 20
        Label21.Text = "⚑"
        ' 
        ' Label22
        ' 
        Label22.Enabled = False
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label22.Location = New Point(48, 6)
        Label22.Name = "Label22"
        Label22.Size = New Size(64, 39)
        Label22.TabIndex = 0
        Label22.Text = "5"
        Label22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAka4
        ' 
        PnlFlagAka4.BackgroundImageLayout = ImageLayout.None
        PnlFlagAka4.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAka4.Controls.Add(Label19)
        PnlFlagAka4.Controls.Add(Label20)
        PnlFlagAka4.Cursor = Cursors.Hand
        PnlFlagAka4.Location = New Point(8, 181)
        PnlFlagAka4.Name = "PnlFlagAka4"
        PnlFlagAka4.RightToLeft = RightToLeft.No
        PnlFlagAka4.Size = New Size(120, 51)
        PnlFlagAka4.TabIndex = 27
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Enabled = False
        Label19.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.Red
        Label19.Location = New Point(11, 4)
        Label19.Name = "Label19"
        Label19.Size = New Size(38, 40)
        Label19.TabIndex = 20
        Label19.Text = "⚑"
        ' 
        ' Label20
        ' 
        Label20.Enabled = False
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label20.Location = New Point(48, 6)
        Label20.Name = "Label20"
        Label20.Size = New Size(64, 39)
        Label20.TabIndex = 0
        Label20.Text = "4"
        Label20.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAka3
        ' 
        PnlFlagAka3.BackgroundImageLayout = ImageLayout.None
        PnlFlagAka3.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAka3.Controls.Add(Label17)
        PnlFlagAka3.Controls.Add(Label18)
        PnlFlagAka3.Cursor = Cursors.Hand
        PnlFlagAka3.Location = New Point(8, 238)
        PnlFlagAka3.Name = "PnlFlagAka3"
        PnlFlagAka3.RightToLeft = RightToLeft.No
        PnlFlagAka3.Size = New Size(120, 51)
        PnlFlagAka3.TabIndex = 27
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Enabled = False
        Label17.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.Red
        Label17.Location = New Point(11, 4)
        Label17.Name = "Label17"
        Label17.Size = New Size(38, 40)
        Label17.TabIndex = 20
        Label17.Text = "⚑"
        ' 
        ' Label18
        ' 
        Label18.Enabled = False
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label18.Location = New Point(48, 6)
        Label18.Name = "Label18"
        Label18.Size = New Size(64, 39)
        Label18.TabIndex = 0
        Label18.Text = "3"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAka2
        ' 
        PnlFlagAka2.BackgroundImageLayout = ImageLayout.None
        PnlFlagAka2.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAka2.Controls.Add(Label15)
        PnlFlagAka2.Controls.Add(Label16)
        PnlFlagAka2.Cursor = Cursors.Hand
        PnlFlagAka2.Location = New Point(8, 295)
        PnlFlagAka2.Name = "PnlFlagAka2"
        PnlFlagAka2.RightToLeft = RightToLeft.No
        PnlFlagAka2.Size = New Size(120, 51)
        PnlFlagAka2.TabIndex = 27
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Enabled = False
        Label15.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Red
        Label15.Location = New Point(11, 4)
        Label15.Name = "Label15"
        Label15.Size = New Size(38, 40)
        Label15.TabIndex = 20
        Label15.Text = "⚑"
        ' 
        ' Label16
        ' 
        Label16.Enabled = False
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label16.Location = New Point(48, 6)
        Label16.Name = "Label16"
        Label16.Size = New Size(64, 39)
        Label16.TabIndex = 0
        Label16.Text = "2"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAka1
        ' 
        PnlFlagAka1.BackgroundImageLayout = ImageLayout.None
        PnlFlagAka1.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAka1.Controls.Add(Label13)
        PnlFlagAka1.Controls.Add(Label14)
        PnlFlagAka1.Cursor = Cursors.Hand
        PnlFlagAka1.Location = New Point(8, 352)
        PnlFlagAka1.Name = "PnlFlagAka1"
        PnlFlagAka1.RightToLeft = RightToLeft.No
        PnlFlagAka1.Size = New Size(120, 51)
        PnlFlagAka1.TabIndex = 26
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Enabled = False
        Label13.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Red
        Label13.Location = New Point(11, 4)
        Label13.Name = "Label13"
        Label13.Size = New Size(38, 40)
        Label13.TabIndex = 20
        Label13.Text = "⚑"
        ' 
        ' Label14
        ' 
        Label14.Enabled = False
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label14.Location = New Point(48, 6)
        Label14.Name = "Label14"
        Label14.Size = New Size(64, 39)
        Label14.TabIndex = 0
        Label14.Text = "1"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagInputsAo
        ' 
        PnlFlagInputsAo.Anchor = AnchorStyles.None
        PnlFlagInputsAo.BackColor = Color.White
        PnlFlagInputsAo.BorderStyle = BorderStyle.FixedSingle
        PnlFlagInputsAo.Controls.Add(PnlFlagAo1)
        PnlFlagInputsAo.Controls.Add(PnlFlagAo2)
        PnlFlagInputsAo.Controls.Add(PnlFlagAo3)
        PnlFlagInputsAo.Controls.Add(PnlFlagAo4)
        PnlFlagInputsAo.Controls.Add(PnlFlagAo5)
        PnlFlagInputsAo.Controls.Add(PnlFlagAo6)
        PnlFlagInputsAo.Controls.Add(PnlFlagAo7)
        PnlFlagInputsAo.Location = New Point(154, 45)
        PnlFlagInputsAo.Name = "PnlFlagInputsAo"
        PnlFlagInputsAo.Size = New Size(140, 425)
        PnlFlagInputsAo.TabIndex = 21
        PnlFlagInputsAo.Visible = False
        ' 
        ' PnlFlagAo1
        ' 
        PnlFlagAo1.BackgroundImageLayout = ImageLayout.None
        PnlFlagAo1.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAo1.Controls.Add(Label11)
        PnlFlagAo1.Controls.Add(Label12)
        PnlFlagAo1.Cursor = Cursors.Hand
        PnlFlagAo1.Location = New Point(10, 352)
        PnlFlagAo1.Name = "PnlFlagAo1"
        PnlFlagAo1.Size = New Size(120, 51)
        PnlFlagAo1.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Enabled = False
        Label11.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Blue
        Label11.Location = New Point(77, 3)
        Label11.Name = "Label11"
        Label11.Size = New Size(38, 40)
        Label11.TabIndex = 20
        Label11.Text = "⚑"
        ' 
        ' Label12
        ' 
        Label12.Enabled = False
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label12.Location = New Point(7, 5)
        Label12.Name = "Label12"
        Label12.Size = New Size(64, 39)
        Label12.TabIndex = 0
        Label12.Text = "1"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAo2
        ' 
        PnlFlagAo2.BackgroundImageLayout = ImageLayout.None
        PnlFlagAo2.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAo2.Controls.Add(Label9)
        PnlFlagAo2.Controls.Add(Label10)
        PnlFlagAo2.Cursor = Cursors.Hand
        PnlFlagAo2.Location = New Point(10, 295)
        PnlFlagAo2.Name = "PnlFlagAo2"
        PnlFlagAo2.Size = New Size(120, 51)
        PnlFlagAo2.TabIndex = 24
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Enabled = False
        Label9.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Blue
        Label9.Location = New Point(77, 3)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 40)
        Label9.TabIndex = 20
        Label9.Text = "⚑"
        ' 
        ' Label10
        ' 
        Label10.Enabled = False
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label10.Location = New Point(7, 5)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 39)
        Label10.TabIndex = 0
        Label10.Text = "2"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAo3
        ' 
        PnlFlagAo3.BackgroundImageLayout = ImageLayout.None
        PnlFlagAo3.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAo3.Controls.Add(Label7)
        PnlFlagAo3.Controls.Add(Label8)
        PnlFlagAo3.Cursor = Cursors.Hand
        PnlFlagAo3.Location = New Point(10, 238)
        PnlFlagAo3.Name = "PnlFlagAo3"
        PnlFlagAo3.Size = New Size(120, 51)
        PnlFlagAo3.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Enabled = False
        Label7.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Blue
        Label7.Location = New Point(77, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 40)
        Label7.TabIndex = 20
        Label7.Text = "⚑"
        ' 
        ' Label8
        ' 
        Label8.Enabled = False
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.Location = New Point(7, 5)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 39)
        Label8.TabIndex = 0
        Label8.Text = "3"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAo4
        ' 
        PnlFlagAo4.BackgroundImageLayout = ImageLayout.None
        PnlFlagAo4.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAo4.Controls.Add(Label5)
        PnlFlagAo4.Controls.Add(Label6)
        PnlFlagAo4.Cursor = Cursors.Hand
        PnlFlagAo4.Location = New Point(10, 181)
        PnlFlagAo4.Name = "PnlFlagAo4"
        PnlFlagAo4.Size = New Size(120, 51)
        PnlFlagAo4.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Enabled = False
        Label5.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(77, 3)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 40)
        Label5.TabIndex = 20
        Label5.Text = "⚑"
        ' 
        ' Label6
        ' 
        Label6.Enabled = False
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.Location = New Point(7, 5)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 39)
        Label6.TabIndex = 0
        Label6.Text = "4"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAo5
        ' 
        PnlFlagAo5.BackgroundImageLayout = ImageLayout.None
        PnlFlagAo5.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAo5.Controls.Add(Label3)
        PnlFlagAo5.Controls.Add(Label4)
        PnlFlagAo5.Cursor = Cursors.Hand
        PnlFlagAo5.Location = New Point(10, 124)
        PnlFlagAo5.Name = "PnlFlagAo5"
        PnlFlagAo5.Size = New Size(120, 51)
        PnlFlagAo5.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Enabled = False
        Label3.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(77, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 40)
        Label3.TabIndex = 20
        Label3.Text = "⚑"
        ' 
        ' Label4
        ' 
        Label4.Enabled = False
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(7, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 39)
        Label4.TabIndex = 0
        Label4.Text = "5"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAo6
        ' 
        PnlFlagAo6.BackgroundImageLayout = ImageLayout.None
        PnlFlagAo6.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAo6.Controls.Add(Label1)
        PnlFlagAo6.Controls.Add(Label2)
        PnlFlagAo6.Cursor = Cursors.Hand
        PnlFlagAo6.Location = New Point(10, 67)
        PnlFlagAo6.Name = "PnlFlagAo6"
        PnlFlagAo6.Size = New Size(120, 51)
        PnlFlagAo6.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(77, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 40)
        Label1.TabIndex = 20
        Label1.Text = "⚑"
        ' 
        ' Label2
        ' 
        Label2.Enabled = False
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(7, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 39)
        Label2.TabIndex = 0
        Label2.Text = "6"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFlagAo7
        ' 
        PnlFlagAo7.BackgroundImageLayout = ImageLayout.None
        PnlFlagAo7.BorderStyle = BorderStyle.FixedSingle
        PnlFlagAo7.Controls.Add(PicFlagAo7)
        PnlFlagAo7.Controls.Add(LblFlagAo7)
        PnlFlagAo7.Cursor = Cursors.Hand
        PnlFlagAo7.Location = New Point(10, 10)
        PnlFlagAo7.Name = "PnlFlagAo7"
        PnlFlagAo7.Size = New Size(120, 51)
        PnlFlagAo7.TabIndex = 17
        ' 
        ' PicFlagAo7
        ' 
        PicFlagAo7.AutoSize = True
        PicFlagAo7.Enabled = False
        PicFlagAo7.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PicFlagAo7.ForeColor = Color.Blue
        PicFlagAo7.Location = New Point(77, 3)
        PicFlagAo7.Name = "PicFlagAo7"
        PicFlagAo7.Size = New Size(38, 40)
        PicFlagAo7.TabIndex = 20
        PicFlagAo7.Text = "⚑"
        ' 
        ' LblFlagAo7
        ' 
        LblFlagAo7.Enabled = False
        LblFlagAo7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LblFlagAo7.Location = New Point(7, 5)
        LblFlagAo7.Name = "LblFlagAo7"
        LblFlagAo7.Size = New Size(64, 39)
        LblFlagAo7.TabIndex = 0
        LblFlagAo7.Text = "7"
        LblFlagAo7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTotalScoreAkaTitle
        ' 
        LblTotalScoreAkaTitle.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LblTotalScoreAkaTitle.BorderStyle = BorderStyle.FixedSingle
        LblTotalScoreAkaTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        LblTotalScoreAkaTitle.ForeColor = Color.Black
        LblTotalScoreAkaTitle.Location = New Point(4, 486)
        LblTotalScoreAkaTitle.Name = "LblTotalScoreAkaTitle"
        LblTotalScoreAkaTitle.Size = New Size(140, 30)
        LblTotalScoreAkaTitle.TabIndex = 0
        LblTotalScoreAkaTitle.Text = "Total Score"
        LblTotalScoreAkaTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTotalScoreAoTitle
        ' 
        LblTotalScoreAoTitle.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LblTotalScoreAoTitle.BorderStyle = BorderStyle.FixedSingle
        LblTotalScoreAoTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        LblTotalScoreAoTitle.ForeColor = Color.Black
        LblTotalScoreAoTitle.Location = New Point(153, 486)
        LblTotalScoreAoTitle.Name = "LblTotalScoreAoTitle"
        LblTotalScoreAoTitle.Size = New Size(140, 30)
        LblTotalScoreAoTitle.TabIndex = 0
        LblTotalScoreAoTitle.Text = "Total Score"
        LblTotalScoreAoTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblJudgeScoreTitle
        ' 
        LblJudgeScoreTitle.Dock = DockStyle.Top
        LblJudgeScoreTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        LblJudgeScoreTitle.Location = New Point(0, 0)
        LblJudgeScoreTitle.Name = "LblJudgeScoreTitle"
        LblJudgeScoreTitle.Size = New Size(299, 35)
        LblJudgeScoreTitle.TabIndex = 0
        LblJudgeScoreTitle.Text = "Judge Score"
        LblJudgeScoreTitle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' PnlAo
        ' 
        PnlAo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PnlAo.BackColor = Color.White
        PnlAo.BorderStyle = BorderStyle.FixedSingle
        PnlAo.Controls.Add(LblAoWinner)
        PnlAo.Controls.Add(LblAoWinnerStatus)
        PnlAo.Controls.Add(PicAoAvatar)
        PnlAo.Controls.Add(PicAoCircle)
        PnlAo.Controls.Add(BtnKikenAo)
        PnlAo.Controls.Add(BtnDiskualifikasiAo)
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
        PnlAo.Location = New Point(633, 0)
        PnlAo.Name = "PnlAo"
        PnlAo.Size = New Size(335, 636)
        PnlAo.TabIndex = 1
        ' 
        ' LblAoWinner
        ' 
        LblAoWinner.BackColor = Color.Orange
        LblAoWinner.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblAoWinner.ForeColor = SystemColors.ButtonFace
        LblAoWinner.Location = New Point(214, -1)
        LblAoWinner.Name = "LblAoWinner"
        LblAoWinner.Size = New Size(120, 31)
        LblAoWinner.TabIndex = 17
        LblAoWinner.Text = "WINNER"
        LblAoWinner.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoWinnerStatus
        ' 
        LblAoWinnerStatus.AutoSize = True
        LblAoWinnerStatus.Font = New Font("Segoe UI", 8F)
        LblAoWinnerStatus.ForeColor = Color.Gray
        LblAoWinnerStatus.Location = New Point(15, 345)
        LblAoWinnerStatus.Name = "LblAoWinnerStatus"
        LblAoWinnerStatus.Size = New Size(92, 13)
        LblAoWinnerStatus.TabIndex = 16
        LblAoWinnerStatus.Text = "Show Winner  ▶"
        ' 
        ' PicAoAvatar
        ' 
        PicAoAvatar.BackColor = Color.White
        PicAoAvatar.BorderStyle = BorderStyle.FixedSingle
        PicAoAvatar.Location = New Point(85, 250)
        PicAoAvatar.Name = "PicAoAvatar"
        PicAoAvatar.Size = New Size(60, 60)
        PicAoAvatar.SizeMode = PictureBoxSizeMode.Zoom
        PicAoAvatar.TabIndex = 15
        PicAoAvatar.TabStop = False
        ' 
        ' PicAoCircle
        ' 
        PicAoCircle.BackColor = Color.White
        PicAoCircle.BorderStyle = BorderStyle.FixedSingle
        PicAoCircle.Location = New Point(15, 250)
        PicAoCircle.Name = "PicAoCircle"
        PicAoCircle.Size = New Size(60, 60)
        PicAoCircle.SizeMode = PictureBoxSizeMode.Zoom
        PicAoCircle.TabIndex = 14
        PicAoCircle.TabStop = False
        ' 
        ' BtnKikenAo
        ' 
        BtnKikenAo.BackColor = Color.White
        BtnKikenAo.FlatAppearance.BorderColor = Color.LightGray
        BtnKikenAo.FlatStyle = FlatStyle.Flat
        BtnKikenAo.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnKikenAo.ForeColor = Color.Black
        BtnKikenAo.Location = New Point(230, 283)
        BtnKikenAo.Name = "BtnKikenAo"
        BtnKikenAo.Size = New Size(80, 26)
        BtnKikenAo.TabIndex = 13
        BtnKikenAo.Text = "Kiken"
        BtnKikenAo.UseVisualStyleBackColor = False
        ' 
        ' BtnDiskualifikasiAo
        ' 
        BtnDiskualifikasiAo.AutoSize = True
        BtnDiskualifikasiAo.BorderStyle = BorderStyle.FixedSingle
        BtnDiskualifikasiAo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnDiskualifikasiAo.Location = New Point(212, 261)
        BtnDiskualifikasiAo.Name = "BtnDiskualifikasiAo"
        BtnDiskualifikasiAo.Size = New Size(98, 19)
        BtnDiskualifikasiAo.TabIndex = 12
        BtnDiskualifikasiAo.Text = "Disqualification"
        ' 
        ' CmbAoKata
        ' 
        CmbAoKata.DropDownStyle = ComboBoxStyle.DropDownList
        CmbAoKata.Font = New Font("Segoe UI", 9F)
        CmbAoKata.Location = New Point(15, 210)
        CmbAoKata.Name = "CmbAoKata"
        CmbAoKata.Size = New Size(295, 23)
        CmbAoKata.TabIndex = 11
        ' 
        ' LblAoKata
        ' 
        LblAoKata.AutoSize = True
        LblAoKata.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblAoKata.Location = New Point(15, 190)
        LblAoKata.Name = "LblAoKata"
        LblAoKata.Size = New Size(36, 15)
        LblAoKata.TabIndex = 10
        LblAoKata.Text = "KATA"
        ' 
        ' TxtAoTeam2
        ' 
        TxtAoTeam2.BorderStyle = BorderStyle.FixedSingle
        TxtAoTeam2.Font = New Font("Segoe UI", 9F)
        TxtAoTeam2.Location = New Point(15, 155)
        TxtAoTeam2.Name = "TxtAoTeam2"
        TxtAoTeam2.Size = New Size(295, 23)
        TxtAoTeam2.TabIndex = 9
        ' 
        ' TxtAoTeam1
        ' 
        TxtAoTeam1.BorderStyle = BorderStyle.FixedSingle
        TxtAoTeam1.Font = New Font("Segoe UI", 9F)
        TxtAoTeam1.Location = New Point(15, 125)
        TxtAoTeam1.Name = "TxtAoTeam1"
        TxtAoTeam1.Size = New Size(295, 23)
        TxtAoTeam1.TabIndex = 8
        ' 
        ' BtnAoSearch
        ' 
        BtnAoSearch.BackColor = Color.WhiteSmoke
        BtnAoSearch.FlatAppearance.BorderColor = Color.LightGray
        BtnAoSearch.FlatStyle = FlatStyle.Flat
        BtnAoSearch.Font = New Font("Segoe UI", 8.5F)
        BtnAoSearch.Location = New Point(270, 96)
        BtnAoSearch.Name = "BtnAoSearch"
        BtnAoSearch.Size = New Size(40, 24)
        BtnAoSearch.TabIndex = 7
        BtnAoSearch.Text = "🔍"
        BtnAoSearch.UseVisualStyleBackColor = False
        ' 
        ' BtnAoSwap
        ' 
        BtnAoSwap.BackColor = Color.WhiteSmoke
        BtnAoSwap.FlatAppearance.BorderColor = Color.LightGray
        BtnAoSwap.FlatStyle = FlatStyle.Flat
        BtnAoSwap.Font = New Font("Segoe UI", 9F)
        BtnAoSwap.Location = New Point(230, 96)
        BtnAoSwap.Name = "BtnAoSwap"
        BtnAoSwap.Size = New Size(30, 24)
        BtnAoSwap.TabIndex = 6
        BtnAoSwap.Text = "⇅"
        BtnAoSwap.UseVisualStyleBackColor = False
        ' 
        ' LblAoTeam
        ' 
        LblAoTeam.AutoSize = True
        LblAoTeam.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LblAoTeam.Location = New Point(15, 100)
        LblAoTeam.Name = "LblAoTeam"
        LblAoTeam.Size = New Size(95, 13)
        LblAoTeam.TabIndex = 5
        LblAoTeam.Text = "Team | Team Info"
        ' 
        ' TxtAoNameMain
        ' 
        TxtAoNameMain.BorderStyle = BorderStyle.FixedSingle
        TxtAoNameMain.Font = New Font("Segoe UI", 9F)
        TxtAoNameMain.Location = New Point(15, 65)
        TxtAoNameMain.Name = "TxtAoNameMain"
        TxtAoNameMain.Size = New Size(295, 23)
        TxtAoNameMain.TabIndex = 4
        ' 
        ' BtnAoExtraIcon
        ' 
        BtnAoExtraIcon.BackColor = Color.WhiteSmoke
        BtnAoExtraIcon.FlatAppearance.BorderColor = Color.LightGray
        BtnAoExtraIcon.FlatStyle = FlatStyle.Flat
        BtnAoExtraIcon.Font = New Font("Segoe UI", 9F)
        BtnAoExtraIcon.Location = New Point(280, 36)
        BtnAoExtraIcon.Name = "BtnAoExtraIcon"
        BtnAoExtraIcon.Size = New Size(30, 24)
        BtnAoExtraIcon.TabIndex = 3
        BtnAoExtraIcon.Text = "👤"
        BtnAoExtraIcon.UseVisualStyleBackColor = False
        ' 
        ' BtnAoUpdateInfo
        ' 
        BtnAoUpdateInfo.BackColor = Color.WhiteSmoke
        BtnAoUpdateInfo.FlatAppearance.BorderColor = Color.LightGray
        BtnAoUpdateInfo.FlatStyle = FlatStyle.Flat
        BtnAoUpdateInfo.Font = New Font("Segoe UI", 7.5F)
        BtnAoUpdateInfo.Location = New Point(150, 36)
        BtnAoUpdateInfo.Name = "BtnAoUpdateInfo"
        BtnAoUpdateInfo.Size = New Size(120, 24)
        BtnAoUpdateInfo.TabIndex = 2
        BtnAoUpdateInfo.Text = "⬆ Update Info"
        BtnAoUpdateInfo.UseVisualStyleBackColor = False
        ' 
        ' LblAoName
        ' 
        LblAoName.AutoSize = True
        LblAoName.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblAoName.Location = New Point(15, 40)
        LblAoName.Name = "LblAoName"
        LblAoName.Size = New Size(40, 15)
        LblAoName.TabIndex = 1
        LblAoName.Text = "Name"
        ' 
        ' LblAoHeader
        ' 
        LblAoHeader.BackColor = Color.FromArgb(CByte(30), CByte(120), CByte(250))
        LblAoHeader.Dock = DockStyle.Top
        LblAoHeader.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LblAoHeader.ForeColor = Color.White
        LblAoHeader.Location = New Point(0, 0)
        LblAoHeader.Name = "LblAoHeader"
        LblAoHeader.Size = New Size(333, 30)
        LblAoHeader.TabIndex = 0
        LblAoHeader.Text = "AO"
        LblAoHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlAka
        ' 
        PnlAka.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PnlAka.BackColor = Color.White
        PnlAka.BorderStyle = BorderStyle.FixedSingle
        PnlAka.Controls.Add(LblAkaWinner)
        PnlAka.Controls.Add(LblAkaWinnerStatus)
        PnlAka.Controls.Add(PicAkaAvatar)
        PnlAka.Controls.Add(PicAkaCircle)
        PnlAka.Controls.Add(BtnKikenAka)
        PnlAka.Controls.Add(BtnDiskualifikasiAka)
        PnlAka.Controls.Add(CmbAkaKata)
        PnlAka.Controls.Add(LblAkaKata)
        PnlAka.Controls.Add(TxtAkaTeam2)
        PnlAka.Controls.Add(TxtAkaTeam1)
        PnlAka.Controls.Add(BtnAkaSearch)
        PnlAka.Controls.Add(BtnAkaSwap)
        PnlAka.Controls.Add(LblAkaTeam)
        PnlAka.Controls.Add(TxtAkaNameMain)
        PnlAka.Controls.Add(BtnEditServer)
        PnlAka.Controls.Add(BtnAkaExtraIcon)
        PnlAka.Controls.Add(LblServer)
        PnlAka.Controls.Add(CmbServer)
        PnlAka.Controls.Add(BtnAkaUpdateInfo)
        PnlAka.Controls.Add(LblAkaName)
        PnlAka.Controls.Add(LblAkaHeader)
        PnlAka.Location = New Point(0, 0)
        PnlAka.Name = "PnlAka"
        PnlAka.Size = New Size(335, 636)
        PnlAka.TabIndex = 0
        ' 
        ' LblAkaWinner
        ' 
        LblAkaWinner.BackColor = Color.Orange
        LblAkaWinner.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblAkaWinner.ForeColor = SystemColors.ButtonFace
        LblAkaWinner.Location = New Point(-1, -1)
        LblAkaWinner.Name = "LblAkaWinner"
        LblAkaWinner.Size = New Size(120, 31)
        LblAkaWinner.TabIndex = 18
        LblAkaWinner.Text = "WINNER"
        LblAkaWinner.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaWinnerStatus
        ' 
        LblAkaWinnerStatus.AutoSize = True
        LblAkaWinnerStatus.Font = New Font("Segoe UI", 8F)
        LblAkaWinnerStatus.ForeColor = Color.Gray
        LblAkaWinnerStatus.Location = New Point(218, 345)
        LblAkaWinnerStatus.Name = "LblAkaWinnerStatus"
        LblAkaWinnerStatus.Size = New Size(92, 13)
        LblAkaWinnerStatus.TabIndex = 16
        LblAkaWinnerStatus.Text = "Show Winner  ▶"
        ' 
        ' PicAkaAvatar
        ' 
        PicAkaAvatar.BackColor = Color.White
        PicAkaAvatar.BorderStyle = BorderStyle.FixedSingle
        PicAkaAvatar.Location = New Point(250, 250)
        PicAkaAvatar.Name = "PicAkaAvatar"
        PicAkaAvatar.Size = New Size(60, 60)
        PicAkaAvatar.SizeMode = PictureBoxSizeMode.Zoom
        PicAkaAvatar.TabIndex = 15
        PicAkaAvatar.TabStop = False
        ' 
        ' PicAkaCircle
        ' 
        PicAkaCircle.BackColor = Color.White
        PicAkaCircle.BorderStyle = BorderStyle.FixedSingle
        PicAkaCircle.Location = New Point(180, 250)
        PicAkaCircle.Name = "PicAkaCircle"
        PicAkaCircle.Size = New Size(60, 60)
        PicAkaCircle.SizeMode = PictureBoxSizeMode.Zoom
        PicAkaCircle.TabIndex = 14
        PicAkaCircle.TabStop = False
        ' 
        ' BtnKikenAka
        ' 
        BtnKikenAka.BackColor = Color.White
        BtnKikenAka.FlatAppearance.BorderColor = Color.LightGray
        BtnKikenAka.FlatStyle = FlatStyle.Flat
        BtnKikenAka.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnKikenAka.ForeColor = Color.Black
        BtnKikenAka.Location = New Point(15, 275)
        BtnKikenAka.Name = "BtnKikenAka"
        BtnKikenAka.Size = New Size(80, 30)
        BtnKikenAka.TabIndex = 13
        BtnKikenAka.Text = "Kiken"
        BtnKikenAka.UseVisualStyleBackColor = False
        ' 
        ' BtnDiskualifikasiAka
        ' 
        BtnDiskualifikasiAka.AutoSize = True
        BtnDiskualifikasiAka.BorderStyle = BorderStyle.FixedSingle
        BtnDiskualifikasiAka.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnDiskualifikasiAka.Location = New Point(15, 250)
        BtnDiskualifikasiAka.Name = "BtnDiskualifikasiAka"
        BtnDiskualifikasiAka.Size = New Size(98, 19)
        BtnDiskualifikasiAka.TabIndex = 12
        BtnDiskualifikasiAka.Text = "Disqualification"
        ' 
        ' CmbAkaKata
        ' 
        CmbAkaKata.DropDownStyle = ComboBoxStyle.DropDownList
        CmbAkaKata.Font = New Font("Segoe UI", 9F)
        CmbAkaKata.Location = New Point(15, 210)
        CmbAkaKata.Name = "CmbAkaKata"
        CmbAkaKata.Size = New Size(295, 23)
        CmbAkaKata.TabIndex = 11
        ' 
        ' LblAkaKata
        ' 
        LblAkaKata.AutoSize = True
        LblAkaKata.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblAkaKata.Location = New Point(15, 190)
        LblAkaKata.Name = "LblAkaKata"
        LblAkaKata.Size = New Size(36, 15)
        LblAkaKata.TabIndex = 10
        LblAkaKata.Text = "KATA"
        ' 
        ' TxtAkaTeam2
        ' 
        TxtAkaTeam2.BorderStyle = BorderStyle.FixedSingle
        TxtAkaTeam2.Font = New Font("Segoe UI", 9F)
        TxtAkaTeam2.Location = New Point(15, 155)
        TxtAkaTeam2.Name = "TxtAkaTeam2"
        TxtAkaTeam2.Size = New Size(295, 23)
        TxtAkaTeam2.TabIndex = 9
        ' 
        ' TxtAkaTeam1
        ' 
        TxtAkaTeam1.BorderStyle = BorderStyle.FixedSingle
        TxtAkaTeam1.Font = New Font("Segoe UI", 9F)
        TxtAkaTeam1.Location = New Point(15, 125)
        TxtAkaTeam1.Name = "TxtAkaTeam1"
        TxtAkaTeam1.Size = New Size(295, 23)
        TxtAkaTeam1.TabIndex = 8
        ' 
        ' BtnAkaSearch
        ' 
        BtnAkaSearch.BackColor = Color.WhiteSmoke
        BtnAkaSearch.FlatAppearance.BorderColor = Color.LightGray
        BtnAkaSearch.FlatStyle = FlatStyle.Flat
        BtnAkaSearch.Font = New Font("Segoe UI", 8.5F)
        BtnAkaSearch.Location = New Point(270, 96)
        BtnAkaSearch.Name = "BtnAkaSearch"
        BtnAkaSearch.Size = New Size(40, 24)
        BtnAkaSearch.TabIndex = 7
        BtnAkaSearch.Text = "🔍"
        BtnAkaSearch.UseVisualStyleBackColor = False
        ' 
        ' BtnAkaSwap
        ' 
        BtnAkaSwap.BackColor = Color.WhiteSmoke
        BtnAkaSwap.FlatAppearance.BorderColor = Color.LightGray
        BtnAkaSwap.FlatStyle = FlatStyle.Flat
        BtnAkaSwap.Font = New Font("Segoe UI", 9F)
        BtnAkaSwap.Location = New Point(230, 96)
        BtnAkaSwap.Name = "BtnAkaSwap"
        BtnAkaSwap.Size = New Size(30, 24)
        BtnAkaSwap.TabIndex = 6
        BtnAkaSwap.Text = "⇅"
        BtnAkaSwap.UseVisualStyleBackColor = False
        ' 
        ' LblAkaTeam
        ' 
        LblAkaTeam.AutoSize = True
        LblAkaTeam.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LblAkaTeam.Location = New Point(15, 100)
        LblAkaTeam.Name = "LblAkaTeam"
        LblAkaTeam.Size = New Size(95, 13)
        LblAkaTeam.TabIndex = 5
        LblAkaTeam.Text = "Team | Team Info"
        ' 
        ' TxtAkaNameMain
        ' 
        TxtAkaNameMain.BorderStyle = BorderStyle.FixedSingle
        TxtAkaNameMain.Font = New Font("Segoe UI", 9F)
        TxtAkaNameMain.Location = New Point(15, 65)
        TxtAkaNameMain.Name = "TxtAkaNameMain"
        TxtAkaNameMain.Size = New Size(295, 23)
        TxtAkaNameMain.TabIndex = 4
        ' 
        ' BtnAkaExtraIcon
        ' 
        BtnAkaExtraIcon.BackColor = Color.WhiteSmoke
        BtnAkaExtraIcon.FlatAppearance.BorderColor = Color.LightGray
        BtnAkaExtraIcon.FlatStyle = FlatStyle.Flat
        BtnAkaExtraIcon.Font = New Font("Segoe UI", 9F)
        BtnAkaExtraIcon.Location = New Point(280, 36)
        BtnAkaExtraIcon.Name = "BtnAkaExtraIcon"
        BtnAkaExtraIcon.Size = New Size(30, 24)
        BtnAkaExtraIcon.TabIndex = 3
        BtnAkaExtraIcon.Text = "👤"
        BtnAkaExtraIcon.UseVisualStyleBackColor = False
        ' 
        ' BtnAkaUpdateInfo
        ' 
        BtnAkaUpdateInfo.BackColor = Color.WhiteSmoke
        BtnAkaUpdateInfo.FlatAppearance.BorderColor = Color.LightGray
        BtnAkaUpdateInfo.FlatStyle = FlatStyle.Flat
        BtnAkaUpdateInfo.Font = New Font("Segoe UI", 7.5F)
        BtnAkaUpdateInfo.Location = New Point(150, 36)
        BtnAkaUpdateInfo.Name = "BtnAkaUpdateInfo"
        BtnAkaUpdateInfo.Size = New Size(120, 24)
        BtnAkaUpdateInfo.TabIndex = 2
        BtnAkaUpdateInfo.Text = "⬆ Update Info"
        BtnAkaUpdateInfo.UseVisualStyleBackColor = False
        ' 
        ' LblAkaName
        ' 
        LblAkaName.AutoSize = True
        LblAkaName.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        LblAkaName.Location = New Point(15, 40)
        LblAkaName.Name = "LblAkaName"
        LblAkaName.Size = New Size(40, 15)
        LblAkaName.TabIndex = 1
        LblAkaName.Text = "Name"
        ' 
        ' LblAkaHeader
        ' 
        LblAkaHeader.BackColor = Color.FromArgb(CByte(220), CByte(40), CByte(40))
        LblAkaHeader.Dock = DockStyle.Top
        LblAkaHeader.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LblAkaHeader.ForeColor = Color.White
        LblAkaHeader.Location = New Point(0, 0)
        LblAkaHeader.Name = "LblAkaHeader"
        LblAkaHeader.Size = New Size(333, 30)
        LblAkaHeader.TabIndex = 0
        LblAkaHeader.Text = "AKA"
        LblAkaHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' KataMainControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 721)
        Controls.Add(PnlMainWorkspace)
        Controls.Add(PnlRightBar)
        Controls.Add(PnlFooter)
        Controls.Add(PnlLeftBar)
        Controls.Add(PnlTopBar)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(1200, 678)
        Name = "KataMainControl"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KATA Main Control"
        TabPageDetail.ResumeLayout(False)
        TabPageDetail.PerformLayout()
        PnlLeftBar.ResumeLayout(False)
        PnlLeftBar.PerformLayout()
        PnlJ7.ResumeLayout(False)
        PnlJ6.ResumeLayout(False)
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
        PnlJudge.ResumeLayout(False)
        PnlJudge.PerformLayout()
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
        PnlMainWorkspace.ResumeLayout(False)
        PnlCenterScore.ResumeLayout(False)
        CType(TotalScoreAO, ComponentModel.ISupportInitialize).EndInit()
        CType(TotalScoreAKA, ComponentModel.ISupportInitialize).EndInit()
        PnlPointInputsAo.ResumeLayout(False)
        CType(NumAoJ7, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ6, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ5, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ1, ComponentModel.ISupportInitialize).EndInit()
        PnlPointInputsAka.ResumeLayout(False)
        CType(NumAkaJ7, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ6, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ5, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ1, ComponentModel.ISupportInitialize).EndInit()
        PnlFlagInputsAka.ResumeLayout(False)
        PnlFlagAka7.ResumeLayout(False)
        PnlFlagAka7.PerformLayout()
        PnlFlagAka6.ResumeLayout(False)
        PnlFlagAka6.PerformLayout()
        PnlFlagAka5.ResumeLayout(False)
        PnlFlagAka5.PerformLayout()
        PnlFlagAka4.ResumeLayout(False)
        PnlFlagAka4.PerformLayout()
        PnlFlagAka3.ResumeLayout(False)
        PnlFlagAka3.PerformLayout()
        PnlFlagAka2.ResumeLayout(False)
        PnlFlagAka2.PerformLayout()
        PnlFlagAka1.ResumeLayout(False)
        PnlFlagAka1.PerformLayout()
        PnlFlagInputsAo.ResumeLayout(False)
        PnlFlagAo1.ResumeLayout(False)
        PnlFlagAo1.PerformLayout()
        PnlFlagAo2.ResumeLayout(False)
        PnlFlagAo2.PerformLayout()
        PnlFlagAo3.ResumeLayout(False)
        PnlFlagAo3.PerformLayout()
        PnlFlagAo4.ResumeLayout(False)
        PnlFlagAo4.PerformLayout()
        PnlFlagAo5.ResumeLayout(False)
        PnlFlagAo5.PerformLayout()
        PnlFlagAo6.ResumeLayout(False)
        PnlFlagAo6.PerformLayout()
        PnlFlagAo7.ResumeLayout(False)
        PnlFlagAo7.PerformLayout()
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
    Friend WithEvents PicFlagAka1 As Label
    Friend WithEvents PicFlagAo7 As Label
    Friend WithEvents LblFlagAo7 As Label
    Friend WithEvents PicFlagRed As Label
    Friend WithEvents PicFlagBlue As Label
    Friend WithEvents PicFlagAka7 As Label
    Friend WithEvents PicFlagAka6 As Label
    Friend WithEvents PicFlagAka5 As Label
    Friend WithEvents PicFlagAka4 As Label
    Friend WithEvents PicFlagAka3 As Label
    Friend WithEvents PicFlagAka2 As Label
    Friend WithEvents LblJudge As Label
    Friend WithEvents PnlJudge As Panel
    Friend WithEvents PnlFlagAo7 As Panel
    Friend WithEvents PnlFlagAo6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PnlFlagAo1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PnlFlagAo2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PnlFlagAo3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PnlFlagAo4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PnlFlagAo5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PnlFlagAka1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PnlFlagAka7 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents PnlFlagAka6 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents PnlFlagAka5 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PnlFlagAka4 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PnlFlagAka3 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PnlFlagAka2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtMatchDetail As TextBox
    Friend WithEvents LblAoWinner As Label
    Friend WithEvents LblAkaWinner As Label

End Class