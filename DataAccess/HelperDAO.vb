Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class HelperDAO
    Private Shared ReadOnly connString As String = "Server=LAB5-05; Database=RentWise; Integrated Security=True; TrustServerCertificate=True"

    Public Shared Function ExecuteQuery(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param As SqlParameter In parameters
                        cmd.Parameters.Add(param)
                    Next
                End If
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Shared Function ExecuteNonQuery(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As Integer
        Dim rowsAffected As Integer = 0

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param As SqlParameter In parameters
                        cmd.Parameters.Add(param)
                    Next
                End If

                conn.Open()

                rowsAffected = cmd.ExecuteNonQuery()
            End Using
        End Using

        Return rowsAffected
    End Function
End Class
