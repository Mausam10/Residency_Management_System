Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form_UI




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login_secretary.Click
        Me.Hide()
        Form_secretary.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles griha_logo.Click

    End Sub

    Private Sub Username_textbox_TextChanged(sender As Object, e As EventArgs) Handles Username_textbox.TextChanged
    End Sub

    Private Sub Username_label_Click(sender As Object, e As EventArgs) Handles Username_label.Click

    End Sub
    Private Sub Login_Guard_Click(sender As Object, e As EventArgs) Handles Login_Guard.Click
        Me.Hide()
        Form_Securityguard.Show()
    End Sub

    Private Sub Login_resident_Click(sender As Object, e As EventArgs) Handles Login_resident.Click
        Me.Hide()
        Form_Resident.Show()
    End Sub

    Protected Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Password_textbox.UseSystemPasswordChar = Not Password_textbox.UseSystemPasswordChar

    End Sub

    Protected Sub Password_textbox_TextChanged(sender As Object, e As EventArgs) Handles Password_textbox.TextChanged

    End Sub
End Class
