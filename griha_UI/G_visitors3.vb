Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class G_visitors3
    Dim query As String
    Dim tempDt As DataTable
    Dim temp_first, temp_phone1, temp_purpose As String

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

    Private Sub reset()
        TextBox_firstname.Text = Nothing
        TextBox_middlename.Text = Nothing
        TextBox_lastname.Text = Nothing
        TextBox_phone1.Text = Nothing
        TextBox_phone2.Text = Nothing
        DateTimePicker1.Text = Date.Now
        DateTimePicker2.Text = Date.Now
        TextBox_purpose.Text = Nothing
    End Sub



    Private Sub G_visitors3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
        reset()
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
            reset()
            populate()
        Else
            MsgBox("Error. Please check and try again.")
        End If

    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click

        'delete from visitors where (first_name = 'Rajesh' and phone1 = '9825123321' and purpose = 'friends meetup') 

        query = " DELETE FROM visitors WHERE (First_name='" & TextBox_firstname.Text & "' and Phone1='" & TextBox_phone1.Text & "' and purpose='" & TextBox_purpose.Text & "')"
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            reset()
            populate()
        End If
    End Sub

    Private Sub DGV_visitors_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_visitors.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV_visitors.Rows(e.RowIndex)
            TextBox_firstname.Text = row.Cells(0).Value.ToString
            TextBox_middlename.Text = row.Cells(1).Value.ToString
            TextBox_lastname.Text = row.Cells(2).Value.ToString
            TextBox_phone1.Text = row.Cells(3).Value.ToString
            TextBox_phone2.Text = row.Cells(4).Value.ToString
            DateTimePicker1.Text = row.Cells(5).Value
            DateTimePicker2.Text = row.Cells(6).Value
            TextBox_purpose.Text = row.Cells(7).Value.ToString

            temp_first = TextBox_firstname.Text 'selected visitor's username 
            temp_phone1 = TextBox_phone1.Text 'selcted visitor's phone1
            temp_purpose = TextBox_purpose.Text 'selected visitor's purpose
        End If

    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

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
        query = "update visitors set First_name='" & First_Name & "', Middle_name='" & Middle_Name & "', Last_name='" & Last_Name & "', Phone1='" & Phone1 & "', Phone2='" & Phone2 & "', Entry_time='" & entry_time & "', Exit_time='" & exit_time & "', purpose='" & Purpose & "'  WHERE (First_name='" & temp_first & "' and Phone1='" & temp_phone1 & "' and purpose='" & temp_purpose & "')"
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Visitor's Info successfully edited.")
            reset()
            populate()
        End If
    End Sub
End Class