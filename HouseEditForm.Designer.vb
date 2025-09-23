<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HouseEditForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblName = New Label()
        txtName = New TextBox()
        lblRentValue = New Label()
        numRentValue = New NumericUpDown()
        lblPostCard = New Label()
        txtPostCard = New MaskedTextBox()
        lblAddress = New Label()
        txtAddress = New TextBox()
        lblNumber = New Label()
        numNumber = New NumericUpDown()
        lblDistrict = New Label()
        txtDistrict = New TextBox()
        lblCity = New Label()
        txtCity = New TextBox()
        lblState = New Label()
        lblImage = New Label()
        picHouse = New PictureBox()
        btnCancel = New Button()
        btnSubmit = New Button()
        Button1 = New Button()
        txtState = New TextBox()
        CType(numRentValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(numNumber, ComponentModel.ISupportInitialize).BeginInit()
        CType(picHouse, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(109, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Editar Casa"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(20, 60)
        lblName.Name = "lblName"
        lblName.Size = New Size(123, 15)
        lblName.TabIndex = 1
        lblName.Text = "Nome da Propriedade"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(20, 80)
        txtName.Name = "txtName"
        txtName.Size = New Size(350, 23)
        txtName.TabIndex = 2
        ' 
        ' lblRentValue
        ' 
        lblRentValue.AutoSize = True
        lblRentValue.Location = New Point(400, 60)
        lblRentValue.Name = "lblRentValue"
        lblRentValue.Size = New Size(118, 15)
        lblRentValue.TabIndex = 3
        lblRentValue.Text = "Valor do Aluguel (R$)"
        ' 
        ' numRentValue
        ' 
        numRentValue.DecimalPlaces = 2
        numRentValue.Location = New Point(400, 80)
        numRentValue.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numRentValue.Name = "numRentValue"
        numRentValue.Size = New Size(120, 23)
        numRentValue.TabIndex = 4
        ' 
        ' lblPostCard
        ' 
        lblPostCard.AutoSize = True
        lblPostCard.Location = New Point(20, 120)
        lblPostCard.Name = "lblPostCard"
        lblPostCard.Size = New Size(28, 15)
        lblPostCard.TabIndex = 5
        lblPostCard.Text = "CEP"
        ' 
        ' txtPostCard
        ' 
        txtPostCard.Location = New Point(20, 140)
        txtPostCard.Mask = "00000-000"
        txtPostCard.Name = "txtPostCard"
        txtPostCard.Size = New Size(100, 23)
        txtPostCard.TabIndex = 6
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(194, 120)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(56, 15)
        lblAddress.TabIndex = 7
        lblAddress.Text = "Endereço"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(194, 138)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(380, 23)
        txtAddress.TabIndex = 8
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Location = New Point(580, 120)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(51, 15)
        lblNumber.TabIndex = 9
        lblNumber.Text = "Número"
        ' 
        ' numNumber
        ' 
        numNumber.Location = New Point(580, 138)
        numNumber.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        numNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numNumber.Name = "numNumber"
        numNumber.Size = New Size(80, 23)
        numNumber.TabIndex = 10
        numNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblDistrict
        ' 
        lblDistrict.AutoSize = True
        lblDistrict.Location = New Point(20, 180)
        lblDistrict.Name = "lblDistrict"
        lblDistrict.Size = New Size(38, 15)
        lblDistrict.TabIndex = 11
        lblDistrict.Text = "Bairro"
        ' 
        ' txtDistrict
        ' 
        txtDistrict.Location = New Point(20, 200)
        txtDistrict.Name = "txtDistrict"
        txtDistrict.Size = New Size(200, 23)
        txtDistrict.TabIndex = 12
        ' 
        ' lblCity
        ' 
        lblCity.AutoSize = True
        lblCity.Location = New Point(240, 180)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(44, 15)
        lblCity.TabIndex = 13
        lblCity.Text = "Cidade"
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(240, 200)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(200, 23)
        txtCity.TabIndex = 14
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.Location = New Point(500, 180)
        lblState.Name = "lblState"
        lblState.Size = New Size(42, 15)
        lblState.TabIndex = 15
        lblState.Text = "Estado"
        ' 
        ' lblImage
        ' 
        lblImage.AutoSize = True
        lblImage.Location = New Point(20, 240)
        lblImage.Name = "lblImage"
        lblImage.Size = New Size(134, 15)
        lblImage.TabIndex = 17
        lblImage.Text = "Imagem da Propriedade"
        ' 
        ' picHouse
        ' 
        picHouse.BackColor = Color.White
        picHouse.BackgroundImage = My.Resources.Resources.home
        picHouse.BackgroundImageLayout = ImageLayout.Stretch
        picHouse.BorderStyle = BorderStyle.FixedSingle
        picHouse.ErrorImage = Nothing
        picHouse.InitialImage = Nothing
        picHouse.Location = New Point(20, 260)
        picHouse.Name = "picHouse"
        picHouse.Size = New Size(200, 150)
        picHouse.SizeMode = PictureBoxSizeMode.StretchImage
        picHouse.TabIndex = 18
        picHouse.TabStop = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(460, 380)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(100, 30)
        btnCancel.TabIndex = 20
        btnCancel.Text = "Cancelar"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(580, 380)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(120, 30)
        btnSubmit.TabIndex = 21
        btnSubmit.Text = "Editar"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.magnifying_glass
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(126, 140)
        Button1.Name = "Button1"
        Button1.Size = New Size(28, 23)
        Button1.TabIndex = 22
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtState
        ' 
        txtState.Location = New Point(500, 200)
        txtState.Name = "txtState"
        txtState.Size = New Size(200, 23)
        txtState.TabIndex = 23
        ' 
        ' HouseEditForm
        ' 
        ClientSize = New Size(720, 450)
        Controls.Add(txtState)
        Controls.Add(Button1)
        Controls.Add(lblTitle)
        Controls.Add(lblName)
        Controls.Add(txtName)
        Controls.Add(lblRentValue)
        Controls.Add(numRentValue)
        Controls.Add(lblPostCard)
        Controls.Add(txtPostCard)
        Controls.Add(lblAddress)
        Controls.Add(txtAddress)
        Controls.Add(lblNumber)
        Controls.Add(numNumber)
        Controls.Add(lblDistrict)
        Controls.Add(txtDistrict)
        Controls.Add(lblCity)
        Controls.Add(txtCity)
        Controls.Add(lblState)
        Controls.Add(lblImage)
        Controls.Add(picHouse)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Name = "HouseEditForm"
        Text = "Editar Casa"
        CType(numRentValue, ComponentModel.ISupportInitialize).EndInit()
        CType(numNumber, ComponentModel.ISupportInitialize).EndInit()
        CType(picHouse, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblRentValue As Label
    Friend WithEvents numRentValue As NumericUpDown
    Friend WithEvents lblPostCard As Label
    Friend WithEvents txtPostCard As MaskedTextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents numNumber As NumericUpDown
    Friend WithEvents lblDistrict As Label
    Friend WithEvents txtDistrict As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents lblImage As Label
    Friend WithEvents picHouse As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtState As TextBox
End Class
