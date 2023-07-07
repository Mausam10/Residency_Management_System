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
        TextBox_ID = New TextBox()
        Button_delete = New Button()
        Button_Update = New Button()
        Button_add = New Button()
        Information_label = New Label()
        TextBox_description = New TextBox()
        TextBox_Name = New TextBox()
        Panel3 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
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
        PictureBox1.Location = New Point(502, 0)
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
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(TextBox_ID)
        Panel2.Controls.Add(Button_delete)
        Panel2.Controls.Add(Button_Update)
        Panel2.Controls.Add(Button_add)
        Panel2.Controls.Add(Information_label)
        Panel2.Controls.Add(TextBox_description)
        Panel2.Controls.Add(TextBox_Name)
        Panel2.Location = New Point(515, 260)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 768)
        Panel2.TabIndex = 18
        ' 
        ' TextBox_ID
        ' 
        TextBox_ID.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_ID.Location = New Point(11, 75)
        TextBox_ID.Name = "TextBox_ID"
        TextBox_ID.PlaceholderText = "Apartment ID"
        TextBox_ID.Size = New Size(446, 34)
        TextBox_ID.TabIndex = 18
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
        Button_Update.Text = "EDIT"
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
        Button_add.Text = "ADD PROPERTY"
        Button_add.UseVisualStyleBackColor = False
        ' 
        ' Information_label
        ' 
        Information_label.AutoSize = True
        Information_label.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Information_label.ForeColor = Color.Teal
        Information_label.Location = New Point(11, 12)
        Information_label.Name = "Information_label"
        Information_label.Size = New Size(201, 32)
        Information_label.TabIndex = 9
        Information_label.Text = "Your Property"
        ' 
        ' TextBox_description
        ' 
        TextBox_description.BackColor = SystemColors.HighlightText
        TextBox_description.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_description.ForeColor = SystemColors.ControlDarkDark
        TextBox_description.Location = New Point(11, 198)
        TextBox_description.Multiline = True
        TextBox_description.Name = "TextBox_description"
        TextBox_description.PlaceholderText = "Amenities of Apartment"
        TextBox_description.Size = New Size(446, 249)
        TextBox_description.TabIndex = 7
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Name.Location = New Point(11, 137)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.PlaceholderText = "Owner Name"
        TextBox_Name.Size = New Size(446, 34)
        TextBox_Name.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(997, 260)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(907, 768)
        Panel3.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(13, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 32)
        Label1.TabIndex = 19
        Label1.Text = "Residency Apartment Info:"
        ' 
        ' Form3_property
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel3)
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
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
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
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_add As Button
    Friend WithEvents Information_label As Label
    Friend WithEvents TextBox_description As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
