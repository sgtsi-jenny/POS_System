<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlPayment
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
        Me.components = New System.ComponentModel.Container()
        Dim Label4 As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlPayment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvw_summary = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.removeItem = New System.Windows.Forms.PictureBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTCash = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.btnQty = New System.Windows.Forms.Button()
        Me.lvProducts = New System.Windows.Forms.ListView()
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnlCash = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtCash = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.vwQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlQty = New System.Windows.Forms.Panel()
        Me.txtQTY = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Label4 = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.removeItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlCash.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlQty.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(-7, 6)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(191, 45)
        Label4.TabIndex = 92
        Label4.Text = "ITEM CODE"
        '
        'TotalLabel
        '
        TotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Segoe UI", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(-9, 458)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(283, 106)
        TotalLabel.TabIndex = 2
        TotalLabel.Text = "TOTAL:"
        '
        'Label3
        '
        Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(0, 203)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(143, 59)
        Label3.TabIndex = 32
        Label3.Text = "CASH:"
        '
        'Label5
        '
        Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(1, 267)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(204, 59)
        Label5.TabIndex = 34
        Label5.Text = "CHANGE:"
        '
        'Label9
        '
        Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(-1, 136)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(225, 59)
        Label9.TabIndex = 85
        Label9.Text = "VAT (12%):"
        '
        'amount
        '
        Me.amount.Text = "Amount"
        Me.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.amount.Width = 150
        '
        'qty
        '
        Me.qty.Text = "Qty"
        Me.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.qty.Width = 75
        '
        'item_name
        '
        Me.item_name.Text = "Product Name"
        Me.item_name.Width = 255
        '
        'lvw_summary
        '
        Me.lvw_summary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvw_summary.BackColor = System.Drawing.Color.White
        Me.lvw_summary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvw_summary.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.qty, Me.item_name, Me.price, Me.amount})
        Me.lvw_summary.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw_summary.FullRowSelect = True
        Me.lvw_summary.GridLines = True
        Me.lvw_summary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvw_summary.Location = New System.Drawing.Point(1, 63)
        Me.lvw_summary.Name = "lvw_summary"
        Me.lvw_summary.Size = New System.Drawing.Size(653, 351)
        Me.lvw_summary.TabIndex = 31
        Me.lvw_summary.UseCompatibleStateImageBehavior = False
        Me.lvw_summary.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "id"
        Me.id.Width = 0
        '
        'price
        '
        Me.price.Text = "Price"
        Me.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.price.Width = 150
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(650, 59)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Order Summary"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(-4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1050, 54)
        Me.Label1.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.removeItem)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(TotalLabel)
        Me.Panel1.Controls.Add(Me.lvw_summary)
        Me.Panel1.Location = New System.Drawing.Point(10, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 570)
        Me.Panel1.TabIndex = 34
        '
        'removeItem
        '
        Me.removeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeItem.Image = CType(resources.GetObject("removeItem.Image"), System.Drawing.Image)
        Me.removeItem.Location = New System.Drawing.Point(608, 420)
        Me.removeItem.Name = "removeItem"
        Me.removeItem.Size = New System.Drawing.Size(44, 38)
        Me.removeItem.TabIndex = 88
        Me.removeItem.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(250, 464)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(398, 89)
        Me.txtTotal.TabIndex = 3
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTCash
        '
        Me.txtTCash.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTCash.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTCash.ForeColor = System.Drawing.Color.Green
        Me.txtTCash.Location = New System.Drawing.Point(211, 203)
        Me.txtTCash.Name = "txtTCash"
        Me.txtTCash.ReadOnly = True
        Me.txtTCash.Size = New System.Drawing.Size(128, 65)
        Me.txtTCash.TabIndex = 36
        Me.txtTCash.Text = "00"
        Me.txtTCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChange
        '
        Me.txtChange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChange.BackColor = System.Drawing.SystemColors.Control
        Me.txtChange.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.Black
        Me.txtChange.Location = New System.Drawing.Point(211, 270)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(128, 65)
        Me.txtChange.TabIndex = 35
        Me.txtChange.TabStop = False
        Me.txtChange.Text = "00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(182, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(335, 50)
        Me.txtSearch.TabIndex = 36
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnExit)
        Me.Panel6.Controls.Add(Me.btnEnter)
        Me.Panel6.Controls.Add(Me.btnQty)
        Me.Panel6.Controls.Add(Me.btnNew)
        Me.Panel6.Controls.Add(Me.txtVat)
        Me.Panel6.Controls.Add(Label9)
        Me.Panel6.Controls.Add(Me.lvProducts)
        Me.Panel6.Controls.Add(Me.txtTCash)
        Me.Panel6.Controls.Add(Me.txtChange)
        Me.Panel6.Controls.Add(Label5)
        Me.Panel6.Controls.Add(Label3)
        Me.Panel6.Location = New System.Drawing.Point(675, 165)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(360, 466)
        Me.Panel6.TabIndex = 91
        '
        'txtVat
        '
        Me.txtVat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVat.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.ForeColor = System.Drawing.Color.Green
        Me.txtVat.Location = New System.Drawing.Point(210, 136)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(128, 65)
        Me.txtVat.TabIndex = 86
        Me.txtVat.Text = "00"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnQty
        '
        Me.btnQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnQty.BackColor = System.Drawing.Color.Transparent
        Me.btnQty.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQty.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQty.Location = New System.Drawing.Point(9, 402)
        Me.btnQty.Name = "btnQty"
        Me.btnQty.Size = New System.Drawing.Size(328, 59)
        Me.btnQty.TabIndex = 84
        Me.btnQty.TabStop = False
        Me.btnQty.Text = "&QTY (Alt+Q)"
        Me.btnQty.UseVisualStyleBackColor = False
        '
        'lvProducts
        '
        Me.lvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvProducts.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProducts.FullRowSelect = True
        Me.lvProducts.GridLines = True
        Me.lvProducts.HideSelection = False
        Me.lvProducts.Location = New System.Drawing.Point(3, 3)
        Me.lvProducts.Name = "lvProducts"
        Me.lvProducts.Size = New System.Drawing.Size(352, 124)
        Me.lvProducts.TabIndex = 0
        Me.lvProducts.UseCompatibleStateImageBehavior = False
        Me.lvProducts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "id"
        Me.ColumnHeader0.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Product Code"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Product Name"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Price"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 140
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Quantity"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Unit"
        Me.ColumnHeader8.Width = 110
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Category"
        Me.ColumnHeader10.Width = 110
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Critical Level"
        Me.ColumnHeader11.Width = 0
        '
        'btnEnter
        '
        Me.btnEnter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.btnEnter.Location = New System.Drawing.Point(47, 337)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(328, 59)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "&PAYMENT (Alt P)"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(49, 402)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(326, 59)
        Me.btnExit.TabIndex = 11
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "&ADMIN (Alt+A)"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(9, 337)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(328, 59)
        Me.btnNew.TabIndex = 1
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "&NEW (Alt N)"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'pnlCash
        '
        Me.pnlCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCash.Controls.Add(Me.btnCancel)
        Me.pnlCash.Controls.Add(Me.btnOk)
        Me.pnlCash.Controls.Add(Me.txtCash)
        Me.pnlCash.Controls.Add(Me.Label7)
        Me.pnlCash.Location = New System.Drawing.Point(428, 194)
        Me.pnlCash.Name = "pnlCash"
        Me.pnlCash.Size = New System.Drawing.Size(390, 194)
        Me.pnlCash.TabIndex = 93
        Me.pnlCash.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(246, 141)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 41)
        Me.btnCancel.TabIndex = 46
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(23, 141)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(122, 41)
        Me.btnOk.TabIndex = 45
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(23, 68)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(345, 70)
        Me.txtCash.TabIndex = 42
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(-3, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(389, 54)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "  Enter Cash"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.vwQty)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Label4)
        Me.Panel3.Location = New System.Drawing.Point(675, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 97)
        Me.Panel3.TabIndex = 94
        '
        'vwQty
        '
        Me.vwQty.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vwQty.ForeColor = System.Drawing.Color.Red
        Me.vwQty.Location = New System.Drawing.Point(183, 55)
        Me.vwQty.Name = "vwQty"
        Me.vwQty.ReadOnly = True
        Me.vwQty.Size = New System.Drawing.Size(96, 39)
        Me.vwQty.TabIndex = 94
        Me.vwQty.Text = "1"
        Me.vwQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 32)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Quantity:"
        '
        'pnlQty
        '
        Me.pnlQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQty.Controls.Add(Me.txtQTY)
        Me.pnlQty.Controls.Add(Me.Label6)
        Me.pnlQty.Location = New System.Drawing.Point(427, 194)
        Me.pnlQty.Name = "pnlQty"
        Me.pnlQty.Size = New System.Drawing.Size(390, 148)
        Me.pnlQty.TabIndex = 95
        Me.pnlQty.Visible = False
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(23, 66)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(345, 70)
        Me.txtQTY.TabIndex = 42
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(-1, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(390, 54)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "  Enter Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveItemToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(142, 26)
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Item"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.White
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.GridColor = System.Drawing.Color.White
        Me.dgvProducts.Location = New System.Drawing.Point(519, 165)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProducts.ShowEditingIcon = False
        Me.dgvProducts.Size = New System.Drawing.Size(558, 196)
        Me.dgvProducts.TabIndex = 35
        Me.dgvProducts.VirtualMode = True
        Me.dgvProducts.Visible = False
        '
        'pnlPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlQty)
        Me.Controls.Add(Me.pnlCash)
        Me.Controls.Add(Me.dgvProducts)
        Me.Name = "pnlPayment"
        Me.Size = New System.Drawing.Size(1043, 635)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.removeItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pnlCash.ResumeLayout(False)
        Me.pnlCash.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlQty.ResumeLayout(False)
        Me.pnlQty.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents amount As System.Windows.Forms.ColumnHeader
    Friend WithEvents qty As System.Windows.Forms.ColumnHeader
    Friend WithEvents item_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvw_summary As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lvProducts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlCash As System.Windows.Forms.Panel
    Friend WithEvents txtCash As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents txtTCash As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents price As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnQty As System.Windows.Forms.Button
    Friend WithEvents pnlQty As System.Windows.Forms.Panel
    Friend WithEvents txtQTY As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vwQty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents removeItem As System.Windows.Forms.PictureBox
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents txtVat As System.Windows.Forms.TextBox

End Class
