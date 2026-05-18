Imports System.Drawing
Imports System.Windows.Forms
' ==========================================================
' WAJIB DITAMBAHKAN UNTUK MEMANGGIL API WINDOWS
' ==========================================================
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
        Me.WindowState = FormWindowState.Normal ' Berubah dari Maximized ke Normal
        Me.StartPosition = FormStartPosition.CenterScreen

        ' ==========================================================
        ' SINKRONISASI UKURAN 100% IDENTIK DENGAN SCOREBOARD
        ' ==========================================================
        Dim frmSb As Form = Application.OpenForms("ScoreBoard")
        If frmSb IsNot Nothing Then
            Me.Size = frmSb.Size ' Meniru ukuran presisi dari ScoreBoard yang sedang menyala
        Else
            Me.Size = New Size(1366, 768) ' Ukuran cadangan jika Scoreboard belum dibuka
        End If

        ' Setel warna latar belakang solid sesuai bendera tim pemenang
        If isAka Then
            Me.BackColor = Color.Crimson ' Merah Tegas AKA
        Else
            Me.BackColor = Color.DodgerBlue ' Biru Tegas AO
        End If

        ' 2. Merakit Komponen UI
        ' A. Label Judul Atas: "WINNER"
        lblTitle = New Label()
        lblTitle.Text = "WINNER"
        lblTitle.Font = New Font("Segoe UI", 60.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.Dock = DockStyle.Top
        lblTitle.Height = 200

        ' B. Label Tengah: Nama Atlet
        lblName = New Label()
        lblName.Text = winnerName.ToUpper()
        lblName.Font = New Font("Segoe UI", 85.0F, FontStyle.Bold)
        lblName.ForeColor = Color.White
        lblName.TextAlign = ContentAlignment.MiddleCenter
        lblName.Dock = DockStyle.Fill

        ' C. Label Bawah: Informasi Kontingen / Tim
        lblTeam = New Label()
        lblTeam.Text = winnerTeam.ToUpper()
        lblTeam.Font = New Font("Segoe UI", 40.0F, FontStyle.Bold)
        lblTeam.ForeColor = Color.White
        lblTeam.TextAlign = ContentAlignment.MiddleCenter
        lblTeam.Dock = DockStyle.Bottom
        lblTeam.Height = 200

        ' Masukkan semua komponen ke dalam layar utama Form
        Me.Controls.Add(lblName)
        Me.Controls.Add(lblTitle)
        Me.Controls.Add(lblTeam)

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