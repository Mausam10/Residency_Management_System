Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class S_workers3

    Dim query As String
    Dim tempDt As DataTable
    Dim tempWorkerID As String
    Dim tempProfession As String
    Private Function addToDatabase() As Integer
        Dim Worker_Id As String
        Dim First_Name, Middle_Name, Last_Name, Phone1, Phone2, Profession, Address As String
        Worker_Id = TextBox_workerID.Text
        First_Name = TextBox_firstname.Text
        Middle_Name = TextBox_middlename.Text
        Last_Name = TextBox_lastname.Text
        Phone1 = TextBox_phone1.Text
        Phone2 = TextBox_phone2.Text
        Profession = Textbox_profession.Text
        Address = TextBox_address.Text

        query = "Insert into workers(Worker_id, First_Name, Middle_Name, Last_Name, Phone1, Phone2, Profession, Address) values('" & Worker_Id & "','" & First_Name & "','" & Middle_Name & "','" & Last_Name & "','" & Phone1 & "' ,'" & Phone2 & "' ,'" & Profession & "','" & Address & "')"
        If (grihaDb.executeMySql(query)) Then
            Return 1
        End If
        Return -1

    End Function

    Private Sub reset()
        TextBox_workerID.Text = Nothing
        TextBox_firstname.Text = Nothing
        TextBox_middlename.Text = Nothing
        TextBox_lastname.Text = Nothing
        TextBox_phone1.Text = Nothing
        TextBox_phone2.Text = Nothing
        Textbox_profession.Text = Nothing
        TextBox_address.Text = Nothing

    End Sub

    Private Sub populate()
        query = "select * from workers"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            'do nothing
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

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        S_notices3.Show()
    End Sub

    Private Sub S_workers3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
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

    Private Sub DGVWorkers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DGVWorkers_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

        Dim rowCount As Integer = DGVWorkers.RowCount - 1
        If (e.RowIndex >= 0 And e.RowIndex < rowCount) Then
            Dim row As DataGridViewRow = DGVWorkers.Rows(e.RowIndex)
            TextBox_workerID.Text = row.Cells(0).Value.ToString
            TextBox_firstname.Text = row.Cells(1).Value.ToString
            TextBox_middlename.Text = row.Cells(2).Value.ToString
            TextBox_lastname.Text = row.Cells(3).Value.ToString
            TextBox_phone1.Text = row.Cells(4).Value.ToString
            TextBox_phone2.Text = row.Cells(5).Value.ToString
            Textbox_profession.Text = row.Cells(6).Value.ToString
            TextBox_address.Text = row.Cells(7).Value.ToString

            tempWorkerID = TextBox_workerID.Text 'selected worker's workerID
            tempProfession = Textbox_profession.Text
        Else
            reset()
        End If

    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        query = " DELETE FROM Workers WHERE worker_id='" & TextBox_workerID.Text & "' "
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            reset()
            populate()
        End If
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

        Dim Worker_Id As String
        Dim First_Name, Middle_Name, Last_Name, Phone1, Phone2, Profession, Address As String
        Worker_Id = TextBox_workerID.Text
        First_Name = TextBox_firstname.Text
        Middle_Name = TextBox_middlename.Text
        Last_Name = TextBox_lastname.Text
        Phone1 = TextBox_phone1.Text
        Phone2 = TextBox_phone2.Text
        Profession = Textbox_profession.Text
        Address = TextBox_address.Text
        query = "update workers set Worker_Id ='" & Worker_Id & "', First_Name ='" & First_Name & "', Middle_Name ='" & Middle_Name & "', Last_Name='" & Last_Name & "', Phone1 ='" & Phone1 & "', Phone2='" & Phone2 & "', Profession='" & Profession & "', Address='" & Address & "' where (Worker_Id='" & tempWorkerID & "' and Profession = '" & tempProfession & "')"
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Worker Info successfully edited.")
            reset()
            populate()
        End If

    End Sub
End Class