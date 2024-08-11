<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        btnLogin = New Button()
        btnSignUp = New Button()
        txtUser = New TextBox()
        txtPassword = New TextBox()
        lblUser = New Label()
        lblPassword = New Label()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(54), CByte(58), CByte(79))
        btnLogin.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        btnLogin.Location = New Point(87, 346)
        btnLogin.Margin = New Padding(0, 0, 0, 0)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(335, 63)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.FromArgb(CByte(91), CByte(96), CByte(120))
        btnSignUp.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        btnSignUp.Location = New Point(90, 434)
        btnSignUp.Margin = New Padding(0, 0, 0, 0)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(332, 63)
        btnSignUp.TabIndex = 1
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = Color.FromArgb(CByte(220), CByte(224), CByte(232))
        txtUser.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUser.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        txtUser.Location = New Point(87, 180)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(335, 32)
        txtUser.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(220), CByte(224), CByte(232))
        txtPassword.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        txtPassword.Location = New Point(87, 290)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(335, 32)
        txtPassword.TabIndex = 3
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Arial", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        lblUser.Location = New Point(87, 128)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(121, 24)
        lblUser.TabIndex = 4
        lblUser.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Arial", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        lblPassword.Location = New Point(87, 243)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(117, 24)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(520, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(529, 519)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        lblTitle.Location = New Point(87, 43)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(90, 32)
        lblTitle.TabIndex = 7
        lblTitle.Text = "Login"
        ' 
        ' frm_Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(58))
        ClientSize = New Size(1050, 518)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Controls.Add(lblPassword)
        Controls.Add(lblUser)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Controls.Add(btnSignUp)
        Controls.Add(btnLogin)
        Cursor = Cursors.Hand
        Name = "frm_Login"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label

End Class
