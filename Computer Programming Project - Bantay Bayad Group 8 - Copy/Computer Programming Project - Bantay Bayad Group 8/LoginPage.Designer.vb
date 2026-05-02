<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        chkShowPassword = New CheckBox()
        lblIncorrect = New Label()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.BackColor = Color.Black
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(552, 519)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter username"
        txtUsername.Size = New Size(484, 23)
        txtUsername.TabIndex = 16
        txtUsername.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Black
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(552, 627)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter password"
        txtPassword.Size = New Size(484, 23)
        txtPassword.TabIndex = 17
        txtPassword.TabStop = False
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(495, 719)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(18, 17)
        chkShowPassword.TabIndex = 18
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' lblIncorrect
        ' 
        lblIncorrect.AutoSize = True
        lblIncorrect.BackColor = Color.Transparent
        lblIncorrect.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIncorrect.ForeColor = Color.Red
        lblIncorrect.Location = New Point(739, 719)
        lblIncorrect.Name = "lblIncorrect"
        lblIncorrect.Size = New Size(287, 20)
        lblIncorrect.TabIndex = 19
        lblIncorrect.Text = "Incorrect username or password!"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(489, 786)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(555, 69)
        btnLogin.TabIndex = 20
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' LoginPage
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        AutoScrollMinSize = New Size(1536, 1024)
        BackgroundImage = My.Resources.Resources._1__Login_Main
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1382, 953)
        Controls.Add(btnLogin)
        Controls.Add(lblIncorrect)
        Controls.Add(chkShowPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginPage"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents btnLogin As Button
End Class
