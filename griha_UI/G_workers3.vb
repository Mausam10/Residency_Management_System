Public Class G_workers3
    Private Sub G_workers3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label_record_visitors_Click(sender As Object, e As EventArgs) Handles Label_record_visitors.Click

    End Sub

    Private Sub Button_Visitors_Click(sender As Object, e As EventArgs) Handles Button_Visitors.Click
        Me.Hide()
        G_visitors3.Show()
    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        Me.Hide()
        G_residents3.Show()
    End Sub
End Class