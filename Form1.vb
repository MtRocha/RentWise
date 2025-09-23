Imports System.IO

Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = _txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text

        If ValidarLogin(username, password) Then
            Dim dao As New UserDAO()
            Dim user As User = dao.GetByPassword(username, password)
            Dim homeForm As New HomeForm()
            homeForm.lblUserName.Text = "Olá " + user.Name
            Me.Hide()
            UserSession.Id = user.Id
            UserSession.Nome = user.Name
            UserSession.Email = user.Email
            homeForm.Show()
        Else
            MessageBox.Show("Usuário ou senha incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidarLogin(username As String, password As String) As Boolean
        Try
            Dim dao As New UserDAO()
            Return dao.VerifyPassword(txtEmail.Text, txtPassword.Text)
        Catch ex As Exception
            MessageBox.Show("Erro ao validar login: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub linkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegister.LinkClicked
        Dim form As New CreateAccountForm()
        Me.Hide()
        form.Show()

    End Sub

End Class