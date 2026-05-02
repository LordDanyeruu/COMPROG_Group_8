<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardPage
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
        components = New ComponentModel.Container()
        btnDashboards = New Button()
        btnLoan = New Button()
        btnPayment = New Button()
        LabelDashboard = New Label()
        LabelOverview = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtSearch = New TextBox()
        chkPaidStatus = New CheckBox()
        chkPartialStatus = New CheckBox()
        chkUnpaidStatus = New CheckBox()
        chkOverdueStatus = New CheckBox()
        DataGridViewDashboard = New DataGridView()
        CustomerName = New DataGridViewTextBoxColumn()
        CustomerID = New DataGridViewTextBoxColumn()
        Type = New DataGridViewTextBoxColumn()
        PreviousBalance = New DataGridViewTextBoxColumn()
        LoanAmount = New DataGridViewTextBoxColumn()
        PaymentAmount = New DataGridViewTextBoxColumn()
        RemainingBalance = New DataGridViewTextBoxColumn()
        TransactionDate = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        TransactionID = New DataGridViewTextBoxColumn()
        Download = New DataGridViewButtonColumn()
        lblTotalOutstandingBalance = New Label()
        lblTotalPaymentCollected = New Label()
        lblTotalTransactions = New Label()
        btnLogout = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        CType(DataGridViewDashboard, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDashboards
        ' 
        btnDashboards.BackColor = Color.Transparent
        btnDashboards.FlatAppearance.BorderSize = 0
        btnDashboards.FlatStyle = FlatStyle.Flat
        btnDashboards.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnDashboards.ForeColor = Color.White
        btnDashboards.Location = New Point(37, 172)
        btnDashboards.Margin = New Padding(8, 6, 8, 6)
        btnDashboards.Name = "btnDashboards"
        btnDashboards.Size = New Size(206, 74)
        btnDashboards.TabIndex = 4
        btnDashboards.Text = "Dashboard"
        btnDashboards.TextAlign = ContentAlignment.MiddleRight
        btnDashboards.UseVisualStyleBackColor = False
        ' 
        ' btnLoan
        ' 
        btnLoan.BackColor = Color.Transparent
        btnLoan.FlatAppearance.BorderSize = 0
        btnLoan.FlatStyle = FlatStyle.Flat
        btnLoan.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnLoan.ForeColor = Color.White
        btnLoan.Location = New Point(37, 285)
        btnLoan.Margin = New Padding(8, 6, 8, 6)
        btnLoan.Name = "btnLoan"
        btnLoan.Size = New Size(206, 74)
        btnLoan.TabIndex = 5
        btnLoan.Text = "Loan"
        btnLoan.TextAlign = ContentAlignment.MiddleRight
        btnLoan.UseVisualStyleBackColor = False
        ' 
        ' btnPayment
        ' 
        btnPayment.BackColor = Color.Transparent
        btnPayment.FlatAppearance.BorderSize = 0
        btnPayment.FlatStyle = FlatStyle.Flat
        btnPayment.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnPayment.ForeColor = Color.White
        btnPayment.Location = New Point(37, 384)
        btnPayment.Margin = New Padding(8, 6, 8, 6)
        btnPayment.Name = "btnPayment"
        btnPayment.Size = New Size(206, 74)
        btnPayment.TabIndex = 6
        btnPayment.Text = "Payment"
        btnPayment.TextAlign = ContentAlignment.MiddleRight
        btnPayment.UseVisualStyleBackColor = False
        ' 
        ' LabelDashboard
        ' 
        LabelDashboard.AutoSize = True
        LabelDashboard.BackColor = Color.Transparent
        LabelDashboard.Font = New Font("Montserrat", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        LabelDashboard.ForeColor = Color.White
        LabelDashboard.Location = New Point(316, 41)
        LabelDashboard.Name = "LabelDashboard"
        LabelDashboard.Size = New Size(176, 39)
        LabelDashboard.TabIndex = 7
        LabelDashboard.Text = "Dashboard"
        ' 
        ' LabelOverview
        ' 
        LabelOverview.AutoSize = True
        LabelOverview.BackColor = Color.Transparent
        LabelOverview.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        LabelOverview.ForeColor = Color.White
        LabelOverview.Location = New Point(318, 76)
        LabelOverview.Name = "LabelOverview"
        LabelOverview.Size = New Size(212, 20)
        LabelOverview.TabIndex = 8
        LabelOverview.Text = "Overview of you financial activity."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(469, 172)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 20)
        Label1.TabIndex = 9
        Label1.Text = "Total Outstanding Balance"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(876, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 20)
        Label2.TabIndex = 10
        Label2.Text = "Total Payment Collected"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(1284, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 20)
        Label3.TabIndex = 11
        Label3.Text = "Total Transactions"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Black
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(342, 375)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search customer name"
        txtSearch.Size = New Size(443, 25)
        txtSearch.TabIndex = 12
        ' 
        ' chkPaidStatus
        ' 
        chkPaidStatus.AutoSize = True
        chkPaidStatus.Location = New Point(867, 379)
        chkPaidStatus.Name = "chkPaidStatus"
        chkPaidStatus.Size = New Size(18, 17)
        chkPaidStatus.TabIndex = 14
        chkPaidStatus.UseVisualStyleBackColor = True
        ' 
        ' chkPartialStatus
        ' 
        chkPartialStatus.AutoSize = True
        chkPartialStatus.Location = New Point(1014, 379)
        chkPartialStatus.Name = "chkPartialStatus"
        chkPartialStatus.Size = New Size(18, 17)
        chkPartialStatus.TabIndex = 15
        chkPartialStatus.UseVisualStyleBackColor = True
        ' 
        ' chkUnpaidStatus
        ' 
        chkUnpaidStatus.AutoSize = True
        chkUnpaidStatus.Location = New Point(1166, 379)
        chkUnpaidStatus.Name = "chkUnpaidStatus"
        chkUnpaidStatus.Size = New Size(18, 17)
        chkUnpaidStatus.TabIndex = 16
        chkUnpaidStatus.UseVisualStyleBackColor = True
        ' 
        ' chkOverdueStatus
        ' 
        chkOverdueStatus.AutoSize = True
        chkOverdueStatus.Location = New Point(1328, 379)
        chkOverdueStatus.Name = "chkOverdueStatus"
        chkOverdueStatus.Size = New Size(18, 17)
        chkOverdueStatus.TabIndex = 17
        chkOverdueStatus.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewDashboard
        ' 
        DataGridViewDashboard.AllowUserToOrderColumns = True
        DataGridViewDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewDashboard.Columns.AddRange(New DataGridViewColumn() {CustomerName, CustomerID, Type, PreviousBalance, LoanAmount, PaymentAmount, RemainingBalance, TransactionDate, Status, TransactionID, Download})
        DataGridViewDashboard.Location = New Point(11, 450)
        DataGridViewDashboard.Name = "DataGridViewDashboard"
        DataGridViewDashboard.RowHeadersWidth = 51
        DataGridViewDashboard.ScrollBars = ScrollBars.Vertical
        DataGridViewDashboard.Size = New Size(1422, 538)
        DataGridViewDashboard.TabIndex = 18
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
        ' Type
        ' 
        Type.HeaderText = "Type"
        Type.MinimumWidth = 6
        Type.Name = "Type"
        Type.Width = 125
        ' 
        ' PreviousBalance
        ' 
        PreviousBalance.HeaderText = "Previous Balance"
        PreviousBalance.MinimumWidth = 6
        PreviousBalance.Name = "PreviousBalance"
        PreviousBalance.Width = 125
        ' 
        ' LoanAmount
        ' 
        LoanAmount.HeaderText = "Loan Amount"
        LoanAmount.MinimumWidth = 6
        LoanAmount.Name = "LoanAmount"
        LoanAmount.Width = 125
        ' 
        ' PaymentAmount
        ' 
        PaymentAmount.HeaderText = "Paid Amount"
        PaymentAmount.MinimumWidth = 6
        PaymentAmount.Name = "PaymentAmount"
        PaymentAmount.Width = 125
        ' 
        ' RemainingBalance
        ' 
        RemainingBalance.HeaderText = "Ramaining Balance"
        RemainingBalance.MinimumWidth = 6
        RemainingBalance.Name = "RemainingBalance"
        RemainingBalance.Width = 125
        ' 
        ' TransactionDate
        ' 
        TransactionDate.HeaderText = "Date"
        TransactionDate.MinimumWidth = 6
        TransactionDate.Name = "TransactionDate"
        TransactionDate.Width = 125
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 6
        Status.Name = "Status"
        Status.Width = 125
        ' 
        ' TransactionID
        ' 
        TransactionID.HeaderText = "Transaction ID"
        TransactionID.MinimumWidth = 6
        TransactionID.Name = "TransactionID"
        TransactionID.Width = 125
        ' 
        ' Download
        ' 
        Download.HeaderText = "Download"
        Download.MinimumWidth = 6
        Download.Name = "Download"
        Download.Width = 125
        ' 
        ' lblTotalOutstandingBalance
        ' 
        lblTotalOutstandingBalance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblTotalOutstandingBalance.AutoSize = True
        lblTotalOutstandingBalance.BackColor = Color.Transparent
        lblTotalOutstandingBalance.Font = New Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblTotalOutstandingBalance.ForeColor = Color.Red
        lblTotalOutstandingBalance.Location = New Point(524, 204)
        lblTotalOutstandingBalance.Name = "lblTotalOutstandingBalance"
        lblTotalOutstandingBalance.Size = New Size(47, 51)
        lblTotalOutstandingBalance.TabIndex = 19
        lblTotalOutstandingBalance.Text = "0"
        lblTotalOutstandingBalance.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalPaymentCollected
        ' 
        lblTotalPaymentCollected.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblTotalPaymentCollected.AutoSize = True
        lblTotalPaymentCollected.BackColor = Color.Transparent
        lblTotalPaymentCollected.Font = New Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblTotalPaymentCollected.ForeColor = Color.Lime
        lblTotalPaymentCollected.Location = New Point(920, 205)
        lblTotalPaymentCollected.Name = "lblTotalPaymentCollected"
        lblTotalPaymentCollected.Size = New Size(47, 51)
        lblTotalPaymentCollected.TabIndex = 20
        lblTotalPaymentCollected.Text = "0"
        lblTotalPaymentCollected.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalTransactions
        ' 
        lblTotalTransactions.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblTotalTransactions.AutoSize = True
        lblTotalTransactions.BackColor = Color.Transparent
        lblTotalTransactions.Font = New Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblTotalTransactions.ForeColor = Color.White
        lblTotalTransactions.Location = New Point(1311, 204)
        lblTotalTransactions.Name = "lblTotalTransactions"
        lblTotalTransactions.Size = New Size(47, 51)
        lblTotalTransactions.TabIndex = 21
        lblTotalTransactions.Text = "0"
        lblTotalTransactions.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(28, 860)
        btnLogout.Margin = New Padding(8, 6, 8, 6)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(206, 97)
        btnLogout.TabIndex = 22
        btnLogout.TextAlign = ContentAlignment.MiddleRight
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' DashboardPage
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        AutoScrollMinSize = New Size(1536, 1024)
        BackgroundImage = My.Resources.Resources._1_Dashboard_Main
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1518, 977)
        Controls.Add(btnLogout)
        Controls.Add(lblTotalTransactions)
        Controls.Add(lblTotalPaymentCollected)
        Controls.Add(lblTotalOutstandingBalance)
        Controls.Add(DataGridViewDashboard)
        Controls.Add(chkOverdueStatus)
        Controls.Add(chkUnpaidStatus)
        Controls.Add(chkPartialStatus)
        Controls.Add(chkPaidStatus)
        Controls.Add(txtSearch)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LabelOverview)
        Controls.Add(LabelDashboard)
        Controls.Add(btnPayment)
        Controls.Add(btnLoan)
        Controls.Add(btnDashboards)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "DashboardPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        CType(DataGridViewDashboard, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDashboards As Button
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents LabelDashboard As Label
    Friend WithEvents LabelOverview As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents chkPaidStatus As CheckBox
    Friend WithEvents chkPartialStatus As CheckBox
    Friend WithEvents chkUnpaidStatus As CheckBox
    Friend WithEvents chkOverdueStatus As CheckBox
    Friend WithEvents DataGridViewDashboard As DataGridView
    Friend WithEvents lblTotalOutstandingBalance As Label
    Friend WithEvents lblTotalPaymentCollected As Label
    Friend WithEvents lblTotalTransactions As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents PreviousBalance As DataGridViewTextBoxColumn
    Friend WithEvents LoanAmount As DataGridViewTextBoxColumn
    Friend WithEvents PaymentAmount As DataGridViewTextBoxColumn
    Friend WithEvents RemainingBalance As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents TransactionID As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Download As DataGridViewButtonColumn
End Class
