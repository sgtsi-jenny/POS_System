Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
'Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class frmLock
    Dim db As New DBHelper(My.Settings.DBconn)
    Dim dr As SqlClient.SqlDataReader
    'Dim cmd As SqlClient.SqlCommand
    Private Const EM_SETCUEBANNER As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
    End Sub
    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider
    Public Shared Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        DES.Key = frmLock.MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String

        DES.Key = frmLock.MD5Hash(key)
        DES.Mode = CipherMode.ECB

        Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
    Private Sub frmLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Focus()
    End Sub
    Private Sub enterKey()
        Try


            Dim pass As String = txtPassword.Text

            If txtPassword.Text = " " Then
                MsgBox("Enter unlock Key. ", MsgBoxStyle.Exclamation, "Invalid")
                txtPassword.Focus()

            Else

                Dim dr As SqlDataReader
                Dim parameters As New Dictionary(Of String, Object)()
                Dim encryptPass = Encrypt(txtPassword.Text, "Keys")
                parameters.Add("user_password", encryptPass)

                dr = db.ExecuteReader("SELECT * FROM Users WHERE user_password=@user_password", parameters)
                If dr.HasRows Then
                    dr.Read()
                    Me.Hide()
                    'showLock(True)

                Else
                    MsgBox("Invalid key", MsgBoxStyle.Exclamation, "Invalid")
                    txtPassword.Text = ""
                    txtPassword.Focus()
                End If
                'Do While dr.Read
                '    MsgBox(dr.Item(1).ToString)
                'Loop

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose() '<--------CHECK THIS!
        End Try
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            enterKey()
        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        enterKey()
        showlock(False)
        uscTransactions.lvw_summary.Items.Clear()
        uscTransactions.txtSearch.Focus()
        uscTransactions.txtTotal.Text = "00"
        uscTransactions.txtTCash.Text = "00"
        uscTransactions.txtChange.Text = "00"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Private Sub showlock(mode As Boolean)
        'Panel1.Enabled = mode
        uscTransactions.txtSearch.Enabled = mode
        uscTransactions.lvProducts.Enabled = mode
        uscTransactions.btnEnter.Enabled = mode
        uscTransactions.btnPrint.Enabled = mode
        uscTransactions.btnLock.Enabled = mode
        uscTransactions.btnAdmin.Enabled = mode
        'btnNew.Enabled = Not mode
        'btnExit.Enabled = Not mode
        'Panel6.Enabled = mode
        'Panel3.Enabled = mode
    End Sub
End Class