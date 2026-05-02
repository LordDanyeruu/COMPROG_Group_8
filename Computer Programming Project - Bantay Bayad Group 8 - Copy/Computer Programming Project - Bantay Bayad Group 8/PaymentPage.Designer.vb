<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentPage
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
        DataGridViewPayment = New DataGridView()
        CustomerName = New DataGridViewTextBoxColumn()
        CustomerID = New DataGridViewTextBoxColumn()
        PaymentAmount = New DataGridViewTextBoxColumn()
        TransactionDate = New DataGridViewTextBoxColumn()
        TransactionID = New DataGridViewTextBoxColumn()
        Delete = New DataGridViewButtonColumn()
        btnTransaction = New Button()
        DateTimePicker = New DateTimePicker()
        txtAmount = New TextBox()
        btnPayment = New Button()
        btnLoan = New Button()
        btnDashboard = New Button()
        btnLogout = New Button()
        txtCustomerName = New TextBox()
        CType(DataGridViewPayment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewPayment
        ' 
        DataGridViewPayment.AllowUserToOrderColumns = True
        DataGridViewPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPayment.Columns.AddRange(New DataGridViewColumn() {CustomerName, CustomerID, PaymentAmount, TransactionDate, TransactionID, Delete})
        DataGridViewPayment.Location = New Point(303, 431)
        DataGridViewPayment.Name = "DataGridViewPayment"
        DataGridViewPayment.RowHeadersWidth = 51
        DataGridViewPayment.ScrollBars = ScrollBars.Vertical
        DataGridViewPayment.Size = New Size(1196, 507)
        DataGridViewPayment.TabIndex = 31
        ' 
        ' CustomerName
        ' 
        CustomerName.HeaderText = "Costumer Name"
        CustomerName.MinimumWidth = 6
        CustomerName.Name = "CustomerName"
        CustomerName.Width = 125
        ' 
        ' CustomerID
        ' 
        CustomerID.HeaderText = "Customer ID"
        CustomerID.MinimumWidth = 6
        CustomerID.Name = "CustomerID"
        CustomerID.Width = 125
        ' 
        ' PaymentAmount
        ' 
        PaymentAmount.HeaderText = "Payment Amount"
        PaymentAmount.MinimumWidth = 6
        PaymentAmount.Name = "PaymentAmount"
        PaymentAmount.Width = 125
        ' 
        ' TransactionDate
        ' 
        TransactionDate.HeaderText = "Date"
        TransactionDate.MinimumWidth = 6
        TransactionDate.Name = "TransactionDate"
        TransactionDate.Width = 125
        ' 
        ' TransactionID
        ' 
        TransactionID.HeaderText = "Transaction ID"
        TransactionID.MinimumWidth = 6
        TransactionID.Name = "TransactionID"
        TransactionID.Width = 125
        ' 
        ' Delete
        ' 
        Delete.HeaderText = "Delete"
        Delete.MinimumWidth = 6
        Delete.Name = "Delete"
        Delete.Width = 125
        ' 
        ' btnTransaction
        ' 
        btnTransaction.BackColor = Color.Transparent
        btnTransaction.FlatAppearance.BorderSize = 0
        btnTransaction.FlatStyle = FlatStyle.Flat
        btnTransaction.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTransaction.ForeColor = Color.White
        btnTransaction.Location = New Point(1262, 243)
        btnTransaction.Margin = New Padding(8, 6, 8, 6)
        btnTransaction.Name = "btnTransaction"
        btnTransaction.Size = New Size(215, 52)
        btnTransaction.TabIndex = 30
        btnTransaction.Text = "Add Transaction"
        btnTransaction.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Format = DateTimePickerFormat.Short
        DateTimePicker.Location = New Point(970, 255)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(242, 27)
        DateTimePicker.TabIndex = 29
        ' 
        ' txtAmount
        ' 
        txtAmount.BackColor = Color.Black
        txtAmount.BorderStyle = BorderStyle.None
        txtAmount.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAmount.ForeColor = Color.White
        txtAmount.Location = New Point(655, 255)
        txtAmount.Name = "txtAmount"
        txtAmount.PlaceholderText = "Type loan amount"
        txtAmount.Size = New Size(259, 23)
        txtAmount.TabIndex = 28
        ' 
        ' btnPayment
        ' 
        btnPayment.BackColor = Color.Transparent
        btnPayment.FlatAppearance.BorderSize = 0
        btnPayment.FlatStyle = FlatStyle.Flat
        btnPayment.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPayment.ForeColor = Color.White
        btnPayment.Location = New Point(17, 353)
        btnPayment.Margin = New Padding(8, 6, 8, 6)
        btnPayment.Name = "btnPayment"
        btnPayment.Size = New Size(206, 74)
        btnPayment.TabIndex = 26
        btnPayment.Text = "Payment"
        btnPayment.TextAlign = ContentAlignment.MiddleRight
        btnPayment.UseVisualStyleBackColor = False
        ' 
        ' btnLoan
        ' 
        btnLoan.BackColor = Color.Transparent
        btnLoan.FlatAppearance.BorderSize = 0
        btnLoan.FlatStyle = FlatStyle.Flat
        btnLoan.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoan.ForeColor = Color.White
        btnLoan.Location = New Point(22, 245)
        btnLoan.Margin = New Padding(8, 6, 8, 6)
        btnLoan.Name = "btnLoan"
        btnLoan.Size = New Size(206, 74)
        btnLoan.TabIndex = 25
        btnLoan.Text = "Loan"
        btnLoan.TextAlign = ContentAlignment.MiddleRight
        btnLoan.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(22, 150)
        btnDashboard.Margin = New Padding(8, 6, 8, 6)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(206, 74)
        btnDashboard.TabIndex = 24
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleRight
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(22, 869)
        btnLogout.Margin = New Padding(8, 6, 8, 6)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(206, 97)
        btnLogout.TabIndex = 32
        btnLogout.TextAlign = ContentAlignment.MiddleRight
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.BackColor = Color.Black
        txtCustomerName.BorderStyle = BorderStyle.None
        txtCustomerName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCustomerName.ForeColor = Color.White
        txtCustomerName.Location = New Point(335, 257)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.PlaceholderText = "Type customer name"
        txtCustomerName.Size = New Size(259, 23)
        txtCustomerName.TabIndex = 33
        ' 
        ' PaymentPage
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        AutoScrollMinSize = New Size(1536, 1024)
        BackgroundImage = My.Resources.Resources._1_Payment_Main
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1518, 977)
        Controls.Add(txtCustomerName)
        Controls.Add(DataGridViewPayment)
        Controls.Add(btnTransaction)
        Controls.Add(DateTimePicker)
        Controls.Add(txtAmount)
        Controls.Add(btnPayment)
        Controls.Add(btnLoan)
        Controls.Add(btnDashboard)
        Controls.Add(btnLogout)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MinimizeBox = False
        Name = "PaymentPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        WindowState = FormWindowState.Maximized
        CType(DataGridViewPayment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridViewPayment As DataGridView
    Friend WithEvents btnTransaction As Button
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents PaymentAmount As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents TransactionID As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents txtCustomerName As TextBox
End Class
