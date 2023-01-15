<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mng_candiates
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_name = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmb_course = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmb_year = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmb_position = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_candiatepic = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.namecand = New Guna.UI2.WinForms.Guna2TextBox()
        Me.course = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.year = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.position = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_register = New Guna.UI2.WinForms.Guna2Button()
        Me.candiatepic = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.candiatepic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(634, 44)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(583, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(48, 43)
        Me.Guna2ControlBox1.TabIndex = 7
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(532, 0)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(45, 43)
        Me.Guna2ControlBox3.TabIndex = 8
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(113, 15)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "MANAGE CANDIATES"
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Transparent
        Me.txt_name.Location = New System.Drawing.Point(236, 98)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(31, 15)
        Me.txt_name.TabIndex = 2
        Me.txt_name.Text = "Name"
        '
        'cmb_course
        '
        Me.cmb_course.BackColor = System.Drawing.Color.Transparent
        Me.cmb_course.Location = New System.Drawing.Point(236, 157)
        Me.cmb_course.Name = "cmb_course"
        Me.cmb_course.Size = New System.Drawing.Size(36, 15)
        Me.cmb_course.TabIndex = 3
        Me.cmb_course.Text = "Course"
        '
        'cmb_year
        '
        Me.cmb_year.BackColor = System.Drawing.Color.Transparent
        Me.cmb_year.Location = New System.Drawing.Point(236, 218)
        Me.cmb_year.Name = "cmb_year"
        Me.cmb_year.Size = New System.Drawing.Size(25, 15)
        Me.cmb_year.TabIndex = 4
        Me.cmb_year.Text = "Year"
        '
        'cmb_position
        '
        Me.cmb_position.BackColor = System.Drawing.Color.Transparent
        Me.cmb_position.Location = New System.Drawing.Point(236, 276)
        Me.cmb_position.Name = "cmb_position"
        Me.cmb_position.Size = New System.Drawing.Size(40, 15)
        Me.cmb_position.TabIndex = 5
        Me.cmb_position.Text = "Position"
        '
        'lbl_candiatepic
        '
        Me.lbl_candiatepic.BackColor = System.Drawing.Color.Transparent
        Me.lbl_candiatepic.Location = New System.Drawing.Point(62, 276)
        Me.lbl_candiatepic.Name = "lbl_candiatepic"
        Me.lbl_candiatepic.Size = New System.Drawing.Size(77, 15)
        Me.lbl_candiatepic.TabIndex = 6
        Me.lbl_candiatepic.Text = "Candiate Image"
        '
        'namecand
        '
        Me.namecand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namecand.DefaultText = ""
        Me.namecand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.namecand.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.namecand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namecand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namecand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namecand.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.namecand.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namecand.Location = New System.Drawing.Point(410, 81)
        Me.namecand.Name = "namecand"
        Me.namecand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namecand.PlaceholderText = ""
        Me.namecand.SelectedText = ""
        Me.namecand.Size = New System.Drawing.Size(200, 36)
        Me.namecand.TabIndex = 7
        '
        'course
        '
        Me.course.BackColor = System.Drawing.Color.Transparent
        Me.course.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.course.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.course.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.course.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.course.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.course.ItemHeight = 30
        Me.course.Items.AddRange(New Object() {"BCA", "BSC", "BA", "BCOM"})
        Me.course.Location = New System.Drawing.Point(410, 140)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(200, 36)
        Me.course.TabIndex = 8
        '
        'year
        '
        Me.year.BackColor = System.Drawing.Color.Transparent
        Me.year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.year.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.year.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.year.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.year.ItemHeight = 30
        Me.year.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year"})
        Me.year.Location = New System.Drawing.Point(410, 201)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(200, 36)
        Me.year.TabIndex = 9
        '
        'position
        '
        Me.position.BackColor = System.Drawing.Color.Transparent
        Me.position.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.position.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.position.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.position.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.position.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.position.ItemHeight = 30
        Me.position.Items.AddRange(New Object() {"Class Representive", "Sports Leader", "Assembly Leader", "Cultrual Leader"})
        Me.position.Location = New System.Drawing.Point(410, 259)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(200, 36)
        Me.position.TabIndex = 10
        '
        'btn_register
        '
        Me.btn_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_register.FillColor = System.Drawing.Color.Black
        Me.btn_register.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_register.ForeColor = System.Drawing.Color.White
        Me.btn_register.Location = New System.Drawing.Point(302, 314)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(180, 35)
        Me.btn_register.TabIndex = 11
        Me.btn_register.Text = "Register"
        '
        'candiatepic
        '
        Me.candiatepic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.candiatepic.ImageRotate = 0!
        Me.candiatepic.Location = New System.Drawing.Point(12, 95)
        Me.candiatepic.Name = "candiatepic"
        Me.candiatepic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.candiatepic.Size = New System.Drawing.Size(181, 161)
        Me.candiatepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.candiatepic.TabIndex = 12
        Me.candiatepic.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'mng_candiates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 373)
        Me.Controls.Add(Me.candiatepic)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.position)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.course)
        Me.Controls.Add(Me.namecand)
        Me.Controls.Add(Me.lbl_candiatepic)
        Me.Controls.Add(Me.cmb_position)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.cmb_year)
        Me.Controls.Add(Me.cmb_course)
        Me.Controls.Add(Me.txt_name)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mng_candiates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mng_candiates"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.candiatepic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmb_course As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmb_year As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmb_position As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_candiatepic As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents namecand As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents course As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents year As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents position As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_register As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents candiatepic As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
