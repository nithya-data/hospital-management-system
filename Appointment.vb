Imports Microsoft.Data.SqlClient
Imports Windows.Win32.System
Public Class Appointment
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand("Insert Into dbo.Appointment (patientID,DoctorID,PatientName, DoctorName, Department, AppointmentDate, AppointmentTime, Reason, Status, ConsultingAmount)
                                  Values (@pid,@did,@pname,@dname,@dept,@adate,@atime,@reason,@status,@amount)", con)
        cmd.Parameters.AddWithValue("@pid", txtPatientID.Text)
        cmd.Parameters.AddWithValue("@did", txtDoctorID.Text)
        cmd.Parameters.AddWithValue("@pname", txtPatientName.Text)
        cmd.Parameters.AddWithValue("@dname", cmbDoctorName.Text)
        cmd.Parameters.AddWithValue("@dept", txtDepartment.Text)
        cmd.Parameters.AddWithValue("@adate", dtpAppointmentDate.Value.Date)
        cmd.Parameters.AddWithValue("@atime", txtAppointmentTime.Text)
        cmd.Parameters.AddWithValue("@reason", txtReason.Text)
        cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
        cmd.Parameters.AddWithValue("@amount ", Convert.ToDecimal(txtAmount.Text))
        If txtPatientID.Text = "" Or txtDoctorID.Text = "" Then
            MessageBox.Show("Please enter Patient ID and Doctor ID")
            Exit Sub
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Appointment scheduled successfully")
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Exit Sub
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtAppointmentID.Text = row.Cells(0).Value.ToString()
            txtPatientName.Text = row.Cells(1).Value.ToString()
            cmbDoctorName.Text = row.Cells(2).Value.ToString()
            txtDepartment.Text = row.Cells(3).Value.ToString()
            dtpAppointmentDate.Value = Convert.ToDateTime(row.Cells(4).Value)
            txtAppointmentTime.Text = row.Cells(5).Value.ToString()
            txtReason.Text = row.Cells(6).Value.ToString()
            cmbStatus.Text = row.Cells(7).Value.ToString()
            txtAmount.Text = row.Cells(8).Value.ToString()
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim da As New SqlDataAdapter("Select * From dbo.Appointment", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtAppointmentID.Text = "" Then
            MessageBox.Show("Please select an appointment to update")
            Exit Sub
        End If
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")

        Dim cmd As New SqlCommand("UPDATE Appointment 
                               SET PatientName=@pname,
                                   DoctorName=@dname,
                                   Department=@dept,
                                   AppointmentDate=@adate,
                                   AppointmentTime=@atime,
                                   Reason=@reason,
                                   Status=@status
                               WHERE AppointmentID=@aid", con)

        cmd.Parameters.AddWithValue("@pname", txtPatientName.Text)
        cmd.Parameters.AddWithValue("@dname", cmbDoctorName.Text)
        cmd.Parameters.AddWithValue("@dept", txtDepartment.Text)
        cmd.Parameters.AddWithValue("@adate", dtpAppointmentDate.Value.Date)
        cmd.Parameters.AddWithValue("@atime", txtAppointmentTime.Text)
        cmd.Parameters.AddWithValue("@reason", txtReason.Text)
        cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
        cmd.Parameters.AddWithValue("@aid", txtAppointmentID.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("Appointment Updated Successfully")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        con.Open()

        Dim cmd1 As New SqlCommand("DELETE FROM Payment WHERE AppointmentID=@aid", con)
        cmd1.Parameters.AddWithValue("@aid", txtAppointmentID.Text)
        cmd1.ExecuteNonQuery()

        Dim cmd2 As New SqlCommand("DELETE FROM Appointment WHERE AppointmentID=@aid", con)
        cmd2.Parameters.AddWithValue("@aid", txtAppointmentID.Text)
        cmd2.ExecuteNonQuery()

        con.Close()

        MessageBox.Show("Appointment Deleted Successfully")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtAppointmentID.Text = "" Then
            MessageBox.Show("Please enter Appointment ID")
            Exit Sub
        End If

        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim da As New SqlDataAdapter("SELECT * FROM dbo.Appointment WHERE AppointmentID = @aid", con)
        Dim dt As New DataTable()

        da.SelectCommand.Parameters.AddWithValue("@aid", txtAppointmentID.Text)

        da.Fill(dt)
        DataGridView1.DataSource = dt

        If dt.Rows.Count > 0 Then
            txtAppointmentID.Text = dt.Rows(0)(0).ToString()
            txtPatientName.Text = dt.Rows(0)(1).ToString()
            cmbDoctorName.Text = dt.Rows(0)(2).ToString()
            txtDepartment.Text = dt.Rows(0)(3).ToString()
            dtpAppointmentDate.Value = Convert.ToDateTime(dt.Rows(0)(4))
            txtAppointmentTime.Text = dt.Rows(0)(5).ToString()
            txtReason.Text = dt.Rows(0)(6).ToString()
            cmbStatus.Text = dt.Rows(0)(7).ToString()
            txtAmount.Text = dt.Rows(0)("ConsultingAmount").ToString()
        Else
            MessageBox.Show("No record found")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAppointmentID.Clear()
        txtPatientName.Clear()
        cmbDoctorName.SelectedIndex = -1
        cmbDoctorName.Text = ""
        txtDepartment.Clear()
        txtAppointmentTime.Clear()
        txtReason.Clear()
        txtPatientID.Clear()
        txtDoctorID.Clear()
        cmbStatus.SelectedIndex = -1
        cmbStatus.Text = ""
        dtpAppointmentDate.Value = Date.Today
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub txtDoctorID_TextChanged(sender As Object, e As EventArgs) Handles txtDoctorID.TextChanged

    End Sub

    Private Sub txtDoctorID_Leave(sender As Object, e As EventArgs) Handles txtDoctorID.Leave
        If txtDoctorID.Text = "" Then Exit Sub

        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand(
        "SELECT DoctorName, Department FROM dbo.Doctor WHERE DoctorID = @did", con)

        cmd.Parameters.AddWithValue("@did", txtDoctorID.Text)

        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            cmbDoctorName.Text = dr("DoctorName").ToString()
            txtDepartment.Text = dr("Department").ToString()
        Else
            MessageBox.Show("Doctor ID not found")
            cmbDoctorName.SelectedIndex = -1
            txtDepartment.Clear()
        End If

        con.Close()

    End Sub

    Private Sub txtPatientID_TextChanged(sender As Object, e As EventArgs) Handles txtPatientID.TextChanged

        If txtPatientID.Text = "" Then Exit Sub


        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand(
        "SELECT [Patient Name] FROM dbo.Patients WHERE PatientID = @pid", con)

        cmd.Parameters.AddWithValue("@pid", txtPatientID.Text)

        con.Open()
        Dim result As Object = cmd.ExecuteScalar()
        con.Close()

        If result IsNot Nothing Then
            txtPatientName.Text = result.ToString()
        Else
            txtPatientName.Clear()
        End If

    End Sub
End Class