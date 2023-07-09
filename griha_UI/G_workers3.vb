Public Class G_workers3

    Dim query As String
    Dim tempDt As DataTable
    Dim tempWorkerId As String
    Dim temp_timeEntry As Date
    Dim temp_timeExit As Date


    Private Function addToDatabase() As Integer

        Dim Worker_id As String
        Dim entry_time, exit_time As Date
        Dim description As String
        Dim Inside As Integer
        Worker_id = ComboBox_workerID.SelectedItem
        entry_time = DateTimePicker1.Value
        'exit_time = Nothing
        description = TextBox_description.Text

        If (CheckBox_worker.Checked = True) Then
            Inside = 0
            exit_time = DateTimePicker2.Value
            query = "Insert into Workers (Worker_id, Entry_time, Exit_time, description, Inside) values('" & Worker_id & "','" & entry_time & "','" & exit_time & "','" & description & "','" & Inside & "')"
        Else
            Inside = 1
            query = "Insert into Workers (Worker_id, Entry_time, Exit_time, description, Inside) values('" & Worker_id & "','" & entry_time & "',Null,'" & description & "','" & Inside & "')"

        End If

        'query = "Insert into Visitors (First_Name,Middle_Name, Last_Name, Phone1, Entry_time, Exit_time, description, Inside) values('" & First_Name & "','" & Middle_Name & "','" & Last_Name & "','" & Phone1 & "','" & entry_time & "','" & exit_time & "','" & description & "','" & Inside & "')"
        If (grihaDb.executeMySql(query)) Then
            Return 1 'success
        End If
        Return -1 'insert operation failed

    End Function






    Private Sub populate()
        query = "select * from Workers_entries"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            MsgBox("No record")

        Else
            DGV_workers.DataSource = tempDt
        End If

    End Sub

    Private Sub reset()
        ComboBox_workerID.SelectedItem = Nothing
        DateTimePicker1.Text = Date.Now
        DateTimePicker2.CustomFormat = " "
        TextBox_description.Text = Nothing
        CheckBox_worker.Checked = False
    End Sub

    Private Sub G_workers3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
        Reset()
    End Sub


    Private Sub Button_Visitors_Click(sender As Object, e As EventArgs) Handles Button_Visitors.Click
        Me.Hide()
        G_visitors3.Show()
    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        Me.Hide()
        G_residents3.Show()
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        G_notices3.Show()
    End Sub

End Class