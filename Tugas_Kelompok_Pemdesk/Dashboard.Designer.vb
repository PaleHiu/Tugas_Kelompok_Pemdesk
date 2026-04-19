<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Header = New Panel()
        btnActivation = New Button()
        lblActivationReq = New Label()
        lblTatamiValue = New Label()
        lblTatamiTitle = New Label()
        picLogo = New PictureBox()
        Body = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        pnlCompetitors = New Panel()
        lblCompetitors = New Label()
        picCompetitors = New PictureBox()
        pnlKumite = New Panel()
        lblKumite = New Label()
        picKumite = New PictureBox()
        pnlKata = New Panel()
        lblKata = New Label()
        picKata = New PictureBox()
        pnlMatchResult = New Panel()
        lblMatchResult = New Label()
        picMatchResult = New PictureBox()
        pnlServerStatus = New Panel()
        lblServerStatusTitle = New Label()
        lblServerDetails = New Label()
        btnKataServer = New Button()
        btnManageJudge = New Button()
        Footer = New Panel()
        lblWeb = New Label()
        lblAbout = New LinkLabel()
        Header.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        Body.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        pnlCompetitors.SuspendLayout()
        CType(picCompetitors, ComponentModel.ISupportInitialize).BeginInit()
        pnlKumite.SuspendLayout()
        CType(picKumite, ComponentModel.ISupportInitialize).BeginInit()
        pnlKata.SuspendLayout()
        CType(picKata, ComponentModel.ISupportInitialize).BeginInit()
        pnlMatchResult.SuspendLayout()
        CType(picMatchResult, ComponentModel.ISupportInitialize).BeginInit()
        pnlServerStatus.SuspendLayout()
        Footer.SuspendLayout()
        SuspendLayout()

        Header.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Header.Controls.Add(btnActivation)
        Header.Controls.Add(lblActivationReq)
        Header.Controls.Add(lblTatamiValue)
        Header.Controls.Add(lblTatamiTitle)
        Header.Controls.Add(picLogo)
        Header.Dock = DockStyle.Top
        Header.Location = New Point(0, 0)
        Header.Name = "Header"
        Header.Size = New Size(943, 120)
        Header.TabIndex = 0

        btnActivation.FlatAppearance.BorderColor = Color.White
        btnActivation.FlatStyle = FlatStyle.Flat
        btnActivation.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnActivation.ForeColor = Color.Cyan
        btnActivation.Location = New Point(380, 55)
        btnActivation.Name = "btnActivation"
        btnActivation.Size = New Size(230, 35)
        btnActivation.TabIndex = 4
        btnActivation.Text = "Enter Activation Code"

        lblActivationReq.AutoSize = True
        lblActivationReq.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold)
        lblActivationReq.ForeColor = Color.Red
        lblActivationReq.Location = New Point(385, 15)
        lblActivationReq.Name = "lblActivationReq"
        lblActivationReq.Size = New Size(210, 28)
        lblActivationReq.TabIndex = 3
        lblActivationReq.Text = "Activation Required"

        lblTatamiValue.AutoSize = True
        lblTatamiValue.Font = New Font("Consolas", 16.0F, FontStyle.Bold)
        lblTatamiValue.ForeColor = Color.White
        lblTatamiValue.Location = New Point(20, 45)
        lblTatamiValue.Name = "lblTatamiValue"
        lblTatamiValue.Size = New Size(239, 32)
        lblTatamiValue.TabIndex = 2
        lblTatamiValue.Text = "TM-E9790EA656F5"

        lblTatamiTitle.AutoSize = True
        lblTatamiTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTatamiTitle.ForeColor = Color.Yellow
        lblTatamiTitle.Location = New Point(20, 15)
        lblTatamiTitle.Name = "lblTatamiTitle"
        lblTatamiTitle.Size = New Size(88, 23)
        lblTatamiTitle.TabIndex = 1
        lblTatamiTitle.Text = "Tatami ID"

        picLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picLogo.Location = New Point(800, 10)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(120, 100)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False

        Body.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        Body.Controls.Add(TableLayoutPanel1)
        Body.Dock = DockStyle.Fill
        Body.Location = New Point(0, 120)
        Body.Name = "Body"
        Body.Size = New Size(943, 415)
        Body.TabIndex = 1

        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.Controls.Add(pnlCompetitors, 0, 0)
        TableLayoutPanel1.Controls.Add(pnlKumite, 1, 0)
        TableLayoutPanel1.Controls.Add(pnlKata, 2, 0)
        TableLayoutPanel1.Controls.Add(pnlMatchResult, 0, 1)
        TableLayoutPanel1.Controls.Add(pnlServerStatus, 1, 1)
        TableLayoutPanel1.Controls.Add(btnKataServer, 2, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Size = New Size(943, 415)
        TableLayoutPanel1.TabIndex = 0

        pnlCompetitors.Anchor = AnchorStyles.None
        pnlCompetitors.Controls.Add(lblCompetitors)
        pnlCompetitors.Controls.Add(picCompetitors)
        pnlCompetitors.Location = New Point(57, 17)
        pnlCompetitors.Name = "pnlCompetitors"
        pnlCompetitors.Size = New Size(200, 173)
        pnlCompetitors.TabIndex = 0

        lblCompetitors.AutoSize = True
        lblCompetitors.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblCompetitors.Location = New Point(36, 140)
        lblCompetitors.Name = "lblCompetitors"
        lblCompetitors.Size = New Size(128, 28)
        lblCompetitors.TabIndex = 1
        lblCompetitors.Text = "Competitors"

        picCompetitors.Image = CType(resources.GetObject("picCompetitors.Image"), Image)
        picCompetitors.Location = New Point(40, 10)
        picCompetitors.Name = "picCompetitors"
        picCompetitors.Size = New Size(120, 120)
        picCompetitors.SizeMode = PictureBoxSizeMode.Zoom
        picCompetitors.TabIndex = 0
        picCompetitors.TabStop = False

        pnlKumite.Anchor = AnchorStyles.None
        pnlKumite.Controls.Add(lblKumite)
        pnlKumite.Controls.Add(picKumite)
        pnlKumite.Location = New Point(371, 17)
        pnlKumite.Name = "pnlKumite"
        pnlKumite.Size = New Size(200, 173)
        pnlKumite.TabIndex = 1

        lblKumite.AutoSize = True
        lblKumite.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblKumite.Location = New Point(57, 140)
        lblKumite.Name = "lblKumite"
        lblKumite.Size = New Size(87, 28)
        lblKumite.TabIndex = 1
        lblKumite.Text = "KUMITE"

        picKumite.Location = New Point(40, 10)
        picKumite.Name = "picKumite"
        picKumite.Size = New Size(120, 120)
        picKumite.SizeMode = PictureBoxSizeMode.Zoom
        picKumite.TabIndex = 0
        picKumite.TabStop = False

        pnlKata.Anchor = AnchorStyles.None
        pnlKata.Controls.Add(lblKata)
        pnlKata.Controls.Add(picKata)
        pnlKata.Location = New Point(685, 17)
        pnlKata.Name = "pnlKata"
        pnlKata.Size = New Size(200, 173)
        pnlKata.TabIndex = 2

        lblKata.AutoSize = True
        lblKata.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblKata.Location = New Point(69, 140)
        lblKata.Name = "lblKata"
        lblKata.Size = New Size(63, 28)
        lblKata.TabIndex = 1
        lblKata.Text = "KATA"

        picKata.Location = New Point(40, 10)
        picKata.Name = "picKata"
        picKata.Size = New Size(120, 120)
        picKata.SizeMode = PictureBoxSizeMode.Zoom
        picKata.TabIndex = 0
        picKata.TabStop = False

        pnlMatchResult.Anchor = AnchorStyles.None
        pnlMatchResult.Controls.Add(lblMatchResult)
        pnlMatchResult.Controls.Add(picMatchResult)
        pnlMatchResult.Location = New Point(57, 224)
        pnlMatchResult.Name = "pnlMatchResult"
        pnlMatchResult.Size = New Size(200, 173)
        pnlMatchResult.TabIndex = 3

        lblMatchResult.AutoSize = True
        lblMatchResult.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblMatchResult.Location = New Point(28, 140)
        lblMatchResult.Name = "lblMatchResult"
        lblMatchResult.Size = New Size(137, 28)
        lblMatchResult.TabIndex = 1
        lblMatchResult.Text = "Match Result"

        picMatchResult.Location = New Point(40, 10)
        picMatchResult.Name = "picMatchResult"
        picMatchResult.Size = New Size(120, 120)
        picMatchResult.SizeMode = PictureBoxSizeMode.Zoom
        picMatchResult.TabIndex = 0
        picMatchResult.TabStop = False

        pnlServerStatus.Anchor = AnchorStyles.None
        pnlServerStatus.BackColor = Color.White
        pnlServerStatus.BorderStyle = BorderStyle.FixedSingle
        pnlServerStatus.Controls.Add(lblServerStatusTitle)
        pnlServerStatus.Controls.Add(lblServerDetails)
        pnlServerStatus.Location = New Point(344, 235)
        pnlServerStatus.Name = "pnlServerStatus"
        pnlServerStatus.Size = New Size(254, 151)
        pnlServerStatus.TabIndex = 4

        lblServerStatusTitle.BackColor = Color.Crimson
        lblServerStatusTitle.Dock = DockStyle.Top
        lblServerStatusTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblServerStatusTitle.ForeColor = Color.White
        lblServerStatusTitle.Location = New Point(0, 0)
        lblServerStatusTitle.Name = "lblServerStatusTitle"
        lblServerStatusTitle.Size = New Size(252, 30)
        lblServerStatusTitle.TabIndex = 0
        lblServerStatusTitle.Text = "Kata Scoring Server Status"
        lblServerStatusTitle.TextAlign = ContentAlignment.MiddleCenter

        lblServerDetails.AutoSize = True
        lblServerDetails.Font = New Font("Consolas", 9.0F)
        lblServerDetails.Location = New Point(10, 50)
        lblServerDetails.Name = "lblServerDetails"
        lblServerDetails.Size = New Size(248, 36)
        lblServerDetails.TabIndex = 1
        lblServerDetails.Text = "Yabinya Server  [Unregistered]" & vbCrLf & "Local Server    [Unregistered]"

        btnKataServer.Anchor = AnchorStyles.None
        btnKataServer.BackColor = Color.White
        btnKataServer.FlatStyle = FlatStyle.Flat
        btnKataServer.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnKataServer.ForeColor = Color.SaddleBrown
        btnKataServer.Location = New Point(661, 288)
        btnKataServer.Name = "btnKataServer"
        btnKataServer.Size = New Size(248, 45)
        btnKataServer.TabIndex = 5
        btnKataServer.Text = "Kata Scoring Server"
        btnKataServer.UseVisualStyleBackColor = False

        btnManageJudge.Location = New Point(0, 0)
        btnManageJudge.Name = "btnManageJudge"
        btnManageJudge.Size = New Size(75, 23)
        btnManageJudge.TabIndex = 0

        Footer.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        Footer.Controls.Add(lblWeb)
        Footer.Controls.Add(lblAbout)
        Footer.Dock = DockStyle.Bottom
        Footer.Location = New Point(0, 535)
        Footer.Name = "Footer"
        Footer.Size = New Size(943, 40)
        Footer.TabIndex = 2

        lblWeb.AutoSize = True
        lblWeb.Location = New Point(390, 10)
        lblWeb.Name = "lblWeb"
        lblWeb.Size = New Size(169, 20)
        lblWeb.TabIndex = 0
        lblWeb.Text = "www.yabinyastudio.com"

        lblAbout.AutoSize = True
        lblAbout.Location = New Point(870, 10)
        lblAbout.Name = "lblAbout"
        lblAbout.Size = New Size(68, 20)
        lblAbout.TabIndex = 1
        lblAbout.TabStop = True
        lblAbout.Text = "About us"

        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(943, 575)
        Controls.Add(Body)
        Controls.Add(Header)
        Controls.Add(Footer)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Yabinya ScoringBoard Karate v3.0 | 2026"
        Header.ResumeLayout(False)
        Header.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        Body.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        pnlCompetitors.ResumeLayout(False)
        pnlCompetitors.PerformLayout()
        CType(picCompetitors, ComponentModel.ISupportInitialize).EndInit()
        pnlKumite.ResumeLayout(False)
        pnlKumite.PerformLayout()
        CType(picKumite, ComponentModel.ISupportInitialize).EndInit()
        pnlKata.ResumeLayout(False)
        pnlKata.PerformLayout()
        CType(picKata, ComponentModel.ISupportInitialize).EndInit()
        pnlMatchResult.ResumeLayout(False)
        pnlMatchResult.PerformLayout()
        CType(picMatchResult, ComponentModel.ISupportInitialize).EndInit()
        pnlServerStatus.ResumeLayout(False)
        pnlServerStatus.PerformLayout()
        Footer.ResumeLayout(False)
        Footer.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents btnActivation As System.Windows.Forms.Button
    Friend WithEvents lblActivationReq As System.Windows.Forms.Label
    Friend WithEvents lblTatamiValue As System.Windows.Forms.Label
    Friend WithEvents lblTatamiTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Body As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlCompetitors As System.Windows.Forms.Panel
    Friend WithEvents picCompetitors As System.Windows.Forms.PictureBox
    Friend WithEvents lblCompetitors As System.Windows.Forms.Label
    Friend WithEvents pnlKumite As System.Windows.Forms.Panel
    Friend WithEvents picKumite As System.Windows.Forms.PictureBox
    Friend WithEvents lblKumite As System.Windows.Forms.Label
    Friend WithEvents pnlKata As System.Windows.Forms.Panel
    Friend WithEvents picKata As System.Windows.Forms.PictureBox
    Friend WithEvents lblKata As System.Windows.Forms.Label
    Friend WithEvents pnlMatchResult As System.Windows.Forms.Panel
    Friend WithEvents picMatchResult As System.Windows.Forms.PictureBox
    Friend WithEvents lblMatchResult As System.Windows.Forms.Label
    Friend WithEvents pnlServerStatus As System.Windows.Forms.Panel
    Friend WithEvents lblServerStatusTitle As System.Windows.Forms.Label
    Friend WithEvents lblServerDetails As System.Windows.Forms.Label
    Friend WithEvents btnKataServer As System.Windows.Forms.Button
    Friend WithEvents btnManageJudge As System.Windows.Forms.Button
    Friend WithEvents Footer As System.Windows.Forms.Panel
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.LinkLabel

End Class