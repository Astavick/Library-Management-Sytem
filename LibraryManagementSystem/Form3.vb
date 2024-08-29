Imports System.Data.OleDb

Public Class AdminLoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userID As String = txtUserID.Text
        Dim password As String = txtPassword.Text

        If ValidateAdminCredentials(userID, password) Then
            Dim librarianForm As New LibrarianForm()
            librarianForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid UserID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateAdminCredentials(userID As String, password As String) As Boolean
        Dim isValid As Boolean = False

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
        Dim query As String = "SELECT * FROM UsersTable WHERE UserID = ? AND Password = ? AND UserType = 'Admin'"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@Password", password)
                connection.Open()
                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        isValid = True
                    End If
                End Using
            End Using
        End Using

        Return isValid
    End Function
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim studentLoginForm As New StudentLoginForm()
        studentLoginForm.Show()
        Me.Hide()
    End Sub
End Class
