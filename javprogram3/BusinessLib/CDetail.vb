
Public Class CDetail

    Private intLine As Integer        'Store the item line
    Private strDescription As String
    Private intQty As Integer
    Private decPrice As Decimal
    Private decItemTotal As Decimal
    Private strError As String      'Return the Error
    Public Sub New()
        strDescription = ""
        intQty = 0
        decPrice = 0
        decItemTotal = 0
        strError = ""

    End Sub
    'get/set property for the order detail

    Public ReadOnly Property total() As Decimal
        Get
            Return decItemTotal
        End Get
    End Property

    Public Sub calcTotal()
        If strDescription <> "" And intQty = 0 Then
            addError("Line:" & intLine & ":Qty: Missing Qty")
        ElseIf strDescription = "" And intQty <> 0 Then
            addError("Line:" & intLine & ":Item: Missing Item")
        Else
            decItemTotal = intQty * decPrice
        End If

    End Sub

    Public Property price() As String
        Get
            Return decPrice
        End Get
        Set(ByVal value As String)
            decPrice = value
        End Set
    End Property

    Public Property qty() As String
        Get
            Return intQty
        End Get
        Set(ByVal value As String)
            If isValidQty(value) Then
                intQty = value
            End If
        End Set
    End Property

    Public Property description() As String
        Get
            Return strDescription
        End Get
        Set(ByVal value As String)
            strDescription = value
        End Set
    End Property

    Public Property line()
        Get
            Return intLine
        End Get
        Set(ByVal value)
            intLine = Convert.ToInt32(value)
        End Set
    End Property

    Public ReadOnly Property detail() As CDetail
        Get
            Return Me
        End Get
    End Property

    Public Function getError() As String
        'return all errors that happen in the class
        Return strError
    End Function

    Private Sub addError(ByVal s As String)
        'format our error message with line breaks
        If strError = "" Then
            strError = s
        Else
            strError += vbCrLf & s
        End If
    End Sub

    Public Function blankLine() As Boolean
        Dim blnResult As Boolean = False

        If strDescription = "" And intQty = 0 And decPrice = 0 Then
            blnResult = True
        End If
        Return blnResult
    End Function

    Private Function isValidQty(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If Convert.ToInt32(s) >= 0 AndAlso Convert.ToInt32(s) <= 100 Then
                bResult = True
            Else
                addError("Line:" & intLine & ":Qty: Invalid Qty (Qty must be between 1 and 100)")
                bResult = False
            End If
        Catch ex As Exception
            addError("Line:" & intLine & ":Qty: Invalid  Qty - Qty must be between 1 and 100(" & ex.Message & ")")
            bResult = False
        End Try
        Return bResult
    End Function

    Private Function isValidPrice(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If Convert.ToDecimal(s) >= 0 AndAlso Convert.ToDecimal(s) <= 1000 Then
                bResult = True
            Else
                addError("Line:" & intLine & ":Price: Invalid Price (Price must be between 1.00 and 1000.00)")
                bResult = False
            End If
        Catch ex As Exception
            addError("Line:" & intLine & ":Price: Invalid  Price - Price must be between 1.00 and 1000.00 (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

End Class
