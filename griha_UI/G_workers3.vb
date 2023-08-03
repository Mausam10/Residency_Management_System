Public Class G_workers3

    Dim query As String
    Dim tempDt As DataTable
    Dim temp_WorkerId As String
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
            query = "Insert into Workers_entries (Worker_id, Entry_time, Exit_time, description, Inside) values('" & Worker_id & "','" & entry_time & "','" & exit_time & "','" & description & "','" & Inside & "')"
        Else
            Inside = 1
            query = "Insert into Workers_entries (Worker_id, Entry_time, Exit_time, description, Inside) values('" & Worker_id & "','" & entry_time & "',Null,'" & description & "','" & Inside & "')"

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

    Private Sub populateComboBox()
        ComboBox_workerID.Items.Clear()
        query = "select Worker_id from Workers"

        Dim items As ComboBox.ObjectCollection = grihaDb.generateComboBox(query, "Worker_id").Items

        For Each item In items
            ComboBox_workerID.Items.Add(item)
        Next
    End Sub

    Private Sub reset()
        ComboBox_workerID.SelectedItem = Nothing
        DateTimePicker1.Text = Date.Now
        DateTimePicker2.CustomFormat = " "
        TextBox_description.Text = Nothing
        CheckBox_worker.Checked = False
        populateComboBox()
    End Sub

    Private Sub G_workers3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
        populateComboBox()
        reset()
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

    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        If (addToDatabase() = 1) Then
            MsgBox("Record successfully Added")
            reset()
            populate()
            populateComboBox()
        Else
            MsgBox("Error. Please check and try again.")
        End If
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

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
            query = "update Workers_entries set Worker_id='" & Worker_id & "', Entry_time='" & entry_time & "', Exit_time='" & exit_time & "', description='" & description & "', Inside='" & Inside & "'  WHERE (Worker_id='" & temp_WorkerId & "' and Entry_time='" & temp_timeEntry & "')"
        Else
            Inside = 1
            query = "update Workers_entries set Worker_id='" & Worker_id & "', Entry_time='" & entry_time & "', Exit_time=Null, description='" & description & "', Inside='" & Inside & "'  WHERE (Worker_id='" & temp_WorkerId & "' and Entry_time='" & temp_timeEntry & "')"

        End If

        If (grihaDb.executeMySql(query)) Then
            MsgBox("Worker's Info successfully edited.")
            reset()
            populate()
            populateComboBox()
        End If

    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click

        query = " DELETE FROM Workers_entries WHERE (Worker_id='" & ComboBox_workerID.SelectedItem & "' and Entry_time='" & DateTimePicker1.Value & "')"
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            reset()
            populate()
            populateComboBox()
        End If
    End Sub

    Private Sub DGV_workers_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_workers.CellMouseClick

        Dim rowCount As Integer = DGV_workers.RowCount - 1
        If (e.RowIndex >= 0 And e.RowIndex < rowCount) Then
            Dim row As DataGridViewRow = DGV_workers.Rows(e.RowIndex)
            ComboBox_workerID.SelectedItem = row.Cells(0).Value.ToString
            DateTimePicker1.Text = row.Cells(1).Value
            ' DateTimePicker2.Text = row.Cells(2).Value
            TextBox_description.Text = row.Cells(3).Value.ToString

            If (row.Cells(4).Value = 0) Then
                CheckBox_worker.Checked = True
                DateTimePicker2.Value = row.Cells(2).Value
            Else
                CheckBox_worker.Checked = False
                DateTimePicker2.Value = Date.Now()
            End If

            temp_WorkerId = ComboBox_workerID.SelectedItem 'selected visitor's username 
            temp_timeEntry = DateTimePicker1.Value 'selected visitor's entry date
        Else
            reset()
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.CustomFormat = "  hh:mm tt dddd dd MMMM yyyy"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub
End Class