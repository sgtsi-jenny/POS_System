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

                    lvProducts.Items(0).Selected = True
                    'lvProducts.Select()
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
        'If e.KeyCode = Keys.Enter Then
        '    e.SuppressKeyPress = True
        '    searchProducts()
        'End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'GetProducts()
        'ClearGridFocus()
        searchProducts()
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
        pnlCash.BringToFront()
        showPayment(True)
        txtCash.Focus()
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

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        lvw_summary.Items.Clear()
        showlock(True)
        txtSearch.Text = ""
        txtSearch.Focus()
        txtTotal.Text = "00"
        txtTCash.Text = "00"
        txtChange.Text = "00"
    End Sub
    Private Sub showlock(mode As Boolean)
        'Panel1.Enabled = mode
        txtSearch.Enabled = mode
        lvProducts.Enabled = mode
        btnEnter.Enabled = mode
        btnPrint.Enabled = mode
        btnLock.Enabled = mode
        btnAdmin.Enabled = mode
        btnQty.Enabled = mode
        'btnNew.Enabled = Not mode
        'btnExit.Enabled = Not mode
        'Panel6.Enabled = mode
        'Panel3.Enabled = mode
    End Sub

    Private Sub btnLock_Click(sender As System.Object, e As EventArgs) Handles btnLock.Click
        'frmLock.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        POS.Hide()
        MainMenu.Show()
        'showUSC(uscMainMenu)
        'Application.Exit()
    End Sub
    Private Shared row As Integer

    Private Sub AddItemToList()
        Dim qty As Integer
        Dim price As Double
        lvw_summary.Items.Add(lvProducts.FocusedItem.Text) 'Subject Code  

        With (lvProducts.FocusedItem)
            price = lvProducts.FocusedItem.SubItems(3).Text
            qty = 1
            total = price * qty
            'lvw_summary.Items(row).SubItems.Add(.SubItems(0))
            lvw_summary.Items(row).SubItems.Add(qty)
            lvw_summary.Items(row).SubItems.Add(.SubItems(2))
            lvw_summary.Items(row).SubItems.Add(.SubItems(3))
            lvw_summary.Items(row).SubItems.Add(total)
            total_Amount += total
            'lvw_summary.FocusedItem.Remove()
        End With
        'total += amount
        'lvw_summary.ListItems.Item(1).ListSubItems.Item(1).Text()
        row = row + 1
    End Sub
    Private Sub lvProducts_DoubleClick(sender As Object, e As EventArgs) Handles lvProducts.DoubleClick
        AddItemToList()
        txtTotal.Text = total_Amount
    End Sub


    Private Sub lvProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProducts.SelectedIndexChanged
        'Dim lvi As New ListViewItem
        'If lvProducts.SelectedItems.Count > 0 Then
        '    lvi = lvProducts.SelectedItems(0)
        '    Dim lvi2 As New ListViewItem
        '    lvi2 = CType(lvi.Clone, ListViewItem)
        '    lvw_summary.Items.Add(lvi2)
        'End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        compute()
    End Sub
    Private Sub compute()
        Dim query, firstState, lastState As String
        Dim total, cash, change As Double
        total = CDbl(txtTotal.Text)
        cash = CDbl(txtCash.Text)
        change = cash - total
        txtTCash.Text = cash
        txtChange.Text = change
        showPayment(False)

        Try
            'data.Add("sales_id", txtCash.Text)
            Dim comName = System.Net.Dns.GetHostName
            Dim purchase_date = DateTime.Now
            Dim order_no = purchase_date.ToString("yyyyMMddhmmss") + Login.lblUid.Text
            data.Add("date_purchased", DateToStr(purchase_date))
            data.Add("user_id", Login.lblUid.Text)
            data.Add("terminal_id", comName)
            data.Add("order_number", order_no)
            data.Add("status", "1")
            data.Add("date_encoded", DateToStr(DateTime.Now))
            data.Add("invoice_number", "00000000")
            data.Add("payment_mode", "1")
            data.Add("total_amount", txtTotal.Text)

            'SAVING in SALES MAIN
            query = "INSERT INTO Sales_main(date_purchased,user_id,terminal_id,order_number,status,date_encoded,invoice_number,payment_mode,total_amount) " & _
                                     "VALUES(@date_purchased,@user_id,@terminal_id,@order_number,@status,@date_encoded,@invoice_number,@payment_mode,@total_amount)"


            ' data.Clear()
            'SAVING in SALES DETAILS
            For i = 0 To lvw_summary.Items.Count - 1
                lvw_summary.Items(i).Selected = True
                Dim iID, qty, s_price, item_name, tAmount

                firstState = "BEGIN TRANSACTION "
                lastState = "COMMIT "
                query += " DECLARE @s_id INT " & vbCrLf &
                " SET @s_id = SCOPE_IDENTITY()" & vbCrLf

                '
                iID = lvw_summary.Items(i).Text
                qty = lvw_summary.Items(i).SubItems(1).Text
                item_name = lvw_summary.Items(i).SubItems(2).Text
                s_price = lvw_summary.Items(i).SubItems(3).Text
                tAmount = lvw_summary.Items(i).SubItems(4).Text

                For x = 1 To lvw_summary.Items.Count Step 1

                    data.Add("item_id_" & x - 1, lvw_summary.Items(x - 1).SubItems(0).Text)
                    data.Add("quantity_" & x - 1, lvw_summary.Items(x - 1).SubItems(1).Text)
                    data.Add("selling_price_" & x - 1, lvw_summary.Items(x - 1).SubItems(3).Text)
                    data.Add("amount_per_item_" & x - 1, lvw_summary.Items(x - 1).SubItems(4).Text)

                    query += "INSERT INTO Sales_details (sales_id, item_id, quantity, seling_price, total_amount) " & _
                        "VALUES (@s_id , @item_id_" & x - 1 & ", @quantity_" & x - 1 & ", @selling_price_" & x - 1 & ", @amount_per_item_" & x - 1 & ")" & vbCrLf ' number na ito!

                Next

                rec = db.ExecuteNonQuery(firstState & vbCrLf & query & vbCrLf & lastState, data)
                data.Clear()
            Next i


            'For i = 0 To lvw_summary.Items.Count - 1
            '    lvw_summary.Items(i).Selected = True
            '    MsgBox(i)
            'Next i
            'Exit Sub



            If Not rec < 1 Then
                MessageBox.Show("Transaction successful!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                data.Clear()
            Else
                MsgBox("Transaction Failed!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try

        'MsgBox("Transaction successful!", vbInformation + vbOKOnly, "")
    End Sub

    Private Sub txtCash_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            compute()
        End If
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        frmLock.ShowDialog()
        MainMenu.Show()
        'showlock(False)
    End Sub

    Private Sub btnQty_Click(sender As Object, e As EventArgs) Handles btnQty.Click
        pnlQty.BringToFront()
        showQty(True)
        txtQTY.Focus()
    End Sub
    Private Sub showQty(mode As Boolean)
        pnlQty.Visible = mode
        Panel1.Enabled = Not mode
        Panel6.Enabled = Not mode
    End Sub

    Private Sub btnOkQty_Click(sender As Object, e As EventArgs) Handles btnOkQty.Click

    End Sub
    Private Sub addQty()

    End Sub

    Private Sub btnCancelQty_Click(sender As Object, e As EventArgs) Handles btnCancelQty.Click
        showQty(False)
        txtQTY.Text = ""
    End Sub

    Private Sub txtQTY_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQTY.KeyDown

    End Sub
End Class
