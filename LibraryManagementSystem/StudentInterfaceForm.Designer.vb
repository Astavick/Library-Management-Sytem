<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentInterfaceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        dgvBooks = New DataGridView()
        TabPage2 = New TabPage()
        dgvBorrowedBooks = New DataGridView()
        TabPage4 = New TabPage()
        txtCheckBookID = New TextBox()
        Label5 = New Label()
        btnCheck = New Button()
        dgvWaitlist = New DataGridView()
        TabPage5 = New TabPage()
        Label3 = New Label()
        txtBookTitle = New TextBox()
        btnCheckS = New Button()
        btnSuggest = New Button()
        Label2 = New Label()
        Label1 = New Label()
        TabPage3 = New TabPage()
        Label4 = New Label()
        btnCash = New Button()
        btnDoIt = New Button()
        ListBox1 = New ListBox()
        Label7 = New Label()
        dgvFines = New DataGridView()
        btnGoBack = New Button()
        NotifyIcon = New NotifyIcon(components)
        notificationTimer = New Timer(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        CType(dgvWaitlist, ComponentModel.ISupportInitialize).BeginInit()
        TabPage5.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(dgvFines, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI", 12F)
        TabControl1.Location = New Point(1, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1236, 593)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(dgvBooks)
        TabPage1.Location = New Point(4, 30)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1228, 559)
        TabPage1.TabIndex = 0
        TabPage1.Text = "ViewBooks"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' dgvBooks
        ' 
        dgvBooks.BackgroundColor = SystemColors.ControlLight
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Location = New Point(0, 0)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.Size = New Size(1224, 559)
        dgvBooks.TabIndex = 2
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgvBorrowedBooks)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1263, 559)
        TabPage2.TabIndex = 1
        TabPage2.Text = "BorrowedBooks"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgvBorrowedBooks
        ' 
        dgvBorrowedBooks.BackgroundColor = SystemColors.ControlLight
        dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowedBooks.Location = New Point(3, 0)
        dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        dgvBorrowedBooks.Size = New Size(722, 559)
        dgvBorrowedBooks.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(txtCheckBookID)
        TabPage4.Controls.Add(Label5)
        TabPage4.Controls.Add(btnCheck)
        TabPage4.Controls.Add(dgvWaitlist)
        TabPage4.Location = New Point(4, 30)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1263, 559)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Waitlist"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' txtCheckBookID
        ' 
        txtCheckBookID.Font = New Font("Segoe UI", 11F)
        txtCheckBookID.Location = New Point(756, 110)
        txtCheckBookID.Name = "txtCheckBookID"
        txtCheckBookID.Size = New Size(195, 27)
        txtCheckBookID.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(691, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 21)
        Label5.TabIndex = 18
        Label5.Text = "BookID"
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(783, 168)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(124, 41)
        btnCheck.TabIndex = 1
        btnCheck.Text = "Check"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' dgvWaitlist
        ' 
        dgvWaitlist.BackgroundColor = SystemColors.ControlLight
        dgvWaitlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvWaitlist.Location = New Point(0, 0)
        dgvWaitlist.Name = "dgvWaitlist"
        dgvWaitlist.Size = New Size(685, 563)
        dgvWaitlist.TabIndex = 0
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(Label3)
        TabPage5.Controls.Add(txtBookTitle)
        TabPage5.Controls.Add(btnCheckS)
        TabPage5.Controls.Add(btnSuggest)
        TabPage5.Controls.Add(Label2)
        TabPage5.Controls.Add(Label1)
        TabPage5.Location = New Point(4, 30)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(1263, 559)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Suggestions"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(122, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 21)
        Label3.TabIndex = 6
        Label3.Text = "BookTitle:"
        ' 
        ' txtBookTitle
        ' 
        txtBookTitle.Location = New Point(199, 114)
        txtBookTitle.Multiline = True
        txtBookTitle.Name = "txtBookTitle"
        txtBookTitle.Size = New Size(200, 122)
        txtBookTitle.TabIndex = 5
        ' 
        ' btnCheckS
        ' 
        btnCheckS.Location = New Point(297, 242)
        btnCheckS.Name = "btnCheckS"
        btnCheckS.Size = New Size(92, 33)
        btnCheckS.TabIndex = 4
        btnCheckS.Text = "Check"
        btnCheckS.UseVisualStyleBackColor = True
        ' 
        ' btnSuggest
        ' 
        btnSuggest.Location = New Point(199, 242)
        btnSuggest.Name = "btnSuggest"
        btnSuggest.Size = New Size(83, 33)
        btnSuggest.TabIndex = 3
        btnSuggest.Text = "Suggest"
        btnSuggest.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(187, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(223, 21)
        Label2.TabIndex = 2
        Label2.Text = "Please leave a sugestion below"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(131, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 37)
        Label1.TabIndex = 1
        Label1.Text = "What book should we add?"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Label4)
        TabPage3.Controls.Add(btnCash)
        TabPage3.Controls.Add(btnDoIt)
        TabPage3.Controls.Add(ListBox1)
        TabPage3.Controls.Add(Label7)
        TabPage3.Controls.Add(dgvFines)
        TabPage3.Location = New Point(4, 30)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1263, 559)
        TabPage3.TabIndex = 6
        TabPage3.Text = "Fines"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(747, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 21)
        Label4.TabIndex = 5
        Label4.Text = "Or"
        ' 
        ' btnCash
        ' 
        btnCash.Location = New Point(628, 125)
        btnCash.Name = "btnCash"
        btnCash.Size = New Size(86, 45)
        btnCash.TabIndex = 4
        btnCash.Text = "Pay Cash"
        btnCash.UseVisualStyleBackColor = True
        ' 
        ' btnDoIt
        ' 
        btnDoIt.Location = New Point(818, 125)
        btnDoIt.Name = "btnDoIt"
        btnDoIt.Size = New Size(92, 45)
        btnDoIt.TabIndex = 3
        btnDoIt.Text = "Do It"
        btnDoIt.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 21
        ListBox1.Items.AddRange(New Object() {"Participate in Library events", "Wash classes", "Wash Dorms", "Wash Toilets", "CLean Compound & Recycle"})
        ListBox1.Location = New Point(781, 55)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(169, 46)
        ListBox1.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(596, 65)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 21)
        Label7.TabIndex = 1
        Label7.Text = "Choose alternative Fines"
        ' 
        ' dgvFines
        ' 
        dgvFines.BackgroundColor = SystemColors.ControlLight
        dgvFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFines.Location = New Point(0, -2)
        dgvFines.Name = "dgvFines"
        dgvFines.Size = New Size(590, 561)
        dgvFines.TabIndex = 0
        ' 
        ' btnGoBack
        ' 
        btnGoBack.Font = New Font("Segoe UI", 12F)
        btnGoBack.Location = New Point(246, 599)
        btnGoBack.Name = "btnGoBack"
        btnGoBack.Size = New Size(128, 47)
        btnGoBack.TabIndex = 4
        btnGoBack.Text = "LogOut"
        btnGoBack.UseVisualStyleBackColor = True
        ' 
        ' NotifyIcon
        ' 
        NotifyIcon.Text = "NotifyIcon1"
        NotifyIcon.Visible = True
        ' 
        ' notificationTimer
        ' 
        notificationTimer.Enabled = True
        notificationTimer.Interval = 60000
        ' 
        ' StudentInterfaceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1332, 658)
        Controls.Add(btnGoBack)
        Controls.Add(TabControl1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "StudentInterfaceForm"
        Text = "Student Interface"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        CType(dgvWaitlist, ComponentModel.ISupportInitialize).EndInit()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(dgvFines, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents dgvBorrowedBooks As DataGridView
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBorrowBookID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCheckBookID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvWaitlist As DataGridView
    Friend WithEvents btnSuggest As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents btnCheckS As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvFines As DataGridView
    Friend WithEvents btnDoIt As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents notificationTimer As Timer
    Friend WithEvents btnGoBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCash As Button

End Class

