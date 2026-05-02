Imports Computer_Programming_Project___Bantay_Bayad_Group_8.Models

Public Class LoanPage

    '=============================
    ' NAVIGATION (DO NOT TOUCH)
    '=============================
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim dashboard As New DashboardPage
        dashboard.Show()
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
    ' CUSTOMER PREFIX
    '=============================
    Private Function GetCustomerPrefix(name As String) As String
        Dim clean = name.Replace(" ", "").ToUpper()

        If clean.Length >= 3 Then
            Return clean.Substring(0, 3)
        ElseIf clean.Length = 2 Then
            Return clean & clean.Substring(1, 1)
        ElseIf clean.Length = 1 Then
            Return clean & clean & clean
        End If

        Return "CUS"
    End Function

    '=============================
    ' GENERATE CUSTOMER ID
    '=============================
    Private Function GenerateCustomerID(name As String) As String

        Dim prefix As String = GetCustomerPrefix(name)
        Dim usedNumbers As New List(Of Integer)

        For Each c In DataStore.Customers
            If c.CustomerID.StartsWith(prefix) Then
                Dim numPart = c.CustomerID.Split("-"c)(1)
                usedNumbers.Add(Convert.ToInt32(numPart))
            End If
        Next

        Dim newNumber As Integer = 1

        While usedNumbers.Contains(newNumber)
            newNumber += 1
        End While

        Return prefix & "-" & newNumber.ToString("0000")
    End Function

    '=============================
    ' GENERATE TRANSACTION ID
    '=============================
    Private Function GenerateTransactionID(type As String, dt As DateTime) As String

        Dim prefix As String = If(type = "Loan", "L", "P")
        Dim datePart As String = dt.ToString("yyyyMMdd")

        Dim usedNumbers As New List(Of Integer)

        For Each t In DataStore.Transactions
            If t.Type = type AndAlso t.TransactionID.StartsWith(prefix & datePart) Then
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
    ' RESOLVE CUSTOMER (FIXED)
    '=============================
    Private Function ResolveCustomer(name As String) As String

        Dim matches As New List(Of Customer)

        For Each c In DataStore.Customers
            If c.CustomerName.ToLower() = name.ToLower() Then
                matches.Add(c)
            End If
        Next

        ' NO MATCH → CREATE
        If matches.Count = 0 Then
            Dim newID As String = GenerateCustomerID(name)

            DataStore.Customers.Add(New Customer With {
                .CustomerID = newID,
                .CustomerName = name
            })

            Return newID
        End If

        ' ASK SAME / NEW / CANCEL
        Dim result = MessageBox.Show(
            "This name already exists. Is this the SAME person?",
            "Duplicate Name",
            MessageBoxButtons.YesNoCancel)

        ' CANCEL → STOP
        If result = DialogResult.Cancel Then
            Return Nothing
        End If

        ' SAME PERSON
        If result = DialogResult.Yes Then
            Return matches(0).CustomerID
        End If

        ' NEW PERSON
        Dim newCustomerID As String = GenerateCustomerID(name)

        DataStore.Customers.Add(New Customer With {
            .CustomerID = newCustomerID,
            .CustomerName = name
        })

        Return newCustomerID

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
    ' STATUS
    '=============================
    Private Function GetStatus(balance As Decimal, loanDate As DateTime) As String

        If balance = 0 Then Return "Paid"

        If DateDiff(DateInterval.Day, loanDate, DateTime.Now) > 30 Then
            Return "Overdue"
        End If

        Return "Unpaid"
    End Function

    '=============================
    ' LOAD TABLE
    '=============================
    Private Sub LoadLoanData()

        DataGridViewLoan.AutoGenerateColumns = False
        DataGridViewLoan.Rows.Clear()

        For i As Integer = DataStore.Transactions.Count - 1 To 0 Step -1
            Dim t = DataStore.Transactions(i)

            If t.Type = "Loan" Then
                DataGridViewLoan.Rows.Add(
                    t.CustomerName,
                    t.CustomerID,
                    t.LoanAmount,
                    t.TransactionDate,
                    t.TransactionID,
                    "Delete"
                )
            End If
        Next

    End Sub

    '=============================
    ' ADD LOAN (FIXED)
    '=============================
    Private Sub btnAddTransaction_Click(sender As Object, e As EventArgs) Handles btnAddTransaction.Click

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
        Dim loanDate As DateTime = DateTimePicker.Value

        Dim customerID As String = ResolveCustomer(name)

        ' STOP if cancelled
        If String.IsNullOrEmpty(customerID) Then Exit Sub

        Dim currentBalance As Decimal = GetCurrentBalance(customerID)

        If currentBalance > 0 Then
            MessageBox.Show("Customer still has unpaid balance!")
            Exit Sub
        End If

        Dim newBalance As Decimal = currentBalance + amount

        Dim newTransaction As New Transaction With {
            .TransactionID = GenerateTransactionID("Loan", loanDate),
            .CustomerID = customerID,
            .CustomerName = name,
            .Type = "Loan",
            .PreviousBalance = currentBalance,
            .LoanAmount = amount,
            .PaymentAmount = 0,
            .RemainingBalance = newBalance,
            .TransactionDate = loanDate,
            .Status = GetStatus(newBalance, loanDate)
        }

        DataStore.Transactions.Add(newTransaction)

        MessageBox.Show("Loan added!")

        LoadLoanData()

        txtCustomerName.Clear()
        txtAmount.Clear()

    End Sub

    '=============================
    ' DELETE
    '=============================
    Private Sub DataGridViewLoan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLoan.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        If DataGridViewLoan.Columns(e.ColumnIndex).Name = "Delete" Then

            Dim id As String = DataGridViewLoan.Rows(e.RowIndex).Cells("TransactionID").Value.ToString()

            For i As Integer = 0 To DataStore.Transactions.Count - 1
                If DataStore.Transactions(i).TransactionID = id Then
                    DataStore.Transactions.RemoveAt(i)
                    Exit For
                End If
            Next

            LoadLoanData()
        End If

    End Sub

    '=============================
    ' LOAD
    '=============================
    Private Sub LoanPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLoanData()
    End Sub

End Class