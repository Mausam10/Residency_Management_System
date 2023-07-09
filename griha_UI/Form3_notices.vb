Public Class Form3_notices

    Dim query As String
    Dim tempDt As DataTable
    Dim counter As Integer = 0
    Dim noticesCount As Integer

    Private Sub getNotices()

        Dim loggedUser As String = Form_UI.getLoggedUsername()
        Dim loggedUserApartmentId = Form_UI.getLoggedUserApartmentId()

        query = "select * from notices where date >= GetDate()"
        tempDt = grihaDb.generateTable(query)
        If (tempDt Is Nothing) Then
            MsgBox("There are no notices for your registered apartments")
        End If
        noticesCount = tempDt.Rows.Count

    End Sub

    Private Sub generateValue(ByVal index As Integer)

        If (index > noticesCount - 1) Then
            counter = 0
            index = counter
        End If

        If (index < 0) Then
            counter = noticesCount - 1
            index = counter
        End If

        If (noticesCount <> 0) Then
            Label_topic.Text = tempDt.Rows(index).Item(0)
            Label_date.Text = tempDt.Rows(index).Item(1)
            Label_noticeDescription.Text = tempDt.Rows(index).Item(2)

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

    Private Sub Button_Workers_Click(sender As Object, e As EventArgs) Handles Button_Workers.Click
        Me.Hide()
        Form3_workers.Show()
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub Form3_notices_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        getNotices()
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
End Class