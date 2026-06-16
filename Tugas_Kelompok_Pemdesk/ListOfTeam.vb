Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.SQLite

Public Class ListOfTeam
    ' Komponen UI
    Dim LblHeader As New Label()
    Dim LblTotal As New Label()
    Dim WithEvents Dgv As New DataGridView()
    Dim PnlBottom As New Panel()
    Dim TxtSearch As New TextBox()
    Dim WithEvents BtnSearch As New Button()
    Dim WithEvents BtnClear As New Button()
    Dim LblHint As New Label()
    Dim WithEvents BtnSelect As New Button()

    ' --- CUSTOM VALUE (ubah di sini untuk menyesuaikan tampilan) ---
    Private Const ROW_HEIGHT As Integer = 28        ' Tinggi baris data (px)
    Private Const HEADER_HEIGHT As Integer = 38     ' Tinggi header kolom (px)

    ' --- SENTRALISASI CONNECTION STRING ---
    Private Const DB_CONN As String = "Data Source=database.db;Version=3;"

    Private Sub ListOfTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Pengaturan Form Dasar
        Me.Text = "List of Team"
        Me.Size = New Size(650, 500)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog   ' Kunci ukuran form
        Me.MaximizeBox = False                             ' Sembunyikan tombol maximize
        Me.MinimizeBox = True
        Me.StartPosition = FormStartPosition.CenterParent
        Me.BackColor = Color.White

        ' 2. Header & Total Records
        LblHeader.Text = "Team List"
        LblHeader.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        LblHeader.TextAlign = ContentAlignment.MiddleCenter
        LblHeader.Dock = DockStyle.Top
        LblHeader.Height = 40

        LblTotal.Text = "Total Records : 0"
        LblTotal.Font = New Font("Segoe UI", 9)
        LblTotal.Location = New Point(10, 45)
        LblTotal.AutoSize = True

        ' 3. DataGridView
        ' Form client area = 500px tinggi - ~30px title bar = ~470px
        ' Layout: LblHeader(40) + LblTotal(~22) + margin(6) = Y mulai 68
        ' PnlBottom = 50px (Dock Bottom), sisa untuk Dgv = 470 - 68 - 50 - 10 (margin bawah) = 342
        Dgv.Location = New Point(10, 68)
        Dgv.Size = New Size(620, 342)
        Dgv.Anchor = AnchorStyles.None
        Dgv.AllowUserToAddRows = False
        Dgv.AllowUserToDeleteRows = False
        Dgv.ReadOnly = True
        Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dgv.RowHeadersVisible = False
        Dgv.BackgroundColor = Color.White
        Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200)
        Dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215)

        ' --- KUNCI: Larang user memperbesar/memperkecil lebar & tinggi kolom/baris ---
        Dgv.AllowUserToResizeColumns = False
        Dgv.AllowUserToResizeRows = False
        Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        ' --- HEADER KOLOM: Background kontras, teks putih bold lebih besar ---
        Dgv.EnableHeadersVisualStyles = False
        Dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 110)
        Dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 58, 110)
        Dgv.ColumnHeadersHeight = HEADER_HEIGHT

        ' --- Tinggi baris default dari konstanta ---
        Dgv.RowTemplate.Height = ROW_HEIGHT

        ' Tambah Kolom
        Dgv.Columns.Add("No", "No")
        Dgv.Columns.Add("Team", "Team")
        Dgv.Columns.Add("TeamInfo", "Team Info")
        Dgv.Columns(0).Width = 40
        Dgv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dgv.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Dgv.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' Kunci tiap kolom agar tidak bisa di-resize satu per satu
        For Each col As DataGridViewColumn In Dgv.Columns
            col.Resizable = DataGridViewTriState.False
        Next

        ' Load Data
        LoadDataTimDariDatabase()

        ' 4. Panel Bawah (Merah Crimson)
        PnlBottom.BackColor = Color.Crimson
        PnlBottom.Dock = DockStyle.Bottom
        PnlBottom.Height = 50

        TxtSearch.Location = New Point(10, 13)
        TxtSearch.Width = 200
        TxtSearch.Font = New Font("Segoe UI", 10)

        BtnSearch.Text = "🔍"
        BtnSearch.Location = New Point(215, 12)
        BtnSearch.Size = New Size(30, 26)
        BtnSearch.BackColor = Color.White

        BtnClear.Text = "X"
        BtnClear.Location = New Point(250, 12)
        BtnClear.Size = New Size(30, 26)
        BtnClear.BackColor = Color.White
        BtnClear.ForeColor = Color.Crimson
        BtnClear.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        LblHint.Text = "**Double Click on row, or click select team."
        LblHint.ForeColor = Color.White
        LblHint.Location = New Point(290, 17)
        LblHint.AutoSize = True
        LblHint.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        BtnSelect.Text = "Select Team"
        BtnSelect.Size = New Size(130, 30)
        BtnSelect.BackColor = Color.DeepSkyBlue
        BtnSelect.ForeColor = Color.White
        BtnSelect.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        BtnSelect.FlatStyle = FlatStyle.Flat
        BtnSelect.FlatAppearance.BorderColor = Color.White
        BtnSelect.FlatAppearance.BorderSize = 1

        PnlBottom.Controls.AddRange(New Control() {TxtSearch, BtnSearch, BtnClear, LblHint, BtnSelect})
        BtnSelect.BringToFront()
        BtnSelect.Location = New Point(PnlBottom.Width - 145, 10)
        BtnSelect.Anchor = AnchorStyles.Top Or AnchorStyles.Right

        Me.Controls.AddRange(New Control() {LblHeader, LblTotal, Dgv, PnlBottom})
    End Sub

    Private Sub LoadDataTimDariDatabase()
        Dgv.Rows.Clear()

        Try
            Using conn As New SQLiteConnection(DB_CONN)
                conn.Open()

                ' --- PERBAIKAN: Ambil data langsung dari team_lengkap agar semua tim terdaftar masuk, 
                ' bukan hanya dari data competitor. Jika ingin kembali ke cara lama, ganti tabel menjadi competitor
                Dim query As String = "SELECT nama_team as team, team_info FROM team_lengkap ORDER BY nama_team ASC"

                Using cmd As New SQLiteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        Dim nomor As Integer = 1
                        While reader.Read()
                            Dgv.Rows.Add(nomor, reader("team").ToString(), reader("team_info").ToString())
                            nomor += 1
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Fallback ke query lama jika tabel team_lengkap belum ada
            Try
                Using conn As New SQLiteConnection(DB_CONN)
                    conn.Open()
                    Dim query As String = "SELECT DISTINCT team, team_info FROM competitor ORDER BY team ASC"
                    Using cmd As New SQLiteCommand(query, conn)
                        Using reader = cmd.ExecuteReader()
                            Dim nomor As Integer = 1
                            While reader.Read()
                                Dgv.Rows.Add(nomor, reader("team").ToString(), reader("team_info").ToString())
                                nomor += 1
                            End While
                        End Using
                    End Using
                End Using
            Catch innerEx As Exception
                MessageBox.Show("Gagal memuat tim: " & innerEx.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Try

        LblTotal.Text = "Total Records : " & Dgv.Rows.Count.ToString()
    End Sub

    Private Sub PilihTim()
        If Dgv.SelectedRows.Count > 0 Then
            Dim selectedTeam As String = Dgv.SelectedRows(0).Cells(1).Value.ToString()
            Dim selectedInfo As String = Dgv.SelectedRows(0).Cells(2).Value.ToString()

            Dim mainFrm As KumiteMainControl = TryCast(Application.OpenForms("KumiteMainControl"), KumiteMainControl)
            If mainFrm IsNot Nothing Then
                mainFrm.UpdateTeamData(selectedTeam, selectedInfo)
            End If

            Dim kataFrm As KataMainControl = TryCast(Application.OpenForms("KataMainControl"), KataMainControl)
            If kataFrm IsNot Nothing Then
                kataFrm.UpdateTeamData(selectedTeam, selectedInfo)
            End If

            Me.Close()
        Else
            MessageBox.Show("Pilih tim terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        PilihTim()
    End Sub

    Private Sub Dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellDoubleClick
        If e.RowIndex >= 0 Then
            PilihTim()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim keyword As String = TxtSearch.Text.ToLower()

        ' --- PERBAIKAN: Melepaskan kaitan memori/fokus pada DataGridView ---
        ' Ini WAJIB dilakukan sebelum menyembunyikan row, jika tidak aplikasi akan crash (Error: "Row associated with the currency manager's position cannot be made invisible.")
        Dgv.CurrentCell = Nothing

        For Each row As DataGridViewRow In Dgv.Rows
            Dim tName As String = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString().ToLower(), "")
            Dim tInfo As String = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString().ToLower(), "")

            If tName.Contains(keyword) OrElse tInfo.Contains(keyword) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtSearch.Text = ""
        ' --- PERBAIKAN: Sama seperti di atas ---
        Dgv.CurrentCell = Nothing

        For Each row As DataGridViewRow In Dgv.Rows
            row.Visible = True
        Next
    End Sub

    ' Fungsi generik: unselect saat diklik
    Private Sub ClearSelectionOnEmptyClick(sender As Object, e As MouseEventArgs)
        Dgv.ClearSelection()
        Dgv.CurrentCell = Nothing
    End Sub

    ' Pasang handler ke semua area yang tidak punya event sendiri
    Private Sub AttachClearSelectionHandlers() Handles MyBase.Load
        AddHandler Me.MouseClick, AddressOf ClearSelectionOnEmptyClick
        AddHandler Dgv.MouseClick, Sub(s, ev)
                                       Dim hit = Dgv.HitTest(ev.X, ev.Y)
                                       If hit.Type = DataGridViewHitTestType.None OrElse
                                          hit.Type = DataGridViewHitTestType.ColumnHeader Then
                                           Dgv.ClearSelection()
                                           Dgv.CurrentCell = Nothing
                                       End If
                                   End Sub
        AddHandler LblHeader.MouseClick, AddressOf ClearSelectionOnEmptyClick
        AddHandler LblTotal.MouseClick, AddressOf ClearSelectionOnEmptyClick
        AddHandler PnlBottom.MouseClick, AddressOf ClearSelectionOnEmptyClick
    End Sub
End Class