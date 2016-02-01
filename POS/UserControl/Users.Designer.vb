<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtUId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbUlevel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblAddedit = New System.Windows.Forms.Label()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.lblItemCode = New System.Windows.Forms.Label()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvInventory = New System.Windows.Forms.ListView()
        Me.pnlAddEdit = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlAddEdit.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUId
        '
        Me.txtUId.BackColor = System.Drawing.Color.White
        Me.txtUId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUId.ForeColor = System.Drawing.Color.Black
        Me.txtUId.Location = New System.Drawing.Point(184, 77)
        Me.txtUId.Name = "txtUId"
        Me.txtUId.ReadOnly = True
        Me.txtUId.Size = New System.Drawing.Size(69, 29)
        Me.txtUId.TabIndex = 209
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(59, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 21)
        Me.Label9.TabIndex = 210
        Me.Label9.Text = "User ID"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Location = New System.Drawing.Point(184, 272)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(252, 29)
        Me.txtpassword.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(58, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 21)
        Me.Label8.TabIndex = 208
        Me.Label8.Text = "Password"
        '
        'cmbUlevel
        '
        Me.cmbUlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUlevel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUlevel.FormattingEnabled = True
        Me.cmbUlevel.Location = New System.Drawing.Point(184, 312)
        Me.cmbUlevel.Name = "cmbUlevel"
        Me.cmbUlevel.Size = New System.Drawing.Size(252, 29)
        Me.cmbUlevel.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(58, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 204
        Me.Label5.Text = "User Level"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(267, -2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 54)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnEnd.FlatAppearance.BorderSize = 0
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnd.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.ForeColor = System.Drawing.Color.Black
        Me.btnEnd.Location = New System.Drawing.Point(375, -2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(102, 54)
        Me.btnEnd.TabIndex = 7
        Me.btnEnd.Text = "Close"
        Me.btnEnd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblAddedit
        '
        Me.lblAddedit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblAddedit.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddedit.ForeColor = System.Drawing.Color.Black
        Me.lblAddedit.Location = New System.Drawing.Point(0, 0)
        Me.lblAddedit.Name = "lblAddedit"
        Me.lblAddedit.Size = New System.Drawing.Size(487, 54)
        Me.lblAddedit.TabIndex = 200
        Me.lblAddedit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtuname
        '
        Me.txtuname.BackColor = System.Drawing.Color.White
        Me.txtuname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.ForeColor = System.Drawing.Color.Black
        Me.txtuname.Location = New System.Drawing.Point(184, 233)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(252, 29)
        Me.txtuname.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(58, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Username"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(184, 194)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(252, 29)
        Me.txtname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(59, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Last Name"
        '
        'txtmname
        '
        Me.txtmname.BackColor = System.Drawing.Color.White
        Me.txtmname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.ForeColor = System.Drawing.Color.Black
        Me.txtmname.Location = New System.Drawing.Point(184, 155)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(252, 29)
        Me.txtmname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 21)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Middle Name"
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.Color.White
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.Black
        Me.txtfname.Location = New System.Drawing.Point(184, 116)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(252, 29)
        Me.txtfname.TabIndex = 1
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.BackColor = System.Drawing.Color.Transparent
        Me.lblItemCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCode.ForeColor = System.Drawing.Color.Black
        Me.lblItemCode.Location = New System.Drawing.Point(59, 124)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(92, 21)
        Me.lblItemCode.TabIndex = 88
        Me.lblItemCode.Text = "First Name"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "User Level"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Username"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 250
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "id"
        Me.ColumnHeader0.Width = 0
        '
        'lvInventory
        '
        Me.lvInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInventory.FullRowSelect = True
        Me.lvInventory.GridLines = True
        Me.lvInventory.Location = New System.Drawing.Point(219, 93)
        Me.lvInventory.Name = "lvInventory"
        Me.lvInventory.Size = New System.Drawing.Size(578, 321)
        Me.lvInventory.TabIndex = 81
        Me.lvInventory.UseCompatibleStateImageBehavior = False
        Me.lvInventory.View = System.Windows.Forms.View.Details
        '
        'pnlAddEdit
        '
        Me.pnlAddEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAddEdit.Controls.Add(Me.txtUId)
        Me.pnlAddEdit.Controls.Add(Me.Label9)
        Me.pnlAddEdit.Controls.Add(Me.txtpassword)
        Me.pnlAddEdit.Controls.Add(Me.Label8)
        Me.pnlAddEdit.Controls.Add(Me.cmbUlevel)
        Me.pnlAddEdit.Controls.Add(Me.Label5)
        Me.pnlAddEdit.Controls.Add(Me.btnSave)
        Me.pnlAddEdit.Controls.Add(Me.btnEnd)
        Me.pnlAddEdit.Controls.Add(Me.lblAddedit)
        Me.pnlAddEdit.Controls.Add(Me.txtuname)
        Me.pnlAddEdit.Controls.Add(Me.Label2)
        Me.pnlAddEdit.Controls.Add(Me.txtname)
        Me.pnlAddEdit.Controls.Add(Me.Label3)
        Me.pnlAddEdit.Controls.Add(Me.txtmname)
        Me.pnlAddEdit.Controls.Add(Me.Label1)
        Me.pnlAddEdit.Controls.Add(Me.txtfname)
        Me.pnlAddEdit.Controls.Add(Me.lblItemCode)
        Me.pnlAddEdit.Location = New System.Drawing.Point(267, -2)
        Me.pnlAddEdit.Name = "pnlAddEdit"
        Me.pnlAddEdit.Size = New System.Drawing.Size(489, 358)
        Me.pnlAddEdit.TabIndex = 7
        Me.pnlAddEdit.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(923, -2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 54)
        Me.btnUpdate.TabIndex = 200
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(815, -2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(102, 54)
        Me.btnAdd.TabIndex = 110
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(-8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1049, 54)
        Me.Label4.TabIndex = 199
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.Controls.Add(Me.Label10)
        Me.pnlMain.Controls.Add(Me.btnUpdate)
        Me.pnlMain.Controls.Add(Me.btnAdd)
        Me.pnlMain.Controls.Add(Me.Label4)
        Me.pnlMain.Controls.Add(Me.lvInventory)
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1040, 467)
        Me.pnlMain.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(212, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(387, 54)
        Me.Label10.TabIndex = 202
        Me.Label10.Text = "Users"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlAddEdit)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Users"
        Me.Size = New System.Drawing.Size(1040, 507)
        Me.pnlAddEdit.ResumeLayout(False)
        Me.pnlAddEdit.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbUlevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents lblAddedit As System.Windows.Forms.Label
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents lblItemCode As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvInventory As System.Windows.Forms.ListView
    Friend WithEvents pnlAddEdit As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
