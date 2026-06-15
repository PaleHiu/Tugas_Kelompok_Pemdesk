<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScoreBoard
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PnlBackground = New Panel()
        LblAkaDotsTop = New Label()
        LblAkaDotsBot = New Label()
        LblAkaName = New Label()
        LblAkaInfo = New Label()
        PnlAkaScore = New Panel()
        LblSenshuAka = New Label()
        LblAkaScore = New Label()
        LblAoDotsTop = New Label()
        LblAoDotsBot = New Label()
        LblAoName = New Label()
        LblAoInfo = New Label()
        PnlAoScore = New Panel()
        LblSenshuAo = New Label()
        LblAoScore = New Label()
        PnlPenaltyBar = New Panel()
        LblPenaltyTitle = New Label()
        LblAkaPen1 = New Label()
        LblAkaPen2 = New Label()
        LblAkaPen3 = New Label()
        LblAkaPen4 = New Label()
        LblAkaPen5 = New Label()
        LblAoPen1 = New Label()
        LblAoPen2 = New Label()
        LblAoPen3 = New Label()
        LblAoPen4 = New Label()
        LblAoPen5 = New Label()
        PnlFooter = New Panel()
        PicMatchLogo = New PictureBox()
        LblTatamiTitle = New Label()
        LblTatamiNum = New Label()
        LblStudio = New Label()
        LblTimerMain = New Label()
        LblTimerMilli = New Label()
        LblMatchDesc = New Label()
        LblVrAka = New Label()
        LblVrAo = New Label()
        PicAkaTeamLogoSb = New PictureBox()
        PicAoTeamLogoSb = New PictureBox()
        PicAoProfileSb = New PictureBox()
        PicAkaProfileSb = New PictureBox()
        LblVrBumper = New Label()
        PnlAkaScore.SuspendLayout()
        PnlAoScore.SuspendLayout()
        PnlPenaltyBar.SuspendLayout()
        PnlFooter.SuspendLayout()
        CType(PicMatchLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicAkaTeamLogoSb, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicAoTeamLogoSb, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicAoProfileSb, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicAkaProfileSb, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBackground
        ' 
        PnlBackground.Location = New Point(0, 0)
        PnlBackground.Name = "PnlBackground"
        PnlBackground.Size = New Size(200, 100)
        PnlBackground.TabIndex = 0
        ' 
        ' LblAkaDotsTop
        ' 
        LblAkaDotsTop.Font = New Font("Consolas", 24F, FontStyle.Bold)
        LblAkaDotsTop.ForeColor = Color.Gold
        LblAkaDotsTop.Location = New Point(44, 46)
        LblAkaDotsTop.Name = "LblAkaDotsTop"
        LblAkaDotsTop.Size = New Size(438, 38)
        LblAkaDotsTop.TabIndex = 6
        LblAkaDotsTop.Text = "■ ■ ■"
        LblAkaDotsTop.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaDotsBot
        ' 
        LblAkaDotsBot.Font = New Font("Consolas", 18.0F, FontStyle.Bold)
        LblAkaDotsBot.ForeColor = Color.White
        LblAkaDotsBot.Location = New Point(44, 84)
        LblAkaDotsBot.Name = "LblAkaDotsBot"
        LblAkaDotsBot.Size = New Size(438, 28)
        LblAkaDotsBot.TabIndex = 5
        LblAkaDotsBot.Text = "..."
        LblAkaDotsBot.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaName
        ' 
        LblAkaName.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold)
        LblAkaName.ForeColor = Color.White
        LblAkaName.Location = New Point(142, 122)
        LblAkaName.Name = "LblAkaName"
        LblAkaName.Size = New Size(438, 84)
        LblAkaName.TabIndex = 4
        LblAkaName.Text = "Activation"
        LblAkaName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaInfo
        ' 
        LblAkaInfo.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        LblAkaInfo.ForeColor = Color.White
        LblAkaInfo.Location = New Point(150, 206)
        LblAkaInfo.Name = "LblAkaInfo"
        LblAkaInfo.Size = New Size(438, 38)
        LblAkaInfo.TabIndex = 3
        LblAkaInfo.Text = "Activation Required..."
        LblAkaInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlAkaScore
        ' 
        PnlAkaScore.BackColor = Color.FromArgb(CByte(180), CByte(25), CByte(40))
        PnlAkaScore.Controls.Add(LblSenshuAka)
        PnlAkaScore.Controls.Add(LblAkaScore)
        PnlAkaScore.Location = New Point(201, 262)
        PnlAkaScore.Name = "PnlAkaScore"
        PnlAkaScore.Size = New Size(306, 206)
        PnlAkaScore.TabIndex = 2
        ' 
        ' LblSenshuAka
        ' 
        LblSenshuAka.BackColor = Color.Yellow
        LblSenshuAka.Font = New Font("Arial Rounded MT Bold", 24.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblSenshuAka.Location = New Point(265, 172)
        LblSenshuAka.Name = "LblSenshuAka"
        LblSenshuAka.Size = New Size(41, 34)
        LblSenshuAka.TabIndex = 1
        LblSenshuAka.Text = "S"
        LblSenshuAka.TextAlign = ContentAlignment.MiddleCenter
        LblSenshuAka.Visible = False
        ' 
        ' LblAkaScore
        ' 
        LblAkaScore.Dock = DockStyle.Fill
        LblAkaScore.Font = New Font("Segoe UI", 120.0F, FontStyle.Bold)
        LblAkaScore.ForeColor = Color.White
        LblAkaScore.Location = New Point(0, 0)
        LblAkaScore.Name = "LblAkaScore"
        LblAkaScore.Size = New Size(306, 206)
        LblAkaScore.TabIndex = 0
        LblAkaScore.Text = "0"
        LblAkaScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoDotsTop
        ' 
        LblAoDotsTop.Font = New Font("Consolas", 24.0F, FontStyle.Bold)
        LblAoDotsTop.ForeColor = Color.Gold
        LblAoDotsTop.Location = New Point(639, 46)
        LblAoDotsTop.Name = "LblAoDotsTop"
        LblAoDotsTop.Size = New Size(438, 38)
        LblAoDotsTop.TabIndex = 11
        LblAoDotsTop.Text = "■ ■ ■"
        LblAoDotsTop.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoDotsBot
        ' 
        LblAoDotsBot.Font = New Font("Consolas", 18.0F, FontStyle.Bold)
        LblAoDotsBot.ForeColor = Color.White
        LblAoDotsBot.Location = New Point(639, 84)
        LblAoDotsBot.Name = "LblAoDotsBot"
        LblAoDotsBot.Size = New Size(438, 28)
        LblAoDotsBot.TabIndex = 10
        LblAoDotsBot.Text = "..."
        LblAoDotsBot.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoName
        ' 
        LblAoName.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold)
        LblAoName.ForeColor = Color.White
        LblAoName.Location = New Point(559, 122)
        LblAoName.Name = "LblAoName"
        LblAoName.Size = New Size(438, 84)
        LblAoName.TabIndex = 9
        LblAoName.Text = "Activation"
        LblAoName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoInfo
        ' 
        LblAoInfo.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        LblAoInfo.ForeColor = Color.White
        LblAoInfo.Location = New Point(545, 206)
        LblAoInfo.Name = "LblAoInfo"
        LblAoInfo.Size = New Size(438, 38)
        LblAoInfo.TabIndex = 8
        LblAoInfo.Text = "Activation Required..."
        LblAoInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlAoScore
        ' 
        PnlAoScore.BackColor = Color.FromArgb(CByte(25), CByte(110), CByte(200))
        PnlAoScore.Controls.Add(LblSenshuAo)
        PnlAoScore.Controls.Add(LblAoScore)
        PnlAoScore.Location = New Point(612, 262)
        PnlAoScore.Name = "PnlAoScore"
        PnlAoScore.Size = New Size(306, 206)
        PnlAoScore.TabIndex = 7
        ' 
        ' LblSenshuAo
        ' 
        LblSenshuAo.BackColor = Color.Yellow
        LblSenshuAo.Font = New Font("Arial Rounded MT Bold", 24.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblSenshuAo.Location = New Point(265, 172)
        LblSenshuAo.Name = "LblSenshuAo"
        LblSenshuAo.Size = New Size(41, 34)
        LblSenshuAo.TabIndex = 2
        LblSenshuAo.Text = "S"
        LblSenshuAo.TextAlign = ContentAlignment.MiddleCenter
        LblSenshuAo.Visible = False
        ' 
        ' LblAoScore
        ' 
        LblAoScore.Dock = DockStyle.Fill
        LblAoScore.Font = New Font("Segoe UI", 120.0F, FontStyle.Bold)
        LblAoScore.ForeColor = Color.White
        LblAoScore.Location = New Point(0, 0)
        LblAoScore.Name = "LblAoScore"
        LblAoScore.Size = New Size(306, 206)
        LblAoScore.TabIndex = 0
        LblAoScore.Text = "0"
        LblAoScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlPenaltyBar
        ' 
        PnlPenaltyBar.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        PnlPenaltyBar.Controls.Add(LblPenaltyTitle)
        PnlPenaltyBar.Controls.Add(LblAkaPen1)
        PnlPenaltyBar.Controls.Add(LblAkaPen2)
        PnlPenaltyBar.Controls.Add(LblAkaPen3)
        PnlPenaltyBar.Controls.Add(LblAkaPen4)
        PnlPenaltyBar.Controls.Add(LblAkaPen5)
        PnlPenaltyBar.Controls.Add(LblAoPen1)
        PnlPenaltyBar.Controls.Add(LblAoPen2)
        PnlPenaltyBar.Controls.Add(LblAoPen3)
        PnlPenaltyBar.Controls.Add(LblAoPen4)
        PnlPenaltyBar.Controls.Add(LblAoPen5)
        PnlPenaltyBar.Location = New Point(0, 488)
        PnlPenaltyBar.Name = "PnlPenaltyBar"
        PnlPenaltyBar.Size = New Size(1120, 46)
        PnlPenaltyBar.TabIndex = 0
        ' 
        ' LblPenaltyTitle
        ' 
        LblPenaltyTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblPenaltyTitle.ForeColor = Color.Gold
        LblPenaltyTitle.Location = New Point(472, 0)
        LblPenaltyTitle.Name = "LblPenaltyTitle"
        LblPenaltyTitle.Size = New Size(175, 46)
        LblPenaltyTitle.TabIndex = 0
        LblPenaltyTitle.Text = "PENALTY"
        LblPenaltyTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen1
        ' 
        LblAkaPen1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen1.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAkaPen1.ForeColor = Color.DarkGray
        LblAkaPen1.Location = New Point(9, 7)
        LblAkaPen1.Name = "LblAkaPen1"
        LblAkaPen1.Size = New Size(61, 33)
        LblAkaPen1.TabIndex = 1
        LblAkaPen1.Text = "1C"
        LblAkaPen1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen2
        ' 
        LblAkaPen2.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen2.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAkaPen2.ForeColor = Color.DarkGray
        LblAkaPen2.Location = New Point(83, 7)
        LblAkaPen2.Name = "LblAkaPen2"
        LblAkaPen2.Size = New Size(61, 33)
        LblAkaPen2.TabIndex = 2
        LblAkaPen2.Text = "2C"
        LblAkaPen2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen3
        ' 
        LblAkaPen3.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen3.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAkaPen3.ForeColor = Color.DarkGray
        LblAkaPen3.Location = New Point(158, 7)
        LblAkaPen3.Name = "LblAkaPen3"
        LblAkaPen3.Size = New Size(61, 33)
        LblAkaPen3.TabIndex = 3
        LblAkaPen3.Text = "3C"
        LblAkaPen3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen4
        ' 
        LblAkaPen4.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen4.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAkaPen4.ForeColor = Color.DarkGray
        LblAkaPen4.Location = New Point(232, 7)
        LblAkaPen4.Name = "LblAkaPen4"
        LblAkaPen4.Size = New Size(61, 33)
        LblAkaPen4.TabIndex = 4
        LblAkaPen4.Text = "HC"
        LblAkaPen4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen5
        ' 
        LblAkaPen5.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen5.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAkaPen5.ForeColor = Color.DarkGray
        LblAkaPen5.Location = New Point(306, 7)
        LblAkaPen5.Name = "LblAkaPen5"
        LblAkaPen5.Size = New Size(61, 33)
        LblAkaPen5.TabIndex = 5
        LblAkaPen5.Text = "H"
        LblAkaPen5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen1
        ' 
        LblAoPen1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen1.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAoPen1.ForeColor = Color.DarkGray
        LblAoPen1.Location = New Point(1041, 7)
        LblAoPen1.Name = "LblAoPen1"
        LblAoPen1.Size = New Size(61, 33)
        LblAoPen1.TabIndex = 6
        LblAoPen1.Text = "1C"
        LblAoPen1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen2
        ' 
        LblAoPen2.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen2.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAoPen2.ForeColor = Color.DarkGray
        LblAoPen2.Location = New Point(967, 7)
        LblAoPen2.Name = "LblAoPen2"
        LblAoPen2.Size = New Size(61, 33)
        LblAoPen2.TabIndex = 7
        LblAoPen2.Text = "2C"
        LblAoPen2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen3
        ' 
        LblAoPen3.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen3.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAoPen3.ForeColor = Color.DarkGray
        LblAoPen3.Location = New Point(892, 7)
        LblAoPen3.Name = "LblAoPen3"
        LblAoPen3.Size = New Size(61, 33)
        LblAoPen3.TabIndex = 8
        LblAoPen3.Text = "3C"
        LblAoPen3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen4
        ' 
        LblAoPen4.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen4.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAoPen4.ForeColor = Color.DarkGray
        LblAoPen4.Location = New Point(818, 7)
        LblAoPen4.Name = "LblAoPen4"
        LblAoPen4.Size = New Size(61, 33)
        LblAoPen4.TabIndex = 9
        LblAoPen4.Text = "HC"
        LblAoPen4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen5
        ' 
        LblAoPen5.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen5.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblAoPen5.ForeColor = Color.DarkGray
        LblAoPen5.Location = New Point(744, 7)
        LblAoPen5.Name = "LblAoPen5"
        LblAoPen5.Size = New Size(61, 33)
        LblAoPen5.TabIndex = 10
        LblAoPen5.Text = "H"
        LblAoPen5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlFooter
        ' 
        PnlFooter.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        PnlFooter.Controls.Add(PicMatchLogo)
        PnlFooter.Controls.Add(LblTatamiTitle)
        PnlFooter.Controls.Add(LblTatamiNum)
        PnlFooter.Controls.Add(LblStudio)
        PnlFooter.Controls.Add(LblTimerMain)
        PnlFooter.Controls.Add(LblTimerMilli)
        PnlFooter.Controls.Add(LblMatchDesc)
        PnlFooter.Location = New Point(0, 534)
        PnlFooter.Name = "PnlFooter"
        PnlFooter.Size = New Size(1120, 141)
        PnlFooter.TabIndex = 1
        ' 
        ' PicMatchLogo
        ' 
        PicMatchLogo.Location = New Point(203, 20)
        PicMatchLogo.Margin = New Padding(3, 2, 3, 2)
        PicMatchLogo.Name = "PicMatchLogo"
        PicMatchLogo.Size = New Size(142, 111)
        PicMatchLogo.SizeMode = PictureBoxSizeMode.Zoom
        PicMatchLogo.TabIndex = 6
        PicMatchLogo.TabStop = False
        ' 
        ' LblTatamiTitle
        ' 
        LblTatamiTitle.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        LblTatamiTitle.ForeColor = Color.Gold
        LblTatamiTitle.Location = New Point(18, 9)
        LblTatamiTitle.Name = "LblTatamiTitle"
        LblTatamiTitle.Size = New Size(175, 46)
        LblTatamiTitle.TabIndex = 0
        LblTatamiTitle.Text = "TATAMI"
        ' 
        ' LblTatamiNum
        ' 
        LblTatamiNum.Font = New Font("Segoe UI", 55.0F, FontStyle.Bold)
        LblTatamiNum.ForeColor = Color.White
        LblTatamiNum.Location = New Point(18, 46)
        LblTatamiNum.Name = "LblTatamiNum"
        LblTatamiNum.Size = New Size(131, 84)
        LblTatamiNum.TabIndex = 1
        LblTatamiNum.Text = "1"
        LblTatamiNum.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblStudio
        ' 
        LblStudio.Font = New Font("Segoe UI", 12.0F, FontStyle.Italic)
        LblStudio.ForeColor = Color.LightGray
        LblStudio.Location = New Point(158, 56)
        LblStudio.Name = "LblStudio"
        LblStudio.Size = New Size(175, 28)
        LblStudio.TabIndex = 2
        ' 
        ' LblTimerMain
        ' 
        LblTimerMain.Font = New Font("Segoe UI", 90.0F, FontStyle.Bold)
        LblTimerMain.ForeColor = Color.White
        LblTimerMain.Location = New Point(350, -14)
        LblTimerMain.Name = "LblTimerMain"
        LblTimerMain.Size = New Size(350, 141)
        LblTimerMain.TabIndex = 3
        LblTimerMain.Text = "2:00"
        LblTimerMain.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblTimerMilli
        ' 
        LblTimerMilli.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold)
        LblTimerMilli.ForeColor = Color.White
        LblTimerMilli.Location = New Point(682, 38)
        LblTimerMilli.Name = "LblTimerMilli"
        LblTimerMilli.Size = New Size(131, 84)
        LblTimerMilli.TabIndex = 4
        LblTimerMilli.Text = ".0"
        LblTimerMilli.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' LblMatchDesc
        ' 
        LblMatchDesc.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        LblMatchDesc.ForeColor = Color.Gold
        LblMatchDesc.Location = New Point(744, 46)
        LblMatchDesc.Name = "LblMatchDesc"
        LblMatchDesc.Size = New Size(350, 46)
        LblMatchDesc.TabIndex = 5
        LblMatchDesc.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblVrAka
        ' 
        LblVrAka.BackColor = Color.Red
        LblVrAka.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblVrAka.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        LblVrAka.Location = New Point(76, 404)
        LblVrAka.Name = "LblVrAka"
        LblVrAka.Size = New Size(68, 64)
        LblVrAka.TabIndex = 12
        LblVrAka.Text = "VR"
        LblVrAka.TextAlign = ContentAlignment.BottomCenter
        LblVrAka.Visible = False
        ' 
        ' LblVrAo
        ' 
        LblVrAo.BackColor = Color.Blue
        LblVrAo.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblVrAo.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        LblVrAo.Location = New Point(967, 404)
        LblVrAo.Name = "LblVrAo"
        LblVrAo.Size = New Size(68, 64)
        LblVrAo.TabIndex = 13
        LblVrAo.Text = "VR"
        LblVrAo.TextAlign = ContentAlignment.BottomCenter
        LblVrAo.Visible = False
        ' 
        ' PicAkaTeamLogoSb
        ' 
        PicAkaTeamLogoSb.Location = New Point(35, 28)
        PicAkaTeamLogoSb.Margin = New Padding(3, 2, 3, 2)
        PicAkaTeamLogoSb.Name = "PicAkaTeamLogoSb"
        PicAkaTeamLogoSb.Size = New Size(109, 91)
        PicAkaTeamLogoSb.TabIndex = 14
        PicAkaTeamLogoSb.TabStop = False
        ' 
        ' PicAoTeamLogoSb
        ' 
        PicAoTeamLogoSb.Location = New Point(984, 28)
        PicAoTeamLogoSb.Margin = New Padding(3, 2, 3, 2)
        PicAoTeamLogoSb.Name = "PicAoTeamLogoSb"
        PicAoTeamLogoSb.Size = New Size(109, 91)
        PicAoTeamLogoSb.SizeMode = PictureBoxSizeMode.Zoom
        PicAoTeamLogoSb.TabIndex = 15
        PicAoTeamLogoSb.TabStop = False
        ' 
        ' PicAoProfileSb
        ' 
        PicAoProfileSb.Location = New Point(984, 262)
        PicAoProfileSb.Margin = New Padding(3, 2, 3, 2)
        PicAoProfileSb.Name = "PicAoProfileSb"
        PicAoProfileSb.Size = New Size(109, 91)
        PicAoProfileSb.SizeMode = PictureBoxSizeMode.Zoom
        PicAoProfileSb.TabIndex = 16
        PicAoProfileSb.TabStop = False
        ' 
        ' PicAkaProfileSb
        ' 
        PicAkaProfileSb.Location = New Point(35, 262)
        PicAkaProfileSb.Margin = New Padding(3, 2, 3, 2)
        PicAkaProfileSb.Name = "PicAkaProfileSb"
        PicAkaProfileSb.Size = New Size(109, 91)
        PicAkaProfileSb.SizeMode = PictureBoxSizeMode.Zoom
        PicAkaProfileSb.TabIndex = 17
        PicAkaProfileSb.TabStop = False
        ' 
        ' LblVrBumper
        ' 
        LblVrBumper.Dock = DockStyle.Fill
        LblVrBumper.Font = New Font("Segoe UI", 72.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblVrBumper.ForeColor = Color.Gold
        LblVrBumper.Location = New Point(0, 0)
        LblVrBumper.Name = "LblVrBumper"
        LblVrBumper.Size = New Size(1120, 675)
        LblVrBumper.TabIndex = 14
        LblVrBumper.Text = "VIDEO REVIEW REQUITED"
        LblVrBumper.TextAlign = ContentAlignment.MiddleCenter
        LblVrBumper.Visible = False
        ' 
        ' ScoreBoard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(1120, 675)
        Controls.Add(LblVrBumper)
        Controls.Add(PicAkaProfileSb)
        Controls.Add(PicAoProfileSb)
        Controls.Add(PicAoTeamLogoSb)
        Controls.Add(PicAkaTeamLogoSb)
        Controls.Add(LblVrAo)
        Controls.Add(LblVrAka)
        Controls.Add(PnlPenaltyBar)
        Controls.Add(PnlFooter)
        Controls.Add(PnlAkaScore)
        Controls.Add(LblAkaInfo)
        Controls.Add(LblAkaName)
        Controls.Add(LblAkaDotsBot)
        Controls.Add(LblAkaDotsTop)
        Controls.Add(PnlAoScore)
        Controls.Add(LblAoInfo)
        Controls.Add(LblAoName)
        Controls.Add(LblAoDotsBot)
        Controls.Add(LblAoDotsTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "ScoreBoard"
        Text = "Score Board"
        PnlAkaScore.ResumeLayout(False)
        PnlAoScore.ResumeLayout(False)
        PnlPenaltyBar.ResumeLayout(False)
        PnlFooter.ResumeLayout(False)
        CType(PicMatchLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(PicAkaTeamLogoSb, ComponentModel.ISupportInitialize).EndInit()
        CType(PicAoTeamLogoSb, ComponentModel.ISupportInitialize).EndInit()
        CType(PicAoProfileSb, ComponentModel.ISupportInitialize).EndInit()
        CType(PicAkaProfileSb, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    ' Variabel Komponen
    Friend WithEvents PnlBackground As System.Windows.Forms.Panel
    Friend WithEvents LblAkaDotsTop As System.Windows.Forms.Label
    Friend WithEvents LblAkaDotsBot As System.Windows.Forms.Label
    Friend WithEvents LblAkaName As System.Windows.Forms.Label
    Friend WithEvents LblAkaInfo As System.Windows.Forms.Label
    Friend WithEvents PnlAkaScore As System.Windows.Forms.Panel
    Friend WithEvents LblAkaScore As System.Windows.Forms.Label

    Friend WithEvents LblAoDotsTop As System.Windows.Forms.Label
    Friend WithEvents LblAoDotsBot As System.Windows.Forms.Label
    Friend WithEvents LblAoName As System.Windows.Forms.Label
    Friend WithEvents LblAoInfo As System.Windows.Forms.Label
    Friend WithEvents PnlAoScore As System.Windows.Forms.Panel
    Friend WithEvents LblAoScore As System.Windows.Forms.Label

    Friend WithEvents PnlPenaltyBar As System.Windows.Forms.Panel
    Friend WithEvents LblPenaltyTitle As System.Windows.Forms.Label

    Friend WithEvents PnlFooter As System.Windows.Forms.Panel
    Friend WithEvents LblTatamiTitle As System.Windows.Forms.Label
    Friend WithEvents LblTatamiNum As System.Windows.Forms.Label
    Friend WithEvents LblStudio As System.Windows.Forms.Label
    Friend WithEvents LblTimerMain As System.Windows.Forms.Label
    Friend WithEvents LblTimerMilli As System.Windows.Forms.Label
    Friend WithEvents LblMatchDesc As System.Windows.Forms.Label
    Friend WithEvents LblTimer As System.Windows.Forms.Label

    ' Tambahkan deklarasi Label Penalti 
    Friend WithEvents LblAkaPen1 As System.Windows.Forms.Label
    Friend WithEvents LblAkaPen2 As System.Windows.Forms.Label
    Friend WithEvents LblAkaPen3 As System.Windows.Forms.Label
    Friend WithEvents LblAkaPen4 As System.Windows.Forms.Label
    Friend WithEvents LblAkaPen5 As System.Windows.Forms.Label

    Friend WithEvents LblAoPen1 As System.Windows.Forms.Label
    Friend WithEvents LblAoPen2 As System.Windows.Forms.Label
    Friend WithEvents LblAoPen3 As System.Windows.Forms.Label
    Friend WithEvents LblAoPen4 As System.Windows.Forms.Label
    Friend WithEvents LblAoPen5 As System.Windows.Forms.Label
    Friend WithEvents PicMatchLogo As PictureBox
    Friend WithEvents LblVrAka As Label
    Friend WithEvents LblVrAo As Label
    Friend WithEvents LblSenshuAka As Label
    Friend WithEvents LblSenshuAo As Label
    Friend WithEvents PicAkaTeamLogoSb As PictureBox
    Friend WithEvents PicAoTeamLogoSb As PictureBox
    Friend WithEvents PicAoProfileSb As PictureBox
    Friend WithEvents PicAkaProfileSb As PictureBox
    Friend WithEvents LblVrBumper As Label
End Class