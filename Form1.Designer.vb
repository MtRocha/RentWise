Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Controle declarados
    Private TextBox1 As TextBox
    Private TextBox2 As TextBox
    Private TextBox3 As TextBox
    Private TextBox6 As TextBox
    Private TextBox7 As TextBox
    Private Button1 As Button
    Private Button2 As Button
    Private Label1 As Label
    Private PictureBox1 As PictureBox
    Private MaskedTextBox1 As MaskedTextBox
    Private MaskedTextBox2 As MaskedTextBox

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        MaskedTextBox1 = New MaskedTextBox()
        MaskedTextBox2 = New MaskedTextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(276, 48)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(422, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(276, 264)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(350, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(10, 316)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(243, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(276, 316)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(198, 23)
        TextBox6.TabIndex = 4
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(501, 316)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(197, 23)
        TextBox7.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(499, 367)
        Button1.Name = "Button1"
        Button1.Size = New Size(199, 49)
        Button1.TabIndex = 6
        Button1.Text = "Salvar"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(276, 367)
        Button2.Name = "Button2"
        Button2.Size = New Size(199, 49)
        Button2.TabIndex = 7
        Button2.Text = "Cancelar"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(276, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 8
        Label1.Text = "Aluguel"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(221, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(10, 264)
        MaskedTextBox1.Mask = "00000-000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(243, 23)
        MaskedTextBox1.TabIndex = 9
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Location = New Point(276, 90)
        MaskedTextBox2.Mask = "$00000,00"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(422, 23)
        MaskedTextBox2.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(632, 264)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(66, 23)
        TextBox4.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(276, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 15)
        Label2.TabIndex = 12
        Label2.Text = "Valor do Aluguel"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(10, 246)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 15)
        Label3.TabIndex = 13
        Label3.Text = "Código Postal - CEP"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(10, 298)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 15)
        Label4.TabIndex = 14
        Label4.Text = "Estado"
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(276, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 15)
        Label5.TabIndex = 15
        Label5.Text = "Cidade"
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(501, 298)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 15)
        Label6.TabIndex = 16
        Label6.Text = "Bairro"
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(276, 246)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 15)
        Label7.TabIndex = 17
        Label7.Text = "Endereço"
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(632, 246)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 15)
        Label8.TabIndex = 18
        Label8.Text = "N°"
        ' 
        ' Form1
        ' 
        ClientSize = New Size(708, 437)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox4)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox6)
        Controls.Add(TextBox7)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(MaskedTextBox1)
        Controls.Add(MaskedTextBox2)
        Name = "Form1"
        Text = "Gerenciamento de Aluguéis"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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

    Private WithEvents TextBox4 As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label8 As Label
End Class
