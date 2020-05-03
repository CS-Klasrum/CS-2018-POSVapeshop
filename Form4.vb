Imports MySql.Data.MySqlClient
Public Class Form4

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vapeshop")
    Dim cart As New cart()
    Public cn, b, t As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim command As New MySqlCommand("SELECT * FROM `vbnet_mysql_item_table` WHERE `ID`=@id", connection)
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = TextBox1.Text

            Dim reader As MySqlDataReader

            connection.Open()

            reader = command.ExecuteReader()

            If reader.Read() Then

                TextBox2.Text = reader(0)
                TextBox3.Text = reader(1)
                TextBox4.Text = reader(2)
                TextBox5.Text = reader(3)
            Else
                MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If

            connection.Close()


        Catch ex As Exception
            MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = cart.getcart()
        Label11.Text = Form1.TextBox1.Text
        Label10.Text = DateAndTime.Now
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick, DataGridView2.CellClick
        TextBox7.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim name As String = TextBox2.Text
        Dim price As String = TextBox4.Text

        Try

            Dim qty As String = InputBox("How many?")

            If name.Trim().Equals("") Or price.Trim().Equals("") Or qty.Trim().Equals("") Then

                MessageBox.Show("error")
            Else

                If cart.addcart(name, price, qty) Then
                    MessageBox.Show("Added succesfully")
                    DataGridView1.DataSource = cart.getcart()

                Else
                    MessageBox.Show("error")
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("error")

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vapeshop")

        Dim command As New MySqlCommand("SELECT SUM(`price` * `qty`) FROM `cart`", connection)

        connection.Open()

        TextBox6.Text = command.ExecuteScalar().ToString()


    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox7.Text.ToString().Trim().Equals("") Then

            MessageBox.Show("Invalid")
        Else
            Dim id As Integer = Convert.ToInt32(TextBox7.Text)

            If cart.removecart(id) Then

                MessageBox.Show("Remove successfully")
                DataGridView1.DataSource = cart.getcart()
                TextBox7.Text = ""
            Else
                MessageBox.Show("remove not successfull")
            End If

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        b = Label10.Text
        cn = TextBox2.Text

        t = TextBox6.Text
        Me.Hide()
        frmPrintReceipt.Show()

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MessageBox.Show("Are you sure?", "Cashier", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If vbYes Then
            Form1.Show()
            Me.Close()
        Else

        End If
    End Sub
End Class