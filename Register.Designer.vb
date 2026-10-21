<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnRegister = New Button()
        btnClear = New Button()
        txtFullName = New TextBox()
        txtUsername = New TextBox()
        txtPhone = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        Panel1 = New Panel()
        lblTitle = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 23)
        Label1.TabIndex = 0
        Label1.Text = "Full Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(48, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 23)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(48, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 23)
        Label3.TabIndex = 2
        Label3.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(48, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 23)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(48, 289)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 23)
        Label5.TabIndex = 4
        Label5.Text = "Confirm Password"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.MediumSeaGreen
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(136, 372)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(220, 37)
        btnRegister.TabIndex = 5
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.IndianRed
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(440, 372)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(220, 37)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Location = New Point(307, 36)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(200, 30)
        txtFullName.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(307, 97)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(200, 30)
        txtUsername.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Location = New Point(307, 163)
        txtPhone.MaxLength = 10
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 30)
        txtPhone.TabIndex = 9
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(307, 226)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(200, 30)
        txtPassword.TabIndex = 10
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Location = New Point(307, 286)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(200, 30)
        txtConfirmPassword.TabIndex = 11
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(900, 71)
        Panel1.TabIndex = 12
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(254, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(322, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ADMIN REGISTRATION"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txtFullName)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(txtConfirmPassword)
        Panel2.Controls.Add(btnRegister)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtPhone)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(0, 70)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(900, 450)
        Panel2.TabIndex = 13
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(900, 518)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaximizeBox = False
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Registration"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel2 As Panel
End Class
