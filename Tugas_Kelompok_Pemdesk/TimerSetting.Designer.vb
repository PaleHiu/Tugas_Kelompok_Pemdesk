' =========================================================
' TIMERSETTING.DESIGNER.VB
' =========================================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimerSetting
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.lblPerformance = New System.Windows.Forms.Label()

        Me.numMinuteWaiting = New System.Windows.Forms.NumericUpDown()
        Me.numSecondWaiting = New System.Windows.Forms.NumericUpDown()

        Me.numMinutePerformance = New System.Windows.Forms.NumericUpDown()
        Me.numSecondPerformance = New System.Windows.Forms.NumericUpDown()

        Me.btnStartWaiting = New System.Windows.Forms.Button()
        Me.btnStopWaiting = New System.Windows.Forms.Button()

        Me.btnShowHide = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStartTimer = New System.Windows.Forms.Button()

        Me.lblTimer = New System.Windows.Forms.Label()

        Me.tmrWaiting = New System.Windows.Forms.Timer()

        CType(Me.numMinuteWaiting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSecondWaiting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinutePerformance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSecondPerformance, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.SuspendLayout()

        ' =====================================================
        ' FORM
        ' =====================================================
        Me.Text = "Timer Setting"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ClientSize = New Size(600, 420)
        Me.BackColor = Color.Gainsboro
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        ' =====================================================
        ' TITLE
        ' =====================================================
        Me.lblTitle.Text = "Timer Setting (minute:second)"
        Me.lblTitle.Location = New Point(20, 15)
        Me.lblTitle.Size = New Size(250, 20)
        Me.lblTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        ' =====================================================
        ' WAITING LABEL
        ' =====================================================
        Me.lblWaiting.Text = "Waiting"
        Me.lblWaiting.Location = New Point(30, 55)
        Me.lblWaiting.Size = New Size(80, 25)
        Me.lblWaiting.Font = New Font("Segoe UI", 10)

        ' =====================================================
        ' WAITING MINUTE
        ' =====================================================
        Me.numMinuteWaiting.Location = New Point(120, 55)
        Me.numMinuteWaiting.Size = New Size(60, 25)
        Me.numMinuteWaiting.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.numMinuteWaiting.Value = 0

        ' =====================================================
        ' WAITING SECOND
        ' =====================================================
        Me.numSecondWaiting.Location = New Point(210, 55)
        Me.numSecondWaiting.Size = New Size(60, 25)
        Me.numSecondWaiting.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.numSecondWaiting.Value = 35

        ' =====================================================
        ' PERFORMANCE LABEL
        ' =====================================================
        Me.lblPerformance.Text = "Performance"
        Me.lblPerformance.Location = New Point(30, 100)
        Me.lblPerformance.Size = New Size(100, 25)
        Me.lblPerformance.Font = New Font("Segoe UI", 10)

        ' =====================================================
        ' PERFORMANCE MINUTE
        ' =====================================================
        Me.numMinutePerformance.Location = New Point(120, 100)
        Me.numMinutePerformance.Size = New Size(60, 25)
        Me.numMinutePerformance.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.numMinutePerformance.Value = 5

        ' =====================================================
        ' PERFORMANCE SECOND
        ' =====================================================
        Me.numSecondPerformance.Location = New Point(210, 100)
        Me.numSecondPerformance.Size = New Size(60, 25)
        Me.numSecondPerformance.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.numSecondPerformance.Value = 0

        ' =====================================================
        ' START WAITING BUTTON
        ' =====================================================
        Me.btnStartWaiting.Text = "Start Waiting Timer"
        Me.btnStartWaiting.Location = New Point(30, 150)
        Me.btnStartWaiting.Size = New Size(240, 40)
        Me.btnStartWaiting.BackColor = Color.Bisque
        Me.btnStartWaiting.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.btnStartWaiting.FlatStyle = FlatStyle.Flat

        ' =====================================================
        ' TIMER LABEL
        ' =====================================================
        Me.lblTimer.Text = "0:00.0"
        Me.lblTimer.Location = New Point(300, 30)
        Me.lblTimer.Size = New Size(260, 220)
        Me.lblTimer.BackColor = Color.Crimson
        Me.lblTimer.ForeColor = Color.White
        Me.lblTimer.Font = New Font("Segoe UI", 42, FontStyle.Bold)
        Me.lblTimer.TextAlign = ContentAlignment.MiddleCenter

        ' =====================================================
        ' STOP BUTTON
        ' =====================================================
        Me.btnStopWaiting.Text = "Stop Waiting Timer"
        Me.btnStopWaiting.Location = New Point(30, 220)
        Me.btnStopWaiting.Size = New Size(240, 40)
        Me.btnStopWaiting.BackColor = Color.Bisque
        Me.btnStopWaiting.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnStopWaiting.FlatStyle = FlatStyle.Flat

        ' =====================================================
        ' SHOW HIDE
        ' =====================================================
        Me.btnShowHide.Text = "👁"
        Me.btnShowHide.Location = New Point(30, 280)
        Me.btnShowHide.Size = New Size(50, 35)
        Me.btnShowHide.BackColor = Color.White
        Me.btnShowHide.FlatStyle = FlatStyle.Flat

        ' =====================================================
        ' RESET
        ' =====================================================
        Me.btnReset.Text = "⟳"
        Me.btnReset.Location = New Point(90, 280)
        Me.btnReset.Size = New Size(50, 35)
        Me.btnReset.BackColor = Color.White
        Me.btnReset.FlatStyle = FlatStyle.Flat

        ' =====================================================
        ' START TIMER
        ' =====================================================
        Me.btnStartTimer.Text = "Start Timer ⏱"
        Me.btnStartTimer.Location = New Point(150, 280)
        Me.btnStartTimer.Size = New Size(120, 35)
        Me.btnStartTimer.BackColor = Color.White
        Me.btnStartTimer.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnStartTimer.FlatStyle = FlatStyle.Flat

        ' =====================================================
        ' TIMER
        ' =====================================================
        Me.tmrWaiting.Interval = 100

        ' =====================================================
        ' ADD CONTROLS
        ' =====================================================
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.lblPerformance)

        Me.Controls.Add(Me.numMinuteWaiting)
        Me.Controls.Add(Me.numSecondWaiting)

        Me.Controls.Add(Me.numMinutePerformance)
        Me.Controls.Add(Me.numSecondPerformance)

        Me.Controls.Add(Me.btnStartWaiting)
        Me.Controls.Add(Me.btnStopWaiting)

        Me.Controls.Add(Me.btnShowHide)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStartTimer)

        Me.Controls.Add(Me.lblTimer)

        CType(Me.numMinuteWaiting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSecondWaiting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinutePerformance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSecondPerformance, System.ComponentModel.ISupportInitialize).EndInit()

        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWaiting As Label
    Friend WithEvents lblPerformance As Label

    Friend WithEvents numMinuteWaiting As NumericUpDown
    Friend WithEvents numSecondWaiting As NumericUpDown

    Friend WithEvents numMinutePerformance As NumericUpDown
    Friend WithEvents numSecondPerformance As NumericUpDown

    Friend WithEvents btnStartWaiting As Button
    Friend WithEvents btnStopWaiting As Button

    Friend WithEvents btnShowHide As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStartTimer As Button

    Friend WithEvents lblTimer As Label

    Friend WithEvents tmrWaiting As Timer

End Class