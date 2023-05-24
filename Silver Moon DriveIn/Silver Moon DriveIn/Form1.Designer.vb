<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.optTax = New System.Windows.Forms.RadioButton()
        Me.optNoTax = New System.Windows.Forms.RadioButton()
        Me.lblPizza = New System.Windows.Forms.Label()
        Me.lblDog = New System.Windows.Forms.Label()
        Me.lblCorndog = New System.Windows.Forms.Label()
        Me.lblNachos = New System.Windows.Forms.Label()
        Me.lblPopcorn = New System.Windows.Forms.Label()
        Me.lblCandy = New System.Windows.Forms.Label()
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.txtCostDrinks = New System.Windows.Forms.TextBox()
        Me.txtCostCandy = New System.Windows.Forms.TextBox()
        Me.txtCostPopcorn = New System.Windows.Forms.TextBox()
        Me.txtCostNachos = New System.Windows.Forms.TextBox()
        Me.txtCostCorndog = New System.Windows.Forms.TextBox()
        Me.txtCostDog = New System.Windows.Forms.TextBox()
        Me.txtCostPizza = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudPizza = New System.Windows.Forms.NumericUpDown()
        Me.nudDog = New System.Windows.Forms.NumericUpDown()
        Me.nudCorndog = New System.Windows.Forms.NumericUpDown()
        Me.nudNachos = New System.Windows.Forms.NumericUpDown()
        Me.nudPopcorn = New System.Windows.Forms.NumericUpDown()
        Me.nudCandy = New System.Windows.Forms.NumericUpDown()
        Me.nudDrinks = New System.Windows.Forms.NumericUpDown()
        Me.boxTotal = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.nudTip = New System.Windows.Forms.NumericUpDown()
        Me.chkTip = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCouponVerify = New System.Windows.Forms.Button()
        Me.txtCoupon = New System.Windows.Forms.TextBox()
        Me.boxMenu = New System.Windows.Forms.GroupBox()
        Me.boxMeal3 = New System.Windows.Forms.GroupBox()
        Me.nudMeal3 = New System.Windows.Forms.NumericUpDown()
        Me.lblScroll3 = New System.Windows.Forms.Label()
        Me.boxMeal2 = New System.Windows.Forms.GroupBox()
        Me.nudMeal2 = New System.Windows.Forms.NumericUpDown()
        Me.lblScroll2 = New System.Windows.Forms.Label()
        Me.boxMeal1 = New System.Windows.Forms.GroupBox()
        Me.nudMeal1 = New System.Windows.Forms.NumericUpDown()
        Me.lblScroll1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.timTime = New System.Windows.Forms.Timer(Me.components)
        Me.timDate = New System.Windows.Forms.Timer(Me.components)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.timScroll1 = New System.Windows.Forms.Timer(Me.components)
        Me.timScroll2 = New System.Windows.Forms.Timer(Me.components)
        Me.timScroll3 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPls1 = New System.Windows.Forms.Label()
        Me.lblPls2 = New System.Windows.Forms.Label()
        Me.lblPls3 = New System.Windows.Forms.Label()
        CType(Me.nudPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCorndog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNachos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPopcorn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCandy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDrinks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxTotal.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudTip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.boxMenu.SuspendLayout()
        Me.boxMeal3.SuspendLayout()
        CType(Me.nudMeal3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxMeal2.SuspendLayout()
        CType(Me.nudMeal2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxMeal1.SuspendLayout()
        CType(Me.nudMeal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(546, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(546, 44)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(86, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset Fo&rm"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(6, 219)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(164, 20)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.Text = "$0.00"
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(6, 190)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(164, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Cal&culate Total"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'optTax
        '
        Me.optTax.AutoSize = True
        Me.optTax.Checked = True
        Me.optTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTax.Location = New System.Drawing.Point(87, 167)
        Me.optTax.Name = "optTax"
        Me.optTax.Size = New System.Drawing.Size(77, 17)
        Me.optTax.TabIndex = 5
        Me.optTax.TabStop = True
        Me.optTax.Text = "Tax Added"
        Me.optTax.UseVisualStyleBackColor = True
        '
        'optNoTax
        '
        Me.optNoTax.AutoSize = True
        Me.optNoTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNoTax.Location = New System.Drawing.Point(12, 167)
        Me.optNoTax.Name = "optNoTax"
        Me.optNoTax.Size = New System.Drawing.Size(60, 17)
        Me.optNoTax.TabIndex = 6
        Me.optNoTax.Text = "No Tax"
        Me.optNoTax.UseVisualStyleBackColor = True
        '
        'lblPizza
        '
        Me.lblPizza.AutoSize = True
        Me.lblPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizza.Location = New System.Drawing.Point(6, 34)
        Me.lblPizza.Name = "lblPizza"
        Me.lblPizza.Size = New System.Drawing.Size(32, 13)
        Me.lblPizza.TabIndex = 7
        Me.lblPizza.Text = "Pizza"
        '
        'lblDog
        '
        Me.lblDog.AutoSize = True
        Me.lblDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDog.Location = New System.Drawing.Point(6, 62)
        Me.lblDog.Name = "lblDog"
        Me.lblDog.Size = New System.Drawing.Size(74, 13)
        Me.lblDog.TabIndex = 8
        Me.lblDog.Text = "Juicy Hot Dog"
        '
        'lblCorndog
        '
        Me.lblCorndog.AutoSize = True
        Me.lblCorndog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorndog.Location = New System.Drawing.Point(6, 91)
        Me.lblCorndog.Name = "lblCorndog"
        Me.lblCorndog.Size = New System.Drawing.Size(84, 13)
        Me.lblCorndog.TabIndex = 9
        Me.lblCorndog.Text = "Golden Corndog"
        '
        'lblNachos
        '
        Me.lblNachos.AutoSize = True
        Me.lblNachos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNachos.Location = New System.Drawing.Point(6, 121)
        Me.lblNachos.Name = "lblNachos"
        Me.lblNachos.Size = New System.Drawing.Size(44, 13)
        Me.lblNachos.TabIndex = 10
        Me.lblNachos.Text = "Nachos"
        '
        'lblPopcorn
        '
        Me.lblPopcorn.AutoSize = True
        Me.lblPopcorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPopcorn.Location = New System.Drawing.Point(6, 149)
        Me.lblPopcorn.Name = "lblPopcorn"
        Me.lblPopcorn.Size = New System.Drawing.Size(47, 13)
        Me.lblPopcorn.TabIndex = 11
        Me.lblPopcorn.Text = "Popcorn"
        '
        'lblCandy
        '
        Me.lblCandy.AutoSize = True
        Me.lblCandy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandy.Location = New System.Drawing.Point(6, 178)
        Me.lblCandy.Name = "lblCandy"
        Me.lblCandy.Size = New System.Drawing.Size(37, 13)
        Me.lblCandy.TabIndex = 12
        Me.lblCandy.Text = "Candy"
        '
        'lblDrinks
        '
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinks.Location = New System.Drawing.Point(6, 204)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(37, 13)
        Me.lblDrinks.TabIndex = 13
        Me.lblDrinks.Text = "Drinks"
        '
        'txtCostDrinks
        '
        Me.txtCostDrinks.BackColor = System.Drawing.Color.White
        Me.txtCostDrinks.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCostDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostDrinks.Location = New System.Drawing.Point(332, 201)
        Me.txtCostDrinks.Name = "txtCostDrinks"
        Me.txtCostDrinks.ReadOnly = True
        Me.txtCostDrinks.Size = New System.Drawing.Size(100, 20)
        Me.txtCostDrinks.TabIndex = 27
        Me.txtCostDrinks.Text = "$0.00"
        Me.txtCostDrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostCandy
        '
        Me.txtCostCandy.BackColor = System.Drawing.Color.White
        Me.txtCostCandy.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCostCandy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostCandy.Location = New System.Drawing.Point(332, 175)
        Me.txtCostCandy.Name = "txtCostCandy"
        Me.txtCostCandy.ReadOnly = True
        Me.txtCostCandy.Size = New System.Drawing.Size(100, 20)
        Me.txtCostCandy.TabIndex = 26
        Me.txtCostCandy.Text = "$0.00"
        Me.txtCostCandy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostPopcorn
        '
        Me.txtCostPopcorn.BackColor = System.Drawing.Color.White
        Me.txtCostPopcorn.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCostPopcorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPopcorn.Location = New System.Drawing.Point(332, 146)
        Me.txtCostPopcorn.Name = "txtCostPopcorn"
        Me.txtCostPopcorn.ReadOnly = True
        Me.txtCostPopcorn.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPopcorn.TabIndex = 25
        Me.txtCostPopcorn.Text = "$0.00"
        Me.txtCostPopcorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostNachos
        '
        Me.txtCostNachos.BackColor = System.Drawing.Color.White
        Me.txtCostNachos.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCostNachos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostNachos.Location = New System.Drawing.Point(332, 118)
        Me.txtCostNachos.Name = "txtCostNachos"
        Me.txtCostNachos.ReadOnly = True
        Me.txtCostNachos.Size = New System.Drawing.Size(100, 20)
        Me.txtCostNachos.TabIndex = 24
        Me.txtCostNachos.Text = "$0.00"
        Me.txtCostNachos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostCorndog
        '
        Me.txtCostCorndog.BackColor = System.Drawing.Color.White
        Me.txtCostCorndog.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCostCorndog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostCorndog.Location = New System.Drawing.Point(332, 88)
        Me.txtCostCorndog.Name = "txtCostCorndog"
        Me.txtCostCorndog.ReadOnly = True
        Me.txtCostCorndog.Size = New System.Drawing.Size(100, 20)
        Me.txtCostCorndog.TabIndex = 23
        Me.txtCostCorndog.Text = "$0.00"
        Me.txtCostCorndog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostDog
        '
        Me.txtCostDog.BackColor = System.Drawing.Color.White
        Me.txtCostDog.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCostDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostDog.Location = New System.Drawing.Point(332, 59)
        Me.txtCostDog.Name = "txtCostDog"
        Me.txtCostDog.ReadOnly = True
        Me.txtCostDog.Size = New System.Drawing.Size(100, 20)
        Me.txtCostDog.TabIndex = 22
        Me.txtCostDog.Text = "$0.00"
        Me.txtCostDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostPizza
        '
        Me.txtCostPizza.BackColor = System.Drawing.Color.White
        Me.txtCostPizza.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCostPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPizza.Location = New System.Drawing.Point(332, 31)
        Me.txtCostPizza.Name = "txtCostPizza"
        Me.txtCostPizza.ReadOnly = True
        Me.txtCostPizza.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPizza.TabIndex = 21
        Me.txtCostPizza.Text = "$0.00"
        Me.txtCostPizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(367, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Cost"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(215, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Number of Items"
        '
        'nudPizza
        '
        Me.nudPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPizza.Location = New System.Drawing.Point(213, 32)
        Me.nudPizza.Name = "nudPizza"
        Me.nudPizza.Size = New System.Drawing.Size(100, 20)
        Me.nudPizza.TabIndex = 30
        Me.nudPizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudDog
        '
        Me.nudDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDog.Location = New System.Drawing.Point(213, 60)
        Me.nudDog.Name = "nudDog"
        Me.nudDog.Size = New System.Drawing.Size(100, 20)
        Me.nudDog.TabIndex = 31
        Me.nudDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudCorndog
        '
        Me.nudCorndog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCorndog.Location = New System.Drawing.Point(213, 89)
        Me.nudCorndog.Name = "nudCorndog"
        Me.nudCorndog.Size = New System.Drawing.Size(100, 20)
        Me.nudCorndog.TabIndex = 32
        Me.nudCorndog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudNachos
        '
        Me.nudNachos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNachos.Location = New System.Drawing.Point(213, 119)
        Me.nudNachos.Name = "nudNachos"
        Me.nudNachos.Size = New System.Drawing.Size(100, 20)
        Me.nudNachos.TabIndex = 33
        Me.nudNachos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudPopcorn
        '
        Me.nudPopcorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPopcorn.Location = New System.Drawing.Point(213, 147)
        Me.nudPopcorn.Name = "nudPopcorn"
        Me.nudPopcorn.Size = New System.Drawing.Size(100, 20)
        Me.nudPopcorn.TabIndex = 34
        Me.nudPopcorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudCandy
        '
        Me.nudCandy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCandy.Location = New System.Drawing.Point(213, 176)
        Me.nudCandy.Name = "nudCandy"
        Me.nudCandy.Size = New System.Drawing.Size(100, 20)
        Me.nudCandy.TabIndex = 35
        Me.nudCandy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudDrinks
        '
        Me.nudDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDrinks.Location = New System.Drawing.Point(213, 202)
        Me.nudDrinks.Name = "nudDrinks"
        Me.nudDrinks.Size = New System.Drawing.Size(100, 20)
        Me.nudDrinks.TabIndex = 36
        Me.nudDrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'boxTotal
        '
        Me.boxTotal.Controls.Add(Me.GroupBox2)
        Me.boxTotal.Controls.Add(Me.GroupBox1)
        Me.boxTotal.Controls.Add(Me.optTax)
        Me.boxTotal.Controls.Add(Me.txtTotal)
        Me.boxTotal.Controls.Add(Me.btnCalc)
        Me.boxTotal.Controls.Add(Me.optNoTax)
        Me.boxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxTotal.Location = New System.Drawing.Point(456, 74)
        Me.boxTotal.Name = "boxTotal"
        Me.boxTotal.Size = New System.Drawing.Size(176, 245)
        Me.boxTotal.TabIndex = 37
        Me.boxTotal.TabStop = False
        Me.boxTotal.Text = "Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPercent)
        Me.GroupBox2.Controls.Add(Me.nudTip)
        Me.GroupBox2.Controls.Add(Me.chkTip)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 49)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Would you like to leave a tip?"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(108, 20)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(15, 13)
        Me.lblPercent.TabIndex = 2
        Me.lblPercent.Text = "%"
        '
        'nudTip
        '
        Me.nudTip.DecimalPlaces = 1
        Me.nudTip.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudTip.Location = New System.Drawing.Point(59, 18)
        Me.nudTip.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudTip.Minimum = New Decimal(New Integer() {11, 0, 0, 65536})
        Me.nudTip.Name = "nudTip"
        Me.nudTip.Size = New System.Drawing.Size(43, 20)
        Me.nudTip.TabIndex = 1
        Me.nudTip.Value = New Decimal(New Integer() {15, 0, 0, 65536})
        '
        'chkTip
        '
        Me.chkTip.AutoSize = True
        Me.chkTip.Location = New System.Drawing.Point(6, 19)
        Me.chkTip.Name = "chkTip"
        Me.chkTip.Size = New System.Drawing.Size(47, 17)
        Me.chkTip.TabIndex = 0
        Me.chkTip.Text = "Yes,"
        Me.chkTip.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCouponVerify)
        Me.GroupBox1.Controls.Add(Me.txtCoupon)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 80)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Coupon Code"
        '
        'btnCouponVerify
        '
        Me.btnCouponVerify.CausesValidation = False
        Me.btnCouponVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCouponVerify.Location = New System.Drawing.Point(44, 46)
        Me.btnCouponVerify.Name = "btnCouponVerify"
        Me.btnCouponVerify.Size = New System.Drawing.Size(70, 23)
        Me.btnCouponVerify.TabIndex = 1
        Me.btnCouponVerify.Text = "Verify"
        Me.btnCouponVerify.UseVisualStyleBackColor = True
        '
        'txtCoupon
        '
        Me.txtCoupon.Location = New System.Drawing.Point(6, 20)
        Me.txtCoupon.Name = "txtCoupon"
        Me.txtCoupon.Size = New System.Drawing.Size(152, 20)
        Me.txtCoupon.TabIndex = 0
        Me.txtCoupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'boxMenu
        '
        Me.boxMenu.Controls.Add(Me.boxMeal3)
        Me.boxMenu.Controls.Add(Me.boxMeal2)
        Me.boxMenu.Controls.Add(Me.boxMeal1)
        Me.boxMenu.Controls.Add(Me.Label10)
        Me.boxMenu.Controls.Add(Me.lblPizza)
        Me.boxMenu.Controls.Add(Me.nudDrinks)
        Me.boxMenu.Controls.Add(Me.lblDog)
        Me.boxMenu.Controls.Add(Me.nudCandy)
        Me.boxMenu.Controls.Add(Me.lblCorndog)
        Me.boxMenu.Controls.Add(Me.nudPopcorn)
        Me.boxMenu.Controls.Add(Me.lblNachos)
        Me.boxMenu.Controls.Add(Me.nudNachos)
        Me.boxMenu.Controls.Add(Me.lblPopcorn)
        Me.boxMenu.Controls.Add(Me.nudCorndog)
        Me.boxMenu.Controls.Add(Me.lblCandy)
        Me.boxMenu.Controls.Add(Me.nudDog)
        Me.boxMenu.Controls.Add(Me.lblDrinks)
        Me.boxMenu.Controls.Add(Me.nudPizza)
        Me.boxMenu.Controls.Add(Me.txtCostPizza)
        Me.boxMenu.Controls.Add(Me.txtCostDog)
        Me.boxMenu.Controls.Add(Me.Label9)
        Me.boxMenu.Controls.Add(Me.txtCostCorndog)
        Me.boxMenu.Controls.Add(Me.txtCostDrinks)
        Me.boxMenu.Controls.Add(Me.txtCostNachos)
        Me.boxMenu.Controls.Add(Me.txtCostCandy)
        Me.boxMenu.Controls.Add(Me.txtCostPopcorn)
        Me.boxMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxMenu.Location = New System.Drawing.Point(12, 12)
        Me.boxMenu.Name = "boxMenu"
        Me.boxMenu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxMenu.Size = New System.Drawing.Size(438, 307)
        Me.boxMenu.TabIndex = 38
        Me.boxMenu.TabStop = False
        Me.boxMenu.Text = "Menu"
        '
        'boxMeal3
        '
        Me.boxMeal3.Controls.Add(Me.lblPls3)
        Me.boxMeal3.Controls.Add(Me.nudMeal3)
        Me.boxMeal3.Controls.Add(Me.lblScroll3)
        Me.boxMeal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxMeal3.Location = New System.Drawing.Point(296, 226)
        Me.boxMeal3.Name = "boxMeal3"
        Me.boxMeal3.Size = New System.Drawing.Size(136, 72)
        Me.boxMeal3.TabIndex = 39
        Me.boxMeal3.TabStop = False
        Me.boxMeal3.Text = "Meal 3: One of Each"
        '
        'nudMeal3
        '
        Me.nudMeal3.Location = New System.Drawing.Point(22, 46)
        Me.nudMeal3.Name = "nudMeal3"
        Me.nudMeal3.Size = New System.Drawing.Size(48, 20)
        Me.nudMeal3.TabIndex = 1
        '
        'lblScroll3
        '
        Me.lblScroll3.AutoSize = True
        Me.lblScroll3.Location = New System.Drawing.Point(140, 23)
        Me.lblScroll3.Name = "lblScroll3"
        Me.lblScroll3.Size = New System.Drawing.Size(278, 13)
        Me.lblScroll3.TabIndex = 0
        Me.lblScroll3.Text = "This hefty meal includes one of everything from our menu!"
        '
        'boxMeal2
        '
        Me.boxMeal2.Controls.Add(Me.lblPls2)
        Me.boxMeal2.Controls.Add(Me.nudMeal2)
        Me.boxMeal2.Controls.Add(Me.lblScroll2)
        Me.boxMeal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxMeal2.Location = New System.Drawing.Point(151, 226)
        Me.boxMeal2.Name = "boxMeal2"
        Me.boxMeal2.Size = New System.Drawing.Size(139, 72)
        Me.boxMeal2.TabIndex = 38
        Me.boxMeal2.TabStop = False
        Me.boxMeal2.Text = "Meal 2: Dog and Drink"
        '
        'nudMeal2
        '
        Me.nudMeal2.Location = New System.Drawing.Point(23, 46)
        Me.nudMeal2.Name = "nudMeal2"
        Me.nudMeal2.Size = New System.Drawing.Size(51, 20)
        Me.nudMeal2.TabIndex = 1
        '
        'lblScroll2
        '
        Me.lblScroll2.AutoSize = True
        Me.lblScroll2.Location = New System.Drawing.Point(140, 23)
        Me.lblScroll2.Name = "lblScroll2"
        Me.lblScroll2.Size = New System.Drawing.Size(325, 13)
        Me.lblScroll2.TabIndex = 0
        Me.lblScroll2.Text = "Hot dog/corndog combo! Includes a hot dog, corndog, and a drink."
        '
        'boxMeal1
        '
        Me.boxMeal1.Controls.Add(Me.lblPls1)
        Me.boxMeal1.Controls.Add(Me.nudMeal1)
        Me.boxMeal1.Controls.Add(Me.lblScroll1)
        Me.boxMeal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxMeal1.Location = New System.Drawing.Point(7, 226)
        Me.boxMeal1.Name = "boxMeal1"
        Me.boxMeal1.Size = New System.Drawing.Size(138, 72)
        Me.boxMeal1.TabIndex = 37
        Me.boxMeal1.TabStop = False
        Me.boxMeal1.Text = "Meal 1: Pizza Combo"
        '
        'nudMeal1
        '
        Me.nudMeal1.Location = New System.Drawing.Point(22, 46)
        Me.nudMeal1.Name = "nudMeal1"
        Me.nudMeal1.Size = New System.Drawing.Size(51, 20)
        Me.nudMeal1.TabIndex = 1
        '
        'lblScroll1
        '
        Me.lblScroll1.AutoSize = True
        Me.lblScroll1.Location = New System.Drawing.Point(140, 23)
        Me.lblScroll1.Name = "lblScroll1"
        Me.lblScroll1.Size = New System.Drawing.Size(331, 13)
        Me.lblScroll1.TabIndex = 0
        Me.lblScroll1.Text = "Best for a family of four! Includes 4 pizzas, 4 drinks, and two candies."
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(462, 17)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(32, 15)
        Me.lblTime.TabIndex = 40
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(462, 49)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(32, 15)
        Me.lblDate.TabIndex = 41
        Me.lblDate.Text = "Date"
        '
        'timTime
        '
        '
        'timDate
        '
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(611, 49)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(12, 13)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.TabStop = False
        Me.btnEdit.Text = "&edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'timScroll1
        '
        Me.timScroll1.Enabled = True
        Me.timScroll1.Interval = 50
        '
        'timScroll2
        '
        Me.timScroll2.Enabled = True
        Me.timScroll2.Interval = 50
        '
        'timScroll3
        '
        Me.timScroll3.Enabled = True
        Me.timScroll3.Interval = 50
        '
        'lblPls1
        '
        Me.lblPls1.AutoSize = True
        Me.lblPls1.Location = New System.Drawing.Point(79, 48)
        Me.lblPls1.Name = "lblPls1"
        Me.lblPls1.Size = New System.Drawing.Size(47, 13)
        Me.lblPls1.TabIndex = 2
        Me.lblPls1.Text = ", please."
        '
        'lblPls2
        '
        Me.lblPls2.AutoSize = True
        Me.lblPls2.Location = New System.Drawing.Point(80, 48)
        Me.lblPls2.Name = "lblPls2"
        Me.lblPls2.Size = New System.Drawing.Size(47, 13)
        Me.lblPls2.TabIndex = 3
        Me.lblPls2.Text = ", please."
        '
        'lblPls3
        '
        Me.lblPls3.AutoSize = True
        Me.lblPls3.Location = New System.Drawing.Point(76, 48)
        Me.lblPls3.Name = "lblPls3"
        Me.lblPls3.Size = New System.Drawing.Size(47, 13)
        Me.lblPls3.TabIndex = 3
        Me.lblPls3.Text = ", please."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 331)
        Me.Controls.Add(Me.boxTotal)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.boxMenu)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEdit)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Form1"
        Me.Text = "Silver Moon Drive-In"
        CType(Me.nudPizza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCorndog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNachos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPopcorn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCandy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDrinks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxTotal.ResumeLayout(False)
        Me.boxTotal.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudTip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.boxMenu.ResumeLayout(False)
        Me.boxMenu.PerformLayout()
        Me.boxMeal3.ResumeLayout(False)
        Me.boxMeal3.PerformLayout()
        CType(Me.nudMeal3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxMeal2.ResumeLayout(False)
        Me.boxMeal2.PerformLayout()
        CType(Me.nudMeal2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxMeal1.ResumeLayout(False)
        Me.boxMeal1.PerformLayout()
        CType(Me.nudMeal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents optTax As RadioButton
    Friend WithEvents optNoTax As RadioButton
    Friend WithEvents lblPizza As Label
    Friend WithEvents lblDog As Label
    Friend WithEvents lblCorndog As Label
    Friend WithEvents lblNachos As Label
    Friend WithEvents lblPopcorn As Label
    Friend WithEvents lblCandy As Label
    Friend WithEvents lblDrinks As Label
    Friend WithEvents txtCostDrinks As TextBox
    Friend WithEvents txtCostCandy As TextBox
    Friend WithEvents txtCostPopcorn As TextBox
    Friend WithEvents txtCostNachos As TextBox
    Friend WithEvents txtCostCorndog As TextBox
    Friend WithEvents txtCostDog As TextBox
    Friend WithEvents txtCostPizza As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents nudPizza As NumericUpDown
    Friend WithEvents nudDog As NumericUpDown
    Friend WithEvents nudCorndog As NumericUpDown
    Friend WithEvents nudNachos As NumericUpDown
    Friend WithEvents nudPopcorn As NumericUpDown
    Friend WithEvents nudCandy As NumericUpDown
    Friend WithEvents nudDrinks As NumericUpDown
    Friend WithEvents boxTotal As GroupBox
    Friend WithEvents boxMenu As GroupBox
    Friend WithEvents boxMeal1 As GroupBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents timTime As Timer
    Friend WithEvents timDate As Timer
    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPercent As Label
    Friend WithEvents nudTip As NumericUpDown
    Friend WithEvents chkTip As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCouponVerify As Button
    Friend WithEvents txtCoupon As TextBox
    Friend WithEvents boxMeal3 As GroupBox
    Friend WithEvents boxMeal2 As GroupBox
    Friend WithEvents lblScroll3 As Label
    Friend WithEvents lblScroll2 As Label
    Friend WithEvents lblScroll1 As Label
    Friend WithEvents timScroll1 As Timer
    Friend WithEvents timScroll2 As Timer
    Friend WithEvents timScroll3 As Timer
    Friend WithEvents nudMeal3 As NumericUpDown
    Friend WithEvents nudMeal2 As NumericUpDown
    Friend WithEvents nudMeal1 As NumericUpDown
    Friend WithEvents lblPls3 As Label
    Friend WithEvents lblPls2 As Label
    Friend WithEvents lblPls1 As Label
End Class
