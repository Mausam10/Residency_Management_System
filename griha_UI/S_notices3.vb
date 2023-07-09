Public Class S_notices3

    Dim query As String
    Dim tempDt As DataTable
    Dim tempTopic_name As String
    Dim tempDate As Date

    Private Function addToDatabase() As Integer
        Dim topic_name As String
        Dim date1 As Date
        Dim notice As String
        topic_name = TextBox_Name.Text
        date1 = DateTimePicker1.Text
        notice = TextBox_notice.Text

        query = "Insert into notices(Topic_name, Date, notice) values('" & topic_name & "', '" & date1 & "' ,'" & notice & "')"
        If (grihaDb.executeMySql(query)) Then
            Return 1 'success
        End If
        Return -1 'insert operation failed

    End Function


    Private Sub populate()
        query = "select * from notices"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            MsgBox("No record")

        Else
            DGV_Notices.DataSource = tempDt
        End If

    End Sub

    Private Sub reset()
        TextBox_Name.Text = Nothing
        DateTimePicker1.Text = Nothing
        TextBox_notice.Text = Nothing
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

    Private Sub Button_Workers_Click(sender As Object, e As EventArgs) Handles Button_Workers.Click
        Me.Hide()
        S_workers3.Show()
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub S_notices3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

        Dim topic_name As String
        Dim date1 As Date
        Dim notice As String
        topic_name = TextBox_Name.Text
        date1 = DateTimePicker1.Text
        notice = TextBox_notice.Text
        query = "update notices set Topic_name ='" & topic_name & "', Date='" & date1 & "', notice='" & notice & "' where (Topic_name = '" & tempTopic_name & "' and Date = '" & tempDate & "')"
        If (grihaDb.executeMySql(query)) Then
            MsgBox("UserInfo successfully edited.")
            reset()
            populate()
        End If

    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click

        query = " DELETE FROM notices WHERE (Topic_name = '" & TextBox_Name.Text & "' and Date = '" & DateTimePicker1.Value & "') "
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            reset()
            populate()
        End If

    End Sub

    Private Sub DGV_Notices_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim rowCount As Integer = DGV_Notices.RowCount - 1
        If (e.RowIndex >= 0 And e.RowIndex < rowCount) Then
            Dim row As DataGridViewRow = DGV_Notices.Rows(e.RowIndex)
            TextBox_Name.Text = row.Cells(0).Value.ToString
            DateTimePicker1.Text = row.Cells(1).Value.ToString
            TextBox_notice.Text = row.Cells(2).Value.ToString
            tempTopic_name = TextBox_Name.Text 'selected user's username 
            tempDate = DateTimePicker1.Value
        Else
            reset()
        End If
    End Sub
End Class