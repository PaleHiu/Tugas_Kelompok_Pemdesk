Imports System.Media
Imports System.IO
Imports System.Collections.Generic
' --- TAMBAHAN BARU: Untuk bisa membaca Application.StartupPath ---
Imports System.Windows.Forms

Module AudioController
    ' Menyimpan lokasi file suara dengan format: Kunci (Nama Alert) -> Nilai (Lokasi File)
    ' KODE ASLI DIPERTAHANKAN
    Public SoundPaths As New Dictionary(Of String, String)()

    ' ==========================================================
    ' TAMBAHAN BARU: Konstruktor Otomatis (Default / Bawaan Pabrik)
    ' Karena ini Module, Sub New() akan otomatis berjalan satu kali 
    ' di latar belakang saat aplikasi pertama kali dibuka.
    ' ==========================================================
    Sub New()
        ' Tentukan folder default. Pastikan Anda membuat folder bernama "Sounds"
        ' di dalam folder bin\Debug\ tempat aplikasi berjalan.
        Dim defaultFolder As String = Application.StartupPath & "\Sounds\"

        ' Isi nilai bawaan statis
        SoundPaths.Add("End of Timer", defaultFolder & "end_timer.wav")
        SoundPaths.Add("15 Second", defaultFolder & "15_second.wav")
        SoundPaths.Add("Winner by Point", defaultFolder & "winner.wav")
        SoundPaths.Add("Get Point", defaultFolder & "point.wav")
        SoundPaths.Add("Get Penalties", defaultFolder & "penalty.wav")
        SoundPaths.Add("Hantei", defaultFolder & "hantei.wav")
        SoundPaths.Add("Knocked Out", defaultFolder & "knockout.wav")
        SoundPaths.Add("VAR Alert", defaultFolder & "var.wav")
        SoundPaths.Add("Manual Alert", defaultFolder & "manual.wav")
    End Sub

    ' ==========================================================
    ' KODE ASLI BAWAAN ANDA (TIDAK ADA YANG DIKURANGI/DIUBAH)
    ' ==========================================================
    ' Fungsi Pintar untuk memutar suara
    Public Sub PlaySound(alertName As String)
        ' Cek apakah nama alert ada di kamus dan path-nya tidak kosong
        If SoundPaths.ContainsKey(alertName) AndAlso Not String.IsNullOrWhiteSpace(SoundPaths(alertName)) Then
            Dim path As String = SoundPaths(alertName)
            If File.Exists(path) Then
                Try
                    Dim player As New SoundPlayer(path)
                    player.Play()
                Catch ex As Exception
                    ' Abaikan jika file korup/format salah
                End Try
            End If
        End If
    End Sub
End Module