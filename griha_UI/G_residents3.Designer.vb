<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_residents3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(G_residents3))
        Panel1 = New Panel()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Visitors = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        Label_record_residents = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label_attending_back = New Label()
        Label_leaving_residency = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Button_delete = New Button()
        Button_Update = New Button()
        Button_add = New Button()
        Information_label = New Label()
        TextBox_description = New TextBox()
        TextBox_residents_username = New TextBox()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.TabIndex = 11
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
        PictureBox2.Location = New Point(-10, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(420, 225)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label_record_residents
        ' 
        Label_record_residents.AutoSize = True
        Label_record_residents.BackColor = Color.Transparent
        Label_record_residents.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_record_residents.Location = New Point(1072, 188)
        Label_record_residents.Name = "Label_record_residents"
        Label_record_residents.Size = New Size(354, 46)
        Label_record_residents.TabIndex = 13
        Label_record_residents.Text = "Record Residents"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(501, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(201, 222)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(Label_attending_back)
        Panel2.Controls.Add(Label_leaving_residency)
        Panel2.Controls.Add(DateTimePicker2)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Button_delete)
        Panel2.Controls.Add(Button_Update)
        Panel2.Controls.Add(Button_add)
        Panel2.Controls.Add(Information_label)
        Panel2.Controls.Add(TextBox_description)
        Panel2.Controls.Add(TextBox_residents_username)
        Panel2.Location = New Point(507, 253)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 768)
        Panel2.TabIndex = 17
        ' 
        ' Label_attending_back
        ' 
        Label_attending_back.AutoSize = True
        Label_attending_back.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label_attending_back.ForeColor = Color.Teal
        Label_attending_back.Location = New Point(11, 207)
        Label_attending_back.Name = "Label_attending_back"
        Label_attending_back.Size = New Size(269, 25)
        Label_attending_back.TabIndex = 20
        Label_attending_back.Text = "Attended Back Residency on:"
        ' 
        ' Label_leaving_residency
        ' 
        Label_leaving_residency.AutoSize = True
        Label_leaving_residency.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label_leaving_residency.ForeColor = Color.Teal
        Label_leaving_residency.Location = New Point(11, 126)
        Label_leaving_residency.Name = "Label_leaving_residency"
        Label_leaving_residency.Size = New Size(173, 25)
        Label_leaving_residency.TabIndex = 19
        Label_leaving_residency.Text = "Left Residency on:"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(11, 233)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(446, 27)
        DateTimePicker2.TabIndex = 18
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(11, 154)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(446, 27)
        DateTimePicker1.TabIndex = 12
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
        ' TextBox_description
        ' 
        TextBox_description.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_description.Location = New Point(11, 278)
        TextBox_description.Multiline = True
        TextBox_description.Name = "TextBox_description"
        TextBox_description.PlaceholderText = "Detail"
        TextBox_description.Size = New Size(446, 202)
        TextBox_description.TabIndex = 7
        ' 
        ' TextBox_residents_username
        ' 
        TextBox_residents_username.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_residents_username.Location = New Point(11, 62)
        TextBox_residents_username.Name = "TextBox_residents_username"
        TextBox_residents_username.PlaceholderText = "username"
        TextBox_residents_username.Size = New Size(446, 34)
        TextBox_residents_username.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(989, 253)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(905, 768)
        Panel3.TabIndex = 18
        ' 
        ' G_residents3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label_record_residents)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "G_residents3"
        Text = "G_residents3"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label_record_residents As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Information_label As Label
    Friend WithEvents TextBox_description As TextBox
    Friend WithEvents TextBox_residents_username As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label_leaving_residency As Label
    Friend WithEvents Label_attending_back As Label
End Class
