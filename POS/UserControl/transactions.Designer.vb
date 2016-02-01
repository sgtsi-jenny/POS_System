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
        Dim Label4 As System.Windows.Forms.Label
        Dim SalesIDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvw_summary = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTCash = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
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
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnlCash = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtCash = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SalesIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Label4 = New System.Windows.Forms.Label()
        SalesIDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlCash.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Label4.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(3, 64)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(81, 24)
        Label4.TabIndex = 92
        Label4.Text = "Search"
        '
        'SalesIDLabel
        '
        SalesIDLabel.AutoSize = True
        SalesIDLabel.BackColor = System.Drawing.Color.Transparent
        SalesIDLabel.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalesIDLabel.Location = New System.Drawing.Point(3, 17)
        SalesIDLabel.Name = "SalesIDLabel"
        SalesIDLabel.Size = New System.Drawing.Size(103, 24)
        SalesIDLabel.TabIndex = 5
        SalesIDLabel.Text = "Sales ID:"
        '
        'DateLabel
        '
        DateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DateLabel.AutoSize = True
        DateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        DateLabel.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(249, 17)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(65, 24)
        DateLabel.TabIndex = 7
        DateLabel.Text = "Date:"
        '
        'TotalLabel
        '
        TotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Bookman Old Style", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(5, 379)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(164, 45)
        TotalLabel.TabIndex = 2
        TotalLabel.Text = "TOTAL:"
        '
        'Label3
        '
        Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Bookman Old Style", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(4, 442)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(148, 45)
        Label3.TabIndex = 32
        Label3.Text = "CASH:"
        '
        'Label5
        '
        Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Bookman Old Style", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(5, 506)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(212, 45)
        Label5.TabIndex = 34
        Label5.Text = "CHANGE:"
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
        Me.dgvProducts.Size = New System.Drawing.Size(570, 196)
        Me.dgvProducts.TabIndex = 35
        Me.dgvProducts.VirtualMode = True
        Me.dgvProducts.Visible = False
        '
        'amount
        '
        Me.amount.Text = "Amount"
        Me.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.amount.Width = 100
        '
        'qty
        '
        Me.qty.Text = "Qty"
        Me.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.qty.Width = 70
        '
        'item_name
        '
        Me.item_name.Text = "Product Name"
        Me.item_name.Width = 182
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
        Me.lvw_summary.Size = New System.Drawing.Size(493, 310)
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
        Me.price.Width = 100
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(490, 59)
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
        Me.Label1.Size = New System.Drawing.Size(1062, 54)
        Me.Label1.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtTCash)
        Me.Panel1.Controls.Add(Me.txtChange)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(TotalLabel)
        Me.Panel1.Controls.Add(Me.lvw_summary)
        Me.Panel1.Location = New System.Drawing.Point(10, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 570)
        Me.Panel1.TabIndex = 34
        '
        'txtTCash
        '
        Me.txtTCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTCash.Font = New System.Drawing.Font("Bookman Old Style", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTCash.ForeColor = System.Drawing.Color.Green
        Me.txtTCash.Location = New System.Drawing.Point(201, 439)
        Me.txtTCash.Name = "txtTCash"
        Me.txtTCash.ReadOnly = True
        Me.txtTCash.Size = New System.Drawing.Size(284, 62)
        Me.txtTCash.TabIndex = 36
        Me.txtTCash.Text = "00"
        Me.txtTCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChange
        '
        Me.txtChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChange.Font = New System.Drawing.Font("Bookman Old Style", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.Black
        Me.txtChange.Location = New System.Drawing.Point(201, 506)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(285, 55)
        Me.txtChange.TabIndex = 35
        Me.txtChange.TabStop = False
        Me.txtChange.Text = "00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Bookman Old Style", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(201, 379)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(285, 55)
        Me.txtTotal.TabIndex = 3
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(99, 59)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(301, 29)
        Me.txtSearch.TabIndex = 36
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lvProducts)
        Me.Panel6.Controls.Add(Me.btnEnter)
        Me.Panel6.Controls.Add(Me.btnAdmin)
        Me.Panel6.Controls.Add(Me.btnPrint)
        Me.Panel6.Controls.Add(Me.btnLock)
        Me.Panel6.Controls.Add(Me.btnExit)
        Me.Panel6.Controls.Add(Me.btnNew)
        Me.Panel6.Location = New System.Drawing.Point(517, 165)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(530, 466)
        Me.Panel6.TabIndex = 91
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
        Me.lvProducts.Location = New System.Drawing.Point(2, 3)
        Me.lvProducts.Name = "lvProducts"
        Me.lvProducts.Size = New System.Drawing.Size(523, 225)
        Me.lvProducts.TabIndex = 83
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
        Me.ColumnHeader5.Width = 180
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Price"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 130
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Quantity"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Unit"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Category"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Critical Level"
        Me.ColumnHeader11.Width = 0
        '
        'btnEnter
        '
        Me.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEnter.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(272, 291)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(309, 51)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "&ENTER CASH (Alt+E)"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.Location = New System.Drawing.Point(150, 402)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(225, 43)
        Me.btnAdmin.TabIndex = 12
        Me.btnAdmin.TabStop = False
        Me.btnAdmin.Text = "A&DMIN (Alt+D)"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(-52, 234)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(633, 51)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.TabStop = False
        Me.btnPrint.Text = "P&RINT TRANSACTION (Alt+R)"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnLock
        '
        Me.btnLock.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLock.BackColor = System.Drawing.Color.Transparent
        Me.btnLock.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLock.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.Location = New System.Drawing.Point(272, 348)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(309, 51)
        Me.btnLock.TabIndex = 13
        Me.btnLock.TabStop = False
        Me.btnLock.Text = "LO&CK (Alt+C)"
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(-52, 348)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(309, 51)
        Me.btnExit.TabIndex = 11
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "E&XIT (Alt+X)"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(-52, 291)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(309, 51)
        Me.btnNew.TabIndex = 1
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "&NEW (Alt+N)"
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
        Me.btnCancel.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnOk.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(23, 141)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(122, 41)
        Me.btnOk.TabIndex = 45
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Bookman Old Style", 35.0!)
        Me.txtCash.Location = New System.Drawing.Point(23, 73)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(345, 62)
        Me.txtCash.TabIndex = 42
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(-1, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(402, 54)
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
        Me.Panel3.Controls.Add(Label4)
        Me.Panel3.Controls.Add(DateLabel)
        Me.Panel3.Controls.Add(Me.SalesIDTextBox)
        Me.Panel3.Controls.Add(Me.DateTextBox)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(SalesIDLabel)
        Me.Panel3.Location = New System.Drawing.Point(517, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(530, 97)
        Me.Panel3.TabIndex = 94
        '
        'SalesIDTextBox
        '
        Me.SalesIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalesIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesIDTextBox.Location = New System.Drawing.Point(320, 13)
        Me.SalesIDTextBox.Name = "SalesIDTextBox"
        Me.SalesIDTextBox.ReadOnly = True
        Me.SalesIDTextBox.Size = New System.Drawing.Size(205, 31)
        Me.SalesIDTextBox.TabIndex = 6
        Me.SalesIDTextBox.TabStop = False
        Me.SalesIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTextBox
        '
        Me.DateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTextBox.Location = New System.Drawing.Point(101, 13)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.ReadOnly = True
        Me.DateTextBox.Size = New System.Drawing.Size(205, 31)
        Me.DateTextBox.TabIndex = 9
        Me.DateTextBox.TabStop = False
        Me.DateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.pnlCash)
        Me.Name = "pnlPayment"
        Me.Size = New System.Drawing.Size(1055, 635)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.pnlCash.ResumeLayout(False)
        Me.pnlCash.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
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
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
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
    Friend WithEvents SalesIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents txtTCash As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents price As System.Windows.Forms.ColumnHeader

End Class
