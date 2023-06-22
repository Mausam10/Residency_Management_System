Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Data


Public Class Form_UI
    Dim tempdt As DataTable

    Public Function authenticationCheck(ByVal username As String, ByVal password As String) As Integer
        Dim i As Integer = 3

        Dim query As String = "select * from residents where Username = '" & username & "'and Password = ' " & password & " ' "
        tempdt = grihaDb.generateTable(query)
        Dim a As Integer
        a = tempdt.Rows.Count
        If a = 0 Then
            MsgBox("incorrect password")
            Return -1
        End If

        'While True
        ' Dim singleUsername As String = tempdt.Rows(i).Item(0)
        'Dim singlePassword As String = tempdt.Rows(i).Item(1)
        'If (singleUsername = Nothing) Then
        ' Return -2  'no resident with that username 
        'End If
        'If username = singleUsername Then
        'MsgBox(singleUsername)
        'MsgBox(singlePassword)
        'If password = singlePassword Then
        'MsgBox(singlePassword)

        Return 1  'username and password matched
        'Else Return -1 'username matched, password didn't match
        'End If
        ' End If
        ' i = i + 1
        'End While

        'Return -1
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()

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

        If (authenticationCheck(Username_textbox.Text, Password_textbox.Text) = 1) Then
            Me.Hide()
            Form_Resident.Show()
        Else
            MsgBox("Incorrect username/password")
        End If

    End Sub

    Protected Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Password_textbox.UseSystemPasswordChar = Not Password_textbox.UseSystemPasswordChar

    End Sub

    Protected Sub Password_textbox_TextChanged(sender As Object, e As EventArgs) Handles Password_textbox.TextChanged

    End Sub
End Class
