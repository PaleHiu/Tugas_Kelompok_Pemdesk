Partial Class Kumite
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelTop = New Panel()
        LabelNextMatch = New Label()
        TxtNextMatchAKA = New TextBox()
        LabelVS = New Label()
        TxtNextMatchAO = New TextBox()
        BtnLoadNextMatch = New Button()
        PanelAKA = New Panel()
        PictureBox1 = New PictureBox()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        LabelTitleAKA = New Label()
        LabelWinnerAKA = New Label()
        PicBoxAKA = New PictureBox()
        LblNameAKA = New Label()
        TxtNameAKA = New TextBox()
        LblTeamAKA = New Label()
        TxtTeamAKA = New TextBox()
        LblTeamInfoAKA = New Label()
        TxtTeamInfoAKA = New TextBox()
        BtnUpdateInfoAKA = New Button()
        BtnKikenAKA = New Button()
        BtnShikkakuAKA = New Button()
        BtnKnockedOutAKA = New Button()
        BtnPAKA = New Button()
        Btn1CAKA = New Button()
        Btn2CAKA = New Button()
        Btn3CAKA = New Button()
        BtnHCAKA = New Button()
        BtnHAKA = New Button()
        GrpScoreSummaryAKA = New GroupBox()
        DgvLogAKA = New DataGridView()
        ColNoAKA = New DataGridViewTextBoxColumn()
        ColTimerAKA = New DataGridViewTextBoxColumn()
        ColTypeAKA = New DataGridViewTextBoxColumn()
        BtnShowWinnerAKA = New Button()
        BtnResetScoreAKA = New Button()
        BtnSenshuAKA = New Button()
        LabelScoreAKA = New Label()
        BtnIpponAKA = New Button()
        BtnWazaariAKA = New Button()
        BtnYukoAKA = New Button()
        PanelAO = New Panel()
        PictureBox2 = New PictureBox()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        LabelTitleAO = New Label()
        PicBoxAO = New PictureBox()
        LblNameAO = New Label()
        TxtNameAO = New TextBox()
        LblTeamAO = New Label()
        TxtTeamAO = New TextBox()
        LblTeamInfoAO = New Label()
        TxtTeamInfoAO = New TextBox()
        BtnUpdateInfoAO = New Button()
        BtnKikenAO = New Button()
        BtnShikkakuAO = New Button()
        BtnKnockedOutAO = New Button()
        BtnPAO = New Button()
        Btn1CAO = New Button()
        Btn2CAO = New Button()
        Btn3CAO = New Button()
        BtnHCAO = New Button()
        BtnHAO = New Button()
        GrpScoreSummaryAO = New GroupBox()
        DgvLogAO = New DataGridView()
        ColNoAO = New DataGridViewTextBoxColumn()
        ColTimerAO = New DataGridViewTextBoxColumn()
        ColTypeAO = New DataGridViewTextBoxColumn()
        BtnShowWinnerAO = New Button()
        BtnResetScoreAO = New Button()
        BtnSenshuAO = New Button()
        LabelScoreAO = New Label()
        BtnIpponAO = New Button()
        BtnWazaariAO = New Button()
        BtnYukoAO = New Button()
        PanelRight = New Panel()
        NumericUpDown1 = New NumericUpDown()
        ComboBox1 = New ComboBox()
        TabControlMatch = New TabControl()
        TabPageDetail = New TabPage()
        TxtMatchDesc = New TextBox()
        LblWinPoint = New Label()
        NumWinPoint = New NumericUpDown()
        LblTatami = New Label()
        NumTatami = New NumericUpDown()
        GrpWaitTimer = New GroupBox()
        NumWaitMin = New NumericUpDown()
        NumWaitSec = New NumericUpDown()
        BtnStartWait = New Button()
        GrpMatchTimer = New GroupBox()
        BtnPreset130 = New Button()
        BtnPreset200 = New Button()
        BtnPreset300 = New Button()
        LabelMainTimer = New Label()
        BtnStartScBoard = New Button()
        BtnStartTimer = New Button()
        PanelBottom = New Panel()
        BtnSettings = New Button()
        BtnLogActivity = New Button()
        BtnShortcut = New Button()
        BtnResetHantei = New Button()
        BtnHantei = New Button()
        BtnDraw = New Button()
        BtnResetMatch = New Button()
        BtnSaveMatch = New Button()
        PanelTop.SuspendLayout()
        PanelAKA.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBoxAKA, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvLogAKA, ComponentModel.ISupportInitialize).BeginInit()
        PanelAO.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBoxAO, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvLogAO, ComponentModel.ISupportInitialize).BeginInit()
        PanelRight.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        TabControlMatch.SuspendLayout()
        TabPageDetail.SuspendLayout()
        CType(NumWinPoint, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumTatami, ComponentModel.ISupportInitialize).BeginInit()
        GrpWaitTimer.SuspendLayout()
        CType(NumWaitMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumWaitSec, ComponentModel.ISupportInitialize).BeginInit()
        GrpMatchTimer.SuspendLayout()
        PanelBottom.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTop
        ' 
        PanelTop.BackColor = Color.WhiteSmoke
        PanelTop.Controls.Add(LabelNextMatch)
        PanelTop.Controls.Add(TxtNextMatchAKA)
        PanelTop.Controls.Add(LabelVS)
        PanelTop.Controls.Add(TxtNextMatchAO)
        PanelTop.Controls.Add(BtnLoadNextMatch)
        PanelTop.Dock = DockStyle.Top
        PanelTop.Location = New Point(0, 0)
        PanelTop.Margin = New Padding(4, 3, 4, 3)
        PanelTop.Name = "PanelTop"
        PanelTop.Size = New Size(1795, 58)
        PanelTop.TabIndex = 0
        ' 
        ' LabelNextMatch
        ' 
        LabelNextMatch.BackColor = Color.Gold
        LabelNextMatch.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        LabelNextMatch.Location = New Point(14, 12)
        LabelNextMatch.Margin = New Padding(4, 0, 4, 0)
        LabelNextMatch.Name = "LabelNextMatch"
        LabelNextMatch.Size = New Size(140, 35)
        LabelNextMatch.TabIndex = 0
        LabelNextMatch.Text = "Next Match"
        LabelNextMatch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtNextMatchAKA
        ' 
        TxtNextMatchAKA.Font = New Font("Arial", 12.0F)
        TxtNextMatchAKA.Location = New Point(163, 14)
        TxtNextMatchAKA.Margin = New Padding(4, 3, 4, 3)
        TxtNextMatchAKA.Name = "TxtNextMatchAKA"
        TxtNextMatchAKA.Size = New Size(233, 26)
        TxtNextMatchAKA.TabIndex = 1
        ' 
        ' LabelVS
        ' 
        LabelVS.BackColor = Color.Gold
        LabelVS.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        LabelVS.Location = New Point(443, 12)
        LabelVS.Margin = New Padding(4, 0, 4, 0)
        LabelVS.Name = "LabelVS"
        LabelVS.Size = New Size(47, 35)
        LabelVS.TabIndex = 2
        LabelVS.Text = "VS"
        LabelVS.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtNextMatchAO
        ' 
        TxtNextMatchAO.Font = New Font("Arial", 12.0F)
        TxtNextMatchAO.Location = New Point(502, 14)
        TxtNextMatchAO.Margin = New Padding(4, 3, 4, 3)
        TxtNextMatchAO.Name = "TxtNextMatchAO"
        TxtNextMatchAO.Size = New Size(233, 26)
        TxtNextMatchAO.TabIndex = 3
        ' 
        ' BtnLoadNextMatch
        ' 
        BtnLoadNextMatch.BackColor = Color.Gold
        BtnLoadNextMatch.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        BtnLoadNextMatch.Location = New Point(793, 12)
        BtnLoadNextMatch.Margin = New Padding(4, 3, 4, 3)
        BtnLoadNextMatch.Name = "BtnLoadNextMatch"
        BtnLoadNextMatch.Size = New Size(175, 35)
        BtnLoadNextMatch.TabIndex = 4
        BtnLoadNextMatch.Text = "Load Next Match"
        BtnLoadNextMatch.UseVisualStyleBackColor = False
        ' 
        ' PanelAKA
        ' 
        PanelAKA.BackColor = Color.White
        PanelAKA.BorderStyle = BorderStyle.FixedSingle
        PanelAKA.Controls.Add(PictureBox1)
        PanelAKA.Controls.Add(Button6)
        PanelAKA.Controls.Add(Button5)
        PanelAKA.Controls.Add(Button4)
        PanelAKA.Controls.Add(Button3)
        PanelAKA.Controls.Add(Button2)
        PanelAKA.Controls.Add(Button1)
        PanelAKA.Controls.Add(LabelTitleAKA)
        PanelAKA.Controls.Add(LabelWinnerAKA)
        PanelAKA.Controls.Add(PicBoxAKA)
        PanelAKA.Controls.Add(LblNameAKA)
        PanelAKA.Controls.Add(TxtNameAKA)
        PanelAKA.Controls.Add(LblTeamAKA)
        PanelAKA.Controls.Add(TxtTeamAKA)
        PanelAKA.Controls.Add(LblTeamInfoAKA)
        PanelAKA.Controls.Add(TxtTeamInfoAKA)
        PanelAKA.Controls.Add(BtnUpdateInfoAKA)
        PanelAKA.Controls.Add(BtnKikenAKA)
        PanelAKA.Controls.Add(BtnShikkakuAKA)
        PanelAKA.Controls.Add(BtnKnockedOutAKA)
        PanelAKA.Controls.Add(BtnPAKA)
        PanelAKA.Controls.Add(Btn1CAKA)
        PanelAKA.Controls.Add(Btn2CAKA)
        PanelAKA.Controls.Add(Btn3CAKA)
        PanelAKA.Controls.Add(BtnHCAKA)
        PanelAKA.Controls.Add(BtnHAKA)
        PanelAKA.Controls.Add(GrpScoreSummaryAKA)
        PanelAKA.Controls.Add(DgvLogAKA)
        PanelAKA.Controls.Add(BtnShowWinnerAKA)
        PanelAKA.Controls.Add(BtnResetScoreAKA)
        PanelAKA.Controls.Add(BtnSenshuAKA)
        PanelAKA.Controls.Add(LabelScoreAKA)
        PanelAKA.Controls.Add(BtnIpponAKA)
        PanelAKA.Controls.Add(BtnWazaariAKA)
        PanelAKA.Controls.Add(BtnYukoAKA)
        PanelAKA.Location = New Point(14, 69)
        PanelAKA.Margin = New Padding(4, 3, 4, 3)
        PanelAKA.Name = "PanelAKA"
        PanelAKA.Size = New Size(1108, 369)
        PanelAKA.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(542, 169)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 50)
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(428, 169)
        Button6.Name = "Button6"
        Button6.Size = New Size(50, 24)
        Button6.TabIndex = 33
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(542, 117)
        Button5.Name = "Button5"
        Button5.Size = New Size(50, 35)
        Button5.TabIndex = 32
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(542, 51)
        Button4.Name = "Button4"
        Button4.Size = New Size(50, 35)
        Button4.TabIndex = 31
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(0, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 30
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(503, 310)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 35)
        Button2.TabIndex = 29
        Button2.Text = "AKA VR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(503, 254)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 35)
        Button1.TabIndex = 28
        Button1.Text = "VR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LabelTitleAKA
        ' 
        LabelTitleAKA.BackColor = Color.Crimson
        LabelTitleAKA.Dock = DockStyle.Top
        LabelTitleAKA.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        LabelTitleAKA.ForeColor = Color.White
        LabelTitleAKA.Location = New Point(0, 0)
        LabelTitleAKA.Margin = New Padding(4, 0, 4, 0)
        LabelTitleAKA.Name = "LabelTitleAKA"
        LabelTitleAKA.Size = New Size(1106, 35)
        LabelTitleAKA.TabIndex = 0
        LabelTitleAKA.Text = "AKA"
        LabelTitleAKA.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelWinnerAKA
        ' 
        LabelWinnerAKA.BackColor = Color.Gold
        LabelWinnerAKA.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        LabelWinnerAKA.Location = New Point(966, 0)
        LabelWinnerAKA.Margin = New Padding(4, 0, 4, 0)
        LabelWinnerAKA.Name = "LabelWinnerAKA"
        LabelWinnerAKA.Size = New Size(140, 35)
        LabelWinnerAKA.TabIndex = 1
        LabelWinnerAKA.Text = "WINNER"
        LabelWinnerAKA.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicBoxAKA
        ' 
        PicBoxAKA.BorderStyle = BorderStyle.FixedSingle
        PicBoxAKA.Location = New Point(23, 58)
        PicBoxAKA.Margin = New Padding(4, 3, 4, 3)
        PicBoxAKA.Name = "PicBoxAKA"
        PicBoxAKA.Size = New Size(81, 80)
        PicBoxAKA.TabIndex = 2
        PicBoxAKA.TabStop = False
        ' 
        ' LblNameAKA
        ' 
        LblNameAKA.Location = New Point(117, 63)
        LblNameAKA.Margin = New Padding(4, 0, 4, 0)
        LblNameAKA.Name = "LblNameAKA"
        LblNameAKA.Size = New Size(58, 23)
        LblNameAKA.TabIndex = 3
        LblNameAKA.Text = "Name"
        ' 
        ' TxtNameAKA
        ' 
        TxtNameAKA.Location = New Point(187, 60)
        TxtNameAKA.Margin = New Padding(4, 3, 4, 3)
        TxtNameAKA.Name = "TxtNameAKA"
        TxtNameAKA.Size = New Size(291, 23)
        TxtNameAKA.TabIndex = 4
        TxtNameAKA.Text = "Wahyu Hidayat"
        ' 
        ' LblTeamAKA
        ' 
        LblTeamAKA.Location = New Point(117, 98)
        LblTeamAKA.Margin = New Padding(4, 0, 4, 0)
        LblTeamAKA.Name = "LblTeamAKA"
        LblTeamAKA.Size = New Size(58, 23)
        LblTeamAKA.TabIndex = 5
        LblTeamAKA.Text = "Team"
        ' 
        ' TxtTeamAKA
        ' 
        TxtTeamAKA.Location = New Point(187, 95)
        TxtTeamAKA.Margin = New Padding(4, 3, 4, 3)
        TxtTeamAKA.Name = "TxtTeamAKA"
        TxtTeamAKA.Size = New Size(291, 23)
        TxtTeamAKA.TabIndex = 6
        TxtTeamAKA.Text = "Dojo Rajawali"
        ' 
        ' LblTeamInfoAKA
        ' 
        LblTeamInfoAKA.Location = New Point(117, 133)
        LblTeamInfoAKA.Margin = New Padding(4, 0, 4, 0)
        LblTeamInfoAKA.Name = "LblTeamInfoAKA"
        LblTeamInfoAKA.Size = New Size(70, 23)
        LblTeamInfoAKA.TabIndex = 7
        LblTeamInfoAKA.Text = "Team Info"
        ' 
        ' TxtTeamInfoAKA
        ' 
        TxtTeamInfoAKA.Location = New Point(187, 129)
        TxtTeamInfoAKA.Margin = New Padding(4, 3, 4, 3)
        TxtTeamInfoAKA.Name = "TxtTeamInfoAKA"
        TxtTeamInfoAKA.Size = New Size(291, 23)
        TxtTeamInfoAKA.TabIndex = 8
        TxtTeamInfoAKA.Text = "INKAI"
        ' 
        ' BtnUpdateInfoAKA
        ' 
        BtnUpdateInfoAKA.Location = New Point(187, 164)
        BtnUpdateInfoAKA.Margin = New Padding(4, 3, 4, 3)
        BtnUpdateInfoAKA.Name = "BtnUpdateInfoAKA"
        BtnUpdateInfoAKA.Size = New Size(175, 29)
        BtnUpdateInfoAKA.TabIndex = 9
        BtnUpdateInfoAKA.Text = "Update Info"
        ' 
        ' BtnKikenAKA
        ' 
        BtnKikenAKA.Location = New Point(23, 208)
        BtnKikenAKA.Margin = New Padding(4, 3, 4, 3)
        BtnKikenAKA.Name = "BtnKikenAKA"
        BtnKikenAKA.Size = New Size(93, 35)
        BtnKikenAKA.TabIndex = 10
        BtnKikenAKA.Text = "Kiken"
        ' 
        ' BtnShikkakuAKA
        ' 
        BtnShikkakuAKA.Location = New Point(23, 248)
        BtnShikkakuAKA.Margin = New Padding(4, 3, 4, 3)
        BtnShikkakuAKA.Name = "BtnShikkakuAKA"
        BtnShikkakuAKA.Size = New Size(93, 35)
        BtnShikkakuAKA.TabIndex = 11
        BtnShikkakuAKA.Text = "Shikkaku"
        ' 
        ' BtnKnockedOutAKA
        ' 
        BtnKnockedOutAKA.Location = New Point(23, 288)
        BtnKnockedOutAKA.Margin = New Padding(4, 3, 4, 3)
        BtnKnockedOutAKA.Name = "BtnKnockedOutAKA"
        BtnKnockedOutAKA.Size = New Size(93, 46)
        BtnKnockedOutAKA.TabIndex = 12
        BtnKnockedOutAKA.Text = "Knocked Out"
        ' 
        ' BtnPAKA
        ' 
        BtnPAKA.Location = New Point(128, 208)
        BtnPAKA.Margin = New Padding(4, 3, 4, 3)
        BtnPAKA.Name = "BtnPAKA"
        BtnPAKA.Size = New Size(41, 40)
        BtnPAKA.TabIndex = 13
        BtnPAKA.Text = "P"
        ' 
        ' Btn1CAKA
        ' 
        Btn1CAKA.Location = New Point(175, 208)
        Btn1CAKA.Margin = New Padding(4, 3, 4, 3)
        Btn1CAKA.Name = "Btn1CAKA"
        Btn1CAKA.Size = New Size(41, 40)
        Btn1CAKA.TabIndex = 14
        Btn1CAKA.Text = "1C"
        ' 
        ' Btn2CAKA
        ' 
        Btn2CAKA.Location = New Point(222, 208)
        Btn2CAKA.Margin = New Padding(4, 3, 4, 3)
        Btn2CAKA.Name = "Btn2CAKA"
        Btn2CAKA.Size = New Size(41, 40)
        Btn2CAKA.TabIndex = 15
        Btn2CAKA.Text = "2C"
        ' 
        ' Btn3CAKA
        ' 
        Btn3CAKA.Location = New Point(268, 208)
        Btn3CAKA.Margin = New Padding(4, 3, 4, 3)
        Btn3CAKA.Name = "Btn3CAKA"
        Btn3CAKA.Size = New Size(41, 40)
        Btn3CAKA.TabIndex = 16
        Btn3CAKA.Text = "3C"
        ' 
        ' BtnHCAKA
        ' 
        BtnHCAKA.Location = New Point(315, 208)
        BtnHCAKA.Margin = New Padding(4, 3, 4, 3)
        BtnHCAKA.Name = "BtnHCAKA"
        BtnHCAKA.Size = New Size(41, 40)
        BtnHCAKA.TabIndex = 17
        BtnHCAKA.Text = "HC"
        ' 
        ' BtnHAKA
        ' 
        BtnHAKA.Location = New Point(362, 208)
        BtnHAKA.Margin = New Padding(4, 3, 4, 3)
        BtnHAKA.Name = "BtnHAKA"
        BtnHAKA.Size = New Size(41, 40)
        BtnHAKA.TabIndex = 18
        BtnHAKA.Text = "H"
        ' 
        ' GrpScoreSummaryAKA
        ' 
        GrpScoreSummaryAKA.Location = New Point(128, 254)
        GrpScoreSummaryAKA.Margin = New Padding(4, 3, 4, 3)
        GrpScoreSummaryAKA.Name = "GrpScoreSummaryAKA"
        GrpScoreSummaryAKA.Padding = New Padding(4, 3, 4, 3)
        GrpScoreSummaryAKA.Size = New Size(350, 81)
        GrpScoreSummaryAKA.TabIndex = 19
        GrpScoreSummaryAKA.TabStop = False
        GrpScoreSummaryAKA.Text = "Score Summary"
        ' 
        ' DgvLogAKA
        ' 
        DgvLogAKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvLogAKA.Columns.AddRange(New DataGridViewColumn() {ColNoAKA, ColTimerAKA, ColTypeAKA})
        DgvLogAKA.Location = New Point(650, 58)
        DgvLogAKA.Margin = New Padding(4, 3, 4, 3)
        DgvLogAKA.Name = "DgvLogAKA"
        DgvLogAKA.Size = New Size(303, 231)
        DgvLogAKA.TabIndex = 20
        ' 
        ' ColNoAKA
        ' 
        ColNoAKA.HeaderText = "No"
        ColNoAKA.Name = "ColNoAKA"
        ColNoAKA.Width = 30
        ' 
        ' ColTimerAKA
        ' 
        ColTimerAKA.HeaderText = "Timer"
        ColTimerAKA.Name = "ColTimerAKA"
        ColTimerAKA.Width = 60
        ' 
        ' ColTypeAKA
        ' 
        ColTypeAKA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColTypeAKA.HeaderText = "Type"
        ColTypeAKA.Name = "ColTypeAKA"
        ' 
        ' BtnShowWinnerAKA
        ' 
        BtnShowWinnerAKA.Location = New Point(768, 312)
        BtnShowWinnerAKA.Margin = New Padding(4, 3, 4, 3)
        BtnShowWinnerAKA.Name = "BtnShowWinnerAKA"
        BtnShowWinnerAKA.Size = New Size(93, 35)
        BtnShowWinnerAKA.TabIndex = 21
        BtnShowWinnerAKA.Text = "Show Winner"
        ' 
        ' BtnResetScoreAKA
        ' 
        BtnResetScoreAKA.Location = New Point(884, 312)
        BtnResetScoreAKA.Margin = New Padding(4, 3, 4, 3)
        BtnResetScoreAKA.Name = "BtnResetScoreAKA"
        BtnResetScoreAKA.Size = New Size(93, 35)
        BtnResetScoreAKA.TabIndex = 22
        BtnResetScoreAKA.Text = "Reset Score"
        ' 
        ' BtnSenshuAKA
        ' 
        BtnSenshuAKA.Location = New Point(994, 312)
        BtnSenshuAKA.Margin = New Padding(4, 3, 4, 3)
        BtnSenshuAKA.Name = "BtnSenshuAKA"
        BtnSenshuAKA.Size = New Size(93, 35)
        BtnSenshuAKA.TabIndex = 23
        BtnSenshuAKA.Text = "Senshu"
        ' 
        ' LabelScoreAKA
        ' 
        LabelScoreAKA.Font = New Font("Arial", 48.0F, FontStyle.Bold)
        LabelScoreAKA.Location = New Point(986, 51)
        LabelScoreAKA.Margin = New Padding(4, 0, 4, 0)
        LabelScoreAKA.Name = "LabelScoreAKA"
        LabelScoreAKA.Size = New Size(116, 72)
        LabelScoreAKA.TabIndex = 24
        LabelScoreAKA.Text = "0"
        LabelScoreAKA.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnIpponAKA
        ' 
        BtnIpponAKA.BackColor = Color.LightCoral
        BtnIpponAKA.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        BtnIpponAKA.Location = New Point(986, 138)
        BtnIpponAKA.Margin = New Padding(4, 3, 4, 3)
        BtnIpponAKA.Name = "BtnIpponAKA"
        BtnIpponAKA.Size = New Size(101, 40)
        BtnIpponAKA.TabIndex = 25
        BtnIpponAKA.Text = "Ippon 3"
        BtnIpponAKA.UseVisualStyleBackColor = False
        ' 
        ' BtnWazaariAKA
        ' 
        BtnWazaariAKA.BackColor = Color.LightCoral
        BtnWazaariAKA.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        BtnWazaariAKA.Location = New Point(986, 184)
        BtnWazaariAKA.Margin = New Padding(4, 3, 4, 3)
        BtnWazaariAKA.Name = "BtnWazaariAKA"
        BtnWazaariAKA.Size = New Size(99, 35)
        BtnWazaariAKA.TabIndex = 26
        BtnWazaariAKA.Text = "Waza-ari 2"
        BtnWazaariAKA.UseVisualStyleBackColor = False
        ' 
        ' BtnYukoAKA
        ' 
        BtnYukoAKA.BackColor = Color.LightCoral
        BtnYukoAKA.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        BtnYukoAKA.Location = New Point(986, 225)
        BtnYukoAKA.Margin = New Padding(4, 3, 4, 3)
        BtnYukoAKA.Name = "BtnYukoAKA"
        BtnYukoAKA.Size = New Size(99, 37)
        BtnYukoAKA.TabIndex = 27
        BtnYukoAKA.Text = "Yuko 1"
        BtnYukoAKA.UseVisualStyleBackColor = False
        ' 
        ' PanelAO
        ' 
        PanelAO.BackColor = Color.White
        PanelAO.BorderStyle = BorderStyle.FixedSingle
        PanelAO.Controls.Add(PictureBox2)
        PanelAO.Controls.Add(Button7)
        PanelAO.Controls.Add(Button8)
        PanelAO.Controls.Add(Button9)
        PanelAO.Controls.Add(LabelTitleAO)
        PanelAO.Controls.Add(PicBoxAO)
        PanelAO.Controls.Add(LblNameAO)
        PanelAO.Controls.Add(TxtNameAO)
        PanelAO.Controls.Add(LblTeamAO)
        PanelAO.Controls.Add(TxtTeamAO)
        PanelAO.Controls.Add(LblTeamInfoAO)
        PanelAO.Controls.Add(TxtTeamInfoAO)
        PanelAO.Controls.Add(BtnUpdateInfoAO)
        PanelAO.Controls.Add(BtnKikenAO)
        PanelAO.Controls.Add(BtnShikkakuAO)
        PanelAO.Controls.Add(BtnKnockedOutAO)
        PanelAO.Controls.Add(BtnPAO)
        PanelAO.Controls.Add(Btn1CAO)
        PanelAO.Controls.Add(Btn2CAO)
        PanelAO.Controls.Add(Btn3CAO)
        PanelAO.Controls.Add(BtnHCAO)
        PanelAO.Controls.Add(BtnHAO)
        PanelAO.Controls.Add(GrpScoreSummaryAO)
        PanelAO.Controls.Add(DgvLogAO)
        PanelAO.Controls.Add(BtnShowWinnerAO)
        PanelAO.Controls.Add(BtnResetScoreAO)
        PanelAO.Controls.Add(BtnSenshuAO)
        PanelAO.Controls.Add(LabelScoreAO)
        PanelAO.Controls.Add(BtnIpponAO)
        PanelAO.Controls.Add(BtnWazaariAO)
        PanelAO.Controls.Add(BtnYukoAO)
        PanelAO.Location = New Point(14, 456)
        PanelAO.Margin = New Padding(4, 3, 4, 3)
        PanelAO.Name = "PanelAO"
        PanelAO.Size = New Size(1108, 369)
        PanelAO.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(568, 185)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 50)
        PictureBox2.TabIndex = 38
        PictureBox2.TabStop = False
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(454, 185)
        Button7.Name = "Button7"
        Button7.Size = New Size(50, 24)
        Button7.TabIndex = 37
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(568, 133)
        Button8.Name = "Button8"
        Button8.Size = New Size(50, 35)
        Button8.TabIndex = 36
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(568, 67)
        Button9.Name = "Button9"
        Button9.Size = New Size(50, 35)
        Button9.TabIndex = 35
        Button9.UseVisualStyleBackColor = True
        ' 
        ' LabelTitleAO
        ' 
        LabelTitleAO.BackColor = Color.DodgerBlue
        LabelTitleAO.Dock = DockStyle.Top
        LabelTitleAO.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        LabelTitleAO.ForeColor = Color.White
        LabelTitleAO.Location = New Point(0, 0)
        LabelTitleAO.Margin = New Padding(4, 0, 4, 0)
        LabelTitleAO.Name = "LabelTitleAO"
        LabelTitleAO.Size = New Size(1106, 35)
        LabelTitleAO.TabIndex = 0
        LabelTitleAO.Text = "AO"
        LabelTitleAO.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicBoxAO
        ' 
        PicBoxAO.BorderStyle = BorderStyle.FixedSingle
        PicBoxAO.Location = New Point(23, 58)
        PicBoxAO.Margin = New Padding(4, 3, 4, 3)
        PicBoxAO.Name = "PicBoxAO"
        PicBoxAO.Size = New Size(81, 80)
        PicBoxAO.TabIndex = 1
        PicBoxAO.TabStop = False
        ' 
        ' LblNameAO
        ' 
        LblNameAO.Location = New Point(117, 63)
        LblNameAO.Margin = New Padding(4, 0, 4, 0)
        LblNameAO.Name = "LblNameAO"
        LblNameAO.Size = New Size(58, 23)
        LblNameAO.TabIndex = 2
        LblNameAO.Text = "Name"
        ' 
        ' TxtNameAO
        ' 
        TxtNameAO.Location = New Point(187, 60)
        TxtNameAO.Margin = New Padding(4, 3, 4, 3)
        TxtNameAO.Name = "TxtNameAO"
        TxtNameAO.Size = New Size(291, 23)
        TxtNameAO.TabIndex = 3
        TxtNameAO.Text = "Farhan Nugraha"
        ' 
        ' LblTeamAO
        ' 
        LblTeamAO.Location = New Point(117, 98)
        LblTeamAO.Margin = New Padding(4, 0, 4, 0)
        LblTeamAO.Name = "LblTeamAO"
        LblTeamAO.Size = New Size(58, 23)
        LblTeamAO.TabIndex = 4
        LblTeamAO.Text = "Team"
        ' 
        ' TxtTeamAO
        ' 
        TxtTeamAO.Location = New Point(187, 95)
        TxtTeamAO.Margin = New Padding(4, 3, 4, 3)
        TxtTeamAO.Name = "TxtTeamAO"
        TxtTeamAO.Size = New Size(291, 23)
        TxtTeamAO.TabIndex = 5
        TxtTeamAO.Text = "Dojo Rajawali"
        ' 
        ' LblTeamInfoAO
        ' 
        LblTeamInfoAO.Location = New Point(117, 133)
        LblTeamInfoAO.Margin = New Padding(4, 0, 4, 0)
        LblTeamInfoAO.Name = "LblTeamInfoAO"
        LblTeamInfoAO.Size = New Size(70, 23)
        LblTeamInfoAO.TabIndex = 6
        LblTeamInfoAO.Text = "Team Info"
        ' 
        ' TxtTeamInfoAO
        ' 
        TxtTeamInfoAO.Location = New Point(187, 129)
        TxtTeamInfoAO.Margin = New Padding(4, 3, 4, 3)
        TxtTeamInfoAO.Name = "TxtTeamInfoAO"
        TxtTeamInfoAO.Size = New Size(291, 23)
        TxtTeamInfoAO.TabIndex = 7
        TxtTeamInfoAO.Text = "INKAI"
        ' 
        ' BtnUpdateInfoAO
        ' 
        BtnUpdateInfoAO.Location = New Point(187, 164)
        BtnUpdateInfoAO.Margin = New Padding(4, 3, 4, 3)
        BtnUpdateInfoAO.Name = "BtnUpdateInfoAO"
        BtnUpdateInfoAO.Size = New Size(175, 29)
        BtnUpdateInfoAO.TabIndex = 8
        BtnUpdateInfoAO.Text = "Update Info"
        ' 
        ' BtnKikenAO
        ' 
        BtnKikenAO.Location = New Point(23, 208)
        BtnKikenAO.Margin = New Padding(4, 3, 4, 3)
        BtnKikenAO.Name = "BtnKikenAO"
        BtnKikenAO.Size = New Size(93, 35)
        BtnKikenAO.TabIndex = 9
        BtnKikenAO.Text = "Kiken"
        ' 
        ' BtnShikkakuAO
        ' 
        BtnShikkakuAO.Location = New Point(23, 248)
        BtnShikkakuAO.Margin = New Padding(4, 3, 4, 3)
        BtnShikkakuAO.Name = "BtnShikkakuAO"
        BtnShikkakuAO.Size = New Size(93, 35)
        BtnShikkakuAO.TabIndex = 10
        BtnShikkakuAO.Text = "Shikkaku"
        ' 
        ' BtnKnockedOutAO
        ' 
        BtnKnockedOutAO.Location = New Point(23, 288)
        BtnKnockedOutAO.Margin = New Padding(4, 3, 4, 3)
        BtnKnockedOutAO.Name = "BtnKnockedOutAO"
        BtnKnockedOutAO.Size = New Size(93, 46)
        BtnKnockedOutAO.TabIndex = 11
        BtnKnockedOutAO.Text = "Knocked Out"
        ' 
        ' BtnPAO
        ' 
        BtnPAO.Location = New Point(128, 208)
        BtnPAO.Margin = New Padding(4, 3, 4, 3)
        BtnPAO.Name = "BtnPAO"
        BtnPAO.Size = New Size(41, 40)
        BtnPAO.TabIndex = 12
        BtnPAO.Text = "P"
        ' 
        ' Btn1CAO
        ' 
        Btn1CAO.Location = New Point(175, 208)
        Btn1CAO.Margin = New Padding(4, 3, 4, 3)
        Btn1CAO.Name = "Btn1CAO"
        Btn1CAO.Size = New Size(41, 40)
        Btn1CAO.TabIndex = 13
        Btn1CAO.Text = "1C"
        ' 
        ' Btn2CAO
        ' 
        Btn2CAO.Location = New Point(222, 208)
        Btn2CAO.Margin = New Padding(4, 3, 4, 3)
        Btn2CAO.Name = "Btn2CAO"
        Btn2CAO.Size = New Size(41, 40)
        Btn2CAO.TabIndex = 14
        Btn2CAO.Text = "2C"
        ' 
        ' Btn3CAO
        ' 
        Btn3CAO.Location = New Point(268, 208)
        Btn3CAO.Margin = New Padding(4, 3, 4, 3)
        Btn3CAO.Name = "Btn3CAO"
        Btn3CAO.Size = New Size(41, 40)
        Btn3CAO.TabIndex = 15
        Btn3CAO.Text = "3C"
        ' 
        ' BtnHCAO
        ' 
        BtnHCAO.Location = New Point(315, 208)
        BtnHCAO.Margin = New Padding(4, 3, 4, 3)
        BtnHCAO.Name = "BtnHCAO"
        BtnHCAO.Size = New Size(41, 40)
        BtnHCAO.TabIndex = 16
        BtnHCAO.Text = "HC"
        ' 
        ' BtnHAO
        ' 
        BtnHAO.Location = New Point(362, 208)
        BtnHAO.Margin = New Padding(4, 3, 4, 3)
        BtnHAO.Name = "BtnHAO"
        BtnHAO.Size = New Size(41, 40)
        BtnHAO.TabIndex = 17
        BtnHAO.Text = "H"
        ' 
        ' GrpScoreSummaryAO
        ' 
        GrpScoreSummaryAO.Location = New Point(128, 254)
        GrpScoreSummaryAO.Margin = New Padding(4, 3, 4, 3)
        GrpScoreSummaryAO.Name = "GrpScoreSummaryAO"
        GrpScoreSummaryAO.Padding = New Padding(4, 3, 4, 3)
        GrpScoreSummaryAO.Size = New Size(350, 81)
        GrpScoreSummaryAO.TabIndex = 18
        GrpScoreSummaryAO.TabStop = False
        GrpScoreSummaryAO.Text = "Score Summary"
        ' 
        ' DgvLogAO
        ' 
        DgvLogAO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvLogAO.Columns.AddRange(New DataGridViewColumn() {ColNoAO, ColTimerAO, ColTypeAO})
        DgvLogAO.Location = New Point(674, 52)
        DgvLogAO.Margin = New Padding(4, 3, 4, 3)
        DgvLogAO.Name = "DgvLogAO"
        DgvLogAO.Size = New Size(303, 231)
        DgvLogAO.TabIndex = 19
        ' 
        ' ColNoAO
        ' 
        ColNoAO.HeaderText = "No"
        ColNoAO.Name = "ColNoAO"
        ColNoAO.Width = 30
        ' 
        ' ColTimerAO
        ' 
        ColTimerAO.HeaderText = "Timer"
        ColTimerAO.Name = "ColTimerAO"
        ColTimerAO.Width = 60
        ' 
        ' ColTypeAO
        ' 
        ColTypeAO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColTypeAO.HeaderText = "Type"
        ColTypeAO.Name = "ColTypeAO"
        ' 
        ' BtnShowWinnerAO
        ' 
        BtnShowWinnerAO.Location = New Point(513, 300)
        BtnShowWinnerAO.Margin = New Padding(4, 3, 4, 3)
        BtnShowWinnerAO.Name = "BtnShowWinnerAO"
        BtnShowWinnerAO.Size = New Size(93, 35)
        BtnShowWinnerAO.TabIndex = 20
        BtnShowWinnerAO.Text = "Show Winner"
        ' 
        ' BtnResetScoreAO
        ' 
        BtnResetScoreAO.Location = New Point(618, 300)
        BtnResetScoreAO.Margin = New Padding(4, 3, 4, 3)
        BtnResetScoreAO.Name = "BtnResetScoreAO"
        BtnResetScoreAO.Size = New Size(93, 35)
        BtnResetScoreAO.TabIndex = 21
        BtnResetScoreAO.Text = "Reset Score"
        ' 
        ' BtnSenshuAO
        ' 
        BtnSenshuAO.Location = New Point(723, 300)
        BtnSenshuAO.Margin = New Padding(4, 3, 4, 3)
        BtnSenshuAO.Name = "BtnSenshuAO"
        BtnSenshuAO.Size = New Size(93, 35)
        BtnSenshuAO.TabIndex = 22
        BtnSenshuAO.Text = "Senshu"
        ' 
        ' LabelScoreAO
        ' 
        LabelScoreAO.Font = New Font("Arial", 48.0F, FontStyle.Bold)
        LabelScoreAO.Location = New Point(986, 52)
        LabelScoreAO.Margin = New Padding(4, 0, 4, 0)
        LabelScoreAO.Name = "LabelScoreAO"
        LabelScoreAO.Size = New Size(102, 75)
        LabelScoreAO.TabIndex = 23
        LabelScoreAO.Text = "0"
        LabelScoreAO.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnIpponAO
        ' 
        BtnIpponAO.BackColor = Color.LightSkyBlue
        BtnIpponAO.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        BtnIpponAO.Location = New Point(989, 133)
        BtnIpponAO.Margin = New Padding(4, 3, 4, 3)
        BtnIpponAO.Name = "BtnIpponAO"
        BtnIpponAO.Size = New Size(99, 40)
        BtnIpponAO.TabIndex = 24
        BtnIpponAO.Text = "Ippon 3"
        BtnIpponAO.UseVisualStyleBackColor = False
        ' 
        ' BtnWazaariAO
        ' 
        BtnWazaariAO.BackColor = Color.LightSkyBlue
        BtnWazaariAO.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        BtnWazaariAO.Location = New Point(989, 177)
        BtnWazaariAO.Margin = New Padding(4, 3, 4, 3)
        BtnWazaariAO.Name = "BtnWazaariAO"
        BtnWazaariAO.Size = New Size(98, 40)
        BtnWazaariAO.TabIndex = 25
        BtnWazaariAO.Text = "Waza-ari 2"
        BtnWazaariAO.UseVisualStyleBackColor = False
        ' 
        ' BtnYukoAO
        ' 
        BtnYukoAO.BackColor = Color.LightSkyBlue
        BtnYukoAO.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        BtnYukoAO.Location = New Point(986, 223)
        BtnYukoAO.Margin = New Padding(4, 3, 4, 3)
        BtnYukoAO.Name = "BtnYukoAO"
        BtnYukoAO.Size = New Size(99, 40)
        BtnYukoAO.TabIndex = 26
        BtnYukoAO.Text = "Yuko 1"
        BtnYukoAO.UseVisualStyleBackColor = False
        ' 
        ' PanelRight
        ' 
        PanelRight.BackColor = Color.White
        PanelRight.Controls.Add(NumericUpDown1)
        PanelRight.Controls.Add(ComboBox1)
        PanelRight.Controls.Add(TabControlMatch)
        PanelRight.Controls.Add(LblWinPoint)
        PanelRight.Controls.Add(NumWinPoint)
        PanelRight.Controls.Add(LblTatami)
        PanelRight.Controls.Add(NumTatami)
        PanelRight.Controls.Add(GrpWaitTimer)
        PanelRight.Controls.Add(GrpMatchTimer)
        PanelRight.Location = New Point(1132, 56)
        PanelRight.Margin = New Padding(4, 3, 4, 3)
        PanelRight.Name = "PanelRight"
        PanelRight.Size = New Size(582, 769)
        PanelRight.TabIndex = 3
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(93, 60)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(35, 23)
        NumericUpDown1.TabIndex = 8
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(16, 59)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(71, 23)
        ComboBox1.TabIndex = 7
        ' 
        ' TabControlMatch
        ' 
        TabControlMatch.Controls.Add(TabPageDetail)
        TabControlMatch.Location = New Point(4, 105)
        TabControlMatch.Margin = New Padding(4, 3, 4, 3)
        TabControlMatch.Name = "TabControlMatch"
        TabControlMatch.SelectedIndex = 0
        TabControlMatch.Size = New Size(231, 104)
        TabControlMatch.TabIndex = 1
        ' 
        ' TabPageDetail
        ' 
        TabPageDetail.Controls.Add(TxtMatchDesc)
        TabPageDetail.Location = New Point(4, 24)
        TabPageDetail.Margin = New Padding(4, 3, 4, 3)
        TabPageDetail.Name = "TabPageDetail"
        TabPageDetail.Size = New Size(223, 76)
        TabPageDetail.TabIndex = 0
        TabPageDetail.Text = "Match Detail"
        ' 
        ' TxtMatchDesc
        ' 
        TxtMatchDesc.Dock = DockStyle.Fill
        TxtMatchDesc.Location = New Point(0, 0)
        TxtMatchDesc.Margin = New Padding(4, 3, 4, 3)
        TxtMatchDesc.Multiline = True
        TxtMatchDesc.Name = "TxtMatchDesc"
        TxtMatchDesc.Size = New Size(223, 76)
        TxtMatchDesc.TabIndex = 0
        TxtMatchDesc.Text = "Match Description..."
        ' 
        ' LblWinPoint
        ' 
        LblWinPoint.Location = New Point(23, 323)
        LblWinPoint.Margin = New Padding(4, 0, 4, 0)
        LblWinPoint.Name = "LblWinPoint"
        LblWinPoint.Size = New Size(70, 23)
        LblWinPoint.TabIndex = 1
        LblWinPoint.Text = "Win. Point"
        ' 
        ' NumWinPoint
        ' 
        NumWinPoint.Location = New Point(105, 321)
        NumWinPoint.Margin = New Padding(4, 3, 4, 3)
        NumWinPoint.Name = "NumWinPoint"
        NumWinPoint.Size = New Size(58, 23)
        NumWinPoint.TabIndex = 2
        NumWinPoint.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' LblTatami
        ' 
        LblTatami.Location = New Point(23, 358)
        LblTatami.Margin = New Padding(4, 0, 4, 0)
        LblTatami.Name = "LblTatami"
        LblTatami.Size = New Size(70, 23)
        LblTatami.TabIndex = 3
        LblTatami.Text = "Tatami"
        ' 
        ' NumTatami
        ' 
        NumTatami.Location = New Point(105, 355)
        NumTatami.Margin = New Padding(4, 3, 4, 3)
        NumTatami.Name = "NumTatami"
        NumTatami.Size = New Size(58, 23)
        NumTatami.TabIndex = 4
        NumTatami.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' GrpWaitTimer
        ' 
        GrpWaitTimer.Controls.Add(NumWaitMin)
        GrpWaitTimer.Controls.Add(NumWaitSec)
        GrpWaitTimer.Controls.Add(BtnStartWait)
        GrpWaitTimer.Location = New Point(12, 392)
        GrpWaitTimer.Margin = New Padding(4, 3, 4, 3)
        GrpWaitTimer.Name = "GrpWaitTimer"
        GrpWaitTimer.Padding = New Padding(4, 3, 4, 3)
        GrpWaitTimer.Size = New Size(432, 69)
        GrpWaitTimer.TabIndex = 5
        GrpWaitTimer.TabStop = False
        GrpWaitTimer.Text = "Waiting Timer (minute:second)"
        ' 
        ' NumWaitMin
        ' 
        NumWaitMin.Location = New Point(23, 29)
        NumWaitMin.Margin = New Padding(4, 3, 4, 3)
        NumWaitMin.Name = "NumWaitMin"
        NumWaitMin.Size = New Size(58, 23)
        NumWaitMin.TabIndex = 0
        ' 
        ' NumWaitSec
        ' 
        NumWaitSec.Location = New Point(93, 29)
        NumWaitSec.Margin = New Padding(4, 3, 4, 3)
        NumWaitSec.Name = "NumWaitSec"
        NumWaitSec.Size = New Size(58, 23)
        NumWaitSec.TabIndex = 1
        ' 
        ' BtnStartWait
        ' 
        BtnStartWait.Location = New Point(175, 23)
        BtnStartWait.Margin = New Padding(4, 3, 4, 3)
        BtnStartWait.Name = "BtnStartWait"
        BtnStartWait.Size = New Size(117, 35)
        BtnStartWait.TabIndex = 2
        BtnStartWait.Text = "Start"
        ' 
        ' GrpMatchTimer
        ' 
        GrpMatchTimer.Controls.Add(BtnPreset130)
        GrpMatchTimer.Controls.Add(BtnPreset200)
        GrpMatchTimer.Controls.Add(BtnPreset300)
        GrpMatchTimer.Controls.Add(LabelMainTimer)
        GrpMatchTimer.Controls.Add(BtnStartScBoard)
        GrpMatchTimer.Controls.Add(BtnStartTimer)
        GrpMatchTimer.Location = New Point(12, 473)
        GrpMatchTimer.Margin = New Padding(4, 3, 4, 3)
        GrpMatchTimer.Name = "GrpMatchTimer"
        GrpMatchTimer.Padding = New Padding(4, 3, 4, 3)
        GrpMatchTimer.Size = New Size(432, 265)
        GrpMatchTimer.TabIndex = 6
        GrpMatchTimer.TabStop = False
        GrpMatchTimer.Text = "Match Timer (minute:second)"
        ' 
        ' BtnPreset130
        ' 
        BtnPreset130.Location = New Point(58, 35)
        BtnPreset130.Margin = New Padding(4, 3, 4, 3)
        BtnPreset130.Name = "BtnPreset130"
        BtnPreset130.Size = New Size(93, 29)
        BtnPreset130.TabIndex = 0
        BtnPreset130.Text = "1:30"
        ' 
        ' BtnPreset200
        ' 
        BtnPreset200.Location = New Point(163, 35)
        BtnPreset200.Margin = New Padding(4, 3, 4, 3)
        BtnPreset200.Name = "BtnPreset200"
        BtnPreset200.Size = New Size(93, 29)
        BtnPreset200.TabIndex = 1
        BtnPreset200.Text = "2:00"
        ' 
        ' BtnPreset300
        ' 
        BtnPreset300.Location = New Point(268, 35)
        BtnPreset300.Margin = New Padding(4, 3, 4, 3)
        BtnPreset300.Name = "BtnPreset300"
        BtnPreset300.Size = New Size(93, 29)
        BtnPreset300.TabIndex = 2
        BtnPreset300.Text = "3:00"
        ' 
        ' LabelMainTimer
        ' 
        LabelMainTimer.BackColor = Color.Gold
        LabelMainTimer.Font = New Font("Arial", 36.0F, FontStyle.Bold)
        LabelMainTimer.Location = New Point(23, 81)
        LabelMainTimer.Margin = New Padding(4, 0, 4, 0)
        LabelMainTimer.Name = "LabelMainTimer"
        LabelMainTimer.Size = New Size(385, 69)
        LabelMainTimer.TabIndex = 3
        LabelMainTimer.Text = "2:00"
        LabelMainTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnStartScBoard
        ' 
        BtnStartScBoard.BackColor = Color.PaleGreen
        BtnStartScBoard.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        BtnStartScBoard.Location = New Point(23, 162)
        BtnStartScBoard.Margin = New Padding(4, 3, 4, 3)
        BtnStartScBoard.Name = "BtnStartScBoard"
        BtnStartScBoard.Size = New Size(385, 40)
        BtnStartScBoard.TabIndex = 4
        BtnStartScBoard.Text = "Start Scoreboard"
        BtnStartScBoard.UseVisualStyleBackColor = False
        ' 
        ' BtnStartTimer
        ' 
        BtnStartTimer.BackColor = Color.Gold
        BtnStartTimer.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        BtnStartTimer.Location = New Point(23, 213)
        BtnStartTimer.Margin = New Padding(4, 3, 4, 3)
        BtnStartTimer.Name = "BtnStartTimer"
        BtnStartTimer.Size = New Size(385, 40)
        BtnStartTimer.TabIndex = 5
        BtnStartTimer.Text = "Start Timer"
        BtnStartTimer.UseVisualStyleBackColor = False
        ' 
        ' PanelBottom
        ' 
        PanelBottom.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PanelBottom.Controls.Add(BtnSettings)
        PanelBottom.Controls.Add(BtnLogActivity)
        PanelBottom.Controls.Add(BtnShortcut)
        PanelBottom.Controls.Add(BtnResetHantei)
        PanelBottom.Controls.Add(BtnHantei)
        PanelBottom.Controls.Add(BtnDraw)
        PanelBottom.Controls.Add(BtnResetMatch)
        PanelBottom.Controls.Add(BtnSaveMatch)
        PanelBottom.Dock = DockStyle.Bottom
        PanelBottom.Location = New Point(0, 821)
        PanelBottom.Margin = New Padding(4, 3, 4, 3)
        PanelBottom.Name = "PanelBottom"
        PanelBottom.Size = New Size(1795, 61)
        PanelBottom.TabIndex = 4
        ' 
        ' BtnSettings
        ' 
        BtnSettings.Location = New Point(14, 17)
        BtnSettings.Margin = New Padding(4, 3, 4, 3)
        BtnSettings.Name = "BtnSettings"
        BtnSettings.Size = New Size(93, 35)
        BtnSettings.TabIndex = 0
        BtnSettings.Text = "Settings"
        ' 
        ' BtnLogActivity
        ' 
        BtnLogActivity.Location = New Point(117, 17)
        BtnLogActivity.Margin = New Padding(4, 3, 4, 3)
        BtnLogActivity.Name = "BtnLogActivity"
        BtnLogActivity.Size = New Size(93, 35)
        BtnLogActivity.TabIndex = 1
        BtnLogActivity.Text = "Log Activity"
        ' 
        ' BtnShortcut
        ' 
        BtnShortcut.Location = New Point(222, 17)
        BtnShortcut.Margin = New Padding(4, 3, 4, 3)
        BtnShortcut.Name = "BtnShortcut"
        BtnShortcut.Size = New Size(93, 35)
        BtnShortcut.TabIndex = 2
        BtnShortcut.Text = "Shortcut"
        ' 
        ' BtnResetHantei
        ' 
        BtnResetHantei.Location = New Point(467, 17)
        BtnResetHantei.Margin = New Padding(4, 3, 4, 3)
        BtnResetHantei.Name = "BtnResetHantei"
        BtnResetHantei.Size = New Size(117, 35)
        BtnResetHantei.TabIndex = 3
        BtnResetHantei.Text = "Reset Hantei"
        ' 
        ' BtnHantei
        ' 
        BtnHantei.Location = New Point(595, 17)
        BtnHantei.Margin = New Padding(4, 3, 4, 3)
        BtnHantei.Name = "BtnHantei"
        BtnHantei.Size = New Size(93, 35)
        BtnHantei.TabIndex = 4
        BtnHantei.Text = "Hantei"
        ' 
        ' BtnDraw
        ' 
        BtnDraw.Location = New Point(700, 17)
        BtnDraw.Margin = New Padding(4, 3, 4, 3)
        BtnDraw.Name = "BtnDraw"
        BtnDraw.Size = New Size(140, 35)
        BtnDraw.TabIndex = 5
        BtnDraw.Text = "Hikiwake/Draw"
        ' 
        ' BtnResetMatch
        ' 
        BtnResetMatch.Location = New Point(1283, 17)
        BtnResetMatch.Margin = New Padding(4, 3, 4, 3)
        BtnResetMatch.Name = "BtnResetMatch"
        BtnResetMatch.Size = New Size(117, 35)
        BtnResetMatch.TabIndex = 6
        BtnResetMatch.Text = "Reset Match"
        ' 
        ' BtnSaveMatch
        ' 
        BtnSaveMatch.Location = New Point(1412, 17)
        BtnSaveMatch.Margin = New Padding(4, 3, 4, 3)
        BtnSaveMatch.Name = "BtnSaveMatch"
        BtnSaveMatch.Size = New Size(175, 35)
        BtnSaveMatch.TabIndex = 7
        BtnSaveMatch.Text = "Save Match Result"
        ' 
        ' Kumite
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1795, 882)
        Controls.Add(PanelBottom)
        Controls.Add(PanelRight)
        Controls.Add(PanelAO)
        Controls.Add(PanelAKA)
        Controls.Add(PanelTop)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Kumite"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kumite Main Control"
        PanelTop.ResumeLayout(False)
        PanelTop.PerformLayout()
        PanelAKA.ResumeLayout(False)
        PanelAKA.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBoxAKA, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvLogAKA, ComponentModel.ISupportInitialize).EndInit()
        PanelAO.ResumeLayout(False)
        PanelAO.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBoxAO, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvLogAO, ComponentModel.ISupportInitialize).EndInit()
        PanelRight.ResumeLayout(False)
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        TabControlMatch.ResumeLayout(False)
        TabPageDetail.ResumeLayout(False)
        TabPageDetail.PerformLayout()
        CType(NumWinPoint, ComponentModel.ISupportInitialize).EndInit()
        CType(NumTatami, ComponentModel.ISupportInitialize).EndInit()
        GrpWaitTimer.ResumeLayout(False)
        CType(NumWaitMin, ComponentModel.ISupportInitialize).EndInit()
        CType(NumWaitSec, ComponentModel.ISupportInitialize).EndInit()
        GrpMatchTimer.ResumeLayout(False)
        PanelBottom.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    ' Deklarasi variabel komponen
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents LabelNextMatch As System.Windows.Forms.Label
    Friend WithEvents TxtNextMatchAKA As System.Windows.Forms.TextBox
    Friend WithEvents LabelVS As System.Windows.Forms.Label
    Friend WithEvents TxtNextMatchAO As System.Windows.Forms.TextBox
    Friend WithEvents BtnLoadNextMatch As System.Windows.Forms.Button

    Friend WithEvents PanelAKA As System.Windows.Forms.Panel
    Friend WithEvents LabelTitleAKA As System.Windows.Forms.Label
    Friend WithEvents LabelWinnerAKA As System.Windows.Forms.Label
    Friend WithEvents PicBoxAKA As System.Windows.Forms.PictureBox
    Friend WithEvents LblNameAKA As System.Windows.Forms.Label
    Friend WithEvents TxtNameAKA As System.Windows.Forms.TextBox
    Friend WithEvents LblTeamAKA As System.Windows.Forms.Label
    Friend WithEvents TxtTeamAKA As System.Windows.Forms.TextBox
    Friend WithEvents LblTeamInfoAKA As System.Windows.Forms.Label
    Friend WithEvents TxtTeamInfoAKA As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdateInfoAKA As System.Windows.Forms.Button
    Friend WithEvents BtnKikenAKA As System.Windows.Forms.Button
    Friend WithEvents BtnShikkakuAKA As System.Windows.Forms.Button
    Friend WithEvents BtnKnockedOutAKA As System.Windows.Forms.Button
    Friend WithEvents BtnPAKA As System.Windows.Forms.Button
    Friend WithEvents Btn1CAKA As System.Windows.Forms.Button
    Friend WithEvents Btn2CAKA As System.Windows.Forms.Button
    Friend WithEvents Btn3CAKA As System.Windows.Forms.Button
    Friend WithEvents BtnHCAKA As System.Windows.Forms.Button
    Friend WithEvents BtnHAKA As System.Windows.Forms.Button
    Friend WithEvents GrpScoreSummaryAKA As System.Windows.Forms.GroupBox
    Friend WithEvents DgvLogAKA As System.Windows.Forms.DataGridView
    Friend WithEvents ColNoAKA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTimerAKA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTypeAKA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnShowWinnerAKA As System.Windows.Forms.Button
    Friend WithEvents BtnResetScoreAKA As System.Windows.Forms.Button
    Friend WithEvents BtnSenshuAKA As System.Windows.Forms.Button
    Friend WithEvents LabelScoreAKA As System.Windows.Forms.Label
    Friend WithEvents BtnIpponAKA As System.Windows.Forms.Button
    Friend WithEvents BtnWazaariAKA As System.Windows.Forms.Button
    Friend WithEvents BtnYukoAKA As System.Windows.Forms.Button

    Friend WithEvents PanelAO As System.Windows.Forms.Panel
    Friend WithEvents LabelTitleAO As System.Windows.Forms.Label
    Friend WithEvents PicBoxAO As System.Windows.Forms.PictureBox
    Friend WithEvents LblNameAO As System.Windows.Forms.Label
    Friend WithEvents TxtNameAO As System.Windows.Forms.TextBox
    Friend WithEvents LblTeamAO As System.Windows.Forms.Label
    Friend WithEvents TxtTeamAO As System.Windows.Forms.TextBox
    Friend WithEvents LblTeamInfoAO As System.Windows.Forms.Label
    Friend WithEvents TxtTeamInfoAO As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdateInfoAO As System.Windows.Forms.Button
    Friend WithEvents BtnKikenAO As System.Windows.Forms.Button
    Friend WithEvents BtnShikkakuAO As System.Windows.Forms.Button
    Friend WithEvents BtnKnockedOutAO As System.Windows.Forms.Button
    Friend WithEvents BtnPAO As System.Windows.Forms.Button
    Friend WithEvents Btn1CAO As System.Windows.Forms.Button
    Friend WithEvents Btn2CAO As System.Windows.Forms.Button
    Friend WithEvents Btn3CAO As System.Windows.Forms.Button
    Friend WithEvents BtnHCAO As System.Windows.Forms.Button
    Friend WithEvents BtnHAO As System.Windows.Forms.Button
    Friend WithEvents GrpScoreSummaryAO As System.Windows.Forms.GroupBox
    Friend WithEvents DgvLogAO As System.Windows.Forms.DataGridView
    Friend WithEvents ColNoAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTimerAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTypeAO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnShowWinnerAO As System.Windows.Forms.Button
    Friend WithEvents BtnResetScoreAO As System.Windows.Forms.Button
    Friend WithEvents BtnSenshuAO As System.Windows.Forms.Button
    Friend WithEvents LabelScoreAO As System.Windows.Forms.Label
    Friend WithEvents BtnIpponAO As System.Windows.Forms.Button
    Friend WithEvents BtnWazaariAO As System.Windows.Forms.Button
    Friend WithEvents BtnYukoAO As System.Windows.Forms.Button

    Friend WithEvents PanelRight As System.Windows.Forms.Panel
    Friend WithEvents TabControlMatch As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDetail As System.Windows.Forms.TabPage
    Friend WithEvents TxtMatchDesc As System.Windows.Forms.TextBox
    Friend WithEvents NumWinPoint As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblWinPoint As System.Windows.Forms.Label
    Friend WithEvents NumTatami As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblTatami As System.Windows.Forms.Label
    Friend WithEvents GrpWaitTimer As System.Windows.Forms.GroupBox
    Friend WithEvents NumWaitMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumWaitSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnStartWait As System.Windows.Forms.Button
    Friend WithEvents GrpMatchTimer As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPreset130 As System.Windows.Forms.Button
    Friend WithEvents BtnPreset200 As System.Windows.Forms.Button
    Friend WithEvents BtnPreset300 As System.Windows.Forms.Button
    Friend WithEvents LabelMainTimer As System.Windows.Forms.Label
    Friend WithEvents BtnStartScBoard As System.Windows.Forms.Button
    Friend WithEvents BtnStartTimer As System.Windows.Forms.Button

    Friend WithEvents PanelBottom As System.Windows.Forms.Panel
    Friend WithEvents BtnSettings As System.Windows.Forms.Button
    Friend WithEvents BtnLogActivity As System.Windows.Forms.Button
    Friend WithEvents BtnShortcut As System.Windows.Forms.Button
    Friend WithEvents BtnResetHantei As System.Windows.Forms.Button
    Friend WithEvents BtnHantei As System.Windows.Forms.Button
    Friend WithEvents BtnDraw As System.Windows.Forms.Button
    Friend WithEvents BtnResetMatch As System.Windows.Forms.Button
    Friend WithEvents BtnSaveMatch As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button

End Class