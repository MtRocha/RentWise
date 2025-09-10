Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.Storage

Public Class HouseDAO

    Function GetAll(userId As Integer) As List(Of House)
        Try
            Dim query As String = $"SELECT * FROM TBL_HOUSES WHERE USER_ID = @userId"
            Dim parameters As List(Of SqlParameter)
            parameters.Add(New SqlParameter("@userId", userId))
            Dim houses As DataTable = HelperDAO.ExecuteQuery(query, parameters)
            Dim list As List(Of House)

            For Each row In houses.Rows
                list.Add(MapObject(row))
            Next

            Return list


        Catch ex As Exception

        End Try
    End Function

    Function GetById(houseId As Integer) As House
        Try
            Dim query As String = $"SELECT * FROM TBL_HOUSES WHERE USER_ID = @houseId"
            Dim parameters As List(Of SqlParameter)
            parameters.Add(New SqlParameter("@houseId", houseId))

            Dim houses As DataTable = HelperDAO.ExecuteQuery(query, parameters)

            Dim list As List(Of House)

            If (houses.Rows.Count = 0) Then
                Return Nothing
            End If

            Return MapObject(houses.Rows(0))

        Catch ex As Exception

        End Try
    End Function

    Function Create(model As House)
        Try
            Dim query As String = "
                INSERT INTO [dbo].[tb_house] 
                    ([name], [rent_value], [house_image], [post_card], [house_address], 
                     [house_number], [district], [city], [state], [id_user])
                VALUES 
                    (@Name, @RentValue, @HouseImage, @PostCard, @HouseAddress, 
                     @HouseNumber, @District, @City, @State, @IdUser)
            "
            Dim parameters = MapTable(model)

            HelperDAO.ExecuteNonQuery(query, parameters)

        Catch ex As Exception

        End Try
    End Function

    Function Update(model As House)

        Try
            Dim query As String = "
                UPDATE [dbo].[tb_house]
                SET 
                    [name] = @Name,
                    [rent_value] = @RentValue,
                    [house_image] = @HouseImage,
                    [post_card] = @PostCard,
                    [house_address] = @HouseAddress,
                    [house_number] = @HouseNumber,
                    [district] = @District,
                    [city] = @City,
                    [state] = @State,
                    [id_user] = @IdUser
                WHERE [id] = @Id
            "

            Dim parameters = MapTable(model)

            HelperDAO.ExecuteNonQuery(query, parameters)

        Catch ex As Exception

        End Try

    End Function

    Function Delete(houseId As Integer)
        Try
            Dim query = "DELETE TB_HOUSE WHERE ID = @ID"
            Dim parameters As List(Of SqlParameter)
            parameters.Add(New SqlParameter("@ID", houseId))

            HelperDAO.ExecuteNonQuery(query, parameters)

        Catch ex As Exception

        End Try
    End Function

    Function MapObject(dr As DataRow) As House

        Try
            Dim house As New House()

            house.Id = If(dr("id"), 0)
            house.Name = If(dr("name"), String.Empty)
            house.RentValue = If(dr("rent_value"), 0.0)
            house.HouseImage = If(dr("house_image"), Nothing)
            house.PostCard = If(dr("post_card"), 0)
            house.HouseAddress = If(dr("house_address"), String.Empty)
            house.HouseNumber = If(dr("house_number"), 0)
            house.District = If(dr("district"), String.Empty)
            house.City = If(dr("city"), String.Empty)
            house.State = If(dr("state"), String.Empty)

            Return house

        Catch ex As Exception

        End Try

    End Function

    Private Function MapTable(house As House) As List(Of SqlParameter)

        Dim parameters = New List(Of SqlParameter)

        parameters.Add(New SqlParameter("@Name", house.Name))
        parameters.Add(New SqlParameter("@RentValue", house.RentValue))
        parameters.Add(New SqlParameter("@HouseImage", house.HouseImage))
        parameters.Add(New SqlParameter("@PostCard", house.PostCard))
        parameters.Add(New SqlParameter("@HouseAddress", house.HouseAddress))
        parameters.Add(New SqlParameter("@HouseNumber", house.HouseNumber))
        parameters.Add(New SqlParameter("@District", house.District))
        parameters.Add(New SqlParameter("@City", house.City))
        parameters.Add(New SqlParameter("@State", house.State))
        parameters.Add(New SqlParameter("@IdUser", house.Id))

        Return parameters


    End Function

End Class
