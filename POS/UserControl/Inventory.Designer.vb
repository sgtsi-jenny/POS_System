<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lvInventory = New System.Windows.Forms.ListView()
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlAddEdit = New System.Windows.Forms.Panel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCLevel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblAddedit = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.lblItemCode = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        Me.pnlAddEdit.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnlMain.Location = New System.Drawing.Point(0, -1)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(835, 437)
        Me.pnlMain.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(718, 0)
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
        Me.btnAdd.Location = New System.Drawing.Point(610, 0)
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
        Me.Label4.Location = New System.Drawing.Point(-8, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(844, 54)
        Me.Label4.TabIndex = 199
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lvInventory
        '
        Me.lvInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInventory.FullRowSelect = True
        Me.lvInventory.GridLines = True
        Me.lvInventory.Location = New System.Drawing.Point(21, 93)
        Me.lvInventory.Name = "lvInventory"
        Me.lvInventory.Size = New System.Drawing.Size(799, 319)
        Me.lvInventory.TabIndex = 81
        Me.lvInventory.UseCompatibleStateImageBehavior = False
        Me.lvInventory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "id"
        Me.ColumnHeader0.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Code"
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.Width = 210
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Unit Price"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Selling Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Quantity"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Category"
        Me.ColumnHeader6.Width = 140
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Critical Level"
        Me.ColumnHeader7.Width = 140
        '
        'pnlAddEdit
        '
        Me.pnlAddEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAddEdit.Controls.Add(Me.txtId)
        Me.pnlAddEdit.Controls.Add(Me.Label9)
        Me.pnlAddEdit.Controls.Add(Me.txtSellingPrice)
        Me.pnlAddEdit.Controls.Add(Me.Label8)
        Me.pnlAddEdit.Controls.Add(Me.cmbCategory)
        Me.pnlAddEdit.Controls.Add(Me.Label7)
        Me.pnlAddEdit.Controls.Add(Me.cmbUnit)
        Me.pnlAddEdit.Controls.Add(Me.Label5)
        Me.pnlAddEdit.Controls.Add(Me.txtCLevel)
        Me.pnlAddEdit.Controls.Add(Me.Label6)
        Me.pnlAddEdit.Controls.Add(Me.btnSave)
        Me.pnlAddEdit.Controls.Add(Me.btnEnd)
        Me.pnlAddEdit.Controls.Add(Me.lblAddedit)
        Me.pnlAddEdit.Controls.Add(Me.txtUnitPrice)
        Me.pnlAddEdit.Controls.Add(Me.Label2)
        Me.pnlAddEdit.Controls.Add(Me.txtQuantity)
        Me.pnlAddEdit.Controls.Add(Me.Label3)
        Me.pnlAddEdit.Controls.Add(Me.txtProductName)
        Me.pnlAddEdit.Controls.Add(Me.Label1)
        Me.pnlAddEdit.Controls.Add(Me.txtProductCode)
        Me.pnlAddEdit.Controls.Add(Me.lblItemCode)
        Me.pnlAddEdit.Location = New System.Drawing.Point(201, -3)
        Me.pnlAddEdit.Name = "pnlAddEdit"
        Me.pnlAddEdit.Size = New System.Drawing.Size(489, 436)
        Me.pnlAddEdit.TabIndex = 5
        Me.pnlAddEdit.Visible = False
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.White
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.Black
        Me.txtId.Location = New System.Drawing.Point(184, 77)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(69, 29)
        Me.txtId.TabIndex = 209
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(59, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 21)
        Me.Label9.TabIndex = 210
        Me.Label9.Text = "Item ID"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.BackColor = System.Drawing.Color.White
        Me.txtSellingPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingPrice.ForeColor = System.Drawing.Color.Black
        Me.txtSellingPrice.Location = New System.Drawing.Point(184, 272)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(252, 29)
        Me.txtSellingPrice.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(58, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 208
        Me.Label8.Text = "Seling Price"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(184, 352)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(252, 29)
        Me.cmbCategory.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(59, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Category"
        '
        'cmbUnit
        '
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(184, 312)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(252, 29)
        Me.cmbUnit.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(58, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 21)
        Me.Label5.TabIndex = 204
        Me.Label5.Text = "Unit"
        '
        'txtCLevel
        '
        Me.txtCLevel.BackColor = System.Drawing.Color.White
        Me.txtCLevel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCLevel.ForeColor = System.Drawing.Color.Black
        Me.txtCLevel.Location = New System.Drawing.Point(184, 393)
        Me.txtCLevel.Name = "txtCLevel"
        Me.txtCLevel.Size = New System.Drawing.Size(252, 29)
        Me.txtCLevel.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(58, 401)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 21)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "Critical Level"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(267, -1)
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
        Me.btnEnd.Location = New System.Drawing.Point(375, -1)
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
        Me.lblAddedit.Location = New System.Drawing.Point(0, 2)
        Me.lblAddedit.Name = "lblAddedit"
        Me.lblAddedit.Size = New System.Drawing.Size(487, 54)
        Me.lblAddedit.TabIndex = 200
        Me.lblAddedit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.Color.White
        Me.txtUnitPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.ForeColor = System.Drawing.Color.Black
        Me.txtUnitPrice.Location = New System.Drawing.Point(184, 233)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(252, 29)
        Me.txtUnitPrice.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(58, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Unit Price"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(184, 194)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(252, 29)
        Me.txtQuantity.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(59, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Quantity"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.White
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(184, 155)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(252, 29)
        Me.txtProductName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Product Name"
        '
        'txtProductCode
        '
        Me.txtProductCode.BackColor = System.Drawing.Color.White
        Me.txtProductCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.ForeColor = System.Drawing.Color.Black
        Me.txtProductCode.Location = New System.Drawing.Point(184, 116)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(252, 29)
        Me.txtProductCode.TabIndex = 1
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.BackColor = System.Drawing.Color.Transparent
        Me.lblItemCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCode.ForeColor = System.Drawing.Color.Black
        Me.lblItemCode.Location = New System.Drawing.Point(59, 124)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(113, 21)
        Me.lblItemCode.TabIndex = 88
        Me.lblItemCode.Text = "Product Code"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(18, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(387, 54)
        Me.Label10.TabIndex = 201
        Me.Label10.Text = "Inventory List"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlAddEdit)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Inventory"
        Me.Size = New System.Drawing.Size(836, 477)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlAddEdit.ResumeLayout(False)
        Me.pnlAddEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lvInventory As System.Windows.Forms.ListView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlAddEdit As System.Windows.Forms.Panel
    Friend WithEvents txtCLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents lblAddedit As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents lblItemCode As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
