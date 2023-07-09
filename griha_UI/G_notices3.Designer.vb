<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_notices3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(G_notices3))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        griha_logo = New PictureBox()
        Label_date = New Label()
        Label14 = New Label()
        Label_noticeDescription = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label_topic = New Label()
        PictureBox2 = New PictureBox()
        button_resident = New Button()
        Button_Visitors = New Button()
        Button_Workers = New Button()
        Button_notices = New Button()
        Button_back = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(griha_logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(1003, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 46)
        Label1.TabIndex = 13
        Label1.Text = "Notices of Residency"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(502, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(201, 222)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1773, 580)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(67, 62)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 33
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(596, 580)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(67, 62)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 34
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(griha_logo)
        Panel2.Controls.Add(Label_date)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label_noticeDescription)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label_topic)
        Panel2.Location = New Point(716, 272)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1008, 687)
        Panel2.TabIndex = 32
        ' 
        ' griha_logo
        ' 
        griha_logo.BorderStyle = BorderStyle.Fixed3D
        griha_logo.Image = CType(resources.GetObject("griha_logo.Image"), Image)
        griha_logo.Location = New Point(3, 3)
        griha_logo.Name = "griha_logo"
        griha_logo.Size = New Size(345, 158)
        griha_logo.SizeMode = PictureBoxSizeMode.CenterImage
        griha_logo.TabIndex = 30
        griha_logo.TabStop = False
        ' 
        ' Label_date
        ' 
        Label_date.AutoSize = True
        Label_date.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_date.ForeColor = Color.Black
        Label_date.Location = New Point(143, 219)
        Label_date.Name = "Label_date"
        Label_date.Size = New Size(78, 29)
        Label_date.TabIndex = 29
        Label_date.Text = "NULL"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(56, 219)
        Label14.Name = "Label14"
        Label14.Size = New Size(74, 29)
        Label14.TabIndex = 28
        Label14.Text = "Date:"
        ' 
        ' Label_noticeDescription
        ' 
        Label_noticeDescription.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_noticeDescription.ForeColor = Color.Black
        Label_noticeDescription.Location = New Point(56, 273)
        Label_noticeDescription.Name = "Label_noticeDescription"
        Label_noticeDescription.Size = New Size(893, 381)
        Label_noticeDescription.TabIndex = 26
        Label_noticeDescription.Text = "Notice"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Teal
        Label3.Location = New Point(187, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 29)
        Label3.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(205, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 29)
        Label2.TabIndex = 22
        ' 
        ' Label_topic
        ' 
        Label_topic.AutoSize = True
        Label_topic.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_topic.ForeColor = Color.Black
        Label_topic.Location = New Point(407, 154)
        Label_topic.Name = "Label_topic"
        Label_topic.Size = New Size(211, 39)
        Label_topic.TabIndex = 21
        Label_topic.Text = "Topic Name"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(420, 225)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
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
        Panel1.TabIndex = 11
        ' 
        ' G_notices3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "G_notices3"
        Text = "G_notices3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(griha_logo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents griha_logo As PictureBox
    Friend WithEvents Label_date As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label_noticeDescription As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_topic As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents button_resident As Button
    Friend WithEvents Button_Visitors As Button
    Friend WithEvents Button_Workers As Button
    Friend WithEvents Button_notices As Button
    Friend WithEvents Button_back As Button
    Friend WithEvents Panel1 As Panel
End Class
