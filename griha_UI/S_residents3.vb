Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class S_residents3
    Dim query As String
    Dim tempDt As DataTable

    Private Sub Button_Events_Click(sender As Object, e As EventArgs) Handles Button_Events.Click
        Me.Hide()
        S_events3.Show()
    End Sub

    Private Sub Button_Expenses_Click(sender As Object, e As EventArgs) Handles Button_Expenses.Click
        Me.Hide()
        S_expenses3.Show()
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub Button_Workers_Click(sender As Object, e As EventArgs) Handles Button_Workers.Click
        Me.Hide()
        S_workers3.Show()
    End Sub

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        S_notices3.Show()
    End Sub

    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click

        Dim Username As String
        Dim Password, First_Name, Middle_Name, Last_Name, Phone1, Phone2, Email, Apartment_id As String
        Username = TextBox_username.Text
        Password = TextBox_password.Text
        First_Name = TextBox_firstname.Text
        Middle_Name = TextBox_middlename.Text
        Last_Name = TextBox_lastname.Text
        Phone1 = TextBox_phoneno.Text
        Phone2 = TextBox_phoneno2.Text
        Email = TextBox_email.Text
        Apartment_id = TextBox_apartmentid.Text

        query = "Insert into residents(Username,Password,First_Name,Middle_Name, Last_Name, Phone1, Phone2, Email, Apartment_id) values('" & Username & "', ' " & Password & " ' ,' " & First_Name & " ',' " & Middle_Name & " ',' " & Last_Name & " ',' " & Phone1 & " ' ,' " & Phone2 & " ',' " & Email & " ',' " & Apartment_id & " ')"
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Added")
        End If
        populate()


    End Sub

    Private Sub populate()
        query = "select * from residents"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            MsgBox("No record")

        Else
            DataDVG.DataSource = tempDt
        End If

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataDVG.CellContentClick
        populate()
    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click

    End Sub

    Private Sub S_residents3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class