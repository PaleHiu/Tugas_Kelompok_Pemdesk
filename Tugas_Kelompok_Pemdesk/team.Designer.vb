<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class team
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

    Friend WithEvents pnlFormTeam As System.Windows.Forms.Panel
    Friend WithEvents lblCountryTeam As System.Windows.Forms.Label
    Friend WithEvents lblTeamPic As System.Windows.Forms.Label
    Friend WithEvents lblNewTitleTeam As System.Windows.Forms.Label
    Friend WithEvents btnClearTeam As System.Windows.Forms.Button
    Friend WithEvents btnAddTeam As System.Windows.Forms.Button
    Friend WithEvents btnSelectTeamPic As System.Windows.Forms.Button
    Friend WithEvents cmbCountryTeam As System.Windows.Forms.ComboBox
    Friend WithEvents pnlTeamPicture As System.Windows.Forms.Panel
    Friend WithEvents chkUseCountryFlagTeam As System.Windows.Forms.CheckBox
    Friend WithEvents txtTimInfoTeam As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaTeam As System.Windows.Forms.TextBox
    Friend WithEvents lblTeamInfoTeam As System.Windows.Forms.Label
    Friend WithEvents lblTeamTeam As System.Windows.Forms.Label
    Friend WithEvents lblTitleFormTeam As System.Windows.Forms.Label
    Friend WithEvents pnlToolbarTeam As System.Windows.Forms.Panel
    Friend WithEvents txtSearchTeam As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchTeam As System.Windows.Forms.Button
    Friend WithEvents btnClearSearchTeam As System.Windows.Forms.Button
    Friend WithEvents btnExportExcelTeam As System.Windows.Forms.Button
    Friend WithEvents btnImportExcelTeam As System.Windows.Forms.Button
    Friend WithEvents pnlGridTeam As System.Windows.Forms.Panel
    Friend WithEvents gridEntriesTeam As System.Windows.Forms.DataGridView
    Friend WithEvents pnlFooterTeam As System.Windows.Forms.Panel
    Friend WithEvents lblTotalRecordsTeam As System.Windows.Forms.Label
    Friend WithEvents btnDeleteAllTeam As System.Windows.Forms.Button
    Friend WithEvents ColRowNoTeam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDeleteTeam As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColEditTeam As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColTeamGrid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTeamInfoGrid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTeamPictGrid As System.Windows.Forms.DataGridViewImageColumn

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        ' DEFINISI GAYA UNTUK HEADER BOLD
        Dim DataGridViewHeaderStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        Me.pnlFormTeam = New System.Windows.Forms.Panel()
        Me.lblCountryTeam = New System.Windows.Forms.Label()
        Me.lblTeamPic = New System.Windows.Forms.Label()
        Me.lblNewTitleTeam = New System.Windows.Forms.Label()
        Me.btnClearTeam = New System.Windows.Forms.Button()
        Me.btnAddTeam = New System.Windows.Forms.Button()
        Me.btnSelectTeamPic = New System.Windows.Forms.Button()
        Me.cmbCountryTeam = New System.Windows.Forms.ComboBox()
        Me.pnlTeamPicture = New System.Windows.Forms.Panel()
        Me.chkUseCountryFlagTeam = New System.Windows.Forms.CheckBox()
        Me.txtTimInfoTeam = New System.Windows.Forms.TextBox()
        Me.txtNamaTeam = New System.Windows.Forms.TextBox()
        Me.lblTeamInfoTeam = New System.Windows.Forms.Label()
        Me.lblTeamTeam = New System.Windows.Forms.Label()
        Me.lblTitleFormTeam = New System.Windows.Forms.Label()
        Me.pnlToolbarTeam = New System.Windows.Forms.Panel()
        Me.lblTotalRecordsTeam = New System.Windows.Forms.Label()
        Me.btnExportExcelTeam = New System.Windows.Forms.Button()
        Me.btnImportExcelTeam = New System.Windows.Forms.Button()
        Me.pnlGridTeam = New System.Windows.Forms.Panel()
        Me.gridEntriesTeam = New System.Windows.Forms.DataGridView()
        Me.ColRowNoTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDeleteTeam = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColEditTeam = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColTeamGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTeamInfoGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTeamPictGrid = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlFooterTeam = New System.Windows.Forms.Panel()
        Me.txtSearchTeam = New System.Windows.Forms.TextBox()
        Me.btnSearchTeam = New System.Windows.Forms.Button()
        Me.btnClearSearchTeam = New System.Windows.Forms.Button()
        Me.btnDeleteAllTeam = New System.Windows.Forms.Button()
        Me.pnlFormTeam.SuspendLayout()
        Me.pnlToolbarTeam.SuspendLayout()
        Me.pnlGridTeam.SuspendLayout()
        CType(Me.gridEntriesTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooterTeam.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlFormTeam
        '
        Me.pnlFormTeam.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlFormTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormTeam.Controls.Add(Me.lblCountryTeam)
        Me.pnlFormTeam.Controls.Add(Me.lblTeamPic)
        Me.pnlFormTeam.Controls.Add(Me.lblNewTitleTeam)
        Me.pnlFormTeam.Controls.Add(Me.btnClearTeam)
        Me.pnlFormTeam.Controls.Add(Me.btnAddTeam)
        Me.pnlFormTeam.Controls.Add(Me.btnSelectTeamPic)
        Me.pnlFormTeam.Controls.Add(Me.cmbCountryTeam)
        Me.pnlFormTeam.Controls.Add(Me.pnlTeamPicture)
        Me.pnlFormTeam.Controls.Add(Me.chkUseCountryFlagTeam)
        Me.pnlFormTeam.Controls.Add(Me.txtTimInfoTeam)
        Me.pnlFormTeam.Controls.Add(Me.txtNamaTeam)
        Me.pnlFormTeam.Controls.Add(Me.lblTeamInfoTeam)
        Me.pnlFormTeam.Controls.Add(Me.lblTeamTeam)
        Me.pnlFormTeam.Controls.Add(Me.lblTitleFormTeam)
        Me.pnlFormTeam.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormTeam.Location = New System.Drawing.Point(0, 0)
        Me.pnlFormTeam.Name = "pnlFormTeam"
        Me.pnlFormTeam.Size = New System.Drawing.Size(850, 168)
        Me.pnlFormTeam.TabIndex = 0
        '
        ' lblTitleFormTeam
        '
        Me.lblTitleFormTeam.AutoSize = True
        Me.lblTitleFormTeam.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitleFormTeam.Location = New System.Drawing.Point(372, 10)
        Me.lblTitleFormTeam.Name = "lblTitleFormTeam"
        Me.lblTitleFormTeam.Size = New System.Drawing.Size(95, 19)
        Me.lblTitleFormTeam.TabIndex = 0
        Me.lblTitleFormTeam.Text = "Team Entries"
        '
        ' lblTeamTeam
        '
        Me.lblTeamTeam.AutoSize = True
        Me.lblTeamTeam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeamTeam.Location = New System.Drawing.Point(70, 45)
        Me.lblTeamTeam.Name = "lblTeamTeam"
        Me.lblTeamTeam.Size = New System.Drawing.Size(45, 15)
        Me.lblTeamTeam.TabIndex = 1
        Me.lblTeamTeam.Text = "Team *"
        '
        ' txtNamaTeam
        '
        Me.txtNamaTeam.Location = New System.Drawing.Point(140, 42)
        Me.txtNamaTeam.Name = "txtNamaTeam"
        Me.txtNamaTeam.Size = New System.Drawing.Size(280, 23)
        Me.txtNamaTeam.TabIndex = 2
        '
        ' lblTeamInfoTeam
        '
        Me.lblTeamInfoTeam.AutoSize = True
        Me.lblTeamInfoTeam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeamInfoTeam.Location = New System.Drawing.Point(52, 75)
        Me.lblTeamInfoTeam.Name = "lblTeamInfoTeam"
        Me.lblTeamInfoTeam.Size = New System.Drawing.Size(63, 15)
        Me.lblTeamInfoTeam.TabIndex = 3
        Me.lblTeamInfoTeam.Text = "Team Info"
        '
        ' txtTimInfoTeam
        '
        Me.txtTimInfoTeam.Location = New System.Drawing.Point(140, 72)
        Me.txtTimInfoTeam.Name = "txtTimInfoTeam"
        Me.txtTimInfoTeam.Size = New System.Drawing.Size(280, 23)
        Me.txtTimInfoTeam.TabIndex = 4
        '
        ' chkUseCountryFlagTeam
        '
        Me.chkUseCountryFlagTeam.AutoSize = True
        Me.chkUseCountryFlagTeam.Location = New System.Drawing.Point(140, 100)
        Me.chkUseCountryFlagTeam.Name = "chkUseCountryFlagTeam"
        Me.chkUseCountryFlagTeam.Size = New System.Drawing.Size(155, 19)
        Me.chkUseCountryFlagTeam.TabIndex = 5
        Me.chkUseCountryFlagTeam.Text = "Use Country Flag (Logo)"
        Me.chkUseCountryFlagTeam.UseVisualStyleBackColor = True
        '
        ' lblCountryTeam
        '
        Me.lblCountryTeam.AutoSize = True
        Me.lblCountryTeam.Location = New System.Drawing.Point(65, 125)
        Me.lblCountryTeam.Name = "lblCountryTeam"
        Me.lblCountryTeam.Size = New System.Drawing.Size(50, 15)
        Me.lblCountryTeam.TabIndex = 6
        Me.lblCountryTeam.Text = "Country"
        '
        ' cmbCountryTeam
        '
        Me.cmbCountryTeam.FormattingEnabled = True
        Me.cmbCountryTeam.Location = New System.Drawing.Point(140, 122)
        Me.cmbCountryTeam.Name = "cmbCountryTeam"
        Me.cmbCountryTeam.Size = New System.Drawing.Size(150, 23)
        Me.cmbCountryTeam.TabIndex = 7
        Me.cmbCountryTeam.Text = "--select--"
        '
        ' lblTeamPic
        '
        Me.lblTeamPic.AutoSize = True
        Me.lblTeamPic.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeamPic.Location = New System.Drawing.Point(445, 30)
        Me.lblTeamPic.Name = "lblTeamPic"
        Me.lblTeamPic.Size = New System.Drawing.Size(79, 15)
        Me.lblTeamPic.TabIndex = 8
        Me.lblTeamPic.Text = "Team Picture"
        '
        ' pnlTeamPicture
        '
        Me.pnlTeamPicture.BackColor = System.Drawing.Color.White
        Me.pnlTeamPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTeamPicture.Location = New System.Drawing.Point(455, 50)
        Me.pnlTeamPicture.Name = "pnlTeamPicture"
        Me.pnlTeamPicture.Size = New System.Drawing.Size(55, 55)
        Me.pnlTeamPicture.TabIndex = 9
        '
        ' btnSelectTeamPic
        '
        Me.btnSelectTeamPic.Location = New System.Drawing.Point(452, 110)
        Me.btnSelectTeamPic.Name = "btnSelectTeamPic"
        Me.btnSelectTeamPic.Size = New System.Drawing.Size(60, 25)
        Me.btnSelectTeamPic.TabIndex = 10
        Me.btnSelectTeamPic.Text = "Select"
        Me.btnSelectTeamPic.UseVisualStyleBackColor = True
        '
        ' btnAddTeam
        '
        Me.btnAddTeam.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddTeam.FlatAppearance.BorderSize = 0
        Me.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTeam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddTeam.Location = New System.Drawing.Point(650, 40)
        Me.btnAddTeam.Name = "btnAddTeam"
        Me.btnAddTeam.Size = New System.Drawing.Size(150, 30)
        Me.btnAddTeam.TabIndex = 11
        Me.btnAddTeam.Text = "Add"
        Me.btnAddTeam.UseVisualStyleBackColor = False
        '
        ' btnClearTeam
        '
        Me.btnClearTeam.BackColor = System.Drawing.Color.LightGreen
        Me.btnClearTeam.FlatAppearance.BorderSize = 0
        Me.btnClearTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTeam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearTeam.Location = New System.Drawing.Point(650, 75)
        Me.btnClearTeam.Name = "btnClearTeam"
        Me.btnClearTeam.Size = New System.Drawing.Size(150, 30)
        Me.btnClearTeam.TabIndex = 12
        Me.btnClearTeam.Text = "Clear"
        Me.btnClearTeam.UseVisualStyleBackColor = False
        '
        ' lblNewTitleTeam
        '
        Me.lblNewTitleTeam.AutoSize = True
        Me.lblNewTitleTeam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewTitleTeam.Location = New System.Drawing.Point(710, 110)
        Me.lblNewTitleTeam.Name = "lblNewTitleTeam"
        Me.lblNewTitleTeam.Size = New System.Drawing.Size(34, 15)
        Me.lblNewTitleTeam.TabIndex = 13
        Me.lblNewTitleTeam.Text = "NEW"
        '
        ' pnlToolbarTeam
        '
        Me.pnlToolbarTeam.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlToolbarTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlToolbarTeam.Controls.Add(Me.lblTotalRecordsTeam)
        Me.pnlToolbarTeam.Controls.Add(Me.btnExportExcelTeam)
        Me.pnlToolbarTeam.Controls.Add(Me.btnImportExcelTeam)
        Me.pnlToolbarTeam.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbarTeam.Location = New System.Drawing.Point(0, 168)
        Me.pnlToolbarTeam.Name = "pnlToolbarTeam"
        Me.pnlToolbarTeam.Size = New System.Drawing.Size(850, 35)
        Me.pnlToolbarTeam.TabIndex = 1
        '
        ' lblTotalRecordsTeam
        '
        Me.lblTotalRecordsTeam.AutoSize = True
        Me.lblTotalRecordsTeam.Location = New System.Drawing.Point(10, 10)
        Me.lblTotalRecordsTeam.Name = "lblTotalRecordsTeam"
        Me.lblTotalRecordsTeam.Size = New System.Drawing.Size(92, 15)
        Me.lblTotalRecordsTeam.TabIndex = 0
        Me.lblTotalRecordsTeam.Text = "Total Records : 5"
        '
        ' btnExportExcelTeam
        '
        Me.btnExportExcelTeam.BackColor = System.Drawing.Color.White
        Me.btnExportExcelTeam.Location = New System.Drawing.Point(570, 5)
        Me.btnExportExcelTeam.Name = "btnExportExcelTeam"
        Me.btnExportExcelTeam.Size = New System.Drawing.Size(120, 25)
        Me.btnExportExcelTeam.TabIndex = 1
        Me.btnExportExcelTeam.Text = "Export to Excel 📊"
        Me.btnExportExcelTeam.UseVisualStyleBackColor = False
        '
        ' btnImportExcelTeam
        '
        Me.btnImportExcelTeam.BackColor = System.Drawing.Color.White
        Me.btnImportExcelTeam.Location = New System.Drawing.Point(695, 5)
        Me.btnImportExcelTeam.Name = "btnImportExcelTeam"
        Me.btnImportExcelTeam.Size = New System.Drawing.Size(125, 25)
        Me.btnImportExcelTeam.TabIndex = 2
        Me.btnImportExcelTeam.Text = "Import from Excel 📊"
        Me.btnImportExcelTeam.UseVisualStyleBackColor = False
        '
        ' pnlGridTeam
        '
        Me.pnlGridTeam.Controls.Add(Me.gridEntriesTeam)
        Me.pnlGridTeam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridTeam.Location = New System.Drawing.Point(0, 203)
        Me.pnlGridTeam.Name = "pnlGridTeam"
        Me.pnlGridTeam.Size = New System.Drawing.Size(850, 357)
        Me.pnlGridTeam.TabIndex = 2
        '
        ' gridEntriesTeam
        '
        Me.gridEntriesTeam.AllowUserToResizeColumns = False
        Me.gridEntriesTeam.AllowUserToResizeRows = False
        Me.gridEntriesTeam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None
        Me.gridEntriesTeam.BackgroundColor = System.Drawing.Color.White

        ' --- PENYEMPURNAAN HEADING BOLD ---
        DataGridViewHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewHeaderStyle.BackColor = System.Drawing.SystemColors.Control
        DataGridViewHeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewHeaderStyle.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewHeaderStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewHeaderStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridEntriesTeam.ColumnHeadersDefaultCellStyle = DataGridViewHeaderStyle

        Me.gridEntriesTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing


        Me.gridEntriesTeam.RowHeadersVisible = False

        Me.gridEntriesTeam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRowNoTeam, Me.ColDeleteTeam, Me.ColEditTeam, Me.ColTeamGrid, Me.ColTeamInfoGrid, Me.ColTeamPictGrid})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False
        Me.gridEntriesTeam.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridEntriesTeam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEntriesTeam.Location = New System.Drawing.Point(0, 0)
        Me.gridEntriesTeam.Name = "gridEntriesTeam"
        Me.gridEntriesTeam.RowTemplate.Height = 80
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridEntriesTeam.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridEntriesTeam.Size = New System.Drawing.Size(850, 357)
        Me.gridEntriesTeam.TabIndex = 0
        '
        ' ColRowNoTeam
        '
        Me.ColRowNoTeam.HeaderText = "No"
        Me.ColRowNoTeam.Name = "ColRowNoTeam"
        Me.ColRowNoTeam.Width = 35
        '
        ' ColDeleteTeam
        '
        Me.ColDeleteTeam.HeaderText = ""
        Me.ColDeleteTeam.Name = "ColDeleteTeam"
        Me.ColDeleteTeam.Text = "❌"
        Me.ColDeleteTeam.UseColumnTextForButtonValue = True
        Me.ColDeleteTeam.Width = 30
        '
        ' ColEditTeam
        '
        Me.ColEditTeam.HeaderText = ""
        Me.ColEditTeam.Name = "ColEditTeam"
        Me.ColEditTeam.Text = "📝"
        Me.ColEditTeam.UseColumnTextForButtonValue = True
        Me.ColEditTeam.Width = 30
        '
        ' ColTeamGrid
        '
        Me.ColTeamGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColTeamGrid.HeaderText = "Team"
        Me.ColTeamGrid.Name = "ColTeamGrid"
        '
        ' ColTeamInfoGrid
        '
        Me.ColTeamInfoGrid.HeaderText = "Team Info"
        Me.ColTeamInfoGrid.Name = "ColTeamInfoGrid"
        Me.ColTeamInfoGrid.Width = 200
        '
        ' ColTeamPictGrid
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColTeamPictGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColTeamPictGrid.HeaderText = "Team Pict"
        Me.ColTeamPictGrid.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ColTeamPictGrid.Name = "ColTeamPictGrid"
        Me.ColTeamPictGrid.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColTeamPictGrid.Width = 80
        '
        ' pnlFooterTeam
        '
        Me.pnlFooterTeam.BackColor = System.Drawing.Color.Crimson
        Me.pnlFooterTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooterTeam.Controls.Add(Me.txtSearchTeam)
        Me.pnlFooterTeam.Controls.Add(Me.btnSearchTeam)
        Me.pnlFooterTeam.Controls.Add(Me.btnClearSearchTeam)
        Me.pnlFooterTeam.Controls.Add(Me.btnDeleteAllTeam)
        Me.pnlFooterTeam.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooterTeam.Location = New System.Drawing.Point(0, 560)
        Me.pnlFooterTeam.Name = "pnlFooterTeam"
        Me.pnlFooterTeam.Size = New System.Drawing.Size(850, 40)
        Me.pnlFooterTeam.TabIndex = 3
        '
        ' txtSearchTeam
        '
        Me.txtSearchTeam.Location = New System.Drawing.Point(10, 8)
        Me.txtSearchTeam.Name = "txtSearchTeam"
        Me.txtSearchTeam.Size = New System.Drawing.Size(200, 23)
        Me.txtSearchTeam.TabIndex = 0
        '
        ' btnSearchTeam
        '
        Me.btnSearchTeam.BackColor = System.Drawing.Color.White
        Me.btnSearchTeam.Location = New System.Drawing.Point(215, 7)
        Me.btnSearchTeam.Name = "btnSearchTeam"
        Me.btnSearchTeam.Size = New System.Drawing.Size(30, 25)
        Me.btnSearchTeam.TabIndex = 1
        Me.btnSearchTeam.Text = "🔍"
        Me.btnSearchTeam.UseVisualStyleBackColor = False
        '
        ' btnClearSearchTeam
        '
        Me.btnClearSearchTeam.BackColor = System.Drawing.Color.White
        Me.btnClearSearchTeam.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnClearSearchTeam.Location = New System.Drawing.Point(250, 7)
        Me.btnClearSearchTeam.Name = "btnClearSearchTeam"
        Me.btnClearSearchTeam.Size = New System.Drawing.Size(30, 25)
        Me.btnClearSearchTeam.TabIndex = 2
        Me.btnClearSearchTeam.Text = "❌"
        Me.btnClearSearchTeam.UseVisualStyleBackColor = False
        '
        ' btnDeleteAllTeam
        '
        Me.btnDeleteAllTeam.BackColor = System.Drawing.Color.LightSalmon
        Me.btnDeleteAllTeam.FlatAppearance.BorderSize = 0
        Me.btnDeleteAllTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAllTeam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteAllTeam.Location = New System.Drawing.Point(695, 5)
        Me.btnDeleteAllTeam.Name = "btnDeleteAllTeam"
        Me.btnDeleteAllTeam.Size = New System.Drawing.Size(125, 28)
        Me.btnDeleteAllTeam.TabIndex = 3
        Me.btnDeleteAllTeam.Text = "Delete All"
        Me.btnDeleteAllTeam.UseVisualStyleBackColor = False
        '
        ' team
        '
        Me.ClientSize = New System.Drawing.Size(850, 600)
        Me.Controls.Add(Me.pnlGridTeam)
        Me.Controls.Add(Me.pnlToolbarTeam)
        Me.Controls.Add(Me.pnlFormTeam)
        Me.Controls.Add(Me.pnlFooterTeam)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "team"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Team Entries"
        Me.pnlFormTeam.ResumeLayout(False)
        Me.pnlFormTeam.PerformLayout()
        Me.pnlToolbarTeam.ResumeLayout(False)
        Me.pnlToolbarTeam.PerformLayout()
        Me.pnlGridTeam.ResumeLayout(False)
        CType(Me.gridEntriesTeam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooterTeam.ResumeLayout(False)
        Me.pnlFooterTeam.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
End Class