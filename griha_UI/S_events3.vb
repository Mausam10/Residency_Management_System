Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class S_events3




    Dim query As String
    Dim tempDt As DataTable
    Dim tempEvent_name As String
    Dim temp_organizer As String
    Dim tempDate As Date


    Private Function addToDatabase() As Integer
        Dim event_name As String
        Dim date1 As Date
        Dim organizer As String
        Dim sponser As String
        Dim description As String
        Dim Event_expenses As String
        event_name = TextBox_Name.Text
        date1 = DateTimePicker1.Text
        organizer = TextBox_organizer.Text
        sponser = TextBox_sponser.Text
        description = TextBox_description.Text
        Event_expenses = TextBox_amount.Text

        query = "Insert into events(Event_name, Date, Organizer, Sponser, Description, Event_expenses) values('" & event_name & "', '" & date1 & "' ,'" & organizer & "', '" & sponser & "' ,'" & description & "', '" & Event_expenses & "')"
        If (grihaDb.executeMySql(query)) Then
            Return 1 'success
        End If
        Return -1 'insert operation failed

    End Function

    Private Sub populate()
        query = "select * from events"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            MsgBox("No record")

        Else
            DGV_Events.DataSource = tempDt
        End If

    End Sub


    Private Sub reset()
        TextBox_Name.Text = Nothing
        DateTimePicker1.Text = Nothing
        TextBox_organizer.Text = Nothing
        TextBox_sponser.Text = Nothing
        TextBox_description.Text = Nothing
        TextBox_amount.Text = Nothing
    End Sub





    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        S_notices3.Show()
    End Sub

    Private Sub Button_Workers_Click(sender As Object, e As EventArgs) Handles Button_Workers.Click
        Me.Hide()
        S_workers3.Show()
    End Sub

    Private Sub Button_Expenses_Click(sender As Object, e As EventArgs) Handles Button_Expenses.Click
        Me.Hide()
        S_expenses3.Show()
    End Sub

    Private Sub Button_Events_Click(sender As Object, e As EventArgs) Handles Button_Events.Click
    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        Me.Hide()
        S_residents3.Show()
    End Sub



    Private Sub S_events3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()

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

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

        Dim event_name As String
        Dim date1 As Date
        Dim organizer As String
        Dim sponser As String
        Dim description As String
        Dim Event_expenses As String
        event_name = TextBox_Name.Text
        date1 = DateTimePicker1.Text
        organizer = TextBox_organizer.Text
        sponser = TextBox_sponser.Text
        description = TextBox_description.Text
        Event_expenses = TextBox_amount.Text

        query = "update events set Event_name ='" & event_name & "', Date='" & date1 & "', Organizer='" & organizer & "' , Sponser='" & organizer & "',Description='" & description & "' , Event_expenses='" & Event_expenses & "' where (Event_name = '" & tempEvent_name & "' and Date = '" & tempDate & "' and Organizer = '" & temp_organizer & "' )"
        If (grihaDb.executeMySql(query)) Then
            MsgBox("UserInfo successfully edited.")
            reset()
            populate()
        End If


    End Sub


    Private Sub DGV_Events_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Events.CellMouseClick

        Dim rowCount As Integer = DGV_Events.RowCount - 1
        If (e.RowIndex >= 0 And e.RowIndex < rowCount) Then
            Dim row As DataGridViewRow = DGV_Events.Rows(e.RowIndex)
            TextBox_Name.Text = row.Cells(0).Value.ToString
            DateTimePicker1.Value = row.Cells(1).Value.ToString
            TextBox_organizer.Text = row.Cells(2).Value.ToString
            TextBox_sponser.Text = row.Cells(3).Value.ToString
            TextBox_description.Text = row.Cells(4).Value.ToString
            TextBox_amount.Text = row.Cells(5).Value.ToString
            tempEvent_name = TextBox_Name.Text 'selected user's username 
            tempDate = DateTimePicker1.Value
            temp_organizer = TextBox_organizer.Text
        Else
            reset()
        End If
    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        query = " DELETE FROM events WHERE (Event_name = '" & TextBox_Name.Text & "' and Date = '" & DateTimePicker1.Value & "' and Organizer = '" & TextBox_organizer.Text & "' ) "
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            reset()
            populate()
        End If
    End Sub


End Class