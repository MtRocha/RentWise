Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Controle declarados
    Private txt_name As TextBox
    Private txt_address As TextBox
    Private txt_state As TextBox
    Private txt_city As TextBox
    Private txt_district As TextBox
    Private Button2 As Button
    Private Label1 As Label
    Private img_house As PictureBox
    Private txt_paste_code As MaskedTextBox
    Private txt_rent_value As MaskedTextBox

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        txt_name = New TextBox()
        txt_address = New TextBox()
        txt_state = New TextBox()
        txt_city = New TextBox()
        txt_district = New TextBox()
        Button2 = New Button()
        Label1 = New Label()
        img_house = New PictureBox()
        txt_paste_code = New MaskedTextBox()
        txt_rent_value = New MaskedTextBox()
        txt_number = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        CType(img_house, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(276, 48)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(422, 23)
        txt_name.TabIndex = 1
        ' 
        ' txt_address
        ' 
        txt_address.Location = New Point(276, 264)
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(350, 23)
        txt_address.TabIndex = 2
        ' 
        ' txt_state
        ' 
        txt_state.Location = New Point(10, 316)
        txt_state.Name = "txt_state"
        txt_state.Size = New Size(243, 23)
        txt_state.TabIndex = 3
        ' 
        ' txt_city
        ' 
        txt_city.Location = New Point(276, 316)
        txt_city.Name = "txt_city"
        txt_city.Size = New Size(198, 23)
        txt_city.TabIndex = 4
        ' 
        ' txt_district
        ' 
        txt_district.Location = New Point(501, 316)
        txt_district.Name = "txt_district"
        txt_district.Size = New Size(197, 23)
        txt_district.TabIndex = 5
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
        ' img_house
        ' 
        img_house.Image = CType(resources.GetObject("img_house.Image"), Image)
        img_house.Location = New Point(12, 47)
        img_house.Name = "img_house"
        img_house.Size = New Size(221, 180)
        img_house.SizeMode = PictureBoxSizeMode.StretchImage
        img_house.TabIndex = 0
        img_house.TabStop = False
        ' 
        ' txt_paste_code
        ' 
        txt_paste_code.Location = New Point(10, 264)
        txt_paste_code.Mask = "00000-000"
        txt_paste_code.Name = "txt_paste_code"
        txt_paste_code.Size = New Size(243, 23)
        txt_paste_code.TabIndex = 9
        ' 
        ' txt_rent_value
        ' 
        txt_rent_value.Location = New Point(276, 90)
        txt_rent_value.Mask = "$00000,00"
        txt_rent_value.Name = "txt_rent_value"
        txt_rent_value.Size = New Size(422, 23)
        txt_rent_value.TabIndex = 10
        ' 
        ' txt_number
        ' 
        txt_number.Location = New Point(632, 264)
        txt_number.Name = "txt_number"
        txt_number.Size = New Size(66, 23)
        txt_number.TabIndex = 11
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
        ' Button1
        ' 
        Button1.Location = New Point(499, 367)
        Button1.Name = "Button1"
        Button1.Size = New Size(199, 49)
        Button1.TabIndex = 19
        Button1.Text = "Cancelar"
        ' 
        ' Form1
        ' 
        ClientSize = New Size(708, 437)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_number)
        Controls.Add(img_house)
        Controls.Add(txt_name)
        Controls.Add(txt_address)
        Controls.Add(txt_state)
        Controls.Add(txt_city)
        Controls.Add(txt_district)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(txt_paste_code)
        Controls.Add(txt_rent_value)
        Name = "Form1"
        Text = "Gerenciamento de Aluguéis"
        CType(img_house, ComponentModel.ISupportInitialize).EndInit()
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

    Private WithEvents txt_number As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Button1 As Button
End Class
