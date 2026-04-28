Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class KumiteMainControl
    Inherits Form

    ' --- Palet Warna Presisi ---
    Private ReadOnly COLOR_AKA As Color = Color.FromArgb(215, 25, 50)
    Private ReadOnly COLOR_AO As Color = Color.FromArgb(50, 150, 250)
    Private ReadOnly COLOR_GOLD As Color = Color.FromArgb(255, 204, 0)
    Private ReadOnly COLOR_BG_WINDOW As Color = Color.FromArgb(240, 240, 240)
    Private ReadOnly COLOR_PANEL_BG As Color = Color.White
    Private ReadOnly COLOR_FOOTER_BG As Color = Color.FromArgb(45, 45, 48)
    Private ReadOnly COLOR_TEXT_DARK As Color = Color.Black
    Private ReadOnly COLOR_TEXT_LIGHT As Color = Color.White
    Private ReadOnly COLOR_BORDER As Color = Color.FromArgb(180, 180, 180)

    ' --- Font Presisi ---
    Private ReadOnly FONT_DEFAULT As New Font("Segoe UI", 8.25F)
    Private ReadOnly FONT_BOLD As New Font("Segoe UI", 8.25F, FontStyle.Bold)
    Private ReadOnly FONT_HEADER As New Font("Segoe UI Black", 10.0F)
    Private ReadOnly FONT_SCORE_BIG As New Font("Impact", 50.0F)

    Public Sub New()
        Me.Text = "Kumite Main Control"
        Me.Size = New Size(1024, 730)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = COLOR_BG_WINDOW
        Me.Font = FONT_DEFAULT
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        InitializeComponentManual()
    End Sub

    Private Sub InitializeComponentManual()
        Me.Controls.Clear()

        ' 1. TOP BAR
        Dim pnlTop As New Panel With {.Bounds = New Rectangle(0, 0, 1008, 50), .BackColor = COLOR_PANEL_BG, .BorderStyle = BorderStyle.FixedSingle}
        BuildTopBar(pnlTop)
        Me.Controls.Add(pnlTop)

        ' 2. AKA PANEL
        Dim pnlAka As New Panel With {.Bounds = New Rectangle(5, 55, 760, 260), .BackColor = COLOR_PANEL_BG, .BorderStyle = BorderStyle.FixedSingle}
        BuildAthletePanel(pnlAka, "AKA", COLOR_AKA, "Siti Aminah", "Harimau Putih", "KKI", "0")
        Me.Controls.Add(pnlAka)

        ' 3. AO PANEL
        Dim pnlAo As New Panel With {.Bounds = New Rectangle(5, 320, 760, 260), .BackColor = COLOR_PANEL_BG, .BorderStyle = BorderStyle.FixedSingle}
        BuildAthletePanel(pnlAo, "AO", COLOR_AO, "Anisa Rahmawati", "Dojo Rajawali", "INKAI", "0")
        Me.Controls.Add(pnlAo)

        ' 4. RIGHT PANEL
        Dim pnlRight As New Panel With {.Bounds = New Rectangle(770, 55, 230, 525), .BackColor = COLOR_PANEL_BG, .BorderStyle = BorderStyle.FixedSingle}
        BuildRightPanel(pnlRight)
        Me.Controls.Add(pnlRight)

        ' 5. FOOTER (Bottom)
        Dim pnlFooter As New Panel With {.Bounds = New Rectangle(0, 585, 1008, 55), .BackColor = COLOR_FOOTER_BG}
        BuildFooter(pnlFooter)
        Me.Controls.Add(pnlFooter)
    End Sub

    Private Sub BuildTopBar(p As Panel)
        p.Controls.Add(CreateBtn("Next Match", 5, 10, 95, 30, COLOR_GOLD, COLOR_TEXT_DARK, FONT_BOLD))

        ' Membungkus Textbox dengan panel agar memiliki Border berwarna seperti digambar
        Dim pnlAkaSearch As New Panel With {.Bounds = New Rectangle(105, 12, 185, 25), .BackColor = COLOR_AKA, .Padding = New Padding(2)}
        Dim txtAkaSearch As New TextBox With {.Dock = DockStyle.Fill, .BorderStyle = BorderStyle.None}
        pnlAkaSearch.Controls.Add(txtAkaSearch)
        p.Controls.Add(pnlAkaSearch)

        p.Controls.Add(CreateBtn("👤", 295, 12, 35, 25, Color.WhiteSmoke, COLOR_TEXT_DARK))
        Dim lblVs As New Label With {.Text = "VS", .Bounds = New Rectangle(335, 10, 45, 30), .BackColor = COLOR_GOLD, .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Arial Black", 11)}
        p.Controls.Add(lblVs)
        p.Controls.Add(CreateBtn("👤", 385, 12, 35, 25, Color.WhiteSmoke, COLOR_TEXT_DARK))

        ' Membungkus Textbox dengan panel border biru
        Dim pnlAoSearch As New Panel With {.Bounds = New Rectangle(425, 12, 185, 25), .BackColor = COLOR_AO, .Padding = New Padding(2)}
        Dim txtAoSearch As New TextBox With {.Dock = DockStyle.Fill, .BorderStyle = BorderStyle.None}
        pnlAoSearch.Controls.Add(txtAoSearch)
        p.Controls.Add(pnlAoSearch)

        p.Controls.Add(CreateBtn("::", 615, 12, 30, 25, Color.DimGray, COLOR_TEXT_LIGHT))
        p.Controls.Add(CreateBtn("Load Next Match", 650, 10, 115, 30, COLOR_GOLD, COLOR_TEXT_DARK, FONT_BOLD))
    End Sub

    Private Sub BuildAthletePanel(p As Panel, side As String, clr As Color, n As String, t As String, info As String, scoreVal As String)
        Dim h As New Label With {.Text = side, .BackColor = clr, .ForeColor = COLOR_TEXT_LIGHT, .Dock = DockStyle.Top, .Height = 22, .TextAlign = ContentAlignment.MiddleCenter, .Font = FONT_HEADER}
        p.Controls.Add(h)

        ' Profile Circle
        Dim pic As New Panel With {.Bounds = New Rectangle(10, 35, 70, 70)}
        AddHandler pic.Paint, Sub(s, e)
                                  e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                                  e.Graphics.DrawEllipse(New Pen(Color.MediumPurple, 2), 2, 2, 65, 65)
                              End Sub
        p.Controls.Add(pic)

        p.Controls.Add(CreateBtn("Kiken", 10, 110, 75, 25, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("Shikkaku", 10, 140, 75, 25, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("Knocked Out", 10, 170, 75, 35, COLOR_PANEL_BG, COLOR_TEXT_DARK, New Font("Segoe UI", 7.5F)))

        ' Athlete Info Fields
        Dim line As New Panel With {.Bounds = New Rectangle(90, 35, 3, 75), .BackColor = COLOR_GOLD}
        p.Controls.Add(line)
        AddInput(p, "Name", 100, 32, n, 260)
        AddInput(p, "Team", 100, 58, t, 260)
        AddInput(p, "Team Info", 100, 84, info, 260)

        p.Controls.Add(CreateBtn("Update Info", 215, 115, 95, 25, Color.WhiteSmoke, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("⇅", 315, 115, 30, 25, Color.WhiteSmoke, COLOR_TEXT_DARK))

        ' Penalties
        Dim pens() As String = {"P", "1C", "2C", "3C", "HC", "H"}
        For i As Integer = 0 To pens.Length - 1
            p.Controls.Add(CreateBtn(pens(i), 100 + (i * 44), 150, 40, 35, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        Next

        ' Score Summary & VR
        Dim pSum As New Panel With {.Bounds = New Rectangle(100, 195, 185, 50), .BorderStyle = BorderStyle.FixedSingle, .BackColor = Color.FromArgb(245, 245, 245)}
        pSum.Controls.Add(New Label With {.Text = "Score Summary", .Dock = DockStyle.Top, .Height = 15, .TextAlign = ContentAlignment.MiddleCenter, .Font = FONT_BOLD})
        pSum.Controls.Add(New Label With {.Text = "Ippon: 0   Waza-ari: 0" & vbCrLf & "Yuko: 0", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter})
        p.Controls.Add(pSum)

        p.Controls.Add(CreateBtn("VR", 295, 195, 80, 25, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(New Label With {.Text = side & " VR Requested", .Bounds = New Rectangle(295, 225, 100, 15), .Font = New Font("Segoe UI", 7.0F)})

        ' List Log
        Dim lv As New ListView With {.View = View.Details, .Bounds = New Rectangle(420, 35, 230, 150), .GridLines = True}
        lv.Columns.Add("No", 35) : lv.Columns.Add("Timer", 65) : lv.Columns.Add("Type", 125)
        p.Controls.Add(lv)

        p.Controls.Add(CreateBtn("Show Winner", 420, 195, 80, 35, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("Reset Score", 510, 195, 75, 35, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("Senshu", 595, 195, 55, 35, COLOR_PANEL_BG, COLOR_TEXT_DARK))

        ' Score Area (Disesuaikan Posisinya di kanan list view, memanjang ke bawah)
        p.Controls.Add(New Label With {.Text = scoreVal, .Bounds = New Rectangle(670, 35, 80, 80), .Font = FONT_SCORE_BIG, .TextAlign = ContentAlignment.MiddleCenter})

        Dim scoreBg As Color = If(side = "AKA", Color.FromArgb(255, 210, 210), Color.FromArgb(210, 235, 255))
        Dim scoreFg As Color = If(side = "AKA", Color.DarkRed, Color.DarkBlue)

        p.Controls.Add(CreateBtn("Ippon 3", 670, 120, 80, 35, scoreBg, scoreFg))
        p.Controls.Add(CreateBtn("Waza-ari 2", 670, 160, 80, 35, scoreBg, scoreFg))
        p.Controls.Add(CreateBtn("Yuko 1", 670, 200, 80, 35, scoreBg, scoreFg))
    End Sub

    Private Sub BuildRightPanel(p As Panel)
        p.Controls.Add(New Label With {.Text = "SCBoard Type        Senshu Style", .Bounds = New Rectangle(10, 5, 200, 15), .Font = New Font("Segoe UI", 7.5F)})
        p.Controls.Add(CreateColorBox(10, 22, Color.Red, Color.Blue))
        p.Controls.Add(CreateColorBox(50, 22, COLOR_GOLD, Color.Blue))
        p.Controls.Add(CreateSenshuBox(130, 22, Color.Green, False))
        p.Controls.Add(CreateSenshuBox(165, 22, Color.Black, True))

        p.Controls.Add(New Label With {.Text = "Adjust Scboard Text Size", .Bounds = New Rectangle(10, 55, 200, 15)})
        p.Controls.Add(New ComboBox With {.Bounds = New Rectangle(10, 72, 90, 25), .DropDownStyle = ComboBoxStyle.DropDownList})
        p.Controls.Add(New NumericUpDown With {.Bounds = New Rectangle(105, 72, 45, 25), .DecimalPlaces = 1, .Increment = 0.1D, .Value = 1.5D})
        p.Controls.Add(CreateBtn("R", 155, 72, 20, 22, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("-", 180, 72, 20, 22, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("+", 205, 72, 20, 22, COLOR_PANEL_BG, COLOR_TEXT_DARK))

        p.Controls.Add(New Label With {.Text = "Match Detail", .Bounds = New Rectangle(10, 105, 100, 15)})
        p.Controls.Add(New Label With {.Text = "Match Logo", .Bounds = New Rectangle(150, 105, 70, 15)})

        p.Controls.Add(New TextBox With {.Multiline = True, .Bounds = New Rectangle(10, 122, 130, 55), .Text = "Match Description...", .BorderStyle = BorderStyle.FixedSingle})
        Dim picLogo As New Panel With {.Bounds = New Rectangle(150, 122, 55, 55), .BorderStyle = BorderStyle.FixedSingle, .BackColor = Color.White}
        p.Controls.Add(picLogo)
        p.Controls.Add(CreateBtn("↑", 210, 160, 18, 18, Color.WhiteSmoke, COLOR_TEXT_DARK, New Font("Arial", 6)))

        p.Controls.Add(New Label With {.Text = "Win. Point", .Bounds = New Rectangle(10, 195, 65, 20)})
        p.Controls.Add(New NumericUpDown With {.Bounds = New Rectangle(80, 193, 40, 25), .Value = 8})
        p.Controls.Add(CreateBtn("Edit", 125, 192, 60, 25, Color.WhiteSmoke, COLOR_TEXT_DARK))

        p.Controls.Add(New Label With {.Text = "Tatami", .Bounds = New Rectangle(10, 225, 65, 20)})
        p.Controls.Add(New NumericUpDown With {.Bounds = New Rectangle(80, 223, 40, 25), .Value = 1})
        p.Controls.Add(CreateBtn("Switch Position", 125, 222, 90, 25, Color.WhiteSmoke, COLOR_TEXT_DARK))

        ' Indikator kotak Red & Blue kecil untuk sisi tim Tatami
        p.Controls.Add(New Panel With {.Bounds = New Rectangle(218, 224, 10, 10), .BackColor = COLOR_AKA})
        p.Controls.Add(New Panel With {.Bounds = New Rectangle(218, 236, 10, 10), .BackColor = COLOR_AO})

        ' Timers
        Dim lblWait As New Label With {.Text = "Waiting Timer (minute:second)", .Bounds = New Rectangle(0, 255, 230, 20), .BackColor = Color.Beige, .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 7.5F)}
        p.Controls.Add(lblWait)
        p.Controls.Add(New NumericUpDown With {.Bounds = New Rectangle(10, 280, 40, 25), .Value = 2})
        p.Controls.Add(New Label With {.Text = ":", .Bounds = New Rectangle(52, 282, 10, 20), .Font = FONT_BOLD})
        p.Controls.Add(New NumericUpDown With {.Bounds = New Rectangle(65, 280, 40, 25)})
        p.Controls.Add(CreateBtn("Start", 120, 278, 95, 28, COLOR_GOLD, COLOR_TEXT_DARK, FONT_BOLD))

        Dim lblMatch As New Label With {.Text = "Match Timer (minute:second)", .Bounds = New Rectangle(0, 315, 230, 22), .BackColor = COLOR_GOLD, .TextAlign = ContentAlignment.MiddleCenter, .Font = FONT_BOLD}
        p.Controls.Add(lblMatch)
        p.Controls.Add(CreateBtn("1:30", 10, 345, 65, 25, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("2:00", 80, 345, 65, 25, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("3:00", 150, 345, 65, 25, COLOR_PANEL_BG, COLOR_TEXT_DARK))

        p.Controls.Add(New NumericUpDown With {.Bounds = New Rectangle(60, 380, 45, 25)})
        p.Controls.Add(New Label With {.Text = ":", .Bounds = New Rectangle(107, 382, 10, 20), .Font = FONT_BOLD})
        p.Controls.Add(New NumericUpDown With {.Bounds = New Rectangle(120, 380, 45, 25), .Value = 5})

        p.Controls.Add(New Label With {.Text = "Adjust" & vbCrLf & "Timer", .Bounds = New Rectangle(10, 410, 45, 40), .Font = New Font("Segoe UI", 7.5F), .TextAlign = ContentAlignment.MiddleCenter})
        Dim pDisp As New Panel With {.Bounds = New Rectangle(60, 410, 105, 40), .BackColor = COLOR_GOLD, .BorderStyle = BorderStyle.FixedSingle}
        pDisp.Controls.Add(New Label With {.Text = "0:05 .0", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Consolas", 15, FontStyle.Bold)})
        p.Controls.Add(pDisp)
        p.Controls.Add(CreateBtn("-", 170, 410, 25, 40, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("+", 200, 410, 25, 40, COLOR_PANEL_BG, COLOR_TEXT_DARK))

        ' Tombol Eksekusi Timer dengan Ikon kecil sesuai gambar
        p.Controls.Add(CreateBtn("⤢", 10, 460, 30, 30, Color.WhiteSmoke, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("Start Scoreboard  📊", 45, 460, 175, 30, Color.PaleGreen, COLOR_TEXT_DARK))

        p.Controls.Add(CreateBtn("⏱", 10, 495, 30, 30, Color.WhiteSmoke, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("Start Timer  ⏲", 45, 495, 175, 30, COLOR_GOLD, COLOR_TEXT_DARK, FONT_BOLD))
    End Sub

    Private Sub BuildFooter(p As Panel)
        ' Mengatur semua button footer agar presisi berada pada satu baris memanjang seperti pada gambar
        AddFooterButton(p, "Settings ⚙", 5, 8, 85)
        AddFooterButton(p, "Log Activity", 95, 8, 90)
        AddFooterButton(p, "Shortcut ⌨", 190, 8, 85)

        AddFooterButton(p, "🖥", 280, 8, 40)
        AddFooterButton(p, "🔊", 325, 8, 40)

        AddFooterButton(p, "Reset Hantei", 370, 8, 85)
        AddFooterButton(p, "Hantei 🚩", 460, 8, 80)
        AddFooterButton(p, "Hikiwake/Draw 🎌", 545, 8, 120)

        AddFooterButton(p, "Reset Match", 780, 8, 85)
        AddFooterButton(p, "Save Match Result 💾", 870, 8, 130)
    End Sub

    ' --- HELPER FUNCTIONS ---
    Private Function CreateBtn(t As String, x As Integer, y As Integer, w As Integer, h As Integer, bg As Color, fg As Color, Optional fnt As Font = Nothing) As Button
        If fnt Is Nothing Then fnt = FONT_DEFAULT
        Return New Button With {.Text = t, .Bounds = New Rectangle(x, y, w, h), .BackColor = bg, .ForeColor = fg, .FlatStyle = FlatStyle.Flat, .Font = fnt}
    End Function

    Private Sub AddInput(p As Panel, t As String, x As Integer, y As Integer, val As String, w As Integer)
        p.Controls.Add(New Label With {.Text = t, .Bounds = New Rectangle(x, y + 4, 65, 15)})
        p.Controls.Add(New TextBox With {.Text = val, .Bounds = New Rectangle(x + 65, y, w - 95, 23), .BorderStyle = BorderStyle.FixedSingle})
        p.Controls.Add(CreateBtn("🔍", x + w - 28, y, 22, 21, Color.WhiteSmoke, COLOR_TEXT_DARK))
    End Sub

    Private Sub AddFooterButton(p As Panel, t As String, x As Integer, y As Integer, w As Integer)
        p.Controls.Add(CreateBtn(t, x, y, w, 40, Color.White, Color.Black, FONT_BOLD))
    End Sub

    Private Function CreateColorBox(x As Integer, y As Integer, c1 As Color, c2 As Color) As Panel
        Dim p As New Panel With {.Bounds = New Rectangle(x, y, 30, 22), .BorderStyle = BorderStyle.FixedSingle}
        p.Controls.Add(New Panel With {.Dock = DockStyle.Left, .Width = 14, .BackColor = c1})
        p.Controls.Add(New Panel With {.Dock = DockStyle.Right, .Width = 14, .BackColor = c2})
        Return p
    End Function

    Private Function CreateSenshuBox(x As Integer, y As Integer, bg As Color, hasStrike As Boolean) As Panel
        Dim p As New Panel With {.Bounds = New Rectangle(x, y, 24, 24), .BackColor = bg, .BorderStyle = BorderStyle.FixedSingle}
        Dim lbl As New Label With {.Text = "S", .ForeColor = Color.Yellow, .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Arial Black", 8)}
        p.Controls.Add(lbl)
        If hasStrike Then
            AddHandler p.Paint, Sub(s, e) e.Graphics.DrawLine(New Pen(Color.Lime, 2), 0, 24, 24, 0)
        End If
        Return p
    End Function

    Private Sub KumiteMainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class