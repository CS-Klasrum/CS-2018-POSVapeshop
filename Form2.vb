Imports MySql.Data.MySqlClient
Public Class Form2
    Dim SQLConn As MySqlConnection
    Dim command As MySqlCommand
    Public pdct As String
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pdct = TextBox5.Text
    End Sub

    Public Sub save()
        SQLConn = New MySqlConnection
        SQLConn.ConnectionString = "server=localhost;userid=root;database=vapeshop"
        Dim reader As MySqlDataReader

        Try
            SQLConn.Open()
            Dim query As String
            query = "insert into vapeshop.users (fullname,username,password,birthdate,role) values ('" & TextBox1.Text & "' , '" & TextBox3.Text & "', '" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox5.Text & "')"
            command = New MySqlCommand(query, SQLConn)
            reader = command.ExecuteReader
            SQLConn.Close()
            MessageBox.Show("Successfully Created Account")

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("Error saving the data")
            SQLConn.Close()

        Finally
            SQLConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MessageBox.Show("Incomplete")
            Else
                save()
            End If

        Catch ex As Exception

        End Try

        Form1.Show()
        Me.Hide()
    End Sub
End Class