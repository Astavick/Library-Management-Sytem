Imports System.Data.OleDb

Public Class StudentRegistrationForm
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegisterMe.Click
        If txtUserID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtUserName.Text = "" Or txtPassword.Text = "" Or ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If
        Dim selectedForm As String = ListBox1.SelectedItem.ToString()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Windows\OneDrive\Documents\Database1.accdb"
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO UsersTable ([UserID], [UserType], [FirstName], [LastName], [UserName], [Password], [Form]) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", txtUserID.Text)
                    command.Parameters.AddWithValue("@UserType", "Student")
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    command.Parameters.AddWithValue("@UserName", txtUserName.Text)
                    command.Parameters.AddWithValue("@Password", txtPassword.Text)
                    command.Parameters.AddWithValue("@Form", selectedForm)

                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Registration successful.")
            Me.Close()
        Catch ex As OleDbException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub StudentRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class