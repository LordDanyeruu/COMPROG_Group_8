<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanPage
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
        btnPayment = New Button()
        btnLoan = New Button()
        btnDashboard = New Button()
        txtAmount = New TextBox()
        DateTimePicker = New DateTimePicker()
        btnAddTransaction = New Button()
        DataGridViewLoan = New DataGridView()
        CustomerName = New DataGridViewTextBoxColumn()
        CustomerID = New DataGridViewTextBoxColumn()
        LoanAmount = New DataGridViewTextBoxColumn()
        TransactionDate = New DataGridViewTextBoxColumn()
        TransactionID = New DataGridViewTextBoxColumn()
        Delete = New DataGridViewButtonColumn()
        btnLogout = New Button()
        txtCustomerName = New TextBox()
        CType(DataGridViewLoan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPayment
        ' 
        btnPayment.BackColor = Color.Transparent
        btnPayment.FlatAppearance.BorderSize = 0
        btnPayment.FlatStyle = FlatStyle.Flat
        btnPayment.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPayment.ForeColor = Color.White
        btnPayment.Location = New Point(17, 351)
        btnPayment.Margin = New Padding(8, 6, 8, 6)
        btnPayment.Name = "btnPayment"
        btnPayment.Size = New Size(206, 74)
        btnPayment.TabIndex = 9
        btnPayment.Text = "Payment"
        btnPayment.TextAlign = ContentAlignment.MiddleRight
        btnPayment.UseVisualStyleBackColor = False
        ' 
        ' btnLoan
        ' 
        btnLoan.BackColor = Color.Transparent
        btnLoan.FlatAppearance.BorderSize = 0
        btnLoan.FlatStyle = FlatStyle.Flat
        btnLoan.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoan.ForeColor = Color.White
        btnLoan.Location = New Point(17, 247)
        btnLoan.Margin = New Padding(8, 6, 8, 6)
        btnLoan.Name = "btnLoan"
        btnLoan.Size = New Size(206, 74)
        btnLoan.TabIndex = 8
        btnLoan.Text = "Loan"
        btnLoan.TextAlign = ContentAlignment.MiddleRight
        btnLoan.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(17, 161)
        btnDashboard.Margin = New Padding(8, 6, 8, 6)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(206, 74)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleRight
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' txtAmount
        ' 
        txtAmount.BackColor = Color.Black
        txtAmount.BorderStyle = BorderStyle.None
        txtAmount.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAmount.ForeColor = Color.White
        txtAmount.Location = New Point(657, 254)
        txtAmount.Name = "txtAmount"
        txtAmount.PlaceholderText = "Type loan amount"
        txtAmount.Size = New Size(259, 25)
        txtAmount.TabIndex = 14
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Format = DateTimePickerFormat.Short
        DateTimePicker.Location = New Point(976, 256)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(242, 27)
        DateTimePicker.TabIndex = 15
        ' 
        ' btnAddTransaction
        ' 
        btnAddTransaction.BackColor = Color.Transparent
        btnAddTransaction.FlatAppearance.BorderSize = 0
        btnAddTransaction.FlatStyle = FlatStyle.Flat
        btnAddTransaction.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddTransaction.ForeColor = Color.White
        btnAddTransaction.Location = New Point(1263, 244)
        btnAddTransaction.Margin = New Padding(8, 6, 8, 6)
        btnAddTransaction.Name = "btnAddTransaction"
        btnAddTransaction.Size = New Size(215, 52)
        btnAddTransaction.TabIndex = 16
        btnAddTransaction.Text = "Add Transaction"
        btnAddTransaction.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewLoan
        ' 
        DataGridViewLoan.AllowUserToOrderColumns = True
        DataGridViewLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewLoan.Columns.AddRange(New DataGridViewColumn() {CustomerName, CustomerID, LoanAmount, TransactionDate, TransactionID, Delete})
        DataGridViewLoan.Location = New Point(311, 442)
        DataGridViewLoan.Name = "DataGridViewLoan"
        DataGridViewLoan.RowHeadersWidth = 51
        DataGridViewLoan.ScrollBars = ScrollBars.Vertical
        DataGridViewLoan.Size = New Size(1167, 502)
        DataGridViewLoan.TabIndex = 19
        ' 
        ' CustomerName
        ' 
        CustomerName.HeaderText = "Customer Name"
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
        ' LoanAmount
        ' 
        LoanAmount.HeaderText = "Loan Amount"
        LoanAmount.MinimumWidth = 6
        LoanAmount.Name = "LoanAmount"
        LoanAmount.Width = 125
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
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(17, 874)
        btnLogout.Margin = New Padding(8, 6, 8, 6)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(206, 97)
        btnLogout.TabIndex = 23
        btnLogout.TextAlign = ContentAlignment.MiddleRight
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.BackColor = Color.Black
        txtCustomerName.BorderStyle = BorderStyle.None
        txtCustomerName.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCustomerName.ForeColor = Color.White
        txtCustomerName.Location = New Point(338, 254)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.PlaceholderText = "Type customer name"
        txtCustomerName.Size = New Size(259, 25)
        txtCustomerName.TabIndex = 34
        ' 
        ' LoanPage
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        AutoScrollMinSize = New Size(1536, 1024)
        BackgroundImage = My.Resources.Resources._1_Loan_Main
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1518, 977)
        Controls.Add(txtCustomerName)
        Controls.Add(btnLogout)
        Controls.Add(DataGridViewLoan)
        Controls.Add(btnAddTransaction)
        Controls.Add(DateTimePicker)
        Controls.Add(txtAmount)
        Controls.Add(btnPayment)
        Controls.Add(btnLoan)
        Controls.Add(btnDashboard)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "LoanPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoanPage"
        WindowState = FormWindowState.Maximized
        CType(DataGridViewLoan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPayment As Button
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents btnAddTransaction As Button
    Friend WithEvents DataGridViewLoan As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents LoanAmount As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents TransactionID As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents txtCustomerName As TextBox
End Class
