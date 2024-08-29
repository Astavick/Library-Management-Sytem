<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLoginForm
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
        Label2 = New Label()
        txtUserID = New TextBox()
        txtPassword = New TextBox()
        Label3 = New Label()
        btnLogin = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(117, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 25)
        Label1.TabIndex = 0
        Label1.Text = "AdminID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(117, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 0
        Label2.Text = "Password:"
        ' 
        ' txtUserID
        ' 
        txtUserID.Font = New Font("Segoe UI", 11F)
        txtUserID.Location = New Point(218, 143)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(312, 27)
        txtUserID.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.Location = New Point(218, 194)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(312, 27)
        txtPassword.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(258, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(228, 37)
        Label3.TabIndex = 3
        Label3.Text = "Welcome Admin"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 14F)
        btnLogin.Location = New Point(258, 260)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(184, 53)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 14F)
        btnBack.Location = New Point(284, 407)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(114, 31)
        btnBack.TabIndex = 5
        btnBack.Text = "Go back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' AdminLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnLogin)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtUserID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AdminLoginForm"
        Text = "AdminLoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBack As Button
End Class
