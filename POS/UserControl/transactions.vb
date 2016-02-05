Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.IO
Imports System.Data.OleDb
Public Class pnlPayment
    Dim rec As Integer
    Dim data As New Dictionary(Of String, Object)
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As New SqlDataAdapter
    Dim DT As New DataTable
    Dim parameters As New Dictionary(Of String, Object)
    Dim cmd As SqlCommand
    Dim sql As String = ""
    Dim index As String = ""
    Dim valuePName As String = ""
    Dim search As String = ""
    Dim valuePrice As String = ""
    Dim valuePCode As String = ""
    Dim valueStock As String = ""
    Dim stockHolder As String = ""
    Dim stockCheck As Integer
    Dim sum As Integer
    Dim count As Integer
    Dim exists As Boolean
    Dim updateStatement As String
    Dim insertStatement As String
    Dim itm As ListViewItem
    Dim transactionDate As Date
    Dim transactionID As String
    Dim total, total_Amount As Double

    Public Sub AddTotal()
        sum = 0
        count = 0
        'For index As Integer = 0 To dgvSummary.RowCount - 1
        '    sum += Convert.ToInt32(dgvSummary.Rows(index).Cells(4).Value)
        '    count += Convert.ToInt32(dgvSummary.Rows(index).Cells(3).Value)
        'Next

        'lblAmtFig.Text = sum.ToString()
        'lblItemFig.Text = count.ToString()

    End Sub

    Public Sub GetProducts()
        search = txtSearch.Text
        sql = "Select product_code, product_name,selling_price,quantity,U.description as unit,C.description as category,critical_level from Items as I LEFT JOIN Categories as C on I.category_id=c.category_id LEFT JOIN Units as U on I.unit_id=U.unit_id " & _
            "WHERE product_code LIKE '%" & search.ToString() & "%' or product_name LIKE '%" & search.ToString() & "%'"
        DS = New DataSet
        DA = New SqlClient.SqlDataAdapter(sql, My.Settings.DBconn)
        DA.Fill(DS, 0)
        If Not DS.Tables.Count = 0 Then
            dgvProducts.DataSource = DS.Tables(0)
        End If
        dgvProducts.AutoSize = True
        redesignColumnHeaders()

    End Sub
    Public Sub redesignColumnHeaders()

        'dgvProducts.Font = Login.btnLogin.Font

        For Each x As DataGridViewColumn In dgvProducts.Columns
            x.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            Select Case x.HeaderText
                Case "product_code"
                    x.HeaderText = "Product Code"
                Case "product_name"
                    x.HeaderText = "Product Name"
                Case "selling_price"
                    x.HeaderText = "Price"
                Case "unit"
                    x.HeaderText = "Unit"
                Case "quantity"
                    x.HeaderText = "Quantity"
                Case "category"
                    x.HeaderText = "Category"
                Case "critical_level"
                    x.HeaderText = "Critical Level"

            End Select

        Next
    End Sub
    Private Sub ClearGridFocus()
        dgvProducts.ClearSelection()
        dgvProducts.CurrentCell = Nothing
    End Sub
    Private Sub transactions_Load(sender As Object, e As EventArgs) Handles Me.Load
        'GetProducts()
        'redesignColumnHeaders()
        btnNew.Enabled = True
        loadProducts()
        showlock(False)
    End Sub
    
    Private Function FindItem(ByVal LV As ListView, ByVal TextToFind As String) As Integer

        ' Loop through LV’s ListViewItems.
        For i As Integer = 0 To LV.Items.Count - 1
            If Trim(LV.Items(i).Text) = Trim(TextToFind) Then
                ' If found, return the row number
                Return (i)
            End If
            For subitem As Integer = 0 To LV.Items(i).SubItems.Count - 1
                If Trim(LV.Items(i).SubItems(subitem).Text) = Trim(TextToFind) Then
                    ' If found, return the row number
                    Return (i)
                End If
            Next
        Next
        ' If not found, then return -1.
        Return -1
    End Function
    Private Sub getme()
        Dim checkInt As Integer = FindItem(lvProducts, txtSearch.Text)
        If checkInt <> -1 Then
            lvProducts.Items(checkInt).Selected = True
            lvProducts.Focus()
            lvProducts.SelectedItems(0).EnsureVisible()
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            'searchProducts()
            For i = 0 To lvProducts.Items.Count - 1
                If lvProducts.Items.Count = 1 Then
                    'lvProducts.Items(0).Selected = True
                    If lvw_summary.Enabled = True Then
                        lvProducts.Items(0).Focused = True
                        AddItemToList()
                        txtTotal.Text = FormatNumber(total_Amount)
                        txtSearch.Text = ""
                        txtQTY.Text = ""
                        vwQty.Text = 1
                    Else
                        MessageBox.Show("Create New Transaction.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    End If
                Else
                    txtSearch.Focus()
                End If
            Next i
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchProducts()
    End Sub
    Private Sub searchProducts()
        Dim parameters As New Dictionary(Of String, Object)
        lvProducts.Items.Clear()
        Dim Item As ListViewItem
        Try
            dr = db.ExecuteReader("Select item_id,product_code, product_name,selling_price,quantity,U.description as Unit,C.description as Category, " & _
                                  "critical_level from Items as I LEFT JOIN Categories as C on I.category_id=c.category_id " & _
                                  "LEFT JOIN Units as U on I.unit_id=U.unit_id WHERE product_code LIKE '%" & txtSearch.Text & "%' OR " & _
                                  " product_name LIKE '%" & txtSearch.Text & "%'")
            If dr.HasRows Then
                Do While dr.Read
                    Item = Me.lvProducts.Items.Add(dr.Item("item_id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("product_code"))
                        .SubItems.Add(dr.Item("product_name"))
                        .SubItems.Add(dr.Item("selling_price"))
                        .SubItems.Add(dr.Item("quantity"))
                        .SubItems.Add(dr.Item("Unit"))
                        .SubItems.Add(dr.Item("Category"))
                        .SubItems.Add(dr.Item("critical_level"))
                    End With
                    'Item.Selected = True
                    'Item.EnsureVisible()
                    'lvProducts.Items(0).Selected = True
                Loop

                'Else
                'MsgBox("No results found", vbExclamation + vbOKOnly, "No product.")
            End If

        Catch ex As Exception
            MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub loadProducts()
        Dim parameters As New Dictionary(Of String, Object)
        lvProducts.Items.Clear()
        Dim Item As ListViewItem
        Try
            dr = db.ExecuteReader("Select item_id,product_code, product_name,selling_price,quantity,U.description as Unit,C.description as Category,critical_level from Items as I LEFT JOIN Categories as C on I.category_id=c.category_id LEFT JOIN Units as U on I.unit_id=U.unit_id ", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    Item = Me.lvProducts.Items.Add(dr.Item("item_id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("product_code"))
                        .SubItems.Add(dr.Item("product_name"))
                        .SubItems.Add(dr.Item("selling_price"))
                        .SubItems.Add(dr.Item("quantity"))
                        .SubItems.Add(dr.Item("Unit"))
                        .SubItems.Add(dr.Item("Category"))
                        .SubItems.Add(dr.Item("critical_level"))
                    End With
                Loop
            Else
                MsgBox("No record of products", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No users")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        getme()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtTotal.Text = "00" Then
            MsgBox("Order item first.")
        ElseIf lvw_summary.Enabled = False Then
            MsgBox("Transaction done. Create New.")
        Else
            txtCash.Text = ""
            pnlCash.BringToFront()
            showPayment(True)
            txtCash.Focus()
        End If
        
    End Sub

    Private Sub showPayment(mode As Boolean)
        pnlCash.Visible = mode
        Panel1.Enabled = Not mode
        Panel6.Enabled = Not mode

        'pnlPayment.Enabled = Not mode
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        showPayment(False)
        txtCash.Text = ""
    End Sub
    Private Sub newTransact()
        showlock(True)
        txtSearch.Text = ""
        txtSearch.Focus()
        txtTotal.Text = "00"
        txtTCash.Text = "00"
        txtChange.Text = "00"
        txtVat.Text = "00"
        lvw_summary.Enabled = True
        removeItem.Enabled = True
        lvw_summary.Items.Clear()
        lvProducts.SelectedItems.Clear()
        row = 0
        total_Amount = 0
    End Sub

    Private Sub btnNew_KeyPress(KeyAscii As Integer)
        'ESC
        'If KeyAscii = 27 Then
        '    newTransact()
        'End If

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        newTransact()
    End Sub
    Private Sub showlock(mode As Boolean)
        txtSearch.Enabled = mode
        lvProducts.Enabled = mode
        btnEnter.Enabled = mode
        'btnPrint.Enabled = mode
        'btnLock.Enabled = mode
        'btnAdmin.Enabled = mode
        btnQty.Enabled = mode
        lvw_summary.Enabled = mode
        removeItem.Enabled = mode
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmLock.txtPassword.Focus()
        frmLock.ShowDialog()
        
        'showUSC(uscMainMenu)
        'Application.Exit()
    End Sub

    Private Sub addQty()

    End Sub
    Private Shared row As Integer
    Private Sub AddItemToList()
        Dim qty As Integer
        Dim price As Double
        lvw_summary.Items.Add(lvProducts.FocusedItem.Text) 'Item Code  
        With (lvProducts.FocusedItem)
            price = lvProducts.FocusedItem.SubItems(3).Text
            If txtQTY.Text = "" Then
                qty = 1
            Else
                qty = CDbl(txtQTY.Text)
            End If
            total = price * qty
            'lvw_summary.Items(row).SubItems.Add(.SubItems(0))
            lvw_summary.Items(row).SubItems.Add(qty)
            lvw_summary.Items(row).SubItems.Add(.SubItems(2))
            lvw_summary.Items(row).SubItems.Add(.SubItems(3))
            lvw_summary.Items(row).SubItems.Add(total)
            total_Amount += total
        End With
        row = row + 1
    End Sub
    Private Sub lvProducts_DoubleClick(sender As Object, e As EventArgs) Handles lvProducts.DoubleClick
        'MsgBox(lvProducts.FocusedItem.Text)
        If lvw_summary.Enabled = True Then
            AddItemToList()
            txtTotal.Text = FormatNumber(total_Amount)
            txtSearch.Text = ""
            txtQTY.Text = ""
            vwQty.Text = 1
        Else
            MessageBox.Show("Create New Transaction.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
        
    End Sub

    Private Sub lvProducts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lvProducts.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If lvw_summary.Enabled = True Then
                AddItemToList()
                txtTotal.Text = FormatNumber(total_Amount)
                txtSearch.Text = ""
                txtQTY.Text = ""
                vwQty.Text = 1
            Else
                MessageBox.Show("Create New Transaction.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Else
            e.Handled = False
        End If

    End Sub

    Private Sub lvProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProducts.SelectedIndexChanged

    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        compute()
        lvw_summary.Enabled = False
        removeItem.Enabled = False
    End Sub
    Private Sub compute()

        Dim query, firstState, lastState As String
        Dim total, cash, change, vat As Double
        total = CDbl(txtTotal.Text)
        cash = CDbl(txtCash.Text)
        change = cash - total
        vat = cash - (total / 1.12)
        'MsgBox(vat)
        
        If cash >= total Then
            txtTCash.Text = FormatNumber(cash)
            txtChange.Text = FormatNumber(change)
            txtVat.Text = FormatNumber(vat)
            Try
                'data.Add("sales_id", txtCash.Text)
                Dim comName = System.Net.Dns.GetHostName
                Dim purchase_date = DateTime.Now
                Dim order_no = purchase_date.ToString("yyyyMMddhmmss") + Login.lblUid.Text
                data.Add("date_purchased", DateToStr(DateTime.Now))
                data.Add("user_id", Login.lblUid.Text)
                data.Add("terminal_id", comName)
                data.Add("order_number", order_no)
                data.Add("status", "1")
                data.Add("date_encoded", DateToStr(DateTime.Now))
                data.Add("invoice_number", "00000000")
                data.Add("payment_mode", "1")
                data.Add("total_amount", txtTotal.Text)
                data.Add("vat", FormatNumber(vat))

                'SAVING in SALES MAIN
                query = "INSERT INTO Sales_main(date_purchased,user_id,terminal_id,order_number,status,date_encoded,invoice_number,payment_mode,total_amount,vat) " & _
                                         "VALUES(@date_purchased,@user_id,@terminal_id,@order_number,@status,@date_encoded,@invoice_number,@payment_mode,@total_amount,@vat)"

                firstState = "BEGIN TRANSACTION "
                lastState = "COMMIT "
                query += " DECLARE @s_id INT " & vbCrLf &
                " SET @s_id = SCOPE_IDENTITY()" & vbCrLf

                ' data.Clear()
                'SAVING in SALES DETAILS
                For i = 0 To lvw_summary.Items.Count - 1
                    lvw_summary.Items(i).Selected = True
                    Dim iID, qty, s_price, item_name, tAmount
                    iID = lvw_summary.Items(i).Text
                    qty = lvw_summary.Items(i).SubItems(1).Text
                    item_name = lvw_summary.Items(i).SubItems(2).Text
                    s_price = lvw_summary.Items(i).SubItems(3).Text
                    tAmount = lvw_summary.Items(i).SubItems(4).Text


                    'For x = 1 To lvw_summary.Items.Count Step 1
                    data.Add("item_id_" & i, lvw_summary.Items(i).SubItems(0).Text)
                    data.Add("quantity_" & i, lvw_summary.Items(i).SubItems(1).Text)
                    data.Add("selling_price_" & i, lvw_summary.Items(i).SubItems(3).Text)
                    data.Add("amount_per_item_" & i, lvw_summary.Items(i).SubItems(4).Text)
                    'data.Add("vat_" & i, vat)

                    query += "INSERT INTO Sales_details (sales_id, item_id, quantity, selling_price, total_amount) " & _
                        "VALUES (@s_id , @item_id_" & i & ", @quantity_" & i & ", @selling_price_" & i & ", @amount_per_item_" & i & ")" & vbCrLf ' number na ito!

                    ' Next
                    'rec = db.ExecuteNonQuery(firstState & vbCrLf & query & vbCrLf & lastState, data)
                    'data.Clear()
                Next i

                rec = db.ExecuteNonQuery(firstState & vbCrLf & query & vbCrLf & lastState, data)
                data.Clear()


                If Not rec < 1 Then
                    showPayment(False)
                    MessageBox.Show("Transaction successful!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    data.Clear()
                    txtSearch.Focus()

                Else
                    MsgBox("Transaction Failed!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose()
            End Try

        Else
            MsgBox("Cash not enough.")
        End If
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs)
        frmLock.ShowDialog()
        btnBACK.Show()
    End Sub

    Private Sub btnQty_Click(sender As Object, e As EventArgs) Handles btnQty.Click
        txtQTY.Text = ""
        pnlQty.BringToFront()
        showQty(True)
        txtQTY.Focus()
    End Sub
    Private Sub showQty(mode As Boolean)
        pnlQty.Visible = mode
        Panel1.Enabled = Not mode
        Panel6.Enabled = Not mode
    End Sub

    Private Sub txtQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQTY.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
                e.Handled = True
                If Asc(e.KeyChar) = 13 Then
                    If txtQTY.Text = "" Then
                        vwQty.Text = "1"
                    Else
                        vwQty.Text = txtQTY.Text
                    End If
                    showQty(False)
                    txtSearch.Focus()
                Else
                    e.Handled = False
                End If
            End If
        End If
    End Sub

    Private Sub txtQTY_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQTY.KeyDown

    End Sub
    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            compute()
            lvw_summary.Enabled = False
            removeItem.Enabled = False
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub txtCash_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCash.MaskInputRejected

    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If lvw_summary.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to be removed.", vbExclamation + vbOKOnly, "Select")
            Exit Sub
        End If
        Select Case MsgBox("Remove this item?" & vbCrLf & "- " & lvw_summary.FocusedItem.SubItems(2).Text _
                           , vbInformation + vbYesNo, "Are you sure?")
            Case vbYes
                lvw_summary.FocusedItem.Remove()
            Case vbNo
                Exit Sub
        End Select
        Dim totalOrderAmount As Double = 0
        For x = 1 To lvw_summary.Items.Count
            totalOrderAmount += Val(Replace(lvw_summary.Items(x - 1).SubItems(4).Text, ",", ""))
        Next
        'txtTotalOrder.Text = FormatNumber(totalOrderAmount)
    End Sub
    

    Public Sub FuncKeysModule(ByVal value As Keys)
        'Check what function key is in a pressed state, and then perform the corresponding action.
        Select Case value
            Case Keys.F1
                'Add the code for the function key F1 here.
            Case Keys.F2
                'Add the code for the function key F2 here.
            Case Keys.F3
                'Add the code for the function key F3 here.
            Case Keys.F4
                'Add the code for the function key F4 here.
            Case Keys.F5
                'Add the code for the function key F5 here.
            Case Keys.F6
                'Add the code for the function key F6 here.
            Case Keys.F7
                'Add the code for the function key F7 here.
            Case Keys.F8
                'Add the code for the function key F8 here.
            Case Keys.F9
                'Add the code for the function key F9 here.
            Case Keys.F10
                'Add the code for the function key F10 here.
            Case Keys.F11
                'Add the code for the function key F11 here.
            Case Keys.F12
                'Add the code for the key F12 here
        End Select
    End Sub

    Private Sub btnQty_KeyDown(sender As Object, e As KeyEventArgs) Handles btnQty.KeyDown
        If e.KeyValue = Keys.F10 Then
            FuncKeysModule(e.KeyValue)
            e.Handled = True
            txtQTY.Text = ""
            pnlQty.BringToFront()
            showQty(True)
            txtQTY.Focus()
        End If
    End Sub

    Private Sub removeItem_Click(sender As Object, e As EventArgs) Handles removeItem.Click
        If lvw_summary.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            Select MessageBox.Show("Are you sure you want to delete this ordered item?.", "Confirm Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                Case DialogResult.Yes
                    Dim tamount As Double
                    tamount = CDbl(lvw_summary.SelectedItems(0).SubItems(4).Text)
                    total_Amount -= tamount
                    txtTotal.Text = FormatNumber(total_Amount)
                    'MsgBox(tamount)
                    lvw_summary.FocusedItem.Remove()
                    row = row - 1
                    txtSearch.Focus()
                Case DialogResult.No
                    lvw_summary.SelectedItems.Clear()
                    txtSearch.Focus()
                    Exit Sub
            End Select

            
        Else
            MessageBox.Show("Please select an item to delete.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
    End Sub

End Class
