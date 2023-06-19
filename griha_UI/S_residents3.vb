Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class S_residents3
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
        Dim con As SqlConnection
        Dim cmd As SqlCommand = New SqlCommand
        con = New SqlConnection("Data Source=LAPTOP-390QHVCB;Initial Catalog=griha;Integrated Security=True;TrustServerCertificate=True")
        cmd.CommandType = System.Data.CommandType.Text

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
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Insert into residents(Username,Password,First_Name,Middle_Name, Last_Name, Phone1, Phone2, Email, Apartment_id) values(@Username,@Password,@First_Name,@Middle_Name,@Last_Name,@phone1,@phone2,@email,@Apartment_id)"
        cmd.Parameters.AddWithValue("@Username", Username)
        cmd.Parameters.AddWithValue("@Password", Password)
        cmd.Parameters.AddWithValue("@First_Name", First_Name)
        cmd.Parameters.AddWithValue("@Middle_Name", Middle_Name)
        cmd.Parameters.AddWithValue("@Last_Name", Last_Name)
        cmd.Parameters.AddWithValue("@Phone1", Phone1)
        cmd.Parameters.AddWithValue("@Phone2", Phone2)
        cmd.Parameters.AddWithValue("@Email", Email)
        cmd.Parameters.AddWithValue("@Apartment_id", Apartment_id)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully added")
        populate()
    End Sub

    Private Sub populate()
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=LAPTOP-390QHVCB;Initial Catalog=griha;Integrated Security=True;TrustServerCertificate=True")
        con.Open()
        Dim query = "select * from residents"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataDVG.DataSource = ds.Tables(0)
        con.Close()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataDVG.CellContentClick
        populate()
    End Sub
End Class