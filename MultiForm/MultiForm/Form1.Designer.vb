<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNumbergame = New System.Windows.Forms.Button()
        Me.btnChecksum = New System.Windows.Forms.Button()
        Me.btnShrug = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNumbergame
        '
        Me.btnNumbergame.Location = New System.Drawing.Point(100, 96)
        Me.btnNumbergame.Name = "btnNumbergame"
        Me.btnNumbergame.Size = New System.Drawing.Size(77, 80)
        Me.btnNumbergame.TabIndex = 1
        Me.btnNumbergame.Text = "Number Guessing Game"
        Me.btnNumbergame.UseVisualStyleBackColor = True
        '
        'btnChecksum
        '
        Me.btnChecksum.Location = New System.Drawing.Point(181, 96)
        Me.btnChecksum.Name = "btnChecksum"
        Me.btnChecksum.Size = New System.Drawing.Size(77, 80)
        Me.btnChecksum.TabIndex = 2
        Me.btnChecksum.Text = "Check Sum Calculator"
        Me.btnChecksum.UseVisualStyleBackColor = True
        '
        'btnShrug
        '
        Me.btnShrug.Location = New System.Drawing.Point(262, 96)
        Me.btnShrug.Name = "btnShrug"
        Me.btnShrug.Size = New System.Drawing.Size(77, 80)
        Me.btnShrug.TabIndex = 3
        Me.btnShrug.Text = " ¯\_(ツ)_/¯"
        Me.btnShrug.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 260)
        Me.Controls.Add(Me.btnShrug)
        Me.Controls.Add(Me.btnChecksum)
        Me.Controls.Add(Me.btnNumbergame)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(466, 299)
        Me.MinimumSize = New System.Drawing.Size(466, 299)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MultiForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnNumbergame As Button
    Friend WithEvents btnChecksum As Button
    Friend WithEvents btnShrug As Button
End Class
