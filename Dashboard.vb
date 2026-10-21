Imports Microsoft.Data.SqlClient
Public Class Dashboard
    Public Sub LoadDashboardData()

        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")

        con.Open()

        Dim cmd As SqlCommand

        cmd = New SqlCommand("Select Count(*) From dbo.Patients", con)
        lblPatientCount.Text = cmd.ExecuteScalar().ToString()

        cmd = New SqlCommand("Select Count(*) From dbo.Doctor", con)
        lblDoctorCount.Text = cmd.ExecuteScalar().ToString()

        cmd = New SqlCommand("Select Count(*) From dbo.Appointment", con)
        lblAppointmentCount.Text = cmd.ExecuteScalar().ToString()

        cmd = New SqlCommand("Select Count(*) From dbo.Payment", con)
        lblPaymentCount.Text = cmd.ExecuteScalar().ToString()

        con.Close()

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand("Select Count(*) From dbo.Patients", con)
        con.Open()
        lblPatientCount.Text = cmd.ExecuteScalar().ToString()
        con.Close()
        Dim cmdDoctor As New SqlCommand("Select Count(*) From dbo.Doctor", con)
        con.Open()
        lblDoctorCount.Text = cmdDoctor.ExecuteScalar().ToString()
        con.Close()
        Dim cmdAppointment As New SqlCommand("Select Count(*) From dbo.Appointment", con)
        con.Open()
        lblAppointmentCount.Text = cmdAppointment.ExecuteScalar().ToString()
        con.Close()
        Dim cmdPayment As New SqlCommand("Select Count(*) From dbo.Payment", con)
        con.Open()
        lblPaymentCount.Text = cmdPayment.ExecuteScalar().ToString()
        con.Close()

    End Sub


    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        Dim p As New PatientForm()
        p.Show()
    End Sub

    Private Sub btnDoctor_Click(sender As Object, e As EventArgs) Handles btnDoctor.Click
        DoctorForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnApppointment_Click(sender As Object, e As EventArgs) Handles btnApppointment.Click
        Appointment.Show()
        Me.Hide()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        PaymentForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        btnlogout.Show()
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()   ' your login form name
        Else
            Return   ' 👈 VERY IMPORTANT
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDashboardData()
        MessageBox.Show("Dashboard refreshed successfully")
    End Sub
End Class