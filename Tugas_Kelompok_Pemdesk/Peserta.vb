Imports System.Data.SQLite
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections.Generic

Public Class Peserta

    Private editRowIndex As Integer = -1
    Private selectedImagePath As String = ""
    Private isFormLoaded As Boolean = False


    ' 1. FORM LOAD

    Private Sub Peserta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isFormLoaded Then Return
        isFormLoaded = True

        gridCompetitors.AllowUserToAddRows = False
        gridCompetitors.ReadOnly = True
        gridCompetitors.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        gridTeams.AllowUserToAddRows = False
        gridTeams.ReadOnly = True
        gridTeams.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gridTeams.RowTemplate.Height = 110

        If Not gridCompetitors.Columns.Contains("ColNo") Then
            Dim colNo As New DataGridViewTextBoxColumn()
            colNo.Name = "ColNo"
            colNo.HeaderText = "No"
            colNo.Width = 35
            gridCompetitors.Columns.Insert(0, colNo)
        End If


        If gridCompetitors.Columns.Contains("ColCompPict") Then
            Dim idx As Integer = gridCompetitors.Columns("ColCompPict").Index
            gridCompetitors.Columns.Remove("ColCompPict")

            Dim imgCol As New DataGridViewImageColumn()
            imgCol.Name = "ColCompPict"
            imgCol.HeaderText = "Comp. Pict"
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            imgCol.Width = 80
            gridCompetitors.Columns.Insert(idx, imgCol)
        End If

        picCircle.Image = GetDefaultProfileImage()
        UpdateTotalRecords()
        RefreshLeftTeamGrid()
        LoadTeamsToComboBox()
        LoadDataPeserta()

        If Not gridCompetitors.Columns.Contains("ColCompPictPath") Then
            Dim pathCol As New DataGridViewTextBoxColumn()
            pathCol.Name = "ColCompPictPath"
            pathCol.Visible = False ' Kita sembunyikan dari layar agar tetap rapi
            gridCompetitors.Columns.Add(pathCol)
        End If
    End Sub

    Private Sub LoadTeamsToComboBox()
        cmbTeam.Items.Clear()

        ' 1. AMBIL DARI DATABASE PERMANEN (Tabel team_lengkap)
        Try
            Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                conn.Open()
                ' Kita coba ambil dari tabel team_lengkap yang baru kita buat di form Team
                Dim query As String = "SELECT nama_team FROM team_lengkap"
                Using cmd As New System.Data.SQLite.SQLiteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim tName = reader("nama_team").ToString()
                            If Not cmbTeam.Items.Contains(tName) Then
                                cmbTeam.Items.Add(tName)
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Jika tabel team_lengkap belum ada, kode akan lanjut ke langkah 2
        End Try

        ' 2. AMBIL DARI TIM YANG SUDAH TERLANJUR ADA DI TABEL (Cadangan)
        ' Ini memastikan tim seperti "sss" atau "qqqaa" di layar Anda ikut masuk ke dropdown
        For Each row As DataGridViewRow In gridCompetitors.Rows
            If Not row.IsNewRow AndAlso row.Cells("ColTeamRight").Value IsNot Nothing Then
                Dim tName = row.Cells("ColTeamRight").Value.ToString()
                If Not cmbTeam.Items.Contains(tName) Then
                    cmbTeam.Items.Add(tName)
                End If
            End If
        Next
    End Sub
    Private Sub gridCompetitors_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles gridCompetitors.DataError
        e.ThrowException = False
    End Sub


    ' 2. LOGIKA ADD / UPDATE & AUTO-FILTER (VERSI DATABASE BARU)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text.Trim() = "" Or cmbTeam.SelectedIndex = -1 Then
            MessageBox.Show("Nama dan Tim wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim teamName As String = cmbTeam.SelectedItem.ToString()
        ' Jika gambar kosong, jadikan "No Image"
        Dim imgPath As String = If(selectedImagePath <> "", selectedImagePath, "No Image")
        Dim displayImage As Image = GetSafeCompImage(imgPath)

        If editRowIndex >= 0 Then
            ' ======================================================
            ' --- LOGIKA UPDATE (PERMANEN KE DATABASE & LAYAR) ---
            ' ======================================================
            Try
                ' 1. Ambil nama dan tim yang LAMA sebelum diubah (sebagai penanda untuk dicari di database)
                Dim oldName As String = gridCompetitors.Rows(editRowIndex).Cells("ColName").Value.ToString()
                Dim oldTeam As String = gridCompetitors.Rows(editRowIndex).Cells("ColTeamRight").Value.ToString()

                ' 2. Update ke Database SQLite!
                Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                    conn.Open()
                    ' Update nama, tim, info, dan foto yang baru berdasarkan nama lama
                    Dim query As String = "UPDATE competitor SET name = @newName, team = @newTeam, team_info = @newInfo, pict_path = @newPict WHERE name = @oldName AND team = @oldTeam"
                    Using cmd As New System.Data.SQLite.SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@newName", txtName.Text.Trim())
                        cmd.Parameters.AddWithValue("@newTeam", teamName)
                        cmd.Parameters.AddWithValue("@newInfo", txtTeamInfo.Text.Trim())
                        cmd.Parameters.AddWithValue("@newPict", imgPath) ' Kirim alamat gambar

                        cmd.Parameters.AddWithValue("@oldName", oldName)
                        cmd.Parameters.AddWithValue("@oldTeam", oldTeam)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' 3. Update di tabel layar (DataGridView)
                Dim row As DataGridViewRow = gridCompetitors.Rows(editRowIndex)
                row.Cells("ColName").Value = txtName.Text.Trim()
                row.Cells("ColTeamRight").Value = teamName
                row.Cells("ColTeamInfoRight").Value = txtTeamInfo.Text.Trim()
                row.Cells("ColCompPict").Value = displayImage
                row.Cells("ColCompPictPath").Value = imgPath ' Simpan alamat gambar di layar

                editRowIndex = -1 ' Reset mode edit

            Catch ex As Exception
                MessageBox.Show("Gagal mengupdate database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            ' ======================================================
            ' --- LOGIKA SIMPAN BARU (PERMANEN KE DATABASE & LAYAR) ---
            ' ======================================================
            Try
                ' 1. Simpan ke Database SQLite!
                Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                    conn.Open()
                    ' Sekarang kita minta 4 wadah (name, team, info, pict_path)
                    Dim query As String = "INSERT INTO competitor (name, team, team_info, pict_path) VALUES (@name, @team, @info, @pict)"
                    Using cmd As New System.Data.SQLite.SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                        cmd.Parameters.AddWithValue("@team", teamName)
                        cmd.Parameters.AddWithValue("@info", txtTeamInfo.Text.Trim())
                        cmd.Parameters.AddWithValue("@pict", imgPath) ' Mantra penyimpan gambar!
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' 2. Tampilkan juga di tabel layar
                gridCompetitors.Rows.Add("", "❌", "📝", txtName.Text.Trim(), teamName, txtTeamInfo.Text.Trim(), displayImage, imgPath)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ' --- REFRESH UI SETELAH SIMPAN/UPDATE ---
        UpdateRowNumbers()
        UpdateTotalRecords()
        RefreshLeftTeamGrid()

        ' Filter tampilan sesuai tim yang baru dipilih
        gridCompetitors.CurrentCell = Nothing
        For Each row As DataGridViewRow In gridCompetitors.Rows
            If Not row.IsNewRow Then
                Dim rowTeam As String = row.Cells("ColTeamRight").Value.ToString()
                row.Visible = (rowTeam = teamName)
            End If
        Next

        MessageBox.Show("Data dan Gambar berhasil disimpan secara permanen!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearInput()
    End Sub


    ' 3. FUNGSI EXPORT & IMPORT

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File|*.csv"
        sfd.FileName = "Data_Peserta.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Using sw As New StreamWriter(sfd.FileName)
                    sw.WriteLine("Name;Team")
                    For Each row As DataGridViewRow In gridCompetitors.Rows
                        If Not row.IsNewRow Then
                            Dim n = row.Cells("ColName").Value.ToString().Replace(";", " ")
                            Dim t = row.Cells("ColTeamRight").Value.ToString().Replace(";", " ")
                            sw.WriteLine(n & ";" & t)
                        End If
                    Next
                End Using
                MessageBox.Show("Export Berhasil!", "Sukses")
            Catch ex As Exception
                MessageBox.Show("Error Export: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim ofd As New OpenFileDialog() With {.Filter = "CSV File|*.csv"}
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Using sr As New StreamReader(ofd.FileName)

                    Dim headerLine As String = sr.ReadLine()
                    If headerLine Is Nothing Then Return


                    Dim separator As Char = If(headerLine.Contains(";"), ";"c, ","c)
                    Dim headers As String() = headerLine.Split(separator)


                    Dim nameColIdx As Integer = -1
                    Dim teamColIdx As Integer = -1

                    For i As Integer = 0 To headers.Length - 1
                        Dim hText As String = headers(i).Trim().ToLower()
                        If hText = "name" Or hText = "nama" Or hText = "peserta" Then
                            nameColIdx = i
                        ElseIf hText = "team" Or hText = "tim" Or hText = "kelompok" Then
                            teamColIdx = i
                        End If
                    Next


                    If nameColIdx = -1 Or teamColIdx = -1 Then
                        MessageBox.Show("Gagal Impor! Pastikan file Excel memiliki judul kolom 'Name' dan 'Team'.", "Format Salah", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If


                    Dim importCount As Integer = 0
                    While Not sr.EndOfStream
                        Dim line As String = sr.ReadLine()
                        Dim data = line.Split(separator)

                        If data.Length > Math.Max(nameColIdx, teamColIdx) Then
                            Dim valName As String = data(nameColIdx).Trim()
                            Dim valTeam As String = data(teamColIdx).Trim()

                            If valName <> "" And valTeam <> "" Then
                                gridCompetitors.Rows.Add("", "❌", "📝", valName, valTeam, "", GetSafeCompImage("No Image"), "No Image")
                                importCount += 1
                            End If
                        End If
                    End While

                    ' 4. FINISHING
                    If importCount > 0 Then
                        UpdateRowNumbers()
                        UpdateTotalRecords()
                        RefreshLeftTeamGrid()
                        MessageBox.Show(importCount & " Data berhasil diimpor dengan akurat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error Import: " & ex.Message)
            End Try
        End If
    End Sub


    ' 4. PENCARIAN & FILTERING

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim key = txtSearch.Text.ToLower().Trim()
        gridCompetitors.CurrentCell = Nothing
        For Each row As DataGridViewRow In gridCompetitors.Rows
            If Not row.IsNewRow Then
                Dim n = If(row.Cells("ColName").Value IsNot Nothing, row.Cells("ColName").Value.ToString().ToLower(), "")
                Dim t = If(row.Cells("ColTeamRight").Value IsNot Nothing, row.Cells("ColTeamRight").Value.ToString().ToLower(), "")
                row.Visible = (key = "" OrElse n.Contains(key) OrElse t.Contains(key))
            End If
        Next
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        For Each row As DataGridViewRow In gridCompetitors.Rows
            If Not row.IsNewRow Then
                row.Visible = True
            End If
        Next
    End Sub


    ' 5. FUNGSI PENOMORAN & REFRESH UI

    Private Sub UpdateRowNumbers()
        Dim counts As New Dictionary(Of String, Integer)
        For Each row As DataGridViewRow In gridCompetitors.Rows
            If Not row.IsNewRow Then
                Dim t = row.Cells("ColTeamRight").Value.ToString()
                If Not counts.ContainsKey(t) Then
                    counts.Add(t, 1)
                Else
                    counts(t) += 1
                End If
                row.Cells("ColNo").Value = counts(t).ToString()
            End If
        Next
    End Sub

    Private Sub UpdateTotalRecords()
        lblTotal.Text = "Total Records : " & gridCompetitors.Rows.Count.ToString()
    End Sub

    Private Sub RefreshLeftTeamGrid()
        gridTeams.Rows.Clear()
        Dim uniqueTeams As New List(Of String)
        For Each row As DataGridViewRow In gridCompetitors.Rows
            If Not row.IsNewRow Then
                Dim t = row.Cells("ColTeamRight").Value.ToString()
                If Not uniqueTeams.Contains(t) Then
                    uniqueTeams.Add(t)
                End If
            End If
        Next
        For Each t In uniqueTeams
            Dim idx = gridTeams.Rows.Add(t)
            gridTeams.Rows(idx).Height = 110
        Next
    End Sub


    Private Function GetDefaultProfileImage() As Image
        Dim bmp As New Bitmap(100, 100)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.Transparent)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.FillEllipse(Brushes.Black, 35, 20, 30, 30)
            Dim path As New GraphicsPath()
            path.AddArc(20, 55, 60, 60, 180, 180)
            g.FillPath(Brushes.Black, path)
        End Using
        Return bmp
    End Function

    Private Function GetSafeCompImage(path As String) As Image
        If Not File.Exists(path) Then Return GetDefaultProfileImage()
        Try
            Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
                Dim img = Image.FromStream(fs)
                Dim sz = Math.Min(img.Width, img.Height)
                Dim res As New Bitmap(sz, sz)
                Using g As Graphics = Graphics.FromImage(res)
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic
                    g.DrawImage(img, New Rectangle(0, 0, sz, sz), New Rectangle((img.Width - sz) \ 2, (img.Height - sz) \ 2, sz, sz), GraphicsUnit.Pixel)
                End Using
                Return res
            End Using
        Catch
            Return GetDefaultProfileImage()
        End Try
    End Function

    Private Sub gridTeams_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles gridTeams.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
            e.Handled = True
            e.PaintBackground(e.CellBounds, True)

            Dim tName = If(e.Value IsNot Nothing, e.Value.ToString(), "")
            Dim textBrush = If((e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected, Brushes.White, Brushes.Black)
            e.Graphics.DrawString(tName, New Font("Segoe UI", 9, FontStyle.Bold), textBrush, New Rectangle(e.CellBounds.X, e.CellBounds.Y + 5, e.CellBounds.Width, 20), New StringFormat() With {.Alignment = StringAlignment.Center})

            Dim teamImg As Image = Nothing

            ' --- PROTEKSI AGAR TIDAK ERROR (OBJECT REFERENCE) ---
            Try
                ' Pastikan form Team dan tabelnya tidak kosong sebelum diakses
                If Dashboard.frmTeamApp IsNot Nothing AndAlso Dashboard.frmTeamApp.gridEntriesTeam IsNot Nothing Then
                    For Each r As DataGridViewRow In Dashboard.frmTeamApp.gridEntriesTeam.Rows
                        If Not r.IsNewRow AndAlso r.Cells("ColTeamGrid").Value IsNot Nothing Then
                            If r.Cells("ColTeamGrid").Value.ToString() = tName Then
                                teamImg = TryCast(r.Cells("ColTeamPictGrid").Value, Image)
                                Exit For
                            End If
                        End If
                    Next
                End If
            Catch
                ' Jika error, biarkan teamImg tetap Nothing agar tidak crash
            End Try

            Dim dRect = New Rectangle(e.CellBounds.X + (e.CellBounds.Width - 70) \ 2, e.CellBounds.Y + 30, 70, 70)
            If teamImg IsNot Nothing Then
                e.Graphics.DrawImage(teamImg, dRect)
            Else
                ' Jika gambar tidak ditemukan, gambar kotak abu-abu polos (tanpa crash)
                e.Graphics.FillRectangle(Brushes.LightGray, dRect)
            End If
            e.Graphics.DrawRectangle(Pens.DarkGray, dRect)
        End If
    End Sub


    ' 7. INTERAKSI TABEL & FORM

    Private Sub gridTeams_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridTeams.CellClick
        If e.RowIndex >= 0 Then
            Dim filter = gridTeams.Rows(e.RowIndex).Cells(0).Value.ToString()
            For Each row As DataGridViewRow In gridCompetitors.Rows
                If Not row.IsNewRow Then
                    row.Visible = (row.Cells("ColTeamRight").Value.ToString() = filter)
                End If
            Next
        End If
    End Sub

    Private Sub gridCompetitors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridCompetitors.CellContentClick
        If e.RowIndex >= 0 Then
            ' JIKA TOMBOL DELETE (❌) DIKLIK
            If e.ColumnIndex = gridCompetitors.Columns("ColDel").Index Then
                If MessageBox.Show("Hapus peserta ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    ' 1. Ambil nama dan tim dari baris yang diklik untuk mencari target di database
                    Dim row = gridCompetitors.Rows(e.RowIndex)
                    Dim n = row.Cells("ColName").Value.ToString()
                    Dim t = row.Cells("ColTeamRight").Value.ToString()

                    ' 2. Hapus target tersebut dari database permanen
                    Try
                        Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                            conn.Open()
                            Dim query As String = "DELETE FROM competitor WHERE name = @name AND team = @team"
                            Using cmd As New System.Data.SQLite.SQLiteCommand(query, conn)
                                cmd.Parameters.AddWithValue("@name", n)
                                cmd.Parameters.AddWithValue("@team", t)
                                cmd.ExecuteNonQuery()
                            End Using
                        End Using
                    Catch ex As Exception
                    End Try

                    ' 3. Hapus dari layar
                    gridCompetitors.Rows.RemoveAt(e.RowIndex)
                    UpdateRowNumbers()
                    UpdateTotalRecords()
                    RefreshLeftTeamGrid()
                End If

                ' JIKA TOMBOL EDIT (📝) DIKLIK
            ElseIf e.ColumnIndex = gridCompetitors.Columns("ColEdit").Index Then
                Dim row = gridCompetitors.Rows(e.RowIndex)
                txtName.Text = row.Cells("ColName").Value.ToString()
                cmbTeam.SelectedItem = row.Cells("ColTeamRight").Value.ToString()

                ' Ambil info tim jika ada
                If row.Cells("ColTeamInfoRight").Value IsNot Nothing Then
                    txtTeamInfo.Text = row.Cells("ColTeamInfoRight").Value.ToString()
                End If

                ' Membaca alamat gambar dengan aman dari kolom tersembunyi
                If row.Cells("ColCompPictPath").Value IsNot Nothing Then
                    selectedImagePath = row.Cells("ColCompPictPath").Value.ToString()
                Else
                    selectedImagePath = "No Image"
                End If

                ' Tampilkan gambar ke lingkaran preview
                picCircle.Image = GetSafeCompImage(selectedImagePath)
                editRowIndex = e.RowIndex
                btnAdd.Text = "Update"
            End If
        End If
    End Sub

    Private Sub ClearFocus_Click(sender As Object, e As EventArgs) Handles MyBase.Click, panelTop.Click, panelBottom.Click
        lblTitle.Focus()
        gridCompetitors.ClearSelection()
        gridTeams.ClearSelection()
        For Each row As DataGridViewRow In gridCompetitors.Rows
            If Not row.IsNewRow Then row.Visible = True
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub ClearInput()
        txtName.Clear()
        cmbTeam.SelectedIndex = -1
        txtTeamInfo.Clear()
        picCircle.Image = GetDefaultProfileImage()
        selectedImagePath = ""
        editRowIndex = -1
        btnAdd.Text = "Add"
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        If MessageBox.Show("Hapus Semua Data Peserta?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            ' --- 1. HAPUS SEMUA DATA DARI DATABASE SQLITE ---
            Try
                Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                    conn.Open()
                    Dim query As String = "DELETE FROM competitor"
                    Using cmd As New System.Data.SQLite.SQLiteCommand(query, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data di database: " & ex.Message)
            End Try

            ' --- 2. KOSONGKAN TAMPILAN DI LAYAR ---
            gridCompetitors.Rows.Clear()
            UpdateTotalRecords()
            RefreshLeftTeamGrid()

            MessageBox.Show("Seluruh data peserta berhasil dihapus secara permanen!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSelectPic_Click(sender As Object, e As EventArgs) Handles btnSelectPic.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Images|*.jpg;*.png"
        If ofd.ShowDialog() = DialogResult.OK Then
            selectedImagePath = ofd.FileName
            picCircle.Image = GetSafeCompImage(selectedImagePath)
        End If
    End Sub

    Private Sub btnEditTeam_Click_1(sender As Object, e As EventArgs) Handles btnEditTeam.Click
        Dashboard.frmTeamApp.ShowDialog()
    End Sub

    Private Sub cmbTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeam.SelectedIndexChanged
        txtTeamInfo.Clear()

        If cmbTeam.SelectedIndex <> -1 Then
            Dim selectedTeam As String = cmbTeam.SelectedItem.ToString()

            ' --- AMBIL INFO LANGSUNG DARI DATABASE AGAR TIDAK ERROR ---
            Try
                Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                    conn.Open()
                    Dim query As String = "SELECT team_info FROM team_lengkap WHERE nama_team = @nama"
                    Using cmd As New System.Data.SQLite.SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@nama", selectedTeam)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing Then
                            txtTeamInfo.Text = result.ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Jika gagal di database, kosongkan saja info timnya
            End Try
        End If
    End Sub

    Private Sub Peserta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub LoadDataPeserta()
        Try
            gridCompetitors.Rows.Clear()
            Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                conn.Open()
                ' Panggil kolom pict_path yang baru saja kita buat!
                Dim query As String = "SELECT name, team, team_info, pict_path FROM competitor"
                Using cmd As New System.Data.SQLite.SQLiteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim n As String = reader("name").ToString()
                            Dim t As String = reader("team").ToString()
                            Dim info As String = reader("team_info").ToString()

                            ' Cek apakah gambar ada, jika tidak, gunakan No Image
                            Dim pPath As String = "No Image"
                            If Not IsDBNull(reader("pict_path")) AndAlso Not String.IsNullOrWhiteSpace(reader("pict_path").ToString()) Then
                                pPath = reader("pict_path").ToString()
                            End If

                            ' Masukkan ke tabel layar
                            gridCompetitors.Rows.Add("", "❌", "📝", n, t, info, GetSafeCompImage(pPath), pPath)
                        End While
                    End Using
                End Using
            End Using

            UpdateRowNumbers()
            UpdateTotalRecords()
            RefreshLeftTeamGrid()
        Catch ex As Exception
            ' Abaikan jika database belum terbuat
        End Try
    End Sub
End Class