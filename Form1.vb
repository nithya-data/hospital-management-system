Imports Microsoft.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithy\OneDrive\Documents\Hms.mdf;Integrated Security=True")
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter Username and Password")
            Exit Sub

        End If
        Dim cmd As New SqlCommand("Select Count(*) From Users Where Username=@u AND Password=@p", con)
        cmd.Parameters.AddWithValue("@u", txtUsername.Text)
        cmd.Parameters.AddWithValue("@p", txtPassword.Text)
        con.open()
        Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        con.Close()
        If result = 1 Then
            MessageBox.Show("Login Successful,Welcome")
            Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or Password")
        End If
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        RegisterForm.Show()
        Me.Hide()
    End Sub
End Class



