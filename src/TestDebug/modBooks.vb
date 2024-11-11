' Book Information Manipulation Module (vbBooks.vb)
' Written by Bart Cabuyao
' Date: 6/6/2022, 1:04a

Imports CdMLMS.modLibrary

Module modBooks

    ' ~ Code for Book Status ~
    '   2   = Stored
    '   1   = Available
    '   0   = Borrowed
    '   -1  = Missing

    Public AffectedRows As Integer

    Sub PopulateListWithBooks(ByVal List As ListView, ByVal BookStatus As Integer)

        '   ==================================================================================
        '   PopulateListWithBooks() is a procedure that requires a ListView Control and an
        '   integer that represents the Book Status of book from the database (refer to the
        '   status code above).
        '
        '   It reads and pulls out the book information found from the database and lists it 
        '   all down to the ListView Control from the parameter specified.
        '   ==================================================================================

        Dim BookCode, BookName, BookAuthor As String

        List.Items.Clear()

        Database.Open()

        With Query
            .Connection = Database

            If BookStatus = 2 Then
                .CommandText = "SELECT * FROM BookInfo"
            Else
                .CommandText = "SELECT * FROM BookInfo WHERE Status=" & BookStatus
            End If

        End With

        Reader = Query.ExecuteReader()

        Do While Reader.Read
            BookCode = Reader.Item("Book Library Code")
            BookName = Reader.Item("Book Title")
            BookAuthor = Reader.Item("Book Author")
            List.Items.Add(New ListViewItem({BookCode, BookName, BookAuthor}))
        Loop

        Query.Reset()
        Reader.Close()
        Database.Close()

    End Sub

    Sub ShowBookInfo(ByVal _code As String, ByVal _status As Label, ByVal _txtcode As TextBox, _
                     ByVal _title As TextBox, ByVal _author As TextBox, ByVal _pub As TextBox, _
                     ByVal _date As TextBox, ByVal _isbn As TextBox, _
                     Optional ByVal _cover As Byte = Nothing)

        Dim i As Integer

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@code", _code)
            .CommandText = "SELECT * FROM BookInfo WHERE [Book Library Code]=@code"
        End With

        Reader = Query.ExecuteReader

        While Reader.Read
            _txtcode.Text = _code
            i = Integer.Parse(Reader.Item("Status"))
            _title.Text = Reader.Item("Book Title")
            _author.Text = Reader.Item("Book Author")
            _pub.Text = Reader.Item("Book Publisher")
            _date.Text = Reader.Item("Date of Publication")
            _isbn.Text = Reader.Item("Book ISBN")
        End While

        Select Case i
            Case 1
                With _status
                    .Text = "AVAILABLE"
                    .ForeColor = Color.Green
                End With
            Case -1
                With _status
                    .Text = "MISSING"
                    .ForeColor = Color.Red
                End With
            Case Else
                With _status
                    .Text = "BORROWED"
                    .ForeColor = Color.Blue
                End With
        End Select

        Query.Reset()
        Reader.Close()
        Database.Close()

    End Sub

    Sub ProcessBook(ByVal _id As String, ByVal _code As String, ByVal _status As Integer)

        '   ==================================================================================
        '   ProcessBook() is a procedure that requires the book code as String data type and 
        '   an integer that represents the Book Status of book from the database (refer to the
        '   status code above).
        '
        '   It reads and pulls out the book information found from the database and lists it 
        '   all down to the ListView Control from the parameter specified. [NOT RIGHT] 
        '   ==================================================================================

        Database.Open()


        With Query
            .Connection = Database
            .Parameters.AddWithValue("@code", _code)
            .Parameters.AddWithValue("@stat", _status)
            .Parameters.AddWithValue("@id", _id)
            .Parameters.AddWithValue("@date", Date.Today.AddDays(7))

            If _status = 0 Then
                .CommandText = "UPDATE BookInfo SET Status=@stat, Borrower=@id, " +
                    "[Date Issued]=@date WHERE [Book Library Code]=@code"
            ElseIf _status = 1 Then
                .CommandText = "UPDATE BookInfo SET Status=@stat, " +
                    "Borrower=@id WHERE [Book Library Code]=@code"
            End If
        End With

        AffectedRows = Query.ExecuteNonQuery

        Query.Reset()
        Reader.Close()
        Database.Close()

    End Sub

    Sub BorrowBook(ByVal _id As String, ByVal _code As String)

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@code", _code)
            .Parameters.AddWithValue("@stat", 0)
            .Parameters.AddWithValue("@id", _id)
            .Parameters.AddWithValue("@date", Date.Today.AddDays(7))
            .CommandText = "UPDATE BookInfo SET Status=@stat, Borrower=@id, " +
                    "[Date Issued]=@date WHERE [Book Library Code]=@code"

            AffectedRows = Query.ExecuteNonQuery

            Query.Reset()
            Reader.Close()
            Database.Close()

        End With
    End Sub

    Sub ReturnBook(ByVal _id As String, ByVal _code As String)

        Dim BookName, BookCode As String
        Dim DateIssued, DateReturned As Date
        Dim DateCompare As TimeSpan

        Database.Open()

        ' Main block
        With Query
            .Connection = Database
            .Parameters.AddWithValue("@code", _code)
            .Parameters.AddWithValue("@stat", 1)
            .Parameters.AddWithValue("@id", _id)
            .Parameters.AddWithValue("@date", Date.Today)
            .CommandText = "UPDATE BookInfo SET Status=@stat, Borrower=@id, " +
                    "[Date Issued]=@date WHERE [Book Library Code]=@code"
        End With

        AffectedRows = Query.ExecuteNonQuery

        Query.Reset()
        Reader.Close()
        Database.Close()

        ' Date Comparison
        With Query
            .Connection = Database
            .Parameters.AddWithValue("@id", _id)
            .Parameters.AddWithValue("@code", _code)
            .CommandText = "SELECT * FROM BookInfo WHERE [Borrower]=@id AND [Book Library Code]=@code"
        End With

        Reader = Query.ExecuteReader

        While Reader.Read

            BookName = Reader.Item("Book Title")
            BookCode = Reader.Item("Book Library Code")
            DateIssued = Date.Parse(Reader.Item("Date Returned"))
            DateReturned = Date.Parse(Reader.Item("Date Issued"))
            DateCompare = DateReturned - DateIssued

        End While

        If DateCompare.TotalDays > 0 Then
            MessageBox.Show("You haven't return the book '" + _
                            BookName + "' with a book code of '" + BookCode + "' for " + DateCompare.TotalDays)
        End If

        Query.Reset()
        Reader.Close()
        Database.Close()

    End Sub

    Sub AddBook(ByVal _code As String, ByVal _title As String, ByVal _author As String, ByVal _pub As String, _
                   ByVal _pubdate As String, ByVal _isbn As String)

        '   ==================================================================================
        '   AddBook() 
        '       Requires:
        '           _code (Book Code)                   Data Type: String
        '           _title (Book Title)
        '           _author (Book Author)
        '           _pub (Book Publisher)
        '           _pubdate (Date of Publisher)
        '           _isbn (Book ISBN)
        '           
        '   It adds a new book information in the database.
        '   ==================================================================================


        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@code", _code)
            .Parameters.AddWithValue("@title", _title)
            .Parameters.AddWithValue("@author", _author)
            .Parameters.AddWithValue("@pub", _pub)
            .Parameters.AddWithValue("@pubdate", _pubdate)
            .Parameters.AddWithValue("@isbn", _isbn)
            .Parameters.AddWithValue("@status", 1)
            .CommandText = "INSERT INTO BookInfo([Book Library Code],[Book Title], [Book Author], " &
                "[Book Publisher], [Date of Publication], [Book ISBN], Status) VALUES " &
                "(@code, @title, @author, @pub, @pubdate, @isbn, @status)"
        End With

        AffectedRows = Query.ExecuteNonQuery()

        If AffectedRows >= 1 Then
            MessageBox.Show("Book successfully recorded.", "Done!", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        Query.Reset()
        Database.Close()

    End Sub

    Sub UpdateBookInfo(ByVal _code As String, ByVal _title As String, ByVal _author As String, ByVal _pub As String, _
                   ByVal _pubdate As String, ByVal _isbn As String)

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@code", _code)
            .Parameters.AddWithValue("@title", _title)
            .Parameters.AddWithValue("@author", _author)
            .Parameters.AddWithValue("@pub", _pub)
            .Parameters.AddWithValue("@pubdate", _pubdate)
            .Parameters.AddWithValue("@isbn", _isbn)
            .CommandText = "UPDATE BookInfo SET [Book Title]=@title, [Book Author]=@author, [Book Publisher]=@pub, " +
                "[Date of Publication]=@pubdate, [Book ISBN]=@isbn WHERE [Book Library Code]=@code"
        End With

        AffectedRows = Query.ExecuteNonQuery()

        If AffectedRows >= 1 Then
            MessageBox.Show("Book infomation successfully updated!", "Done!", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Query.Reset()
        Database.Close()

    End Sub

    Sub DeleteBook(ByVal _code As String)

        Database.Open()

        With Query
            .Connection = Database
            .Parameters.AddWithValue("@code", _code)
            .CommandText = "DELETE FROM BookInfo WHERE [Book Library Code]=@code"
        End With

        AffectedRows = Query.ExecuteNonQuery()

        If AffectedRows >= 1 Then
            MessageBox.Show("Book successfully remove from the database", "Done!", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Query.Reset()
        Database.Close()

    End Sub


End Module
