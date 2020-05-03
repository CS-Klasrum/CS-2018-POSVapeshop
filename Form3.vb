Imports MySql.Data.MySqlClient
Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim connection As New MySqlConnection("server=localhost;userid=root;database=vapeshop")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM vapeshop.users", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub
End Class