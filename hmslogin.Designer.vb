<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hmslogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hmslogin))
        Me.uname = New System.Windows.Forms.TextBox()
        Me.pword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.user = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'uname
        '
        Me.uname.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.uname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.uname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.uname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.uname.Location = New System.Drawing.Point(61, 284)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(305, 30)
        Me.uname.TabIndex = 2
        Me.uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pword
        '
        Me.pword.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.pword.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pword.Location = New System.Drawing.Point(61, 376)
        Me.pword.MaxLength = 20
        Me.pword.Name = "pword"
        Me.pword.Size = New System.Drawing.Size(305, 30)
        Me.pword.TabIndex = 3
        Me.pword.Tag = ""
        Me.pword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(164, 439)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 45)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(61, 412)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "show"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.BackgroundImage = CType(resources.GetObject("btnInfo.BackgroundImage"), System.Drawing.Image)
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnInfo.Location = New System.Drawing.Point(12, 588)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(35, 35)
        Me.btnInfo.TabIndex = 1
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.user.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(165, 287)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(91, 24)
        Me.user.TabIndex = 6
        Me.user.Text = "username"
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pass.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(165, 379)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(90, 24)
        Me.pass.TabIndex = 7
        Me.pass.Text = "password"
        '
        'hmslogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1129, 635)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pword)
        Me.Controls.Add(Me.uname)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "hmslogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HMS Log in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uname As TextBox
    Friend WithEvents pword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents user As Label
    Friend WithEvents pass As Label
End Class
