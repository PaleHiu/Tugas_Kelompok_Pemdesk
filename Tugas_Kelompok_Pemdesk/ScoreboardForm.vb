Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class ScoreboardForm
    Inherits Form

    Private akaScore As Integer = 0
    Private aoScore As Integer = 0
    Private tatami As Integer = 1
    Private timeSeconds As Double = 5.0
    Private timerRunning As Boolean = False
    Private WithEvents countdownTimer As Timer

    Public Sub New()
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.KeyPreview = True

        ' Memanggil HanteiForm saat Load
        AddHandler Me.Load, Sub(s, e)
                                Dim h As New HanteiForm()
                                h.Owner = Me
                                h.ShowDialog()
                            End Sub

        ' Inisialisasi Timer
        countdownTimer = New Timer With {.Interval = 100}
        countdownTimer.Start()
    End Sub

    ' Event Timer Tick
    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        If timerRunning AndAlso timeSeconds > 0 Then
            timeSeconds -= 0.1
            Me.Invalidate() ' Gambar ulang layar
        End If
    End Sub

    ' Kontrol Keyboard
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        If e.KeyCode = Keys.Space Then timerRunning = Not timerRunning
        If e.KeyCode = Keys.Escape Then Me.Close()
        Me.Invalidate()
        MyBase.OnKeyDown(e)
    End Sub

    ' LOGIKA MENGGAMBAR UI (ONPAINT)
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        Dim W As Integer = Me.ClientSize.Width
        Dim H As Integer = Me.ClientSize.Height

        ' Background Gradient
        Dim rectAka As New Rectangle(0, 0, W \ 2, H)
        Using bAka As New LinearGradientBrush(rectAka, Color.FromArgb(90, 5, 10), Color.Black, 0.0F)
            g.FillRectangle(bAka, rectAka)
        End Using

        Dim rectAo As New Rectangle(W \ 2, 0, W \ 2, H)
        Using bAo As New LinearGradientBrush(rectAo, Color.Black, Color.FromArgb(5, 30, 70), 0.0F)
            g.FillRectangle(bAo, rectAo)
        End Using

        ' Gambar Skor Box
        DrawScoreBox(g, (W * 0.25) - 165, (H * 0.42), akaScore.ToString(), Color.FromArgb(215, 20, 40))
        DrawScoreBox(g, (W * 0.75) - 165, (H * 0.42), aoScore.ToString(), Color.FromArgb(25, 105, 215))

        ' Timer Text
        ' Baris 75: Format Menit dan Detik (D2 diganti menjadi :00)
        Dim tM As String = $"{Int(timeSeconds / 60)}:{Int(timeSeconds Mod 60):00}"

        ' Baris 76: Format Mili Detik
        Dim tS As String = $".{Int((timeSeconds * 10) Mod 10)}"
        g.DrawString(tM, New Font("Arial", 155, FontStyle.Bold), Brushes.White, New PointF((W / 2) - 250, H - 200))

        ' Gambar Tatami & Match Description
        g.DrawString("TATAMI", New Font("Arial", 26, FontStyle.Bold), Brushes.Yellow, 45, H - 160)
        g.DrawString(tatami.ToString(), New Font("Arial", 100, FontStyle.Bold), Brushes.White, 65, H - 120)
        g.DrawString("Match Description...", New Font("Arial", 24, FontStyle.Bold), Brushes.Yellow, W - 420, H - 110)
    End Sub

    ' Helper Fungsi Menggambar
    Private Sub DrawScoreBox(g As Graphics, x As Integer, y As Integer, score As String, c As Color)
        Dim r As New Rectangle(x, y, 330, 230)
        Dim p As New GraphicsPath()
        Dim rad As Integer = 110
        p.AddArc(r.X, r.Y, rad, rad, 180, 90)
        p.AddArc(r.Right - rad, r.Y, rad, rad, 270, 90)
        p.AddArc(r.Right - rad, r.Bottom - rad, rad, rad, 0, 90)
        p.AddArc(r.X, r.Bottom - rad, rad, rad, 90, 90)
        p.CloseFigure()

        Using br As New LinearGradientBrush(r, c, Color.Black, 90.0F)
            g.FillPath(br, p)
        End Using
        DrawCenteredString(g, score, New Font("Arial", 150, FontStyle.Bold), Brushes.White, x + 165, y + 115)
    End Sub

    Private Sub DrawCenteredString(g As Graphics, s As String, f As Font, b As Brush, x As Single, y As Single)
        Dim sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        g.DrawString(s, f, b, x, y, sf)
    End Sub
End Class