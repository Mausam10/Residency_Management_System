Public Class S_events3
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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
End Class