Public Class G_residents3

    Dim query As String
    Dim tempDt As DataTable
    Dim temp_username As String
    Dim temp_DateExit As Date
    Dim temp_DateEntry As Date

    Private Function usernameVerification(ByVal username As String) As Boolean
        Dim count As Integer
        query = "select Username from residents"
        Dim temp As DataTable = grihaDb.generateTable(query)
        count = temp.Rows.Count
        If (count <> 0) Then
            For i As Integer = 0 To count - 1
                If (username = temp.Rows(i).Item(0).ToString) Then
                    Return False
                End If
            Next
            Return True
        Else
            Return True
        End If

    End Function

    Private Function addToDatabase() As Integer

        Dim username As String
        Dim entry_date, exit_date As Date
        Dim description As String
        Dim Outside As Integer
        username = TextBox_residents_username.Text
        exit_date = DateTimePicker1.Value
        'entry_date = Nothing
        description = TextBox_description.Text

        If (usernameVerification(username) = False) Then
            Return -2
        End If

        query = "delete from Residents_entries where username = '" & username & "'"

        If (grihaDb.executeMySql(query)) Then
            'do nothing
        End If

        If (CheckBox_resident.Checked = True) Then
            Outside = 0
            entry_date = DateTimePicker2.Value
            query = "Insert into Residents_entries (username, Exit_date, Entry_date, Description, Outside) values('" & username & "','" & exit_date & "','" & entry_date & "','" & description & "','" & Outside & "')"

        Else
            Outside = 1
            query = "Insert into Residents_entries (username, Exit_date, Entry_date, Description, Outside) values('" & username & "','" & exit_date & "',Null,'" & description & "','" & Outside & "')"
        End If

        If (grihaDb.executeMySql(query)) Then
            Return 1 'success
        End If
        Return -1 'insert operation failed

    End Function

    Private Sub populate()
        query = "select * from Residents_entries"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            MsgBox("No record")

        Else
            DGV_residents.DataSource = tempDt
        End If

    End Sub

    Private Sub reset()
        TextBox_residents_username.Text = Nothing
        DateTimePicker1.Text = Date.Now
        DateTimePicker2.CustomFormat = " "
        TextBox_description.Text = Nothing
        CheckBox_resident.Checked = False
    End Sub

    Private Sub G_residents3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()
        reset()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.CustomFormat = "  hh:mm tt dddd dd MMMM yyyy"
    End Sub

    Private Sub Button_Visitors_Click(sender As Object, e As EventArgs) Handles Button_Visitors.Click
        Me.Hide()
        G_visitors3.Show()
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
        ElseIf (addtodatabase() = -1) Then
            MsgBox("Error. Please check and try again.")
        ElseIf (addtoDatabase() = -2) Then
            MsgBox("The username doesn't exist or contains invalid characters, Try Again!!")
        End If

    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

        Dim username As String
        Dim entry_date, exit_date As Date
        Dim description As String
        Dim Outside As Integer
        username = TextBox_residents_username.Text
        exit_date = DateTimePicker1.Value
        'entry_date = Nothing
        description = TextBox_description.Text

        If (usernameVerification(username) = False) Then
            MsgBox("The username doesn't exist or contains invalid characters, Try Again!!")
            Exit Sub
        End If

        If (CheckBox_resident.Checked = True) Then
            Outside = 0
            entry_date = DateTimePicker2.Value
            query = "update Residents_entries set Username='" & username & "', Exit_date='" & exit_date & "', entry_date='" & entry_date & "', description='" & description & "', Outside='" & Outside & "'  WHERE (Username='" & temp_username & "' and Exit_date='" & temp_DateExit & "')"

        Else
            Outside = 1
            query = "update Residents_entries set Username='" & username & "', Exit_date='" & exit_date & "', entry_date=Null, description='" & description & "', Outside='" & Outside & "'  WHERE (Username='" & temp_username & "' and Exit_date='" & temp_DateExit & "')"
        End If

        If (grihaDb.executeMySql(query)) Then
            MsgBox("Residents Entry/Exit Info successfully edited.")
            reset()
            populate()
        End If

    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click

        query = " DELETE FROM Residents_entries WHERE (username='" & TextBox_residents_username.Text & "' and Exit_date='" & DateTimePicker1.Value & "')"
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            reset()
            populate()
        End If

    End Sub

    Private Sub DGV_residents_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_residents.CellMouseClick

        Dim rowCount As Integer = DGV_residents.RowCount - 1
        If (e.RowIndex >= 0 And e.RowIndex < rowCount) Then
            Dim row As DataGridViewRow = DGV_residents.Rows(e.RowIndex)
            TextBox_residents_username.Text = row.Cells(0).Value.ToString
            DateTimePicker1.Value = row.Cells(1).Value
            ' DateTimePicker2.Text = row.Cells(2).Value
            TextBox_description.Text = row.Cells(3).Value.ToString

            If (row.Cells(4).Value = 0) Then
                CheckBox_resident.Checked = True
                DateTimePicker2.Value = row.Cells(2).Value
            Else
                CheckBox_resident.Checked = False
                DateTimePicker2.Value = Date.Now()
            End If

            temp_username = TextBox_residents_username.Text 'selected resident's username 
            temp_DateExit = DateTimePicker1.Value 'selected resident's exit date
        Else
            reset()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub
End Class