<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbfruit = New System.Windows.Forms.GroupBox()
        Me.tbsc = New System.Windows.Forms.TextBox()
        Me.rbpath = New System.Windows.Forms.RadioButton()
        Me.rbcolor = New System.Windows.Forms.RadioButton()
        Me.rbgt = New System.Windows.Forms.RadioButton()
        Me.rbplace = New System.Windows.Forms.RadioButton()
        Me.rbnut = New System.Windows.Forms.RadioButton()
        Me.rbvar = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbgt = New System.Windows.Forms.ComboBox()
        Me.tbpath = New System.Windows.Forms.TextBox()
        Me.tbcolor = New System.Windows.Forms.TextBox()
        Me.tbplace = New System.Windows.Forms.TextBox()
        Me.tbnut = New System.Windows.Forms.TextBox()
        Me.tbvar = New System.Windows.Forms.TextBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.l5 = New System.Windows.Forms.Label()
        Me.l4 = New System.Windows.Forms.Label()
        Me.l3 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
        Me.lbitems = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbcatalog = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.gbfruit.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel1.Controls.Add(Me.gbfruit)
        Me.Panel1.Controls.Add(Me.lbitems)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbcatalog)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1160, 609)
        Me.Panel1.TabIndex = 0
        '
        'gbfruit
        '
        Me.gbfruit.BackgroundImage = CType(resources.GetObject("gbfruit.BackgroundImage"), System.Drawing.Image)
        Me.gbfruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbfruit.Controls.Add(Me.tbsc)
        Me.gbfruit.Controls.Add(Me.rbpath)
        Me.gbfruit.Controls.Add(Me.rbcolor)
        Me.gbfruit.Controls.Add(Me.rbgt)
        Me.gbfruit.Controls.Add(Me.rbplace)
        Me.gbfruit.Controls.Add(Me.rbnut)
        Me.gbfruit.Controls.Add(Me.rbvar)
        Me.gbfruit.Controls.Add(Me.CheckBox1)
        Me.gbfruit.Controls.Add(Me.Button5)
        Me.gbfruit.Controls.Add(Me.Button4)
        Me.gbfruit.Controls.Add(Me.Button3)
        Me.gbfruit.Controls.Add(Me.Button2)
        Me.gbfruit.Controls.Add(Me.Button1)
        Me.gbfruit.Controls.Add(Me.PictureBox1)
        Me.gbfruit.Controls.Add(Me.cbgt)
        Me.gbfruit.Controls.Add(Me.tbpath)
        Me.gbfruit.Controls.Add(Me.tbcolor)
        Me.gbfruit.Controls.Add(Me.tbplace)
        Me.gbfruit.Controls.Add(Me.tbnut)
        Me.gbfruit.Controls.Add(Me.tbvar)
        Me.gbfruit.Controls.Add(Me.tbname)
        Me.gbfruit.Controls.Add(Me.Label8)
        Me.gbfruit.Controls.Add(Me.Label7)
        Me.gbfruit.Controls.Add(Me.l5)
        Me.gbfruit.Controls.Add(Me.l4)
        Me.gbfruit.Controls.Add(Me.l3)
        Me.gbfruit.Controls.Add(Me.l2)
        Me.gbfruit.Controls.Add(Me.l1)
        Me.gbfruit.Location = New System.Drawing.Point(355, 15)
        Me.gbfruit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbfruit.Name = "gbfruit"
        Me.gbfruit.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbfruit.Size = New System.Drawing.Size(760, 416)
        Me.gbfruit.TabIndex = 100
        Me.gbfruit.TabStop = False
        Me.gbfruit.Text = "details"
        '
        'tbsc
        '
        Me.tbsc.Location = New System.Drawing.Point(231, 213)
        Me.tbsc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbsc.Name = "tbsc"
        Me.tbsc.Size = New System.Drawing.Size(176, 22)
        Me.tbsc.TabIndex = 6
        '
        'rbpath
        '
        Me.rbpath.AutoSize = True
        Me.rbpath.BackColor = System.Drawing.Color.Transparent
        Me.rbpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbpath.Location = New System.Drawing.Point(655, 258)
        Me.rbpath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbpath.Name = "rbpath"
        Me.rbpath.Size = New System.Drawing.Size(16, 15)
        Me.rbpath.TabIndex = 21
        Me.rbpath.TabStop = True
        Me.rbpath.UseVisualStyleBackColor = False
        Me.rbpath.Visible = False
        '
        'rbcolor
        '
        Me.rbcolor.AutoSize = True
        Me.rbcolor.BackColor = System.Drawing.Color.Transparent
        Me.rbcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbcolor.Location = New System.Drawing.Point(416, 257)
        Me.rbcolor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbcolor.Name = "rbcolor"
        Me.rbcolor.Size = New System.Drawing.Size(16, 15)
        Me.rbcolor.TabIndex = 20
        Me.rbcolor.TabStop = True
        Me.rbcolor.UseVisualStyleBackColor = False
        Me.rbcolor.Visible = False
        '
        'rbgt
        '
        Me.rbgt.AutoSize = True
        Me.rbgt.BackColor = System.Drawing.Color.Transparent
        Me.rbgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbgt.Location = New System.Drawing.Point(416, 218)
        Me.rbgt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbgt.Name = "rbgt"
        Me.rbgt.Size = New System.Drawing.Size(16, 15)
        Me.rbgt.TabIndex = 19
        Me.rbgt.TabStop = True
        Me.rbgt.UseVisualStyleBackColor = False
        Me.rbgt.Visible = False
        '
        'rbplace
        '
        Me.rbplace.AutoSize = True
        Me.rbplace.BackColor = System.Drawing.Color.Transparent
        Me.rbplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbplace.Location = New System.Drawing.Point(416, 178)
        Me.rbplace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbplace.Name = "rbplace"
        Me.rbplace.Size = New System.Drawing.Size(16, 15)
        Me.rbplace.TabIndex = 18
        Me.rbplace.TabStop = True
        Me.rbplace.UseVisualStyleBackColor = False
        Me.rbplace.Visible = False
        '
        'rbnut
        '
        Me.rbnut.AutoSize = True
        Me.rbnut.BackColor = System.Drawing.Color.Transparent
        Me.rbnut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbnut.Location = New System.Drawing.Point(416, 138)
        Me.rbnut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbnut.Name = "rbnut"
        Me.rbnut.Size = New System.Drawing.Size(16, 15)
        Me.rbnut.TabIndex = 17
        Me.rbnut.TabStop = True
        Me.rbnut.UseVisualStyleBackColor = False
        Me.rbnut.Visible = False
        '
        'rbvar
        '
        Me.rbvar.AutoSize = True
        Me.rbvar.BackColor = System.Drawing.Color.Transparent
        Me.rbvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbvar.Location = New System.Drawing.Point(416, 95)
        Me.rbvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbvar.Name = "rbvar"
        Me.rbvar.Size = New System.Drawing.Size(16, 15)
        Me.rbvar.TabIndex = 16
        Me.rbvar.TabStop = True
        Me.rbvar.UseVisualStyleBackColor = False
        Me.rbvar.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(301, 372)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(14, 13)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Font = New System.Drawing.Font("Footlight MT Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(463, 361)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 37)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Footlight MT Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(329, 361)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 37)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "UPDATE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Footlight MT Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(164, 361)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 37)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Snow
        Me.Button2.Font = New System.Drawing.Font("Footlight MT Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(19, 361)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 37)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "ADD NEW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Footlight MT Light", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(547, 251)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "BROWSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(489, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'cbgt
        '
        Me.cbgt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbgt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbgt.FormattingEnabled = True
        Me.cbgt.Items.AddRange(New Object() {"Vine", "plant", "tree"})
        Me.cbgt.Location = New System.Drawing.Point(231, 214)
        Me.cbgt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbgt.Name = "cbgt"
        Me.cbgt.Size = New System.Drawing.Size(176, 24)
        Me.cbgt.TabIndex = 6
        '
        'tbpath
        '
        Me.tbpath.Location = New System.Drawing.Point(231, 297)
        Me.tbpath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpath.Name = "tbpath"
        Me.tbpath.ReadOnly = True
        Me.tbpath.Size = New System.Drawing.Size(341, 22)
        Me.tbpath.TabIndex = 100
        '
        'tbcolor
        '
        Me.tbcolor.Location = New System.Drawing.Point(231, 255)
        Me.tbcolor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbcolor.Name = "tbcolor"
        Me.tbcolor.Size = New System.Drawing.Size(176, 22)
        Me.tbcolor.TabIndex = 7
        '
        'tbplace
        '
        Me.tbplace.Location = New System.Drawing.Point(231, 175)
        Me.tbplace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbplace.Name = "tbplace"
        Me.tbplace.Size = New System.Drawing.Size(176, 22)
        Me.tbplace.TabIndex = 5
        '
        'tbnut
        '
        Me.tbnut.Location = New System.Drawing.Point(231, 134)
        Me.tbnut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbnut.Name = "tbnut"
        Me.tbnut.Size = New System.Drawing.Size(176, 22)
        Me.tbnut.TabIndex = 4
        '
        'tbvar
        '
        Me.tbvar.Location = New System.Drawing.Point(231, 91)
        Me.tbvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbvar.Name = "tbvar"
        Me.tbvar.Size = New System.Drawing.Size(176, 22)
        Me.tbvar.TabIndex = 3
        '
        'tbname
        '
        Me.tbname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbname.Location = New System.Drawing.Point(231, 49)
        Me.tbname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(176, 22)
        Me.tbname.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(60, 297)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Photo Path"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(60, 255)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Color"
        '
        'l5
        '
        Me.l5.AutoSize = True
        Me.l5.BackColor = System.Drawing.Color.Transparent
        Me.l5.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l5.ForeColor = System.Drawing.Color.White
        Me.l5.Location = New System.Drawing.Point(60, 215)
        Me.l5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(102, 19)
        Me.l5.TabIndex = 1
        Me.l5.Text = "Grow type"
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.BackColor = System.Drawing.Color.Transparent
        Me.l4.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l4.ForeColor = System.Drawing.Color.White
        Me.l4.Location = New System.Drawing.Point(60, 175)
        Me.l4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(55, 19)
        Me.l4.TabIndex = 1
        Me.l4.Text = "Place"
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.BackColor = System.Drawing.Color.Transparent
        Me.l3.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.White
        Me.l3.Location = New System.Drawing.Point(60, 134)
        Me.l3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(92, 19)
        Me.l3.TabIndex = 1
        Me.l3.Text = "Nutrients"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.Color.Transparent
        Me.l2.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.White
        Me.l2.Location = New System.Drawing.Point(60, 91)
        Me.l2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(88, 19)
        Me.l2.TabIndex = 1
        Me.l2.Text = "Varaities"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.Transparent
        Me.l1.Font = New System.Drawing.Font("Lucida Bright", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.White
        Me.l1.Location = New System.Drawing.Point(60, 49)
        Me.l1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(60, 19)
        Me.l1.TabIndex = 1
        Me.l1.Text = "Name"
        '
        'lbitems
        '
        Me.lbitems.FormattingEnabled = True
        Me.lbitems.ItemHeight = 16
        Me.lbitems.Location = New System.Drawing.Point(29, 162)
        Me.lbitems.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbitems.Name = "lbitems"
        Me.lbitems.Size = New System.Drawing.Size(248, 340)
        Me.lbitems.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Select a catagory"
        '
        'cbcatalog
        '
        Me.cbcatalog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbcatalog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbcatalog.FormattingEnabled = True
        Me.cbcatalog.Items.AddRange(New Object() {"Fruits", "Vegetables", "Animals", "Birds"})
        Me.cbcatalog.Location = New System.Drawing.Point(36, 85)
        Me.cbcatalog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbcatalog.Name = "cbcatalog"
        Me.cbcatalog.Size = New System.Drawing.Size(199, 24)
        Me.cbcatalog.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 609)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form4"
        Me.Text = "Edit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbfruit.ResumeLayout(False)
        Me.gbfruit.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbitems As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbcatalog As System.Windows.Forms.ComboBox
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents l5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents tbvar As System.Windows.Forms.TextBox
    Friend WithEvents tbnut As System.Windows.Forms.TextBox
    Friend WithEvents tbplace As System.Windows.Forms.TextBox
    Friend WithEvents tbcolor As System.Windows.Forms.TextBox
    Friend WithEvents cbgt As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbfruit As System.Windows.Forms.GroupBox
    Friend WithEvents rbpath As System.Windows.Forms.RadioButton
    Friend WithEvents rbcolor As System.Windows.Forms.RadioButton
    Friend WithEvents rbgt As System.Windows.Forms.RadioButton
    Friend WithEvents rbplace As System.Windows.Forms.RadioButton
    Friend WithEvents rbnut As System.Windows.Forms.RadioButton
    Friend WithEvents rbvar As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents tbpath As System.Windows.Forms.TextBox
    Friend WithEvents tbsc As System.Windows.Forms.TextBox
End Class
