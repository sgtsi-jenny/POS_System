Public Class btnBACK


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
        Login.txtUsername.Text = ""
        Login.txtPassword.Text = ""
        Login.lbl_utype.Text = ""
        'Application.Exit()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        uscTransactions.btnEnter.Anchor = AnchorStyles.Bottom
        uscTransactions.btnEnter.Width = 200
        uscTransactions.btnEnter.Height = 59
        uscTransactions.btnExit.Anchor = AnchorStyles.Bottom
        uscTransactions.btnExit.Width = 200
        uscTransactions.btnExit.Height = 59

        uscTransactions.btnNew.Width = 200
        uscTransactions.btnNew.Height = 59
        uscTransactions.btnQty.Width = 200
        uscTransactions.btnQty.Height = 59
        showUSC(uscTransactions)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        showUSC(uscInventory)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        showUSC(uscUsers)
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showPanel(True)
    End Sub
    Private Sub showPanel(mode As Boolean)
        pnl_main.Visible = mode
        pnlReports.Visible = Not mode
    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        pnlReports.BringToFront()
        showPanel(False)
        showUSC(uscReports)

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        pnl_main.BringToFront()
        showPanel(True)
    End Sub
End Class