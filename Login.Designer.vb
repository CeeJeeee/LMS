<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LoginTo = New System.Windows.Forms.Panel()
        Me.LoginAccess = New System.Windows.Forms.TableLayoutPanel()
        Me.LibraryAccess = New System.Windows.Forms.Panel()
        Me.LogbookPanel = New LMS.RoundedPanel()
        Me.btnLogClear = New LMS.RoundedButton()
        Me.btnLogSave = New LMS.RoundedButton()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.cmbPurpose = New System.Windows.Forms.ComboBox()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.txtLogLN = New LMS.RoundedTextbox()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.txtLogFN = New LMS.RoundedTextbox()
        Me.lblLibraryAccess = New System.Windows.Forms.Label()
        Me.AdminLogin = New System.Windows.Forms.Panel()
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginPanel = New LMS.RoundedPanel()
        Me.btnCancel = New LMS.RoundedButton()
        Me.btnLogin = New LMS.RoundedButton()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtAdminPW = New LMS.RoundedTextbox()
        Me.Troubleshoot = New System.Windows.Forms.LinkLabel()
        Me.txtAdminUN = New LMS.RoundedTextbox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblTroubleshoot = New System.Windows.Forms.Label()
        Me.LoginTo.SuspendLayout()
        Me.LoginAccess.SuspendLayout()
        Me.LibraryAccess.SuspendLayout()
        Me.LogbookPanel.SuspendLayout()
        Me.AdminLogin.SuspendLayout()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginTo
        '
        Me.LoginTo.BackColor = System.Drawing.Color.White
        Me.LoginTo.Controls.Add(Me.LoginAccess)
        Me.LoginTo.Controls.Add(Me.Header)
        Me.LoginTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginTo.Location = New System.Drawing.Point(0, 0)
        Me.LoginTo.Name = "LoginTo"
        Me.LoginTo.Size = New System.Drawing.Size(1370, 749)
        Me.LoginTo.TabIndex = 1
        '
        'LoginAccess
        '
        Me.LoginAccess.ColumnCount = 2
        Me.LoginAccess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LoginAccess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LoginAccess.Controls.Add(Me.LibraryAccess, 0, 0)
        Me.LoginAccess.Controls.Add(Me.AdminLogin, 0, 0)
        Me.LoginAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginAccess.Location = New System.Drawing.Point(0, 110)
        Me.LoginAccess.Name = "LoginAccess"
        Me.LoginAccess.RowCount = 1
        Me.LoginAccess.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LoginAccess.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LoginAccess.Size = New System.Drawing.Size(1370, 639)
        Me.LoginAccess.TabIndex = 3
        '
        'LibraryAccess
        '
        Me.LibraryAccess.Controls.Add(Me.LogbookPanel)
        Me.LibraryAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibraryAccess.Location = New System.Drawing.Point(688, 3)
        Me.LibraryAccess.Name = "LibraryAccess"
        Me.LibraryAccess.Size = New System.Drawing.Size(679, 633)
        Me.LibraryAccess.TabIndex = 15
        '
        'LogbookPanel
        '
        Me.LogbookPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LogbookPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.LogbookPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogbookPanel.Controls.Add(Me.lblFirstname)
        Me.LogbookPanel.Controls.Add(Me.lblLastname)
        Me.LogbookPanel.Controls.Add(Me.lblPurpose)
        Me.LogbookPanel.Controls.Add(Me.lblLibraryAccess)
        Me.LogbookPanel.Controls.Add(Me.btnLogClear)
        Me.LogbookPanel.Controls.Add(Me.btnLogSave)
        Me.LogbookPanel.Controls.Add(Me.cmbPurpose)
        Me.LogbookPanel.Controls.Add(Me.txtLogLN)
        Me.LogbookPanel.Controls.Add(Me.txtLogFN)
        Me.LogbookPanel.Location = New System.Drawing.Point(57, 82)
        Me.LogbookPanel.Name = "LogbookPanel"
        Me.LogbookPanel.Size = New System.Drawing.Size(556, 411)
        Me.LogbookPanel.TabIndex = 17
        '
        'btnLogClear
        '
        Me.btnLogClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnLogClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogClear.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnLogClear.Location = New System.Drawing.Point(294, 311)
        Me.btnLogClear.Name = "btnLogClear"
        Me.btnLogClear.Size = New System.Drawing.Size(116, 37)
        Me.btnLogClear.TabIndex = 13
        Me.btnLogClear.Text = "Clear"
        Me.btnLogClear.UseVisualStyleBackColor = False
        '
        'btnLogSave
        '
        Me.btnLogSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnLogSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogSave.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnLogSave.Location = New System.Drawing.Point(143, 311)
        Me.btnLogSave.Name = "btnLogSave"
        Me.btnLogSave.Size = New System.Drawing.Size(116, 37)
        Me.btnLogSave.TabIndex = 12
        Me.btnLogSave.Text = "Save"
        Me.btnLogSave.UseVisualStyleBackColor = False
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.BackColor = System.Drawing.Color.Transparent
        Me.lblPurpose.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurpose.ForeColor = System.Drawing.Color.White
        Me.lblPurpose.Location = New System.Drawing.Point(72, 254)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(81, 23)
        Me.lblPurpose.TabIndex = 11
        Me.lblPurpose.Text = "Purpose"
        '
        'cmbPurpose
        '
        Me.cmbPurpose.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurpose.FormattingEnabled = True
        Me.cmbPurpose.Items.AddRange(New Object() {"Library Visit", "Study or Reading", "Borrowing/Returning Books", "Research", "Using Computers"})
        Me.cmbPurpose.Location = New System.Drawing.Point(167, 256)
        Me.cmbPurpose.Name = "cmbPurpose"
        Me.cmbPurpose.Size = New System.Drawing.Size(192, 27)
        Me.cmbPurpose.TabIndex = 10
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.BackColor = System.Drawing.Color.Transparent
        Me.lblLastname.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.ForeColor = System.Drawing.Color.White
        Me.lblLastname.Location = New System.Drawing.Point(57, 199)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(99, 23)
        Me.lblLastname.TabIndex = 9
        Me.lblLastname.Text = "Last name"
        '
        'txtLogLN
        '
        Me.txtLogLN.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogLN.Location = New System.Drawing.Point(162, 196)
        Me.txtLogLN.Multiline = True
        Me.txtLogLN.Name = "txtLogLN"
        Me.txtLogLN.Size = New System.Drawing.Size(328, 30)
        Me.txtLogLN.TabIndex = 8
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstname.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.ForeColor = System.Drawing.Color.White
        Me.lblFirstname.Location = New System.Drawing.Point(55, 142)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(102, 23)
        Me.lblFirstname.TabIndex = 7
        Me.lblFirstname.Text = "First name"
        '
        'txtLogFN
        '
        Me.txtLogFN.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogFN.Location = New System.Drawing.Point(162, 138)
        Me.txtLogFN.Multiline = True
        Me.txtLogFN.Name = "txtLogFN"
        Me.txtLogFN.Size = New System.Drawing.Size(328, 30)
        Me.txtLogFN.TabIndex = 3
        '
        'lblLibraryAccess
        '
        Me.lblLibraryAccess.AutoSize = True
        Me.lblLibraryAccess.BackColor = System.Drawing.Color.Transparent
        Me.lblLibraryAccess.Font = New System.Drawing.Font("Bahnschrift Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibraryAccess.ForeColor = System.Drawing.Color.White
        Me.lblLibraryAccess.Location = New System.Drawing.Point(119, 31)
        Me.lblLibraryAccess.Name = "lblLibraryAccess"
        Me.lblLibraryAccess.Size = New System.Drawing.Size(316, 48)
        Me.lblLibraryAccess.TabIndex = 2
        Me.lblLibraryAccess.Text = "Library Access Record"
        '
        'AdminLogin
        '
        Me.AdminLogin.Controls.Add(Me.LoginPanel)
        Me.AdminLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminLogin.Location = New System.Drawing.Point(3, 3)
        Me.AdminLogin.Name = "AdminLogin"
        Me.AdminLogin.Size = New System.Drawing.Size(679, 633)
        Me.AdminLogin.TabIndex = 4
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
        'LoginPanel
        '
        Me.LoginPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LoginPanel.Controls.Add(Me.btnCancel)
        Me.LoginPanel.Controls.Add(Me.btnLogin)
        Me.LoginPanel.Controls.Add(Me.lblLogin)
        Me.LoginPanel.Controls.Add(Me.lblUsername)
        Me.LoginPanel.Controls.Add(Me.txtAdminPW)
        Me.LoginPanel.Controls.Add(Me.Troubleshoot)
        Me.LoginPanel.Controls.Add(Me.txtAdminUN)
        Me.LoginPanel.Controls.Add(Me.lblPassword)
        Me.LoginPanel.Controls.Add(Me.lblTroubleshoot)
        Me.LoginPanel.Location = New System.Drawing.Point(63, 82)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(556, 411)
        Me.LoginPanel.TabIndex = 14
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(285, 293)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 37)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(130, 293)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(127, 37)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Bahnschrift SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(197, 46)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(160, 58)
        Me.lblLogin.TabIndex = 1
        Me.lblLogin.Text = "LOGIN"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(65, 146)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(97, 23)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username"
        '
        'txtAdminPW
        '
        Me.txtAdminPW.BackColor = System.Drawing.Color.White
        Me.txtAdminPW.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPW.ForeColor = System.Drawing.Color.Black
        Me.txtAdminPW.Location = New System.Drawing.Point(168, 209)
        Me.txtAdminPW.Name = "txtAdminPW"
        Me.txtAdminPW.Size = New System.Drawing.Size(325, 30)
        Me.txtAdminPW.TabIndex = 4
        Me.txtAdminPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Troubleshoot
        '
        Me.Troubleshoot.AutoSize = True
        Me.Troubleshoot.BackColor = System.Drawing.Color.Transparent
        Me.Troubleshoot.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Troubleshoot.ForeColor = System.Drawing.Color.White
        Me.Troubleshoot.LinkColor = System.Drawing.Color.Yellow
        Me.Troubleshoot.Location = New System.Drawing.Point(442, 367)
        Me.Troubleshoot.Name = "Troubleshoot"
        Me.Troubleshoot.Size = New System.Drawing.Size(49, 23)
        Me.Troubleshoot.TabIndex = 9
        Me.Troubleshoot.TabStop = True
        Me.Troubleshoot.Text = "here"
        '
        'txtAdminUN
        '
        Me.txtAdminUN.BackColor = System.Drawing.Color.White
        Me.txtAdminUN.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminUN.ForeColor = System.Drawing.Color.Black
        Me.txtAdminUN.Location = New System.Drawing.Point(168, 143)
        Me.txtAdminUN.Name = "txtAdminUN"
        Me.txtAdminUN.Size = New System.Drawing.Size(325, 30)
        Me.txtAdminUN.TabIndex = 3
        Me.txtAdminUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(67, 212)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(95, 23)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password"
        '
        'lblTroubleshoot
        '
        Me.lblTroubleshoot.AutoSize = True
        Me.lblTroubleshoot.BackColor = System.Drawing.Color.Transparent
        Me.lblTroubleshoot.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroubleshoot.ForeColor = System.Drawing.Color.White
        Me.lblTroubleshoot.Location = New System.Drawing.Point(63, 367)
        Me.lblTroubleshoot.Name = "lblTroubleshoot"
        Me.lblTroubleshoot.Size = New System.Drawing.Size(384, 23)
        Me.lblTroubleshoot.TabIndex = 8
        Me.lblTroubleshoot.Text = "Have trouble logging in? Try troubleshooting"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.LoginTo)
        Me.Name = "Login"
        Me.Text = "ESTI Library Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.LoginTo.ResumeLayout(False)
        Me.LoginAccess.ResumeLayout(False)
        Me.LibraryAccess.ResumeLayout(False)
        Me.LogbookPanel.ResumeLayout(False)
        Me.LogbookPanel.PerformLayout()
        Me.AdminLogin.ResumeLayout(False)
        Me.Header.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoginTo As Panel
    Friend WithEvents Header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoginAccess As TableLayoutPanel
    Friend WithEvents AdminLogin As Panel
    Friend WithEvents LibraryAccess As Panel
    Friend WithEvents LogbookPanel As RoundedPanel
    Friend WithEvents btnLogClear As RoundedButton
    Friend WithEvents btnLogSave As RoundedButton
    Friend WithEvents lblPurpose As Label
    Friend WithEvents cmbPurpose As ComboBox
    Friend WithEvents lblLastname As Label
    Friend WithEvents txtLogLN As RoundedTextbox
    Friend WithEvents lblFirstname As Label
    Friend WithEvents txtLogFN As RoundedTextbox
    Friend WithEvents lblLibraryAccess As Label
    Friend WithEvents LoginPanel As RoundedPanel
    Friend WithEvents btnCancel As RoundedButton
    Friend WithEvents btnLogin As RoundedButton
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtAdminPW As RoundedTextbox
    Friend WithEvents Troubleshoot As LinkLabel
    Friend WithEvents txtAdminUN As RoundedTextbox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblTroubleshoot As Label
End Class
