<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Peserta
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

    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblTeam As System.Windows.Forms.Label
    Friend WithEvents cmbTeam As System.Windows.Forms.ComboBox
    Friend WithEvents btnEditTeam As System.Windows.Forms.Button
    Friend WithEvents lblTeamInfo As System.Windows.Forms.Label
    Friend WithEvents txtTeamInfo As System.Windows.Forms.TextBox
    Friend WithEvents lblProfilePic As System.Windows.Forms.Label
    Friend WithEvents picCircle As PictureBoxBulat
    Friend WithEvents btnSelectPic As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents panelMiddle As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClearSearch As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents panelBottom As System.Windows.Forms.Panel
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents splitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents gridTeams As System.Windows.Forms.DataGridView
    Friend WithEvents gridCompetitors As System.Windows.Forms.DataGridView
    Friend WithEvents ColTeam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTeamRight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTeamInfoRight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCompPict As System.Windows.Forms.DataGridViewImageColumn

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        panelTop = New Panel()
        lblTitle = New Label()
        lblName = New Label()
        txtName = New TextBox()
        lblTeam = New Label()
        cmbTeam = New ComboBox()
        btnEditTeam = New Button()
        lblTeamInfo = New Label()
        txtTeamInfo = New TextBox()
        lblProfilePic = New Label()
        picCircle = New PictureBoxBulat()
        btnSelectPic = New Button()
        btnAdd = New Button()
        btnClear = New Button()
        lblNew = New Label()
        panelMiddle = New Panel()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnClearSearch = New Button()
        btnExport = New Button()
        btnImport = New Button()
        panelBottom = New Panel()
        lblTotal = New Label()
        btnDeleteAll = New Button()
        splitContainer = New SplitContainer()
        gridTeams = New DataGridView()
        ColTeam = New DataGridViewTextBoxColumn()
        gridCompetitors = New DataGridView()
        ColDel = New DataGridViewButtonColumn()
        ColEdit = New DataGridViewButtonColumn()
        ColName = New DataGridViewTextBoxColumn()
        ColTeamRight = New DataGridViewTextBoxColumn()
        ColTeamInfoRight = New DataGridViewTextBoxColumn()
        ColCompPict = New DataGridViewImageColumn()
        panelTop.SuspendLayout()
        panelMiddle.SuspendLayout()
        panelBottom.SuspendLayout()
        CType(splitContainer, ComponentModel.ISupportInitialize).BeginInit()
        splitContainer.Panel1.SuspendLayout()
        splitContainer.Panel2.SuspendLayout()
        splitContainer.SuspendLayout()
        CType(gridTeams, ComponentModel.ISupportInitialize).BeginInit()
        CType(gridCompetitors, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCircle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelTop
        ' 
        panelTop.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        panelTop.BorderStyle = BorderStyle.FixedSingle
        panelTop.Controls.Add(lblTitle)
        panelTop.Controls.Add(lblName)
        panelTop.Controls.Add(txtName)
        panelTop.Controls.Add(lblTeam)
        panelTop.Controls.Add(cmbTeam)
        panelTop.Controls.Add(btnEditTeam)
        panelTop.Controls.Add(lblTeamInfo)
        panelTop.Controls.Add(txtTeamInfo)
        panelTop.Controls.Add(lblProfilePic)
        panelTop.Controls.Add(picCircle)
        panelTop.Controls.Add(btnSelectPic)
        panelTop.Controls.Add(btnAdd)
        panelTop.Controls.Add(btnClear)
        panelTop.Controls.Add(lblNew)
        panelTop.Dock = DockStyle.Top
        panelTop.Location = New Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Size = New Size(833, 190)
        panelTop.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTitle.Location = New Point(350, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(134, 19)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Competitor Entries"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblName.Location = New Point(50, 45)
        lblName.Name = "lblName"
        lblName.Size = New Size(48, 15)
        lblName.TabIndex = 1
        lblName.Text = "Name *"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(150, 42)
        txtName.Name = "txtName"
        txtName.Size = New Size(300, 23)
        txtName.TabIndex = 2
        ' 
        ' lblTeam
        ' 
        lblTeam.AutoSize = True
        lblTeam.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTeam.Location = New Point(50, 75)
        lblTeam.Name = "lblTeam"
        lblTeam.Size = New Size(45, 15)
        lblTeam.TabIndex = 3
        lblTeam.Text = "Team *"
        ' 
        ' cmbTeam
        ' 
        cmbTeam.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTeam.Location = New Point(150, 72)
        cmbTeam.Name = "cmbTeam"
        cmbTeam.Size = New Size(300, 23)
        cmbTeam.TabIndex = 4
        ' 
        ' btnEditTeam
        ' 
        btnEditTeam.BackColor = Color.White
        btnEditTeam.Location = New Point(455, 71)
        btnEditTeam.Name = "btnEditTeam"
        btnEditTeam.Size = New Size(30, 25)
        btnEditTeam.TabIndex = 5
        btnEditTeam.Text = "📝"
        btnEditTeam.UseVisualStyleBackColor = False
        ' 
        ' lblTeamInfo
        ' 
        lblTeamInfo.AutoSize = True
        lblTeamInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTeamInfo.Location = New Point(50, 105)
        lblTeamInfo.Name = "lblTeamInfo"
        lblTeamInfo.Size = New Size(63, 15)
        lblTeamInfo.TabIndex = 6
        lblTeamInfo.Text = "Team Info"
        ' 
        ' txtTeamInfo
        ' 
        txtTeamInfo.BackColor = Color.WhiteSmoke
        txtTeamInfo.Location = New Point(150, 102)
        txtTeamInfo.Name = "txtTeamInfo"
        txtTeamInfo.ReadOnly = True
        txtTeamInfo.Size = New Size(300, 23)
        txtTeamInfo.TabIndex = 7
        ' 
        ' lblProfilePic
        ' 
        lblProfilePic.AutoSize = True
        lblProfilePic.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblProfilePic.Location = New Point(40, 145)
        lblProfilePic.Name = "lblProfilePic"
        lblProfilePic.Size = New Size(87, 15)
        lblProfilePic.TabIndex = 8
        lblProfilePic.Text = "Profile Picture"
        ' 
        ' picCircle
        ' 
        picCircle.Location = New Point(150, 130)
        picCircle.Name = "picCircle"
        picCircle.Size = New Size(50, 50)
        picCircle.SizeMode = PictureBoxSizeMode.Zoom
        picCircle.TabIndex = 9
        picCircle.TabStop = False
        ' 
        ' btnSelectPic
        ' 
        btnSelectPic.Location = New Point(215, 142)
        btnSelectPic.Name = "btnSelectPic"
        btnSelectPic.Size = New Size(60, 25)
        btnSelectPic.TabIndex = 10
        btnSelectPic.Text = "Select"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.DeepSkyBlue
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnAdd.Location = New Point(650, 40)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(150, 30)
        btnAdd.TabIndex = 11
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGreen
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnClear.Location = New Point(650, 75)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 30)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblNew
        ' 
        lblNew.AutoSize = True
        lblNew.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNew.Location = New Point(710, 110)
        lblNew.Name = "lblNew"
        lblNew.Size = New Size(34, 15)
        lblNew.TabIndex = 13
        lblNew.Text = "NEW"
        ' 
        ' panelMiddle
        ' 
        panelMiddle.BackColor = Color.White
        panelMiddle.BorderStyle = BorderStyle.FixedSingle
        panelMiddle.Controls.Add(txtSearch)
        panelMiddle.Controls.Add(btnSearch)
        panelMiddle.Controls.Add(btnClearSearch)
        panelMiddle.Controls.Add(btnExport)
        panelMiddle.Controls.Add(btnImport)
        panelMiddle.Dock = DockStyle.Top
        panelMiddle.Location = New Point(0, 190)
        panelMiddle.Name = "panelMiddle"
        panelMiddle.Size = New Size(833, 35)
        panelMiddle.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(10, 6)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(200, 23)
        txtSearch.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.White
        btnSearch.Location = New Point(215, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(30, 25)
        btnSearch.TabIndex = 1
        btnSearch.Text = "🔍"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.BackColor = Color.White
        btnClearSearch.ForeColor = Color.DodgerBlue
        btnClearSearch.Location = New Point(250, 5)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(30, 25)
        btnClearSearch.TabIndex = 2
        btnClearSearch.Text = "❌"
        btnClearSearch.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.White
        btnExport.Location = New Point(570, 5)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(120, 25)
        btnExport.TabIndex = 3
        btnExport.Text = "Export to Excel 📊"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnImport
        ' 
        btnImport.BackColor = Color.White
        btnImport.Location = New Point(695, 5)
        btnImport.Name = "btnImport"
        btnImport.Size = New Size(125, 25)
        btnImport.TabIndex = 4
        btnImport.Text = "Import from Excel 📊"
        btnImport.UseVisualStyleBackColor = False
        ' 
        ' panelBottom
        ' 
        panelBottom.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        panelBottom.BorderStyle = BorderStyle.FixedSingle
        panelBottom.Controls.Add(lblTotal)
        panelBottom.Controls.Add(btnDeleteAll)
        panelBottom.Dock = DockStyle.Bottom
        panelBottom.Location = New Point(0, 555)
        panelBottom.Name = "panelBottom"
        panelBottom.Size = New Size(833, 40)
        panelBottom.TabIndex = 3
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(10, 10)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(93, 15)
        lblTotal.TabIndex = 0
        lblTotal.Text = "Total Records : 6"
        ' 
        ' btnDeleteAll
        ' 
        btnDeleteAll.BackColor = Color.LightSalmon
        btnDeleteAll.FlatAppearance.BorderSize = 0
        btnDeleteAll.FlatStyle = FlatStyle.Flat
        btnDeleteAll.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDeleteAll.Location = New Point(710, 5)
        btnDeleteAll.Name = "btnDeleteAll"
        btnDeleteAll.Size = New Size(110, 30)
        btnDeleteAll.TabIndex = 1
        btnDeleteAll.Text = "Delete All"
        btnDeleteAll.UseVisualStyleBackColor = False
        ' 
        ' splitContainer
        ' 
        splitContainer.BorderStyle = BorderStyle.FixedSingle
        splitContainer.Dock = DockStyle.Fill
        splitContainer.IsSplitterFixed = True
        splitContainer.Location = New Point(0, 225)
        splitContainer.Name = "splitContainer"
        ' 
        ' splitContainer.Panel1
        ' 
        splitContainer.Panel1.Controls.Add(gridTeams)
        ' 
        ' splitContainer.Panel2
        ' 
        splitContainer.Panel2.Controls.Add(gridCompetitors)
        splitContainer.Size = New Size(833, 330)
        splitContainer.SplitterDistance = 240
        splitContainer.TabIndex = 0
        ' 
        ' gridTeams
        ' 
        gridTeams.AllowUserToResizeColumns = False
        gridTeams.AllowUserToResizeRows = False
        gridTeams.BackgroundColor = Color.White
        ' --- PENYEMPURNAAN HEADING BOLD gridTeams ---
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Crimson
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold) ' BOLD AKTIF
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        gridTeams.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        gridTeams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        gridTeams.Columns.AddRange(New DataGridViewColumn() {ColTeam})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        gridTeams.DefaultCellStyle = DataGridViewCellStyle2
        gridTeams.Dock = DockStyle.Fill
        gridTeams.EnableHeadersVisualStyles = False
        gridTeams.Location = New Point(0, 0)
        gridTeams.Name = "gridTeams"
        gridTeams.RowHeadersVisible = False
        gridTeams.Size = New Size(238, 328)
        gridTeams.TabIndex = 0
        ' 
        ' ColTeam
        ' 
        ColTeam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColTeam.HeaderText = "Team"
        ColTeam.Name = "ColTeam"
        ColTeam.ReadOnly = True
        ' 
        ' gridCompetitors
        ' 
        gridCompetitors.AllowUserToResizeColumns = False
        gridCompetitors.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        gridCompetitors.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        gridCompetitors.BackgroundColor = Color.White
        ' --- PENYEMPURNAAN HEADING BOLD gridCompetitors ---
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold) ' BOLD AKTIF
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        gridCompetitors.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        gridCompetitors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        gridCompetitors.Columns.AddRange(New DataGridViewColumn() {ColDel, ColEdit, ColName, ColTeamRight, ColTeamInfoRight, ColCompPict})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        gridCompetitors.DefaultCellStyle = DataGridViewCellStyle5
        gridCompetitors.Dock = DockStyle.Fill
        gridCompetitors.Location = New Point(0, 0)
        gridCompetitors.Name = "gridCompetitors"
        gridCompetitors.RowHeadersVisible = False
        gridCompetitors.Size = New Size(589, 328)
        gridCompetitors.TabIndex = 0
        ' 
        ' ColDel
        ' 
        ColDel.HeaderText = ""
        ColDel.Name = "ColDel"
        ColDel.Resizable = DataGridViewTriState.False
        ColDel.Text = "❌"
        ColDel.UseColumnTextForButtonValue = True
        ColDel.Width = 35
        ' 
        ' ColEdit
        ' 
        ColEdit.HeaderText = ""
        ColEdit.Name = "ColEdit"
        ColEdit.Resizable = DataGridViewTriState.False
        ColEdit.Text = "📝"
        ColEdit.UseColumnTextForButtonValue = True
        ColEdit.Width = 35
        ' 
        ' ColName
        ' 
        ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColName.HeaderText = "Name"
        ColName.Name = "ColName"
        ColName.ReadOnly = True
        ' 
        ' ColTeamRight
        ' 
        ColTeamRight.HeaderText = "Team"
        ColTeamRight.Name = "ColTeamRight"
        ColTeamRight.ReadOnly = True
        ColTeamRight.Resizable = DataGridViewTriState.False
        ColTeamRight.Width = 100
        ' 
        ' ColTeamInfoRight
        ' 
        ColTeamInfoRight.HeaderText = "Team Info"
        ColTeamInfoRight.Name = "ColTeamInfoRight"
        ColTeamInfoRight.ReadOnly = True
        ColTeamInfoRight.Resizable = DataGridViewTriState.False
        ColTeamInfoRight.Width = 120
        ' 
        ' ColCompPict
        ' 
        ColCompPict.HeaderText = "Comp. Pict"
        ColCompPict.ImageLayout = DataGridViewImageCellLayout.Zoom
        ColCompPict.Name = "ColCompPict"
        ColCompPict.ReadOnly = True
        ColCompPict.Resizable = DataGridViewTriState.False
        ColCompPict.Width = 80
        ' 
        ' Peserta
        ' 
        ClientSize = New Size(833, 595)
        Controls.Add(splitContainer)
        Controls.Add(panelMiddle)
        Controls.Add(panelTop)
        Controls.Add(panelBottom)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Peserta"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Competitor Entries"
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        panelMiddle.ResumeLayout(False)
        panelMiddle.PerformLayout()
        panelBottom.ResumeLayout(False)
        panelBottom.PerformLayout()
        splitContainer.Panel1.ResumeLayout(False)
        splitContainer.Panel2.ResumeLayout(False)
        CType(splitContainer, ComponentModel.ISupportInitialize).EndInit()
        splitContainer.ResumeLayout(False)
        CType(gridTeams, ComponentModel.ISupportInitialize).EndInit()
        CType(gridCompetitors, ComponentModel.ISupportInitialize).EndInit()
        CType(picCircle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
End Class