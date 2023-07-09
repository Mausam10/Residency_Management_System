<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_workers3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(G_workers3))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Visitors = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        Label_record_visitors = New Label()
        PictureBox1 = New PictureBox()
        Label_attending_back = New Label()
        Label_leaving_residency = New Label()
        Button_delete = New Button()
        Button_Update = New Button()
        Button_add = New Button()
        Information_label = New Label()
        TextBox_description = New TextBox()
        Panel3 = New Panel()
        DGV_workers = New DataGridView()
        Panel2 = New Panel()
        CheckBox_worker = New CheckBox()
        Label2 = New Label()
        Label1 = New Label()
        ComboBox_workerID = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(DGV_workers, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
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
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 1080)
        Panel1.TabIndex = 24
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
        ' Label_record_visitors
        ' 
        Label_record_visitors.AutoSize = True
        Label_record_visitors.BackColor = Color.Transparent
        Label_record_visitors.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_record_visitors.Location = New Point(1052, 188)
        Label_record_visitors.Name = "Label_record_visitors"
        Label_record_visitors.Size = New Size(324, 46)
        Label_record_visitors.TabIndex = 26
        Label_record_visitors.Text = "Record Workers"
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
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' Label_attending_back
        ' 
        Label_attending_back.AutoSize = True
        Label_attending_back.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label_attending_back.ForeColor = Color.Teal
        Label_attending_back.Location = New Point(13, 234)
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
        Label_leaving_residency.Location = New Point(13, 130)
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
        Button_delete.Location = New Point(255, 589)
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
        Button_Update.Location = New Point(13, 589)
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
        Button_add.Location = New Point(13, 530)
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
        ' TextBox_description
        ' 
        TextBox_description.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_description.Location = New Point(13, 310)
        TextBox_description.Multiline = True
        TextBox_description.Name = "TextBox_description"
        TextBox_description.PlaceholderText = "Additional Information"
        TextBox_description.Size = New Size(446, 202)
        TextBox_description.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DGV_workers)
        Panel3.Location = New Point(990, 253)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(905, 768)
        Panel3.TabIndex = 28
        ' 
        ' DGV_workers
        ' 
        DGV_workers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_workers.BackgroundColor = SystemColors.ButtonFace
        DGV_workers.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGV_workers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGV_workers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_workers.Location = New Point(36, 62)
        DGV_workers.MultiSelect = False
        DGV_workers.Name = "DGV_workers"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV_workers.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV_workers.RowHeadersWidth = 51
        DGV_workers.RowTemplate.Height = 29
        DGV_workers.Size = New Size(839, 545)
        DGV_workers.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(CheckBox_worker)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ComboBox_workerID)
        Panel2.Controls.Add(DateTimePicker2)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label_attending_back)
        Panel2.Controls.Add(Label_leaving_residency)
        Panel2.Controls.Add(Button_delete)
        Panel2.Controls.Add(Button_Update)
        Panel2.Controls.Add(Button_add)
        Panel2.Controls.Add(Information_label)
        Panel2.Controls.Add(TextBox_description)
        Panel2.Location = New Point(505, 253)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 768)
        Panel2.TabIndex = 27
        ' 
        ' CheckBox_worker
        ' 
        CheckBox_worker.Location = New Point(223, 193)
        CheckBox_worker.Name = "CheckBox_worker"
        CheckBox_worker.Size = New Size(45, 37)
        CheckBox_worker.TabIndex = 31
        CheckBox_worker.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(13, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 25)
        Label2.TabIndex = 30
        Label2.Text = "Did the Worker Left?"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(13, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 25)
        Label1.TabIndex = 29
        Label1.Text = "Worker ID:"
        ' 
        ' ComboBox_workerID
        ' 
        ComboBox_workerID.FormattingEnabled = True
        ComboBox_workerID.Location = New Point(13, 90)
        ComboBox_workerID.Name = "ComboBox_workerID"
        ComboBox_workerID.Size = New Size(446, 28)
        ComboBox_workerID.TabIndex = 28
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.CustomFormat = " "
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(13, 262)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(446, 27)
        DateTimePicker2.TabIndex = 27
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.CustomFormat = "  hh:mm tt dddd dd MMMM yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(13, 159)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(446, 27)
        DateTimePicker1.TabIndex = 26
        ' 
        ' G_workers3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel1)
        Controls.Add(Label_record_visitors)
        Controls.Add(PictureBox1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Name = "G_workers3"
        Text = "G_workers3"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(DGV_workers, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_back As Button
    Friend WithEvents Button_notices As Button
    Friend WithEvents Button_Workers As Button
    Friend WithEvents Button_Visitors As Button
    Friend WithEvents button_resident As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label_record_visitors As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_attending_back As Label
    Friend WithEvents Label_leaving_residency As Label
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Information_label As Label
    Friend WithEvents TextBox_description As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox_workerID As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox_worker As CheckBox
    Friend WithEvents DGV_workers As DataGridView
End Class
