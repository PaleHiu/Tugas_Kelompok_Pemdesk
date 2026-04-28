Imports System.Data.SQLite
' System.Data.SqlClient dihapus karena kita pakai SQLite

Public Class ListOfCompetitor

    ' Koneksi ke file database lokal
    Dim connString As String = "Data Source=database.db;Version=3;"

    Private Sub ListOfCompetitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Jalankan InitDatabase dulu agar tabel dibuat sebelum data dibaca
        InitDatabase()
        LoadTeam()
    End Sub

    ' --- 1. INISIALISASI TABEL (PENTING!) ---
    Private Sub InitDatabase()
        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Dim sql As String = "
                    CREATE TABLE IF NOT EXISTS team (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        nama_team TEXT
                    );
                    CREATE TABLE IF NOT EXISTS competitor (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        name TEXT,
                        team TEXT,
                        team_info TEXT
                    );"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal inisialisasi database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 2. LOAD TEAM KE LISTBOX ---
    Private Sub LoadTeam()
        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Dim query As String = "SELECT nama_team FROM team"
                Using cmd As New SQLiteCommand(query, conn)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        ListBoxTeam.Items.Clear()
                        While reader.Read()
                            ListBoxTeam.Items.Add(reader("nama_team").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat team: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- 3. EVENT KLIK TEAM ---
    Private Sub ListBoxTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTeam.SelectedIndexChanged
        If ListBoxTeam.SelectedItem IsNot Nothing Then
            LoadCompetitor(ListBoxTeam.SelectedItem.ToString())
        End If
    End Sub

    ' --- 4. LOAD DATA KOMPETITOR KE GRID ---
    Private Sub LoadCompetitor(teamName As String)
        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Dim query As String = "SELECT name, team, team_info FROM competitor WHERE team = @team"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@team", teamName)
                    Dim adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat kompetitor: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class