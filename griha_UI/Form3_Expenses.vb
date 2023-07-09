Imports System.Diagnostics.Metrics
Imports System.Runtime.InteropServices

Public Class Form3_Expenses

    Dim query As String
    Dim tempDt As DataTable
    Dim counter As Integer = 0
    Dim expensesCount As Integer


    Private Sub getExpenses()

        Dim loggedUser As String = Form_UI.getLoggedUsername()
        Dim loggedUserApartmentId = Form_UI.getLoggedUserApartmentId()

        query = "select * from expenses where Apartment_id = '" & loggedUserApartmentId & "'"
        tempDt = grihaDb.generateTable(query)
        expensesCount = tempDt.Rows.Count
        If (expensesCount = 0) Then
            MsgBox("There are no expenses for your registered apartments")
        End If

    End Sub

    Private Sub generateValue(ByVal index As Integer)

        If (index > expensesCount - 1) Then
            counter = 0
            index = counter
        End If

        If (index < 0) Then
            counter = expensesCount - 1
            index = counter
        End If



        If (expensesCount <> 0) Then
            Label_apartmentID.Text = tempDt.Rows(index).Item(0)
            Label_expensesType.Text = tempDt.Rows(index).Item(1)
            Label_amount.Text = tempDt.Rows(index).Item(2)
            Label_date.Text = tempDt.Rows(index).Item(3)

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

    Private Sub Form3_Expenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        getExpenses()
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

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class