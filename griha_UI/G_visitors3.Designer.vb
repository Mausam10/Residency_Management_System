<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_visitors3
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(G_visitors3))
        Panel3 = New Panel()
        DGV_visitors = New DataGridView()
        Label_attending_back = New Label()
        Label_leaving_residency = New Label()
        Button_delete = New Button()
        Button_Update = New Button()
        Button_add = New Button()
        Information_label = New Label()
        TextBox_purpose = New TextBox()
        Panel2 = New Panel()
        CheckBox_visitor = New CheckBox()
        Label2 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        TextBox_phone1 = New TextBox()
        TextBox_lastname = New TextBox()
        TextBox_middlename = New TextBox()
        TextBox_firstname = New TextBox()
        Label_record_visitors = New Label()
        PictureBox1 = New PictureBox()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Visitors = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel3.SuspendLayout()
        CType(DGV_visitors, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DGV_visitors)
        Panel3.Location = New Point(989, 254)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(905, 768)
        Panel3.TabIndex = 23
        ' 
        ' DGV_visitors
        ' 
        DGV_visitors.BackgroundColor = SystemColors.ButtonFace
        DGV_visitors.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGV_visitors.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGV_visitors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_visitors.Location = New Point(36, 62)
        DGV_visitors.MultiSelect = False
        DGV_visitors.Name = "DGV_visitors"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV_visitors.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV_visitors.RowHeadersWidth = 51
        DGV_visitors.RowTemplate.Height = 29
        DGV_visitors.Size = New Size(839, 545)
        DGV_visitors.TabIndex = 3
        ' 
        ' Label_attending_back
        ' 
        Label_attending_back.AutoSize = True
        Label_attending_back.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label_attending_back.ForeColor = Color.Teal
        Label_attending_back.Location = New Point(13, 278)
        Label_attending_back.Name = "Label_attending_back"
        Label_attending_back.Size = New Size(173, 25)
        Label_attending_back.TabIndex = 20
        Label_attending_back.Text = "Left Residency on:"
        ' 
        ' Label_leaving_residency
        ' 
        Label_leaving_residency.AutoSize = True
        Label_leaving_residency.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label_leaving_residency.ForeColor = Color.Teal
        Label_leaving_residency.Location = New Point(13, 170)
        Label_leaving_residency.Name = "Label_leaving_residency"
        Label_leaving_residency.Size = New Size(200, 25)
        Label_leaving_residency.TabIndex = 19
        Label_leaving_residency.Text = "Visited Residency on:"
        ' 
        ' Button_delete
        ' 
        Button_delete.BackColor = Color.Black
        Button_delete.BackgroundImageLayout = ImageLayout.None
        Button_delete.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_delete.ForeColor = Color.White
        Button_delete.Location = New Point(255, 607)
        Button_delete.Name = "Button_delete"
        Button_delete.Size = New Size(204, 43)
        Button_delete.TabIndex = 17
        Button_delete.Text = "DELETE"
        Button_delete.UseVisualStyleBackColor = False
        ' 
        ' Button_Update
        ' 
        Button_Update.BackColor = Color.Black
        Button_Update.BackgroundImageLayout = ImageLayout.None
        Button_Update.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Update.ForeColor = Color.White
        Button_Update.Location = New Point(13, 607)
        Button_Update.Name = "Button_Update"
        Button_Update.Size = New Size(205, 43)
        Button_Update.TabIndex = 16
        Button_Update.Text = "UPDATE "
        Button_Update.UseVisualStyleBackColor = False
        ' 
        ' Button_add
        ' 
        Button_add.BackColor = Color.Black
        Button_add.BackgroundImageLayout = ImageLayout.None
        Button_add.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_add.ForeColor = Color.White
        Button_add.Location = New Point(13, 548)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(446, 43)
        Button_add.TabIndex = 15
        Button_add.Text = "ADD"
        Button_add.UseVisualStyleBackColor = False
        ' 
        ' Information_label
        ' 
        Information_label.AutoSize = True
        Information_label.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Information_label.ForeColor = Color.Teal
        Information_label.Location = New Point(7, 11)
        Information_label.Name = "Information_label"
        Information_label.Size = New Size(243, 32)
        Information_label.TabIndex = 9
        Information_label.Text = "Information Field"
        ' 
        ' TextBox_purpose
        ' 
        TextBox_purpose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_purpose.Location = New Point(13, 340)
        TextBox_purpose.Multiline = True
        TextBox_purpose.Name = "TextBox_purpose"
        TextBox_purpose.PlaceholderText = "Purpose of Visit"
        TextBox_purpose.Size = New Size(446, 202)
        TextBox_purpose.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(CheckBox_visitor)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(DateTimePicker2)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(TextBox_phone1)
        Panel2.Controls.Add(TextBox_lastname)
        Panel2.Controls.Add(TextBox_middlename)
        Panel2.Controls.Add(TextBox_firstname)
        Panel2.Controls.Add(Label_attending_back)
        Panel2.Controls.Add(Label_leaving_residency)
        Panel2.Controls.Add(Button_delete)
        Panel2.Controls.Add(Button_Update)
        Panel2.Controls.Add(Button_add)
        Panel2.Controls.Add(Information_label)
        Panel2.Controls.Add(TextBox_purpose)
        Panel2.Location = New Point(507, 254)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 768)
        Panel2.TabIndex = 22
        ' 
        ' CheckBox_visitor
        ' 
        CheckBox_visitor.Location = New Point(196, 236)
        CheckBox_visitor.Name = "CheckBox_visitor"
        CheckBox_visitor.Size = New Size(45, 37)
        CheckBox_visitor.TabIndex = 32
        CheckBox_visitor.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(13, 241)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 25)
        Label2.TabIndex = 31
        Label2.Text = "Did the Visitor left?"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.CustomFormat = " "
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(13, 307)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(446, 27)
        DateTimePicker2.TabIndex = 27
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.CustomFormat = "  hh:mm tt dddd dd MMMM yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(13, 198)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(446, 27)
        DateTimePicker1.TabIndex = 26
        ' 
        ' TextBox_phone1
        ' 
        TextBox_phone1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_phone1.Location = New Point(13, 125)
        TextBox_phone1.Name = "TextBox_phone1"
        TextBox_phone1.PlaceholderText = "phone number"
        TextBox_phone1.Size = New Size(446, 34)
        TextBox_phone1.TabIndex = 24
        ' 
        ' TextBox_lastname
        ' 
        TextBox_lastname.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_lastname.Location = New Point(311, 71)
        TextBox_lastname.Name = "TextBox_lastname"
        TextBox_lastname.PlaceholderText = "last name"
        TextBox_lastname.Size = New Size(148, 34)
        TextBox_lastname.TabIndex = 23
        ' 
        ' TextBox_middlename
        ' 
        TextBox_middlename.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_middlename.Location = New Point(162, 71)
        TextBox_middlename.Name = "TextBox_middlename"
        TextBox_middlename.PlaceholderText = "middle name"
        TextBox_middlename.Size = New Size(143, 34)
        TextBox_middlename.TabIndex = 22
        ' 
        ' TextBox_firstname
        ' 
        TextBox_firstname.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_firstname.Location = New Point(13, 70)
        TextBox_firstname.Name = "TextBox_firstname"
        TextBox_firstname.PlaceholderText = "first name"
        TextBox_firstname.Size = New Size(143, 34)
        TextBox_firstname.TabIndex = 21
        ' 
        ' Label_record_visitors
        ' 
        Label_record_visitors.AutoSize = True
        Label_record_visitors.BackColor = Color.Transparent
        Label_record_visitors.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_record_visitors.Location = New Point(1072, 189)
        Label_record_visitors.Name = "Label_record_visitors"
        Label_record_visitors.Size = New Size(308, 46)
        Label_record_visitors.TabIndex = 21
        Label_record_visitors.Text = "Record Visitors"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(501, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(201, 222)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Button_back
        ' 
        Button_back.BackColor = Color.Black
        Button_back.BackgroundImageLayout = ImageLayout.None
        Button_back.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_back.ForeColor = Color.White
        Button_back.Location = New Point(121, 771)
        Button_back.Name = "Button_back"
        Button_back.Size = New Size(248, 43)
        Button_back.TabIndex = 14
        Button_back.Text = "Back to Login"
        Button_back.UseVisualStyleBackColor = False
        ' 
        ' Button_notices
        ' 
        Button_notices.BackColor = Color.Black
        Button_notices.BackgroundImageLayout = ImageLayout.None
        Button_notices.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_notices.ForeColor = Color.White
        Button_notices.Location = New Point(121, 648)
        Button_notices.Name = "Button_notices"
        Button_notices.Size = New Size(248, 43)
        Button_notices.TabIndex = 12
        Button_notices.Text = "Notices"
        Button_notices.UseVisualStyleBackColor = False
        ' 
        ' Button_Workers
        ' 
        Button_Workers.BackColor = Color.Black
        Button_Workers.BackgroundImageLayout = ImageLayout.None
        Button_Workers.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Workers.ForeColor = Color.White
        Button_Workers.Location = New Point(121, 521)
        Button_Workers.Name = "Button_Workers"
        Button_Workers.Size = New Size(248, 43)
        Button_Workers.TabIndex = 11
        Button_Workers.Text = "Workers"
        Button_Workers.UseVisualStyleBackColor = False
        ' 
        ' Button_Visitors
        ' 
        Button_Visitors.BackColor = Color.Black
        Button_Visitors.BackgroundImageLayout = ImageLayout.None
        Button_Visitors.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Visitors.ForeColor = Color.White
        Button_Visitors.Location = New Point(121, 403)
        Button_Visitors.Name = "Button_Visitors"
        Button_Visitors.Size = New Size(248, 43)
        Button_Visitors.TabIndex = 9
        Button_Visitors.Text = "Visitors"
        Button_Visitors.UseVisualStyleBackColor = False
        ' 
        ' button_resident
        ' 
        button_resident.BackColor = Color.Black
        button_resident.BackgroundImageLayout = ImageLayout.None
        button_resident.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        button_resident.ForeColor = Color.White
        button_resident.Location = New Point(121, 289)
        button_resident.Name = "button_resident"
        button_resident.Size = New Size(248, 43)
        button_resident.TabIndex = 8
        button_resident.Text = "Residents"
        button_resident.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-14, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(420, 225)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuText
        Panel1.Controls.Add(Button_back)
        Panel1.Controls.Add(Button_notices)
        Panel1.Controls.Add(Button_Workers)
        Panel1.Controls.Add(Button_Visitors)
        Panel1.Controls.Add(button_resident)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 1080)
        Panel1.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(13, 666)
        Button1.Name = "Button1"
        Button1.Size = New Size(446, 43)
        Button1.TabIndex = 24
        Button1.Text = "RESET"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' G_visitors3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label_record_visitors)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "G_visitors3"
        Text = "G_visitors3"
        Panel3.ResumeLayout(False)
        CType(DGV_visitors, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label_attending_back As Label
    Friend WithEvents Label_leaving_residency As Label
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Information_label As Label
    Friend WithEvents TextBox_purpose As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_record_visitors As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_back As Button
    Friend WithEvents Button_notices As Button
    Friend WithEvents Button_Workers As Button
    Friend WithEvents Button_Visitors As Button
    Friend WithEvents button_resident As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_lastname As TextBox
    Friend WithEvents TextBox_middlename As TextBox
    Friend WithEvents TextBox_firstname As TextBox
    Friend WithEvents TextBox_phone1 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox_visitor As CheckBox
    Friend WithEvents DGV_visitors As DataGridView
    Friend WithEvents Button1 As Button
End Class
