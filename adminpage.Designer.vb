<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminpage))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEmpRecords = New System.Windows.Forms.Button()
        Me.btnAdmLogs = New System.Windows.Forms.Button()
        Me.btnAdmRooms = New System.Windows.Forms.Button()
        Me.btnAdmAbout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(46, 606)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(227, 94)
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
        'btnEmpRecords
        '
        Me.btnEmpRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEmpRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmpRecords.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnEmpRecords.Location = New System.Drawing.Point(46, 159)
        Me.btnEmpRecords.Name = "btnEmpRecords"
        Me.btnEmpRecords.Size = New System.Drawing.Size(227, 94)
        Me.btnEmpRecords.TabIndex = 8
        Me.btnEmpRecords.Text = "Employee Records"
        Me.btnEmpRecords.UseVisualStyleBackColor = False
        '
        'btnAdmLogs
        '
        Me.btnAdmLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAdmLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmLogs.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAdmLogs.Location = New System.Drawing.Point(46, 271)
        Me.btnAdmLogs.Name = "btnAdmLogs"
        Me.btnAdmLogs.Size = New System.Drawing.Size(227, 94)
        Me.btnAdmLogs.TabIndex = 9
        Me.btnAdmLogs.Text = "Transaction Logs"
        Me.btnAdmLogs.UseVisualStyleBackColor = False
        '
        'btnAdmRooms
        '
        Me.btnAdmRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAdmRooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmRooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmRooms.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAdmRooms.Location = New System.Drawing.Point(46, 384)
        Me.btnAdmRooms.Name = "btnAdmRooms"
        Me.btnAdmRooms.Size = New System.Drawing.Size(227, 94)
        Me.btnAdmRooms.TabIndex = 10
        Me.btnAdmRooms.Text = "View Rooms"
        Me.btnAdmRooms.UseVisualStyleBackColor = False
        '
        'btnAdmAbout
        '
        Me.btnAdmAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAdmAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmAbout.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAdmAbout.Location = New System.Drawing.Point(46, 495)
        Me.btnAdmAbout.Name = "btnAdmAbout"
        Me.btnAdmAbout.Size = New System.Drawing.Size(227, 94)
        Me.btnAdmAbout.TabIndex = 12
        Me.btnAdmAbout.Text = "About HMS"
        Me.btnAdmAbout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 22)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Logged in as: Hotel Administrator"
        '
        'adminpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1346, 725)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdmAbout)
        Me.Controls.Add(Me.btnAdmRooms)
        Me.Controls.Add(Me.btnAdmLogs)
        Me.Controls.Add(Me.btnEmpRecords)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLogout)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "adminpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HMS Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEmpRecords As Button
    Friend WithEvents btnAdmLogs As Button
    Friend WithEvents btnAdmRooms As Button
    Friend WithEvents btnAdmAbout As Button
    Friend WithEvents Label1 As Label
End Class
