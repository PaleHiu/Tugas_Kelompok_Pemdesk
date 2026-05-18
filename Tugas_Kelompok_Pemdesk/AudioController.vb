Imports System.Media
Imports System.IO
Imports System.Collections.Generic

Module AudioController
    ' Menyimpan lokasi file suara dengan format: Kunci (Nama Alert) -> Nilai (Lokasi File)
    Public SoundPaths As New Dictionary(Of String, String)()

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