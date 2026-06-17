Imports System.Data.SQLite
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections.Generic

Public Class Peserta

    ' --- PERBAIKAN 1: Sentralisasi Connection String ---
    ' Memudahkan maintenance jika suatu saat nama/lokasi database berubah
    Private Const DB_CONN As String = "Data Source=database.db;Version=3;"

    Private editRowIndex As Integer = -1
    Private selectedImagePath As String = ""
    Private isFormLoaded As Boolean = False

    ' --- PERBAIKAN 2: Image Caching untuk Performa UI ---
    ' Menyimpan gambar tim di memori agar CellPainting tidak lag
    Private teamImageCache As New Dictionary(Of String, Image)


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

        LoadDataPeserta() ' Load Data dipindah ke atas agar grid terisi dulu
        LoadTeamImageCache() ' Load gambar tim ke memori
        UpdateTotalRecords()
        RefreshLeftTeamGrid()
        LoadTeamsToComboBox()

        If Not gridCompetitors.Columns.Contains("ColCompPictPath") Then
            Dim pathCol As New DataGridViewTextBoxColumn()
            pathCol.Name = "ColCompPictPath"
            pathCol.Visible = False
            gridCompetitors.Columns.Add(pathCol)
        End If
    End Sub

    ' Menyimpan referensi logo tim ke dalam Dictionary agar CellPainting lebih ringan
    ' Menyimpan referensi logo tim ke dalam Dictionary langsung dari Database
    Private Sub LoadTeamImageCache()
        teamImageCache.Clear()
        Try
            Using conn As New SQLiteConnection(DB_CONN)
                conn.Open()
                ' Ambil nama tim dan alamat gambarnya langsung dari database
                Dim query As String = "SELECT nama_team, pict_path FROM team_lengkap"
                Using cmd As New SQLiteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim tName As String = reader("nama_team").ToString()
                            Dim pPath As String = reader("pict_path").ToString()

                            ' Minta form Team untuk merender gambar/benderanya
                            If Dashboard.frmTeamApp IsNot Nothing Then
                                Dim teamImg As Image = Dashboard.frmTeamApp.GetTeamImage(pPath)
                                If teamImg IsNot Nothing AndAlso Not teamImageCache.ContainsKey(tName) Then
                                    teamImageCache.Add(tName, teamImg)
                                End If
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Biarkan cache kosong jika terjadi error koneksi
        End Try
    End Sub

    Public Sub LoadTeamsToComboBox()
        cmbTeam.Items.Clear()
        Try
            Using conn As New SQLiteConnection(DB_CONN)
                conn.Open()
                Dim query As String = "SELECT nama_team FROM team_lengkap"
                Using cmd As New SQLiteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim tName = reader("nama_team").ToString()
                            If Not cmbTeam.Items.Contains(tName) Then cmbTeam.Items.Add(tName)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try

        For Each row As DataGridViewRow In gridCompetitors.Rows
            If Not row.IsNewRow AndAlso row.Cells("ColTeamRight").Value IsNot Nothing Then
                Dim tName = row.Cells("ColTeamRight").Value.ToString()
                If Not cmbTeam.Items.Contains(tName) Then cmbTeam.Items.Add(tName)
            End If
        Next
    End Sub

    Private Sub gridCompetitors_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles gridCompetitors.DataError
        e.ThrowException = False
    End Sub


    ' 2. LOGIKA ADD / UPDATE & AUTO-FILTER

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text.Trim() = "" Or cmbTeam.SelectedIndex = -1 Then
            MessageBox.Show("Nama dan Tim wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim teamName As String = cmbTeam.SelectedItem.ToString()
        Dim imgPath As String = If(selectedImagePath <> "", selectedImagePath, "No Image")
        Dim displayImage As Image = GetSafeCompImage(imgPath)

        If editRowIndex >= 0 Then
            Try
                Dim oldName As String = gridCompetitors.Rows(editRowIndex).Cells("ColName").Value.ToString()
                Dim oldTeam As String = gridCompetitors.Rows(editRowIndex).Cells("ColTeamRight").Value.ToString()

                Using conn As New SQLiteConnection(DB_CONN)
                    conn.Open()
                    Dim query As String = "UPDATE competitor SET name = @newName, team = @newTeam, team_info = @newInfo, pict_path = @newPict WHERE name = @oldName AND team = @oldTeam"
                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@newName", txtName.Text.Trim())
                        cmd.Parameters.AddWithValue("@newTeam", teamName)
                        cmd.Parameters.AddWithValue("@newInfo", txtTeamInfo.Text.Trim())
                        cmd.Parameters.AddWithValue("@newPict", imgPath)
                        cmd.Parameters.AddWithValue("@oldName", oldName)
                        cmd.Parameters.AddWithValue("@oldTeam", oldTeam)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                Dim row As DataGridViewRow = gridCompetitors.Rows(editRowIndex)
                row.Cells("ColName").Value = txtName.Text.Trim()
                row.Cells("ColTeamRight").Value = teamName
                row.Cells("ColTeamInfoRight").Value = txtTeamInfo.Text.Trim()
                row.Cells("ColCompPict").Value = displayImage
                row.Cells("ColCompPictPath").Value = imgPath

                editRowIndex = -1

            Catch ex As Exception
                MessageBox.Show("Gagal mengupdate database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                Using conn As New SQLiteConnection(DB_CONN)
                    conn.Open()
                    Dim query As String = "INSERT INTO competitor (name, team, team_info, pict_path) VALUES (@name, @team, @info, @pict)"
                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                        cmd.Parameters.AddWithValue("@team", teamName)
                        cmd.Parameters.AddWithValue("@info", txtTeamInfo.Text.Trim())
                        cmd.Parameters.AddWithValue("@pict", imgPath)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                gridCompetitors.Rows.Add("", "❌", "📝", txtName.Text.Trim(), teamName, txtTeamInfo.Text.Trim(), displayImage, imgPath)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        UpdateRowNumbers()
        UpdateTotalRecords()
        RefreshLeftTeamGrid()

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
        Dim sfd As New SaveFileDialog() With {.Filter = "CSV File|*.csv", .FileName = "Data_Peserta.csv"}
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

                    Using conn As New SQLiteConnection(DB_CONN)
                        conn.Open()
                        Using trans = conn.BeginTransaction()

                            ' 1. Mencegah Duplikasi Peserta & Tim dengan kondisi WHERE NOT EXISTS
                            Dim queryTeam As String = "INSERT INTO team_lengkap (nama_team, team_info, pict_path) SELECT @teamName, '', 'No Image' WHERE NOT EXISTS (SELECT 1 FROM team_lengkap WHERE nama_team = @teamName)"
                            Dim queryCompetitor As String = "INSERT INTO competitor (name, team, team_info, pict_path) SELECT @name, @team, '', 'No Image' WHERE NOT EXISTS (SELECT 1 FROM competitor WHERE name = @name AND team = @team)"

                            Using cmdTeam As New SQLiteCommand(queryTeam, conn),
                                  cmdComp As New SQLiteCommand(queryCompetitor, conn)

                                cmdTeam.Parameters.Add("@teamName", DbType.String)
                                cmdComp.Parameters.Add("@name", DbType.String)
                                cmdComp.Parameters.Add("@team", DbType.String)

                                While Not sr.EndOfStream
                                    Dim line As String = sr.ReadLine()
                                    Dim data = line.Split(separator)

                                    If data.Length > Math.Max(nameColIdx, teamColIdx) Then
                                        Dim valName As String = data(nameColIdx).Trim()
                                        Dim valTeam As String = data(teamColIdx).Trim()

                                        If valName <> "" And valTeam <> "" Then
                                            ' Daftarkan Tim
                                            cmdTeam.Parameters("@teamName").Value = valTeam
                                            cmdTeam.ExecuteNonQuery()

                                            ' Daftarkan Atlet
                                            cmdComp.Parameters("@name").Value = valName
                                            cmdComp.Parameters("@team").Value = valTeam

                                            ' ExecuteNonQuery mengembalikan nilai > 0 jika ada data baru yang berhasil dimasukkan
                                            Dim rowsAffected As Integer = cmdComp.ExecuteNonQuery()
                                            If rowsAffected > 0 Then
                                                importCount += 1
                                            End If
                                        End If
                                    End If
                                End While
                            End Using
                            trans.Commit()
                        End Using
                    End Using

                    ' --- PERBAIKAN AUTO-REFRESH UI ---
                    If importCount > 0 Then
                        ' 1. Refresh layar Peserta (Ambil ulang dari DB agar akurat dan tidak ada duplikat layar)
                        LoadDataPeserta()
                        LoadTeamsToComboBox()

                        ' 2. TRIGGER REFRESH KE FORM TEAM ENTRIES
                        ' Pastikan Form Team sudah terinisialisasi sebelum kita memanggil fungsinya
                        If Dashboard.frmTeamApp IsNot Nothing Then
                            ' CATATAN: Ubah "LoadDataTim" dengan nama fungsi pemuat data yang ada di file Team Entries Anda
                            ' Dashboard.frmTeamApp.LoadDataTim() 
                        End If

                        MessageBox.Show(importCount & " Data peserta baru berhasil diimpor tanpa duplikasi!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Tidak ada data baru yang ditambahkan. Semua data di Excel sudah ada di sistem (Duplikat).", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            UpdateRowNumbers()
        Next
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        For Each row As DataGridViewRow In gridCompetitors.Rows
            If Not row.IsNewRow Then row.Visible = True
        Next
        UpdateRowNumbers()
    End Sub


    ' 5. FUNGSI PENOMORAN & REFRESH UI

    Private Sub UpdateRowNumbers()
        Dim count As Integer = 1
        For Each row As DataGridViewRow In gridCompetitors.Rows
            ' Hanya beri nomor jika barisnya tidak kosong DAN sedang tidak disembunyikan (Visible)
            If Not row.IsNewRow AndAlso row.Visible Then
                row.Cells("ColNo").Value = count.ToString()
                count += 1
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
                If Not uniqueTeams.Contains(t) Then uniqueTeams.Add(t)
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

            ' --- PERBAIKAN 4: Mengambil gambar dari Cache, bukan lintas Form ---
            If teamImageCache.ContainsKey(tName) Then
                teamImg = teamImageCache(tName)
            End If

            Dim dRect = New Rectangle(e.CellBounds.X + (e.CellBounds.Width - 70) \ 2, e.CellBounds.Y + 30, 70, 70)
            If teamImg IsNot Nothing Then
                e.Graphics.DrawImage(teamImg, dRect)
            Else
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
            UpdateRowNumbers()
        End If
    End Sub

    Private Sub gridCompetitors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridCompetitors.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = gridCompetitors.Columns("ColDel").Index Then
                If MessageBox.Show("Hapus peserta ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim row = gridCompetitors.Rows(e.RowIndex)
                    Dim n = row.Cells("ColName").Value.ToString()
                    Dim t = row.Cells("ColTeamRight").Value.ToString()

                    Try
                        Using conn As New SQLiteConnection(DB_CONN)
                            conn.Open()
                            Dim query As String = "DELETE FROM competitor WHERE name = @name AND team = @team"
                            Using cmd As New SQLiteCommand(query, conn)
                                cmd.Parameters.AddWithValue("@name", n)
                                cmd.Parameters.AddWithValue("@team", t)
                                cmd.ExecuteNonQuery()
                            End Using
                        End Using
                    Catch ex As Exception
                    End Try

                    gridCompetitors.Rows.RemoveAt(e.RowIndex)
                    UpdateRowNumbers()
                    UpdateTotalRecords()
                    RefreshLeftTeamGrid()
                End If
            ElseIf e.ColumnIndex = gridCompetitors.Columns("ColEdit").Index Then
                Dim row = gridCompetitors.Rows(e.RowIndex)
                txtName.Text = row.Cells("ColName").Value.ToString()
                cmbTeam.SelectedItem = row.Cells("ColTeamRight").Value.ToString()

                If row.Cells("ColTeamInfoRight").Value IsNot Nothing Then
                    txtTeamInfo.Text = row.Cells("ColTeamInfoRight").Value.ToString()
                End If

                If row.Cells("ColCompPictPath").Value IsNot Nothing Then
                    selectedImagePath = row.Cells("ColCompPictPath").Value.ToString()
                Else
                    selectedImagePath = "No Image"
                End If

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
        UpdateRowNumbers()
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
            Try
                Using conn As New SQLiteConnection(DB_CONN)
                    conn.Open()
                    Using cmd As New SQLiteCommand("DELETE FROM competitor", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data di database: " & ex.Message)
            End Try

            gridCompetitors.Rows.Clear()
            UpdateTotalRecords()
            RefreshLeftTeamGrid()
            MessageBox.Show("Seluruh data peserta berhasil dihapus secara permanen!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSelectPic_Click(sender As Object, e As EventArgs) Handles btnSelectPic.Click
        Dim ofd As New OpenFileDialog() With {.Filter = "Images|*.jpg;*.jpeg;*.png"}
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim localFolder As String = IO.Path.Combine(Application.StartupPath, "Images_Peserta")
                If Not IO.Directory.Exists(localFolder) Then IO.Directory.CreateDirectory(localFolder)

                Dim fileExt As String = IO.Path.GetExtension(ofd.FileName)
                Dim uniqueFileName As String = "Peserta_" & DateTime.Now.ToString("yyyyMMddHHmmss") & fileExt
                Dim destinationPath As String = IO.Path.Combine(localFolder, uniqueFileName)

                IO.File.Copy(ofd.FileName, destinationPath, True)
                selectedImagePath = destinationPath
                picCircle.Image = GetSafeCompImage(selectedImagePath)
            Catch ex As Exception
                MessageBox.Show("Gagal menyalin gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnEditTeam_Click_1(sender As Object, e As EventArgs) Handles btnEditTeam.Click
        Dashboard.frmTeamApp.ShowDialog()
        LoadTeamImageCache() ' Update cache memori jika ada tim yang logonya diubah
        gridTeams.Refresh()
    End Sub

    Private Sub cmbTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeam.SelectedIndexChanged
        txtTeamInfo.Clear()
        If cmbTeam.SelectedIndex <> -1 Then
            Dim selectedTeam As String = cmbTeam.SelectedItem.ToString()
            Try
                Using conn As New SQLiteConnection(DB_CONN)
                    conn.Open()
                    Dim query As String = "SELECT team_info FROM team_lengkap WHERE nama_team = @nama"
                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@nama", selectedTeam)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing Then txtTeamInfo.Text = result.ToString()
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Peserta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Public Sub LoadDataPeserta()
        Try
            gridCompetitors.Rows.Clear()
            Using conn As New SQLiteConnection(DB_CONN)
                conn.Open()

                Dim sqlCreate As String = "CREATE TABLE IF NOT EXISTS competitor (name TEXT, team TEXT, team_info TEXT);"
                Using cmdCreate As New SQLiteCommand(sqlCreate, conn)
                    cmdCreate.ExecuteNonQuery()
                End Using

                Try
                    Dim sqlAlter As String = "ALTER TABLE competitor ADD COLUMN pict_path TEXT;"
                    Using cmdAlter As New SQLiteCommand(sqlAlter, conn)
                        cmdAlter.ExecuteNonQuery()
                    End Using
                Catch exAlter As Exception
                End Try

                Dim query As String = "SELECT name, team, team_info, pict_path FROM competitor"
                Using cmd As New SQLiteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim n As String = reader("name").ToString()
                            Dim t As String = reader("team").ToString()
                            Dim info As String = reader("team_info").ToString()

                            Dim pPath As String = "No Image"
                            If Not IsDBNull(reader("pict_path")) AndAlso Not String.IsNullOrWhiteSpace(reader("pict_path").ToString()) Then
                                pPath = reader("pict_path").ToString()
                            End If

                            gridCompetitors.Rows.Add("", "❌", "📝", n, t, info, GetSafeCompImage(pPath), pPath)
                        End While
                    End Using
                End Using
            End Using

            UpdateRowNumbers()
            UpdateTotalRecords()
            RefreshLeftTeamGrid()
        Catch ex As Exception
        End Try
    End Sub
End Class