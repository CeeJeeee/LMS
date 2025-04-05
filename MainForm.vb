Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetActiveButton(btnHome, My.Resources.actHomepage)
        Timer1.Start()
        InitializePlaceholder()
        LoadBarGraph()
    End Sub
    Private Sub InitializePlaceholder()
        txtCode.Text = "Enter Code"
        txtCode.ForeColor = Color.Gray
    End Sub



    Private Sub ShowPanel(selectedPanel As Panel)
        ' Hide all panels
        Homepage.Visible = False
        Settings.Visible = False
        Notifications.Visible = False
        Statistics.Visible = False

        ' Show the selected panel
        selectedPanel.Visible = True
        selectedPanel.BringToFront()
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowPanel(Homepage)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ShowPanel(Settings)
    End Sub

    Private Sub btnNotif_Click(sender As Object, e As EventArgs) Handles btnNotif.Click
        ShowPanel(Notifications)
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        ShowPanel(Statistics)
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm tt") ' Example: 07:12 AM
        lblDate.Text = DateTime.Now.ToString("MMMM d, yyyy") ' Example: February 13, 2025
    End Sub

    'Color.FromArgb(18, 58, 4) 'DarkGreen
    'Color.FromArgb(54, 115, 13) 'Lightgreen

    ' Reusable method to set the active button using resource images
    Private Sub SetActiveButton(activeButton As Button, activeImage As Bitmap)
        ' Reset all buttons to default
        ' Define default color and active color
        Dim defaultColor As Color = Color.FromArgb(18, 58, 4)
        Dim activeColor As Color = Color.FromArgb(54, 115, 13)

        ' Reset all buttons to default
        Dim buttons As Button() = {btnHome, btnSettings, btnNotif, btnStatistics, btnLogout}
        Dim images As Bitmap() = {My.Resources.homepageS, My.Resources.Ssettings, My.Resources.Snotif, My.Resources.StatsA, My.Resources.Slogout}

        For i As Integer = 0 To buttons.Length - 1
            buttons(i).BackColor = defaultColor
            buttons(i).ForeColor = Color.White
            buttons(i).Image = images(i)
        Next


        ' Set the active button's appearance
        activeButton.BackColor = Color.FromArgb(54, 115, 13) ' Active color
        activeButton.ForeColor = Color.White
        activeButton.Image = activeImage
        activeButton.Refresh() ' Force UI to update
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnHome.Click, btnStatistics.Click, btnLogout.Click, btnSettings.Click, btnNotif.Click
        Dim clickedButton As Button = CType(sender, Button)
        Dim activeImage As Bitmap = Nothing

        ' Determine the active image based on the button clicked
        Select Case clickedButton.Name
            Case "btnHome"
                activeImage = My.Resources.actHomepage
            Case "btnStatistics"
                activeImage = My.Resources.statsB
            Case "btnLogout"
                activeImage = My.Resources.Slogout
                Login.Show()
                Me.Close() ' Closes the application
            Case "btnSettings"
                activeImage = My.Resources.actSettings
            Case "btnNotif"
                activeImage = My.Resources.actNotif
        End Select

        ' Set the active button
        SetActiveButton(clickedButton, activeImage)
    End Sub


    Private Sub btnChoosePhoto_Click_1(sender As Object, e As EventArgs) Handles btnChoosePhoto.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Configure file dialog
        openFileDialog.Title = "Select Profile Picture"
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        ' Show file dialog and update the profile picture on selection
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Load the selected image into the profile picture box
                picProfile.Image = Image.FromFile(openFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show("Failed to load the image. Please select a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtCode_GotFocus(sender As Object, e As EventArgs) Handles txtCode.GotFocus
        If txtCode.Text = "Enter Code" Then
            txtCode.Text = ""
            txtCode.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCode_LostFocus(sender As Object, e As EventArgs) Handles txtCode.LostFocus
        If String.IsNullOrWhiteSpace(txtCode.Text) Then
            txtCode.Text = "Enter Code"
            txtCode.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get password inputs
        Dim currentPassword As String = txtCurrentPassword.Text
        Dim newPassword As String = txtNewPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        ' Placeholder: Replace with the actual stored password retrieval
        Dim storedPassword As String = "admin123" ' Example only

        ' Validate current password
        If currentPassword <> storedPassword Then
            MessageBox.Show("Incorrect current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCurrentPassword.Clear()
            txtCurrentPassword.Focus()
            Return
        End If

        ' Check if new password matches confirmation
        If newPassword <> confirmPassword Then
            MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewPassword.Clear()
            txtConfirmPassword.Clear()
            txtNewPassword.Focus()
            Return
        End If

        ' Validate password length
        If newPassword.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNewPassword.Clear()
            txtConfirmPassword.Clear()
            txtNewPassword.Focus()
            Return
        End If

        ' Save the new password (implement saving logic as needed)
        ' Example: Update stored password
        storedPassword = newPassword

        ' Confirmation message
        MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear all input fields
        txtCurrentPassword.Clear()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub

    Private Sub SetupDataGridView()
        ' Clear existing columns if any
        dgvAdmins.Columns.Clear()

        ' Add Username column
        Dim colUsername As New DataGridViewTextBoxColumn()
        colUsername.HeaderText = "Username"
        colUsername.Name = "Username"
        dgvAdmins.Columns.Add(colUsername)

        ' Add Full Name column
        Dim colFullName As New DataGridViewTextBoxColumn()
        colFullName.HeaderText = "Full Name"
        colFullName.Name = "FullName"
        dgvAdmins.Columns.Add(colFullName)

        ' Add Role column
        Dim colRole As New DataGridViewTextBoxColumn()
        colRole.HeaderText = "Role"
        colRole.Name = "Role"
        dgvAdmins.Columns.Add(colRole)

        ' Add Contact Info column
        Dim colContact As New DataGridViewTextBoxColumn()
        colContact.HeaderText = "Contact Info"
        colContact.Name = "ContactInfo"
        dgvAdmins.Columns.Add(colContact)

        ' Add Edit Button column
        Dim btnEdit As New DataGridViewButtonColumn()
        btnEdit.HeaderText = "Actions"
        btnEdit.Name = "btnEdit"
        btnEdit.Text = "Edit"
        btnEdit.UseColumnTextForButtonValue = True
        dgvAdmins.Columns.Add(btnEdit)

        ' Add Delete Button column
        Dim btnDelete As New DataGridViewButtonColumn()
        btnDelete.HeaderText = "Actions"
        btnDelete.Name = "btnDelete"
        btnDelete.Text = "Delete"
        btnDelete.UseColumnTextForButtonValue = True
       dgvAdmins.Columns.Add(btnDelete)
    End Sub

    Private Sub LoadBarGraph()
        ' Clear any existing data
        chartStatistics.Series.Clear()

        ' Create a new series for statistics
        Dim series As New DataVisualization.Charting.Series("Library Statistics")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Bar
        series.Color = Color.FromArgb(54, 115, 13) ' Dark Green
        series.IsValueShownAsLabel = True ' Show values on bars

        ' Add data points (replace these with actual database values)
        series.Points.AddXY("Total Books", GetTotalBooks())
        series.Points.AddXY("Books Borrowed", GetBorrowedBooks())
        series.Points.AddXY("Books Returned", GetReturnedBooks())
        series.Points.AddXY("Overdue Books", GetOverdueBooks())

        ' Add the series to the chart
        chartStatistics.Series.Add(series)
    End Sub
    Private Function GetTotalBooks() As Integer
        ' Query to get the total number of books from the database
        Return 1200 ' Example value
    End Function

    Private Function GetBorrowedBooks() As Integer
        ' Query to get the total number of borrowed books
        Return 350 ' Example value
    End Function

    Private Function GetReturnedBooks() As Integer
        ' Query to get the total number of returned books
        Return 250 ' Example value
    End Function

    Private Function GetOverdueBooks() As Integer
        ' Query to get the total number of overdue books
        Return 40 ' Example value
    End Function

    Private Sub btnBookMngmt_Click(sender As Object, e As EventArgs) Handles btnBookMngmt.Click
        BookManagement.Show()
        Me.Close()
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Transactions.Show()
        Me.Close()
    End Sub

    Private Sub btnEntryLogs_Click(sender As Object, e As EventArgs) Handles btnEntryLogs.Click
        LogEntry.Show()
        Me.Close()
    End Sub

    Private Sub btnOPAC_Click(sender As Object, e As EventArgs) Handles btnOPAC.Click
        OPAC.Show()
        Me.Close()
    End Sub
End Class
