<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_UI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_UI))
        login_panel = New Panel()
        Button1 = New Button()
        Login_Guard = New Button()
        Login_resident = New Button()
        Username_textbox = New TextBox()
        Login_secretary = New Button()
        Password_label = New Label()
        Password_textbox = New TextBox()
        griha_logo = New PictureBox()
        Username_label = New Label()
        login_panel.SuspendLayout()
        CType(griha_logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' login_panel
        ' 
        login_panel.BackColor = Color.Transparent
        login_panel.BorderStyle = BorderStyle.Fixed3D
        login_panel.Controls.Add(Button1)
        login_panel.Controls.Add(Login_Guard)
        login_panel.Controls.Add(Login_resident)
        login_panel.Controls.Add(Username_textbox)
        login_panel.Controls.Add(Login_secretary)
        login_panel.Controls.Add(Password_label)
        login_panel.Controls.Add(Password_textbox)
        login_panel.Controls.Add(griha_logo)
        login_panel.Controls.Add(Username_label)
        login_panel.Font = New Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        login_panel.Location = New Point(626, 247)
        login_panel.Name = "login_panel"
        login_panel.Size = New Size(661, 538)
        login_panel.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(611, 279)
        Button1.Name = "Button1"
        Button1.Size = New Size(13, 17)
        Button1.TabIndex = 10
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Login_Guard
        ' 
        Login_Guard.BackColor = Color.Teal
        Login_Guard.BackgroundImageLayout = ImageLayout.None
        Login_Guard.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Login_Guard.ForeColor = Color.White
        Login_Guard.Location = New Point(222, 467)
        Login_Guard.Name = "Login_Guard"
        Login_Guard.Size = New Size(248, 43)
        Login_Guard.TabIndex = 9
        Login_Guard.Text = "Log In as Guard"
        Login_Guard.UseVisualStyleBackColor = False
        ' 
        ' Login_resident
        ' 
        Login_resident.BackColor = Color.MidnightBlue
        Login_resident.BackgroundImageLayout = ImageLayout.None
        Login_resident.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Login_resident.ForeColor = Color.White
        Login_resident.Location = New Point(222, 343)
        Login_resident.Name = "Login_resident"
        Login_resident.Size = New Size(248, 43)
        Login_resident.TabIndex = 7
        Login_resident.Text = "Log In"
        Login_resident.UseVisualStyleBackColor = False
        ' 
        ' Username_textbox
        ' 
        Username_textbox.BackColor = SystemColors.Menu
        Username_textbox.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point)
        Username_textbox.ForeColor = SystemColors.WindowText
        Username_textbox.Location = New Point(367, 198)
        Username_textbox.Name = "Username_textbox"
        Username_textbox.PlaceholderText = "username@123"
        Username_textbox.Size = New Size(268, 38)
        Username_textbox.TabIndex = 6
        ' 
        ' Login_secretary
        ' 
        Login_secretary.BackColor = Color.Teal
        Login_secretary.BackgroundImageLayout = ImageLayout.None
        Login_secretary.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Login_secretary.ForeColor = Color.White
        Login_secretary.Location = New Point(222, 405)
        Login_secretary.Name = "Login_secretary"
        Login_secretary.Size = New Size(248, 43)
        Login_secretary.TabIndex = 5
        Login_secretary.Text = "Log In as Secretary" & vbCrLf
        Login_secretary.UseVisualStyleBackColor = False
        ' 
        ' Password_label
        ' 
        Password_label.AutoSize = True
        Password_label.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Password_label.ForeColor = Color.Teal
        Password_label.Location = New Point(128, 269)
        Password_label.Name = "Password_label"
        Password_label.Size = New Size(146, 32)
        Password_label.TabIndex = 4
        Password_label.Text = "Password"
        ' 
        ' Password_textbox
        ' 
        Password_textbox.BackColor = SystemColors.Menu
        Password_textbox.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Password_textbox.ForeColor = SystemColors.WindowFrame
        Password_textbox.Location = New Point(366, 269)
        Password_textbox.Name = "Password_textbox"
        Password_textbox.PlaceholderText = "password"
        Password_textbox.Size = New Size(268, 38)
        Password_textbox.TabIndex = 3
        Password_textbox.UseSystemPasswordChar = True
        ' 
        ' griha_logo
        ' 
        griha_logo.BorderStyle = BorderStyle.Fixed3D
        griha_logo.Image = CType(resources.GetObject("griha_logo.Image"), Image)
        griha_logo.Location = New Point(3, 3)
        griha_logo.Name = "griha_logo"
        griha_logo.Size = New Size(345, 158)
        griha_logo.SizeMode = PictureBoxSizeMode.CenterImage
        griha_logo.TabIndex = 2
        griha_logo.TabStop = False
        ' 
        ' Username_label
        ' 
        Username_label.AutoSize = True
        Username_label.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Username_label.ForeColor = Color.Teal
        Username_label.Location = New Point(124, 195)
        Username_label.Name = "Username_label"
        Username_label.Size = New Size(152, 32)
        Username_label.TabIndex = 0
        Username_label.Text = "Username"
        ' 
        ' Form_UI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1902, 1033)
        Controls.Add(login_panel)
        DoubleBuffered = True
        Name = "Form_UI"
        Text = "Form_UI"
        login_panel.ResumeLayout(False)
        login_panel.PerformLayout()
        CType(griha_logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents login_panel As Panel
    Friend WithEvents Username_label As Label
    Friend WithEvents griha_logo As PictureBox
    Friend WithEvents Login_secretary As Button
    Friend WithEvents Password_label As Label
    Friend WithEvents Password_textbox As TextBox
    Friend WithEvents Username_textbox As TextBox
    Friend WithEvents Login_resident As Button
    Friend WithEvents Login_Guard As Button
    Friend WithEvents Button1 As Button
End Class
