Public Class CMenu
    Private strSKU As String
    Private strDescription As String
    Private decPrice As Decimal
    Private sError As String

    'TODO ADD THE PROPERTY METHODS FOR THIS CLASS
    'get/set of sku, description, price
    Public Sub New()
        strSKU = ""
        strDescription = ""

        sError = ""

    End Sub
    Public Property SKU()
        Get
            Return strSKU
        End Get
        Set(ByVal value)
            If isValidSku(value) Then
                strSKU = value
            End If
        End Set
    End Property
    Public Property description()
        Get
            Return strDescription
        End Get
        Set(ByVal value)
            If isValidStrDescription(value) Then
                strDescription = value
            End If
        End Set
    End Property

   
    Public Property price() As String
        Get
            Return decPrice
        End Get
        Set(ByVal value As String)
            decPrice = value
        End Set
    End Property

    Private Function isValidSku(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If s <> "" Then

                bResult = True
            Else
                addError("Sku: invalid sku")
                bResult = False
            End If
        Catch ex As Exception
            addError("Sku: invalid sku (" & ex.Message & ")")
            bResult = False
        End Try
        Return bResult
    End Function

    Private Function isValidStrDescription(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If s <> "" Then

                bResult = True
            Else
                addError("Sku: invalid Description")
                bResult = False
            End If
        Catch ex As Exception
            addError("Sku: invalid Description (" & ex.Message & ")")
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
                addError("Line :Price: Invalid Price (Price must be between 1.00 and 1000.00)")
                bResult = False
            End If
        Catch ex As Exception
            addError("Line: Price: Invalid  Price - Price must be between 1.00 and 1000.00 (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

    Private Sub addError(ByVal s As String)
        'private function to format our error message by
        'adding line breaks when necessary
        If sError = "" Then
            sError = s
        Else
            sError += vbCrLf & s
        End If
    End Sub

    Public Function getError()
        'public Function to return the error 
        'To other objects
        Return sError
    End Function



End Class
