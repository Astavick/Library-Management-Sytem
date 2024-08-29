<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrarianForm
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
        Dim Label14 As Label
        TabPage3 = New TabPage()
        Label13 = New Label()
        btnBorrow = New Button()
        txtBorrowUserID = New TextBox()
        txtBorrowBookID = New TextBox()
        Label1 = New Label()
        dgvBorrowedBooks = New DataGridView()
        TabPage2 = New TabPage()
        txtSuggestedBookTitle = New TextBox()
        btnDeleteSuggestion = New Button()
        dgvSuggestedBooks = New DataGridView()
        TabPage1 = New TabPage()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        txtCopiesAvailable = New TextBox()
        Label5 = New Label()
        txtPublicationYear = New TextBox()
        txtBookID = New TextBox()
        txtisbn = New TextBox()
        txtSubject = New TextBox()
        btnAddBook = New Button()
        txtAuthor = New TextBox()
        btnDeleteBook = New Button()
        txtTitle = New TextBox()
        dgvViewBooks = New DataGridView()
        txtAddBookID = New TextBox()
        TabControl1 = New TabControl()
        TabPage4 = New TabPage()
        btnReturn = New Button()
        txtReturnUserID = New TextBox()
        Label12 = New Label()
        txtReturnBookID = New TextBox()
        Label2 = New Label()
        dgvReturnedBooks = New DataGridView()
        TabPage5 = New TabPage()
        Label3 = New Label()
        txtManageFinesUserID = New TextBox()
        btnClear = New Button()
        dgvManageFines = New DataGridView()
        TabPage6 = New TabPage()
        Label17 = New Label()
        Label16 = New Label()
        txtWaitlistUserID = New TextBox()
        Label15 = New Label()
        txtWaitlistBookID = New TextBox()
        btnRemove = New Button()
        dgvWaitlist = New DataGridView()
        btnGoBack = New Button()
        Label14 = New Label()
        TabPage3.SuspendLayout()
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgvSuggestedBooks, ComponentModel.ISupportInitialize).BeginInit()
        TabPage1.SuspendLayout()
        CType(dgvViewBooks, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage4.SuspendLayout()
        CType(dgvReturnedBooks, ComponentModel.ISupportInitialize).BeginInit()
        TabPage5.SuspendLayout()
        CType(dgvManageFines, ComponentModel.ISupportInitialize).BeginInit()
        TabPage6.SuspendLayout()
        CType(dgvWaitlist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(931, 167)
        Label14.Name = "Label14"
        Label14.Size = New Size(74, 21)
        Label14.TabIndex = 2
        Label14.Text = "BookTitle"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Label13)
        TabPage3.Controls.Add(btnBorrow)
        TabPage3.Controls.Add(txtBorrowUserID)
        TabPage3.Controls.Add(txtBorrowBookID)
        TabPage3.Controls.Add(Label1)
        TabPage3.Controls.Add(dgvBorrowedBooks)
        TabPage3.Location = New Point(4, 30)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1481, 593)
        TabPage3.TabIndex = 2
        TabPage3.Text = "BorrowedBooks"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(957, 156)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 21)
        Label13.TabIndex = 4
        Label13.Text = "UserID:"
        ' 
        ' btnBorrow
        ' 
        btnBorrow.Location = New Point(1056, 225)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(101, 47)
        btnBorrow.TabIndex = 3
        btnBorrow.Text = "Borrow"
        btnBorrow.UseVisualStyleBackColor = True
        ' 
        ' txtBorrowUserID
        ' 
        txtBorrowUserID.Location = New Point(1021, 148)
        txtBorrowUserID.Name = "txtBorrowUserID"
        txtBorrowUserID.Size = New Size(179, 29)
        txtBorrowUserID.TabIndex = 2
        ' 
        ' txtBorrowBookID
        ' 
        txtBorrowBookID.Location = New Point(1021, 185)
        txtBorrowBookID.Name = "txtBorrowBookID"
        txtBorrowBookID.Size = New Size(179, 29)
        txtBorrowBookID.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(956, 193)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 21)
        Label1.TabIndex = 1
        Label1.Text = "BookID:"
        ' 
        ' dgvBorrowedBooks
        ' 
        dgvBorrowedBooks.BackgroundColor = SystemColors.ControlLight
        dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowedBooks.Location = New Point(0, 0)
        dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        dgvBorrowedBooks.Size = New Size(951, 597)
        dgvBorrowedBooks.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(txtSuggestedBookTitle)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(btnDeleteSuggestion)
        TabPage2.Controls.Add(dgvSuggestedBooks)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1481, 593)
        TabPage2.TabIndex = 1
        TabPage2.Text = "SuggestedBooks"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtSuggestedBookTitle
        ' 
        txtSuggestedBookTitle.Location = New Point(1002, 159)
        txtSuggestedBookTitle.Name = "txtSuggestedBookTitle"
        txtSuggestedBookTitle.Size = New Size(196, 29)
        txtSuggestedBookTitle.TabIndex = 3
        ' 
        ' btnDeleteSuggestion
        ' 
        btnDeleteSuggestion.Location = New Point(1033, 200)
        btnDeleteSuggestion.Name = "btnDeleteSuggestion"
        btnDeleteSuggestion.Size = New Size(120, 51)
        btnDeleteSuggestion.TabIndex = 1
        btnDeleteSuggestion.Text = "Bought"
        btnDeleteSuggestion.UseVisualStyleBackColor = True
        ' 
        ' dgvSuggestedBooks
        ' 
        dgvSuggestedBooks.BackgroundColor = SystemColors.ControlLight
        dgvSuggestedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSuggestedBooks.Location = New Point(0, 0)
        dgvSuggestedBooks.Name = "dgvSuggestedBooks"
        dgvSuggestedBooks.Size = New Size(925, 590)
        dgvSuggestedBooks.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(txtCopiesAvailable)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(txtPublicationYear)
        TabPage1.Controls.Add(txtBookID)
        TabPage1.Controls.Add(txtisbn)
        TabPage1.Controls.Add(txtSubject)
        TabPage1.Controls.Add(btnAddBook)
        TabPage1.Controls.Add(txtAuthor)
        TabPage1.Controls.Add(btnDeleteBook)
        TabPage1.Controls.Add(txtTitle)
        TabPage1.Controls.Add(dgvViewBooks)
        TabPage1.Controls.Add(txtAddBookID)
        TabPage1.Location = New Point(4, 30)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1481, 593)
        TabPage1.TabIndex = 0
        TabPage1.Text = "ViewBooks"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(1194, 408)
        Label11.Name = "Label11"
        Label11.Size = New Size(123, 21)
        Label11.TabIndex = 8
        Label11.Text = "CopiesAvailable:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(1194, 373)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 21)
        Label10.TabIndex = 8
        Label10.Text = "PublicationYear:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(1194, 338)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 21)
        Label9.TabIndex = 8
        Label9.Text = "ISBN:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(1194, 303)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 21)
        Label8.TabIndex = 8
        Label8.Text = "Subject:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1194, 268)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 21)
        Label7.TabIndex = 8
        Label7.Text = "Author:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1194, 236)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 21)
        Label6.TabIndex = 8
        Label6.Text = "Title:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1194, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 21)
        Label4.TabIndex = 8
        Label4.Text = "NewBookID:"
        ' 
        ' txtCopiesAvailable
        ' 
        txtCopiesAvailable.Location = New Point(1320, 400)
        txtCopiesAvailable.Name = "txtCopiesAvailable"
        txtCopiesAvailable.Size = New Size(139, 29)
        txtCopiesAvailable.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1194, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 21)
        Label5.TabIndex = 6
        Label5.Text = "BookID:"
        ' 
        ' txtPublicationYear
        ' 
        txtPublicationYear.Location = New Point(1320, 365)
        txtPublicationYear.Name = "txtPublicationYear"
        txtPublicationYear.Size = New Size(139, 29)
        txtPublicationYear.TabIndex = 6
        ' 
        ' txtBookID
        ' 
        txtBookID.Location = New Point(1320, 85)
        txtBookID.Name = "txtBookID"
        txtBookID.Size = New Size(139, 29)
        txtBookID.TabIndex = 5
        ' 
        ' txtisbn
        ' 
        txtisbn.Location = New Point(1320, 330)
        txtisbn.Name = "txtisbn"
        txtisbn.Size = New Size(139, 29)
        txtisbn.TabIndex = 5
        ' 
        ' txtSubject
        ' 
        txtSubject.Location = New Point(1320, 295)
        txtSubject.Name = "txtSubject"
        txtSubject.Size = New Size(139, 29)
        txtSubject.TabIndex = 4
        ' 
        ' btnAddBook
        ' 
        btnAddBook.Location = New Point(1348, 435)
        btnAddBook.Name = "btnAddBook"
        btnAddBook.Size = New Size(87, 29)
        btnAddBook.TabIndex = 1
        btnAddBook.Text = "AddBook"
        btnAddBook.UseVisualStyleBackColor = True
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(1320, 260)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(139, 29)
        txtAuthor.TabIndex = 3
        ' 
        ' btnDeleteBook
        ' 
        btnDeleteBook.Location = New Point(1337, 120)
        btnDeleteBook.Name = "btnDeleteBook"
        btnDeleteBook.Size = New Size(98, 37)
        btnDeleteBook.TabIndex = 1
        btnDeleteBook.Text = "Delete"
        btnDeleteBook.UseVisualStyleBackColor = True
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(1320, 225)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(139, 29)
        txtTitle.TabIndex = 2
        ' 
        ' dgvViewBooks
        ' 
        dgvViewBooks.BackgroundColor = SystemColors.ControlLight
        dgvViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvViewBooks.Location = New Point(-4, 1)
        dgvViewBooks.Name = "dgvViewBooks"
        dgvViewBooks.Size = New Size(1192, 589)
        dgvViewBooks.TabIndex = 0
        ' 
        ' txtAddBookID
        ' 
        txtAddBookID.Location = New Point(1320, 191)
        txtAddBookID.Name = "txtAddBookID"
        txtAddBookID.Size = New Size(139, 29)
        txtAddBookID.TabIndex = 1
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage6)
        TabControl1.Font = New Font("Segoe UI", 12F)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1489, 627)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(btnReturn)
        TabPage4.Controls.Add(txtReturnUserID)
        TabPage4.Controls.Add(Label12)
        TabPage4.Controls.Add(txtReturnBookID)
        TabPage4.Controls.Add(Label2)
        TabPage4.Controls.Add(dgvReturnedBooks)
        TabPage4.Location = New Point(4, 30)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1481, 593)
        TabPage4.TabIndex = 3
        TabPage4.Text = "ReturnedBooks"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(1066, 216)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(84, 36)
        btnReturn.TabIndex = 6
        btnReturn.Text = "Returned"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' txtReturnUserID
        ' 
        txtReturnUserID.Location = New Point(1010, 144)
        txtReturnUserID.Name = "txtReturnUserID"
        txtReturnUserID.Size = New Size(201, 29)
        txtReturnUserID.TabIndex = 5
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(951, 152)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 21)
        Label12.TabIndex = 4
        Label12.Text = "UserID:"
        ' 
        ' txtReturnBookID
        ' 
        txtReturnBookID.Location = New Point(1010, 178)
        txtReturnBookID.Name = "txtReturnBookID"
        txtReturnBookID.Size = New Size(201, 29)
        txtReturnBookID.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(950, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 21)
        Label2.TabIndex = 2
        Label2.Text = "BookID:"
        ' 
        ' dgvReturnedBooks
        ' 
        dgvReturnedBooks.BackgroundColor = SystemColors.ControlLight
        dgvReturnedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReturnedBooks.Location = New Point(0, 0)
        dgvReturnedBooks.Name = "dgvReturnedBooks"
        dgvReturnedBooks.Size = New Size(944, 593)
        dgvReturnedBooks.TabIndex = 0
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(Label3)
        TabPage5.Controls.Add(txtManageFinesUserID)
        TabPage5.Controls.Add(btnClear)
        TabPage5.Controls.Add(dgvManageFines)
        TabPage5.Location = New Point(4, 30)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(1481, 593)
        TabPage5.TabIndex = 4
        TabPage5.Text = "ManageFines"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(927, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 21)
        Label3.TabIndex = 3
        Label3.Text = "UserID:"
        ' 
        ' txtManageFinesUserID
        ' 
        txtManageFinesUserID.Location = New Point(997, 126)
        txtManageFinesUserID.Name = "txtManageFinesUserID"
        txtManageFinesUserID.Size = New Size(199, 29)
        txtManageFinesUserID.TabIndex = 2
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1039, 171)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(90, 42)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvManageFines
        ' 
        dgvManageFines.BackgroundColor = SystemColors.ControlLight
        dgvManageFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvManageFines.Location = New Point(-4, 0)
        dgvManageFines.Name = "dgvManageFines"
        dgvManageFines.RightToLeft = RightToLeft.No
        dgvManageFines.Size = New Size(895, 597)
        dgvManageFines.TabIndex = 1
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(Label17)
        TabPage6.Controls.Add(Label16)
        TabPage6.Controls.Add(txtWaitlistUserID)
        TabPage6.Controls.Add(Label15)
        TabPage6.Controls.Add(txtWaitlistBookID)
        TabPage6.Controls.Add(btnRemove)
        TabPage6.Controls.Add(dgvWaitlist)
        TabPage6.Location = New Point(4, 30)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(1481, 593)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Waitlist"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(907, 157)
        Label17.Name = "Label17"
        Label17.Size = New Size(60, 21)
        Label17.TabIndex = 6
        Label17.Text = "BookID"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(684, 157)
        Label16.Name = "Label16"
        Label16.Size = New Size(0, 21)
        Label16.TabIndex = 5
        ' 
        ' txtWaitlistUserID
        ' 
        txtWaitlistUserID.Location = New Point(982, 111)
        txtWaitlistUserID.Name = "txtWaitlistUserID"
        txtWaitlistUserID.Size = New Size(179, 29)
        txtWaitlistUserID.TabIndex = 3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(901, 116)
        Label15.Name = "Label15"
        Label15.Size = New Size(60, 21)
        Label15.TabIndex = 4
        Label15.Text = "UserID:"
        ' 
        ' txtWaitlistBookID
        ' 
        txtWaitlistBookID.Location = New Point(982, 149)
        txtWaitlistBookID.Name = "txtWaitlistBookID"
        txtWaitlistBookID.Size = New Size(179, 29)
        txtWaitlistBookID.TabIndex = 3
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(1014, 178)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(104, 50)
        btnRemove.TabIndex = 1
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' dgvWaitlist
        ' 
        dgvWaitlist.BackgroundColor = SystemColors.ControlLight
        dgvWaitlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvWaitlist.Location = New Point(0, 0)
        dgvWaitlist.Name = "dgvWaitlist"
        dgvWaitlist.Size = New Size(816, 593)
        dgvWaitlist.TabIndex = 0
        ' 
        ' btnGoBack
        ' 
        btnGoBack.Font = New Font("Segoe UI", 14F)
        btnGoBack.Location = New Point(437, 629)
        btnGoBack.Margin = New Padding(4, 3, 4, 3)
        btnGoBack.Name = "btnGoBack"
        btnGoBack.Size = New Size(125, 62)
        btnGoBack.TabIndex = 2
        btnGoBack.Text = "LogOut"
        btnGoBack.UseVisualStyleBackColor = True
        ' 
        ' LibrarianForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1540, 710)
        Controls.Add(btnGoBack)
        Controls.Add(TabControl1)
        Name = "LibrarianForm"
        Text = "LibrarianForm"
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgvSuggestedBooks, ComponentModel.ISupportInitialize).EndInit()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvViewBooks, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        CType(dgvReturnedBooks, ComponentModel.ISupportInitialize).EndInit()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        CType(dgvManageFines, ComponentModel.ISupportInitialize).EndInit()
        TabPage6.ResumeLayout(False)
        TabPage6.PerformLayout()
        CType(dgvWaitlist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnBorrow As Button
    Friend WithEvents txtBorrowBookID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBorrowedBooks As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnDeleteSuggestion As Button
    Friend WithEvents dgvSuggestedBooks As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnDeleteBook As Button
    Friend WithEvents dgvViewBooks As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvReturnedBooks As DataGridView
    Friend WithEvents txtReturnBookID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvManageFines As DataGridView
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents btnRemove As Button
    Friend WithEvents dgvWaitlist As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtManageFinesUserID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAddBookID As TextBox
    Friend WithEvents txtisbn As TextBox
    Friend WithEvents txtPublicationYear As TextBox
    Friend WithEvents txtCopiesAvailable As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReturnUserID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtWaitlistBookID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBorrowUserID As TextBox
    Friend WithEvents txtSuggestedBookTitle As TextBox
    Friend WithEvents txtWaitlistUserID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnGoBack As Button
    Friend WithEvents btnReturn As Button
End Class
