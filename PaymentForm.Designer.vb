<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Panel1 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtPaymentID = New TextBox()
        txtAppointmentID = New TextBox()
        txtPatientName = New TextBox()
        txtAmount = New TextBox()
        cmbPaymentStatus = New ComboBox()
        cmbPaymentMode = New ComboBox()
        dtpPaymentDate = New DateTimePicker()
        btnSave = New Button()
        btnSearch = New Button()
        btnClear = New Button()
        btnShowAll = New Button()
        btnBack = New Button()
        DataGridView1 = New DataGridView()
        btnReceipt = New Button()
        rtbReceipt = New RichTextBox()
        Panel2 = New Panel()
        Label9 = New Label()
        btnUpdate = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintDialog1 = New PrintDialog()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(267, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 28)
        Label1.TabIndex = 0
        Label1.Text = "PAYMENT MANAGEMENT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(873, 50)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 30)
        Label2.TabIndex = 2
        Label2.Text = "Payment ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 28)
        Label3.TabIndex = 3
        Label3.Text = "Appointment ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(24, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 28)
        Label4.TabIndex = 4
        Label4.Text = "Patient Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(24, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 28)
        Label5.TabIndex = 5
        Label5.Text = "Amount"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(24, 268)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 28)
        Label6.TabIndex = 6
        Label6.Text = "Payment Mode"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(24, 322)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 28)
        Label7.TabIndex = 7
        Label7.Text = "Payment Date"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(24, 374)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 28)
        Label8.TabIndex = 8
        Label8.Text = "Status"
        ' 
        ' txtPaymentID
        ' 
        txtPaymentID.BackColor = Color.Gainsboro
        txtPaymentID.Location = New Point(246, 71)
        txtPaymentID.Name = "txtPaymentID"
        txtPaymentID.Size = New Size(151, 27)
        txtPaymentID.TabIndex = 9
        ' 
        ' txtAppointmentID
        ' 
        txtAppointmentID.BackColor = Color.Gainsboro
        txtAppointmentID.Location = New Point(246, 119)
        txtAppointmentID.Name = "txtAppointmentID"
        txtAppointmentID.Size = New Size(151, 27)
        txtAppointmentID.TabIndex = 10
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Location = New Point(246, 171)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(151, 27)
        txtPatientName.TabIndex = 11
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(246, 222)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(151, 27)
        txtAmount.TabIndex = 12
        ' 
        ' cmbPaymentStatus
        ' 
        cmbPaymentStatus.FormattingEnabled = True
        cmbPaymentStatus.Items.AddRange(New Object() {"Paid", "Pending", "Failed"})
        cmbPaymentStatus.Location = New Point(246, 374)
        cmbPaymentStatus.Name = "cmbPaymentStatus"
        cmbPaymentStatus.Size = New Size(151, 28)
        cmbPaymentStatus.TabIndex = 13
        ' 
        ' cmbPaymentMode
        ' 
        cmbPaymentMode.FormattingEnabled = True
        cmbPaymentMode.Items.AddRange(New Object() {"Cash", "UPI", "Card", "Net Banking"})
        cmbPaymentMode.Location = New Point(246, 268)
        cmbPaymentMode.Name = "cmbPaymentMode"
        cmbPaymentMode.Size = New Size(151, 28)
        cmbPaymentMode.TabIndex = 14
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.Location = New Point(246, 322)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(151, 27)
        dtpPaymentDate.TabIndex = 15
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.IndianRed
        btnSave.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(12, 457)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 41)
        btnSave.TabIndex = 16
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(403, 117)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(63, 29)
        btnSearch.TabIndex = 17
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Bisque
        btnClear.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(128, 457)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 41)
        btnClear.TabIndex = 18
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnShowAll
        ' 
        btnShowAll.BackColor = Color.RosyBrown
        btnShowAll.ForeColor = Color.Black
        btnShowAll.Location = New Point(354, 151)
        btnShowAll.Name = "btnShowAll"
        btnShowAll.Size = New Size(94, 29)
        btnShowAll.TabIndex = 19
        btnShowAll.Text = "Show All"
        btnShowAll.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.MistyRose
        btnBack.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(228, 457)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 41)
        btnBack.TabIndex = 20
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(873, 196)
        DataGridView1.TabIndex = 21
        ' 
        ' btnReceipt
        ' 
        btnReceipt.BackColor = Color.Tan
        btnReceipt.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReceipt.Location = New Point(616, 457)
        btnReceipt.Name = "btnReceipt"
        btnReceipt.Size = New Size(181, 41)
        btnReceipt.TabIndex = 22
        btnReceipt.Text = "Generate  Receipt"
        btnReceipt.UseVisualStyleBackColor = False
        ' 
        ' rtbReceipt
        ' 
        rtbReceipt.Font = New Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbReceipt.Location = New Point(559, 71)
        rtbReceipt.Name = "rtbReceipt"
        rtbReceipt.ReadOnly = True
        rtbReceipt.Size = New Size(290, 357)
        rtbReceipt.TabIndex = 23
        rtbReceipt.Text = ""
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(btnShowAll)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(0, 504)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(873, 199)
        Panel2.TabIndex = 24
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(37, 424)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 20)
        Label9.TabIndex = 25
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(467, 464)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 26
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Payment
        ClientSize = New Size(873, 696)
        Controls.Add(btnUpdate)
        Controls.Add(Label9)
        Controls.Add(Panel2)
        Controls.Add(rtbReceipt)
        Controls.Add(btnReceipt)
        Controls.Add(btnBack)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(btnSave)
        Controls.Add(dtpPaymentDate)
        Controls.Add(cmbPaymentMode)
        Controls.Add(cmbPaymentStatus)
        Controls.Add(txtAmount)
        Controls.Add(txtPatientName)
        Controls.Add(txtAppointmentID)
        Controls.Add(txtPaymentID)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "PaymentForm"
        Text = "PaymentForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents txtAppointmentID As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbPaymentStatus As ComboBox
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReceipt As Button
    Friend WithEvents rtbReceipt As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
