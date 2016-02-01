<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.panelMain.SuspendLayout()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.Controls.Add(Me.Label1)
        Me.panelMain.Location = New System.Drawing.Point(191, 1)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(786, 664)
        Me.panelMain.TabIndex = 1
        '
        'pnl_main
        '
        Me.pnl_main.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnl_main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_main.Controls.Add(Me.Label4)
        Me.pnl_main.Controls.Add(Me.btnLogout)
        Me.pnl_main.Controls.Add(Me.btnReports)
        Me.pnl_main.Controls.Add(Me.btnUsers)
        Me.pnl_main.Controls.Add(Me.btnTransaction)
        Me.pnl_main.Controls.Add(Me.btnInventory)
        Me.pnl_main.Location = New System.Drawing.Point(-6, 1)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.Size = New System.Drawing.Size(201, 664)
        Me.pnl_main.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 54)
        Me.Label4.TabIndex = 197
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(786, 54)
        Me.Label1.TabIndex = 198
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(-6, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(985, 54)
        Me.Label2.TabIndex = 199
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLogout.Location = New System.Drawing.Point(14, 445)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(178, 85)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.Black
        Me.btnReports.Image = Global.POS.My.Resources.Resources.sales1
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnReports.Location = New System.Drawing.Point(13, 356)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(178, 85)
        Me.btnReports.TabIndex = 7
        Me.btnReports.Text = "REPORTS"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUsers.ForeColor = System.Drawing.Color.Black
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUsers.Location = New System.Drawing.Point(13, 267)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(178, 85)
        Me.btnUsers.TabIndex = 6
        Me.btnUsers.Text = "USERS"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTransaction.ForeColor = System.Drawing.Color.Black
        Me.btnTransaction.Image = CType(resources.GetObject("btnTransaction.Image"), System.Drawing.Image)
        Me.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnTransaction.Location = New System.Drawing.Point(14, 178)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(178, 85)
        Me.btnTransaction.TabIndex = 5
        Me.btnTransaction.Text = "TRANSACTIONS"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnInventory.ForeColor = System.Drawing.Color.Black
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnInventory.Location = New System.Drawing.Point(13, 90)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(178, 85)
        Me.btnInventory.TabIndex = 4
        Me.btnInventory.Text = "INVENTORY"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 668)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "MainMenu"
        Me.Text = "POS v.1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMain.ResumeLayout(False)
        Me.pnl_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents pnl_main As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
