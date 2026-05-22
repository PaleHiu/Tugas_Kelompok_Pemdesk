<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormQRGenerated
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        ' ── Declare all controls ──────────────────────────────────────
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblMainTitle = New System.Windows.Forms.Label()

        ' Judge PictureBoxes
        Me.pbJ1 = New System.Windows.Forms.PictureBox()
        Me.pbJ2 = New System.Windows.Forms.PictureBox()
        Me.pbJ3 = New System.Windows.Forms.PictureBox()
        Me.pbJ4 = New System.Windows.Forms.PictureBox()
        Me.pbJ5 = New System.Windows.Forms.PictureBox()
        Me.pbJ6 = New System.Windows.Forms.PictureBox()
        Me.pbJ7 = New System.Windows.Forms.PictureBox()

        ' Judge Labels
        Me.lblJ1 = New System.Windows.Forms.Label()
        Me.lblJ2 = New System.Windows.Forms.Label()
        Me.lblJ3 = New System.Windows.Forms.Label()
        Me.lblJ4 = New System.Windows.Forms.Label()
        Me.lblJ5 = New System.Windows.Forms.Label()
        Me.lblJ6 = New System.Windows.Forms.Label()
        Me.lblJ7 = New System.Windows.Forms.Label()

        ' Save buttons per judge
        Me.btnSaveJ1 = New System.Windows.Forms.Button()
        Me.btnSaveJ2 = New System.Windows.Forms.Button()
        Me.btnSaveJ3 = New System.Windows.Forms.Button()
        Me.btnSaveJ4 = New System.Windows.Forms.Button()
        Me.btnSaveJ5 = New System.Windows.Forms.Button()
        Me.btnSaveJ6 = New System.Windows.Forms.Button()
        Me.btnSaveJ7 = New System.Windows.Forms.Button()

        ' Scan hint label
        Me.lblScanHint = New System.Windows.Forms.Label()

        ' Tatami ID area
        Me.pnlTatamiID = New System.Windows.Forms.Panel()
        Me.lblTatamiIDTitle = New System.Windows.Forms.Label()
        Me.lblTatamiIDValue = New System.Windows.Forms.Label()
        Me.lblDefaultURLTitle = New System.Windows.Forms.Label()
        Me.lblDefaultURL = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()

        ' Right panel
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.rbYabinya = New System.Windows.Forms.RadioButton()
        Me.rbOwn = New System.Windows.Forms.RadioButton()
        Me.lblBaseURL = New System.Windows.Forms.Label()
        Me.txtBaseURL = New System.Windows.Forms.TextBox()
        Me.btnSavePDF = New System.Windows.Forms.Button()

        ' QR Value Set panel
        Me.pnlQRValues = New System.Windows.Forms.Panel()
        Me.lblQRValueTitle = New System.Windows.Forms.Label()
        Me.lvQRValues = New System.Windows.Forms.ListView()
        Me.colJ = New System.Windows.Forms.ColumnHeader()
        Me.colURL = New System.Windows.Forms.ColumnHeader()
        Me.colCopy = New System.Windows.Forms.ColumnHeader()

        ' Copy buttons
        Me.btnCopyJ1 = New System.Windows.Forms.Button()
        Me.btnCopyJ2 = New System.Windows.Forms.Button()
        Me.btnCopyJ3 = New System.Windows.Forms.Button()
        Me.btnCopyJ4 = New System.Windows.Forms.Button()
        Me.btnCopyJ5 = New System.Windows.Forms.Button()
        Me.btnCopyJ6 = New System.Windows.Forms.Button()
        Me.btnCopyJ7 = New System.Windows.Forms.Button()

        ' Timer
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)

        ' ── Suspend ──────────────────────────────────────────────────
        Me.pnlLeft.SuspendLayout()
        Me.pnlTatamiID.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlQRValues.SuspendLayout()
        CType(Me.pbJ1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '=============================================================
        ' TIMER
        '=============================================================
        Me.tmrClock.Interval = 1000
        Me.tmrClock.Enabled = True

        '=============================================================
        ' pnlLeft  (area QR kode 7 judge)
        '=============================================================
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Location = New System.Drawing.Point(8, 8)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(555, 615)
        Me.pnlLeft.TabIndex = 0

        ' lblMainTitle
        Me.lblMainTitle.AutoSize = False
        Me.lblMainTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMainTitle.Location = New System.Drawing.Point(50, 12)
        Me.lblMainTitle.Size = New System.Drawing.Size(460, 28)
        Me.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMainTitle.Text = "QR Code For Direct Access Judges"
        Me.pnlLeft.Controls.Add(Me.lblMainTitle)

        ' ── Row 1: Judge 1,2,3 ──
        Dim rowY1 As Integer = 48
        Dim rowY1Lbl As Integer = rowY1 + 148

        ' PB J1
        Me.pbJ1.BackColor = System.Drawing.Color.LightGray
        Me.pbJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ1.Location = New System.Drawing.Point(28, rowY1)
        Me.pbJ1.Size = New System.Drawing.Size(145, 145)
        Me.pbJ1.TabIndex = 10
        Me.pbJ1.TabStop = False
        Me.pnlLeft.Controls.Add(Me.pbJ1)

        ' PB J2
        Me.pbJ2.BackColor = System.Drawing.Color.LightGray
        Me.pbJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ2.Location = New System.Drawing.Point(203, rowY1)
        Me.pbJ2.Size = New System.Drawing.Size(145, 145)
        Me.pbJ2.TabIndex = 11
        Me.pbJ2.TabStop = False
        Me.pnlLeft.Controls.Add(Me.pbJ2)

        ' PB J3
        Me.pbJ3.BackColor = System.Drawing.Color.LightGray
        Me.pbJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ3.Location = New System.Drawing.Point(378, rowY1)
        Me.pbJ3.Size = New System.Drawing.Size(145, 145)
        Me.pbJ3.TabIndex = 12
        Me.pbJ3.TabStop = False
        Me.pnlLeft.Controls.Add(Me.pbJ3)

        ' lblJ1
        Me.lblJ1.AutoSize = True
        Me.lblJ1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ1.Location = New System.Drawing.Point(28, rowY1Lbl + 3)
        Me.lblJ1.Text = "JUDGE 1"
        Me.pnlLeft.Controls.Add(Me.lblJ1)

        ' btnSaveJ1
        Me.btnSaveJ1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ1.Location = New System.Drawing.Point(95, rowY1Lbl)
        Me.btnSaveJ1.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ1.Text = "Save 🖼"
        Me.btnSaveJ1.UseVisualStyleBackColor = True
        Me.pnlLeft.Controls.Add(Me.btnSaveJ1)

        ' lblJ2
        Me.lblJ2.AutoSize = True
        Me.lblJ2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ2.Location = New System.Drawing.Point(203, rowY1Lbl + 3)
        Me.lblJ2.Text = "JUDGE 2"
        Me.pnlLeft.Controls.Add(Me.lblJ2)

        ' btnSaveJ2
        Me.btnSaveJ2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ2.Location = New System.Drawing.Point(270, rowY1Lbl)
        Me.btnSaveJ2.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ2.Text = "Save 🖼"
        Me.btnSaveJ2.UseVisualStyleBackColor = True
        Me.pnlLeft.Controls.Add(Me.btnSaveJ2)

        ' lblJ3
        Me.lblJ3.AutoSize = True
        Me.lblJ3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ3.Location = New System.Drawing.Point(378, rowY1Lbl + 3)
        Me.lblJ3.Text = "JUDGE 3"
        Me.pnlLeft.Controls.Add(Me.lblJ3)

        ' btnSaveJ3
        Me.btnSaveJ3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ3.Location = New System.Drawing.Point(445, rowY1Lbl)
        Me.btnSaveJ3.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ3.Text = "Save 🖼"
        Me.btnSaveJ3.UseVisualStyleBackColor = True
        Me.pnlLeft.Controls.Add(Me.btnSaveJ3)

        ' ── Row 2: Judge 4,5,6 ──
        Dim rowY2 As Integer = rowY1Lbl + 34
        Dim rowY2Lbl As Integer = rowY2 + 148

        ' PB J4
        Me.pbJ4.BackColor = System.Drawing.Color.LightGray
        Me.pbJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ4.Location = New System.Drawing.Point(28, rowY2)
        Me.pbJ4.Size = New System.Drawing.Size(145, 145)
        Me.pbJ4.TabIndex = 13
        Me.pbJ4.TabStop = False
        Me.pnlLeft.Controls.Add(Me.pbJ4)

        ' PB J5
        Me.pbJ5.BackColor = System.Drawing.Color.LightGray
        Me.pbJ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ5.Location = New System.Drawing.Point(203, rowY2)
        Me.pbJ5.Size = New System.Drawing.Size(145, 145)
        Me.pbJ5.TabIndex = 14
        Me.pbJ5.TabStop = False
        Me.pnlLeft.Controls.Add(Me.pbJ5)

        ' PB J6
        Me.pbJ6.BackColor = System.Drawing.Color.LightGray
        Me.pbJ6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ6.Location = New System.Drawing.Point(378, rowY2)
        Me.pbJ6.Size = New System.Drawing.Size(145, 145)
        Me.pbJ6.TabIndex = 15
        Me.pbJ6.TabStop = False
        Me.pnlLeft.Controls.Add(Me.pbJ6)

        ' lblJ4
        Me.lblJ4.AutoSize = True
        Me.lblJ4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ4.Location = New System.Drawing.Point(28, rowY2Lbl + 3)
        Me.lblJ4.Text = "JUDGE 4"
        Me.pnlLeft.Controls.Add(Me.lblJ4)

        ' btnSaveJ4
        Me.btnSaveJ4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ4.Location = New System.Drawing.Point(95, rowY2Lbl)
        Me.btnSaveJ4.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ4.Text = "Save 🖼"
        Me.btnSaveJ4.UseVisualStyleBackColor = True
        Me.pnlLeft.Controls.Add(Me.btnSaveJ4)

        ' lblJ5
        Me.lblJ5.AutoSize = True
        Me.lblJ5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ5.Location = New System.Drawing.Point(203, rowY2Lbl + 3)
        Me.lblJ5.Text = "JUDGE 5"
        Me.pnlLeft.Controls.Add(Me.lblJ5)

        ' btnSaveJ5
        Me.btnSaveJ5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ5.Location = New System.Drawing.Point(270, rowY2Lbl)
        Me.btnSaveJ5.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ5.Text = "Save 🖼"
        Me.btnSaveJ5.UseVisualStyleBackColor = True
        Me.pnlLeft.Controls.Add(Me.btnSaveJ5)

        ' lblJ6
        Me.lblJ6.AutoSize = True
        Me.lblJ6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ6.Location = New System.Drawing.Point(378, rowY2Lbl + 3)
        Me.lblJ6.Text = "JUDGE 6"
        Me.pnlLeft.Controls.Add(Me.lblJ6)

        ' btnSaveJ6
        Me.btnSaveJ6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ6.Location = New System.Drawing.Point(445, rowY2Lbl)
        Me.btnSaveJ6.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ6.Text = "Save 🖼"
        Me.btnSaveJ6.UseVisualStyleBackColor = True
        Me.pnlLeft.Controls.Add(Me.btnSaveJ6)

        ' lblScanHint
        Me.lblScanHint.AutoSize = True
        Me.lblScanHint.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblScanHint.ForeColor = System.Drawing.Color.DimGray
        Me.lblScanHint.Location = New System.Drawing.Point(345, rowY2Lbl + 32)
        Me.lblScanHint.Text = "Scan with QR Code Reader" & vbNewLine & "Copy URL then open with browser"
        Me.pnlLeft.Controls.Add(Me.lblScanHint)

        ' ── Row 3: Judge 7 + Tatami ID ──
        Dim rowY3 As Integer = rowY2Lbl + 62
        Dim rowY3Lbl As Integer = rowY3 + 148

        ' PB J7
        Me.pbJ7.BackColor = System.Drawing.Color.LightGray
        Me.pbJ7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ7.Location = New System.Drawing.Point(28, rowY3)
        Me.pbJ7.Size = New System.Drawing.Size(145, 145)
        Me.pbJ7.TabIndex = 16
        Me.pbJ7.TabStop = False
        Me.pnlLeft.Controls.Add(Me.pbJ7)

        ' lblJ7
        Me.lblJ7.AutoSize = True
        Me.lblJ7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ7.Location = New System.Drawing.Point(28, rowY3Lbl + 3)
        Me.lblJ7.Text = "JUDGE 7"
        Me.pnlLeft.Controls.Add(Me.lblJ7)

        ' btnSaveJ7
        Me.btnSaveJ7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ7.Location = New System.Drawing.Point(95, rowY3Lbl)
        Me.btnSaveJ7.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ7.Text = "Save 🖼"
        Me.btnSaveJ7.UseVisualStyleBackColor = True
        Me.pnlLeft.Controls.Add(Me.btnSaveJ7)

        ' ── pnlTatamiID (kotak Tatami ID info) ──
        Me.pnlTatamiID.BackColor = System.Drawing.Color.White
        Me.pnlTatamiID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTatamiID.Location = New System.Drawing.Point(185, rowY3)
        Me.pnlTatamiID.Size = New System.Drawing.Size(340, 155)
        Me.pnlTatamiID.TabIndex = 50

        Me.lblTatamiIDTitle.AutoSize = False
        Me.lblTatamiIDTitle.BackColor = System.Drawing.Color.Gray
        Me.lblTatamiIDTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTatamiIDTitle.ForeColor = System.Drawing.Color.White
        Me.lblTatamiIDTitle.Location = New System.Drawing.Point(8, 10)
        Me.lblTatamiIDTitle.Size = New System.Drawing.Size(90, 22)
        Me.lblTatamiIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTatamiIDTitle.Text = "TATAMI ID"
        Me.pnlTatamiID.Controls.Add(Me.lblTatamiIDTitle)

        Me.lblTatamiIDValue.AutoSize = True
        Me.lblTatamiIDValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTatamiIDValue.Location = New System.Drawing.Point(6, 38)
        Me.lblTatamiIDValue.Text = "TM-545FB238400A"
        Me.pnlTatamiID.Controls.Add(Me.lblTatamiIDValue)

        Me.lblDefaultURLTitle.AutoSize = True
        Me.lblDefaultURLTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblDefaultURLTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblDefaultURLTitle.Location = New System.Drawing.Point(8, 90)
        Me.lblDefaultURLTitle.Text = "Default URL Access :"
        Me.pnlTatamiID.Controls.Add(Me.lblDefaultURLTitle)

        Me.lblDefaultURL.AutoSize = True
        Me.lblDefaultURL.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDefaultURL.Location = New System.Drawing.Point(8, 108)
        Me.lblDefaultURL.Text = "https://kata.yabinya.com/scbscoring"
        Me.pnlTatamiID.Controls.Add(Me.lblDefaultURL)

        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.lblDateTime.Location = New System.Drawing.Point(170, 130)
        Me.lblDateTime.Text = "5/21/2026 2:43 PM"
        Me.pnlTatamiID.Controls.Add(Me.lblDateTime)

        Me.pnlLeft.Controls.Add(Me.pnlTatamiID)

        '=============================================================
        ' pnlRight  (server option + QR value set)
        '=============================================================
        Me.pnlRight.Location = New System.Drawing.Point(572, 8)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(310, 615)
        Me.pnlRight.TabIndex = 1

        ' rbYabinya
        Me.rbYabinya.AutoSize = True
        Me.rbYabinya.Checked = True
        Me.rbYabinya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbYabinya.Location = New System.Drawing.Point(8, 10)
        Me.rbYabinya.Name = "rbYabinya"
        Me.rbYabinya.TabIndex = 0
        Me.rbYabinya.Text = "Yabinya Server"
        Me.rbYabinya.UseVisualStyleBackColor = True
        Me.pnlRight.Controls.Add(Me.rbYabinya)

        ' rbOwn
        Me.rbOwn.AutoSize = True
        Me.rbOwn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbOwn.Location = New System.Drawing.Point(165, 10)
        Me.rbOwn.Name = "rbOwn"
        Me.rbOwn.TabIndex = 1
        Me.rbOwn.Text = "Own Server"
        Me.rbOwn.UseVisualStyleBackColor = True
        Me.pnlRight.Controls.Add(Me.rbOwn)

        ' lblBaseURL
        Me.lblBaseURL.AutoSize = True
        Me.lblBaseURL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBaseURL.Location = New System.Drawing.Point(8, 42)
        Me.lblBaseURL.Text = "Base URL"
        Me.pnlRight.Controls.Add(Me.lblBaseURL)

        ' txtBaseURL
        Me.txtBaseURL.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtBaseURL.Location = New System.Drawing.Point(75, 39)
        Me.txtBaseURL.Name = "txtBaseURL"
        Me.txtBaseURL.ReadOnly = True
        Me.txtBaseURL.Size = New System.Drawing.Size(228, 23)
        Me.txtBaseURL.Text = "https://kata.yabinya.com/scbscoring"
        Me.txtBaseURL.TabIndex = 2
        Me.pnlRight.Controls.Add(Me.txtBaseURL)

        ' btnSavePDF
        Me.btnSavePDF.BackColor = System.Drawing.Color.White
        Me.btnSavePDF.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnSavePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePDF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSavePDF.Location = New System.Drawing.Point(75, 72)
        Me.btnSavePDF.Name = "btnSavePDF"
        Me.btnSavePDF.Size = New System.Drawing.Size(190, 30)
        Me.btnSavePDF.TabIndex = 3
        Me.btnSavePDF.Text = "Save QR Code to PDF  🟥"
        Me.btnSavePDF.UseVisualStyleBackColor = False
        Me.pnlRight.Controls.Add(Me.btnSavePDF)

        '=============================================================
        ' pnlQRValues  (tabel QR value set - background kuning header)
        '=============================================================
        Me.pnlQRValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQRValues.Location = New System.Drawing.Point(8, 260)
        Me.pnlQRValues.Name = "pnlQRValues"
        Me.pnlQRValues.Size = New System.Drawing.Size(294, 350)
        Me.pnlQRValues.TabIndex = 4

        ' lblQRValueTitle
        Me.lblQRValueTitle.AutoSize = False
        Me.lblQRValueTitle.BackColor = System.Drawing.Color.Yellow
        Me.lblQRValueTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblQRValueTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblQRValueTitle.Size = New System.Drawing.Size(292, 30)
        Me.lblQRValueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblQRValueTitle.Text = "QR Code value set"
        Me.pnlQRValues.Controls.Add(Me.lblQRValueTitle)

        ' lvQRValues
        Me.lvQRValues.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvQRValues.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colJ, Me.colURL, Me.colCopy})
        Me.lvQRValues.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lvQRValues.FullRowSelect = True
        Me.lvQRValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvQRValues.Location = New System.Drawing.Point(0, 30)
        Me.lvQRValues.Name = "lvQRValues"
        Me.lvQRValues.Size = New System.Drawing.Size(250, 316)
        Me.lvQRValues.TabIndex = 0
        Me.lvQRValues.UseCompatibleStateImageBehavior = False
        Me.lvQRValues.View = System.Windows.Forms.View.Details

        Me.colJ.Text = "J"
        Me.colJ.Width = 28

        Me.colURL.Text = "URL"
        Me.colURL.Width = 205

        Me.colCopy.Text = ""
        Me.colCopy.Width = 0

        Me.pnlQRValues.Controls.Add(Me.lvQRValues)

        ' Copy buttons (overlay di kanan lvQRValues)
        Dim copyBtns() As System.Windows.Forms.Button = {
            Me.btnCopyJ1, Me.btnCopyJ2, Me.btnCopyJ3, Me.btnCopyJ4,
            Me.btnCopyJ5, Me.btnCopyJ6, Me.btnCopyJ7}

        For i As Integer = 0 To 6
            copyBtns(i).Font = New System.Drawing.Font("Segoe UI", 7.0!)
            copyBtns(i).Location = New System.Drawing.Point(252, 30 + i * 45)
            copyBtns(i).Size = New System.Drawing.Size(38, 42)
            copyBtns(i).Text = "📋"
            copyBtns(i).UseVisualStyleBackColor = True
            copyBtns(i).FlatStyle = System.Windows.Forms.FlatStyle.Flat
            copyBtns(i).FlatAppearance.BorderSize = 1
            Me.pnlQRValues.Controls.Add(copyBtns(i))
        Next

        Me.pnlRight.Controls.Add(Me.pnlQRValues)

        '=============================================================
        ' FormQRGenerated (form utama)
        '=============================================================
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(236, 236, 236)
        Me.ClientSize = New System.Drawing.Size(890, 632)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormQRGenerated"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QR Generated"

        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlTatamiID.ResumeLayout(False)
        Me.pnlTatamiID.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.pnlQRValues.ResumeLayout(False)
        CType(Me.pbJ1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    ' ── Control Declarations ──────────────────────────────────────────
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblMainTitle As System.Windows.Forms.Label
    Friend WithEvents pbJ1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbJ2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbJ3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbJ4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbJ5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbJ6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbJ7 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJ1 As System.Windows.Forms.Label
    Friend WithEvents lblJ2 As System.Windows.Forms.Label
    Friend WithEvents lblJ3 As System.Windows.Forms.Label
    Friend WithEvents lblJ4 As System.Windows.Forms.Label
    Friend WithEvents lblJ5 As System.Windows.Forms.Label
    Friend WithEvents lblJ6 As System.Windows.Forms.Label
    Friend WithEvents lblJ7 As System.Windows.Forms.Label
    Friend WithEvents btnSaveJ1 As System.Windows.Forms.Button
    Friend WithEvents btnSaveJ2 As System.Windows.Forms.Button
    Friend WithEvents btnSaveJ3 As System.Windows.Forms.Button
    Friend WithEvents btnSaveJ4 As System.Windows.Forms.Button
    Friend WithEvents btnSaveJ5 As System.Windows.Forms.Button
    Friend WithEvents btnSaveJ6 As System.Windows.Forms.Button
    Friend WithEvents btnSaveJ7 As System.Windows.Forms.Button
    Friend WithEvents lblScanHint As System.Windows.Forms.Label
    Friend WithEvents pnlTatamiID As System.Windows.Forms.Panel
    Friend WithEvents lblTatamiIDTitle As System.Windows.Forms.Label
    Friend WithEvents lblTatamiIDValue As System.Windows.Forms.Label
    Friend WithEvents lblDefaultURLTitle As System.Windows.Forms.Label
    Friend WithEvents lblDefaultURL As System.Windows.Forms.Label
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents rbYabinya As System.Windows.Forms.RadioButton
    Friend WithEvents rbOwn As System.Windows.Forms.RadioButton
    Friend WithEvents lblBaseURL As System.Windows.Forms.Label
    Friend WithEvents txtBaseURL As System.Windows.Forms.TextBox
    Friend WithEvents btnSavePDF As System.Windows.Forms.Button
    Friend WithEvents pnlQRValues As System.Windows.Forms.Panel
    Friend WithEvents lblQRValueTitle As System.Windows.Forms.Label
    Friend WithEvents lvQRValues As System.Windows.Forms.ListView
    Friend WithEvents colJ As System.Windows.Forms.ColumnHeader
    Friend WithEvents colURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCopy As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCopyJ1 As System.Windows.Forms.Button
    Friend WithEvents btnCopyJ2 As System.Windows.Forms.Button
    Friend WithEvents btnCopyJ3 As System.Windows.Forms.Button
    Friend WithEvents btnCopyJ4 As System.Windows.Forms.Button
    Friend WithEvents btnCopyJ5 As System.Windows.Forms.Button
    Friend WithEvents btnCopyJ6 As System.Windows.Forms.Button
    Friend WithEvents btnCopyJ7 As System.Windows.Forms.Button
    Friend WithEvents tmrClock As System.Windows.Forms.Timer

End Class
