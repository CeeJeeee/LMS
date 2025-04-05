<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transactions))
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TransactionsLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.HolderPanel = New System.Windows.Forms.Panel()
        Me.pnlTransactions = New LMS.RoundedPanel()
        Me.btnBack = New LMS.RoundedButton()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New LMS.RoundedButton()
        Me.txtSearch = New LMS.RoundedTextbox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.TransactionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Borrower = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGBEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DGBDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransactionsLayout.SuspendLayout()
        Me.HolderPanel.SuspendLayout()
        Me.pnlTransactions.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TransactionsLayout
        '
        Me.TransactionsLayout.BackColor = System.Drawing.Color.White
        Me.TransactionsLayout.ColumnCount = 3
        Me.TransactionsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TransactionsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TransactionsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TransactionsLayout.Controls.Add(Me.HolderPanel, 1, 1)
        Me.TransactionsLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionsLayout.Location = New System.Drawing.Point(0, 110)
        Me.TransactionsLayout.Name = "TransactionsLayout"
        Me.TransactionsLayout.RowCount = 3
        Me.TransactionsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.291874!))
        Me.TransactionsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.70812!))
        Me.TransactionsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TransactionsLayout.Size = New System.Drawing.Size(1370, 639)
        Me.TransactionsLayout.TabIndex = 3
        '
        'HolderPanel
        '
        Me.HolderPanel.Controls.Add(Me.pnlTransactions)
        Me.HolderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HolderPanel.Location = New System.Drawing.Point(71, 53)
        Me.HolderPanel.Name = "HolderPanel"
        Me.HolderPanel.Size = New System.Drawing.Size(1227, 547)
        Me.HolderPanel.TabIndex = 1
        '
        'pnlTransactions
        '
        Me.pnlTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlTransactions.Controls.Add(Me.btnBack)
        Me.pnlTransactions.Controls.Add(Me.lblTransactions)
        Me.pnlTransactions.Controls.Add(Me.grpSearch)
        Me.pnlTransactions.Controls.Add(Me.dgvTransactions)
        Me.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTransactions.Location = New System.Drawing.Point(0, 0)
        Me.pnlTransactions.Name = "pnlTransactions"
        Me.pnlTransactions.Size = New System.Drawing.Size(1227, 547)
        Me.pnlTransactions.TabIndex = 22
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
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblTransactions.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactions.ForeColor = System.Drawing.Color.White
        Me.lblTransactions.Location = New System.Drawing.Point(573, 30)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(149, 33)
        Me.lblTransactions.TabIndex = 17
        Me.lblTransactions.Text = "Transactions"
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
        Me.cmbFilter.Items.AddRange(New Object() {"All", "Borrowed", "Returned", "Overdue"})
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
        'dgvTransactions
        '
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionID, Me.BookID, Me.BookTitle, Me.Borrower, Me.IssueDate, Me.DueDate, Me.ReturnDate, Me.cmbStatus, Me.DGBEdit, Me.DGBDelete})
        Me.dgvTransactions.Location = New System.Drawing.Point(27, 133)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.Size = New System.Drawing.Size(1173, 361)
        Me.dgvTransactions.TabIndex = 0
        '
        'TransactionID
        '
        Me.TransactionID.HeaderText = "Transaction ID"
        Me.TransactionID.Name = "TransactionID"
        Me.TransactionID.ReadOnly = True
        '
        'BookID
        '
        Me.BookID.HeaderText = "Book ID"
        Me.BookID.Name = "BookID"
        '
        'BookTitle
        '
        Me.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BookTitle.HeaderText = "Book Title"
        Me.BookTitle.Name = "BookTitle"
        '
        'Borrower
        '
        Me.Borrower.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Borrower.HeaderText = "Borrower Name"
        Me.Borrower.Name = "Borrower"
        '
        'IssueDate
        '
        Me.IssueDate.HeaderText = "Issue Date"
        Me.IssueDate.Name = "IssueDate"
        '
        'DueDate
        '
        Me.DueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DueDate.HeaderText = "Due Date"
        Me.DueDate.Name = "DueDate"
        '
        'ReturnDate
        '
        Me.ReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReturnDate.HeaderText = "Return Date"
        Me.ReturnDate.Name = "ReturnDate"
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cmbStatus.HeaderText = "Status"
        Me.cmbStatus.Items.AddRange(New Object() {"Borrowed", "Returned", "Overdue"})
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmbStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DGBEdit
        '
        Me.DGBEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DGBEdit.HeaderText = ""
        Me.DGBEdit.Name = "DGBEdit"
        Me.DGBEdit.Text = "Edit"
        Me.DGBEdit.UseColumnTextForButtonValue = True
        '
        'DGBDelete
        '
        Me.DGBDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DGBDelete.HeaderText = ""
        Me.DGBDelete.Name = "DGBDelete"
        Me.DGBDelete.Text = "Delete"
        Me.DGBDelete.UseColumnTextForButtonValue = True
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TransactionsLayout)
        Me.Controls.Add(Me.Header)
        Me.Name = "Transactions"
        Me.Text = "Transactions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Header.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransactionsLayout.ResumeLayout(False)
        Me.HolderPanel.ResumeLayout(False)
        Me.pnlTransactions.ResumeLayout(False)
        Me.pnlTransactions.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TransactionsLayout As TableLayoutPanel
    Friend WithEvents HolderPanel As Panel
    Friend WithEvents pnlTransactions As RoundedPanel
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents lblTransactions As Label
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnSearch As RoundedButton
    Friend WithEvents txtSearch As RoundedTextbox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents TransactionID As DataGridViewTextBoxColumn
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents BookTitle As DataGridViewTextBoxColumn
    Friend WithEvents Borrower As DataGridViewTextBoxColumn
    Friend WithEvents IssueDate As DataGridViewTextBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDate As DataGridViewTextBoxColumn
    Friend WithEvents cmbStatus As DataGridViewComboBoxColumn
    Friend WithEvents DGBEdit As DataGridViewButtonColumn
    Friend WithEvents DGBDelete As DataGridViewButtonColumn
End Class
