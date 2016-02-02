Imports System.IO

Module GeneralMethods
    Public Function NumToStr(number As String, Optional size As Byte = 8) As String
        number = FormatNumber(number, 2)
        number = Replace(number, ".", "")
        number = Replace(number, ",", "")
        number = "00000000" & number
        Return number.Substring(number.Length - size)
    End Function

    Public Function StrToNum(str As String, Optional decimalplace As Byte = 2, Optional withComma As Boolean = True) As String
        str = str.Substring(0, str.Length - decimalplace) & "." & str.Substring(str.Length - decimalplace)
        If withComma Then
            Return FormatNumber(Val(str), 2)
        Else
            Return Val(str)
        End If
    End Function

    Public Function StrToDate(str As String) As Date
        str = str.Substring(4, 2) & "/" & str.Substring(6, 2) & "/" & str.Substring(0, 4)
        Return Format(str, "Short date")
    End Function

    Public Function DateToStr(petsa As Date) As String
        Return Format(petsa, "yyyyMMdd")
    End Function
    'Public Function is_debitted(account_type_id As Integer)
    '    Dim debitted() = {3, 4, 5}
    '    Return debitted.Contains(account_type_id)
    'End Function
    'Public Function get_journals(ledger_id As Integer)
    '    Dim dr As SqlClient.SqlDataReader
    '    Dim db As New DBHelper(My.Settings.connectionString)

    '    Dim journals(0) As String
    '    Dim counter As Integer

    '    dr = db.ExecuteReader("SELECT id FROM journals WHERE ledger_id=" & ledger_id)
    '    If dr.HasRows Then
    '        counter = 0
    '        Do While dr.Read
    '            ReDim Preserve journals(counter)
    '            journals(counter) = (dr.Item(0))
    '            counter += 1
    '        Loop
    '        Return String.Join(",", journals)
    '    Else
    '        Return Nothing
    '    End If
    'End Function
    ''Call this method for logging user activities
    'Public Sub log(msg As String, Optional logType As String = "EVENT")
    '    Dim curDirectory As String = "D:/LMSdb/" 'My.Settings.CurrentLogDirectory
    '    If System.IO.File.Exists(curDirectory) = False Then
    '        System.IO.Directory.CreateDirectory(curDirectory)
    '    End If

    '    Dim fs As FileStream = New FileStream(curDirectory + "LMS_LOGS_" + Format(Now, "yyyyMMdd") + ".log", FileMode.OpenOrCreate, FileAccess.ReadWrite)
    '    Dim s As StreamWriter = New StreamWriter(fs)
    '    s.Close()
    '    fs.Close()

    '    Dim fs1 As FileStream = New FileStream(curDirectory + "LMS_LOGS_" + Format(Now, "yyyyMMdd") + ".log", FileMode.Append, FileAccess.Write)
    '    Dim s1 As StreamWriter = New StreamWriter(fs1)

    '    msg.Replace(Chr(0), "")
    '    s1.WriteLine(Now + " #" + logType.ToUpper + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name + " - " + msg)
    '    s1.Close()
    '    fs1.Close()


    'End Sub


End Module
