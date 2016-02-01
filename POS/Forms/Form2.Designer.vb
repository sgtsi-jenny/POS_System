<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim SalesIDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ChangeLabel As System.Windows.Forms.Label
        Dim CashLabel As System.Windows.Forms.Label
        Dim VATLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SalesIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        SalesIDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ChangeLabel = New System.Windows.Forms.Label()
        CashLabel = New System.Windows.Forms.Label()
        VATLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesIDLabel
        '
        SalesIDLabel.AutoSize = True
        SalesIDLabel.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalesIDLabel.Location = New System.Drawing.Point(3, 17)
        SalesIDLabel.Name = "SalesIDLabel"
        SalesIDLabel.Size = New System.Drawing.Size(103, 24)
        SalesIDLabel.TabIndex = 5
        SalesIDLabel.Text = "Sales ID:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(386, 17)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(65, 24)
        DateLabel.TabIndex = 7
        DateLabel.Text = "Date:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(3, 17)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(163, 32)
        Label1.TabIndex = 12
        Label1.Text = "BARCODE:"
        '
        'ChangeLabel
        '
        ChangeLabel.AutoSize = True
        ChangeLabel.Font = New System.Drawing.Font("Bookman Old Style", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChangeLabel.Location = New System.Drawing.Point(11, 282)
        ChangeLabel.Name = "ChangeLabel"
        ChangeLabel.Size = New System.Drawing.Size(255, 58)
        ChangeLabel.TabIndex = 4
        ChangeLabel.Text = "CHANGE:"
        '
        'CashLabel
        '
        CashLabel.AutoSize = True
        CashLabel.Font = New System.Drawing.Font("Bookman Old Style", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CashLabel.Location = New System.Drawing.Point(11, 149)
        CashLabel.Name = "CashLabel"
        CashLabel.Size = New System.Drawing.Size(179, 58)
        CashLabel.TabIndex = 2
        CashLabel.Text = "CASH:"
        '
        'VATLabel
        '
        VATLabel.AutoSize = True
        VATLabel.Font = New System.Drawing.Font("Bookman Old Style", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VATLabel.Location = New System.Drawing.Point(11, 17)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New System.Drawing.Size(284, 58)
        VATLabel.TabIndex = 0
        VATLabel.Text = "VAT (0.12):"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Bookman Old Style", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(17, 35)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(302, 85)
        TotalLabel.TabIndex = 0
        TotalLabel.Text = "TOTAL:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(SalesIDLabel)
        Me.Panel3.Controls.Add(DateLabel)
        Me.Panel3.Controls.Add(Me.SalesIDTextBox)
        Me.Panel3.Controls.Add(Me.DateTextBox)
        Me.Panel3.Location = New System.Drawing.Point(20, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 57)
        Me.Panel3.TabIndex = 14
        '
        'SalesIDTextBox
        '
        Me.SalesIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesIDTextBox.Location = New System.Drawing.Point(131, 13)
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
        Me.DateTextBox.Location = New System.Drawing.Point(458, 13)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.ReadOnly = True
        Me.DateTextBox.Size = New System.Drawing.Size(301, 31)
        Me.DateTextBox.TabIndex = 9
        Me.DateTextBox.TabStop = False
        Me.DateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Label1)
        Me.Panel4.Controls.Add(Me.txtCode)
        Me.Panel4.Controls.Add(Me.btnAdd)
        Me.Panel4.Location = New System.Drawing.Point(825, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(443, 106)
        Me.Panel4.TabIndex = 15
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(172, 13)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(251, 40)
        Me.txtCode.TabIndex = 0
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Enabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(329, 59)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 32)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(ChangeLabel)
        Me.Panel5.Controls.Add(Me.txtChange)
        Me.Panel5.Controls.Add(CashLabel)
        Me.Panel5.Controls.Add(Me.txtCash)
        Me.Panel5.Controls.Add(VATLabel)
        Me.Panel5.Controls.Add(Me.txtVAT)
        Me.Panel5.Location = New System.Drawing.Point(825, 121)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(443, 418)
        Me.Panel5.TabIndex = 16
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Bookman Old Style", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.Blue
        Me.txtChange.Location = New System.Drawing.Point(21, 340)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(406, 64)
        Me.txtChange.TabIndex = 5
        Me.txtChange.TabStop = False
        Me.txtChange.Text = "000"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCash
        '
        Me.txtCash.Enabled = False
        Me.txtCash.Font = New System.Drawing.Font("Bookman Old Style", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.Green
        Me.txtCash.Location = New System.Drawing.Point(21, 207)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(406, 64)
        Me.txtCash.TabIndex = 1
        Me.txtCash.Text = "000"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVAT
        '
        Me.txtVAT.Font = New System.Drawing.Font("Bookman Old Style", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.ForeColor = System.Drawing.Color.Blue
        Me.txtVAT.Location = New System.Drawing.Point(21, 75)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(406, 64)
        Me.txtVAT.TabIndex = 1
        Me.txtVAT.TabStop = False
        Me.txtVAT.Text = "000"
        Me.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.btnAdmin)
        Me.Panel6.Controls.Add(Me.btnPrint)
        Me.Panel6.Controls.Add(Me.btnLock)
        Me.Panel6.Controls.Add(Me.btnExit)
        Me.Panel6.Controls.Add(Me.btnNew)
        Me.Panel6.Location = New System.Drawing.Point(825, 547)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(443, 225)
        Me.Panel6.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(215, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 51)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "E&NTER CASH (Alt+N)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.Location = New System.Drawing.Point(96, 179)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(225, 43)
        Me.btnAdmin.TabIndex = 12
        Me.btnAdmin.TabStop = False
        Me.btnAdmin.Text = "A&DMIN (Alt+D)"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(3, 11)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(437, 51)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.TabStop = False
        Me.btnPrint.Text = "P&RINT TRANSACTION (Alt+R)"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.Transparent
        Me.btnLock.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLock.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.Location = New System.Drawing.Point(215, 125)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(225, 51)
        Me.btnLock.TabIndex = 13
        Me.btnLock.TabStop = False
        Me.btnLock.Text = "LO&CK (Alt+C)"
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(3, 125)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(206, 51)
        Me.btnExit.TabIndex = 11
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "E&XIT (Alt+X)"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(3, 68)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(206, 51)
        Me.btnNew.TabIndex = 1
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "N&EW (Alt+E)"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(TotalLabel)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Location = New System.Drawing.Point(20, 627)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 146)
        Me.Panel2.TabIndex = 18
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Bookman Old Style", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(245, 34)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(512, 86)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "000"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(20, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 548)
        Me.Panel1.TabIndex = 19
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 780)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSales"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SalesIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
