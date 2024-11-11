<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrower
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRegisterUpdate = New System.Windows.Forms.Button()
        Me.btnUnregisterStudent = New System.Windows.Forms.Button()
        Me.btnRegisterNewStudent = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtSuffixes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstRegisteredStudents = New System.Windows.Forms.ListView()
        Me.StudentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StudentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegisterUpdate
        '
        Me.btnRegisterUpdate.Location = New System.Drawing.Point(205, 238)
        Me.btnRegisterUpdate.Name = "btnRegisterUpdate"
        Me.btnRegisterUpdate.Size = New System.Drawing.Size(100, 23)
        Me.btnRegisterUpdate.TabIndex = 14
        Me.btnRegisterUpdate.Text = "Register / Update"
        Me.btnRegisterUpdate.UseVisualStyleBackColor = True
        '
        'btnUnregisterStudent
        '
        Me.btnUnregisterStudent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUnregisterStudent.Location = New System.Drawing.Point(664, 107)
        Me.btnUnregisterStudent.Name = "btnUnregisterStudent"
        Me.btnUnregisterStudent.Size = New System.Drawing.Size(114, 23)
        Me.btnUnregisterStudent.TabIndex = 18
        Me.btnUnregisterStudent.Text = "Unregister Student"
        Me.btnUnregisterStudent.UseVisualStyleBackColor = True
        '
        'btnRegisterNewStudent
        '
        Me.btnRegisterNewStudent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRegisterNewStudent.Location = New System.Drawing.Point(533, 107)
        Me.btnRegisterNewStudent.Name = "btnRegisterNewStudent"
        Me.btnRegisterNewStudent.Size = New System.Drawing.Size(125, 23)
        Me.btnRegisterNewStudent.TabIndex = 17
        Me.btnRegisterNewStudent.Text = "Register New Student"
        Me.btnRegisterNewStudent.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(370, 123)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(412, 316)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtSuffixes)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtMiddleName)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtLastName)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnRegisterUpdate)
        Me.TabPage1.Controls.Add(Me.txtFirstName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtID)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(404, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Student Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtSuffixes
        '
        Me.txtSuffixes.Location = New System.Drawing.Point(119, 152)
        Me.txtSuffixes.Name = "txtSuffixes"
        Me.txtSuffixes.Size = New System.Drawing.Size(267, 20)
        Me.txtSuffixes.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Suffixes:"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(119, 117)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(267, 20)
        Me.txtMiddleName.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Middle Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(119, 84)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(267, 20)
        Me.txtLastName.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Last Name:"
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(311, 238)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(119, 50)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(267, 20)
        Me.txtFirstName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student Code:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(119, 16)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(132, 20)
        Me.txtID.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lstRegisteredStudents)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 322)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registered Students"
        '
        'lstRegisteredStudents
        '
        Me.lstRegisteredStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstRegisteredStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.StudentID, Me.StudentName})
        Me.lstRegisteredStudents.FullRowSelect = True
        Me.lstRegisteredStudents.GridLines = True
        Me.lstRegisteredStudents.Location = New System.Drawing.Point(6, 22)
        Me.lstRegisteredStudents.Name = "lstRegisteredStudents"
        Me.lstRegisteredStudents.Size = New System.Drawing.Size(328, 294)
        Me.lstRegisteredStudents.TabIndex = 9
        Me.lstRegisteredStudents.UseCompatibleStateImageBehavior = False
        Me.lstRegisteredStudents.View = System.Windows.Forms.View.Details
        '
        'StudentID
        '
        Me.StudentID.Text = "Student ID"
        Me.StudentID.Width = 76
        '
        'StudentName
        '
        Me.StudentName.Text = "Student Name"
        Me.StudentName.Width = 237
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(107, 20)
        Me.TextBox1.TabIndex = 19
        '
        'btnVerify
        '
        Me.btnVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerify.Location = New System.Drawing.Point(190, 77)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(84, 23)
        Me.btnVerify.TabIndex = 20
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Password:"
        '
        'frmBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 457)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnUnregisterStudent)
        Me.Controls.Add(Me.btnRegisterNewStudent)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmBorrower"
        Me.Text = "Borrower's Registry"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegisterUpdate As System.Windows.Forms.Button
    Friend WithEvents btnUnregisterStudent As System.Windows.Forms.Button
    Friend WithEvents btnRegisterNewStudent As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtSuffixes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstRegisteredStudents As System.Windows.Forms.ListView
    Friend WithEvents StudentID As System.Windows.Forms.ColumnHeader
    Friend WithEvents StudentName As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
