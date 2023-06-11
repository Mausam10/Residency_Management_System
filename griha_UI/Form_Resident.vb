Public Class Form_Resident
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label_Welcome_Click(sender As Object, e As EventArgs) Handles Label_Welcome.Click

    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
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

    Private Sub Button_notices_Click(sender As Object, e As EventArgs) Handles Button_notices.Click
        Me.Hide()
        Form3_notices.Show()
    End Sub
End Class