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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBatas = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batas"
        '
        'TxtBatas
        '
        Me.TxtBatas.Location = New System.Drawing.Point(185, 69)
        Me.TxtBatas.Name = "TxtBatas"
        Me.TxtBatas.Size = New System.Drawing.Size(367, 34)
        Me.TxtBatas.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(454, 563)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tampilkan"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(330, 136)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(0, 34)
        Me.TextBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 27
        Me.ListBox1.Location = New System.Drawing.Point(185, 136)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(367, 409)
        Me.ListBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 640)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TxtBatas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Variable Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Perulangan WHILE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBatas As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
