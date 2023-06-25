Public Class G_visitors3
    Dim query As String
    Dim tempDt As DataTable
    Dim tempGen As String
    Dim tempUsername As String

    Private Function addToDatabase() As Integer

        Dim First_Name, Middle_Name, Last_Name, Phone1, Phone2 As String
        Dim entry_time, exit_time As Date
        Dim Purpose As String
        First_Name = TextBox_firstname.Text
        Middle_Name = TextBox_middlename.Text
        Last_Name = TextBox_lastname.Text
        Phone1 = TextBox_phone1.Text
        Phone2 = TextBox_phone2.Text
        entry_time = DateTimePicker1.Text
        exit_time = DateTimePicker2.Text
        Purpose = TextBox_purpose.Text
        query = "Insert into Visitors (First_Name,Middle_Name, Last_Name, Phone1, Phone2, Entry_time, Exit_time, Purpose) values('" & First_Name & "','" & Middle_Name & "','" & Last_Name & "','" & Phone1 & "' ,'" & Phone2 & "','" & entry_time & "','" & exit_time & "','" & Purpose & "')"
        If (grihaDb.executeMySql(query)) Then
            Return 1 'success
        End If
        Return -1 'insert operation failed

    End Function

    Private Sub populate()
        query = "select * from Visitors"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            MsgBox("No record")

        Else
            DGV_visitors.DataSource = tempDt
        End If

    End Sub



    Private Sub G_visitors3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        Me.Hide()
        G_residents3.Show()
    End Sub

    Private Sub Button_Workers_Click(sender As Object, e As EventArgs) Handles Button_Workers.Click
        Me.Hide()
        G_workers3.Show()
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        G_notices3.Show()
    End Sub

    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click

        If (addToDatabase() = 1) Then
            MsgBox("Record successfully Added")
            Reset()
            populate()
        Else
            MsgBox("Error. Please check and try again.")
        End If

    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click

        'delete from visitors where (first_name = 'Rajesh' and phone1 = '9825123321' and purpose = 'friends meetup') 

        query = " DELETE FROM Residents WHERE (First_name='" & TextBox_firstname.Text & "' and Phone1='" & TextBox_phone1.Text & "' and purpose='" & TextBox_purpose.Text & "' "
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            Reset()
            populate()
        End If
    End Sub
End Class