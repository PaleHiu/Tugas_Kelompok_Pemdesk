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
        ' ==========================================
        ' DEKLARASI KOMPONEN
        ' ==========================================
        Me.PnlBackground = New System.Windows.Forms.Panel()

        ' AKA (Merah)
        Me.LblAkaDotsTop = New System.Windows.Forms.Label()
        Me.LblAkaDotsBot = New System.Windows.Forms.Label()
        Me.LblAkaName = New System.Windows.Forms.Label()
        Me.LblAkaInfo = New System.Windows.Forms.Label()
        Me.PnlAkaScore = New System.Windows.Forms.Panel()
        Me.LblAkaScore = New System.Windows.Forms.Label()

        ' AO (Biru)
        Me.LblAoDotsTop = New System.Windows.Forms.Label()
        Me.LblAoDotsBot = New System.Windows.Forms.Label()
        Me.LblAoName = New System.Windows.Forms.Label()
        Me.LblAoInfo = New System.Windows.Forms.Label()
        Me.PnlAoScore = New System.Windows.Forms.Panel()
        Me.LblAoScore = New System.Windows.Forms.Label()

        ' Baris Penalti
        Me.PnlPenaltyBar = New System.Windows.Forms.Panel()
        Me.LblPenaltyTitle = New System.Windows.Forms.Label()

        ' Baris Bawah (Footer)
        Me.PnlFooter = New System.Windows.Forms.Panel()
        Me.LblTatamiTitle = New System.Windows.Forms.Label()
        Me.LblTatamiNum = New System.Windows.Forms.Label()
        Me.LblStudio = New System.Windows.Forms.Label()
        Me.LblTimerMain = New System.Windows.Forms.Label()
        Me.LblTimerMilli = New System.Windows.Forms.Label()
        Me.LblMatchDesc = New System.Windows.Forms.Label()

        Me.PnlBackground.SuspendLayout()
        Me.PnlAkaScore.SuspendLayout()
        Me.PnlAoScore.SuspendLayout()
        Me.PnlPenaltyBar.SuspendLayout()
        Me.PnlFooter.SuspendLayout()
        Me.SuspendLayout()

        ' ==========================================
        ' SETTING FORM UTAMA
        ' ==========================================
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(15, 15, 15) ' Latar sangat gelap
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None ' Fullscreen look
        Me.Name = "ScoreBoard"
        Me.Text = "Score Board"

        ' ==========================================
        ' AKA (SUDUT MERAH - KIRI)
        ' ==========================================
        Me.LblAkaDotsTop.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaDotsTop.ForeColor = System.Drawing.Color.Gold
        Me.LblAkaDotsTop.Location = New System.Drawing.Point(50, 50)
        Me.LblAkaDotsTop.Size = New System.Drawing.Size(500, 40)
        Me.LblAkaDotsTop.Text = "■ ■ ■"
        Me.LblAkaDotsTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.LblAkaDotsBot.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaDotsBot.ForeColor = System.Drawing.Color.White
        Me.LblAkaDotsBot.Location = New System.Drawing.Point(50, 90)
        Me.LblAkaDotsBot.Size = New System.Drawing.Size(500, 30)
        Me.LblAkaDotsBot.Text = "..."
        Me.LblAkaDotsBot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.LblAkaName.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaName.ForeColor = System.Drawing.Color.White
        Me.LblAkaName.Location = New System.Drawing.Point(50, 130)
        Me.LblAkaName.Size = New System.Drawing.Size(500, 90)
        Me.LblAkaName.Text = "Activation"
        Me.LblAkaName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.LblAkaInfo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaInfo.ForeColor = System.Drawing.Color.White
        Me.LblAkaInfo.Location = New System.Drawing.Point(50, 220)
        Me.LblAkaInfo.Size = New System.Drawing.Size(500, 40)
        Me.LblAkaInfo.Text = "Activation Required..."
        Me.LblAkaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' Kotak Skor Merah
        Me.PnlAkaScore.BackColor = System.Drawing.Color.FromArgb(180, 25, 40) ' Merah pekat
        Me.PnlAkaScore.Controls.Add(Me.LblAkaScore)
        Me.PnlAkaScore.Location = New System.Drawing.Point(230, 280)
        Me.PnlAkaScore.Size = New System.Drawing.Size(350, 220)

        Me.LblAkaScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAkaScore.Font = New System.Drawing.Font("Segoe UI", 120.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaScore.ForeColor = System.Drawing.Color.White
        Me.LblAkaScore.Text = "0"
        Me.LblAkaScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ==========================================
        ' AO (SUDUT BIRU - KANAN)
        ' ==========================================
        Me.LblAoDotsTop.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoDotsTop.ForeColor = System.Drawing.Color.Gold
        Me.LblAoDotsTop.Location = New System.Drawing.Point(730, 50)
        Me.LblAoDotsTop.Size = New System.Drawing.Size(500, 40)
        Me.LblAoDotsTop.Text = "■ ■ ■"
        Me.LblAoDotsTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.LblAoDotsBot.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoDotsBot.ForeColor = System.Drawing.Color.White
        Me.LblAoDotsBot.Location = New System.Drawing.Point(730, 90)
        Me.LblAoDotsBot.Size = New System.Drawing.Size(500, 30)
        Me.LblAoDotsBot.Text = "..."
        Me.LblAoDotsBot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.LblAoName.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoName.ForeColor = System.Drawing.Color.White
        Me.LblAoName.Location = New System.Drawing.Point(730, 130)
        Me.LblAoName.Size = New System.Drawing.Size(500, 90)
        Me.LblAoName.Text = "Activation"
        Me.LblAoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.LblAoInfo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoInfo.ForeColor = System.Drawing.Color.White
        Me.LblAoInfo.Location = New System.Drawing.Point(730, 220)
        Me.LblAoInfo.Size = New System.Drawing.Size(500, 40)
        Me.LblAoInfo.Text = "Activation Required..."
        Me.LblAoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' Kotak Skor Biru
        Me.PnlAoScore.BackColor = System.Drawing.Color.FromArgb(25, 110, 200) ' Biru pekat
        Me.PnlAoScore.Controls.Add(Me.LblAoScore)
        Me.PnlAoScore.Location = New System.Drawing.Point(700, 280)
        Me.PnlAoScore.Size = New System.Drawing.Size(350, 220)

        Me.LblAoScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAoScore.Font = New System.Drawing.Font("Segoe UI", 120.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoScore.ForeColor = System.Drawing.Color.White
        Me.LblAoScore.Text = "0"
        Me.LblAoScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ==========================================
        ' PENALTY BAR (TENGAH BAWAH)
        ' ==========================================
        Me.PnlPenaltyBar.BackColor = System.Drawing.Color.FromArgb(20, 20, 20)
        Me.PnlPenaltyBar.Location = New System.Drawing.Point(0, 520)
        Me.PnlPenaltyBar.Size = New System.Drawing.Size(1280, 50)

        Me.LblPenaltyTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblPenaltyTitle.ForeColor = System.Drawing.Color.Gold
        Me.LblPenaltyTitle.Location = New System.Drawing.Point(540, 0)
        Me.LblPenaltyTitle.Size = New System.Drawing.Size(200, 50)
        Me.LblPenaltyTitle.Text = "PENALTY"
        Me.LblPenaltyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblPenaltyTitle)

        ' Helper untuk membuat Label Penalti (1C, 2C, dst)
        Dim penAkaX As Integer = 10
        Dim penAoX As Integer = 1190
        Dim penalties() As String = {"1C", "2C", "3C", "HC", "H"}

        ' ==========================================================
        ' INISIALISASI LABEL PENALTI SECARA INDIVIDUAL (KODE FINAL)
        ' ==========================================================

        ' --- PENALTI AKA (SUDUT MERAH - KIRI KE KANAN) ---
        ' LblAkaPen1 (1C)
        Me.LblAkaPen1 = New System.Windows.Forms.Label()
        Me.LblAkaPen1.Text = "1C"
        Me.LblAkaPen1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaPen1.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAkaPen1.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAkaPen1.Size = New System.Drawing.Size(70, 35)
        Me.LblAkaPen1.Location = New System.Drawing.Point(10, 7)
        Me.LblAkaPen1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAkaPen1)

        ' LblAkaPen2 (2C)
        Me.LblAkaPen2 = New System.Windows.Forms.Label()
        Me.LblAkaPen2.Text = "2C"
        Me.LblAkaPen2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaPen2.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAkaPen2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAkaPen2.Size = New System.Drawing.Size(70, 35)
        Me.LblAkaPen2.Location = New System.Drawing.Point(95, 7)
        Me.LblAkaPen2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAkaPen2)

        ' LblAkaPen3 (3C)
        Me.LblAkaPen3 = New System.Windows.Forms.Label()
        Me.LblAkaPen3.Text = "3C"
        Me.LblAkaPen3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaPen3.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAkaPen3.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAkaPen3.Size = New System.Drawing.Size(70, 35)
        Me.LblAkaPen3.Location = New System.Drawing.Point(180, 7)
        Me.LblAkaPen3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAkaPen3)

        ' LblAkaPen4 (HC)
        Me.LblAkaPen4 = New System.Windows.Forms.Label()
        Me.LblAkaPen4.Text = "HC"
        Me.LblAkaPen4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaPen4.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAkaPen4.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAkaPen4.Size = New System.Drawing.Size(70, 35)
        Me.LblAkaPen4.Location = New System.Drawing.Point(265, 7)
        Me.LblAkaPen4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAkaPen4)

        ' LblAkaPen5 (H)
        Me.LblAkaPen5 = New System.Windows.Forms.Label()
        Me.LblAkaPen5.Text = "H"
        Me.LblAkaPen5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAkaPen5.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAkaPen5.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAkaPen5.Size = New System.Drawing.Size(70, 35)
        Me.LblAkaPen5.Location = New System.Drawing.Point(350, 7)
        Me.LblAkaPen5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAkaPen5)


        ' --- PENALTI AO (SUDUT BIRU - KANAN KE KIRI) ---
        ' LblAoPen1 (1C)
        Me.LblAoPen1 = New System.Windows.Forms.Label()
        Me.LblAoPen1.Text = "1C"
        Me.LblAoPen1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoPen1.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAoPen1.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAoPen1.Size = New System.Drawing.Size(70, 35)
        Me.LblAoPen1.Location = New System.Drawing.Point(1190, 7)
        Me.LblAoPen1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAoPen1)

        ' LblAoPen2 (2C)
        Me.LblAoPen2 = New System.Windows.Forms.Label()
        Me.LblAoPen2.Text = "2C"
        Me.LblAoPen2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoPen2.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAoPen2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAoPen2.Size = New System.Drawing.Size(70, 35)
        Me.LblAoPen2.Location = New System.Drawing.Point(1105, 7)
        Me.LblAoPen2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAoPen2)

        ' LblAoPen3 (3C)
        Me.LblAoPen3 = New System.Windows.Forms.Label()
        Me.LblAoPen3.Text = "3C"
        Me.LblAoPen3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoPen3.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAoPen3.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAoPen3.Size = New System.Drawing.Size(70, 35)
        Me.LblAoPen3.Location = New System.Drawing.Point(1020, 7)
        Me.LblAoPen3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAoPen3)

        ' LblAoPen4 (HC)
        Me.LblAoPen4 = New System.Windows.Forms.Label()
        Me.LblAoPen4.Text = "HC"
        Me.LblAoPen4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoPen4.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAoPen4.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAoPen4.Size = New System.Drawing.Size(70, 35)
        Me.LblAoPen4.Location = New System.Drawing.Point(935, 7)
        Me.LblAoPen4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAoPen4)

        ' LblAoPen5 (H)
        Me.LblAoPen5 = New System.Windows.Forms.Label()
        Me.LblAoPen5.Text = "H"
        Me.LblAoPen5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblAoPen5.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAoPen5.BackColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LblAoPen5.Size = New System.Drawing.Size(70, 35)
        Me.LblAoPen5.Location = New System.Drawing.Point(850, 7)
        Me.LblAoPen5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlPenaltyBar.Controls.Add(Me.LblAoPen5)

        ' ==========================================
        ' FOOTER (TATAMI, TIMER, DESC)
        ' ==========================================
        Me.PnlFooter.BackColor = System.Drawing.Color.FromArgb(25, 25, 25)
        Me.PnlFooter.Location = New System.Drawing.Point(0, 570)
        Me.PnlFooter.Size = New System.Drawing.Size(1280, 150)

        ' Tatami
        Me.LblTatamiTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblTatamiTitle.ForeColor = System.Drawing.Color.Gold
        Me.LblTatamiTitle.Location = New System.Drawing.Point(20, 10)
        Me.LblTatamiTitle.Size = New System.Drawing.Size(200, 50)
        Me.LblTatamiTitle.Text = "TATAMI"
        Me.PnlFooter.Controls.Add(Me.LblTatamiTitle)

        Me.LblTatamiNum.Font = New System.Drawing.Font("Segoe UI", 55.0!, System.Drawing.FontStyle.Bold)
        Me.LblTatamiNum.ForeColor = System.Drawing.Color.White
        Me.LblTatamiNum.Location = New System.Drawing.Point(20, 50)
        Me.LblTatamiNum.Size = New System.Drawing.Size(150, 90)
        Me.LblTatamiNum.Text = "1"
        Me.LblTatamiNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PnlFooter.Controls.Add(Me.LblTatamiNum)

        ' Logo/Teks Studio
        Me.LblStudio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.LblStudio.ForeColor = System.Drawing.Color.LightGray
        Me.LblStudio.Location = New System.Drawing.Point(180, 60)
        Me.LblStudio.Size = New System.Drawing.Size(200, 30)
        Me.LblStudio.Text = ""
        Me.PnlFooter.Controls.Add(Me.LblStudio)

        ' Timer Utama (Besar)
        Me.LblTimerMain.Font = New System.Drawing.Font("Segoe UI", 90.0!, System.Drawing.FontStyle.Bold)
        Me.LblTimerMain.ForeColor = System.Drawing.Color.White
        Me.LblTimerMain.Location = New System.Drawing.Point(400, -15)
        Me.LblTimerMain.Size = New System.Drawing.Size(400, 150)
        Me.LblTimerMain.Text = "2:00"
        Me.LblTimerMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PnlFooter.Controls.Add(Me.LblTimerMain)

        ' Timer Milidetik (Kecil)
        Me.LblTimerMilli.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold)
        Me.LblTimerMilli.ForeColor = System.Drawing.Color.White
        Me.LblTimerMilli.Location = New System.Drawing.Point(780, 40)
        Me.LblTimerMilli.Size = New System.Drawing.Size(150, 90)
        Me.LblTimerMilli.Text = ".0"
        Me.LblTimerMilli.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.PnlFooter.Controls.Add(Me.LblTimerMilli)

        ' Deskripsi Match
        Me.LblMatchDesc.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblMatchDesc.ForeColor = System.Drawing.Color.Gold
        Me.LblMatchDesc.Location = New System.Drawing.Point(850, 50)
        Me.LblMatchDesc.Size = New System.Drawing.Size(400, 50)
        Me.LblMatchDesc.Text = ""
        Me.LblMatchDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PnlFooter.Controls.Add(Me.LblMatchDesc)

        ' ==========================================
        ' ADD CONTROLS TO FORM
        ' ==========================================
        Me.Controls.Add(Me.PnlPenaltyBar)
        Me.Controls.Add(Me.PnlFooter)
        Me.Controls.Add(Me.PnlAkaScore)
        Me.Controls.Add(Me.LblAkaInfo)
        Me.Controls.Add(Me.LblAkaName)
        Me.Controls.Add(Me.LblAkaDotsBot)
        Me.Controls.Add(Me.LblAkaDotsTop)
        Me.Controls.Add(Me.PnlAoScore)
        Me.Controls.Add(Me.LblAoInfo)
        Me.Controls.Add(Me.LblAoName)
        Me.Controls.Add(Me.LblAoDotsBot)
        Me.Controls.Add(Me.LblAoDotsTop)

        Me.PnlAkaScore.ResumeLayout(False)
        Me.PnlAoScore.ResumeLayout(False)
        Me.PnlPenaltyBar.ResumeLayout(False)
        Me.PnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

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
End Class