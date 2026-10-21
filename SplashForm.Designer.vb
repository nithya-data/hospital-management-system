<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashForm
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
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        Label1 = New Label()
        lblLoading = New Label()
        ProgressBar1 = New ProgressBar()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.slash
        PictureBox1.Location = New Point(1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(801, 460)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Peru
        Label1.Location = New Point(214, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 28)
        Label1.TabIndex = 1
        Label1.Text = "HOSPITAL MANAGEMENT SYSTEM"
        ' 
        ' lblLoading
        ' 
        lblLoading.AutoSize = True
        lblLoading.BackColor = Color.White
        lblLoading.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLoading.Location = New Point(12, 411)
        lblLoading.Name = "lblLoading"
        lblLoading.Size = New Size(95, 25)
        lblLoading.TabIndex = 2
        lblLoading.Text = "Loading..."
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.White
        ProgressBar1.ForeColor = SystemColors.Control
        ProgressBar1.Location = New Point(120, 411)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(634, 29)
        ProgressBar1.TabIndex = 3
        ' 
        ' SplashForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ProgressBar1)
        Controls.Add(lblLoading)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SplashForm"
        Text = "SplashForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLoading As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
