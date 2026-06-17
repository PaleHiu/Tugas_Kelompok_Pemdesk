Imports System.Data.SqlTypes
Imports System.Drawing
Imports System.Net
Imports System.Net.Sockets
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Threading
Imports System.Collections.Generic
Imports ZXing
Imports ZXing.Common

Public Class FormQRGenerated

    Private baseUrl As String = "https://kata.yabinya.com/scbscoring"
    Private tatamiID As String = "TM-545FB238400A"
    Private judgeUrls(6) As String

    ' True jika sedang memakai SERVER LOKAL (aplikasi ini sendiri jadi server).
    Private useLocalServer As Boolean = False
    ' Port default server lokal.
    Private Const LOCAL_PORT As Integer = 8080

    Private Sub FormQRGenerated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "QR Generated"

        ' ---> AKTIFKAN SENSOR KLIK GLOBAL (UNSELECT) <---
        PasangSensorKlikGlobal(Me)

        ' Default awal: pakai server aplikasi (Yabinya)
        useLocalServer = False
        BuildJudgeUrls()

        lblTatamiIDValue.Text = tatamiID
        lblDefaultURL.Text = baseUrl

        GenerateAllQR()
        LoadQRValueSet()

        tmrClock.Start()
        UpdateClock()
    End Sub

    ' ====================================================================
    ' 1. FUNGSI UNSELECT (MENGHAPUS SELEKSI PADA TABEL QR)
    ' ====================================================================
    Private Sub HapusSeleksiQR()
        lvQRValues.SelectedItems.Clear()
    End Sub

    ' ====================================================================
    ' 2. SENSOR KLIK GLOBAL (UNTUK FORM DAN SEMUA PANEL)
    ' ====================================================================
    Private Sub PasangSensorKlikGlobal(induk As Control)
        ' Pasang sensor klik pada Form dan Panel (Area kosong)
        If TypeOf induk Is Form OrElse TypeOf induk Is Panel Then
            AddHandler induk.MouseDown, Sub(sender_obj, ev) HapusSeleksiQR()
        End If

        ' Telusuri elemen di dalamnya secara otomatis
        For Each elemen As Control In induk.Controls
            PasangSensorKlikGlobal(elemen)
        Next
    End Sub

    ' ====================================================================
    ' 3. SENSOR AREA KOSONG KHUSUS DI DALAM TABEL (LISTVIEW)
    ' ====================================================================
    Private Sub lvQRValues_MouseDown(sender As Object, e As MouseEventArgs) Handles lvQRValues.MouseDown
        Dim hit As ListViewHitTestInfo = lvQRValues.HitTest(e.X, e.Y)
        ' Jika klik area kosong di dalam tabel (bukan teks URL)
        If hit.Item Is Nothing Then
            HapusSeleksiQR()
        End If
    End Sub

    ' Bangun URL tiap juri sesuai mode server yang aktif.
    Private Sub BuildJudgeUrls()
        For i As Integer = 0 To 6
            Dim judgeNo As Integer = i + 1
            If useLocalServer Then
                ' Server lokal (embedded di aplikasi): tidak pakai .php
                judgeUrls(i) = baseUrl & "/login?judge=" & judgeNo & "&tatami=" & tatamiID
            Else
                ' Server web (Yabinya / PHP)
                judgeUrls(i) = baseUrl & "/login.php?judge=" & judgeNo & "&tatami=" & tatamiID
            End If
        Next
    End Sub

    ' Ambil PictureBox berdasarkan index langsung tanpa array
    Private Function GetPB(index As Integer) As PictureBox
        Select Case index
            Case 0 : Return pbJ1
            Case 1 : Return pbJ2
            Case 2 : Return pbJ3
            Case 3 : Return pbJ4
            Case 4 : Return pbJ5
            Case 5 : Return pbJ6
            Case 6 : Return pbJ7
            Case Else : Return Nothing
        End Select
    End Function

    Private Sub GenerateAllQR()
        For i As Integer = 0 To 6
            Dim pb As PictureBox = GetPB(i)
            If pb IsNot Nothing Then
                Dim bmp As Bitmap = GenerateQRBitmap(judgeUrls(i), 145, 145)
                pb.Image = bmp
                pb.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Next
    End Sub

    Private Function GenerateQRBitmap(text As String, width As Integer, height As Integer) As Bitmap
        Try
            Dim writer As New BarcodeWriterPixelData()
            writer.Format = BarcodeFormat.QR_CODE
            writer.Options = New EncodingOptions() With {
                .Width = width,
                .Height = height,
                .Margin = 1
            }
            Dim pixelData = writer.Write(text)
            Dim bmp As New Bitmap(pixelData.Width, pixelData.Height, Drawing.Imaging.PixelFormat.Format32bppRgb)
            Dim bmpData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height),
                                        Drawing.Imaging.ImageLockMode.WriteOnly,
                                        Drawing.Imaging.PixelFormat.Format32bppRgb)
            Try
                System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bmpData.Scan0, pixelData.Pixels.Length)
            Finally
                bmp.UnlockBits(bmpData)
            End Try
            Return bmp
        Catch ex As Exception
            Dim bmp As New Bitmap(width, height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
                g.DrawString("QR Error", New Font("Segoe UI", 8), Brushes.Red, 10, 60)
            End Using
            Return bmp
        End Try
    End Function

    Private Sub LoadQRValueSet()
        lvQRValues.Items.Clear()
        For i As Integer = 0 To 6
            Dim item As New ListViewItem("J" & (i + 1))

            ' 1. Matikan gaya seragam agar kita bisa membedakan font antar kolom
            item.UseItemStyleForSubItems = False

            ' 2. Jadikan teks kolom pertama (J1, J2, dst) menjadi BOLD
            item.Font = New Font(lvQRValues.Font.FontFamily, 9.5!, FontStyle.Bold)

            ' 3. Tambahkan teks URL di kolom kedua dengan gaya NORMAL (Regular)
            item.SubItems.Add(judgeUrls(i))
            item.SubItems(1).Font = New Font(lvQRValues.Font.FontFamily, 8.5!, FontStyle.Regular)

            lvQRValues.Items.Add(item)
        Next
    End Sub

    Private Sub UpdateClock()
        lblDateTime.Text = DateTime.Now.ToString("M/d/yyyy h:mm tt")
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        UpdateClock()
    End Sub

    ' ============================ PILIHAN SERVER ============================

    Private Sub rbYabinya_CheckedChanged(sender As Object, e As EventArgs) Handles rbYabinya.CheckedChanged
        If rbYabinya.Checked Then
            useLocalServer = False
            baseUrl = "https://kata.yabinya.com/scbscoring"
            txtBaseURL.Text = baseUrl
            txtBaseURL.ReadOnly = True
            RefreshURLs()
        End If
    End Sub

    Private Sub rbOwn_CheckedChanged(sender As Object, e As EventArgs) Handles rbOwn.CheckedChanged
        If rbOwn.Checked Then
            useLocalServer = True
            ' Boleh diubah manual kalau user punya server PHP sendiri,
            ' tapi defaultnya kita isi otomatis dengan server lokal aplikasi.
            txtBaseURL.ReadOnly = False
            StartLocalServerAndFillUrl()
        End If
    End Sub

    ' Menyalakan server lokal (embedded), deteksi IP LAN, lalu isi Base URL.
    Private Sub StartLocalServerAndFillUrl()
        ' Beritahu server nomor Tatami agar tampil di halaman juri
        LocalScoringServer.Instance.TatamiId = tatamiID

        Dim activePort As Integer = LocalScoringServer.Instance.StartServer(LOCAL_PORT)
        Dim ip As String = LocalScoringServer.GetLocalIPv4()

        If activePort = 0 Then
            MessageBox.Show(
                "Server lokal gagal dinyalakan." & vbCrLf &
                "Kemungkinan port sedang dipakai aplikasi lain atau diblokir Firewall." & vbCrLf &
                "Coba tutup aplikasi lain yang memakai port, atau izinkan aplikasi ini di Windows Firewall.",
                "Server Lokal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            baseUrl = "http://" & ip & ":" & LOCAL_PORT
        Else
            baseUrl = "http://" & ip & ":" & activePort
            MessageBox.Show(
                "Server lokal AKTIF." & vbCrLf & vbCrLf &
                "Alamat       : " & baseUrl & vbCrLf &
                "Status uji   : " & baseUrl & "/status" & vbCrLf & vbCrLf &
                "Pastikan HP juri tersambung ke Wi-Fi/jaringan yang SAMA dengan komputer ini, " &
                "lalu scan QR masing-masing juri.",
                "Server Lokal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Set teks tanpa memicu logika ganda
        txtBaseURL.Text = baseUrl
        RefreshURLs()
    End Sub

    Private Sub txtBaseURL_TextChanged(sender As Object, e As EventArgs) Handles txtBaseURL.TextChanged
        ' Hanya berlaku jika user memilih "Own Server" dan mengetik manual.
        If rbOwn.Checked Then
            baseUrl = txtBaseURL.Text.Trim()
            RefreshURLs()
        End If
    End Sub

    Private Sub RefreshURLs()
        BuildJudgeUrls()
        GenerateAllQR()
        LoadQRValueSet()
        lblDefaultURL.Text = baseUrl
    End Sub

    ' ============================ SIMPAN & SALIN ============================

    Private Sub btnSaveJ1_Click(sender As Object, e As EventArgs) Handles btnSaveJ1.Click
        SaveQRImage(0)
    End Sub
    Private Sub btnSaveJ2_Click(sender As Object, e As EventArgs) Handles btnSaveJ2.Click
        SaveQRImage(1)
    End Sub
    Private Sub btnSaveJ3_Click(sender As Object, e As EventArgs) Handles btnSaveJ3.Click
        SaveQRImage(2)
    End Sub
    Private Sub btnSaveJ4_Click(sender As Object, e As EventArgs) Handles btnSaveJ4.Click
        SaveQRImage(3)
    End Sub
    Private Sub btnSaveJ5_Click(sender As Object, e As EventArgs) Handles btnSaveJ5.Click
        SaveQRImage(4)
    End Sub
    Private Sub btnSaveJ6_Click(sender As Object, e As EventArgs) Handles btnSaveJ6.Click
        SaveQRImage(5)
    End Sub
    Private Sub btnSaveJ7_Click(sender As Object, e As EventArgs) Handles btnSaveJ7.Click
        SaveQRImage(6)
    End Sub

    Private Sub SaveQRImage(judgeIndex As Integer)
        Dim pb As PictureBox = GetPB(judgeIndex)
        If pb Is Nothing OrElse pb.Image Is Nothing Then Return
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg"
        sfd.FileName = "QR_Judge" & (judgeIndex + 1) & "_" & tatamiID
        If sfd.ShowDialog() = DialogResult.OK Then
            pb.Image.Save(sfd.FileName)
            MessageBox.Show("QR Code berhasil disimpan!", "Simpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CopyQRValue(judgeIndex As Integer)
        Clipboard.SetText(judgeUrls(judgeIndex))
        MessageBox.Show("URL Judge " & (judgeIndex + 1) & " disalin!", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCopyJ1_Click(sender As Object, e As EventArgs) Handles btnCopyJ1.Click
        CopyQRValue(0)
    End Sub
    Private Sub btnCopyJ2_Click(sender As Object, e As EventArgs) Handles btnCopyJ2.Click
        CopyQRValue(1)
    End Sub
    Private Sub btnCopyJ3_Click(sender As Object, e As EventArgs) Handles btnCopyJ3.Click
        CopyQRValue(2)
    End Sub
    Private Sub btnCopyJ4_Click(sender As Object, e As EventArgs) Handles btnCopyJ4.Click
        CopyQRValue(3)
    End Sub
    Private Sub btnCopyJ5_Click(sender As Object, e As EventArgs) Handles btnCopyJ5.Click
        CopyQRValue(4)
    End Sub
    Private Sub btnCopyJ6_Click(sender As Object, e As EventArgs) Handles btnCopyJ6.Click
        CopyQRValue(5)
    End Sub
    Private Sub btnCopyJ7_Click(sender As Object, e As EventArgs) Handles btnCopyJ7.Click
        CopyQRValue(6)
    End Sub

    Private Sub btnSavePDF_Click(sender As Object, e As EventArgs) Handles btnSavePDF.Click
        MessageBox.Show("Fitur Save QR Code to PDF memerlukan library tambahan (PdfSharp)." & vbCrLf &
                        "Silakan install via NuGet: PdfSharp", "Info PDF",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class

' =====================================================================================
' ============================  SERVER LOKAL (EMBEDDED)  ===============================
' Aplikasi ini menjadi server-nya sendiri memakai TcpListener (tidak butuh Apache/PHP,
' tidak butuh hak admin / urlacl seperti HttpListener). HP juri yang berada di jaringan
' Wi-Fi yang SAMA cukup men-scan QR -> browser HP membuka halaman login & scoring yang
' di-serve oleh aplikasi ini -> skor yang dikirim ditampung di sini secara real-time.
'
' Cara konsumsi dari KataMainControl (mode Online) - contoh:
'   AddHandler LocalScoringServer.Instance.ScoreReceived, AddressOf OnJudgeScore
'   Private Sub OnJudgeScore(judgeNo As Integer, side As String, value As Decimal)
'       If Me.InvokeRequired Then
'           Me.Invoke(Sub() OnJudgeScore(judgeNo, side, value)) : Return
'       End If
'       ' isi NumAkaJ{n} / NumAoJ{n} sesuai judgeNo & side -> total dihitung otomatis
'   End Sub
' =====================================================================================
Public Class LocalScoringServer

    Private Shared _instance As LocalScoringServer
    Public Shared ReadOnly Property Instance As LocalScoringServer
        Get
            If _instance Is Nothing Then _instance = New LocalScoringServer()
            Return _instance
        End Get
    End Property

    Private listener As TcpListener
    Private worker As Thread
    Private running As Boolean = False

    Public Property Port As Integer = 8080
    Public Property TatamiId As String = ""

    ' Skor tersimpan, key "AKA1".."AO7" -> nilai Decimal
    Private ReadOnly scoreMap As New Dictionary(Of String, Decimal)
    Private ReadOnly sync As New Object()

    Public Event ScoreReceived(judgeNumber As Integer, side As String, value As Decimal)
    Public Event JudgeLoggedIn(judgeNumber As Integer)
    Public Event ServerLog(message As String)

    Public ReadOnly Property IsRunning As Boolean
        Get
            Return running
        End Get
    End Property

    ' Menyalakan server. Mencoba beberapa port jika port utama sibuk.
    ' Mengembalikan port yang berhasil dipakai (0 jika gagal total).
    Public Function StartServer(preferredPort As Integer) As Integer
        If running Then Return Port
        For p As Integer = preferredPort To preferredPort + 9
            Try
                listener = New TcpListener(IPAddress.Any, p)
                listener.Start()
                Port = p
                running = True
                worker = New Thread(AddressOf AcceptLoop)
                worker.IsBackground = True
                worker.Start()
                RaiseEvent ServerLog("Server lokal aktif di port " & p)
                Return p
            Catch
                ' coba port berikutnya
            End Try
        Next
        Return 0
    End Function

    Public Sub StopServer()
        running = False
        Try
            If listener IsNot Nothing Then listener.Stop()
        Catch
        End Try
    End Sub

    Private Sub AcceptLoop()
        While running
            Try
                Dim c As TcpClient = listener.AcceptTcpClient()
                Dim t As New Thread(AddressOf HandleClient)
                t.IsBackground = True
                t.Start(c)
            Catch
                Exit While
            End Try
        End While
    End Sub

    Private Sub HandleClient(o As Object)
        Dim client As TcpClient = CType(o, TcpClient)
        Try
            client.ReceiveTimeout = 8000
            Dim ns As NetworkStream = client.GetStream()

            Dim method As String = "", rawPath As String = "", body As String = ""
            If Not ReadHttp(ns, method, rawPath, body) Then Return

            Dim path As String = rawPath
            Dim query As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
            Dim qpos As Integer = rawPath.IndexOf("?"c)
            If qpos >= 0 Then
                path = rawPath.Substring(0, qpos)
                ParseQuery(rawPath.Substring(qpos + 1), query)
            End If
            If body <> "" Then ParseQuery(body, query)

            Dim status As String = "200 OK"
            Dim respContentType As String = "text/html; charset=utf-8"
            Dim responseBody As String = ""

            Select Case path.ToLowerInvariant()
                Case "/", "/login"
                    responseBody = PageLogin(ClampJudge(GetInt(query, "judge", 1)))
                Case "/dologin"
                    Dim jn As Integer = ClampJudge(GetInt(query, "judge", 1))
                    RaiseEvent JudgeLoggedIn(jn)
                    responseBody = PageScore(jn)
                Case "/score"
                    responseBody = PageScore(ClampJudge(GetInt(query, "judge", 1)))
                Case "/submit"
                    Dim jn As Integer = ClampJudge(GetInt(query, "judge", 1))
                    Dim side As String = "AKA"
                    If query.ContainsKey("side") AndAlso query("side").ToUpperInvariant() = "AO" Then side = "AO"
                    Dim val As Decimal = ParseDec(If(query.ContainsKey("value"), query("value"), "0"))
                    StoreScore(jn, side, val)
                    respContentType = "application/json; charset=utf-8"
                    responseBody = "{""ok"":true,""judge"":" & jn & ",""side"":""" & side & """,""value"":" &
                          val.ToString("0.0", Globalization.CultureInfo.InvariantCulture) & "}"
                Case "/status"
                    respContentType = "application/json; charset=utf-8"
                    responseBody = StatusJson()
                Case "/favicon.ico"
                    status = "204 No Content"
                    responseBody = ""
                Case Else
                    status = "404 Not Found"
                    responseBody = "Not Found"
            End Select

            WriteHttp(ns, status, respContentType, responseBody)
            ns.Flush()
        Catch
        Finally
            Try : client.Close() : Catch : End Try
        End Try
    End Sub

    ' --------- HTTP parsing minimal ---------
    Private Function ReadHttp(ns As NetworkStream, ByRef method As String, ByRef path As String, ByRef body As String) As Boolean
        Dim header As New List(Of Byte)
        Dim count As Integer = 0
        Do
            Dim b As Integer = ns.ReadByte()
            If b = -1 Then Exit Do
            header.Add(CByte(b))
            count += 1
            If count >= 4 AndAlso header(count - 4) = 13 AndAlso header(count - 3) = 10 AndAlso
               header(count - 2) = 13 AndAlso header(count - 1) = 10 Then
                Exit Do
            End If
            If count > 16384 Then Exit Do
        Loop
        If header.Count = 0 Then Return False

        Dim headerText As String = Encoding.ASCII.GetString(header.ToArray())
        Dim lines() As String = headerText.Split(New String() {vbCrLf}, StringSplitOptions.None)
        If lines.Length = 0 Then Return False
        Dim first() As String = lines(0).Split(" "c)
        If first.Length < 2 Then Return False
        method = first(0)
        path = first(1)

        Dim clen As Integer = 0
        For Each ln As String In lines
            If ln.ToLowerInvariant().StartsWith("content-length:") Then
                Integer.TryParse(ln.Substring("content-length:".Length).Trim(), clen)
            End If
        Next
        If clen > 0 AndAlso clen < 1048576 Then
            Dim buf(clen - 1) As Byte
            Dim read As Integer = 0
            While read < clen
                Dim n As Integer = ns.Read(buf, read, clen - read)
                If n <= 0 Then Exit While
                read += n
            End While
            body = Encoding.UTF8.GetString(buf, 0, read)
        End If
        Return True
    End Function

    Private Sub WriteHttp(ns As NetworkStream, status As String, contentType As String, body As String)
        Dim bodyBytes() As Byte = Encoding.UTF8.GetBytes(body)
        Dim head As String =
            "HTTP/1.1 " & status & vbCrLf &
            "Content-Type: " & contentType & vbCrLf &
            "Content-Length: " & bodyBytes.Length & vbCrLf &
            "Cache-Control: no-store" & vbCrLf &
            "Connection: close" & vbCrLf & vbCrLf
        Dim headBytes() As Byte = Encoding.ASCII.GetBytes(head)
        ns.Write(headBytes, 0, headBytes.Length)
        If bodyBytes.Length > 0 Then ns.Write(bodyBytes, 0, bodyBytes.Length)
    End Sub

    Private Sub ParseQuery(q As String, dict As Dictionary(Of String, String))
        For Each pair As String In q.Split("&"c)
            If pair = "" Then Continue For
            Dim kv() As String = pair.Split(New Char() {"="c}, 2)
            Dim k As String = Uri.UnescapeDataString(kv(0).Replace("+"c, " "c))
            Dim v As String = If(kv.Length > 1, Uri.UnescapeDataString(kv(1).Replace("+"c, " "c)), "")
            dict(k) = v
        Next
    End Sub

    Private Function GetInt(d As Dictionary(Of String, String), key As String, def As Integer) As Integer
        Dim r As Integer = def
        If d.ContainsKey(key) Then Integer.TryParse(d(key), r)
        Return r
    End Function

    Private Function ClampJudge(n As Integer) As Integer
        If n < 1 Then Return 1
        If n > 7 Then Return 7
        Return n
    End Function

    Private Function ParseDec(s As String) As Decimal
        Dim r As Decimal = 0D
        Decimal.TryParse(s, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, r)
        Return r
    End Function

    ' --------- penyimpanan skor ---------
    Private Sub StoreScore(judgeNumber As Integer, side As String, value As Decimal)
        SyncLock sync
            scoreMap(side & judgeNumber) = value
        End SyncLock
        RaiseEvent ScoreReceived(judgeNumber, side, value)
        RaiseEvent ServerLog("Skor masuk: " & side & " J" & judgeNumber & " = " &
                              value.ToString("0.0", Globalization.CultureInfo.InvariantCulture))
    End Sub

    Public Function GetScore(side As String, judgeNumber As Integer) As Decimal
        SyncLock sync
            Dim key As String = side.ToUpperInvariant() & judgeNumber
            If scoreMap.ContainsKey(key) Then Return scoreMap(key)
        End SyncLock
        Return 0D
    End Function

    Public Function SnapshotScores() As Dictionary(Of String, Decimal)
        SyncLock sync
            Return New Dictionary(Of String, Decimal)(scoreMap)
        End SyncLock
    End Function

    Public Sub ResetScores()
        SyncLock sync
            scoreMap.Clear()
        End SyncLock
    End Sub

    Private Function StatusJson() As String
        Dim sb As New StringBuilder("{""tatami"":""" & TatamiId & """,""running"":true,""scores"":{")
        SyncLock sync
            Dim first As Boolean = True
            For Each kvp As KeyValuePair(Of String, Decimal) In scoreMap
                If Not first Then sb.Append(",")
                sb.Append("""" & kvp.Key & """:" & kvp.Value.ToString("0.0", Globalization.CultureInfo.InvariantCulture))
                first = False
            Next
        End SyncLock
        sb.Append("}}")
        Return sb.ToString()
    End Function

    ' --------- deteksi IP LAN (IPv4) ---------
    Public Shared Function GetLocalIPv4() As String
        Try
            For Each ni As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
                If ni.OperationalStatus = OperationalStatus.Up AndAlso
                   (ni.NetworkInterfaceType = NetworkInterfaceType.Wireless80211 OrElse
                    ni.NetworkInterfaceType = NetworkInterfaceType.Ethernet) Then
                    For Each ua As UnicastIPAddressInformation In ni.GetIPProperties().UnicastAddresses
                        If ua.Address.AddressFamily = AddressFamily.InterNetwork AndAlso
                           Not IPAddress.IsLoopback(ua.Address) Then
                            Return ua.Address.ToString()
                        End If
                    Next
                End If
            Next
        Catch
        End Try
        Try
            For Each ip As IPAddress In Dns.GetHostEntry(Dns.GetHostName()).AddressList
                If ip.AddressFamily = AddressFamily.InterNetwork AndAlso Not IPAddress.IsLoopback(ip) Then
                    Return ip.ToString()
                End If
            Next
        Catch
        End Try
        Return "127.0.0.1"
    End Function

    ' ====================== HALAMAN WEB UNTUK HP JURI ======================
    Private Function HtmlHead(title As String) As String
        Return "<!DOCTYPE html><html><head><meta charset='utf-8'>" &
               "<meta name='viewport' content='width=device-width,initial-scale=1'>" &
               "<title>" & title & "</title><style>" &
               "*{box-sizing:border-box;font-family:Segoe UI,Arial,sans-serif}" &
               "body{margin:0;background:#0f1830;color:#fff;display:flex;justify-content:center;padding:16px}" &
               ".card{width:100%;max-width:430px;background:#16213e;border-radius:16px;padding:20px}" &
               "h1{font-size:18px;margin:0 0 2px}.sub{color:#7da0ff;font-size:13px;margin-bottom:14px}" &
               "label{display:block;font-size:12px;color:#9fb3d1;margin:10px 0 4px}" &
               "input{width:100%;padding:11px;border-radius:9px;border:1px solid #2c3a5e;background:#0f1830;color:#fff;font-size:15px}" &
               ".btn{display:block;width:100%;margin-top:16px;padding:13px;border:0;border-radius:10px;background:#2f6df6;color:#fff;font-size:16px;font-weight:700}" &
               ".side{display:flex;gap:8px;margin:6px 0 4px}.side button{flex:1;padding:12px;border:0;border-radius:10px;font-weight:700;font-size:15px;color:#fff}" &
               ".aka{background:#e23d4c}.ao{background:#2f6df6}.dim{opacity:.4}" &
               ".grid{display:grid;grid-template-columns:repeat(5,1fr);gap:7px;margin-top:12px}" &
               ".s{padding:13px 0;border-radius:10px;border:1px solid #2c3a5e;background:#0f1830;color:#fff;font-size:15px;font-weight:700;text-align:center}" &
               ".s:active{background:#2f6df6}.zero{background:#c0392b;border-color:#c0392b}" &
               "#msg{margin-top:12px;text-align:center;color:#7CFC9A;font-weight:700;min-height:22px}" &
               "</style></head><body><div class='card'>"
    End Function

    Private Function PageLogin(judge As Integer) As String
        Dim uname As String = "Judge" & judge.ToString("00")
        Dim sb As New StringBuilder(HtmlHead("KATA Scoring Online"))
        sb.Append("<h1>Yabinya Studio</h1><div class='sub'>KATA Scoring Online - Server Lokal</div>")
        sb.Append("<form method='get' action='/dologin'>")
        sb.Append("<input type='hidden' name='judge' value='" & judge & "'>")
        sb.Append("<label>Tatami ID</label><input value='" & TatamiId & "' readonly>")
        sb.Append("<label>Username</label><input name='user' value='" & uname & "' readonly>")
        sb.Append("<label>Password</label><input name='pass' type='password' placeholder='(bebas untuk demo)'>")
        sb.Append("<button class='btn' type='submit'>Login</button>")
        sb.Append("</form></div></body></html>")
        Return sb.ToString()
    End Function

    Private Function PageScore(judge As Integer) As String
        Dim sb As New StringBuilder(HtmlHead("Scoring J" & judge))
        sb.Append("<h1>Judge " & judge & "</h1><div class='sub'>Tatami " & TatamiId & " - pilih sisi lalu ketuk nilai</div>")
        sb.Append("<div class='side'>")
        sb.Append("<button id='bAka' class='aka' onclick='pick(&quot;AKA&quot;)'>AKA</button>")
        sb.Append("<button id='bAo' class='ao dim' onclick='pick(&quot;AO&quot;)'>AO</button>")
        sb.Append("</div>")
        sb.Append("<div class='grid'>")
        sb.Append("<div class='s zero' onclick='send(0)'>0</div>")
        Dim v As Decimal = 5D
        While v <= 10D
            Dim valStr As String = v.ToString("0.0", Globalization.CultureInfo.InvariantCulture)
            Dim disp As String = If(v = Math.Truncate(v), CInt(v).ToString(), valStr)
            sb.Append("<div class='s' onclick='send(" & valStr & ")'>" & disp & "</div>")
            v += 0.1D
        End While
        sb.Append("</div><div id='msg'></div>")

        sb.Append("<script>var side='AKA';")
        sb.Append("function pick(s){side=s;")
        sb.Append("document.getElementById('bAka').className=(s=='AKA')?'aka':'aka dim';")
        sb.Append("document.getElementById('bAo').className=(s=='AO')?'ao':'ao dim';}")
        sb.Append("function send(v){fetch('/submit?judge=" & judge & "&side='+side+'&value='+v,{method:'POST'})")
        sb.Append(".then(function(r){return r.json();}).then(function(d){")
        sb.Append("document.getElementById('msg').textContent='Tersimpan: '+d.side+' J'+d.judge+' = '+d.value;})")
        sb.Append(".catch(function(e){document.getElementById('msg').textContent='Gagal mengirim skor';});}")
        sb.Append("</script>")

        sb.Append("</div></body></html>")
        Return sb.ToString()
    End Function

End Class