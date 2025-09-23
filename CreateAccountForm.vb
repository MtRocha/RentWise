Public Class CreateAccountForm

    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked

        Dim form As New Form1()
        Me.Hide()
        form.Show()

    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        Dim name As String = txtName.Text.Trim()
        Dim username As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(email) Then
            MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("E-mail inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If UsuarioExiste(username, email) Then
            MessageBox.Show("Usuário ou e-mail já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If InserirUsuario(name, username, password, email) Then
            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Form1.Show()
        Else
            MessageBox.Show("Erro ao cadastrar usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function InserirUsuario(name As String, username As String, password As String, email As String) As Boolean
        Try
            Dim user As New User()
            user.Name = name
            user.Password = password
            user.Email = email
            user.Role = 0 ' Defina o papel padrão conforme necessário

            Dim dao As New UserDAO()
            dao.Create(user)
            Return True
        Catch ex As Exception
            ' Opcional: log do erro
            Return False
        End Try
    End Function

    Private Function UsuarioExiste(username As String, email As String) As Boolean
        Dim dao As New UserDAO()
        Return dao.ExistsByUsernameOrEmail(username, email)
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

End Class