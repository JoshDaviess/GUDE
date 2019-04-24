<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UncollectedCache
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UncollectedCache))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PageLabel = New System.Windows.Forms.Label()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.showhide2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showhide2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(387, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(750, 450)
        Me.PictureBox2.TabIndex = 196
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 27)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "Text"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 27)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Cache Description"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(369, 294)
        Me.PictureBox1.TabIndex = 193
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(1017, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 50)
        Me.Button2.TabIndex = 191
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 27)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Uncollected"
        '
        'PageLabel
        '
        Me.PageLabel.AutoSize = True
        Me.PageLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.PageLabel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageLabel.Location = New System.Drawing.Point(168, 10)
        Me.PageLabel.Name = "PageLabel"
        Me.PageLabel.Size = New System.Drawing.Size(151, 27)
        Me.PageLabel.TabIndex = 188
        Me.PageLabel.Text = "Cache Name"
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.PictureBox15.Image = Global.GUDE.My.Resources.Resources.Treasure
        Me.PictureBox15.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 187
        Me.PictureBox15.TabStop = False
        '
        'showhide2
        '
        Me.showhide2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.showhide2.Location = New System.Drawing.Point(12, 10)
        Me.showhide2.Name = "showhide2"
        Me.showhide2.Size = New System.Drawing.Size(369, 150)
        Me.showhide2.TabIndex = 192
        Me.showhide2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(589, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(379, 27)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "????? ???? ?? ? ???? ????? ????"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(396, 60)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBox1.Size = New System.Drawing.Size(741, 400)
        Me.RichTextBox1.TabIndex = 197
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'UncollectedCache
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1188, 592)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PageLabel)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.showhide2)
        Me.Name = "UncollectedCache"
        Me.Text = "UncollectedCache"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showhide2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PageLabel As Label
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents showhide2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
