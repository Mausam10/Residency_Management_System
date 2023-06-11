<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_secretary
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_secretary))
        Panel1 = New Panel()
        Button_back = New Button()
        Button_notices = New Button()
        Button_Workers = New Button()
        Button_Expenses = New Button()
        Button_Events = New Button()
        button_resident = New Button()
        PictureBox2 = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label_Welcome = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 1080)
        Panel1.TabIndex = 0
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
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(501, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 209)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Metropolis Extra Bold", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(715, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 40)
        Label1.TabIndex = 5
        Label1.Text = "Secretary"
        ' 
        ' Label_Welcome
        ' 
        Label_Welcome.AutoSize = True
        Label_Welcome.BackColor = Color.Transparent
        Label_Welcome.Font = New Font("Metropolis Black", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label_Welcome.ForeColor = Color.Azure
        Label_Welcome.Location = New Point(960, 540)
        Label_Welcome.Name = "Label_Welcome"
        Label_Welcome.Size = New Size(427, 80)
        Label_Welcome.TabIndex = 6
        Label_Welcome.Text = "Welcome "
        ' 
        ' Form_secretary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label_Welcome)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form_secretary"
        Text = "Form_secretary"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents button_resident As Button
    Friend WithEvents Button_Workers As Button
    Friend WithEvents Button_Expenses As Button
    Friend WithEvents Button_Events As Button
    Friend WithEvents Button_notices As Button
    Friend WithEvents Label_Welcome As Label
    Friend WithEvents Button_back As Button
End Class
