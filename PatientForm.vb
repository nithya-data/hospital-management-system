Imports Microsoft.Data.SqlClient

Public Class PatientForm
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPatientName.Text = "" Or txtAge.Text = "" Or cmbGender.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Then
            MessageBox.Show("Please fill all the fields")
            Exit Sub
        End If
        Try
            Dim cmd As New SqlCommand("Insert into dbo.Patients ([Patient Name], Age, Gender, Phone, Address)
            Values (@pname, @age, @gender, @phone, @address)", con)
            cmd.Parameters.AddWithValue("@pname", txtPatientName.Text)
            cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text))
            cmd.Parameters.AddWithValue("@gender", cmbGender.Text)
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Patient saved successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPatientId.Clear()
        txtPatientName.Clear()
        txtAge.Clear()
        cmbGender.SelectedIndex = -1
        txtPhone.Clear()
        txtAddress.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim cmd As New SqlCommand("Select [Patient Name],Age,Gender,Phone,Address
        From dbo.Patients Where Patientid=@pid", con)
        cmd.Parameters.AddWithValue("@pid", txtPatientId.Text)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            txtPatientName.Text = dr("Patient Name").ToString()
            txtAge.Text = dr("Age").ToString()
            cmbGender.Text = dr("Gender").ToString()
            txtPhone.Text = dr("Phone").ToString()
            txtAddress.Text = dr("Address").ToString()
        Else
            MessageBox.Show("Patient not found")
        End If
        con.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As New SqlCommand("Update dbo.Patients Set [Patient Name]=@pname,Age=@age,Gender=@gender,Phone=@phone,address=@address Where PatientId=@pid", con)
        cmd.Parameters.AddWithValue("@pid", txtPatientId.Text)
        cmd.Parameters.AddWithValue("@pname", txtPatientName.Text)
        cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text))
        cmd.Parameters.AddWithValue("@gender", cmbGender.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@address", txtAddress.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Patient updated successfully")

    End Sub


    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Dim dt As New DataTable
        Dim cmd As New SqlDataAdapter("Select PatientId,[Patient Name],Age,Gender,Phone,Address From dbo.Patients", con)
        cmd.Fill(dt)
        dvgPatients.DataSource = dt
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtAddress.Text = "" Then
            MessageBox.Show("Please enter Patient ID to delete")
            Exit Sub
        End If
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this Patient?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim cmd As New SqlCommand("Delete From dbo.Patients Where PatientId=@pid", con)
            cmd.Parameters.AddWithValue("@pid", txtPatientId.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Patient deleted successfully")
            btnShowAll.PerformClick()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class
