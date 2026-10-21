<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        lnkRegister = New LinkLabel()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Teal
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(117, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 31)
        Label2.TabIndex = 1
        Label2.Text = "ADMIN LOGIN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkGray
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 28)
        Label3.TabIndex = 2
        Label3.Text = "USERNAME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DarkGray
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(30, 276)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 28)
        Label4.TabIndex = 3
        Label4.Text = "PASSWORD"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(215, 173)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(125, 27)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(215, 276)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(125, 27)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Teal
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(115, 347)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(171, 38)
        btnLogin.TabIndex = 6
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.BackgroundImage = My.Resources.Resources.HOSPITAL1
        Panel1.Location = New Point(52, 451)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(447, 10)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(24, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 56)
        Label1.TabIndex = 0
        Label1.Text = "HOSPITAL MANAGEMENT SYSTEM" & vbCrLf & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.HOSPITAL1
        Panel2.Location = New Point(-1, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(500, 459)
        Panel2.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Teal
        Panel3.Controls.Add(lnkRegister)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(btnLogin)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(txtUsername)
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(496, -1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(374, 459)
        Panel3.TabIndex = 9
        ' 
        ' lnkRegister
        ' 
        lnkRegister.AutoSize = True
        lnkRegister.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lnkRegister.LinkColor = Color.WhiteSmoke
        lnkRegister.Location = New Point(115, 407)
        lnkRegister.Name = "lnkRegister"
        lnkRegister.Size = New Size(189, 25)
        lnkRegister.TabIndex = 7
        lnkRegister.TabStop = True
        lnkRegister.Text = "Click here to Register"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(872, 450)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hospital Management System"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lnkRegister As LinkLabel

End Class
