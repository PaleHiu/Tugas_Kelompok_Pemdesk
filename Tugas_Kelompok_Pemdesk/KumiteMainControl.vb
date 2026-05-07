Imports System.Drawing
Imports System.Windows.Forms

Partial Public Class KumiteMainControl

    ' ==========================================================
    ' DEKLARASI GLOBAL FORM (STATE MANAGER)
    ' ==========================================================
    Public Shared frmScoreboardSettingApp As FrmScoreboardSetting
    Public Shared frmLogActivityApp As FormLogActivity
    Public Shared frmKeyboardShortcutApp As FormKeyboardShortcut
    Public Shared frmHanteiApp As HanteiForm

    ' Timer untuk Waiting Timer (dibuat manual karena tidak ada di Designer baru)
    Private WithEvents waitTimer As New Timer() With {.Interval = 1000}

    ' ==========================================================
    ' KONSTRUKTOR FORM UTAMA
    ' ==========================================================
    Public Sub New()
        ' Wajib dipanggil pertama - menginisialisasi semua komponen dari Designer
        InitializeComponent()

        ' Setup tambahan setelah komponen siap
        Me.Text = "Kumite Main Control"
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    ' ==========================================================
    ' EVENT LOAD FORM
    ' ==========================================================
    Private Sub KumiteMainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hubungkan event handler tombol-tombol (Kode lama Anda)
        AddHandler BtnSettings.Click, AddressOf BtnSettings_Click
        AddHandler BtnLogActivity.Click, AddressOf BtnLogActivity_Click
        AddHandler BtnShortcut.Click, AddressOf BtnShortcut_Click
        AddHandler BtnHantei.Click, AddressOf BtnHantei_Click
        AddHandler BtnStartScoreboard.Click, AddressOf BtnStartScoreboard_Click
        AddHandler BtnStartWait.Click, AddressOf BtnStartWait_Click
        AddHandler ResetTimer.Click, AddressOf ResetTimer_Click

        ' =======================================================
        ' PENGUNCIAN UKURAN, PERATAAN TEKS, & SCROLLBAR TABEL
        ' =======================================================

        ' 1. Matikan fitur resize manual & AKTIFKAN SCROLLBAR VERTIKAL SAJA
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

    Private Sub BtnLogActivity_Click(sender As Object, e As EventArgs)
        If frmLogActivityApp Is Nothing OrElse frmLogActivityApp.IsDisposed Then
            frmLogActivityApp = New FormLogActivity()
        End If
        frmLogActivityApp.ShowDialog()
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

    Private Sub BtnStartScoreboard_Click(sender As Object, e As EventArgs)
        Dim scBoard As New ScoreboardForm()
        scBoard.Show()
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

    ' ==========================================================
    ' FUNGSI LOGIKA TOMBOL PENALTI (P) SEKUENSIAL (BERURUTAN)
    ' ==========================================================

    ' Fungsi Penalti AKA (Merah)
    Private Sub BtnPenaltyAka_Click(sender As Object, e As EventArgs) Handles BtnAka1C.Click, BtnAka2C.Click, BtnAka3C.Click, BtnAkaHC.Click, BtnAkaH.Click
        Dim clickedBtn As Button = CType(sender, Button)

        ' 1. Daftarkan tombol ke dalam Array sesuai urutan yang benar
        Dim arrBtns() As Button = {BtnAka1C, BtnAka2C, BtnAka3C, BtnAkaHC, BtnAkaH}

        ' 2. Cari indeks tombol yang baru saja diklik (0 sampai 4)
        Dim clickedIndex As Integer = Array.IndexOf(arrBtns, clickedBtn)

        ' 3. Cari batas tertinggi tombol yang saat ini sedang aktif (berwarna merah)
        Dim currentMaxIndex As Integer = -1
        For i As Integer = 4 To 0 Step -1
            If arrBtns(i).BackColor = Color.Crimson Then
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

        ' 5. Terapkan warna ke semua tombol berdasarkan batas yang baru
        For i As Integer = 0 To 4
            If i <= newMaxIndex Then
                ' Nyalakan tombol (Urutan di bawah/sama dengan batas)
                arrBtns(i).BackColor = Color.Crimson
                arrBtns(i).ForeColor = Color.White
            Else
                ' Matikan tombol (Urutan di atas batas)
                arrBtns(i).BackColor = SystemColors.Control
                arrBtns(i).ForeColor = Color.Black
            End If
        Next

        ' 6. KONDISI WINNER: Jika H menyala, AO menang (HANYA JIKA AKA belum dideklarasikan menang)
        If newMaxIndex = 4 Then
            If LblAkaWinner.Visible = False Then
                LblAoWinner.Visible = True
            End If
        Else
            ' Jika batal 'H', sembunyikan label pemenang AO
            LblAoWinner.Visible = False

            ' SMART UNDO: Jika ternyata AO posisinya sedang 'H' (sempat tertahan), nyalakan kemenangan AKA sekarang
            If BtnAoH.BackColor = Color.DodgerBlue Then
                LblAkaWinner.Visible = True
            End If
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
            If arrBtns(i).BackColor = Color.DodgerBlue Then
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
                arrBtns(i).BackColor = Color.DodgerBlue
                arrBtns(i).ForeColor = Color.White
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
            If BtnAkaH.BackColor = Color.Crimson Then
                LblAoWinner.Visible = True
            End If
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
    Private Sub BtnStartTimer_Click(sender As Object, e As EventArgs) Handles BtnStartTimer.Click
        If matchTimer.Enabled Then
            ' Jika sedang jalan, maka Pause/Stop
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
        Else
            ' Validasi jika waktu sudah 00:00
            If matchSecondsLeft <= 0 Then
                MessageBox.Show("Waktu sudah habis! Silakan reset atau setel waktu baru.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Mulai timer
            matchTimer.Start()
            BtnStartTimer.Text = "Stop Timer"
            BtnStartTimer.BackColor = Color.LightCoral ' Berubah merah saat jalan
        End If
    End Sub

    ' 2. Logika Hitung Mundur (Berjalan otomatis setiap 1 detik)
    Private Sub matchTimer_Tick(sender As Object, e As EventArgs) Handles matchTimer.Tick
        If matchSecondsLeft > 0 Then
            matchSecondsLeft -= 1
            UpdateMatchTimerDisplay()
        Else
            ' Waktu habis (Yame)
            matchTimer.Stop()
            BtnStartTimer.Text = "Start Timer"
            BtnStartTimer.BackColor = Color.Gold
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

        ' 4. Kalkulasi ulang seluruh skor di tabel agar selalu akurat
        RecalculateTotalScore(dgv, lblScore)
    End Sub

    ' ==========================================================
    ' FUNGSI RESET SKOR (AKA & AO)
    ' ==========================================================

    ' Tombol Reset Score AKA (Merah)
    Private Sub BtnAkaResetScore_Click(sender As Object, e As EventArgs) Handles BtnAkaResetScore.Click
        ' Kosongkan tabel dan kembalikan angka ke 0
        DgvAkaHistory.Rows.Clear()
        LblAkaMainScore.Text = "0"

        ' Matikan label WINNER secara paksa
        LblAkaWinner.Visible = False
    End Sub

    ' Tombol Reset Score AO (Biru)
    Private Sub BtnAoResetScore_Click(sender As Object, e As EventArgs) Handles BtnAoResetScore.Click
        ' Kosongkan tabel dan kembalikan angka ke 0
        DgvAoHistory.Rows.Clear()
        LblAoMainScore.Text = "0"

        ' Matikan label WINNER secara paksa
        LblAoWinner.Visible = False
    End Sub


    ' ==========================================================
    ' FUNGSI POPUP "CHANGE" & KALKULASI ULANG SKOR
    ' ==========================================================

    ' Helper: Menghitung ulang seluruh poin yang ada di tabel
    ' ==========================================================
    ' FUNGSI KALKULASI ULANG SKOR & PENENTUAN PEMENANG (WIN. POINT)
    ' ==========================================================
    Private Sub RecalculateTotalScore(dgv As DataGridView, lblScore As Label)
        ' 1. Hitung ulang total poin dari tabel
        Dim total As Integer = 0
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow AndAlso row.Cells.Count > 2 AndAlso row.Cells(2).Value IsNot Nothing Then
                Dim typeStr As String = row.Cells(2).Value.ToString()
                If typeStr.Contains("(3)") Then total += 3
                If typeStr.Contains("(2)") Then total += 2
                If typeStr.Contains("(1)") Then total += 1
            End If
        Next

        ' 2. Tampilkan skor terbaru ke angka raksasa
        lblScore.Text = total.ToString()

        ' =======================================================
        ' 3. LOGIKA WIN. POINT (CEK PEMENANG)
        ' =======================================================
        ' Ambil nilai batas kemenangan secara real-time dari kontrol UI (bisa di-adjust kapan saja)
        Dim batasMenang As Integer = CInt(NumWinPoint.Value)

        ' Jika skor mencapai atau melebihi batas kemenangan
        If total >= batasMenang AndAlso batasMenang > 0 Then

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
            ' 4. LOGIKA PEMBATALAN (SMART UNDO)
            ' =======================================================
            ' Jika wasit meralat skor (lewat tombol Change) sehingga poin turun di bawah Win Point.
            ' Kita harus menyembunyikan label WINNER, TAPI pastikan dulu dia tidak menang karena lawan kena diskualifikasi (H).

            If lblScore.Name = "LblAkaMainScore" AndAlso BtnAoH.BackColor <> Color.DodgerBlue Then
                LblAkaWinner.Visible = False ' Sembunyikan jika batal menang dan lawan tidak kena H
            ElseIf lblScore.Name = "LblAoMainScore" AndAlso BtnAkaH.BackColor <> Color.Crimson Then
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

    Private Sub BtnAoKiken_Click(sender As Object, e As EventArgs) Handles BtnAoKiken.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAkaKiken.Click

    End Sub
End Class