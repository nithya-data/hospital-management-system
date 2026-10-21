<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        Label6 = New Label()
        Label7 = New Label()
        txtPatientName = New TextBox()
        txtAppointmentID = New TextBox()
        cmbDoctorName = New ComboBox()
        txtDepartment = New TextBox()
        dtpAppointmentDate = New DateTimePicker()
        txtAppointmentTime = New TextBox()
        cmbStatus = New ComboBox()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnShowAll = New Button()
        btnBack = New Button()
        DataGridView1 = New DataGridView()
        Label8 = New Label()
        txtReason = New TextBox()
        Label9 = New Label()
        Panel1 = New Panel()
        btnSearch = New Button()
        Label10 = New Label()
        Panel2 = New Panel()
        Label11 = New Label()
        txtAmount = New TextBox()
        Label12 = New Label()
        txtDoctorID = New TextBox()
        txtPatientID = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 28)
        Label1.TabIndex = 0
        Label1.Text = "Appointment ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 365)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 28)
        Label2.TabIndex = 1
        Label2.Text = "Patient Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 290)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 28)
        Label3.TabIndex = 2
        Label3.Text = "Doctor Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(487, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 28)
        Label4.TabIndex = 3
        Label4.Text = "Department"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(487, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(190, 28)
        Label5.TabIndex = 4
        Label5.Text = "Appointment Time"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(487, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 28)
        Label6.TabIndex = 5
        Label6.Text = "Appointment Date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(487, 286)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 28)
        Label7.TabIndex = 6
        Label7.Text = "Status"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.BackColor = Color.White
        txtPatientName.BorderStyle = BorderStyle.FixedSingle
        txtPatientName.Location = New Point(236, 363)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(125, 27)
        txtPatientName.TabIndex = 7
        ' 
        ' txtAppointmentID
        ' 
        txtAppointmentID.BackColor = Color.Gainsboro
        txtAppointmentID.Location = New Point(236, 86)
        txtAppointmentID.Name = "txtAppointmentID"
        txtAppointmentID.Size = New Size(125, 27)
        txtAppointmentID.TabIndex = 8
        ' 
        ' cmbDoctorName
        ' 
        cmbDoctorName.BackColor = Color.White
        cmbDoctorName.FormattingEnabled = True
        cmbDoctorName.Items.AddRange(New Object() {"Dr Sanjeev", "Dr Prakash", "Dr Divya Darani", "Dr Monika", "Dr Karthik"})
        cmbDoctorName.Location = New Point(236, 290)
        cmbDoctorName.Name = "cmbDoctorName"
        cmbDoctorName.Size = New Size(125, 28)
        cmbDoctorName.TabIndex = 9
        ' 
        ' txtDepartment
        ' 
        txtDepartment.AutoCompleteCustomSource.AddRange(New String() {"Pediatrician", "Cardiologist", "Dermatology", "Neurology", "General Doctor(MBBS)"})
        txtDepartment.BackColor = Color.White
        txtDepartment.BorderStyle = BorderStyle.FixedSingle
        txtDepartment.Location = New Point(710, 86)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(125, 27)
        txtDepartment.TabIndex = 10
        ' 
        ' dtpAppointmentDate
        ' 
        dtpAppointmentDate.CalendarMonthBackground = Color.White
        dtpAppointmentDate.Location = New Point(710, 153)
        dtpAppointmentDate.Name = "dtpAppointmentDate"
        dtpAppointmentDate.Size = New Size(156, 27)
        dtpAppointmentDate.TabIndex = 11
        ' 
        ' txtAppointmentTime
        ' 
        txtAppointmentTime.BackColor = Color.White
        txtAppointmentTime.BorderStyle = BorderStyle.FixedSingle
        txtAppointmentTime.Location = New Point(710, 218)
        txtAppointmentTime.Name = "txtAppointmentTime"
        txtAppointmentTime.Size = New Size(156, 27)
        txtAppointmentTime.TabIndex = 12
        ' 
        ' cmbStatus
        ' 
        cmbStatus.BackColor = Color.White
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Pending", "Confirmed", "Completed", "Cancelled"})
        cmbStatus.Location = New Point(710, 286)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(156, 28)
        cmbStatus.TabIndex = 13
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.MistyRose
        btnSave.Location = New Point(40, 477)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 39)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.LightCoral
        btnUpdate.Location = New Point(220, 477)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 39)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.IndianRed
        btnDelete.Location = New Point(410, 477)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 39)
        btnDelete.TabIndex = 16
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DarkSalmon
        btnClear.Location = New Point(583, 477)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 39)
        btnClear.TabIndex = 17
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnShowAll
        ' 
        btnShowAll.BackColor = Color.RosyBrown
        btnShowAll.ForeColor = Color.Black
        btnShowAll.Location = New Point(397, 142)
        btnShowAll.Name = "btnShowAll"
        btnShowAll.Size = New Size(94, 39)
        btnShowAll.TabIndex = 18
        btnShowAll.Text = "Show All"
        btnShowAll.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.PeachPuff
        btnBack.Location = New Point(772, 477)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 39)
        btnBack.TabIndex = 19
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.LightGray
        DataGridView1.Location = New Point(-3, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(894, 239)
        DataGridView1.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(487, 362)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 28)
        Label8.TabIndex = 21
        Label8.Text = "Reason"
        ' 
        ' txtReason
        ' 
        txtReason.BackColor = Color.White
        txtReason.BorderStyle = BorderStyle.FixedSingle
        txtReason.Location = New Point(710, 340)
        txtReason.Multiline = True
        txtReason.Name = "txtReason"
        txtReason.Size = New Size(156, 50)
        txtReason.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(281, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(309, 28)
        Label9.TabIndex = 23
        Label9.Text = "APPOINTMENT MANAGEMENT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateBlue
        Panel1.Controls.Add(Label9)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(894, 60)
        Panel1.TabIndex = 24
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(367, 86)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(61, 29)
        btnSearch.TabIndex = 25
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(17, 151)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 28)
        Label10.TabIndex = 26
        Label10.Text = "Doctor ID"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnShowAll)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(0, 536)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(894, 193)
        Panel2.TabIndex = 28
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(476, 415)
        Label11.Name = "Label11"
        Label11.Size = New Size(195, 28)
        Label11.TabIndex = 29
        Label11.Text = "Consulting Amount"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(741, 415)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(125, 27)
        txtAmount.TabIndex = 30
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(17, 217)
        Label12.Name = "Label12"
        Label12.Size = New Size(101, 28)
        Label12.TabIndex = 31
        Label12.Text = "PatientID"
        ' 
        ' txtDoctorID
        ' 
        txtDoctorID.Location = New Point(236, 151)
        txtDoctorID.Name = "txtDoctorID"
        txtDoctorID.Size = New Size(125, 27)
        txtDoctorID.TabIndex = 32
        ' 
        ' txtPatientID
        ' 
        txtPatientID.Location = New Point(236, 218)
        txtPatientID.Name = "txtPatientID"
        txtPatientID.Size = New Size(125, 27)
        txtPatientID.TabIndex = 33
        ' 
        ' Appointment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.appointment
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(894, 729)
        Controls.Add(txtPatientID)
        Controls.Add(txtDoctorID)
        Controls.Add(Label12)
        Controls.Add(txtAmount)
        Controls.Add(Label11)
        Controls.Add(Panel2)
        Controls.Add(Label10)
        Controls.Add(btnSearch)
        Controls.Add(Panel1)
        Controls.Add(txtReason)
        Controls.Add(Label8)
        Controls.Add(btnBack)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(cmbStatus)
        Controls.Add(txtAppointmentTime)
        Controls.Add(dtpAppointmentDate)
        Controls.Add(txtDepartment)
        Controls.Add(cmbDoctorName)
        Controls.Add(txtAppointmentID)
        Controls.Add(txtPatientName)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Appointment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Appointment Management"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents txtAppointmentID As TextBox
    Friend WithEvents cmbDoctorName As ComboBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents dtpAppointmentDate As DateTimePicker
    Friend WithEvents txtAppointmentTime As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label10 As Label
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDoctorID As TextBox
    Friend WithEvents txtPatientID As TextBox
End Class
