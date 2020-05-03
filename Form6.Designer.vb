<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonClearAll = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonIDMaker = New System.Windows.Forms.Button()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonClearSelectedandImagePreview = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxImagePreview = New System.Windows.Forms.PictureBox()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.Buttondelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonClearAll)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ButtonIDMaker)
        Me.GroupBox1.Controls.Add(Me.TextBoxAmount)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrice)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input and Update Data"
        '
        'ButtonClearAll
        '
        Me.ButtonClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearAll.ForeColor = System.Drawing.Color.Black
        Me.ButtonClearAll.Location = New System.Drawing.Point(527, 201)
        Me.ButtonClearAll.Name = "ButtonClearAll"
        Me.ButtonClearAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearAll.TabIndex = 12
        Me.ButtonClearAll.Text = "Clear All"
        Me.ButtonClearAll.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.ForeColor = System.Drawing.Color.Black
        Me.ButtonSave.Location = New System.Drawing.Point(23, 201)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonIDMaker
        '
        Me.ButtonIDMaker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonIDMaker.ForeColor = System.Drawing.Color.Black
        Me.ButtonIDMaker.Location = New System.Drawing.Point(563, 57)
        Me.ButtonIDMaker.Name = "ButtonIDMaker"
        Me.ButtonIDMaker.Size = New System.Drawing.Size(81, 20)
        Me.ButtonIDMaker.TabIndex = 10
        Me.ButtonIDMaker.Text = "ID Maker"
        Me.ButtonIDMaker.UseVisualStyleBackColor = True
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAmount.Location = New System.Drawing.Point(113, 110)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(489, 20)
        Me.TextBoxAmount.TabIndex = 9
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrice.Location = New System.Drawing.Point(113, 84)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(489, 20)
        Me.TextBoxPrice.TabIndex = 8
        '
        'TextBoxID
        '
        Me.TextBoxID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxID.Location = New System.Drawing.Point(113, 58)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.ReadOnly = True
        Me.TextBoxID.Size = New System.Drawing.Size(444, 20)
        Me.TextBoxID.TabIndex = 7
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.Location = New System.Drawing.Point(113, 35)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(489, 20)
        Me.TextBoxName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Price($)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(608, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Image"
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImageInput.Image = Global.VapeShop.My.Resources.Resources.about_icon_
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(650, 32)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(191, 192)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImageInput.TabIndex = 0
        Me.PictureBoxImageInput.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ButtonClearSelectedandImagePreview)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.PictureBoxImagePreview)
        Me.GroupBox2.Controls.Add(Me.CheckBoxByID)
        Me.GroupBox2.Controls.Add(Me.CheckBoxByName)
        Me.GroupBox2.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox2.Controls.Add(Me.Buttondelete)
        Me.GroupBox2.Controls.Add(Me.ButtonEdit)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 266)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(864, 320)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record View"
        '
        'ButtonClearSelectedandImagePreview
        '
        Me.ButtonClearSelectedandImagePreview.ForeColor = System.Drawing.Color.Black
        Me.ButtonClearSelectedandImagePreview.Location = New System.Drawing.Point(650, 264)
        Me.ButtonClearSelectedandImagePreview.Name = "ButtonClearSelectedandImagePreview"
        Me.ButtonClearSelectedandImagePreview.Size = New System.Drawing.Size(191, 23)
        Me.ButtonClearSelectedandImagePreview.TabIndex = 10
        Me.ButtonClearSelectedandImagePreview.Text = "Clear Selected and Image Preview"
        Me.ButtonClearSelectedandImagePreview.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(596, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 26)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Image " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Preview:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(560, 192)
        Me.DataGridView1.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.EditToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(121, 70)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select all"
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(650, 66)
        Me.PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        Me.PictureBoxImagePreview.Size = New System.Drawing.Size(191, 192)
        Me.PictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImagePreview.TabIndex = 7
        Me.PictureBoxImagePreview.TabStop = False
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Location = New System.Drawing.Point(376, 39)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxByID.TabIndex = 6
        Me.CheckBoxByID.Text = "Search by ID"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Checked = True
        Me.CheckBoxByName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxByName.Location = New System.Drawing.Point(249, 39)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(105, 17)
        Me.CheckBoxByName.TabIndex = 5
        Me.CheckBoxByName.Text = "Search by Name"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Location = New System.Drawing.Point(325, 13)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(516, 20)
        Me.TextBoxSearch.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Search Here:"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.Black
        Me.ButtonRefresh.Location = New System.Drawing.Point(168, 19)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 2
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'Buttondelete
        '
        Me.Buttondelete.ForeColor = System.Drawing.Color.Black
        Me.Buttondelete.Location = New System.Drawing.Point(87, 19)
        Me.Buttondelete.Name = "Buttondelete"
        Me.Buttondelete.Size = New System.Drawing.Size(75, 23)
        Me.Buttondelete.TabIndex = 1
        Me.Buttondelete.Text = "Delete"
        Me.Buttondelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.ForeColor = System.Drawing.Color.Black
        Me.ButtonEdit.Location = New System.Drawing.Point(6, 19)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 0
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(888, 589)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonClearAll As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonIDMaker As System.Windows.Forms.Button
    Friend WithEvents TextBoxAmount As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxImageInput As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonClearSelectedandImagePreview As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBoxImagePreview As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBoxByID As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxByName As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents Buttondelete As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
