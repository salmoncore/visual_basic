<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScroll
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
        Me.components = New System.ComponentModel.Container()
        Me.lblShrug = New System.Windows.Forms.Label()
        Me.timScroll = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblShrug
        '
        Me.lblShrug.AutoSize = True
        Me.lblShrug.Font = New System.Drawing.Font("Microsoft Sans Serif", 300.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShrug.Location = New System.Drawing.Point(90, 121)
        Me.lblShrug.Name = "lblShrug"
        Me.lblShrug.Size = New System.Drawing.Size(1814, 453)
        Me.lblShrug.TabIndex = 0
        Me.lblShrug.Text = "¯\_(ツ)_/¯"
        '
        'timScroll
        '
        Me.timScroll.Enabled = True
        Me.timScroll.Interval = 10
        '
        'frmScroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblShrug)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmScroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblShrug As Label
    Friend WithEvents timScroll As Timer
End Class
