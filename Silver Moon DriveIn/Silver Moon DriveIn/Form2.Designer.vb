<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudDrinks = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudCandy = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudPopcorn = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudNachos = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudCorndog = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudDog = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudPizza = New System.Windows.Forms.NumericUpDown()
        Me.nudTax = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.boxVerify = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.nudTaxModifer = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.nudDrinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCandy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPopcorn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNachos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCorndog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxVerify.SuspendLayout()
        CType(Me.nudTaxModifer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(172, 12)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(100, 23)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Return To Kiosk"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(175, 13)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Price Editor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Pizza"
        '
        'nudDrinks
        '
        Me.nudDrinks.DecimalPlaces = 2
        Me.nudDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDrinks.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudDrinks.Location = New System.Drawing.Point(172, 212)
        Me.nudDrinks.Name = "nudDrinks"
        Me.nudDrinks.Size = New System.Drawing.Size(100, 20)
        Me.nudDrinks.TabIndex = 50
        Me.nudDrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Juicy Hot Dog"
        '
        'nudCandy
        '
        Me.nudCandy.DecimalPlaces = 2
        Me.nudCandy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCandy.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudCandy.Location = New System.Drawing.Point(172, 186)
        Me.nudCandy.Name = "nudCandy"
        Me.nudCandy.Size = New System.Drawing.Size(100, 20)
        Me.nudCandy.TabIndex = 49
        Me.nudCandy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Golden Corndog"
        '
        'nudPopcorn
        '
        Me.nudPopcorn.DecimalPlaces = 2
        Me.nudPopcorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPopcorn.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudPopcorn.Location = New System.Drawing.Point(172, 157)
        Me.nudPopcorn.Name = "nudPopcorn"
        Me.nudPopcorn.Size = New System.Drawing.Size(100, 20)
        Me.nudPopcorn.TabIndex = 48
        Me.nudPopcorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Nachos"
        '
        'nudNachos
        '
        Me.nudNachos.DecimalPlaces = 2
        Me.nudNachos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNachos.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudNachos.Location = New System.Drawing.Point(172, 129)
        Me.nudNachos.Name = "nudNachos"
        Me.nudNachos.Size = New System.Drawing.Size(100, 20)
        Me.nudNachos.TabIndex = 47
        Me.nudNachos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Popcorn"
        '
        'nudCorndog
        '
        Me.nudCorndog.DecimalPlaces = 2
        Me.nudCorndog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCorndog.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudCorndog.Location = New System.Drawing.Point(172, 99)
        Me.nudCorndog.Name = "nudCorndog"
        Me.nudCorndog.Size = New System.Drawing.Size(100, 20)
        Me.nudCorndog.TabIndex = 46
        Me.nudCorndog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Candy"
        '
        'nudDog
        '
        Me.nudDog.DecimalPlaces = 2
        Me.nudDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDog.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudDog.Location = New System.Drawing.Point(172, 70)
        Me.nudDog.Name = "nudDog"
        Me.nudDog.Size = New System.Drawing.Size(100, 20)
        Me.nudDog.TabIndex = 45
        Me.nudDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Drinks"
        '
        'nudPizza
        '
        Me.nudPizza.DecimalPlaces = 2
        Me.nudPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPizza.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudPizza.Location = New System.Drawing.Point(172, 42)
        Me.nudPizza.Name = "nudPizza"
        Me.nudPizza.Size = New System.Drawing.Size(100, 20)
        Me.nudPizza.TabIndex = 44
        Me.nudPizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudTax
        '
        Me.nudTax.DecimalPlaces = 2
        Me.nudTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTax.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudTax.Location = New System.Drawing.Point(172, 238)
        Me.nudTax.Name = "nudTax"
        Me.nudTax.Size = New System.Drawing.Size(100, 20)
        Me.nudTax.TabIndex = 52
        Me.nudTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Tax"
        '
        'boxVerify
        '
        Me.boxVerify.Controls.Add(Me.txtPassword)
        Me.boxVerify.Controls.Add(Me.btnConfirm)
        Me.boxVerify.Location = New System.Drawing.Point(16, 288)
        Me.boxVerify.Name = "boxVerify"
        Me.boxVerify.Size = New System.Drawing.Size(256, 41)
        Me.boxVerify.TabIndex = 54
        Me.boxVerify.TabStop = False
        Me.boxVerify.Text = "Verify with Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(6, 15)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(163, 20)
        Me.txtPassword.TabIndex = 2
        '
        'nudTaxModifer
        '
        Me.nudTaxModifer.DecimalPlaces = 2
        Me.nudTaxModifer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTaxModifer.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudTaxModifer.Location = New System.Drawing.Point(172, 262)
        Me.nudTaxModifer.Name = "nudTaxModifer"
        Me.nudTaxModifer.Size = New System.Drawing.Size(100, 20)
        Me.nudTaxModifer.TabIndex = 56
        Me.nudTaxModifer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Tax Modifier"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(117, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(49, 23)
        Me.btnReset.TabIndex = 57
        Me.btnReset.Text = "Default"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 341)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.nudTaxModifer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.boxVerify)
        Me.Controls.Add(Me.nudTax)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudDrinks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudCandy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudPopcorn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nudNachos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudCorndog)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudDog)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nudPizza)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "Form2"
        Me.Text = "Price Editor"
        CType(Me.nudDrinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCandy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPopcorn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNachos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCorndog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPizza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxVerify.ResumeLayout(False)
        Me.boxVerify.PerformLayout()
        CType(Me.nudTaxModifer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudDrinks As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents nudCandy As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nudPopcorn As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudNachos As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nudCorndog As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents nudDog As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents nudPizza As NumericUpDown
    Friend WithEvents nudTax As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents boxVerify As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents nudTaxModifer As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents btnReset As Button
End Class
