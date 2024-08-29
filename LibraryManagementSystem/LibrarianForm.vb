Imports System.Data.OleDb
Imports System.Text
Public Class LibrarianForm
    Private Sub LibrarianForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadViewBooks()
        LoadSuggestedBooks()
        LoadBorrowedBooks()
        LoadReturnedBooks()
        LoadManageFines()
        LoadWaitList()

    End Sub

    Private Sub LoadSuggestedBooks()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT * FROM SuggestedBooksTable"

            Using connection As New OleDbConnection(connectionString)
                Dim adapter As New OleDbDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvSuggestedBooks.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading suggested books: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadBorrowedBooks()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT UserID, BookID, BorrowDate, DueDate FROM BorrowTable WHERE ReturnDate IS NULL"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    connection.Open()
                    Dim adapter As New OleDbDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvBorrowedBooks.DataSource = table
                    dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading borrowed books: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadReturnedBooks()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT * FROM BorrowTable WHERE ReturnDate IS NOT NULL"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    connection.Open()
                    Dim adapter As New OleDbDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvReturnedBooks.DataSource = table
                    dgvReturnedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading returned books: " & ex.Message)
        End Try
    End Sub
    Private Sub AddFine(userID As Integer, bookID As String, fineAmount As Decimal)
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "INSERT INTO FinesTable (UserID, BookID, FineAmount, DateIssued) VALUES (?, ?, ?, ?)"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", userID)
                    command.Parameters.AddWithValue("?", bookID)
                    command.Parameters.AddWithValue("?", fineAmount)
                    command.Parameters.AddWithValue("?", DateTime.Now)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the fine: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadOverdueBooks()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT UserID, BookID, DueDate FROM BorrowTable WHERE ReturnDate IS NULL AND DueDate < @CurrentDate"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.Add("@CurrentDate", OleDbType.Date).Value = DateTime.Now

                    Dim adapter As New OleDbDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        MessageBox.Show("No overdue books found.")
                    Else
                        dgvManageFines.DataSource = table
                        dgvManageFines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading overdue books: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadManageFines()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT UserID, BookID, DueDate FROM BorrowTable WHERE DueDate < ? AND ReturnDate IS NULL"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.Add(New OleDbParameter("?", OleDbType.Date)).Value = DateTime.Now
                    connection.Open()
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim userID As String = reader("UserID").ToString()
                            Dim bookID As String = reader("BookID").ToString()
                            Dim dueDate As DateTime = Convert.ToDateTime(reader("DueDate"))
                            Dim minutesOverdue As Integer = Convert.ToInt32((DateTime.Now - dueDate).TotalMinutes)
                            Dim fineAmount As Decimal = minutesOverdue * 50
                            SaveFine(userID, bookID, fineAmount)
                        End While
                    End Using
                End Using
            End Using
            LoadFinesIntoGrid()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading fines: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveFine(userID As String, bookID As String, fineAmount As Decimal)
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim insertQuery As String = "INSERT INTO FinesTable (UserID, BookID, FineAmount, DateIssued, AlternativeTask) VALUES (?, ?, ?, ?, ?)"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(insertQuery, connection)
                    command.Parameters.Add(New OleDbParameter("?", OleDbType.VarChar)).Value = userID
                    command.Parameters.Add(New OleDbParameter("?", OleDbType.VarChar)).Value = bookID
                    command.Parameters.Add(New OleDbParameter("?", OleDbType.Currency)).Value = fineAmount
                    command.Parameters.Add(New OleDbParameter("?", OleDbType.Date)).Value = DateTime.Now
                    command.Parameters.Add(New OleDbParameter("?", OleDbType.VarChar)).Value = DBNull.Value
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving fines: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadFinesIntoGrid()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT UserID, BookID, FineAmount, DateIssued, AlternativeTask FROM FinesTable WHERE FineAmount > 0"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    Dim adapter As New OleDbDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        MessageBox.Show("No fines to display.")
                    End If

                    dgvManageFines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvManageFines.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading manage fines: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadWaitList()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT WaitlistID, UserID, BookID FROM WaitlistTable"
            Using connection As New OleDbConnection(connectionString)
                Dim adapter As New OleDbDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvWaitlist.DataSource = table
                dgvWaitlist.Columns("WaitlistID").HeaderText = "Waitlist ID"
                dgvWaitlist.Columns("UserID").HeaderText = "User ID"
                dgvWaitlist.Columns("BookID").HeaderText = "Book ID"
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading waitlist: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDeleteSuggestion_Click(sender As Object, e As EventArgs) Handles btnDeleteSuggestion.Click
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "DELETE FROM SuggestedBooksTable WHERE BookTitle = ?"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", txtSuggestedBookTitle.Text)
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Suggested book deleted successfully!")
                    Else
                        MessageBox.Show("No matching book found to delete.")
                    End If
                End Using
            End Using
            LoadSuggestedBooks()
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the suggested book: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "INSERT INTO BooksTable (BookID, Title, Author, Subject, ISBN, PublicationYear, CopiesAvailable) VALUES (?, ?, ?, ?, ?, ?, ?)"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@BookID", txtAddBookID.Text)
                    command.Parameters.AddWithValue("@Title", txtTitle.Text)
                    command.Parameters.AddWithValue("@Author", txtAuthor.Text)
                    command.Parameters.AddWithValue("@Subject", txtSubject.Text)
                    command.Parameters.AddWithValue("@ISBN", txtisbn.Text)
                    command.Parameters.AddWithValue("@PublicationYear", txtPublicationYear.Text)
                    command.Parameters.AddWithValue("@CopiesAvailable", txtCopiesAvailable.Text)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Book added successfully!")
            LoadViewBooks()
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the book: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadViewBooks()
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "SELECT BookID, Title, Author, Subject, ISBN, PublicationYear, CopiesAvailable FROM BooksTable"

            Using connection As New OleDbConnection(connectionString)
                Dim adapter As New OleDbDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvViewBooks.DataSource = table
                dgvViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading view books: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Try
            MessageBox.Show($"UserID: {txtBorrowUserID.Text}, BookID: {txtBorrowBookID.Text}, BorrowDate: {DateTime.Now}, DueDate: {DateTime.Now.AddDays(3)}")
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "INSERT INTO BorrowTable (UserID, BookID, BorrowDate, DueDate) VALUES (?, ?, ?, ?)"
            Dim updateCopiesQuery As String = "UPDATE BooksTable SET CopiesAvailable = CopiesAvailable - 1 WHERE BookID = ?"

            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.Clear()
                    command.Parameters.Add("@UserID", OleDbType.VarChar).Value = txtBorrowUserID.Text
                    command.Parameters.Add("@BookID", OleDbType.VarChar).Value = txtBorrowBookID.Text
                    command.Parameters.Add("@BorrowDate", OleDbType.Date).Value = DateTime.Now
                    command.Parameters.Add("@DueDate", OleDbType.Date).Value = DateTime.Now.AddMinutes(1)
                    command.ExecuteNonQuery()
                End Using
                Using updateCommand As New OleDbCommand(updateCopiesQuery, connection)
                    updateCommand.Parameters.Clear()
                    updateCommand.Parameters.Add("@BookID", OleDbType.VarChar).Value = txtBorrowBookID.Text
                    updateCommand.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Book borrowed successfully!")
            LoadBorrowedBooks()
            LoadViewBooks()
        Catch ex As Exception
            MessageBox.Show("An error occurred while borrowing the book: " & ex.Message)
        End Try
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            MessageBox.Show($"UserID: {txtReturnUserID.Text}, BookID: {txtReturnBookID.Text}")

            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim returnQuery As String = "UPDATE BorrowTable SET ReturnDate = @ReturnDate WHERE UserID = @UserID AND BookID = @BookID AND ReturnDate IS NULL"
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Using command As New OleDbCommand(returnQuery, connection)
                    command.Parameters.Clear()
                    command.Parameters.Add("@ReturnDate", OleDbType.Date).Value = DateTime.Now
                    command.Parameters.Add("@UserID", OleDbType.VarChar).Value = txtReturnUserID.Text.Trim()
                    command.Parameters.Add("@BookID", OleDbType.VarChar).Value = txtReturnBookID.Text.Trim()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        UpdateAvailableCopies(txtReturnBookID.Text.Trim())
                        MessageBox.Show("Book returned successfully!")
                    Else
                        MessageBox.Show("No matching record found to update. Please check the UserID and BookID.")
                    End If
                End Using
            End Using
            LoadBorrowedBooks()
            LoadReturnedBooks()
            LoadViewBooks()
        Catch ex As Exception
            MessageBox.Show("An error occurred while returning the book: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateAvailableCopies(bookID As String)
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "UPDATE BooksTable SET CopiesAvailable = CopiesAvailable + 1 WHERE BookID = @BookID"
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@BookID", bookID)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating available copies: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "DELETE FROM BooksTable WHERE BookID = ?"
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@BookID", txtBookID.Text)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Book deleted successfully!")
            LoadViewBooks()
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the book: " & ex.Message)
        End Try
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim removeQuery As String = "DELETE FROM WaitlistTable WHERE UserID = ? AND BookID = ?"
            Dim updateCopiesQuery As String = "UPDATE BooksTable SET CopiesAvailable = CopiesAvailable + 1 WHERE BookID = ?"
            Dim bookID As String = txtWaitlistBookID.Text.Trim()
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Using removeCommand As New OleDbCommand(removeQuery, connection)
                    removeCommand.Parameters.AddWithValue("@UserID", txtWaitlistUserID.Text.Trim())
                    removeCommand.Parameters.AddWithValue("@BookID", bookID)
                    removeCommand.ExecuteNonQuery()
                End Using
                Using updateCommand As New OleDbCommand(updateCopiesQuery, connection)
                    updateCommand.Parameters.AddWithValue("@BookID", bookID)
                    updateCommand.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("User removed from waitlist and book availability updated successfully!")
            LoadWaitList()
            LoadViewBooks()
        Catch ex As Exception
            MessageBox.Show("An error occurred while removing user from waitlist: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            Dim userID As String = txtManageFinesUserID.Text.Trim()
            ClearFines(userID)
            MessageBox.Show("Fine cleared successfully!")
            LoadManageFines()
        Catch ex As OleDbException
            MessageBox.Show("An error occurred while clearing the fine: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearFines(userID As String)
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "DELETE FROM FinesTable WHERE UserID = @UserID"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadFinesData()
            MessageBox.Show("Fines cleared successfully!")

        Catch ex As OleDbException
            MessageBox.Show("An error occurred while clearing the fine: " & ex.Message)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadFinesData()
    End Sub
    Private Sub dgvBorrowedBooks_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBorrowedBooks.SelectionChanged
        If dgvBorrowedBooks.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvBorrowedBooks.SelectedRows(0)
            txtReturnUserID.Text = selectedRow.Cells("UserID").Value.ToString().Trim()
            txtReturnBookID.Text = selectedRow.Cells("BookID").Value.ToString().Trim()
        End If
    End Sub
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Dim mainForm As New StudentLoginForm()
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub AddFine(userID As String, fineAmount As Decimal)
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
            Dim query As String = "INSERT INTO FinesTable (UserID, FineAmount) VALUES (@UserID, @FineAmount)"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)
                    command.Parameters.AddWithValue("@FineAmount", fineAmount)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadManageFines()
            MessageBox.Show("Fine added successfully!")

        Catch ex As OleDbException
            MessageBox.Show("An error occurred while adding the fine: " & ex.Message)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class

