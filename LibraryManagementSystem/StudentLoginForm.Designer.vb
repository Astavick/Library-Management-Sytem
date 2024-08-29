<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentLoginForm
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
        Label1 = New Label()
        txtUserID = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        btnUserLogin = New Button()
        btnRegister = New Button()
        Label3 = New Label()
        Label4 = New Label()
        btnAdmin = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(200, 172)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 25)
        Label1.TabIndex = 0
        Label1.Text = "UserID:"
        ' 
        ' txtUserID
        ' 
        txtUserID.Font = New Font("Segoe UI", 12F)
        txtUserID.Location = New Point(281, 170)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(180, 29)
        txtUserID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(184, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 0
        Label2.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12F)
        txtPassword.Location = New Point(281, 211)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(180, 29)
        txtPassword.TabIndex = 1
        ' 
        ' btnUserLogin
        ' 
        btnUserLogin.Font = New Font("Segoe UI", 14F)
        btnUserLogin.Location = New Point(316, 251)
        btnUserLogin.Name = "btnUserLogin"
        btnUserLogin.Size = New Size(92, 40)
        btnUserLogin.TabIndex = 2
        btnUserLogin.Text = "Login"
        btnUserLogin.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Segoe UI", 14F)
        btnRegister.Location = New Point(315, 365)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(93, 34)
        btnRegister.TabIndex = 2
        btnRegister.Text = "Register Me"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(303, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 37)
        Label3.TabIndex = 3
        Label3.Text = "Welcome"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(243, 330)
        Label4.Name = "Label4"
        Label4.Size = New Size(218, 20)
        Label4.TabIndex = 4
        Label4.Text = "New here? click below to register"
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Font = New Font("Segoe UI", 12F)
        btnAdmin.Location = New Point(623, 34)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(130, 45)
        btnAdmin.TabIndex = 5
        btnAdmin.Text = "Admin?"
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Italic)
        Label5.Location = New Point(663, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 6
        Label5.Text = "Switch User"
        ' 
        ' StudentLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(765, 402)
        Controls.Add(Label5)
        Controls.Add(btnAdmin)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnRegister)
        Controls.Add(btnUserLogin)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtUserID)
        Controls.Add(Label1)
        Name = "StudentLoginForm"
        Text = "StudentLoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnUserLogin As Button
    Friend WithEvents btnRegister As Button

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnUserLogin.Click

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Label5 As Label


End Class
