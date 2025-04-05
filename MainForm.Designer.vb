<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title8 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Header = New System.Windows.Forms.Panel()
        Me.picLMS = New System.Windows.Forms.PictureBox()
        Me.picESTI = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.AboutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Navigation = New System.Windows.Forms.Panel()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.Homepage = New System.Windows.Forms.TableLayoutPanel()
        Me.Dashboard = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Settings = New System.Windows.Forms.Panel()
        Me.SettingsLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlProfile = New System.Windows.Forms.Panel()
        Me.AdminManagement = New System.Windows.Forms.Panel()
        Me.AdminMngmtLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvAdmins = New System.Windows.Forms.DataGridView()
        Me.Notifications = New System.Windows.Forms.TableLayoutPanel()
        Me.Statistics = New System.Windows.Forms.TableLayoutPanel()
        Me.StatsGeneral = New System.Windows.Forms.TableLayoutPanel()
        Me.DashboardOutline = New LMS.OutlineRoundPanel()
        Me.lblRecentLogs = New System.Windows.Forms.Label()
        Me.displayRecentLogs = New LMS.RoundedPanel()
        Me.lblOverdue = New System.Windows.Forms.Label()
        Me.lblReturned = New System.Windows.Forms.Label()
        Me.displayOverdue = New LMS.RoundedPanel()
        Me.displayReturned = New LMS.RoundedPanel()
        Me.displayBorrowed = New LMS.RoundedPanel()
        Me.lblBorrowed = New System.Windows.Forms.Label()
        Me.lblTotalBooks = New System.Windows.Forms.Label()
        Me.displayTotalBooks = New LMS.RoundedPanel()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.BookStats = New LMS.OutlineRoundPanel()
        Me.chartStatistics = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LogEntryStats = New LMS.OutlineRoundPanel()
        Me.lblWeekly = New System.Windows.Forms.Label()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.AnnualLogs = New LMS.CircularProgressBar()
        Me.ChangePW = New LMS.OutlineRoundPanel()
        Me.btnVerify = New LMS.RoundedButton()
        Me.btnSave = New LMS.RoundedButton()
        Me.txtCode = New LMS.RoundedTextbox()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.txtConfirmPassword = New LMS.RoundedTextbox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New LMS.RoundedTextbox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblChangePW = New System.Windows.Forms.Label()
        Me.txtCurrentPassword = New LMS.RoundedTextbox()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.ProfileMngmt = New LMS.OutlineRoundPanel()
        Me.lblImageFileName = New System.Windows.Forms.Label()
        Me.btnSaveProfile = New LMS.RoundedButton()
        Me.btnChoosePhoto = New LMS.RoundedButton()
        Me.lblProfilePicture = New System.Windows.Forms.Label()
        Me.txtContact = New LMS.RoundedTextbox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtFullname = New LMS.RoundedTextbox()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.txtUsername = New LMS.RoundedTextbox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblProfileMngmt = New System.Windows.Forms.Label()
        Me.AddAdmin = New LMS.OutlineRoundPanel()
        Me.cmbChooseRole = New System.Windows.Forms.ComboBox()
        Me.lblAddRole = New System.Windows.Forms.Label()
        Me.txtAddContact = New LMS.RoundedTextbox()
        Me.lblAddContact = New System.Windows.Forms.Label()
        Me.txtAddLastname = New LMS.RoundedTextbox()
        Me.lblAddLastname = New System.Windows.Forms.Label()
        Me.txtAddFirstname = New LMS.RoundedTextbox()
        Me.lblAddFirstname = New System.Windows.Forms.Label()
        Me.lblAdminMngmt = New System.Windows.Forms.Label()
        Me.pnlNotifications = New LMS.OutlineRoundPanel()
        Me.btnDeleteNotification = New LMS.RoundedButton()
        Me.btnMarkAsRead = New LMS.RoundedButton()
        Me.grpFiltersNotif = New System.Windows.Forms.GroupBox()
        Me.ApplyFilter = New LMS.RoundedButton()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblNotifications = New System.Windows.Forms.Label()
        Me.picProfile = New LMS.RoundPictureBox()
        Me.btnSettings = New LMS.RoundedButton()
        Me.btnNotif = New LMS.RoundedButton()
        Me.btnLogout = New LMS.RoundedButton()
        Me.btnStatistics = New LMS.RoundedButton()
        Me.btnHome = New LMS.RoundedButton()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.ManageQuickAccess = New System.Windows.Forms.TableLayoutPanel()
        Me.QuickAccess = New System.Windows.Forms.Panel()
        Me.lblQuickAccess = New System.Windows.Forms.Label()
        Me.QuickAccessOutline = New LMS.OutlineRoundPanel()
        Me.RoundedButton1 = New LMS.RoundedButton()
        Me.RoundedButton2 = New LMS.RoundedButton()
        Me.RoundedButton3 = New LMS.RoundedButton()
        Me.OutlineRoundPanel3 = New LMS.OutlineRoundPanel()
        Me.lblManage = New System.Windows.Forms.Label()
        Me.btnBookMngmt = New LMS.RoundedButton()
        Me.btnTransactions = New LMS.RoundedButton()
        Me.btnEntryLogs = New LMS.RoundedButton()
        Me.btnOPAC = New LMS.RoundedButton()
        Me.lblAccession = New System.Windows.Forms.Label()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.lblEntryLogs = New System.Windows.Forms.Label()
        Me.lblOPAC = New System.Windows.Forms.Label()
        Me.Manage = New System.Windows.Forms.Panel()
        Me.btnAddAdmin = New LMS.RoundedButton()
        Me.lvNotifications = New System.Windows.Forms.ListView()
        Me.clmDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmMessage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmSender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Header.SuspendLayout()
        CType(Me.picLMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picESTI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AboutPanel.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Navigation.SuspendLayout()
        Me.Homepage.SuspendLayout()
        Me.Dashboard.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.SettingsLayout.SuspendLayout()
        Me.pnlProfile.SuspendLayout()
        Me.AdminManagement.SuspendLayout()
        Me.AdminMngmtLayout.SuspendLayout()
        CType(Me.dgvAdmins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Notifications.SuspendLayout()
        Me.Statistics.SuspendLayout()
        Me.StatsGeneral.SuspendLayout()
        Me.DashboardOutline.SuspendLayout()
        Me.BookStats.SuspendLayout()
        CType(Me.chartStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogEntryStats.SuspendLayout()
        Me.ChangePW.SuspendLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfileMngmt.SuspendLayout()
        Me.AddAdmin.SuspendLayout()
        Me.pnlNotifications.SuspendLayout()
        Me.grpFiltersNotif.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManageQuickAccess.SuspendLayout()
        Me.QuickAccess.SuspendLayout()
        Me.QuickAccessOutline.SuspendLayout()
        Me.OutlineRoundPanel3.SuspendLayout()
        Me.Manage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Header.Controls.Add(Me.picLMS)
        Me.Header.Controls.Add(Me.picESTI)
        Me.Header.Controls.Add(Me.picLogo)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1370, 110)
        Me.Header.TabIndex = 0
        '
        'picLMS
        '
        Me.picLMS.Image = CType(resources.GetObject("picLMS.Image"), System.Drawing.Image)
        Me.picLMS.Location = New System.Drawing.Point(309, 19)
        Me.picLMS.Name = "picLMS"
        Me.picLMS.Size = New System.Drawing.Size(283, 78)
        Me.picLMS.TabIndex = 2
        Me.picLMS.TabStop = False
        '
        'picESTI
        '
        Me.picESTI.Image = CType(resources.GetObject("picESTI.Image"), System.Drawing.Image)
        Me.picESTI.Location = New System.Drawing.Point(111, 16)
        Me.picESTI.Name = "picESTI"
        Me.picESTI.Size = New System.Drawing.Size(196, 78)
        Me.picESTI.TabIndex = 1
        Me.picESTI.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(11, 8)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(94, 90)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RichTextBox1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(112, 385)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(908, 237)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'AboutPanel
        '
        Me.AboutPanel.BackColor = System.Drawing.Color.White
        Me.AboutPanel.ColumnCount = 1
        Me.AboutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AboutPanel.Controls.Add(Me.RichTextBox1, 0, 2)
        Me.AboutPanel.Controls.Add(Me.PictureBox8, 0, 1)
        Me.AboutPanel.Controls.Add(Me.PictureBox7, 0, 0)
        Me.AboutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AboutPanel.Location = New System.Drawing.Point(238, 110)
        Me.AboutPanel.Name = "AboutPanel"
        Me.AboutPanel.RowCount = 3
        Me.AboutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280.0!))
        Me.AboutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.79109!))
        Me.AboutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.20892!))
        Me.AboutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.AboutPanel.Size = New System.Drawing.Size(1132, 639)
        Me.AboutPanel.TabIndex = 3
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(343, 284)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(445, 80)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(351, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(429, 256)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDate.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(0, 600)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(236, 37)
        Me.lblDate.TabIndex = 5
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTime
        '
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTime.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(0, 546)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(236, 54)
        Me.lblTime.TabIndex = 6
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Navigation
        '
        Me.Navigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Navigation.Controls.Add(Me.lblPosition)
        Me.Navigation.Controls.Add(Me.lblName)
        Me.Navigation.Controls.Add(Me.lblRole)
        Me.Navigation.Controls.Add(Me.picProfile)
        Me.Navigation.Controls.Add(Me.btnSettings)
        Me.Navigation.Controls.Add(Me.btnNotif)
        Me.Navigation.Controls.Add(Me.btnLogout)
        Me.Navigation.Controls.Add(Me.btnStatistics)
        Me.Navigation.Controls.Add(Me.btnHome)
        Me.Navigation.Controls.Add(Me.lblTime)
        Me.Navigation.Controls.Add(Me.lblDate)
        Me.Navigation.Dock = System.Windows.Forms.DockStyle.Left
        Me.Navigation.Location = New System.Drawing.Point(0, 110)
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(238, 639)
        Me.Navigation.TabIndex = 1
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblPosition.Location = New System.Drawing.Point(77, 172)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(76, 19)
        Me.lblPosition.TabIndex = 15
        Me.lblPosition.Text = "Librarian"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(87, 144)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 23)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Name"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(53, 11)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(127, 23)
        Me.lblRole.TabIndex = 13
        Me.lblRole.Text = "Administrator"
        '
        'Homepage
        '
        Me.Homepage.BackColor = System.Drawing.Color.White
        Me.Homepage.ColumnCount = 1
        Me.Homepage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Homepage.Controls.Add(Me.Dashboard, 0, 1)
        Me.Homepage.Controls.Add(Me.ManageQuickAccess, 0, 0)
        Me.Homepage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Homepage.Location = New System.Drawing.Point(238, 110)
        Me.Homepage.Name = "Homepage"
        Me.Homepage.RowCount = 3
        Me.Homepage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.56778!))
        Me.Homepage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.43222!))
        Me.Homepage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 239.0!))
        Me.Homepage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Homepage.Size = New System.Drawing.Size(1132, 639)
        Me.Homepage.TabIndex = 8
        '
        'Dashboard
        '
        Me.Dashboard.Controls.Add(Me.DashboardOutline)
        Me.Dashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dashboard.Location = New System.Drawing.Point(3, 237)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Size = New System.Drawing.Size(1126, 159)
        Me.Dashboard.TabIndex = 1
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.Color.White
        Me.Settings.Controls.Add(Me.SettingsLayout)
        Me.Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Settings.Location = New System.Drawing.Point(238, 110)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(1132, 639)
        Me.Settings.TabIndex = 2
        '
        'SettingsLayout
        '
        Me.SettingsLayout.ColumnCount = 1
        Me.SettingsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SettingsLayout.Controls.Add(Me.pnlProfile, 0, 0)
        Me.SettingsLayout.Controls.Add(Me.AdminManagement, 0, 2)
        Me.SettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsLayout.Location = New System.Drawing.Point(0, 0)
        Me.SettingsLayout.Name = "SettingsLayout"
        Me.SettingsLayout.RowCount = 3
        Me.SettingsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.26464!))
        Me.SettingsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.73536!))
        Me.SettingsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 277.0!))
        Me.SettingsLayout.Size = New System.Drawing.Size(1132, 639)
        Me.SettingsLayout.TabIndex = 0
        '
        'pnlProfile
        '
        Me.pnlProfile.Controls.Add(Me.ChangePW)
        Me.pnlProfile.Controls.Add(Me.ProfileMngmt)
        Me.pnlProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProfile.Location = New System.Drawing.Point(3, 3)
        Me.pnlProfile.Name = "pnlProfile"
        Me.pnlProfile.Size = New System.Drawing.Size(1126, 288)
        Me.pnlProfile.TabIndex = 0
        '
        'AdminManagement
        '
        Me.AdminManagement.Controls.Add(Me.AdminMngmtLayout)
        Me.AdminManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminManagement.Location = New System.Drawing.Point(3, 364)
        Me.AdminManagement.Name = "AdminManagement"
        Me.AdminManagement.Size = New System.Drawing.Size(1126, 272)
        Me.AdminManagement.TabIndex = 1
        '
        'AdminMngmtLayout
        '
        Me.AdminMngmtLayout.ColumnCount = 2
        Me.AdminMngmtLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.85258!))
        Me.AdminMngmtLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.14742!))
        Me.AdminMngmtLayout.Controls.Add(Me.dgvAdmins, 0, 0)
        Me.AdminMngmtLayout.Controls.Add(Me.AddAdmin, 0, 0)
        Me.AdminMngmtLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminMngmtLayout.Location = New System.Drawing.Point(0, 0)
        Me.AdminMngmtLayout.Name = "AdminMngmtLayout"
        Me.AdminMngmtLayout.RowCount = 1
        Me.AdminMngmtLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AdminMngmtLayout.Size = New System.Drawing.Size(1126, 272)
        Me.AdminMngmtLayout.TabIndex = 0
        '
        'dgvAdmins
        '
        Me.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdmins.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Username, Me.FullName, Me.ContactInfo, Me.Role, Me.AddPassword, Me.btnEdit, Me.btnDelete})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdmins.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAdmins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAdmins.Location = New System.Drawing.Point(463, 3)
        Me.dgvAdmins.Name = "dgvAdmins"
        Me.dgvAdmins.Size = New System.Drawing.Size(660, 266)
        Me.dgvAdmins.TabIndex = 8
        '
        'Notifications
        '
        Me.Notifications.BackColor = System.Drawing.Color.White
        Me.Notifications.ColumnCount = 3
        Me.Notifications.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.Notifications.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.Notifications.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.Notifications.Controls.Add(Me.pnlNotifications, 1, 1)
        Me.Notifications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notifications.Location = New System.Drawing.Point(238, 110)
        Me.Notifications.Name = "Notifications"
        Me.Notifications.RowCount = 3
        Me.Notifications.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Notifications.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 531.0!))
        Me.Notifications.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.Notifications.Size = New System.Drawing.Size(1132, 639)
        Me.Notifications.TabIndex = 16
        '
        'Statistics
        '
        Me.Statistics.BackColor = System.Drawing.Color.White
        Me.Statistics.ColumnCount = 1
        Me.Statistics.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.02827!))
        Me.Statistics.Controls.Add(Me.StatsGeneral, 0, 0)
        Me.Statistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Statistics.Location = New System.Drawing.Point(238, 110)
        Me.Statistics.Name = "Statistics"
        Me.Statistics.RowCount = 3
        Me.Statistics.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.47863!))
        Me.Statistics.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.52137!))
        Me.Statistics.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.Statistics.Size = New System.Drawing.Size(1132, 639)
        Me.Statistics.TabIndex = 1
        '
        'StatsGeneral
        '
        Me.StatsGeneral.ColumnCount = 2
        Me.StatsGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.33393!))
        Me.StatsGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.66608!))
        Me.StatsGeneral.Controls.Add(Me.BookStats, 0, 0)
        Me.StatsGeneral.Controls.Add(Me.LogEntryStats, 0, 0)
        Me.StatsGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatsGeneral.Location = New System.Drawing.Point(3, 3)
        Me.StatsGeneral.Name = "StatsGeneral"
        Me.StatsGeneral.RowCount = 1
        Me.StatsGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.StatsGeneral.Size = New System.Drawing.Size(1126, 270)
        Me.StatsGeneral.TabIndex = 0
        '
        'DashboardOutline
        '
        Me.DashboardOutline.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DashboardOutline.BackColor = System.Drawing.Color.White
        Me.DashboardOutline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DashboardOutline.BorderColor = System.Drawing.Color.Black
        Me.DashboardOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DashboardOutline.BorderWidth = 6
        Me.DashboardOutline.Controls.Add(Me.lblDashboard)
        Me.DashboardOutline.Controls.Add(Me.lblTotalBooks)
        Me.DashboardOutline.Controls.Add(Me.lblBorrowed)
        Me.DashboardOutline.Controls.Add(Me.lblRecentLogs)
        Me.DashboardOutline.Controls.Add(Me.lblReturned)
        Me.DashboardOutline.Controls.Add(Me.lblOverdue)
        Me.DashboardOutline.Controls.Add(Me.displayTotalBooks)
        Me.DashboardOutline.Controls.Add(Me.displayBorrowed)
        Me.DashboardOutline.Controls.Add(Me.displayRecentLogs)
        Me.DashboardOutline.Controls.Add(Me.displayReturned)
        Me.DashboardOutline.Controls.Add(Me.displayOverdue)
        Me.DashboardOutline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardOutline.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardOutline.Location = New System.Drawing.Point(0, 0)
        Me.DashboardOutline.Name = "DashboardOutline"
        Me.DashboardOutline.Size = New System.Drawing.Size(1126, 159)
        Me.DashboardOutline.TabIndex = 2
        '
        'lblRecentLogs
        '
        Me.lblRecentLogs.AutoSize = True
        Me.lblRecentLogs.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentLogs.Location = New System.Drawing.Point(952, 101)
        Me.lblRecentLogs.Name = "lblRecentLogs"
        Me.lblRecentLogs.Size = New System.Drawing.Size(118, 18)
        Me.lblRecentLogs.TabIndex = 5
        Me.lblRecentLogs.Text = "Recent Log Entries"
        '
        'displayRecentLogs
        '
        Me.displayRecentLogs.BackColor = System.Drawing.Color.Gainsboro
        Me.displayRecentLogs.Location = New System.Drawing.Point(919, 52)
        Me.displayRecentLogs.Name = "displayRecentLogs"
        Me.displayRecentLogs.Size = New System.Drawing.Size(180, 47)
        Me.displayRecentLogs.TabIndex = 6
        '
        'lblOverdue
        '
        Me.lblOverdue.AutoSize = True
        Me.lblOverdue.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdue.Location = New System.Drawing.Point(740, 101)
        Me.lblOverdue.Name = "lblOverdue"
        Me.lblOverdue.Size = New System.Drawing.Size(97, 18)
        Me.lblOverdue.TabIndex = 2
        Me.lblOverdue.Text = "Overdue Books"
        '
        'lblReturned
        '
        Me.lblReturned.AutoSize = True
        Me.lblReturned.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturned.Location = New System.Drawing.Point(513, 101)
        Me.lblReturned.Name = "lblReturned"
        Me.lblReturned.Size = New System.Drawing.Size(101, 18)
        Me.lblReturned.TabIndex = 3
        Me.lblReturned.Text = "Books Returned"
        '
        'displayOverdue
        '
        Me.displayOverdue.BackColor = System.Drawing.Color.Gainsboro
        Me.displayOverdue.Location = New System.Drawing.Point(696, 52)
        Me.displayOverdue.Name = "displayOverdue"
        Me.displayOverdue.Size = New System.Drawing.Size(180, 47)
        Me.displayOverdue.TabIndex = 3
        '
        'displayReturned
        '
        Me.displayReturned.BackColor = System.Drawing.Color.Gainsboro
        Me.displayReturned.Location = New System.Drawing.Point(473, 52)
        Me.displayReturned.Name = "displayReturned"
        Me.displayReturned.Size = New System.Drawing.Size(180, 47)
        Me.displayReturned.TabIndex = 4
        '
        'displayBorrowed
        '
        Me.displayBorrowed.BackColor = System.Drawing.Color.Gainsboro
        Me.displayBorrowed.Location = New System.Drawing.Point(250, 52)
        Me.displayBorrowed.Name = "displayBorrowed"
        Me.displayBorrowed.Size = New System.Drawing.Size(180, 47)
        Me.displayBorrowed.TabIndex = 2
        '
        'lblBorrowed
        '
        Me.lblBorrowed.AutoSize = True
        Me.lblBorrowed.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowed.Location = New System.Drawing.Point(286, 101)
        Me.lblBorrowed.Name = "lblBorrowed"
        Me.lblBorrowed.Size = New System.Drawing.Size(106, 18)
        Me.lblBorrowed.TabIndex = 1
        Me.lblBorrowed.Text = "Books Borrowed"
        '
        'lblTotalBooks
        '
        Me.lblTotalBooks.AutoSize = True
        Me.lblTotalBooks.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBooks.Location = New System.Drawing.Point(81, 101)
        Me.lblTotalBooks.Name = "lblTotalBooks"
        Me.lblTotalBooks.Size = New System.Drawing.Size(75, 18)
        Me.lblTotalBooks.TabIndex = 0
        Me.lblTotalBooks.Text = "Total Books"
        '
        'displayTotalBooks
        '
        Me.displayTotalBooks.BackColor = System.Drawing.Color.Gainsboro
        Me.displayTotalBooks.Location = New System.Drawing.Point(29, 52)
        Me.displayTotalBooks.Name = "displayTotalBooks"
        Me.displayTotalBooks.Size = New System.Drawing.Size(180, 47)
        Me.displayTotalBooks.TabIndex = 1
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblDashboard.Location = New System.Drawing.Point(28, -3)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(129, 33)
        Me.lblDashboard.TabIndex = 0
        Me.lblDashboard.Text = "Dashboard"
        '
        'BookStats
        '
        Me.BookStats.BorderColor = System.Drawing.Color.Black
        Me.BookStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BookStats.BorderWidth = 6
        Me.BookStats.Controls.Add(Me.chartStatistics)
        Me.BookStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookStats.Location = New System.Drawing.Point(277, 3)
        Me.BookStats.Name = "BookStats"
        Me.BookStats.Size = New System.Drawing.Size(846, 264)
        Me.BookStats.TabIndex = 4
        '
        'chartStatistics
        '
        ChartArea8.AxisX.Title = "Statistics"
        ChartArea8.AxisY.Title = "Count"
        ChartArea8.Name = "ChartArea1"
        Me.chartStatistics.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.chartStatistics.Legends.Add(Legend8)
        Me.chartStatistics.Location = New System.Drawing.Point(34, 15)
        Me.chartStatistics.Name = "chartStatistics"
        Series8.ChartArea = "ChartArea1"
        Series8.Color = System.Drawing.Color.Green
        Series8.Legend = "Legend1"
        Series8.Name = "StatisticsSeries"
        Me.chartStatistics.Series.Add(Series8)
        Me.chartStatistics.Size = New System.Drawing.Size(661, 216)
        Me.chartStatistics.TabIndex = 0
        Title8.Name = "Title1"
        Title8.Text = "Library Statistics Overview"
        Me.chartStatistics.Titles.Add(Title8)
        '
        'LogEntryStats
        '
        Me.LogEntryStats.BorderColor = System.Drawing.Color.Black
        Me.LogEntryStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogEntryStats.BorderWidth = 6
        Me.LogEntryStats.Controls.Add(Me.lblMonthly)
        Me.LogEntryStats.Controls.Add(Me.lblWeekly)
        Me.LogEntryStats.Controls.Add(Me.lblAnnual)
        Me.LogEntryStats.Controls.Add(Me.AnnualLogs)
        Me.LogEntryStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogEntryStats.Location = New System.Drawing.Point(3, 3)
        Me.LogEntryStats.Name = "LogEntryStats"
        Me.LogEntryStats.Size = New System.Drawing.Size(268, 264)
        Me.LogEntryStats.TabIndex = 3
        '
        'lblWeekly
        '
        Me.lblWeekly.AutoSize = True
        Me.lblWeekly.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeekly.Location = New System.Drawing.Point(32, 183)
        Me.lblWeekly.Name = "lblWeekly"
        Me.lblWeekly.Size = New System.Drawing.Size(97, 17)
        Me.lblWeekly.TabIndex = 3
        Me.lblWeekly.Text = "Weekly Average:"
        '
        'lblAnnual
        '
        Me.lblAnnual.AutoSize = True
        Me.lblAnnual.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnual.Location = New System.Drawing.Point(63, 25)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(147, 19)
        Me.lblAnnual.TabIndex = 1
        Me.lblAnnual.Text = "Annual Log Entries"
        '
        'AnnualLogs
        '
        Me.AnnualLogs.BackColor = System.Drawing.Color.Transparent
        Me.AnnualLogs.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.AnnualLogs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AnnualLogs.Location = New System.Drawing.Point(83, 59)
        Me.AnnualLogs.MaxValue = 100
        Me.AnnualLogs.Name = "AnnualLogs"
        Me.AnnualLogs.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.AnnualLogs.ProgressValue = 0
        Me.AnnualLogs.Size = New System.Drawing.Size(100, 100)
        Me.AnnualLogs.TabIndex = 0
        '
        'ChangePW
        '
        Me.ChangePW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ChangePW.BorderColor = System.Drawing.Color.Black
        Me.ChangePW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangePW.BorderWidth = 6
        Me.ChangePW.Controls.Add(Me.picQRCode)
        Me.ChangePW.Controls.Add(Me.txtCurrentPassword)
        Me.ChangePW.Controls.Add(Me.txtNewPassword)
        Me.ChangePW.Controls.Add(Me.txtConfirmPassword)
        Me.ChangePW.Controls.Add(Me.lblChangePW)
        Me.ChangePW.Controls.Add(Me.lblCurrentPassword)
        Me.ChangePW.Controls.Add(Me.lblNewPassword)
        Me.ChangePW.Controls.Add(Me.lblConfirmPassword)
        Me.ChangePW.Controls.Add(Me.btnVerify)
        Me.ChangePW.Controls.Add(Me.btnSave)
        Me.ChangePW.Controls.Add(Me.txtCode)
        Me.ChangePW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangePW.Location = New System.Drawing.Point(458, 0)
        Me.ChangePW.Name = "ChangePW"
        Me.ChangePW.Size = New System.Drawing.Size(668, 288)
        Me.ChangePW.TabIndex = 2
        '
        'btnVerify
        '
        Me.btnVerify.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerify.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnVerify.Location = New System.Drawing.Point(572, 199)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(51, 25)
        Me.btnVerify.TabIndex = 24
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(254, 204)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 27)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCode.Location = New System.Drawing.Point(503, 201)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(68, 23)
        Me.txtCode.TabIndex = 22
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picQRCode
        '
        Me.picQRCode.BackColor = System.Drawing.Color.White
        Me.picQRCode.Location = New System.Drawing.Point(503, 84)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(120, 112)
        Me.picQRCode.TabIndex = 21
        Me.picQRCode.TabStop = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(198, 164)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.ReadOnly = True
        Me.txtConfirmPassword.Size = New System.Drawing.Size(254, 27)
        Me.txtConfirmPassword.TabIndex = 20
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(40, 168)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(156, 19)
        Me.lblConfirmPassword.TabIndex = 19
        Me.lblConfirmPassword.Text = "Confirm New Password"
        Me.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassword.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(197, 124)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.ReadOnly = True
        Me.txtNewPassword.Size = New System.Drawing.Size(254, 27)
        Me.txtNewPassword.TabIndex = 18
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblNewPassword.Location = New System.Drawing.Point(94, 128)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(102, 19)
        Me.lblNewPassword.TabIndex = 17
        Me.lblNewPassword.Text = "New Password"
        Me.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChangePW
        '
        Me.lblChangePW.AutoSize = True
        Me.lblChangePW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblChangePW.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePW.ForeColor = System.Drawing.Color.White
        Me.lblChangePW.Location = New System.Drawing.Point(236, 22)
        Me.lblChangePW.Name = "lblChangePW"
        Me.lblChangePW.Size = New System.Drawing.Size(164, 27)
        Me.lblChangePW.TabIndex = 16
        Me.lblChangePW.Text = "Change Password"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(198, 83)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.ReadOnly = True
        Me.txtCurrentPassword.Size = New System.Drawing.Size(254, 27)
        Me.txtCurrentPassword.TabIndex = 9
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.AutoSize = True
        Me.lblCurrentPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblCurrentPassword.Location = New System.Drawing.Point(74, 86)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(123, 19)
        Me.lblCurrentPassword.TabIndex = 8
        Me.lblCurrentPassword.Text = "Current Password"
        Me.lblCurrentPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProfileMngmt
        '
        Me.ProfileMngmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ProfileMngmt.BorderColor = System.Drawing.Color.Black
        Me.ProfileMngmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfileMngmt.BorderWidth = 6
        Me.ProfileMngmt.Controls.Add(Me.txtUsername)
        Me.ProfileMngmt.Controls.Add(Me.txtFullname)
        Me.ProfileMngmt.Controls.Add(Me.txtContact)
        Me.ProfileMngmt.Controls.Add(Me.lblProfileMngmt)
        Me.ProfileMngmt.Controls.Add(Me.lblUsername)
        Me.ProfileMngmt.Controls.Add(Me.lblContact)
        Me.ProfileMngmt.Controls.Add(Me.lblLastname)
        Me.ProfileMngmt.Controls.Add(Me.lblProfilePicture)
        Me.ProfileMngmt.Controls.Add(Me.lblImageFileName)
        Me.ProfileMngmt.Controls.Add(Me.btnSaveProfile)
        Me.ProfileMngmt.Controls.Add(Me.btnChoosePhoto)
        Me.ProfileMngmt.Cursor = System.Windows.Forms.Cursors.Default
        Me.ProfileMngmt.Dock = System.Windows.Forms.DockStyle.Left
        Me.ProfileMngmt.Location = New System.Drawing.Point(0, 0)
        Me.ProfileMngmt.Name = "ProfileMngmt"
        Me.ProfileMngmt.Size = New System.Drawing.Size(458, 288)
        Me.ProfileMngmt.TabIndex = 1
        '
        'lblImageFileName
        '
        Me.lblImageFileName.AutoSize = True
        Me.lblImageFileName.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImageFileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblImageFileName.Location = New System.Drawing.Point(280, 165)
        Me.lblImageFileName.Name = "lblImageFileName"
        Me.lblImageFileName.Size = New System.Drawing.Size(98, 16)
        Me.lblImageFileName.TabIndex = 15
        Me.lblImageFileName.Text = "*Image FileName*"
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProfile.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSaveProfile.Location = New System.Drawing.Point(157, 204)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(136, 27)
        Me.btnSaveProfile.TabIndex = 14
        Me.btnSaveProfile.Text = "Save"
        Me.btnSaveProfile.UseVisualStyleBackColor = False
        '
        'btnChoosePhoto
        '
        Me.btnChoosePhoto.BackColor = System.Drawing.Color.LightGray
        Me.btnChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChoosePhoto.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoosePhoto.Location = New System.Drawing.Point(141, 161)
        Me.btnChoosePhoto.Name = "btnChoosePhoto"
        Me.btnChoosePhoto.Size = New System.Drawing.Size(131, 27)
        Me.btnChoosePhoto.TabIndex = 13
        Me.btnChoosePhoto.Text = "Choose Photo"
        Me.btnChoosePhoto.UseVisualStyleBackColor = False
        '
        'lblProfilePicture
        '
        Me.lblProfilePicture.AutoSize = True
        Me.lblProfilePicture.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfilePicture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblProfilePicture.Location = New System.Drawing.Point(32, 167)
        Me.lblProfilePicture.Name = "lblProfilePicture"
        Me.lblProfilePicture.Size = New System.Drawing.Size(102, 19)
        Me.lblProfilePicture.TabIndex = 12
        Me.lblProfilePicture.Text = "Profile Picture:"
        Me.lblProfilePicture.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(140, 127)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(269, 27)
        Me.txtContact.TabIndex = 11
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(45, 132)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(88, 19)
        Me.lblContact.TabIndex = 10
        Me.lblContact.Text = "Contact Info:"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFullname
        '
        Me.txtFullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullname.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(140, 92)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.ReadOnly = True
        Me.txtFullname.Size = New System.Drawing.Size(269, 27)
        Me.txtFullname.TabIndex = 9
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblLastname.Location = New System.Drawing.Point(57, 96)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(75, 19)
        Me.lblLastname.TabIndex = 8
        Me.lblLastname.Text = "Full Name:"
        Me.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(140, 58)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(269, 27)
        Me.txtUsername.TabIndex = 7
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(55, 61)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(76, 19)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProfileMngmt
        '
        Me.lblProfileMngmt.AutoSize = True
        Me.lblProfileMngmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblProfileMngmt.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileMngmt.ForeColor = System.Drawing.Color.White
        Me.lblProfileMngmt.Location = New System.Drawing.Point(144, 20)
        Me.lblProfileMngmt.Name = "lblProfileMngmt"
        Me.lblProfileMngmt.Size = New System.Drawing.Size(182, 27)
        Me.lblProfileMngmt.TabIndex = 5
        Me.lblProfileMngmt.Text = "Profile Management"
        '
        'AddAdmin
        '
        Me.AddAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.AddAdmin.BorderColor = System.Drawing.Color.Black
        Me.AddAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddAdmin.BorderWidth = 6
        Me.AddAdmin.Controls.Add(Me.txtAddFirstname)
        Me.AddAdmin.Controls.Add(Me.txtAddLastname)
        Me.AddAdmin.Controls.Add(Me.txtAddContact)
        Me.AddAdmin.Controls.Add(Me.cmbChooseRole)
        Me.AddAdmin.Controls.Add(Me.lblAdminMngmt)
        Me.AddAdmin.Controls.Add(Me.lblAddFirstname)
        Me.AddAdmin.Controls.Add(Me.lblAddLastname)
        Me.AddAdmin.Controls.Add(Me.lblAddContact)
        Me.AddAdmin.Controls.Add(Me.lblAddRole)
        Me.AddAdmin.Controls.Add(Me.btnAddAdmin)
        Me.AddAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.AddAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddAdmin.Location = New System.Drawing.Point(3, 3)
        Me.AddAdmin.Name = "AddAdmin"
        Me.AddAdmin.Size = New System.Drawing.Size(454, 266)
        Me.AddAdmin.TabIndex = 7
        '
        'cmbChooseRole
        '
        Me.cmbChooseRole.BackColor = System.Drawing.Color.White
        Me.cmbChooseRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbChooseRole.FormattingEnabled = True
        Me.cmbChooseRole.Items.AddRange(New Object() {"Librarian", "Assistant Librarian", "Library Clerk"})
        Me.cmbChooseRole.Location = New System.Drawing.Point(143, 165)
        Me.cmbChooseRole.Name = "cmbChooseRole"
        Me.cmbChooseRole.Size = New System.Drawing.Size(210, 21)
        Me.cmbChooseRole.TabIndex = 16
        '
        'lblAddRole
        '
        Me.lblAddRole.AutoSize = True
        Me.lblAddRole.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddRole.Location = New System.Drawing.Point(94, 167)
        Me.lblAddRole.Name = "lblAddRole"
        Me.lblAddRole.Size = New System.Drawing.Size(39, 19)
        Me.lblAddRole.TabIndex = 12
        Me.lblAddRole.Text = "Role:"
        Me.lblAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddContact
        '
        Me.txtAddContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAddContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddContact.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddContact.Location = New System.Drawing.Point(140, 127)
        Me.txtAddContact.Name = "txtAddContact"
        Me.txtAddContact.ReadOnly = True
        Me.txtAddContact.Size = New System.Drawing.Size(269, 27)
        Me.txtAddContact.TabIndex = 11
        '
        'lblAddContact
        '
        Me.lblAddContact.AutoSize = True
        Me.lblAddContact.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddContact.Location = New System.Drawing.Point(45, 132)
        Me.lblAddContact.Name = "lblAddContact"
        Me.lblAddContact.Size = New System.Drawing.Size(88, 19)
        Me.lblAddContact.TabIndex = 10
        Me.lblAddContact.Text = "Contact Info:"
        Me.lblAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddLastname
        '
        Me.txtAddLastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAddLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddLastname.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddLastname.Location = New System.Drawing.Point(140, 92)
        Me.txtAddLastname.Name = "txtAddLastname"
        Me.txtAddLastname.ReadOnly = True
        Me.txtAddLastname.Size = New System.Drawing.Size(269, 27)
        Me.txtAddLastname.TabIndex = 9
        '
        'lblAddLastname
        '
        Me.lblAddLastname.AutoSize = True
        Me.lblAddLastname.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddLastname.Location = New System.Drawing.Point(53, 96)
        Me.lblAddLastname.Name = "lblAddLastname"
        Me.lblAddLastname.Size = New System.Drawing.Size(75, 19)
        Me.lblAddLastname.TabIndex = 8
        Me.lblAddLastname.Text = "Full Name:"
        Me.lblAddLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddFirstname
        '
        Me.txtAddFirstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAddFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddFirstname.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddFirstname.Location = New System.Drawing.Point(140, 58)
        Me.txtAddFirstname.Name = "txtAddFirstname"
        Me.txtAddFirstname.ReadOnly = True
        Me.txtAddFirstname.Size = New System.Drawing.Size(269, 27)
        Me.txtAddFirstname.TabIndex = 7
        '
        'lblAddFirstname
        '
        Me.lblAddFirstname.AutoSize = True
        Me.lblAddFirstname.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddFirstname.Location = New System.Drawing.Point(57, 61)
        Me.lblAddFirstname.Name = "lblAddFirstname"
        Me.lblAddFirstname.Size = New System.Drawing.Size(76, 19)
        Me.lblAddFirstname.TabIndex = 6
        Me.lblAddFirstname.Text = "Username:"
        Me.lblAddFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdminMngmt
        '
        Me.lblAdminMngmt.AutoSize = True
        Me.lblAdminMngmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblAdminMngmt.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminMngmt.ForeColor = System.Drawing.Color.White
        Me.lblAdminMngmt.Location = New System.Drawing.Point(144, 20)
        Me.lblAdminMngmt.Name = "lblAdminMngmt"
        Me.lblAdminMngmt.Size = New System.Drawing.Size(180, 27)
        Me.lblAdminMngmt.TabIndex = 5
        Me.lblAdminMngmt.Text = "Admin Management"
        '
        'pnlNotifications
        '
        Me.pnlNotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlNotifications.BorderColor = System.Drawing.Color.DarkGreen
        Me.pnlNotifications.BorderWidth = 6
        Me.pnlNotifications.Controls.Add(Me.lblNotifications)
        Me.pnlNotifications.Controls.Add(Me.lvNotifications)
        Me.pnlNotifications.Controls.Add(Me.btnDeleteNotification)
        Me.pnlNotifications.Controls.Add(Me.btnMarkAsRead)
        Me.pnlNotifications.Controls.Add(Me.grpFiltersNotif)
        Me.pnlNotifications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNotifications.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNotifications.Location = New System.Drawing.Point(215, 76)
        Me.pnlNotifications.Name = "pnlNotifications"
        Me.pnlNotifications.Size = New System.Drawing.Size(701, 525)
        Me.pnlNotifications.TabIndex = 0
        '
        'btnDeleteNotification
        '
        Me.btnDeleteNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnDeleteNotification.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteNotification.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnDeleteNotification.Location = New System.Drawing.Point(353, 488)
        Me.btnDeleteNotification.Name = "btnDeleteNotification"
        Me.btnDeleteNotification.Size = New System.Drawing.Size(136, 27)
        Me.btnDeleteNotification.TabIndex = 4
        Me.btnDeleteNotification.Text = "Delete"
        Me.btnDeleteNotification.UseVisualStyleBackColor = False
        '
        'btnMarkAsRead
        '
        Me.btnMarkAsRead.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnMarkAsRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAsRead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnMarkAsRead.Location = New System.Drawing.Point(211, 488)
        Me.btnMarkAsRead.Name = "btnMarkAsRead"
        Me.btnMarkAsRead.Size = New System.Drawing.Size(136, 27)
        Me.btnMarkAsRead.TabIndex = 3
        Me.btnMarkAsRead.Text = "Mark as Read"
        Me.btnMarkAsRead.UseVisualStyleBackColor = False
        '
        'grpFiltersNotif
        '
        Me.grpFiltersNotif.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltersNotif.Controls.Add(Me.ApplyFilter)
        Me.grpFiltersNotif.Controls.Add(Me.cmbStatus)
        Me.grpFiltersNotif.Controls.Add(Me.cmbType)
        Me.grpFiltersNotif.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFiltersNotif.ForeColor = System.Drawing.Color.White
        Me.grpFiltersNotif.Location = New System.Drawing.Point(156, 95)
        Me.grpFiltersNotif.Name = "grpFiltersNotif"
        Me.grpFiltersNotif.Size = New System.Drawing.Size(388, 64)
        Me.grpFiltersNotif.TabIndex = 2
        Me.grpFiltersNotif.TabStop = False
        Me.grpFiltersNotif.Text = "Filter Notifications"
        '
        'ApplyFilter
        '
        Me.ApplyFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ApplyFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.ApplyFilter.Location = New System.Drawing.Point(284, 23)
        Me.ApplyFilter.Name = "ApplyFilter"
        Me.ApplyFilter.Size = New System.Drawing.Size(90, 27)
        Me.ApplyFilter.TabIndex = 2
        Me.ApplyFilter.Text = "Apply"
        Me.ApplyFilter.UseVisualStyleBackColor = False
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"All", "Overdue", "System Alerts", "General"})
        Me.cmbStatus.Location = New System.Drawing.Point(151, 24)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 26)
        Me.cmbStatus.TabIndex = 1
        Me.cmbStatus.Text = "Status"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"All", "Overdue", "System Alerts", "General"})
        Me.cmbType.Location = New System.Drawing.Point(16, 25)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 26)
        Me.cmbType.TabIndex = 0
        Me.cmbType.Text = "Type"
        '
        'lblNotifications
        '
        Me.lblNotifications.AutoSize = True
        Me.lblNotifications.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotifications.ForeColor = System.Drawing.Color.White
        Me.lblNotifications.Location = New System.Drawing.Point(22, 23)
        Me.lblNotifications.Name = "lblNotifications"
        Me.lblNotifications.Size = New System.Drawing.Size(216, 42)
        Me.lblNotifications.TabIndex = 0
        Me.lblNotifications.Text = "Notifications"
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(72, 46)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(92, 91)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 12
        Me.picProfile.TabStop = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettings.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = Global.LMS.My.Resources.Resources.Ssettings
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(11, 289)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(212, 47)
        Me.btnSettings.TabIndex = 11
        Me.btnSettings.Text = "  Settings"
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnNotif
        '
        Me.btnNotif.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNotif.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotif.ForeColor = System.Drawing.Color.White
        Me.btnNotif.Image = Global.LMS.My.Resources.Resources.Snotif
        Me.btnNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotif.Location = New System.Drawing.Point(11, 344)
        Me.btnNotif.Name = "btnNotif"
        Me.btnNotif.Size = New System.Drawing.Size(212, 47)
        Me.btnNotif.TabIndex = 10
        Me.btnNotif.Text = "  Notifications"
        Me.btnNotif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotif.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.LMS.My.Resources.Resources.Slogout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(11, 454)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(212, 47)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "  Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStatistics.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.Color.White
        Me.btnStatistics.Image = Global.LMS.My.Resources.Resources.StatsA
        Me.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatistics.Location = New System.Drawing.Point(11, 399)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(212, 47)
        Me.btnStatistics.TabIndex = 8
        Me.btnStatistics.Text = "   Statistics"
        Me.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.LMS.My.Resources.Resources.homepageS
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(11, 234)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(212, 47)
        Me.btnHome.TabIndex = 7
        Me.btnHome.Text = "  Homepage"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthly.Location = New System.Drawing.Point(32, 206)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(102, 17)
        Me.lblMonthly.TabIndex = 4
        Me.lblMonthly.Text = "Monthly Average:"
        '
        'ManageQuickAccess
        '
        Me.ManageQuickAccess.ColumnCount = 2
        Me.ManageQuickAccess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.37656!))
        Me.ManageQuickAccess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.62345!))
        Me.ManageQuickAccess.Controls.Add(Me.QuickAccess, 1, 0)
        Me.ManageQuickAccess.Controls.Add(Me.Manage, 0, 0)
        Me.ManageQuickAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManageQuickAccess.Location = New System.Drawing.Point(3, 3)
        Me.ManageQuickAccess.Name = "ManageQuickAccess"
        Me.ManageQuickAccess.RowCount = 1
        Me.ManageQuickAccess.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ManageQuickAccess.Size = New System.Drawing.Size(1126, 228)
        Me.ManageQuickAccess.TabIndex = 4
        '
        'QuickAccess
        '
        Me.QuickAccess.Controls.Add(Me.QuickAccessOutline)
        Me.QuickAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuickAccess.Location = New System.Drawing.Point(863, 3)
        Me.QuickAccess.Name = "QuickAccess"
        Me.QuickAccess.Size = New System.Drawing.Size(260, 222)
        Me.QuickAccess.TabIndex = 5
        '
        'lblQuickAccess
        '
        Me.lblQuickAccess.AutoSize = True
        Me.lblQuickAccess.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickAccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblQuickAccess.Location = New System.Drawing.Point(52, -6)
        Me.lblQuickAccess.Name = "lblQuickAccess"
        Me.lblQuickAccess.Size = New System.Drawing.Size(156, 33)
        Me.lblQuickAccess.TabIndex = 5
        Me.lblQuickAccess.Text = "Quick Access"
        '
        'QuickAccessOutline
        '
        Me.QuickAccessOutline.BorderColor = System.Drawing.Color.Black
        Me.QuickAccessOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuickAccessOutline.BorderWidth = 6
        Me.QuickAccessOutline.Controls.Add(Me.RoundedButton3)
        Me.QuickAccessOutline.Controls.Add(Me.RoundedButton2)
        Me.QuickAccessOutline.Controls.Add(Me.RoundedButton1)
        Me.QuickAccessOutline.Controls.Add(Me.lblQuickAccess)
        Me.QuickAccessOutline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuickAccessOutline.Location = New System.Drawing.Point(0, 0)
        Me.QuickAccessOutline.Name = "QuickAccessOutline"
        Me.QuickAccessOutline.Size = New System.Drawing.Size(260, 222)
        Me.QuickAccessOutline.TabIndex = 1
        '
        'RoundedButton1
        '
        Me.RoundedButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.RoundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RoundedButton1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton1.ForeColor = System.Drawing.Color.White
        Me.RoundedButton1.Location = New System.Drawing.Point(35, 53)
        Me.RoundedButton1.Name = "RoundedButton1"
        Me.RoundedButton1.Size = New System.Drawing.Size(188, 33)
        Me.RoundedButton1.TabIndex = 6
        Me.RoundedButton1.Text = "Generate Reports"
        Me.RoundedButton1.UseVisualStyleBackColor = False
        '
        'RoundedButton2
        '
        Me.RoundedButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.RoundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RoundedButton2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton2.ForeColor = System.Drawing.Color.White
        Me.RoundedButton2.Location = New System.Drawing.Point(35, 98)
        Me.RoundedButton2.Name = "RoundedButton2"
        Me.RoundedButton2.Size = New System.Drawing.Size(188, 33)
        Me.RoundedButton2.TabIndex = 7
        Me.RoundedButton2.Text = "Add Books"
        Me.RoundedButton2.UseVisualStyleBackColor = False
        '
        'RoundedButton3
        '
        Me.RoundedButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.RoundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RoundedButton3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedButton3.ForeColor = System.Drawing.Color.White
        Me.RoundedButton3.Location = New System.Drawing.Point(35, 142)
        Me.RoundedButton3.Name = "RoundedButton3"
        Me.RoundedButton3.Size = New System.Drawing.Size(188, 33)
        Me.RoundedButton3.TabIndex = 8
        Me.RoundedButton3.UseVisualStyleBackColor = False
        '
        'OutlineRoundPanel3
        '
        Me.OutlineRoundPanel3.BorderColor = System.Drawing.Color.Black
        Me.OutlineRoundPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutlineRoundPanel3.BorderWidth = 6
        Me.OutlineRoundPanel3.Controls.Add(Me.lblAccession)
        Me.OutlineRoundPanel3.Controls.Add(Me.lblTransactions)
        Me.OutlineRoundPanel3.Controls.Add(Me.lblEntryLogs)
        Me.OutlineRoundPanel3.Controls.Add(Me.lblOPAC)
        Me.OutlineRoundPanel3.Controls.Add(Me.btnOPAC)
        Me.OutlineRoundPanel3.Controls.Add(Me.btnEntryLogs)
        Me.OutlineRoundPanel3.Controls.Add(Me.btnTransactions)
        Me.OutlineRoundPanel3.Controls.Add(Me.btnBookMngmt)
        Me.OutlineRoundPanel3.Controls.Add(Me.lblManage)
        Me.OutlineRoundPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutlineRoundPanel3.Location = New System.Drawing.Point(0, 0)
        Me.OutlineRoundPanel3.Name = "OutlineRoundPanel3"
        Me.OutlineRoundPanel3.Size = New System.Drawing.Size(854, 222)
        Me.OutlineRoundPanel3.TabIndex = 1
        '
        'lblManage
        '
        Me.lblManage.AutoSize = True
        Me.lblManage.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblManage.Location = New System.Drawing.Point(28, -6)
        Me.lblManage.Name = "lblManage"
        Me.lblManage.Size = New System.Drawing.Size(98, 33)
        Me.lblManage.TabIndex = 5
        Me.lblManage.Text = "Manage"
        '
        'btnBookMngmt
        '
        Me.btnBookMngmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnBookMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookMngmt.Image = Global.LMS.My.Resources.Resources.book_management
        Me.btnBookMngmt.Location = New System.Drawing.Point(106, 49)
        Me.btnBookMngmt.Name = "btnBookMngmt"
        Me.btnBookMngmt.Size = New System.Drawing.Size(79, 89)
        Me.btnBookMngmt.TabIndex = 6
        Me.btnBookMngmt.UseVisualStyleBackColor = False
        '
        'btnTransactions
        '
        Me.btnTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransactions.Image = Global.LMS.My.Resources.Resources.circulation
        Me.btnTransactions.Location = New System.Drawing.Point(291, 49)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(79, 89)
        Me.btnTransactions.TabIndex = 7
        Me.btnTransactions.UseVisualStyleBackColor = False
        '
        'btnEntryLogs
        '
        Me.btnEntryLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnEntryLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntryLogs.Image = Global.LMS.My.Resources.Resources.Logbook
        Me.btnEntryLogs.Location = New System.Drawing.Point(479, 49)
        Me.btnEntryLogs.Name = "btnEntryLogs"
        Me.btnEntryLogs.Size = New System.Drawing.Size(79, 89)
        Me.btnEntryLogs.TabIndex = 8
        Me.btnEntryLogs.UseVisualStyleBackColor = False
        '
        'btnOPAC
        '
        Me.btnOPAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnOPAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOPAC.Image = Global.LMS.My.Resources.Resources.OPAC
        Me.btnOPAC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOPAC.Location = New System.Drawing.Point(665, 49)
        Me.btnOPAC.Name = "btnOPAC"
        Me.btnOPAC.Size = New System.Drawing.Size(79, 89)
        Me.btnOPAC.TabIndex = 9
        Me.btnOPAC.UseVisualStyleBackColor = False
        '
        'lblAccession
        '
        Me.lblAccession.AutoSize = True
        Me.lblAccession.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccession.Location = New System.Drawing.Point(82, 143)
        Me.lblAccession.Name = "lblAccession"
        Me.lblAccession.Size = New System.Drawing.Size(127, 18)
        Me.lblAccession.TabIndex = 10
        Me.lblAccession.Text = "Accession Record"
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactions.Location = New System.Drawing.Point(285, 141)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(92, 18)
        Me.lblTransactions.TabIndex = 11
        Me.lblTransactions.Text = "Transactions"
        '
        'lblEntryLogs
        '
        Me.lblEntryLogs.AutoSize = True
        Me.lblEntryLogs.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryLogs.Location = New System.Drawing.Point(481, 141)
        Me.lblEntryLogs.Name = "lblEntryLogs"
        Me.lblEntryLogs.Size = New System.Drawing.Size(80, 18)
        Me.lblEntryLogs.TabIndex = 12
        Me.lblEntryLogs.Text = "Entry Logs"
        '
        'lblOPAC
        '
        Me.lblOPAC.AutoSize = True
        Me.lblOPAC.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPAC.Location = New System.Drawing.Point(643, 141)
        Me.lblOPAC.Name = "lblOPAC"
        Me.lblOPAC.Size = New System.Drawing.Size(128, 48)
        Me.lblOPAC.TabIndex = 13
        Me.lblOPAC.Text = "Online Public Access " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Catalog " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(OPAC)"
        Me.lblOPAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Manage
        '
        Me.Manage.Controls.Add(Me.OutlineRoundPanel3)
        Me.Manage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Manage.Location = New System.Drawing.Point(3, 3)
        Me.Manage.Name = "Manage"
        Me.Manage.Size = New System.Drawing.Size(854, 222)
        Me.Manage.TabIndex = 4
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAdmin.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnAddAdmin.Location = New System.Drawing.Point(157, 204)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(136, 27)
        Me.btnAddAdmin.TabIndex = 14
        Me.btnAddAdmin.Text = "Add"
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'lvNotifications
        '
        Me.lvNotifications.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmDate, Me.clmMessage, Me.clmSender})
        Me.lvNotifications.FullRowSelect = True
        Me.lvNotifications.GridLines = True
        Me.lvNotifications.HideSelection = False
        Me.lvNotifications.Location = New System.Drawing.Point(49, 172)
        Me.lvNotifications.MultiSelect = False
        Me.lvNotifications.Name = "lvNotifications"
        Me.lvNotifications.Size = New System.Drawing.Size(604, 305)
        Me.lvNotifications.TabIndex = 5
        Me.lvNotifications.UseCompatibleStateImageBehavior = False
        Me.lvNotifications.View = System.Windows.Forms.View.Details
        '
        'clmDate
        '
        Me.clmDate.Text = "Date"
        Me.clmDate.Width = 100
        '
        'clmMessage
        '
        Me.clmMessage.Text = "Message"
        Me.clmMessage.Width = 400
        '
        'clmSender
        '
        Me.clmSender.Text = "Sender"
        Me.clmSender.Width = 100
        '
        'Username
        '
        Me.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FullName
        '
        Me.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FullName.HeaderText = "Full Name"
        Me.FullName.Name = "FullName"
        Me.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ContactInfo
        '
        Me.ContactInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ContactInfo.HeaderText = "Contact Info"
        Me.ContactInfo.Name = "ContactInfo"
        Me.ContactInfo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Role
        '
        Me.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Role.HeaderText = "Role"
        Me.Role.Name = "Role"
        Me.Role.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'AddPassword
        '
        Me.AddPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AddPassword.HeaderText = "Password"
        Me.AddPassword.Name = "AddPassword"
        '
        'btnEdit
        '
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.btnEdit.HeaderText = ""
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseColumnTextForButtonValue = True
        '
        'btnDelete
        '
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.btnDelete.HeaderText = ""
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseColumnTextForButtonValue = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Homepage)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.Notifications)
        Me.Controls.Add(Me.Statistics)
        Me.Controls.Add(Me.AboutPanel)
        Me.Controls.Add(Me.Navigation)
        Me.Controls.Add(Me.Header)
        Me.Name = "MainForm"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Header.ResumeLayout(False)
        CType(Me.picLMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picESTI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AboutPanel.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Navigation.ResumeLayout(False)
        Me.Navigation.PerformLayout()
        Me.Homepage.ResumeLayout(False)
        Me.Dashboard.ResumeLayout(False)
        Me.Settings.ResumeLayout(False)
        Me.SettingsLayout.ResumeLayout(False)
        Me.pnlProfile.ResumeLayout(False)
        Me.AdminManagement.ResumeLayout(False)
        Me.AdminMngmtLayout.ResumeLayout(False)
        CType(Me.dgvAdmins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Notifications.ResumeLayout(False)
        Me.Statistics.ResumeLayout(False)
        Me.StatsGeneral.ResumeLayout(False)
        Me.DashboardOutline.ResumeLayout(False)
        Me.DashboardOutline.PerformLayout()
        Me.BookStats.ResumeLayout(False)
        CType(Me.chartStatistics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogEntryStats.ResumeLayout(False)
        Me.LogEntryStats.PerformLayout()
        Me.ChangePW.ResumeLayout(False)
        Me.ChangePW.PerformLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfileMngmt.ResumeLayout(False)
        Me.ProfileMngmt.PerformLayout()
        Me.AddAdmin.ResumeLayout(False)
        Me.AddAdmin.PerformLayout()
        Me.pnlNotifications.ResumeLayout(False)
        Me.pnlNotifications.PerformLayout()
        Me.grpFiltersNotif.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManageQuickAccess.ResumeLayout(False)
        Me.QuickAccess.ResumeLayout(False)
        Me.QuickAccessOutline.ResumeLayout(False)
        Me.QuickAccessOutline.PerformLayout()
        Me.OutlineRoundPanel3.ResumeLayout(False)
        Me.OutlineRoundPanel3.PerformLayout()
        Me.Manage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picLMS As PictureBox
    Friend WithEvents picESTI As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents AboutPanel As TableLayoutPanel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Navigation As Panel
    Friend WithEvents btnHome As RoundedButton
    Friend WithEvents Homepage As TableLayoutPanel
    Friend WithEvents btnLogout As RoundedButton
    Friend WithEvents Dashboard As Panel
    Friend WithEvents btnSettings As RoundedButton
    Friend WithEvents btnNotif As RoundedButton
    Friend WithEvents btnStatistics As RoundedButton
    Friend WithEvents picProfile As RoundPictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DashboardOutline As OutlineRoundPanel
    Friend WithEvents lblRecentLogs As Label
    Friend WithEvents displayRecentLogs As RoundedPanel
    Friend WithEvents lblOverdue As Label
    Friend WithEvents lblReturned As Label
    Friend WithEvents displayOverdue As RoundedPanel
    Friend WithEvents displayReturned As RoundedPanel
    Friend WithEvents displayBorrowed As RoundedPanel
    Friend WithEvents lblBorrowed As Label
    Friend WithEvents lblTotalBooks As Label
    Friend WithEvents displayTotalBooks As RoundedPanel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Settings As Panel
    Friend WithEvents SettingsLayout As TableLayoutPanel
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents ProfileMngmt As OutlineRoundPanel
    Friend WithEvents btnSaveProfile As RoundedButton
    Friend WithEvents btnChoosePhoto As RoundedButton
    Friend WithEvents lblProfilePicture As Label
    Friend WithEvents txtContact As RoundedTextbox
    Friend WithEvents lblContact As Label
    Friend WithEvents txtFullname As RoundedTextbox
    Friend WithEvents lblLastname As Label
    Friend WithEvents txtUsername As RoundedTextbox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblProfileMngmt As Label
    Friend WithEvents lblImageFileName As Label
    Friend WithEvents ChangePW As OutlineRoundPanel
    Friend WithEvents txtCurrentPassword As RoundedTextbox
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents lblChangePW As Label
    Friend WithEvents txtNewPassword As RoundedTextbox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtConfirmPassword As RoundedTextbox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents btnSave As RoundedButton
    Friend WithEvents txtCode As RoundedTextbox
    Friend WithEvents btnVerify As RoundedButton
    Friend WithEvents AdminManagement As Panel
    Friend WithEvents AdminMngmtLayout As TableLayoutPanel
    Friend WithEvents dgvAdmins As DataGridView
    Friend WithEvents AddAdmin As OutlineRoundPanel
    Friend WithEvents cmbChooseRole As ComboBox
    Friend WithEvents lblAddRole As Label
    Friend WithEvents txtAddContact As RoundedTextbox
    Friend WithEvents lblAddContact As Label
    Friend WithEvents txtAddLastname As RoundedTextbox
    Friend WithEvents lblAddLastname As Label
    Friend WithEvents txtAddFirstname As RoundedTextbox
    Friend WithEvents lblAddFirstname As Label
    Friend WithEvents lblAdminMngmt As Label
    Friend WithEvents Notifications As TableLayoutPanel
    Friend WithEvents pnlNotifications As OutlineRoundPanel
    Friend WithEvents lblNotifications As Label
    Friend WithEvents grpFiltersNotif As GroupBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents ApplyFilter As RoundedButton
    Friend WithEvents btnMarkAsRead As RoundedButton
    Friend WithEvents btnDeleteNotification As RoundedButton
    Friend WithEvents Statistics As TableLayoutPanel
    Friend WithEvents StatsGeneral As TableLayoutPanel
    Friend WithEvents BookStats As OutlineRoundPanel
    Friend WithEvents chartStatistics As DataVisualization.Charting.Chart
    Friend WithEvents LogEntryStats As OutlineRoundPanel
    Friend WithEvents lblWeekly As Label
    Friend WithEvents lblAnnual As Label
    Friend WithEvents AnnualLogs As CircularProgressBar
    Friend WithEvents lblMonthly As Label
    Friend WithEvents ManageQuickAccess As TableLayoutPanel
    Friend WithEvents QuickAccess As Panel
    Friend WithEvents QuickAccessOutline As OutlineRoundPanel
    Friend WithEvents RoundedButton1 As RoundedButton
    Friend WithEvents lblQuickAccess As Label
    Friend WithEvents RoundedButton3 As RoundedButton
    Friend WithEvents RoundedButton2 As RoundedButton
    Friend WithEvents Manage As Panel
    Friend WithEvents OutlineRoundPanel3 As OutlineRoundPanel
    Friend WithEvents lblAccession As Label
    Friend WithEvents lblTransactions As Label
    Friend WithEvents lblEntryLogs As Label
    Friend WithEvents lblOPAC As Label
    Friend WithEvents btnOPAC As RoundedButton
    Friend WithEvents btnEntryLogs As RoundedButton
    Friend WithEvents btnTransactions As RoundedButton
    Friend WithEvents btnBookMngmt As RoundedButton
    Friend WithEvents lblManage As Label
    Friend WithEvents btnAddAdmin As RoundedButton
    Friend WithEvents lvNotifications As ListView
    Friend WithEvents clmDate As ColumnHeader
    Friend WithEvents clmMessage As ColumnHeader
    Friend WithEvents clmSender As ColumnHeader
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents ContactInfo As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
    Friend WithEvents AddPassword As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit As DataGridViewButtonColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
End Class
