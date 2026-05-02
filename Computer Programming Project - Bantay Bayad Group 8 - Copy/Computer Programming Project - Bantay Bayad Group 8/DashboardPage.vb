Public Class DashboardPage

    '=============================
    ' NAVIGATION DO NOT TOUCH!
    '=============================
    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        Dim loan As New LoanPage
        loan.Show()
        Me.Hide()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim payment As New PaymentPage
        payment.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New LoginPage
        login.Show()
        Me.Hide()
    End Sub

    '=============================
    ' LOAD DASHBOARD (FIXED)
    '=============================
    Private Sub LoadDashboard()

        DataGridViewDashboard.AutoGenerateColumns = False
        DataGridViewDashboard.Rows.Clear()

        '=============================
        ' TOTALS (IGNORE FILTERS)
        '=============================
        Dim totalOutstanding As Decimal = 0
        Dim totalCollected As Decimal = 0
        Dim totalTransactions As Integer = DataStore.Transactions.Count

        For Each t In DataStore.Transactions
            totalOutstanding += t.RemainingBalance
            totalCollected += t.PaymentAmount
        Next

        lblTotalOutstandingBalance.Text = totalOutstanding.ToString("N2")
        lblTotalPaymentCollected.Text = totalCollected.ToString("N2")
        lblTotalTransactions.Text = totalTransactions.ToString()

        '=============================
        ' FILTER MODE CHECK
        '=============================
        Dim allChecked As Boolean =
            chkPaidStatus.Checked AndAlso
            chkPartialStatus.Checked AndAlso
            chkUnpaidStatus.Checked AndAlso
            chkOverdueStatus.Checked

        '=============================
        ' GET LATEST PER CUSTOMER
        '=============================
        Dim latestPerCustomer As New Dictionary(Of String, Transaction)

        If Not allChecked Then
            For i As Integer = DataStore.Transactions.Count - 1 To 0 Step -1
                Dim t = DataStore.Transactions(i)

                If Not latestPerCustomer.ContainsKey(t.CustomerID) Then
                    latestPerCustomer(t.CustomerID) = t
                End If
            Next
        End If

        '=============================
        ' DISPLAY LOOP
        '=============================
        For i As Integer = DataStore.Transactions.Count - 1 To 0 Step -1

            Dim t = DataStore.Transactions(i)

            ' SEARCH
            If txtSearch.Text.Trim <> "" Then
                Dim keyword = txtSearch.Text.ToLower()

                If Not (t.CustomerName.ToLower().Contains(keyword) Or
                        t.CustomerID.ToLower().Contains(keyword)) Then
                    Continue For
                End If
            End If

            If Not allChecked Then

                If Not latestPerCustomer.ContainsKey(t.CustomerID) Then Continue For
                If latestPerCustomer(t.CustomerID).TransactionID <> t.TransactionID Then Continue For

                If chkPaidStatus.Checked = False AndAlso t.Status = "Paid" Then Continue For
                If chkPartialStatus.Checked = False AndAlso t.Status = "Partial" Then Continue For
                If chkUnpaidStatus.Checked = False AndAlso t.Status = "Unpaid" Then Continue For
                If chkOverdueStatus.Checked = False AndAlso t.Status = "Overdue" Then Continue For

            End If

            DataGridViewDashboard.Rows.Add(
                t.CustomerName,
                t.CustomerID,
                t.Type,
                t.PreviousBalance,
                t.LoanAmount,
                t.PaymentAmount,
                t.RemainingBalance,
                t.TransactionDate,
                t.Status,
                t.TransactionID,
                "Download"
            )

        Next

    End Sub

    '=============================
    ' EVENTS
    '=============================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDashboard()
    End Sub

    Private Sub chkPaidStatus_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaidStatus.CheckedChanged
        LoadDashboard()
    End Sub

    Private Sub chkPartialStatus_CheckedChanged(sender As Object, e As EventArgs) Handles chkPartialStatus.CheckedChanged
        LoadDashboard()
    End Sub

    Private Sub chkUnpaidStatus_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnpaidStatus.CheckedChanged
        LoadDashboard()
    End Sub

    Private Sub chkOverdueStatus_CheckedChanged(sender As Object, e As EventArgs) Handles chkOverdueStatus.CheckedChanged
        LoadDashboard()
    End Sub

    Private Sub DashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkPaidStatus.Checked = True
        chkPartialStatus.Checked = True
        chkUnpaidStatus.Checked = True
        chkOverdueStatus.Checked = True

        LoadDashboard()

    End Sub

End Class