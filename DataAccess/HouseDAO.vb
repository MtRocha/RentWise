Imports Microsoft.Data.SqlClient

Public Class HouseDAO

    Function GetAll(userId As Integer) As List(Of House)
        Try
            Dim query As String = "SELECT * FROM TBL_HOUSES WHERE USER_ID = @userId"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@userId", userId)
            }

            Dim houses As DataTable = HelperDAO.ExecuteQuery(query, parameters)
            Dim list As New List(Of House)

            For Each row As DataRow In houses.Rows
                list.Add(MapObject(row))
            Next

            Return list
        Catch ex As Exception
            Throw New Exception("Erro em GetAll: " & ex.Message, ex)
        End Try
    End Function

    Function GetById(houseId As Integer) As House
        Try
            Dim query As String = "SELECT * FROM TBL_HOUSES WHERE ID = @houseId"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@houseId", houseId)
            }

            Dim houses As DataTable = HelperDAO.ExecuteQuery(query, parameters)

            If houses.Rows.Count = 0 Then
                Return Nothing
            End If

            Return MapObject(houses.Rows(0))
        Catch ex As Exception
            Throw New Exception("Erro em GetById: " & ex.Message, ex)
        End Try
    End Function

    Sub Create(model As House)
        Try
            Dim query As String = "
                INSERT INTO [dbo].[tbl_houses]
                    ([name], [rentValue], [houseImage], [postcard], [houseAddress],
                     [houseNumber], [district], [city], [state], [User_id])
                VALUES
                    (@Name, @RentValue, @HouseImage, @PostCard, @HouseAddress,
                     @HouseNumber, @District, @City, @State, @IdUser)
            "
            Dim parameters = MapTable(model)
            HelperDAO.ExecuteNonQuery(query, parameters)
        Catch ex As Exception
            Throw New Exception("Erro em Create: " & ex.Message, ex)
        End Try
    End Sub

    Sub Update(model As House)
        Try
            Dim query As String = "
                UPDATE [dbo].[tbl_houses]
                SET
                    [name] = @Name,
                    [rentValue] = @RentValue,
                    [houseImage] = @HouseImage,
                    [postcard] = @PostCard,
                    [houseAddress] = @HouseAddress,
                    [houseNumber] = @HouseNumber,
                    [district] = @District,
                    [city] = @City,
                    [state] = @State,
                    [user_id] = @IdUser
                WHERE [id] = @Id
            "
            Dim parameters = MapTable(model)
            parameters.Add(New SqlParameter("@Id", model.Id))

            HelperDAO.ExecuteNonQuery(query, parameters)
        Catch ex As Exception
            Throw New Exception("Erro em Update: " & ex.Message, ex)
        End Try
    End Sub

    Sub Delete(houseId As Integer)
        Try
            Dim query = "DELETE FROM TBl_HOUSEs WHERE ID = @ID"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@ID", houseId)
            }

            HelperDAO.ExecuteNonQuery(query, parameters)
        Catch ex As Exception
            Throw New Exception("Erro em Delete: " & ex.Message, ex)
        End Try
    End Sub

    Function MapObject(dr As DataRow) As House
        Try
            Dim house As New House()

            house.Id = If(IsDBNull(dr("id")), 0, Convert.ToInt32(dr("id")))
            house.Name = If(IsDBNull(dr("name")), String.Empty, dr("name").ToString())
            house.RentValue = If(IsDBNull(dr("rentvalue")), 0D, Convert.ToDecimal(dr("rentvalue")))
            house.HouseImage = If(IsDBNull(dr("houseimage")), Nothing, dr("houseimage"))
            house.PostCard = If(IsDBNull(dr("postcard")), String.Empty, dr("postcard").ToString())
            house.HouseAddress = If(IsDBNull(dr("houseaddress")), String.Empty, dr("houseaddress").ToString())
            house.HouseNumber = If(IsDBNull(dr("housenumber")), 0, Convert.ToInt32(dr("housenumber")))
            house.District = If(IsDBNull(dr("district")), String.Empty, dr("district").ToString())
            house.City = If(IsDBNull(dr("city")), String.Empty, dr("city").ToString())
            house.State = If(IsDBNull(dr("state")), String.Empty, dr("state").ToString())
            house.IdUser = If(IsDBNull(dr("user_id")), 0, Convert.ToInt32(dr("user_id")))

            Return house
        Catch ex As Exception
            Throw New Exception("Erro em MapObject: " & ex.Message, ex)
        End Try
    End Function

    Private Function MapTable(house As House) As List(Of SqlParameter)
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("@Name", house.Name),
            New SqlParameter("@RentValue", house.RentValue),
            New SqlParameter("@HouseImage", house.HouseImage),
            New SqlParameter("@PostCard", house.PostCard),
            New SqlParameter("@HouseAddress", house.HouseAddress),
            New SqlParameter("@HouseNumber", house.HouseNumber),
            New SqlParameter("@District", house.District),
            New SqlParameter("@City", house.City),
            New SqlParameter("@State", house.State),
            New SqlParameter("@IdUser", house.IdUser)
        }

        Return parameters
    End Function

End Class