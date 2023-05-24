Public Class frmScroll
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblShrug.Click

    End Sub

    Private Sub frmScroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub timScroll_Tick(sender As Object, e As EventArgs) Handles timScroll.Tick

        lblShrug.Left -= 10
        If lblShrug.Left <= -2000 Then
            lblShrug.Left = 2500
        End If

    End Sub
End Class