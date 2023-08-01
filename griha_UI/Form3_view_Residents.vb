Public Class Form3_view_Residents

    Dim query As String
    Dim tempDt_residents As DataTable
    Dim counter As Integer = 0
    Dim ResidentCount As Integer
    Dim tempCount As Integer
    Dim tempDt_secretary As DataTable
    Dim tempDt_guard As DataTable

    Private Function getTable(ByVal post As String) As DataTable
        Dim tempDt As DataTable
        If (post = "Residents") Then
            query = $"SELECT ISNULL(First_Name,'') + ' ' + ISNULL(Last_Name,'') AS 'Full Name', Apartment_id, Phone1, Profession from {post}"
        End If

        If (post = "Secretary") Then
            query = $"SELECT ISNULL(First_Name,'') + ' ' + ISNULL(Last_Name,'') AS 'Full Name', Apartment_id, Phone1 from {post}"
        End If

        If (post = "Guards") Then
            query = $"SELECT ISNULL(First_Name,'') + ' ' + ISNULL(Last_Name,'') AS 'Full Name', Shift, Phone1 from {post}"
        End If

        tempDt = grihaDb.generateTable(query)
        Return tempDt

    End Function

    Private Sub generateValue_Secretary()
        If (tempDt_secretary.Rows.Count <> 0) Then
            Dim index As Integer = 0
            S_name.Text = tempDt_secretary.Rows(index).Item(0)
            S_apartment.Text = tempDt_secretary.Rows(index).Item(1)
            S_phone.Text = tempDt_secretary.Rows(index).Item(2)
        End If
    End Sub

    Private Sub generateValue_Guards()
        If (tempDt_guard.Rows.Count <> 0) Then
            G0_name.Text = tempDt_guard.Rows(0).Item(0)
            G0_shift.Text = tempDt_guard.Rows(0).Item(1)
            G0_phone.Text = tempDt_guard.Rows(0).Item(2)
            G1_name.Text = tempDt_guard.Rows(1).Item(0)
            G1_shift.Text = tempDt_guard.Rows(1).Item(1)
            G1_phone.Text = tempDt_guard.Rows(1).Item(2)
        End If
    End Sub



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



    Private Sub generateValue_Residents(ByVal index As Integer)



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
        tempDt_residents = getTable("Residents")
        If (tempDt_residents Is Nothing) Then
            MsgBox("No Residents Record Available")
        Else
            ResidentCount = tempDt_residents.Rows.Count
            tempCount = ResidentCount
            generateValue_Residents(counter)

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

        'for residents data
        counter = 0
        tempDt_residents = getTable("Residents")
        If (tempDt_residents Is Nothing) Then
            MsgBox("No Residents Record Available")
        Else
            ResidentCount = tempDt_residents.Rows.Count
            tempCount = ResidentCount
            generateValue_Residents(counter)
        End If

        'for secretary data
        tempDt_secretary = getTable("Secretary")
        generateValue_Secretary()

        'for guard data
        tempDt_guard = getTable("Guards")
        generateValue_Guards()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        generateValue_Residents(counter)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        generateValue_Residents(counter)
    End Sub

End Class