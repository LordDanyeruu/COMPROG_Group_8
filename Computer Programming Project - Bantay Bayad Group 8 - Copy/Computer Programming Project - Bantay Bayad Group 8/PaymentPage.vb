Imports Computer_Programming_Project___Bantay_Bayad_Group_8.Models

Public Class PaymentPage

    '=============================
    ' NAVIGATION DO NOT TOUCH!
    '=============================
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim dashboard As New DashboardPage
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        Dim loan As New LoanPage
        loan.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New LoginPage
        login.Show()
        Me.Hide()
    End Sub

    '=============================
    ' GENERATE TRANSACTION ID
    '=============================
    Private Function GenerateTransactionID(dt As DateTime) As String

        Dim prefix As String = "P"
        Dim datePart As String = dt.ToString("yyyyMMdd")

        Dim usedNumbers As New List(Of Integer)

        For Each t In DataStore.Transactions
            If t.Type = "Payment" AndAlso t.TransactionID.StartsWith(prefix & datePart) Then
                Dim num = t.TransactionID.Split("-"c)(1)
                usedNumbers.Add(Convert.ToInt32(num))
            End If
        Next

        Dim newNumber As Integer = 1

        While usedNumbers.Contains(newNumber)
            newNumber += 1
        End While

        Return prefix & datePart & "-" & newNumber.ToString("0000")

    End Function

    '=============================
    ' RESOLVE CUSTOMER
    '=============================
    Private Function ResolveCustomer(name As String) As String

        Dim matches As New List(Of Customer)

        For Each c In DataStore.Customers
            If c.CustomerName.ToLower() = name.ToLower() Then
                matches.Add(c)
            End If
        Next

        If matches.Count = 0 Then
            MessageBox.Show("Customer not found!")
            Return Nothing
        End If

        If matches.Count = 1 Then
            Return matches(0).CustomerID
        End If

        ' MULTIPLE → SELECT (ONLY HERE)
        Dim message As String = "Multiple customers found:" & vbCrLf

        For Each c In matches
            message &= c.CustomerID & vbCrLf
        Next

        Dim input = InputBox(message & "Enter CustomerID:")

        If String.IsNullOrEmpty(input) Then Return Nothing

        Return input

    End Function

    '=============================
    ' GET BALANCE
    '=============================
    Private Function GetCurrentBalance(customerID As String) As Decimal

        For i As Integer = DataStore.Transactions.Count - 1 To 0 Step -1
            If DataStore.Transactions(i).CustomerID = customerID Then
                Return DataStore.Transactions(i).RemainingBalance
            End If
        Next

        Return 0

    End Function

    '=============================
    ' GET LOAN DATE
    '=============================
    Private Function GetLoanDate(customerID As String) As DateTime

        For i As Integer = DataStore.Transactions.Count - 1 To 0 Step -1
            Dim t = DataStore.Transactions(i)
            If t.CustomerID = customerID And t.Type = "Loan" Then
                Return t.TransactionDate
            End If
        Next

        Return DateTime.Now

    End Function

    '=============================
    ' STATUS
    '=============================
    Private Function GetStatus(balance As Decimal, loanDate As DateTime) As String

        If balance = 0 Then Return "Paid"

        If DateDiff(DateInterval.Day, loanDate, DateTime.Now) > 30 Then
            Return "Overdue"
        End If

        Return "Partial"

    End Function

    '=============================
    ' LOAD TABLE
    '=============================
    Private Sub LoadPaymentData()

        DataGridViewPayment.AutoGenerateColumns = False
        DataGridViewPayment.Rows.Clear()

        For i As Integer = DataStore.Transactions.Count - 1 To 0 Step -1

            Dim t = DataStore.Transactions(i)

            If t.Type = "Payment" Then
                DataGridViewPayment.Rows.Add(
                    t.CustomerName,
                    t.CustomerID,        ' FIXED (ADD THIS COLUMN)
                    t.PaymentAmount,
                    t.TransactionDate,
                    t.TransactionID,
                    "Delete"
                )
            End If

        Next

    End Sub

    '=============================
    ' ADD PAYMENT
    '=============================
    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click

        If txtCustomerName.Text.Trim = "" Or txtAmount.Text.Trim = "" Then
            MessageBox.Show("Complete all fields")
            Exit Sub
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(txtAmount.Text, amount) OrElse amount <= 0 Then
            MessageBox.Show("Invalid amount")
            Exit Sub
        End If

        Dim name As String = txtCustomerName.Text.Trim
        Dim paymentDate As DateTime = DateTimePicker.Value

        Dim customerID As String = ResolveCustomer(name)

        If String.IsNullOrEmpty(customerID) Then Exit Sub

        Dim currentBalance As Decimal = GetCurrentBalance(customerID)

        If currentBalance = 0 Then
            MessageBox.Show("This customer has no outstanding balance.")
            Exit Sub
        End If

        If amount > currentBalance Then
            MessageBox.Show("Payment exceeds balance.")
            Exit Sub
        End If

        Dim remainingBalance As Decimal = currentBalance - amount
        Dim loanDate As DateTime = GetLoanDate(customerID)
        Dim status As String = GetStatus(remainingBalance, loanDate)

        Dim newTransaction As New Transaction With {
            .TransactionID = GenerateTransactionID(paymentDate),
            .CustomerID = customerID,
            .CustomerName = name,
            .Type = "Payment",
            .PreviousBalance = currentBalance,
            .LoanAmount = 0,
            .PaymentAmount = amount,
            .RemainingBalance = remainingBalance,
            .TransactionDate = paymentDate,
            .Status = status
        }

        DataStore.Transactions.Add(newTransaction)

        MessageBox.Show("Payment recorded!")

        LoadPaymentData()

        txtCustomerName.Clear()
        txtAmount.Clear()

    End Sub

    '=============================
    ' DELETE
    '=============================
    Private Sub DataGridViewPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPayment.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        If DataGridViewPayment.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim id As String = DataGridViewPayment.Rows(e.RowIndex).Cells("TransactionID").Value.ToString()

            For i As Integer = 0 To DataStore.Transactions.Count - 1
                If DataStore.Transactions(i).TransactionID = id Then
                    DataStore.Transactions.RemoveAt(i)
                    Exit For
                End If
            Next

            LoadPaymentData()
        End If

    End Sub

    '=============================
    ' LOAD
    '=============================
    Private Sub PaymentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentData()
    End Sub


End Class