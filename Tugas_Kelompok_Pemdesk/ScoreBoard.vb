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

End Class