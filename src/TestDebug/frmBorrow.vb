Imports CdMLMS.modBooks
Imports CdMLMS.modItems
Imports CdMLMS.modBorrower

Public Class frmBorrow

    Sub Init() Handles Me.Load

        lstAvailableBooks.Items.Clear()
        lstBorrowedBooks.Items.Clear()
        PopulateListWithBooks(lstAvailableBooks, 1)                                     '   From modBooks.vb

        AllControlsEnable(False)

    End Sub

    Sub MoveRight() Handles btnRight.Click
        MoveItem(lstAvailableBooks, lstBorrowedBooks)                                   '   From modItems.vb
    End Sub

    Sub MoveLeft() Handles btnLeft.Click
        MoveItem(lstBorrowedBooks, lstAvailableBooks)                                   '   From modItems.vb
    End Sub

    'Sub Debug() Handles lstBorrowedBooks.MouseHover
    '   Label2.Text = lstBorrowedBooks.Items.Count
    'End Sub

    Sub Confirm() Handles btnConfirmTransaction.Click

        Dim Response As DialogResult = MessageBox.Show("Are you sure?", "Proceed?", _
                                                  MessageBoxButtons.YesNo, _
                                                  MessageBoxIcon.Warning)
        If Response = DialogResult.No Then
            'Exit Sub
        End If

        For i As Integer = 0 To (lstBorrowedBooks.Items.Count - 1)
            BorrowBook(txtID.Text, lstBorrowedBooks.Items.Item(i).Text)                         '   From modBooks.vb
        Next


        If modBooks.AffectedRows > 0 Then
            MessageBox.Show("Done", "Success", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information, _
                            MessageBoxDefaultButton.Button1)
            MessageBox.Show("The books should be returned to " + vbLf + " the library at " _
                            + Date.Today.AddDays(7), "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Nothing happened...")
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

    ' ==================================================================================================

    Sub AllControlsEnable(ByVal _flag As Boolean)
        lstAvailableBooks.Enabled = _flag
        lstBorrowedBooks.Enabled = _flag
        btnLeft.Enabled = _flag
        btnRight.Enabled = _flag
        btnConfirmTransaction.Enabled = _flag
    End Sub

End Class