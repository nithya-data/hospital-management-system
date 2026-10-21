Imports Microsoft.Data.SqlClient

Public Class RegisterForm
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtFullName.Text = "" Or txtUsername.Text = "" Or txtPhone.Text = "" _
       Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then

            MessageBox.Show("Please fill all fields")
            Exit Sub
        End If
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match")
            Exit Sub
        End If
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand("INSERT INTO Users (Username, Password, FullName, PhoneNumber) 
                               VALUES (@uname, @pwd, @fname, @phone)", con)

        cmd.Parameters.AddWithValue("@uname", txtUsername.Text)
        cmd.Parameters.AddWithValue("@pwd", txtPassword.Text)
        cmd.Parameters.AddWithValue("@fname", txtFullName.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("Registration Successful")
        Form1.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFullName.Clear()
        txtUsername.Clear()
        txtPhone.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

    End Sub


End Class