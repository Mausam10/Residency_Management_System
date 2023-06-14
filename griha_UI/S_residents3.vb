Imports Microsoft.Data.SqlClient
Imports sytem.data

Public Class S_residents3
    Dim con As New SqlConnection("Data Source=LAPTOP-H5H6CH7L\PRASHANTSQL;Initial Catalog=griha;Integrated Security=True")

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
        con.Open()
        Dim query As String
        query = "insert into residents values('" & TextBox_username.Text & "','" & TextBox_password.Text & "','" & TextBox_firstname.Text & "','" & TextBox_middlename.Text & "','" & TextBox_lastname.Text & "','" & TextBox_email.Text & "','" & TextBox_apartmentid.Text & "',)"

        Dim cmd As SqlCommand = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("added")
        '    cmd.CommandType = System.Data.CommandType.Text
        '   Dim Username, Password As String
        '  Dim Firstname, MiddleName, LastName As String
        '  Dim PhoneNo1, PhoneNo2 As String
        ' Dim Email As String
        ''Dim apartmentID As Integer
        ' Username = TextBox_username.Text
        ' Password = TextBox_password.Text
        ' Firstname = TextBox_firstname.Text
        ' MiddleName = TextBox_middlename.Text
        ' LastName = TextBox_lastname.Text
        con.Close()
    End Sub

    Private Sub populate()
        con.Open()
        Dim query = "select * from residents"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataDVG.DataSource = ds.Tables
        con.Close()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataDVG.CellContentClick
        populate()
    End Sub
End Class