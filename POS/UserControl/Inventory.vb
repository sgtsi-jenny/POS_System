Public Class Inventory
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim rec As Integer
    Dim data As New Dictionary(Of String, Object)
    Private Sub clearItem()
        For Each Control In pnlAddEdit.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub
    Private Sub showAddEdit(mode As Boolean)
        pnlAddEdit.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub btnEnd_Click_1(sender As Object, e As EventArgs) Handles btnEnd.Click
        showAddEdit(False)
        clearItem()
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInventory()
        loadUnit()
        loadCategory()
    End Sub
    Private Sub loadInventory()
        Dim parameters As New Dictionary(Of String, Object)
        lvInventory.Items.Clear()
        Dim Item As ListViewItem
        Try
            dr = db.ExecuteReader("Select I.item_id, product_code, product_name, unit_price,selling_price,U.description as Unit,quantity,C.description as Category,critical_level from Items as I LEFT JOIN Categories as C on I.category_id=c.category_id LEFT JOIN Units as U on I.unit_id=U.unit_id ", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    Item = Me.lvInventory.Items.Add(dr.Item("item_id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("product_code"))
                        .SubItems.Add(dr.Item("product_name"))
                        .SubItems.Add(dr.Item("unit_price"))
                        .SubItems.Add(dr.Item("selling_price"))
                        .SubItems.Add(dr.Item("Unit"))
                        .SubItems.Add(dr.Item("quantity"))
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        showAddEdit(True)
        lblAddedit.Text = "Add New Item"
        cmbUnit.Text = Nothing
        cmbCategory.Text = Nothing
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        EditItemInListView()
    End Sub
    Private Function correctinputs()
        If txtProductCode.Text = "" Or txtProductName.Text = "" Or cmbUnit.Text = "" Or txtSellingPrice.Text = "" Or cmbCategory.Text = "" Or txtCLevel.Text = "" Then
            MessageBox.Show("Some fields are empty.", "Fill up the Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProductCode.Text = "" Or txtProductName.Text = "" Or cmbUnit.Text = "" Or txtSellingPrice.Text = "" Or cmbCategory.Text = "" Or txtCLevel.Text = "" Then
            MessageBox.Show("Some fields are empty.", "Fill up the Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If lblAddedit.Text = "Add New Item" Then
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)
            Try
                data.Add("item_id", txtId.Text)
                data.Add("product_code", txtProductCode.Text)
                data.Add("product_name", txtProductName.Text)
                data.Add("unit_price", txtUnitPrice.Text)
                data.Add("selling_price", txtSellingPrice.Text)
                data.Add("unit_id", cmbUnit.SelectedIndex + 1)
                'data.Add("quantity", txtQuantity.Text)
                data.Add("category_id", cmbCategory.SelectedIndex + 1)
                data.Add("critical_level", txtCLevel.Text)

                rec = db.ExecuteNonQuery("INSERT INTO Items(product_code,product_name, unit_price,selling_price,unit_id,category_id,critical_level) " & _
                                         "VALUES(@product_code,@product_name,@unit_price,@selling_price,@unit_id,@category_id,@critical_level)", data)

                If Not rec < 1 Then
                    MessageBox.Show("Record saved!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    showAddEdit(False)
                    loadInventory()
                    clearItem()
                    data.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose()
            End Try

        ElseIf lblAddedit.Text = "Update Item" Then
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)
            Try
                data.Add("item_id", txtId.Text)
                data.Add("product_code", txtProductCode.Text)
                data.Add("product_name", txtProductName.Text)
                data.Add("unit_price", txtUnitPrice.Text)
                data.Add("selling_price", txtSellingPrice.Text)
                data.Add("unit_id", cmbUnit.SelectedIndex + 1)
                'data.Add("quantity", txtQuantity.Text)
                data.Add("category_id", cmbCategory.SelectedIndex + 1)
                data.Add("critical_level", txtCLevel.Text)
                rec = db.ExecuteNonQuery("UPDATE Items set product_code=@product_code,product_name=@product_name,unit_price=@unit_price, " & _
                                         "selling_price=@selling_price,unit_id=@unit_id,category_id=@category_id,critical_level=@critical_level  WHERE item_id = " & txtId.Text, data)
                'MsgBox("Unit = " & cmbUnit.SelectedIndex + 1)
                'MsgBox("Category = " & cmbCategory.SelectedIndex + 1)
                If Not rec < 1 Then
                    MessageBox.Show("Record updated!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    lvInventory.SelectedItems.Clear()
                    showAddEdit(False)
                    loadInventory()
                    clearItem()
                    data.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose()
            End Try
        End If
            

    End Sub
    Private Sub EditItemInListView()
        pnlAddEdit.BringToFront()
        'clearItem()
        If lvInventory.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            showAddEdit(True)
            lblAddedit.Text = "Update Item"
            txtId.Text = lvInventory.FocusedItem.Text
            txtId.Text = lvInventory.SelectedItems(0).SubItems(0).Text.ToString
            txtProductCode.Text = lvInventory.SelectedItems(0).SubItems(1).Text.ToString
            txtProductName.Text = lvInventory.SelectedItems(0).SubItems(2).Text
            txtUnitPrice.Text = lvInventory.SelectedItems(0).SubItems(3).Text
            txtSellingPrice.Text = lvInventory.SelectedItems(0).SubItems(4).Text
            cmbUnit.Text = lvInventory.SelectedItems(0).SubItems(5).Text
            'txtQuantity.Text = lvInventory.SelectedItems(0).SubItems(6).Text
            cmbCategory.Text = lvInventory.SelectedItems(0).SubItems(7).Text
            txtCLevel.Text = lvInventory.SelectedItems(0).SubItems(8).Text
                
        Else
            MessageBox.Show("Please select record to update.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
    End Sub
    Private Sub loadUnit()
        Try
            Dim unit_type As New ArrayList

            dr = db.ExecuteReader("SELECT unit_id,description FROM Units")
            Do While dr.Read
                unit_type.Add(New MyCombo(dr.Item("unit_id"), dr.Item("description")))
            Loop

            With cmbUnit
                .DataSource = unit_type 'Set arraylist as data source of combobox
                .DisplayMember = "Description" 'as per class property
                .ValueMember = "ID" 'as per class property
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub loadCategory()
        Try
            Dim category_type As New ArrayList

            dr = db.ExecuteReader("SELECT category_id,description FROM Categories")
            Do While dr.Read
                category_type.Add(New MyCombo(dr.Item("category_id"), dr.Item("description")))
            Loop

            With cmbCategory
                .DataSource = category_type 'Set arraylist as data source of combobox
                .DisplayMember = "Description" 'as per class property
                .ValueMember = "ID" 'as per class property
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub cmbUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnit.SelectedIndexChanged

    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class
