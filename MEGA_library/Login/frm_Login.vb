Imports System.Data.SqlClient


Public Class frm_Login
    Dim SQL As New SQLControl
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim stUsername As String
        Dim stPassword As String

        stUsername = txtUser.Text
        stPassword = txtPassword.Text


        If SQL.HasLogin(stUsername, stPassword) = True Then
            Me.Hide()
            Dashboard.Show()
            Dashboard.lblUsername.Text = stUsername

            Dashboard.DataGridView1.DataSource = SQL.LoadBooks("")


        Else
            MsgBox("login failed")
        End If


    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        MessageBox.Show("This is the Sign Up Button")


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
