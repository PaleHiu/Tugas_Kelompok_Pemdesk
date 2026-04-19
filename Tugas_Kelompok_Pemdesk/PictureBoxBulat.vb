Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class PictureBoxBulat
    Inherits PictureBox

    ' Fungsi ini memaksa PictureBox bawaan Windows menjadi bulat secara permanen
    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, Me.Width - 1, Me.Height - 1)
        Me.Region = New Region(path)

        MyBase.OnPaint(pe)

        ' Menggambar garis tepi melingkar (Border)
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim pen As New Pen(Color.DarkGray, 2)
        pe.Graphics.DrawEllipse(pen, 1, 1, Me.Width - 3, Me.Height - 3)
        pen.Dispose()
    End Sub

End Class