<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staffpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffpage))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCheckIO = New System.Windows.Forms.Button()
        Me.btnReservations = New System.Windows.Forms.Button()
        Me.btnStfLogs = New System.Windows.Forms.Button()
        Me.btnStfAbout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStfRooms = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(46, 615)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(227, 70)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(318, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 619)
        Me.Panel1.TabIndex = 7
        '
        'btnCheckIO
        '
        Me.btnCheckIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCheckIO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckIO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheckIO.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnCheckIO.Location = New System.Drawing.Point(46, 164)
        Me.btnCheckIO.Name = "btnCheckIO"
        Me.btnCheckIO.Size = New System.Drawing.Size(227, 70)
        Me.btnCheckIO.TabIndex = 8
        Me.btnCheckIO.Text = "Check-in/out"
        Me.btnCheckIO.UseVisualStyleBackColor = False
        '
        'btnReservations
        '
        Me.btnReservations.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReservations.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnReservations.Location = New System.Drawing.Point(46, 344)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Size = New System.Drawing.Size(227, 70)
        Me.btnReservations.TabIndex = 9
        Me.btnReservations.Text = "Reservations"
        Me.btnReservations.UseVisualStyleBackColor = False
        '
        'btnStfLogs
        '
        Me.btnStfLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnStfLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStfLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStfLogs.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStfLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnStfLogs.Location = New System.Drawing.Point(46, 434)
        Me.btnStfLogs.Name = "btnStfLogs"
        Me.btnStfLogs.Size = New System.Drawing.Size(227, 70)
        Me.btnStfLogs.TabIndex = 10
        Me.btnStfLogs.Text = "Transaction Logs"
        Me.btnStfLogs.UseVisualStyleBackColor = False
        '
        'btnStfAbout
        '
        Me.btnStfAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnStfAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStfAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStfAbout.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStfAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnStfAbout.Location = New System.Drawing.Point(46, 524)
        Me.btnStfAbout.Name = "btnStfAbout"
        Me.btnStfAbout.Size = New System.Drawing.Size(227, 70)
        Me.btnStfAbout.TabIndex = 12
        Me.btnStfAbout.Text = "About HMS"
        Me.btnStfAbout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 22)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Logged in as: Hotel Staff"
        '
        'btnStfRooms
        '
        Me.btnStfRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnStfRooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStfRooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStfRooms.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStfRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnStfRooms.Location = New System.Drawing.Point(46, 254)
        Me.btnStfRooms.Name = "btnStfRooms"
        Me.btnStfRooms.Size = New System.Drawing.Size(227, 70)
        Me.btnStfRooms.TabIndex = 14
        Me.btnStfRooms.Text = "Rooms"
        Me.btnStfRooms.UseVisualStyleBackColor = False
        '
        'staffpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1346, 725)
        Me.Controls.Add(Me.btnStfRooms)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStfAbout)
        Me.Controls.Add(Me.btnStfLogs)
        Me.Controls.Add(Me.btnReservations)
        Me.Controls.Add(Me.btnCheckIO)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLogout)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "staffpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HMS Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCheckIO As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents btnStfLogs As Button
    Friend WithEvents btnStfAbout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStfRooms As Button
End Class
