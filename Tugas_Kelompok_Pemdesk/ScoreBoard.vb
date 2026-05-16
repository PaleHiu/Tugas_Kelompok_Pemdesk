' WAJIB ADA KATA PARTIAL DI SINI
Partial Public Class ScoreBoard

    ' Ini array buat nampung penalti biar nggak error di KumiteMainControl
    Public AkaPenLabels As Label()
    Public AoPenLabels As Label()

    Private Sub ScoreBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hubungin label yang ada di designer ke array
        ' Pastikan nama LblAkaPen1 dsb sudah ada di layar desain
        AkaPenLabels = {LblAkaPen1, LblAkaPen2, LblAkaPen3, LblAkaPen4, LblAkaPen5}
        AoPenLabels = {LblAoPen1, LblAoPen2, LblAoPen3, LblAoPen4, LblAoPen5}
    End Sub
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