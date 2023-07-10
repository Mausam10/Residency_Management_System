<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_property
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3_property))
        Panel1 = New Panel()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Expenses = New Button()
        Button_Property = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label_property = New Label()
        Panel2 = New Panel()
        Label_description = New Label()
        Label_area = New Label()
        Label10 = New Label()
        Label_floor = New Label()
        Label8 = New Label()
        Label_bhk = New Label()
        Label6 = New Label()
        Label_ownedBy = New Label()
        Label4 = New Label()
        griha_logo = New PictureBox()
        Label_apartmentID = New Label()
        Label14 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
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
        Panel1.TabIndex = 15
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
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(504, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(390, 228)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label_property
        ' 
        Label_property.AutoSize = True
        Label_property.BackColor = Color.Transparent
        Label_property.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label_property.Location = New Point(1055, 182)
        Label_property.Name = "Label_property"
        Label_property.Size = New Size(401, 46)
        Label_property.TabIndex = 17
        Label_property.Text = "Property Information"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Label_description)
        Panel2.Controls.Add(Label_area)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label_floor)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label_bhk)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label_ownedBy)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(griha_logo)
        Panel2.Controls.Add(Label_apartmentID)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(754, 279)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1008, 687)
        Panel2.TabIndex = 32
        ' 
        ' Label_description
        ' 
        Label_description.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_description.ForeColor = Color.Black
        Label_description.Location = New Point(56, 488)
        Label_description.Name = "Label_description"
        Label_description.Size = New Size(923, 186)
        Label_description.TabIndex = 39
        ' 
        ' Label_area
        ' 
        Label_area.AutoSize = True
        Label_area.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_area.ForeColor = Color.Black
        Label_area.Location = New Point(335, 271)
        Label_area.Name = "Label_area"
        Label_area.Size = New Size(78, 29)
        Label_area.TabIndex = 38
        Label_area.Text = "NULL"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(56, 271)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 29)
        Label10.TabIndex = 37
        Label10.Text = "Area:"
        ' 
        ' Label_floor
        ' 
        Label_floor.AutoSize = True
        Label_floor.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_floor.ForeColor = Color.Black
        Label_floor.Location = New Point(335, 327)
        Label_floor.Name = "Label_floor"
        Label_floor.Size = New Size(78, 29)
        Label_floor.TabIndex = 36
        Label_floor.Text = "NULL"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(56, 327)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 29)
        Label8.TabIndex = 35
        Label8.Text = "Floor:"
        ' 
        ' Label_bhk
        ' 
        Label_bhk.AutoSize = True
        Label_bhk.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_bhk.ForeColor = Color.Black
        Label_bhk.Location = New Point(335, 381)
        Label_bhk.Name = "Label_bhk"
        Label_bhk.Size = New Size(78, 29)
        Label_bhk.TabIndex = 34
        Label_bhk.Text = "NULL"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(56, 381)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 29)
        Label6.TabIndex = 33
        Label6.Text = "BHK:"
        ' 
        ' Label_ownedBy
        ' 
        Label_ownedBy.AutoSize = True
        Label_ownedBy.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_ownedBy.ForeColor = Color.Black
        Label_ownedBy.Location = New Point(335, 437)
        Label_ownedBy.Name = "Label_ownedBy"
        Label_ownedBy.Size = New Size(78, 29)
        Label_ownedBy.TabIndex = 32
        Label_ownedBy.Text = "NULL"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(56, 437)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 29)
        Label4.TabIndex = 31
        Label4.Text = "Owned By:"
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
        ' Label_apartmentID
        ' 
        Label_apartmentID.AutoSize = True
        Label_apartmentID.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_apartmentID.ForeColor = Color.Black
        Label_apartmentID.Location = New Point(335, 219)
        Label_apartmentID.Name = "Label_apartmentID"
        Label_apartmentID.Size = New Size(78, 29)
        Label_apartmentID.TabIndex = 29
        Label_apartmentID.Text = "NULL"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(56, 219)
        Label14.Name = "Label14"
        Label14.Size = New Size(170, 29)
        Label14.TabIndex = 28
        Label14.Text = "Apartment ID:"
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
        ' Form3_property
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel2)
        Controls.Add(Label_property)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "Form3_property"
        Text = "Form3_property"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_property As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents griha_logo As PictureBox
    Friend WithEvents Label_apartmentID As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_area As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label_floor As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label_bhk As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_ownedBy As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_description As Label
End Class
