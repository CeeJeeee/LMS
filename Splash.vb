Public Class LoadScreen
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Timer1.Start()
        LoadStatus.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment the progress bar value
        LoadStatus.Increment(2)

        ' Check if progress is complete
        If LoadStatus.Value >= LoadStatus.Maximum Then
            Timer1.Stop()
            ' Open the main form and close the splash screen
            Dim mainForm As New MainForm()
            Login.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub LoadStatus_Click(sender As Object, e As EventArgs) Handles LoadStatus.Click

    End Sub
End Class