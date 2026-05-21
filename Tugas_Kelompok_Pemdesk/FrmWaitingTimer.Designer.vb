<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWaitingTimer
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

        Me.lblBigTimer = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        '
        ' lblBigTimer
        '
        Me.lblBigTimer.BackColor = System.Drawing.Color.Crimson
        Me.lblBigTimer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBigTimer.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold)
        Me.lblBigTimer.ForeColor = System.Drawing.Color.White
        Me.lblBigTimer.Location = New System.Drawing.Point(0, 0)
        Me.lblBigTimer.Name = "lblBigTimer"
        Me.lblBigTimer.Size = New System.Drawing.Size(1000, 500)
        Me.lblBigTimer.TabIndex = 0
        Me.lblBigTimer.Text = "0:00.0"
        Me.lblBigTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        ' FrmWaitingTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.lblBigTimer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWaitingTimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmWaitingTimer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblBigTimer As Label

End Class