Public Class FormKeyboardShortcut
    ' ==========================================================
    ' DEKLARASI GLOBAL (UNTUK INTEGRASI KE KUMITEMAINCONTROL NANTINYA)
    ' ==========================================================
    Public Shared IsShortcutEnabled As Boolean = True
    Public Shared ShortcutMap As New Dictionary(Of String, String)()

    ' Variabel penanda apakah aplikasi sedang merekam input keyboard
    Private isRecording As Boolean = False

    Private Sub FormKeyboardShortcut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.KeyPreview = True ' PENTING: Form menangkap keyboard duluan

        If lvShortcuts IsNot Nothing Then
            lvShortcuts.OwnerDraw = True
            isiDataShortcut()
        End If

        ' Sinkronisasi UI tombol ON/OFF dengan status global saat form dibuka
        UpdateToggleUI()
    End Sub

    ' ==========================================================
    ' FUNGSI 1: MENDETEKSI & MEREKAM TOMBOL KEYBOARD (UPDATE: ANTI DUPLIKAT)
    ' ==========================================================
    Private Sub FormKeyboardShortcut_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If isRecording Then
            ' Jangan rekam jika hanya menekan tombol modifier (Ctrl/Shift/Alt) sendirian
            If e.KeyCode = Keys.ControlKey Or e.KeyCode = Keys.ShiftKey Or e.KeyCode = Keys.Menu Then
                Exit Sub
            End If

            ' Susun kombinasi shortcut
            Dim strShortcut As String = ""
            If e.Control Then strShortcut &= "Control+"
            If e.Shift Then strShortcut &= "Shift+"
            If e.Alt Then strShortcut &= "Alt+"
            strShortcut &= e.KeyCode.ToString()

            If lvShortcuts.SelectedItems.Count > 0 Then
                ' ---------------------------------------------------
                ' ALGORITMA ANTI-DUPLIKASI (NEW)
                ' ---------------------------------------------------
                Dim isDuplicate As Boolean = False
                Dim duplicateActionName As String = ""

                ' Sisir seluruh baris di tabel untuk mencari kesamaan
                For Each item As ListViewItem In lvShortcuts.Items
                    ' Abaikan pengecekan pada baris yang sedang kita ubah saat ini
                    If item IsNot lvShortcuts.SelectedItems(0) Then
                        ' Jika shortcut yang ditekan ternyata sama dengan baris lain
                        If item.SubItems(1).Text = strShortcut Then
                            isDuplicate = True
                            duplicateActionName = item.Text
                            Exit For ' Hentikan pencarian, sudah ketemu duplikat
                        End If
                    End If
                Next

                ' Jika terdeteksi duplikat, blokir aksi tersebut
                If isDuplicate Then
                    MessageBox.Show($"Kombinasi tombol '{strShortcut}' sudah digunakan untuk aksi '{duplicateActionName}'." & vbCrLf & "Sistem mencegah duplikasi. Silakan tekan kombinasi tombol yang lain.", "Peringatan Duplikasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    ' Hentikan perintah Windows, tapi biarkan form tetap mode "Recording" 
                    ' agar operator bisa langsung mencoba tombol lain tanpa harus klik "Change" lagi.
                    e.SuppressKeyPress = True
                    e.Handled = True
                    Exit Sub
                End If
                ' ---------------------------------------------------

                ' Jika LULUS pengecekan duplikat, terapkan ke tabel
                lvShortcuts.SelectedItems(0).SubItems(1).Text = strShortcut

                ' Selesai merekam, kembalikan UI
                isRecording = False
                txtCurrentAction.Text = $"Shortcut for [{lvShortcuts.SelectedItems(0).Text}] changed to: {strShortcut}"
                txtCurrentAction.ForeColor = Color.Black

                btnChange.Enabled = True

                ' Nyalakan tombol Save
                btnSave.Enabled = True
                btnSave.ForeColor = Color.Black
            End If

            ' Hentikan fungsi bawaan windows agar tidak bunyi "ding" error
            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub

    ' ==========================================================
    ' FUNGSI 2: LOGIKA BUTTON (TOGGLE, CHANGE, REMOVE, SAVE, RESET)
    ' ==========================================================

    ' --- TOGGLE ON/OFF ---
    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        ' Ubah status global
        IsShortcutEnabled = Not IsShortcutEnabled
        UpdateToggleUI()
    End Sub

    Private Sub UpdateToggleUI()
        If IsShortcutEnabled Then
            lblStatusValue.Text = "ON"
            lblStatusValue.ForeColor = Color.FromArgb(0, 192, 239) ' Cyan
            btnToggle.BackColor = Color.FromArgb(0, 120, 215) ' Blue
            btnToggle.TextAlign = ContentAlignment.MiddleRight
        Else
            lblStatusValue.Text = "OFF"
            lblStatusValue.ForeColor = Color.Gray
            btnToggle.BackColor = Color.Gray
            btnToggle.TextAlign = ContentAlignment.MiddleLeft
        End If
    End Sub

    ' --- BUTTON CHANGE ---
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If lvShortcuts.SelectedItems.Count > 0 Then
            isRecording = True
            txtCurrentAction.Text = ">>> SEKARANG TEKAN KOMBINASI TOMBOL DI KEYBOARD ANDA... <<<"
            txtCurrentAction.ForeColor = Color.Red
            btnChange.Enabled = False
        Else
            MessageBox.Show("Pilih salah satu baris di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' --- BUTTON REMOVE ---
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lvShortcuts.SelectedItems.Count > 0 Then
            ' Kosongkan teks shortcut pada baris yang dipilih
            lvShortcuts.SelectedItems(0).SubItems(1).Text = ""

            txtCurrentAction.Text = $"Shortcut for [{lvShortcuts.SelectedItems(0).Text}] has been removed."

            ' Nyalakan tombol save karena ada perubahan
            btnSave.Enabled = True
            btnSave.ForeColor = Color.Black
        Else
            MessageBox.Show("Pilih shortcut yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' --- BUTTON SAVE ---
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Kosongkan memory map lama, lalu simpan ulang dari tabel
        ShortcutMap.Clear()

        For Each item As ListViewItem In lvShortcuts.Items
            Dim actionName As String = item.Text
            Dim keysCombo As String = item.SubItems(1).Text

            ' Simpan ke Dictionary Global (Hanya yang tidak kosong)
            If Not String.IsNullOrWhiteSpace(keysCombo) Then
                ShortcutMap(actionName) = keysCombo
            End If
        Next

        ' Matikan kembali tombol save
        btnSave.Enabled = False
        btnSave.ForeColor = Color.DarkGray

        MessageBox.Show("Pengaturan Keyboard Shortcut berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' --- BUTTON RESET ---
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim confirm = MessageBox.Show("Apakah Anda yakin ingin mengembalikan semua shortcut ke pengaturan pabrik (Default)?", "Konfirmasi Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            ShortcutMap.Clear() ' Hapus semua data
            isiDataShortcut()   ' Generate ulang default

            ' Nyalakan tombol save agar user memvalidasi reset ini
            btnSave.Enabled = True
            btnSave.ForeColor = Color.Black
            txtCurrentAction.Text = "Shortcuts reset to default. Please click 'Save' to apply."
        End If
    End Sub

    ' ==========================================================
    ' FUNGSI 3: DATA BINDING & CUSTOM DRAWING (UI)
    ' ==========================================================
    Private Sub isiDataShortcut()
        If lvShortcuts Is Nothing Then Exit Sub
        lvShortcuts.Items.Clear()

        ' Jika Dictionary kosong (Baru pertama kali buka / Di-reset)
        If ShortcutMap.Count = 0 Then
            ' Set DEFAULT Factory
            ShortcutMap.Add("Start-Close Scoreboard", "Control+B")
            ShortcutMap.Add("Timer Waiting Start-Stop", "Control+W")
            ShortcutMap.Add("Match Timer Start-Stop", "Space")
            ShortcutMap.Add("Next Match", "Control+N")
            ShortcutMap.Add("Save Match Result", "Control+S")
            ShortcutMap.Add("Match Timer Reset", "Control+R")
            ShortcutMap.Add("Show Winner", "Control+E")

            ShortcutMap.Add("AKA - Yuko(1)", "Shift+A")
            ShortcutMap.Add("AKA - Wazaari(2)", "Shift+S")
            ShortcutMap.Add("AKA - Ippon(3)", "Shift+D")
            ShortcutMap.Add("AKA - SENSHU", "Shift+Q")

            ShortcutMap.Add("AO - Yuko(1)", "Shift+J")
            ShortcutMap.Add("AO - Wazaari(2)", "Shift+K")
            ShortcutMap.Add("AO - Ippon(3)", "Shift+L")
            ShortcutMap.Add("AO - SENSHU", "Shift+P")
        End If

        ' Render isi tabel berdasarkan Dictionary Global
        For Each actionName In ShortcutMap.Keys
            tambahItem(actionName, ShortcutMap(actionName))
        Next
    End Sub

    Private Sub tambahItem(action As String, shortcut As String)
        Dim lvi As New ListViewItem(action)
        lvi.SubItems.Add(shortcut)
        lvShortcuts.Items.Add(lvi)
    End Sub

    Private Sub lvShortcuts_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lvShortcuts.DrawColumnHeader
        e.DrawDefault = True
    End Sub

    Private Sub lvShortcuts_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lvShortcuts.DrawSubItem
        If e.Item Is Nothing Then Exit Sub
        If e.Item.Selected Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(135, 206, 250)), e.Bounds)
        Else
            e.Graphics.FillRectangle(Brushes.White, e.Bounds)
        End If

        Dim textColor As Color = Color.Black
        If Not String.IsNullOrEmpty(e.Item.Text) Then
            If e.Item.Text.StartsWith("AKA") Then textColor = Color.Crimson
            If e.Item.Text.StartsWith("AO") Then textColor = Color.DodgerBlue
        End If
        If e.ColumnIndex = 1 Then textColor = Color.Black

        Dim sf As New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near}
        Dim textRect As New Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        e.Graphics.DrawString(e.SubItem.Text, lvShortcuts.Font, New SolidBrush(textColor), textRect, sf)
    End Sub

    Private Sub lvShortcuts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvShortcuts.SelectedIndexChanged
        If lvShortcuts.SelectedItems.Count > 0 Then
            Dim actionName As String = lvShortcuts.SelectedItems(0).Text
            lblCurrentAction.Text = "Current Action : " & actionName
            txtCurrentAction.Text = actionName
        End If
    End Sub
End Class