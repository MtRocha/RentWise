Imports System.IO
Imports System.ComponentModel

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

        flowCards.Controls.Add(card)
    End Sub

    Private Sub EditarCasa(house As House)
        Dim frmEdit As New HouseEditForm()

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

        If Not String.IsNullOrEmpty(house.HouseImage) AndAlso IO.File.Exists(house.HouseImage) Then
            frmEdit.picHouse.Image = Image.FromFile(house.HouseImage)
        End If

        frmEdit.lblTitle.Text = "Editar Casa"
        frmEdit.btnSubmit.Text = "Salvar Alterações"

        frmEdit.ShowDialog()
    End Sub

    Private Sub ExcluirCasa(house As House, card As Panel)
        If MessageBox.Show($"Deseja realmente excluir {house.Name}?", "Excluir", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim dao As New HouseDAO()
            dao.Delete(house.Id)
            flowCards.Controls.Remove(card)
        End If
    End Sub

    Private Sub HomeForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadItems()
        SetupAdminUIIfNeeded()
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

    ' -------- Admin ---------
    Private btnManage As Button
    Private panelAdmin As Panel
    Private gridUsers As DataGridView

    Private Sub SetupAdminUIIfNeeded()
        Try
            Dim udao As New UserDAO()
            If udao.IsAdminById(UserSession.Id) Then
                EnsureManageButton()
            End If
        Catch ex As Exception
            ' ignore
        End Try
    End Sub

    Private Sub EnsureManageButton()
        If btnManage Is Nothing Then
            btnManage = New Button()
            btnManage.Text = "Gerenciar Painéis"
            btnManage.Width = 150
            btnManage.Height = 30
            btnManage.BackColor = Color.White
            btnManage.FlatStyle = FlatStyle.Flat
            btnManage.FlatAppearance.BorderSize = 0
            btnManage.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnManage.Top = 15
            btnManage.Left = Math.Max(10, BtnNewHouse.Left - btnManage.Width - 10)
            AddHandler btnManage.Click, AddressOf OnManageClick
            PanelHeader.Controls.Add(btnManage)
            btnManage.BringToFront()
        End If
    End Sub

    Private Sub OnManageClick(sender As Object, e As EventArgs)
        If panelAdmin Is Nothing Then
            CreateAdminPanel()
        End If

        panelAdmin.Visible = Not panelAdmin.Visible
        If panelAdmin.Visible Then
            LoadNormalUsersIntoGrid()
            panelAdmin.BringToFront()
        End If
    End Sub

    Private Sub CreateAdminPanel()
        panelAdmin = New Panel()
        panelAdmin.Visible = False
        panelAdmin.BackColor = Color.White
        panelAdmin.BorderStyle = BorderStyle.FixedSingle
        panelAdmin.Left = 10
        panelAdmin.Top = 60 ' abaixo do header
        panelAdmin.Width = Me.ClientSize.Width - 20
        panelAdmin.Height = Math.Max(200, CInt(Me.ClientSize.Height * 0.45))
        panelAdmin.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom Or AnchorStyles.Top

        Dim lbl As New Label()
        lbl.Text = "Usuários (não administradores)"
        lbl.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lbl.AutoSize = True
        lbl.Left = 10
        lbl.Top = 10
        panelAdmin.Controls.Add(lbl)

        gridUsers = New DataGridView()
        gridUsers.Left = 10
        gridUsers.Top = lbl.Bottom + 8
        gridUsers.Width = panelAdmin.Width - 20
        gridUsers.Height = panelAdmin.Height - gridUsers.Top - 10
        gridUsers.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Bottom
        gridUsers.AutoGenerateColumns = False
        gridUsers.AllowUserToAddRows = False
        gridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gridUsers.MultiSelect = False
        gridUsers.RowHeadersVisible = False
        gridUsers.BackgroundColor = Color.White

        Dim colId As New DataGridViewTextBoxColumn()
        colId.HeaderText = "Id"
        colId.DataPropertyName = "Id"
        colId.ReadOnly = True
        colId.Width = 60

        Dim colName As New DataGridViewTextBoxColumn()
        colName.HeaderText = "Nome"
        colName.DataPropertyName = "Name"
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Dim colEmail As New DataGridViewTextBoxColumn()
        colEmail.HeaderText = "Email"
        colEmail.DataPropertyName = "Email"
        colEmail.Width = 180

        Dim colPass As New DataGridViewTextBoxColumn()
        colPass.HeaderText = "Senha"
        colPass.DataPropertyName = "Password"
        colPass.Width = 120

        Dim colRole As New DataGridViewTextBoxColumn()
        colRole.HeaderText = "Role"
        colRole.DataPropertyName = "Role"
        colRole.Width = 70

        Dim colSave As New DataGridViewButtonColumn()
        colSave.Name = "colSave"
        colSave.HeaderText = "Salvar"
        colSave.Text = "Salvar"
        colSave.UseColumnTextForButtonValue = True
        colSave.Width = 80

        Dim colDelete As New DataGridViewButtonColumn()
        colDelete.Name = "colDelete"
        colDelete.HeaderText = "Excluir"
        colDelete.Text = "Excluir"
        colDelete.UseColumnTextForButtonValue = True
        colDelete.Width = 80

        gridUsers.Columns.AddRange(New DataGridViewColumn() {colId, colName, colEmail, colPass, colRole, colSave, colDelete})
        AddHandler gridUsers.CellContentClick, AddressOf gridUsers_CellContentClick

        panelAdmin.Controls.Add(gridUsers)
        Me.Controls.Add(panelAdmin)
    End Sub

    Private Sub LoadNormalUsersIntoGrid()
        Try
            Dim dao As New UserDAO()
            Dim users As List(Of User) = dao.GetNormalUsers()
            gridUsers.DataSource = New BindingList(Of User)(users)
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar usuários: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gridUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return
        If TypeOf gridUsers.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            Dim user As User = TryCast(gridUsers.Rows(e.RowIndex).DataBoundItem, User)
            If user Is Nothing Then Return

            Dim colName = gridUsers.Columns(e.ColumnIndex).Name
            Dim dao As New UserDAO()

            If colName = "colSave" Then
                Try
                    dao.Update(user)
                    MessageBox.Show("Usuário atualizado com sucesso.")
                Catch ex As Exception
                    MessageBox.Show("Erro ao atualizar usuário: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf colName = "colDelete" Then
                If MessageBox.Show($"Deseja realmente excluir o usuário {user.Name}?", "Excluir Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        dao.Delete(user.Id)
                        Dim list = TryCast(gridUsers.DataSource, BindingList(Of User))
                        If list IsNot Nothing Then
                            list.Remove(user)
                        Else
                            gridUsers.Rows.RemoveAt(e.RowIndex)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Erro ao excluir usuário: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
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