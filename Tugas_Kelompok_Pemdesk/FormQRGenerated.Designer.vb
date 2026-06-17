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
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.pbJ1 = New System.Windows.Forms.PictureBox()
        Me.pbJ2 = New System.Windows.Forms.PictureBox()
        Me.pbJ3 = New System.Windows.Forms.PictureBox()
        Me.pbJ4 = New System.Windows.Forms.PictureBox()
        Me.pbJ5 = New System.Windows.Forms.PictureBox()
        Me.pbJ6 = New System.Windows.Forms.PictureBox()
        Me.pbJ7 = New System.Windows.Forms.PictureBox()
        Me.lblJ1 = New System.Windows.Forms.Label()
        Me.lblJ2 = New System.Windows.Forms.Label()
        Me.lblJ3 = New System.Windows.Forms.Label()
        Me.lblJ4 = New System.Windows.Forms.Label()
        Me.lblJ5 = New System.Windows.Forms.Label()
        Me.lblJ6 = New System.Windows.Forms.Label()
        Me.lblJ7 = New System.Windows.Forms.Label()
        Me.btnSaveJ1 = New System.Windows.Forms.Button()
        Me.btnSaveJ2 = New System.Windows.Forms.Button()
        Me.btnSaveJ3 = New System.Windows.Forms.Button()
        Me.btnSaveJ4 = New System.Windows.Forms.Button()
        Me.btnSaveJ5 = New System.Windows.Forms.Button()
        Me.btnSaveJ6 = New System.Windows.Forms.Button()
        Me.btnSaveJ7 = New System.Windows.Forms.Button()
        Me.lblScanHint = New System.Windows.Forms.Label()
        Me.pnlTatamiID = New System.Windows.Forms.Panel()
        Me.lblTatamiIDTitle = New System.Windows.Forms.Label()
        Me.lblTatamiIDValue = New System.Windows.Forms.Label()
        Me.lblDefaultURLTitle = New System.Windows.Forms.Label()
        Me.lblDefaultURL = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.rbYabinya = New System.Windows.Forms.RadioButton()
        Me.rbOwn = New System.Windows.Forms.RadioButton()
        Me.lblBaseURL = New System.Windows.Forms.Label()
        Me.txtBaseURL = New System.Windows.Forms.TextBox()
        Me.btnSavePDF = New System.Windows.Forms.Button()
        Me.pnlQRValues = New System.Windows.Forms.Panel()
        Me.lblQRValueTitle = New System.Windows.Forms.Label()
        Me.lvQRValues = New System.Windows.Forms.ListView()
        Me.colJ = New System.Windows.Forms.ColumnHeader()
        Me.colURL = New System.Windows.Forms.ColumnHeader()
        Me.colCopy = New System.Windows.Forms.ColumnHeader()
        Me.btnCopyJ1 = New System.Windows.Forms.Button()
        Me.btnCopyJ2 = New System.Windows.Forms.Button()
        Me.btnCopyJ3 = New System.Windows.Forms.Button()
        Me.btnCopyJ4 = New System.Windows.Forms.Button()
        Me.btnCopyJ5 = New System.Windows.Forms.Button()
        Me.btnCopyJ6 = New System.Windows.Forms.Button()
        Me.btnCopyJ7 = New System.Windows.Forms.Button()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlLeft.SuspendLayout()
        CType(Me.pbJ1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJ7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTatamiID.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlQRValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1000
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(1, 45)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblMainTitle)
        Me.pnlLeft.Controls.Add(Me.pbJ1)
        Me.pnlLeft.Controls.Add(Me.pbJ2)
        Me.pnlLeft.Controls.Add(Me.pbJ3)
        Me.pnlLeft.Controls.Add(Me.lblJ1)
        Me.pnlLeft.Controls.Add(Me.btnSaveJ1)
        Me.pnlLeft.Controls.Add(Me.lblJ2)
        Me.pnlLeft.Controls.Add(Me.btnSaveJ2)
        Me.pnlLeft.Controls.Add(Me.lblJ3)
        Me.pnlLeft.Controls.Add(Me.btnSaveJ3)
        Me.pnlLeft.Controls.Add(Me.pbJ4)
        Me.pnlLeft.Controls.Add(Me.pbJ5)
        Me.pnlLeft.Controls.Add(Me.pbJ6)
        Me.pnlLeft.Controls.Add(Me.lblJ4)
        Me.pnlLeft.Controls.Add(Me.btnSaveJ4)
        Me.pnlLeft.Controls.Add(Me.lblJ5)
        Me.pnlLeft.Controls.Add(Me.btnSaveJ5)
        Me.pnlLeft.Controls.Add(Me.lblJ6)
        Me.pnlLeft.Controls.Add(Me.btnSaveJ6)
        Me.pnlLeft.Controls.Add(Me.lblScanHint)
        Me.pnlLeft.Controls.Add(Me.pbJ7)
        Me.pnlLeft.Controls.Add(Me.lblJ7)
        Me.pnlLeft.Controls.Add(Me.btnSaveJ7)
        Me.pnlLeft.Controls.Add(Me.pnlTatamiID)
        Me.pnlLeft.Location = New System.Drawing.Point(8, 8)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(555, 615)
        Me.pnlLeft.TabIndex = 0
        '
        'lblMainTitle
        '
        Me.lblMainTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMainTitle.Location = New System.Drawing.Point(50, 12)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(460, 28)
        Me.lblMainTitle.TabIndex = 0
        Me.lblMainTitle.Text = "QR Code For Direct Access Judges"
        Me.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbJ1
        '
        Me.pbJ1.BackColor = System.Drawing.Color.LightGray
        Me.pbJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ1.Location = New System.Drawing.Point(28, 48)
        Me.pbJ1.Name = "pbJ1"
        Me.pbJ1.Size = New System.Drawing.Size(145, 145)
        Me.pbJ1.TabIndex = 10
        Me.pbJ1.TabStop = False
        '
        'pbJ2
        '
        Me.pbJ2.BackColor = System.Drawing.Color.LightGray
        Me.pbJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ2.Location = New System.Drawing.Point(203, 48)
        Me.pbJ2.Name = "pbJ2"
        Me.pbJ2.Size = New System.Drawing.Size(145, 145)
        Me.pbJ2.TabIndex = 11
        Me.pbJ2.TabStop = False
        '
        'pbJ3
        '
        Me.pbJ3.BackColor = System.Drawing.Color.LightGray
        Me.pbJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ3.Location = New System.Drawing.Point(378, 48)
        Me.pbJ3.Name = "pbJ3"
        Me.pbJ3.Size = New System.Drawing.Size(145, 145)
        Me.pbJ3.TabIndex = 12
        Me.pbJ3.TabStop = False
        '
        'lblJ1
        '
        Me.lblJ1.AutoSize = True
        Me.lblJ1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ1.Location = New System.Drawing.Point(28, 199)
        Me.lblJ1.Name = "lblJ1"
        Me.lblJ1.Size = New System.Drawing.Size(53, 15)
        Me.lblJ1.TabIndex = 1
        Me.lblJ1.Text = "JUDGE 1"
        '
        'btnSaveJ1
        '
        Me.btnSaveJ1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ1.Location = New System.Drawing.Point(95, 196)
        Me.btnSaveJ1.Name = "btnSaveJ1"
        Me.btnSaveJ1.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ1.TabIndex = 2
        Me.btnSaveJ1.Text = "Save 🖼"
        Me.btnSaveJ1.UseVisualStyleBackColor = True
        '
        'lblJ2
        '
        Me.lblJ2.AutoSize = True
        Me.lblJ2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ2.Location = New System.Drawing.Point(203, 199)
        Me.lblJ2.Name = "lblJ2"
        Me.lblJ2.Size = New System.Drawing.Size(53, 15)
        Me.lblJ2.TabIndex = 3
        Me.lblJ2.Text = "JUDGE 2"
        '
        'btnSaveJ2
        '
        Me.btnSaveJ2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ2.Location = New System.Drawing.Point(270, 196)
        Me.btnSaveJ2.Name = "btnSaveJ2"
        Me.btnSaveJ2.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ2.TabIndex = 4
        Me.btnSaveJ2.Text = "Save 🖼"
        Me.btnSaveJ2.UseVisualStyleBackColor = True
        '
        'lblJ3
        '
        Me.lblJ3.AutoSize = True
        Me.lblJ3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ3.Location = New System.Drawing.Point(378, 199)
        Me.lblJ3.Name = "lblJ3"
        Me.lblJ3.Size = New System.Drawing.Size(53, 15)
        Me.lblJ3.TabIndex = 5
        Me.lblJ3.Text = "JUDGE 3"
        '
        'btnSaveJ3
        '
        Me.btnSaveJ3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ3.Location = New System.Drawing.Point(445, 196)
        Me.btnSaveJ3.Name = "btnSaveJ3"
        Me.btnSaveJ3.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ3.TabIndex = 6
        Me.btnSaveJ3.Text = "Save 🖼"
        Me.btnSaveJ3.UseVisualStyleBackColor = True
        '
        'pbJ4
        '
        Me.pbJ4.BackColor = System.Drawing.Color.LightGray
        Me.pbJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ4.Location = New System.Drawing.Point(28, 230)
        Me.pbJ4.Name = "pbJ4"
        Me.pbJ4.Size = New System.Drawing.Size(145, 145)
        Me.pbJ4.TabIndex = 13
        Me.pbJ4.TabStop = False
        '
        'pbJ5
        '
        Me.pbJ5.BackColor = System.Drawing.Color.LightGray
        Me.pbJ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ5.Location = New System.Drawing.Point(203, 230)
        Me.pbJ5.Name = "pbJ5"
        Me.pbJ5.Size = New System.Drawing.Size(145, 145)
        Me.pbJ5.TabIndex = 14
        Me.pbJ5.TabStop = False
        '
        'pbJ6
        '
        Me.pbJ6.BackColor = System.Drawing.Color.LightGray
        Me.pbJ6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ6.Location = New System.Drawing.Point(378, 230)
        Me.pbJ6.Name = "pbJ6"
        Me.pbJ6.Size = New System.Drawing.Size(145, 145)
        Me.pbJ6.TabIndex = 15
        Me.pbJ6.TabStop = False
        '
        'lblJ4
        '
        Me.lblJ4.AutoSize = True
        Me.lblJ4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ4.Location = New System.Drawing.Point(28, 381)
        Me.lblJ4.Name = "lblJ4"
        Me.lblJ4.Size = New System.Drawing.Size(53, 15)
        Me.lblJ4.TabIndex = 7
        Me.lblJ4.Text = "JUDGE 4"
        '
        'btnSaveJ4
        '
        Me.btnSaveJ4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ4.Location = New System.Drawing.Point(95, 378)
        Me.btnSaveJ4.Name = "btnSaveJ4"
        Me.btnSaveJ4.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ4.TabIndex = 8
        Me.btnSaveJ4.Text = "Save 🖼"
        Me.btnSaveJ4.UseVisualStyleBackColor = True
        '
        'lblJ5
        '
        Me.lblJ5.AutoSize = True
        Me.lblJ5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ5.Location = New System.Drawing.Point(203, 381)
        Me.lblJ5.Name = "lblJ5"
        Me.lblJ5.Size = New System.Drawing.Size(53, 15)
        Me.lblJ5.TabIndex = 9
        Me.lblJ5.Text = "JUDGE 5"
        '
        'btnSaveJ5
        '
        Me.btnSaveJ5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ5.Location = New System.Drawing.Point(270, 378)
        Me.btnSaveJ5.Name = "btnSaveJ5"
        Me.btnSaveJ5.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ5.TabIndex = 10
        Me.btnSaveJ5.Text = "Save 🖼"
        Me.btnSaveJ5.UseVisualStyleBackColor = True
        '
        'lblJ6
        '
        Me.lblJ6.AutoSize = True
        Me.lblJ6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ6.Location = New System.Drawing.Point(378, 381)
        Me.lblJ6.Name = "lblJ6"
        Me.lblJ6.Size = New System.Drawing.Size(53, 15)
        Me.lblJ6.TabIndex = 11
        Me.lblJ6.Text = "JUDGE 6"
        '
        'btnSaveJ6
        '
        Me.btnSaveJ6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ6.Location = New System.Drawing.Point(445, 378)
        Me.btnSaveJ6.Name = "btnSaveJ6"
        Me.btnSaveJ6.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ6.TabIndex = 12
        Me.btnSaveJ6.Text = "Save 🖼"
        Me.btnSaveJ6.UseVisualStyleBackColor = True
        '
        'lblScanHint
        '
        Me.lblScanHint.AutoSize = True
        Me.lblScanHint.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblScanHint.ForeColor = System.Drawing.Color.DimGray
        Me.lblScanHint.Location = New System.Drawing.Point(345, 410)
        Me.lblScanHint.Name = "lblScanHint"
        Me.lblScanHint.Size = New System.Drawing.Size(184, 26)
        Me.lblScanHint.TabIndex = 13
        Me.lblScanHint.Text = "Scan with QR Code Reader" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copy URL then open with browser"
        '
        'pbJ7
        '
        Me.pbJ7.BackColor = System.Drawing.Color.LightGray
        Me.pbJ7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbJ7.Location = New System.Drawing.Point(28, 440)
        Me.pbJ7.Name = "pbJ7"
        Me.pbJ7.Size = New System.Drawing.Size(145, 145)
        Me.pbJ7.TabIndex = 16
        Me.pbJ7.TabStop = False
        '
        'lblJ7
        '
        Me.lblJ7.AutoSize = True
        Me.lblJ7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJ7.Location = New System.Drawing.Point(28, 591)
        Me.lblJ7.Name = "lblJ7"
        Me.lblJ7.Size = New System.Drawing.Size(53, 15)
        Me.lblJ7.TabIndex = 14
        Me.lblJ7.Text = "JUDGE 7"
        '
        'btnSaveJ7
        '
        Me.btnSaveJ7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSaveJ7.Location = New System.Drawing.Point(95, 588)
        Me.btnSaveJ7.Name = "btnSaveJ7"
        Me.btnSaveJ7.Size = New System.Drawing.Size(60, 24)
        Me.btnSaveJ7.TabIndex = 15
        Me.btnSaveJ7.Text = "Save 🖼"
        Me.btnSaveJ7.UseVisualStyleBackColor = True
        '
        'pnlTatamiID
        '
        Me.pnlTatamiID.BackColor = System.Drawing.Color.White
        Me.pnlTatamiID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTatamiID.Controls.Add(Me.lblTatamiIDTitle)
        Me.pnlTatamiID.Controls.Add(Me.lblTatamiIDValue)
        Me.pnlTatamiID.Controls.Add(Me.lblDefaultURLTitle)
        Me.pnlTatamiID.Controls.Add(Me.lblDefaultURL)
        Me.pnlTatamiID.Controls.Add(Me.lblDateTime)
        Me.pnlTatamiID.Location = New System.Drawing.Point(185, 440)
        Me.pnlTatamiID.Name = "pnlTatamiID"
        Me.pnlTatamiID.Size = New System.Drawing.Size(340, 155)
        Me.pnlTatamiID.TabIndex = 50
        '
        'lblTatamiIDTitle
        '
        Me.lblTatamiIDTitle.BackColor = System.Drawing.Color.Gray
        Me.lblTatamiIDTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTatamiIDTitle.ForeColor = System.Drawing.Color.White
        Me.lblTatamiIDTitle.Location = New System.Drawing.Point(8, 10)
        Me.lblTatamiIDTitle.Name = "lblTatamiIDTitle"
        Me.lblTatamiIDTitle.Size = New System.Drawing.Size(90, 22)
        Me.lblTatamiIDTitle.TabIndex = 0
        Me.lblTatamiIDTitle.Text = "TATAMI ID"
        Me.lblTatamiIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTatamiIDValue
        '
        Me.lblTatamiIDValue.AutoSize = True
        Me.lblTatamiIDValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTatamiIDValue.Location = New System.Drawing.Point(6, 38)
        Me.lblTatamiIDValue.Name = "lblTatamiIDValue"
        Me.lblTatamiIDValue.Size = New System.Drawing.Size(227, 32)
        Me.lblTatamiIDValue.TabIndex = 1
        Me.lblTatamiIDValue.Text = "TM-545FB238400A"
        '
        'lblDefaultURLTitle
        '
        Me.lblDefaultURLTitle.AutoSize = True
        Me.lblDefaultURLTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblDefaultURLTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblDefaultURLTitle.Location = New System.Drawing.Point(8, 90)
        Me.lblDefaultURLTitle.Name = "lblDefaultURLTitle"
        Me.lblDefaultURLTitle.Size = New System.Drawing.Size(115, 15)
        Me.lblDefaultURLTitle.TabIndex = 2
        Me.lblDefaultURLTitle.Text = "Default URL Access :"
        '
        'lblDefaultURL
        '
        Me.lblDefaultURL.AutoSize = True
        Me.lblDefaultURL.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDefaultURL.Location = New System.Drawing.Point(8, 108)
        Me.lblDefaultURL.Name = "lblDefaultURL"
        Me.lblDefaultURL.Size = New System.Drawing.Size(226, 15)
        Me.lblDefaultURL.TabIndex = 3
        Me.lblDefaultURL.Text = "https://kata.yabinya.com/scbscoring"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblDateTime.ForeColor = System.Drawing.Color.DimGray
        Me.lblDateTime.Location = New System.Drawing.Point(170, 130)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(109, 15)
        Me.lblDateTime.TabIndex = 4
        Me.lblDateTime.Text = "5/21/2026 2:43 PM"
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.rbYabinya)
        Me.pnlRight.Controls.Add(Me.rbOwn)
        Me.pnlRight.Controls.Add(Me.lblBaseURL)
        Me.pnlRight.Controls.Add(Me.txtBaseURL)
        Me.pnlRight.Controls.Add(Me.btnSavePDF)
        Me.pnlRight.Controls.Add(Me.pnlQRValues)
        Me.pnlRight.Location = New System.Drawing.Point(572, 8)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(310, 615)
        Me.pnlRight.TabIndex = 1
        '
        'rbYabinya
        '
        Me.rbYabinya.AutoSize = True
        Me.rbYabinya.Checked = True
        Me.rbYabinya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbYabinya.Location = New System.Drawing.Point(8, 10)
        Me.rbYabinya.Name = "rbYabinya"
        Me.rbYabinya.Size = New System.Drawing.Size(103, 19)
        Me.rbYabinya.TabIndex = 0
        Me.rbYabinya.TabStop = True
        Me.rbYabinya.Text = "Yabinya Server"
        Me.rbYabinya.UseVisualStyleBackColor = True
        '
        'rbOwn
        '
        Me.rbOwn.AutoSize = True
        Me.rbOwn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbOwn.Location = New System.Drawing.Point(165, 10)
        Me.rbOwn.Name = "rbOwn"
        Me.rbOwn.Size = New System.Drawing.Size(86, 19)
        Me.rbOwn.TabIndex = 1
        Me.rbOwn.Text = "Own Server"
        Me.rbOwn.UseVisualStyleBackColor = True
        '
        'lblBaseURL
        '
        Me.lblBaseURL.AutoSize = True
        Me.lblBaseURL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBaseURL.Location = New System.Drawing.Point(8, 42)
        Me.lblBaseURL.Name = "lblBaseURL"
        Me.lblBaseURL.Size = New System.Drawing.Size(55, 15)
        Me.lblBaseURL.TabIndex = 2
        Me.lblBaseURL.Text = "Base URL"
        '
        'txtBaseURL
        '
        Me.txtBaseURL.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtBaseURL.Location = New System.Drawing.Point(75, 39)
        Me.txtBaseURL.Name = "txtBaseURL"
        Me.txtBaseURL.ReadOnly = True
        Me.txtBaseURL.Size = New System.Drawing.Size(228, 23)
        Me.txtBaseURL.TabIndex = 2
        Me.txtBaseURL.Text = "https://kata.yabinya.com/scbscoring"
        '
        'btnSavePDF
        '
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
        '
        'pnlQRValues
        '
        Me.pnlQRValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQRValues.Controls.Add(Me.lblQRValueTitle)
        Me.pnlQRValues.Controls.Add(Me.lvQRValues)
        Me.pnlQRValues.Controls.Add(Me.btnCopyJ1)
        Me.pnlQRValues.Controls.Add(Me.btnCopyJ2)
        Me.pnlQRValues.Controls.Add(Me.btnCopyJ3)
        Me.pnlQRValues.Controls.Add(Me.btnCopyJ4)
        Me.pnlQRValues.Controls.Add(Me.btnCopyJ5)
        Me.pnlQRValues.Controls.Add(Me.btnCopyJ6)
        Me.pnlQRValues.Controls.Add(Me.btnCopyJ7)
        Me.pnlQRValues.Location = New System.Drawing.Point(8, 260)
        Me.pnlQRValues.Name = "pnlQRValues"
        Me.pnlQRValues.Size = New System.Drawing.Size(284, 350)
        Me.pnlQRValues.TabIndex = 4
        '
        'lblQRValueTitle
        '
        Me.lblQRValueTitle.BackColor = System.Drawing.Color.Yellow
        Me.lblQRValueTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQRValueTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblQRValueTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblQRValueTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblQRValueTitle.Name = "lblQRValueTitle"
        Me.lblQRValueTitle.Size = New System.Drawing.Size(282, 30)
        Me.lblQRValueTitle.TabIndex = 0
        Me.lblQRValueTitle.Text = "QR Code value set"
        Me.lblQRValueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvQRValues
        '
        Me.lvQRValues.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvQRValues.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colJ, Me.colURL, Me.colCopy})
        Me.lvQRValues.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lvQRValues.FullRowSelect = True
        Me.lvQRValues.GridLines = True
        Me.lvQRValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvQRValues.Location = New System.Drawing.Point(0, 30)
        Me.lvQRValues.Name = "lvQRValues"
        Me.lvQRValues.Scrollable = False
        Me.lvQRValues.Size = New System.Drawing.Size(244, 318)
        Me.lvQRValues.SmallImageList = Me.ImageList1
        Me.lvQRValues.TabIndex = 0
        Me.lvQRValues.UseCompatibleStateImageBehavior = False
        Me.lvQRValues.View = System.Windows.Forms.View.Details
        '
        'colJ
        '
        Me.colJ.Text = "J"
        Me.colJ.Width = 28
        '
        'colURL
        '
        Me.colURL.Text = "URL"
        Me.colURL.Width = 216
        '
        'colCopy
        '
        Me.colCopy.Text = ""
        Me.colCopy.Width = 0
        '
        'btnCopyJ1
        '
        Me.btnCopyJ1.FlatAppearance.BorderSize = 1
        Me.btnCopyJ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyJ1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.btnCopyJ1.Location = New System.Drawing.Point(244, 33)
        Me.btnCopyJ1.Name = "btnCopyJ1"
        Me.btnCopyJ1.Size = New System.Drawing.Size(38, 38)
        Me.btnCopyJ1.TabIndex = 5
        Me.btnCopyJ1.Text = "📋"
        Me.btnCopyJ1.UseVisualStyleBackColor = True
        '
        'btnCopyJ2
        '
        Me.btnCopyJ2.FlatAppearance.BorderSize = 1
        Me.btnCopyJ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyJ2.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.btnCopyJ2.Location = New System.Drawing.Point(244, 78)
        Me.btnCopyJ2.Name = "btnCopyJ2"
        Me.btnCopyJ2.Size = New System.Drawing.Size(38, 38)
        Me.btnCopyJ2.TabIndex = 6
        Me.btnCopyJ2.Text = "📋"
        Me.btnCopyJ2.UseVisualStyleBackColor = True
        '
        'btnCopyJ3
        '
        Me.btnCopyJ3.FlatAppearance.BorderSize = 1
        Me.btnCopyJ3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyJ3.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.btnCopyJ3.Location = New System.Drawing.Point(244, 123)
        Me.btnCopyJ3.Name = "btnCopyJ3"
        Me.btnCopyJ3.Size = New System.Drawing.Size(38, 38)
        Me.btnCopyJ3.TabIndex = 7
        Me.btnCopyJ3.Text = "📋"
        Me.btnCopyJ3.UseVisualStyleBackColor = True
        '
        'btnCopyJ4
        '
        Me.btnCopyJ4.FlatAppearance.BorderSize = 1
        Me.btnCopyJ4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyJ4.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.btnCopyJ4.Location = New System.Drawing.Point(244, 168)
        Me.btnCopyJ4.Name = "btnCopyJ4"
        Me.btnCopyJ4.Size = New System.Drawing.Size(38, 38)
        Me.btnCopyJ4.TabIndex = 8
        Me.btnCopyJ4.Text = "📋"
        Me.btnCopyJ4.UseVisualStyleBackColor = True
        '
        'btnCopyJ5
        '
        Me.btnCopyJ5.FlatAppearance.BorderSize = 1
        Me.btnCopyJ5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyJ5.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.btnCopyJ5.Location = New System.Drawing.Point(244, 213)
        Me.btnCopyJ5.Name = "btnCopyJ5"
        Me.btnCopyJ5.Size = New System.Drawing.Size(38, 38)
        Me.btnCopyJ5.TabIndex = 9
        Me.btnCopyJ5.Text = "📋"
        Me.btnCopyJ5.UseVisualStyleBackColor = True
        '
        'btnCopyJ6
        '
        Me.btnCopyJ6.FlatAppearance.BorderSize = 1
        Me.btnCopyJ6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyJ6.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.btnCopyJ6.Location = New System.Drawing.Point(244, 258)
        Me.btnCopyJ6.Name = "btnCopyJ6"
        Me.btnCopyJ6.Size = New System.Drawing.Size(38, 38)
        Me.btnCopyJ6.TabIndex = 10
        Me.btnCopyJ6.Text = "📋"
        Me.btnCopyJ6.UseVisualStyleBackColor = True
        '
        'btnCopyJ7
        '
        Me.btnCopyJ7.FlatAppearance.BorderSize = 1
        Me.btnCopyJ7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyJ7.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.btnCopyJ7.Location = New System.Drawing.Point(244, 303)
        Me.btnCopyJ7.Name = "btnCopyJ7"
        Me.btnCopyJ7.Size = New System.Drawing.Size(38, 38)
        Me.btnCopyJ7.TabIndex = 11
        Me.btnCopyJ7.Text = "📋"
        Me.btnCopyJ7.UseVisualStyleBackColor = True
        '
        'FormQRGenerated
        '
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
        CType(Me.pbJ1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJ7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTatamiID.ResumeLayout(False)
        Me.pnlTatamiID.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.pnlQRValues.ResumeLayout(False)
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class