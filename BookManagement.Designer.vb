<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookManagement))
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AccessionRecords = New System.Windows.Forms.TableLayoutPanel()
        Me.HolderPanel = New System.Windows.Forms.Panel()
        Me.Accession = New LMS.RoundedPanel()
        Me.btnBack = New LMS.RoundedButton()
        Me.lblAccessionRecord = New System.Windows.Forms.Label()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.btnSearchby = New LMS.RoundedButton()
        Me.txtSearchby = New LMS.RoundedTextbox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.Books = New System.Windows.Forms.DataGridView()
        Me.clmDateRecieved = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMaterialType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEdition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmVolume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPages = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCostPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPublisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGBChoosePhoto = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DGBEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DGBDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccessionRecords.SuspendLayout()
        Me.HolderPanel.SuspendLayout()
        Me.Accession.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        CType(Me.Books, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Header.TabIndex = 1
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
        'AccessionRecords
        '
        Me.AccessionRecords.BackColor = System.Drawing.Color.White
        Me.AccessionRecords.ColumnCount = 3
        Me.AccessionRecords.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.AccessionRecords.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.AccessionRecords.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.AccessionRecords.Controls.Add(Me.HolderPanel, 1, 1)
        Me.AccessionRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessionRecords.Location = New System.Drawing.Point(0, 110)
        Me.AccessionRecords.Name = "AccessionRecords"
        Me.AccessionRecords.RowCount = 3
        Me.AccessionRecords.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.291874!))
        Me.AccessionRecords.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.70812!))
        Me.AccessionRecords.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.AccessionRecords.Size = New System.Drawing.Size(1370, 639)
        Me.AccessionRecords.TabIndex = 2
        '
        'HolderPanel
        '
        Me.HolderPanel.Controls.Add(Me.Accession)
        Me.HolderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HolderPanel.Location = New System.Drawing.Point(71, 53)
        Me.HolderPanel.Name = "HolderPanel"
        Me.HolderPanel.Size = New System.Drawing.Size(1227, 547)
        Me.HolderPanel.TabIndex = 1
        '
        'Accession
        '
        Me.Accession.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Accession.Controls.Add(Me.btnBack)
        Me.Accession.Controls.Add(Me.lblAccessionRecord)
        Me.Accession.Controls.Add(Me.grpFilter)
        Me.Accession.Controls.Add(Me.Books)
        Me.Accession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Accession.Location = New System.Drawing.Point(0, 0)
        Me.Accession.Name = "Accession"
        Me.Accession.Size = New System.Drawing.Size(1227, 547)
        Me.Accession.TabIndex = 25
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
        'lblAccessionRecord
        '
        Me.lblAccessionRecord.AutoSize = True
        Me.lblAccessionRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblAccessionRecord.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessionRecord.ForeColor = System.Drawing.Color.White
        Me.lblAccessionRecord.Location = New System.Drawing.Point(552, 30)
        Me.lblAccessionRecord.Name = "lblAccessionRecord"
        Me.lblAccessionRecord.Size = New System.Drawing.Size(202, 33)
        Me.lblAccessionRecord.TabIndex = 17
        Me.lblAccessionRecord.Text = "Accession Record"
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.btnSearchby)
        Me.grpFilter.Controls.Add(Me.txtSearchby)
        Me.grpFilter.Controls.Add(Me.cmbFilter)
        Me.grpFilter.Controls.Add(Me.lblFilter)
        Me.grpFilter.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFilter.ForeColor = System.Drawing.Color.White
        Me.grpFilter.Location = New System.Drawing.Point(302, 83)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(611, 44)
        Me.grpFilter.TabIndex = 1
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Search"
        '
        'btnSearchby
        '
        Me.btnSearchby.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSearchby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSearchby.Location = New System.Drawing.Point(518, 11)
        Me.btnSearchby.Name = "btnSearchby"
        Me.btnSearchby.Size = New System.Drawing.Size(75, 28)
        Me.btnSearchby.TabIndex = 3
        Me.btnSearchby.Text = "Search"
        Me.btnSearchby.UseVisualStyleBackColor = False
        '
        'txtSearchby
        '
        Me.txtSearchby.Location = New System.Drawing.Point(219, 12)
        Me.txtSearchby.Name = "txtSearchby"
        Me.txtSearchby.Size = New System.Drawing.Size(284, 26)
        Me.txtSearchby.TabIndex = 2
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Title", "", "", "Author", "", "", "Genre", "", "", "Availability"})
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
        'Books
        '
        Me.Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Books.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmDateRecieved, Me.clmMaterialType, Me.clmAuthor, Me.clmBookTitle, Me.clmEdition, Me.clmVolume, Me.clmPages, Me.clmCostPrice, Me.clmPublisher, Me.clmYear, Me.clmRemarks, Me.DGBChoosePhoto, Me.DGBEdit, Me.DGBDelete})
        Me.Books.Location = New System.Drawing.Point(27, 133)
        Me.Books.Name = "Books"
        Me.Books.Size = New System.Drawing.Size(1173, 361)
        Me.Books.TabIndex = 0
        '
        'clmDateRecieved
        '
        Me.clmDateRecieved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmDateRecieved.HeaderText = "Date Recieved"
        Me.clmDateRecieved.Name = "clmDateRecieved"
        '
        'clmMaterialType
        '
        Me.clmMaterialType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmMaterialType.HeaderText = "Type of Material"
        Me.clmMaterialType.Name = "clmMaterialType"
        '
        'clmAuthor
        '
        Me.clmAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmAuthor.HeaderText = "Author"
        Me.clmAuthor.Name = "clmAuthor"
        '
        'clmBookTitle
        '
        Me.clmBookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmBookTitle.HeaderText = "Book Title"
        Me.clmBookTitle.Name = "clmBookTitle"
        '
        'clmEdition
        '
        Me.clmEdition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmEdition.HeaderText = "Edition"
        Me.clmEdition.Name = "clmEdition"
        '
        'clmVolume
        '
        Me.clmVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmVolume.HeaderText = "Volume"
        Me.clmVolume.Name = "clmVolume"
        '
        'clmPages
        '
        Me.clmPages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmPages.HeaderText = "Pages"
        Me.clmPages.Name = "clmPages"
        '
        'clmCostPrice
        '
        Me.clmCostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmCostPrice.HeaderText = "Cost Price"
        Me.clmCostPrice.Name = "clmCostPrice"
        '
        'clmPublisher
        '
        Me.clmPublisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmPublisher.HeaderText = "Publisher"
        Me.clmPublisher.Name = "clmPublisher"
        '
        'clmYear
        '
        Me.clmYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmYear.HeaderText = "Year"
        Me.clmYear.Name = "clmYear"
        '
        'clmRemarks
        '
        Me.clmRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmRemarks.HeaderText = "Remarks"
        Me.clmRemarks.Name = "clmRemarks"
        '
        'DGBChoosePhoto
        '
        Me.DGBChoosePhoto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DGBChoosePhoto.HeaderText = ""
        Me.DGBChoosePhoto.Name = "DGBChoosePhoto"
        Me.DGBChoosePhoto.Text = "Choose Photo"
        Me.DGBChoosePhoto.UseColumnTextForButtonValue = True
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
        'BookManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.AccessionRecords)
        Me.Controls.Add(Me.Header)
        Me.Name = "BookManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookManagement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Header.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccessionRecords.ResumeLayout(False)
        Me.HolderPanel.ResumeLayout(False)
        Me.Accession.ResumeLayout(False)
        Me.Accession.PerformLayout()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        CType(Me.Books, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AccessionRecords As TableLayoutPanel
    Friend WithEvents HolderPanel As Panel
    Friend WithEvents Accession As RoundedPanel
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents lblAccessionRecord As Label
    Friend WithEvents grpFilter As GroupBox
    Friend WithEvents btnSearchby As RoundedButton
    Friend WithEvents txtSearchby As RoundedTextbox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents Books As DataGridView
    Friend WithEvents clmDateRecieved As DataGridViewTextBoxColumn
    Friend WithEvents clmMaterialType As DataGridViewTextBoxColumn
    Friend WithEvents clmAuthor As DataGridViewTextBoxColumn
    Friend WithEvents clmBookTitle As DataGridViewTextBoxColumn
    Friend WithEvents clmEdition As DataGridViewTextBoxColumn
    Friend WithEvents clmVolume As DataGridViewTextBoxColumn
    Friend WithEvents clmPages As DataGridViewTextBoxColumn
    Friend WithEvents clmCostPrice As DataGridViewTextBoxColumn
    Friend WithEvents clmPublisher As DataGridViewTextBoxColumn
    Friend WithEvents clmYear As DataGridViewTextBoxColumn
    Friend WithEvents clmRemarks As DataGridViewTextBoxColumn
    Friend WithEvents DGBChoosePhoto As DataGridViewButtonColumn
    Friend WithEvents DGBEdit As DataGridViewButtonColumn
    Friend WithEvents DGBDelete As DataGridViewButtonColumn
End Class
