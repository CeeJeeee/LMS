<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPAC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OPAC))
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OPACLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.HolderPanel = New System.Windows.Forms.Panel()
        Me.pnlOPAC = New LMS.RoundedPanel()
        Me.btnBack = New LMS.RoundedButton()
        Me.lblOPAC = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New LMS.RoundedButton()
        Me.txtSearch = New LMS.RoundedTextbox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.dgvOPAC = New System.Windows.Forms.DataGridView()
        Me.BookThumbnail = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CallNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgbIssueBook = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OPACLayout.SuspendLayout()
        Me.HolderPanel.SuspendLayout()
        Me.pnlOPAC.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.dgvOPAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Header.Controls.Add(Me.PictureBox3)
        Me.Header.Controls.Add(Me.PictureBox2)
        Me.Header.Controls.Add(Me.PictureBox1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1370, 110)
        Me.Header.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(309, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(283, 78)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(111, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 78)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'OPACLayout
        '
        Me.OPACLayout.BackColor = System.Drawing.Color.White
        Me.OPACLayout.ColumnCount = 3
        Me.OPACLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.OPACLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.OPACLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.OPACLayout.Controls.Add(Me.HolderPanel, 1, 1)
        Me.OPACLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OPACLayout.Location = New System.Drawing.Point(0, 110)
        Me.OPACLayout.Name = "OPACLayout"
        Me.OPACLayout.RowCount = 3
        Me.OPACLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.291874!))
        Me.OPACLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.70812!))
        Me.OPACLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.OPACLayout.Size = New System.Drawing.Size(1370, 639)
        Me.OPACLayout.TabIndex = 3
        '
        'HolderPanel
        '
        Me.HolderPanel.Controls.Add(Me.pnlOPAC)
        Me.HolderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HolderPanel.Location = New System.Drawing.Point(71, 53)
        Me.HolderPanel.Name = "HolderPanel"
        Me.HolderPanel.Size = New System.Drawing.Size(1227, 547)
        Me.HolderPanel.TabIndex = 1
        '
        'pnlOPAC
        '
        Me.pnlOPAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlOPAC.Controls.Add(Me.btnBack)
        Me.pnlOPAC.Controls.Add(Me.lblOPAC)
        Me.pnlOPAC.Controls.Add(Me.grpSearch)
        Me.pnlOPAC.Controls.Add(Me.dgvOPAC)
        Me.pnlOPAC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOPAC.Location = New System.Drawing.Point(0, 0)
        Me.pnlOPAC.Name = "pnlOPAC"
        Me.pnlOPAC.Size = New System.Drawing.Size(1227, 547)
        Me.pnlOPAC.TabIndex = 22
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Image = Global.LMS.My.Resources.Resources.back
        Me.btnBack.Location = New System.Drawing.Point(1177, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(48, 39)
        Me.btnBack.TabIndex = 18
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblOPAC
        '
        Me.lblOPAC.AutoSize = True
        Me.lblOPAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblOPAC.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPAC.ForeColor = System.Drawing.Color.White
        Me.lblOPAC.Location = New System.Drawing.Point(428, 29)
        Me.lblOPAC.Name = "lblOPAC"
        Me.lblOPAC.Size = New System.Drawing.Size(410, 33)
        Me.lblOPAC.TabIndex = 17
        Me.lblOPAC.Text = "OPAC (Online Public Access Catalog)  "
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.cmbFilter)
        Me.grpSearch.Controls.Add(Me.lblFilter)
        Me.grpSearch.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.ForeColor = System.Drawing.Color.White
        Me.grpSearch.Location = New System.Drawing.Point(302, 83)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(611, 44)
        Me.grpSearch.TabIndex = 1
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(518, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 28)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(219, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(284, 26)
        Me.txtSearch.TabIndex = 2
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Keyword", "Author", "Title", "Subject", "Series", "Call Number"})
        Me.cmbFilter.Location = New System.Drawing.Point(132, 13)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbFilter.Size = New System.Drawing.Size(81, 26)
        Me.cmbFilter.TabIndex = 1
        Me.cmbFilter.Text = "Title"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(84, 16)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(43, 18)
        Me.lblFilter.TabIndex = 0
        Me.lblFilter.Text = "Filter"
        '
        'dgvOPAC
        '
        Me.dgvOPAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOPAC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookThumbnail, Me.BookTitle, Me.Author, Me.CallNumber, Me.BookStatus, Me.dgbIssueBook})
        Me.dgvOPAC.Location = New System.Drawing.Point(27, 133)
        Me.dgvOPAC.Name = "dgvOPAC"
        Me.dgvOPAC.Size = New System.Drawing.Size(1173, 361)
        Me.dgvOPAC.TabIndex = 0
        '
        'BookThumbnail
        '
        Me.BookThumbnail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BookThumbnail.HeaderText = "Book Thumbnail"
        Me.BookThumbnail.Name = "BookThumbnail"
        '
        'BookTitle
        '
        Me.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BookTitle.HeaderText = "Book Title"
        Me.BookTitle.Name = "BookTitle"
        '
        'Author
        '
        Me.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        '
        'CallNumber
        '
        Me.CallNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CallNumber.HeaderText = "Call Number"
        Me.CallNumber.Name = "CallNumber"
        '
        'BookStatus
        '
        Me.BookStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BookStatus.HeaderText = "Status"
        Me.BookStatus.Name = "BookStatus"
        '
        'dgbIssueBook
        '
        Me.dgbIssueBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgbIssueBook.HeaderText = ""
        Me.dgbIssueBook.Name = "dgbIssueBook"
        Me.dgbIssueBook.Text = "Edit"
        Me.dgbIssueBook.UseColumnTextForButtonValue = True
        '
        'OPAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.OPACLayout)
        Me.Controls.Add(Me.Header)
        Me.Name = "OPAC"
        Me.Text = "OPAC"
        Me.Header.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OPACLayout.ResumeLayout(False)
        Me.HolderPanel.ResumeLayout(False)
        Me.pnlOPAC.ResumeLayout(False)
        Me.pnlOPAC.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.dgvOPAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OPACLayout As TableLayoutPanel
    Friend WithEvents HolderPanel As Panel
    Friend WithEvents pnlOPAC As RoundedPanel
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents lblOPAC As Label
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnSearch As RoundedButton
    Friend WithEvents txtSearch As RoundedTextbox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents dgvOPAC As DataGridView
    Friend WithEvents BookThumbnail As DataGridViewImageColumn
    Friend WithEvents BookTitle As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents CallNumber As DataGridViewTextBoxColumn
    Friend WithEvents BookStatus As DataGridViewTextBoxColumn
    Friend WithEvents dgbIssueBook As DataGridViewButtonColumn
End Class
