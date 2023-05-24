Public Class frmChecksum

    Dim decV As Decimal
    Dim decX As Decimal
    Dim decY As Decimal
    Dim decZ As Decimal
    Dim decChecksum As Decimal

    Private Sub frmChecksum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtV.Text = ""
        txtX.Text = ""
        txtY.Text = ""
        txtZ.Text = ""
        txtChecksum.Text = ""

        decV = 0
        decX = 0
        decY = 0
        decZ = 0
        decChecksum = 0

        nudInput.Value = 0


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        decV = nudInput.Value
        txtV.Text = decV

        decX = decV / 256
        txtX.Text = decX

        decY = decV \ 256
        txtY.Text = decY

        decZ = decY * 256
        txtZ.Text = decZ

        decChecksum = decV - decZ
        txtChecksum.Text = decChecksum

    End Sub

    Private Sub txtV_TextChanged(sender As Object, e As EventArgs) Handles txtV.TextChanged

    End Sub

    Private Sub txtX_TextChanged(sender As Object, e As EventArgs) Handles txtX.TextChanged

    End Sub

    Private Sub txtY_TextChanged(sender As Object, e As EventArgs) Handles txtY.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub txtEquation_TextChanged(sender As Object, e As EventArgs) Handles txtEquation.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtChecksum_TextChanged(sender As Object, e As EventArgs) Handles txtChecksum.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub nudInput_ValueChanged(sender As Object, e As EventArgs) Handles nudInput.ValueChanged

    End Sub
End Class