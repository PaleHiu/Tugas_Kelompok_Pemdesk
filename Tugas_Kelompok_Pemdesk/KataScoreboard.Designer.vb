<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KataScoreboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        pnlAka = New Panel()
        lblAkaScore = New Label()
        lblAkaScoreTitle = New Label()
        lblAkaTeamName = New Label()
        lblAkaTeamTitle = New Label()
        lblAkaCompetitorName = New Label()
        lblAkaCompetitorTitle = New Label()
        lblAkaHeader = New Label()
        pnlAo = New Panel()
        lblAoScore = New Label()
        lblAoScoreTitle = New Label()
        lblAoTeamName = New Label()
        lblAoTeamTitle = New Label()
        lblAoCompetitorName = New Label()
        lblAoCompetitorTitle = New Label()
        lblAoHeader = New Label()
        pnlFooter = New Panel()
        lblTatami = New Label()
        lblStudio = New Label()
        pnlAka.SuspendLayout()
        pnlAo.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Arial", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Yellow
        lblTitle.Location = New Point(0, 0)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1400, 115)
        lblTitle.TabIndex = 0
        lblTitle.Text = "KATA Scoring Board"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlAka
        ' 
        pnlAka.Anchor = AnchorStyles.None
        pnlAka.BackColor = Color.FromArgb(CByte(40), CByte(0), CByte(0))
        pnlAka.BorderStyle = BorderStyle.FixedSingle
        pnlAka.Controls.Add(lblAkaScore)
        pnlAka.Controls.Add(lblAkaScoreTitle)
        pnlAka.Controls.Add(lblAkaTeamName)
        pnlAka.Controls.Add(lblAkaTeamTitle)
        pnlAka.Controls.Add(lblAkaCompetitorName)
        pnlAka.Controls.Add(lblAkaCompetitorTitle)
        pnlAka.Controls.Add(lblAkaHeader)
        pnlAka.Location = New Point(58, 173)
        pnlAka.Margin = New Padding(4, 3, 4, 3)
        pnlAka.Name = "pnlAka"
        pnlAka.Size = New Size(583, 577)
        pnlAka.TabIndex = 1
        ' 
        ' lblAkaScore
        ' 
        lblAkaScore.AutoSize = True
        lblAkaScore.Font = New Font("Arial", 48.0F, FontStyle.Bold)
        lblAkaScore.ForeColor = Color.Yellow
        lblAkaScore.Location = New Point(35, 438)
        lblAkaScore.Margin = New Padding(4, 0, 4, 0)
        lblAkaScore.Name = "lblAkaScore"
        lblAkaScore.Size = New Size(68, 75)
        lblAkaScore.TabIndex = 6
        lblAkaScore.Text = "0"
        ' 
        ' lblAkaScoreTitle
        ' 
        lblAkaScoreTitle.AutoSize = True
        lblAkaScoreTitle.Font = New Font("Arial", 16.0F)
        lblAkaScoreTitle.ForeColor = Color.White
        lblAkaScoreTitle.Location = New Point(23, 392)
        lblAkaScoreTitle.Margin = New Padding(4, 0, 4, 0)
        lblAkaScoreTitle.Name = "lblAkaScoreTitle"
        lblAkaScoreTitle.Size = New Size(76, 25)
        lblAkaScoreTitle.TabIndex = 5
        lblAkaScoreTitle.Text = "Score:"
        ' 
        ' lblAkaTeamName
        ' 
        lblAkaTeamName.AutoSize = True
        lblAkaTeamName.Font = New Font("Arial", 16.0F)
        lblAkaTeamName.ForeColor = Color.Yellow
        lblAkaTeamName.Location = New Point(35, 300)
        lblAkaTeamName.Margin = New Padding(4, 0, 4, 0)
        lblAkaTeamName.Name = "lblAkaTeamName"
        lblAkaTeamName.Size = New Size(19, 25)
        lblAkaTeamName.TabIndex = 4
        lblAkaTeamName.Text = "-"
        ' 
        ' lblAkaTeamTitle
        ' 
        lblAkaTeamTitle.AutoSize = True
        lblAkaTeamTitle.Font = New Font("Arial", 16.0F)
        lblAkaTeamTitle.ForeColor = Color.White
        lblAkaTeamTitle.Location = New Point(23, 254)
        lblAkaTeamTitle.Margin = New Padding(4, 0, 4, 0)
        lblAkaTeamTitle.Name = "lblAkaTeamTitle"
        lblAkaTeamTitle.Size = New Size(72, 25)
        lblAkaTeamTitle.TabIndex = 3
        lblAkaTeamTitle.Text = "Team:"
        ' 
        ' lblAkaCompetitorName
        ' 
        lblAkaCompetitorName.AutoSize = True
        lblAkaCompetitorName.Font = New Font("Arial", 16.0F)
        lblAkaCompetitorName.ForeColor = Color.Yellow
        lblAkaCompetitorName.Location = New Point(35, 173)
        lblAkaCompetitorName.Margin = New Padding(4, 0, 4, 0)
        lblAkaCompetitorName.Name = "lblAkaCompetitorName"
        lblAkaCompetitorName.Size = New Size(19, 25)
        lblAkaCompetitorName.TabIndex = 2
        lblAkaCompetitorName.Text = "-"
        ' 
        ' lblAkaCompetitorTitle
        ' 
        lblAkaCompetitorTitle.AutoSize = True
        lblAkaCompetitorTitle.Font = New Font("Arial", 16.0F)
        lblAkaCompetitorTitle.ForeColor = Color.White
        lblAkaCompetitorTitle.Location = New Point(23, 127)
        lblAkaCompetitorTitle.Margin = New Padding(4, 0, 4, 0)
        lblAkaCompetitorTitle.Name = "lblAkaCompetitorTitle"
        lblAkaCompetitorTitle.Size = New Size(126, 25)
        lblAkaCompetitorTitle.TabIndex = 1
        lblAkaCompetitorTitle.Text = "Competitor:"
        ' 
        ' lblAkaHeader
        ' 
        lblAkaHeader.AutoSize = True
        lblAkaHeader.Font = New Font("Arial", 24.0F, FontStyle.Bold)
        lblAkaHeader.ForeColor = Color.Red
        lblAkaHeader.Location = New Point(23, 23)
        lblAkaHeader.Margin = New Padding(4, 0, 4, 0)
        lblAkaHeader.Name = "lblAkaHeader"
        lblAkaHeader.Size = New Size(86, 37)
        lblAkaHeader.TabIndex = 0
        lblAkaHeader.Text = "AKA"
        ' 
        ' pnlAo
        ' 
        pnlAo.Anchor = AnchorStyles.None
        pnlAo.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(40))
        pnlAo.BorderStyle = BorderStyle.FixedSingle
        pnlAo.Controls.Add(lblAoScore)
        pnlAo.Controls.Add(lblAoScoreTitle)
        pnlAo.Controls.Add(lblAoTeamName)
        pnlAo.Controls.Add(lblAoTeamTitle)
        pnlAo.Controls.Add(lblAoCompetitorName)
        pnlAo.Controls.Add(lblAoCompetitorTitle)
        pnlAo.Controls.Add(lblAoHeader)
        pnlAo.Location = New Point(758, 173)
        pnlAo.Margin = New Padding(4, 3, 4, 3)
        pnlAo.Name = "pnlAo"
        pnlAo.Size = New Size(583, 577)
        pnlAo.TabIndex = 2
        ' 
        ' lblAoScore
        ' 
        lblAoScore.AutoSize = True
        lblAoScore.Font = New Font("Arial", 48.0F, FontStyle.Bold)
        lblAoScore.ForeColor = Color.Yellow
        lblAoScore.Location = New Point(35, 438)
        lblAoScore.Margin = New Padding(4, 0, 4, 0)
        lblAoScore.Name = "lblAoScore"
        lblAoScore.Size = New Size(68, 75)
        lblAoScore.TabIndex = 13
        lblAoScore.Text = "0"
        ' 
        ' lblAoScoreTitle
        ' 
        lblAoScoreTitle.AutoSize = True
        lblAoScoreTitle.Font = New Font("Arial", 16.0F)
        lblAoScoreTitle.ForeColor = Color.White
        lblAoScoreTitle.Location = New Point(23, 392)
        lblAoScoreTitle.Margin = New Padding(4, 0, 4, 0)
        lblAoScoreTitle.Name = "lblAoScoreTitle"
        lblAoScoreTitle.Size = New Size(76, 25)
        lblAoScoreTitle.TabIndex = 12
        lblAoScoreTitle.Text = "Score:"
        ' 
        ' lblAoTeamName
        ' 
        lblAoTeamName.AutoSize = True
        lblAoTeamName.Font = New Font("Arial", 16.0F)
        lblAoTeamName.ForeColor = Color.Yellow
        lblAoTeamName.Location = New Point(35, 300)
        lblAoTeamName.Margin = New Padding(4, 0, 4, 0)
        lblAoTeamName.Name = "lblAoTeamName"
        lblAoTeamName.Size = New Size(19, 25)
        lblAoTeamName.TabIndex = 11
        lblAoTeamName.Text = "-"
        ' 
        ' lblAoTeamTitle
        ' 
        lblAoTeamTitle.AutoSize = True
        lblAoTeamTitle.Font = New Font("Arial", 16.0F)
        lblAoTeamTitle.ForeColor = Color.White
        lblAoTeamTitle.Location = New Point(23, 254)
        lblAoTeamTitle.Margin = New Padding(4, 0, 4, 0)
        lblAoTeamTitle.Name = "lblAoTeamTitle"
        lblAoTeamTitle.Size = New Size(72, 25)
        lblAoTeamTitle.TabIndex = 10
        lblAoTeamTitle.Text = "Team:"
        ' 
        ' lblAoCompetitorName
        ' 
        lblAoCompetitorName.AutoSize = True
        lblAoCompetitorName.Font = New Font("Arial", 16.0F)
        lblAoCompetitorName.ForeColor = Color.Yellow
        lblAoCompetitorName.Location = New Point(35, 173)
        lblAoCompetitorName.Margin = New Padding(4, 0, 4, 0)
        lblAoCompetitorName.Name = "lblAoCompetitorName"
        lblAoCompetitorName.Size = New Size(19, 25)
        lblAoCompetitorName.TabIndex = 9
        lblAoCompetitorName.Text = "-"
        ' 
        ' lblAoCompetitorTitle
        ' 
        lblAoCompetitorTitle.AutoSize = True
        lblAoCompetitorTitle.Font = New Font("Arial", 16.0F)
        lblAoCompetitorTitle.ForeColor = Color.White
        lblAoCompetitorTitle.Location = New Point(23, 127)
        lblAoCompetitorTitle.Margin = New Padding(4, 0, 4, 0)
        lblAoCompetitorTitle.Name = "lblAoCompetitorTitle"
        lblAoCompetitorTitle.Size = New Size(126, 25)
        lblAoCompetitorTitle.TabIndex = 8
        lblAoCompetitorTitle.Text = "Competitor:"
        ' 
        ' lblAoHeader
        ' 
        lblAoHeader.AutoSize = True
        lblAoHeader.Font = New Font("Arial", 24.0F, FontStyle.Bold)
        lblAoHeader.ForeColor = Color.Blue
        lblAoHeader.Location = New Point(23, 23)
        lblAoHeader.Margin = New Padding(4, 0, 4, 0)
        lblAoHeader.Name = "lblAoHeader"
        lblAoHeader.Size = New Size(64, 37)
        lblAoHeader.TabIndex = 7
        lblAoHeader.Text = "AO"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        pnlFooter.Controls.Add(lblTatami)
        pnlFooter.Controls.Add(lblStudio)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 808)
        pnlFooter.Margin = New Padding(4, 3, 4, 3)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(1400, 115)
        pnlFooter.TabIndex = 3
        ' 
        ' lblTatami
        ' 
        lblTatami.Dock = DockStyle.Right
        lblTatami.Font = New Font("Arial", 20.0F, FontStyle.Bold)
        lblTatami.ForeColor = Color.White
        lblTatami.Location = New Point(933, 0)
        lblTatami.Margin = New Padding(4, 0, 4, 0)
        lblTatami.Name = "lblTatami"
        lblTatami.Padding = New Padding(0, 0, 23, 0)
        lblTatami.Size = New Size(467, 115)
        lblTatami.TabIndex = 1
        lblTatami.Text = "TATAMI  1"
        lblTatami.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblStudio
        ' 
        lblStudio.Dock = DockStyle.Left
        lblStudio.Font = New Font("Arial", 20.0F, FontStyle.Bold)
        lblStudio.ForeColor = Color.White
        lblStudio.Location = New Point(0, 0)
        lblStudio.Margin = New Padding(4, 0, 4, 0)
        lblStudio.Name = "lblStudio"
        lblStudio.Padding = New Padding(23, 0, 0, 0)
        lblStudio.Size = New Size(467, 115)
        lblStudio.TabIndex = 0
        lblStudio.Text = "Kelompok 2"
        lblStudio.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' KataScoreboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1400, 923)
        Controls.Add(pnlFooter)
        Controls.Add(pnlAo)
        Controls.Add(pnlAka)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "KataScoreboard"
        Text = "KataScoreboard"
        WindowState = FormWindowState.Maximized
        pnlAka.ResumeLayout(False)
        pnlAka.PerformLayout()
        pnlAo.ResumeLayout(False)
        pnlAo.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlAka As System.Windows.Forms.Panel
    Friend WithEvents lblAkaHeader As System.Windows.Forms.Label
    Friend WithEvents lblAkaScore As System.Windows.Forms.Label
    Friend WithEvents lblAkaScoreTitle As System.Windows.Forms.Label
    Friend WithEvents lblAkaTeamName As System.Windows.Forms.Label
    Friend WithEvents lblAkaTeamTitle As System.Windows.Forms.Label
    Friend WithEvents lblAkaCompetitorName As System.Windows.Forms.Label
    Friend WithEvents lblAkaCompetitorTitle As System.Windows.Forms.Label
    Friend WithEvents pnlAo As System.Windows.Forms.Panel
    Friend WithEvents lblAoScore As System.Windows.Forms.Label
    Friend WithEvents lblAoScoreTitle As System.Windows.Forms.Label
    Friend WithEvents lblAoTeamName As System.Windows.Forms.Label
    Friend WithEvents lblAoTeamTitle As System.Windows.Forms.Label
    Friend WithEvents lblAoCompetitorName As System.Windows.Forms.Label
    Friend WithEvents lblAoCompetitorTitle As System.Windows.Forms.Label
    Friend WithEvents lblAoHeader As System.Windows.Forms.Label
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblTatami As System.Windows.Forms.Label
    Friend WithEvents lblStudio As System.Windows.Forms.Label
End Class