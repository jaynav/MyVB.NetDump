
Public Class COrder
    Private strOrderID As String
    Private strCustomerName As String
    Private strCustomerPhone As String
    Private dtOrderDate As Date
    Private blnPickup As Boolean
    Private blnSameAddress As Boolean
    Private strDeliveryStreet As String
    Private strDeliveryCity As String
    Private strDeliveryState As String
    Private strDeliveryZip As String
    Private strBillStreet As String
    Private strBillCity As String
    Private strBillState As String
    Private strBillZip As String

    Private decSubtotal As Decimal
    Private decTax As Decimal
    Private decDeliveryFee As Decimal
    Private decTotal As Decimal

    Private detailsList As New ArrayList
    Private sError As String

    Private Const TAX_RATE As Decimal = 7.75 / 100.0
    Private Const DELIVERY_FEE As Decimal = 10.0

    Sub New()
        decSubtotal = 0
        decTax = 0
        decDeliveryFee = 0
        decTotal = 0
        strOrderID = ""
        strCustomerName = ""
        strCustomerPhone = ""
        strDeliveryStreet = ""
        strDeliveryCity = ""
        strDeliveryState = ""
        strDeliveryZip = ""
        strBillStreet = ""
        strBillCity = ""
        strBillState = ""
        strBillZip = ""
        detailsList = New ArrayList



    End Sub
    'the get/set method for the order
    Public Property ID() As String
        'get and set the order id
        Get
            Return strOrderID
        End Get
        Set(ByVal value As String)
            'Validation at class level
            If isValidID(value) = True Then
                Try
                    strOrderID = Convert.ToInt32(value)
                Catch ex As Exception
                    'Throw any other exceptional errors we haven't
                    'Anticipated
                    Throw
                End Try
            End If
        End Set
    End Property

    Public Property name() As String
        'Get and set the customer name
        Get
            Return strCustomerName
        End Get
        Set(ByVal value As String)
            If isValidName(value) Then
                strCustomerName = value
            End If
        End Set
    End Property

    Public Property orderDate() As String
        'Get and set the order date
        Get
            Return dtOrderDate
        End Get
        Set(ByVal value As String)
            If isValidDate(value) Then
                dtOrderDate = value
            End If
        End Set
    End Property

    Public Property phone() As String
        'get and set the phone number
        Get
            Return strCustomerPhone
        End Get
        Set(ByVal value As String)
            If isValidPhone(value) Then
                strCustomerPhone = value
            End If
        End Set
    End Property

    Public Property details() As ArrayList
        'Get and set the detail
        Get
            Dim detailsResultList As New ArrayList
            For i As Integer = 0 To detailsList.Count - 1
                Dim orderDetail As New CDetail
                orderDetail = CType(detailsList.Item(i), CDetail)
                Dim arrItem(4) As String
                arrItem(0) = orderDetail.line
                arrItem(1) = orderDetail.description

                arrItem(2) = FormatNumber(orderDetail.price)
                arrItem(3) = orderDetail.qty
                arrItem(4) = FormatNumber(orderDetail.total)
                detailsResultList.Add(arrItem)
            Next

            Return detailsResultList
        End Get
        Set(ByVal value As ArrayList)

            'Loop through all our arraylist of details
            For i As Integer = 0 To value.Count - 1
                'get a single order detail line out of 
                'the ArrayList of orders details
                Dim arrItem As String() = value(i)

                'create a new order detail object
                Dim orderDetail As New CDetail

                'Add detail info to our object
                ' 0 - detail line
                ' 1 - Item Description
                ' 2 - Item Quantity
                ' 3 - Item Price
                'Make sure it's not a blank line
                orderDetail.line = arrItem(0)
                orderDetail.description = arrItem(1)
                orderDetail.qty = arrItem(2)
                orderDetail.price = arrItem(3)
                If orderDetail.getError = "" Then
                    orderDetail.calcTotal()
                End If

                'Add the order to our collection
                'Check for errors in the detail
                'if no errors then add
                If orderDetail.getError = "" Then
                    If orderDetail.blankLine = False Then
                        detailsList.Add(orderDetail)
                    End If
                Else
                    addError(orderDetail.getError)
                End If
            Next

            If detailsList.Count = 0 Then
                addError("Detail:Order must contain at least one valid detail line")
            End If

        End Set
    End Property

    Public ReadOnly Property order() As COrder
        Get
            Return Me
        End Get
    End Property

    Public ReadOnly Property total() As Decimal
        'get the total
        Get
            Return decTotal
        End Get
    End Property

    Public Property pickUp()
        'get and set pickup / delivery
        Get
            Return blnPickup
        End Get
        Set(ByVal value)
            If isvaildpickup(value) Then
                blnPickup = value
            End If
        End Set
    End Property

    Public Property sameAddress()
        'get and set if delivery address is same as billing
        Get
            Return blnSameAddress
        End Get
        Set(ByVal value)
            If isvalidsameaddress(value) Then
                blnSameAddress = value
            End If
        End Set
    End Property

    Public ReadOnly Property deliveryFee() As Decimal
        'get delivery fee
        Get
            Return decDeliveryFee
        End Get
    End Property

    Public ReadOnly Property subtotal() As Decimal
        'get subtotal
        Get
            Return decSubtotal
        End Get
    End Property

    Public ReadOnly Property tax() As Decimal
        'get tax
        Get
            Return decTax
        End Get
    End Property

    Public Property billingStreet() As String
        'get/set billing street
        Get
            Return strBillStreet
        End Get
        Set(ByVal value As String)
            If isValidStreet(value, "Bill") Then
                strBillStreet = value
            End If
        End Set
    End Property

    Public Property billingCity() As String
        'get/set billing city
        Get
            Return strBillCity
        End Get
        Set(ByVal value As String)
            If isValidCity(value, "Bill") Then
                strBillCity = value
            End If
        End Set
    End Property

    Public Property billingState() As String
        'get/set billing state
        Get
            Return strBillState
        End Get
        Set(ByVal value As String)
            If isValidState(value, "Bill") Then
                strBillState = value
            End If
        End Set
    End Property

    Public Property billingZip() As String
        'get/set billing zip
        Get
            Return strBillZip
        End Get
        Set(ByVal value As String)
            If isValidZip(value, "Bill") Then
                strBillZip = value
            End If
        End Set
    End Property

    Public Property deliveryStreet() As String
        Get
            Return strDeliveryStreet
        End Get
        Set(ByVal value As String)
            If pickUp = False AndAlso sameAddress = False AndAlso isValidStreet(value, "Delivery") Then
                strDeliveryStreet = value
            End If
        End Set
    End Property

    Public Property deliveryCity() As String
        'get /set delivery city
        Get
            Return strDeliveryCity
        End Get
        Set(ByVal value As String)
            If pickUp = False AndAlso sameAddress = False AndAlso isValidCity(value, "Delivery") Then
                strDeliveryCity = value
            End If
        End Set
    End Property

    Public Property deliveryState() As String
        'get / set delivery state
        Get
            Return strDeliveryState
        End Get
        Set(ByVal value As String)
            If pickUp = False AndAlso sameAddress = False AndAlso isValidState(value, "Delivery") Then
                strDeliveryState = value
            End If
        End Set
    End Property

    Public Property deliveryZip() As String
        'get / set delivery zip
        Get
            Return strDeliveryZip
        End Get
        Set(ByVal value As String)
            If pickUp = False AndAlso sameAddress = False AndAlso isValidZip(value, "Delivery") Then
                strDeliveryZip = value
            End If
        End Set
    End Property

    Private Sub calcDelivery()
        'calculate delivery cost
        decDeliveryFee = 0
        If blnPickup = False Then
            decDeliveryFee = DELIVERY_FEE
        Else
            decDeliveryFee = 0
        End If
        decDeliveryFee = FormatNumber(decDeliveryFee)
    End Sub

    Private Sub calcSubtotal()
        'calculate subtotal
        Dim myOrderDetail As CDetail

        decSubtotal = 0
        For Each myOrderDetail In detailsList
            decSubtotal += myOrderDetail.total
        Next
        decSubtotal = FormatNumber(decSubtotal)
    End Sub

    Private Sub calcTotal()
        'calculate total
        decTotal = 0
        decTotal = FormatNumber(decSubtotal + decTax + decDeliveryFee)
    End Sub

    Private Sub calcTax()
        'calculate tax
        decTax = 0
        decTax = FormatNumber(decSubtotal * TAX_RATE)
    End Sub

    Public Sub calculateOrder()
        'perform order calculations
        calcSubtotal()
        calcTax()
        calcDelivery()
        calcTotal()
    End Sub

    Private Sub addError(ByVal s As String)
        'private function to format our error message by
        'adding line breaks when necessary
        If sError = "" Then
            sError = s
        Else
            sError += vbCrLf & s
        End If
    End Sub

    Public Function getLineTotal(ByVal iLine As Integer) As Decimal
        'return the line total
        For i As Integer = 0 To detailsList.Count - 1
            Dim myOrderDetail As CDetail = CType(detailsList(i), CDetail)
            If myOrderDetail.line = iLine Then
                Return myOrderDetail.total
            End If
        Next
    End Function

    Public Function getError()
        'public Function to return the error 
        'To other objects
        Return sError
    End Function

    '===================================================
    ' Validation routines
    '===================================================

    Private Function isValidID(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If Convert.ToInt32(s) > 0 Then
                bResult = True
            Else
                addError("ID: Invalid ID (ID must be an integer)")
                bResult = False
            End If
        Catch ex As Exception
            addError("ID: Invalid ID - ID must be an integer (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

    Private Function isValidName(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Name: Invalid Customer Name")
                bResult = False
            End If
        Catch ex As Exception
            addError("Name: Invalid Customer Name (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

    Private Function isValidDate(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If IsDate(s) Then
                bResult = True
            Else
                addError("OrderDate: Invalid Date")
                bResult = False
            End If
        Catch ex As Exception
            addError("OrderDate: Invalid  Date (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

    Private Function isValidPhone(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Try
            If s.Length = 10 AndAlso (isNumbersOnly(s)) Then
                bResult = True
            Else
                addError("Phone: Invalid Phone Number")
                bResult = False
            End If
        Catch ex As Exception
            addError("Phone: Invalid  Phone Number (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

    Private Function isValidStreet(ByVal s As String, ByVal source As String) As Boolean
        Dim bResult As Boolean
        Try
            If s <> "" Then
                bResult = True
            Else
                addError(source & "Street: Invalid Street")
                bResult = False
            End If
        Catch ex As Exception
            addError(source & "Street: Invalid Street (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

    Private Function isValidState(ByVal s As String, ByVal source As String) As Boolean
        Dim bResult As Boolean
        Try
            If isInStates(s) = True Then
                bResult = True
            Else
                addError(source & "State: Invalid State")
                bResult = False
            End If
        Catch ex As Exception
            addError(source & "State: Invalid State (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

    Private Function isValidCity(ByVal s As String, ByVal source As String) As Boolean
        Dim bResult As Boolean
        Try
            If s <> "" Then
                bResult = True
            Else
                addError(source & "City: Invalid City")
                bResult = False
            End If
        Catch ex As Exception
            addError(source & "City: Invalid City (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

    Private Function isValidZip(ByVal s As String, ByVal source As String) As Boolean
        Dim bResult As Boolean
        Try
            If (s.Length = 10 Or s.Length = 5) AndAlso (isNumbersOnly(s)) Then
                bResult = True
            Else
                addError(source & "Zip: Invalid Zip Code")
                bResult = False
            End If
        Catch ex As Exception
            addError(source & "Zip: Invalid  Zip Code (" & ex.Message & ")")
            bResult = False
        End Try

        Return bResult
    End Function

    Private Function isNumbersOnly(ByVal s As String) As Boolean
        Dim strNumbers As String = "1234567890"
        Dim blnResult = True
        For i As Integer = 0 To s.Length - 1
            If strNumbers.Contains(s(i)) = False Then
                blnResult = False
                Exit For
            End If
        Next
        Return blnResult
    End Function

    Private Function isInStates(ByVal s As String) As Boolean
        Dim blnResult As Boolean = False
        Dim arrStates As String() = {"AL", "AK", "AZ", _
                        "AS", "AR", "AA", _
                        "AE", "AP", "CA", _
                        "CO", "CT", "DE", _
                        "DC", "FL", "GA", _
                        "GU", "HI", "ID", _
                        "IL", "IN", "IA", _
                        "KS", "KY", "LA", _
                        "ME", "MH", "MD", _
                        "MA", "MI", "FM", _
                        "MN", "MS", "MO", _
                        "MT", "NE", "NV", _
                        "NH", "NJ", "NM", _
                        "NY", "NC", "ND", _
                        "MP", "OH", "OK", _
                        "OR", "PW", "PA", _
                        "RI", "PR", "SC", _
                        "SD", "TN", "TX", _
                        "UT", "VT", "VA", _
                        "VI", "WA", "WV", _
                        "WI", "WY"}
        For i As Integer = 0 To arrStates.Length - 1
            If s.ToUpper = arrStates(i).ToUpper Then
                blnResult = True
                Exit For
            End If
        Next
        Return blnResult
    End Function

    Private Function isvaildpickup(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s = "True" Then
                bResult = True
            ElseIf s = "False" Then
                bResult = False
            End If
        Catch ex As Exception

        End Try
        Return bResult
    End Function

    Private Function isvalidsameaddress(ByVal s As Object) As Boolean
        Dim bResult As Boolean

        Try
            If s = "True" Then
                bResult = True
            ElseIf s = "False" Then
                bResult = False
            End If
        Catch ex As Exception
        End Try
    End Function

End Class
