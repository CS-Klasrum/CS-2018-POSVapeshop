Imports MySql.Data.MySqlClient
Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim connection As New MySqlConnection("server=localhost;userid=root;database=vapeshop")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM vapeshop.binayad", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class