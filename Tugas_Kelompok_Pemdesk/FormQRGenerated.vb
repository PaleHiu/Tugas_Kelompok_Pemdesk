Imports System.Data.SqlTypes
Imports System.Drawing
Imports ZXing
Imports ZXing.Common

Public Class FormQRGenerated

    Private baseUrl As String = "https://kata.yabinya.com/scbscoring"
    Private tatamiID As String = "TM-545FB238400A"
    Private judgeUrls(6) As String

    Private Sub FormQRGenerated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "QR Generated"

        ' Generate URL tiap judge
        For i As Integer = 0 To 6
            judgeUrls(i) = baseUrl & "/login.php?judge=" & (i + 1) & "&tatami=" & tatamiID
        Next
        judgeUrls(0) = "zg0MDBBfDF8SIVER0UxfGp1ZGdlMQ%3D%3D"

        lblTatamiIDValue.Text = tatamiID
        lblDefaultURL.Text = baseUrl

        GenerateAllQR()
        LoadQRValueSet()

        tmrClock.Start()
        UpdateClock()
    End Sub

    ' Ambil PictureBox berdasarkan index langsung tanpa array
    Private Function GetPB(index As Integer) As PictureBox
        Select Case index
            Case 0 : Return pbJ1
            Case 1 : Return pbJ2
            Case 2 : Return pbJ3
            Case 3 : Return pbJ4
            Case 4 : Return pbJ5
            Case 5 : Return pbJ6
            Case 6 : Return pbJ7
            Case Else : Return Nothing
        End Select
    End Function

    Private Sub GenerateAllQR()
        For i As Integer = 0 To 6
            Dim pb As PictureBox = GetPB(i)
            If pb IsNot Nothing Then
                Dim bmp As Bitmap = GenerateQRBitmap(judgeUrls(i), 145, 145)
                pb.Image = bmp
                pb.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Next
    End Sub

    Private Function GenerateQRBitmap(text As String, width As Integer, height As Integer) As Bitmap
        Try
            Dim writer As New BarcodeWriterPixelData()
            writer.Format = BarcodeFormat.QR_CODE
            writer.Options = New EncodingOptions() With {
                .Width = width,
                .Height = height,
                .Margin = 1
            }
            Dim pixelData = writer.Write(text)
            Dim bmp As New Bitmap(pixelData.Width, pixelData.Height, Drawing.Imaging.PixelFormat.Format32bppRgb)
            Dim bmpData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height),
                                        Drawing.Imaging.ImageLockMode.WriteOnly,
                                        Drawing.Imaging.PixelFormat.Format32bppRgb)
            Try
                System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bmpData.Scan0, pixelData.Pixels.Length)
            Finally
                bmp.UnlockBits(bmpData)
            End Try
            Return bmp
        Catch ex As Exception
            Dim bmp As New Bitmap(width, height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
                g.DrawString("QR Error", New Font("Segoe UI", 8), Brushes.Red, 10, 60)
            End Using
            Return bmp
        End Try
    End Function

    Private Sub LoadQRValueSet()
        lvQRValues.Items.Clear()
        For i As Integer = 0 To 6
            Dim item As New ListViewItem("J" & (i + 1))
            item.SubItems.Add(judgeUrls(i))
            lvQRValues.Items.Add(item)
        Next
        If lvQRValues.Items.Count > 0 Then
            lvQRValues.Items(0).BackColor = Color.Yellow
            lvQRValues.Items(0).ForeColor = Color.Blue
        End If
    End Sub

    Private Sub UpdateClock()
        lblDateTime.Text = DateTime.Now.ToString("M/d/yyyy h:mm tt")
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        UpdateClock()
    End Sub

    Private Sub rbYabinya_CheckedChanged(sender As Object, e As EventArgs) Handles rbYabinya.CheckedChanged
        If rbYabinya.Checked Then
            baseUrl = "https://kata.yabinya.com/scbscoring"
            txtBaseURL.Text = baseUrl
            txtBaseURL.ReadOnly = True
            RefreshURLs()
        End If
    End Sub

    Private Sub rbOwn_CheckedChanged(sender As Object, e As EventArgs) Handles rbOwn.CheckedChanged
        If rbOwn.Checked Then
            txtBaseURL.ReadOnly = False
            txtBaseURL.Focus()
        End If
    End Sub

    Private Sub txtBaseURL_TextChanged(sender As Object, e As EventArgs) Handles txtBaseURL.TextChanged
        If rbOwn.Checked Then
            baseUrl = txtBaseURL.Text
            RefreshURLs()
        End If
    End Sub

    Private Sub RefreshURLs()
        For i As Integer = 0 To 6
            judgeUrls(i) = baseUrl & "/login.php?judge=" & (i + 1) & "&tatami=" & tatamiID
        Next
        judgeUrls(0) = "zg0MDBBfDF8SIVER0UxfGp1ZGdlMQ%3D%3D"
        GenerateAllQR()
        LoadQRValueSet()
        lblDefaultURL.Text = baseUrl
    End Sub

    Private Sub btnSaveJ1_Click(sender As Object, e As EventArgs) Handles btnSaveJ1.Click
        SaveQRImage(0)
    End Sub
    Private Sub btnSaveJ2_Click(sender As Object, e As EventArgs) Handles btnSaveJ2.Click
        SaveQRImage(1)
    End Sub
    Private Sub btnSaveJ3_Click(sender As Object, e As EventArgs) Handles btnSaveJ3.Click
        SaveQRImage(2)
    End Sub
    Private Sub btnSaveJ4_Click(sender As Object, e As EventArgs) Handles btnSaveJ4.Click
        SaveQRImage(3)
    End Sub
    Private Sub btnSaveJ5_Click(sender As Object, e As EventArgs) Handles btnSaveJ5.Click
        SaveQRImage(4)
    End Sub
    Private Sub btnSaveJ6_Click(sender As Object, e As EventArgs) Handles btnSaveJ6.Click
        SaveQRImage(5)
    End Sub
    Private Sub btnSaveJ7_Click(sender As Object, e As EventArgs) Handles btnSaveJ7.Click
        SaveQRImage(6)
    End Sub

    Private Sub SaveQRImage(judgeIndex As Integer)
        Dim pb As PictureBox = GetPB(judgeIndex)
        If pb Is Nothing OrElse pb.Image Is Nothing Then Return
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg"
        sfd.FileName = "QR_Judge" & (judgeIndex + 1) & "_" & tatamiID
        If sfd.ShowDialog() = DialogResult.OK Then
            pb.Image.Save(sfd.FileName)
            MessageBox.Show("QR Code berhasil disimpan!", "Simpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CopyQRValue(judgeIndex As Integer)
        Clipboard.SetText(judgeUrls(judgeIndex))
        MessageBox.Show("URL Judge " & (judgeIndex + 1) & " disalin!", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCopyJ1_Click(sender As Object, e As EventArgs) Handles btnCopyJ1.Click
        CopyQRValue(0)
    End Sub
    Private Sub btnCopyJ2_Click(sender As Object, e As EventArgs) Handles btnCopyJ2.Click
        CopyQRValue(1)
    End Sub
    Private Sub btnCopyJ3_Click(sender As Object, e As EventArgs) Handles btnCopyJ3.Click
        CopyQRValue(2)
    End Sub
    Private Sub btnCopyJ4_Click(sender As Object, e As EventArgs) Handles btnCopyJ4.Click
        CopyQRValue(3)
    End Sub
    Private Sub btnCopyJ5_Click(sender As Object, e As EventArgs) Handles btnCopyJ5.Click
        CopyQRValue(4)
    End Sub
    Private Sub btnCopyJ6_Click(sender As Object, e As EventArgs) Handles btnCopyJ6.Click
        CopyQRValue(5)
    End Sub
    Private Sub btnCopyJ7_Click(sender As Object, e As EventArgs) Handles btnCopyJ7.Click
        CopyQRValue(6)
    End Sub

    Private Sub btnSavePDF_Click(sender As Object, e As EventArgs) Handles btnSavePDF.Click
        MessageBox.Show("Fitur Save QR Code to PDF memerlukan library tambahan (PdfSharp)." & vbCrLf &
                        "Silakan install via NuGet: PdfSharp", "Info PDF",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
