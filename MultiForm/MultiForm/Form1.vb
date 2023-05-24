Public Class Form1
    Private Sub btnChecksum_Click(sender As Object, e As EventArgs) Handles btnChecksum.Click
        frmChecksum.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShrug_Click(sender As Object, e As EventArgs) Handles btnShrug.Click
        frmScroll.Show()
        Me.Hide()
    End Sub

    Private Sub btnNumbergame_Click(sender As Object, e As EventArgs) Handles btnNumbergame.Click
        frmNumbergame.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
        End
    End Sub
End Class
