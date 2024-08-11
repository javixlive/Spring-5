Public Class History
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click
        lblUsername.Text = Dashboard.lblUsername.Text
    End Sub
End Class