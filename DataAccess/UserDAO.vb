Imports Microsoft.Data.SqlClient

Public Class UserDAO

    Public Function ExistsByUsernameOrEmail(username As String, email As String) As Boolean
        Try
            Dim query As String = "SELECT * FROM Tbl_Users WHERE UserName = @UserName"
            Dim parameters As New List(Of SqlParameter) From {
                    New SqlParameter("@UserName", email)
                    }
            Dim result = HelperDAO.ExecuteQuery(query, parameters)
            Dim final As Int32 = result.Rows.Count
            Return If(final > 0, True, False)
        Catch ex As Exception
            Throw New Exception("Erro em ExistsByUsernameOrEmail: " & ex.Message, ex)
        End Try
    End Function

    Function GetAll() As List(Of User)
        Try
            Dim query As String = "SELECT * FROM Tbl_Users"
            Dim users As DataTable = HelperDAO.ExecuteQuery(query, Nothing)

            Dim list As New List(Of User)

            For Each row As DataRow In users.Rows
                list.Add(MapObject(row))
            Next

            Return list
        Catch ex As Exception
            Throw New Exception("Erro em GetAll: " & ex.Message, ex)
        End Try
    End Function

    Function GetById(userId As Integer) As User
        Try
            Dim query As String = "SELECT * FROM Tbl_Users WHERE Id = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", userId)
            }

            Dim users As DataTable = HelperDAO.ExecuteQuery(query, parameters)

            If users.Rows.Count = 0 Then
                Return Nothing
            End If

            Return MapObject(users.Rows(0))
        Catch ex As Exception
            Throw New Exception("Erro em GetById: " & ex.Message, ex)
        End Try
    End Function

    Function VerifyPassword(username As String, password As String) As Boolean

        Try
            Dim query As String = "SELECT * FROM Tbl_Users WHERE UserName = @UserName AND PassWord = @PassWord"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@UserName", username),
                New SqlParameter("@PassWord", password)
            }
            Dim users As DataTable = HelperDAO.ExecuteQuery(query, parameters)
            If users.Rows.Count = 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw New Exception("Erro em VerifyPassword: " & ex.Message, ex)
        End Try
    End Function

    Function GetByPassword(username As String, password As String) As User

        Try
            Dim query As String = "SELECT * FROM Tbl_Users WHERE UserName = @UserName AND PassWord = @PassWord"
            Dim parameters As New List(Of SqlParameter) From {
                    New SqlParameter("@UserName", username),
                    New SqlParameter("@PassWord", password)
                    }
            Dim users As DataTable = HelperDAO.ExecuteQuery(query, parameters)
            If users.Rows.Count = 0 Then
                Return Nothing
            End If
            Return MapObject(users.Rows(0))
        Catch ex As Exception
            Throw New Exception("Erro em VerifyPassword: " & ex.Message, ex)
        End Try
    End Function

    Public Function IsAdminById(userId As Integer) As Boolean
        Try
            Dim query As String = "SELECT Role FROM Tbl_Users WHERE Id = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", userId)
            }

            Dim dt As DataTable = HelperDAO.ExecuteQuery(query, parameters)
            If dt.Rows.Count = 0 Then Return False

            Dim roleValue As String = If(IsDBNull(dt.Rows(0)("Role")), "", dt.Rows(0)("Role").ToString().Trim())

            Dim roleInt As Integer
            If Integer.TryParse(roleValue, roleInt) Then
                Return roleInt = 1
            End If

            Return roleValue = "1"
        Catch ex As Exception
            Throw New Exception("Erro em IsAdminById: " & ex.Message, ex)
        End Try
    End Function

    Public Function GetNormalUsers() As List(Of User)
        Try
            Dim query As String = "SELECT * FROM Tbl_Users WHERE ISNULL(Role, '0') <> '1'"
            Dim users As DataTable = HelperDAO.ExecuteQuery(query, Nothing)

            Dim list As New List(Of User)
            For Each row As DataRow In users.Rows
                list.Add(MapObject(row))
            Next

            Return list
        Catch ex As Exception
            Throw New Exception("Erro em GetNormalUsers: " & ex.Message, ex)
        End Try
    End Function

    Sub Create(model As User)
        Try
            Dim query As String = "
                INSERT INTO [dbo].[Tbl_Users]
                    ([Name], [PassWord], [UserName], [Role])
                VALUES
                    (@Name, @PassWord, @UserName, @Role)
            "

            Dim parameters = MapTable(model)
            HelperDAO.ExecuteNonQuery(query, parameters)
        Catch ex As Exception
            Throw New Exception("Erro em Create: " & ex.Message, ex)
        End Try
    End Sub

    Sub Update(model As User)
        Try
            Dim query As String = "
                UPDATE [dbo].[Tbl_Users]
                SET
                    [Name] = @Name,
                    [PassWord] = @PassWord,
                    [UserName] = @UserName,
                    [Role] = @Role
                WHERE [Id] = @Id
            "

            Dim parameters = MapTable(model)
            parameters.Add(New SqlParameter("@Id", model.Id))

            HelperDAO.ExecuteNonQuery(query, parameters)
        Catch ex As Exception
            Throw New Exception("Erro em Update: " & ex.Message, ex)
        End Try
    End Sub

    Sub Delete(userId As Integer)
        Try
            Dim query = "DELETE FROM Tbl_Users WHERE Id = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", userId)
            }

            HelperDAO.ExecuteNonQuery(query, parameters)
        Catch ex As Exception
            Throw New Exception("Erro em Delete: " & ex.Message, ex)
        End Try
    End Sub

    Function MapObject(dr As DataRow) As User
        Try
            Dim user As New User()

            user.Id = If(IsDBNull(dr("Id")), 0, Convert.ToInt32(dr("Id")))
            user.Name = If(IsDBNull(dr("Name")), String.Empty, dr("Name").ToString())
            user.Password = If(IsDBNull(dr("PassWord")), String.Empty, dr("PassWord").ToString())
            user.Email = If(IsDBNull(dr("UserName")), String.Empty, dr("UserName").ToString())
            user.Role = If(IsDBNull(dr("Role")), String.Empty, dr("Role").ToString())

            Return user
        Catch ex As Exception
            Throw New Exception("Erro em MapObject: " & ex.Message, ex)
        End Try
    End Function

    Private Function MapTable(user As User) As List(Of SqlParameter)
        Dim parameters = New List(Of SqlParameter) From {
            New SqlParameter("@Name", user.Name),
            New SqlParameter("@PassWord", user.Password),
            New SqlParameter("@UserName", user.Email),
            New SqlParameter("@Role", user.Role)
        }

        Return parameters
    End Function

End Class