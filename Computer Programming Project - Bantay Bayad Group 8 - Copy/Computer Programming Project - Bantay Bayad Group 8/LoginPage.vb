Public Class LoginPage

    ' FORM LOAD
    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide password by default
        txtPassword.UseSystemPasswordChar = True

        ' Uncheck checkbox by default
        chkShowPassword.Checked = False

        ' Hide error label initially
        lblIncorrect.Visible = False
    End Sub

    ' LOGIN BUTTON
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Hide error first
        lblIncorrect.Visible = False

        ' Check empty fields
        If username = "" Or password = "" Then
            lblIncorrect.Text = "Please enter username and password!"
            lblIncorrect.Visible = True
            Exit Sub
        End If

        ' Check credentials
        If username = "Admin" And password = "1234admin" Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open Dashboard
            Dim dashboard As New DashboardPage
            dashboard.Show()

            ' Hide login form
            Me.Hide()

        Else
            lblIncorrect.Text = "Incorrect username or password!"
            lblIncorrect.Visible = True
        End If

    End Sub

    ' SHOW / HIDE PASSWORD
    Private Sub chkShowPassword_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            ' Show password
            txtPassword.UseSystemPasswordChar = False
        Else
            ' Hide password
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class