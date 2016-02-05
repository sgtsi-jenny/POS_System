Public Class Reports
    Dim ds As New DataSet
    Dim con As New SqlClient.SqlConnection
    Dim da As SqlClient.SqlDataAdapter
    Dim query As String
    Dim rptSales As New Sales_Report
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loadSales(Optional search = False)
        If search = True Then
            Dim from_date, to_date As String
            from_date = DateToStr(dtFrom.Text)
            to_date = DateToStr(dtTo.Text)

            crvSalesReport.ReportSource = Nothing
            crvSalesReport.Refresh()
            ds.Tables.Clear()
            Try
                'con.ConnectionString = My.Settings.ConnectionString
                'query = "Select client_id ,company_name, branch_name, first_name || ' ' || middle_name || ' ' || last_name as name, address, contact_number, credit_limit from tbl_clients as A left join tbl_branches as B on A.branch_id=B.branch_id left join tbl_company as C on B.company_id=C.company_id WHERE status_info=1"
                query = "SELECT sd.sales_id,date_purchased,order_number, product_name, sd.quantity,sd.selling_price,sd.total_amount FROM Sales_details as sd " & _
                    "left join Items as i on i.item_id=sd.item_id left join Sales_main as sm on sm.sales_id=sd.sales_id"

                da = New SqlClient.SqlDataAdapter(query, con)
                da.Fill(ds, "SalesReport")
                If ds.Tables.Count <> 0 Then
                    'Creating xml file
                    ds.WriteXml("XML\SalesReport.xml")
                    'MsgBox("Creating xml file done.")
                End If

                'Report for Branch
                Dim dsSales As New DataSet
                dsSales = New dsPOS
                Dim dsBranchTemp As New DataSet
                dsBranchTemp = New DataSet()
                dsBranchTemp.ReadXml("XML\SalesReport.xml")
                dsSales.Merge(dsBranchTemp.Tables(0))
                rptSales = New Sales_Report
                rptSales.SetDataSource(dsSales)
                crvSalesReport.ReportSource = rptSales
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Try
        '    ds.Tables.Clear()
        '    Dim row As DataRow = Nothing
        '    ds.Tables.Add("Items")
        '    With ds.Tables(0).Columns
        '        .Add("order_date")
        '    End With


        '    For x = 1 To lvItems.Items.Count Step 1
        '        row = ds.Tables(0).NewRow

        '        row(0) = lvItems.Items(x - 1).SubItems(1).Text
        '        row(1) = lvItems.Items(x - 1).SubItems(2).Text

        '        ds.Tables(0).Rows.Add(row)
        '    Next
        '    ds.WriteXml("XML\SalesReport.xml")
        '    Dim dsItem As New DataSet
        '    dsItem = New dsPOS
        '    Dim dsItemTemp As New DataSet
        '    dsItemTemp = New DataSet()
        '    dsItemTemp.ReadXml("XML\SalesReport.xml")
        '    dsItem.Merge(dsItemTemp.Tables(0))
        '    rptSales = New Sales_Report
        '    rptSales.SetDataSource(dsItem)
        '    crvSalesReport.ReportSource = rptSales
        '    Exit Sub
        'Catch ex As Exception
        '    MsgBox("Error occured!" & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
        'End Try
    End Sub
End Class
