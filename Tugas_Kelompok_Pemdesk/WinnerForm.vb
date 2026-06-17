Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class WinnerForm
    Inherits Form

    Private lblTitle As Label
    Private lblName As Label
    Private lblTeam As Label

    ' ==========================================================
    ' DEKLARASI API WINDOWS (DRAG BORDERLESS FORM)
    ' ==========================================================
    <DllImport("user32.dll")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Sub SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As IntPtr)
    End Sub

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2
    ' ==========================================================

    ' Konstruktor menerima parameter: status tim (True = AKA, False = AO), Nama, dan Tim
    Public Sub New(isAka As Boolean, winnerName As String, winnerTeam As String)
        ' 1. Pengaturan Jendela Form (Borderless & Normal Size)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen

        ' ==========================================================
        ' SINKRONISASI UKURAN 100% IDENTIK DENGAN SCOREBOARD
        ' ==========================================================
        Dim frmSb As Form = Application.OpenForms("ScoreBoard")
        If frmSb IsNot Nothing Then
            Me.Size = frmSb.Size
        Else
            Me.Size = New Size(1366, 768)
        End If

        ' Setel warna latar belakang solid sesuai bendera tim pemenang
        If isAka Then
            Me.BackColor = Color.Crimson
        Else
            Me.BackColor = Color.DodgerBlue
        End If

        ' ==========================================================
        ' 2. MERAKIT KOMPONEN UI
        ' Layout: [WINNER] atas, [NAMA ATLET] tengah, [TIM] bawah
        ' ==========================================================

        ' A. Label Judul Atas: "WINNER"
        lblTitle = New Label()
        lblTitle.Text = "WINNER"
        lblTitle.Font = New Font("Segoe UI", 52.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.Dock = DockStyle.Top
        lblTitle.Height = CInt(Me.Height * 0.22) ' ~22% tinggi form

        ' B. Label Tengah: Nama Atlet (Fill sisa ruang di antara atas & bawah)
        lblName = New Label()
        lblName.Text = winnerName.ToUpper()
        lblName.Font = New Font("Segoe UI", 90.0F, FontStyle.Bold)
        lblName.ForeColor = Color.White
        lblName.TextAlign = ContentAlignment.MiddleCenter
        lblName.Dock = DockStyle.Fill

        ' C. Label Bawah: Nama Tim / Kontingen
        lblTeam = New Label()
        ' Jika winnerTeam kosong, sembunyikan area bawah agar nama tetap terlihat besar
        If String.IsNullOrWhiteSpace(winnerTeam) Then
            lblTeam.Text = ""
            lblTeam.Height = 0
        Else
            lblTeam.Text = winnerTeam.ToUpper()
            lblTeam.Height = CInt(Me.Height * 0.22) ' ~22% tinggi form
        End If
        lblTeam.Font = New Font("Segoe UI", 42.0F, FontStyle.Bold)
        lblTeam.ForeColor = Color.White
        lblTeam.TextAlign = ContentAlignment.MiddleCenter
        lblTeam.Dock = DockStyle.Bottom

        ' Urutan penambahan PENTING untuk DockStyle:
        ' Fill harus ditambahkan PERTAMA, lalu Top & Bottom
        Me.Controls.Add(lblName)   ' Fill - ditambah dulu
        Me.Controls.Add(lblTitle)  ' Top  - lalu ini
        Me.Controls.Add(lblTeam)   ' Bottom - terakhir

        ' 3. Fitur Fleksibilitas UX: Double-Click atau ESC/Spasi/Enter untuk menutup overlay
        Me.KeyPreview = True
        AddHandler Me.DoubleClick, AddressOf DismissForm
        AddHandler lblTitle.DoubleClick, AddressOf DismissForm
        AddHandler lblName.DoubleClick, AddressOf DismissForm
        AddHandler lblTeam.DoubleClick, AddressOf DismissForm
        AddHandler Me.KeyDown, AddressOf WinnerForm_KeyDown

        ' 4. Aktifkan fitur Drag (Geser Layar)
        EnableBorderlessDrag(Me)
    End Sub

    ' ==========================================================
    ' FUNGSI PINTAR: INJEKTOR FITUR GESER KE SEMUA ELEMEN
    ' ==========================================================
    Private Sub EnableBorderlessDrag(parentCtrl As Control)
        AddHandler parentCtrl.MouseDown, AddressOf DragForm_MouseDown
        For Each childCtrl As Control In parentCtrl.Controls
            EnableBorderlessDrag(childCtrl)
        Next
    End Sub

    Private Sub DragForm_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, IntPtr.Zero)
        End If
    End Sub

    ' Prosedur penutup form saat diklik Ganda (Double-Click)
    Private Sub DismissForm(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    ' Prosedur penutup form saat menekan tombol keyboard (ESC / Enter / Spasi)
    Private Sub WinnerForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Escape OrElse e.KeyCode = Keys.Space OrElse e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub
End Class