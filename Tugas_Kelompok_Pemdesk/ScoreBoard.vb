Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Collections.Generic

' WAJIB ADA KATA PARTIAL DI SINI
Partial Public Class ScoreBoard

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

    Public AkaPenLabels As Label()
    Public AoPenLabels As Label()

    ' ==========================================================
    ' VARIABEL MESIN SKALA OTOMATIS (AUTO-SCALING ENGINE)
    ' ==========================================================
    Private originalFormSize As Size
    Private ctrlBounds As New Dictionary(Of Control, Rectangle)
    Private ctrlFonts As New Dictionary(Of Control, Single)
    Private isScaling As Boolean = False

    Private Sub ScoreBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AkaPenLabels = {LblAkaPen1, LblAkaPen2, LblAkaPen3, LblAkaPen4, LblAkaPen5}
        AoPenLabels = {LblAoPen1, LblAoPen2, LblAoPen3, LblAoPen4, LblAoPen5}

        ' 1. Simpan ukuran kanvas asli bawaan Designer
        originalFormSize = Me.Size

        ' 2. Rekam posisi, ukuran, dan ukuran font asli seluruh elemen
        SaveOriginalLayout(Me)

        ' 3. Aktifkan fitur geser (Drag) ke Form dan seluruh isinya
        EnableBorderlessDrag(Me)

        ' 4. Aktifkan pembacaan keyboard (F11/ESC/Enter)
        Me.KeyPreview = True
    End Sub

    Private Sub SaveOriginalLayout(parent As Control)
        For Each ctrl As Control In parent.Controls
            ctrlBounds(ctrl) = ctrl.Bounds
            ctrlFonts(ctrl) = ctrl.Font.Size
            If ctrl.HasChildren Then SaveOriginalLayout(ctrl)
        Next
    End Sub

    Private Sub ScoreBoard_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If ctrlBounds.Count = 0 OrElse isScaling Then Return
        isScaling = True

        Dim ratioX As Single = CSng(Me.Width) / originalFormSize.Width
        Dim ratioY As Single = CSng(Me.Height) / originalFormSize.Height
        Dim ratioFont As Single = Math.Min(ratioX, ratioY)

        For Each ctrl As Control In ctrlBounds.Keys
            Dim origB As Rectangle = ctrlBounds(ctrl)
            ctrl.Bounds = New Rectangle(CInt(origB.X * ratioX), CInt(origB.Y * ratioY), CInt(origB.Width * ratioX), CInt(origB.Height * ratioY))
            ctrl.Font = New Font(ctrl.Font.FontFamily, ctrlFonts(ctrl) * ratioFont, ctrl.Font.Style)
        Next

        isScaling = False
    End Sub

    ' ==========================================================
    ' INJEKTOR FITUR GESER (KODE MURNI AMAN & BERHASIL)
    ' ==========================================================
    Private Sub EnableBorderlessDrag(parentCtrl As Control)
        ' Pasang deteksi seret mouse ke elemen saat ini
        AddHandler parentCtrl.MouseDown, AddressOf DragForm_MouseDown

        ' Looping rekursif untuk mendistribusikan fitur geser ke seluruh anak elemen
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

    ' ==========================================================
    ' SOLUSI TOTAL MUTLAK: INTERCEPT DOUBLE-CLICK LOW LEVEL
    ' ==========================================================
    Protected Overrides Sub WndProc(ByRef m As Message)
        ' &HA3 adalah kode sinyal Windows untuk Non-Client Left Button Double Click (WM_NCLBUTTONDBLCLK)
        ' Sinyal ini otomatis terkirim saat user klik 2x cepat di area yang sudah di-hijack SendMessage
        Const WM_NCLBUTTONDBLCLK As Integer = &HA3

        If m.Msg = WM_NCLBUTTONDBLCLK Then
            ' Eksekusi Fullscreen / Normal Size
            ToggleFullScreen(Nothing, Nothing)
            Exit Sub ' Hentikan pesan di sini agar tidak diabaikan oleh Windows Form
        End If

        MyBase.WndProc(m)
    End Sub

    ' ==========================================================
    ' EKSEKUTOR UKURAN LAYAR (FULLSCREEN CONTROLLER)
    ' ==========================================================
    Private Sub ToggleFullScreen(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ScoreBoard_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape OrElse e.KeyCode = Keys.F11 OrElse e.KeyCode = Keys.Enter Then
            ToggleFullScreen(Nothing, Nothing)
        End If
    End Sub

    ' ==========================================================
    ' KODE ASLI BAWAAN ANDA (DIPERTAHANKAN 100%)
    ' ==========================================================
    Public Sub ApplyCustomFont(timerFontName As String, timerBold As Boolean, scoreFontName As String, scoreBold As Boolean)
        Dim timerStyle As FontStyle = If(timerBold, FontStyle.Bold, FontStyle.Regular)
        Dim scoreStyle As FontStyle = If(scoreBold, FontStyle.Bold, FontStyle.Regular)

        ctrlFonts(LblTimerMain) = 90.0F
        ctrlFonts(LblTimerMilli) = 48.0F
        ctrlFonts(LblAkaScore) = 120.0F
        ctrlFonts(LblAoScore) = 120.0F

        LblTimerMain.Font = New Font(timerFontName, 90.0F, timerStyle)
        LblTimerMilli.Font = New Font(timerFontName, 48.0F, timerStyle)
        LblAkaScore.Font = New Font(scoreFontName, 120.0F, scoreStyle)
        LblAoScore.Font = New Font(scoreFontName, 120.0F, scoreStyle)

        ScoreBoard_SizeChanged(Nothing, Nothing)
    End Sub

End Class