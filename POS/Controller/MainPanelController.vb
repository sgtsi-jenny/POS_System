Module MainPanelController
    'Public uscEntry As New Journal_Entry
    Public uscMainMenu As New MainMenu
    Public uscInventory As New Inventory
    Public uscTransactions As New pnlPayment
    Public uscUsers As New Users

    
    Public currentUSC As Control
    Sub clearMainPanel()
        MainMenu.panelMain.Controls.Clear()
    End Sub
    Sub showUSC(usc As Control)
        currentUSC = usc
        clearMainPanel()
        currentUSC.Parent = MainMenu.panelMain
        currentUSC.Width = MainMenu.panelMain.Width
        currentUSC.Height = MainMenu.panelMain.Height
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
