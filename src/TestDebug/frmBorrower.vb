Imports CdMLMS.modBorrower

Public Class frmBorrower

    Sub Init() Handles Me.Load
        PopulateListWithBorrowers(lstRegisteredStudents)
    End Sub

    Sub RegisterStudentSelected() Handles lstRegisteredStudents.SelectedIndexChanged
        BorrowerLookup(lstRegisteredStudents.FocusedItem.Text, txtID, _
                       txtFirstName, txtLastName, txtMiddleName, txtSuffixes)
    End Sub

    Sub AddNewStudent() Handles btnRegisterNewStudent.Click
        ControlBtnTxtLst(False)
        AllTextClear()
    End Sub

    Sub CancelRegistration() Handles btnCancel.Click
        ControlBtnTxtLst(True)
        AllTextClear()
    End Sub

    Sub ConfirmAddUpdate() Handles btnRegisterUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Attention!", MessageBoxButtons.YesNo, _
                                                     MessageBoxIcon.Exclamation)

        If result = DialogResult.No Then
            Exit Sub
        End If

        If btnRegisterNewStudent.Enabled = False And Not (TextboxEmpty()) Then
            RegisterBorrower(txtID, txtFirstName, txtLastName, txtMiddleName, txtSuffixes)
            ControlBtnTxtLst(True)
            AllTextClear()
            Exit Sub
        End If

        UpdateBorrowerInfo(txtID, txtFirstName, txtLastName, txtMiddleName, txtSuffixes)
        ControlBtnTxtLst(True)
        AllTextClear()
    End Sub

    Sub ConfirmUnreg() Handles btnUnregisterStudent.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Attention!", MessageBoxButtons.YesNo, _
                                             MessageBoxIcon.Exclamation)

        If result = DialogResult.No Then
            Exit Sub
        End If

        If txtID.Text = Nothing Then
            Exit Sub
        End If

        UnRegisterBorrower(txtID)

    End Sub

    ' ==============================================================================

    Function TextboxEmpty() As Boolean
        Return txtFirstName.Text = Nothing AndAlso txtLastName.Text = Nothing AndAlso txtMiddleName.Text = Nothing AndAlso txtID.Text = Nothing
    End Function

    Sub ControlBtnTxtLst(ByVal flag As Boolean)

        btnRegisterNewStudent.Enabled = flag
        btnUnregisterStudent.Enabled = flag
        btnCancel.Enabled = Not flag

        lstRegisteredStudents.Enabled = flag

        txtID.ReadOnly = flag

    End Sub

    Sub AllTextClear()
        txtFirstName.Text = Nothing
        txtID.Text = Nothing
        txtLastName.Text = Nothing
        txtMiddleName.Text = Nothing
        txtSuffixes.Text = Nothing
    End Sub

End Class