' Borrowers Information Reader and Manipulator Module
' Bart Cabuyao
' 7/4/22 1:58a

Imports CdMLMS.modLibrary

Module modBorrower

    Dim AffectedRows As Integer

    Sub PopulateListWithBorrowers(ByVal _list As ListView)

        '   ==================================================================================
        '   ==================================================================================

        Dim _id, _name As String

        _list.Items.Clear()

        Database.Open()

        With Query
            .Connection = Database
            .CommandText = "SELECT * FROM BorrowersInfo"
        End With

        Reader = Query.ExecuteReader()

        Do While Reader.Read
            _id = Reader.Item("Student ID")

            _name = Reader.Item("Last Name") & ", " & Reader.Item("First Name") & " " _
                & Reader.Item("Suffixes") & " " & Reader.Item("Middle Name")

            _list.Items.Add(New ListViewItem({_id, _name}))
        Loop

        Query.Reset()
        Reader.Close()
        Database.Close()

    End Sub

    Function IsRegisteredBorrower(ByVal _id As String) As Boolean

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@id", _id)
            .CommandText = "SELECT * FROM BorrowersInfo WHERE [Student ID]=@id"
        End With

        Reader = Query.ExecuteReader

        Try      
            If Reader.StepCount <= 0 Then
                Return False
            Else
                Return True
            End If
        Finally
            Query.Reset()
            Reader.Close()
            Database.Close()
        End Try

    End Function

    Sub BorrowerLookup(ByVal _id As String, ByVal _idtxt As TextBox, ByVal _first As TextBox, _
                       ByVal _last As TextBox, ByVal _middle As TextBox, ByVal _suffixes As TextBox)

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@id", _id)
            .CommandText = "SELECT * FROM BorrowersInfo WHERE [Student ID]=@id"
        End With

        Reader = Query.ExecuteReader()

        While Reader.Read
            _idtxt.Text = _id
            _first.Text = Reader.Item("First Name")
            _last.Text = Reader.Item("Last Name")
            _middle.Text = Reader.Item("Middle Name")
            _suffixes.Text = Reader.Item("Suffixes")
        End While

        Query.Reset()
        Reader.Close()
        Database.Close()

    End Sub

    Sub RegisterBorrower(ByVal _id As TextBox, ByVal _first As TextBox, _
                       ByVal _last As TextBox, ByVal _middle As TextBox, _
                       Optional ByVal _suffixes As TextBox = Nothing)

        '   ==================================================================================

        '   ==================================================================================

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@id", _id.Text)
            .Parameters.AddWithValue("@first", _first.Text)
            .Parameters.AddWithValue("@last", _last.Text)
            .Parameters.AddWithValue("@middle", _middle.Text)
            .Parameters.AddWithValue("@suffixes", _suffixes.Text)
            .CommandText = "INSERT INTO BorrowersInfo([Student ID],[First Name],[Last Name],[Middle Name],[Suffixes]) " +
                "VALUES (@id,@first,@last,@middle,@suffixes)"
        End With

        AffectedRows = Query.ExecuteNonQuery()

        If AffectedRows >= 1 Then
            MessageBox.Show("Student was successfully registered.", "Done!", _
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Query.Reset()
        Database.Close()

    End Sub

    Sub UpdateBorrowerInfo(ByVal _id As TextBox, ByVal _first As TextBox, _
                       ByVal _last As TextBox, ByVal _middle As TextBox, _
                       Optional ByVal _suffixes As TextBox = Nothing)

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@id", _id.Text)
            .Parameters.AddWithValue("@first", _first.Text)
            .Parameters.AddWithValue("@last", _last.Text)
            .Parameters.AddWithValue("@middle", _middle.Text)
            .Parameters.AddWithValue("@suffixes", _suffixes.Text)
            .CommandText = "UPDATE BorrowersInfo SET [First Name]=@first,[Last Name]=@last,[Middle Name]=@middle," & _
                "Suffixes=@suffixes WHERE [Student ID]=@id"
        End With

        AffectedRows = Query.ExecuteNonQuery()

        If AffectedRows >= 1 Then
            MessageBox.Show("Student information was successfully updated!", "Done!", _
             MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Query.Reset()
        Database.Close()

    End Sub

    Sub UnRegisterBorrower(ByVal _id As TextBox)

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@code", _id.Text)
            .CommandText = "DELETE FROM BorrowersInfo WHERE [Student ID]=@code"
        End With

        AffectedRows = Query.ExecuteNonQuery()

        If AffectedRows >= 1 Then
            MessageBox.Show("Student was successfully unregistered!", "Done!", _
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Query.Reset()
        Database.Close()

    End Sub


End Module
