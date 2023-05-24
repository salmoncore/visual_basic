Public Class Form2

    Public decCostPizza As Decimal
    Public decCostDog As Decimal
    Public decCostCorndog As Decimal
    Public decCostNachos As Decimal
    Public decCostPopcorn As Decimal
    Public decCostCandy As Decimal
    Public decCostDrinks As Decimal
    Public decTax As Decimal
    Public decTaxModifier As Decimal

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtPassword.Text = "123321" Then

            decCostPizza = nudPizza.Text
            decCostDog = nudDog.Text
            decCostCorndog = nudCorndog.Text
            decCostNachos = nudNachos.Text
            decCostPopcorn = nudPopcorn.Text
            decCostCandy = nudCandy.Text
            decCostDrinks = nudDrinks.Text
            decTax = nudTax.Text
            decTaxModifier = nudTaxModifer.Text

            Form1.decCostPizza = decCostPizza
            Form1.decCostDog = decCostDog
            Form1.decCostCorndog = decCostCorndog
            Form1.decCostCorndog = decCostCorndog
            Form1.decCostPopcorn = decCostPopcorn
            Form1.decCostCandy = decCostCandy
            Form1.decCostDrinks = decCostDrinks
            Form1.decTax = decTax
            Form1.decTaxModifier = decTaxModifier

            txtPassword.Text = ""

            MsgBox("Changes verified.", vbOKOnly)


        Else

            txtPassword.Text = ""
            MsgBox("Incorrect password.", vbOKOnly)

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub nudDrinks_ValueChanged(sender As Object, e As EventArgs) Handles nudDrinks.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub nudCandy_ValueChanged(sender As Object, e As EventArgs) Handles nudCandy.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub nudPopcorn_ValueChanged(sender As Object, e As EventArgs) Handles nudPopcorn.ValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub nudNachos_ValueChanged(sender As Object, e As EventArgs) Handles nudNachos.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub nudCorndog_ValueChanged(sender As Object, e As EventArgs) Handles nudCorndog.ValueChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub nudDog_ValueChanged(sender As Object, e As EventArgs) Handles nudDog.ValueChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub nudPizza_ValueChanged(sender As Object, e As EventArgs) Handles nudPizza.ValueChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nudTax.ValueChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles boxVerify.Enter

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        decCostPizza = Form1.decCostPizza
        decCostDog = Form1.decCostDog
        decCostCorndog = Form1.decCostCorndog
        decCostNachos = Form1.decCostNachos
        decCostPopcorn = Form1.decCostPopcorn
        decCostCandy = Form1.decCostCandy
        decCostDrinks = Form1.decCostDrinks
        decTax = Form1.decTax
        decTaxModifier = Form1.decTaxModifier

        nudPizza.Text = decCostPizza
        nudDog.Text = decCostDog
        nudCorndog.Text = decCostCorndog
        nudNachos.Text = decCostCorndog
        nudPopcorn.Text = decCostPopcorn
        nudCandy.Text = decCostCandy
        nudDrinks.Text = decCostDrinks
        nudTax.Text = decTax
        nudTaxModifer.Text = decTaxModifier


    End Sub

    Private Sub nudTaxModifer_ValueChanged(sender As Object, e As EventArgs) Handles nudTaxModifer.ValueChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        decCostPizza = 15
        decCostDog = 3.5
        decCostCorndog = 4.25
        decCostNachos = 3.75
        decCostPopcorn = 5
        decCostCandy = 2.75
        decCostDrinks = 4.5
        decTax = 0.07
        decTaxModifier = 1.07

        nudPizza.Text = decCostPizza
        nudDog.Text = decCostDog
        nudCorndog.Text = decCostCorndog
        nudNachos.Text = decCostCorndog
        nudPopcorn.Text = decCostPopcorn
        nudCandy.Text = decCostCandy
        nudDrinks.Text = decCostDrinks
        nudTax.Text = decTax
        nudTaxModifer.Text = decTaxModifier

    End Sub
End Class