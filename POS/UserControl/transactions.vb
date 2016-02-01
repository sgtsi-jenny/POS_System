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

    Private Sub AddSubjectToList()
        Dim qty As Integer
        Dim price As Double
        lvw_summary.Items.Add(lvProducts.FocusedItem.Text) 'Subject Code  

        With (lvProducts.FocusedItem)
            price = lvProducts.FocusedItem.SubItems(3).Text
            qty = 1
            total = price * qty
            lvw_summary.Items(row).SubItems.Add("1")
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
        'lvw_summary.Items.Add(lvProducts.Items(lvProducts.SelectedItem.Count).Clone())

        AddSubjectToList()
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
        Dim total, cash, change As Double
        total = CDbl(txtTotal.Text)
        cash = CDbl(txtCash.Text)
        change = cash - total
        txtTCash.Text = cash
        txtChange.Text = change
        showPayment(False)
        Try
            'data.Add("sd_id", txtCash.Text)
            data.Add("sales_id", txtCash.Text)
            data.Add("item_id", txtCash.Text)
            data.Add("quantity", txtCash.Text)
            data.Add("selling_price", txtCash.Text)
            data.Add("total_amount", txtCash.Text)


            rec = db.ExecuteNonQuery("INSERT INTO Items(product_code,product_name, unit_price,selling_price,unit_id,quantity,category_id,critical_level) " & _
                                     "VALUES(@product_code,@product_name,@unit_price,@selling_price,@unit_id,@quantity,@category_id,@critical_level)", data)

            If Not rec < 1 Then
                MessageBox.Show("Record saved!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                data.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try

        MsgBox("Transaction successful!", vbInformation + vbOKOnly, "")
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
    End Sub
    Private Sub showQty(mode As Boolean)
        pnlQty.Visible = mode
        Panel1.Enabled = Not mode
        Panel6.Enabled = Not mode
    End Sub

    Private Sub btnOkQty_Click(sender As Object, e As EventArgs) Handles btnOkQty.Click
        showQty(False)
    End Sub
End Class
