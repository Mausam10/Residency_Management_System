﻿Public Class Form3_view_Residents
    Dim tempdt As DataTable
    Dim query As String
    Private Sub populate()
        query = "SELECT ISNULL(First_Name,'') + ' ' + ISNULL(Middle_Name,'')  + ' ' + ISNULL(Last_Name,'') AS 'Full Name', Phone1, Phone2 , Apartment_id from Residents "
        tempdt = grihaDb.generateTable(query)
        If (tempdt Is Nothing) Then
            MsgBox("No record")

        Else
            ' DataGridResidents.DataSource = tempdt
        End If

    End Sub


    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click

    End Sub

    Private Sub Button_Property_Click(sender As Object, e As EventArgs) Handles Button_Property.Click
        Me.Hide()
        Form3_property.Show()

    End Sub

    Private Sub Button_Expenses_Click(sender As Object, e As EventArgs) Handles Button_Expenses.Click
        Me.Hide()
        Form3_Expenses.Show()

    End Sub

    Private Sub Button_Workers_Click(sender As Object, e As EventArgs) Handles Button_Workers.Click
        Me.Hide()
        Form3_workers.Show()

    End Sub

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        Form3_notices.Show()

    End Sub


    Private Sub Form3_view_Residents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
    End Sub

End Class