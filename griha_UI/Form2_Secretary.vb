Public Class Form_secretary
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        Me.Hide()
        S_residents3.Show()
    End Sub
End Class