Imports System.IO
Imports System.Drawing

Public Class team

    Private editRowIndex As Integer = -1
    Private selectedImagePath As String = ""
    Private isFormLoaded As Boolean = False

    Private Sub team_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isFormLoaded Then Return
        isFormLoaded = True


        gridEntriesTeam.AllowUserToAddRows = False
        gridEntriesTeam.AllowUserToDeleteRows = False
        gridEntriesTeam.ReadOnly = True
        gridEntriesTeam.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        If gridEntriesTeam.Columns.Contains("ColTeamPictGrid") Then
            gridEntriesTeam.Columns.Remove("ColTeamPictGrid")
        End If

        Dim imgCol As New DataGridViewImageColumn()
        imgCol.Name = "ColTeamPictGrid"
        imgCol.HeaderText = "Team Pict"
        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        imgCol.Width = 80
        gridEntriesTeam.Columns.Add(imgCol)

        Dim pathCol As New DataGridViewTextBoxColumn()
        pathCol.Name = "ColTeamPictPath"
        pathCol.Visible = False
        gridEntriesTeam.Columns.Add(pathCol)

        gridEntriesTeam.RowTemplate.Height = 50

        cmbCountryTeam.Items.AddRange(New String() {"Indonesia", "Malaysia", "Singapore", "Japan", "Brazil", "USA"})
        cmbCountryTeam.Enabled = False
        LoadTeamsFromDatabase()
        UpdateTotalRecordsTeam()
    End Sub

    Private Sub gridEntriesTeam_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles gridEntriesTeam.DataError
        e.ThrowException = False
    End Sub

    Private Sub gridEntriesTeam_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles gridEntriesTeam.CellFormatting
        If gridEntriesTeam.Columns(e.ColumnIndex).Name = "ColTeamPictGrid" Then
            If e.Value Is Nothing OrElse IsDBNull(e.Value) Then
                Dim blankBmp As New Bitmap(1, 1)
                blankBmp.SetPixel(0, 0, Color.Transparent)
                e.Value = blankBmp
                e.FormattingApplied = True
            End If
        End If
    End Sub

    ' LOGIKA CHECKBOX NEGARA
    Private Sub chkUseCountryFlagTeam_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseCountryFlagTeam.CheckedChanged
        If chkUseCountryFlagTeam.Checked Then
            cmbCountryTeam.Enabled = True
            btnSelectTeamPic.Enabled = False

            If pnlTeamPicture.BackgroundImage IsNot Nothing Then
                pnlTeamPicture.BackgroundImage.Dispose()
            End If
            pnlTeamPicture.BackgroundImage = Nothing
            selectedImagePath = ""
        Else
            cmbCountryTeam.Enabled = False
            cmbCountryTeam.SelectedIndex = -1
            btnSelectTeamPic.Enabled = True

            If pnlTeamPicture.BackgroundImage IsNot Nothing Then
                pnlTeamPicture.BackgroundImage.Dispose()
            End If
            pnlTeamPicture.BackgroundImage = Nothing
        End If
    End Sub

    ' MEMUNCULKAN PREVIEW BENDERA SAAT COMBOBOX DIPILIH
    Private Sub cmbCountryTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCountryTeam.SelectedIndexChanged
        If cmbCountryTeam.SelectedIndex <> -1 Then
            Dim countryName As String = cmbCountryTeam.SelectedItem.ToString()
            Dim flagImage As Image = GetTeamImage("Flag: " & countryName)

            If pnlTeamPicture.BackgroundImage IsNot Nothing Then
                pnlTeamPicture.BackgroundImage.Dispose()
            End If

            pnlTeamPicture.BackgroundImage = flagImage
            pnlTeamPicture.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub

    ' SINKRONISASI KE FORM PESERTA
    Private Sub SyncTeamsToPeserta()
        SaveAllTeamsToDatabase()
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Peserta Then
                Dim formPeserta As Peserta = DirectCast(frm, Peserta)
                Dim currentSelection As String = If(formPeserta.cmbTeam.SelectedItem IsNot Nothing, formPeserta.cmbTeam.SelectedItem.ToString(), "")

                formPeserta.cmbTeam.Items.Clear()

                For Each row As DataGridViewRow In gridEntriesTeam.Rows
                    If Not row.IsNewRow Then
                        Dim tName As String = row.Cells("ColTeamGrid").Value.ToString()
                        If Not formPeserta.cmbTeam.Items.Contains(tName) Then
                            formPeserta.cmbTeam.Items.Add(tName)
                        End If
                    End If
                Next

                If formPeserta.cmbTeam.Items.Contains(currentSelection) Then
                    formPeserta.cmbTeam.SelectedItem = currentSelection
                End If
            End If
        Next
    End Sub

    ' FUNGSI MEMUAT GAMBAR AMAN
    Private Function GetTeamImage(pathOrFlag As String) As Image
        Try
            If pathOrFlag.StartsWith("Flag: ") Then
                Dim countryName As String = pathOrFlag.Replace("Flag: ", "")

                Dim flagPathPNG As String = IO.Path.Combine(Application.StartupPath, countryName & "_Flag.png")
                Dim flagPathJPG As String = IO.Path.Combine(Application.StartupPath, countryName & "_Flag.jpg")

                Dim finalPath As String = ""
                If File.Exists(flagPathPNG) Then finalPath = flagPathPNG
                If File.Exists(flagPathJPG) Then finalPath = flagPathJPG

                If finalPath <> "" Then
                    Dim fs As New FileStream(finalPath, FileMode.Open, FileAccess.Read)
                    Dim originalImg As Image = Image.FromStream(fs)
                    Dim imgCopy As New Bitmap(originalImg)
                    fs.Close()
                    Return imgCopy
                Else
                    Dim bmp As New Bitmap(100, 60)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        g.Clear(Color.LightGray)
                        g.DrawRectangle(Pens.Black, 0, 0, 99, 59)
                        g.DrawString(countryName, New Font("Segoe UI", 8, FontStyle.Bold), Brushes.Black, New PointF(5, 20))
                    End Using
                    Return bmp
                End If

            ElseIf File.Exists(pathOrFlag) Then
                Dim fs As New FileStream(pathOrFlag, FileMode.Open, FileAccess.Read)
                Dim originalImg As Image = Image.FromStream(fs)
                Dim imgCopy As New Bitmap(originalImg)
                fs.Close()
                Return imgCopy
            End If
        Catch ex As Exception
        End Try

        Dim blankBmp As New Bitmap(1, 1)
        blankBmp.SetPixel(0, 0, Color.Transparent)
        Return blankBmp
    End Function

    ' FUNGSI TOMBOL ADD / UPDATE
    Private Sub btnAddTeam_Click(sender As Object, e As EventArgs) Handles btnAddTeam.Click
        If txtNamaTeam.Text.Trim() = "" Then
            MessageBox.Show("Nama Team wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim teamName As String = txtNamaTeam.Text.Trim()
        Dim teamInfo As String = txtTimInfoTeam.Text.Trim()

        Dim teamPictPath As String = "No Image"
        If chkUseCountryFlagTeam.Checked AndAlso cmbCountryTeam.SelectedIndex <> -1 Then
            teamPictPath = "Flag: " & cmbCountryTeam.SelectedItem.ToString()
        ElseIf selectedImagePath <> "" Then
            teamPictPath = selectedImagePath
        End If

        Dim displayImage As Image = GetTeamImage(teamPictPath)

        If editRowIndex >= 0 Then
            gridEntriesTeam.Rows(editRowIndex).Cells("ColTeamGrid").Value = teamName
            gridEntriesTeam.Rows(editRowIndex).Cells("ColTeamInfoGrid").Value = teamInfo
            gridEntriesTeam.Rows(editRowIndex).Cells("ColTeamPictGrid").Value = displayImage
            gridEntriesTeam.Rows(editRowIndex).Cells("ColTeamPictPath").Value = teamPictPath
            editRowIndex = -1
        Else
            Dim idx As Integer = gridEntriesTeam.Rows.Add()
            Dim row As DataGridViewRow = gridEntriesTeam.Rows(idx)
            row.Cells("ColRowNoTeam").Value = ""
            row.Cells("ColDeleteTeam").Value = "❌"
            row.Cells("ColEditTeam").Value = "📝"
            row.Cells("ColTeamGrid").Value = teamName
            row.Cells("ColTeamInfoGrid").Value = teamInfo
            row.Cells("ColTeamPictGrid").Value = displayImage
            row.Cells("ColTeamPictPath").Value = teamPictPath
        End If

        UpdateRowNumbers()
        UpdateTotalRecordsTeam()
        SyncTeamsToPeserta()
        ClearInputTeam()
    End Sub

    ' FUNGSI PENOMORAN BARIS OTOMATIS
    Private Sub UpdateRowNumbers()
        Dim count As Integer = 1
        For Each row As DataGridViewRow In gridEntriesTeam.Rows
            If Not row.IsNewRow Then
                row.Cells("ColRowNoTeam").Value = count.ToString()
                count += 1
            End If
        Next
    End Sub

    ' TOMBOL CLEAR & RESET INPUT
    Private Sub btnClearTeam_Click(sender As Object, e As EventArgs) Handles btnClearTeam.Click
        ClearInputTeam()
    End Sub

    Private Sub ClearInputTeam()
        txtNamaTeam.Clear()
        txtTimInfoTeam.Clear()
        chkUseCountryFlagTeam.Checked = False
        cmbCountryTeam.SelectedIndex = -1

        If pnlTeamPicture.BackgroundImage IsNot Nothing Then
            pnlTeamPicture.BackgroundImage.Dispose()
        End If
        pnlTeamPicture.BackgroundImage = Nothing
        selectedImagePath = ""
        txtNamaTeam.Focus()

        editRowIndex = -1
        btnAddTeam.Text = "Add"
        btnAddTeam.BackColor = Color.DeepSkyBlue
    End Sub

    ' KLIK EDIT & DELETE DI DATAGRIDVIEW
    Private Sub gridEntriesTeam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridEntriesTeam.CellContentClick
        If e.RowIndex >= 0 AndAlso Not gridEntriesTeam.Rows(e.RowIndex).IsNewRow Then

            If e.ColumnIndex = gridEntriesTeam.Columns("ColDeleteTeam").Index Then
                If MessageBox.Show("Hapus tim ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    gridEntriesTeam.Rows.RemoveAt(e.RowIndex)
                    UpdateRowNumbers()
                    UpdateTotalRecordsTeam()
                    SyncTeamsToPeserta()
                End If
            End If

            If e.ColumnIndex = gridEntriesTeam.Columns("ColEditTeam").Index Then
                ClearInputTeam()

                txtNamaTeam.Text = gridEntriesTeam.Rows(e.RowIndex).Cells("ColTeamGrid").Value.ToString()
                txtTimInfoTeam.Text = gridEntriesTeam.Rows(e.RowIndex).Cells("ColTeamInfoGrid").Value.ToString()

                Dim pictData As String = gridEntriesTeam.Rows(e.RowIndex).Cells("ColTeamPictPath").Value.ToString()

                If pictData.StartsWith("Flag: ") Then
                    chkUseCountryFlagTeam.Checked = True
                    cmbCountryTeam.SelectedItem = pictData.Replace("Flag: ", "")
                ElseIf File.Exists(pictData) Then
                    selectedImagePath = pictData
                    Dim fs As New FileStream(selectedImagePath, FileMode.Open, FileAccess.Read)
                    Dim originalImg As Image = Image.FromStream(fs)
                    pnlTeamPicture.BackgroundImage = New Bitmap(originalImg)
                    fs.Close()
                    pnlTeamPicture.BackgroundImageLayout = ImageLayout.Zoom
                End If

                editRowIndex = e.RowIndex
                btnAddTeam.Text = "Update"
                btnAddTeam.BackColor = Color.Orange
            End If
        End If
    End Sub

    ' TOMBOL SELECT PICTURE
    Private Sub btnSelectTeamPic_Click(sender As Object, e As EventArgs) Handles btnSelectTeamPic.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If ofd.ShowDialog() = DialogResult.OK Then
            selectedImagePath = ofd.FileName
            Dim fs As New FileStream(selectedImagePath, FileMode.Open, FileAccess.Read)
            Dim originalImg As Image = Image.FromStream(fs)
            pnlTeamPicture.BackgroundImage = New Bitmap(originalImg)
            fs.Close()
            pnlTeamPicture.BackgroundImageLayout = ImageLayout.Zoom
            chkUseCountryFlagTeam.Checked = False
        End If
    End Sub

    ' DELETE ALL
    Private Sub btnDeleteAllTeam_Click(sender As Object, e As EventArgs) Handles btnDeleteAllTeam.Click
        If MessageBox.Show("Hapus SEMUA data Tim?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            gridEntriesTeam.Rows.Clear()
            UpdateRowNumbers()
            UpdateTotalRecordsTeam()
            SyncTeamsToPeserta()
        End If
    End Sub

    ' PENCARIAN & TOTAL RECORD
    Private Sub btnSearchTeam_Click(sender As Object, e As EventArgs) Handles btnSearchTeam.Click
        Dim keyword As String = txtSearchTeam.Text.ToLower()
        For Each row As DataGridViewRow In gridEntriesTeam.Rows
            If Not row.IsNewRow Then
                Dim teamName As String = If(row.Cells("ColTeamGrid").Value IsNot Nothing, row.Cells("ColTeamGrid").Value.ToString().ToLower(), "")
                row.Visible = teamName.Contains(keyword)
            End If
        Next
    End Sub

    Private Sub btnClearSearchTeam_Click(sender As Object, e As EventArgs) Handles btnClearSearchTeam.Click
        txtSearchTeam.Clear()
        For Each row As DataGridViewRow In gridEntriesTeam.Rows
            If Not row.IsNewRow Then row.Visible = True
        Next
    End Sub

    Private Sub UpdateTotalRecordsTeam()
        Dim count As Integer = gridEntriesTeam.Rows.Count
        If gridEntriesTeam.AllowUserToAddRows Then count -= 1
        If count < 0 Then count = 0
        lblTotalRecordsTeam.Text = "Total Records : " & count.ToString()
    End Sub

    ' PROTEKSI FORM
    Private Sub team_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub


    ' EXPORT / IMPORT CSV

    Private Sub btnExportExcelTeam_Click(sender As Object, e As EventArgs) Handles btnExportExcelTeam.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV (Excel Compatible) (*.csv)|*.csv"
        sfd.FileName = "Data_Team.csv"
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim sw As New StreamWriter(sfd.FileName)

                sw.WriteLine("Team Name;Team Info")

                For Each row As DataGridViewRow In gridEntriesTeam.Rows
                    If Not row.IsNewRow Then

                        Dim tName = If(row.Cells("ColTeamGrid").Value IsNot Nothing, row.Cells("ColTeamGrid").Value.ToString().Replace(";", " "), "")
                        Dim tInfo = If(row.Cells("ColTeamInfoGrid").Value IsNot Nothing, row.Cells("ColTeamInfoGrid").Value.ToString().Replace(";", " "), "")

                        sw.WriteLine(tName & ";" & tInfo)
                    End If
                Next
                sw.Close()
                MessageBox.Show("Data berhasil diexport ke Excel!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnImportExcelTeam_Click(sender As Object, e As EventArgs) Handles btnImportExcelTeam.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "CSV Files (*.csv)|*.csv"
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim sr As New StreamReader(ofd.FileName)
                Dim isHeader As Boolean = True
                While Not sr.EndOfStream
                    Dim line As String = sr.ReadLine()
                    If isHeader Then
                        isHeader = False
                        Continue While
                    End If

                    Dim data As String()
                    If line.Contains(";") Then
                        data = line.Split(";"c)
                    Else
                        data = line.Split(","c)
                    End If

                    If data.Length >= 2 Then
                        Dim pictPath As String = "No Image"
                        Dim displayImage As Image = GetTeamImage(pictPath)

                        Dim idx As Integer = gridEntriesTeam.Rows.Add()
                        Dim row As DataGridViewRow = gridEntriesTeam.Rows(idx)
                        row.Cells("ColRowNoTeam").Value = ""
                        row.Cells("ColDeleteTeam").Value = "❌"
                        row.Cells("ColEditTeam").Value = "📝"

                        row.Cells("ColTeamGrid").Value = data(0)
                        row.Cells("ColTeamInfoGrid").Value = data(1)

                        row.Cells("ColTeamPictGrid").Value = displayImage
                        row.Cells("ColTeamPictPath").Value = pictPath
                    End If
                End While
                sr.Close()
                UpdateRowNumbers()
                UpdateTotalRecordsTeam()
                SyncTeamsToPeserta()
                MessageBox.Show("Data berhasil diimport!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub ClearFocus_Click(sender As Object, e As EventArgs) Handles MyBase.Click, pnlFormTeam.Click, pnlToolbarTeam.Click, pnlFooterTeam.Click, pnlGridTeam.Click
        lblTitleFormTeam.Focus()

        gridEntriesTeam.ClearSelection()
    End Sub


    Private Sub gridEntriesTeam_MouseDown(sender As Object, e As MouseEventArgs) Handles gridEntriesTeam.MouseDown
        Dim hit As DataGridView.HitTestInfo = gridEntriesTeam.HitTest(e.X, e.Y)
        If hit.Type = DataGridViewHitTestType.None OrElse hit.Type = DataGridViewHitTestType.TopLeftHeader Then
            gridEntriesTeam.ClearSelection()
            lblTitleFormTeam.Focus()
        End If
    End Sub

    ' --- FUNGSI MENYIMPAN SEMUA TIM KE DATABASE ---
    Private Sub SaveAllTeamsToDatabase()
        Try
            Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                conn.Open()
                ' 1. Buat tabelnya jika belum ada
                Dim sqlCreate As String = "CREATE TABLE IF NOT EXISTS team_lengkap (nama_team TEXT, team_info TEXT, pict_path TEXT);"
                Using cmdCreate As New System.Data.SQLite.SQLiteCommand(sqlCreate, conn)
                    cmdCreate.ExecuteNonQuery()
                End Using

                ' 2. Hapus data lama agar tidak dobel
                Dim sqlDelete As String = "DELETE FROM team_lengkap"
                Using cmdDelete As New System.Data.SQLite.SQLiteCommand(sqlDelete, conn)
                    cmdDelete.ExecuteNonQuery()
                End Using

                ' 3. Simpan ulang semua dari tabel di layar
                For Each row As DataGridViewRow In gridEntriesTeam.Rows
                    If Not row.IsNewRow Then
                        Dim tName As String = row.Cells("ColTeamGrid").Value.ToString()
                        Dim tInfo As String = row.Cells("ColTeamInfoGrid").Value.ToString()
                        Dim pPath As String = row.Cells("ColTeamPictPath").Value.ToString()

                        Dim sqlInsert As String = "INSERT INTO team_lengkap (nama_team, team_info, pict_path) VALUES (@nama, @info, @path)"
                        Using cmdInsert As New System.Data.SQLite.SQLiteCommand(sqlInsert, conn)
                            cmdInsert.Parameters.AddWithValue("@nama", tName)
                            cmdInsert.Parameters.AddWithValue("@info", tInfo)
                            cmdInsert.Parameters.AddWithValue("@path", pPath)
                            cmdInsert.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using
        Catch ex As Exception
        End Try
    End Sub

    ' --- FUNGSI MEMANGGIL TIM DARI DATABASE ---
    Private Sub LoadTeamsFromDatabase()
        Try
            gridEntriesTeam.Rows.Clear()
            Using conn As New System.Data.SQLite.SQLiteConnection("Data Source=database.db;Version=3;")
                conn.Open()
                Dim query As String = "SELECT nama_team, team_info, pict_path FROM team_lengkap"
                Using cmd As New System.Data.SQLite.SQLiteCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim tName As String = reader("nama_team").ToString()
                            Dim tInfo As String = reader("team_info").ToString()
                            Dim pPath As String = reader("pict_path").ToString()
                            Dim displayImage As Image = GetTeamImage(pPath)

                            Dim idx As Integer = gridEntriesTeam.Rows.Add()
                            Dim row As DataGridViewRow = gridEntriesTeam.Rows(idx)
                            row.Cells("ColRowNoTeam").Value = ""
                            row.Cells("ColDeleteTeam").Value = "❌"
                            row.Cells("ColEditTeam").Value = "📝"
                            row.Cells("ColTeamGrid").Value = tName
                            row.Cells("ColTeamInfoGrid").Value = tInfo
                            row.Cells("ColTeamPictGrid").Value = displayImage
                            row.Cells("ColTeamPictPath").Value = pPath
                        End While
                    End Using
                End Using
            End Using
            UpdateRowNumbers()
            UpdateTotalRecordsTeam()
        Catch ex As Exception
        End Try
    End Sub
End Class