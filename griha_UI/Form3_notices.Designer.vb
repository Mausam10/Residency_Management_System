<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_notices
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3_notices))
        Panel1 = New Panel()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Expenses = New Button()
        Button_Property = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        Label_notices = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label_date = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label11 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        griha_logo = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(griha_logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuText
        Panel1.Controls.Add(Button_back)
        Panel1.Controls.Add(Button_notices)
        Panel1.Controls.Add(Button_Workers)
        Panel1.Controls.Add(Button_Expenses)
        Panel1.Controls.Add(Button_Property)
        Panel1.Controls.Add(button_resident)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 1080)
        Panel1.TabIndex = 18
        ' 
        ' Button_back
        ' 
        Button_back.BackColor = Color.Black
        Button_back.BackgroundImageLayout = ImageLayout.None
        Button_back.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_back.ForeColor = Color.White
        Button_back.Location = New Point(102, 883)
        Button_back.Name = "Button_back"
        Button_back.Size = New Size(248, 43)
        Button_back.TabIndex = 13
        Button_back.Text = "Back to Login"
        Button_back.UseVisualStyleBackColor = False
        ' 
        ' Button_notices
        ' 
        Button_notices.BackColor = Color.Black
        Button_notices.BackgroundImageLayout = ImageLayout.None
        Button_notices.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_notices.ForeColor = Color.White
        Button_notices.Location = New Point(102, 769)
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
        Button_Workers.Location = New Point(102, 655)
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
        Button_Expenses.Location = New Point(102, 538)
        Button_Expenses.Name = "Button_Expenses"
        Button_Expenses.Size = New Size(248, 43)
        Button_Expenses.TabIndex = 10
        Button_Expenses.Text = "Expenses"
        Button_Expenses.UseVisualStyleBackColor = False
        ' 
        ' Button_Property
        ' 
        Button_Property.BackColor = Color.Black
        Button_Property.BackgroundImageLayout = ImageLayout.None
        Button_Property.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Property.ForeColor = Color.White
        Button_Property.Location = New Point(102, 421)
        Button_Property.Name = "Button_Property"
        Button_Property.Size = New Size(248, 43)
        Button_Property.TabIndex = 9
        Button_Property.Text = "Property"
        Button_Property.UseVisualStyleBackColor = False
        ' 
        ' button_resident
        ' 
        button_resident.BackColor = Color.Black
        button_resident.BackgroundImageLayout = ImageLayout.None
        button_resident.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        button_resident.ForeColor = Color.White
        button_resident.Location = New Point(102, 303)
        button_resident.Name = "button_resident"
        button_resident.Size = New Size(248, 43)
        button_resident.TabIndex = 8
        button_resident.Text = "Residents"
        button_resident.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-8, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(420, 225)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label_notices
        ' 
        Label_notices.AutoSize = True
        Label_notices.BackColor = Color.Transparent
        Label_notices.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label_notices.Location = New Point(1156, 181)
        Label_notices.Name = "Label_notices"
        Label_notices.Size = New Size(162, 46)
        Label_notices.TabIndex = 20
        Label_notices.Text = "Notices"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(502, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(390, 228)
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(griha_logo)
        Panel2.Controls.Add(Label_date)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(733, 303)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1008, 687)
        Panel2.TabIndex = 22
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
        ' Label13
        ' 
        Label13.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(56, 273)
        Label13.Name = "Label13"
        Label13.Size = New Size(893, 381)
        Label13.TabIndex = 26
        Label13.Text = "Notice"
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
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(407, 154)
        Label11.Name = "Label11"
        Label11.Size = New Size(211, 39)
        Label11.TabIndex = 21
        Label11.Text = "Topic Name"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(611, 614)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(67, 62)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 30
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1793, 614)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(67, 62)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 24
        PictureBox4.TabStop = False
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
        ' Form3_notices
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label_notices)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "Form3_notices"
        Text = "Form3_notices"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(griha_logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_back As Button
    Friend WithEvents Button_notices As Button
    Friend WithEvents Button_Workers As Button
    Friend WithEvents Button_Expenses As Button
    Friend WithEvents Button_Property As Button
    Friend WithEvents button_resident As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label_notices As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_date As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents griha_logo As PictureBox
End Class
