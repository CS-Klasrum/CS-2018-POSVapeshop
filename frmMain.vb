Imports MySql.Data.MySqlClient
Public Class frmMain

    Private Sub btnCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With Form7
            .TopLevel = False
            Panel3.Controls.Add(Form7)
            .BringToFront()
            Form7.Show()

        End With
    End Sub

    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        With Form6
            .TopLevel = False
            Panel3.Controls.Add(Form6)
            .BringToFront()
            Form6.Show()
        End With
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MessageBox.Show("Are you sure?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If vbYes Then
            Form1.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        With Form5
            .TopLevel = False
            Panel3.Controls.Add(Form5)
            .BringToFront()
            Form5.Show()
        End With
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        With Form3
            .TopLevel = False
            Panel3.Controls.Add(Form3)
            .BringToFront()
            Form3.Show()

        End With
    End Sub
End Class