Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Partial Public Class KumiteMainControl
    Inherits Form

    ' ==========================================================
    ' BAGIAN 1: DEKLARASI SISTEM DESAIN & VARIABEL KOMPONEN UI
    ' ==========================================================
    ' --- Palet Warna Presisi ---
    Friend ReadOnly COLOR_AKA As Color = Color.FromArgb(215, 25, 50)
    Friend ReadOnly COLOR_AO As Color = Color.FromArgb(50, 150, 250)
    Friend ReadOnly COLOR_GOLD As Color = Color.FromArgb(255, 204, 0)
    Friend ReadOnly COLOR_BG_WINDOW As Color = Color.FromArgb(240, 240, 240)
    Friend ReadOnly COLOR_PANEL_BG As Color = Color.White
    Friend ReadOnly COLOR_FOOTER_BG As Color = Color.FromArgb(45, 45, 48)
    Friend ReadOnly COLOR_TEXT_DARK As Color = Color.Black
    Friend ReadOnly COLOR_TEXT_LIGHT As Color = Color.White
    Friend ReadOnly COLOR_BORDER As Color = Color.FromArgb(180, 180, 180)

    ' --- Font Presisi ---
    Friend ReadOnly FONT_DEFAULT As New Font("Segoe UI", 8.25F)
    Friend ReadOnly FONT_BOLD As New Font("Segoe UI", 8.25F, FontStyle.Bold)
    Friend ReadOnly FONT_HEADER As New Font("Segoe UI Black", 10.0F)
    Friend ReadOnly FONT_SCORE_BIG As New Font("Impact", 50.0F)

    ' --- Komponen UI Interaktif (Diakses oleh Logic) ---
    Friend WithEvents waitTimer As New Timer() With {.Interval = 1000}
    Friend numWaitMin As NumericUpDown
    Friend numWaitSec As NumericUpDown
    Friend btnStartWaitTimer As Button
    Friend btnHantei As Button

    ' ==========================================================
    ' BAGIAN 2: INISIALISASI TATA LETAK (LAYOUTING)
    ' ==========================================================
    Protected Sub InitializeComponentManual()
        Me.Controls.Clear()

        ' 1. TOP BAR
        Dim pnlTop As New Panel With {
            .Bounds = New Rectangle(0, 0, 1008, 50),
            .BackColor = COLOR_PANEL_BG,
            .BorderStyle = BorderStyle.FixedSingle
        }
        BuildTopBar(pnlTop)
        Me.Controls.Add(pnlTop)

        ' 2. AKA PANEL
        Dim pnlAka As New Panel With {
            .Bounds = New Rectangle(5, 55, 760, 255),
            .BackColor = COLOR_PANEL_BG,
            .BorderStyle = BorderStyle.FixedSingle
        }
        BuildAthletePanel(pnlAka, "AKA", COLOR_AKA, "Siti Aminah", "Harimau Putih", "KKI", "0")
        Me.Controls.Add(pnlAka)

        ' 3. AO PANEL
        Dim pnlAo As New Panel With {
            .Bounds = New Rectangle(5, 315, 760, 255),
            .BackColor = COLOR_PANEL_BG,
            .BorderStyle = BorderStyle.FixedSingle
        }
        BuildAthletePanel(pnlAo, "AO", COLOR_AO, "Anisa Rahmawati", "Dojo Rajawali", "INKAI", "0")
        Me.Controls.Add(pnlAo)

        ' 4. RIGHT PANEL
        Dim pnlRight As New Panel With {
            .Bounds = New Rectangle(770, 55, 238, 515),
            .BackColor = COLOR_PANEL_BG,
            .BorderStyle = BorderStyle.FixedSingle
        }
        BuildRightPanel(pnlRight)
        Me.Controls.Add(pnlRight)

        ' 5. FOOTER (Bottom)
        Dim pnlFooter As New Panel With {
            .Bounds = New Rectangle(0, 575, 1008, 55),
            .BackColor = COLOR_FOOTER_BG
        }
        BuildFooter(pnlFooter)
        Me.Controls.Add(pnlFooter)
    End Sub

    ' ----------------------------------------------------------
    ' TOP BAR: Next Match | [AKA Search] [👤] VS [👤] [AO Search] [::] Load Next Match
    ' ----------------------------------------------------------
    Private Sub BuildTopBar(p As Panel)
        ' Tombol Next Match (kiri, kuning)
        p.Controls.Add(CreateBtn("Next Match", 5, 10, 95, 30, COLOR_GOLD, COLOR_TEXT_DARK, FONT_BOLD))

        ' Search box AKA: panel merah dengan TextBox putih di tengah
        Dim pnlAkaSearch As New Panel With {
            .Bounds = New Rectangle(105, 10, 200, 30),
            .BackColor = COLOR_AKA,
            .Padding = New Padding(3)
        }
        Dim txtAkaSearch As New TextBox With {
            .Dock = DockStyle.Fill,
            .BorderStyle = BorderStyle.None,
            .BackColor = Color.White,
            .ForeColor = COLOR_TEXT_DARK,
            .Font = FONT_DEFAULT
        }
        pnlAkaSearch.Controls.Add(txtAkaSearch)
        p.Controls.Add(pnlAkaSearch)

        ' Tombol pilih kompetitor AKA (ikon orang)
        p.Controls.Add(CreateBtn("👤", 310, 12, 28, 26, Color.FromArgb(220, 220, 220), COLOR_TEXT_DARK))

        ' Label VS (tengah, kuning)
        Dim lblVs As New Label With {
            .Text = "VS",
            .Bounds = New Rectangle(343, 10, 45, 30),
            .BackColor = COLOR_GOLD,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Arial Black", 11)
        }
        p.Controls.Add(lblVs)

        ' Tombol pilih kompetitor AO (ikon orang)
        p.Controls.Add(CreateBtn("👤", 393, 12, 28, 26, Color.FromArgb(220, 220, 220), COLOR_TEXT_DARK))

        ' Search box AO: panel biru dengan TextBox putih di tengah
        Dim pnlAoSearch As New Panel With {
            .Bounds = New Rectangle(426, 10, 200, 30),
            .BackColor = COLOR_AO,
            .Padding = New Padding(3)
        }
        Dim txtAoSearch As New TextBox With {
            .Dock = DockStyle.Fill,
            .BorderStyle = BorderStyle.None,
            .BackColor = Color.White,
            .ForeColor = COLOR_TEXT_DARK,
            .Font = FONT_DEFAULT
        }
        pnlAoSearch.Controls.Add(txtAoSearch)
        p.Controls.Add(pnlAoSearch)

        ' Tombol "::" (tengah, abu-abu gelap)
        p.Controls.Add(CreateBtn("::", 631, 12, 28, 26, Color.DimGray, COLOR_TEXT_LIGHT))

        ' Tombol Load Next Match (kanan, kuning)
        p.Controls.Add(CreateBtn("Load Next Match", 664, 10, 120, 30, COLOR_GOLD, COLOR_TEXT_DARK, FONT_BOLD))
    End Sub

    ' ----------------------------------------------------------
    ' ATHLETE PANEL: AKA atau AO (Versi Presisi)
    ' ----------------------------------------------------------
    Private Sub BuildAthletePanel(p As Panel, side As String, clr As Color,
                                  n As String, t As String, info As String, scoreVal As String)

        ' ══════════════════════════════════════════════════════════
        ' [A] HEADER BAR berwarna penuh (AKA=merah, AO=biru)
        ' ══════════════════════════════════════════════════════════
        Dim h As New Label With {
            .Text = side,
            .BackColor = clr,
            .ForeColor = COLOR_TEXT_LIGHT,
            .Dock = DockStyle.Top,
            .Height = 26,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = FONT_HEADER
        }
        p.Controls.Add(h)

        ' ══════════════════════════════════════════════════════════
        ' [B] KOLOM KIRI: Avatar lingkaran + Kiken/Shikkaku/KO
        ' ══════════════════════════════════════════════════════════
        ' Avatar lingkaran ungu (placeholder foto)
        Dim pic As New Panel With {.Bounds = New Rectangle(12, 34, 68, 68), .BackColor = Color.Transparent}
        AddHandler pic.Paint, Sub(s2, e2)
                                  e2.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                                  Using pen As New Pen(Color.MediumPurple, 2)
                                      e2.Graphics.DrawEllipse(pen, 1, 1, 65, 65)
                                  End Using
                              End Sub
        p.Controls.Add(pic)

        ' Tombol Kiken / Shikkaku / Knocked Out (di bawah avatar)
        ' Menggunakan FlatAppearance untuk tampilan bersih tanpa border tebal
        Dim btnKiken As Button = CreateBtnClean("Kiken", 8, 108, 78, 28)
        Dim btnShikkaku As Button = CreateBtnClean("Shikkaku", 8, 140, 78, 28)
        Dim btnKO As Button = CreateBtnClean("Knocked Out", 8, 172, 78, 40)
        btnKO.Font = New Font("Segoe UI", 7.5F)
        p.Controls.Add(btnKiken)
        p.Controls.Add(btnShikkaku)
        p.Controls.Add(btnKO)

        ' ══════════════════════════════════════════════════════════
        ' [C] GARIS KUNING VERTIKAL TIPIS (pemisah kiri & tengah)
        ' ══════════════════════════════════════════════════════════
        Dim line As New Panel With {
            .Bounds = New Rectangle(91, 34, 2, 78),
            .BackColor = COLOR_GOLD
        }
        p.Controls.Add(line)

        ' ══════════════════════════════════════════════════════════
        ' [D] KOLOM TENGAH-KIRI: Name (👤), Team (🔍), Team Info
        '     Field kosong (placeholder), data di-load saat runtime
        ' ══════════════════════════════════════════════════════════
        Dim xBase As Integer = 96
        Dim lblW As Integer = 60
        Dim txtW As Integer = 175
        Dim icoW As Integer = 24

        ' Name + ikon orang
        p.Controls.Add(MakeLabel("Name", xBase, 38, lblW))
        p.Controls.Add(MakeTxtBox("", xBase + lblW, 34, txtW))
        p.Controls.Add(CreateBtnIcon("👤", xBase + lblW + txtW + 2, 34, icoW))

        ' Team + ikon kaca pembesar
        p.Controls.Add(MakeLabel("Team", xBase, 62, lblW))
        p.Controls.Add(MakeTxtBox("", xBase + lblW, 58, txtW))
        p.Controls.Add(CreateBtnIcon("🔍", xBase + lblW + txtW + 2, 58, icoW))

        ' Team Info — TANPA ikon (sesuai desain asli)
        p.Controls.Add(MakeLabel("Team Info", xBase, 86, lblW))
        p.Controls.Add(MakeTxtBox("", xBase + lblW, 82, txtW))
        ' Kotak kosong kecil kanan Team Info (logo team placeholder)
        Dim pnlLogo As New Panel With {
            .Bounds = New Rectangle(xBase + lblW + txtW + 2, 82, 28, 23),
            .BackColor = Color.White,
            .BorderStyle = BorderStyle.FixedSingle
        }
        p.Controls.Add(pnlLogo)

        ' Tombol Update Info (abu-abu muda bergradasi) + ⇅
        ' Gunakan warna lebih muda supaya terlihat subtle seperti aslinya
        Dim btnUpdate As New Button With {
            .Text = "Update Info",
            .Bounds = New Rectangle(xBase + lblW + 12, 112, 105, 26),
            .BackColor = Color.FromArgb(230, 230, 230),
            .ForeColor = COLOR_TEXT_DARK,
            .FlatStyle = FlatStyle.Flat,
            .Font = FONT_DEFAULT
        }
        btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180)
        p.Controls.Add(btnUpdate)
        p.Controls.Add(CreateBtnIcon("⇅", xBase + lblW + 122, 112, 26))

        ' ══════════════════════════════════════════════════════════
        ' [E] TOMBOL PENALTY: P 1C 2C 3C HC H
        '     Teks center, ukuran seragam, border tipis
        ' ══════════════════════════════════════════════════════════
        Dim pens() As String = {"P", "1C", "2C", "3C", "HC", "H"}
        For i As Integer = 0 To pens.Length - 1
            Dim btn As New Button With {
                .Text = pens(i),
                .Bounds = New Rectangle(xBase + (i * 43), 148, 39, 36),
                .BackColor = Color.White,
                .ForeColor = COLOR_TEXT_DARK,
                .FlatStyle = FlatStyle.Flat,
                .Font = New Font("Segoe UI", 8.5F, FontStyle.Bold),
                .TextAlign = ContentAlignment.MiddleCenter
            }
            btn.FlatAppearance.BorderColor = Color.FromArgb(160, 160, 160)
            p.Controls.Add(btn)
        Next

        ' ══════════════════════════════════════════════════════════
        ' [F] SCORE SUMMARY (kotak berisi 3 baris teks presisi)
        '     Sejajar bawah dengan tombol P-1C-2C-3C-HC-H
        ' ══════════════════════════════════════════════════════════
        Dim pSum As New Panel With {
            .Bounds = New Rectangle(xBase, 193, 188, 52),
            .BorderStyle = BorderStyle.FixedSingle,
            .BackColor = Color.FromArgb(248, 248, 248)
        }
        ' Judul bold centered
        pSum.Controls.Add(New Label With {
            .Text = "Score Summary",
            .Bounds = New Rectangle(0, 2, 188, 17),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = FONT_BOLD
        })
        ' Baris 1: Ippon (rata kiri)  Waza-ari (rata kiri)
        Dim pnlScoreRow1 As New Panel With {.Bounds = New Rectangle(4, 21, 180, 14), .BackColor = Color.Transparent}
        pnlScoreRow1.Controls.Add(New Label With {
            .Text = "Ippon",
            .Bounds = New Rectangle(0, 0, 35, 14),
            .Font = FONT_DEFAULT
        })
        pnlScoreRow1.Controls.Add(New Label With {
            .Text = "0",
            .Bounds = New Rectangle(36, 0, 20, 14),
            .Font = FONT_BOLD
        })
        pnlScoreRow1.Controls.Add(New Label With {
            .Text = "Waza-ari",
            .Bounds = New Rectangle(65, 0, 55, 14),
            .Font = FONT_DEFAULT
        })
        pnlScoreRow1.Controls.Add(New Label With {
            .Text = "0",
            .Bounds = New Rectangle(122, 0, 20, 14),
            .Font = FONT_BOLD
        })
        pSum.Controls.Add(pnlScoreRow1)
        ' Baris 2: Yuko
        Dim pnlScoreRow2 As New Panel With {.Bounds = New Rectangle(4, 37, 180, 14), .BackColor = Color.Transparent}
        pnlScoreRow2.Controls.Add(New Label With {
            .Text = "Yuko",
            .Bounds = New Rectangle(0, 0, 30, 14),
            .Font = FONT_DEFAULT
        })
        pnlScoreRow2.Controls.Add(New Label With {
            .Text = "0",
            .Bounds = New Rectangle(36, 0, 20, 14),
            .Font = FONT_BOLD
        })
        pSum.Controls.Add(pnlScoreRow2)
        p.Controls.Add(pSum)

        ' ══════════════════════════════════════════════════════════
        ' [G] TOMBOL VR + LABEL "VR Requested" (bisa diklik)
        ' ══════════════════════════════════════════════════════════
        ' Tombol VR utama
        Dim btnVR As New Button With {
            .Text = "VR",
            .Bounds = New Rectangle(292, 193, 55, 28),
            .BackColor = Color.White,
            .ForeColor = COLOR_TEXT_DARK,
            .FlatStyle = FlatStyle.Flat,
            .Font = FONT_BOLD
        }
        btnVR.FlatAppearance.BorderColor = Color.FromArgb(160, 160, 160)
        p.Controls.Add(btnVR)

        ' Tombol "AKA/AO VR Requested" — bisa diklik, font kecil, abu-abu
        Dim btnVRReq As New Button With {
            .Text = side & " VR Requested",
            .Bounds = New Rectangle(292, 224, 118, 18),
            .BackColor = Color.FromArgb(235, 235, 235),
            .ForeColor = COLOR_TEXT_DARK,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 7.0F),
            .TextAlign = ContentAlignment.MiddleCenter
        }
        btnVRReq.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180)
        p.Controls.Add(btnVRReq)

        ' ══════════════════════════════════════════════════════════
        ' [H] LISTVIEW LOG SKOR (No, Timer, Type)
        '     GridLines samar, header tanpa garis vertikal mencolok
        ' ══════════════════════════════════════════════════════════
        Dim lv As New ListView With {
            .View = View.Details,
            .Bounds = New Rectangle(415, 30, 238, 155),
            .GridLines = False,
            .FullRowSelect = True,
            .HeaderStyle = ColumnHeaderStyle.Nonclickable,
            .BorderStyle = BorderStyle.FixedSingle,
            .Font = FONT_DEFAULT,
            .BackColor = Color.White
        }
        lv.Columns.Add("No", 32)
        lv.Columns.Add("Timer", 62)
        lv.Columns.Add("Type", 138)
        p.Controls.Add(lv)

        ' ══════════════════════════════════════════════════════════
        ' [I] ANGKA SKOR BESAR (kanan atas)
        ' ══════════════════════════════════════════════════════════
        p.Controls.Add(New Label With {
            .Text = scoreVal,
            .Bounds = New Rectangle(658, 22, 92, 88),
            .Font = FONT_SCORE_BIG,
            .TextAlign = ContentAlignment.MiddleCenter,
            .ForeColor = COLOR_TEXT_DARK,
            .BackColor = Color.Transparent
        })

        ' ══════════════════════════════════════════════════════════
        ' [J] TOMBOL IPPON / WAZA-ARI / YUKO
        '     Warna solid: AKA=merah, AO=biru, teks putih tebal
        ' ══════════════════════════════════════════════════════════
        Dim scoreBg As Color = If(side = "AKA", COLOR_AKA, COLOR_AO)
        Dim scoreFg As Color = COLOR_TEXT_LIGHT

        Dim btnIppon As New Button With {
            .Text = "Ippon 3",
            .Bounds = New Rectangle(658, 116, 92, 34),
            .BackColor = scoreBg,
            .ForeColor = scoreFg,
            .FlatStyle = FlatStyle.Flat,
            .Font = FONT_BOLD,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        btnIppon.FlatAppearance.BorderSize = 0
        p.Controls.Add(btnIppon)

        Dim btnWaza As New Button With {
            .Text = "Waza-ari 2",
            .Bounds = New Rectangle(658, 154, 92, 34),
            .BackColor = scoreBg,
            .ForeColor = scoreFg,
            .FlatStyle = FlatStyle.Flat,
            .Font = FONT_BOLD,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        btnWaza.FlatAppearance.BorderSize = 0
        p.Controls.Add(btnWaza)

        Dim btnYuko As New Button With {
            .Text = "Yuko 1",
            .Bounds = New Rectangle(658, 192, 92, 34),
            .BackColor = scoreBg,
            .ForeColor = scoreFg,
            .FlatStyle = FlatStyle.Flat,
            .Font = FONT_BOLD,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        btnYuko.FlatAppearance.BorderSize = 0
        p.Controls.Add(btnYuko)

        ' ══════════════════════════════════════════════════════════
        ' [K] TOMBOL BAWAH: Show Winner | Reset Score | Senshu
        '     Semua putih bersih, border tipis, ukuran seragam
        ' ══════════════════════════════════════════════════════════
        Dim btnShowWin As New Button With {
            .Text = "Show" & Environment.NewLine & "Winner",
            .Bounds = New Rectangle(415, 193, 72, 44),
            .BackColor = Color.White,
            .ForeColor = COLOR_TEXT_DARK,
            .FlatStyle = FlatStyle.Flat,
            .Font = FONT_DEFAULT,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        btnShowWin.FlatAppearance.BorderColor = Color.FromArgb(160, 160, 160)
        p.Controls.Add(btnShowWin)

        ' Reset Score — warna PUTIH (bukan abu gelap)
        Dim btnReset As New Button With {
            .Text = "Reset Score",
            .Bounds = New Rectangle(491, 204, 78, 30),
            .BackColor = Color.White,
            .ForeColor = COLOR_TEXT_DARK,
            .FlatStyle = FlatStyle.Flat,
            .Font = FONT_DEFAULT,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        btnReset.FlatAppearance.BorderColor = Color.FromArgb(160, 160, 160)
        p.Controls.Add(btnReset)

        Dim btnSenshu As New Button With {
            .Text = "Senshu",
            .Bounds = New Rectangle(573, 204, 62, 30),
            .BackColor = Color.White,
            .ForeColor = COLOR_TEXT_DARK,
            .FlatStyle = FlatStyle.Flat,
            .Font = FONT_DEFAULT,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        btnSenshu.FlatAppearance.BorderColor = Color.FromArgb(160, 160, 160)
        p.Controls.Add(btnSenshu)
    End Sub

    ' ----------------------------------------------------------
    ' RIGHT PANEL: Setting SCBoard, Timer, dll.
    ' ----------------------------------------------------------
    Private Sub BuildRightPanel(p As Panel)
        ' --- Label judul ---
        p.Controls.Add(New Label With {
            .Text = "SCBoard Type",
            .Bounds = New Rectangle(10, 5, 90, 15),
            .Font = New Font("Segoe UI", 7.5F)
        })
        p.Controls.Add(New Label With {
            .Text = "Senshu Style",
            .Bounds = New Rectangle(120, 5, 80, 15),
            .Font = New Font("Segoe UI", 7.5F)
        })

        ' --- SCBoard Type: 2 kotak warna (Horizontal & Vertikal) ---
        p.Controls.Add(CreateColorBox(10, 22, Color.Red, Color.Blue))
        p.Controls.Add(CreateColorBox(50, 22, COLOR_GOLD, Color.Blue))

        ' --- Senshu Style: kotak S (hijau & hitam) ---
        p.Controls.Add(CreateSenshuBox(120, 22, Color.DarkGreen, False))
        p.Controls.Add(CreateSenshuBox(155, 22, Color.Black, True))

        ' --- Adjust Scboard Text Size ---
        p.Controls.Add(New Label With {
            .Text = "Adjust Scboard Text Size",
            .Bounds = New Rectangle(10, 55, 210, 15)
        })
        Dim cboAdjust As New ComboBox With {
            .Bounds = New Rectangle(10, 72, 90, 25),
            .DropDownStyle = ComboBoxStyle.DropDownList
        }
        cboAdjust.Items.AddRange(New String() {"Player Name", "All", "Score", "Team", "Team Info", "Category", "Timer", "Tatami", "Match Detail"})
        cboAdjust.SelectedIndex = 0
        p.Controls.Add(cboAdjust)
        p.Controls.Add(New NumericUpDown With {
            .Bounds = New Rectangle(105, 72, 42, 25),
            .DecimalPlaces = 1,
            .Increment = 0.1D,
            .Value = 1.5D
        })
        p.Controls.Add(CreateBtn("R", 150, 72, 22, 25, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("-", 175, 72, 22, 25, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("+", 200, 72, 22, 25, COLOR_PANEL_BG, COLOR_TEXT_DARK))

        ' --- Match Detail & Match Logo tabs ---
        Dim tabCtrl As New TabControl With {
            .Bounds = New Rectangle(5, 100, 225, 100),
            .Font = New Font("Segoe UI", 8.0F)
        }
        Dim tabDetail As New TabPage With {.Text = "Match Detail", .BackColor = COLOR_PANEL_BG}
        Dim txtMatchDesc As New TextBox With {
            .Multiline = True,
            .Dock = DockStyle.Fill,
            .Text = "Match Description...",
            .BorderStyle = BorderStyle.None
        }
        tabDetail.Controls.Add(txtMatchDesc)
        tabCtrl.TabPages.Add(tabDetail)

        Dim tabLogo As New TabPage With {.Text = "Match Logo", .BackColor = COLOR_PANEL_BG}
        Dim picLogoBox As New Panel With {
            .Bounds = New Rectangle(5, 5, 50, 50),
            .BackColor = Color.White,
            .BorderStyle = BorderStyle.FixedSingle
        }
        tabLogo.Controls.Add(picLogoBox)
        tabCtrl.TabPages.Add(tabLogo)
        p.Controls.Add(tabCtrl)

        ' Tombol upload (↑)
        p.Controls.Add(CreateBtn("↑", 205, 175, 22, 22, Color.WhiteSmoke, COLOR_TEXT_DARK, New Font("Arial", 8)))

        ' --- Win. Point ---
        p.Controls.Add(New Label With {
            .Text = "Win. Point",
            .Bounds = New Rectangle(10, 205, 65, 20)
        })
        p.Controls.Add(New NumericUpDown With {
            .Bounds = New Rectangle(78, 203, 42, 25),
            .Value = 8
        })
        p.Controls.Add(CreateBtn("Edit", 125, 202, 58, 26, Color.WhiteSmoke, COLOR_TEXT_DARK))

        ' --- Tatami + Switch Position ---
        p.Controls.Add(New Label With {
            .Text = "Tatami",
            .Bounds = New Rectangle(10, 237, 55, 20)
        })
        p.Controls.Add(New NumericUpDown With {
            .Bounds = New Rectangle(68, 235, 42, 25),
            .Value = 1
        })
        p.Controls.Add(CreateBtn("Switch" & Environment.NewLine & "Position", 115, 232, 80, 28, Color.WhiteSmoke, COLOR_TEXT_DARK, New Font("Segoe UI", 7.0F)))
        ' Kotak warna AKA & AO di sebelah Switch
        p.Controls.Add(New Panel With {.Bounds = New Rectangle(200, 233, 12, 12), .BackColor = COLOR_AKA})
        p.Controls.Add(New Panel With {.Bounds = New Rectangle(200, 248, 12, 12), .BackColor = COLOR_AO})

        ' --- Waiting Timer ---
        Dim lblWait As New Label With {
            .Text = "Waiting Timer (minute:second)",
            .Bounds = New Rectangle(0, 268, 238, 20),
            .BackColor = Color.Beige,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Segoe UI", 7.5F)
        }
        p.Controls.Add(lblWait)
        numWaitMin = New NumericUpDown With {.Bounds = New Rectangle(8, 294, 42, 25), .Value = 2, .Maximum = 59}
        p.Controls.Add(numWaitMin)
        p.Controls.Add(New Label With {.Text = ":", .Bounds = New Rectangle(53, 296, 10, 20), .Font = FONT_BOLD})
        numWaitSec = New NumericUpDown With {.Bounds = New Rectangle(65, 294, 42, 25), .Value = 0, .Maximum = 59}
        p.Controls.Add(numWaitSec)
        btnStartWaitTimer = CreateBtn("Start", 112, 292, 118, 28, COLOR_GOLD, COLOR_TEXT_DARK, FONT_BOLD)
        AddHandler btnStartWaitTimer.Click, AddressOf btnStartWaitTimer_Click
        p.Controls.Add(btnStartWaitTimer)

        ' --- Match Timer ---
        Dim lblMatch As New Label With {
            .Text = "Match Timer (minute:second)",
            .Bounds = New Rectangle(0, 330, 238, 22),
            .BackColor = COLOR_GOLD,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = FONT_BOLD
        }
        p.Controls.Add(lblMatch)

        ' Tombol preset waktu
        p.Controls.Add(CreateBtn("1:30", 8, 358, 65, 26, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("2:00", 80, 358, 65, 26, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("3:00", 152, 358, 70, 26, COLOR_PANEL_BG, COLOR_TEXT_DARK))

        ' Input manual timer
        p.Controls.Add(New NumericUpDown With {.Bounds = New Rectangle(55, 392, 42, 25)})
        p.Controls.Add(New Label With {.Text = ":", .Bounds = New Rectangle(99, 394, 10, 20), .Font = FONT_BOLD})
        p.Controls.Add(New NumericUpDown With {.Bounds = New Rectangle(112, 392, 42, 25), .Value = 5})

        ' Adjust Timer display
        p.Controls.Add(New Label With {
            .Text = "Adjust" & Environment.NewLine & "Timer",
            .Bounds = New Rectangle(5, 423, 45, 38),
            .Font = New Font("Segoe UI", 7.5F),
            .TextAlign = ContentAlignment.MiddleCenter
        })
        Dim pDisp As New Panel With {
            .Bounds = New Rectangle(52, 423, 118, 38),
            .BackColor = COLOR_GOLD,
            .BorderStyle = BorderStyle.FixedSingle
        }
        pDisp.Controls.Add(New Label With {
            .Text = "0:05  .0",
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Consolas", 14, FontStyle.Bold)
        })
        p.Controls.Add(pDisp)
        p.Controls.Add(CreateBtn("-", 173, 423, 28, 38, COLOR_PANEL_BG, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("+", 204, 423, 28, 38, COLOR_PANEL_BG, COLOR_TEXT_DARK))

        ' --- Start Scoreboard ---
        p.Controls.Add(CreateBtn("⤢", 8, 470, 30, 32, Color.WhiteSmoke, COLOR_TEXT_DARK))
        Dim btnStartScoreboard As Button = CreateBtn("Start Scoreboard  📊", 42, 470, 188, 32, Color.PaleGreen, COLOR_TEXT_DARK, FONT_BOLD)
        AddHandler btnStartScoreboard.Click, AddressOf btnStartScoreboard_Click
        p.Controls.Add(btnStartScoreboard)

        ' --- Start Timer ---
        p.Controls.Add(CreateBtn("⏱", 8, 507, 30, 32, Color.WhiteSmoke, COLOR_TEXT_DARK))
        p.Controls.Add(CreateBtn("Start Timer  ⏲", 42, 507, 188, 32, COLOR_GOLD, COLOR_TEXT_DARK, FONT_BOLD))
    End Sub

    ' ----------------------------------------------------------
    ' FOOTER: Tombol-tombol bawah
    ' ----------------------------------------------------------
    Private Sub BuildFooter(p As Panel)
        ' Settings
        Dim btnSettings As Button = CreateBtn("Settings ⚙", 5, 8, 85, 40, Color.White, Color.Black, FONT_BOLD)
        AddHandler btnSettings.Click, AddressOf btnSettings_Click
        p.Controls.Add(btnSettings)

        ' Log Activity
        Dim btnLogActivity As Button = CreateBtn("Log Activity", 95, 8, 90, 40, Color.White, Color.Black, FONT_BOLD)
        AddHandler btnLogActivity.Click, AddressOf btnLogActivity_Click
        p.Controls.Add(btnLogActivity)

        ' Shortcut
        Dim btnShortcut As Button = CreateBtn("Shortcut ⌨", 190, 8, 85, 40, Color.White, Color.Black, FONT_BOLD)
        AddHandler btnShortcut.Click, AddressOf btnShortcut_Click
        p.Controls.Add(btnShortcut)

        ' Ikon layar & speaker
        AddFooterButton(p, "🖥", 280, 8, 38)
        AddFooterButton(p, "🔊", 323, 8, 38)

        ' Reset Hantei
        AddFooterButton(p, "Reset Hantei", 366, 8, 85)

        ' Hantei
        btnHantei = CreateBtn("Hantei 🚩", 456, 8, 80, 40, Color.White, Color.Black, FONT_BOLD)
        AddHandler btnHantei.Click, AddressOf btnHantei_Click
        p.Controls.Add(btnHantei)

        ' Hikiwake/Draw
        AddFooterButton(p, "Hikiwake/Draw 🎌", 541, 8, 130)

        ' Reset Match
        AddFooterButton(p, "Reset Match", 775, 8, 90)

        ' Save Match Result
        AddFooterButton(p, "Save Match Result 💾", 870, 8, 132)
    End Sub

    ' ==========================================================
    ' BAGIAN 3: FUNGSI HELPER UI
    ' ==========================================================

    ' Tombol standar serbaguna
    Private Function CreateBtn(t As String, x As Integer, y As Integer, w As Integer, h As Integer,
                               bg As Color, fg As Color, Optional fnt As Font = Nothing) As Button
        If fnt Is Nothing Then fnt = FONT_DEFAULT
        Return New Button With {
            .Text = t,
            .Bounds = New Rectangle(x, y, w, h),
            .BackColor = bg,
            .ForeColor = fg,
            .FlatStyle = FlatStyle.Flat,
            .Font = fnt,
            .TextAlign = ContentAlignment.MiddleCenter
        }
    End Function

    ' Tombol bersih putih, border abu-abu tipis (untuk Kiken, Shikkaku, dll)
    Private Function CreateBtnClean(t As String, x As Integer, y As Integer, w As Integer, h As Integer) As Button
        Dim btn As New Button With {
            .Text = t,
            .Bounds = New Rectangle(x, y, w, h),
            .BackColor = Color.White,
            .ForeColor = COLOR_TEXT_DARK,
            .FlatStyle = FlatStyle.Flat,
            .Font = FONT_DEFAULT,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        btn.FlatAppearance.BorderColor = Color.FromArgb(160, 160, 160)
        Return btn
    End Function

    ' Tombol ikon kecil (👤 atau 🔍), tinggi 23px
    Private Function CreateBtnIcon(icon As String, x As Integer, y As Integer, w As Integer) As Button
        Dim btn As New Button With {
            .Text = icon,
            .Bounds = New Rectangle(x, y, w, 23),
            .BackColor = Color.FromArgb(240, 240, 240),
            .ForeColor = COLOR_TEXT_DARK,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 8.0F),
            .TextAlign = ContentAlignment.MiddleCenter
        }
        btn.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180)
        Return btn
    End Function

    ' Label sederhana untuk field input
    Private Function MakeLabel(t As String, x As Integer, y As Integer, w As Integer) As Label
        Return New Label With {
            .Text = t,
            .Bounds = New Rectangle(x, y + 5, w, 16),
            .Font = FONT_DEFAULT
        }
    End Function

    ' TextBox kosong untuk input field
    Private Function MakeTxtBox(val As String, x As Integer, y As Integer, w As Integer) As TextBox
        Return New TextBox With {
            .Text = val,
            .Bounds = New Rectangle(x, y, w, 23),
            .BorderStyle = BorderStyle.FixedSingle,
            .Font = FONT_DEFAULT
        }
    End Function

    ' AddInput lama (dipakai oleh bagian lain jika diperlukan)
    Private Sub AddInput(p As Panel, t As String, x As Integer, y As Integer, val As String, w As Integer)
        p.Controls.Add(New Label With {.Text = t, .Bounds = New Rectangle(x, y + 4, 65, 15)})
        p.Controls.Add(New TextBox With {
            .Text = val,
            .Bounds = New Rectangle(x + 65, y, w - 95, 23),
            .BorderStyle = BorderStyle.FixedSingle
        })
        p.Controls.Add(CreateBtn("👤", x + w - 28, y, 24, 23, Color.WhiteSmoke, COLOR_TEXT_DARK))
    End Sub

    ' AddInputWithIcon (Name=👤, Team=🔍)
    Private Sub AddInputWithIcon(p As Panel, t As String, x As Integer, y As Integer, val As String, isPersonIcon As Boolean)
        Dim lblWidth As Integer = 60
        Dim iconWidth As Integer = 24
        Dim txtWidth As Integer = 178
        p.Controls.Add(New Label With {.Text = t, .Bounds = New Rectangle(x, y + 4, lblWidth, 16)})
        p.Controls.Add(New TextBox With {.Text = val, .Bounds = New Rectangle(x + lblWidth, y, txtWidth, 23), .BorderStyle = BorderStyle.FixedSingle})
        Dim iconText As String = If(isPersonIcon, "👤", "🔍")
        p.Controls.Add(CreateBtn(iconText, x + lblWidth + txtWidth + 2, y, iconWidth, 23, Color.WhiteSmoke, COLOR_TEXT_DARK))
    End Sub

    Private Sub AddFooterButton(p As Panel, t As String, x As Integer, y As Integer, w As Integer)
        p.Controls.Add(CreateBtn(t, x, y, w, 40, Color.White, Color.Black, FONT_BOLD))
    End Sub

    Private Function CreateColorBox(x As Integer, y As Integer, c1 As Color, c2 As Color) As Panel
        Dim p As New Panel With {
            .Bounds = New Rectangle(x, y, 32, 24),
            .BorderStyle = BorderStyle.FixedSingle
        }
        p.Controls.Add(New Panel With {.Dock = DockStyle.Left, .Width = 15, .BackColor = c1})
        p.Controls.Add(New Panel With {.Dock = DockStyle.Right, .Width = 15, .BackColor = c2})
        Return p
    End Function

    Private Function CreateSenshuBox(x As Integer, y As Integer, bg As Color, hasStrike As Boolean) As Panel
        Dim p As New Panel With {
            .Bounds = New Rectangle(x, y, 26, 26),
            .BackColor = bg,
            .BorderStyle = BorderStyle.FixedSingle
        }
        Dim lbl As New Label With {
            .Text = "S",
            .ForeColor = Color.Yellow,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Arial Black", 9)
        }
        p.Controls.Add(lbl)
        If hasStrike Then
            AddHandler p.Paint, Sub(s, e) e.Graphics.DrawLine(New Pen(Color.Lime, 2), 0, 26, 26, 0)
        End If
        Return p
    End Function
End Class