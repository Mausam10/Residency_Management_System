Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Data
Imports Azure.Identity
Imports Microsoft.Identity.Client

Public Class Form_UI
    Dim tempdt As DataTable
    Dim query As String
    Shared loggedUsername As String
    Shared loggedUserApartment_id As String
    Public Shared Function getLoggedUsername() As String
        Return loggedUsername
    End Function

    Public Shared Function getLoggedUserApartmentId() As String
        Return loggedUserApartment_id
    End Function

    Public Function authenticationCheck(ByVal username As String, ByVal password As String, ByVal user As String) As Integer
        Try
            If (user = "Residents") Then
                query = "select Username, Apartment_id from " & user & " Where (Username = '" & username & "' and Password = '" & password & "' )"
            Else
                query = "select * from " & user & " Where (Username = '" & username & "' and Password = '" & password & "' )"
            End If
            'query = "select * from " & user & " Where Username = '" & username & "'and Password = '" & password & "' "
            tempdt = grihaDb.generateTable(query)

            If (tempdt Is Nothing) Then
                Return -1 'username/password not matched or no user exists
            End If

            If (user = "Residents") Then
                loggedUsername = tempdt.Rows(0).Item(0)
                loggedUserApartment_id = tempdt.Rows(0).Item(1)
                'MsgBox(loggedUsername)
                'MsgBox(loggedUserApartment_id)
            End If
            Return 1  'username and password matched
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try



    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login_secretary.Click

        If (authenticationCheck(Username_textbox.Text, Password_textbox.Text, "Secretary") = 1) Then
            Me.Hide()
            Form_secretary.Show()
        Else
            MsgBox("Incorrect username or password. Please try again.")
        End If

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
        If (authenticationCheck(Username_textbox.Text, Password_textbox.Text, "Guards") = 1) Then
            Me.Hide()
            Form_Securityguard.Show()
        Else
            MsgBox("Incorrect username or password. Please try again.")
        End If

    End Sub

    Private Sub Login_resident_Click(sender As Object, e As EventArgs) Handles Login_resident.Click
        If (authenticationCheck(Username_textbox.Text, Password_textbox.Text, "Residents") = 1) Then
            Me.Hide()
            Form_Resident.Show()
        Else
            MsgBox("Incorrect username or password. Please try again.")
        End If

    End Sub

    Protected Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Password_textbox.UseSystemPasswordChar = Not Password_textbox.UseSystemPasswordChar

    End Sub

    Protected Sub Password_textbox_TextChanged(sender As Object, e As EventArgs) Handles Password_textbox.TextChanged

    End Sub
End Class
