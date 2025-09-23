Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private WithEvents logoLabel As Label
    Private WithEvents titleLabel As Label
    Private WithEvents subtitleLabel As Label
    Private WithEvents emailLabel As Label
    Friend WithEvents txtEmail As TextBox
    Private WithEvents passwordLabel As Label
    Friend WithEvents txtPassword As MaskedTextBox
    Private WithEvents btnLogin As Button
    Private WithEvents linkRegister As LinkLabel
    Private WithEvents heroPanel As Panel
    Private WithEvents heroTitle As Label
    Private WithEvents heroDesc As Label

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        logoLabel = New Label()
        titleLabel = New Label()
        subtitleLabel = New Label()
        emailLabel = New Label()
        txtEmail = New TextBox()
        passwordLabel = New Label()
        txtPassword = New MaskedTextBox()
        btnLogin = New Button()
        linkRegister = New LinkLabel()
        heroPanel = New Panel()
        heroTitle = New Label()
        heroDesc = New Label()
        heroPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' logoLabel
        ' 
        logoLabel.AutoSize = True
        logoLabel.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        logoLabel.ForeColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        logoLabel.Location = New Point(80, 40)
        logoLabel.Name = "logoLabel"
        logoLabel.Size = New Size(257, 50)
        logoLabel.TabIndex = 0
        logoLabel.Text = "🏠 Rent Wise"
        ' 
        ' titleLabel
        ' 
        titleLabel.AutoSize = True
        titleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        titleLabel.Location = New Point(80, 90)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(294, 41)
        titleLabel.TabIndex = 1
        titleLabel.Text = "Bem-vindo de volta"
        ' 
        ' subtitleLabel
        ' 
        subtitleLabel.AutoSize = True
        subtitleLabel.ForeColor = Color.Gray
        subtitleLabel.Location = New Point(80, 130)
        subtitleLabel.Name = "subtitleLabel"
        subtitleLabel.Size = New Size(411, 23)
        subtitleLabel.TabIndex = 2
        subtitleLabel.Text = "Entre na sua conta para gerenciar suas propriedades"
        ' 
        ' emailLabel
        ' 
        emailLabel.Location = New Point(80, 174)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(100, 23)
        emailLabel.TabIndex = 3
        emailLabel.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(80, 200)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(300, 30)
        txtEmail.TabIndex = 4
        ' 
        ' passwordLabel
        ' 
        passwordLabel.Location = New Point(80, 244)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(100, 23)
        passwordLabel.TabIndex = 5
        passwordLabel.Text = "Senha"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(80, 270)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(300, 30)
        txtPassword.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(80, 370)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(300, 45)
        btnLogin.TabIndex = 9
        btnLogin.Text = "Entrar"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' linkRegister
        ' 
        linkRegister.LinkColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        linkRegister.Location = New Point(80, 430)
        linkRegister.Name = "linkRegister"
        linkRegister.Size = New Size(300, 23)
        linkRegister.TabIndex = 11
        linkRegister.TabStop = True
        linkRegister.Text = "Criar conta"
        linkRegister.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' heroPanel
        ' 
        heroPanel.BackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        heroPanel.Controls.Add(heroTitle)
        heroPanel.Controls.Add(heroDesc)
        heroPanel.Dock = DockStyle.Right
        heroPanel.Location = New Point(531, 0)
        heroPanel.Name = "heroPanel"
        heroPanel.Size = New Size(531, 509)
        heroPanel.TabIndex = 12
        ' 
        ' heroTitle
        ' 
        heroTitle.AutoSize = True
        heroTitle.FlatStyle = FlatStyle.System
        heroTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        heroTitle.ForeColor = Color.White
        heroTitle.Location = New Point(20, 45)
        heroTitle.Name = "heroTitle"
        heroTitle.Size = New Size(504, 32)
        heroTitle.TabIndex = 0
        heroTitle.Text = "Gerencie suas propriedades com facilidade"
        heroTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' heroDesc
        ' 
        heroDesc.ForeColor = Color.White
        heroDesc.Location = New Point(20, 100)
        heroDesc.Name = "heroDesc"
        heroDesc.Size = New Size(489, 60)
        heroDesc.TabIndex = 1
        heroDesc.Text = "Controle aluguéis, inquilinos e manutenções em um só lugar."
        ' 
        ' Form1
        ' 
        BackColor = Color.White
        ClientSize = New Size(1062, 509)
        Controls.Add(logoLabel)
        Controls.Add(titleLabel)
        Controls.Add(subtitleLabel)
        Controls.Add(emailLabel)
        Controls.Add(txtEmail)
        Controls.Add(passwordLabel)
        Controls.Add(txtPassword)
        Controls.Add(btnLogin)
        Controls.Add(linkRegister)
        Controls.Add(heroPanel)
        Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rent Wise - Login"
        heroPanel.ResumeLayout(False)
        heroPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
