Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class S_events3




    Dim query As String
    Dim tempDt As DataTable
    Dim tempGen As String
    Dim tempUsername As String


    Private Function addToDatabase() As Integer
        Dim event_name As String
        Dim date1 As Date
        Dim description As String
        event_name = TextBox_Name.Text
        date1 = DateTimePicker1.Text
        description = TextBox_description.Text

        query = "Insert into events(Event_name, Date, Description) values('" & event_name & "', '" & date1 & "' ,'" & description & "')"
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label_events.Click
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
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

    End Sub

    Private Sub DGV_events_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Events.CellContentClick

    End Sub
End Class