Imports System.Drawing
Imports System.Windows.Forms

Partial Public Class KumiteMainControl

    ' ==========================================================
    ' DEKLARASI GLOBAL FORM (STATE MANAGER)
    ' ==========================================================
    Public Shared frmScoreboardSettingApp As New FrmScoreboardSetting()
    Public Shared frmLogActivityApp As New FormLogActivity()
    Public Shared frmKeyboardShortcutApp As New FormKeyboardShortcut()
    Public Shared frmHanteiApp As New HanteiForm()

    ' ==========================================================
    ' KONSTRUKTOR FORM UTAMA
    ' ==========================================================
    Public Sub New()
        ' Setup Dasar Jendela Utama
        Me.Text = "Kumite Main Control"
        Me.Size = New Size(1024, 730)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = COLOR_BG_WINDOW ' Mengambil warna dari Designer
        Me.Font = FONT_DEFAULT
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        ' Panggil fungsi penyusun tata letak dari Designer
        InitializeComponentManual()
    End Sub

    Private Sub KumiteMainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tempatkan logika yang berjalan saat aplikasi pertama kali terbuka di sini
    End Sub

    ' ==========================================================
    ' EVENT HANDLER NAVIGASI & FOOTER
    ' ==========================================================
    Private Sub btnSettings_Click(sender As Object, e As EventArgs)
        If frmScoreboardSettingApp Is Nothing OrElse frmScoreboardSettingApp.IsDisposed Then
            frmScoreboardSettingApp = New FrmScoreboardSetting()
        End If
        frmScoreboardSettingApp.ShowDialog()
    End Sub

    Private Sub btnLogActivity_Click(sender As Object, e As EventArgs)
        If frmLogActivityApp Is Nothing OrElse frmLogActivityApp.IsDisposed Then
            frmLogActivityApp = New FormLogActivity()
        End If
        frmLogActivityApp.ShowDialog()
    End Sub

    Private Sub btnShortcut_Click(sender As Object, e As EventArgs)
        If frmKeyboardShortcutApp Is Nothing OrElse frmKeyboardShortcutApp.IsDisposed Then
            frmKeyboardShortcutApp = New FormKeyboardShortcut()
        End If
        frmKeyboardShortcutApp.ShowDialog()
    End Sub

    Private Sub btnHantei_Click(sender As Object, e As EventArgs)
        If frmHanteiApp Is Nothing OrElse frmHanteiApp.IsDisposed Then
            frmHanteiApp = New HanteiForm()
        End If
        frmHanteiApp.ShowDialog()
    End Sub

    Private Sub btnStartScoreboard_Click(sender As Object, e As EventArgs)
        Dim scBoard As New ScoreboardForm()
        scBoard.Show()
    End Sub

    ' ==========================================================
    ' EVENT HANDLER & LOGIKA TIMER
    ' ==========================================================
    Protected Sub btnStartWaitTimer_Click(sender As Object, e As EventArgs)
        If waitTimer.Enabled Then
            waitTimer.Stop()
            btnStartWaitTimer.Text = "Start"
            btnStartWaitTimer.BackColor = COLOR_GOLD
        Else
            If numWaitMin.Value = 0 AndAlso numWaitSec.Value = 0 Then
                MessageBox.Show("Silakan atur waktu timer terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            waitTimer.Start()
            btnStartWaitTimer.Text = "Stop"
            btnStartWaitTimer.BackColor = Color.LightCoral
        End If
    End Sub

    Private Sub waitTimer_Tick(sender As Object, e As EventArgs) Handles waitTimer.Tick
        Dim mins As Integer = CInt(numWaitMin.Value)
        Dim secs As Integer = CInt(numWaitSec.Value)

        If secs > 0 Then
            secs -= 1
        ElseIf mins > 0 Then
            mins -= 1
            secs = 59
        Else
            waitTimer.Stop()
            btnStartWaitTimer.Text = "Start"
            btnStartWaitTimer.BackColor = COLOR_GOLD
            MessageBox.Show("Waktu tunggu (Waiting Timer) telah habis!", "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        numWaitMin.Value = mins
        numWaitSec.Value = secs
    End Sub

End Class