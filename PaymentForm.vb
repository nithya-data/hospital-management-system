Imports Microsoft.Data.SqlClient
Imports Windows.Win32.System

Public Class PaymentForm
    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT ISNULL(MAX(PaymentID), 0) + 1 FROM Payment", con)
        con.Open()
        txtPaymentID.Text = cmd.ExecuteScalar().ToString()
        con.Close()
        dtpPaymentDate.Value = Date.Today
        cmbPaymentStatus.Text = "Paid"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAppointmentID.Text = "" Or txtPatientName.Text = "" Or txtAmount.Text = "" Then
            MessageBox.Show("Please fill all required fields")
            Exit Sub
        End If
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand("INSERT INTO dbo.Payment (AppointmentID, PatientName, ConsultingAmount, PaymentMode, PaymentDate, PaymentStatus)
                               VALUES (@aid,@pname,@amount,@mode,@date,@status)", con)
        cmd.Parameters.AddWithValue("@aid", txtAppointmentID.Text)
        cmd.Parameters.AddWithValue("@pname", txtPatientName.Text)
        cmd.Parameters.AddWithValue("@amount", txtAmount.Text)
        cmd.Parameters.AddWithValue("@mode", cmbPaymentMode.Text)
        cmd.Parameters.AddWithValue("@date", dtpPaymentDate.Value.Date)
        cmd.Parameters.AddWithValue("@status", cmbPaymentStatus.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Payment Saved Successfully")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand("
SELECT PatientName, ConsultingAmount 
FROM Appointment 
WHERE AppointmentID = @aid", con)

        cmd.Parameters.AddWithValue("@aid", txtAppointmentID.Text)

        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            txtPatientName.Text = dr("PatientName").ToString()
            txtAmount.Text = dr("ConsultingAmount").ToString()   ' 👈 AUTO FILL
        Else
            MessageBox.Show("Appointment not found")
        End If

        dr.Close()
        con.Close()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim da As New SqlDataAdapter("SELECT * FROM dbo.Payment", con)
        Dim dt As New DataTable()

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAppointmentID.Clear()
        txtPatientName.Clear()
        txtAmount.Clear()
        cmbPaymentMode.SelectedIndex = -1
        cmbPaymentStatus.SelectedIndex = -1
        dtpPaymentDate.Value = Date.Today
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        rtbReceipt.Clear()

        rtbReceipt.AppendText("HOSPITAL MANAGEMENT SYSTEM" & vbCrLf)
        rtbReceipt.AppendText("PAYMENT RECEIPT" & vbCrLf)
        rtbReceipt.AppendText("        -------------------------" & vbCrLf & vbCrLf)

        rtbReceipt.AppendText("Payment ID      : " & txtPaymentID.Text & vbCrLf)
        rtbReceipt.AppendText("Appointment ID  : " & txtAppointmentID.Text & vbCrLf)
        rtbReceipt.AppendText("Patient Name    : " & txtPatientName.Text & vbCrLf & vbCrLf)

        rtbReceipt.AppendText("Payment Mode    : " & cmbPaymentMode.Text & vbCrLf)
        rtbReceipt.AppendText("Amount Paid     : ₹ " & txtAmount.Text & vbCrLf)
        rtbReceipt.AppendText("Payment Date    : " & dtpPaymentDate.Value.ToShortDateString() & vbCrLf)
        rtbReceipt.AppendText("Status          : " & cmbPaymentStatus.Text & vbCrLf & vbCrLf)

        rtbReceipt.AppendText("---------------------------------" & vbCrLf)
        rtbReceipt.AppendText("Thank you for choosing our hospital" & vbCrLf)
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        If txtPaymentID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Payment ID")
            Exit Sub
        End If

        Dim cmd As New SqlCommand(
        "UPDATE Payment 
         SET PaymentMode = @mode,
          PaymentStatus = @Paymentstatus,
             PaymentDate = @pdate
         WHERE PaymentID = @pid", con)

        cmd.Parameters.Add("@mode", SqlDbType.VarChar).Value = cmbPaymentMode.Text
        cmd.Parameters.Add("@Paymentstatus", SqlDbType.VarChar).Value = cmbPaymentStatus.Text
        cmd.Parameters.Add("@pdate", SqlDbType.DateTime).Value = dtpPaymentDate.Value
        cmd.Parameters.Add("@pid", SqlDbType.Int).Value = CInt(txtPaymentID.Text.Trim())

        con.Open()
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        con.Close()

        If rowsAffected > 0 Then
            MessageBox.Show("Payment updated successfully")
        Else
            MessageBox.Show("Payment ID not found")
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 12)
        e.Graphics.DrawString(rtbReceipt.Text, font, Brushes.Black, 10, 10)
    End Sub
End Class
