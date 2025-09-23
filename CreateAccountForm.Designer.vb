Partial Class CreateAccountForm
    Inherits Form

    Private WithEvents lblTitle As Label
    Private WithEvents lblSubtitle As Label
    Private WithEvents txtName As TextBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtConfirmPassword As TextBox
    Private WithEvents btnCadastrar As Button
    Private WithEvents linkLogin As LinkLabel

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblSubtitle = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        btnCadastrar = New Button()
        linkLogin = New LinkLabel()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(43, 29)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(143, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Criar Conta"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblSubtitle.ForeColor = Color.DimGray
        lblSubtitle.Location = New Point(43, 70)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(354, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Cadastre-se para começar a gerenciar suas propriedades"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(120, 120)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Digite seu nome completo"
        txtName.Size = New Size(350, 25)
        txtName.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(120, 170)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Digite seu email"
        txtEmail.Size = New Size(350, 25)
        txtEmail.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(120, 220)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Digite sua senha"
        txtPassword.Size = New Size(350, 25)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(120, 270)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Confirme sua senha"
        txtConfirmPassword.Size = New Size(350, 25)
        txtConfirmPassword.TabIndex = 5
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' btnCadastrar
        ' 
        btnCadastrar.Location = New Point(120, 327)
        btnCadastrar.Name = "btnCadastrar"
        btnCadastrar.Size = New Size(350, 40)
        btnCadastrar.TabIndex = 7
        btnCadastrar.Text = "Criar Conta"
        ' 
        ' linkLogin
        ' 
        linkLogin.AutoSize = True
        linkLogin.Location = New Point(168, 381)
        linkLogin.Name = "linkLogin"
        linkLogin.Size = New Size(194, 19)
        linkLogin.TabIndex = 8
        linkLogin.TabStop = True
        linkLogin.Text = "Já tem uma conta? Fazer login"
        ' 
        ' CreateAccountForm
        ' 
        BackColor = Color.White
        ClientSize = New Size(580, 553)
        Controls.Add(lblTitle)
        Controls.Add(lblSubtitle)
        Controls.Add(txtName)
        Controls.Add(txtEmail)
        Controls.Add(txtPassword)
        Controls.Add(txtConfirmPassword)
        Controls.Add(btnCadastrar)
        Controls.Add(linkLogin)
        Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "CreateAccountForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastro - Rent Wise"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub EstilizarBotao(botao As Button, corFundo As Color, corFonte As Color)
        botao.FlatStyle = FlatStyle.Flat
        botao.BackColor = corFundo
        botao.ForeColor = corFonte
        botao.FlatAppearance.BorderSize = 0
        botao.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        botao.Cursor = Cursors.Hand
    End Sub
End Class
