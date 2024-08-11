Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl
    'Connection to SQL DataBase
    Public SQLCon As New SqlConnection With {.ConnectionString =
        "Server= @InsertServerName; 
            Database = @InserDatabaseName; 
            Integrated Security = True"
    }
    Public SQLCmd As SqlCommand
    Public SQLrd As SqlDataReader
    Public SQLadapt As SqlDataAdapter
    Public dt As DataTable

    Dim i As Integer

    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function HasLogin(username, password) As Boolean
        SQLCon.Open()
        SQLCmd = New SqlCommand("sp_users", SQLCon)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
        SQLCmd.Parameters.Add("@userPassword", SqlDbType.VarChar).Value = password
        SQLrd = SQLCmd.ExecuteReader()
        If (SQLrd.Read()) Then
            SQLCon.Close()
            Return True
        Else
            SQLCon.Close()
            Return False
        End If

    End Function

    Public Function AddBook(id, title, description, author, edition, img_url) As Boolean


        SQLCon.Open()
        SQLCmd = New SqlCommand("sp_add_books", SQLCon)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Parameters.Add("@bookId", SqlDbType.UniqueIdentifier).Value = id
        SQLCmd.Parameters.Add("@bookTitle", SqlDbType.VarChar).Value = title
        SQLCmd.Parameters.Add("@bookDescription", SqlDbType.VarChar).Value = description
        SQLCmd.Parameters.Add("@bookAuthor", SqlDbType.VarChar).Value = author
        SQLCmd.Parameters.Add("@bookEdition", SqlDbType.VarChar).Value = edition
        SQLCmd.Parameters.Add("@bookImgUrl", SqlDbType.VarChar).Value = img_url
        SQLCmd.ExecuteNonQuery()
        SQLCon.Close()
        i = SQLCmd.ExecuteNonQuery

        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function LoadBooks(title)
        SQLCon.Open()
        SQLCmd = New SqlCommand("sp_viewbooks", SQLCon)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Parameters.Add("@bookTitle", SqlDbType.VarChar).Value = title
        SQLadapt = New SqlDataAdapter(SQLCmd)
        dt = New DataTable()
        SQLadapt.Fill(dt)
        SQLCon.Close()
        Return dt

    End Function

    Public Function LoadHistory(id)
        SQLCon.Open()
        SQLCmd = New SqlCommand("sp_get_History", SQLCon)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Parameters.Add("@userId", SqlDbType.UniqueIdentifier).Value = id
        SQLadapt = New SqlDataAdapter(SQLCmd)
        dt = New DataTable()
        SQLadapt.Fill(dt)
        SQLCon.Close()
        Return dt
    End Function

    Public Function LoadWishlist(id)
        SQLCon.Open()
        SQLCmd = New SqlCommand("sp_get_wishlist", SQLCon)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Parameters.Add("@userId", SqlDbType.UniqueIdentifier).Value = id
        SQLadapt = New SqlDataAdapter(SQLCmd)
        dt = New DataTable()
        SQLadapt.Fill(dt)
        SQLCon.Close()
        Return dt
    End Function

    Public Function LoadFavBooks(id)
        SQLCon.Open()
        SQLCmd = New SqlCommand("sp_get_FavBooks", SQLCon)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Parameters.Add("@userId", SqlDbType.UniqueIdentifier).Value = id
        SQLadapt = New SqlDataAdapter(SQLCmd)
        dt = New DataTable()
        SQLadapt.Fill(dt)
        SQLCon.Close()
        Return dt
    End Function

End Class
