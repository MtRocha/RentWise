Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim hr = New HouseDAO()

            Dim model = New House()

            model.Name = txt_name.Text
            model.RentValue = txt_rent_value.Text
            model.HouseImage = img_house
            model.PostCard = txt_paste_code.Text.Replace("-", "")
            model.HouseAddress = txt_address.Text
            model.HouseNumber = txt_number.Text
            model.District = txt_district.Text
            model.City = txt_city.Text
            model.State = txt_state.Text


            hr.Create(model)

            MsgBox("Imóvel cadastrado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CADASTRO DE IMÓVEL")
        Catch ex As Exception
            MsgBox($"Falha na conexão {ex.Message} ", MsgBoxStyle.Critical, "CADASTRO DE CLIENTE")
        End Try
    End Sub
End Class
