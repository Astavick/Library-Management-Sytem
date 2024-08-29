Imports System.Data.OleDb

Public Class StudentLoginForm
    Private Sub btnUserLogin_Click(sender As Object, e As EventArgs) Handles btnUserLogin.Click
        Dim userID As String = txtUserID.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(userID) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both UserID and Password.")
            Return
        End If

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
        Dim query As String = "SELECT COUNT(*) FROM UsersTable WHERE UserID = @UserID AND Password = @Password"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@Password", password)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then

                    Dim studentInterfaceForm As New StudentInterfaceForm(userID)
                    studentInterfaceForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid UserID or Password.")
                End If
            End Using
        End Using
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim registrationForm As New StudentRegistrationForm()
        registrationForm.Show()
    End Sub

    Private Sub StudentLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        MessageBox.Show("Restricted Access: Admin only", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Dim adminLoginForm As New AdminLoginForm()
        adminLoginForm.Show()
        Me.Hide()
    End Sub

End Class

