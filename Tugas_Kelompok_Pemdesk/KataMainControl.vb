Public Class KataMainControl
    Private PnlFlagSystem As New Panel()

    Private AkaFlags(6) As Button
    Private AoFlags(6) As Button

    Private TotalJudge As Integer = 5
    Private AkaScore As Integer = 0
    Private AoScore As Integer = 0
    Public Shared KataDetailFontName As String = "Microsoft Sans Serif"
    Public Shared KataDetailIsBold As Boolean = True
    Public Shared KataDetailColor As Color = Color.Yellow
    Public Sub New()
        InitializeComponent()

        SetupFlagSystem()
        SetupJudgeSelector()
        UpdateJudgeDisplay()
        ApplyKataMatchDetailStyle(KataDetailFontName, KataDetailIsBold, KataDetailColor)
    End Sub

    Private Sub UpdateJudgeDisplay()

        For i As Integer = 0 To 6

            If i < TotalJudge Then

                AkaFlags(i).Visible = True
                AoFlags(i).Visible = True

            Else

                AkaFlags(i).Visible = False
                AoFlags(i).Visible = False

            End If

        Next

    End Sub
    Private Sub AkaFlag_Click(sender As Object, e As EventArgs)

        Dim btn As Button = CType(sender, Button)

        Dim selectedValue As Integer =
        Integer.Parse(btn.Text.Replace("🚩", "").Trim())

        AkaScore = selectedValue
        AoScore = TotalJudge - AkaScore

        UpdateFlagDisplay()

    End Sub

    Private Sub AoFlag_Click(sender As Object, e As EventArgs)

        Dim btn As Button = CType(sender, Button)

        Dim selectedValue As Integer =
        Integer.Parse(btn.Text.Replace("🚩", "").Trim())

        AoScore = selectedValue
        AkaScore = TotalJudge - AoScore

        UpdateFlagDisplay()

    End Sub

    Private Sub UpdateFlagDisplay()

        TotalScoreAKA.Value = AkaScore
        TotalScoreAO.Value = AoScore

        ' RESET WARNA
        For i As Integer = 0 To 6

            AkaFlags(i).BackColor = Color.White
            AoFlags(i).BackColor = Color.White

        Next

        ' AKTIFKAN FLAG AKA
        For i As Integer = 0 To AkaScore - 1

            AkaFlags(i).BackColor = Color.Red
            AkaFlags(i).ForeColor = Color.White

        Next

        ' AKTIFKAN FLAG AO
        For i As Integer = 0 To AoScore - 1

            AoFlags(i).BackColor = Color.Blue
            AoFlags(i).ForeColor = Color.White

        Next

        CheckWinner()

    End Sub

    Private Sub CheckWinner()

        If AkaScore > AoScore Then

            LblAkaWinnerStatus.Text = "WINNER"
            LblAoWinnerStatus.Text = ""

        ElseIf AoScore > AkaScore Then

            LblAoWinnerStatus.Text = "WINNER"
            LblAkaWinnerStatus.Text = ""

        Else

            LblAoWinnerStatus.Text = ""
            LblAkaWinnerStatus.Text = ""

        End If

    End Sub

    Private Sub BtnResetScoreAka_Click(sender As Object, e As EventArgs) Handles BtnResetScoreAka.Click

        ResetFlagSystem()

    End Sub

    Private Sub BtnResetScoreAo_Click(sender As Object, e As EventArgs) Handles BtnResetScoreAo.Click

        ResetFlagSystem()

    End Sub

    Private Sub ResetFlagSystem()

        AkaScore = 0
        AoScore = 0

        TotalScoreAKA.Value = 0
        TotalScoreAO.Value = 0

        ' RESET SEMUA WARNA BUTTON
        For i As Integer = 0 To 6

            AkaFlags(i).BackColor = Color.White
            AkaFlags(i).ForeColor = Color.Red

            AoFlags(i).BackColor = Color.White
            AoFlags(i).ForeColor = Color.Blue

        Next

        ' HAPUS STATUS WINNER
        LblAkaWinnerStatus.Text = ""
        LblAoWinnerStatus.Text = ""

    End Sub
    Private Sub PnlCenterScore_Paint(sender As Object, e As PaintEventArgs) Handles PnlCenterScore.Paint

    End Sub

    Private Sub PnlAka_Paint(sender As Object, e As PaintEventArgs) Handles PnlAka.Paint

    End Sub

    Private Sub BtnKikenAka_Click(sender As Object, e As EventArgs) Handles BtnKikenAka.Click

    End Sub

    Private Sub LblAoDisqualification_Click(sender As Object, e As EventArgs) Handles LblAoDisqualification.Click

    End Sub

    Private Sub BtnKikenAo_Click(sender As Object, e As EventArgs) Handles BtnKikenAo.Click

    End Sub

    Private Sub BtnDetailScorePlus_Click(sender As Object, e As EventArgs) Handles BtnDetailScorePlus.Click

    End Sub

    Private Sub LblBigTotalAka_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblBigTotalAo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumAkaJ5_ValueChanged(sender As Object, e As EventArgs) Handles NumAkaJ5.ValueChanged

    End Sub

    Private Sub LblAkaJ2_Click(sender As Object, e As EventArgs) Handles LblAkaJ2.Click

    End Sub

    Private Sub LblAkaJ4_Click(sender As Object, e As EventArgs) Handles LblAkaJ4.Click

    End Sub

    Private Sub NumAoJ4_ValueChanged(sender As Object, e As EventArgs) Handles NumAoJ4.ValueChanged

    End Sub

    Private Sub TotalScoreAKA_ValueChanged(sender As Object, e As EventArgs) Handles TotalScoreAKA.ValueChanged

    End Sub

    Private Sub GrpScoreboardSelect_Enter(sender As Object, e As EventArgs) Handles GrpScoreboardSelect.Enter

    End Sub

    Private Sub PicAkaCircle_Click(sender As Object, e As EventArgs) Handles PicAkaCircle.Click

    End Sub

    Private Sub LblAkaWinnerStatus_Click(sender As Object, e As EventArgs) Handles LblAkaWinnerStatus.Click

    End Sub

    Private Sub SetupFlagSystem()

        PnlFlagSystem.Controls.Clear()

        PnlFlagSystem.Size = New Size(250, 280)
        PnlFlagSystem.Location = New Point(175, 40)
        PnlFlagSystem.BackColor = Color.Transparent
        PnlFlagSystem.Visible = False

        ' ======================
        ' FLAG AKA
        ' ======================
        For i As Integer = 0 To 6

            AkaFlags(i) = New Button()

            With AkaFlags(i)

                .Size = New Size(90, 35)
                .Location = New Point(10, 10 + (i * 45))

                .BackColor = Color.White
                .ForeColor = Color.Red

                .FlatStyle = FlatStyle.Flat

                .Font = New Font("Segoe UI", 11, FontStyle.Bold)

                .Text = "🚩 " & (7 - i).ToString()

            End With

            PnlFlagSystem.Controls.Add(AkaFlags(i))
            AddHandler AkaFlags(i).Click, AddressOf AkaFlag_Click

        Next

        ' ======================
        ' FLAG AO
        ' ======================
        For i As Integer = 0 To 6

            AoFlags(i) = New Button()

            With AoFlags(i)

                .Size = New Size(90, 35)
                .Location = New Point(130, 10 + (i * 45))

                .BackColor = Color.White
                .ForeColor = Color.Blue

                .FlatStyle = FlatStyle.Flat

                .Font = New Font("Segoe UI", 11, FontStyle.Bold)

                .Text = (7 - i).ToString() & " 🚩"

            End With

            PnlFlagSystem.Controls.Add(AoFlags(i))
            AddHandler AoFlags(i).Click, AddressOf AoFlag_Click

        Next

        PnlCenterScore.Controls.Add(PnlFlagSystem)

    End Sub

    Private Sub SetupJudgeSelector()
        ' RB 3 JUDGE
        With Rb3Judge

            .Text = "3 Judge"
            .AutoSize = True

        End With

        ' RB 5 JUDGE
        With Rb5Judge

            .Text = "5 Judge"
            .AutoSize = True
            .Checked = True

        End With

        ' RB 7 JUDGE
        With Rb7Judge

            .Text = "7 Judge"
            .AutoSize = True

        End With

        ' EVENT
        AddHandler Rb3Judge.CheckedChanged, AddressOf Rb3Judge_CheckedChanged
        AddHandler Rb5Judge.CheckedChanged, AddressOf Rb5Judge_CheckedChanged
        AddHandler Rb7Judge.CheckedChanged, AddressOf Rb7Judge_CheckedChanged

    End Sub

    Private Sub RbFlagSystem_CheckedChanged(sender As Object, e As EventArgs) Handles RbFlagSystem.CheckedChanged

        If RbFlagSystem.Checked Then

            PnlPointInputsAka.Visible = False
            PnlPointInputsAo.Visible = False

            PnlFlagSystem.Visible = True

        End If

    End Sub

    Private Sub RbScoreType_CheckedChanged(sender As Object, e As EventArgs) Handles RbScoreType.CheckedChanged

        If RbScoreType.Checked Then

            PnlPointInputsAka.Visible = True
            PnlPointInputsAo.Visible = True

            PnlFlagSystem.Visible = False

        End If

    End Sub

    Private Sub Rb3Judge_CheckedChanged(sender As Object, e As EventArgs)

        If Rb3Judge.Checked Then

            TotalJudge = 3

            ResetFlagSystem()
            UpdateJudgeDisplay()

        End If

    End Sub

    Private Sub Rb5Judge_CheckedChanged(sender As Object, e As EventArgs)

        If Rb5Judge.Checked Then

            TotalJudge = 5

            ResetFlagSystem()
            UpdateJudgeDisplay()

        End If

    End Sub

    Private Sub Rb7Judge_CheckedChanged(sender As Object, e As EventArgs)

        If Rb7Judge.Checked Then

            TotalJudge = 7

            ResetFlagSystem()
            UpdateJudgeDisplay()

        End If

    End Sub

    Public Sub ApplyKataMatchDetailStyle(fontName As String, isBold As Boolean, textColor As System.Drawing.Color)
        Try
            Dim style As FontStyle = If(isBold, FontStyle.Bold, FontStyle.Regular)

            If LblJudgeStatusTitle IsNot Nothing Then
                LblJudgeStatusTitle.Font = New Font(fontName, LblJudgeStatusTitle.Font.Size, style)
                LblJudgeStatusTitle.ForeColor = textColor
                LblJudgeStatusTitle.Refresh()
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class