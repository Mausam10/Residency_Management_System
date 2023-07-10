Public Class Form3_property

    Private Sub getApartmentInfo()
        Dim tempDt_apartment As DataTable
        Dim query As String
        Dim query1 As String
        Try
            Dim loggedUser As String = Form_UI.getLoggedUsername()
            Dim loggedUserApartmentId = Form_UI.getLoggedUserApartmentId()

            query = "select * from Apartments where Apartment_id = '" & loggedUserApartmentId & "'"
            tempDt_apartment = grihaDb.generateTable(query)

            query1 = "SELECT ISNULL(First_Name,'') + ' ' + ISNULL(Last_Name,'') AS 'Full Name' from Residents where (username = '" & loggedUser & "' and Apartment_id = '" & loggedUserApartmentId & "')"
            Dim ownerName As String = grihaDb.generateComboBox(query1, "Full Name").Items(0) 'get owner's name

            If (tempDt_apartment Is Nothing) Then
                MsgBox("Record is not found, Please Check and Try Again")
            Else
                Dim index As Integer = 0
                Label_apartmentID.Text = tempDt_apartment.Rows(index).Item(0)
                Label_area.Text = tempDt_apartment.Rows(index).Item(1)
                Label_floor.Text = tempDt_apartment.Rows(index).Item(2)
                Label_bhk.Text = tempDt_apartment.Rows(index).Item(3)
                Label_ownedBy.Text = ownerName
                Label_description.Text = tempDt_apartment.Rows(index).Item(4)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        Me.Hide()
        Form3_view_Residents.Show()

    End Sub

    Private Sub Button_Property_Click(sender As Object, e As EventArgs) Handles Button_Property.Click
        getApartmentInfo()
    End Sub

    Private Sub Button_Expenses_Click(sender As Object, e As EventArgs) Handles Button_Expenses.Click
        Me.Hide()
        Form3_Expenses.Show()
    End Sub

    Private Sub Button_Workers_Click(sender As Object, e As EventArgs) Handles Button_Workers.Click
        Me.Hide()
        Form3_workers.Show()

    End Sub

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        Form3_notices.Show()
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()

    End Sub

    Private Sub Form3_property_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        getApartmentInfo()
    End Sub

    'Private Sub TextBox_Name_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Name.TextChanged

    'End Sub
End Class