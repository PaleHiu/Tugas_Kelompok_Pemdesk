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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        sfd.FileName = "LogActivity_" & dtpDate.Value.ToString("yyyyMMdd")
        If sfd.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("Data berhasil diekspor!" & vbNewLine & sfd.FileName,
                            "Export Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
