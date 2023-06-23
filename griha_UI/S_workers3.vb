﻿Public Class S_workers3

    Dim query As String
    Dim tempDt As DataTable
    Private Sub addToDatabase()
        Dim Worker_Id As String
        Dim First_Name, Middle_Name, Last_Name, Phone1, Phone2 As String
        Worker_Id = TextBox_workerID.Text
        First_Name = TextBox_firstname.Text
        Middle_Name = TextBox_middlename.Text
        Last_Name = TextBox_lastname.Text
        Phone1 = TextBox_phone1.Text
        Phone2 = TextBox_phone2.Text

        query = "Insert into workers(Worker_id, First_Name, Middle_Name, Last_Name, Phone1, Phone2) values('" & Worker_Id & "','" & First_Name & "','" & Middle_Name & "','" & Last_Name & "','" & Phone1 & "' ,'" & Phone2 & "')"
        If (grihaDb.executeMySql(query)) Then
        End If

    End Sub

    Private Sub reset()
        TextBox_workerID.Text = Nothing
        TextBox_firstname.Text = Nothing
        TextBox_middlename.Text = Nothing
        TextBox_lastname.Text = Nothing
        TextBox_phone1.Text = Nothing
        TextBox_phone2.Text = Nothing
    End Sub

    Private Sub populate()
        query = "select * from workers"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            MsgBox("No record")

        Else
            DGVWorkers.DataSource = tempDt
        End If

    End Sub


    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        Me.Hide()
        S_residents3.Show()

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
    End Sub

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        S_notices3.Show()
    End Sub

    Private Sub S_workers3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
    End Sub

    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        addToDatabase()
        MsgBox("Record Added")
        reset()
        populate()
    End Sub

    Private Sub DGVWorkers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVWorkers.CellContentClick

    End Sub

    Private Sub DGVWorkers_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVWorkers.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGVWorkers.Rows(e.RowIndex)
            TextBox_workerID = row.Cells(0).Value.ToString
            TextBox_firstname.Text = row.Cells(1).Value.ToString
            TextBox_middlename.Text = row.Cells(2).Value.ToString
            TextBox_lastname.Text = row.Cells(3).Value.ToString
            TextBox_phone1.Text = row.Cells(4).Value.ToString
            TextBox_phone2.Text = row.Cells(5).Value.ToString
            ' tempUsername = TextBox_username.Text 'selected user's username 
        End If

    End Sub
End Class