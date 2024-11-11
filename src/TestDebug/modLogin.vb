'' Data Fetcher from Database for Login System (modLogin.vb)
'' By Bart Cabuyao
'' 3/27/2022

Imports CdMLMS.modLibrary

Module modLogin
    Public NameOfStaff As String
    Public ID As UInt16
    Public IsAdmin As Boolean
    Public Position As String

    Function CheckAccount(ByVal user As String, ByVal pass As String) As Boolean

        If String.IsNullOrEmpty(user) And String.IsNullOrEmpty(pass) Then
            MessageBox.Show("Please input", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@user", user)
            .Parameters.AddWithValue("@pass", pass)
            .CommandText = "SELECT * FROM LoginInfo WHERE Username=@user AND Password=@pass"
        End With

        Reader = Query.ExecuteReader

        While Reader.Read

            NameOfStaff = Reader.Item("Last Name") & ", " & Reader.Item("First Name") _
                & " " & Reader.Item("Middle Initials") & " " & Reader.Item("Suffix")

            ID = Reader.Item("ID Number")

            IsAdmin = Reader.Item("Administrative Privilages")

            Position = Reader.Item("Position")

        End While

        Try
            Select Case Reader.StepCount
                Case 1
                    MessageBox.Show("Login Successful", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Case Else
                    MessageBox.Show("Wrong username/password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
            End Select
        Finally
            Query.Reset()
            Reader.Close()
            Database.Close()
        End Try
    End Function
End Module
