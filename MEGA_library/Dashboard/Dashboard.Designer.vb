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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        lblTitle = New Label()
        SQLControlBindingSource = New BindingSource(components)
        btnWishlist = New Button()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnFavorites = New Button()
        Button3 = New Button()
        btnHistory = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DataGridView1 = New DataGridView()
        TabPage2 = New TabPage()
        Label7 = New Label()
        txtEdition = New TextBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        txtImageURL = New TextBox()
        btnSearch = New Button()
        Label5 = New Label()
        txtSearch = New TextBox()
        btnDelete = New Button()
        btnEdit = New Button()
        btnSave = New Button()
        Label3 = New Label()
        txtBookAuthor = New TextBox()
        Label4 = New Label()
        txtBookDescription = New TextBox()
        Label2 = New Label()
        txtBookTitle = New TextBox()
        Label1 = New Label()
        txtBoxId = New TextBox()
        BindingSource1 = New BindingSource(components)
        lblUsername = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        CType(SQLControlBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        lblTitle.Location = New Point(23, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(324, 56)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Mega Library"
        ' 
        ' SQLControlBindingSource
        ' 
        SQLControlBindingSource.DataSource = GetType(SQLControl)
        ' 
        ' btnWishlist
        ' 
        btnWishlist.BackColor = Color.FromArgb(CByte(110), CByte(115), CByte(141))
        btnWishlist.Font = New Font("Arial", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnWishlist.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        btnWishlist.Location = New Point(234, 3)
        btnWishlist.Name = "btnWishlist"
        btnWishlist.Size = New Size(225, 112)
        btnWishlist.TabIndex = 3
        btnWishlist.Text = "Wishlist"
        btnWishlist.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(135), CByte(162))
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1485, 122)
        Panel1.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(btnFavorites, 0, 0)
        TableLayoutPanel1.Controls.Add(Button3, 0, 0)
        TableLayoutPanel1.Controls.Add(btnHistory, 0, 0)
        TableLayoutPanel1.Controls.Add(btnWishlist, 0, 0)
        TableLayoutPanel1.Location = New Point(559, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(924, 118)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' btnFavorites
        ' 
        btnFavorites.BackColor = Color.FromArgb(CByte(147), CByte(154), CByte(183))
        btnFavorites.Font = New Font("Arial", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnFavorites.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        btnFavorites.Location = New Point(465, 3)
        btnFavorites.Name = "btnFavorites"
        btnFavorites.Size = New Size(225, 112)
        btnFavorites.TabIndex = 8
        btnFavorites.Text = "Favorite Books"
        btnFavorites.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(198), CByte(160), CByte(246))
        Button3.Font = New Font("Arial", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(24), CByte(25), CByte(38))
        Button3.Location = New Point(696, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(225, 112)
        Button3.TabIndex = 7
        Button3.Text = "Quit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.FromArgb(CByte(128), CByte(135), CByte(162))
        btnHistory.Font = New Font("Arial", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnHistory.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        btnHistory.Location = New Point(3, 3)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(225, 112)
        btnHistory.TabIndex = 6
        btnHistory.Text = "History"
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Arial", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TabControl1.ItemSize = New Size(120, 40)
        TabControl1.Location = New Point(0, 122)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1485, 613)
        TabControl1.TabIndex = 10
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Location = New Point(4, 44)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1477, 565)
        TabPage1.TabIndex = 0
        TabPage1.Text = "BOOK LIST"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(73), CByte(77), CByte(100))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Arial", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(73), CByte(77), CByte(100))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1471, 559)
        DataGridView1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(73), CByte(77), CByte(100))
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(txtEdition)
        TabPage2.Controls.Add(PictureBox1)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(txtImageURL)
        TabPage2.Controls.Add(btnSearch)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(txtSearch)
        TabPage2.Controls.Add(btnDelete)
        TabPage2.Controls.Add(btnEdit)
        TabPage2.Controls.Add(btnSave)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(txtBookAuthor)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(txtBookDescription)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(txtBookTitle)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(txtBoxId)
        TabPage2.Location = New Point(4, 44)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1477, 565)
        TabPage2.TabIndex = 1
        TabPage2.Text = " Manage Books"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        Label7.Location = New Point(608, 297)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 17)
        Label7.TabIndex = 18
        Label7.Text = "Book Edition"
        ' 
        ' txtEdition
        ' 
        txtEdition.BackColor = Color.FromArgb(CByte(220), CByte(224), CByte(232))
        txtEdition.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        txtEdition.Location = New Point(733, 289)
        txtEdition.Name = "txtEdition"
        txtEdition.Size = New Size(554, 25)
        txtEdition.TabIndex = 17
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(64, 150)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(400, 250)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        Label6.Location = New Point(591, 406)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 17)
        Label6.TabIndex = 15
        Label6.Text = "Book Image Url"
        ' 
        ' txtImageURL
        ' 
        txtImageURL.BackColor = Color.FromArgb(CByte(220), CByte(224), CByte(232))
        txtImageURL.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        txtImageURL.Location = New Point(733, 398)
        txtImageURL.Name = "txtImageURL"
        txtImageURL.Size = New Size(554, 25)
        txtImageURL.TabIndex = 14
        ' 
        ' btnSearch
        ' 
        btnSearch.ForeColor = Color.FromArgb(CByte(184), CByte(192), CByte(224))
        btnSearch.Location = New Point(1305, 44)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(86, 25)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        Label5.Location = New Point(650, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 17)
        Label5.TabIndex = 12
        Label5.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(220), CByte(224), CByte(232))
        txtSearch.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        txtSearch.Location = New Point(733, 44)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(554, 25)
        txtSearch.TabIndex = 11
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(237), CByte(135), CByte(150))
        btnDelete.ForeColor = Color.FromArgb(CByte(24), CByte(25), CByte(38))
        btnDelete.Location = New Point(1117, 464)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(128, 77)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(238), CByte(212), CByte(159))
        btnEdit.ForeColor = Color.FromArgb(CByte(24), CByte(25), CByte(38))
        btnEdit.Location = New Point(933, 464)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(128, 77)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(138), CByte(173), CByte(244))
        btnSave.ForeColor = Color.FromArgb(CByte(24), CByte(25), CByte(38))
        btnSave.Location = New Point(733, 464)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(128, 77)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        Label3.Location = New Point(610, 354)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 17)
        Label3.TabIndex = 7
        Label3.Text = "Book Author"
        ' 
        ' txtBookAuthor
        ' 
        txtBookAuthor.BackColor = Color.FromArgb(CByte(220), CByte(224), CByte(232))
        txtBookAuthor.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        txtBookAuthor.Location = New Point(733, 346)
        txtBookAuthor.Name = "txtBookAuthor"
        txtBookAuthor.Size = New Size(554, 25)
        txtBookAuthor.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        Label4.Location = New Point(577, 241)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 17)
        Label4.TabIndex = 5
        Label4.Text = "Book Description"
        ' 
        ' txtBookDescription
        ' 
        txtBookDescription.BackColor = Color.FromArgb(CByte(220), CByte(224), CByte(232))
        txtBookDescription.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        txtBookDescription.Location = New Point(733, 233)
        txtBookDescription.Name = "txtBookDescription"
        txtBookDescription.Size = New Size(554, 25)
        txtBookDescription.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        Label2.Location = New Point(628, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 17)
        Label2.TabIndex = 3
        Label2.Text = "Book Title"
        ' 
        ' txtBookTitle
        ' 
        txtBookTitle.BackColor = Color.FromArgb(CByte(220), CByte(224), CByte(232))
        txtBookTitle.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        txtBookTitle.Location = New Point(733, 179)
        txtBookTitle.Name = "txtBookTitle"
        txtBookTitle.Size = New Size(554, 25)
        txtBookTitle.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(202), CByte(211), CByte(245))
        Label1.Location = New Point(646, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 17)
        Label1.TabIndex = 1
        Label1.Text = "Book Id"
        ' 
        ' txtBoxId
        ' 
        txtBoxId.BackColor = Color.FromArgb(CByte(220), CByte(224), CByte(232))
        txtBoxId.ForeColor = Color.FromArgb(CByte(76), CByte(79), CByte(105))
        txtBoxId.Location = New Point(733, 124)
        txtBoxId.Name = "txtBoxId"
        txtBoxId.Size = New Size(554, 25)
        txtBoxId.TabIndex = 0
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(204), CByte(208), CByte(218))
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(lblUsername)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 735)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1485, 101)
        Panel2.TabIndex = 9
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
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1485, 836)
        Controls.Add(TabControl1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Dashboard"
        Text = "Dashboard"
        CType(SQLControlBindingSource, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents SQLControlBindingSource As BindingSource
    Friend WithEvents btnWishlist As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxId As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBookAuthor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBookDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents txtImageURL As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEdition As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHistory As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnFavorites As Button
    Friend WithEvents Button3 As Button
End Class
