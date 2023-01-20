<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emprecords
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btnUpdEmp = New System.Windows.Forms.Button()
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxFrstname = New System.Windows.Forms.TextBox()
        Me.txtbxMidname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbxContNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbxEmpNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combGender = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAddEmp
        '
        Me.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAddEmp.Location = New System.Drawing.Point(252, 574)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(100, 50)
        Me.btnAddEmp.TabIndex = 6
        Me.btnAddEmp.Text = "Add"
        Me.btnAddEmp.UseVisualStyleBackColor = False
        '
        'btnUpdEmp
        '
        Me.btnUpdEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnUpdEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnUpdEmp.Location = New System.Drawing.Point(465, 574)
        Me.btnUpdEmp.Name = "btnUpdEmp"
        Me.btnUpdEmp.Size = New System.Drawing.Size(100, 50)
        Me.btnUpdEmp.TabIndex = 7
        Me.btnUpdEmp.Text = "Update"
        Me.btnUpdEmp.UseVisualStyleBackColor = False
        '
        'btnDelEmp
        '
        Me.btnDelEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDelEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnDelEmp.Location = New System.Drawing.Point(679, 574)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(100, 50)
        Me.btnDelEmp.TabIndex = 8
        Me.btnDelEmp.Text = "Delete"
        Me.btnDelEmp.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1027, 294)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(265, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(502, 35)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "E  M  P  L  O  Y  E  E    R  E  C  O  R  D  S"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(145, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "First name:"
        '
        'txtbxFrstname
        '
        Me.txtbxFrstname.BackColor = System.Drawing.Color.White
        Me.txtbxFrstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxFrstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxFrstname.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFrstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxFrstname.Location = New System.Drawing.Point(149, 370)
        Me.txtbxFrstname.Name = "txtbxFrstname"
        Me.txtbxFrstname.Size = New System.Drawing.Size(300, 32)
        Me.txtbxFrstname.TabIndex = 12
        Me.txtbxFrstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbxMidname
        '
        Me.txtbxMidname.BackColor = System.Drawing.Color.White
        Me.txtbxMidname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxMidname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxMidname.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxMidname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxMidname.Location = New System.Drawing.Point(149, 446)
        Me.txtbxMidname.Name = "txtbxMidname"
        Me.txtbxMidname.Size = New System.Drawing.Size(300, 32)
        Me.txtbxMidname.TabIndex = 14
        Me.txtbxMidname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(145, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Middle name:"
        '
        'txtbxSurname
        '
        Me.txtbxSurname.BackColor = System.Drawing.Color.White
        Me.txtbxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxSurname.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxSurname.Location = New System.Drawing.Point(149, 523)
        Me.txtbxSurname.Name = "txtbxSurname"
        Me.txtbxSurname.Size = New System.Drawing.Size(300, 32)
        Me.txtbxSurname.TabIndex = 16
        Me.txtbxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(145, 496)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Surname:"
        '
        'txtbxEmail
        '
        Me.txtbxEmail.BackColor = System.Drawing.Color.White
        Me.txtbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtbxEmail.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxEmail.Location = New System.Drawing.Point(588, 523)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(300, 32)
        Me.txtbxEmail.TabIndex = 22
        Me.txtbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(584, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 24)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Email:"
        '
        'txtbxContNum
        '
        Me.txtbxContNum.BackColor = System.Drawing.Color.White
        Me.txtbxContNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxContNum.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxContNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxContNum.Location = New System.Drawing.Point(588, 446)
        Me.txtbxContNum.MaxLength = 11
        Me.txtbxContNum.Name = "txtbxContNum"
        Me.txtbxContNum.Size = New System.Drawing.Size(300, 32)
        Me.txtbxContNum.TabIndex = 21
        Me.txtbxContNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(584, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Contact number:"
        '
        'txtbxEmpNo
        '
        Me.txtbxEmpNo.BackColor = System.Drawing.Color.White
        Me.txtbxEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxEmpNo.Enabled = False
        Me.txtbxEmpNo.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmpNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxEmpNo.Location = New System.Drawing.Point(588, 370)
        Me.txtbxEmpNo.Name = "txtbxEmpNo"
        Me.txtbxEmpNo.ReadOnly = True
        Me.txtbxEmpNo.Size = New System.Drawing.Size(176, 32)
        Me.txtbxEmpNo.TabIndex = 18
        Me.txtbxEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(584, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Employee #:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(785, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Gender:"
        '
        'combGender
        '
        Me.combGender.BackColor = System.Drawing.Color.White
        Me.combGender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.combGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combGender.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.combGender.FormattingEnabled = True
        Me.combGender.ItemHeight = 27
        Me.combGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.combGender.Location = New System.Drawing.Point(789, 370)
        Me.combGender.Name = "combGender"
        Me.combGender.Size = New System.Drawing.Size(99, 35)
        Me.combGender.TabIndex = 25
        '
        'emprecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.combGender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbxEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbxContNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbxEmpNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtbxSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbxMidname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxFrstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnDelEmp)
        Me.Controls.Add(Me.btnUpdEmp)
        Me.Controls.Add(Me.btnAddEmp)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "emprecords"
        Me.Size = New System.Drawing.Size(1033, 646)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents btnUpdEmp As Button
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxFrstname As TextBox
    Friend WithEvents txtbxMidname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxContNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxEmpNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents combGender As ComboBox
End Class
