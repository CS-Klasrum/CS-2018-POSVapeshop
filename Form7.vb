Imports MySql.Data.MySqlClient

Public Class Form7

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim connection As New MySqlConnection("server=localhost;userid=root;database=vapeshop")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM vapeshop.vbnet_mysql_item_table", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub
End Class