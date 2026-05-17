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
    Public NextAkaName As String = ""
    Public NextAkaTeam As String = ""
    Public NextAkaInfo As String = ""

    Public NextAoName As String = ""
    Public NextAoTeam As String = ""
    Public NextAoInfo As String = ""

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
    ' FUNGSI PENCARI GAMBAR DARI DATABASE
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
                            boxTeam.Image = LoadSafeImage(result.ToString())
                        End If
                    End Using
                Catch ex As Exception
                End Try
            End Using
        Catch ex As Exception
        End Try
    End Sub

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
    Public Shared frmLogActivityApp As FormLogActivity
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

        frmLogActivityApp = New FormLogActivity()
    End Sub

    Private Sub KumiteMainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttachGlobalLogger(Me)
        Me.KeyPreview = True
        ' Hubungkan event handler tombol-tombol (Kode lama Anda)
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

        DgvAoHistory.AllowUserToResizeColumns = False
        DgvAoHistory.AllowUserToResizeRows = False
        DgvAoHistory.ScrollBars = ScrollBars.Vertical ' <- Kembalikan ke Vertical

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
        ' Cukup tampilkan saja, karena sudah di-New saat aplikasi pertama kali jalan
        frmLogActivityApp.Show()
        frmLogActivityApp.BringToFront()
    End Sub

    Private Sub BtnShortcut_Click(sender As Object, e As EventArgs)
        If frmKeyboardShortcutApp Is Nothing OrElse frmKeyboardShortcutApp.IsDisposed Then
            frmKeyboardShortcutApp = New FormKeyboardShortcut()
        End If
        frmKeyboardShortcutApp.ShowDialog()
    End Sub

    Private Sub BtnHantei_Click(sender As Object, e As EventArgs)
        If frmHanteiApp Is Nothing OrElse frmHanteiApp.IsDisposed Then
            frmHanteiApp = New HanteiForm()
        End If
        frmHanteiApp.ShowDialog()
    End Sub

    ' ==========================================================
    ' EVENT HANDLER TOMBOL START SCOREBOARD
    ' ==========================================================
    Private Sub BtnStartScoreboard_Click(sender As Object, e As EventArgs)
        ' 1. Cek apakah layar Score Board sudah terbuka
        If frmScoreboard Is Nothing OrElse frmScoreboard.IsDisposed Then
            ' 2. Jika belum, buat instance baru dari desain ScoreBoard kita
            frmScoreboard = New ScoreBoard()

            ' 3. Tampilkan layar Score Board
            ' Kita menggunakan .Show() bukan .ShowDialog() agar Control Panel 
            ' tetap bisa diklik dan digunakan bersamaan dengan Score Board.
            frmScoreboard.Show()
        Else
            ' 4. Jika sudah terbuka tapi tertumpuk jendela lain, panggil ke depan
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
        AudioController.PlaySound("Get Penalties")
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
        AudioController.PlaySound("Get Penalties")
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
    ' FUNGSI LOGIKA MATCH TIMER (PERTANDINGAN UTAMA)
    ' ==========================================================

    ' Deklarasi Timer backend (Interval 1000 ms = 1 detik)
    Private WithEvents matchTimer As New Timer() With {.Interval = 1000}
    Private matchSecondsLeft As Integer = 120 ' Default 2 menit (120 detik)

    ' Fungsi pembantu untuk memperbarui tampilan teks waktu (M:SS.0)
    Private Sub UpdateMatchTimerDisplay()
        Dim mins As Integer = matchSecondsLeft \ 60
        Dim secs As Integer = matchSecondsLeft Mod 60

        ' Memperbarui label teks besar kuning
        LblMatchTimerValue.Text = String.Format("{0}:{1:00}.0", mins, secs)

        ' Opsional: Sinkronkan juga dengan NumericUpDown agar selaras
        NumMatchMin.Value = mins
        NumMatchSec.Value = secs
    End Sub

    ' 1. Logika Tombol Start/Pause Timer
    ' Logika Tombol Start/Pause Timer yang BENER
    Private Sub BtnStartTimer_Click(sender As Object, e As EventArgs) Handles BtnStartTimer.Click
        If matchTimer.Enabled Then
            ' Jika sedang jalan, maka Pause/Stop
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
        Else
            ' CEK PAKAI VARIABEL YANG ADA: matchSecondsLeft
            ' Jangan pakai GetTotalSeconds() karena fungsinya emang nggak lu buat
            If matchSecondsLeft <= 0 Then
                MessageBox.Show("Waktu sudah habis! Silakan reset atau setel waktu baru.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Mulai timer
            matchTimer.Start()
            BtnStartTimer.Text = "Stop Timer"
            BtnStartTimer.BackColor = Color.LightCoral
        End If
    End Sub

    ' 2. Logika Hitung Mundur (Berjalan otomatis setiap 1 detik)
    Private Sub matchTimer_Tick(sender As Object, e As EventArgs) Handles matchTimer.Tick
        If matchSecondsLeft > 0 Then
            matchSecondsLeft -= 1
            UpdateMatchTimerDisplay()
            SyncScoreboardTimer()
        Else
            ' Waktu habis (Yame)
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold

            ' --- PANGGIL SUARA END OF TIMER ---
            AudioController.PlaySound("End of Timer")

            MessageBox.Show("Waktu Pertandingan Habis (Yame)!", "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' 3. Logika Tombol Preset Waktu Cepat (1:30, 2:00, 3:00)
    Private Sub BtnTime130_Click(sender As Object, e As EventArgs) Handles BtnTime130.Click
        matchSecondsLeft = 90 ' 90 detik
        UpdateMatchTimerDisplay()
    End Sub

    Private Sub BtnTime200_Click(sender As Object, e As EventArgs) Handles BtnTime200.Click
        matchSecondsLeft = 120 ' 120 detik
        UpdateMatchTimerDisplay()
    End Sub

    Private Sub BtnTime300_Click(sender As Object, e As EventArgs) Handles BtnTime300.Click
        matchSecondsLeft = 180 ' 180 detik
        UpdateMatchTimerDisplay()
    End Sub

    ' 4. Logika Tombol Adjust Presisi (+ dan -) per 1 detik
    Private Sub BtnMatchTimePlus_Click(sender As Object, e As EventArgs) Handles BtnMatchTimePlus.Click
        matchSecondsLeft += 1
        UpdateMatchTimerDisplay()
    End Sub

    Private Sub BtnMatchTimeMinus_Click(sender As Object, e As EventArgs) Handles BtnMatchTimeMinus.Click
        If matchSecondsLeft > 0 Then
            matchSecondsLeft -= 1
            UpdateMatchTimerDisplay()
        End If
    End Sub

    ' 5. Logika Tombol Reset Timer
    Private Sub BtnResetTimer_Click(sender As Object, e As EventArgs) Handles BtnResetTimer.Click
        matchTimer.Stop()
        BtnStartTimer.Text = "Start Timer"
        BtnStartTimer.BackColor = Color.Gold

        ' Cerdas: Mengambil nilai dari kotak input angka (NumMatchMin & NumMatchSec)
        ' Jika kotak tersebut diatur ke 4 Menit 0 Detik, maka timer akan direset ke 4:00
        matchSecondsLeft = CInt(NumMatchMin.Value * 60) + CInt(NumMatchSec.Value)

        ' Fallback jika kotak input 0:00, kembalikan ke default 2 menit
        If matchSecondsLeft = 0 Then matchSecondsLeft = 120

        UpdateMatchTimerDisplay()
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

    ' Tombol Reset Score AKA (Merah)
    Private Sub BtnAkaResetScore_Click(sender As Object, e As EventArgs) Handles BtnAkaResetScore.Click
        ' Kosongkan tabel
        DgvAkaHistory.Rows.Clear()

        ' Panggil mesin penghitung agar angka raksasa dan Score Summary kembali ke 0
        RecalculateTotalScore(DgvAkaHistory, LblAkaMainScore)

        ' Matikan label WINNER secara paksa
        LblAkaWinner.Visible = False
    End Sub

    ' Tombol Reset Score AO (Biru)
    Private Sub BtnAoResetScore_Click(sender As Object, e As EventArgs) Handles BtnAoResetScore.Click
        ' Kosongkan tabel
        DgvAoHistory.Rows.Clear()

        ' Panggil mesin penghitung agar angka raksasa dan Score Summary kembali ke 0
        RecalculateTotalScore(DgvAoHistory, LblAoMainScore)

        ' Matikan label WINNER secara paksa
        LblAoWinner.Visible = False
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
                AudioController.PlaySound("Get Penalties")
            End If
        End If

        ' Logika Winner: Jika AKA Kiken/Shikkaku, maka AO Menang
        If BtnAkaKiken.BackColor = Color.Yellow OrElse BtnAkaShikkaku.BackColor = Color.Yellow Then
            LblAoWinner.Visible = True ' Munculkan label pemenang di AO

            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
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
                AudioController.PlaySound("Get Penalties")
            End If
        End If

        ' Logika Winner: Jika AO Kiken/Shikkaku, maka AKA Menang
        If BtnAoKiken.BackColor = Color.Yellow OrElse BtnAoShikkaku.BackColor = Color.Yellow Then
            LblAkaWinner.Visible = True ' Munculkan label pemenang di AKA

            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
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
    Private Function ShowKnockOutCountdown(isAka As Boolean, sourceButton As Button, winnerLabel As Label) As DialogResult
        ' 1. Buat Form Dasar
        Dim frmKO As New Form()
        frmKO.Size = New Size(600, 350)
        frmKO.StartPosition = FormStartPosition.CenterParent
        frmKO.FormBorderStyle = FormBorderStyle.FixedToolWindow
        frmKO.Text = If(isAka, "AKA Knocked Out Countdown", "AO Knocked Out Countdown")

        ' Tentukan warna berdasarkan sudut petarung
        Dim bgColor As Color = If(isAka, AkaColor, AoColor)

        ' 2. Buat Panel Atas (Latar Berwarna untuk Angka)
        Dim pnlTop As New Panel() With {.Dock = DockStyle.Fill, .BackColor = bgColor}

        ' 3. Buat Label Angka Raksasa
        Dim lblNumber As New Label() With {
            .AutoSize = False,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Segoe UI", 130, FontStyle.Bold),
            .ForeColor = Color.White,
            .Text = "10"
        }
        pnlTop.Controls.Add(lblNumber)

        ' 4. Buat Panel Bawah (Latar Putih untuk Teks)
        Dim pnlBottom As New Panel() With {.Dock = DockStyle.Bottom, .Height = 80, .BackColor = Color.White}

        ' 5. Buat Label Teks "Knocked Out Countdown"
        Dim lblText As New Label() With {
            .AutoSize = False,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Segoe UI", 32, FontStyle.Bold),
            .ForeColor = Color.Black,
            .Text = "Knocked Out Countdown"
        }
        pnlBottom.Controls.Add(lblText)

        frmKO.Controls.Add(pnlTop)
        frmKO.Controls.Add(pnlBottom)

        ' 6. Logika Timer
        Dim timeLeft As Integer = 10
        Dim koTimer As New Timer() With {.Interval = 1000}

        ' Simpan kondisi tombol agar bisa berubah selama countdown
        sourceButton.BackColor = bgColor
        sourceButton.ForeColor = Color.White

        AddHandler koTimer.Tick, Sub(senderObj, eArgs)
                                     timeLeft -= 1
                                     lblNumber.Text = timeLeft.ToString("00")
                                     sourceButton.Text = $"Stop Countdown ({timeLeft:00})"

                                     If timeLeft <= 0 Then
                                         koTimer.Stop()

                                         ' --- LOGIKA OTOMATIS SAAT 0 DETIK ---
                                         winnerLabel.Visible = True ' Tampilkan Winner di sisi lawan

                                         AudioController.PlaySound("Knocked Out")
                                         ' Hentikan timer pertandingan utama (Yame)
                                         matchTimer.Stop()
                                         BtnStartTimer.Text = "Start Timer"
                                         BtnStartTimer.BackColor = Color.Gold

                                         frmKO.DialogResult = DialogResult.OK
                                         frmKO.Close()
                                     End If
                                 End Sub

        ' Event saat popup ditutup (baik selesai timer atau klik X)
        AddHandler frmKO.FormClosing, Sub(senderObj, eArgs)
                                          koTimer.Stop()
                                          ' Kembalikan tombol ke wujud asli agar bisa digunakan lagi
                                          sourceButton.Text = "Knocked Out"
                                          sourceButton.BackColor = SystemColors.Control
                                          sourceButton.ForeColor = Color.Black
                                      End Sub

        koTimer.Start()
        Return frmKO.ShowDialog()
    End Function

    ' ==========================================================
    ' EVENT HANDLER TOMBOL KNOCKED OUT AKA & AO (VERSI PRO)
    ' ==========================================================

    ' Tombol Knocked Out AKA (Merah)
    Private Sub BtnAkaKnockedOut_Click(sender As Object, e As EventArgs) Handles BtnAkaKnockedOut.Click
        ' --- 1. LOGIKA UNDO (BATALKAN K.O) ---
        If BtnAkaKnockedOut.BackColor = AkaColor Then
            BtnAkaKnockedOut.BackColor = SystemColors.Control
            BtnAkaKnockedOut.ForeColor = Color.Black
            LblAoWinner.Visible = False

            ' Jika ternyata AO sedang K.O, berarti AKA yang harusnya kembali menang
            If BtnAoKnockedOut.BackColor = AoColor Then
                LblAkaWinner.Visible = True
            End If

            ' Hitung ulang skor barangkali AO menang karena poin
            RecalculateTotalScore(DgvAoHistory, LblAoMainScore)
            Return
        End If

        ' --- 2. LOGIKA K.O AKTIF ---
        If UseKnockoutCountdown Then
            ' MODE 1: Hitung Mundur 10 Detik
            If ShowKnockOutCountdown(True, BtnAkaKnockedOut, LblAoWinner) = DialogResult.OK Then
                ' Cegah Double Winner jika kedua pihak K.O
                If BtnAoKnockedOut.BackColor = AoColor Then
                    LblAoWinner.Visible = False
                    LblAkaWinner.Visible = False
                End If
            End If
        Else
            ' MODE 2: Instan K.O (Tanpa Pop-up)
            BtnAkaKnockedOut.BackColor = AkaColor
            BtnAkaKnockedOut.ForeColor = AkaTextColor

            ' Tentukan Pemenang (Cegah Double Winner)
            If BtnAoKnockedOut.BackColor = AoColor Then
                LblAoWinner.Visible = False
                LblAkaWinner.Visible = False
            Else
                LblAoWinner.Visible = True
            End If

            AudioController.PlaySound("Knocked Out")
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
        End If
    End Sub

    ' Tombol Knocked Out AO (Biru)
    Private Sub BtnAoKnockedOut_Click(sender As Object, e As EventArgs) Handles BtnAoKnockedOut.Click
        ' --- 1. LOGIKA UNDO (BATALKAN K.O) ---
        If BtnAoKnockedOut.BackColor = AoColor Then
            BtnAoKnockedOut.BackColor = SystemColors.Control
            BtnAoKnockedOut.ForeColor = Color.Black
            LblAkaWinner.Visible = False

            ' Jika ternyata AKA sedang K.O, berarti AO yang harusnya kembali menang
            If BtnAkaKnockedOut.BackColor = AkaColor Then
                LblAoWinner.Visible = True
            End If

            ' Hitung ulang skor barangkali AKA menang karena poin
            RecalculateTotalScore(DgvAkaHistory, LblAkaMainScore)
            Return
        End If

        ' --- 2. LOGIKA K.O AKTIF ---
        If UseKnockoutCountdown Then
            ' MODE 1: Hitung Mundur 10 Detik
            If ShowKnockOutCountdown(False, BtnAoKnockedOut, LblAkaWinner) = DialogResult.OK Then
                ' Cegah Double Winner jika kedua pihak K.O
                If BtnAkaKnockedOut.BackColor = AkaColor Then
                    LblAkaWinner.Visible = False
                    LblAoWinner.Visible = False
                End If
            End If
        Else
            ' MODE 2: Instan K.O (Tanpa Pop-up)
            BtnAoKnockedOut.BackColor = AoColor
            BtnAoKnockedOut.ForeColor = AoTextColor

            ' Tentukan Pemenang (Cegah Double Winner)
            If BtnAkaKnockedOut.BackColor = AkaColor Then
                LblAkaWinner.Visible = False
                LblAoWinner.Visible = False
            Else
                LblAkaWinner.Visible = True
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

    ' Fungsi 2: Aksi yang dijalankan ketika tombol APAPUN ditekan
    Private Sub GlobalLogger_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)

        ' Ambil teks dari tombol yang diklik. 
        ' Bersihkan teks jika ada enter/baris baru (seperti pada tombol "Approve Knocked Out")
        Dim actionText As String = btn.Text.Replace(vbCrLf, " ").Replace(vbLf, " ")

        ' Abaikan jika tombol tidak memiliki teks (misal tombol icon kaca pembesar/profil)
        If String.IsNullOrWhiteSpace(actionText) Then Return

        ' Deteksi Cerdas: Apakah ini tombol AKA, AO, atau Sistem Umum?
        Dim logDetail As String = ""
        Dim logType As String = "SYSTEM"

        ' Kita menebak konteks berdasarkan nama tombol (Name) di Designer
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

        ' Kirim datanya ke FormLogActivity!
        If frmLogActivityApp IsNot Nothing AndAlso Not frmLogActivityApp.IsDisposed Then
            frmLogActivityApp.InsertLog(logDetail, logType, currentTime)
        End If
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
    ''' Sinkronisasi Nama, Kontingen, dan Nomor Tatami.
    ''' </summary>
    Public Sub SyncScoreboardProfile()
        If frmScoreboard IsNot Nothing AndAlso Not frmScoreboard.IsDisposed Then
            ' Mengupdate Label Nama dan Info (Team + Info)
            frmScoreboard.LblAkaName.Text = TxtAkaNameMain.Text
            frmScoreboard.LblAkaInfo.Text = TxtAkaTeam.Text & " (" & TxtAkaTeamInfo.Text & ")"

            frmScoreboard.LblAoName.Text = TxtAoNameMain.Text
            frmScoreboard.LblAoInfo.Text = TxtAoTeam.Text & " (" & TxtAoTeamInfo.Text & ")"

            ' Mengupdate Nomor Tatami
            frmScoreboard.LblTatamiNum.Text = NumTatami.Value.ToString()
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
End Class