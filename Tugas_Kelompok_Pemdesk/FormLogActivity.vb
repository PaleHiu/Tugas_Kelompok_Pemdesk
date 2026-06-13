Public Class FormLogActivity

    ' ==========================================================
    ' [FILTER SYSTEM] MEMORI PENAMPUNG SELURUH LOG
    ' ==========================================================
    Private MasterLogList As New List(Of ListViewItem)

    Private Sub FormLogActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Log Activity"

        ' ==========================================================
        ' [FILTER SYSTEM] SETUP COMBOBOX KATEGORI
        ' ==========================================================
        cmbCategories.Items.Clear()
        cmbCategories.Items.Add("All Categories") ' Opsi untuk melihat gabungan KATA & KUMITE
        cmbCategories.Items.Add("KATA ScoreBoard")
        cmbCategories.Items.Add("KUMITE Blank ScoreBoard")
        ' (Bisa ditambahkan kategori U60 Male, dll sesuai kebutuhan ke depannya)
        cmbCategories.SelectedIndex = 0

        ' Set tanggal hari ini
        dtpDate.Value = DateTime.Today

        ' Setup kolom ListView sesuai screenshot asli (Sudah dibersihkan dari duplikasi)
        lvActivity.Columns.Add("Categories", 100)
        lvActivity.Columns.Add("Activity", 100)
        lvActivity.Columns.Add("ActivityType", 110)
        lvActivity.Columns.Add("Date Time", 130)
        lvActivity.Columns.Add("MatchTime", 90)
        lvActivity.Columns.Add("UserName", 100)
        lvActivity.Columns.Add("Pool", 80)
        lvActivity.Columns.Add("Round", 80)
        lvActivity.Columns.Add("Match No", 80)
        lvActivity.Columns.Add("RoundStatus", 90)
        lvActivity.Columns.Add("Versus", 80)
        lvActivity.Columns.Add("Tatami", 80)
    End Sub

    ' ==========================================================
    ' FUNGSI 1: INSERT LOG ASLI (KHUSUS UNTUK KUMITE)
    ' ==========================================================
    Public Sub InsertLog(activityDetail As String, activityType As String, matchTime As String)
        Dim category As String = "KUMITE Blank ScoreBoard"
        Dim newItem As New ListViewItem(category)

        newItem.SubItems.Add(activityDetail)
        newItem.SubItems.Add(activityType)
        newItem.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        newItem.SubItems.Add(matchTime)
        newItem.SubItems.Add("Admin")
        newItem.SubItems.Add("-")
        newItem.SubItems.Add("-")
        newItem.SubItems.Add("-")
        newItem.SubItems.Add("-")
        newItem.SubItems.Add("AKA vs AO")
        newItem.SubItems.Add("1")

        ' Menyimpan log ke memori dan langsung memperbarui layar
        MasterLogList.Insert(0, newItem)
        ApplyFilter()
    End Sub

    ' ==========================================================
    ' FUNGSI 2: OVERLOAD INSERT LOG (KHUSUS UNTUK KATA / DINAMIS)
    ' ==========================================================
    Public Sub InsertLog(categoryName As String, activityDetail As String, activityType As String, matchTime As String)
        Dim newItem As New ListViewItem(categoryName)

        newItem.SubItems.Add(activityDetail)
        newItem.SubItems.Add(activityType)
        newItem.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        newItem.SubItems.Add(matchTime)
        newItem.SubItems.Add("Admin")
        newItem.SubItems.Add("-")
        newItem.SubItems.Add("-")
        newItem.SubItems.Add("-")
        newItem.SubItems.Add("-")
        newItem.SubItems.Add("AKA vs AO")
        newItem.SubItems.Add("1")

        ' Menyimpan log ke memori dan langsung memperbarui layar
        MasterLogList.Insert(0, newItem)
        ApplyFilter()
    End Sub

    ' ==========================================================
    ' FITUR EKSPOR DATA KE CSV
    ' ==========================================================
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        sfd.FileName = "LogActivity_" & dtpDate.Value.ToString("yyyyMMdd")
        If sfd.ShowDialog() = DialogResult.OK Then
            ' Menggunakan vbCrLf agar tidak memunculkan warning kuning di Visual Studio
            MessageBox.Show("Data berhasil diekspor!" & vbCrLf & sfd.FileName,
                            "Export Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ==========================================================
    ' MENCEGAH BUG DISPOSED: HIDE FORM SAAT DI-CLOSE
    ' ==========================================================
    Private Sub FormLogActivity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Jika penutupan dilakukan oleh user (mengklik tombol silang / X)
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True ' Batalkan perintah penghancuran form
            Me.Hide()       ' Sembunyikan form ke latar belakang
        End If
    End Sub

    ' ==========================================================
    ' [FILTER SYSTEM] LOGIKA MENYARING TABEL (BULLETPROOF VERSION)
    ' ==========================================================
    Private Sub ApplyFilter()
        ' Cegah crash jika combobox belum siap atau sedang dikosongkan
        If cmbCategories.SelectedItem Is Nothing Then Exit Sub

        ' Bersihkan tabel di layar (Data asli aman di MasterLogList)
        lvActivity.Items.Clear()

        Dim isFilterActive As Boolean = chkFilterByCategories.Checked
        ' Ambil teks, bersihkan spasi, dan jadikan huruf kecil untuk pencocokan sempurna
        Dim selectedCategory As String = cmbCategories.SelectedItem.ToString().Trim().ToLower()

        ' Pindahkan data dari memori Master ke layar sesuai kondisi
        For Each item In MasterLogList
            ' Jika filter aktif dan user tidak memilih "All Categories"
            If isFilterActive AndAlso selectedCategory <> "all categories" Then
                ' Cek apakah teks di kolom 1 (Categories) cocok secara eksak
                If item.Text.Trim().ToLower() = selectedCategory Then
                    ' Clone digunakan karena 1 Item tidak bisa dipakai di 2 tempat bersamaan
                    lvActivity.Items.Add(CType(item.Clone(), ListViewItem))
                End If
            Else
                ' Jika filter dimatikan (Uncheck) atau memilih All Categories, tampilkan semua
                lvActivity.Items.Add(CType(item.Clone(), ListViewItem))
            End If
        Next
    End Sub

    ' ==========================================================
    ' [FILTER SYSTEM] TRIGGER / EVENT SAAT KONTROL DIKLIK USER
    ' ==========================================================
    Private Sub cmbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategories.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub chkFilterByCategories_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterByCategories.CheckedChanged
        ApplyFilter()
    End Sub

End Class