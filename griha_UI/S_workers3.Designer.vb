<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_workers3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(S_workers3))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button_back = New Button()
        Button_Workers = New Button()
        Panel1 = New Panel()
        Button_notices = New Button()
        Button_Expenses = New Button()
        Button_Events = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        Button_delete = New Button()
        Button_Update = New Button()
        Button_add = New Button()
        Information_label = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label_workers = New Label()
        Panel3 = New Panel()
        DGVWorkers = New DataGridView()
        Panel2 = New Panel()
        Textbox_profession = New TextBox()
        TextBox_workerID = New TextBox()
        TextBox_phone2 = New TextBox()
        TextBox_phone1 = New TextBox()
        TextBox_lastname = New TextBox()
        TextBox_middlename = New TextBox()
        TextBox_firstname = New TextBox()
        PictureBox1 = New PictureBox()
        TextBox_address = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(DGVWorkers, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.TabIndex = 17
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
        ' Label_workers
        ' 
        Label_workers.AutoSize = True
        Label_workers.BackColor = Color.Transparent
        Label_workers.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_workers.Location = New Point(997, 170)
        Label_workers.Name = "Label_workers"
        Label_workers.Size = New Size(337, 46)
        Label_workers.TabIndex = 19
        Label_workers.Text = "Manage Workers"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DGVWorkers)
        Panel3.Location = New Point(997, 260)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(905, 768)
        Panel3.TabIndex = 21
        ' 
        ' DGVWorkers
        ' 
        DGVWorkers.BackgroundColor = SystemColors.ButtonFace
        DGVWorkers.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DGVWorkers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DGVWorkers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVWorkers.Location = New Point(36, 62)
        DGVWorkers.MultiSelect = False
        DGVWorkers.Name = "DGVWorkers"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DGVWorkers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DGVWorkers.RowHeadersWidth = 51
        DGVWorkers.RowTemplate.Height = 29
        DGVWorkers.Size = New Size(839, 545)
        DGVWorkers.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(TextBox_address)
        Panel2.Controls.Add(Textbox_profession)
        Panel2.Controls.Add(TextBox_workerID)
        Panel2.Controls.Add(TextBox_phone2)
        Panel2.Controls.Add(TextBox_phone1)
        Panel2.Controls.Add(TextBox_lastname)
        Panel2.Controls.Add(TextBox_middlename)
        Panel2.Controls.Add(TextBox_firstname)
        Panel2.Controls.Add(Button_delete)
        Panel2.Controls.Add(Button_Update)
        Panel2.Controls.Add(Button_add)
        Panel2.Controls.Add(Information_label)
        Panel2.Location = New Point(515, 260)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 768)
        Panel2.TabIndex = 20
        ' 
        ' Textbox_profession
        ' 
        Textbox_profession.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Textbox_profession.Location = New Point(11, 218)
        Textbox_profession.Name = "Textbox_profession"
        Textbox_profession.PlaceholderText = "profession"
        Textbox_profession.Size = New Size(441, 34)
        Textbox_profession.TabIndex = 27
        ' 
        ' TextBox_workerID
        ' 
        TextBox_workerID.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_workerID.Location = New Point(11, 49)
        TextBox_workerID.Name = "TextBox_workerID"
        TextBox_workerID.PlaceholderText = "worker ID"
        TextBox_workerID.Size = New Size(256, 34)
        TextBox_workerID.TabIndex = 26
        ' 
        ' TextBox_phone2
        ' 
        TextBox_phone2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_phone2.Location = New Point(240, 160)
        TextBox_phone2.Name = "TextBox_phone2"
        TextBox_phone2.PlaceholderText = "phone number"
        TextBox_phone2.Size = New Size(212, 34)
        TextBox_phone2.TabIndex = 25
        ' 
        ' TextBox_phone1
        ' 
        TextBox_phone1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_phone1.Location = New Point(11, 160)
        TextBox_phone1.Name = "TextBox_phone1"
        TextBox_phone1.PlaceholderText = "phone number"
        TextBox_phone1.Size = New Size(212, 34)
        TextBox_phone1.TabIndex = 24
        ' 
        ' TextBox_lastname
        ' 
        TextBox_lastname.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_lastname.Location = New Point(309, 102)
        TextBox_lastname.Name = "TextBox_lastname"
        TextBox_lastname.PlaceholderText = "last name"
        TextBox_lastname.Size = New Size(143, 34)
        TextBox_lastname.TabIndex = 23
        ' 
        ' TextBox_middlename
        ' 
        TextBox_middlename.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_middlename.Location = New Point(160, 102)
        TextBox_middlename.Name = "TextBox_middlename"
        TextBox_middlename.PlaceholderText = "middle name"
        TextBox_middlename.Size = New Size(143, 34)
        TextBox_middlename.TabIndex = 22
        ' 
        ' TextBox_firstname
        ' 
        TextBox_firstname.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_firstname.Location = New Point(11, 101)
        TextBox_firstname.Name = "TextBox_firstname"
        TextBox_firstname.PlaceholderText = "first name"
        TextBox_firstname.Size = New Size(143, 34)
        TextBox_firstname.TabIndex = 21
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
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' TextBox_address
        ' 
        TextBox_address.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_address.Location = New Point(11, 281)
        TextBox_address.Name = "TextBox_address"
        TextBox_address.PlaceholderText = "address"
        TextBox_address.Size = New Size(441, 34)
        TextBox_address.TabIndex = 28
        ' 
        ' S_workers3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel1)
        Controls.Add(Label_workers)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "S_workers3"
        Text = "S_workers3"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(DGVWorkers, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_back As Button
    Friend WithEvents Button_Workers As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_notices As Button
    Friend WithEvents Button_Expenses As Button
    Friend WithEvents Button_Events As Button
    Friend WithEvents button_resident As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Information_label As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label_workers As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox_lastname As TextBox
    Friend WithEvents TextBox_middlename As TextBox
    Friend WithEvents TextBox_firstname As TextBox
    Friend WithEvents TextBox_phone2 As TextBox
    Friend WithEvents TextBox_phone1 As TextBox
    Friend WithEvents TextBox_workerID As TextBox
    Friend WithEvents Textbox_profession As TextBox
    Friend WithEvents DGV_Workers As DataGridView
    Friend WithEvents DGVWorkers As DataGridView
    Friend WithEvents TextBox_address As TextBox
End Class
