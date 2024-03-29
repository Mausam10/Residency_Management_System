﻿Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class grihaDb
    Shared con As SqlConnection
    Shared cmd As SqlCommand
    Shared sda As SqlDataAdapter
    Shared dt As DataTable
    Shared cb As ComboBox
    Shared reader As SqlDataReader
    Shared Sub connect()
        Dim connectionString As String = "Data Source=LAPTOP-390QHVCB;Initial Catalog=griha;Integrated Security=True;TrustServerCertificate=True"
        con = New SqlConnection(connectionString)
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
            MsgBox("Server Connection Error!! Please try again or restart the Application.")
            Return False
        End Try
    End Function

    Shared Function generateTable(ByVal sqlQuery As String, Optional ByRef check As Integer = 1) As DataTable
        sda = New SqlDataAdapter
        dt = New DataTable
        Try
            cmd = New SqlCommand(sqlQuery, con)
            con.Open()
            sda.SelectCommand = cmd
            sda.Fill(dt)
            con.Close()
            check = 1
            Return dt

        Catch ex As Exception
            con.Close()
            MsgBox("Database Server Error!! Please try again or restart the Application.")
            dt = Nothing
            check = 0
            Return dt
        End Try

    End Function


    Shared Function generateComboBox(ByVal sqlQuery As String, ByVal columnName As String) As ComboBox
        cb = New ComboBox

        Try
            cmd = New SqlCommand(sqlQuery, con)
            con.Open()
            reader = cmd.ExecuteReader
            While reader.Read
                Dim value = reader.GetString(columnName)
                cb.Items.Add(value)
            End While
            con.Close()
            Return cb
        Catch ex As Exception
            con.Close()
            MsgBox("Server Error!! Please try again or restart the Application.")
            cb = Nothing
            Return cb
        End Try

    End Function



End Class
