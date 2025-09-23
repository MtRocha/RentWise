Imports System.IO

Public Class HomeForm

    Public Sub AdicionarHouseCard(house As House)
        Dim card As New Panel()
        card.Width = 300
        card.Height = 300
        card.BackColor = Color.White
        card.Margin = New Padding(10)
        card.Padding = New Padding(5)
        card.BorderStyle = BorderStyle.FixedSingle
        card.Tag = house

        ' Imagem
        Dim img As New PictureBox()
        img.Width = card.Width - 10
        img.Height = 150
        img.Top = 0
        img.Left = 0
        img.SizeMode = PictureBoxSizeMode.StretchImage
        If File.Exists(house.HouseImage) Then
            img.Image = Image.FromFile(house.HouseImage)
        End If
        card.Controls.Add(img)

        ' Nome
        Dim lblName As New Label()
        lblName.Text = house.Name
        lblName.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblName.AutoSize = False
        lblName.Width = card.Width - 10
        lblName.Height = 25
        lblName.Top = img.Bottom + 5
        lblName.Left = 5
        card.Controls.Add(lblName)

        ' Aluguel
        Dim lblRent As New Label()
        lblRent.Text = $"R$ {house.RentValue:F2}"
        lblRent.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        lblRent.AutoSize = False
        lblRent.Width = card.Width - 10
        lblRent.Height = 20
        lblRent.Top = lblName.Bottom + 2
        lblRent.Left = 5
        card.Controls.Add(lblRent)

        ' Endereço
        Dim lblAddress As New Label()
        lblAddress.Text = $"{house.HouseAddress}, {house.HouseNumber} - {house.District}, {house.City}/{house.State}"
        lblAddress.Font = New Font("Segoe UI", 9, FontStyle.Italic)
        lblAddress.AutoSize = False
        lblAddress.Width = card.Width - 10
        lblAddress.Height = 40
        lblAddress.Top = lblRent.Bottom + 2
        lblAddress.Left = 5
        lblAddress.MaximumSize = New Size(card.Width - 10, 40)
        lblAddress.TextAlign = ContentAlignment.TopLeft
        card.Controls.Add(lblAddress)

        ' Botões
        Dim panelButtons As New Panel()
        panelButtons.Width = card.Width
        panelButtons.Height = 35
        panelButtons.Top = lblAddress.Bottom + 5
        panelButtons.Left = 0
        panelButtons.BackColor = Color.FromArgb(245, 245, 245)

        Dim btnEdit As New Button()
        btnEdit.Text = "Editar"
        btnEdit.BackColor = Color.FromArgb(124, 58, 237)
        btnEdit.ForeColor = Color.White
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.Width = 70
        AddHandler btnEdit.Click, Sub(s, e) EditarCasa(house)
        panelButtons.Controls.Add(btnEdit)

        Dim btnDelete As New Button()
        btnDelete.Text = "Excluir"
        btnDelete.BackColor = Color.FromArgb(239, 68, 68)
        btnDelete.ForeColor = Color.White
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.Width = 70
        btnDelete.Left = btnEdit.Right + 10
        AddHandler btnDelete.Click, Sub(s, e) ExcluirCasa(house, card)
        panelButtons.Controls.Add(btnDelete)

        card.Controls.Add(panelButtons)

        ' Adiciona ao FlowLayoutPanel
        flowCards.Controls.Add(card)
    End Sub

    ' Métodos exemplo para edição e exclusão
    Private Sub EditarCasa(house As House)
        Dim frmEdit As New HouseEditForm()

        ' Preenche os campos do formulário com os dados da casa
        frmEdit.txtName.Text = house.Name
        frmEdit.numRentValue.Value = CDec(house.RentValue)
        frmEdit.txtPostCard.Text = house.PostCard
        frmEdit.txtAddress.Text = house.HouseAddress
        frmEdit.numNumber.Value = CDec(house.HouseNumber)
        frmEdit.txtDistrict.Text = house.District
        frmEdit.txtCity.Text = house.City
        frmEdit.txtState.Text = house.State
        frmEdit._houseId = house.Id
        frmEdit._caminhoImagem = house.HouseImage

        ' Carrega a imagem, se existir
        If Not String.IsNullOrEmpty(house.HouseImage) AndAlso IO.File.Exists(house.HouseImage) Then
            frmEdit.picHouse.Image = Image.FromFile(house.HouseImage)
        End If

        ' Altera o título e o texto do botão para indicar edição
        frmEdit.lblTitle.Text = "Editar Casa"
        frmEdit.btnSubmit.Text = "Salvar Alterações"

        ' Exibe o formulário como diálogo
        frmEdit.ShowDialog()
    End Sub

    Private Sub ExcluirCasa(house As House, card As Panel)
        If MessageBox.Show($"Deseja realmente excluir {house.Name}?", "Excluir", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Remover do banco
            Dim dao As New HouseDAO()
            dao.Delete(house.Id)
            ' Remover do FlowPanel
            flowCards.Controls.Remove(card)
        End If
    End Sub

    Private Sub HomeForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadItems()
    End Sub

    Friend Sub LoadItems()
        lblUserName.Text = $"Olá, {UserSession.Nome}"
        flowCards.Controls.Clear()
        Try
            Dim dao As New HouseDAO()
            Dim houses As List(Of House) = dao.GetAll(UserSession.Id)
            For Each house As House In houses
                AdicionarHouseCard(house)
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar casas: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnNewHouse_Click(sender As Object, e As EventArgs) Handles BtnNewHouse.Click
        Me.Hide()
        HouseHelperForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        UserSession.Nome = ""
        UserSession.Email = ""
        UserSession.Id = 0
        Form1.Name = ""
        Form1.txtEmail.Text = ""
        Form1.txtPassword.Text = ""
        Form1.Show()
    End Sub

End Class