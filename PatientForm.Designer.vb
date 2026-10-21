<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientForm
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
        label1 = New Label()
        label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtPatientName = New TextBox()
        txtAge = New TextBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        btnSave = New Button()
        btnClear = New Button()
        cmbGender = New ComboBox()
        Label6 = New Label()
        txtPatientId = New TextBox()
        btnSearch = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        Panel1 = New Panel()
        Label7 = New Label()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Panel3 = New Panel()
        btnBack = New Button()
        PictureBox1 = New PictureBox()
        pnlGridTop = New Panel()
        btnShowAll = New Button()
        Panel4 = New Panel()
        dvgPatients = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlGridTop.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dvgPatients, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.Transparent
        label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(13, 85)
        label1.Name = "label1"
        label1.Size = New Size(142, 28)
        label1.TabIndex = 0
        label1.Text = "Patient Name"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.BackColor = Color.Transparent
        label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(516, 27)
        label2.Name = "label2"
        label2.Size = New Size(49, 28)
        label2.TabIndex = 1
        label2.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 28)
        Label3.TabIndex = 2
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(471, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 28)
        Label4.TabIndex = 3
        Label4.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(505, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 28)
        Label5.TabIndex = 4
        Label5.Text = "Address"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Location = New Point(211, 86)
        txtPatientName.MaxLength = 100
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(125, 27)
        txtPatientName.TabIndex = 5
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(683, 22)
        txtAge.MaxLength = 3
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 27)
        txtAge.TabIndex = 6
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(683, 90)
        txtPhone.MaxLength = 10
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(125, 27)
        txtPhone.TabIndex = 8
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(683, 144)
        txtAddress.MaxLength = 200
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.ScrollBars = ScrollBars.Vertical
        txtAddress.Size = New Size(168, 80)
        txtAddress.TabIndex = 9
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Azure
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(13, 16)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Azure
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(757, 16)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' cmbGender
        ' 
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male ", "Female", "Other"})
        cmbGender.Location = New Point(211, 154)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(125, 28)
        cmbGender.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(13, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 28)
        Label6.TabIndex = 13
        Label6.Text = "Patient ID"
        ' 
        ' txtPatientId
        ' 
        txtPatientId.BackColor = Color.Gainsboro
        txtPatientId.Location = New Point(211, 26)
        txtPatientId.Name = "txtPatientId"
        txtPatientId.Size = New Size(125, 27)
        txtPatientId.TabIndex = 14
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.WhiteSmoke
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(342, 26)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(65, 29)
        btnSearch.TabIndex = 15
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Azure
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(194, 16)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Azure
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(384, 16)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 19
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label7)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(912, 50)
        Panel1.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(912, 50)
        Label7.TabIndex = 0
        Label7.Text = "PATIENT MANAGEMENT"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(txtPatientId)
        Panel2.Controls.Add(label1)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(txtPatientName)
        Panel2.Controls.Add(label2)
        Panel2.Controls.Add(txtAge)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(cmbGender)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtAddress)
        Panel2.Controls.Add(txtPhone)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Panel5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 50)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(912, 230)
        Panel2.TabIndex = 21
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImage = My.Resources.Resources.hhms
        Panel5.BackgroundImageLayout = ImageLayout.Stretch
        Panel5.Location = New Point(0, -57)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(912, 703)
        Panel5.TabIndex = 16
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(btnBack)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnClear)
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 280)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(912, 60)
        Panel3.TabIndex = 22
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Azure
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(573, 16)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 19
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.heart
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(909, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' pnlGridTop
        ' 
        pnlGridTop.BackColor = Color.White
        pnlGridTop.BackgroundImage = My.Resources.Resources.hhms
        pnlGridTop.Controls.Add(btnShowAll)
        pnlGridTop.Dock = DockStyle.Top
        pnlGridTop.Location = New Point(0, 0)
        pnlGridTop.Name = "pnlGridTop"
        pnlGridTop.Size = New Size(912, 40)
        pnlGridTop.TabIndex = 18
        ' 
        ' btnShowAll
        ' 
        btnShowAll.BackColor = Color.Azure
        btnShowAll.FlatAppearance.BorderSize = 0
        btnShowAll.FlatStyle = FlatStyle.Flat
        btnShowAll.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowAll.Location = New Point(384, 6)
        btnShowAll.Name = "btnShowAll"
        btnShowAll.Size = New Size(94, 29)
        btnShowAll.TabIndex = 18
        btnShowAll.Text = "Show All"
        btnShowAll.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(dvgPatients)
        Panel4.Controls.Add(pnlGridTop)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 340)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(912, 359)
        Panel4.TabIndex = 23
        ' 
        ' dvgPatients
        ' 
        dvgPatients.BackgroundColor = SystemColors.Menu
        dvgPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgPatients.Location = New Point(0, 42)
        dvgPatients.Name = "dvgPatients"
        dvgPatients.RowHeadersWidth = 51
        dvgPatients.Size = New Size(909, 314)
        dvgPatients.TabIndex = 19
        ' 
        ' PatientForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(912, 699)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "PatientForm"
        Text = "PatientForm"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlGridTop.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        CType(dvgPatients, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPatientId As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlGridTop As Panel
    Friend WithEvents btnShowAll As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dvgPatients As DataGridView
    Friend WithEvents btnBack As Button
End Class
