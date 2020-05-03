Imports MySql.Data.MySqlClient
Public Class cart

    Dim connection As New connection()

    Function addcart(ByVal name As String, ByVal price As String, ByVal qty As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `cart`(`name`, `price`, `qty`) VALUES (@nm, @pr, @qty)", connection.getconnection())

        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@pr", MySqlDbType.Int32).Value = price
        command.Parameters.Add("@qty", MySqlDbType.VarChar).Value = qty

        connection.openconnection()

        If command.ExecuteNonQuery() > 0 Then

            connection.closeconnection()
            Return True

        Else

            connection.closeconnection()
            Return False


        End If

    End Function

    Function getcart() As DataTable

        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim selectquery As String = "SELECT * FROM `cart`"

        command.CommandText = selectquery
        command.Connection = connection.getconnection()

        adapter.SelectCommand = command
        adapter.Fill(table)

        Return table


    End Function
    Function removecart(ByVal id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `cart` WHERE `ID`=@cid", connection.getconnection())


        command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id



        connection.openconnection()

        If command.ExecuteNonQuery() > 0 Then

            connection.closeconnection()
            Return True

        Else

            connection.closeconnection()
            Return False


        End If
    End Function

End Class
