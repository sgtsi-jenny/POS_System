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
            'Dim row As DataRow = Nothing
            Dim s_price, t_sprice, tamount, total_amount As Double
            from_date = DateToStr(dtFrom.Text)
            to_date = DateToStr(dtTo.Text)

            crvSalesReport.ReportSource = Nothing
            crvSalesReport.Refresh()
            ds.Tables.Clear()
            Try
                con.ConnectionString = My.Settings.POSConnectionString
                'query = "Select client_id ,company_name, branch_name, first_name || ' ' || middle_name || ' ' || last_name as name, address, contact_number, credit_limit from tbl_clients as A left join tbl_branches as B on A.branch_id=B.branch_id left join tbl_company as C on B.company_id=C.company_id WHERE status_info=1"
                query = "SELECT sd.sales_id,order_number,date_purchased, product_name, sd.quantity,sd.selling_price,sd.total_amount FROM Sales_details as sd " & _
                    "left join Items as i on i.item_id=sd.item_id left join Sales_main as sm on sm.sales_id=sd.sales_id where date_purchased BETWEEN " & from_date & " AND " & to_date

                da = New SqlClient.SqlDataAdapter(query, con)
                da.Fill(ds, "SalesReport")
                For Each x As DataRow In ds.Tables(0).Rows
                    s_price = x.Item("selling_price")
                    tamount = x.Item("total_amount")
                    t_sprice += s_price
                    total_amount += tamount
                Next
                With ds.Tables(0).Columns
                    .Add("total_item_amount")
                    .Add("grand_total_amount")
                    .Add("dtFrom")
                    .Add("dtTo")
                End With
                If ds.Tables.Count <> 0 Then
                    'Creating xml file  
                    Dim row1 As DataRow = Nothing
                    row1 = ds.Tables(0).NewRow
                    row1(7) = FormatNumber(t_sprice)
                    row1(8) = FormatNumber(total_amount)
                    row1(9) = uscReports.dtFrom.Value.ToString("MM/dd/yyyy")
                    row1(10) = uscReports.dtTo.Value.ToString("MM/dd/yyyy")
                    ds.Tables(0).Rows.Add(row1)
                    ds.WriteXml("XML\SalesReport.xml")
                    ' MsgBox("Creating xml file done.")
                    'Exit Sub
                End If

                'MsgBox(t_sprice)
                'MsgBox(total_amount)
                'Exit Sub
                'Report for Sales
                Dim dsSales As New DataSet
                dsSales = New dsPOS
                Dim dsSalesTemp As New DataSet
                dsSalesTemp = New DataSet()
                dsSalesTemp.ReadXml("XML\SalesReport.xml")
                dsSales.Merge(dsSalesTemp.Tables(0))
                rptSales = New Sales_Report
                rptSales.SetDataSource(dsSales)
                crvSalesReport.ReportSource = rptSales

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Else
            MsgBox("No sales on this date.")
        End If

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        loadSales(True)
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        crvSalesReport.PrintReport()
    End Sub
End Class
