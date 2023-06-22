Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class grihaDb
    Shared con As SqlConnection
    Shared cmd As SqlCommand
    Shared sda As SqlDataAdapter
    Shared dt As DataTable

    Shared Sub connect()
        con = New SqlConnection("Data Source=LAPTOP-H5H6CH7L\PRASHANTSQL;Initial Catalog=griha;Integrated Security=True;TrustServerCertificate=True")
    End Sub

    Shared Function executeMySql(ByVal sqlQuery As String) As Boolean
        Try
            cmd = New SqlCommand(sqlQuery, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Return True

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Shared Function generateTable(ByVal sqlQuery As String) As DataTable
        sda = New SqlDataAdapter
        dt = New DataTable
        Try
            cmd = New SqlCommand(sqlQuery, con)
            con.Open()
            sda.SelectCommand = cmd
            sda.Fill(dt)
            con.Close()
            Return dt

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
            dt = Nothing
            Return dt
        End Try

    End Function



End Class
