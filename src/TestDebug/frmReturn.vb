' Return a book
' Cabuyao
' 7/3/2022  3:33p

'Imports CdMLMS.modBooks
Imports CdMLMS.modItems
Imports CdMLMS.modBorrower

Public Class frmReturn

    Sub Init() Handles Me.Load

        lstBorrowedBooks.Items.Clear()
        lstMissingBooks.Items.Clear()
        lstReturningBooks.Items.Clear()

        PopulateListWithBooks(lstBorrowedBooks, 0)                                  '   From modBooks.vb

    End Sub

    Sub MoveItemToRight() Handles btnMoveRight.Click

        If tabBookSections.SelectedTab.Text = "Returning Books" Then
            MoveItem(lstBorrowedBooks, lstReturningBooks)                           '   From modItem.vb
        ElseIf tabBookSections.SelectedTab.Text = "Missing Books" Then
            MoveItem(lstBorrowedBooks, lstMissingBooks)                             '   From modItem.vb
        End If

    End Sub

    Sub MoveItemToLeft() Handles btnMoveLeft.Click

        If tabBookSections.SelectedTab.Text = "Returning Books" Then
            MoveItem(lstReturningBooks, lstBorrowedBooks)
        ElseIf tabBookSections.SelectedTab.Text = "Missing Books" Then
            MoveItem(lstMissingBooks, lstBorrowedBooks)
        End If

    End Sub

    Sub Confirm() Handles btnConfirmTransaction.Click

        Dim Response As Int16 = MessageBox.Show("Are you sure?", "Proceed?", _
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If Response = vbNo Then
            Exit Sub
        End If

        For i As Int16 = 0 To (lstReturningBooks.Items.Count - 1)
            ProcessBook(txtID.Text, lstReturningBooks.Items.Item(i).Text, 1)                    '   from modBooks.vb
        Next

        ' Prompt for successful return of the books
        If AffectedRows > 0 And lstReturningBooks.Items.Count > 0 Then
            MessageBox.Show("The book(s) was successfully returned!", _
                            "Success!", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
        End If

        For i As Int16 = 0 To (lstMissingBooks.Items.Count - 1)
            ProcessBook(txtID.Text, lstMissingBooks.Items.Item(i).Text, -1)                     '   from modBooks.vb
        Next

        ' Prompt for successful declaration of of the book(s) as missing.
        If AffectedRows > 0 And lstMissingBooks.Items.Count > 0 Then
            MessageBox.Show("The book(s) was successfully marked as missing", _
                            "Success!", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
        End If

        Me.Close()

    End Sub

    Sub VerifyBorrower() Handles btnVerify.Click

        If IsRegisteredBorrower(txtID.Text) = False Then
            MessageBox.Show("Wrong Student ID or not yet registered.", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        AllControlsEnable(True)

    End Sub

    Sub AllControlsEnable(ByVal _flag As Boolean)
        lstBorrowedBooks.Enabled = _flag
        lstMissingBooks.Enabled = _flag
        lstReturningBooks.Enabled = _flag
        btnMoveLeft.Enabled = _flag
        btnMoveRight.Enabled = _flag
        btnConfirmTransaction.Enabled = _flag
    End Sub

End Class