Imports MySql.Data.MySqlClient

Public Class Form1
    Dim SQLConn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        SQLConn = New MySqlConnection
        SQLConn.ConnectionString = "server=localhost;userid=root;database=vapeshop"
        Try
            SQLConn.Open()
            Label1.Text = "Connected"
        Catch ex As Exception
            MsgBox(ex.Message)
            Label1.Text = "Not Connected"
        Finally
            SQLConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SQLConn = New MySqlConnection
        SQLConn.ConnectionString = "server=localhost;userid=root;database=vapeshop"
        Dim reader As MySqlDataReader


        Try
            SQLConn.Open()
            Dim query As String
            query = "select * from vapeshop.users where username='" & TextBox1.Text & "'and password= '" & TextBox2.Text & "'"
            command = New MySqlCommand(query, SQLConn)
            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
                If reader("role") = "Admin" Then

                    MessageBox.Show("You Login as admin")

                    frmMain.Show()
                    Me.Hide()


                ElseIf reader("role") = "Cashier" Then
                    MessageBox.Show("You Login as cashier")
                    Call Form4.Show()
                    Me.Hide()

                End If
            End While
                
            If count = 1 Then

                MessageBox.Show("Successfully login")
            ElseIf count > 1 Then
                MessageBox.Show("Username/Password is duplicate")
            Else
                MessageBox.Show("Username/Password is incorrect")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SQLConn.Dispose()
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub
End Class
