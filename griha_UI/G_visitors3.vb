﻿Public Class G_visitors3
    Private Sub G_visitors3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        Me.Hide()
        G_residents3.Show()
    End Sub
End Class