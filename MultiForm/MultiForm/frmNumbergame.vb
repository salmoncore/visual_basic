Public Class frmNumbergame

    Dim intNumber As Integer
    Dim intScore As Integer
    Dim intGamestate As Integer

    Private Sub frmNumbergame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
        End
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub txtScore_TextChanged(sender As Object, e As EventArgs) Handles txtScore.TextChanged

    End Sub

    Private Sub txtOutput_TextChanged(sender As Object, e As EventArgs) Handles txtOutput.TextChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        intGamestate = 0
        intScore = 0
        intNumber = 0
        txtScore.Text = "0"
        nudInput.Value = 1
        txtOutput.Text = "Enter a number between 1 and 100!"

    End Sub

    Private Sub nudInput_ValueChanged(sender As Object, e As EventArgs) Handles nudInput.ValueChanged

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If intGamestate = 0 Then
            intNumber = nudInput.Value
            nudInput.Value = 1
            txtOutput.Text = "Now, guess what number was put in! It's between 1 and 100."
            intGamestate = 1

        ElseIf intGamestate = 1 Then

            If intNumber > nudInput.Value Then
                txtOutput.Text = "Nope, that number is too low. Keep trying!"
            End If

            If intNumber < nudInput.Value Then
                txtOutput.Text = "Nope, that number is too high. Keep trying!"
            End If

            If nudInput.Value = intNumber Then
                txtOutput.Text = "Wow, you guessed it! Congratulations, have a point!"
                intGamestate = 0
                intScore = intScore + 1
                txtScore.Text = intScore
                txtOutput.Text = "Enter another number to start the game again!"
            End If

        End If
    End Sub
End Class