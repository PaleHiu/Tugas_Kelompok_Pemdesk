Imports System.Runtime.InteropServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KumiteMainControl
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelHeader = New Panel()
        LblNextMatch = New Label()
        TxtAkaName = New TextBox()
        BtnAkaIcon = New Button()
        LblVS = New Label()
        BtnAoIcon = New Button()
        TxtAoName = New TextBox()
        BtnSwap = New Button()
        BtnLoadNextMatch = New Button()
        PanelFooter = New Panel()
        BtnSettings = New Button()
        BtnLogActivity = New Button()
        BtnShortcut = New Button()
        BtnDisplay = New Button()
        BtnVolume = New Button()
        BtnResetHantei = New Button()
        BtnHantei = New Button()
        BtnHikiwake = New Button()
        BtnResetMatch = New Button()
        BtnSaveMatch = New Button()
        PanelMainCenter = New Panel()
        PanelAO = New Panel()
        LblAoWinner = New Label()
        AOVR = New Button()
        LblAoTitle = New Label()
        PicAoProfile = New PictureBox()
        PnlAoInfo = New Panel()
        LblAoNameTitle = New Label()
        TxtAoNameMain = New TextBox()
        BtnAoUserIcon1 = New Button()
        LblAoTeamTitle = New Label()
        TxtAoTeam = New TextBox()
        BtnAoTeamSearch = New Button()
        LblAoTeamInfoTitle = New Label()
        TxtAoTeamInfo = New TextBox()
        PicAoTeamLogo = New PictureBox()
        BtnAoKiken = New Button()
        BtnAoShikkaku = New Button()
        BtnAoKnockedOut = New Button()
        PnlAoPenalty = New Panel()
        LabelAoPenaltyP = New Label()
        BtnAo1C = New Button()
        BtnAo2C = New Button()
        BtnAo3C = New Button()
        BtnAoHC = New Button()
        BtnAoH = New Button()
        PnlAoScoreSummary = New Panel()
        LblAoScoreSummaryTitle = New Label()
        LblAoIpponCount = New Label()
        LblAoWazaariCount = New Label()
        LblAoYukoCount = New Label()
        BtnAoVR = New Button()
        DgvAoHistory = New DataGridView()
        ColNoAo = New DataGridViewTextBoxColumn()
        ColTimerAo = New DataGridViewTextBoxColumn()
        ColTypeAo = New DataGridViewTextBoxColumn()
        ColActionAo = New DataGridViewButtonColumn()
        LblAoMainScore = New Label()
        BtnAoIppon = New Button()
        BtnAoWazaari = New Button()
        BtnAoYuko = New Button()
        BtnAoShowWinner = New Button()
        BtnAoResetScore = New Button()
        BtnAoSenshu = New Button()
        PanelAKA = New Panel()
        DataGridView1 = New DataGridView()
        LblAkaWinner = New Label()
        BtnAkaKiken = New Button()
        AKAVR = New Button()
        LblAkaTitle = New Label()
        PicAkaProfile = New PictureBox()
        PnlAkaInfo = New Panel()
        LblAkaNameTitle = New Label()
        TxtAkaNameMain = New TextBox()
        BtnAkaUserIcon1 = New Button()
        LblAkaTeamTitle = New Label()
        TxtAkaTeam = New TextBox()
        BtnAkaTeamSearch = New Button()
        LblAkaTeamInfoTitle = New Label()
        TxtAkaTeamInfo = New TextBox()
        PicAkaTeamLogo = New PictureBox()
        BtnAkaShikkaku = New Button()
        BtnAkaKnockedOut = New Button()
        PnlAkaPenalty = New Panel()
        Label1 = New Label()
        BtnAka1C = New Button()
        BtnAka2C = New Button()
        BtnAka3C = New Button()
        BtnAkaHC = New Button()
        BtnAkaH = New Button()
        PnlAkaScoreSummary = New Panel()
        LblAkaScoreSummaryTitle = New Label()
        LblAkaIpponCount = New Label()
        LblAkaWazaariCount = New Label()
        LblAkaYukoCount = New Label()
        BtnAkaVR = New Button()
        DgvAkaHistory = New DataGridView()
        ColNo = New DataGridViewTextBoxColumn()
        ColTimer = New DataGridViewTextBoxColumn()
        ColType = New DataGridViewTextBoxColumn()
        ColActionAka = New DataGridViewButtonColumn()
        LblAkaMainScore = New Label()
        BtnAkaIppon = New Button()
        BtnAkaWazaari = New Button()
        BtnAkaYuko = New Button()
        BtnAkaShowWinner = New Button()
        BtnAkaResetScore = New Button()
        BtnAkaSenshu = New Button()
        PanelSidebarRight = New Panel()
        BtnSendMatchInfo = New Button()
        BtnSaveWinPoint = New Button()
        ResetTimer = New Button()
        LblScboardType = New Label()
        LblSenshuStyle = New Label()
        LblAdjustScboard = New Label()
        CboAdjustPlayer = New ComboBox()
        NumAdjustSize = New NumericUpDown()
        BtnAdjustR = New Button()
        BtnAdjustMin = New Button()
        BtnAdjustPlus = New Button()
        TabMatchDetail = New TabControl()
        PageMatchDetail = New TabPage()
        TxtMatchDesc = New TextBox()
        PageMatchLogo = New TabPage()
        PicPreviewLogo = New PictureBox()
        BtnSelectLogo = New Button()
        BtnRemoveLogo = New Button()
        LblWinPoint = New Label()
        NumWinPoint = New NumericUpDown()
        BtnEditWinPoint = New Button()
        LblTatami = New Label()
        NumTatami = New NumericUpDown()
        BtnSwitchPosition = New Button()
        PnlWaitingTimer = New Panel()
        LblWaitingTimerTitle = New Label()
        NumWaitMin = New NumericUpDown()
        LblWaitColon = New Label()
        NumWaitSec = New NumericUpDown()
        BtnStartWait = New Button()
        PanelMatchTimer = New Panel()
        LblMatchTimerTitle = New Label()
        BtnTime130 = New Button()
        BtnTime200 = New Button()
        BtnTime300 = New Button()
        NumMatchMin = New NumericUpDown()
        LblMatchColon = New Label()
        NumMatchSec = New NumericUpDown()
        PnlYellowTimerBox = New Panel()
        LblAdjustTimerTitle = New Label()
        LblMatchTimerValue = New Label()
        BtnMatchTimeMinus = New Button()
        BtnMatchTimePlus = New Button()
        BtnStartScoreboard = New Button()
        BtnStartTimer = New Button()
        BtnResetTimer = New Button()
        PanelHeader.SuspendLayout()
        PanelFooter.SuspendLayout()
        PanelMainCenter.SuspendLayout()
        PanelAO.SuspendLayout()
        CType(PicAoProfile, ComponentModel.ISupportInitialize).BeginInit()
        PnlAoInfo.SuspendLayout()
        CType(PicAoTeamLogo, ComponentModel.ISupportInitialize).BeginInit()
        PnlAoPenalty.SuspendLayout()
        PnlAoScoreSummary.SuspendLayout()
        CType(DgvAoHistory, ComponentModel.ISupportInitialize).BeginInit()
        PanelAKA.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicAkaProfile, ComponentModel.ISupportInitialize).BeginInit()
        PnlAkaInfo.SuspendLayout()
        CType(PicAkaTeamLogo, ComponentModel.ISupportInitialize).BeginInit()
        PnlAkaPenalty.SuspendLayout()
        PnlAkaScoreSummary.SuspendLayout()
        CType(DgvAkaHistory, ComponentModel.ISupportInitialize).BeginInit()
        PanelSidebarRight.SuspendLayout()
        CType(NumAdjustSize, ComponentModel.ISupportInitialize).BeginInit()
        TabMatchDetail.SuspendLayout()
        PageMatchDetail.SuspendLayout()
        PageMatchLogo.SuspendLayout()
        CType(PicPreviewLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumWinPoint, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumTatami, ComponentModel.ISupportInitialize).BeginInit()
        PnlWaitingTimer.SuspendLayout()
        CType(NumWaitMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumWaitSec, ComponentModel.ISupportInitialize).BeginInit()
        PanelMatchTimer.SuspendLayout()
        CType(NumMatchMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumMatchSec, ComponentModel.ISupportInitialize).BeginInit()
        PnlYellowTimerBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.White
        PanelHeader.Controls.Add(LblNextMatch)
        PanelHeader.Controls.Add(TxtAkaName)
        PanelHeader.Controls.Add(BtnAkaIcon)
        PanelHeader.Controls.Add(LblVS)
        PanelHeader.Controls.Add(BtnAoIcon)
        PanelHeader.Controls.Add(TxtAoName)
        PanelHeader.Controls.Add(BtnSwap)
        PanelHeader.Controls.Add(BtnLoadNextMatch)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Margin = New Padding(3, 4, 3, 4)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1200, 53)
        PanelHeader.TabIndex = 0
        ' 
        ' LblNextMatch
        ' 
        LblNextMatch.BackColor = Color.Gold
        LblNextMatch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblNextMatch.Location = New Point(11, 11)
        LblNextMatch.Name = "LblNextMatch"
        LblNextMatch.Size = New Size(91, 32)
        LblNextMatch.TabIndex = 0
        LblNextMatch.Text = "Next Match"
        LblNextMatch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtAkaName
        ' 
        TxtAkaName.BorderStyle = BorderStyle.FixedSingle
        TxtAkaName.Font = New Font("Segoe UI", 9.0F)
        TxtAkaName.Location = New Point(114, 12)
        TxtAkaName.Margin = New Padding(3, 4, 3, 4)
        TxtAkaName.Name = "TxtAkaName"
        TxtAkaName.Size = New Size(171, 27)
        TxtAkaName.TabIndex = 1
        ' 
        ' BtnAkaIcon
        ' 
        BtnAkaIcon.BackColor = Color.WhiteSmoke
        BtnAkaIcon.FlatStyle = FlatStyle.Flat
        BtnAkaIcon.Location = New Point(291, 11)
        BtnAkaIcon.Margin = New Padding(3, 4, 3, 4)
        BtnAkaIcon.Name = "BtnAkaIcon"
        BtnAkaIcon.Size = New Size(34, 33)
        BtnAkaIcon.TabIndex = 2
        BtnAkaIcon.Text = "👤"
        BtnAkaIcon.UseVisualStyleBackColor = False
        ' 
        ' LblVS
        ' 
        LblVS.BackColor = Color.Gold
        LblVS.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblVS.Location = New Point(337, 11)
        LblVS.Name = "LblVS"
        LblVS.Size = New Size(34, 32)
        LblVS.TabIndex = 3
        LblVS.Text = "VS"
        LblVS.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnAoIcon
        ' 
        BtnAoIcon.BackColor = Color.WhiteSmoke
        BtnAoIcon.FlatStyle = FlatStyle.Flat
        BtnAoIcon.Location = New Point(383, 11)
        BtnAoIcon.Margin = New Padding(3, 4, 3, 4)
        BtnAoIcon.Name = "BtnAoIcon"
        BtnAoIcon.Size = New Size(34, 33)
        BtnAoIcon.TabIndex = 4
        BtnAoIcon.Text = "👤"
        BtnAoIcon.UseVisualStyleBackColor = False
        ' 
        ' TxtAoName
        ' 
        TxtAoName.BorderStyle = BorderStyle.FixedSingle
        TxtAoName.Font = New Font("Segoe UI", 9.0F)
        TxtAoName.Location = New Point(423, 12)
        TxtAoName.Margin = New Padding(3, 4, 3, 4)
        TxtAoName.Name = "TxtAoName"
        TxtAoName.Size = New Size(171, 27)
        TxtAoName.TabIndex = 5
        ' 
        ' BtnSwap
        ' 
        BtnSwap.BackColor = Color.Gray
        BtnSwap.FlatStyle = FlatStyle.Flat
        BtnSwap.ForeColor = Color.White
        BtnSwap.Location = New Point(606, 11)
        BtnSwap.Margin = New Padding(3, 4, 3, 4)
        BtnSwap.Name = "BtnSwap"
        BtnSwap.Size = New Size(34, 33)
        BtnSwap.TabIndex = 6
        BtnSwap.Text = "⇄"
        BtnSwap.UseVisualStyleBackColor = False
        ' 
        ' BtnLoadNextMatch
        ' 
        BtnLoadNextMatch.BackColor = Color.Gold
        BtnLoadNextMatch.FlatStyle = FlatStyle.Flat
        BtnLoadNextMatch.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        BtnLoadNextMatch.Location = New Point(651, 11)
        BtnLoadNextMatch.Margin = New Padding(3, 4, 3, 4)
        BtnLoadNextMatch.Name = "BtnLoadNextMatch"
        BtnLoadNextMatch.Size = New Size(137, 33)
        BtnLoadNextMatch.TabIndex = 7
        BtnLoadNextMatch.Text = "Load Next Match"
        BtnLoadNextMatch.UseVisualStyleBackColor = False
        ' 
        ' PanelFooter
        ' 
        PanelFooter.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        PanelFooter.Controls.Add(BtnSettings)
        PanelFooter.Controls.Add(BtnLogActivity)
        PanelFooter.Controls.Add(BtnShortcut)
        PanelFooter.Controls.Add(BtnDisplay)
        PanelFooter.Controls.Add(BtnVolume)
        PanelFooter.Controls.Add(BtnResetHantei)
        PanelFooter.Controls.Add(BtnHantei)
        PanelFooter.Controls.Add(BtnHikiwake)
        PanelFooter.Controls.Add(BtnResetMatch)
        PanelFooter.Controls.Add(BtnSaveMatch)
        PanelFooter.Dock = DockStyle.Bottom
        PanelFooter.Location = New Point(0, 812)
        PanelFooter.Margin = New Padding(3, 4, 3, 4)
        PanelFooter.Name = "PanelFooter"
        PanelFooter.Size = New Size(1200, 63)
        PanelFooter.TabIndex = 1
        ' 
        ' BtnSettings
        ' 
        BtnSettings.BackColor = Color.White
        BtnSettings.FlatStyle = FlatStyle.Flat
        BtnSettings.Location = New Point(11, 8)
        BtnSettings.Margin = New Padding(3, 4, 3, 4)
        BtnSettings.Name = "BtnSettings"
        BtnSettings.Size = New Size(97, 44)
        BtnSettings.TabIndex = 2
        BtnSettings.Text = "Settings ⚙"
        BtnSettings.UseVisualStyleBackColor = False
        ' 
        ' BtnLogActivity
        ' 
        BtnLogActivity.BackColor = Color.White
        BtnLogActivity.FlatStyle = FlatStyle.Flat
        BtnLogActivity.Location = New Point(114, 8)
        BtnLogActivity.Margin = New Padding(3, 4, 3, 4)
        BtnLogActivity.Name = "BtnLogActivity"
        BtnLogActivity.Size = New Size(97, 44)
        BtnLogActivity.TabIndex = 3
        BtnLogActivity.Text = "Log Activity"
        BtnLogActivity.UseVisualStyleBackColor = False
        ' 
        ' BtnShortcut
        ' 
        BtnShortcut.BackColor = Color.White
        BtnShortcut.FlatStyle = FlatStyle.Flat
        BtnShortcut.Location = New Point(217, 8)
        BtnShortcut.Margin = New Padding(3, 4, 3, 4)
        BtnShortcut.Name = "BtnShortcut"
        BtnShortcut.Size = New Size(97, 44)
        BtnShortcut.TabIndex = 4
        BtnShortcut.Text = "Shortcut ⌨"
        BtnShortcut.UseVisualStyleBackColor = False
        ' 
        ' BtnDisplay
        ' 
        BtnDisplay.BackColor = Color.White
        BtnDisplay.FlatStyle = FlatStyle.Flat
        BtnDisplay.Location = New Point(457, 8)
        BtnDisplay.Margin = New Padding(3, 4, 3, 4)
        BtnDisplay.Name = "BtnDisplay"
        BtnDisplay.Size = New Size(40, 44)
        BtnDisplay.TabIndex = 5
        BtnDisplay.Text = "🖥"
        BtnDisplay.UseVisualStyleBackColor = False
        ' 
        ' BtnVolume
        ' 
        BtnVolume.BackColor = Color.White
        BtnVolume.FlatStyle = FlatStyle.Flat
        BtnVolume.Location = New Point(503, 8)
        BtnVolume.Margin = New Padding(3, 4, 3, 4)
        BtnVolume.Name = "BtnVolume"
        BtnVolume.Size = New Size(40, 44)
        BtnVolume.TabIndex = 6
        BtnVolume.Text = "🔊"
        BtnVolume.UseVisualStyleBackColor = False
        ' 
        ' BtnResetHantei
        ' 
        BtnResetHantei.BackColor = Color.White
        BtnResetHantei.FlatStyle = FlatStyle.Flat
        BtnResetHantei.Location = New Point(549, 8)
        BtnResetHantei.Margin = New Padding(3, 4, 3, 4)
        BtnResetHantei.Name = "BtnResetHantei"
        BtnResetHantei.Size = New Size(109, 44)
        BtnResetHantei.TabIndex = 7
        BtnResetHantei.Text = "Reset Hantei ⮌"
        BtnResetHantei.UseVisualStyleBackColor = False
        ' 
        ' BtnHantei
        ' 
        BtnHantei.BackColor = Color.White
        BtnHantei.FlatStyle = FlatStyle.Flat
        BtnHantei.Location = New Point(663, 8)
        BtnHantei.Margin = New Padding(3, 4, 3, 4)
        BtnHantei.Name = "BtnHantei"
        BtnHantei.Size = New Size(86, 44)
        BtnHantei.TabIndex = 8
        BtnHantei.Text = "Hantei 🏳"
        BtnHantei.UseVisualStyleBackColor = False
        ' 
        ' BtnHikiwake
        ' 
        BtnHikiwake.BackColor = Color.White
        BtnHikiwake.FlatStyle = FlatStyle.Flat
        BtnHikiwake.Location = New Point(754, 8)
        BtnHikiwake.Margin = New Padding(3, 4, 3, 4)
        BtnHikiwake.Name = "BtnHikiwake"
        BtnHikiwake.Size = New Size(143, 44)
        BtnHikiwake.TabIndex = 9
        BtnHikiwake.Text = "Hikiwake/Draw 🎌"
        BtnHikiwake.UseVisualStyleBackColor = False
        ' 
        ' BtnResetMatch
        ' 
        BtnResetMatch.BackColor = Color.White
        BtnResetMatch.FlatStyle = FlatStyle.Flat
        BtnResetMatch.Location = New Point(911, 8)
        BtnResetMatch.Margin = New Padding(3, 4, 3, 4)
        BtnResetMatch.Name = "BtnResetMatch"
        BtnResetMatch.Size = New Size(120, 44)
        BtnResetMatch.TabIndex = 17
        BtnResetMatch.Text = "Reset Match"
        BtnResetMatch.UseVisualStyleBackColor = False
        ' 
        ' BtnSaveMatch
        ' 
        BtnSaveMatch.BackColor = Color.White
        BtnSaveMatch.FlatStyle = FlatStyle.Flat
        BtnSaveMatch.Location = New Point(1049, 8)
        BtnSaveMatch.Margin = New Padding(3, 4, 3, 4)
        BtnSaveMatch.Name = "BtnSaveMatch"
        BtnSaveMatch.Size = New Size(143, 44)
        BtnSaveMatch.TabIndex = 18
        BtnSaveMatch.Text = "Save Match Result"
        BtnSaveMatch.UseVisualStyleBackColor = False
        ' 
        ' PanelMainCenter
        ' 
        PanelMainCenter.Controls.Add(PanelAO)
        PanelMainCenter.Controls.Add(PanelAKA)
        PanelMainCenter.Dock = DockStyle.Fill
        PanelMainCenter.Location = New Point(0, 53)
        PanelMainCenter.Margin = New Padding(3, 4, 3, 4)
        PanelMainCenter.Name = "PanelMainCenter"
        PanelMainCenter.Padding = New Padding(21, 25, 21, 25)
        PanelMainCenter.Size = New Size(900, 759)
        PanelMainCenter.TabIndex = 3
        ' 
        ' PanelAO
        ' 
        PanelAO.BackColor = Color.White
        PanelAO.BorderStyle = BorderStyle.FixedSingle
        PanelAO.Controls.Add(LblAoWinner)
        PanelAO.Controls.Add(AOVR)
        PanelAO.Controls.Add(LblAoTitle)
        PanelAO.Controls.Add(PicAoProfile)
        PanelAO.Controls.Add(PnlAoInfo)
        PanelAO.Controls.Add(BtnAoKiken)
        PanelAO.Controls.Add(BtnAoShikkaku)
        PanelAO.Controls.Add(BtnAoKnockedOut)
        PanelAO.Controls.Add(PnlAoPenalty)
        PanelAO.Controls.Add(PnlAoScoreSummary)
        PanelAO.Controls.Add(BtnAoVR)
        PanelAO.Controls.Add(DgvAoHistory)
        PanelAO.Controls.Add(LblAoMainScore)
        PanelAO.Controls.Add(BtnAoIppon)
        PanelAO.Controls.Add(BtnAoWazaari)
        PanelAO.Controls.Add(BtnAoYuko)
        PanelAO.Controls.Add(BtnAoShowWinner)
        PanelAO.Controls.Add(BtnAoResetScore)
        PanelAO.Controls.Add(BtnAoSenshu)
        PanelAO.Dock = DockStyle.Bottom
        PanelAO.Location = New Point(21, 388)
        PanelAO.Margin = New Padding(3, 4, 3, 4)
        PanelAO.Name = "PanelAO"
        PanelAO.Size = New Size(858, 346)
        PanelAO.TabIndex = 1
        ' 
        ' LblAoWinner
        ' 
        LblAoWinner.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LblAoWinner.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblAoWinner.ForeColor = SystemColors.ControlLightLight
        LblAoWinner.Location = New Point(706, -3)
        LblAoWinner.Name = "LblAoWinner"
        LblAoWinner.Size = New Size(151, 29)
        LblAoWinner.TabIndex = 21
        LblAoWinner.Text = "WINNER"
        LblAoWinner.TextAlign = ContentAlignment.MiddleCenter
        LblAoWinner.Visible = False
        ' 
        ' AOVR
        ' 
        AOVR.Location = New Point(331, 288)
        AOVR.Margin = New Padding(3, 4, 3, 4)
        AOVR.Name = "AOVR"
        AOVR.Size = New Size(136, 33)
        AOVR.TabIndex = 0
        AOVR.Text = "AO VR Requested"
        ' 
        ' LblAoTitle
        ' 
        LblAoTitle.BackColor = Color.DodgerBlue
        LblAoTitle.Dock = DockStyle.Top
        LblAoTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblAoTitle.ForeColor = Color.White
        LblAoTitle.Location = New Point(0, 0)
        LblAoTitle.Name = "LblAoTitle"
        LblAoTitle.Size = New Size(856, 27)
        LblAoTitle.TabIndex = 0
        LblAoTitle.Text = "AO"
        LblAoTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicAoProfile
        ' 
        PicAoProfile.BorderStyle = BorderStyle.FixedSingle
        PicAoProfile.Location = New Point(11, 40)
        PicAoProfile.Margin = New Padding(3, 4, 3, 4)
        PicAoProfile.Name = "PicAoProfile"
        PicAoProfile.Size = New Size(68, 79)
        PicAoProfile.TabIndex = 1
        PicAoProfile.TabStop = False
        ' 
        ' PnlAoInfo
        ' 
        PnlAoInfo.Controls.Add(LblAoNameTitle)
        PnlAoInfo.Controls.Add(TxtAoNameMain)
        PnlAoInfo.Controls.Add(BtnAoUserIcon1)
        PnlAoInfo.Controls.Add(LblAoTeamTitle)
        PnlAoInfo.Controls.Add(TxtAoTeam)
        PnlAoInfo.Controls.Add(BtnAoTeamSearch)
        PnlAoInfo.Controls.Add(LblAoTeamInfoTitle)
        PnlAoInfo.Controls.Add(TxtAoTeamInfo)
        PnlAoInfo.Controls.Add(PicAoTeamLogo)
        PnlAoInfo.Location = New Point(91, 33)
        PnlAoInfo.Margin = New Padding(3, 4, 3, 4)
        PnlAoInfo.Name = "PnlAoInfo"
        PnlAoInfo.Size = New Size(366, 133)
        PnlAoInfo.TabIndex = 2
        ' 
        ' LblAoNameTitle
        ' 
        LblAoNameTitle.AutoSize = True
        LblAoNameTitle.Location = New Point(0, 11)
        LblAoNameTitle.Name = "LblAoNameTitle"
        LblAoNameTitle.Size = New Size(49, 20)
        LblAoNameTitle.TabIndex = 0
        LblAoNameTitle.Text = "Name"
        ' 
        ' TxtAoNameMain
        ' 
        TxtAoNameMain.Location = New Point(69, 7)
        TxtAoNameMain.Margin = New Padding(3, 4, 3, 4)
        TxtAoNameMain.Name = "TxtAoNameMain"
        TxtAoNameMain.Size = New Size(182, 27)
        TxtAoNameMain.TabIndex = 1
        TxtAoNameMain.Text = ""
        ' 
        ' BtnAoUserIcon1
        ' 
        BtnAoUserIcon1.Location = New Point(257, 5)
        BtnAoUserIcon1.Margin = New Padding(3, 4, 3, 4)
        BtnAoUserIcon1.Name = "BtnAoUserIcon1"
        BtnAoUserIcon1.Size = New Size(29, 33)
        BtnAoUserIcon1.TabIndex = 2
        BtnAoUserIcon1.Text = "👤"
        ' 
        ' LblAoTeamTitle
        ' 
        LblAoTeamTitle.AutoSize = True
        LblAoTeamTitle.Location = New Point(0, 51)
        LblAoTeamTitle.Name = "LblAoTeamTitle"
        LblAoTeamTitle.Size = New Size(45, 20)
        LblAoTeamTitle.TabIndex = 3
        LblAoTeamTitle.Text = "Team"
        ' 
        ' TxtAoTeam
        ' 
        TxtAoTeam.Location = New Point(69, 47)
        TxtAoTeam.Margin = New Padding(3, 4, 3, 4)
        TxtAoTeam.Name = "TxtAoTeam"
        TxtAoTeam.Size = New Size(182, 27)
        TxtAoTeam.TabIndex = 4
        TxtAoTeam.Text = ""
        ' 
        ' BtnAoTeamSearch
        ' 
        BtnAoTeamSearch.Location = New Point(257, 44)
        BtnAoTeamSearch.Margin = New Padding(3, 4, 3, 4)
        BtnAoTeamSearch.Name = "BtnAoTeamSearch"
        BtnAoTeamSearch.Size = New Size(29, 33)
        BtnAoTeamSearch.TabIndex = 5
        BtnAoTeamSearch.Text = "🔍"
        ' 
        ' LblAoTeamInfoTitle
        ' 
        LblAoTeamInfoTitle.AutoSize = True
        LblAoTeamInfoTitle.Location = New Point(0, 91)
        LblAoTeamInfoTitle.Name = "LblAoTeamInfoTitle"
        LblAoTeamInfoTitle.Size = New Size(75, 20)
        LblAoTeamInfoTitle.TabIndex = 6
        LblAoTeamInfoTitle.Text = "Team Info"
        ' 
        ' TxtAoTeamInfo
        ' 
        TxtAoTeamInfo.Location = New Point(69, 87)
        TxtAoTeamInfo.Margin = New Padding(3, 4, 3, 4)
        TxtAoTeamInfo.Name = "TxtAoTeamInfo"
        TxtAoTeamInfo.Size = New Size(114, 27)
        TxtAoTeamInfo.TabIndex = 7
        TxtAoTeamInfo.Text = ""
        ' 
        ' PicAoTeamLogo
        ' 
        PicAoTeamLogo.BorderStyle = BorderStyle.FixedSingle
        PicAoTeamLogo.Location = New Point(310, 15)
        PicAoTeamLogo.Margin = New Padding(3, 4, 3, 4)
        PicAoTeamLogo.Name = "PicAoTeamLogo"
        PicAoTeamLogo.Size = New Size(44, 54)
        PicAoTeamLogo.TabIndex = 10
        PicAoTeamLogo.TabStop = False
        ' 
        ' BtnAoKiken
        ' 
        BtnAoKiken.Location = New Point(11, 173)
        BtnAoKiken.Margin = New Padding(3, 4, 3, 4)
        BtnAoKiken.Name = "BtnAoKiken"
        BtnAoKiken.Size = New Size(80, 40)
        BtnAoKiken.TabIndex = 3
        BtnAoKiken.Text = "Kiken"
        ' 
        ' BtnAoShikkaku
        ' 
        BtnAoShikkaku.Location = New Point(11, 220)
        BtnAoShikkaku.Margin = New Padding(3, 4, 3, 4)
        BtnAoShikkaku.Name = "BtnAoShikkaku"
        BtnAoShikkaku.Size = New Size(80, 40)
        BtnAoShikkaku.TabIndex = 4
        BtnAoShikkaku.Text = "Shikkaku"
        ' 
        ' BtnAoKnockedOut
        ' 
        BtnAoKnockedOut.Location = New Point(11, 267)
        BtnAoKnockedOut.Margin = New Padding(3, 4, 3, 4)
        BtnAoKnockedOut.Name = "BtnAoKnockedOut"
        BtnAoKnockedOut.Size = New Size(80, 53)
        BtnAoKnockedOut.TabIndex = 5
        BtnAoKnockedOut.Text = "Knocked Out"
        ' 
        ' PnlAoPenalty
        ' 
        PnlAoPenalty.BorderStyle = BorderStyle.FixedSingle
        PnlAoPenalty.Controls.Add(LabelAoPenaltyP)
        PnlAoPenalty.Controls.Add(BtnAo1C)
        PnlAoPenalty.Controls.Add(BtnAo2C)
        PnlAoPenalty.Controls.Add(BtnAo3C)
        PnlAoPenalty.Controls.Add(BtnAoHC)
        PnlAoPenalty.Controls.Add(BtnAoH)
        PnlAoPenalty.Location = New Point(103, 173)
        PnlAoPenalty.Margin = New Padding(3, 4, 3, 4)
        PnlAoPenalty.Name = "PnlAoPenalty"
        PnlAoPenalty.Size = New Size(308, 59)
        PnlAoPenalty.TabIndex = 6
        ' 
        ' LabelAoPenaltyP
        ' 
        LabelAoPenaltyP.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        LabelAoPenaltyP.Location = New Point(6, -1)
        LabelAoPenaltyP.Name = "LabelAoPenaltyP"
        LabelAoPenaltyP.Size = New Size(39, 52)
        LabelAoPenaltyP.TabIndex = 0
        LabelAoPenaltyP.Text = "P"
        LabelAoPenaltyP.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnAo1C
        ' 
        BtnAo1C.Location = New Point(51, 7)
        BtnAo1C.Margin = New Padding(3, 4, 3, 4)
        BtnAo1C.Name = "BtnAo1C"
        BtnAo1C.Size = New Size(40, 40)
        BtnAo1C.TabIndex = 1
        BtnAo1C.Text = "1C"
        ' 
        ' BtnAo2C
        ' 
        BtnAo2C.Location = New Point(97, 7)
        BtnAo2C.Margin = New Padding(3, 4, 3, 4)
        BtnAo2C.Name = "BtnAo2C"
        BtnAo2C.Size = New Size(40, 40)
        BtnAo2C.TabIndex = 2
        BtnAo2C.Text = "2C"
        ' 
        ' BtnAo3C
        ' 
        BtnAo3C.Location = New Point(143, 7)
        BtnAo3C.Margin = New Padding(3, 4, 3, 4)
        BtnAo3C.Name = "BtnAo3C"
        BtnAo3C.Size = New Size(40, 40)
        BtnAo3C.TabIndex = 3
        BtnAo3C.Text = "3C"
        ' 
        ' BtnAoHC
        ' 
        BtnAoHC.Location = New Point(189, 7)
        BtnAoHC.Margin = New Padding(3, 4, 3, 4)
        BtnAoHC.Name = "BtnAoHC"
        BtnAoHC.Size = New Size(40, 40)
        BtnAoHC.TabIndex = 4
        BtnAoHC.Text = "HC"
        ' 
        ' BtnAoH
        ' 
        BtnAoH.Location = New Point(234, 7)
        BtnAoH.Margin = New Padding(3, 4, 3, 4)
        BtnAoH.Name = "BtnAoH"
        BtnAoH.Size = New Size(40, 40)
        BtnAoH.TabIndex = 5
        BtnAoH.Text = "H"
        ' 
        ' PnlAoScoreSummary
        ' 
        PnlAoScoreSummary.BorderStyle = BorderStyle.FixedSingle
        PnlAoScoreSummary.Controls.Add(LblAoScoreSummaryTitle)
        PnlAoScoreSummary.Controls.Add(LblAoIpponCount)
        PnlAoScoreSummary.Controls.Add(LblAoWazaariCount)
        PnlAoScoreSummary.Controls.Add(LblAoYukoCount)
        PnlAoScoreSummary.Location = New Point(103, 247)
        PnlAoScoreSummary.Margin = New Padding(3, 4, 3, 4)
        PnlAoScoreSummary.Name = "PnlAoScoreSummary"
        PnlAoScoreSummary.Size = New Size(217, 73)
        PnlAoScoreSummary.TabIndex = 7
        ' 
        ' LblAoScoreSummaryTitle
        ' 
        LblAoScoreSummaryTitle.BackColor = Color.LightGray
        LblAoScoreSummaryTitle.Dock = DockStyle.Top
        LblAoScoreSummaryTitle.Location = New Point(0, 0)
        LblAoScoreSummaryTitle.Name = "LblAoScoreSummaryTitle"
        LblAoScoreSummaryTitle.Size = New Size(215, 27)
        LblAoScoreSummaryTitle.TabIndex = 0
        LblAoScoreSummaryTitle.Text = "Score Summary"
        LblAoScoreSummaryTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoIpponCount
        ' 
        LblAoIpponCount.AutoSize = True
        LblAoIpponCount.Location = New Point(6, 29)
        LblAoIpponCount.Name = "LblAoIpponCount"
        LblAoIpponCount.Size = New Size(64, 20)
        LblAoIpponCount.TabIndex = 1
        LblAoIpponCount.Text = "Ippon  0"
        ' 
        ' LblAoWazaariCount
        ' 
        LblAoWazaariCount.AutoSize = True
        LblAoWazaariCount.Location = New Point(80, 31)
        LblAoWazaariCount.Name = "LblAoWazaariCount"
        LblAoWazaariCount.Size = New Size(84, 20)
        LblAoWazaariCount.TabIndex = 2
        LblAoWazaariCount.Text = "Waza-ari  0"
        ' 
        ' LblAoYukoCount
        ' 
        LblAoYukoCount.AutoSize = True
        LblAoYukoCount.Location = New Point(6, 49)
        LblAoYukoCount.Name = "LblAoYukoCount"
        LblAoYukoCount.Size = New Size(57, 20)
        LblAoYukoCount.TabIndex = 3
        LblAoYukoCount.Text = "Yuko  0"
        ' 
        ' BtnAoVR
        ' 
        BtnAoVR.Location = New Point(331, 247)
        BtnAoVR.Margin = New Padding(3, 4, 3, 4)
        BtnAoVR.Name = "BtnAoVR"
        BtnAoVR.Size = New Size(136, 33)
        BtnAoVR.TabIndex = 8
        BtnAoVR.Text = "VR"
        ' 
        ' DgvAoHistory
        ' 
        DgvAoHistory.BackgroundColor = Color.White
        DgvAoHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvAoHistory.Columns.AddRange(New DataGridViewColumn() {ColNoAo, ColTimerAo, ColTypeAo, ColActionAo})
        DgvAoHistory.Location = New Point(480, 33)
        DgvAoHistory.Margin = New Padding(3, 4, 3, 4)
        DgvAoHistory.Name = "DgvAoHistory"
        DgvAoHistory.RowHeadersVisible = False
        DgvAoHistory.RowHeadersWidth = 51
        DgvAoHistory.Size = New Size(263, 227)
        DgvAoHistory.TabIndex = 9
        ' 
        ' ColNoAo
        ' 
        ColNoAo.HeaderText = "No"
        ColNoAo.MinimumWidth = 6
        ColNoAo.Name = "ColNoAo"
        ColNoAo.Width = 35
        ' 
        ' ColTimerAo
        ' 
        ColTimerAo.HeaderText = "Timer"
        ColTimerAo.MinimumWidth = 6
        ColTimerAo.Name = "ColTimerAo"
        ColTimerAo.Width = 50
        ' 
        ' ColTypeAo
        ' 
        ColTypeAo.HeaderText = "Type"
        ColTypeAo.MinimumWidth = 6
        ColTypeAo.Name = "ColTypeAo"
        ColTypeAo.Width = 65
        ' 
        ' ColActionAo
        ' 
        ColActionAo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColActionAo.HeaderText = ""
        ColActionAo.MinimumWidth = 6
        ColActionAo.Name = "ColActionAo"
        ' 
        ' LblAoMainScore
        ' 
        LblAoMainScore.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
        LblAoMainScore.Location = New Point(720, 40)
        LblAoMainScore.Name = "LblAoMainScore"
        LblAoMainScore.Size = New Size(133, 80)
        LblAoMainScore.TabIndex = 10
        LblAoMainScore.Text = "0"
        LblAoMainScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnAoIppon
        ' 
        BtnAoIppon.BackColor = Color.LightCyan
        BtnAoIppon.FlatStyle = FlatStyle.Flat
        BtnAoIppon.Location = New Point(749, 133)
        BtnAoIppon.Margin = New Padding(3, 4, 3, 4)
        BtnAoIppon.Name = "BtnAoIppon"
        BtnAoIppon.Size = New Size(91, 33)
        BtnAoIppon.TabIndex = 11
        BtnAoIppon.Text = "Ippon 3"
        BtnAoIppon.UseVisualStyleBackColor = False
        ' 
        ' BtnAoWazaari
        ' 
        BtnAoWazaari.BackColor = Color.LightCyan
        BtnAoWazaari.FlatStyle = FlatStyle.Flat
        BtnAoWazaari.Location = New Point(749, 180)
        BtnAoWazaari.Margin = New Padding(3, 4, 3, 4)
        BtnAoWazaari.Name = "BtnAoWazaari"
        BtnAoWazaari.Size = New Size(91, 33)
        BtnAoWazaari.TabIndex = 12
        BtnAoWazaari.Text = "Waza-ari 2"
        BtnAoWazaari.UseVisualStyleBackColor = False
        ' 
        ' BtnAoYuko
        ' 
        BtnAoYuko.BackColor = Color.LightCyan
        BtnAoYuko.FlatStyle = FlatStyle.Flat
        BtnAoYuko.Location = New Point(749, 227)
        BtnAoYuko.Margin = New Padding(3, 4, 3, 4)
        BtnAoYuko.Name = "BtnAoYuko"
        BtnAoYuko.Size = New Size(91, 33)
        BtnAoYuko.TabIndex = 13
        BtnAoYuko.Text = "Yuko 1"
        BtnAoYuko.UseVisualStyleBackColor = False
        ' 
        ' BtnAoShowWinner
        ' 
        BtnAoShowWinner.Location = New Point(480, 275)
        BtnAoShowWinner.Margin = New Padding(3, 4, 3, 4)
        BtnAoShowWinner.Name = "BtnAoShowWinner"
        BtnAoShowWinner.Size = New Size(91, 60)
        BtnAoShowWinner.TabIndex = 14
        BtnAoShowWinner.Text = "Show Winner"
        ' 
        ' BtnAoResetScore
        ' 
        BtnAoResetScore.Location = New Point(600, 280)
        BtnAoResetScore.Margin = New Padding(3, 4, 3, 4)
        BtnAoResetScore.Name = "BtnAoResetScore"
        BtnAoResetScore.Size = New Size(91, 40)
        BtnAoResetScore.TabIndex = 15
        BtnAoResetScore.Text = "Reset Score"
        ' 
        ' BtnAoSenshu
        ' 
        BtnAoSenshu.Location = New Point(720, 280)
        BtnAoSenshu.Margin = New Padding(3, 4, 3, 4)
        BtnAoSenshu.Name = "BtnAoSenshu"
        BtnAoSenshu.Size = New Size(91, 40)
        BtnAoSenshu.TabIndex = 16
        BtnAoSenshu.Text = "Senshu"
        ' 
        ' PanelAKA
        ' 
        PanelAKA.BackColor = Color.White
        PanelAKA.BorderStyle = BorderStyle.FixedSingle
        PanelAKA.Controls.Add(DataGridView1)
        PanelAKA.Controls.Add(LblAkaWinner)
        PanelAKA.Controls.Add(BtnAkaKiken)
        PanelAKA.Controls.Add(AKAVR)
        PanelAKA.Controls.Add(LblAkaTitle)
        PanelAKA.Controls.Add(PicAkaProfile)
        PanelAKA.Controls.Add(PnlAkaInfo)
        PanelAKA.Controls.Add(BtnAkaShikkaku)
        PanelAKA.Controls.Add(BtnAkaKnockedOut)
        PanelAKA.Controls.Add(PnlAkaPenalty)
        PanelAKA.Controls.Add(PnlAkaScoreSummary)
        PanelAKA.Controls.Add(BtnAkaVR)
        PanelAKA.Controls.Add(DgvAkaHistory)
        PanelAKA.Controls.Add(LblAkaMainScore)
        PanelAKA.Controls.Add(BtnAkaIppon)
        PanelAKA.Controls.Add(BtnAkaWazaari)
        PanelAKA.Controls.Add(BtnAkaYuko)
        PanelAKA.Controls.Add(BtnAkaShowWinner)
        PanelAKA.Controls.Add(BtnAkaResetScore)
        PanelAKA.Controls.Add(BtnAkaSenshu)
        PanelAKA.Dock = DockStyle.Top
        PanelAKA.Location = New Point(21, 25)
        PanelAKA.Margin = New Padding(3, 4, 3, 4)
        PanelAKA.Name = "PanelAKA"
        PanelAKA.Size = New Size(858, 346)
        PanelAKA.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(635, 344)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(299, 188)
        DataGridView1.TabIndex = 21
        ' 
        ' LblAkaWinner
        ' 
        LblAkaWinner.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LblAkaWinner.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblAkaWinner.ForeColor = SystemColors.ControlLightLight
        LblAkaWinner.Location = New Point(706, -1)
        LblAkaWinner.Name = "LblAkaWinner"
        LblAkaWinner.Size = New Size(151, 28)
        LblAkaWinner.TabIndex = 20
        LblAkaWinner.Text = "WINNER"
        LblAkaWinner.TextAlign = ContentAlignment.MiddleCenter
        LblAkaWinner.Visible = False
        ' 
        ' BtnAkaKiken
        ' 
        BtnAkaKiken.Location = New Point(11, 172)
        BtnAkaKiken.Margin = New Padding(3, 4, 3, 4)
        BtnAkaKiken.Name = "BtnAkaKiken"
        BtnAkaKiken.Size = New Size(80, 40)
        BtnAkaKiken.TabIndex = 17
        BtnAkaKiken.Text = "Kiken"
        ' 
        ' AKAVR
        ' 
        AKAVR.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AKAVR.Location = New Point(331, 288)
        AKAVR.Margin = New Padding(3, 4, 3, 4)
        AKAVR.Name = "AKAVR"
        AKAVR.Size = New Size(136, 33)
        AKAVR.TabIndex = 18
        AKAVR.Text = "AKA VR Requested"
        ' 
        ' LblAkaTitle
        ' 
        LblAkaTitle.BackColor = Color.Crimson
        LblAkaTitle.Dock = DockStyle.Top
        LblAkaTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblAkaTitle.ForeColor = Color.White
        LblAkaTitle.Location = New Point(0, 0)
        LblAkaTitle.Name = "LblAkaTitle"
        LblAkaTitle.Size = New Size(856, 27)
        LblAkaTitle.TabIndex = 0
        LblAkaTitle.Text = "AKA"
        LblAkaTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicAkaProfile
        ' 
        PicAkaProfile.BorderStyle = BorderStyle.FixedSingle
        PicAkaProfile.Location = New Point(11, 40)
        PicAkaProfile.Margin = New Padding(3, 4, 3, 4)
        PicAkaProfile.Name = "PicAkaProfile"
        PicAkaProfile.Size = New Size(68, 79)
        PicAkaProfile.TabIndex = 1
        PicAkaProfile.TabStop = False
        ' 
        ' PnlAkaInfo
        ' 
        PnlAkaInfo.Controls.Add(LblAkaNameTitle)
        PnlAkaInfo.Controls.Add(TxtAkaNameMain)
        PnlAkaInfo.Controls.Add(BtnAkaUserIcon1)
        PnlAkaInfo.Controls.Add(LblAkaTeamTitle)
        PnlAkaInfo.Controls.Add(TxtAkaTeam)
        PnlAkaInfo.Controls.Add(BtnAkaTeamSearch)
        PnlAkaInfo.Controls.Add(LblAkaTeamInfoTitle)
        PnlAkaInfo.Controls.Add(TxtAkaTeamInfo)
        PnlAkaInfo.Controls.Add(PicAkaTeamLogo)
        PnlAkaInfo.Location = New Point(91, 33)
        PnlAkaInfo.Margin = New Padding(3, 4, 3, 4)
        PnlAkaInfo.Name = "PnlAkaInfo"
        PnlAkaInfo.Size = New Size(366, 133)
        PnlAkaInfo.TabIndex = 2
        ' 
        ' LblAkaNameTitle
        ' 
        LblAkaNameTitle.AutoSize = True
        LblAkaNameTitle.Location = New Point(0, 11)
        LblAkaNameTitle.Name = "LblAkaNameTitle"
        LblAkaNameTitle.Size = New Size(49, 20)
        LblAkaNameTitle.TabIndex = 0
        LblAkaNameTitle.Text = "Name"
        ' 
        ' TxtAkaNameMain
        ' 
        TxtAkaNameMain.Location = New Point(69, 7)
        TxtAkaNameMain.Margin = New Padding(3, 4, 3, 4)
        TxtAkaNameMain.Name = "TxtAkaNameMain"
        TxtAkaNameMain.Size = New Size(182, 27)
        TxtAkaNameMain.TabIndex = 1
        TxtAkaNameMain.Text = ""
        ' 
        ' BtnAkaUserIcon1
        ' 
        BtnAkaUserIcon1.Location = New Point(257, 5)
        BtnAkaUserIcon1.Margin = New Padding(3, 4, 3, 4)
        BtnAkaUserIcon1.Name = "BtnAkaUserIcon1"
        BtnAkaUserIcon1.Size = New Size(29, 33)
        BtnAkaUserIcon1.TabIndex = 10
        BtnAkaUserIcon1.Text = "👤"
        ' 
        ' LblAkaTeamTitle
        ' 
        LblAkaTeamTitle.AutoSize = True
        LblAkaTeamTitle.Location = New Point(0, 51)
        LblAkaTeamTitle.Name = "LblAkaTeamTitle"
        LblAkaTeamTitle.Size = New Size(45, 20)
        LblAkaTeamTitle.TabIndex = 3
        LblAkaTeamTitle.Text = "Team"
        ' 
        ' TxtAkaTeam
        ' 
        TxtAkaTeam.Location = New Point(69, 47)
        TxtAkaTeam.Margin = New Padding(3, 4, 3, 4)
        TxtAkaTeam.Name = "TxtAkaTeam"
        TxtAkaTeam.Size = New Size(182, 27)
        TxtAkaTeam.TabIndex = 4
        TxtAkaTeam.Text = ""
        ' 
        ' BtnAkaTeamSearch
        ' 
        BtnAkaTeamSearch.Location = New Point(257, 44)
        BtnAkaTeamSearch.Margin = New Padding(3, 4, 3, 4)
        BtnAkaTeamSearch.Name = "BtnAkaTeamSearch"
        BtnAkaTeamSearch.Size = New Size(29, 33)
        BtnAkaTeamSearch.TabIndex = 5
        BtnAkaTeamSearch.Text = "🔍"
        ' 
        ' LblAkaTeamInfoTitle
        ' 
        LblAkaTeamInfoTitle.AutoSize = True
        LblAkaTeamInfoTitle.Location = New Point(0, 91)
        LblAkaTeamInfoTitle.Name = "LblAkaTeamInfoTitle"
        LblAkaTeamInfoTitle.Size = New Size(75, 20)
        LblAkaTeamInfoTitle.TabIndex = 6
        LblAkaTeamInfoTitle.Text = "Team Info"
        ' 
        ' TxtAkaTeamInfo
        ' 
        TxtAkaTeamInfo.Location = New Point(69, 87)
        TxtAkaTeamInfo.Margin = New Padding(3, 4, 3, 4)
        TxtAkaTeamInfo.Name = "TxtAkaTeamInfo"
        TxtAkaTeamInfo.Size = New Size(114, 27)
        TxtAkaTeamInfo.TabIndex = 7
        TxtAkaTeamInfo.Text = ""
        ' 
        ' PicAkaTeamLogo
        ' 
        PicAkaTeamLogo.BorderStyle = BorderStyle.FixedSingle
        PicAkaTeamLogo.Location = New Point(310, 15)
        PicAkaTeamLogo.Margin = New Padding(3, 4, 3, 4)
        PicAkaTeamLogo.Name = "PicAkaTeamLogo"
        PicAkaTeamLogo.Size = New Size(44, 54)
        PicAkaTeamLogo.TabIndex = 12
        PicAkaTeamLogo.TabStop = False
        ' 
        ' BtnAkaShikkaku
        ' 
        BtnAkaShikkaku.Location = New Point(11, 220)
        BtnAkaShikkaku.Margin = New Padding(3, 4, 3, 4)
        BtnAkaShikkaku.Name = "BtnAkaShikkaku"
        BtnAkaShikkaku.Size = New Size(80, 40)
        BtnAkaShikkaku.TabIndex = 4
        BtnAkaShikkaku.Text = "Shikkaku"
        ' 
        ' BtnAkaKnockedOut
        ' 
        BtnAkaKnockedOut.Location = New Point(11, 267)
        BtnAkaKnockedOut.Margin = New Padding(3, 4, 3, 4)
        BtnAkaKnockedOut.Name = "BtnAkaKnockedOut"
        BtnAkaKnockedOut.Size = New Size(80, 53)
        BtnAkaKnockedOut.TabIndex = 5
        BtnAkaKnockedOut.Text = "Knocked Out"
        ' 
        ' PnlAkaPenalty
        ' 
        PnlAkaPenalty.BorderStyle = BorderStyle.FixedSingle
        PnlAkaPenalty.Controls.Add(Label1)
        PnlAkaPenalty.Controls.Add(BtnAka1C)
        PnlAkaPenalty.Controls.Add(BtnAka2C)
        PnlAkaPenalty.Controls.Add(BtnAka3C)
        PnlAkaPenalty.Controls.Add(BtnAkaHC)
        PnlAkaPenalty.Controls.Add(BtnAkaH)
        PnlAkaPenalty.Location = New Point(103, 173)
        PnlAkaPenalty.Margin = New Padding(3, 4, 3, 4)
        PnlAkaPenalty.Name = "PnlAkaPenalty"
        PnlAkaPenalty.Size = New Size(308, 59)
        PnlAkaPenalty.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 52)
        Label1.TabIndex = 18
        Label1.Text = "P"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnAka1C
        ' 
        BtnAka1C.Location = New Point(51, 7)
        BtnAka1C.Margin = New Padding(3, 4, 3, 4)
        BtnAka1C.Name = "BtnAka1C"
        BtnAka1C.Size = New Size(40, 40)
        BtnAka1C.TabIndex = 1
        BtnAka1C.Text = "1C"
        ' 
        ' BtnAka2C
        ' 
        BtnAka2C.Location = New Point(97, 7)
        BtnAka2C.Margin = New Padding(3, 4, 3, 4)
        BtnAka2C.Name = "BtnAka2C"
        BtnAka2C.Size = New Size(40, 40)
        BtnAka2C.TabIndex = 2
        BtnAka2C.Text = "2C"
        ' 
        ' BtnAka3C
        ' 
        BtnAka3C.Location = New Point(143, 7)
        BtnAka3C.Margin = New Padding(3, 4, 3, 4)
        BtnAka3C.Name = "BtnAka3C"
        BtnAka3C.Size = New Size(40, 40)
        BtnAka3C.TabIndex = 3
        BtnAka3C.Text = "3C"
        ' 
        ' BtnAkaHC
        ' 
        BtnAkaHC.Location = New Point(189, 7)
        BtnAkaHC.Margin = New Padding(3, 4, 3, 4)
        BtnAkaHC.Name = "BtnAkaHC"
        BtnAkaHC.Size = New Size(40, 40)
        BtnAkaHC.TabIndex = 4
        BtnAkaHC.Text = "HC"
        ' 
        ' BtnAkaH
        ' 
        BtnAkaH.Location = New Point(234, 7)
        BtnAkaH.Margin = New Padding(3, 4, 3, 4)
        BtnAkaH.Name = "BtnAkaH"
        BtnAkaH.Size = New Size(40, 40)
        BtnAkaH.TabIndex = 5
        BtnAkaH.Text = "H"
        ' 
        ' PnlAkaScoreSummary
        ' 
        PnlAkaScoreSummary.BorderStyle = BorderStyle.FixedSingle
        PnlAkaScoreSummary.Controls.Add(LblAkaScoreSummaryTitle)
        PnlAkaScoreSummary.Controls.Add(LblAkaIpponCount)
        PnlAkaScoreSummary.Controls.Add(LblAkaWazaariCount)
        PnlAkaScoreSummary.Controls.Add(LblAkaYukoCount)
        PnlAkaScoreSummary.Location = New Point(103, 247)
        PnlAkaScoreSummary.Margin = New Padding(3, 4, 3, 4)
        PnlAkaScoreSummary.Name = "PnlAkaScoreSummary"
        PnlAkaScoreSummary.Size = New Size(217, 73)
        PnlAkaScoreSummary.TabIndex = 7
        ' 
        ' LblAkaScoreSummaryTitle
        ' 
        LblAkaScoreSummaryTitle.BackColor = Color.LightGray
        LblAkaScoreSummaryTitle.Dock = DockStyle.Top
        LblAkaScoreSummaryTitle.Location = New Point(0, 0)
        LblAkaScoreSummaryTitle.Name = "LblAkaScoreSummaryTitle"
        LblAkaScoreSummaryTitle.Size = New Size(215, 27)
        LblAkaScoreSummaryTitle.TabIndex = 0
        LblAkaScoreSummaryTitle.Text = "Score Summary"
        LblAkaScoreSummaryTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaIpponCount
        ' 
        LblAkaIpponCount.AutoSize = True
        LblAkaIpponCount.Location = New Point(6, 28)
        LblAkaIpponCount.Name = "LblAkaIpponCount"
        LblAkaIpponCount.Size = New Size(64, 20)
        LblAkaIpponCount.TabIndex = 1
        LblAkaIpponCount.Text = "Ippon  0"
        ' 
        ' LblAkaWazaariCount
        ' 
        LblAkaWazaariCount.AutoSize = True
        LblAkaWazaariCount.Location = New Point(80, 29)
        LblAkaWazaariCount.Name = "LblAkaWazaariCount"
        LblAkaWazaariCount.Size = New Size(84, 20)
        LblAkaWazaariCount.TabIndex = 2
        LblAkaWazaariCount.Text = "Waza-ari  0"
        ' 
        ' LblAkaYukoCount
        ' 
        LblAkaYukoCount.AutoSize = True
        LblAkaYukoCount.Location = New Point(6, 51)
        LblAkaYukoCount.Name = "LblAkaYukoCount"
        LblAkaYukoCount.Size = New Size(57, 20)
        LblAkaYukoCount.TabIndex = 3
        LblAkaYukoCount.Text = "Yuko  0"
        ' 
        ' BtnAkaVR
        ' 
        BtnAkaVR.Location = New Point(331, 247)
        BtnAkaVR.Margin = New Padding(3, 4, 3, 4)
        BtnAkaVR.Name = "BtnAkaVR"
        BtnAkaVR.Size = New Size(136, 33)
        BtnAkaVR.TabIndex = 8
        BtnAkaVR.Text = "VR"
        ' 
        ' DgvAkaHistory
        ' 
        DgvAkaHistory.BackgroundColor = Color.White
        DgvAkaHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvAkaHistory.Columns.AddRange(New DataGridViewColumn() {ColNo, ColTimer, ColType, ColActionAka})
        DgvAkaHistory.Location = New Point(480, 33)
        DgvAkaHistory.Margin = New Padding(3, 4, 3, 4)
        DgvAkaHistory.Name = "DgvAkaHistory"
        DgvAkaHistory.RowHeadersVisible = False
        DgvAkaHistory.RowHeadersWidth = 51
        DgvAkaHistory.Size = New Size(263, 227)
        DgvAkaHistory.TabIndex = 10
        ' 
        ' ColNo
        ' 
        ColNo.HeaderText = "No"
        ColNo.MinimumWidth = 6
        ColNo.Name = "ColNo"
        ColNo.Width = 35
        ' 
        ' ColTimer
        ' 
        ColTimer.HeaderText = "Timer"
        ColTimer.MinimumWidth = 6
        ColTimer.Name = "ColTimer"
        ColTimer.Width = 50
        ' 
        ' ColType
        ' 
        ColType.HeaderText = "Type"
        ColType.MinimumWidth = 6
        ColType.Name = "ColType"
        ColType.Width = 65
        ' 
        ' ColActionAka
        ' 
        ColActionAka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColActionAka.HeaderText = ""
        ColActionAka.MinimumWidth = 6
        ColActionAka.Name = "ColActionAka"
        ' 
        ' LblAkaMainScore
        ' 
        LblAkaMainScore.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold)
        LblAkaMainScore.Location = New Point(715, 44)
        LblAkaMainScore.Name = "LblAkaMainScore"
        LblAkaMainScore.Size = New Size(125, 80)
        LblAkaMainScore.TabIndex = 11
        LblAkaMainScore.Text = "0"
        LblAkaMainScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnAkaIppon
        ' 
        BtnAkaIppon.BackColor = Color.MistyRose
        BtnAkaIppon.FlatStyle = FlatStyle.Flat
        BtnAkaIppon.Location = New Point(749, 132)
        BtnAkaIppon.Margin = New Padding(3, 4, 3, 4)
        BtnAkaIppon.Name = "BtnAkaIppon"
        BtnAkaIppon.Size = New Size(91, 33)
        BtnAkaIppon.TabIndex = 12
        BtnAkaIppon.Text = "Ippon 3"
        BtnAkaIppon.UseVisualStyleBackColor = False
        ' 
        ' BtnAkaWazaari
        ' 
        BtnAkaWazaari.BackColor = Color.MistyRose
        BtnAkaWazaari.FlatStyle = FlatStyle.Flat
        BtnAkaWazaari.Location = New Point(749, 179)
        BtnAkaWazaari.Margin = New Padding(3, 4, 3, 4)
        BtnAkaWazaari.Name = "BtnAkaWazaari"
        BtnAkaWazaari.Size = New Size(91, 33)
        BtnAkaWazaari.TabIndex = 13
        BtnAkaWazaari.Text = "Waza-ari 2"
        BtnAkaWazaari.UseVisualStyleBackColor = False
        ' 
        ' BtnAkaYuko
        ' 
        BtnAkaYuko.BackColor = Color.MistyRose
        BtnAkaYuko.FlatStyle = FlatStyle.Flat
        BtnAkaYuko.Location = New Point(749, 227)
        BtnAkaYuko.Margin = New Padding(3, 4, 3, 4)
        BtnAkaYuko.Name = "BtnAkaYuko"
        BtnAkaYuko.Size = New Size(91, 33)
        BtnAkaYuko.TabIndex = 14
        BtnAkaYuko.Text = "Yuko 1"
        BtnAkaYuko.UseVisualStyleBackColor = False
        ' 
        ' BtnAkaShowWinner
        ' 
        BtnAkaShowWinner.Location = New Point(480, 271)
        BtnAkaShowWinner.Margin = New Padding(3, 4, 3, 4)
        BtnAkaShowWinner.Name = "BtnAkaShowWinner"
        BtnAkaShowWinner.Size = New Size(91, 60)
        BtnAkaShowWinner.TabIndex = 15
        BtnAkaShowWinner.Text = "Show Winner"
        ' 
        ' BtnAkaResetScore
        ' 
        BtnAkaResetScore.Location = New Point(600, 280)
        BtnAkaResetScore.Margin = New Padding(3, 4, 3, 4)
        BtnAkaResetScore.Name = "BtnAkaResetScore"
        BtnAkaResetScore.Size = New Size(91, 40)
        BtnAkaResetScore.TabIndex = 16
        BtnAkaResetScore.Text = "Reset Score"
        ' 
        ' BtnAkaSenshu
        ' 
        BtnAkaSenshu.Location = New Point(720, 280)
        BtnAkaSenshu.Margin = New Padding(3, 4, 3, 4)
        BtnAkaSenshu.Name = "BtnAkaSenshu"
        BtnAkaSenshu.Size = New Size(91, 40)
        BtnAkaSenshu.TabIndex = 17
        BtnAkaSenshu.Text = "Senshu"
        ' 
        ' PanelSidebarRight
        ' 
        PanelSidebarRight.BackColor = Color.WhiteSmoke
        PanelSidebarRight.BorderStyle = BorderStyle.FixedSingle
        PanelSidebarRight.Controls.Add(BtnSendMatchInfo)
        PanelSidebarRight.Controls.Add(BtnSaveWinPoint)
        PanelSidebarRight.Controls.Add(ResetTimer)
        PanelSidebarRight.Controls.Add(LblScboardType)
        PanelSidebarRight.Controls.Add(LblSenshuStyle)
        PanelSidebarRight.Controls.Add(LblAdjustScboard)
        PanelSidebarRight.Controls.Add(CboAdjustPlayer)
        PanelSidebarRight.Controls.Add(NumAdjustSize)
        PanelSidebarRight.Controls.Add(BtnAdjustR)
        PanelSidebarRight.Controls.Add(BtnAdjustMin)
        PanelSidebarRight.Controls.Add(BtnAdjustPlus)
        PanelSidebarRight.Controls.Add(TabMatchDetail)
        PanelSidebarRight.Controls.Add(LblWinPoint)
        PanelSidebarRight.Controls.Add(NumWinPoint)
        PanelSidebarRight.Controls.Add(BtnEditWinPoint)
        PanelSidebarRight.Controls.Add(LblTatami)
        PanelSidebarRight.Controls.Add(NumTatami)
        PanelSidebarRight.Controls.Add(BtnSwitchPosition)
        PanelSidebarRight.Controls.Add(PnlWaitingTimer)
        PanelSidebarRight.Controls.Add(PanelMatchTimer)
        PanelSidebarRight.Dock = DockStyle.Right
        PanelSidebarRight.Location = New Point(900, 53)
        PanelSidebarRight.Margin = New Padding(3, 4, 3, 4)
        PanelSidebarRight.Name = "PanelSidebarRight"
        PanelSidebarRight.Size = New Size(300, 759)
        PanelSidebarRight.TabIndex = 2
        ' 
        ' BtnSendMatchInfo
        ' 
        BtnSendMatchInfo.Font = New Font("Segoe UI", 35.0F)
        BtnSendMatchInfo.Location = New Point(246, 171)
        BtnSendMatchInfo.Name = "BtnSendMatchInfo"
        BtnSendMatchInfo.Size = New Size(41, 86)
        BtnSendMatchInfo.TabIndex = 18
        BtnSendMatchInfo.Text = "⬆️"
        BtnSendMatchInfo.UseVisualStyleBackColor = True
        ' 
        ' BtnSaveWinPoint
        ' 
        BtnSaveWinPoint.Location = New Point(191, 269)
        BtnSaveWinPoint.Margin = New Padding(3, 4, 3, 4)
        BtnSaveWinPoint.Name = "BtnSaveWinPoint"
        BtnSaveWinPoint.Size = New Size(50, 31)
        BtnSaveWinPoint.TabIndex = 17
        BtnSaveWinPoint.Text = "Save"
        BtnSaveWinPoint.UseVisualStyleBackColor = True
        ' 
        ' ResetTimer
        ' 
        ResetTimer.BackColor = Color.Gold
        ResetTimer.FlatStyle = FlatStyle.Flat
        ResetTimer.Location = New Point(29, 677)
        ResetTimer.Margin = New Padding(3, 4, 3, 4)
        ResetTimer.Name = "ResetTimer"
        ResetTimer.Size = New Size(237, 37)
        ResetTimer.TabIndex = 10
        ResetTimer.Text = "Reset Timer"
        ResetTimer.UseVisualStyleBackColor = False
        ' 
        ' LblScboardType
        ' 
        LblScboardType.AutoSize = True
        LblScboardType.Font = New Font("Segoe UI", 8.25F)
        LblScboardType.Location = New Point(10, 12)
        LblScboardType.Name = "LblScboardType"
        LblScboardType.Size = New Size(93, 19)
        LblScboardType.TabIndex = 0
        LblScboardType.Text = "SCBoard Type"
        ' 
        ' LblSenshuStyle
        ' 
        LblSenshuStyle.AutoSize = True
        LblSenshuStyle.Font = New Font("Segoe UI", 8.25F)
        LblSenshuStyle.Location = New Point(150, 12)
        LblSenshuStyle.Name = "LblSenshuStyle"
        LblSenshuStyle.Size = New Size(86, 19)
        LblSenshuStyle.TabIndex = 1
        LblSenshuStyle.Text = "Senshu Style"
        ' 
        ' LblAdjustScboard
        ' 
        LblAdjustScboard.AutoSize = True
        LblAdjustScboard.Font = New Font("Segoe UI", 8.25F)
        LblAdjustScboard.Location = New Point(10, 75)
        LblAdjustScboard.Name = "LblAdjustScboard"
        LblAdjustScboard.Size = New Size(156, 19)
        LblAdjustScboard.TabIndex = 2
        LblAdjustScboard.Text = "Adjust Scboard Text Size"
        ' 
        ' CboAdjustPlayer
        ' 
        CboAdjustPlayer.FormattingEnabled = True
        CboAdjustPlayer.Items.AddRange(New Object() {"Player Name", "Team Name"})
        CboAdjustPlayer.Location = New Point(13, 100)
        CboAdjustPlayer.Margin = New Padding(3, 4, 3, 4)
        CboAdjustPlayer.Name = "CboAdjustPlayer"
        CboAdjustPlayer.Size = New Size(90, 28)
        CboAdjustPlayer.TabIndex = 3
        CboAdjustPlayer.Text = "Player Name"
        ' 
        ' NumAdjustSize
        ' 
        NumAdjustSize.DecimalPlaces = 1
        NumAdjustSize.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        NumAdjustSize.Location = New Point(110, 100)
        NumAdjustSize.Margin = New Padding(3, 4, 3, 4)
        NumAdjustSize.Name = "NumAdjustSize"
        NumAdjustSize.Size = New Size(50, 27)
        NumAdjustSize.TabIndex = 4
        NumAdjustSize.Value = New Decimal(New Integer() {15, 0, 0, 65536})
        ' 
        ' BtnAdjustR
        ' 
        BtnAdjustR.Location = New Point(165, 97)
        BtnAdjustR.Margin = New Padding(3, 4, 3, 4)
        BtnAdjustR.Name = "BtnAdjustR"
        BtnAdjustR.Size = New Size(30, 31)
        BtnAdjustR.TabIndex = 5
        BtnAdjustR.Text = "R"
        BtnAdjustR.UseVisualStyleBackColor = True
        ' 
        ' BtnAdjustMin
        ' 
        BtnAdjustMin.Location = New Point(200, 97)
        BtnAdjustMin.Margin = New Padding(3, 4, 3, 4)
        BtnAdjustMin.Name = "BtnAdjustMin"
        BtnAdjustMin.Size = New Size(30, 31)
        BtnAdjustMin.TabIndex = 6
        BtnAdjustMin.Text = "-"
        BtnAdjustMin.UseVisualStyleBackColor = True
        ' 
        ' BtnAdjustPlus
        ' 
        BtnAdjustPlus.Location = New Point(235, 97)
        BtnAdjustPlus.Margin = New Padding(3, 4, 3, 4)
        BtnAdjustPlus.Name = "BtnAdjustPlus"
        BtnAdjustPlus.Size = New Size(30, 31)
        BtnAdjustPlus.TabIndex = 7
        BtnAdjustPlus.Text = "+"
        BtnAdjustPlus.UseVisualStyleBackColor = True
        ' 
        ' TabMatchDetail
        ' 
        TabMatchDetail.Controls.Add(PageMatchDetail)
        TabMatchDetail.Controls.Add(PageMatchLogo)
        TabMatchDetail.Location = New Point(13, 144)
        TabMatchDetail.Margin = New Padding(3, 4, 3, 4)
        TabMatchDetail.Name = "TabMatchDetail"
        TabMatchDetail.SelectedIndex = 0
        TabMatchDetail.Size = New Size(228, 119)
        TabMatchDetail.TabIndex = 8
        ' 
        ' PageMatchDetail
        ' 
        PageMatchDetail.Controls.Add(TxtMatchDesc)
        PageMatchDetail.Location = New Point(4, 29)
        PageMatchDetail.Margin = New Padding(3, 4, 3, 4)
        PageMatchDetail.Name = "PageMatchDetail"
        PageMatchDetail.Padding = New Padding(3, 4, 3, 4)
        PageMatchDetail.Size = New Size(220, 86)
        PageMatchDetail.TabIndex = 0
        PageMatchDetail.Text = "Match Detail"
        PageMatchDetail.UseVisualStyleBackColor = True
        ' 
        ' TxtMatchDesc
        ' 
        TxtMatchDesc.Dock = DockStyle.Fill
        TxtMatchDesc.ForeColor = Color.Gray
        TxtMatchDesc.Location = New Point(3, 4)
        TxtMatchDesc.Margin = New Padding(3, 4, 3, 4)
        TxtMatchDesc.Multiline = True
        TxtMatchDesc.Name = "TxtMatchDesc"
        TxtMatchDesc.Size = New Size(214, 78)
        TxtMatchDesc.TabIndex = 0
        TxtMatchDesc.Text = "Match Description..."
        ' 
        ' PageMatchLogo
        ' 
        PageMatchLogo.Controls.Add(PicPreviewLogo)
        PageMatchLogo.Controls.Add(BtnSelectLogo)
        PageMatchLogo.Controls.Add(BtnRemoveLogo)
        PageMatchLogo.Location = New Point(4, 29)
        PageMatchLogo.Margin = New Padding(3, 4, 3, 4)
        PageMatchLogo.Name = "PageMatchLogo"
        PageMatchLogo.Padding = New Padding(3, 4, 3, 4)
        PageMatchLogo.Size = New Size(220, 86)
        PageMatchLogo.TabIndex = 1
        PageMatchLogo.Text = "Match Logo"
        PageMatchLogo.UseVisualStyleBackColor = True
        ' 
        ' PicPreviewLogo
        ' 
        PicPreviewLogo.BorderStyle = BorderStyle.FixedSingle
        PicPreviewLogo.Location = New Point(7, 8)
        PicPreviewLogo.Margin = New Padding(3, 4, 3, 4)
        PicPreviewLogo.Name = "PicPreviewLogo"
        PicPreviewLogo.Size = New Size(57, 66)
        PicPreviewLogo.SizeMode = PictureBoxSizeMode.Zoom
        PicPreviewLogo.TabIndex = 0
        PicPreviewLogo.TabStop = False
        ' 
        ' BtnSelectLogo
        ' 
        BtnSelectLogo.Location = New Point(74, 8)
        BtnSelectLogo.Margin = New Padding(3, 4, 3, 4)
        BtnSelectLogo.Name = "BtnSelectLogo"
        BtnSelectLogo.Size = New Size(103, 31)
        BtnSelectLogo.TabIndex = 1
        BtnSelectLogo.Text = "Select Image"
        BtnSelectLogo.UseVisualStyleBackColor = True
        ' 
        ' BtnRemoveLogo
        ' 
        BtnRemoveLogo.Location = New Point(74, 44)
        BtnRemoveLogo.Margin = New Padding(3, 4, 3, 4)
        BtnRemoveLogo.Name = "BtnRemoveLogo"
        BtnRemoveLogo.Size = New Size(103, 31)
        BtnRemoveLogo.TabIndex = 2
        BtnRemoveLogo.Text = "Remove.."
        BtnRemoveLogo.UseVisualStyleBackColor = True
        ' 
        ' LblWinPoint
        ' 
        LblWinPoint.AutoSize = True
        LblWinPoint.Location = New Point(13, 275)
        LblWinPoint.Name = "LblWinPoint"
        LblWinPoint.Size = New Size(75, 20)
        LblWinPoint.TabIndex = 9
        LblWinPoint.Text = "Win. Point"
        ' 
        ' NumWinPoint
        ' 
        NumWinPoint.Location = New Point(85, 272)
        NumWinPoint.Margin = New Padding(3, 4, 3, 4)
        NumWinPoint.Name = "NumWinPoint"
        NumWinPoint.Size = New Size(40, 27)
        NumWinPoint.TabIndex = 10
        NumWinPoint.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' BtnEditWinPoint
        ' 
        BtnEditWinPoint.Location = New Point(135, 269)
        BtnEditWinPoint.Margin = New Padding(3, 4, 3, 4)
        BtnEditWinPoint.Name = "BtnEditWinPoint"
        BtnEditWinPoint.Size = New Size(50, 31)
        BtnEditWinPoint.TabIndex = 11
        BtnEditWinPoint.Text = "Edit"
        BtnEditWinPoint.UseVisualStyleBackColor = True
        ' 
        ' LblTatami
        ' 
        LblTatami.AutoSize = True
        LblTatami.Location = New Point(13, 312)
        LblTatami.Name = "LblTatami"
        LblTatami.Size = New Size(53, 20)
        LblTatami.TabIndex = 12
        LblTatami.Text = "Tatami"
        ' 
        ' NumTatami
        ' 
        NumTatami.Location = New Point(85, 309)
        NumTatami.Margin = New Padding(3, 4, 3, 4)
        NumTatami.Name = "NumTatami"
        NumTatami.Size = New Size(40, 27)
        NumTatami.TabIndex = 13
        NumTatami.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' BtnSwitchPosition
        ' 
        BtnSwitchPosition.Location = New Point(135, 308)
        BtnSwitchPosition.Margin = New Padding(3, 4, 3, 4)
        BtnSwitchPosition.Name = "BtnSwitchPosition"
        BtnSwitchPosition.Size = New Size(101, 31)
        BtnSwitchPosition.TabIndex = 14
        BtnSwitchPosition.Text = "Switch Position"
        BtnSwitchPosition.UseVisualStyleBackColor = True
        ' 
        ' PnlWaitingTimer
        ' 
        PnlWaitingTimer.BackColor = Color.Bisque
        PnlWaitingTimer.BorderStyle = BorderStyle.FixedSingle
        PnlWaitingTimer.Controls.Add(LblWaitingTimerTitle)
        PnlWaitingTimer.Controls.Add(NumWaitMin)
        PnlWaitingTimer.Controls.Add(LblWaitColon)
        PnlWaitingTimer.Controls.Add(NumWaitSec)
        PnlWaitingTimer.Controls.Add(BtnStartWait)
        PnlWaitingTimer.Location = New Point(13, 349)
        PnlWaitingTimer.Margin = New Padding(3, 4, 3, 4)
        PnlWaitingTimer.Name = "PnlWaitingTimer"
        PnlWaitingTimer.Size = New Size(269, 74)
        PnlWaitingTimer.TabIndex = 15
        ' 
        ' LblWaitingTimerTitle
        ' 
        LblWaitingTimerTitle.AutoSize = True
        LblWaitingTimerTitle.Location = New Point(5, 7)
        LblWaitingTimerTitle.Name = "LblWaitingTimerTitle"
        LblWaitingTimerTitle.Size = New Size(213, 20)
        LblWaitingTimerTitle.TabIndex = 0
        LblWaitingTimerTitle.Text = "Waiting Timer (minute second)"
        ' 
        ' NumWaitMin
        ' 
        NumWaitMin.Location = New Point(10, 31)
        NumWaitMin.Margin = New Padding(3, 4, 3, 4)
        NumWaitMin.Name = "NumWaitMin"
        NumWaitMin.Size = New Size(40, 27)
        NumWaitMin.TabIndex = 1
        NumWaitMin.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' LblWaitColon
        ' 
        LblWaitColon.AutoSize = True
        LblWaitColon.Location = New Point(55, 33)
        LblWaitColon.Name = "LblWaitColon"
        LblWaitColon.Size = New Size(12, 20)
        LblWaitColon.TabIndex = 2
        LblWaitColon.Text = ":"
        ' 
        ' NumWaitSec
        ' 
        NumWaitSec.Location = New Point(70, 31)
        NumWaitSec.Margin = New Padding(3, 4, 3, 4)
        NumWaitSec.Name = "NumWaitSec"
        NumWaitSec.Size = New Size(40, 27)
        NumWaitSec.TabIndex = 3
        ' 
        ' BtnStartWait
        ' 
        BtnStartWait.Location = New Point(150, 29)
        BtnStartWait.Margin = New Padding(3, 4, 3, 4)
        BtnStartWait.Name = "BtnStartWait"
        BtnStartWait.Size = New Size(101, 31)
        BtnStartWait.TabIndex = 4
        BtnStartWait.Text = "Start"
        BtnStartWait.UseVisualStyleBackColor = True
        ' 
        ' PanelMatchTimer
        ' 
        PanelMatchTimer.BackColor = Color.WhiteSmoke
        PanelMatchTimer.BorderStyle = BorderStyle.FixedSingle
        PanelMatchTimer.Controls.Add(LblMatchTimerTitle)
        PanelMatchTimer.Controls.Add(BtnTime130)
        PanelMatchTimer.Controls.Add(BtnTime200)
        PanelMatchTimer.Controls.Add(BtnTime300)
        PanelMatchTimer.Controls.Add(NumMatchMin)
        PanelMatchTimer.Controls.Add(LblMatchColon)
        PanelMatchTimer.Controls.Add(NumMatchSec)
        PanelMatchTimer.Controls.Add(PnlYellowTimerBox)
        PanelMatchTimer.Controls.Add(BtnStartScoreboard)
        PanelMatchTimer.Controls.Add(BtnStartTimer)
        PanelMatchTimer.Location = New Point(13, 437)
        PanelMatchTimer.Margin = New Padding(3, 4, 3, 4)
        PanelMatchTimer.Name = "PanelMatchTimer"
        PanelMatchTimer.Size = New Size(269, 231)
        PanelMatchTimer.TabIndex = 16
        ' 
        ' LblMatchTimerTitle
        ' 
        LblMatchTimerTitle.BackColor = Color.Gold
        LblMatchTimerTitle.Dock = DockStyle.Top
        LblMatchTimerTitle.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        LblMatchTimerTitle.Location = New Point(0, 0)
        LblMatchTimerTitle.Name = "LblMatchTimerTitle"
        LblMatchTimerTitle.Size = New Size(267, 25)
        LblMatchTimerTitle.TabIndex = 0
        LblMatchTimerTitle.Text = "Match Timer (minute:second)"
        LblMatchTimerTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnTime130
        ' 
        BtnTime130.Location = New Point(15, 37)
        BtnTime130.Margin = New Padding(3, 4, 3, 4)
        BtnTime130.Name = "BtnTime130"
        BtnTime130.Size = New Size(59, 31)
        BtnTime130.TabIndex = 1
        BtnTime130.Text = "1:30"
        BtnTime130.UseVisualStyleBackColor = True
        ' 
        ' BtnTime200
        ' 
        BtnTime200.Location = New Point(85, 37)
        BtnTime200.Margin = New Padding(3, 4, 3, 4)
        BtnTime200.Name = "BtnTime200"
        BtnTime200.Size = New Size(59, 31)
        BtnTime200.TabIndex = 2
        BtnTime200.Text = "2:00"
        BtnTime200.UseVisualStyleBackColor = True
        ' 
        ' BtnTime300
        ' 
        BtnTime300.Location = New Point(155, 37)
        BtnTime300.Margin = New Padding(3, 4, 3, 4)
        BtnTime300.Name = "BtnTime300"
        BtnTime300.Size = New Size(59, 31)
        BtnTime300.TabIndex = 3
        BtnTime300.Text = "3:00"
        BtnTime300.UseVisualStyleBackColor = True
        ' 
        ' NumMatchMin
        ' 
        NumMatchMin.Location = New Point(40, 81)
        NumMatchMin.Margin = New Padding(3, 4, 3, 4)
        NumMatchMin.Name = "NumMatchMin"
        NumMatchMin.Size = New Size(50, 27)
        NumMatchMin.TabIndex = 4
        NumMatchMin.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' LblMatchColon
        ' 
        LblMatchColon.AutoSize = True
        LblMatchColon.Location = New Point(95, 84)
        LblMatchColon.Name = "LblMatchColon"
        LblMatchColon.Size = New Size(12, 20)
        LblMatchColon.TabIndex = 5
        LblMatchColon.Text = ":"
        ' 
        ' NumMatchSec
        ' 
        NumMatchSec.Location = New Point(110, 81)
        NumMatchSec.Margin = New Padding(3, 4, 3, 4)
        NumMatchSec.Name = "NumMatchSec"
        NumMatchSec.Size = New Size(50, 27)
        NumMatchSec.TabIndex = 6
        ' 
        ' PnlYellowTimerBox
        ' 
        PnlYellowTimerBox.BackColor = Color.Gold
        PnlYellowTimerBox.Controls.Add(LblAdjustTimerTitle)
        PnlYellowTimerBox.Controls.Add(LblMatchTimerValue)
        PnlYellowTimerBox.Controls.Add(BtnMatchTimeMinus)
        PnlYellowTimerBox.Controls.Add(BtnMatchTimePlus)
        PnlYellowTimerBox.Location = New Point(10, 125)
        PnlYellowTimerBox.Margin = New Padding(3, 4, 3, 4)
        PnlYellowTimerBox.Name = "PnlYellowTimerBox"
        PnlYellowTimerBox.Size = New Size(248, 51)
        PnlYellowTimerBox.TabIndex = 7
        ' 
        ' LblAdjustTimerTitle
        ' 
        LblAdjustTimerTitle.AutoSize = True
        LblAdjustTimerTitle.Location = New Point(5, 15)
        LblAdjustTimerTitle.Name = "LblAdjustTimerTitle"
        LblAdjustTimerTitle.Size = New Size(93, 20)
        LblAdjustTimerTitle.TabIndex = 0
        LblAdjustTimerTitle.Text = "Adjust Timer"
        ' 
        ' LblMatchTimerValue
        ' 
        LblMatchTimerValue.AutoSize = True
        LblMatchTimerValue.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblMatchTimerValue.Location = New Point(90, 11)
        LblMatchTimerValue.Name = "LblMatchTimerValue"
        LblMatchTimerValue.Size = New Size(70, 28)
        LblMatchTimerValue.TabIndex = 1
        LblMatchTimerValue.Text = "2:00.0"
        ' 
        ' BtnMatchTimeMinus
        ' 
        BtnMatchTimeMinus.Location = New Point(170, 9)
        BtnMatchTimeMinus.Margin = New Padding(3, 4, 3, 4)
        BtnMatchTimeMinus.Name = "BtnMatchTimeMinus"
        BtnMatchTimeMinus.Size = New Size(30, 31)
        BtnMatchTimeMinus.TabIndex = 2
        BtnMatchTimeMinus.Text = "-"
        BtnMatchTimeMinus.UseVisualStyleBackColor = True
        ' 
        ' BtnMatchTimePlus
        ' 
        BtnMatchTimePlus.Location = New Point(205, 9)
        BtnMatchTimePlus.Margin = New Padding(3, 4, 3, 4)
        BtnMatchTimePlus.Name = "BtnMatchTimePlus"
        BtnMatchTimePlus.Size = New Size(30, 31)
        BtnMatchTimePlus.TabIndex = 3
        BtnMatchTimePlus.Text = "+"
        BtnMatchTimePlus.UseVisualStyleBackColor = True
        ' 
        ' BtnStartScoreboard
        ' 
        BtnStartScoreboard.BackColor = Color.PaleGreen
        BtnStartScoreboard.FlatStyle = FlatStyle.Flat
        BtnStartScoreboard.Location = New Point(15, 181)
        BtnStartScoreboard.Margin = New Padding(3, 4, 3, 4)
        BtnStartScoreboard.Name = "BtnStartScoreboard"
        BtnStartScoreboard.Size = New Size(115, 37)
        BtnStartScoreboard.TabIndex = 8
        BtnStartScoreboard.Text = "Start Scoreboard"
        BtnStartScoreboard.UseVisualStyleBackColor = False
        ' 
        ' BtnStartTimer
        ' 
        BtnStartTimer.BackColor = Color.Gold
        BtnStartTimer.FlatStyle = FlatStyle.Flat
        BtnStartTimer.Location = New Point(135, 181)
        BtnStartTimer.Margin = New Padding(3, 4, 3, 4)
        BtnStartTimer.Name = "BtnStartTimer"
        BtnStartTimer.Size = New Size(115, 37)
        BtnStartTimer.TabIndex = 9
        BtnStartTimer.Text = "Start Timer"
        BtnStartTimer.UseVisualStyleBackColor = False
        ' 
        ' BtnResetTimer
        ' 
        BtnResetTimer.Location = New Point(13, 172)
        BtnResetTimer.Name = "BtnResetTimer"
        BtnResetTimer.Size = New Size(206, 28)
        BtnResetTimer.TabIndex = 10
        BtnResetTimer.Text = "Reset Timer"
        BtnResetTimer.UseVisualStyleBackColor = True
        ' 
        ' KumiteMainControl
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1200, 875)
        Controls.Add(PanelMainCenter)
        Controls.Add(PanelSidebarRight)
        Controls.Add(PanelFooter)
        Controls.Add(PanelHeader)
        Margin = New Padding(3, 4, 3, 4)
        Name = "KumiteMainControl"
        Text = "Kumite Main Control"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelFooter.ResumeLayout(False)
        PanelMainCenter.ResumeLayout(False)
        PanelAO.ResumeLayout(False)
        CType(PicAoProfile, ComponentModel.ISupportInitialize).EndInit()
        PnlAoInfo.ResumeLayout(False)
        PnlAoInfo.PerformLayout()
        CType(PicAoTeamLogo, ComponentModel.ISupportInitialize).EndInit()
        PnlAoPenalty.ResumeLayout(False)
        PnlAoScoreSummary.ResumeLayout(False)
        PnlAoScoreSummary.PerformLayout()
        CType(DgvAoHistory, ComponentModel.ISupportInitialize).EndInit()
        PanelAKA.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PicAkaProfile, ComponentModel.ISupportInitialize).EndInit()
        PnlAkaInfo.ResumeLayout(False)
        PnlAkaInfo.PerformLayout()
        CType(PicAkaTeamLogo, ComponentModel.ISupportInitialize).EndInit()
        PnlAkaPenalty.ResumeLayout(False)
        PnlAkaScoreSummary.ResumeLayout(False)
        PnlAkaScoreSummary.PerformLayout()
        CType(DgvAkaHistory, ComponentModel.ISupportInitialize).EndInit()
        PanelSidebarRight.ResumeLayout(False)
        PanelSidebarRight.PerformLayout()
        CType(NumAdjustSize, ComponentModel.ISupportInitialize).EndInit()
        TabMatchDetail.ResumeLayout(False)
        PageMatchDetail.ResumeLayout(False)
        PageMatchDetail.PerformLayout()
        PageMatchLogo.ResumeLayout(False)
        CType(PicPreviewLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(NumWinPoint, ComponentModel.ISupportInitialize).EndInit()
        CType(NumTatami, ComponentModel.ISupportInitialize).EndInit()
        PnlWaitingTimer.ResumeLayout(False)
        PnlWaitingTimer.PerformLayout()
        CType(NumWaitMin, ComponentModel.ISupportInitialize).EndInit()
        CType(NumWaitSec, ComponentModel.ISupportInitialize).EndInit()
        PanelMatchTimer.ResumeLayout(False)
        PanelMatchTimer.PerformLayout()
        CType(NumMatchMin, ComponentModel.ISupportInitialize).EndInit()
        CType(NumMatchSec, ComponentModel.ISupportInitialize).EndInit()
        PnlYellowTimerBox.ResumeLayout(False)
        PnlYellowTimerBox.PerformLayout()
        ResumeLayout(False)

    End Sub

    ' Base Panels
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents PanelSidebarRight As System.Windows.Forms.Panel
    Friend WithEvents PanelMainCenter As System.Windows.Forms.Panel
    Friend WithEvents PanelAKA As System.Windows.Forms.Panel
    Friend WithEvents PanelAO As System.Windows.Forms.Panel

    ' Right Sidebar Controls
    Friend WithEvents LblScboardType As System.Windows.Forms.Label
    Friend WithEvents LblSenshuStyle As System.Windows.Forms.Label
    Friend WithEvents LblAdjustScboard As System.Windows.Forms.Label
    Friend WithEvents CboAdjustPlayer As System.Windows.Forms.ComboBox
    Friend WithEvents NumAdjustSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnAdjustR As System.Windows.Forms.Button
    Friend WithEvents BtnAdjustMin As System.Windows.Forms.Button
    Friend WithEvents BtnAdjustPlus As System.Windows.Forms.Button
    Friend WithEvents TabMatchDetail As System.Windows.Forms.TabControl
    Friend WithEvents PageMatchDetail As System.Windows.Forms.TabPage
    Friend WithEvents PageMatchLogo As System.Windows.Forms.TabPage
    Friend WithEvents TxtMatchDesc As System.Windows.Forms.TextBox
    Friend WithEvents LblWinPoint As System.Windows.Forms.Label
    Friend WithEvents NumWinPoint As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnEditWinPoint As System.Windows.Forms.Button
    Friend WithEvents LblTatami As System.Windows.Forms.Label
    Friend WithEvents NumTatami As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnSwitchPosition As System.Windows.Forms.Button
    Friend WithEvents PnlWaitingTimer As System.Windows.Forms.Panel
    Friend WithEvents LblWaitingTimerTitle As System.Windows.Forms.Label
    Friend WithEvents NumWaitMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblWaitColon As System.Windows.Forms.Label
    Friend WithEvents NumWaitSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnStartWait As System.Windows.Forms.Button
    Friend WithEvents PanelMatchTimer As System.Windows.Forms.Panel
    Friend WithEvents LblMatchTimerTitle As System.Windows.Forms.Label
    Friend WithEvents BtnTime130 As System.Windows.Forms.Button
    Friend WithEvents BtnTime200 As System.Windows.Forms.Button
    Friend WithEvents BtnTime300 As System.Windows.Forms.Button
    Friend WithEvents NumMatchMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblMatchColon As System.Windows.Forms.Label
    Friend WithEvents NumMatchSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents PnlYellowTimerBox As System.Windows.Forms.Panel
    Friend WithEvents LblAdjustTimerTitle As System.Windows.Forms.Label
    Friend WithEvents LblMatchTimerValue As System.Windows.Forms.Label
    Friend WithEvents BtnMatchTimeMinus As System.Windows.Forms.Button
    Friend WithEvents BtnMatchTimePlus As System.Windows.Forms.Button
    Friend WithEvents BtnStartScoreboard As System.Windows.Forms.Button
    Friend WithEvents BtnStartTimer As System.Windows.Forms.Button
    Friend WithEvents BtnResetMatch As System.Windows.Forms.Button
    Friend WithEvents BtnSaveMatch As System.Windows.Forms.Button
    Friend WithEvents PicPreviewLogo As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSelectLogo As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveLogo As System.Windows.Forms.Button
    Friend WithEvents BtnResetTimer As System.Windows.Forms.Button
    Friend WithEvents ResetTimer As Button
    Friend WithEvents LblNextMatch As System.Windows.Forms.Label
    Friend WithEvents TxtAkaName As System.Windows.Forms.TextBox
    Friend WithEvents BtnAkaIcon As System.Windows.Forms.Button
    Friend WithEvents LblVS As System.Windows.Forms.Label
    Friend WithEvents BtnAoIcon As System.Windows.Forms.Button
    Friend WithEvents TxtAoName As System.Windows.Forms.TextBox
    Friend WithEvents BtnSwap As System.Windows.Forms.Button
    Friend WithEvents BtnLoadNextMatch As System.Windows.Forms.Button
    ' AKA Panel Controls
    Friend WithEvents LblAkaTitle As Label
    Friend WithEvents PicAkaProfile As PictureBox
    Friend WithEvents PnlAkaInfo As Panel
    Friend WithEvents LblAkaNameTitle As Label
    Friend WithEvents TxtAkaNameMain As TextBox
    Friend WithEvents LblAkaTeamTitle As Label
    Friend WithEvents TxtAkaTeam As TextBox
    Friend WithEvents BtnAkaTeamSearch As Button
    Friend WithEvents LblAkaTeamInfoTitle As Label
    Friend WithEvents TxtAkaTeamInfo As TextBox
    Friend WithEvents BtnAkaShikkaku As Button
    Friend WithEvents BtnAkaKnockedOut As Button
    Friend WithEvents PnlAkaPenalty As Panel
    Friend WithEvents BtnAka1C As Button
    Friend WithEvents BtnAka2C As Button
    Friend WithEvents BtnAka3C As Button
    Friend WithEvents BtnAkaHC As Button
    Friend WithEvents BtnAkaH As Button
    Friend WithEvents PnlAkaScoreSummary As Panel
    Friend WithEvents LblAkaScoreSummaryTitle As Label
    Friend WithEvents LblAkaIpponCount As Label
    Friend WithEvents LblAkaWazaariCount As Label
    Friend WithEvents LblAkaYukoCount As Label
    Friend WithEvents BtnAkaVR As Button
    Friend WithEvents DgvAkaHistory As DataGridView
    Friend WithEvents LblAkaMainScore As Label
    Friend WithEvents BtnAkaIppon As Button
    Friend WithEvents BtnAkaWazaari As Button
    Friend WithEvents BtnAkaYuko As Button
    Friend WithEvents BtnAkaShowWinner As Button
    Friend WithEvents BtnAkaResetScore As Button
    Friend WithEvents BtnAkaSenshu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAkaUserIcon1 As Button
    Friend WithEvents PicAkaTeamLogo As PictureBox
    Friend WithEvents AKAVR As Button
    ' AO Panel Controls
    Friend WithEvents LblAoTitle As Label
    Friend WithEvents PicAoProfile As PictureBox
    Friend WithEvents PnlAoInfo As Panel
    Friend WithEvents LblAoNameTitle As Label
    Friend WithEvents TxtAoNameMain As TextBox
    Friend WithEvents BtnAoUserIcon1 As Button
    Friend WithEvents LblAoTeamTitle As Label
    Friend WithEvents TxtAoTeam As TextBox
    Friend WithEvents BtnAoTeamSearch As Button
    Friend WithEvents LblAoTeamInfoTitle As Label
    Friend WithEvents TxtAoTeamInfo As TextBox
    Friend WithEvents PicAoTeamLogo As PictureBox
    Friend WithEvents BtnAoKiken As Button
    Friend WithEvents BtnAoShikkaku As Button
    Friend WithEvents BtnAoKnockedOut As Button
    Friend WithEvents PnlAoPenalty As Panel
    Friend WithEvents LabelAoPenaltyP As Label
    Friend WithEvents BtnAo1C As Button
    Friend WithEvents BtnAo2C As Button
    Friend WithEvents BtnAo3C As Button
    Friend WithEvents BtnAoHC As Button
    Friend WithEvents BtnAoH As Button
    Friend WithEvents PnlAoScoreSummary As Panel
    Friend WithEvents LblAoScoreSummaryTitle As Label
    Friend WithEvents LblAoIpponCount As Label
    Friend WithEvents LblAoWazaariCount As Label
    Friend WithEvents LblAoYukoCount As Label
    Friend WithEvents BtnAoVR As Button
    Friend WithEvents AOVR As Button
    Friend WithEvents DgvAoHistory As DataGridView
    Friend WithEvents LblAoMainScore As Label
    Friend WithEvents BtnAoIppon As Button
    Friend WithEvents BtnAoWazaari As Button
    Friend WithEvents BtnAoYuko As Button
    Friend WithEvents BtnAoShowWinner As Button
    Friend WithEvents BtnAoResetScore As Button
    Friend WithEvents BtnAoSenshu As Button
    ' Footer Controls
    Friend WithEvents BtnSettings As Button
    Friend WithEvents BtnLogActivity As Button
    Friend WithEvents BtnShortcut As Button
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents BtnVolume As Button
    Friend WithEvents BtnResetHantei As Button
    Friend WithEvents BtnHantei As Button
    Friend WithEvents BtnHikiwake As Button
    Friend WithEvents BtnAkaKiken As Button
    Friend WithEvents LblAkaWinner As Label
    Friend WithEvents LblAoWinner As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColNoAo As DataGridViewTextBoxColumn
    Friend WithEvents ColTimerAo As DataGridViewTextBoxColumn
    Friend WithEvents ColTypeAo As DataGridViewTextBoxColumn
    Friend WithEvents ColActionAo As DataGridViewButtonColumn
    Friend WithEvents ColNo As DataGridViewTextBoxColumn
    Friend WithEvents ColTimer As DataGridViewTextBoxColumn
    Friend WithEvents ColType As DataGridViewTextBoxColumn
    Friend WithEvents ColActionAka As DataGridViewButtonColumn
    Friend WithEvents BtnSaveWinPoint As Button
    Friend WithEvents BtnSendMatchInfo As Button

End Class