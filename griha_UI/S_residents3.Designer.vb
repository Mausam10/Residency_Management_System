<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_residents3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(S_residents3))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Expenses = New Button()
        Button_Events = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button1 = New Button()
        ComboBox_apartments = New ComboBox()
        Label2 = New Label()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Button_delete = New Button()
        Button_Update = New Button()
        Button_add = New Button()
        Information_label = New Label()
        TextBox_email = New TextBox()
        TextBox_phoneno2 = New TextBox()
        TextBox_phoneno = New TextBox()
        TextBox_password = New TextBox()
        TextBox_username = New TextBox()
        TextBox_lastname = New TextBox()
        TextBox_middlename = New TextBox()
        TextBox_firstname = New TextBox()
        Panel3 = New Panel()
        DataDVG = New DataGridView()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataDVG, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuText
        Panel1.Controls.Add(Button_back)
        Panel1.Controls.Add(Button_notices)
        Panel1.Controls.Add(Button_Workers)
        Panel1.Controls.Add(Button_Expenses)
        Panel1.Controls.Add(Button_Events)
        Panel1.Controls.Add(button_resident)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 1080)
        Panel1.TabIndex = 7
        ' 
        ' Button_back
        ' 
        Button_back.BackColor = Color.Black
        Button_back.BackgroundImageLayout = ImageLayout.None
        Button_back.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_back.ForeColor = Color.White
        Button_back.Location = New Point(122, 885)
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
        Button_notices.Location = New Point(122, 774)
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
        Button_Workers.Location = New Point(122, 661)
        Button_Workers.Name = "Button_Workers"
        Button_Workers.Size = New Size(248, 43)
        Button_Workers.TabIndex = 11
        Button_Workers.Text = "Workers"
        Button_Workers.UseVisualStyleBackColor = False
        ' 
        ' Button_Expenses
        ' 
        Button_Expenses.BackColor = Color.Black
        Button_Expenses.BackgroundImageLayout = ImageLayout.None
        Button_Expenses.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Expenses.ForeColor = Color.White
        Button_Expenses.Location = New Point(122, 540)
        Button_Expenses.Name = "Button_Expenses"
        Button_Expenses.Size = New Size(248, 43)
        Button_Expenses.TabIndex = 10
        Button_Expenses.Text = "Expenses"
        Button_Expenses.UseVisualStyleBackColor = False
        ' 
        ' Button_Events
        ' 
        Button_Events.BackColor = Color.Black
        Button_Events.BackgroundImageLayout = ImageLayout.None
        Button_Events.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Events.ForeColor = Color.White
        Button_Events.Location = New Point(122, 423)
        Button_Events.Name = "Button_Events"
        Button_Events.Size = New Size(248, 43)
        Button_Events.TabIndex = 9
        Button_Events.Text = "Events"
        Button_Events.UseVisualStyleBackColor = False
        ' 
        ' button_resident
        ' 
        button_resident.BackColor = Color.Black
        button_resident.BackgroundImageLayout = ImageLayout.None
        button_resident.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        button_resident.ForeColor = Color.White
        button_resident.Location = New Point(122, 308)
        button_resident.Name = "button_resident"
        button_resident.Size = New Size(248, 43)
        button_resident.TabIndex = 8
        button_resident.Text = "Residents"
        button_resident.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, -5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(426, 265)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(1059, 170)
        Label1.Name = "Label1"
        Label1.Size = New Size(367, 46)
        Label1.TabIndex = 9
        Label1.Text = "Manage Residents"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(500, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 209)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(ComboBox_apartments)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(RadioButton3)
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(Button_delete)
        Panel2.Controls.Add(Button_Update)
        Panel2.Controls.Add(Button_add)
        Panel2.Controls.Add(Information_label)
        Panel2.Controls.Add(TextBox_email)
        Panel2.Controls.Add(TextBox_phoneno2)
        Panel2.Controls.Add(TextBox_phoneno)
        Panel2.Controls.Add(TextBox_password)
        Panel2.Controls.Add(TextBox_username)
        Panel2.Controls.Add(TextBox_lastname)
        Panel2.Controls.Add(TextBox_middlename)
        Panel2.Controls.Add(TextBox_firstname)
        Panel2.Location = New Point(515, 260)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 768)
        Panel2.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(11, 590)
        Button1.Name = "Button1"
        Button1.Size = New Size(441, 43)
        Button1.TabIndex = 23
        Button1.Text = "RESET"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox_apartments
        ' 
        ComboBox_apartments.FormattingEnabled = True
        ComboBox_apartments.Location = New Point(11, 439)
        ComboBox_apartments.Name = "ComboBox_apartments"
        ComboBox_apartments.Size = New Size(441, 28)
        ComboBox_apartments.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(11, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 29)
        Label2.TabIndex = 21
        Label2.Text = "Gender"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton3.ForeColor = Color.Teal
        RadioButton3.Location = New Point(309, 270)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(82, 29)
        RadioButton3.TabIndex = 20
        RadioButton3.TabStop = True
        RadioButton3.Text = "Other"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.ForeColor = Color.Teal
        RadioButton2.Location = New Point(160, 270)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(98, 29)
        RadioButton2.TabIndex = 19
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.ForeColor = Color.Teal
        RadioButton1.Location = New Point(11, 270)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(76, 29)
        RadioButton1.TabIndex = 18
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Button_delete
        ' 
        Button_delete.BackColor = Color.Black
        Button_delete.BackgroundImageLayout = ImageLayout.None
        Button_delete.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_delete.ForeColor = Color.White
        Button_delete.Location = New Point(309, 534)
        Button_delete.Name = "Button_delete"
        Button_delete.Size = New Size(143, 43)
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
        Button_Update.Location = New Point(160, 534)
        Button_Update.Name = "Button_Update"
        Button_Update.Size = New Size(143, 43)
        Button_Update.TabIndex = 16
        Button_Update.Text = "UPDATE"
        Button_Update.UseVisualStyleBackColor = False
        ' 
        ' Button_add
        ' 
        Button_add.BackColor = Color.Black
        Button_add.BackgroundImageLayout = ImageLayout.None
        Button_add.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_add.ForeColor = Color.White
        Button_add.Location = New Point(11, 534)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(143, 43)
        Button_add.TabIndex = 15
        Button_add.Text = "ADD"
        Button_add.UseVisualStyleBackColor = False
        ' 
        ' Information_label
        ' 
        Information_label.AutoSize = True
        Information_label.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Information_label.ForeColor = Color.Teal
        Information_label.Location = New Point(11, 12)
        Information_label.Name = "Information_label"
        Information_label.Size = New Size(243, 32)
        Information_label.TabIndex = 9
        Information_label.Text = "Information Field"
        ' 
        ' TextBox_email
        ' 
        TextBox_email.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_email.Location = New Point(11, 376)
        TextBox_email.Name = "TextBox_email"
        TextBox_email.PlaceholderText = "e-mail address"
        TextBox_email.Size = New Size(441, 34)
        TextBox_email.TabIndex = 7
        ' 
        ' TextBox_phoneno2
        ' 
        TextBox_phoneno2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_phoneno2.Location = New Point(240, 317)
        TextBox_phoneno2.Name = "TextBox_phoneno2"
        TextBox_phoneno2.PlaceholderText = "phone number"
        TextBox_phoneno2.Size = New Size(212, 34)
        TextBox_phoneno2.TabIndex = 6
        ' 
        ' TextBox_phoneno
        ' 
        TextBox_phoneno.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_phoneno.Location = New Point(11, 317)
        TextBox_phoneno.Name = "TextBox_phoneno"
        TextBox_phoneno.PlaceholderText = "phone number"
        TextBox_phoneno.Size = New Size(223, 34)
        TextBox_phoneno.TabIndex = 5
        ' 
        ' TextBox_password
        ' 
        TextBox_password.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_password.Location = New Point(11, 120)
        TextBox_password.Name = "TextBox_password"
        TextBox_password.PlaceholderText = "password"
        TextBox_password.Size = New Size(441, 34)
        TextBox_password.TabIndex = 4
        ' 
        ' TextBox_username
        ' 
        TextBox_username.CharacterCasing = CharacterCasing.Lower
        TextBox_username.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_username.Location = New Point(11, 62)
        TextBox_username.Name = "TextBox_username"
        TextBox_username.PlaceholderText = "username"
        TextBox_username.Size = New Size(441, 34)
        TextBox_username.TabIndex = 3
        ' 
        ' TextBox_lastname
        ' 
        TextBox_lastname.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_lastname.Location = New Point(309, 177)
        TextBox_lastname.Name = "TextBox_lastname"
        TextBox_lastname.PlaceholderText = "last name"
        TextBox_lastname.Size = New Size(143, 34)
        TextBox_lastname.TabIndex = 2
        ' 
        ' TextBox_middlename
        ' 
        TextBox_middlename.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_middlename.Location = New Point(160, 177)
        TextBox_middlename.Name = "TextBox_middlename"
        TextBox_middlename.PlaceholderText = "middle name"
        TextBox_middlename.Size = New Size(143, 34)
        TextBox_middlename.TabIndex = 1
        ' 
        ' TextBox_firstname
        ' 
        TextBox_firstname.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_firstname.Location = New Point(11, 177)
        TextBox_firstname.Name = "TextBox_firstname"
        TextBox_firstname.PlaceholderText = "first name"
        TextBox_firstname.Size = New Size(143, 34)
        TextBox_firstname.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DataDVG)
        Panel3.Location = New Point(997, 260)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(905, 768)
        Panel3.TabIndex = 11
        ' 
        ' DataDVG
        ' 
        DataDVG.BackgroundColor = SystemColors.ButtonFace
        DataDVG.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataDVG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataDVG.Location = New Point(36, 62)
        DataDVG.MultiSelect = False
        DataDVG.Name = "DataDVG"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataDVG.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataDVG.RowHeadersWidth = 51
        DataDVG.RowTemplate.Height = 29
        DataDVG.Size = New Size(839, 545)
        DataDVG.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(11, 484)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "profession"
        TextBox1.Size = New Size(441, 34)
        TextBox1.TabIndex = 24
        ' 
        ' S_residents3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "S_residents3"
        Text = "S_residents3"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataDVG, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_back As Button
    Friend WithEvents Button_notices As Button
    Friend WithEvents Button_Workers As Button
    Friend WithEvents Button_Expenses As Button
    Friend WithEvents Button_Events As Button
    Friend WithEvents button_resident As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox_email As TextBox
    Friend WithEvents TextBox_phoneno2 As TextBox
    Friend WithEvents TextBox_phoneno As TextBox
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents TextBox_lastname As TextBox
    Friend WithEvents TextBox_middlename As TextBox
    Friend WithEvents TextBox_firstname As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Information_label As Label
    Friend WithEvents DataDVG As DataGridView
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboBox_apartments As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
