Public Class FromKeyboardShortcutKata
    ' ==========================================================
    ' DEKLARASI GLOBAL (COPY DARI FormKeyboardShortcut)
    ' ==========================================================
    Public Shared IsShortcutEnabled As Boolean = True
    Public Shared ShortcutMap As New Dictionary(Of String, String)()

    ' Variabel penanda apakah aplikasi sedang merekam input keyboard
    Private isRecording As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FromKeyboardShortcutKata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.KeyPreview = True ' Form menangkap keyboard duluan

        If lvShortcuts IsNot Nothing Then
            lvShortcuts.OwnerDraw = True
            isiDataShortcut()
        End If

        ' Sinkronisasi UI tombol ON/OFF dengan status global saat form dibuka
        ' Default to OFF visual like reference (but IsShortcutEnabled may be True)
        If IsShortcutEnabled Then
            lblStatusValue.Text = "ON"
            lblStatusValue.ForeColor = Color.FromArgb(0, 192, 239)
            btnToggle.BackColor = Color.FromArgb(0, 120, 215)
        Else
            lblStatusValue.Text = "OFF"
            lblStatusValue.ForeColor = Color.FromArgb(230, 76, 60)
            btnToggle.BackColor = Color.FromArgb(230, 76, 60)
        End If
    End Sub

    Private Sub FromKeyboardShortcutKata_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If isRecording Then
            If e.KeyCode = Keys.ControlKey Or e.KeyCode = Keys.ShiftKey Or e.KeyCode = Keys.Menu Then
                Exit Sub
            End If

            Dim strShortcut As String = ""
            If e.Control Then strShortcut &= "Control+"
            If e.Shift Then strShortcut &= "Shift+"
            If e.Alt Then strShortcut &= "Alt+"
            strShortcut &= e.KeyCode.ToString()

            If lvShortcuts.SelectedItems.Count > 0 Then
                Dim isDuplicate As Boolean = False
                Dim duplicateActionName As String = ""

                For Each item As ListViewItem In lvShortcuts.Items
                    If item IsNot lvShortcuts.SelectedItems(0) Then
                        If item.SubItems(1).Text = strShortcut Then
                            isDuplicate = True
                            duplicateActionName = item.Text
                            Exit For
                        End If
                    End If
                Next

                If isDuplicate Then
                    MessageBox.Show($"Kombinasi tombol '{strShortcut}' sudah digunakan untuk aksi '{duplicateActionName}'." & vbCrLf & "Sistem mencegah duplikasi. Silakan tekan kombinasi tombol yang lain.", "Peringatan Duplikasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.SuppressKeyPress = True
                    e.Handled = True
                    Exit Sub
                End If

                lvShortcuts.SelectedItems(0).SubItems(1).Text = strShortcut

                isRecording = False
                txtCurrentAction.Text = $"Shortcut for [{lvShortcuts.SelectedItems(0).Text}] changed to: {strShortcut}"
                txtCurrentAction.ForeColor = Color.Black

                btnChange.Enabled = True

                btnSave.Enabled = True
                btnSave.ForeColor = Color.Black
            End If

            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        IsShortcutEnabled = Not IsShortcutEnabled
        UpdateToggleUI()
    End Sub

    Private Sub UpdateToggleUI()
        If IsShortcutEnabled Then
            lblStatusValue.Text = "ON"
            lblStatusValue.ForeColor = Color.FromArgb(0, 192, 239)
            btnToggle.BackColor = Color.FromArgb(0, 120, 215)
            btnToggle.TextAlign = ContentAlignment.MiddleRight
        Else
            lblStatusValue.Text = "OFF"
            lblStatusValue.ForeColor = Color.Gray
            btnToggle.BackColor = Color.Gray
            btnToggle.TextAlign = ContentAlignment.MiddleLeft
        End If
    End Sub

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

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lvShortcuts.SelectedItems.Count > 0 Then
            lvShortcuts.SelectedItems(0).SubItems(1).Text = ""
            txtCurrentAction.Text = $"Shortcut for [{lvShortcuts.SelectedItems(0).Text}] has been removed."
            btnSave.Enabled = True
            btnSave.ForeColor = Color.Black
        Else
            MessageBox.Show("Pilih shortcut yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ShortcutMap.Clear()

        For Each item As ListViewItem In lvShortcuts.Items
            Dim actionName As String = item.Text
            Dim keysCombo As String = item.SubItems(1).Text

            If Not String.IsNullOrWhiteSpace(keysCombo) Then
                ShortcutMap(actionName) = keysCombo
            End If
        Next

        btnSave.Enabled = False
        btnSave.ForeColor = Color.DarkGray

        MessageBox.Show("Pengaturan Keyboard Shortcut berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim confirm = MessageBox.Show("Apakah Anda yakin ingin mengembalikan semua shortcut ke pengaturan pabrik (Default)?", "Konfirmasi Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            ShortcutMap.Clear()
            isiDataShortcut()

            btnSave.Enabled = True
            btnSave.ForeColor = Color.Black
            txtCurrentAction.Text = "Shortcuts reset to default. Please click 'Save' to apply."
        End If
    End Sub

    Private Sub isiDataShortcut()
        If lvShortcuts Is Nothing Then Exit Sub
        lvShortcuts.Items.Clear()

        If ShortcutMap.Count = 0 Then
            ShortcutMap.Add("Start-Close Scoreboard", "Control+B")
            ShortcutMap.Add("Timer Waiting Start-Stop", "Control+W")
            ShortcutMap.Add("Match Timer Start-Stop", "Control+T")
            ShortcutMap.Add("Match Timer Reset", "Control+R")
            ShortcutMap.Add("Hide-Show KATA Timer", "Control+H")
            ShortcutMap.Add("Show Winner", "Control+E")
            ShortcutMap.Add("Show Score to Scoreboard", "Control+K")
            ShortcutMap.Add("Assign Task to Judges", "Control+J")
            ShortcutMap.Add("Next Match", "Control+N")
            ShortcutMap.Add("Save Match Result", "Control+S")

            ShortcutMap.Add("Show Competitor 1 (AKA)", "Control+D1")
            ShortcutMap.Add("Show Competitor 2 (AO)", "Control+D2")
            ShortcutMap.Add("Show All Competitor", "Control+D3")
        End If

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
            If e.Item.Text.Contains("(AKA)") Then textColor = Color.Crimson
            If e.Item.Text.Contains("(AO)") Then textColor = Color.DodgerBlue
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
