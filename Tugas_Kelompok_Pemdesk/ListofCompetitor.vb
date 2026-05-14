Imports System.Data.SQLite

Public Class ListOfCompetitor
    Dim connString As String = "Data Source=database.db;Version=3;"

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub ListOfCompetitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeam()
        LoadCompetitor("")
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
End Class