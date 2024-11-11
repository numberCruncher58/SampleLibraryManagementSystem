<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturn
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
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.lstReturningBooks = New System.Windows.Forms.ListView()
        Me.BookCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BookName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BookAuthor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabBookSections = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstMissingBooks = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstBorrowedBooks = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.btnConfirmTransaction = New System.Windows.Forms.Button()
        Me.tabBookSections.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(227, 65)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 23)
        Me.btnVerify.TabIndex = 19
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'lstReturningBooks
        '
        Me.lstReturningBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstReturningBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BookCode, Me.BookName, Me.BookAuthor})
        Me.lstReturningBooks.Enabled = False
        Me.lstReturningBooks.FullRowSelect = True
        Me.lstReturningBooks.GridLines = True
        Me.lstReturningBooks.Location = New System.Drawing.Point(6, 6)
        Me.lstReturningBooks.Name = "lstReturningBooks"
        Me.lstReturningBooks.Size = New System.Drawing.Size(351, 280)
        Me.lstReturningBooks.TabIndex = 9
        Me.lstReturningBooks.UseCompatibleStateImageBehavior = False
        Me.lstReturningBooks.View = System.Windows.Forms.View.Details
        '
        'BookCode
        '
        Me.BookCode.Text = "Book Code"
        Me.BookCode.Width = 76
        '
        'BookName
        '
        Me.BookName.Text = "Book Name"
        Me.BookName.Width = 204
        '
        'BookAuthor
        '
        Me.BookAuthor.Text = "Book Author/s"
        Me.BookAuthor.Width = 198
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Student ID:"
        '
        'tabBookSections
        '
        Me.tabBookSections.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabBookSections.Controls.Add(Me.TabPage1)
        Me.tabBookSections.Controls.Add(Me.TabPage2)
        Me.tabBookSections.Location = New System.Drawing.Point(459, 102)
        Me.tabBookSections.Name = "tabBookSections"
        Me.tabBookSections.SelectedIndex = 0
        Me.tabBookSections.Size = New System.Drawing.Size(371, 318)
        Me.tabBookSections.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstReturningBooks)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(363, 292)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Returning Books"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstMissingBooks)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(363, 292)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Missing Books"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstMissingBooks
        '
        Me.lstMissingBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstMissingBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstMissingBooks.Enabled = False
        Me.lstMissingBooks.FullRowSelect = True
        Me.lstMissingBooks.GridLines = True
        Me.lstMissingBooks.Location = New System.Drawing.Point(6, 6)
        Me.lstMissingBooks.Name = "lstMissingBooks"
        Me.lstMissingBooks.Size = New System.Drawing.Size(351, 280)
        Me.lstMissingBooks.TabIndex = 22
        Me.lstMissingBooks.UseCompatibleStateImageBehavior = False
        Me.lstMissingBooks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Book Code"
        Me.ColumnHeader1.Width = 76
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Book Name"
        Me.ColumnHeader2.Width = 204
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Book Author/s"
        Me.ColumnHeader3.Width = 198
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(82, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(139, 20)
        Me.txtID.TabIndex = 18
        Me.txtID.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lstBorrowedBooks)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 315)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrowed Books"
        '
        'lstBorrowedBooks
        '
        Me.lstBorrowedBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstBorrowedBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstBorrowedBooks.Enabled = False
        Me.lstBorrowedBooks.FullRowSelect = True
        Me.lstBorrowedBooks.GridLines = True
        Me.lstBorrowedBooks.Location = New System.Drawing.Point(6, 19)
        Me.lstBorrowedBooks.Name = "lstBorrowedBooks"
        Me.lstBorrowedBooks.Size = New System.Drawing.Size(350, 290)
        Me.lstBorrowedBooks.TabIndex = 9
        Me.lstBorrowedBooks.UseCompatibleStateImageBehavior = False
        Me.lstBorrowedBooks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Book Code"
        Me.ColumnHeader4.Width = 76
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Book Name"
        Me.ColumnHeader5.Width = 204
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Book Author/s"
        Me.ColumnHeader6.Width = 198
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Enabled = False
        Me.btnMoveLeft.Location = New System.Drawing.Point(386, 265)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(67, 46)
        Me.btnMoveLeft.TabIndex = 24
        Me.btnMoveLeft.Text = "<<"
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Enabled = False
        Me.btnMoveRight.Location = New System.Drawing.Point(386, 213)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(67, 46)
        Me.btnMoveRight.TabIndex = 23
        Me.btnMoveRight.Text = ">>"
        Me.btnMoveRight.UseVisualStyleBackColor = True
        '
        'btnConfirmTransaction
        '
        Me.btnConfirmTransaction.Enabled = False
        Me.btnConfirmTransaction.Location = New System.Drawing.Point(690, 65)
        Me.btnConfirmTransaction.Name = "btnConfirmTransaction"
        Me.btnConfirmTransaction.Size = New System.Drawing.Size(130, 23)
        Me.btnConfirmTransaction.TabIndex = 25
        Me.btnConfirmTransaction.Text = "Confirm Transaction..."
        Me.btnConfirmTransaction.UseVisualStyleBackColor = True
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 432)
        Me.Controls.Add(Me.btnConfirmTransaction)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tabBookSections)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.txtID)
        Me.Name = "frmReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return a Book"
        Me.tabBookSections.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents lstReturningBooks As System.Windows.Forms.ListView
    Friend WithEvents BookCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents BookName As System.Windows.Forms.ColumnHeader
    Friend WithEvents BookAuthor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabBookSections As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lstMissingBooks As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstBorrowedBooks As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnMoveLeft As System.Windows.Forms.Button
    Friend WithEvents btnMoveRight As System.Windows.Forms.Button
    Friend WithEvents btnConfirmTransaction As System.Windows.Forms.Button
End Class
