Imports CdMLMS.modBooks

Public Class frmBooks

    Sub Init() Handles Me.Load

        lstAvailableBooks.Items.Clear()
        PopulateListWithBooks(lstAvailableBooks, 2)

    End Sub

    Sub ViewBookInfo() Handles lstAvailableBooks.SelectedIndexChanged

        ShowBookInfo(lstAvailableBooks.FocusedItem.Text, lblStatus, txtCode, _
                     txtTitle, txtAuthor, txtPublisher, txtPubDate, txtISBN)

    End Sub

    Sub AddNewBook() Handles btnAddNewBook.Click

        ControlBtnTxtLst(False)
        AllTextClear()

    End Sub

    Sub CancelAddNewBook() Handles btnCancel.Click

        ControlBtnTxtLst(True)
        AllTextClear()

    End Sub

    Sub AddOrUpdateNewBook() Handles btnAddUpdate.Click


        If MsgBox("Are you sure?", vbYesNo + vbExclamation, "Attention!") = MsgBoxResult.No Then
            Exit Sub
        End If

        If btnAddNewBook.Enabled = False And Not (TextboxEmpty()) Then
            AddBook(txtCode.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, txtPubDate.Text, txtISBN.Text)
            Init()
            Exit Sub
        End If

        UpdateBookInfo(txtCode.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, txtPubDate.Text, txtISBN.Text)
        Init()

    End Sub

    Sub DeleteSelectedBook() Handles btnDeleteBook.Click

        Dim result As DialogResult

        result = MessageBox.Show("Are you sure?", "Attention!", _
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.No Then
            Exit Sub
        End If

        DeleteBook(lstAvailableBooks.FocusedItem.Text)
        Init()

    End Sub

    Function TextboxEmpty() As Boolean

        Return txtCode.Text = Nothing AndAlso txtTitle.Text = Nothing AndAlso txtAuthor.Text = Nothing _
            AndAlso txtPublisher.Text = Nothing AndAlso txtPubDate.Text = Nothing AndAlso txtISBN.Text = Nothing

    End Function

    Sub ControlBtnTxtLst(ByVal flag As Boolean)

        lstAvailableBooks.Enabled = flag

        txtCode.ReadOnly = flag

        btnAddNewBook.Enabled = flag
        btnDeleteBook.Enabled = flag
        btnCancel.Enabled = Not flag

    End Sub

    Sub AllTextClear()

        lblStatus.Text = Nothing
        txtCode.Text = Nothing
        txtAuthor.Text = Nothing
        txtTitle.Text = Nothing
        txtPublisher.Text = Nothing
        txtPubDate.Text = Nothing
        txtISBN.Text = Nothing

    End Sub
End Class