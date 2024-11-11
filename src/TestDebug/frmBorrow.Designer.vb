<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrow
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
        Me.lstAvailableBooks = New System.Windows.Forms.ListView()
        Me.BookCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BookName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BookAuthor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstBorrowedBooks = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnConfirmTransaction = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAvailableBooks
        '
        Me.lstAvailableBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAvailableBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BookCode, Me.BookName, Me.BookAuthor})
        Me.lstAvailableBooks.FullRowSelect = True
        Me.lstAvailableBooks.GridLines = True
        Me.lstAvailableBooks.Location = New System.Drawing.Point(6, 19)
        Me.lstAvailableBooks.Name = "lstAvailableBooks"
        Me.lstAvailableBooks.Size = New System.Drawing.Size(333, 255)
        Me.lstAvailableBooks.TabIndex = 9
        Me.lstAvailableBooks.UseCompatibleStateImageBehavior = False
        Me.lstAvailableBooks.View = System.Windows.Forms.View.Details
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lstAvailableBooks)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 280)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Available Books"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lstBorrowedBooks)
        Me.GroupBox2.Location = New System.Drawing.Point(436, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 274)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Books to be Borrowed"
        '
        'lstBorrowedBooks
        '
        Me.lstBorrowedBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstBorrowedBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstBorrowedBooks.FullRowSelect = True
        Me.lstBorrowedBooks.GridLines = True
        Me.lstBorrowedBooks.Location = New System.Drawing.Point(6, 19)
        Me.lstBorrowedBooks.Name = "lstBorrowedBooks"
        Me.lstBorrowedBooks.Size = New System.Drawing.Size(341, 249)
        Me.lstBorrowedBooks.TabIndex = 9
        Me.lstBorrowedBooks.UseCompatibleStateImageBehavior = False
        Me.lstBorrowedBooks.View = System.Windows.Forms.View.Details
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
        Me.txtID.Location = New System.Drawing.Point(82, 62)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(139, 20)
        Me.txtID.TabIndex = 12
        Me.txtID.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Student ID:"
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(363, 176)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(67, 46)
        Me.btnRight.TabIndex = 14
        Me.btnRight.Text = ">>"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(363, 228)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(67, 46)
        Me.btnLeft.TabIndex = 15
        Me.btnLeft.Text = "<<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(227, 60)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 23)
        Me.btnVerify.TabIndex = 16
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'btnConfirmTransaction
        '
        Me.btnConfirmTransaction.Location = New System.Drawing.Point(669, 60)
        Me.btnConfirmTransaction.Name = "btnConfirmTransaction"
        Me.btnConfirmTransaction.Size = New System.Drawing.Size(120, 23)
        Me.btnConfirmTransaction.TabIndex = 17
        Me.btnConfirmTransaction.Text = "Confirm Transaction..."
        Me.btnConfirmTransaction.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(363, 60)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 18
        Me.lblDate.Text = "Label2"
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 387)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnConfirmTransaction)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrow a Book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAvailableBooks As System.Windows.Forms.ListView
    Friend WithEvents BookCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents BookName As System.Windows.Forms.ColumnHeader
    Friend WithEvents BookAuthor As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstBorrowedBooks As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents btnConfirmTransaction As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
End Class
