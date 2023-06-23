Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class S_residents3
    Dim query As String
    Dim tempDt As DataTable
    Dim tempGen As String
    Dim tempUsername As String
    Private Sub checkRadioButton(ByVal gen As String)
        If gen = "Male" Then
            RadioButton1.Checked = True
        ElseIf gen = "Female" Then
            RadioButton2.Checked = True
        ElseIf gen = "Other" Then
            RadioButton3.Checked = True
        End If
    End Sub

    Private Sub addToDatabase()
        Dim Username As String
        Dim Password, First_Name, Middle_Name, Last_Name, Gender, Phone1, Phone2, Email, Apartment_id As String
        Username = TextBox_username.Text
        Password = TextBox_password.Text
        First_Name = TextBox_firstname.Text
        Middle_Name = TextBox_middlename.Text
        Last_Name = TextBox_lastname.Text
        Gender = tempGen
        Phone1 = TextBox_phoneno.Text
        Phone2 = TextBox_phoneno2.Text
        Email = TextBox_email.Text
        Apartment_id = TextBox_apartmentid.Text

        query = "Insert into residents(Username,Password,First_Name,Middle_Name, Last_Name,Gender, Phone1, Phone2, Email, Apartment_id) values('" & Username & "', '" & Password & "' ,'" & First_Name & "','" & Middle_Name & "','" & Last_Name & "','" & Gender & "','" & Phone1 & "' ,'" & Phone2 & "','" & Email & "','" & Apartment_id & "')"
        If (grihaDb.executeMySql(query)) Then
        End If

    End Sub

    Private Sub reset()
        TextBox_username.Text = Nothing
        TextBox_password.Text = Nothing
        TextBox_firstname.Text = Nothing
        TextBox_middlename.Text = Nothing
        TextBox_lastname.Text = Nothing
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        TextBox_phoneno.Text = Nothing
        TextBox_phoneno2.Text = Nothing
        TextBox_email.Text = Nothing
        TextBox_apartmentid.Text = Nothing
    End Sub


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
        addToDatabase()
        MsgBox("Record Added")
        reset()
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
    Private Sub dataGridView1_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataDVG.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataDVG.Rows(e.RowIndex)
            TextBox_username.Text = row.Cells(0).Value.ToString
            TextBox_password.Text = row.Cells(1).Value.ToString
            TextBox_firstname.Text = row.Cells(2).Value.ToString
            TextBox_middlename.Text = row.Cells(3).Value.ToString
            TextBox_lastname.Text = row.Cells(4).Value.ToString
            checkRadioButton(row.Cells(5).Value.ToString)    'for gender
            TextBox_phoneno.Text = row.Cells(6).Value.ToString
            TextBox_phoneno2.Text = row.Cells(7).Value.ToString
            TextBox_email.Text = row.Cells(8).Value.ToString
            TextBox_apartmentid.Text = row.Cells(9).Value.ToString
            tempUsername = TextBox_username.Text 'selected user's username 
        End If

    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click

    End Sub

    Private Sub S_residents3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        query = " DELETE FROM Residents WHERE Username='" & tempUsername & "' "
        grihaDb.executeMySql(query)
        addToDatabase()
        MsgBox("UserInfo successfully edited.")
        reset()
        populate()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        tempGen = RadioButton1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        tempGen = RadioButton2.Text
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        tempGen = RadioButton3.Text
    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        query = " DELETE FROM Residents WHERE Username='" & TextBox_username.Text & "' "
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            reset()
            populate()
        End If
    End Sub
End Class