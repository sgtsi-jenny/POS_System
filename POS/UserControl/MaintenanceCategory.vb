Public Class MaintenanceCategory
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim rec As Integer
    Dim data As New Dictionary(Of String, Object)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtunitId.Text = ""
        txtDescription.Text = ""
        txtDescription.Enabled = True
        txtDescription.Focus()
    End Sub
    Private Sub loadListview()
        Dim parameters As New Dictionary(Of String, Object)
        lvCategory.Items.Clear()
        Dim Item As ListViewItem
        Try
            dr = db.ExecuteReader("Select category_id, description from Categories where is_deleted=0", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    Item = Me.lvCategory.Items.Add(dr.Item("unit_id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("description"))
                    End With
                Loop
            Else
                MsgBox("No record of categories", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No category")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub MaintenanceCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadListview()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDescription.Text = "" Then
            MessageBox.Show("Add category description", "Fill up the Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If txtunitId.Text = "" Then
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)
            Try
                data.Add("unit_id", txtunitId.Text)
                data.Add("description", txtDescription.Text)

                rec = db.ExecuteNonQuery("INSERT INTO Categories(description) " & _
                                         "VALUES(@description)", data)

                If Not rec < 1 Then
                    MessageBox.Show("Record saved!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    data.Clear()
                    loadListview()
                    txtDescription.Text = ""
                    txtDescription.Enabled = False
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose()
            End Try

        Else
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)
            Try
                data.Add("unit_id", txtunitId.Text)
                data.Add("description", txtDescription.Text)
                rec = db.ExecuteNonQuery("UPDATE Categories set description=@description WHERE unit_id = " & txtunitId.Text, data)

                If Not rec < 1 Then
                    MessageBox.Show("Record updated!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    data.Clear()
                    loadListview()
                    txtDescription.Text = ""
                    txtunitId.Text = ""
                    txtDescription.Enabled = False
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose()
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvCategory.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            txtDescription.Enabled = True
            txtunitId.Text = lvCategory.FocusedItem.Text
            txtunitId.Text = lvCategory.SelectedItems(0).SubItems(0).Text.ToString
            txtDescription.Text = lvCategory.SelectedItems(0).SubItems(1).Text.ToString
        Else
            MessageBox.Show("Please select record to update.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtDescription.Text = ""
        txtunitId.Text = ""
        txtDescription.Enabled = False
    End Sub
End Class
