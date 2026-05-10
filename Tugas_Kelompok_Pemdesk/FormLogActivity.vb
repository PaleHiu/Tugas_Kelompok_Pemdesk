Public Class FormLogActivity

    Private Sub FormLogActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Log Activity"

        ' Isi combobox categories
        cmbCategories.Items.Add("")
        cmbCategories.Items.Add("U60 Male")
        cmbCategories.Items.Add("U66 Male")
        cmbCategories.Items.Add("U73 Male")
        cmbCategories.SelectedIndex = 0

        ' Set tanggal hari ini
        dtpDate.Value = DateTime.Today

        ' Setup kolom ListView sesuai screenshot asli
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

    Public Sub InsertLog(activityDetail As String, activityType As String, matchTime As String)
        ' 1. Kategori default (Bisa disesuaikan dengan ComboBox nantinya)
        Dim category As String = "KUMITE Blank ScoreBoard"

        ' 2. Buat baris baru untuk ListView (Kolom pertama: Categories)
        Dim newItem As New ListViewItem(category)

        ' 3. Isi kolom-kolom sub-item sesuai urutan yang kita buat di Form_Load
        newItem.SubItems.Add(activityDetail) ' Kolom: Activity
        newItem.SubItems.Add(activityType)   ' Kolom: ActivityType
        newItem.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) ' Kolom: Date Time
        newItem.SubItems.Add(matchTime)      ' Kolom: MatchTime

        ' Kolom statis (Bisa dikembangkan nanti jika ada form login/setup pertandingan)
        newItem.SubItems.Add("Admin")        ' UserName
        newItem.SubItems.Add("-")            ' Pool
        newItem.SubItems.Add("-")            ' Round
        newItem.SubItems.Add("-")            ' Match No
        newItem.SubItems.Add("-")            ' RoundStatus
        newItem.SubItems.Add("AKA vs AO")    ' Versus
        newItem.SubItems.Add("1")            ' Tatami

        ' 4. Masukkan baris baru ini ke urutan PALING ATAS (Indeks 0) tabel
        lvActivity.Items.Insert(0, newItem)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        sfd.FileName = "LogActivity_" & dtpDate.Value.ToString("yyyyMMdd")
        If sfd.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("Data berhasil diekspor!" & vbNewLine & sfd.FileName,
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



End Class

