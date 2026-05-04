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
        ' Hubungkan event handler tombol-tombol ke sub yang sesuai
        AddHandler BtnSettings.Click, AddressOf BtnSettings_Click
        AddHandler BtnLogActivity.Click, AddressOf BtnLogActivity_Click
        AddHandler BtnShortcut.Click, AddressOf BtnShortcut_Click
        AddHandler BtnHantei.Click, AddressOf BtnHantei_Click
        AddHandler BtnStartScoreboard.Click, AddressOf BtnStartScoreboard_Click
        AddHandler BtnStartWait.Click, AddressOf BtnStartWait_Click
        AddHandler ResetTimer.Click, AddressOf ResetTimer_Click
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

End Class