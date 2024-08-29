<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRegistrationForm
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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtUserID = New TextBox()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtUserName = New TextBox()
        txtPassword = New TextBox()
        btnRegisterMe = New Button()
        Label8 = New Label()
        Label7 = New Label()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(156, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 25)
        Label1.TabIndex = 0
        Label1.Text = "UserID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(152, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 25)
        Label2.TabIndex = 1
        Label2.Text = "FirstName:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F)
        Label3.Location = New Point(152, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 25)
        Label3.TabIndex = 2
        Label3.Text = "SecondName:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.Location = New Point(152, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 25)
        Label4.TabIndex = 3
        Label4.Text = "UserName:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F)
        Label5.Location = New Point(152, 306)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 25)
        Label5.TabIndex = 4
        Label5.Text = "Password:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F)
        Label6.Location = New Point(156, 355)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 25)
        Label6.TabIndex = 5
        Label6.Text = "Form:"
        ' 
        ' txtUserID
        ' 
        txtUserID.Font = New Font("Segoe UI", 11F)
        txtUserID.Location = New Point(285, 100)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(243, 27)
        txtUserID.TabIndex = 7
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 11F)
        txtFirstName.Location = New Point(285, 147)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(243, 27)
        txtFirstName.TabIndex = 7
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 11F)
        txtLastName.Location = New Point(285, 198)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(243, 27)
        txtLastName.TabIndex = 7
        ' 
        ' txtUserName
        ' 
        txtUserName.Font = New Font("Segoe UI", 11F)
        txtUserName.Location = New Point(285, 253)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(243, 27)
        txtUserName.TabIndex = 7
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.Location = New Point(285, 307)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(243, 27)
        txtPassword.TabIndex = 7
        ' 
        ' btnRegisterMe
        ' 
        btnRegisterMe.Font = New Font("Segoe UI", 14F)
        btnRegisterMe.Location = New Point(411, 382)
        btnRegisterMe.Name = "btnRegisterMe"
        btnRegisterMe.Size = New Size(144, 37)
        btnRegisterMe.TabIndex = 8
        btnRegisterMe.Text = "Register Me"
        btnRegisterMe.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(285, 21)
        Label8.Name = "Label8"
        Label8.Size = New Size(221, 32)
        Label8.TabIndex = 10
        Label8.Text = "create an Account"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(286, 65)
        Label7.Name = "Label7"
        Label7.Size = New Size(228, 21)
        Label7.TabIndex = 11
        Label7.Text = "Fill in the following Information"
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 12F)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 21
        ListBox1.Items.AddRange(New Object() {"Form1", "Form2", "Form3", "Form4"})
        ListBox1.Location = New Point(285, 353)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 88)
        ListBox1.TabIndex = 12
        ' 
        ' StudentRegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(867, 529)
        Controls.Add(ListBox1)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(btnRegisterMe)
        Controls.Add(txtPassword)
        Controls.Add(txtUserName)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(txtUserID)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "StudentRegistrationForm"
        Text = "StudentRegistrationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtFirstame As TextBox
    Friend WithEvents txtSecondName As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRegisterMe As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
