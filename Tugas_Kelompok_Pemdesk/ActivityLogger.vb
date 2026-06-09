Public Module ActivityLogger
    ' Variabel global penampung Form Log (Satu untuk semua)
    Public SharedLogForm As FormLogActivity

    ' Fungsi untuk memastikan form log selalu tersedia dan hanya ada 1 di memori
    Public Sub InitializeLogger()
        If SharedLogForm Is Nothing OrElse SharedLogForm.IsDisposed Then
            SharedLogForm = New FormLogActivity()
        End If
    End Sub

    ' ==========================================================
    ' CCTV KHUSUS KATA
    ' ==========================================================
    Public Sub LogKataAction(activityDetail As String, activityType As String, matchTime As String)
        InitializeLogger()
        ' Memanggil fungsi InsertLog versi 4 Parameter
        SharedLogForm.InsertLog("KATA ScoreBoard", activityDetail, activityType, matchTime)
    End Sub

    ' ==========================================================
    ' CCTV KHUSUS KUMITE
    ' ==========================================================
    Public Sub LogKumiteAction(activityDetail As String, activityType As String, matchTime As String)
        InitializeLogger()
        ' Memanggil fungsi InsertLog versi 3 Parameter (kode lama Kumite Anda)
        SharedLogForm.InsertLog(activityDetail, activityType, matchTime)
    End Sub

End Module