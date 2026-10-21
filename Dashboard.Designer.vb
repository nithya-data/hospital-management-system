<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        PanelHeader = New Panel()
        Label1 = New Label()
        PanelMenu = New Panel()
        btnlogout = New Button()
        btnPayment = New Button()
        btnApppointment = New Button()
        btnDoctor = New Button()
        btnPatient = New Button()
        Button1 = New Button()
        PanelMain = New Panel()
        btnRefresh = New Button()
        Panel3 = New Panel()
        lblPaymentCount = New Label()
        Label9 = New Label()
        PanelDoctor = New Panel()
        lblDoctorCount = New Label()
        Label7 = New Label()
        PanelAppointments = New Panel()
        lblAppointmentCount = New Label()
        Label5 = New Label()
        PanelPatients = New Panel()
        lblPatientCount = New Label()
        label3 = New Label()
        PanelHeader.SuspendLayout()
        PanelMenu.SuspendLayout()
        PanelMain.SuspendLayout()
        Panel3.SuspendLayout()
        PanelDoctor.SuspendLayout()
        PanelAppointments.SuspendLayout()
        PanelPatients.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.Teal
        PanelHeader.Controls.Add(Label1)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(800, 60)
        PanelHeader.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(181, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(426, 25)
        Label1.TabIndex = 0
        Label1.Text = "HOSPITAL MANAGEMENT SYSTEM"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.DarkSlateGray
        PanelMenu.Controls.Add(btnlogout)
        PanelMenu.Controls.Add(btnPayment)
        PanelMenu.Controls.Add(btnApppointment)
        PanelMenu.Controls.Add(btnDoctor)
        PanelMenu.Controls.Add(btnPatient)
        PanelMenu.Controls.Add(Button1)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 60)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(220, 390)
        PanelMenu.TabIndex = 1
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = Color.Teal
        btnlogout.FlatAppearance.BorderSize = 0
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogout.ForeColor = Color.White
        btnlogout.Location = New Point(28, 331)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(130, 45)
        btnlogout.TabIndex = 5
        btnlogout.Text = "Logout"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' btnPayment
        ' 
        btnPayment.BackColor = Color.Teal
        btnPayment.FlatAppearance.BorderSize = 0
        btnPayment.FlatStyle = FlatStyle.Flat
        btnPayment.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPayment.ForeColor = Color.White
        btnPayment.Location = New Point(28, 266)
        btnPayment.Name = "btnPayment"
        btnPayment.Size = New Size(130, 45)
        btnPayment.TabIndex = 4
        btnPayment.Text = "Payment"
        btnPayment.UseVisualStyleBackColor = False
        ' 
        ' btnApppointment
        ' 
        btnApppointment.BackColor = Color.Teal
        btnApppointment.FlatAppearance.BorderSize = 0
        btnApppointment.FlatStyle = FlatStyle.Flat
        btnApppointment.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnApppointment.ForeColor = Color.White
        btnApppointment.Location = New Point(28, 203)
        btnApppointment.Name = "btnApppointment"
        btnApppointment.Size = New Size(130, 45)
        btnApppointment.TabIndex = 3
        btnApppointment.Text = "Appointment"
        btnApppointment.UseVisualStyleBackColor = False
        ' 
        ' btnDoctor
        ' 
        btnDoctor.BackColor = Color.Teal
        btnDoctor.FlatAppearance.BorderSize = 0
        btnDoctor.FlatStyle = FlatStyle.Flat
        btnDoctor.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDoctor.ForeColor = Color.White
        btnDoctor.Location = New Point(28, 142)
        btnDoctor.Name = "btnDoctor"
        btnDoctor.Size = New Size(130, 45)
        btnDoctor.TabIndex = 2
        btnDoctor.Text = "Doctor"
        btnDoctor.UseVisualStyleBackColor = False
        ' 
        ' btnPatient
        ' 
        btnPatient.BackColor = Color.Teal
        btnPatient.FlatAppearance.BorderSize = 0
        btnPatient.FlatStyle = FlatStyle.Flat
        btnPatient.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPatient.ForeColor = Color.White
        btnPatient.Location = New Point(28, 81)
        btnPatient.Name = "btnPatient"
        btnPatient.Size = New Size(130, 45)
        btnPatient.TabIndex = 1
        btnPatient.Text = "Patient"
        btnPatient.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(28, 15)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 45)
        Button1.TabIndex = 0
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.WhiteSmoke
        PanelMain.Controls.Add(btnRefresh)
        PanelMain.Controls.Add(Panel3)
        PanelMain.Controls.Add(PanelDoctor)
        PanelMain.Controls.Add(PanelAppointments)
        PanelMain.Controls.Add(PanelPatients)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(220, 60)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(580, 390)
        PanelMain.TabIndex = 2
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(477, 10)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(94, 29)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lblPaymentCount)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(327, 230)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(214, 125)
        Panel3.TabIndex = 3
        ' 
        ' lblPaymentCount
        ' 
        lblPaymentCount.AutoSize = True
        lblPaymentCount.BackColor = Color.White
        lblPaymentCount.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPaymentCount.ForeColor = Color.Teal
        lblPaymentCount.Location = New Point(10, 56)
        lblPaymentCount.Name = "lblPaymentCount"
        lblPaymentCount.Size = New Size(120, 46)
        lblPaymentCount.TabIndex = 3
        lblPaymentCount.Text = "20000"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = SystemColors.GrayText
        Label9.Location = New Point(10, 10)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 20)
        Label9.TabIndex = 0
        Label9.Text = "Total Payment"
        ' 
        ' PanelDoctor
        ' 
        PanelDoctor.BackColor = Color.White
        PanelDoctor.BorderStyle = BorderStyle.FixedSingle
        PanelDoctor.Controls.Add(lblDoctorCount)
        PanelDoctor.Controls.Add(Label7)
        PanelDoctor.Location = New Point(327, 61)
        PanelDoctor.Name = "PanelDoctor"
        PanelDoctor.Size = New Size(214, 120)
        PanelDoctor.TabIndex = 2
        ' 
        ' lblDoctorCount
        ' 
        lblDoctorCount.AutoSize = True
        lblDoctorCount.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDoctorCount.ForeColor = Color.Teal
        lblDoctorCount.Location = New Point(10, 45)
        lblDoctorCount.Name = "lblDoctorCount"
        lblDoctorCount.Size = New Size(60, 46)
        lblDoctorCount.TabIndex = 1
        lblDoctorCount.Text = "15"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.GrayText
        Label7.Location = New Point(10, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 20)
        Label7.TabIndex = 0
        Label7.Text = "Total Doctor"
        ' 
        ' PanelAppointments
        ' 
        PanelAppointments.BackColor = Color.White
        PanelAppointments.BorderStyle = BorderStyle.FixedSingle
        PanelAppointments.Controls.Add(lblAppointmentCount)
        PanelAppointments.Controls.Add(Label5)
        PanelAppointments.Location = New Point(74, 230)
        PanelAppointments.Name = "PanelAppointments"
        PanelAppointments.Size = New Size(220, 125)
        PanelAppointments.TabIndex = 1
        ' 
        ' lblAppointmentCount
        ' 
        lblAppointmentCount.AutoSize = True
        lblAppointmentCount.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppointmentCount.ForeColor = Color.Teal
        lblAppointmentCount.Location = New Point(10, 45)
        lblAppointmentCount.Name = "lblAppointmentCount"
        lblAppointmentCount.Size = New Size(60, 46)
        lblAppointmentCount.TabIndex = 1
        lblAppointmentCount.Text = "24"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.GrayText
        Label5.Location = New Point(10, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 20)
        Label5.TabIndex = 0
        Label5.Text = "Total Appointments"
        ' 
        ' PanelPatients
        ' 
        PanelPatients.BackColor = Color.White
        PanelPatients.BorderStyle = BorderStyle.FixedSingle
        PanelPatients.Controls.Add(lblPatientCount)
        PanelPatients.Controls.Add(label3)
        PanelPatients.Location = New Point(74, 61)
        PanelPatients.Name = "PanelPatients"
        PanelPatients.Size = New Size(220, 120)
        PanelPatients.TabIndex = 0
        ' 
        ' lblPatientCount
        ' 
        lblPatientCount.AutoSize = True
        lblPatientCount.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPatientCount.ForeColor = Color.Teal
        lblPatientCount.Location = New Point(10, 45)
        lblPatientCount.Name = "lblPatientCount"
        lblPatientCount.Size = New Size(80, 46)
        lblPatientCount.TabIndex = 1
        lblPatientCount.Text = "120"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.ForeColor = SystemColors.GrayText
        label3.Location = New Point(10, 10)
        label3.Name = "label3"
        label3.Size = New Size(97, 20)
        label3.TabIndex = 0
        label3.Text = "Total Patients"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(PanelMain)
        Controls.Add(PanelMenu)
        Controls.Add(PanelHeader)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hospital Dashboard"
        WindowState = FormWindowState.Maximized
        PanelHeader.ResumeLayout(False)
        PanelMenu.ResumeLayout(False)
        PanelMain.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        PanelDoctor.ResumeLayout(False)
        PanelDoctor.PerformLayout()
        PanelAppointments.ResumeLayout(False)
        PanelAppointments.PerformLayout()
        PanelPatients.ResumeLayout(False)
        PanelPatients.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnApppointment As Button
    Friend WithEvents btnDoctor As Button
    Friend WithEvents btnPatient As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelPatients As Panel
    Friend WithEvents lblPatientCount As Label
    Friend WithEvents label3 As Label
    Friend WithEvents PanelAppointments As Panel
    Friend WithEvents lblAppointmentCount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelDoctor As Panel
    Friend WithEvents lblDoctorCount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPaymentCount As Label
    Friend WithEvents btnRefresh As Button
End Class
