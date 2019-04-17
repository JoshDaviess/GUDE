<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.UsernameText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Sign_In = New System.Windows.Forms.Button()
        Me.FB_Sign = New System.Windows.Forms.Button()
        Me.Goog_Sign = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(49, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login to PortsHistory"
        '
        'UsernameText
        '
        Me.UsernameText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameText.Location = New System.Drawing.Point(66, 155)
        Me.UsernameText.MaxLength = 16
        Me.UsernameText.Name = "UsernameText"
        Me.UsernameText.Size = New System.Drawing.Size(150, 26)
        Me.UsernameText.TabIndex = 1
        Me.UsernameText.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(66, 209)
        Me.password.MaxLength = 16
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(150, 26)
        Me.password.TabIndex = 3
        Me.password.WordWrap = False
        '
        'Sign_In
        '
        Me.Sign_In.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sign_In.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sign_In.ForeColor = System.Drawing.SystemColors.Control
        Me.Sign_In.Location = New System.Drawing.Point(71, 259)
        Me.Sign_In.Name = "Sign_In"
        Me.Sign_In.Size = New System.Drawing.Size(138, 30)
        Me.Sign_In.TabIndex = 5
        Me.Sign_In.Text = "Sign In"
        Me.Sign_In.UseVisualStyleBackColor = False
        '
        'FB_Sign
        '
        Me.FB_Sign.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.FB_Sign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FB_Sign.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FB_Sign.ForeColor = System.Drawing.SystemColors.Control
        Me.FB_Sign.Location = New System.Drawing.Point(71, 295)
        Me.FB_Sign.Name = "FB_Sign"
        Me.FB_Sign.Size = New System.Drawing.Size(138, 30)
        Me.FB_Sign.TabIndex = 6
        Me.FB_Sign.Text = "Facebook Sign In"
        Me.FB_Sign.UseVisualStyleBackColor = False
        '
        'Goog_Sign
        '
        Me.Goog_Sign.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Goog_Sign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Goog_Sign.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Goog_Sign.ForeColor = System.Drawing.SystemColors.Control
        Me.Goog_Sign.Location = New System.Drawing.Point(71, 331)
        Me.Goog_Sign.Name = "Goog_Sign"
        Me.Goog_Sign.Size = New System.Drawing.Size(138, 30)
        Me.Goog_Sign.TabIndex = 7
        Me.Goog_Sign.Text = "Google Sign In"
        Me.Goog_Sign.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(288, 55)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.Sign_In
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 461)
        Me.Controls.Add(Me.Goog_Sign)
        Me.Controls.Add(Me.FB_Sign)
        Me.Controls.Add(Me.Sign_In)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UsernameText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PortsHistory: Log In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Sign_In As Button
    Friend WithEvents FB_Sign As Button
    Friend WithEvents Goog_Sign As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
