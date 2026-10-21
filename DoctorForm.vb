Imports Microsoft.Data.SqlClient

Public Class DoctorForm
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand("INSERT INTO dbo.Doctor (DoctorName, Department, Phone, Email, AvailableTime)
                               VALUES (@dname, @dept, @phone, @email, @time)", con)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtDoctorName.Text = "" Or txtDepartment.Text = "" Or txtTime.Text = "" Then
            MessageBox.Show("Please fill mandatory fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim cmd As New SqlCommand("INSERT INTO dbo.Doctor (DoctorName, Department, Phone, Email, AvailableTime)
                               VALUES (@dname, @dept, @phone, @email, @time)", con)

        cmd.Parameters.AddWithValue("@dname", txtDoctorName.Text)
        cmd.Parameters.AddWithValue("@dept", txtDepartment.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@time", txtTime.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Doctor details saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDoctorID.Clear()
        txtDoctorName.Clear()
        txtDepartment.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtTime.Clear()

        txtDoctorName.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtDoctorID.Text = "" Then
            MessageBox.Show("Please enter Doctor ID", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT * FROM dbo.Doctor WHERE DoctorID = @did", con)

        cmd.Parameters.AddWithValue("@did", txtDoctorID.Text)

        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            txtDoctorName.Text = dr("DoctorName").ToString()
            txtDepartment.Text = dr("Department").ToString()
            txtPhone.Text = dr("Phone").ToString()
            txtEmail.Text = dr("Email").ToString()
            txtTime.Text = dr("AvailableTime").ToString()
        Else
            MessageBox.Show("Doctor ID not found", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        con.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As New SqlCommand("
            UPDATE Doctor 
            SET DoctorName=@dname, Department=@dept, Phone=@phone 
            WHERE DoctorID=@did", con)

        cmd.Parameters.AddWithValue("@did", txtDoctorID.Text)
        cmd.Parameters.AddWithValue("@dname", txtDoctorName.Text)
        cmd.Parameters.AddWithValue("@dept", txtDepartment.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("Doctor updated successfully")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim count As Integer

        con.Open()

        ' Check if doctor has appointments
        cmd = New SqlCommand("Select Count(*) From Appointment Where DoctorID=@did", con)
        cmd.Parameters.AddWithValue("@did", txtDoctorID.Text)

        count = Convert.ToInt32(cmd.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("Cannot delete doctor. Appointments exist.")
            con.Close()
            Exit Sub
        End If

        ' Delete doctor
        cmd = New SqlCommand("Delete From Doctor Where DoctorID=@did", con)
        cmd.Parameters.AddWithValue("@did", txtDoctorID.Text)
        cmd.ExecuteNonQuery()

        con.Close()

        MessageBox.Show("Doctor deleted successfully")

    End Sub

    Private Sub btnShowAll_Click_1(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Dim da As New SqlDataAdapter("Select * From dbo.Doctor", con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class