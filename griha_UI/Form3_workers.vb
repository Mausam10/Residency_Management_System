Public Class Form3_workers

    Dim query As String
    Dim tempDt_Workers As DataTable
    Dim counter As Integer = 0
    Dim workerCount As Integer = 0

    Private Sub getWorkers()

        query = "
        select distinct workers.Worker_id, ISNULL(First_Name,'') + ' ' + ISNULL(Last_Name,'') AS 'Full Name', Phone1, Address, Profession, Workers_entries.inside from workers full outer join workers_entries on workers.Worker_id = workers_entries.worker_id"
        tempDt_Workers = grihaDb.generateTable(query)

        If (tempDt_Workers Is Nothing) Then
            workerCount = 0
            MsgBox("There are no workers registered for the Residency")
        Else
            workerCount = tempDt_Workers.Rows.Count
        End If

    End Sub

    Private Sub generateValue(ByVal index As Integer)

        If (index > workerCount - 1) Then
            counter = 0
            index = counter
        End If

        If (index < 0) Then
            counter = workerCount - 1
            index = counter
        End If


        Dim label_color As Color
        If (workerCount <> 0) Then

            If Not IsDBNull(tempDt_Workers.Rows(index).Item(5)) Then
                If (tempDt_Workers.Rows(index).Item(5) = 1) Then
                    label_color = Color.Lime
                Else
                    label_color = Color.Black
                End If
            Else
                label_color = Color.Black
            End If

            Label10.ForeColor = label_color
            Label11.ForeColor = label_color
            Label12.ForeColor = label_color
            Label13.ForeColor = label_color
            Label14.ForeColor = label_color
            Label_WorkerId.ForeColor = label_color
            Label_WorkerId.Text = tempDt_Workers.Rows(index).Item(0)
            Label_name.ForeColor = label_color
            Label_name.Text = tempDt_Workers.Rows(index).Item(1)
            Label_phone.ForeColor = label_color
            Label_phone.Text = tempDt_Workers.Rows(index).Item(2)
            Label_address.ForeColor = label_color
            Label_address.Text = tempDt_Workers.Rows(index).Item(3)
            Label_profession.ForeColor = label_color
            Label_profession.Text = tempDt_Workers.Rows(index).Item(4)

        End If


    End Sub



    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        Me.Hide()
        Form3_view_Residents.Show()
    End Sub

    Private Sub Button_Property_Click(sender As Object, e As EventArgs) Handles Button_Property.Click
        Me.Hide()
        Form3_property.Show()
    End Sub

    Private Sub Button_Expenses_Click(sender As Object, e As EventArgs) Handles Button_Expenses.Click
        Me.Hide()
        Form3_Expenses.Show()
    End Sub

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        Form3_notices.Show()
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub Form3_workers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        getWorkers()
        generateValue(counter)

    End Sub

    Private Sub Button_Workers_Click(sender As Object, e As EventArgs) Handles Button_Workers.Click
        getWorkers()
        counter = 0
        generateValue(counter)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        counter = counter - 1
        generateValue(counter)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        counter = counter + 1
        generateValue(counter)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class