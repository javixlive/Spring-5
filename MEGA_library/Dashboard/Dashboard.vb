Public Class Dashboard

    Dim SQL As New SQLControl

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim id As Guid
        Dim title As String
        Dim description As String
        Dim author As String
        Dim edition As String
        Dim imageUrl As String

        id = New Guid(txtBoxId.Text)
        title = txtBookTitle.Text
        description = txtBookDescription.Text
        author = txtBookAuthor.Text
        edition = txtEdition.Text
        imageUrl = txtImageURL.Text

        'MessageBox.Show(SQL.AddBook(id, title, description, author, edition, imageUrl))
        If SQL.AddBook(id, title, description, author, edition, imageUrl) = True Then
            MessageBox.Show("Book Succesfully Added")
        Else
            MessageBox.Show("Something went wrong")
        End If



    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTitle As String
        searchTitle = txtSearch.Text
        SQL.LoadBooks(searchTitle)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHistory.Click

    End Sub

    Private Sub btnHistory_Click_1(sender As Object, e As EventArgs) Handles btnHistory.Click
        Me.Hide()
        History.DataGridView1.DataSource = SQL.LoadHistory("")
        History.Show()
    End Sub

    Private Sub btnWishlist_Click(sender As Object, e As EventArgs) Handles btnWishlist.Click
        Me.Hide()
        WishList.DataGridView1.DataSource = SQL.LoadWishlist("")
        WishList.Show()
    End Sub

    Private Sub btnFavorites_Click(sender As Object, e As EventArgs) Handles btnFavorites.Click
        Me.Hide()
        Favorites.DataGridView1.DataSource = SQL.LoadFavBooks("")
        Favorites.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class