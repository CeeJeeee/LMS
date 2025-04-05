<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogEntry))
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogEntryLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelHolder = New System.Windows.Forms.Panel()
        Me.LibraryLogEntries = New LMS.RoundedPanel()
        Me.btnExport = New LMS.RoundedButton()
        Me.btnBack = New LMS.RoundedButton()
        Me.lblLogEntries = New System.Windows.Forms.Label()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.dptTo = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dptFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.Books = New System.Windows.Forms.DataGridView()
        Me.clmIDNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGBEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DGBDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogEntryLayout.SuspendLayout()
        Me.PanelHolder.SuspendLayout()
        Me.LibraryLogEntries.SuspendLayout()
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
        'LogEntryLayout
        '
        Me.LogEntryLayout.BackColor = System.Drawing.Color.White
        Me.LogEntryLayout.ColumnCount = 3
        Me.LogEntryLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.LogEntryLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.LogEntryLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.LogEntryLayout.Controls.Add(Me.PanelHolder, 1, 1)
        Me.LogEntryLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogEntryLayout.Location = New System.Drawing.Point(0, 110)
        Me.LogEntryLayout.Name = "LogEntryLayout"
        Me.LogEntryLayout.RowCount = 3
        Me.LogEntryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.291874!))
        Me.LogEntryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.70812!))
        Me.LogEntryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.LogEntryLayout.Size = New System.Drawing.Size(1370, 639)
        Me.LogEntryLayout.TabIndex = 3
        '
        'PanelHolder
        '
        Me.PanelHolder.Controls.Add(Me.LibraryLogEntries)
        Me.PanelHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHolder.Location = New System.Drawing.Point(71, 53)
        Me.PanelHolder.Name = "PanelHolder"
        Me.PanelHolder.Size = New System.Drawing.Size(1227, 547)
        Me.PanelHolder.TabIndex = 1
        '
        'LibraryLogEntries
        '
        Me.LibraryLogEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.LibraryLogEntries.Controls.Add(Me.btnExport)
        Me.LibraryLogEntries.Controls.Add(Me.btnBack)
        Me.LibraryLogEntries.Controls.Add(Me.lblLogEntries)
        Me.LibraryLogEntries.Controls.Add(Me.grpFilter)
        Me.LibraryLogEntries.Controls.Add(Me.Books)
        Me.LibraryLogEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibraryLogEntries.Location = New System.Drawing.Point(0, 0)
        Me.LibraryLogEntries.Name = "LibraryLogEntries"
        Me.LibraryLogEntries.Size = New System.Drawing.Size(1227, 547)
        Me.LibraryLogEntries.TabIndex = 22
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExport.Image = Global.LMS.My.Resources.Resources.Export
        Me.btnExport.Location = New System.Drawing.Point(1152, 88)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(48, 39)
        Me.btnExport.TabIndex = 19
        Me.btnExport.UseVisualStyleBackColor = False
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
        'lblLogEntries
        '
        Me.lblLogEntries.AutoSize = True
        Me.lblLogEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblLogEntries.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogEntries.ForeColor = System.Drawing.Color.White
        Me.lblLogEntries.Location = New System.Drawing.Point(552, 30)
        Me.lblLogEntries.Name = "lblLogEntries"
        Me.lblLogEntries.Size = New System.Drawing.Size(217, 33)
        Me.lblLogEntries.TabIndex = 17
        Me.lblLogEntries.Text = "Library Log Entries"
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.lblDateFrom)
        Me.grpFilter.Controls.Add(Me.lblTo)
        Me.grpFilter.Controls.Add(Me.dptFrom)
        Me.grpFilter.Controls.Add(Me.dptTo)
        Me.grpFilter.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFilter.ForeColor = System.Drawing.Color.White
        Me.grpFilter.Location = New System.Drawing.Point(275, 79)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(646, 48)
        Me.grpFilter.TabIndex = 1
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Filter"
        '
        'dptTo
        '
        Me.dptTo.Location = New System.Drawing.Point(391, 16)
        Me.dptTo.Name = "dptTo"
        Me.dptTo.Size = New System.Drawing.Size(236, 26)
        Me.dptTo.TabIndex = 4
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(364, 20)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(21, 18)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "to"
        '
        'dptFrom
        '
        Me.dptFrom.Location = New System.Drawing.Point(122, 16)
        Me.dptFrom.Name = "dptFrom"
        Me.dptFrom.Size = New System.Drawing.Size(236, 26)
        Me.dptFrom.TabIndex = 2
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Location = New System.Drawing.Point(46, 20)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(75, 18)
        Me.lblDateFrom.TabIndex = 0
        Me.lblDateFrom.Text = "Date from"
        '
        'Books
        '
        Me.Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Books.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIDNumber, Me.clmName, Me.clmRole, Me.clmDateTime, Me.clmStatus, Me.DGBEdit, Me.DGBDelete})
        Me.Books.Location = New System.Drawing.Point(27, 133)
        Me.Books.Name = "Books"
        Me.Books.Size = New System.Drawing.Size(1173, 361)
        Me.Books.TabIndex = 0
        '
        'clmIDNumber
        '
        Me.clmIDNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmIDNumber.HeaderText = "ID Number"
        Me.clmIDNumber.Name = "clmIDNumber"
        '
        'clmName
        '
        Me.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmName.HeaderText = "Name"
        Me.clmName.Name = "clmName"
        '
        'clmRole
        '
        Me.clmRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmRole.HeaderText = "Role"
        Me.clmRole.Name = "clmRole"
        '
        'clmDateTime
        '
        Me.clmDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmDateTime.HeaderText = "Date and Time"
        Me.clmDateTime.Name = "clmDateTime"
        '
        'clmStatus
        '
        Me.clmStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmStatus.HeaderText = "Status"
        Me.clmStatus.Name = "clmStatus"
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
        'LogEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.LogEntryLayout)
        Me.Controls.Add(Me.Header)
        Me.Name = "LogEntry"
        Me.Text = "Log Entry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Header.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogEntryLayout.ResumeLayout(False)
        Me.PanelHolder.ResumeLayout(False)
        Me.LibraryLogEntries.ResumeLayout(False)
        Me.LibraryLogEntries.PerformLayout()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        CType(Me.Books, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogEntryLayout As TableLayoutPanel
    Friend WithEvents PanelHolder As Panel
    Friend WithEvents LibraryLogEntries As RoundedPanel
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents lblLogEntries As Label
    Friend WithEvents grpFilter As GroupBox
    Friend WithEvents lblDateFrom As Label
    Friend WithEvents Books As DataGridView
    Friend WithEvents dptTo As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents dptFrom As DateTimePicker
    Friend WithEvents btnExport As RoundedButton
    Friend WithEvents clmIDNumber As DataGridViewTextBoxColumn
    Friend WithEvents clmName As DataGridViewTextBoxColumn
    Friend WithEvents clmRole As DataGridViewTextBoxColumn
    Friend WithEvents clmDateTime As DataGridViewTextBoxColumn
    Friend WithEvents clmStatus As DataGridViewTextBoxColumn
    Friend WithEvents DGBEdit As DataGridViewButtonColumn
    Friend WithEvents DGBDelete As DataGridViewButtonColumn
End Class
