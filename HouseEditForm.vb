Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq

Public Class HouseEditForm

    Friend _houseId = 0

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cep As String = txtPostCard.Text.Trim().Replace("-", "")
        If String.IsNullOrEmpty(cep) Then
            MessageBox.Show("Por favor, informe o CEP.")
            Return
        End If

        Dim url As String = $"https://viacep.com.br/ws/{cep}/json/"
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                response.EnsureSuccessStatusCode()
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim obj As JObject = JObject.Parse(json)

                If obj.ContainsKey("erro") AndAlso obj("erro").Value(Of Boolean)() Then
                    MessageBox.Show("CEP não encontrado.")
                    Return
                End If

                txtAddress.Text = obj("logradouro")?.ToString()
                txtDistrict.Text = obj("bairro")?.ToString()
                txtCity.Text = obj("localidade")?.ToString()
                txtState.Text = obj("uf")?.ToString()
            Catch ex As Exception
                MessageBox.Show("Erro ao buscar o endereço: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        HomeForm.lblUserName.Text = $"Olá, {UserSession.Nome}"
        HomeForm.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Not ValidarCampos() Then Return

        Try
            Dim rentValue As Decimal
            If Not Decimal.TryParse(numRentValue.Text.Trim(), rentValue) Then
                MessageBox.Show("Informe um valor de aluguel válido.")
                Return
            End If

            Dim houseNumber As Integer
            If Not Integer.TryParse(numNumber.Text.Trim(), houseNumber) Then
                MessageBox.Show("Informe um número válido.")
                Return
            End If

            Dim novaCasa As New House() With {
                    .Id = _houseId,
                    .Name = txtName.Text.Trim(),
                    .RentValue = rentValue,
                    .HouseImage = _caminhoImagem,
                    .PostCard = txtPostCard.Text.Trim().Replace("-", ""),
                    .HouseAddress = txtAddress.Text.Trim(),
                    .HouseNumber = houseNumber,
                    .District = txtDistrict.Text.Trim(),
                    .City = txtCity.Text.Trim(),
                    .State = txtState.Text.Trim(),
                    .IdUser = UserSession.Id
                    }

            Dim dao As New HouseDAO()
            dao.Update(novaCasa)

            MessageBox.Show("Casa Alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            HomeForm.LoadItems()
            HomeForm.Show()
        Catch ex As Exception
            MessageBox.Show("Erro ao Editar casa: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Informe o nome da casa.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(numRentValue.Text) OrElse Not Decimal.TryParse(numRentValue.Text, Nothing) Then
            MessageBox.Show("Informe um valor de aluguel válido.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(_caminhoImagem) Then
            MessageBox.Show("Informe o caminho da imagem da casa.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtPostCard.Text) Then
            MessageBox.Show("Informe o CEP.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Informe o endereço.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(numNumber.Text) OrElse Not Integer.TryParse(numNumber.Text, Nothing) Then
            MessageBox.Show("Informe o número da casa válido.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtDistrict.Text) Then
            MessageBox.Show("Informe o bairro.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtCity.Text) Then
            MessageBox.Show("Informe a cidade.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtState.Text) Then
            MessageBox.Show("Informe o estado.")
            Return False
        End If
        Return True
    End Function

    Friend _caminhoImagem As String = ""

    Private Sub picHouse_Click(sender As Object, e As EventArgs) Handles picHouse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.gif"
            If ofd.ShowDialog() = DialogResult.OK Then
                picHouse.Image = Image.FromFile(ofd.FileName)
                _caminhoImagem = ofd.FileName ' <-- salvar caminho
            End If
        End Using
    End Sub

End Class