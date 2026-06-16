Imports System.Drawing
Imports System.Windows.Forms

Partial Public Class KumiteMainControl

    ' --- VARIABEL PENYIMPANAN SEMENTARA ---
    Public targetSide As String = ""
    Public Shared AkaColor As Color = Color.Crimson
    Public Shared AoColor As Color = Color.DodgerBlue
    Public Shared AkaTextColor As Color = Color.White
    Public Shared AoTextColor As Color = Color.White
    Public Shared UseKnockoutCountdown As Boolean = True
    Public Shared MatchDetailFontName As String = "Microsoft Sans Serif"
    Public Shared MatchDetailIsBold As Boolean = True
    Public Shared MatchDetailColor As Color = Color.Yellow
    Public NextAkaName As String = ""
    Public NextAkaTeam As String = ""
    Public NextAkaInfo As String = ""
    Public NextAoName As String = ""
    Public NextAoTeam As String = ""
    Public NextAoInfo As String = ""
    Private isAkaVrActive As Boolean = False
    Private isAoVrActive As Boolean = False
    Private isVrBumperActive As Boolean = False
    Private isAkaSenshu As Boolean = False
    Private isAoSenshu As Boolean = False
    Public isAkaHanteiWin As Boolean = False
    Public isAoHanteiWin As Boolean = False
    Private frmKOActive As Form = Nothing
    Private koTimerActive As Timer = Nothing
    Private isKOCountdownDone As Boolean = False
    Private frmKOTrackingActive As Form = Nothing   ' Referensi popup Tracking KO (AKA/AO KNOCKOUT)


    ' --- FUNGSI PENERIMA DATA BARU (NAMA & TIM) ---
    Public Sub SetCompetitorData(nama As String, team As String, info As String)
        If targetSide = "AKA" Then
            NextAkaName = nama
            NextAkaTeam = team
            NextAkaInfo = info
            ' Format teks jadi "Nama | Tim"
            TxtAkaName.Text = nama & " | " & team

            ' Panggil foto dari database ke PictureBox AKA milikmu
            LoadMatchImages(nama, team, PicAkaProfile, PicAkaTeamLogo)

        ElseIf targetSide = "AO" Then
            NextAoName = nama
            NextAoTeam = team
            NextAoInfo = info
            ' Format teks jadi "Nama | Tim"
            TxtAoName.Text = nama & " | " & team

            ' Panggil foto dari database ke PictureBox AO milikmu
            LoadMatchImages(nama, team, PicAoProfile, PicAoTeamLogo)
        End If
    End Sub

    ' ==========================================================
    ' FUNGSI PENCARI GAMBAR DARI DATABASE (UPDATED: SUPPORT BENDERA)
    ' ==========================================================
    Private Sub LoadMatchImages(nama As String, namaTeam As String, boxComp As PictureBox, boxTeam As PictureBox)

        ' 1. FIX UKURAN: Memaksa gambar mengecil secara proporsional dan pas di tengah frame
        boxComp.SizeMode = PictureBoxSizeMode.Zoom
        boxTeam.SizeMode = PictureBoxSizeMode.Zoom

        ' 2. FIX WARNA: Paksa background menjadi warna Putih agar menghilangkan kotak hitam pekat
        boxComp.BackColor = Color.White
        boxTeam.BackColor = Color.White

        ' Kosongkan gambar pertandingan sebelumnya
        boxComp.Image = Nothing
        boxTeam.Image = Nothing

        Try
            Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                conn.Open()

                ' Cari Foto Peserta di tabel competitor
                Try
                    Dim qComp As String = "SELECT pict_path FROM competitor WHERE name = @n AND team = @t LIMIT 1"
                    Using cmdComp As New System.Data.SQLite.SQLiteCommand(qComp, conn)
                        cmdComp.Parameters.AddWithValue("@n", nama)
                        cmdComp.Parameters.AddWithValue("@t", namaTeam)
                        Dim result = cmdComp.ExecuteScalar()

                        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                            boxComp.Image = LoadSafeImage(result.ToString())
                        End If
                    End Using
                Catch ex As Exception
                End Try

                ' Cari Logo Tim di tabel team_lengkap
                Try
                    Dim qTeam As String = "SELECT pict_path FROM team_lengkap WHERE nama_team = @nt LIMIT 1"
                    Using cmdTeam As New System.Data.SQLite.SQLiteCommand(qTeam, conn)
                        cmdTeam.Parameters.AddWithValue("@nt", namaTeam)
                        Dim result = cmdTeam.ExecuteScalar()

                        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                            ' [PERBAIKAN MUTLAK] Menggunakan fungsi pembaca bendera khusus
                            boxTeam.Image = GetSafeTeamImage(result.ToString())
                        End If
                    End Using
                Catch ex As Exception
                End Try
            End Using
        Catch ex As Exception
        End Try
    End Sub

    ' ==========================================================
    ' FUNGSI KHUSUS PEMBACA LOGO TIM / BENDERA NEGARA (NEW)
    ' ==========================================================
    Private Function GetSafeTeamImage(pathOrFlag As String) As Image
        Try
            If String.IsNullOrWhiteSpace(pathOrFlag) OrElse pathOrFlag.Trim() = "No Image" Then
                Return Nothing
            End If

            pathOrFlag = pathOrFlag.Trim()

            ' 1. JIKA INI ADALAH BENDERA (Ada teks "Flag: ")
            If pathOrFlag.StartsWith("Flag: ") Then
                Dim countryName As String = pathOrFlag.Replace("Flag: ", "").Trim()
                Dim flagPathPNG As String = IO.Path.Combine(Application.StartupPath, countryName & "_Flag.png")
                Dim flagPathJPG As String = IO.Path.Combine(Application.StartupPath, countryName & "_Flag.jpg")

                Dim finalPath As String = ""
                If System.IO.File.Exists(flagPathPNG) Then finalPath = flagPathPNG
                If System.IO.File.Exists(flagPathJPG) Then finalPath = flagPathJPG

                If finalPath <> "" Then
                    Dim bytes As Byte() = System.IO.File.ReadAllBytes(finalPath)
                    ' PERBAIKAN: Hilangkan blok 'Using' agar memori gambar tidak dihapus sistem (Anti-Crash)
                    Dim ms As New IO.MemoryStream(bytes)
                    Return Image.FromStream(ms)
                Else
                    ' Kotak darurat jika gambar bendera asli di folder tidak ditemukan
                    Dim bmp As New Bitmap(100, 60)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        g.Clear(Color.LightGray)
                        g.DrawRectangle(Pens.Black, 0, 0, 99, 59)
                        g.DrawString(countryName, New Font("Segoe UI", 8, FontStyle.Bold), Brushes.Black, New PointF(5, 20))
                    End Using
                    Return bmp
                End If

                ' 2. JIKA INI ADALAH LOGO CUSTOM BIASA (Alamat File)
            ElseIf System.IO.File.Exists(pathOrFlag) Then
                Dim bytes As Byte() = System.IO.File.ReadAllBytes(pathOrFlag)
                ' PERBAIKAN: Hilangkan blok 'Using' agar memori gambar tidak dihapus sistem
                Dim ms As New IO.MemoryStream(bytes)
                Return Image.FromStream(ms)
            End If
        Catch ex As Exception
        End Try

        Return Nothing
    End Function

    ' ==========================================================
    ' FUNGSI MEMUAT GAMBAR AMAN DENGAN 1 PARAMETER SINKRON
    ' ==========================================================
    Private Function LoadSafeImage(path As String) As Image
        Try
            ' Cek jika path kosong atau bernilai "No Image", langsung lewati tanpa error
            If String.IsNullOrWhiteSpace(path) OrElse path.Trim() = "No Image" Then
                Return Nothing
            End If

            path = path.Trim()

            ' Membaca file gambar dengan aman
            If System.IO.File.Exists(path) Then
                Dim bytes As Byte() = System.IO.File.ReadAllBytes(path)
                Using ms As New IO.MemoryStream(bytes)
                    Return Image.FromStream(ms)
                End Using
            End If
        Catch ex As Exception
        End Try
        Return Nothing
    End Function

    ' ==========================================================
    ' FUNGSI MEMUAT GAMBAR AMAN & MENJAGA TRANSPARANSI
    ' ==========================================================
    Private Function LoadSafeImage(path As String, tipe As String) As Image
        Try
            ' 1. CEGAL ERROR "No Image": Jika path kosong atau bernilai "No Image" (karena peserta memang tidak pakai foto), 
            ' maka langsung kembalikan kosong (Nothing) TANPA memunculkan pesan error!
            If String.IsNullOrWhiteSpace(path) OrElse path.Trim() = "No Image" Then
                Return Nothing
            End If

            path = path.Trim()

            ' 2. Load gambar jika file benar-benar ada
            If System.IO.File.Exists(path) Then
                Dim bytes As Byte() = System.IO.File.ReadAllBytes(path)
                ' Trik Anti-Hitam: Kita langsung load dari MemoryStream tanpa dibungkus New Bitmap() lagi
                ' Ini akan menjaga efek transparansi gambar PNG 100% utuh!
                Dim ms As New IO.MemoryStream(bytes)
                Return Image.FromStream(ms)
            Else
                MessageBox.Show($"File gambar untuk {tipe} tidak ditemukan di komputer:{vbCrLf}{path}", "Gambar Hilang", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try
        Return Nothing
    End Function

    ' --- FUNGSI UPDATE TEAM & INFO SAJA (DARI LIST OF TEAM) ---
    Public Sub UpdateTeamData(team As String, info As String)
        If targetSide = "AKA" Then
            NextAkaTeam = team
            NextAkaInfo = info
            TxtAkaTeam.Text = team
            TxtAkaTeamInfo.Text = info

            ' Memperbarui teks gabungan "Nama | Tim" jika pesertanya sudah dipilih
            If NextAkaName <> "" Then
                TxtAkaName.Text = NextAkaName & " | " & team
            End If

        ElseIf targetSide = "AO" Then
            NextAoTeam = team
            NextAoInfo = info
            TxtAoTeam.Text = team
            TxtAoTeamInfo.Text = info

            ' Memperbarui teks gabungan "Nama | Tim" jika pesertanya sudah dipilih
            If NextAoName <> "" Then
                TxtAoName.Text = NextAoName & " | " & team
            End If
        End If
    End Sub

    Private Sub BtnAkaTeamSearch_Click(sender As Object, e As EventArgs) Handles BtnAkaTeamSearch.Click
        targetSide = "AKA"
        Dim frm As New ListOfTeam()
        frm.ShowDialog()
    End Sub

    Private Sub BtnAoTeamSearch_Click(sender As Object, e As EventArgs) Handles BtnAoTeamSearch.Click
        targetSide = "AO"
        Dim frm As New ListOfTeam()
        frm.ShowDialog()
    End Sub

    ' --- FUNGSI TOMBOL LOAD NEXT MATCH ---
    Private Sub BtnLoadNextMatch_Click(sender As Object, e As EventArgs) Handles BtnLoadNextMatch.Click
        ' Memasukkan data ke sisi AKA (Merah)
        If NextAkaName <> "" Then
            TxtAkaNameMain.Text = NextAkaName
            TxtAkaTeam.Text = NextAkaTeam
            TxtAkaTeamInfo.Text = NextAkaInfo
        End If

        ' Memasukkan data ke sisi AO (Biru)
        If NextAoName <> "" Then
            TxtAoNameMain.Text = NextAoName
            TxtAoTeam.Text = NextAoTeam
            TxtAoTeamInfo.Text = NextAoInfo
        End If

        ' Otomatis sinkronkan nama di layar Scoreboard raksasa (jika terbuka)
        SyncScoreboardProfile()

        MessageBox.Show("Data pertandingan berhasil di-load!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Klik ikon 👤 untuk AKA
    Private Sub BtnAkaSearch_Click(sender As Object, e As EventArgs) Handles BtnAkaIcon.Click
        targetSide = "AKA"
        Try
            Dim frm As New ListOfCompetitor()
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal memanggil form ListOfCompetitor: " & ex.Message, "Error Tombol AKA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Klik ikon 👤 untuk AO
    Private Sub BtnAoSearch_Click(sender As Object, e As EventArgs) Handles BtnAoIcon.Click
        targetSide = "AO"
        Try
            Dim frm As New ListOfCompetitor()
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal memanggil form ListOfCompetitor: " & ex.Message, "Error Tombol AO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared frmScoreboardSettingApp As FrmScoreboardSetting
    Public Shared frmKeyboardShortcutApp As FormKeyboardShortcut
    Public Shared frmHanteiApp As HanteiForm
    Public Shared frmScoreboard As ScoreBoard

    ' Timer untuk Waiting Timer (dibuat manual karena tidak ada di Designer baru)
    Private WithEvents waitTimer As New Timer() With {.Interval = 1000}

    Public Sub New()
        ' Wajib dipanggil pertama - menginisialisasi semua komponen dari Designer
        InitializeComponent()

        ' Setup tambahan setelah komponen siap
        Me.Text = "Kumite Main Control"
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub KumiteMainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttachGlobalLogger(Me)
        Me.KeyPreview = True

        ' 2. Ciptakan form menu shortcut di latar belakang (RAM)
        If frmKeyboardShortcutApp Is Nothing OrElse frmKeyboardShortcutApp.IsDisposed Then
            frmKeyboardShortcutApp = New FormKeyboardShortcut()
        End If
        Dim phantomHandle As IntPtr = frmKeyboardShortcutApp.Handle
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' 1. Mengunci border agar tidak bisa ditarik/di-stretch manual
        Me.MaximizeBox = False                           ' 2. Mematikan fungsi tombol kotak (Maximize) di pojok kanan atas
        Me.StartPosition = FormStartPosition.CenterScreen ' 3. Memaksa aplikasi muncul rapi tepat di tengah-tengah monitor

        AttachBackgroundClickSensor(Me)
        NumWinPoint.Enabled = False
        ' Mematikan tombol Save, dan menyalakan tombol Edit
        BtnSaveWinPoint.Enabled = False
        BtnEditWinPoint.Enabled = True

        ' Hubungkan event handler tombol-tombol
        AddHandler BtnSettings.Click, AddressOf BtnSettings_Click
        AddHandler BtnLogActivity.Click, AddressOf BtnLogActivity_Click
        AddHandler BtnShortcut.Click, AddressOf BtnShortcut_Click
        AddHandler BtnHantei.Click, AddressOf BtnHantei_Click
        AddHandler BtnStartScoreboard.Click, AddressOf BtnStartScoreboard_Click
        AddHandler BtnStartWait.Click, AddressOf BtnStartWait_Click
        AddHandler ResetTimer.Click, AddressOf ResetTimer_Click

        DgvAkaHistory.AllowUserToResizeColumns = False
        DgvAkaHistory.AllowUserToResizeRows = False
        DgvAkaHistory.ScrollBars = ScrollBars.Vertical ' <- Kembalikan ke Vertical
        DgvAkaHistory.AllowUserToAddRows = False

        DgvAoHistory.AllowUserToResizeColumns = False
        DgvAoHistory.AllowUserToResizeRows = False
        DgvAoHistory.ScrollBars = ScrollBars.Vertical ' <- Kembalikan ke Vertical
        DgvAoHistory.AllowUserToAddRows = False

        ' 2. BUAT SEMUA TEKS RATA TENGAH (Isi Tabel & Header)
        ' Untuk Tabel AKA
        DgvAkaHistory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvAkaHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Untuk Tabel AO
        DgvAoHistory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvAoHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' 3. Atur Lebar Tetap (Constant Width) untuk AKA
        DgvAkaHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        If DgvAkaHistory.Columns.Count >= 4 Then
            DgvAkaHistory.Columns(0).Width = 25  ' No
            DgvAkaHistory.Columns(1).Width = 40  ' Timer
            DgvAkaHistory.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Type (Bertindak sbg shock-absorber)
            DgvAkaHistory.Columns(3).Width = 65  ' Change (Aman dari potongan)
        End If

        ' 4. Atur Lebar Tetap (Constant Width) untuk AO
        DgvAoHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        If DgvAoHistory.Columns.Count >= 4 Then
            DgvAoHistory.Columns(0).Width = 25
            DgvAoHistory.Columns(1).Width = 40
            DgvAoHistory.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            DgvAoHistory.Columns(3).Width = 65
        End If

        ' Memberi warna dan menebalkan teks di kotak Next Match
        TxtAkaName.ForeColor = AkaColor
        TxtAkaName.Font = New Font(TxtAkaName.Font, FontStyle.Bold)

        TxtAoName.ForeColor = AoColor
        TxtAoName.Font = New Font(TxtAoName.Font, FontStyle.Bold)

        CboAdjustPlayer.Items.Clear()
        CboAdjustPlayer.Items.AddRange({"All", "Player Name", "Score", "Team", "Team Info", "Category", "Timer", "Tatami", "Match Detail"})
        CboAdjustPlayer.SelectedIndex = 0
    End Sub

    ' ==========================================================
    ' EVENT HANDLER FOOTER & NAVIGASI
    ' ==========================================================
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs)
        If frmScoreboardSettingApp Is Nothing OrElse frmScoreboardSettingApp.IsDisposed Then
            frmScoreboardSettingApp = New FrmScoreboardSetting()
        End If
        frmScoreboardSettingApp.ShowDialog()
    End Sub

    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs) Handles BtnLogActivity.Click
        ' Menggunakan form global yang sama dengan KATA
        ActivityLogger.InitializeLogger()
        ActivityLogger.SharedLogForm.Show()
        ActivityLogger.SharedLogForm.BringToFront()
    End Sub

    Private Sub BtnShortcut_Click(sender As Object, e As EventArgs)
        If frmKeyboardShortcutApp Is Nothing OrElse frmKeyboardShortcutApp.IsDisposed Then
            frmKeyboardShortcutApp = New FormKeyboardShortcut()
        End If
        frmKeyboardShortcutApp.ShowDialog()
    End Sub

    Private Sub BtnHantei_Click(sender As Object, e As EventArgs)
        ' --- TAMBAHAN AUDIO HANTEI ---
        AudioController.PlaySound("Hantei")

        If frmHanteiApp Is Nothing OrElse frmHanteiApp.IsDisposed Then
            frmHanteiApp = New HanteiForm()
        End If

        ' Sapu bersih memori Hantei sebelumnya
        frmHanteiApp.ResetAll()

        ' ---> 1. TAMPILKAN LAYAR HITAM HANTEI DI SCOREBOARD <---
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            frmScoreboard.ToggleHanteiScreen(True)
        End If

        ' ---> 2. TAMPILKAN FORM POPUP UNTUK WASIT <---
        If frmHanteiApp.ShowDialog() = DialogResult.OK Then
            Me.Activate() ' Mengembalikan fokus ke layar KumiteMainControl

            Dim winner As String = frmHanteiApp.FinalWinner
            If winner = "AKA" Then
                ForceDeclareWinner("AKA")
            ElseIf winner = "AO" Then
                ForceDeclareWinner("AO")
            End If
        End If

        ' ---> 3. TUTUP LAYAR HITAM HANTEI SETELAH WASIT SELESAI / CANCEL <---
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            frmScoreboard.ToggleHanteiScreen(False)
        End If
    End Sub

    ' ---> TAMBAHKAN FUNGSI EKSEKUTOR INI TEPAT DI BAWAHNYA <---
    Private Sub ForceDeclareWinner(winnerSide As String)
        matchTimer.Stop()
        BtnStartTimer.Text = "Start Timer"
        BtnStartTimer.BackColor = Color.Gold

        If winnerSide = "AKA" Then
            isAkaHanteiWin = True
            isAoHanteiWin = False
            firstWinnerDeclared = "AKA"
            LblAkaWinner.Visible = True
            LblAoWinner.Visible = False
            LblHanteiAka.Visible = True
            LblHanteiAo.Visible = False
        ElseIf winnerSide = "AO" Then
            isAkaHanteiWin = False
            isAoHanteiWin = True
            firstWinnerDeclared = "AO"
            LblAkaWinner.Visible = False
            LblAoWinner.Visible = True
            LblHanteiAka.Visible = False
            LblHanteiAo.Visible = True
        End If

        AudioController.PlaySound("Winner by Point")
        blinkTimer.Start() ' Ini otomatis akan membuat layar Scoreboard raksasa berkedip!
    End Sub

    ' ==========================================================
    ' EVENT HANDLER TOMBOL START SCOREBOARD
    ' ==========================================================
    Private Sub BtnStartScoreboard_Click(sender As Object, e As EventArgs)
        ' 1. Cek apakah layar Score Board sudah terbuka
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then
            ' 2. Jika belum, buat instance baru dari desain ScoreBoard kita
            frmScoreboard = New ScoreBoard()
            frmScoreboard.Show()
            frmScoreboard.LblMatchDesc.Text = TxtMatchDesc.Text
            If PicPreviewLogo.Image IsNot Nothing Then
                frmScoreboard.PicMatchLogo.Image = PicPreviewLogo.Image
            End If

            frmScoreboard.ApplyMatchDetailStyle(MatchDetailFontName, MatchDetailIsBold, MatchDetailColor)
            ' (Opsional tapi penting): Sinkronisasi data utama lainnya agar Scoreboard tidak kosong melompong saat dibuka
            SyncScoreboardProfile()
            SyncScoreboardPoints()
            SyncScoreboardTimer()
            SyncScoreboardPenalties()
        Else
            ' 3. Jika sudah terbuka tapi tertumpuk jendela lain, panggil ke depan
            frmScoreboard.BringToFront()
        End If
    End Sub

    ' ==========================================================
    ' EVENT HANDLER WAITING TIMER
    ' ==========================================================
    Private Sub BtnStartWait_Click(sender As Object, e As EventArgs)
        If waitTimer.Enabled Then
            ' Timer sedang berjalan → Stop
            waitTimer.Stop()
            BtnStartWait.Text = "Start"
            BtnStartWait.BackColor = SystemColors.Control
        Else
            ' Validasi: pastikan waktu tidak 0
            If NumWaitMin.Value = 0 AndAlso NumWaitSec.Value = 0 Then
                MessageBox.Show("Silakan atur waktu timer terlebih dahulu.",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            ' Mulai timer
            waitTimer.Start()
            BtnStartWait.Text = "Stop"
            BtnStartWait.BackColor = Color.LightCoral
        End If
    End Sub

    ' Dipanggil setiap 1 detik oleh waitTimer
    Private Sub waitTimer_Tick(sender As Object, e As EventArgs) Handles waitTimer.Tick
        Dim mins As Integer = CInt(NumWaitMin.Value)
        Dim secs As Integer = CInt(NumWaitSec.Value)

        If secs > 0 Then
            secs -= 1
        ElseIf mins > 0 Then
            mins -= 1
            secs = 59
        Else
            ' Waktu habis
            waitTimer.Stop()
            BtnStartWait.Text = "Start"
            BtnStartWait.BackColor = SystemColors.Control
            MessageBox.Show("Waktu tunggu (Waiting Timer) telah habis!",
                            "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        NumWaitMin.Value = mins
        NumWaitSec.Value = secs
    End Sub

    ' Reset waiting timer ke nilai awal
    Private Sub ResetTimer_Click(sender As Object, e As EventArgs)
        waitTimer.Stop()
        BtnStartWait.Text = "Start"
        BtnStartWait.BackColor = SystemColors.Control
        NumWaitMin.Value = 2
        NumWaitSec.Value = 0
    End Sub

    Private Sub BtnPenaltyAka_Click(sender As Object, e As EventArgs) Handles BtnAka1C.Click, BtnAka2C.Click, BtnAka3C.Click, BtnAkaHC.Click, BtnAkaH.Click
        Dim clickedBtn As Button = CType(sender, Button)

        ' 1. Daftarkan tombol ke dalam Array sesuai urutan yang benar
        Dim arrBtns() As Button = {BtnAka1C, BtnAka2C, BtnAka3C, BtnAkaHC, BtnAkaH}

        ' 2. Cari indeks tombol yang baru saja diklik (0 sampai 4)
        Dim clickedIndex As Integer = Array.IndexOf(arrBtns, clickedBtn)

        ' 3. Cari batas tertinggi tombol yang saat ini sedang aktif (berwarna merah)
        Dim currentMaxIndex As Integer = -1
        For i As Integer = 4 To 0 Step -1
            If arrBtns(i).BackColor = AkaColor Then
                currentMaxIndex = i
                Exit For
            End If
        Next

        ' 4. Tentukan batas akhir (level) yang baru
        Dim newMaxIndex As Integer
        If clickedIndex = currentMaxIndex Then
            ' Jika mengklik ujung tertinggi yang sedang aktif -> Matikan tombol tersebut (Undo 1 langkah)
            newMaxIndex = clickedIndex - 1
        Else
            ' Jika klik tombol lain (lebih tinggi atau lebih rendah) -> Setel batas ke tombol yang diklik
            newMaxIndex = clickedIndex
        End If

        For i As Integer = 0 To 4
            If i <= newMaxIndex Then
                arrBtns(i).BackColor = AkaColor
                arrBtns(i).ForeColor = AkaTextColor
            Else
                arrBtns(i).BackColor = SystemColors.Control
                arrBtns(i).ForeColor = Color.Black
            End If
        Next

        If newMaxIndex = 4 Then
            If LblAkaWinner.Visible = False Then
                LblAoWinner.Visible = True
            End If
        Else

            LblAoWinner.Visible = False

            If BtnAoH.BackColor = AoColor Then
                LblAkaWinner.Visible = True
            End If
        End If

        SyncScoreboardPenalties()

        ' ==========================================================
        ' MODIFIKASI AUDIO PENALTI AKA (Sesuai Peraturan Kumite)
        ' ==========================================================
        If newMaxIndex = 4 Then
            ' Jika mencapai batas indeks 4 (Hansoku / H) -> Mainkan suara Winner
            AudioController.PlaySound("Winner by Point")
        Else
            ' Jika di indeks 0-3 (1C, 2C, 3C, HC) atau batal -> Mainkan suara Penalty
            AudioController.PlaySound("Get Penalties")
        End If

    End Sub

    ' Fungsi Penalti AO (Biru)
    Private Sub BtnPenaltyAo_Click(sender As Object, e As EventArgs) Handles BtnAo1C.Click, BtnAo2C.Click, BtnAo3C.Click, BtnAoHC.Click, BtnAoH.Click
        Dim clickedBtn As Button = CType(sender, Button)

        ' 1. Daftarkan tombol ke dalam Array sesuai urutan yang benar
        Dim arrBtns() As Button = {BtnAo1C, BtnAo2C, BtnAo3C, BtnAoHC, BtnAoH}

        ' 2. Cari indeks tombol yang baru saja diklik (0 sampai 4)
        Dim clickedIndex As Integer = Array.IndexOf(arrBtns, clickedBtn)

        ' 3. Cari batas tertinggi tombol yang saat ini sedang aktif (berwarna biru)
        Dim currentMaxIndex As Integer = -1
        For i As Integer = 4 To 0 Step -1
            If arrBtns(i).BackColor = AoColor Then
                currentMaxIndex = i
                Exit For
            End If
        Next

        ' 4. Tentukan batas akhir (level) yang baru
        Dim newMaxIndex As Integer
        If clickedIndex = currentMaxIndex Then
            ' Jika mengklik ujung tertinggi yang sedang aktif -> Matikan tombol tersebut (Undo 1 langkah)
            newMaxIndex = clickedIndex - 1
        Else
            ' Jika klik tombol lain -> Setel batas ke tombol yang diklik
            newMaxIndex = clickedIndex
        End If

        ' 5. Terapkan warna ke semua tombol berdasarkan batas yang baru
        For i As Integer = 0 To 4
            If i <= newMaxIndex Then
                ' Nyalakan tombol
                arrBtns(i).BackColor = AoColor
                arrBtns(i).ForeColor = AoTextColor
            Else
                ' Matikan tombol
                arrBtns(i).BackColor = SystemColors.Control
                arrBtns(i).ForeColor = Color.Black
            End If
        Next

        ' 6. KONDISI WINNER: Jika H menyala, AKA menang (HANYA JIKA AO belum dideklarasikan menang)
        If newMaxIndex = 4 Then
            If LblAoWinner.Visible = False Then
                LblAkaWinner.Visible = True
            End If
        Else
            ' Jika batal 'H', sembunyikan label pemenang AKA
            LblAkaWinner.Visible = False

            ' SMART UNDO: Jika ternyata AKA posisinya sedang 'H' (sempat tertahan), nyalakan kemenangan AO sekarang
            If BtnAkaH.BackColor = AkaColor Then
                LblAoWinner.Visible = True
            End If
        End If

        SyncScoreboardPenalties()

        ' ==========================================================
        ' MODIFIKASI AUDIO PENALTI AO (Sesuai Peraturan Kumite)
        ' ==========================================================
        If newMaxIndex = 4 Then
            ' Jika mencapai batas indeks 4 (Hansoku / H) -> Mainkan suara Winner
            AudioController.PlaySound("Winner by Point")
        Else
            ' Jika di indeks 0-3 (1C, 2C, 3C, HC) atau batal -> Mainkan suara Penalty
            AudioController.PlaySound("Get Penalties")
        End If

    End Sub

    Private Sub DgvAoHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAoHistory.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 3 Then
            Dim row As DataGridViewRow = DgvAoHistory.Rows(e.RowIndex)
            Dim no As String = row.Cells(0).Value.ToString()
            Dim time As String = row.Cells(1).Value.ToString()
            Dim currentType As String = row.Cells(2).Value.ToString()

            Dim newScore As String = ShowChangeScoreDialog(no, currentType, time)

            If newScore = "Cancel" Then
                DgvAoHistory.Rows.RemoveAt(e.RowIndex)
            ElseIf newScore <> "" Then
                row.Cells(2).Value = newScore
            End If

            RecalculateTotalScore(DgvAoHistory, LblAoMainScore)
        End If
    End Sub

    ' ==========================================================
    ' FUNGSI LOGIKA MATCH TIMER (PERTANDINGAN UTAMA) - PRESISI TINGGI
    ' ==========================================================

    ' Deklarasi Timer backend (Interval 100 ms = 0.1 detik)
    Private WithEvents matchTimer As New Timer() With {.Interval = 100}

    ' Variabel baru: Menggunakan skala Desidetik (Contoh 2 Menit = 120 detik = 1200 desidetik)
    Private totalTenths As Integer = 1200

    ' Gembok Anti-Looping
    Private isSyncingTimer As Boolean = False

    ' Fungsi pembantu untuk memperbarui tampilan teks waktu (M:SS.ms)
    Private Sub UpdateMatchTimerDisplay()
        Dim mins As Integer = totalTenths \ 600
        Dim secs As Integer = (totalTenths Mod 600) \ 10
        Dim ms As Integer = totalTenths Mod 10

        ' Memperbarui label teks besar kuning menggunakan variabel asli LblMatchTimerValue
        LblMatchTimerValue.Text = String.Format("{0}:{1:00}.{2}", mins, secs, ms)

        ' Kunci gembok agar ValueChanged tidak terpancing otomatis saat UI disinkronkan
        isSyncingTimer = True
        NumMatchMin.Value = mins
        NumMatchSec.Value = secs
        isSyncingTimer = False
    End Sub

    ' ==========================================================
    ' EVENT HANDLER INPUT MANUAL (NUMERIC UP DOWN)
    ' ==========================================================
    Private Sub NumMatch_ValueChanged(sender As Object, e As EventArgs) Handles NumMatchMin.ValueChanged, NumMatchSec.ValueChanged
        ' Jika perubahan nilai dilakukan oleh sistem, abaikan!
        If isSyncingTimer Then Return

        ' Perbarui variabel utama penampung waktu (Menit & Detik dikonversi ke Desidetik)
        totalTenths = (CInt(NumMatchMin.Value) * 600) + (CInt(NumMatchSec.Value) * 10)

        UpdateMatchTimerDisplay()
        SyncScoreboardTimer() ' Langsung lempar perubahan ke layar Scoreboard
    End Sub

    ' 1. Logika Tombol Start/Pause Timer
    Private Sub BtnStartTimer_Click(sender As Object, e As EventArgs) Handles BtnStartTimer.Click
        If matchTimer.Enabled Then
            ' Jika sedang jalan, maka Pause/Stop
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
        Else
            If totalTenths <= 0 Then
                MessageBox.Show("Waktu sudah habis! Silakan reset atau setel waktu baru.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Mulai timer
            matchTimer.Start()
            BtnStartTimer.Text = "Stop Timer"
            BtnStartTimer.BackColor = Color.LightCoral
        End If
    End Sub

    ' 2. Logika Hitung Mundur (Berjalan otomatis berkecepatan tinggi setiap 0.1 detik)
    Private Sub matchTimer_Tick(sender As Object, e As EventArgs) Handles matchTimer.Tick
        If totalTenths > 0 Then
            totalTenths -= 1
            UpdateMatchTimerDisplay()
            SyncScoreboardTimer() ' Sinkronisasi angka berputar secara REAL-TIME ke proyektor

            ' ==========================================================
            ' TAMBAHAN AUDIO: 15 Second Warning (Atoshi Baraku)
            ' ==========================================================
            If totalTenths = 150 Then ' 150 desidetik = 15.0 Detik
                AudioController.PlaySound("15 Second")
            End If

        Else
            ' Waktu habis (Yame)
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold

            UpdateMatchTimerDisplay() ' Memaksa tampilan membeku pas di angka 0:00.0
            SyncScoreboardTimer()

            ' --- PANGGIL SUARA END OF TIMER ---
            AudioController.PlaySound("End of Timer")

            MessageBox.Show("Waktu Pertandingan Habis (Yame)!", "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' 3. Logika Tombol Preset Waktu Cepat (1:30, 2:00, 3:00)
    Private Sub BtnTime130_Click(sender As Object, e As EventArgs) Handles BtnTime130.Click
        totalTenths = 900 ' 90.0 detik
        UpdateMatchTimerDisplay()
        SyncScoreboardTimer()
    End Sub

    Private Sub BtnTime200_Click(sender As Object, e As EventArgs) Handles BtnTime200.Click
        totalTenths = 1200 ' 120.0 detik
        UpdateMatchTimerDisplay()
        SyncScoreboardTimer()
    End Sub

    Private Sub BtnTime300_Click(sender As Object, e As EventArgs) Handles BtnTime300.Click
        totalTenths = 1800 ' 180.0 detik
        UpdateMatchTimerDisplay()
        SyncScoreboardTimer()
    End Sub

    ' 4. Logika Tombol Adjust Presisi (+ dan -) per 1 detik
    Private Sub BtnMatchTimePlus_Click(sender As Object, e As EventArgs) Handles BtnMatchTimePlus.Click
        totalTenths += 10 ' Menambah 1 detik penuh
        UpdateMatchTimerDisplay()
        SyncScoreboardTimer()
    End Sub

    Private Sub BtnMatchTimeMinus_Click(sender As Object, e As EventArgs) Handles BtnMatchTimeMinus.Click
        If totalTenths >= 10 Then
            totalTenths -= 10 ' Mengurangi 1 detik penuh
            UpdateMatchTimerDisplay()
            SyncScoreboardTimer()
        End If
    End Sub

    ' 5. Logika Tombol Reset Timer
    Private Sub BtnResetTimer_Click(sender As Object, e As EventArgs) Handles BtnResetTimer.Click
        matchTimer.Stop()
        BtnStartTimer.Text = "Start Timer"
        BtnStartTimer.BackColor = Color.Gold

        ' Cerdas: Mengambil nilai dari kotak input angka (NumMatchMin & NumMatchSec)
        totalTenths = (CInt(NumMatchMin.Value) * 600) + (CInt(NumMatchSec.Value) * 10)

        ' Fallback jika kotak input 0:00, kembalikan ke default 2 menit (1200)
        If totalTenths = 0 Then totalTenths = 1200

        UpdateMatchTimerDisplay()
        SyncScoreboardTimer()
    End Sub

    ' ----------------------------------------------------------
    ' EVENT HANDLER TOMBOL SKOR AKA (MERAH)
    ' ----------------------------------------------------------
    Private Sub BtnAkaIppon_Click(sender As Object, e As EventArgs) Handles BtnAkaIppon.Click
        AddMatchScore(DgvAkaHistory, LblAkaMainScore, "(3)-Ippon", 3)
    End Sub

    Private Sub BtnAkaWazaari_Click(sender As Object, e As EventArgs) Handles BtnAkaWazaari.Click
        AddMatchScore(DgvAkaHistory, LblAkaMainScore, "(2)-Waza-ari", 2)
    End Sub

    Private Sub BtnAkaYuko_Click(sender As Object, e As EventArgs) Handles BtnAkaYuko.Click
        AddMatchScore(DgvAkaHistory, LblAkaMainScore, "(1)-Yuko", 1)
    End Sub

    ' ----------------------------------------------------------
    ' EVENT HANDLER TOMBOL SKOR AO (BIRU)
    ' ----------------------------------------------------------
    Private Sub BtnAoIppon_Click(sender As Object, e As EventArgs) Handles BtnAoIppon.Click
        AddMatchScore(DgvAoHistory, LblAoMainScore, "(3)-Ippon", 3)
    End Sub

    Private Sub BtnAoWazaari_Click(sender As Object, e As EventArgs) Handles BtnAoWazaari.Click
        AddMatchScore(DgvAoHistory, LblAoMainScore, "(2)-Waza-ari", 2)
    End Sub

    Private Sub BtnAoYuko_Click(sender As Object, e As EventArgs) Handles BtnAoYuko.Click
        AddMatchScore(DgvAoHistory, LblAoMainScore, "(1)-Yuko", 1)
    End Sub

    ' Deteksi Klik Tabel AKA
    Private Sub DgvAkaHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAkaHistory.CellContentClick
        ' Pastikan yang diklik adalah isi baris dan merupakan kolom tombol "Change" (Kolom ke-4 / Indeks 3)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 3 Then
            Dim row As DataGridViewRow = DgvAkaHistory.Rows(e.RowIndex)
            Dim no As String = row.Cells(0).Value.ToString()
            Dim time As String = row.Cells(1).Value.ToString()
            Dim currentType As String = row.Cells(2).Value.ToString()

            ' Tampilkan Popup UI Desain Khusus
            Dim newScore As String = ShowChangeScoreDialog(no, currentType, time)

            ' Proses hasil dari Popup
            If newScore = "Cancel" Then
                DgvAkaHistory.Rows.RemoveAt(e.RowIndex) ' Hapus baris jika di-cancel
            ElseIf newScore <> "" Then
                row.Cells(2).Value = newScore ' Ubah teks tipe skor
            End If

            ' Hitung ulang skor raksasa
            RecalculateTotalScore(DgvAkaHistory, LblAkaMainScore)
        End If
    End Sub

    ' ==========================================================
    ' FUNGSI LOGIKA PENAMBAHAN SKOR & RESET
    ' ==========================================================

    Private Sub AddMatchScore(dgv As DataGridView, lblScore As Label, scoreType As String, points As Integer)
        ' Kunci untuk memperbaiki BUG Index (Mematikan baris kosong bawaan)
        dgv.AllowUserToAddRows = False

        ' 1. Tentukan Nomor Urut Otomatis dengan benar
        Dim noUrut As Integer = dgv.Rows.Count + 1

        ' 2. Ambil Waktu dari Match Timer
        Dim waktuSaatIni As String = "0:00"
        If LblMatchTimerValue.Text.Contains(".") Then
            waktuSaatIni = LblMatchTimerValue.Text.Split("."c)(0)
        Else
            waktuSaatIni = LblMatchTimerValue.Text
        End If

        ' 3. Tambahkan Baris Baru ke Tabel (Nomor, Timer, Tipe Skor, Tombol Action)
        ' Kolom ke-4 (indeks 3) otomatis terisi teks "Change" karena settingan Designer
        dgv.Rows.Add(noUrut, waktuSaatIni, scoreType, "Change")
        ' --- PANGGIL SUARA GET POINT ---
        AudioController.PlaySound("Get Point")
        ' 4. Kalkulasi ulang seluruh skor di tabel agar selalu akurat
        RecalculateTotalScore(dgv, lblScore)
    End Sub

    ' ==========================================================
    ' FUNGSI RESET SKOR (AKA & AO)
    ' ==========================================================

    Private Sub BtnAkaResetScore_Click(sender As Object, e As EventArgs) Handles BtnAkaResetScore.Click
        ' 1. MATIKAN TIMER KEDIP DAN RESET STATUS KEMENANGAN TERLEBIH DAHULU
        If blinkTimer IsNot Nothing Then blinkTimer.Stop()
        firstWinnerDeclared = ""
        isAkaHanteiWin = False
        isAoHanteiWin = False

        ' 2. Kosongkan tabel
        DgvAkaHistory.Rows.Clear()

        ' 3. Panggil mesin penghitung agar angka raksasa dan Score Summary kembali ke 0
        RecalculateTotalScore(DgvAkaHistory, LblAkaMainScore)

        ' 4. MATIKAN LABEL SECARA PAKSA (Diletakkan di akhir agar tidak tertimpa proses lain)
        LblAkaWinner.Visible = False
        LblHanteiAka.Visible = False
        LblHanteiAo.Visible = False

        ' 5. Paksa antarmuka (UI) untuk langsung memuat ulang perubahannya
        Me.Refresh()
    End Sub

    ' Tombol Reset Score AO (Biru)
    Private Sub BtnAoResetScore_Click(sender As Object, e As EventArgs) Handles BtnAoResetScore.Click
        ' 1. MATIKAN TIMER KEDIP DAN RESET STATUS KEMENANGAN TERLEBIH DAHULU
        If blinkTimer IsNot Nothing Then blinkTimer.Stop()
        firstWinnerDeclared = ""
        isAkaHanteiWin = False
        isAoHanteiWin = False

        ' 2. Kosongkan tabel
        DgvAoHistory.Rows.Clear()

        ' 3. Panggil mesin penghitung agar angka raksasa dan Score Summary kembali ke 0
        RecalculateTotalScore(DgvAoHistory, LblAoMainScore)

        ' 4. MATIKAN LABEL SECARA PAKSA (Diletakkan di akhir agar tidak tertimpa proses lain)
        LblAoWinner.Visible = False
        LblHanteiAka.Visible = False
        LblHanteiAo.Visible = False

        ' 5. Paksa antarmuka (UI) untuk langsung memuat ulang perubahannya
        Me.Refresh()
    End Sub


    ' ==========================================================
    ' FUNGSI POPUP "CHANGE" & KALKULASI ULANG SKOR
    ' ==========================================================

    ' Helper: Menghitung ulang seluruh poin yang ada di tabel
    ' ==========================================================
    ' FUNGSI KALKULASI ULANG SKOR & PENENTUAN PEMENANG (WIN.POINT)
    ' ==========================================================
    Private Sub RecalculateTotalScore(dgv As DataGridView, lblScore As Label)
        ' 1. Hitung ulang total poin DAN JUMLAH KLIK dari tabel
        Dim total As Integer = 0
        Dim countIppon As Integer = 0
        Dim countWazaari As Integer = 0
        Dim countYuko As Integer = 0

        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow AndAlso row.Cells.Count > 2 AndAlso row.Cells(2).Value IsNot Nothing Then
                Dim typeStr As String = row.Cells(2).Value.ToString()
                ' Deteksi tipe skor dan hitung jumlah kemunculannya
                If typeStr.Contains("(3)") Then
                    total += 3
                    countIppon += 1
                End If
                If typeStr.Contains("(2)") Then
                    total += 2
                    countWazaari += 1
                End If
                If typeStr.Contains("(1)") Then
                    total += 1
                    countYuko += 1
                End If
            End If
        Next

        ' 2. Tampilkan skor terbaru ke angka raksasa
        lblScore.Text = total.ToString()
        SyncScoreboardPoints()

        ' =======================================================
        ' 3. UPDATE SCORE SUMMARY (RINGKASAN POIN)
        ' =======================================================
        If lblScore.Name = "LblAkaMainScore" Then
            LblAkaIpponCount.Text = "Ippon  " & countIppon.ToString()
            LblAkaWazaariCount.Text = "Waza-ari  " & countWazaari.ToString()
            LblAkaYukoCount.Text = "Yuko  " & countYuko.ToString()
        ElseIf lblScore.Name = "LblAoMainScore" Then
            LblAoIpponCount.Text = "Ippon  " & countIppon.ToString()
            LblAoWazaariCount.Text = "Waza-ari  " & countWazaari.ToString()
            LblAoYukoCount.Text = "Yuko  " & countYuko.ToString()
        End If

        ' =======================================================
        ' 4. LOGIKA WIN.POINT (CEK PEMENANG)
        ' =======================================================
        ' Ambil nilai batas kemenangan secara real-time dari kontrol UI (bisa di-adjust kapan saja)
        Dim batasMenang As Integer = CInt(NumWinPoint.Value)

        ' Jika skor mencapai atau melebihi batas kemenangan
        If total >= batasMenang AndAlso batasMenang > 0 Then

            ' --- PANGGIL SUARA WINNER ---
            AudioController.PlaySound("Winner by Point")

            ' Cek siapa yang mencapai poin tersebut
            If lblScore.Name = "LblAkaMainScore" Then
                LblAkaWinner.Visible = True ' Nyalakan label WINNER AKA

                ' Fitur Pintar: Otomatis hentikan timer pertandingan
                matchTimer.Stop()
                BtnStartTimer.Text = "Start Timer"
                BtnStartTimer.BackColor = Color.Gold

            ElseIf lblScore.Name = "LblAoMainScore" Then
                LblAoWinner.Visible = True ' Nyalakan label WINNER AO

                ' Fitur Pintar: Otomatis hentikan timer pertandingan
                matchTimer.Stop()
                BtnStartTimer.Text = "Start Timer"
                BtnStartTimer.BackColor = Color.Gold
            End If

        Else
            ' =======================================================
            ' 5. LOGIKA PEMBATALAN (SMART UNDO)
            ' =======================================================
            ' Jika wasit meralat skor (lewat tombol Change) sehingga poin turun di bawah Win Point.
            ' Kita harus menyembunyikan label WINNER, TAPI pastikan dulu dia tidak menang karena lawan kena diskualifikasi (H).
            If lblScore.Name = "LblAkaMainScore" AndAlso BtnAoH.BackColor <> AoColor Then
                LblAkaWinner.Visible = False ' Sembunyikan jika batal menang dan lawan tidak kena H
            ElseIf lblScore.Name = "LblAoMainScore" AndAlso BtnAkaH.BackColor <> AkaColor Then
                LblAoWinner.Visible = False ' Sembunyikan jika batal menang dan lawan tidak kena H
            End If
        End If
    End Sub

    ' ==========================================================
    ' FUNGSI PENGATURAN WIN POINT (EDIT & SAVE)
    ' ==========================================================

    Private Sub BtnEditWinPoint_Click(sender As Object, e As EventArgs) Handles BtnEditWinPoint.Click
        ' 1. Buka kunci kotak angka Win Point
        NumWinPoint.Enabled = True

        ' 2. Pindahkan kursor (fokus) langsung ke kotak tersebut agar operator bisa langsung mengetik
        NumWinPoint.Focus()

        ' 3. Matikan tombol Edit, nyalakan tombol Save
        BtnEditWinPoint.Enabled = False
        BtnSaveWinPoint.Enabled = True
    End Sub

    Private Sub BtnSaveWinPoint_Click(sender As Object, e As EventArgs) Handles BtnSaveWinPoint.Click
        ' 1. Kunci kembali kotak angka Win Point agar aman dari salah klik
        NumWinPoint.Enabled = False

        ' 2. Matikan tombol Save, nyalakan kembali tombol Edit
        BtnSaveWinPoint.Enabled = False
        BtnEditWinPoint.Enabled = True

        ' 3. FITUR PINTAR: Cek ulang status pemenang!
        ' Mengapa ini penting? Jika operator menurunkan Win Point dari 9 ke 6, 
        ' dan AKA sudah punya skor 7, maka AKA harus otomatis langsung dideklarasikan menang detik itu juga.
        RecalculateTotalScore(DgvAkaHistory, LblAkaMainScore)
        RecalculateTotalScore(DgvAoHistory, LblAoMainScore)

        MessageBox.Show("Win Point berhasil diperbarui menjadi " & NumWinPoint.Value.ToString() & "!", "Pengaturan Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Helper: Menggambar Form Popup Change secara dinamis (Sesuai Referensi)
    ' Helper: Menggambar Form Popup Change secara dinamis (Sesuai Referensi)
    Private Function ShowChangeScoreDialog(no As String, currentType As String, time As String) As String
        ' Buat Form baru di memori
        Dim frm As New Form()
        frm.Text = $"{no}. {currentType} [{time}]"
        frm.Size = New Size(280, 150)
        frm.StartPosition = FormStartPosition.CenterParent
        frm.FormBorderStyle = FormBorderStyle.FixedToolWindow
        frm.BackColor = Color.OldLace ' Warna krem muda

        ' Buat Label Judul
        Dim lblTitle As New Label() With {.Text = "Change to", .TextAlign = ContentAlignment.MiddleCenter, .Dock = DockStyle.Top, .Font = New Font("Segoe UI", 9, FontStyle.Bold)}
        frm.Controls.Add(lblTitle)

        ' Buat Tombol & Gunakan fitur bawaan DialogResult (Tanpa AddHandler / Lambda)
        Dim btnIppon As New Button() With {.Text = "Ippon", .Location = New Point(10, 30), .Size = New Size(75, 30), .BackColor = Color.White, .DialogResult = DialogResult.Yes}
        Dim btnWazaari As New Button() With {.Text = "Waza-ari", .Location = New Point(90, 30), .Size = New Size(80, 30), .BackColor = Color.White, .DialogResult = DialogResult.No}
        Dim btnYuko As New Button() With {.Text = "Yuko", .Location = New Point(175, 30), .Size = New Size(75, 30), .BackColor = Color.White, .DialogResult = DialogResult.Retry}

        ' Tombol batal/hapus skor (Kita gunakan Abort sebagai penanda)
        Dim btnCancel As New Button() With {.Text = "Cancel Score (0)", .Location = New Point(50, 70), .Size = New Size(160, 30), .BackColor = Color.White, .Font = New Font("Segoe UI", 9, FontStyle.Bold), .DialogResult = DialogResult.Abort}

        ' Nonaktifkan tombol yang sedang menjadi skor saat ini
        If currentType.Contains("Ippon") Then btnIppon.Enabled = False
        If currentType.Contains("Waza-ari") Then btnWazaari.Enabled = False
        If currentType.Contains("Yuko") Then btnYuko.Enabled = False

        frm.Controls.Add(btnIppon)
        frm.Controls.Add(btnWazaari)
        frm.Controls.Add(btnYuko)
        frm.Controls.Add(btnCancel)

        ' Tampilkan form dan tangkap tombol mana yang ditekan
        Dim aksiUser As DialogResult = frm.ShowDialog()

        ' Kembalikan hasil string berdasarkan tombol yang ditekan
        If aksiUser = DialogResult.Yes Then Return "(3)-Ippon"
        If aksiUser = DialogResult.No Then Return "(2)-Waza-ari"
        If aksiUser = DialogResult.Retry Then Return "(1)-Yuko"
        If aksiUser = DialogResult.Abort Then Return "Cancel"

        ' Jika user menekan silang (X) di pojok kanan atas form, hasilnya adalah string kosong (Tidak jadi ubah)
        Return ""
    End Function

    ' ==========================================================
    ' FUNGSI KIKEN & SHIKKAKU (UPDATE: ANTI DUPLIKAT WINNER)
    ' ==========================================================

    ' 1. Logika untuk Sudut AKA (Merah)
    Private Sub BtnAkaKikenShikkaku_Click(sender As Object, e As EventArgs) Handles BtnAkaKiken.Click, BtnAkaShikkaku.Click
        Dim clickedBtn As Button = CType(sender, Button)

        ' MENCEGAH DUPLIKAT: Jika tombol ini mau diaktifkan (belum kuning)
        If clickedBtn.BackColor <> Color.Yellow Then
            ' Cek apakah musuh (AO) sudah mengaktifkan Kiken/Shikkaku lebih dulu?
            If BtnAoKiken.BackColor = Color.Yellow OrElse BtnAoShikkaku.BackColor = Color.Yellow Then
                MessageBox.Show("Tim AO sudah berstatus Kiken/Shikkaku terlebih dahulu." & vbCrLf & "Sistem mencegah duplikat pemenang. Batalkan status AO jika terjadi kesalahan operator.", "Peringatan Blokir", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Hentikan proses, tombol AKA tidak jadi kuning
            End If
        End If

        ' Toggle: Jika sudah kuning (aktif), maka matikan. Jika belum, nyalakan kuning.
        If clickedBtn.BackColor = Color.Yellow Then
            clickedBtn.BackColor = SystemColors.Control
        Else
            clickedBtn.BackColor = Color.Yellow

            ' Cegah nyala bersamaan: Jika Kiken diklik, matikan Shikkaku, begitu sebaliknya
            If clickedBtn.Name = "BtnAkaKiken" Then BtnAkaShikkaku.BackColor = SystemColors.Control
            If clickedBtn.Name = "BtnAkaShikkaku" Then
                BtnAkaKiken.BackColor = SystemColors.Control
                ' (Suara Penalty lama dihapus dari sini agar tidak bertabrakan)
            End If
        End If

        ' Logika Winner: Jika AKA Kiken/Shikkaku, maka AO Menang
        If BtnAkaKiken.BackColor = Color.Yellow OrElse BtnAkaShikkaku.BackColor = Color.Yellow Then
            LblAoWinner.Visible = True ' Munculkan label pemenang di AO

            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold

            ' --- MODIFIKASI AUDIO: K.O / Diskualifikasi -> Lawan Menang ---
            AudioController.PlaySound("Winner by Point")
        Else
            ' Jika batal (Undo), sembunyikan Winner AO
            LblAoWinner.Visible = False

            ' SMART UNDO
            RecalculateTotalScore(DgvAoHistory, LblAoMainScore)
        End If
    End Sub

    ' 2. Logika untuk Sudut AO (Biru)
    Private Sub BtnAoKikenShikkaku_Click(sender As Object, e As EventArgs) Handles BtnAoKiken.Click, BtnAoShikkaku.Click
        Dim clickedBtn As Button = CType(sender, Button)

        ' MENCEGAH DUPLIKAT: Jika tombol ini mau diaktifkan (belum kuning)
        If clickedBtn.BackColor <> Color.Yellow Then
            ' Cek apakah musuh (AKA) sudah mengaktifkan Kiken/Shikkaku lebih dulu?
            If BtnAkaKiken.BackColor = Color.Yellow OrElse BtnAkaShikkaku.BackColor = Color.Yellow Then
                MessageBox.Show("Tim AKA sudah berstatus Kiken/Shikkaku terlebih dahulu." & vbCrLf & "Sistem mencegah duplikat pemenang. Batalkan status AKA jika terjadi kesalahan operator.", "Peringatan Blokir", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Hentikan proses, tombol AO tidak jadi kuning
            End If
        End If

        ' Toggle: Jika sudah kuning (aktif), maka matikan. Jika belum, nyalakan kuning.
        If clickedBtn.BackColor = Color.Yellow Then
            clickedBtn.BackColor = SystemColors.Control
        Else
            clickedBtn.BackColor = Color.Yellow

            ' Cegah nyala bersamaan: Jika Kiken diklik, matikan Shikkaku, begitu sebaliknya
            If clickedBtn.Name = "BtnAoKiken" Then BtnAoShikkaku.BackColor = SystemColors.Control
            If clickedBtn.Name = "BtnAoShikkaku" Then
                BtnAoKiken.BackColor = SystemColors.Control
                ' (Suara Penalty lama dihapus dari sini agar tidak bertabrakan)
            End If
        End If

        ' Logika Winner: Jika AO Kiken/Shikkaku, maka AKA Menang
        If BtnAoKiken.BackColor = Color.Yellow OrElse BtnAoShikkaku.BackColor = Color.Yellow Then
            LblAkaWinner.Visible = True ' Munculkan label pemenang di AKA

            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold

            ' --- MODIFIKASI AUDIO: K.O / Diskualifikasi -> Lawan Menang ---
            AudioController.PlaySound("Winner by Point")
        Else
            ' Jika batal (Undo), sembunyikan Winner AKA
            LblAkaWinner.Visible = False

            ' SMART UNDO
            RecalculateTotalScore(DgvAkaHistory, LblAkaMainScore)
        End If
    End Sub

    ' ==========================================================
    ' FUNGSI POP-UP TIMER KNOCKED OUT (UPDATE: OTOMATIS WINNER)
    ' ==========================================================
    Private Sub ShowKnockOutCountdown(isAka As Boolean, sourceButton As Button, winnerLabel As Label)

        ' Jika ada popup KO sebelumnya yang belum ditutup, tutup dulu
        If frmKOActive IsNot Nothing AndAlso Not frmKOActive.IsDisposed Then
            frmKOActive.Close()
        End If
        If koTimerActive IsNot Nothing Then
            koTimerActive.Stop()
        End If

        isKOCountdownDone = False

        ' ----------------------------------------------------------
        ' 1. Buat Form popup KO (hanya untuk display angka)
        ' ----------------------------------------------------------
        Dim frmKO As New Form()
        frmKO.Text = If(isAka, "AKA Knocked Out Countdown", "AO Knocked Out Countdown")
        frmKO.KeyPreview = True
        frmKO.TopMost = True   ' Selalu di atas semua window

        Dim bottomPanelHeight As Integer = 80

        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed AndAlso frmScoreboard.Visible Then
            frmKO.StartPosition = FormStartPosition.Manual
            frmKO.FormBorderStyle = FormBorderStyle.None
            frmKO.Location = frmScoreboard.Location
            frmKO.Size = frmScoreboard.Size
            bottomPanelHeight = CInt(frmKO.Height * 0.25)
        Else
            frmKO.Size = New Size(600, 350)
            frmKO.StartPosition = FormStartPosition.CenterScreen
            frmKO.FormBorderStyle = FormBorderStyle.FixedToolWindow
        End If

        Dim bgColor As Color = If(isAka, AkaColor, AoColor)

        ' Panel atas: angka countdown
        Dim pnlTop As New Panel() With {.Dock = DockStyle.Fill, .BackColor = bgColor}
        Dim numberFontSize As Single = If(frmKO.Height > 500, 250, 130)
        Dim lblNumber As New Label() With {
            .AutoSize = False,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Segoe UI", numberFontSize, FontStyle.Bold),
            .ForeColor = Color.White,
            .Text = "10"
        }
        pnlTop.Controls.Add(lblNumber)

        ' Panel bawah: teks status
        Dim pnlBottom As New Panel() With {.Dock = DockStyle.Bottom, .Height = bottomPanelHeight, .BackColor = Color.White}
        Dim textFontSize As Single = If(frmKO.Height > 500, 60, 32)
        Dim lblText As New Label() With {
            .AutoSize = False,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Segoe UI", textFontSize, FontStyle.Bold),
            .ForeColor = Color.Black,
            .Text = "Knocked Out Countdown"
        }
        pnlBottom.Controls.Add(lblText)

        frmKO.Controls.Add(pnlTop)
        frmKO.Controls.Add(pnlBottom)

        ' Simpan referensi ke variabel class agar bisa diakses dari luar
        frmKOActive = frmKO

        ' ----------------------------------------------------------
        ' 2. Setup timer countdown
        ' ----------------------------------------------------------
        Dim timeLeft As Integer = 10
        Dim koTimer As New Timer() With {.Interval = 1000}
        koTimerActive = koTimer

        ' Teks tombol saat countdown berjalan
        sourceButton.Text = $"Stop Countdown ({timeLeft:00})"
        sourceButton.BackColor = bgColor
        sourceButton.ForeColor = Color.White

        AddHandler koTimer.Tick, Sub(senderObj, eArgs)
                                     timeLeft -= 1
                                     lblNumber.Text = timeLeft.ToString("00")
                                     sourceButton.Text = $"Stop Countdown ({timeLeft:00})"

                                     If timeLeft <= 0 Then
                                         koTimer.Stop()
                                         isKOCountdownDone = True   ' <-- flag: siap Approve

                                         lblNumber.Text = "00"
                                         lblText.Text = If(isAka, "AKA Knocked Out", "AO Knocked Out")

                                         ' Ganti teks tombol menjadi Approve
                                         sourceButton.Text = "Approve Knocked Out?"
                                         sourceButton.BackColor = Color.LimeGreen
                                         sourceButton.ForeColor = Color.Black

                                         ' Nyalakan pemenang lawan
                                         winnerLabel.Visible = True
                                         AudioController.PlaySound("Knocked Out")

                                         ' Stop timer pertandingan
                                         matchTimer.Stop()
                                         BtnStartTimer.Text = "Start Timer"
                                         BtnStartTimer.BackColor = Color.Gold
                                     End If
                                 End Sub

        ' Tutup popup jika ESC ditekan (sama dengan Stop)
        AddHandler frmKO.KeyDown, Sub(sKey, eKey)
                                      If eKey.KeyCode = Keys.Escape Then
                                          koTimer.Stop()
                                          frmKO.Close()
                                      End If
                                  End Sub

        ' Saat popup ditutup karena alasan apapun: stop timer, bersihkan referensi
        AddHandler frmKO.FormClosing, Sub(senderObj, eArgs)
                                          koTimer.Stop()
                                          koTimerActive = Nothing
                                          frmKOActive = Nothing
                                      End Sub

        koTimer.Start()
        frmKO.Show()   ' <-- NON-MODAL: KumiteMainControl tetap bisa diklik
    End Sub

    ' ==========================================================
    ' EVENT HANDLER TOMBOL KNOCKED OUT AKA & AO (VERSI PRO)
    ' ==========================================================

    ' Tombol Knocked Out AKA (Merah)
    ' ==========================================================
    ' EVENT HANDLER TOMBOL KNOCKED OUT AKA & AO (VERSI PRO + POPUP TRACKING)
    ' ==========================================================

    ' Tombol Knocked Out AKA (Merah)
    Private Sub BtnAkaKnockedOut_Click(sender As Object, e As EventArgs) Handles BtnAkaKnockedOut.Click

        ' === FASE TUTUP TRACKING: popup "AKA KNOCKOUT" sedang tampil, klik = tutup & selesai ===
        If frmKOTrackingActive IsNot Nothing AndAlso Not frmKOTrackingActive.IsDisposed Then
            frmKOTrackingActive.Close()
            frmKOTrackingActive = Nothing
            Return
        End If

        ' === FASE APPROVE: countdown sudah 0, tunggu konfirmasi ===
        If isKOCountdownDone Then
            isKOCountdownDone = False

            If frmKOActive IsNot Nothing AndAlso Not frmKOActive.IsDisposed Then
                frmKOActive.Close()
            End If

            BtnAkaKnockedOut.Text = "Knocked Out"
            BtnAkaKnockedOut.BackColor = AkaColor
            BtnAkaKnockedOut.ForeColor = Color.White

            If BtnAoKnockedOut.BackColor = AoColor Then
                LblAoWinner.Visible = False
                LblAkaWinner.Visible = False
            Else
                ShowTrackingKnockOutPopup(True)
                EvaluateWinnerLogic()   ' AKA handler
            End If
            Return
        End If

        ' === FASE STOP: countdown sedang berjalan, batalkan KO ===
        If koTimerActive IsNot Nothing AndAlso koTimerActive.Enabled Then
            koTimerActive.Stop()
            koTimerActive = Nothing

            If frmKOActive IsNot Nothing AndAlso Not frmKOActive.IsDisposed Then
                frmKOActive.Close()
            End If

            BtnAkaKnockedOut.Text = "Knocked Out"
            BtnAkaKnockedOut.BackColor = SystemColors.Control
            BtnAkaKnockedOut.ForeColor = Color.Black
            Return
        End If

        ' === FASE UNDO: KO sudah dikonfirmasi, batalkan ===
        If BtnAkaKnockedOut.BackColor = AkaColor Then
            BtnAkaKnockedOut.BackColor = SystemColors.Control
            BtnAkaKnockedOut.ForeColor = Color.Black
            BtnAkaKnockedOut.Text = "Knocked Out"
            LblAoWinner.Visible = False

            If BtnAoKnockedOut.BackColor = AoColor Then
                LblAkaWinner.Visible = True
            End If

            RecalculateTotalScore(DgvAoHistory, LblAoMainScore)
            Return
        End If

        ' === FASE MULAI: Mulai countdown baru ===
        If UseKnockoutCountdown Then
            ShowKnockOutCountdown(True, BtnAkaKnockedOut, LblAoWinner)
        Else
            BtnAkaKnockedOut.BackColor = AkaColor
            BtnAkaKnockedOut.ForeColor = AkaTextColor

            If BtnAoKnockedOut.BackColor = AoColor Then
                LblAoWinner.Visible = False
                LblAkaWinner.Visible = False
            Else
                LblAoWinner.Visible = True
                ShowTrackingKnockOutPopup(True)
            End If

            AudioController.PlaySound("Knocked Out")
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
        End If
    End Sub

    ' Tombol Knocked Out AO (Biru)
    Private Sub BtnAoKnockedOut_Click(sender As Object, e As EventArgs) Handles BtnAoKnockedOut.Click

        ' === FASE TUTUP TRACKING: popup "AO KNOCKOUT" sedang tampil, klik = tutup & selesai ===
        If frmKOTrackingActive IsNot Nothing AndAlso Not frmKOTrackingActive.IsDisposed Then
            frmKOTrackingActive.Close()
            frmKOTrackingActive = Nothing
            Return
        End If

        ' === FASE APPROVE: countdown sudah 0, tunggu konfirmasi ===
        If isKOCountdownDone Then
            isKOCountdownDone = False

            If frmKOActive IsNot Nothing AndAlso Not frmKOActive.IsDisposed Then
                frmKOActive.Close()
            End If

            BtnAoKnockedOut.Text = "Knocked Out"
            BtnAoKnockedOut.BackColor = AoColor
            BtnAoKnockedOut.ForeColor = Color.White

            If BtnAkaKnockedOut.BackColor = AkaColor Then
                LblAkaWinner.Visible = False
                LblAoWinner.Visible = False
            Else
                ShowTrackingKnockOutPopup(False)
                EvaluateWinnerLogic()   ' AO handler
            End If
            Return
        End If

        ' === FASE STOP: countdown sedang berjalan, batalkan KO ===
        If koTimerActive IsNot Nothing AndAlso koTimerActive.Enabled Then
            koTimerActive.Stop()
            koTimerActive = Nothing

            If frmKOActive IsNot Nothing AndAlso Not frmKOActive.IsDisposed Then
                frmKOActive.Close()
            End If

            BtnAoKnockedOut.Text = "Knocked Out"
            BtnAoKnockedOut.BackColor = SystemColors.Control
            BtnAoKnockedOut.ForeColor = Color.Black
            Return
        End If

        ' === FASE UNDO: KO sudah dikonfirmasi, batalkan ===
        If BtnAoKnockedOut.BackColor = AoColor Then
            BtnAoKnockedOut.BackColor = SystemColors.Control
            BtnAoKnockedOut.ForeColor = Color.Black
            BtnAoKnockedOut.Text = "Knocked Out"
            LblAkaWinner.Visible = False

            If BtnAkaKnockedOut.BackColor = AkaColor Then
                LblAoWinner.Visible = True
            End If

            RecalculateTotalScore(DgvAkaHistory, LblAkaMainScore)
            Return
        End If

        ' === FASE MULAI: Mulai countdown baru ===
        If UseKnockoutCountdown Then
            ShowKnockOutCountdown(False, BtnAoKnockedOut, LblAkaWinner)
        Else
            BtnAoKnockedOut.BackColor = AoColor
            BtnAoKnockedOut.ForeColor = AoTextColor

            If BtnAkaKnockedOut.BackColor = AkaColor Then
                LblAkaWinner.Visible = False
                LblAoWinner.Visible = False
            Else
                LblAkaWinner.Visible = True
                ShowTrackingKnockOutPopup(False)
            End If

            AudioController.PlaySound("Knocked Out")
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
        End If
    End Sub

    ' ==========================================================
    ' SMART GLOBAL LOGGER (AUTO-INJECT KE SEMUA TOMBOL)
    ' ==========================================================

    ' Fungsi 1: Menyisir seluruh form dan menempelkan perekam ke setiap tombol
    Private Sub AttachGlobalLogger(parentControl As Control)
        For Each ctrl As Control In parentControl.Controls
            ' Jika kontrol ini adalah sebuah Button
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                ' Tambahkan 'mata-mata' (Event Handler) ke aksi kliknya secara dinamis
                AddHandler btn.Click, AddressOf GlobalLogger_Click
            End If

            ' Jika kontrol ini punya anak (misal Panel di dalam Panel), lakukan pencarian rekursif
            If ctrl.HasChildren Then
                AttachGlobalLogger(ctrl)
            End If
        Next
    End Sub


    ' ==========================================================
    ' FUNGSI HELPER: POP-UP KNOCKOUT YANG MENGIKUTI SCOREBOARD
    ' ==========================================================
    Private Sub ShowTrackingKnockOutPopup(isAkaKO As Boolean)
        If frmKOTrackingActive IsNot Nothing AndAlso Not frmKOTrackingActive.IsDisposed Then
            frmKOTrackingActive.Close()
        End If

        Dim popUp As New Form()
        Dim koColor As Color = If(isAkaKO, AkaColor, AoColor)
        Dim koText As String = If(isAkaKO, "AKA (RED)" & vbCrLf & "KNOCKOUT", "AO (BLUE)" & vbCrLf & "KNOCKOUT")

        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed AndAlso frmScoreboard.Visible Then
            popUp.StartPosition = FormStartPosition.Manual
            popUp.FormBorderStyle = FormBorderStyle.None
            popUp.Location = frmScoreboard.Location
            popUp.Size = frmScoreboard.Size
        Else
            popUp.StartPosition = FormStartPosition.CenterScreen
            popUp.FormBorderStyle = FormBorderStyle.None
            popUp.Size = New Size(1366, 768)
        End If

        popUp.BackColor = Color.FromArgb(20, 20, 20)
        popUp.TopMost = True
        popUp.KeyPreview = True

        Dim lblFontSize As Single = If(popUp.Height > 500, 90, 48)
        Dim lblKO As New Label() With {
            .Text = koText,
            .ForeColor = koColor,
            .Font = New Font("Segoe UI", lblFontSize, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Fill,
            .BackColor = Color.Transparent
        }
        popUp.Controls.Add(lblKO)

        frmKOTrackingActive = popUp

        ' Helper: tutup popup tracking
        Dim closeTracking As Action = Sub()
                                          If Not popUp.IsDisposed Then popUp.Close()
                                          frmKOTrackingActive = Nothing
                                      End Sub

        ' Klik di area mana saja pada popup = tutup
        Dim clickAnyArea As EventHandler = Sub(s, e) closeTracking()

        AddHandler popUp.Click, clickAnyArea
        AddHandler lblKO.Click, clickAnyArea

        ' ESC = tutup
        AddHandler popUp.KeyDown, Sub(sKey, eKey)
                                      If eKey.KeyCode = Keys.Escape Then closeTracking()
                                  End Sub

        AddHandler popUp.FormClosing, Sub(s, e)
                                          frmKOTrackingActive = Nothing
                                      End Sub

        popUp.Show()
    End Sub

    ' Fungsi 2: Aksi yang dijalankan ketika tombol APAPUN ditekan
    Private Sub GlobalLogger_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)

        ' Ambil teks dari tombol yang diklik. Bersihkan teks jika ada enter/baris baru
        Dim actionText As String = btn.Text.Replace(vbCrLf, " ").Replace(vbLf, " ")

        ' Abaikan jika tombol tidak memiliki teks
        If String.IsNullOrWhiteSpace(actionText) Then Return

        ' Deteksi Cerdas: Apakah ini tombol AKA, AO, atau Sistem Umum?
        Dim logDetail As String = ""
        Dim logType As String = "SYSTEM"

        If btn.Name.StartsWith("BtnAka") Then
            logDetail = $"(AKA) Clicked {actionText}"
            logType = "AKA ACTION"
        ElseIf btn.Name.StartsWith("BtnAo") Then
            logDetail = $"(AO) Clicked {actionText}"
            logType = "AO ACTION"
        Else
            logDetail = $"System Action: {actionText}"
            logType = "GENERAL"
        End If

        ' Tangkap waktu pertandingan saat ini
        Dim currentTime As String = "0:00"
        If LblMatchTimerValue IsNot Nothing Then currentTime = LblMatchTimerValue.Text

        ' ==========================================================
        ' [BUG FIX]: KIRIM DATA KE LOG GLOBAL (ACTIVITY LOGGER)
        ' ==========================================================
        ActivityLogger.LogKumiteAction(logDetail, logType, currentTime)
    End Sub


    ' ==========================================================
    ' SISTEM PENGHUBUNG KEYBOARD SHORTCUT
    ' ==========================================================
    Private Sub KumiteMainControl_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' 1. Cek apakah sistem shortcut sedang ON di menu setup
        If Not FormKeyboardShortcut.IsShortcutEnabled Then Exit Sub

        ' 2. Jangan jalankan shortcut jika user sedang mengetik di TextBox (Nama/Team)
        If TypeOf Me.ActiveControl Is TextBox Then Exit Sub

        ' 3. Terjemahkan input keyboard ke format teks (Contoh: "Control+B")
        Dim strShortcut As String = ""
        If e.Control Then strShortcut &= "Control+"
        If e.Shift Then strShortcut &= "Shift+"
        If e.Alt Then strShortcut &= "Alt+"
        strShortcut &= e.KeyCode.ToString()

        ' 4. Cari aksi yang cocok di ShortcutMap
        For Each entry In FormKeyboardShortcut.ShortcutMap
            If entry.Value = strShortcut Then
                ' JIKA COCOK, Jalankan fungsinya berdasarkan Nama Aksinya
                ExecuteShortcutAction(entry.Key)

                ' Hentikan fungsi asli windows (agar tidak bunyi Beep)
                e.SuppressKeyPress = True
                e.Handled = True
                Exit For
            End If
        Next
    End Sub

    ' Fungsi Mapper: Menghubungkan Nama Teks ke Sub/Fungsi aslinya
    Private Sub ExecuteShortcutAction(actionName As String)
        Select Case actionName
            Case "Start-Close Scoreboard" : BtnStartScoreboard_Click(Nothing, Nothing)
            Case "Match Timer Start-Stop" : BtnStartTimer_Click(Nothing, Nothing)
            Case "Match Timer Reset" : BtnResetTimer_Click(Nothing, Nothing)
            Case "AKA - Ippon(3)" : BtnAkaIppon_Click(Nothing, Nothing)
            Case "AKA - Wazaari(2)" : BtnAkaWazaari_Click(Nothing, Nothing)
            Case "AKA - Yuko(1)" : BtnAkaYuko_Click(Nothing, Nothing)
            Case "AO - Ippon(3)" : BtnAoIppon_Click(Nothing, Nothing)
            Case "AO - Wazaari(2)" : BtnAoWazaari_Click(Nothing, Nothing)
            Case "AO - Yuko(1)" : BtnAoYuko_Click(Nothing, Nothing)
                ' Tambahkan case lainnya sesuai daftar di isiDataShortcut()
        End Select
    End Sub

    ' ==========================================================
    ' ENGINE SINKRONISASI REAL-TIME KE SCOREBOARD
    ' ==========================================================

    ''' <summary>
    ''' Sinkronisasi Nama Pemain, Nama Tim (ke titik kuning), dan Info Tim (ke titik putih), serta Gambar.
    ''' </summary>
    Public Sub SyncScoreboardProfile()
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then

            ' 1. Mengupdate Nama Pemain
            frmScoreboard.LblAkaName.Text = TxtAkaNameMain.Text
            frmScoreboard.LblAoName.Text = TxtAoNameMain.Text

            ' 2. Mengupdate Nama Tim ke Titik Kuning (Atas)
            frmScoreboard.LblAkaDotsTop.Text = TxtAkaTeam.Text
            frmScoreboard.LblAoDotsTop.Text = TxtAoTeam.Text

            ' 3. Mengupdate Info Tim ke Titik Putih (Bawah)
            frmScoreboard.LblAkaDotsBot.Text = TxtAkaTeamInfo.Text
            frmScoreboard.LblAoDotsBot.Text = TxtAoTeamInfo.Text

            ' 4. Kosongkan teks di bawah nama pemain agar tidak dobel/berantakan
            frmScoreboard.LblAkaInfo.Text = ""
            frmScoreboard.LblAoInfo.Text = ""

            frmScoreboard.LblTatamiNum.Text = NumTatami.Value.ToString()
            frmScoreboard.LblMatchDesc.Text = TxtMatchDesc.Text

            ' 6. SINKRONISASI GAMBAR (PROFIL & LOGO)
            ' Memaksa mode gambar menjadi Zoom agar bendera utuh dan tidak nge-zoom ke warna merah saja
            frmScoreboard.PicAkaProfileSb.SizeMode = PictureBoxSizeMode.Zoom
            frmScoreboard.PicAkaTeamLogoSb.SizeMode = PictureBoxSizeMode.Zoom
            frmScoreboard.PicAoProfileSb.SizeMode = PictureBoxSizeMode.Zoom
            frmScoreboard.PicAoTeamLogoSb.SizeMode = PictureBoxSizeMode.Zoom

            ' Transfer gambar dari Control Panel ke Scoreboard
            frmScoreboard.PicAkaProfileSb.Image = PicAkaProfile.Image
            frmScoreboard.PicAkaTeamLogoSb.Image = PicAkaTeamLogo.Image

            frmScoreboard.PicAoProfileSb.Image = PicAoProfile.Image
            frmScoreboard.PicAoTeamLogoSb.Image = PicAoTeamLogo.Image


        End If
    End Sub

    ''' <summary>
    ''' Sinkronisasi Skor (Point) Utama AKA dan AO.
    ''' </summary>
    Public Sub SyncScoreboardPoints()
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            frmScoreboard.LblAkaScore.Text = LblAkaMainScore.Text
            frmScoreboard.LblAoScore.Text = LblAoMainScore.Text
        End If
    End Sub

    ''' <summary>
    ''' Sinkronisasi Timer Pertandingan (0:00.0).
    ''' </summary>
    Public Sub SyncScoreboardTimer()
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            ' Gunakan LblTimerMain untuk angka menit:detik 
            ' Kita pisahkan milidetik jika Anda ingin tampilan lebih presisi
            Dim timerFull As String = LblMatchTimerValue.Text
            If timerFull.Contains(".") Then
                frmScoreboard.LblTimerMain.Text = timerFull.Split("."c)(0)
                frmScoreboard.LblTimerMilli.Text = "." & timerFull.Split("."c)(1)
            Else
                frmScoreboard.LblTimerMain.Text = timerFull
            End If
        End If
    End Sub



    Public Sub SyncScoreboardPenalties()
        ' Pastikan menggunakan nama variabel form yang sudah dideklarasikan (frmScoreboard)
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then

            ' Pastikan array di dalam form Scoreboard sudah terisi (Load sudah berjalan)
            If frmScoreboard.AkaPenLabels IsNot Nothing Then
                Dim akaBtns = {BtnAka1C, BtnAka2C, BtnAka3C, BtnAkaHC, BtnAkaH}
                Dim aoBtns = {BtnAo1C, BtnAo2C, BtnAo3C, BtnAoHC, BtnAoH}

                For i As Integer = 0 To 4
                    ' Sinkronisasi AKA (Merah)
                    If akaBtns(i).BackColor = AkaColor Then
                        frmScoreboard.AkaPenLabels(i).BackColor = AkaColor
                    Else
                        frmScoreboard.AkaPenLabels(i).BackColor = Color.Transparent
                    End If

                    ' Sinkronisasi AO (Biru)
                    If aoBtns(i).BackColor = AoColor Then
                        frmScoreboard.AoPenLabels(i).BackColor = AoColor
                    Else
                        frmScoreboard.AoPenLabels(i).BackColor = Color.Transparent
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub BtnAkaUserIcon1_Click(sender As Object, e As EventArgs) Handles BtnAkaUserIcon1.Click
        targetSide = "AKA"
        Dim frm As New ListOfCompetitor()
        frm.ShowDialog()
    End Sub

    Private Sub BtnAoUserIcon1_Click(sender As Object, e As EventArgs) Handles BtnAoUserIcon1.Click
        targetSide = "AO"
        Dim frm As New ListOfCompetitor()
        frm.ShowDialog()
    End Sub

    ' ==========================================================
    ' INTERFACES INTEGRASI: TOMBOL SHOW WINNER AKA & AO (KODE FINAL)
    ' ==========================================================

    ' =========================================================
    ' 1. EVENT CLICK SHOW WINNER (AKA - MERAH)
    ' =========================================================
    Private Sub BtnAkaShowWinner_Click(sender As Object, e As EventArgs) Handles BtnAkaShowWinner.Click
        ' Ambil nama dari field nama utama (TxtAkaNameMain), bukan TxtAkaName yang berisi "Nama | Tim"
        Dim namaPemenang As String = TxtAkaNameMain.Text.Trim()
        Dim timPemenang As String = TxtAkaTeam.Text.Trim()

        ' Fallback: jika TxtAkaNameMain kosong, coba parse dari TxtAkaName ("Nama | Tim")
        If String.IsNullOrWhiteSpace(namaPemenang) AndAlso TxtAkaName.Text.Contains("|") Then
            Dim parts() As String = TxtAkaName.Text.Split("|"c)
            namaPemenang = parts(0).Trim()
            If String.IsNullOrWhiteSpace(timPemenang) AndAlso parts.Length > 1 Then
                timPemenang = parts(1).Trim()
            End If
        End If

        Dim frmWinner As New WinnerForm(True, namaPemenang, timPemenang)

        ' --- LOGIKA OVERLAY FULLSIZE MENGIKUTI SCOREBOARD ---
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed AndAlso frmScoreboard.Visible Then
            frmWinner.StartPosition = FormStartPosition.Manual
            frmWinner.Location = frmScoreboard.Location
            frmWinner.Size = frmScoreboard.Size
        End If

        frmWinner.ShowDialog()
    End Sub

    ' =========================================================
    ' 2. EVENT CLICK SHOW WINNER (AO - BIRU)
    ' =========================================================
    Private Sub BtnAoShowWinner_Click(sender As Object, e As EventArgs) Handles BtnAoShowWinner.Click
        ' Ambil nama dari field nama utama (TxtAoNameMain), bukan TxtAoName yang berisi "Nama | Tim"
        Dim namaPemenang As String = TxtAoNameMain.Text.Trim()
        Dim timPemenang As String = TxtAoTeam.Text.Trim()

        ' Fallback: jika TxtAoNameMain kosong, coba parse dari TxtAoName ("Nama | Tim")
        If String.IsNullOrWhiteSpace(namaPemenang) AndAlso TxtAoName.Text.Contains("|") Then
            Dim parts() As String = TxtAoName.Text.Split("|"c)
            namaPemenang = parts(0).Trim()
            If String.IsNullOrWhiteSpace(timPemenang) AndAlso parts.Length > 1 Then
                timPemenang = parts(1).Trim()
            End If
        End If

        Dim frmWinner As New WinnerForm(False, namaPemenang, timPemenang)

        ' --- LOGIKA OVERLAY FULLSIZE MENGIKUTI SCOREBOARD ---
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed AndAlso frmScoreboard.Visible Then
            frmWinner.StartPosition = FormStartPosition.Manual
            frmWinner.Location = frmScoreboard.Location
            frmWinner.Size = frmScoreboard.Size
        End If

        frmWinner.ShowDialog()
    End Sub

    ' ==========================================================
    ' ANIMASI INTERAKTIF: SKOR BERKEDAP-KEDIP SAAT WINNER TARGET REACHED
    ' ==========================================================

    ' Deklarasi Timer Animasi (Interval 500 ms = Kedip setiap setengah detik)
    Private WithEvents blinkTimer As New Timer() With {.Interval = 500}
    Private isBlinkOn As Boolean = True

    ' --- 1. MOTOR PENGHENTI: Mematikan & Mengembalikan Skor ke Kondisi Normal ---
    Public Sub StopWinnerBlinking()
        blinkTimer.Stop()

        ' Pastikan angka skor di Main Control kembali terlihat solid (tidak hilang)
        LblAkaMainScore.Visible = True
        LblAoMainScore.Visible = True

        ' Pastikan angka skor di Scoreboard Raksasa kembali terlihat solid
        Dim frmSb As ScoreBoard = CType(Application.OpenForms("ScoreBoard"), ScoreBoard)
        If frmSb IsNot Nothing Then
            frmSb.LblAkaScore.Visible = True
            frmSb.LblAoScore.Visible = True
        End If
    End Sub

    ' --- 2. EKSEKUTOR TICKING SINKRON: Mengedipkan SKOR HANYA pada tim yang ada di 'firstWinnerDeclared'
    Private Sub blinkTimer_Tick(sender As Object, e As EventArgs) Handles blinkTimer.Tick
        isBlinkOn = Not isBlinkOn

        ' Deteksi keberadaan jendela Scoreboard yang sedang aktif di layar kedua
        Dim frmSb As ScoreBoard = CType(Application.OpenForms("ScoreBoard"), ScoreBoard)

        ' PENGAMAN MUTLAK: Pastikan tim yang TIDAK menang tetap selalu menyala solid (tidak ikut hilang/berkedip)
        If firstWinnerDeclared <> "AKA" Then
            LblAkaMainScore.Visible = True
            If frmSb IsNot Nothing Then frmSb.LblAkaScore.Visible = True
        End If
        If firstWinnerDeclared <> "AO" Then
            LblAoMainScore.Visible = True
            If frmSb IsNot Nothing Then frmSb.LblAoScore.Visible = True
        End If

        ' EKSEKUSI KEDIP: Hanya merespons target yang dikunci abadi oleh firstWinnerDeclared
        If firstWinnerDeclared = "AKA" Then
            LblAkaMainScore.Visible = isBlinkOn
            If frmSb IsNot Nothing Then frmSb.LblAkaScore.Visible = isBlinkOn
        ElseIf firstWinnerDeclared = "AO" Then
            LblAoMainScore.Visible = isBlinkOn
            If frmSb IsNot Nothing Then frmSb.LblAoScore.Visible = isBlinkOn
        End If
    End Sub

    ' ==========================================================
    ' MUTAL EXCLUSION: LOCK WINNER PERTAMA (ANTI-DUPLIKAT GLOBAL)
    ' ==========================================================

    ' Variabel Kunci Utama di RAM untuk mencatat siapa yang menang DULUAN
    Private firstWinnerDeclared As String = ""
    Private isEvaluatingWinner As Boolean = False ' Gembok Anti-Looping/Anti-Recursion

    ' 1. SENSOR UTAMA MULTI-PROG: Mengawasi skor DAN menghadang manipulasi label ilegal
    Private Sub SystemWinnerLock_Watchers(sender As Object, e As EventArgs) Handles _
        LblAkaMainScore.TextChanged, LblAoMainScore.TextChanged,
        LblAkaWinner.VisibleChanged, LblAoWinner.VisibleChanged

        ' Jika sistem sedang merapikan label, abaikan sensor agar tidak stack overflow
        If isEvaluatingWinner Then Return

        EvaluateWinnerLogic()
    End Sub

    ' 2. CORE EVALUATOR UNIFIED: Satu-satunya Otak Penentu Kemenangan & Animasi di Sistem
    Private Sub EvaluateWinnerLogic()
        isEvaluatingWinner = True
        Try
            Dim akaScore As Integer = 0
            Dim aoScore As Integer = 0

            Integer.TryParse(LblAkaMainScore.Text, akaScore)
            Integer.TryParse(LblAoMainScore.Text, aoScore)

            ' Membaca target poin kemenangan dari setting secara dinamis
            Dim winTarget As Integer = 8
            Try
                Dim ctrl As Control = Me.Controls.Find("NumWinPoint", True).FirstOrDefault()
                If ctrl IsNot Nothing AndAlso TypeOf ctrl Is NumericUpDown Then
                    winTarget = CInt(CType(ctrl, NumericUpDown).Value)
                End If
            Catch
                winTarget = 8
            End Try

            ' ==========================================================
            ' DEFINISI DISKUALIFIKASI TOTAL (KIKEN, SHIKKAKU, HANSOKU, K.O)
            ' ==========================================================
            ' Variabel deteksi pintar agar kode jauh lebih bersih dan mencakup SEMUA jenis pelanggaran berat
            Dim isAkaDisqualified As Boolean = (BtnAkaKiken.BackColor = Color.Yellow OrElse BtnAkaShikkaku.BackColor = Color.Yellow OrElse BtnAkaH.BackColor = AkaColor OrElse BtnAkaKnockedOut.BackColor = AkaColor)
            Dim isAoDisqualified As Boolean = (BtnAoKiken.BackColor = Color.Yellow OrElse BtnAoShikkaku.BackColor = Color.Yellow OrElse BtnAoH.BackColor = AoColor OrElse BtnAoKnockedOut.BackColor = AoColor)
            If isAkaHanteiWin Then isAoDisqualified = True
            If isAoHanteiWin Then isAkaDisqualified = True

            ' ==========================================================
            ' PRIORITAS 1: LOCK SYSTEM MUTLAK (SIAPA CEPAT DIA MENGUNCI)
            ' ==========================================================
            If firstWinnerDeclared = "AKA" Then
                If akaScore >= winTarget OrElse isAoDisqualified Then
                    LblAkaWinner.Visible = True
                    LblAoWinner.Visible = False
                    blinkTimer.Start()
                    Exit Sub
                End If
            End If

            If firstWinnerDeclared = "AO" Then
                If aoScore >= winTarget OrElse isAkaDisqualified Then
                    LblAkaWinner.Visible = False
                    LblAoWinner.Visible = True
                    blinkTimer.Start()
                    Exit Sub
                End If
            End If

            ' ==========================================================
            ' PRIORITAS 2: LOGIKA SMART UNDO / RESET MATCH
            ' ==========================================================
            ' Jika skor di bawah target DAN tidak ada pelanggaran berat sama sekali di kedua belah pihak
            If akaScore < winTarget AndAlso aoScore < winTarget AndAlso Not isAkaDisqualified AndAlso Not isAoDisqualified Then
                firstWinnerDeclared = "" ' Bebaskan memori kunci pemenang
                LblAkaWinner.Visible = False
                LblAoWinner.Visible = False
                StopWinnerBlinking() ' Kembalikan angka skor menjadi solid menyala
                Exit Sub
            End If

            ' ==========================================================
            ' PRIORITAS 3: ELEKSI PENENTUAN BARU (FIRST-COME, FIRST-SERVED)
            ' ==========================================================

            ' --- JALUR A: DETEKSI KEMENANGAN POIN TERCEPAT ---
            If akaScore >= winTarget Then
                firstWinnerDeclared = "AKA"
                LblAkaWinner.Visible = True
                LblAoWinner.Visible = False

                matchTimer.Stop()
                BtnStartTimer.Text = "Start Timer"
                BtnStartTimer.BackColor = Color.Gold
                blinkTimer.Start()
                Exit Sub

            ElseIf aoScore >= winTarget Then
                firstWinnerDeclared = "AO"
                LblAkaWinner.Visible = False
                LblAoWinner.Visible = True

                matchTimer.Stop()
                BtnStartTimer.Text = "Start Timer"
                BtnStartTimer.BackColor = Color.Gold
                blinkTimer.Start()
                Exit Sub
            End If

            ' --- JALUR B: DETEKSI DISKUALIFIKASI MANUAL TERCEPAT (KIKEN / SHIKKAKU / H / KO) ---
            If isAkaDisqualified Then
                firstWinnerDeclared = "AO" ' AKA pelanggaran/KO duluan, AO dikunci menang
                LblAkaWinner.Visible = False
                LblAoWinner.Visible = True

                matchTimer.Stop()
                BtnStartTimer.Text = "Start Timer"
                BtnStartTimer.BackColor = Color.Gold
                blinkTimer.Start()
                Exit Sub
            End If

            If isAoDisqualified Then
                firstWinnerDeclared = "AKA" ' AO pelanggaran/KO duluan, AKA dikunci menang
                LblAkaWinner.Visible = True
                LblAoWinner.Visible = False

                matchTimer.Stop()
                BtnStartTimer.Text = "Start Timer"
                BtnStartTimer.BackColor = Color.Gold
                blinkTimer.Start()
                Exit Sub
            End If

        Finally
            isEvaluatingWinner = False ' Buka kembali gembok sensor sistem
        End Try
    End Sub

    ' ==========================================================
    ' FUNGSI INTEGRASI TATAMI KE SCORE BOARD
    ' ==========================================================

    ' 1. REAL-TIME SYNC: Berubah otomatis saat panah angka diklik
    Private Sub NumTatami_ValueChanged(sender As Object, e As EventArgs) Handles NumTatami.ValueChanged
        ' Mencari jendela ScoreBoard yang sedang aktif/terbuka di layar
        Dim frmSb As ScoreBoard = CType(Application.OpenForms("ScoreBoard"), ScoreBoard)

        ' Jika jendela ditemukan, paksa angka Tatami berubah
        If frmSb IsNot Nothing Then
            frmSb.LblTatamiNum.Text = NumTatami.Value.ToString()
        End If
    End Sub

    ' 2. FORCE SYNC: Fungsi tombol "Switch" untuk memaksa sinkronisasi
    Private Sub BtnSwitchPosition_Click(sender As Object, e As EventArgs) Handles BtnSwitchPosition.Click
        ' Mencari jendela ScoreBoard yang sedang aktif/terbuka di layar
        Dim frmSb As ScoreBoard = CType(Application.OpenForms("ScoreBoard"), ScoreBoard)

        ' Jika jendela ditemukan, sinkronkan dan beri notifikasi sukses
        If frmSb IsNot Nothing Then
            frmSb.LblTatamiNum.Text = NumTatami.Value.ToString()
            MessageBox.Show($"Nomor Tatami [{NumTatami.Value}] berhasil disinkronkan ke layar Score Board!", "Sinkronisasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Jika jendela ScoreBoard belum dibuka sama sekali
            MessageBox.Show("Layar Score Board belum dibuka! Silakan tampilkan Score Board terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    ' ==========================================================
    ' CLEAN UI ENGINE PRO: PEMBERSIH FOKUS & SELEKSI TOTAL
    ' ==========================================================

    ' 1. Fungsi Utama Pembersih (Sengaja tanpa "Handles MyBase.Click" agar bisa disebar otomatis)
    Private Sub ClearSelection_Click(sender As Object, e As EventArgs)
        ' Hilangkan kursor berkedip dari kotak input/angka
        Me.ActiveControl = Nothing
        targetSide = ""

        ' SENJATA MUTLAK: Hapus seleksi DAN lepaskan kursor memori tabel
        DgvAkaHistory.CurrentCell = Nothing
        DgvAkaHistory.ClearSelection()

        DgvAoHistory.CurrentCell = Nothing
        DgvAoHistory.ClearSelection()
    End Sub

    ' 2. Pemasang Sensor Gaib ke Seluruh Area Kosong (Form, Panel, GroupBox)
    Private Sub AttachBackgroundClickSensor(parentControl As Control)
        ' Pasang sensor klik HANYA pada area yang bertindak sebagai "Latar Belakang"
        If TypeOf parentControl Is Form OrElse TypeOf parentControl Is Panel OrElse TypeOf parentControl Is GroupBox Then
            AddHandler parentControl.Click, AddressOf ClearSelection_Click
        End If

        ' Sisir seluruh komponen anak di dalamnya secara rekursif (sampai ke akar)
        For Each ctrl As Control In parentControl.Controls
            AttachBackgroundClickSensor(ctrl)
        Next
    End Sub

    Private Sub BtnSendMatchInfo_Click(sender As Object, e As EventArgs) Handles BtnSendMatchInfo.Click
        ' 1. Jika layar Scoreboard kebetulan SEDANG TERBUKA, langsung update secara live di layar
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            ' Update Teks
            frmScoreboard.LblMatchDesc.Text = TxtMatchDesc.Text

            ' Update Logo
            If PicPreviewLogo.Image IsNot Nothing Then
                frmScoreboard.PicMatchLogo.Image = PicPreviewLogo.Image
            Else
                frmScoreboard.PicMatchLogo.Image = Nothing
            End If
        End If

        ' 2. SELALU munculkan notifikasi sukses persis seperti aplikasi aslinya!
        ' (Tanpa peduli layarnya sedang dibuka atau ditutup, sistem akan menganggapnya sukses tersimpan di memori).
        MessageBox.Show("Information updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnSelectLogo_Click(sender As Object, e As EventArgs) Handles BtnSelectLogo.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                ' Gunakan MemoryStream agar gambar transparan (PNG) tidak jadi hitam
                Dim bytes As Byte() = System.IO.File.ReadAllBytes(ofd.FileName)
                Dim ms As New IO.MemoryStream(bytes)
                PicPreviewLogo.Image = Image.FromStream(ms)
            End If
        End Using
    End Sub

    Private Sub BtnRemoveLogo_Click(sender As Object, e As EventArgs) Handles BtnRemoveLogo.Click
        PicPreviewLogo.Image = Nothing
    End Sub

    Private Sub BtnAkaVR_Click(sender As Object, e As EventArgs) Handles BtnAkaVR.Click
        isAkaVrActive = Not isAkaVrActive

        ' 2. Ubah warna tombol wasit sebagai indikator
        Dim btn As Button = CType(sender, Button)
        If isAkaVrActive Then
            btn.BackColor = AkaColor
            btn.ForeColor = Color.White
        Else
            btn.BackColor = SystemColors.Control
            btn.ForeColor = Color.Black
        End If

        ' 3. Munculkan/sembunyikan di Scoreboard Raksasa
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            frmScoreboard.LblVrAka.Visible = isAkaVrActive
        End If
    End Sub
    Private Sub BtnAoVR_Click(sender As Object, e As EventArgs) Handles BtnAoVR.Click
        isAoVrActive = Not isAoVrActive

        ' 2. Ubah warna tombol wasit sebagai indikator
        Dim btn As Button = CType(sender, Button)
        If isAoVrActive Then
            btn.BackColor = AoColor
            btn.ForeColor = Color.White
        Else
            btn.BackColor = SystemColors.Control
            btn.ForeColor = Color.Black
        End If

        ' 3. Munculkan/sembunyikan di Scoreboard Raksasa
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            frmScoreboard.LblVrAo.Visible = isAoVrActive
        End If
    End Sub
    Private Sub ShowVrRequestedSplash(teamName As String, teamColor As Color)
        Dim targetScreen As Screen

        ' 1. Cek ketersediaan monitor/proyektor
        If Screen.AllScreens.Length > 1 Then
            ' Jika ADA layar kedua (Extend Mode), targetkan ke proyektor
            targetScreen = Screen.AllScreens(1)
        Else
            ' Jika TIDAK ADA layar kedua (sedang ngoding/testing di laptop), 
            ' paksa targetkan ke layar utama laptop saja!
            targetScreen = Screen.AllScreens(0)
        End If

        ' 2. Buat Form layar penuh
        Dim splash As New Form()
        splash.FormBorderStyle = FormBorderStyle.None
        splash.BackColor = Color.Black
        splash.StartPosition = FormStartPosition.Manual
        splash.TopMost = True ' Selalu berada di paling depan

        ' 3. Pindahkan form ke layar yang sudah ditentukan oleh mesin pengecek di atas
        splash.Bounds = targetScreen.Bounds

        ' 4. Buat teks peringatan raksasa di tengah layar
        Dim lblPeringatan As New Label()
        lblPeringatan.Text = teamName & " VIDEO REVIEW REQUESTED"
        lblPeringatan.ForeColor = teamColor
        lblPeringatan.Font = New Font("Segoe UI", 65, FontStyle.Bold)
        lblPeringatan.Dock = DockStyle.Fill
        lblPeringatan.TextAlign = ContentAlignment.MiddleCenter
        splash.Controls.Add(lblPeringatan)

        ' 5. Fitur Pintar: Klik di mana saja pada layar raksasa ini untuk menutupnya
        AddHandler splash.Click, Sub() splash.Close()
        AddHandler lblPeringatan.Click, Sub() splash.Close()

        ' Tampilkan layarnya!
        splash.Show()
    End Sub

    Private Sub UpdateSenshuUI()
        ' 1. Ubah warna tombol di panel operator (KumiteMainControl)
        If isAkaSenshu Then
            BtnAkaSenshu.BackColor = AkaColor
            BtnAkaSenshu.ForeColor = Color.White
        Else
            BtnAkaSenshu.BackColor = SystemColors.Control
            BtnAkaSenshu.ForeColor = Color.Black
        End If

        If isAoSenshu Then
            BtnAoSenshu.BackColor = AoColor
            BtnAoSenshu.ForeColor = Color.White
        Else
            BtnAoSenshu.BackColor = SystemColors.Control
            BtnAoSenshu.ForeColor = Color.Black
        End If

        ' 2. Munculkan/Sembunyikan Label "S" kuning di Layar Scoreboard Raksasa
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            frmScoreboard.LblSenshuAka.Visible = isAkaSenshu
            frmScoreboard.LblSenshuAo.Visible = isAoSenshu
        End If
    End Sub

    Private Sub BtnAkaSenshu_Click(sender As Object, e As EventArgs) Handles BtnAkaSenshu.Click
        isAkaSenshu = Not isAkaSenshu

        ' LOGIKA KUNCI: Jika Senshu AKA menyala, Senshu AO otomatis DIMATIKAN!
        If isAkaSenshu Then
            isAoSenshu = False
        End If

        ' Panggil mesin update
        UpdateSenshuUI()
    End Sub

    Private Sub BtnAoSenshu_Click(sender As Object, e As EventArgs) Handles BtnAoSenshu.Click
        isAoSenshu = Not isAoSenshu
        ' LOGIKA KUNCI: Jika Senshu AO menyala, Senshu AKA otomatis DIMATIKAN!
        If isAoSenshu Then
            isAkaSenshu = False
        End If
        ' Panggil mesin update
        UpdateSenshuUI()
    End Sub

    Private Sub AKAVR_Click(sender As Object, e As EventArgs) Handles AKAVR.Click
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then
            MessageBox.Show("Scoreboard belum dinyalakan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Balikkan status saklar Tirai (Bumper)
        isVrBumperActive = Not isVrBumperActive

        ' 3. Kirim perintah ke layar Scoreboard untuk menurunkan "Tirai Hitam"
        frmScoreboard.LblVrBumper.Visible = isVrBumperActive

        ' 4. Ubah warna teks tirai sesuai tim yang meminta VR (AKA = Merah)
        frmScoreboard.LblVrBumper.ForeColor = AkaColor

        ' 5. Bawa Tirai ke lapisan paling depan (menutupi segalanya)
        frmScoreboard.LblVrBumper.BringToFront()

        ' 6. Ubah warna tombol wasit sebagai indikator
        Dim btn As Button = CType(sender, Button)
        If isVrBumperActive Then
            btn.BackColor = AkaColor
            btn.ForeColor = Color.White
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
        Else
            btn.BackColor = SystemColors.Control
            btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub AOVR_Click(sender As Object, e As EventArgs) Handles AOVR.Click
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then
            MessageBox.Show("Scoreboard belum dinyalakan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Balikkan status saklar Tirai (Bumper)
        isVrBumperActive = Not isVrBumperActive

        ' 3. Kirim perintah ke layar Scoreboard untuk menurunkan "Tirai Hitam"
        frmScoreboard.LblVrBumper.Visible = isVrBumperActive

        ' 4. Ubah warna teks tirai sesuai tim yang meminta VR (AO = Biru)
        frmScoreboard.LblVrBumper.ForeColor = AoColor

        ' 5. Bawa Tirai ke lapisan paling depan
        frmScoreboard.LblVrBumper.BringToFront()

        ' 6. Ubah warna tombol wasit sebagai indikator
        Dim btn As Button = CType(sender, Button)
        If isVrBumperActive Then
            btn.BackColor = AoColor
            btn.ForeColor = Color.White
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
        Else
            btn.BackColor = SystemColors.Control
            btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnAdjustPlus_Click(sender As Object, e As EventArgs) Handles BtnAdjustPlus.Click
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            ' Ambil angka dari kotak NumAdjustSize, lalu perintahkan Scoreboard untuk "Plus"
            frmScoreboard.AdjustTextSize(CboAdjustPlayer.Text, "Plus", CSng(NumAdjustSize.Value))
        End If
    End Sub

    ' Tombol Minus (-)
    Private Sub BtnAdjustMin_Click(sender As Object, e As EventArgs) Handles BtnAdjustMin.Click
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            ' Ambil angka dari kotak NumAdjustSize, lalu perintahkan Scoreboard untuk "Minus"
            frmScoreboard.AdjustTextSize(CboAdjustPlayer.Text, "Minus", CSng(NumAdjustSize.Value))
        End If
    End Sub

    ' Tombol Reset (R)
    Private Sub BtnAdjustR_Click(sender As Object, e As EventArgs) Handles BtnAdjustR.Click
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            ' Perintahkan Scoreboard untuk "Reset" ke ukuran bawaan pabrik
            frmScoreboard.AdjustTextSize(CboAdjustPlayer.Text, "Reset", 0)
        End If
    End Sub

    ' ==========================================================
    ' FUNGSI RESET MATCH (MENGEMBALIKAN KE KONDISI AWAL PABRIK)
    ' ==========================================================
    Private Sub BtnResetMatch_Click(sender As Object, e As EventArgs) Handles BtnResetMatch.Click
        ' 1. Minta Konfirmasi Keamanan
        If MessageBox.Show("Apakah Anda yakin ingin me-reset seluruh pertandingan?" & vbCrLf & "Semua data profil, skor, penalti, dan waktu akan dihapus bersih!", "Konfirmasi Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            ' 2. Hentikan semua timer dan reset memori pemenang
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
            StopWinnerBlinking()
            firstWinnerDeclared = ""

            ' 3. Bersihkan Profil & Antrean AKA (Merah)
            NextAkaName = ""
            NextAkaTeam = ""
            NextAkaInfo = ""
            TxtAkaName.Text = ""
            TxtAkaNameMain.Text = ""
            TxtAkaTeam.Text = ""
            TxtAkaTeamInfo.Text = ""
            PicAkaProfile.Image = Nothing
            PicAkaTeamLogo.Image = Nothing

            ' 4. Bersihkan Profil & Antrean AO (Biru)
            NextAoName = ""
            NextAoTeam = ""
            NextAoInfo = ""
            TxtAoName.Text = ""
            TxtAoNameMain.Text = ""
            TxtAoTeam.Text = ""
            TxtAoTeamInfo.Text = ""
            PicAoProfile.Image = Nothing
            PicAoTeamLogo.Image = Nothing

            ' 5. Bersihkan Tabel Skor & Label Pemenang
            DgvAkaHistory.Rows.Clear()
            DgvAoHistory.Rows.Clear()
            RecalculateTotalScore(DgvAkaHistory, LblAkaMainScore)
            RecalculateTotalScore(DgvAoHistory, LblAoMainScore)
            LblAkaWinner.Visible = False
            LblAoWinner.Visible = False

            ' 6. Matikan Semua Lampu Tombol Penalti AKA & AO
            Dim akaPenBtns() As Button = {BtnAka1C, BtnAka2C, BtnAka3C, BtnAkaHC, BtnAkaH}
            Dim aoPenBtns() As Button = {BtnAo1C, BtnAo2C, BtnAo3C, BtnAoHC, BtnAoH}
            For i As Integer = 0 To 4
                akaPenBtns(i).BackColor = SystemColors.Control
                akaPenBtns(i).ForeColor = Color.Black
                aoPenBtns(i).BackColor = SystemColors.Control
                aoPenBtns(i).ForeColor = Color.Black
            Next

            ' 7. Matikan Tombol Pelanggaran Berat (Kiken, Shikkaku, K.O)
            BtnAkaKiken.BackColor = SystemColors.Control
            BtnAkaShikkaku.BackColor = SystemColors.Control
            BtnAkaKnockedOut.BackColor = SystemColors.Control
            BtnAkaKnockedOut.ForeColor = Color.Black

            BtnAoKiken.BackColor = SystemColors.Control
            BtnAoShikkaku.BackColor = SystemColors.Control
            BtnAoKnockedOut.BackColor = SystemColors.Control
            BtnAoKnockedOut.ForeColor = Color.Black

            ' 8. Matikan Senshu & Sistem Video Review (VR)
            isAkaSenshu = False
            isAoSenshu = False
            BtnAkaSenshu.BackColor = SystemColors.Control
            BtnAkaSenshu.ForeColor = Color.Black
            BtnAoSenshu.BackColor = SystemColors.Control
            BtnAoSenshu.ForeColor = Color.Black

            isAkaVrActive = False
            isAoVrActive = False
            BtnAkaVR.BackColor = SystemColors.Control
            BtnAkaVR.ForeColor = Color.Black
            BtnAoVR.BackColor = SystemColors.Control
            BtnAoVR.ForeColor = Color.Black

            isVrBumperActive = False
            LblHanteiAka.Visible = False
            LblHanteiAo.Visible = False

            BtnResetTimer_Click(Nothing, Nothing)

            TxtMatchDesc.Clear()

            SyncScoreboardProfile()
            SyncScoreboardPoints()
            SyncScoreboardPenalties()
            UpdateSenshuUI()

            If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
                frmScoreboard.LblVrAka.Visible = False
                frmScoreboard.LblVrAo.Visible = False
                frmScoreboard.LblVrBumper.Visible = False
                frmScoreboard.PicMatchLogo.Image = Nothing
            End If

            MessageBox.Show("Sistem berhasil di-reset! Siap untuk pertandingan selanjutnya.", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        isAkaHanteiWin = False
        isAoHanteiWin = False
    End Sub

    ' ==========================================================
    ' FUNGSI SWAP (TUKAR POSISI AKA & AO)
    ' ==========================================================
    Private Sub BtnSwap_Click(sender As Object, e As EventArgs) Handles BtnSwap.Click
        ' Kunci Evaluator (Otak Pemenang) agar tidak salah deteksi saat proses pertukaran data berjalan
        isEvaluatingWinner = True

        ' ---> TAMBAHAN BARU: SWAP VARIABEL NEXT MATCH (ANTREAN ATAS) <---
        Dim tempNextName As String = NextAkaName
        NextAkaName = NextAoName
        NextAoName = tempNextName

        Dim tempNextTeam As String = NextAkaTeam
        NextAkaTeam = NextAoTeam
        NextAoTeam = tempNextTeam

        Dim tempNextInfo As String = NextAkaInfo
        NextAkaInfo = NextAoInfo
        NextAoInfo = tempNextInfo

        ' Menukar tulisan di kotak putih bagian paling atas form
        Dim tempTxtNext As String = TxtAkaName.Text
        TxtAkaName.Text = TxtAoName.Text
        TxtAoName.Text = tempTxtNext
        ' ----------------------------------------------------------------

        ' 1. SWAP PROFIL (Nama, Tim, Info & Foto di Panel Utama)
        Dim tempName As String = TxtAkaNameMain.Text
        TxtAkaNameMain.Text = TxtAoNameMain.Text
        TxtAoNameMain.Text = tempName

        Dim tempTeam As String = TxtAkaTeam.Text
        TxtAkaTeam.Text = TxtAoTeam.Text
        TxtAoTeam.Text = tempTeam

        Dim tempInfo As String = TxtAkaTeamInfo.Text
        TxtAkaTeamInfo.Text = TxtAoTeamInfo.Text
        TxtAoTeamInfo.Text = tempInfo

        Dim tempProf As Image = PicAkaProfile.Image
        PicAkaProfile.Image = PicAoProfile.Image
        PicAoProfile.Image = tempProf

        Dim tempLogo As Image = PicAkaTeamLogo.Image
        PicAkaTeamLogo.Image = PicAoTeamLogo.Image
        PicAoTeamLogo.Image = tempLogo

        ' 2. SWAP PENALTI & PELANGGARAN BERAT (Tombol)
        Dim akaBtns() As Button = {BtnAka1C, BtnAka2C, BtnAka3C, BtnAkaHC, BtnAkaH, BtnAkaKiken, BtnAkaShikkaku, BtnAkaKnockedOut}
        Dim aoBtns() As Button = {BtnAo1C, BtnAo2C, BtnAo3C, BtnAoHC, BtnAoH, BtnAoKiken, BtnAoShikkaku, BtnAoKnockedOut}

        For i As Integer = 0 To 7
            Dim tBack As Color = akaBtns(i).BackColor
            Dim tFore As Color = akaBtns(i).ForeColor
            Dim tText As String = akaBtns(i).Text

            ' Pindahkan AO ke AKA (Konversi warna biru menjadi merah)
            akaBtns(i).BackColor = If(aoBtns(i).BackColor = AoColor, AkaColor, aoBtns(i).BackColor)
            akaBtns(i).ForeColor = aoBtns(i).ForeColor
            akaBtns(i).Text = aoBtns(i).Text

            ' Pindahkan AKA ke AO (Konversi warna merah menjadi biru)
            aoBtns(i).BackColor = If(tBack = AkaColor, AoColor, tBack)
            aoBtns(i).ForeColor = tFore
            aoBtns(i).Text = tText
        Next

        ' 3. SWAP SENSHU
        Dim tempSenshu As Boolean = isAkaSenshu
        isAkaSenshu = isAoSenshu
        isAoSenshu = tempSenshu
        UpdateSenshuUI()

        ' 4. SWAP STATUS KEMENANGAN & HANTEI
        Dim tempAkaWin As Boolean = LblAkaWinner.Visible
        LblAkaWinner.Visible = LblAoWinner.Visible
        LblAoWinner.Visible = tempAkaWin

        Dim tempHanteiVis As Boolean = LblHanteiAka.Visible
        LblHanteiAka.Visible = LblHanteiAo.Visible
        LblHanteiAo.Visible = tempHanteiVis

        Dim tempHanteiStat As Boolean = isAkaHanteiWin
        isAkaHanteiWin = isAoHanteiWin
        isAoHanteiWin = tempHanteiStat

        If firstWinnerDeclared = "AKA" Then
            firstWinnerDeclared = "AO"
        ElseIf firstWinnerDeclared = "AO" Then
            firstWinnerDeclared = "AKA"
        End If

        ' 5. SWAP RIWAYAT SKOR (Tabel DataGridView)
        SwapDataGridViews(DgvAkaHistory, DgvAoHistory)

        ' Hitung ulang angka raksasa berdasarkan isi tabel yang baru saja ditukar
        RecalculateTotalScore(DgvAkaHistory, LblAkaMainScore)
        RecalculateTotalScore(DgvAoHistory, LblAoMainScore)

        ' Buka kunci dan pastikan tidak ada logika kemenangan yang terlewat
        isEvaluatingWinner = False
        EvaluateWinnerLogic()

        ' 6. SINKRONISASI TOTAL KE SCOREBOARD RAKSASA
        SyncScoreboardProfile()
        SyncScoreboardPoints()
        SyncScoreboardPenalties()

        Me.Refresh()
    End Sub

    ' ========================================================================
    ' FUNGSI BANTUAN UNTUK MENUKAR ISI TABEL HISTORY TANPA ERROR
    ' ========================================================================
    Private Sub SwapDataGridViews(dgv1 As DataGridView, dgv2 As DataGridView)
        ' Simpan data dgv1 ke dalam daftar sementara (Memory)
        Dim tempList As New List(Of Object())
        For Each row As DataGridViewRow In dgv1.Rows
            If Not row.IsNewRow Then
                Dim cellValues(row.Cells.Count - 1) As Object
                For i As Integer = 0 To row.Cells.Count - 1
                    cellValues(i) = row.Cells(i).Value
                Next
                tempList.Add(cellValues)
            End If
        Next

        ' Pindahkan isi dgv2 ke dgv1
        dgv1.Rows.Clear()
        For Each row As DataGridViewRow In dgv2.Rows
            If Not row.IsNewRow Then
                Dim cellValues(row.Cells.Count - 1) As Object
                For i As Integer = 0 To row.Cells.Count - 1
                    cellValues(i) = row.Cells(i).Value
                Next
                dgv1.Rows.Add(cellValues)
            End If
        Next

        ' Pindahkan data dgv1 (yang ada di memori sementara) ke dgv2
        dgv2.Rows.Clear()
        For Each item In tempList
            dgv2.Rows.Add(item)
        Next
    End Sub

End Class