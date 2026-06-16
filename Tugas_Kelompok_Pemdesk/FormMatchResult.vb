Imports System.Data.SQLite
Imports System.Drawing

Public Class FormMatchResult

    ' Koneksi string SQLite
    Private Const DB_CONN As String = "Data Source=database.db;Version=3;"

    ' Deklarasi kontrol UI (Kerangka Luar)
    Dim WithEvents dgvMatchResult As New DataGridView()
    Dim WithEvents cmbMatchType As New ComboBox()
    Dim WithEvents chkMatchDate As New CheckBox()
    Dim WithEvents dtpFrom As New DateTimePicker()
    Dim WithEvents dtpTo As New DateTimePicker()
    Dim WithEvents txtSearch As New TextBox()
    Dim WithEvents btnFilter As New Button()
    Dim WithEvents btnDeleteAll As New Button()
    Dim WithEvents chkWithDetail As New CheckBox()
    Dim WithEvents btnExport As New Button()

    Private Sub FormMatchResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Bangun kerangka UI tombol & panel dulu
        InitializeCustomUI()

        ' 2. Buat tabel database jika belum ada
        CreateTableIfNotExists()
        UpgradeDatabase()

        ' 3. Setup tampilan awal filter
        cmbMatchType.SelectedIndex = 0 ' Pilih All Match Type
        dtpFrom.Value = DateTime.Now
        dtpTo.Value = DateTime.Now
        dtpFrom.Enabled = False
        dtpTo.Enabled = False

        ' 4. Setup kolom dan warna dalam DataGridView
        SetupDataGridView()
    End Sub

    Private Sub UpgradeDatabase()
        Try
            Using conn As New SQLiteConnection(DB_CONN)
                conn.Open()
                ' Mencoba menambahkan laci (kolom) status_aka (Kalau sudah ada, akan diskip)
                Try
                    Using cmd As New SQLiteCommand("ALTER TABLE match_result ADD COLUMN status_aka TEXT DEFAULT '';", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                End Try
                ' Mencoba menambahkan laci (kolom) status_ao
                Try
                    Using cmd As New SQLiteCommand("ALTER TABLE match_result ADD COLUMN status_ao TEXT DEFAULT '';", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                End Try
            End Using
        Catch ex As Exception
        End Try
    End Sub
    ' --- 1. FUNGSI PEMBUAT KERANGKA UI ---
    Private Sub InitializeCustomUI()
        Me.Text = "List of Match Result"
        Me.Size = New Size(1100, 600)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Panel Kiri (Filter)
        Dim pnlLeft As New Panel() With {.Dock = DockStyle.Left, .Width = 200, .BackColor = Color.WhiteSmoke}
        Me.Controls.Add(pnlLeft)

        pnlLeft.Controls.Add(New Label() With {.Text = "Match Type", .Location = New Point(10, 10), .AutoSize = True})
        cmbMatchType.Items.AddRange(New String() {"--All Match Type--", "KUMITE", "KATA"})
        cmbMatchType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMatchType.Location = New Point(10, 30)
        cmbMatchType.Width = 170
        pnlLeft.Controls.Add(cmbMatchType)

        chkMatchDate.Text = "Match Date"
        chkMatchDate.Location = New Point(10, 70)
        pnlLeft.Controls.Add(chkMatchDate)

        pnlLeft.Controls.Add(New Label() With {.Text = "From", .Location = New Point(10, 100), .AutoSize = True})
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "yyyy-MM-dd"
        dtpFrom.Location = New Point(10, 120)
        dtpFrom.Width = 170
        pnlLeft.Controls.Add(dtpFrom)

        pnlLeft.Controls.Add(New Label() With {.Text = "To", .Location = New Point(10, 150), .AutoSize = True})
        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.CustomFormat = "yyyy-MM-dd"
        dtpTo.Location = New Point(10, 170)
        dtpTo.Width = 170
        pnlLeft.Controls.Add(dtpTo)

        pnlLeft.Controls.Add(New Label() With {.Text = "Search", .Location = New Point(10, 210), .AutoSize = True})
        txtSearch.Location = New Point(10, 230)
        txtSearch.Width = 170
        pnlLeft.Controls.Add(txtSearch)

        btnFilter.Text = "Filter"
        btnFilter.BackColor = Color.DeepSkyBlue
        btnFilter.ForeColor = Color.White
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.Location = New Point(10, 270)
        btnFilter.Size = New Size(170, 35)
        pnlLeft.Controls.Add(btnFilter)

        btnDeleteAll.Text = "Delete All"
        btnDeleteAll.BackColor = Color.LightSalmon
        btnDeleteAll.FlatStyle = FlatStyle.Flat
        btnDeleteAll.Dock = DockStyle.Bottom
        btnDeleteAll.Height = 40
        pnlLeft.Controls.Add(btnDeleteAll)

        ' Panel Atas (Tombol Export)
        Dim pnlTopRight As New Panel() With {.Dock = DockStyle.Top, .Height = 40, .BackColor = Color.White}
        Me.Controls.Add(pnlTopRight)

        btnExport.Text = "Export to Excel"
        btnExport.Location = New Point(Me.ClientSize.Width - 120, 10)
        btnExport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlTopRight.Controls.Add(btnExport)

        chkWithDetail.Text = "With Match Detail"
        chkWithDetail.Location = New Point(btnExport.Left - 130, 15)
        chkWithDetail.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkWithDetail.AutoSize = True
        pnlTopRight.Controls.Add(chkWithDetail)

        ' Area Tengah (DataGridView)
        dgvMatchResult.Dock = DockStyle.Fill
        Me.Controls.Add(dgvMatchResult)
        dgvMatchResult.BringToFront()
    End Sub

    ' --- 2. FUNGSI PEMBUAT TABEL DATABASE ---
    Private Sub CreateTableIfNotExists()
        Try
            Using conn As New SQLiteConnection(DB_CONN)
                conn.Open()
                Dim sqlCreate As String = "CREATE TABLE IF NOT EXISTS match_result (" &
                                          "id INTEGER PRIMARY KEY AUTOINCREMENT, " &
                                          "tatami INTEGER, match_type TEXT, match_date TEXT, " &
                                          "name_aka TEXT, team_aka TEXT, score_aka INTEGER, " &
                                          "name_ao TEXT, team_ao TEXT, score_ao INTEGER, winner TEXT);"
                Using cmd As New SQLiteCommand(sqlCreate, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal membuat tabel match_result: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 3. FUNGSI PENGATURAN KOLOM DATAGRIDVIEW ---
    Private Sub SetupDataGridView()
        dgvMatchResult.AllowUserToAddRows = False
        dgvMatchResult.ReadOnly = True
        dgvMatchResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMatchResult.RowHeadersVisible = False
        dgvMatchResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMatchResult.Columns.Clear()

        dgvMatchResult.Columns.Add("colNo", "No")
        dgvMatchResult.Columns(0).Width = 35

        Dim btnDelete As New DataGridViewButtonColumn() With {.Name = "colDelete", .HeaderText = "Delete", .Text = "Delete", .UseColumnTextForButtonValue = True, .Width = 60}
        dgvMatchResult.Columns.Add(btnDelete)

        Dim btnView As New DataGridViewButtonColumn() With {.Name = "colView", .HeaderText = "View Details", .Text = "View Detail", .UseColumnTextForButtonValue = True, .Width = 80}
        dgvMatchResult.Columns.Add(btnView)

        dgvMatchResult.Columns.Add("colTatami", "Tatami")
        dgvMatchResult.Columns.Add("colMatchType", "Match Type")
        dgvMatchResult.Columns.Add("colMatchDate", "Match Date")

        dgvMatchResult.Columns.Add("colNameAka", "Name (AKA)")
        dgvMatchResult.Columns.Add("colTeamAka", "Team (AKA)")
        dgvMatchResult.Columns.Add("colScoreAka", "Score (AKA)")

        dgvMatchResult.Columns.Add("colVS", "VS")
        dgvMatchResult.Columns("colVS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvMatchResult.Columns.Add("colNameAo", "Name (AO)")
        dgvMatchResult.Columns.Add("colTeamAo", "Team (AO)")
        dgvMatchResult.Columns.Add("colScoreAo", "Score (AO)")

        dgvMatchResult.Columns.Add("colWinner", "Winner")
        dgvMatchResult.Columns("colWinner").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvMatchResult.Columns("colWinner").DefaultCellStyle.Font = New Font(dgvMatchResult.Font, FontStyle.Bold)

        dgvMatchResult.Columns.Add("colId", "ID")
        dgvMatchResult.Columns("colId").Visible = False
    End Sub

    ' =================================================================
    ' FUNGSI LOAD DATA & FILTERING
    ' =================================================================
    Private Sub LoadData()
        dgvMatchResult.Rows.Clear()

        Try
            Using conn As New SQLiteConnection(DB_CONN)
                conn.Open()

                Dim sqlQuery As String = "SELECT * FROM match_result WHERE 1=1"
                Dim parameters As New List(Of SQLiteParameter)()

                ' Filter Match Type
                If cmbMatchType.SelectedIndex > 0 Then
                    sqlQuery &= " AND match_type = @matchType"
                    parameters.Add(New SQLiteParameter("@matchType", cmbMatchType.SelectedItem.ToString()))
                End If

                ' Filter Tanggal
                If chkMatchDate.Checked Then
                    sqlQuery &= " AND date(match_date) >= date(@dateFrom) AND date(match_date) <= date(@dateTo)"
                    parameters.Add(New SQLiteParameter("@dateFrom", dtpFrom.Value.ToString("yyyy-MM-dd")))
                    parameters.Add(New SQLiteParameter("@dateTo", dtpTo.Value.ToString("yyyy-MM-dd")))
                End If

                ' Filter Pencarian Teks
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    sqlQuery &= " AND (name_aka LIKE @search OR name_ao LIKE @search OR team_aka LIKE @search OR team_ao LIKE @search)"
                    parameters.Add(New SQLiteParameter("@search", "%" & txtSearch.Text.Trim() & "%"))
                End If

                sqlQuery &= " ORDER BY id DESC"

                Using cmd As New SQLiteCommand(sqlQuery, conn)
                    For Each param In parameters
                        cmd.Parameters.Add(param)
                    Next

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        Dim no As Integer = 1
                        While reader.Read()
                            dgvMatchResult.Rows.Add(
                                no,
                                "Delete",
                                "View Detail",
                                reader("tatami").ToString(),
                                reader("match_type").ToString(),
                                reader("match_date").ToString(),
                                reader("name_aka").ToString(),
                                reader("team_aka").ToString(),
                                reader("score_aka").ToString(),
                                "vs",
                                reader("name_ao").ToString(),
                                reader("team_ao").ToString(),
                                reader("score_ao").ToString(),
                                reader("winner").ToString(),
                                reader("id").ToString()
                            )
                            no += 1
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- EVENT HANDLER UI ---

    ' Panggil LoadData saat form pertama kali tampil
    Private Sub FormMatchResult_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadData()
    End Sub

    ' Saat tombol Filter di-klik
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        LoadData()
    End Sub

    ' Saat mengetik di textbox pencarian lalu menekan Enter
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadData()
            e.SuppressKeyPress = True
        End If
    End Sub

    ' Aktifkan/Matikan filter tanggal
    Private Sub chkMatchDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkMatchDate.CheckedChanged
        dtpFrom.Enabled = chkMatchDate.Checked
        dtpTo.Enabled = chkMatchDate.Checked
    End Sub

    ' Pewarnaan baris otomatis (Merah untuk AKA, Biru untuk AO)
    Private Sub dgvMatchResult_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMatchResult.CellFormatting
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = dgvMatchResult.Columns("colNameAka").Index OrElse e.ColumnIndex = dgvMatchResult.Columns("colTeamAka").Index OrElse e.ColumnIndex = dgvMatchResult.Columns("colScoreAka").Index Then
                e.CellStyle.BackColor = Color.FromArgb(255, 192, 192)
            End If

            If e.ColumnIndex = dgvMatchResult.Columns("colVS").Index Then
                e.CellStyle.BackColor = Color.FromArgb(192, 255, 192)
                If e.Value Is Nothing OrElse String.IsNullOrEmpty(e.Value.ToString()) Then e.Value = "vs"
            End If

            If e.ColumnIndex = dgvMatchResult.Columns("colNameAo").Index OrElse e.ColumnIndex = dgvMatchResult.Columns("colTeamAo").Index OrElse e.ColumnIndex = dgvMatchResult.Columns("colScoreAo").Index Then
                e.CellStyle.BackColor = Color.FromArgb(192, 192, 255)
            End If

            If e.ColumnIndex = dgvMatchResult.Columns("colWinner").Index Then
                e.CellStyle.BackColor = Color.LightGoldenrodYellow
                If e.Value IsNot Nothing Then
                    If e.Value.ToString() = "AKA" Then
                        e.CellStyle.ForeColor = Color.Red
                    ElseIf e.Value.ToString() = "AO" Then
                        e.CellStyle.ForeColor = Color.Blue
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub dgvMatchResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMatchResult.CellContentClick
        If e.RowIndex >= 0 Then
            ' LOGIKA TOMBOL VIEW DETAIL
            If e.ColumnIndex = dgvMatchResult.Columns("colView").Index Then
                Dim id As String = dgvMatchResult.Rows(e.RowIndex).Cells("colId").Value.ToString()
                Dim matchType As String = dgvMatchResult.Rows(e.RowIndex).Cells("colMatchType").Value.ToString()
                Dim nameAka As String = dgvMatchResult.Rows(e.RowIndex).Cells("colNameAka").Value.ToString()
                Dim teamAka As String = dgvMatchResult.Rows(e.RowIndex).Cells("colTeamAka").Value.ToString()
                Dim scoreAka As String = dgvMatchResult.Rows(e.RowIndex).Cells("colScoreAka").Value.ToString()

                Dim nameAo As String = dgvMatchResult.Rows(e.RowIndex).Cells("colNameAo").Value.ToString()
                Dim teamAo As String = dgvMatchResult.Rows(e.RowIndex).Cells("colTeamAo").Value.ToString()
                Dim scoreAo As String = dgvMatchResult.Rows(e.RowIndex).Cells("colScoreAo").Value.ToString()
                Dim winner As String = dgvMatchResult.Rows(e.RowIndex).Cells("colWinner").Value.ToString()

                ' Bongkar Database untuk melihat ada/tidaknya Hantei & Penalti
                Dim statusAka As String = ""
                Dim statusAo As String = ""
                Try
                    Using conn As New SQLiteConnection(DB_CONN)
                        conn.Open()
                        Dim sql As String = "SELECT status_aka, status_ao FROM match_result WHERE id = @id"
                        Using cmd As New SQLiteCommand(sql, conn)
                            cmd.Parameters.AddWithValue("@id", id)
                            Using reader As SQLiteDataReader = cmd.ExecuteReader()
                                If reader.Read() Then
                                    If Not IsDBNull(reader("status_aka")) Then statusAka = reader("status_aka").ToString()
                                    If Not IsDBNull(reader("status_ao")) Then statusAo = reader("status_ao").ToString()
                                End If
                            End Using
                        End Using
                    End Using
                Catch ex As Exception
                End Try

                ' Tampilkan Pop up dengan Label Hantei/Penalti
                ShowDetailPopup(matchType, nameAka, teamAka, scoreAka, nameAo, teamAo, scoreAo, winner, statusAka, statusAo)
            End If

            ' LOGIKA TOMBOL DELETE
            If e.ColumnIndex = dgvMatchResult.Columns("colDelete").Index Then
                Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data pertandingan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim id As String = dgvMatchResult.Rows(e.RowIndex).Cells("colId").Value.ToString()
                    HapusData(id)
                End If
            End If
        End If
    End Sub

    ' Fungsi Pembuat Desain Pop-Up
    Private Sub ShowDetailPopup(matchType As String, nAka As String, tAka As String, sAka As String, nAo As String, tAo As String, sAo As String, winner As String, statusAka As String, statusAo As String)
        Dim frm As New Form()
        frm.Text = "Scoring Result - " & matchType
        frm.Size = New Size(680, 480)
        frm.StartPosition = FormStartPosition.CenterParent
        frm.FormBorderStyle = FormBorderStyle.FixedDialog
        frm.MaximizeBox = False : frm.MinimizeBox = False
        frm.BackColor = Color.FromArgb(240, 240, 240)

        ' --- PANEL AKA (MERAH) ---
        Dim pnlAka As New Panel() With {.Location = New Point(10, 10), .Size = New Size(640, 160), .BackColor = Color.White, .BorderStyle = BorderStyle.FixedSingle}
        pnlAka.Controls.Add(New Label() With {.Text = "AKA", .BackColor = Color.Crimson, .ForeColor = Color.White, .Location = New Point(0, 0), .Size = New Size(40, 160), .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 12, FontStyle.Bold)})

        If winner = "AKA" Then pnlAka.Controls.Add(New Label() With {.Text = "WINNER", .BackColor = Color.Gold, .Location = New Point(40, 0), .Size = New Size(600, 25), .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 10, FontStyle.Bold)})

        Dim topAka As Integer = If(winner = "AKA", 40, 20)
        pnlAka.Controls.Add(New Label() With {.Text = "Name", .Location = New Point(60, topAka), .AutoSize = True})
        pnlAka.Controls.Add(New TextBox() With {.Text = nAka, .Location = New Point(120, topAka - 3), .Width = 230, .ReadOnly = True})
        pnlAka.Controls.Add(New Label() With {.Text = "Team", .Location = New Point(60, topAka + 30), .AutoSize = True})
        pnlAka.Controls.Add(New TextBox() With {.Text = tAka, .Location = New Point(120, topAka + 27), .Width = 230, .ReadOnly = True})
        pnlAka.Controls.Add(New Label() With {.Text = "Total Score", .Location = New Point(450, topAka + 30), .AutoSize = True, .Font = New Font("Segoe UI", 10)})
        pnlAka.Controls.Add(New Label() With {.Text = sAka, .Location = New Point(530, topAka + 15), .AutoSize = True, .Font = New Font("Segoe UI", 26, FontStyle.Bold)})

        ' Memunculkan Status/Penalti AKA jika ada
        If Not String.IsNullOrWhiteSpace(statusAka) Then
            Dim badgeAka As New Label() With {.Text = statusAka, .Location = New Point(120, topAka + 65), .Size = New Size(130, 25), .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 9, FontStyle.Bold), .BorderStyle = BorderStyle.FixedSingle}
            If statusAka = "HANTEI" Then badgeAka.BackColor = Color.Gold
            If statusAka = "KIKEN" OrElse statusAka = "SHIKKAKU" OrElse statusAka = "DISQUALIFICATION" Then badgeAka.BackColor = Color.Yellow
            If statusAka = "KNOCKED OUT" Then badgeAka.BackColor = Color.Crimson : badgeAka.ForeColor = Color.White
            pnlAka.Controls.Add(badgeAka)
        End If

        ' --- PANEL AO (BIRU) ---
        Dim pnlAo As New Panel() With {.Location = New Point(10, 180), .Size = New Size(640, 160), .BackColor = Color.White, .BorderStyle = BorderStyle.FixedSingle}
        pnlAo.Controls.Add(New Label() With {.Text = "AO", .BackColor = Color.DodgerBlue, .ForeColor = Color.White, .Location = New Point(0, 0), .Size = New Size(40, 160), .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 12, FontStyle.Bold)})

        If winner = "AO" Then pnlAo.Controls.Add(New Label() With {.Text = "WINNER", .BackColor = Color.Gold, .Location = New Point(40, 0), .Size = New Size(600, 25), .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 10, FontStyle.Bold)})

        Dim topAo As Integer = If(winner = "AO", 40, 20)
        pnlAo.Controls.Add(New Label() With {.Text = "Name", .Location = New Point(60, topAo), .AutoSize = True})
        pnlAo.Controls.Add(New TextBox() With {.Text = nAo, .Location = New Point(120, topAo - 3), .Width = 230, .ReadOnly = True})
        pnlAo.Controls.Add(New Label() With {.Text = "Team", .Location = New Point(60, topAo + 30), .AutoSize = True})
        pnlAo.Controls.Add(New TextBox() With {.Text = tAo, .Location = New Point(120, topAo + 27), .Width = 230, .ReadOnly = True})
        pnlAo.Controls.Add(New Label() With {.Text = "Total Score", .Location = New Point(450, topAo + 30), .AutoSize = True, .Font = New Font("Segoe UI", 10)})
        pnlAo.Controls.Add(New Label() With {.Text = sAo, .Location = New Point(530, topAo + 15), .AutoSize = True, .Font = New Font("Segoe UI", 26, FontStyle.Bold)})

        ' Memunculkan Status/Penalti AO jika ada
        If Not String.IsNullOrWhiteSpace(statusAo) Then
            Dim badgeAo As New Label() With {.Text = statusAo, .Location = New Point(120, topAo + 65), .Size = New Size(130, 25), .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 9, FontStyle.Bold), .BorderStyle = BorderStyle.FixedSingle}
            If statusAo = "HANTEI" Then badgeAo.BackColor = Color.Gold
            If statusAo = "KIKEN" OrElse statusAo = "SHIKKAKU" OrElse statusAo = "DISQUALIFICATION" Then badgeAo.BackColor = Color.Yellow
            If statusAo = "KNOCKED OUT" Then badgeAo.BackColor = Color.DodgerBlue : badgeAo.ForeColor = Color.White
            pnlAo.Controls.Add(badgeAo)
        End If

        Dim btnClose As New Button() With {.Text = "Close", .Location = New Point(550, 390), .Size = New Size(100, 35)}
        AddHandler btnClose.Click, Sub(s, ev) frm.Close()

        frm.Controls.Add(pnlAka)
        frm.Controls.Add(pnlAo)
        frm.Controls.Add(btnClose)
        frm.ShowDialog()
    End Sub
    ' Fungsi untuk menghapus 1 baris berdasarkan ID
    Private Sub HapusData(id As String)
        Try
            Using conn As New SQLiteConnection(DB_CONN)
                conn.Open()
                Dim sql As String = "DELETE FROM match_result WHERE id = @id"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData() ' Segarkan tabel setelah menghapus
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event saat tombol Delete All di-klik
    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        Dim result As DialogResult = MessageBox.Show("PERINGATAN KERAS! Anda yakin ingin menghapus SEMUA riwayat pertandingan? Tindakan ini tidak bisa dibatalkan.", "Hapus Semua Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Using conn As New SQLiteConnection(DB_CONN)
                    conn.Open()
                    Dim sql As String = "DELETE FROM match_result" ' Menghapus isi seluruh tabel
                    Using cmd As New SQLiteCommand(sql, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Semua riwayat pertandingan berhasil dihanguskan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData() ' Segarkan tabel agar kosong
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus semua data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dgvMatchResult.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk diekspor ke Excel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        ' 1. Munculkan jendela "Save As" terlebih dahulu
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
        sfd.Title = "Simpan Hasil Pertandingan"
        sfd.FileName = "Rekap_Pertandingan_" & DateTime.Now.ToString("dd_MM_yyyy") & ".xlsx"
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                ' Ubah kursor jadi loading
                Me.Cursor = Cursors.WaitCursor

                ' Buka Excel di latar belakang (tak terlihat user)
                Dim excelApp As Object = CreateObject("Excel.Application")
                excelApp.Visible = False
                excelApp.DisplayAlerts = False ' Matikan pop-up peringatan Excel

                Dim workbook As Object = excelApp.Workbooks.Add()
                Dim worksheet As Object = workbook.Sheets(1)
                worksheet.Name = "Rekap Pertandingan"
                ' --- PROSES DESAIN TABEL (SAMA SEPERTI SEBELUMNYA) ---
                Dim headers As String() = {"No", "Tatami", "Match Type", "Tanggal", "Nama AKA", "Tim AKA", "Skor AKA", "Nama AO", "Tim AO", "Skor AO", "Pemenang"}
                For col As Integer = 0 To headers.Length - 1
                    worksheet.Cells(1, col + 1).Value = headers(col)
                    worksheet.Cells(1, col + 1).Interior.Color = ColorTranslator.ToOle(Color.FromArgb(0, 120, 215))
                    worksheet.Cells(1, col + 1).Font.Color = ColorTranslator.ToOle(Color.White)
                    worksheet.Cells(1, col + 1).Font.Bold = True
                    worksheet.Cells(1, col + 1).HorizontalAlignment = -4108
                Next
                Dim excelRow As Integer = 2
                For Each row As DataGridViewRow In dgvMatchResult.Rows
                    If Not row.IsNewRow Then
                        worksheet.Cells(excelRow, 1).Value = row.Cells("colNo").Value?.ToString()
                        worksheet.Cells(excelRow, 2).Value = row.Cells("colTatami").Value?.ToString()
                        worksheet.Cells(excelRow, 3).Value = row.Cells("colMatchType").Value?.ToString()
                        worksheet.Cells(excelRow, 4).Value = row.Cells("colMatchDate").Value?.ToString()
                        worksheet.Range(worksheet.Cells(excelRow, 1), worksheet.Cells(excelRow, 4)).HorizontalAlignment = -4108

                        worksheet.Cells(excelRow, 5).Value = row.Cells("colNameAka").Value?.ToString()
                        worksheet.Cells(excelRow, 6).Value = row.Cells("colTeamAka").Value?.ToString()
                        worksheet.Cells(excelRow, 7).Value = row.Cells("colScoreAka").Value?.ToString()
                        Dim akaColor As Integer = ColorTranslator.ToOle(Color.FromArgb(255, 210, 210))
                        worksheet.Range(worksheet.Cells(excelRow, 5), worksheet.Cells(excelRow, 7)).Interior.Color = akaColor
                        worksheet.Cells(excelRow, 7).Font.Bold = True
                        worksheet.Cells(excelRow, 7).HorizontalAlignment = -4108
                        worksheet.Cells(excelRow, 8).Value = row.Cells("colNameAo").Value?.ToString()
                        worksheet.Cells(excelRow, 9).Value = row.Cells("colTeamAo").Value?.ToString()
                        worksheet.Cells(excelRow, 10).Value = row.Cells("colScoreAo").Value?.ToString()
                        Dim aoColor As Integer = ColorTranslator.ToOle(Color.FromArgb(210, 228, 255))
                        worksheet.Range(worksheet.Cells(excelRow, 8), worksheet.Cells(excelRow, 10)).Interior.Color = aoColor
                        worksheet.Cells(excelRow, 10).Font.Bold = True
                        worksheet.Cells(excelRow, 10).HorizontalAlignment = -4108
                        Dim winner As String = row.Cells("colWinner").Value?.ToString()
                        worksheet.Cells(excelRow, 11).Value = winner
                        worksheet.Cells(excelRow, 11).Font.Bold = True
                        worksheet.Cells(excelRow, 11).HorizontalAlignment = -4108
                        If winner = "AKA" Then
                            worksheet.Cells(excelRow, 11).Font.Color = ColorTranslator.ToOle(Color.Red)
                        ElseIf winner = "AO" Then
                            worksheet.Cells(excelRow, 11).Font.Color = ColorTranslator.ToOle(Color.Blue)
                        End If
                        excelRow += 1
                    End If
                Next
                Dim fullRange As Object = worksheet.Range(worksheet.Cells(1, 1), worksheet.Cells(excelRow - 1, 11))
                fullRange.EntireColumn.AutoFit()
                fullRange.Borders.LineStyle = 1
                workbook.SaveAs(sfd.FileName)
                workbook.Close()
                excelApp.Quit()

                ' Bebaskan memori
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
                Me.Cursor = Cursors.Default

                ' 4. Tampilkan pesan berhasil
                MessageBox.Show("Data berhasil diekspor ke Excel!", "Export Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MessageBox.Show("Gagal mengekspor data." & vbCrLf & "Pesan Error: " & ex.Message, "Error Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class