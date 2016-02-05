Module MainPanelController
    'Public uscEntry As New Journal_Entry
    Public uscMainMenu As New btnBACK
    Public uscInventory As New Inventory
    Public uscTransactions As New pnlPayment
    Public uscUsers As New Users
    Public uscReports As New Reports
    Public uscMaintenanceInventory As New MaintenanceInventory
    Public uscMaintenanceUnit As New MaintenanceUnit
    Public uscMaintenanceCategory As New MaintenanceCategory


    Public currentUSC As Control
    Sub clearMainPanel()
        btnBACK.panelMain.Controls.Clear()
    End Sub
    Sub showUSC(usc As Control)
        currentUSC = usc
        clearMainPanel()
        currentUSC.Parent = btnBACK.panelMain
        currentUSC.Width = btnBACK.panelMain.Width
        currentUSC.Height = btnBACK.panelMain.Height
    End Sub

    Public posUSC As Control
    Sub clearPOS()
        POS.panelMain.Controls.Clear()
    End Sub
    Sub showPOS(usc As Control)
        posUSC = usc
        clearMainPanel()
        posUSC.Parent = POS.panelMain
        posUSC.Width = POS.panelMain.Width
        posUSC.Height = POS.panelMain.Height
    End Sub
End Module
