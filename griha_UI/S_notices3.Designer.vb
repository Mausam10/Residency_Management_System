<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_notices3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(S_notices3))
        Panel3 = New Panel()
        DGV_Notices = New DataGridView()
        Panel1 = New Panel()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Expenses = New Button()
        Button_Events = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        Button_delete = New Button()
        Button_Update = New Button()
        Button_add = New Button()
        Information_label = New Label()
        TextBox_notice = New TextBox()
        Panel2 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        TextBox_Name = New TextBox()
        Label_notices = New Label()
        PictureBox1 = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel3.SuspendLayout()
        CType(DGV_Notices, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DGV_Notices)
        Panel3.Location = New Point(997, 261)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(905, 768)
        Panel3.TabIndex = 17
        ' 
        ' DGV_Notices
        ' 
        DGV_Notices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_Notices.BackgroundColor = SystemColors.ButtonFace
        DGV_Notices.BorderStyle = BorderStyle.None
        DGV_Notices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Notices.Dock = DockStyle.Fill
        DGV_Notices.Location = New Point(0, 0)
        DGV_Notices.Name = "DGV_Notices"
        DGV_Notices.RowHeadersWidth = 51
        DGV_Notices.RowTemplate.Height = 29
        DGV_Notices.Size = New Size(905, 768)
        DGV_Notices.TabIndex = 0
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
        Panel1.TabIndex = 13
        ' 
        ' Button_back
        ' 
        Button_back.BackColor = Color.Black
        Button_back.BackgroundImageLayout = ImageLayout.None
        Button_back.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_back.ForeColor = Color.White
        Button_back.Location = New Point(121, 884)
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
        Button_notices.Location = New Point(121, 773)
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
        Button_Workers.Location = New Point(121, 660)
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
        Button_Expenses.Location = New Point(121, 539)
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
        Button_Events.Location = New Point(121, 422)
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
        button_resident.Location = New Point(121, 307)
        button_resident.Name = "button_resident"
        button_resident.Size = New Size(248, 43)
        button_resident.TabIndex = 8
        button_resident.Text = "Residents"
        button_resident.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, -6)
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
        Button_delete.Location = New Point(253, 552)
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
        Button_Update.Location = New Point(11, 552)
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
        Button_add.Location = New Point(11, 493)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(446, 43)
        Button_add.TabIndex = 15
        Button_add.Text = "New Notice"
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
        ' TextBox_notice
        ' 
        TextBox_notice.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_notice.Location = New Point(11, 174)
        TextBox_notice.Multiline = True
        TextBox_notice.Name = "TextBox_notice"
        TextBox_notice.PlaceholderText = "Notice"
        TextBox_notice.Size = New Size(446, 249)
        TextBox_notice.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Button_delete)
        Panel2.Controls.Add(Button_Update)
        Panel2.Controls.Add(Button_add)
        Panel2.Controls.Add(Information_label)
        Panel2.Controls.Add(TextBox_notice)
        Panel2.Controls.Add(TextBox_Name)
        Panel2.Location = New Point(515, 261)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 768)
        Panel2.TabIndex = 16
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.CustomFormat = "  hh:mm tt dddd dd MMMM yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(3, 121)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(446, 27)
        DateTimePicker1.TabIndex = 22
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Name.Location = New Point(11, 62)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.PlaceholderText = "Topic Name"
        TextBox_Name.Size = New Size(446, 34)
        TextBox_Name.TabIndex = 3
        ' 
        ' Label_notices
        ' 
        Label_notices.AutoSize = True
        Label_notices.BackColor = Color.Transparent
        Label_notices.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_notices.Location = New Point(1058, 170)
        Label_notices.Name = "Label_notices"
        Label_notices.Size = New Size(323, 46)
        Label_notices.TabIndex = 15
        Label_notices.Text = "Manage Notices"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(502, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 209)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' S_notices3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Label_notices)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "S_notices3"
        Text = "S_notices3"
        Panel3.ResumeLayout(False)
        CType(DGV_Notices, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_back As Button
    Friend WithEvents Button_notices As Button
    Friend WithEvents Button_Workers As Button
    Friend WithEvents Button_Expenses As Button
    Friend WithEvents Button_Events As Button
    Friend WithEvents button_resident As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Information_label As Label
    Friend WithEvents TextBox_notice As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label_notices As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DGV_Notices As DataGridView
End Class
