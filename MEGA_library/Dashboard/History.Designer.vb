<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        btnGoBack = New Button()
        lblTitle = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        lblUsername = New Label()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(135), CByte(162))
        Panel1.Controls.Add(btnGoBack)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1502, 100)
        Panel1.TabIndex = 1
        ' 
        ' btnGoBack
        ' 
        btnGoBack.BackColor = Color.FromArgb(CByte(198), CByte(160), CByte(246))
        btnGoBack.Dock = DockStyle.Right
        btnGoBack.Font = New Font("Arial", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnGoBack.ForeColor = Color.FromArgb(CByte(24), CByte(25), CByte(38))
        btnGoBack.Location = New Point(1326, 0)
        btnGoBack.Name = "btnGoBack"
        btnGoBack.Size = New Size(176, 100)
        btnGoBack.TabIndex = 2
        btnGoBack.Text = "Go Back"
        btnGoBack.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        lblTitle.Location = New Point(12, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(190, 56)
        lblTitle.TabIndex = 1
        lblTitle.Text = "History"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(204), CByte(208), CByte(218))
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(lblUsername)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 736)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1502, 101)
        Panel2.TabIndex = 10
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(4, 23)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(600, 75)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Arial", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        lblUsername.Location = New Point(632, 41)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(114, 24)
        lblUsername.TabIndex = 8
        lblUsername.Text = "Username"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(73), CByte(77), CByte(100))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(91), CByte(96), CByte(120))
        DataGridViewCellStyle1.Font = New Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(244), CByte(219), CByte(214))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(24), CByte(25), CByte(38))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 100)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(1502, 636)
        DataGridView1.TabIndex = 12
        ' 
        ' History
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1502, 837)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "History"
        Text = "History"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnGoBack As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
