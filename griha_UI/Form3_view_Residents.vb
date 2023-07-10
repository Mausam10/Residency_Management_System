Public Class Form3_view_Residents

    Dim query As String
    Dim tempDt_residents As DataTable
    Dim counter As Integer = 0
    Dim ResidentCount As Integer
    Dim tempCount As Integer
    Private Function getResidents() As Boolean
        query = "SELECT ISNULL(First_Name,'') + ' ' + ISNULL(Last_Name,'') AS 'Full Name', Apartment_id, Phone1, Profession from Residents"
        tempDt_residents = grihaDb.generateTable(query)
        If (tempDt_residents Is Nothing) Then
            MsgBox("No Residents Record Available")
            ResidentCount = 0
            tempCount = ResidentCount
            Return False
        Else
            ResidentCount = tempDt_residents.Rows.Count
            tempCount = ResidentCount
            Return True
        End If

    End Function

    Private Sub insert_R0(ByVal index As Integer)

        If (tempCount > 0) Then
            R0_name.Text = tempDt_residents.Rows(index).Item(0)
            R0_apartment.Text = tempDt_residents.Rows(index).Item(1)
            R0_phone.Text = tempDt_residents.Rows(index).Item(2)
            R0_profession.Text = tempDt_residents.Rows(index).Item(3)
            counter = counter + 1
        End If
    End Sub

    Private Sub insert_R1(ByVal index As Integer)
        If (tempCount > 0) Then
            R1_name.Text = tempDt_residents.Rows(index).Item(0)
            R1_apartment.Text = tempDt_residents.Rows(index).Item(1)
            R1_phone.Text = tempDt_residents.Rows(index).Item(2)
            R1_profession.Text = tempDt_residents.Rows(index).Item(3)
            counter = counter + 1
        End If
    End Sub

    Private Sub insert_R2(ByVal index As Integer)
        If (tempCount > 0) Then
            R2_name.Text = tempDt_residents.Rows(index).Item(0)
            R2_apartment.Text = tempDt_residents.Rows(index).Item(1)
            R2_phone.Text = tempDt_residents.Rows(index).Item(2)
            R2_profession.Text = tempDt_residents.Rows(index).Item(3)
            counter = counter + 1
        End If
    End Sub

    Private Sub indexCorrector(ByRef index As Integer)

        If (index < 0) Then
            counter = ResidentCount - 1
            index = counter

        ElseIf (index > ResidentCount - 1) Then
            counter = 0
            index = counter
        Else
        End If
    End Sub



    Private Sub generateValue(ByVal index As Integer)

        indexCorrector(index)
        insert_R0(index)

        index = index + 1
        indexCorrector(index)
        insert_R1(index)

        index = index + 1
        indexCorrector(index)
        insert_R2(index)

    End Sub


    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Hide()
        Form_UI.Show()
    End Sub

    Private Sub button_resident_Click(sender As Object, e As EventArgs) Handles button_resident.Click
        counter = 0
        If (getResidents()) Then
            generateValue(counter)
        End If
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


    Private Sub Form3_view_Residents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grihaDb.connect()
        counter = 0
        If (getResidents()) Then
            generateValue(counter)
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        generateValue(counter)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        generateValue(counter)
    End Sub


End Class