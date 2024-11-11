' CdM Library Management System ~ Main Menu
' Bart Cabuyao
' 5/17/22 9:35a

Imports CdMLMS.modLogin
Imports CdMLMS.modBooks

Public Class frmMain

    Sub Init() Handles Me.Activated

        lblPersonnelName.Text = modLogin.NameOfStaff
        lblPersonnelPosition.Text = modLogin.Position

        PopulateListWithBooks(lstBooks, 2)

    End Sub

    Sub ExitProgram() Handles Me.FormClosed
        ' One last final touch. To avoid memory leaks
        End
    End Sub

    Sub BorrowBooks() Handles btnBorrow.Click
        frmBorrow.ShowDialog()
    End Sub

    Sub ReturnBooks() Handles btnReturn.Click
        frmReturn.ShowDialog()
    End Sub

    Sub ViewBooks() Handles btnAddRemoveBook.Click
        frmBooks.ShowDialog()
    End Sub

    Sub ManipulteBorrower() Handles btnAddRemoveBorrowerInfo.Click
        frmBorrower.ShowDialog()
    End Sub

End Class