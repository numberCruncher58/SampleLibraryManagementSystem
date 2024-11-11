<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblPersonnelName = New System.Windows.Forms.Label()
        Me.lblPersonnelPosition = New System.Windows.Forms.Label()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnAddRemoveBook = New System.Windows.Forms.Button()
        Me.btnAddRemoveBorrowerInfo = New System.Windows.Forms.Button()
        Me.lstBooks = New System.Windows.Forms.ListView()
        Me.BookCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BookName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BookAuthor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPersonnelName
        '
        Me.lblPersonnelName.AutoSize = True
        Me.lblPersonnelName.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonnelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonnelName.ForeColor = System.Drawing.Color.White
        Me.lblPersonnelName.Location = New System.Drawing.Point(24, 66)
        Me.lblPersonnelName.Name = "lblPersonnelName"
        Me.lblPersonnelName.Size = New System.Drawing.Size(127, 16)
        Me.lblPersonnelName.TabIndex = 0
        Me.lblPersonnelName.Text = "[Personnel's Name]"
        Me.lblPersonnelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPersonnelPosition
        '
        Me.lblPersonnelPosition.AutoSize = True
        Me.lblPersonnelPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonnelPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonnelPosition.ForeColor = System.Drawing.Color.White
        Me.lblPersonnelPosition.Location = New System.Drawing.Point(24, 88)
        Me.lblPersonnelPosition.Name = "lblPersonnelPosition"
        Me.lblPersonnelPosition.Size = New System.Drawing.Size(138, 16)
        Me.lblPersonnelPosition.TabIndex = 2
        Me.lblPersonnelPosition.Text = "[Personnel's Position]"
        Me.lblPersonnelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(7, 19)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(132, 48)
        Me.btnBorrow.TabIndex = 4
        Me.btnBorrow.Text = "Borrow a Book"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(7, 73)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(132, 48)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "Return a Book"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnAddRemoveBook
        '
        Me.btnAddRemoveBook.Location = New System.Drawing.Point(7, 127)
        Me.btnAddRemoveBook.Name = "btnAddRemoveBook"
        Me.btnAddRemoveBook.Size = New System.Drawing.Size(132, 48)
        Me.btnAddRemoveBook.TabIndex = 6
        Me.btnAddRemoveBook.Text = "Add/Remove a Book"
        Me.btnAddRemoveBook.UseVisualStyleBackColor = True
        '
        'btnAddRemoveBorrowerInfo
        '
        Me.btnAddRemoveBorrowerInfo.Location = New System.Drawing.Point(7, 181)
        Me.btnAddRemoveBorrowerInfo.Name = "btnAddRemoveBorrowerInfo"
        Me.btnAddRemoveBorrowerInfo.Size = New System.Drawing.Size(132, 48)
        Me.btnAddRemoveBorrowerInfo.TabIndex = 7
        Me.btnAddRemoveBorrowerInfo.Text = "Add/Remove Borrower Info"
        Me.btnAddRemoveBorrowerInfo.UseVisualStyleBackColor = True
        '
        'lstBooks
        '
        Me.lstBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BookCode, Me.BookName, Me.BookAuthor})
        Me.lstBooks.FullRowSelect = True
        Me.lstBooks.GridLines = True
        Me.lstBooks.Location = New System.Drawing.Point(6, 19)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(486, 250)
        Me.lstBooks.TabIndex = 8
        Me.lstBooks.UseCompatibleStateImageBehavior = False
        Me.lstBooks.View = System.Windows.Forms.View.Details
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
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Old English Text MT", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(20, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(154, 42)
        Me.lblWelcome.TabIndex = 9
        Me.lblWelcome.Text = "Welcome!"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lstBooks)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 275)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Books stored in database"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBorrow)
        Me.GroupBox2.Controls.Add(Me.btnReturn)
        Me.GroupBox2.Controls.Add(Me.btnAddRemoveBook)
        Me.GroupBox2.Controls.Add(Me.btnAddRemoveBorrowerInfo)
        Me.GroupBox2.Location = New System.Drawing.Point(516, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 236)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CdMLMS.My.Resources.Resources.login_banner
        Me.PictureBox1.Location = New System.Drawing.Point(239, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(419, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CdMLMS.My.Resources.Resources.books_main_edited
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(670, 425)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblPersonnelPosition)
        Me.Controls.Add(Me.lblPersonnelName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colegio de Montalban Library Management Software"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPersonnelName As System.Windows.Forms.Label
    Friend WithEvents lblPersonnelPosition As System.Windows.Forms.Label
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnAddRemoveBook As System.Windows.Forms.Button
    Friend WithEvents btnAddRemoveBorrowerInfo As System.Windows.Forms.Button
    Friend WithEvents lstBooks As System.Windows.Forms.ListView
    Friend WithEvents BookCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents BookName As System.Windows.Forms.ColumnHeader
    Friend WithEvents BookAuthor As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
