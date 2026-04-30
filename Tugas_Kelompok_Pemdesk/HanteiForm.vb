Imports System.Drawing
Imports System.Windows.Forms

Public Class HanteiForm
    Private akaVotes As Integer = 0
    Private aoVotes As Integer = 0

    Private akaState(3) As Boolean
    Private aoState(3) As Boolean

    Private akaButtons As New List(Of Button)
    Private aoButtons As New List(Of Button)

    Private titleLbl As Label
    Private lblAka As Label
    Private lblAo As Label
    Private lblWin As Label
    Private btnClear As Button
    Private btnClose As Button
    Private btnSave As Button

    ' [BARU] Memindahkan deklarasi tombol Referee ke level class agar bisa dikontrol on/off
    Private btnRefAka As Button
    Private btnRefAo As Button
    ' [BARU] Menyimpan keputusan wasit saat terjadi DRAW
    Private refereeDecision As String = ""

    Private ReadOnly activeColor As Color = Color.FromArgb(80, 20, 60)
    Private ReadOnly whiteBtn As Color = Color.White

    Public Sub New()
        InitializeComponent()

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.StartPosition = FormStartPosition.CenterParent
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.TopMost = True
        Me.Text = "Manual Decision"

        ' 1. Judul
        titleLbl = New Label With {
            .Text = "Manual Decision is Required.",
            .Dock = DockStyle.Top,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Arial", 14, FontStyle.Bold),
            .Height = 40
        }
        Me.Controls.Add(titleLbl)

        ' 2. GroupBox HANTEI
        Dim gbMain As New GroupBox With {
            .Text = "HANTEI",
            .Location = New Point(15, 50),
            .Size = New Size(700, 380),
            .Font = New Font("Arial", 10, FontStyle.Bold)
        }
        Me.Controls.Add(gbMain)

        ' 3. Tombol 4 kolom 
        Dim spacing As Integer = 110
        For i As Integer = 0 To 3
            Dim capturedIdx As Integer = i

            Dim btnAka As New Button With {
                .Text = "🚩" & vbCrLf & (i + 1),
                .Location = New Point(30 + (i * spacing), 40),
                .Size = New Size(100, 85),
                .Font = New Font("Arial", 16, FontStyle.Bold),
                .ForeColor = Color.Red,
                .BackColor = whiteBtn,
                .FlatStyle = FlatStyle.Standard
            }
            AddHandler btnAka.Click, Sub(s As Object, e As EventArgs) OnAkaClicked(capturedIdx)
            akaButtons.Add(btnAka)
            gbMain.Controls.Add(btnAka)

            Dim btnAo As New Button With {
                .Text = "🚩" & vbCrLf & (i + 1),
                .Location = New Point(30 + (i * spacing), 140),
                .Size = New Size(100, 85),
                .Font = New Font("Arial", 16, FontStyle.Bold),
                .ForeColor = Color.Blue,
                .BackColor = whiteBtn,
                .FlatStyle = FlatStyle.Standard
            }
            AddHandler btnAo.Click, Sub(s As Object, e As EventArgs) OnAoClicked(capturedIdx)
            aoButtons.Add(btnAo)
            gbMain.Controls.Add(btnAo)
        Next

        ' 4. Label Skor
        lblAka = New Label With {
            .Text = "AKA   = 0",
            .Location = New Point(480, 65),
            .AutoSize = True,
            .Font = New Font("Arial", 18, FontStyle.Bold),
            .ForeColor = Color.DarkRed
        }
        lblAo = New Label With {
            .Text = "AO    = 0",
            .Location = New Point(480, 165),
            .AutoSize = True,
            .Font = New Font("Arial", 18, FontStyle.Bold),
            .ForeColor = Color.DarkBlue
        }
        gbMain.Controls.AddRange({lblAka, lblAo})

        ' 5. Referee Selected Winner
        Dim gbRef As New GroupBox With {
            .Text = "Referee Selected Winner",
            .Location = New Point(30, 245),
            .Size = New Size(300, 110),
            .Font = New Font("Arial", 9, FontStyle.Regular)
        }

        ' [BARU] Hapus 'Dim' karena sudah dideklarasikan di level class
        btnRefAka = New Button With {
            .Text = "AKA", .Location = New Point(20, 35),
            .Size = New Size(110, 50), .Enabled = False, .BackColor = whiteBtn
        }
        ' [BARU] Perintah jika wasit klik tombol AKA
        AddHandler btnRefAka.Click, Sub(s, e)
                                        refereeDecision = "AKA"
                                        RefreshUI()
                                    End Sub

        btnRefAo = New Button With {
            .Text = "AO", .Location = New Point(150, 35),
            .Size = New Size(110, 50), .Enabled = False, .BackColor = whiteBtn
        }
        ' [BARU] Perintah jika wasit klik tombol AO
        AddHandler btnRefAo.Click, Sub(s, e)
                                       refereeDecision = "AO"
                                       RefreshUI()
                                   End Sub

        gbRef.Controls.AddRange({btnRefAka, btnRefAo})
        gbMain.Controls.Add(gbRef)

        ' 6. Ikon User
        Dim lblUser As New Label With {
            .Text = "👤",
            .Font = New Font("Segoe UI Symbol", 50),
            .Location = New Point(550, 250),
            .AutoSize = True,
            .ForeColor = Color.FromArgb(70, 90, 110)
        }
        gbMain.Controls.Add(lblUser)

        ' 7. Label Winner
        lblWin = New Label With {
            .Text = "Winner :",
            .BackColor = Color.Yellow,
            .Location = New Point(15, 450),
            .Size = New Size(700, 45),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Arial", 16, FontStyle.Bold),
            .BorderStyle = BorderStyle.FixedSingle
        }
        Me.Controls.Add(lblWin)

        ' 8. Tombol bawah
        btnClear = New Button With {
            .Text = "Clear", .Location = New Point(380, 510), .Size = New Size(100, 35)
        }
        AddHandler btnClear.Click, Sub(s As Object, e As EventArgs) ResetAll()

        btnClose = New Button With {
            .Text = "Close", .Location = New Point(495, 510), .Size = New Size(100, 35)
        }
        AddHandler btnClose.Click, Sub(s As Object, e As EventArgs) Me.Close()

        btnSave = New Button With {
            .Text = "Save", .Location = New Point(610, 510),
            .Size = New Size(100, 35), .BackColor = Color.AliceBlue
        }
        AddHandler btnSave.Click, Sub(s As Object, e As EventArgs) Me.Close()

        Me.Controls.AddRange({btnClear, btnClose, btnSave})

        ' Memanggil ResetAll() SETELAH semua komponen selesai dibuat!
        ResetAll()
    End Sub

    Private Sub OnAkaClicked(idx As Integer)
        Dim currentCount = CountActive(akaState)
        Dim nextCount = If(akaState(idx) AndAlso currentCount = (idx + 1), currentCount - 1, idx + 1)

        BuildColumns(nextCount, isAkaMode:=True)
        RefreshUI()
    End Sub

    Private Sub OnAoClicked(idx As Integer)
        Dim currentCount = CountActive(aoState)
        Dim nextCount = If(aoState(idx) AndAlso currentCount = (idx + 1), currentCount - 1, idx + 1)

        BuildColumns(nextCount, isAkaMode:=False)
        RefreshUI()
    End Sub

    Private Sub BuildColumns(n As Integer, isAkaMode As Boolean)
        Array.Clear(akaState, 0, 4)
        Array.Clear(aoState, 0, 4)

        ' [BARU] Jika formasi bendera diganti, pilihan wasit sebelumnya harus di-reset
        refereeDecision = ""

        If n <= 0 Then Return

        If isAkaMode Then
            Select Case n
                Case 1
                    akaState(0) = True
                    aoState(0) = True : aoState(1) = True : aoState(2) = True
                Case 2
                    akaState(0) = True : akaState(1) = True
                    aoState(0) = True : aoState(1) = True
                Case 3
                    akaState(0) = True : akaState(1) = True : akaState(2) = True
                    aoState(0) = True
                Case 4
                    For i As Integer = 0 To 3 : akaState(i) = True : Next
            End Select
        Else
            Select Case n
                Case 1
                    aoState(0) = True
                    akaState(0) = True : akaState(1) = True : akaState(2) = True
                Case 2
                    aoState(0) = True : aoState(1) = True
                    akaState(0) = True : akaState(1) = True
                Case 3
                    aoState(0) = True : aoState(1) = True : aoState(2) = True
                    akaState(0) = True
                Case 4
                    For i As Integer = 0 To 3 : aoState(i) = True : Next
            End Select
        End If
    End Sub

    Private Function CountActive(arr As Boolean()) As Integer
        Dim c As Integer = 0
        For i As Integer = 0 To 3
            If arr(i) Then c += 1
        Next
        Return c
    End Function

    Private Sub RefreshUI()
        akaVotes = 0
        aoVotes = 0

        For i As Integer = 0 To 3
            If akaState(i) Then
                akaButtons(i).BackColor = activeColor
                akaButtons(i).ForeColor = Color.White
                akaVotes += 1
            Else
                akaButtons(i).BackColor = whiteBtn
                akaButtons(i).ForeColor = Color.Red
            End If

            If aoState(i) Then
                aoButtons(i).BackColor = activeColor
                aoButtons(i).ForeColor = Color.White
                aoVotes += 1
            Else
                aoButtons(i).BackColor = whiteBtn
                aoButtons(i).ForeColor = Color.Blue
            End If
        Next

        lblAka.Text = "AKA   = " & akaVotes
        lblAo.Text = "AO    = " & aoVotes

        ' [BARU] Reset warna tombol juri secara default
        btnRefAka.BackColor = whiteBtn
        btnRefAka.ForeColor = Color.Black
        btnRefAo.BackColor = whiteBtn
        btnRefAo.ForeColor = Color.Black

        ' [BARU] Logika Penentuan Pemenang dan Aktivasi Tombol Referee
        If akaVotes = 0 AndAlso aoVotes = 0 Then
            lblWin.Text = "Winner :"
            btnRefAka.Enabled = False
            btnRefAo.Enabled = False

        ElseIf akaVotes > aoVotes Then
            lblWin.Text = "Winner :          AKA"
            btnRefAka.Enabled = False
            btnRefAo.Enabled = False

        ElseIf aoVotes > akaVotes Then
            lblWin.Text = "Winner :          AO"
            btnRefAka.Enabled = False
            btnRefAo.Enabled = False

        Else
            ' ==========================================
            ' KONDISI DRAW: Aktifkan kedua tombol wasit!
            ' ==========================================
            btnRefAka.Enabled = True
            btnRefAo.Enabled = True

            ' Cek apakah wasit sudah memilih siapa yang menang
            If refereeDecision = "AKA" Then
                lblWin.Text = "Winner :          AKA"
                btnRefAka.BackColor = Color.Red
                btnRefAka.ForeColor = Color.White
            ElseIf refereeDecision = "AO" Then
                lblWin.Text = "Winner :          AO"
                btnRefAo.BackColor = Color.Blue
                btnRefAo.ForeColor = Color.White
            Else
                ' Jika belum diklik oleh wasit, tetap tampilkan DRAW
                lblWin.Text = "Winner :          DRAW"
            End If
        End If
    End Sub

    Private Sub ResetAll()
        Array.Clear(akaState, 0, 4)
        Array.Clear(aoState, 0, 4)
        refereeDecision = "" ' [BARU] Reset juga pilihan juri ke kosong
        RefreshUI()
    End Sub
End Class