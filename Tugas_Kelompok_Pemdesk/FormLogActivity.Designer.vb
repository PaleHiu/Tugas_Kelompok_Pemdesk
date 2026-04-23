Partial Class FormLogActivity
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblMatch = New System.Windows.Forms.Label()
        Me.cmbCategories = New System.Windows.Forms.ComboBox()
        Me.chkFilterByCategories = New System.Windows.Forms.CheckBox()
        Me.chkTop100 = New System.Windows.Forms.CheckBox()
        Me.lvActivity = New System.Windows.Forms.ListView()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' -----------------------------------------------
        ' lblTitle
        ' -----------------------------------------------
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(290, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Tatami Admin Log Activity"

        ' -----------------------------------------------
        ' lblDate
        ' -----------------------------------------------
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDate.Location = New System.Drawing.Point(12, 62)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"

        ' -----------------------------------------------
        ' dtpDate
        ' -----------------------------------------------
        Me.dtpDate.CustomFormat = "M/d/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(145, 58)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(155, 23)
        Me.dtpDate.TabIndex = 2

        ' -----------------------------------------------
        ' lblMatch
        ' -----------------------------------------------
        Me.lblMatch.AutoSize = True
        Me.lblMatch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMatch.Location = New System.Drawing.Point(12, 93)
        Me.lblMatch.Name = "lblMatch"
        Me.lblMatch.TabIndex = 3
        Me.lblMatch.Text = "Match (Categories)"

        ' -----------------------------------------------
        ' cmbCategories
        ' -----------------------------------------------
        Me.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategories.FormattingEnabled = True
        Me.cmbCategories.Location = New System.Drawing.Point(145, 89)
        Me.cmbCategories.Name = "cmbCategories"
        Me.cmbCategories.Size = New System.Drawing.Size(280, 23)
        Me.cmbCategories.TabIndex = 4

        ' -----------------------------------------------
        ' chkFilterByCategories
        ' -----------------------------------------------
        Me.chkFilterByCategories.AutoSize = True
        Me.chkFilterByCategories.Checked = True
        Me.chkFilterByCategories.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFilterByCategories.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkFilterByCategories.Location = New System.Drawing.Point(440, 91)
        Me.chkFilterByCategories.Name = "chkFilterByCategories"
        Me.chkFilterByCategories.TabIndex = 5
        Me.chkFilterByCategories.Text = "Filter by Categories"
        Me.chkFilterByCategories.UseVisualStyleBackColor = True

        ' -----------------------------------------------
        ' chkTop100
        ' -----------------------------------------------
        Me.chkTop100.AutoSize = True
        Me.chkTop100.Checked = True
        Me.chkTop100.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTop100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkTop100.Location = New System.Drawing.Point(145, 122)
        Me.chkTop100.Name = "chkTop100"
        Me.chkTop100.TabIndex = 6
        Me.chkTop100.Text = "Top 100 Last Activity"
        Me.chkTop100.UseVisualStyleBackColor = True

        ' -----------------------------------------------
        ' lvActivity
        ' -----------------------------------------------
        Me.lvActivity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvActivity.FullRowSelect = True
        Me.lvActivity.GridLines = True
        Me.lvActivity.Location = New System.Drawing.Point(0, 155)
        Me.lvActivity.Name = "lvActivity"
        Me.lvActivity.Size = New System.Drawing.Size(1270, 560)
        Me.lvActivity.TabIndex = 7
        Me.lvActivity.UseCompatibleStateImageBehavior = False
        Me.lvActivity.View = System.Windows.Forms.View.Details

        ' -----------------------------------------------
        ' btnExport
        ' -----------------------------------------------
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExport.Location = New System.Drawing.Point(1170, 727)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(90, 30)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "Export  💾"
        Me.btnExport.UseVisualStyleBackColor = True

        ' -----------------------------------------------
        ' FormLogActivity
        ' -----------------------------------------------
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(236, 236, 236)
        Me.ClientSize = New System.Drawing.Size(1270, 770)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lvActivity)
        Me.Controls.Add(Me.chkTop100)
        Me.Controls.Add(Me.chkFilterByCategories)
        Me.Controls.Add(Me.cmbCategories)
        Me.Controls.Add(Me.lblMatch)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FormLogActivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log Activity"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMatch As System.Windows.Forms.Label
    Friend WithEvents cmbCategories As System.Windows.Forms.ComboBox
    Friend WithEvents chkFilterByCategories As System.Windows.Forms.CheckBox
    Friend WithEvents chkTop100 As System.Windows.Forms.CheckBox
    Friend WithEvents lvActivity As System.Windows.Forms.ListView
    Friend WithEvents btnExport As System.Windows.Forms.Button

End Class
