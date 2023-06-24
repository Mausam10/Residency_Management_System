Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class S_expenses3

    Dim query As String
    Dim tempDt As DataTable
    Dim tempGen As String
    Dim tempUsername As String

    Private Function addToDatabase() As Integer
        Dim Username As String
        Dim Apartment_id, Expenses_type, Amount As String

        Username = TextBox_username.Text
        Apartment_id = TextBox_apartmentid.Text
        Expenses_type = ComboBox1.SelectedItem
        Amount = TextBox_Amount.Text

        query = "Insert into expenses(Username,Apartment_id, Expenses_type, Amount) values('" & Username & "', '" & Apartment_id & "' ,'" & Expenses_type & "','" & Amount & "')"
        If (grihaDb.executeMySql(query)) Then
            Return 1 'success
        End If
        Return -1 'insert operation failed

    End Function

    Private Sub reset()
        TextBox_username.Text = Nothing
        TextBox_apartmentid.Text = Nothing
        ComboBox1.SelectedItem = Nothing
        TextBox_Amount.Text = Nothing
    End Sub

    Private Sub populate()
        query = "select * from expenses"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            MsgBox("No record")

        Else
            DGV_Expenses.DataSource = tempDt
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

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub


    Private Sub Label_types_of_expenses_Click(sender As Object, e As EventArgs) Handles Label_types_of_expenses.Click
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        query = " DELETE FROM expenses WHERE Username='" & TextBox_username.Text & "' "
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            reset()
            populate()
        End If
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        query = " DELETE FROM expenses WHERE Username='" & tempUsername & "' "
        grihaDb.executeMySql(query)
        addToDatabase()
        MsgBox("UserInfo successfully edited.")
        reset()
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

    Private Sub Information_label_Click(sender As Object, e As EventArgs) Handles Information_label.Click
    End Sub

    Private Sub TextBox_apartmentid_TextChanged(sender As Object, e As EventArgs) Handles TextBox_apartmentid.TextChanged
    End Sub

    Private Sub TextBox_username_TextChanged(sender As Object, e As EventArgs) Handles TextBox_username.TextChanged
    End Sub

    Private Sub Label_expenses_Click(sender As Object, e As EventArgs) Handles Label_expenses.Click
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    End Sub

    Private Sub Button_Workers_Click(sender As Object, e As EventArgs) Handles Button_Workers.Click
        Me.Hide()
        S_workers3.Show()
    End Sub

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        S_notices3.Show()
    End Sub

    Private Sub S_expenses3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        populate()

    End Sub

    Private Sub DGV_Expenses_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Expenses.CellContentClick

    End Sub

    Private Sub DGV_Expenses_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Expenses.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV_Expenses.Rows(e.RowIndex)
            TextBox_username.Text = row.Cells(0).Value.ToString
            TextBox_apartmentid.Text = row.Cells(1).Value.ToString
            ComboBox1.SelectedItem = row.Cells(2).Value.ToString
            TextBox_Amount.Text = row.Cells(3).Value.ToString
            tempUsername = TextBox_username.Text 'selected user's username 
        End If
    End Sub
End Class