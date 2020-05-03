Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmPrintReceipt

    Dim SQLConn As MySqlConnection
    Dim command As MySqlCommand
    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mPrintBitmap As Bitmap

    Private Sub frmPrintReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLConn = New MySqlConnection
        SQLConn.ConnectionString = "server=localhost;userid=root;database=vapeshop"

        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()


        End If
        SQLConn.Open()
        ' disp_data()

        Label3.Text = My.Forms.Form4.b
        Label7.Text = My.Forms.Form4.cn
        Label8.Text = My.Forms.Form2.pdct
        Label9.Text = My.Forms.Form4.t
        Label10.Text = "We Received" & " " & Label9.Text & " "




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        command = SQLConn.CreateCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "insert into vapeshop.binayad values ('" & Label3.Text & "','" & Label7.Text & "','" & Label8.Text & "','" & Label9.Text & "')"
        command.ExecuteNonQuery()

        'disp_data()


   
        MessageBox.Show("Record Successfully Added")
        Text = "Print Receipt"

        Dim Preview As New PrintPreviewDialog
        Dim pd As New System.Drawing.Printing.PrintDocument
        pd.DefaultPageSettings.Landscape = True
        AddHandler pd.PrintPage, AddressOf OnPrintPage
        Preview.Document = pd
        Preview.ShowDialog()
    End Sub

    Public Sub OnPrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Using bmp As Bitmap = New Bitmap(Me.Width, Me.Height)

            Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
            Dim ratio As Single = CSng(bmp.Width / bmp.Height)

            If ratio > e.MarginBounds.Width / e.MarginBounds.Height Then


                e.Graphics.DrawImage(bmp,
                e.MarginBounds.Left,
                CInt(e.MarginBounds.Top + (e.MarginBounds.Height / 2) - ((e.MarginBounds.Width / ratio) / 2)),
                e.MarginBounds.Width,
                CInt(e.MarginBounds.Width / ratio))


            Else
                e.Graphics.DrawImage(bmp,
         CInt(e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (e.MarginBounds.Height * ratio / 2)),
         e.MarginBounds.Top,
         CInt(e.MarginBounds.Height * ratio),
         e.MarginBounds.Height)

            End If
        End Using


    End Sub
    Private Sub m_PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim lWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitmap.Width) \ 2
        Dim lHeight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mPrintBitmap.Height) \ 2
        e.Graphics.DrawImage(mPrintBitmap, lWidth, lHeight)

        e.HasMorePages = False
    End Sub


    Private Sub PrintDocument1_BeginPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        MsgBox("Begin Print Called")
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        MsgBox("Print page called")
    End Sub
    Private Sub PrintDocument1_EndPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        MsgBox("end Print called")
    End Sub

    Private Sub PrintDocument1_QueryPageSettings(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings
        MsgBox("Query page Print Called")
    End Sub
End Class