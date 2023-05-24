Public Class Form1

    Dim strExit As String

    Public decCostPizza As Decimal
    Public decCostDog As Decimal
    Public decCostCorndog As Decimal
    Public decCostNachos As Decimal
    Public decCostPopcorn As Decimal
    Public decCostCandy As Decimal
    Public decCostDrinks As Decimal

    Dim decPizza As Decimal
    Dim decDog As Decimal
    Dim decCorndog As Decimal
    Dim decNachos As Decimal
    Dim decPopcorn As Decimal
    Dim decCandy As Decimal
    Dim decDrinks As Decimal

    Public decTax As Decimal
    Dim decTaxPizza As Decimal
    Dim decTaxDog As Decimal
    Dim decTaxCorndog As Decimal
    Dim decTaxNachos As Decimal
    Dim decTaxPopcorn As Decimal
    Dim decTaxCandy As Decimal
    Dim decTaxDrinks As Decimal
    Public decTaxModifier As Decimal

    Dim decTotal As Decimal

    Dim decCoupon As Decimal
    Dim decCouponModifier As Decimal



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        timTime.Start()
        lblTime.Text = TimeOfDay
        timDate.Start()
        lblDate.Text = DateString

        decCostPizza = 15
        decCostDog = 3.5
        decCostCorndog = 4.25
        decCostNachos = 3.75
        decCostPopcorn = 5
        decCostCandy = 2.75
        decCostDrinks = 4.5
        decTax = 0.07
        decTaxModifier = 1.07


    End Sub

    Private Sub txtDrinks_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCandy_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPopcorn_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNachos_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCornDog_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDog_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPizza_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        decPizza = nudPizza.Value
        decDog = nudDog.Value
        decCorndog = nudCorndog.Value
        decNachos = nudNachos.Value
        decPopcorn = nudPopcorn.Value
        decCandy = nudCandy.Value
        decDrinks = nudDrinks.Value

        decTaxPizza = (decTax * (decPizza * decCostPizza))
        decTaxDog = (decTax * (decDog * decCostDog))
        decTaxCorndog = (decTax * (decTaxCorndog * decCostCorndog))
        decTaxNachos = (decTax * (decNachos * decCostNachos))
        decTaxPopcorn = (decTax * (decPopcorn * decCostPopcorn))
        decTaxCandy = (decTax * (decCandy * decCostCandy))
        decTaxDrinks = (decTax * (decDrinks * decCostDrinks))

        If optNoTax.Checked Then
            decTotal = ((decPizza * decCostPizza) + (decDog * decCostDog) + (decCorndog * decCostCorndog) + (decNachos * decCostNachos) + (decPopcorn * decCostPopcorn) + (decCandy * decCostCandy) + (decDrinks * decCostDrinks) + (nudMeal1.Value * ((4 * decCostPizza) + (4 * decCostDrinks) + (2 * decCostCandy))) + (nudMeal2.Value * (decCostDog + decCostCorndog + decCostDrinks)) + (nudMeal3.Value * (decCostPizza + decCostDog + decCostCorndog + decCostNachos + decCostPopcorn + decCostDrinks + decCostCandy)))

            If decCoupon = True And chkTip.Checked = True Then
                decTotal = ((decTotal * decCouponModifier) * nudTip.Value)
                txtTotal.Text = FormatCurrency(decTotal)

            ElseIf decCoupon = True And chkTip.Checked = False Then
                decTotal = (decTotal * decCouponModifier)
                txtTotal.Text = FormatCurrency(decTotal)

            ElseIf decCoupon = False And chkTip.Checked = True Then
                decTotal = (decTotal * nudTip.Value)
                txtTotal.Text = FormatCurrency(decTotal)

            ElseIf decCoupon = False And chkTip.Checked = False Then
                txtTotal.Text = FormatCurrency(decTotal)

            End If

        End If


        If optTax.Checked Then
            decTotal = (decTaxModifier * ((decPizza * decCostPizza) + (decDog * decCostDog) + (decCorndog * decCostCorndog) + (decNachos * decCostNachos) + (decPopcorn * decCostPopcorn) + (decCandy * decCostCandy) + (decDrinks * decCostDrinks) + (nudMeal1.Value * ((4 * decCostPizza) + (4 * decCostDrinks) + (2 * decCostCandy))) + (nudMeal2.Value * (decCostDog + decCostCorndog + decCostDrinks)) + (nudMeal3.Value * (decCostPizza + decCostDog + decCostCorndog + decCostNachos + decCostPopcorn + decCostDrinks + decCostCandy))))

            If decCoupon = True And chkTip.Checked = True Then
                decTotal = ((decTotal * decCouponModifier) * nudTip.Value)
                txtTotal.Text = FormatCurrency(decTotal)

            ElseIf decCoupon = True And chkTip.Checked = False Then
                decTotal = (decTotal * decCouponModifier)
                txtTotal.Text = FormatCurrency(decTotal)

            ElseIf decCoupon = False And chkTip.Checked = True Then
                decTotal = (decTotal * nudTip.Value)
                txtTotal.Text = FormatCurrency(decTotal)

            ElseIf decCoupon = False And chkTip.Checked = False Then
                txtTotal.Text = FormatCurrency(decTotal)

            End If

        End If

    End Sub

    Private Sub txtCostCandy_TextChanged(sender As Object, e As EventArgs) Handles txtCostCandy.TextChanged

    End Sub

    Private Sub txtCostPopcorn_TextChanged(sender As Object, e As EventArgs) Handles txtCostPopcorn.TextChanged

    End Sub

    Private Sub txtCostNachos_TextChanged(sender As Object, e As EventArgs) Handles txtCostNachos.TextChanged

    End Sub

    Private Sub txtCostCorndog_TextChanged(sender As Object, e As EventArgs) Handles txtCostCorndog.TextChanged

    End Sub

    Private Sub txtCostDog_TextChanged(sender As Object, e As EventArgs) Handles txtCostDog.TextChanged

    End Sub

    Private Sub txtCostPizza_TextChanged(sender As Object, e As EventArgs) Handles txtCostPizza.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        strExit = MsgBox("Are you sure you want to exit?", vbYesNo)
        If strExit = vbYes Then
            Application.Exit()
            End
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        nudPizza.Value = 0
        nudDog.Value = 0
        nudCorndog.Value = 0
        nudNachos.Value = 0
        nudPopcorn.Value = 0
        nudCandy.Value = 0
        nudDrinks.Value = 0
        txtCostPizza.Text = FormatCurrency(0)
        txtCostDog.Text = FormatCurrency(0)
        txtCostCorndog.Text = FormatCurrency(0)
        txtCostNachos.Text = FormatCurrency(0)
        txtCostPopcorn.Text = FormatCurrency(0)
        txtCostCandy.Text = FormatCurrency(0)
        txtCostDrinks.Text = FormatCurrency(0)
        txtTotal.Text = FormatCurrency(0)
        decCouponModifier = 0
        decCoupon = False
        txtCoupon.Text = ""
        chkTip.Checked = False
        nudTip.Value = 1.5
        nudMeal1.Value = 0
        nudMeal2.Value = 0
        nudMeal3.Value = 0

    End Sub

    Private Sub optTax_CheckedChanged(sender As Object, e As EventArgs) Handles optTax.CheckedChanged

        If optNoTax.Checked Then
            decPizza = nudPizza.Value
            decPizza = (decPizza * decCostPizza)
            txtCostPizza.Text = FormatCurrency(decPizza)
        End If

        If optTax.Checked Then
            decPizza = nudPizza.Value
            decPizza = ((decPizza * decCostPizza) * decTaxModifier)
            txtCostPizza.Text = FormatCurrency(decPizza)
        End If

        If optNoTax.Checked Then
            decDog = nudDog.Value
            decDog = (decDog * decCostDog)
            txtCostDog.Text = FormatCurrency(decDog)
        End If

        If optTax.Checked Then
            decDog = nudDog.Value
            decDog = ((decDog * decCostDog) * decTaxModifier)
            txtCostDog.Text = FormatCurrency(decDog)
        End If

        If optNoTax.Checked Then
            decCorndog = nudCorndog.Value
            decCorndog = (decCorndog * decCostCorndog)
            txtCostCorndog.Text = FormatCurrency(decCorndog)
        End If

        If optTax.Checked Then
            decCorndog = nudCorndog.Value
            decCorndog = ((decCorndog * decCostCorndog) * decTaxModifier)
            txtCostCorndog.Text = FormatCurrency(decCorndog)
        End If

        If optNoTax.Checked Then
            decNachos = nudNachos.Value
            decNachos = (decNachos * decCostNachos)
            txtCostNachos.Text = FormatCurrency(decNachos)
        End If

        If optTax.Checked Then
            decNachos = nudNachos.Value
            decNachos = ((decNachos * decCostNachos) * decTaxModifier)
            txtCostNachos.Text = FormatCurrency(decNachos)
        End If

        If optNoTax.Checked Then
            decPopcorn = nudPopcorn.Value
            decPopcorn = (decPopcorn * decCostPopcorn)
            txtCostPopcorn.Text = FormatCurrency(decPopcorn)
        End If

        If optTax.Checked Then
            decPopcorn = nudPopcorn.Value
            decPopcorn = ((decPopcorn * decCostPopcorn) * decTaxModifier)
            txtCostPopcorn.Text = FormatCurrency(decPopcorn)
        End If

        If optNoTax.Checked Then
            decCandy = nudCandy.Value
            decCandy = (decCandy * decCostCandy)
            txtCostCandy.Text = FormatCurrency(decCandy)
        End If

        If optTax.Checked Then
            decCandy = nudCandy.Value
            decCandy = ((decCandy * decCostCandy) * decTaxModifier)
            txtCostCandy.Text = FormatCurrency(decCandy)
        End If

        If optNoTax.Checked Then
            decDrinks = nudDrinks.Value
            decDrinks = (decDrinks * decCostDrinks)
            txtCostDrinks.Text = FormatCurrency(decDrinks)
        End If

        If optTax.Checked Then
            decDrinks = nudDrinks.Value
            decDrinks = ((decDrinks * decCostDrinks) * decTaxModifier)
            txtCostDrinks.Text = FormatCurrency(decDrinks)
        End If


    End Sub

    Private Sub optNoTax_CheckedChanged(sender As Object, e As EventArgs) Handles optNoTax.CheckedChanged

        If optNoTax.Checked Then
            decPizza = nudPizza.Value
            decPizza = (decPizza * decCostPizza)
            txtCostPizza.Text = FormatCurrency(decPizza)
        End If

        If optTax.Checked Then
            decPizza = nudPizza.Value
            decPizza = ((decPizza * decCostPizza) * decTaxModifier)
            txtCostPizza.Text = FormatCurrency(decPizza)
        End If

        If optNoTax.Checked Then
            decDog = nudDog.Value
            decDog = (decDog * decCostDog)
            txtCostDog.Text = FormatCurrency(decDog)
        End If

        If optTax.Checked Then
            decDog = nudDog.Value
            decDog = ((decDog * decCostDog) * decTaxModifier)
            txtCostDog.Text = FormatCurrency(decDog)
        End If

        If optNoTax.Checked Then
            decCorndog = nudCorndog.Value
            decCorndog = (decCorndog * decCostCorndog)
            txtCostCorndog.Text = FormatCurrency(decCorndog)
        End If

        If optTax.Checked Then
            decCorndog = nudCorndog.Value
            decCorndog = ((decCorndog * decCostCorndog) * decTaxModifier)
            txtCostCorndog.Text = FormatCurrency(decCorndog)
        End If

        If optNoTax.Checked Then
            decNachos = nudNachos.Value
            decNachos = (decNachos * decCostNachos)
            txtCostNachos.Text = FormatCurrency(decNachos)
        End If

        If optTax.Checked Then
            decNachos = nudNachos.Value
            decNachos = ((decNachos * decCostNachos) * decTaxModifier)
            txtCostNachos.Text = FormatCurrency(decNachos)
        End If

        If optNoTax.Checked Then
            decPopcorn = nudPopcorn.Value
            decPopcorn = (decPopcorn * decCostPopcorn)
            txtCostPopcorn.Text = FormatCurrency(decPopcorn)
        End If

        If optTax.Checked Then
            decPopcorn = nudPopcorn.Value
            decPopcorn = ((decPopcorn * decCostPopcorn) * decTaxModifier)
            txtCostPopcorn.Text = FormatCurrency(decPopcorn)
        End If

        If optNoTax.Checked Then
            decCandy = nudCandy.Value
            decCandy = (decCandy * decCostCandy)
            txtCostCandy.Text = FormatCurrency(decCandy)
        End If

        If optTax.Checked Then
            decCandy = nudCandy.Value
            decCandy = ((decCandy * decCostCandy) * decTaxModifier)
            txtCostCandy.Text = FormatCurrency(decCandy)
        End If

        If optNoTax.Checked Then
            decDrinks = nudDrinks.Value
            decDrinks = (decDrinks * decCostDrinks)
            txtCostDrinks.Text = FormatCurrency(decDrinks)
        End If

        If optTax.Checked Then
            decDrinks = nudDrinks.Value
            decDrinks = ((decDrinks * decCostDrinks) * decTaxModifier)
            txtCostDrinks.Text = FormatCurrency(decDrinks)
        End If


    End Sub

    Private Sub txtCostDrinks_TextChanged(sender As Object, e As EventArgs) Handles txtCostDrinks.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub nudPizza_ValueChanged(sender As Object, e As EventArgs) Handles nudPizza.ValueChanged
        If optNoTax.Checked Then
            decPizza = nudPizza.Value
            decPizza = (decPizza * decCostPizza)
            txtCostPizza.Text = FormatCurrency(decPizza)
        End If

        If optTax.Checked Then
            decPizza = nudPizza.Value
            decPizza = ((decPizza * decCostPizza) * decTaxModifier)
            txtCostPizza.Text = FormatCurrency(decPizza)
        End If


    End Sub

    Private Sub nudDog_ValueChanged(sender As Object, e As EventArgs) Handles nudDog.ValueChanged
        If optNoTax.Checked Then
            decDog = nudDog.Value
            decDog = (decDog * decCostDog)
            txtCostDog.Text = FormatCurrency(decDog)
        End If

        If optTax.Checked Then
            decDog = nudDog.Value
            decDog = ((decDog * decCostDog) * decTaxModifier)
            txtCostDog.Text = FormatCurrency(decDog)
        End If


    End Sub

    Private Sub nudCorndog_ValueChanged(sender As Object, e As EventArgs) Handles nudCorndog.ValueChanged
        If optNoTax.Checked Then
            decCorndog = nudCorndog.Value
            decCorndog = (decCorndog * decCostCorndog)
            txtCostCorndog.Text = FormatCurrency(decCorndog)
        End If

        If optTax.Checked Then
            decCorndog = nudCorndog.Value
            decCorndog = ((decCorndog * decCostCorndog) * decTaxModifier)
            txtCostCorndog.Text = FormatCurrency(decCorndog)
        End If

    End Sub

    Private Sub nudNachos_ValueChanged(sender As Object, e As EventArgs) Handles nudNachos.ValueChanged
        If optNoTax.Checked Then
            decNachos = nudNachos.Value
            decNachos = (decNachos * decCostNachos)
            txtCostNachos.Text = FormatCurrency(decNachos)
        End If

        If optTax.Checked Then
            decNachos = nudNachos.Value
            decNachos = ((decNachos * decCostNachos) * decTaxModifier)
            txtCostNachos.Text = FormatCurrency(decNachos)
        End If

    End Sub

    Private Sub nudPopcorn_ValueChanged(sender As Object, e As EventArgs) Handles nudPopcorn.ValueChanged
        If optNoTax.Checked Then
            decPopcorn = nudPopcorn.Value
            decPopcorn = (decPopcorn * decCostPopcorn)
            txtCostPopcorn.Text = FormatCurrency(decPopcorn)
        End If

        If optTax.Checked Then
            decPopcorn = nudPopcorn.Value
            decPopcorn = ((decPopcorn * decCostPopcorn) * decTaxModifier)
            txtCostPopcorn.Text = FormatCurrency(decPopcorn)
        End If

    End Sub

    Private Sub nudCandy_ValueChanged(sender As Object, e As EventArgs) Handles nudCandy.ValueChanged
        If optNoTax.Checked Then
            decCandy = nudCandy.Value
            decCandy = (decCandy * decCostCandy)
            txtCostCandy.Text = FormatCurrency(decCandy)
        End If

        If optTax.Checked Then
            decCandy = nudCandy.Value
            decCandy = ((decCandy * decCostCandy) * decTaxModifier)
            txtCostCandy.Text = FormatCurrency(decCandy)
        End If

    End Sub

    Private Sub nudDrinks_ValueChanged(sender As Object, e As EventArgs) Handles nudDrinks.ValueChanged
        If optNoTax.Checked Then
            decDrinks = nudDrinks.Value
            decDrinks = (decDrinks * decCostDrinks)
            txtCostDrinks.Text = FormatCurrency(decDrinks)
        End If

        If optTax.Checked Then
            decDrinks = nudDrinks.Value
            decDrinks = ((decDrinks * decCostDrinks) * decTaxModifier)
            txtCostDrinks.Text = FormatCurrency(decDrinks)
        End If

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblPizza.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblDog.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblCorndog.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblNachos.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblPopcorn.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblCandy.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblDrinks.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub boxTotal_Enter(sender As Object, e As EventArgs) Handles boxTotal.Enter

    End Sub

    Private Sub boxMenu_Enter(sender As Object, e As EventArgs) Handles boxMenu.Enter

    End Sub

    Private Sub boxPresets_Enter(sender As Object, e As EventArgs) Handles boxMeal1.Enter

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timTime.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles timDate.Tick
        lblDate.Text = DateString
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Form2.Show()
    End Sub

    Private Sub txtCoupon_TextChanged(sender As Object, e As EventArgs) Handles txtCoupon.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCouponVerify_Click(sender As Object, e As EventArgs) Handles btnCouponVerify.Click

        If txtCoupon.Text = "Silver25" Then
            decCoupon = True
            decCouponModifier = 0.75
            txtCoupon.Text = "25% Off!"


        ElseIf txtCoupon.Text = "Silver50" Then
            decCoupon = True
            decCouponModifier = 0.5
            txtCoupon.Text = "50% Off!"


        ElseIf txtCoupon.Text = "Silver75" Then
            decCoupon = True
            decCouponModifier = 0.25
            txtCoupon.Text = "75% Off!"


        ElseIf txtCoupon.Text = "Silver100" Then
            decCoupon = True
            decCouponModifier = 0
            txtCoupon.Text = "100% Off!"

        Else
            MsgBox("The code you entered was invalid.", vbOKOnly)

        End If

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTip.CheckedChanged

    End Sub

    Private Sub nudTip_ValueChanged(sender As Object, e As EventArgs) Handles nudTip.ValueChanged

    End Sub

    Private Sub lblPercent_Click(sender As Object, e As EventArgs) Handles lblPercent.Click

    End Sub

    Private Sub txtCouponStatus_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMeal3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMeal1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMeal2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub boxMeal2_Enter(sender As Object, e As EventArgs) Handles boxMeal2.Enter

    End Sub

    Private Sub boxMeal3_Enter(sender As Object, e As EventArgs) Handles boxMeal3.Enter

    End Sub

    Private Sub timScroll1_Tick(sender As Object, e As EventArgs) Handles timScroll1.Tick
        lblScroll1.Left -= 2
        If lblScroll1.Left <= -330 Then
            lblScroll1.Left = 140
        End If
    End Sub

    Private Sub timScroll2_Tick(sender As Object, e As EventArgs) Handles timScroll2.Tick
        lblScroll2.Left -= 2
        If lblScroll2.Left <= -320 Then
            lblScroll2.Left = 140
        End If
    End Sub

    Private Sub lblScroll3_Click(sender As Object, e As EventArgs) Handles lblScroll3.Click

    End Sub

    Private Sub timScroll3_Tick(sender As Object, e As EventArgs) Handles timScroll3.Tick
        lblScroll3.Left -= 2
        If lblScroll3.Left <= -310 Then
            lblScroll3.Left = 140
        End If
    End Sub

    Private Sub nudMeal2_ValueChanged(sender As Object, e As EventArgs) Handles nudMeal2.ValueChanged


    End Sub

    Private Sub nudMeal1_ValueChanged(sender As Object, e As EventArgs) Handles nudMeal1.ValueChanged


    End Sub

    Private Sub nudMeal3_ValueChanged(sender As Object, e As EventArgs) Handles nudMeal3.ValueChanged


    End Sub
End Class
