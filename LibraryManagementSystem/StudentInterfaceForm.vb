Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class StudentInterfaceForm
    Public Property UserID As String
    Public Sub New(ByVal userID As String)
        InitializeComponent()
        Me.UserID = userID
        notificationTimer.Interval = 15000
        notificationTimer.Enabled = True
        NotifyIcon.Visible = True
        NotifyIcon.Icon = SystemIcons.Information
        dgvBooks.Columns.Add("BookIDColumn", "Book ID")
        dgvBooks.Columns.Add("BookTitleColumn", "Book Title")
        dgvBooks.Columns.Add("AuthorColumn", "Author")
        dgvBooks.Columns.Add("SubjectColumn", "Subject")
        dgvBooks.Columns.Add("ISBNColumn", "ISBN")
        dgvBooks.Columns.Add("PublicationYearColumn", "PublicationYear")
        dgvBooks.Columns.Add("AvailabilityColumn", "Availability")
        dgvBorrowedBooks.Columns.Add("BookIDColumn", "Book ID")
        dgvBorrowedBooks.Columns.Add("BorrowDateColumn", "Borrow Date")
        dgvBorrowedBooks.Columns.Add("DueDateColumn", "Due Date")
        dgvBorrowedBooks.Columns.Add("ReturnDateColumn", "Return Date")
        dgvFines.Columns.Add("FineID", "Fine ID")
        dgvFines.Columns.Add("BookID", "Book ID")
        dgvFines.Columns.Add("FineAmount", "Fine Amount")
        dgvFines.Columns.Add("DateReturned", "Date Returned")
        dgvWaitlist.Columns.Clear()
        dgvWaitlist.Columns.Add("WaitlistIDColumn", "Waitlist ID")
        dgvWaitlist.Columns.Add("UserIDColumn", "User ID")
        dgvWaitlist.Columns.Add("BookIDColumn", "Book ID")
    End Sub
    Private Sub StudentInterfaceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadViewBooksData()
        LoadBorrowedBooksData()
        LoadBFinesData()
        LoadWaitlistData()
        notificationTimer.Start()
    End Sub
    Private Sub notificationTimer_Tick(sender As Object, e As EventArgs) Handles notificationTimer.Tick
        CheckNotifications()
    End Sub
    Private Sub CheckNotifications()
        CheckFines()
        CheckWaitlist()
        CheckSuggestions()
        CheckDueDate()
    End Sub
    Private Sub CheckFines()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT COUNT(*) FROM FinesTable WHERE UserID = @UserID AND FineAmount > 0"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", UserID)
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then
                        NotifyIcon.ShowBalloonTip(3000, "Library Notification", "You have fines to pay.", ToolTipIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while checking fines: " & ex.Message)
        End Try
    End Sub
    Private Sub CheckWaitlist()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT COUNT(*) FROM WaitlistTable WHERE UserID = @UserID"
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", UserID)
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If count = 0 Then
                        NotifyIcon.ShowBalloonTip(3000, "Library Notification", "Your book is now available.", ToolTipIcon.Info)
                    End If
                End Using
            End Using
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while checking the waitlist: " & ex.Message)
        End Try
    End Sub
    Private Sub CheckSuggestions()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT COUNT(*) FROM SuggestedBooksTable WHERE UserID = ?"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", UserID)
                    connection.Open()

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count = 0 Then
                        NotifyIcon.ShowBalloonTip(3000, "Library Notification", "Your suggested book has been bought.", ToolTipIcon.Info)
                    End If
                End Using
            End Using
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while checking suggested books: " & ex.Message)
        End Try
    End Sub
    Private Sub CheckDueDate()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT COUNT(*) FROM BorrowTable WHERE UserID = ? AND DueDate <= ? AND ReturnDate IS NULL"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", UserID)
                    command.Parameters.Add(New OleDbParameter("?", OleDbType.Date)).Value = DateTime.Now
                    connection.Open()

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then
                        NotifyIcon.ShowBalloonTip(3000, "Library Notification", "You have books due soon. Please return them.", ToolTipIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while checking due dates: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadViewBooksData()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT BookID, Title, Author, Subject, ISBN, PublicationYear, CopiesAvailable FROM BooksTable ORDER BY Title ASC"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    connection.Open()
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        dgvBooks.Rows.Clear()

                        While reader.Read()
                            dgvBooks.Rows.Add(reader("BookID"), reader("Title"), reader("Author"), reader("Subject"), reader("ISBN"), reader("PublicationYear"), reader("CopiesAvailable"))
                        End While
                    End Using
                End Using
            End Using
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As OleDbException
            MessageBox.Show("An error occurred while loading view books: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadBorrowedBooksData()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT BookID, BorrowDate, DueDate, ReturnDate FROM BorrowTable WHERE UserID = @UserID"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", UserID)
                    connection.Open()
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        dgvBorrowedBooks.Rows.Clear()
                        While reader.Read()
                            dgvBorrowedBooks.Rows.Add(reader("BookID"), reader("BorrowDate"), reader("DueDate"), If(IsDBNull(reader("ReturnDate")), Nothing, reader("ReturnDate")))
                        End While
                    End Using
                End Using
            End Using
            dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while loading borrowed books: " & ex.Message)
        End Try
    End Sub
    Public Sub LoadBFinesData()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT FineID, FineAmount FROM FinesTable WHERE UserID = @UserID"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", Me.UserID)
                    connection.Open()
                    Dim table As New DataTable()
                    Using adapter As New OleDbDataAdapter(command)
                        adapter.Fill(table)
                    End Using
                    dgvFines.Columns.Clear()
                    dgvFines.DataSource = table
                    dgvFines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    For Each column As DataGridViewColumn In dgvFines.Columns
                        If column.Name <> "FineID" AndAlso column.Name <> "FineAmount" Then
                            column.Visible = False
                        End If
                    Next
                End Using
            End Using
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while loading fines: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message)
        End Try
    End Sub
    Public Sub LoadWaitlistData()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT WaitlistID, UserID, BookID FROM WaitlistTable WHERE UserID = @UserID"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", UserID)
                    connection.Open()
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        dgvWaitlist.Rows.Clear()
                        While reader.Read()
                            dgvWaitlist.Rows.Add(reader("WaitlistID"), reader("UserID"), reader("BookID"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while loading waitlist data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnSuggest_Click(sender As Object, e As EventArgs) Handles btnSuggest.Click
        Try
            Dim bookTitle As String = txtBookTitle.Text.Trim()
            If String.IsNullOrEmpty(bookTitle) Then
                MessageBox.Show("Please enter a book title.")
                Return
            End If
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "INSERT INTO SuggestedBooksTable (UserID, BookTitle) VALUES (@UserID, @BookTitle)"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", UserID)
                    command.Parameters.AddWithValue("@BookTitle", bookTitle)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Book suggestion recorded successfully!")
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while recording the book suggestion: " & ex.Message)
        End Try
    End Sub
    Private Sub btnCheckS_Click(sender As Object, e As EventArgs) Handles btnCheckS.Click
        Try
            Dim bookTitle As String = txtBookTitle.Text.Trim()
            If String.IsNullOrEmpty(bookTitle) Then
                MessageBox.Show("Please enter a book title.")
                Return
            End If
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT COUNT(*) FROM BooksTable WHERE Title = @BookTitle"
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@BookTitle", bookTitle)
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("The book is available. You can borrow it.")
                    Else
                        MessageBox.Show("The book hasn't been bought yet.")
                    End If
                End Using
            End Using
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while checking the book: " & ex.Message)
        End Try
    End Sub
    Private Sub AddToWaitlist()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "INSERT INTO WaitlistTable (UserID, BookID) VALUES (@UserID, @BookID)"
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", UserID)
                    command.Parameters.AddWithValue("@BookID", txtCheckBookID.Text.Trim())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("The book is not available right now. You have been added to the waitlist.")
            LoadWaitlistData()
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding to the waitlist: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDoIt_Click(sender As Object, e As EventArgs) Handles btnDoIt.Click
        Try

            If ListBox1.SelectedIndex = -1 Then
                MessageBox.Show("Please select an alternative task from the list.")
                Exit Sub
            End If


            Dim selectedTask As String = ListBox1.SelectedItem.ToString()

            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "UPDATE FinesTable SET AlternativeTask = @AlternativeTask WHERE UserID = @UserID"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@AlternativeTask", selectedTask)
                    command.Parameters.AddWithValue("@UserID", UserID)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Alternative task selected successfully!")
            LoadBFinesData()
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while selecting alternative task: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
    End Sub
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Dim mainForm As New StudentLoginForm()
        mainForm.Show()
        Me.Close()
    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT CopiesAvailable FROM BooksTable WHERE BookID = @BookID"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@BookID", txtCheckBookID.Text.Trim())
                    connection.Open()
                    Dim copiesAvailable As Integer = 0
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            copiesAvailable = reader("CopiesAvailable")
                        End If
                    End Using
                    If copiesAvailable > 0 Then
                        MessageBox.Show("The book is available. Please proceed to borrow it.")
                    Else
                        AddToWaitlist()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking book availability: " & ex.Message)
        End Try
    End Sub
    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT FineAmount FROM FinesTable WHERE UserID = @UserID"

            Dim fineAmount As Decimal

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", UserID)

                    connection.Open()
                    Dim result = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Decimal.TryParse(result.ToString(), fineAmount) Then
                        MessageBox.Show($"Please pay the fine amount of Ksh {fineAmount:N2} to the librarian.")
                    Else
                        MessageBox.Show("No fine amount found for the current user.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class


