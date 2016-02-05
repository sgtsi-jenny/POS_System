Public Class MaintenanceUnit
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
        lvUnit.Items.Clear()
        Dim Item As ListViewItem
        Try
            dr = db.ExecuteReader("Select unit_id, description from Units where is_deleted=0", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    Item = Me.lvUnit.Items.Add(dr.Item("unit_id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("description"))
                    End With
                Loop
            Else
                MsgBox("No record of units", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No unit")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub MaintenanceUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadListview()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDescription.Text = "" Then
            MessageBox.Show("Add unit description", "Fill up the Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If txtunitId.Text = "" Then
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)
            Try
                data.Add("unit_id", txtunitId.Text)
                data.Add("description", txtDescription.Text)

                rec = db.ExecuteNonQuery("INSERT INTO Units(description) " & _
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
                rec = db.ExecuteNonQuery("UPDATE Units set description=@description WHERE unit_id = " & txtunitId.Text, data)

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

    Private Sub lvUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUnit.SelectedIndexChanged

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvUnit.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            txtDescription.Enabled = True
            txtunitId.Text = lvUnit.FocusedItem.Text
            txtunitId.Text = lvUnit.SelectedItems(0).SubItems(0).Text.ToString
            txtDescription.Text = lvUnit.SelectedItems(0).SubItems(1).Text.ToString
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
