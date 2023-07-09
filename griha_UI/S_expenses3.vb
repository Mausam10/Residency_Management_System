Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class S_expenses3

    Dim query As String
    Dim tempDt As DataTable
    Dim tempApartment As String
    Dim tempExpenses_type As String
    Dim tempDate As Date
    Dim tempAmount As String


    Private Function addToDatabase() As Integer
        Dim Apartment_id, Expenses_type, Amount As String
        Dim date1 As Date
        Apartment_id = ComboBox_apartments.SelectedItem
        Expenses_type = ComboBox1.SelectedItem
        Amount = TextBox_Amount.Text
        date1 = DateTimePicker1.Text
        query = "Insert into expenses(Apartment_id, Expenses_type, Amount, Date) values('" & Apartment_id & "' ,'" & Expenses_type & "','" & Amount & "','" & date1 & "')"
        If (grihaDb.executeMySql(query)) Then
            Return 1 'success
        End If
        Return -1 'insert operation failed

    End Function

    Private Sub reset()
        ComboBox_apartments.SelectedItem = Nothing
        ComboBox1.SelectedItem = Nothing
        TextBox_Amount.Text = Nothing
        DateTimePicker1.Text = Nothing
        populateComboBox()
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

    Private Sub populateComboBox()
        ComboBox_apartments.Items.Clear()
        'query = "select * from apartments"
        query = "select apartments.Apartment_id from apartments left join residents on apartments.apartment_id = residents.apartment_id where residents.apartment_id is not null"

        Dim items As ComboBox.ObjectCollection = grihaDb.generateComboBox(query, "Apartment_id").Items

        For Each item In items
            ComboBox_apartments.Items.Add(item)
        Next
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
        query = " DELETE FROM expenses WHERE (Apartment_Id='" & ComboBox_apartments.SelectedItem & "' and Expenses_type = '" & ComboBox1.SelectedItem & "' and Amount = '" & TextBox_Amount.Text & "' and Date = '" & DateTimePicker1.Value & "') "
        If (grihaDb.executeMySql(query)) Then
            MsgBox("Record Deleted")
            reset()
            populate()
            populateComboBox()
        End If
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

        Dim Apartment_id, Expenses_type, Amount As String
        Dim date1 As Date
        Apartment_id = ComboBox_apartments.SelectedItem
        Expenses_type = ComboBox1.SelectedItem
        Amount = TextBox_Amount.Text
        date1 = DateTimePicker1.Text
        query = "update expenses set Apartment_Id ='" & Apartment_id & "', expenses_type ='" & Expenses_type & "', amount='" & Amount & "',date='" & date1 & "' where (Apartment_id='" & tempApartment & "' and Expenses_type = '" & tempExpenses_type & "' and Amount = '" & tempAmount & "' and Date = '" & tempDate & "')"
        If (grihaDb.executeMySql(query)) Then
            MsgBox("UserInfo successfully edited.")
            reset()
            populate()
            populateComboBox()
        End If

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
        populateComboBox()
        reset()
    End Sub

    Private Sub DGV_Expenses_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DGV_Expenses_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)

        Dim rowCount As Integer = DGV_Expenses.RowCount - 1
        If (e.RowIndex >= 0 And e.RowIndex < rowCount) Then
            Dim row As DataGridViewRow = DGV_Expenses.Rows(e.RowIndex)
            ComboBox_apartments.SelectedItem = row.Cells(0).Value.ToString
            ComboBox1.SelectedItem = row.Cells(1).Value.ToString
            TextBox_Amount.Text = row.Cells(2).Value.ToString
            DateTimePicker1.Text = row.Cells(3).Value
            tempApartment = ComboBox_apartments.SelectedItem 'selected user's username 
            tempExpenses_type = ComboBox1.SelectedItem
            tempAmount = TextBox_Amount.Text
            tempDate = DateTimePicker1.Value
        Else
            reset()
        End If
    End Sub

    Private Sub DGV_Expenses_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Expenses.CellContentClick

    End Sub
End Class