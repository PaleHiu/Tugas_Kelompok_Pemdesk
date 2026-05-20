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
        LblAkaScore = New Label()
        LblAoDotsTop = New Label()
        LblAoDotsBot = New Label()
        LblAoName = New Label()
        LblAoInfo = New Label()
        PnlAoScore = New Panel()
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
        PnlAkaScore.SuspendLayout()
        PnlAoScore.SuspendLayout()
        PnlPenaltyBar.SuspendLayout()
        PnlFooter.SuspendLayout()
        CType(PicMatchLogo, ComponentModel.ISupportInitialize).BeginInit()
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
        LblAkaDotsTop.Location = New Point(50, 62)
        LblAkaDotsTop.Name = "LblAkaDotsTop"
        LblAkaDotsTop.Size = New Size(500, 50)
        LblAkaDotsTop.TabIndex = 6
        LblAkaDotsTop.Text = "■ ■ ■"
        LblAkaDotsTop.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaDotsBot
        ' 
        LblAkaDotsBot.Font = New Font("Consolas", 18F, FontStyle.Bold)
        LblAkaDotsBot.ForeColor = Color.White
        LblAkaDotsBot.Location = New Point(50, 112)
        LblAkaDotsBot.Name = "LblAkaDotsBot"
        LblAkaDotsBot.Size = New Size(500, 38)
        LblAkaDotsBot.TabIndex = 5
        LblAkaDotsBot.Text = "..."
        LblAkaDotsBot.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaName
        ' 
        LblAkaName.Font = New Font("Segoe UI", 48F, FontStyle.Bold)
        LblAkaName.ForeColor = Color.White
        LblAkaName.Location = New Point(162, 162)
        LblAkaName.Name = "LblAkaName"
        LblAkaName.Size = New Size(500, 112)
        LblAkaName.TabIndex = 4
        LblAkaName.Text = "Activation"
        LblAkaName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaInfo
        ' 
        LblAkaInfo.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        LblAkaInfo.ForeColor = Color.White
        LblAkaInfo.Location = New Point(171, 274)
        LblAkaInfo.Name = "LblAkaInfo"
        LblAkaInfo.Size = New Size(500, 50)
        LblAkaInfo.TabIndex = 3
        LblAkaInfo.Text = "Activation Required..."
        LblAkaInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlAkaScore
        ' 
        PnlAkaScore.BackColor = Color.FromArgb(CByte(180), CByte(25), CByte(40))
        PnlAkaScore.Controls.Add(LblAkaScore)
        PnlAkaScore.Location = New Point(230, 350)
        PnlAkaScore.Margin = New Padding(3, 4, 3, 4)
        PnlAkaScore.Name = "PnlAkaScore"
        PnlAkaScore.Size = New Size(350, 275)
        PnlAkaScore.TabIndex = 2
        ' 
        ' LblAkaScore
        ' 
        LblAkaScore.Dock = DockStyle.Fill
        LblAkaScore.Font = New Font("Segoe UI", 120F, FontStyle.Bold)
        LblAkaScore.ForeColor = Color.White
        LblAkaScore.Location = New Point(0, 0)
        LblAkaScore.Name = "LblAkaScore"
        LblAkaScore.Size = New Size(350, 275)
        LblAkaScore.TabIndex = 0
        LblAkaScore.Text = "0"
        LblAkaScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoDotsTop
        ' 
        LblAoDotsTop.Font = New Font("Consolas", 24F, FontStyle.Bold)
        LblAoDotsTop.ForeColor = Color.Gold
        LblAoDotsTop.Location = New Point(730, 62)
        LblAoDotsTop.Name = "LblAoDotsTop"
        LblAoDotsTop.Size = New Size(500, 50)
        LblAoDotsTop.TabIndex = 11
        LblAoDotsTop.Text = "■ ■ ■"
        LblAoDotsTop.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoDotsBot
        ' 
        LblAoDotsBot.Font = New Font("Consolas", 18F, FontStyle.Bold)
        LblAoDotsBot.ForeColor = Color.White
        LblAoDotsBot.Location = New Point(730, 112)
        LblAoDotsBot.Name = "LblAoDotsBot"
        LblAoDotsBot.Size = New Size(500, 38)
        LblAoDotsBot.TabIndex = 10
        LblAoDotsBot.Text = "..."
        LblAoDotsBot.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoName
        ' 
        LblAoName.Font = New Font("Segoe UI", 48F, FontStyle.Bold)
        LblAoName.ForeColor = Color.White
        LblAoName.Location = New Point(639, 162)
        LblAoName.Name = "LblAoName"
        LblAoName.Size = New Size(500, 112)
        LblAoName.TabIndex = 9
        LblAoName.Text = "Activation"
        LblAoName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoInfo
        ' 
        LblAoInfo.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        LblAoInfo.ForeColor = Color.White
        LblAoInfo.Location = New Point(623, 274)
        LblAoInfo.Name = "LblAoInfo"
        LblAoInfo.Size = New Size(500, 50)
        LblAoInfo.TabIndex = 8
        LblAoInfo.Text = "Activation Required..."
        LblAoInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlAoScore
        ' 
        PnlAoScore.BackColor = Color.FromArgb(CByte(25), CByte(110), CByte(200))
        PnlAoScore.Controls.Add(LblAoScore)
        PnlAoScore.Location = New Point(700, 350)
        PnlAoScore.Margin = New Padding(3, 4, 3, 4)
        PnlAoScore.Name = "PnlAoScore"
        PnlAoScore.Size = New Size(350, 275)
        PnlAoScore.TabIndex = 7
        ' 
        ' LblAoScore
        ' 
        LblAoScore.Dock = DockStyle.Fill
        LblAoScore.Font = New Font("Segoe UI", 120F, FontStyle.Bold)
        LblAoScore.ForeColor = Color.White
        LblAoScore.Location = New Point(0, 0)
        LblAoScore.Name = "LblAoScore"
        LblAoScore.Size = New Size(350, 275)
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
        PnlPenaltyBar.Location = New Point(0, 650)
        PnlPenaltyBar.Margin = New Padding(3, 4, 3, 4)
        PnlPenaltyBar.Name = "PnlPenaltyBar"
        PnlPenaltyBar.Size = New Size(1280, 62)
        PnlPenaltyBar.TabIndex = 0
        ' 
        ' LblPenaltyTitle
        ' 
        LblPenaltyTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblPenaltyTitle.ForeColor = Color.Gold
        LblPenaltyTitle.Location = New Point(540, 0)
        LblPenaltyTitle.Name = "LblPenaltyTitle"
        LblPenaltyTitle.Size = New Size(200, 62)
        LblPenaltyTitle.TabIndex = 0
        LblPenaltyTitle.Text = "PENALTY"
        LblPenaltyTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen1
        ' 
        LblAkaPen1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAkaPen1.ForeColor = Color.DarkGray
        LblAkaPen1.Location = New Point(10, 9)
        LblAkaPen1.Name = "LblAkaPen1"
        LblAkaPen1.Size = New Size(70, 44)
        LblAkaPen1.TabIndex = 1
        LblAkaPen1.Text = "1C"
        LblAkaPen1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen2
        ' 
        LblAkaPen2.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAkaPen2.ForeColor = Color.DarkGray
        LblAkaPen2.Location = New Point(95, 9)
        LblAkaPen2.Name = "LblAkaPen2"
        LblAkaPen2.Size = New Size(70, 44)
        LblAkaPen2.TabIndex = 2
        LblAkaPen2.Text = "2C"
        LblAkaPen2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen3
        ' 
        LblAkaPen3.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAkaPen3.ForeColor = Color.DarkGray
        LblAkaPen3.Location = New Point(180, 9)
        LblAkaPen3.Name = "LblAkaPen3"
        LblAkaPen3.Size = New Size(70, 44)
        LblAkaPen3.TabIndex = 3
        LblAkaPen3.Text = "3C"
        LblAkaPen3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen4
        ' 
        LblAkaPen4.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen4.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAkaPen4.ForeColor = Color.DarkGray
        LblAkaPen4.Location = New Point(265, 9)
        LblAkaPen4.Name = "LblAkaPen4"
        LblAkaPen4.Size = New Size(70, 44)
        LblAkaPen4.TabIndex = 4
        LblAkaPen4.Text = "HC"
        LblAkaPen4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaPen5
        ' 
        LblAkaPen5.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAkaPen5.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAkaPen5.ForeColor = Color.DarkGray
        LblAkaPen5.Location = New Point(350, 9)
        LblAkaPen5.Name = "LblAkaPen5"
        LblAkaPen5.Size = New Size(70, 44)
        LblAkaPen5.TabIndex = 5
        LblAkaPen5.Text = "H"
        LblAkaPen5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen1
        ' 
        LblAoPen1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAoPen1.ForeColor = Color.DarkGray
        LblAoPen1.Location = New Point(1190, 9)
        LblAoPen1.Name = "LblAoPen1"
        LblAoPen1.Size = New Size(70, 44)
        LblAoPen1.TabIndex = 6
        LblAoPen1.Text = "1C"
        LblAoPen1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen2
        ' 
        LblAoPen2.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAoPen2.ForeColor = Color.DarkGray
        LblAoPen2.Location = New Point(1105, 9)
        LblAoPen2.Name = "LblAoPen2"
        LblAoPen2.Size = New Size(70, 44)
        LblAoPen2.TabIndex = 7
        LblAoPen2.Text = "2C"
        LblAoPen2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen3
        ' 
        LblAoPen3.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAoPen3.ForeColor = Color.DarkGray
        LblAoPen3.Location = New Point(1020, 9)
        LblAoPen3.Name = "LblAoPen3"
        LblAoPen3.Size = New Size(70, 44)
        LblAoPen3.TabIndex = 8
        LblAoPen3.Text = "3C"
        LblAoPen3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen4
        ' 
        LblAoPen4.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen4.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAoPen4.ForeColor = Color.DarkGray
        LblAoPen4.Location = New Point(935, 9)
        LblAoPen4.Name = "LblAoPen4"
        LblAoPen4.Size = New Size(70, 44)
        LblAoPen4.TabIndex = 9
        LblAoPen4.Text = "HC"
        LblAoPen4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoPen5
        ' 
        LblAoPen5.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LblAoPen5.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAoPen5.ForeColor = Color.DarkGray
        LblAoPen5.Location = New Point(850, 9)
        LblAoPen5.Name = "LblAoPen5"
        LblAoPen5.Size = New Size(70, 44)
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
        PnlFooter.Location = New Point(0, 712)
        PnlFooter.Margin = New Padding(3, 4, 3, 4)
        PnlFooter.Name = "PnlFooter"
        PnlFooter.Size = New Size(1280, 188)
        PnlFooter.TabIndex = 1
        ' 
        ' PicMatchLogo
        ' 
        PicMatchLogo.Location = New Point(232, 26)
        PicMatchLogo.Name = "PicMatchLogo"
        PicMatchLogo.Size = New Size(162, 148)
        PicMatchLogo.SizeMode = PictureBoxSizeMode.Zoom
        PicMatchLogo.TabIndex = 6
        PicMatchLogo.TabStop = False
        ' 
        ' LblTatamiTitle
        ' 
        LblTatamiTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        LblTatamiTitle.ForeColor = Color.Gold
        LblTatamiTitle.Location = New Point(20, 12)
        LblTatamiTitle.Name = "LblTatamiTitle"
        LblTatamiTitle.Size = New Size(200, 62)
        LblTatamiTitle.TabIndex = 0
        LblTatamiTitle.Text = "TATAMI"
        ' 
        ' LblTatamiNum
        ' 
        LblTatamiNum.Font = New Font("Segoe UI", 55F, FontStyle.Bold)
        LblTatamiNum.ForeColor = Color.White
        LblTatamiNum.Location = New Point(20, 62)
        LblTatamiNum.Name = "LblTatamiNum"
        LblTatamiNum.Size = New Size(150, 112)
        LblTatamiNum.TabIndex = 1
        LblTatamiNum.Text = "1"
        LblTatamiNum.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblStudio
        ' 
        LblStudio.Font = New Font("Segoe UI", 12F, FontStyle.Italic)
        LblStudio.ForeColor = Color.LightGray
        LblStudio.Location = New Point(180, 75)
        LblStudio.Name = "LblStudio"
        LblStudio.Size = New Size(200, 38)
        LblStudio.TabIndex = 2
        ' 
        ' LblTimerMain
        ' 
        LblTimerMain.Font = New Font("Segoe UI", 90F, FontStyle.Bold)
        LblTimerMain.ForeColor = Color.White
        LblTimerMain.Location = New Point(400, -19)
        LblTimerMain.Name = "LblTimerMain"
        LblTimerMain.Size = New Size(400, 188)
        LblTimerMain.TabIndex = 3
        LblTimerMain.Text = "2:00"
        LblTimerMain.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblTimerMilli
        ' 
        LblTimerMilli.Font = New Font("Segoe UI", 48F, FontStyle.Bold)
        LblTimerMilli.ForeColor = Color.White
        LblTimerMilli.Location = New Point(780, 50)
        LblTimerMilli.Name = "LblTimerMilli"
        LblTimerMilli.Size = New Size(150, 112)
        LblTimerMilli.TabIndex = 4
        LblTimerMilli.Text = ".0"
        LblTimerMilli.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' LblMatchDesc
        ' 
        LblMatchDesc.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        LblMatchDesc.ForeColor = Color.Gold
        LblMatchDesc.Location = New Point(850, 62)
        LblMatchDesc.Name = "LblMatchDesc"
        LblMatchDesc.Size = New Size(400, 62)
        LblMatchDesc.TabIndex = 5
        LblMatchDesc.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ScoreBoard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(1280, 900)
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "ScoreBoard"
        Text = "Score Board"
        PnlAkaScore.ResumeLayout(False)
        PnlAoScore.ResumeLayout(False)
        PnlPenaltyBar.ResumeLayout(False)
        PnlFooter.ResumeLayout(False)
        CType(PicMatchLogo, ComponentModel.ISupportInitialize).EndInit()
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
End Class