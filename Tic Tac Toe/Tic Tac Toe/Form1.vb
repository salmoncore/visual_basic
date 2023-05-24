Public Class Form1

    Dim intPlayerTurn As Integer
    Dim intTurns As Integer

    Private Sub lblBottomCenter_Click(sender As Object, e As EventArgs) Handles lblBottomCenter.Click

        If intPlayerTurn = 1 Then
            lblBottomCenter.Text = "X"
            intPlayerTurn = 2
        ElseIf intPlayerTurn = 2 Then
            lblBottomCenter.Text = "O"
            intPlayerTurn = 1
        End If

        lblBottomCenter.Enabled = False

        CheckForWin()

        intTurns = intTurns + 1

        CheckForTie()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        intPlayerTurn = 1

    End Sub

    Private Sub lblTopCenter_Click(sender As Object, e As EventArgs) Handles lblTopCenter.Click

        If intPlayerTurn = 1 Then
            lblTopCenter.Text = "X"
            intPlayerTurn = 2
        ElseIf intPlayerTurn = 2 Then
            lblTopCenter.Text = "O"
            intPlayerTurn = 1
        End If

        lblTopCenter.Enabled = False

        CheckForWin()

        intTurns = intTurns + 1

        CheckForTie()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblTopLeft_Click(sender As Object, e As EventArgs) Handles lblTopLeft.Click

        If intPlayerTurn = 1 Then
            lblTopLeft.Text = "X"
            intPlayerTurn = 2
        ElseIf intPlayerTurn = 2 Then
            lblTopLeft.Text = "O"
            intPlayerTurn = 1
        End If

        lblTopLeft.Enabled = False

        CheckForWin()

        intTurns = intTurns + 1

        CheckForTie()

    End Sub

    Private Sub lblTopRight_Click(sender As Object, e As EventArgs) Handles lblTopRight.Click

        If intPlayerTurn = 1 Then
            lblTopRight.Text = "X"
            intPlayerTurn = 2
        ElseIf intPlayerTurn = 2 Then
            lblTopRight.Text = "O"
            intPlayerTurn = 1
        End If

        lblTopRight.Enabled = False

        CheckForWin()

        intTurns = intTurns + 1

        CheckForTie()

    End Sub

    Private Sub lblCenterLeft_Click(sender As Object, e As EventArgs) Handles lblCenterLeft.Click

        If intPlayerTurn = 1 Then
            lblCenterLeft.Text = "X"
            intPlayerTurn = 2
        ElseIf intPlayerTurn = 2 Then
            lblCenterLeft.Text = "O"
            intPlayerTurn = 1
        End If

        lblCenterLeft.Enabled = False

        CheckForWin()

        intTurns = intTurns + 1

        CheckForTie()

    End Sub

    Private Sub lblCenterCenter_Click(sender As Object, e As EventArgs) Handles lblCenterCenter.Click

        If intPlayerTurn = 1 Then
            lblCenterCenter.Text = "X"
            intPlayerTurn = 2
        ElseIf intPlayerTurn = 2 Then
            lblCenterCenter.Text = "O"
            intPlayerTurn = 1
        End If

        lblCenterCenter.Enabled = False

        CheckForWin()

        intTurns = intTurns + 1

        CheckForTie()

    End Sub

    Private Sub lblCenterRight_Click(sender As Object, e As EventArgs) Handles lblCenterRight.Click

        If intPlayerTurn = 1 Then
            lblCenterRight.Text = "X"
            intPlayerTurn = 2
        ElseIf intPlayerTurn = 2 Then
            lblCenterRight.Text = "O"
            intPlayerTurn = 1
        End If

        lblCenterRight.Enabled = False

        CheckForWin()

        intTurns = intTurns + 1

        CheckForTie()

    End Sub

    Private Sub lblBottomLeft_Click(sender As Object, e As EventArgs) Handles lblBottomLeft.Click

        If intPlayerTurn = 1 Then
            lblBottomLeft.Text = "X"
            intPlayerTurn = 2
        ElseIf intPlayerTurn = 2 Then
            lblBottomLeft.Text = "O"
            intPlayerTurn = 1
        End If

        lblBottomLeft.Enabled = False

        CheckForWin()

        intTurns = intTurns + 1

        CheckForTie()

    End Sub

    Private Sub lblBottomRight_Click(sender As Object, e As EventArgs) Handles lblBottomRight.Click

        If intPlayerTurn = 1 Then
            lblBottomRight.Text = "X"
            intPlayerTurn = 2
        ElseIf intPlayerTurn = 2 Then
            lblBottomRight.Text = "O"
            intPlayerTurn = 1
        End If

        lblBottomRight.Enabled = False

        CheckForWin()

        intTurns = intTurns + 1

        CheckForTie()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Reset()

    End Sub

    Public Sub Reset()

        lblTopLeft.Text = ""
        lblTopCenter.Text = ""
        lblTopRight.Text = ""
        lblCenterLeft.Text = ""
        lblCenterCenter.Text = ""
        lblCenterRight.Text = ""
        lblBottomLeft.Text = ""
        lblBottomCenter.Text = ""
        lblBottomRight.Text = ""

        lblTopLeft.Enabled = True
        lblTopCenter.Enabled = True
        lblTopRight.Enabled = True
        lblCenterLeft.Enabled = True
        lblCenterCenter.Enabled = True
        lblCenterRight.Enabled = True
        lblBottomLeft.Enabled = True
        lblBottomCenter.Enabled = True
        lblBottomRight.Enabled = True


        intPlayerTurn = 1
        intTurns = 0

    End Sub

    Public Sub CheckForWin()

        If lblTopLeft.Text = "X" And lblTopCenter.Text = "X" And lblTopRight.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        ElseIf lblTopLeft.Text = "X" And lblCenterCenter.Text = "X" And lblBottomRight.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        ElseIf lblTopLeft.Text = "X" And lblCenterLeft.Text = "X" And lblBottomLeft.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        ElseIf lblTopCenter.Text = "X" And lblCenterCenter.Text = "X" And lblBottomCenter.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        ElseIf lblTopRight.Text = "X" And lblCenterCenter.Text = "X" And lblBottomLeft.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        ElseIf lblCenterLeft.Text = "X" And lblCenterCenter.Text = "X" And lblCenterRight.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        ElseIf lblTopRight.Text = "X" And lblCenterRight.Text = "X" And lblBottomRight.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        ElseIf lblTopLeft.Text = "X" And lblCenterCenter.Text = "X" And lblBottomRight.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        ElseIf lblCenterLeft.Text = "X" And lblCenterCenter.Text = "X" And lblCenterRight.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        ElseIf lblBottomLeft.Text = "X" And lblBottomCenter.Text = "X" And lblBottomRight.Text = "X" Then
            MsgBox("Player 1 Wins!")
            Reset()
        End If

        If lblTopLeft.Text = "O" And lblTopCenter.Text = "O" And lblTopRight.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        ElseIf lblTopLeft.Text = "O" And lblCenterCenter.Text = "O" And lblBottomRight.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        ElseIf lblTopLeft.Text = "O" And lblCenterLeft.Text = "O" And lblBottomLeft.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        ElseIf lblTopCenter.Text = "O" And lblCenterCenter.Text = "O" And lblBottomCenter.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        ElseIf lblTopRight.Text = "O" And lblCenterCenter.Text = "O" And lblBottomLeft.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        ElseIf lblCenterLeft.Text = "O" And lblCenterCenter.Text = "O" And lblCenterRight.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        ElseIf lblTopRight.Text = "O" And lblCenterRight.Text = "O" And lblBottomRight.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        ElseIf lblTopLeft.Text = "O" And lblCenterCenter.Text = "O" And lblBottomRight.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        ElseIf lblCenterLeft.Text = "O" And lblCenterCenter.Text = "O" And lblCenterRight.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        ElseIf lblBottomLeft.Text = "O" And lblBottomCenter.Text = "O" And lblBottomRight.Text = "O" Then
            MsgBox("Player 2 Wins!")
            Reset()
        End If

    End Sub

    Public Sub CheckForTie()

        If intTurns = 9 Then
            MsgBox("You have tied!")
            Reset()
        End If

    End Sub

End Class
