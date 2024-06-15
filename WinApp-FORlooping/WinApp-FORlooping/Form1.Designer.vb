<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbTgl = New System.Windows.Forms.ComboBox()
        Me.CmbBln = New System.Windows.Forms.ComboBox()
        Me.CmbThn = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tgl/Bln/Thn"
        '
        'CmbTgl
        '
        Me.CmbTgl.FormattingEnabled = True
        Me.CmbTgl.Location = New System.Drawing.Point(157, 72)
        Me.CmbTgl.Name = "CmbTgl"
        Me.CmbTgl.Size = New System.Drawing.Size(121, 35)
        Me.CmbTgl.TabIndex = 1
        '
        'CmbBln
        '
        Me.CmbBln.FormattingEnabled = True
        Me.CmbBln.Location = New System.Drawing.Point(284, 72)
        Me.CmbBln.Name = "CmbBln"
        Me.CmbBln.Size = New System.Drawing.Size(121, 35)
        Me.CmbBln.TabIndex = 1
        '
        'CmbThn
        '
        Me.CmbThn.FormattingEnabled = True
        Me.CmbThn.Location = New System.Drawing.Point(411, 72)
        Me.CmbThn.Name = "CmbThn"
        Me.CmbThn.Size = New System.Drawing.Size(121, 35)
        Me.CmbThn.TabIndex = 1
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 177)
        Me.Controls.Add(Me.CmbThn)
        Me.Controls.Add(Me.CmbBln)
        Me.Controls.Add(Me.CmbTgl)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "form1"
        Me.Text = "Perulangan FOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbTgl As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBln As System.Windows.Forms.ComboBox
    Friend WithEvents CmbThn As System.Windows.Forms.ComboBox

End Class
