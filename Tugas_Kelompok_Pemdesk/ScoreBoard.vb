Imports System.Drawing
Imports System.Windows.Forms
' ==========================================================
' WAJIB DITAMBAHKAN UNTUK MEMANGGIL API WINDOWS
' ==========================================================
Imports System.Runtime.InteropServices

' WAJIB ADA KATA PARTIAL DI SINI
Partial Public Class ScoreBoard

    ' ==========================================================
    ' DEKLARASI API WINDOWS (PERBAIKAN ERROR ENTRY POINT)
    ' ==========================================================
    <DllImport("user32.dll")>
    Private Shared Sub ReleaseCapture()
    End Sub

    ' MENGHAPUS ExactSpelling:=True agar Windows bisa mencari SendMessageA/W secara otomatis
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Sub SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As IntPtr)
    End Sub

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2
    ' ==========================================================

    ' Ini array buat nampung penalti biar nggak error di KumiteMainControl
    Public AkaPenLabels As Label()
    Public AoPenLabels As Label()

    Private Sub ScoreBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hubungin label yang ada di designer ke array
        ' Pastikan nama LblAkaPen1 dsb sudah ada di layar desain
        AkaPenLabels = {LblAkaPen1, LblAkaPen2, LblAkaPen3, LblAkaPen4, LblAkaPen5}
        AoPenLabels = {LblAoPen1, LblAoPen2, LblAoPen3, LblAoPen4, LblAoPen5}

        ' --- TAMBAHAN BARU: Aktifkan fitur geser (Drag) ke Form dan seluruh isinya ---
        EnableBorderlessDrag(Me)
    End Sub

    ' ==========================================================
    ' FUNGSI PINTAR: INJEKTOR FITUR GESER KE SEMUA ELEMEN
    ' ==========================================================
    Private Sub EnableBorderlessDrag(parentCtrl As Control)
        ' 1. Tambahkan event MouseDown ke kontrol saat ini
        AddHandler parentCtrl.MouseDown, AddressOf DragForm_MouseDown

        ' 2. Cari semua kontrol di dalamnya (Label Skor, Panel Warna, Teks, dll) 
        ' dan beri kemampuan yang sama agar user bisa menggeser dari bagian mana saja.
        For Each childCtrl As Control In parentCtrl.Controls
            EnableBorderlessDrag(childCtrl)
        Next
    End Sub

    ' ==========================================================
    ' AKSI EKSEKUSI GESER (MENGELABUI WINDOWS)
    ' ==========================================================
    Private Sub DragForm_MouseDown(sender As Object, e As MouseEventArgs)
        ' Hanya bereaksi jika yang diklik adalah klik kiri mouse
        If e.Button = MouseButtons.Left Then
            ReleaseCapture() ' Lepaskan fokus klik bawaan .NET
            ' Perintahkan OS Windows seolah-olah kita sedang men-drag Title Bar standar
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, IntPtr.Zero)
        End If
    End Sub

    ' ==========================================================
    ' KODE ASLI BAWAAN ANDA (DIPERTAHANKAN 100%)
    ' ==========================================================
    Public Sub ApplyCustomFont(timerFontName As String, timerBold As Boolean, scoreFontName As String, scoreBold As Boolean)
        ' 1. Tentukan style font (Bold atau Regular)
        Dim timerStyle As FontStyle = If(timerBold, FontStyle.Bold, FontStyle.Regular)
        Dim scoreStyle As FontStyle = If(scoreBold, FontStyle.Bold, FontStyle.Regular)

        ' 2. Terapkan ke Timer (Ukuran 90 dan 48 disamakan dengan desainer aslimu)
        LblTimerMain.Font = New Font(timerFontName, 90.0F, timerStyle)
        LblTimerMilli.Font = New Font(timerFontName, 48.0F, timerStyle)

        ' 3. Terapkan ke Skor Raksasa (Ukuran 120)
        LblAkaScore.Font = New Font(scoreFontName, 120.0F, scoreStyle)
        LblAoScore.Font = New Font(scoreFontName, 120.0F, scoreStyle)
    End Sub

End Class