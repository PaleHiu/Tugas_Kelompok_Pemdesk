Imports System.Data.SQLite

Public Class ListOfCompetitor
    Dim connString As String = "Data Source=database.db;Version=3;"

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ListOfCompetitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. KUNCI UKURAN FORM
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        ' 2. PERBAIKAN WARNA HEADER TABEL (KONTRAST TINGGI & ANTI BIRU)
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson
        DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Crimson
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        ' ---> TAMBAHKAN KODE INI UNTUK MEMPERBESAR TEKS HEADER KIRI <---
        LabelTeam.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        LabelTeam.ForeColor = Color.White ' Memastikan warnanya tetap putih kontras

        ' ---> TAMBAHKAN 2 BARIS INI UNTUK MENGATUR & MENGUNCI TINGGI HEADER <---
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.ColumnHeadersHeight = 60 ' Silakan ubah angka 45 ini sesuai kebutuhan Anda

        ' 3. KUNCI UKURAN TABEL & TEKS EXTEND KE BAWAH (WRAP TEXT)
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AllowUserToAddRows = False
        ' ---> MATIKAN AutoSize agar ukuran manual bisa berfungsi <---
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DataGridView1.RowTemplate.Height = 40
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True

        ' 4. KODE MODE RENDER LISTBOX
        ListBoxTeam.DrawMode = DrawMode.OwnerDrawFixed
        ListBoxTeam.ItemHeight = 60

        Try
            LoadTeam()
            LoadCompetitor("")
        Catch ex As Exception
            MessageBox.Show("Form gagal terbuka karena ada silent crash di dalam Load: " & vbCrLf & ex.Message,
                            "Pelacak Error Misterius", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ... (sisanya biarkan saja)

    ' --- 1. LOAD DAFTAR TIM KE LISTBOX (Kiri) ---
    Private Sub LoadTeam()
        Try
            ListBoxTeam.Items.Clear()
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                ' Ambil dari tabel team_lengkap yang kita buat di form Team
                Dim query As String = "SELECT nama_team FROM team_lengkap ORDER BY nama_team ASC"
                Using cmd As New SQLiteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            ListBoxTeam.Items.Add(reader("nama_team").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Jika tabel belum ada, tampilkan pesan ringan saja
        End Try
    End Sub

    ' --- 2. EVENT SAAT NAMA TIM DIKLIK ---
    Private Sub ListBoxTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTeam.SelectedIndexChanged
        If ListBoxTeam.SelectedItem IsNot Nothing Then
            LoadCompetitor(ListBoxTeam.SelectedItem.ToString())
        End If
    End Sub

    ' --- 3. LOAD DATA KOMPETITOR KE GRID (Kanan) ---
    Private Sub LoadCompetitor(teamName As String)
        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Dim query As String

                If teamName = "" Then
                    query = "SELECT name AS [Nama Peserta], team AS [Nama Team], team_info AS [Info] FROM competitor"
                Else
                    query = "SELECT name AS [Nama Peserta], team AS [Nama Team], team_info AS [Info] FROM competitor WHERE team = @team"
                End If

                Using cmd As New SQLiteCommand(query, conn)
                    If teamName <> "" Then cmd.Parameters.AddWithValue("@team", teamName)

                    Dim adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DataGridView1.DataSource = dt

                    ' Percantik Grid
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    ' ---> TAMBAHKAN BARIS INI: Menghilangkan blok biru otomatis <---
                    DataGridView1.ClearSelection()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    ' --- 4. TOMBOL SEARCH ---
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If TxtSearch.Text.Trim <> "" Then
            Try
                Using conn As New SQLiteConnection(connString)
                    conn.Open()
                    Dim query As String = "SELECT name, team, team_info FROM competitor WHERE name LIKE @search OR team LIKE @search"
                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@search", "%" & TxtSearch.Text & "%")
                        Dim adapter As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End If
    End Sub

    ' --- 5. TOMBOL CLEAR & CLOSE ---
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ListBoxTeam.SelectedIndex = -1
        TxtSearch.Clear()
        LoadCompetitor("")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    ' --- FUNGSI UNTUK TOMBOL X (CLEAR SEARCH) ---
    Private Sub BtnClearSearch_Click(sender As Object, e As EventArgs) Handles BtnClearSearch.Click
        TxtSearch.Clear()
        LoadCompetitor("") ' Menampilkan semua orang kembali ke grid
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' 1. Tarik ketiga data dari tabel (Kolom 0: Nama, Kolom 1: Tim, Kolom 2: Info)
            Dim nama As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            Dim tim As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            Dim info As String = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()

            ' 2. Kirim datanya menggunakan SetCompetitorData yang baru
            Dim frmKumite As KumiteMainControl = TryCast(Application.OpenForms("KumiteMainControl"), KumiteMainControl)
            If frmKumite IsNot Nothing Then
                frmKumite.SetCompetitorData(nama, tim, info)
            End If

            Me.Close()
        Else
            MessageBox.Show("Silakan pilih salah satu peserta terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' --- FUNGSI CUSTOM UI UNTUK LISTBOX TIM ---
    Private Sub ListBoxTeam_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBoxTeam.DrawItem
        If e.Index < 0 Then Return

        Dim lb As ListBox = DirectCast(sender, ListBox)
        Dim itemText As String = lb.Items(e.Index).ToString()

        ' 1. Tentukan ukuran "Kartu" (Memberikan margin/gap sebesar 4 pixel di setiap sisi)
        Dim margin As Integer = 4
        Dim itemRect As New Rectangle(e.Bounds.X + margin, e.Bounds.Y + margin, e.Bounds.Width - (margin * 2), e.Bounds.Height - (margin * 2))

        ' Bersihkan background bawaan
        e.DrawBackground()

        ' 2. Atur Warna Background & Border saat dipilih vs tidak dipilih
        Dim isSelected As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected
        Dim bgBrush As Brush
        Dim borderPen As Pen
        Dim textBrush As Brush

        If isSelected Then
            ' Warna saat tim diklik (Biru gaya Windows)
            bgBrush = New SolidBrush(Color.DeepSkyBlue)
            borderPen = New Pen(Color.SteelBlue, 1)
            textBrush = Brushes.White
        Else
            ' Warna normal (Putih keabu-abuan dengan border abu-abu)
            bgBrush = New SolidBrush(Color.WhiteSmoke)
            borderPen = New Pen(Color.LightGray, 1)
            textBrush = Brushes.Black
        End If

        ' 3. Gambar Background Kotak
        e.Graphics.FillRectangle(bgBrush, itemRect)

        ' 4. Gambar Border Kotak
        e.Graphics.DrawRectangle(borderPen, itemRect)

        ' 5. Gambar Teks (Rata Tengah Horizontal & Vertikal)
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        ' Gunakan font bawaan ListBox, tapi buat sedikit Bold jika dipilih
        Dim itemFont As Font = If(isSelected, New Font(e.Font, FontStyle.Bold), e.Font)
        e.Graphics.DrawString(itemText, itemFont, textBrush, itemRect, sf)

        ' Clean up resource
        If isSelected Then itemFont.Dispose()
    End Sub

    ' ====================================================================
    ' FUNGSI CLEAR SELECTION (KLIK AREA KOSONG)
    ' ====================================================================

    ' 1. Jika User mengklik area kosong di background/panel form
    Private Sub ClearFocus_Click(sender As Object, e As EventArgs) Handles MyBase.Click, PanelLeft.Click, PanelRight.Click, PanelLeftHeader.Click, PanelBottomLeft.Click, PanelBottomRight.Click
        ListBoxTeam.SelectedIndex = -1
        DataGridView1.ClearSelection()
        LoadCompetitor("") ' Tampilkan semua data kembali
    End Sub

    ' 2. Jika User mengklik area kosong abu-abu di dalam Tabel
    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        Dim hit As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)
        ' Jika tipe yang diklik adalah "None" (Area kosong tanpa baris data)
        If hit.Type = DataGridViewHitTestType.None Then
            DataGridView1.ClearSelection()
        End If
    End Sub

    ' 3. Jika User mengklik area kosong di bawah daftar Tim (Listbox)
    Private Sub ListBoxTeam_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBoxTeam.MouseDown
        ' Cek apakah titik yang diklik merupakan baris nama tim atau area kosong
        Dim index As Integer = ListBoxTeam.IndexFromPoint(e.X, e.Y)
        If index = ListBox.NoMatches Then
            ListBoxTeam.SelectedIndex = -1
            LoadCompetitor("") ' Tampilkan semua data kembali
        End If
    End Sub
End Class