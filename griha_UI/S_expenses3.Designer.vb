<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_expenses3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(S_expenses3))
        Panel3 = New Panel()
        Panel2 = New Panel()
        Label_types_of_expenses = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Button_delete = New Button()
        Button_Update = New Button()
        Button_add = New Button()
        Information_label = New Label()
        TextBox_apartmentid = New TextBox()
        TextBox_Amount = New TextBox()
        TextBox_username = New TextBox()
        Label_expenses = New Label()
        PictureBox1 = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PictureBox2 = New PictureBox()
        Button_Events = New Button()
        button_resident = New Button()
        Panel1 = New Panel()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Expenses = New Button()
        DataGridView1 = New DataGridView()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(997, 260)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(905, 768)
        Panel3.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(Label_types_of_expenses)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Button_delete)
        Panel2.Controls.Add(Button_Update)
        Panel2.Controls.Add(Button_add)
        Panel2.Controls.Add(Information_label)
        Panel2.Controls.Add(TextBox_apartmentid)
        Panel2.Controls.Add(TextBox_Amount)
        Panel2.Controls.Add(TextBox_username)
        Panel2.Location = New Point(515, 260)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 768)
        Panel2.TabIndex = 15
        ' 
        ' Label_types_of_expenses
        ' 
        Label_types_of_expenses.AutoSize = True
        Label_types_of_expenses.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_types_of_expenses.ForeColor = Color.Teal
        Label_types_of_expenses.Location = New Point(11, 184)
        Label_types_of_expenses.Name = "Label_types_of_expenses"
        Label_types_of_expenses.Size = New Size(200, 29)
        Label_types_of_expenses.TabIndex = 20
        Label_types_of_expenses.Text = "Expenses Type:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(11, 321)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(441, 27)
        DateTimePicker1.TabIndex = 19
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Utility Expenses", "Maintainence Expenses", "Other Expenses"})
        ComboBox1.Location = New Point(11, 210)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(441, 33)
        ComboBox1.TabIndex = 18
        ' 
        ' Button_delete
        ' 
        Button_delete.BackColor = Color.Black
        Button_delete.BackgroundImageLayout = ImageLayout.None
        Button_delete.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_delete.ForeColor = Color.White
        Button_delete.Location = New Point(309, 429)
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
        Button_Update.Location = New Point(160, 429)
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
        Button_add.Location = New Point(11, 429)
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
        ' TextBox_apartmentid
        ' 
        TextBox_apartmentid.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_apartmentid.Location = New Point(11, 130)
        TextBox_apartmentid.Name = "TextBox_apartmentid"
        TextBox_apartmentid.PlaceholderText = "apartment/property ID"
        TextBox_apartmentid.Size = New Size(441, 34)
        TextBox_apartmentid.TabIndex = 8
        ' 
        ' TextBox_Amount
        ' 
        TextBox_Amount.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Amount.Location = New Point(11, 264)
        TextBox_Amount.Name = "TextBox_Amount"
        TextBox_Amount.PlaceholderText = "Amount"
        TextBox_Amount.Size = New Size(223, 34)
        TextBox_Amount.TabIndex = 5
        ' 
        ' TextBox_username
        ' 
        TextBox_username.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_username.Location = New Point(11, 77)
        TextBox_username.Name = "TextBox_username"
        TextBox_username.PlaceholderText = "username"
        TextBox_username.Size = New Size(441, 34)
        TextBox_username.TabIndex = 3
        ' 
        ' Label_expenses
        ' 
        Label_expenses.AutoSize = True
        Label_expenses.BackColor = Color.Transparent
        Label_expenses.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_expenses.Location = New Point(997, 170)
        Label_expenses.Name = "Label_expenses"
        Label_expenses.Size = New Size(460, 46)
        Label_expenses.TabIndex = 14
        Label_expenses.Text = "Expenses of Residency"
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
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' BackgroundWorker1
        ' 
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
        Panel1.TabIndex = 12
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
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(71, 77)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(766, 494)
        DataGridView1.TabIndex = 0
        ' 
        ' S_expenses3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label_expenses)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "S_expenses3"
        Text = "S_expenses3"
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Information_label As Label
    Friend WithEvents TextBox_apartmentid As TextBox
    Friend WithEvents TextBox_Amount As TextBox
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents Label_expenses As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button_Events As Button
    Friend WithEvents button_resident As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_back As Button
    Friend WithEvents Button_notices As Button
    Friend WithEvents Button_Workers As Button
    Friend WithEvents Button_Expenses As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label_types_of_expenses As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
