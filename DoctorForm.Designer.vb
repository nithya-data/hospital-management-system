<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorForm
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
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        txtTime = New TextBox()
        txtEmail = New TextBox()
        Label5 = New Label()
        txtPhone = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        txtDepartment = New TextBox()
        txtDoctorName = New TextBox()
        Label2 = New Label()
        btnSearch = New Button()
        txtDoctorID = New TextBox()
        Label1 = New Label()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnBack = New Button()
        DataGridView1 = New DataGridView()
        btnShowAll = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateBlue
        Panel1.Controls.Add(Label7)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(845, 50)
        Panel1.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(320, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(177, 28)
        Label7.TabIndex = 0
        Label7.Text = "DOCTOR DETAILS"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(421, 160)
        Label6.Name = "Label6"
        Label6.Size = New Size(153, 28)
        Label6.TabIndex = 5
        Label6.Text = "Available Time"
        ' 
        ' txtTime
        ' 
        txtTime.Location = New Point(636, 160)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(125, 27)
        txtTime.TabIndex = 11
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(636, 88)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(421, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 28)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(636, 21)
        txtPhone.MaxLength = 10
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(125, 27)
        txtPhone.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(420, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 28)
        Label4.TabIndex = 3
        Label4.Text = "Phone Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 28)
        Label3.TabIndex = 2
        Label3.Text = "Department"
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Location = New Point(180, 157)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(125, 27)
        txtDepartment.TabIndex = 8
        ' 
        ' txtDoctorName
        ' 
        txtDoctorName.Location = New Point(180, 84)
        txtDoctorName.Name = "txtDoctorName"
        txtDoctorName.Size = New Size(125, 27)
        txtDoctorName.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 28)
        Label2.TabIndex = 1
        Label2.Text = "Doctor Name"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(320, 19)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(64, 29)
        btnSearch.TabIndex = 19
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtDoctorID
        ' 
        txtDoctorID.BackColor = Color.Gainsboro
        txtDoctorID.Location = New Point(180, 21)
        txtDoctorID.Name = "txtDoctorID"
        txtDoctorID.Size = New Size(125, 27)
        txtDoctorID.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(20, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 28)
        Label1.TabIndex = 0
        Label1.Text = "Doctor ID"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightGreen
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(15, 284)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 12
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.LightBlue
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = SystemColors.ControlText
        btnUpdate.Location = New Point(171, 284)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 13
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightCoral
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(378, 284)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Linen
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(546, 284)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.LightGray
        btnBack.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(720, 284)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 16
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.LightGray
        DataGridView1.Location = New Point(0, 398)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(845, 195)
        DataGridView1.TabIndex = 20
        ' 
        ' btnShowAll
        ' 
        btnShowAll.BackColor = Color.RosyBrown
        btnShowAll.ForeColor = Color.White
        btnShowAll.Location = New Point(348, 548)
        btnShowAll.Name = "btnShowAll"
        btnShowAll.Size = New Size(94, 29)
        btnShowAll.TabIndex = 21
        btnShowAll.Text = "Show All"
        btnShowAll.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BackgroundImage = My.Resources.Resources.hos
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Controls.Add(btnShowAll)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtDoctorID)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtDoctorName)
        Panel2.Controls.Add(txtDepartment)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtPhone)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtEmail)
        Panel2.Controls.Add(txtTime)
        Panel2.Controls.Add(Label6)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 50)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(845, 593)
        Panel2.TabIndex = 21
        ' 
        ' DoctorForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.doctor1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(845, 639)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "DoctorForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Doctor Management"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtDoctorName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Public WithEvents txtDoctorID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnShowAll As Button
    Friend WithEvents Panel2 As Panel
End Class
