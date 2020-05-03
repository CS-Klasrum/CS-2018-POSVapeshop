Imports MySql.Data.MySqlClient
Module Module1
    Public cn As New MySqlConnection
    Public command As New MySqlCommand
    Public dr As MySqlDataReader

    Sub connection()
        cn = New MySqlConnection("server=localhost;userid=root;database=vapeshop")
        cn.Open()
    End Sub
End Module
