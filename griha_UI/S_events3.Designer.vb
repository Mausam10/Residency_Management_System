<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_events3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(S_events3))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Expenses = New Button()
        Button_Events = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label_events = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        TextBox_sponser = New TextBox()
        TextBox_amount = New TextBox()
        TextBox_organizer = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Button_delete = New Button()
        Button_Update = New Button()
        Button_add = New Button()
        Information_label = New Label()
        TextBox_description = New TextBox()
        TextBox_Name = New TextBox()
        Panel3 = New Panel()
        DGV_Events = New DataGridView()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DGV_Events, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Location = New Point(0, 0)
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
        ' Label_events
        ' 
        Label_events.AutoSize = True
        Label_events.BackColor = Color.Transparent
        Label_events.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_events.Location = New Point(1058, 169)
        Label_events.Name = "Label_events"
        Label_events.Size = New Size(308, 46)
        Label_events.TabIndex = 9
        Label_events.Text = "Manage Events"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(502, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 209)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox_sponser)
        Panel2.Controls.Add(TextBox_amount)
        Panel2.Controls.Add(TextBox_organizer)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Button_delete)
        Panel2.Controls.Add(Button_Update)
        Panel2.Controls.Add(Button_add)
        Panel2.Controls.Add(Information_label)
        Panel2.Controls.Add(TextBox_description)
        Panel2.Controls.Add(TextBox_Name)
        Panel2.Location = New Point(515, 260)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 768)
        Panel2.TabIndex = 11
        ' 
        ' TextBox_sponser
        ' 
        TextBox_sponser.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_sponser.Location = New Point(11, 237)
        TextBox_sponser.Name = "TextBox_sponser"
        TextBox_sponser.PlaceholderText = "Event Sponsers"
        TextBox_sponser.Size = New Size(446, 34)
        TextBox_sponser.TabIndex = 25
        ' 
        ' TextBox_amount
        ' 
        TextBox_amount.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_amount.Location = New Point(11, 573)
        TextBox_amount.Name = "TextBox_amount"
        TextBox_amount.PlaceholderText = "Event Expenses Amount"
        TextBox_amount.Size = New Size(446, 34)
        TextBox_amount.TabIndex = 24
        ' 
        ' TextBox_organizer
        ' 
        TextBox_organizer.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_organizer.Location = New Point(11, 178)
        TextBox_organizer.Name = "TextBox_organizer"
        TextBox_organizer.PlaceholderText = "Organizer Name"
        TextBox_organizer.Size = New Size(446, 34)
        TextBox_organizer.TabIndex = 23
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.CustomFormat = "  hh:mm tt dddd dd MMMM yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(11, 126)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(446, 27)
        DateTimePicker1.TabIndex = 22
        ' 
        ' Button_delete
        ' 
        Button_delete.BackColor = Color.Black
        Button_delete.BackgroundImageLayout = ImageLayout.None
        Button_delete.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_delete.ForeColor = Color.White
        Button_delete.Location = New Point(253, 676)
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
        Button_Update.Location = New Point(252, 624)
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
        Button_add.Location = New Point(11, 624)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(205, 43)
        Button_add.TabIndex = 15
        Button_add.Text = "Add Event"
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
        ' TextBox_description
        ' 
        TextBox_description.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_description.Location = New Point(11, 296)
        TextBox_description.Multiline = True
        TextBox_description.Name = "TextBox_description"
        TextBox_description.PlaceholderText = "Description about events"
        TextBox_description.Size = New Size(446, 249)
        TextBox_description.TabIndex = 7
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Name.Location = New Point(11, 62)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.PlaceholderText = "Event Name"
        TextBox_Name.Size = New Size(446, 34)
        TextBox_Name.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DGV_Events)
        Panel3.Location = New Point(997, 260)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(905, 768)
        Panel3.TabIndex = 12
        ' 
        ' DGV_Events
        ' 
        DGV_Events.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_Events.BackgroundColor = SystemColors.ButtonFace
        DGV_Events.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DGV_Events.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DGV_Events.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Events.Location = New Point(36, 62)
        DGV_Events.MultiSelect = False
        DGV_Events.Name = "DGV_Events"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DGV_Events.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DGV_Events.RowHeadersWidth = 51
        DGV_Events.RowTemplate.Height = 29
        DGV_Events.Size = New Size(839, 545)
        DGV_Events.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(11, 676)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 43)
        Button1.TabIndex = 26
        Button1.Text = "RESET"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' S_events3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label_events)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "S_events3"
        Text = "S_events3"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DGV_Events, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label_events As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Information_label As Label
    Friend WithEvents TextBox_description As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox_organizer As TextBox
    Friend WithEvents TextBox_sponser As TextBox
    Friend WithEvents TextBox_amount As TextBox
    Friend WithEvents DGV_Events As DataGridView
    Friend WithEvents Button1 As Button
End Class
