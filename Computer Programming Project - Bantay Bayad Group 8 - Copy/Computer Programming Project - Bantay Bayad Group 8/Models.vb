Public Class Customer
    Public Property CustomerID As String
    Public Property CustomerName As String
End Class

Public Class Transaction
    Public Property TransactionID As String
    Public Property CustomerID As String
    Public Property CustomerName As String
    Public Property Type As String
    Public Property PreviousBalance As Decimal
    Public Property LoanAmount As Decimal
    Public Property PaymentAmount As Decimal
    Public Property RemainingBalance As Decimal
    Public Property TransactionDate As DateTime
    Public Property Status As String
End Class