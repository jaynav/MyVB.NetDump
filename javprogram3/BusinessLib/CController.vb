Imports DatabaseLib
Public Class CController


    ' Private htblOrders As New Hashtable
    Private colMenu As New SortedList(Of String, CMenu)
    Private colOrders As New Hashtable
    Private Const CONNECTIONSTRING As String = "Data source = (local); Initial Catalog =javProgram3;" &
            "Integrated Security=True"
    Private anOrder As COrder
    Private strError As String


    Public Sub New()
        'load the menu
        loadMenu()

        'load the orders
        loadOrders()
    End Sub
    ' get menu and prices for combo box
    Public ReadOnly Property getMenus() As String()
        'return the menu item desc
        Get
            Dim arrMenuItems(colMenu.Keys.Count - 1) As String
            Dim i As Integer = 0
            For Each key As String In colMenu.Keys
                arrMenuItems(i) = colMenu.Item(key).description
                i = i + 1
            Next
            Return arrMenuItems
        End Get
    End Property

    Public ReadOnly Property getPrices() As String()
        'get menu item price
        Get
            Dim arrMenuPrices(colMenu.Keys.Count - 1) As String
            Dim i As Integer = 0
            For Each key As String In colMenu.Keys
                arrMenuPrices(i) = colMenu.Item(key).price
                i = i + 1
            Next
            Return arrMenuPrices
        End Get
    End Property
    'delete and save the current order
    Public Sub deleteOrder(ByVal anID As String)
        'delete an order
        strError = ""
        If colOrders.Contains(anID) Then
            colOrders.Remove(anID)
            CDBSystem.openDatabase(CONNECTIONSTRING)
            CDBSystem.dbDelete(anID)
        Else
            addError("ID: No matching order found")
        End If
    End Sub

    Public Sub saveOrder(ByVal OrderInfoList As ArrayList)
        'Clear the Class error variable

        strError = ""

        'Check to see if order is already saved
        'If that's the case exit
        If colOrders.Contains(OrderInfoList(0)) Then
            addError("ID: Duplicate Order ID (Order exists already!)")
            Return
        End If

        'Create an order object an Order
        Dim order As New COrder

        Try
            'Store the Order
            order.ID = OrderInfoList(0)                     '0
            order.name = OrderInfoList(1)                   '1
            order.phone = OrderInfoList(2)                  '2
            order.orderDate = OrderInfoList(3)              '3
            order.pickUp = OrderInfoList(4)                '13
            order.sameAddress = OrderInfoList(5)            '8
            order.deliveryStreet = OrderInfoList(6)         '9
            order.deliveryCity = OrderInfoList(7)
            order.deliveryState = OrderInfoList(8)         '11
            order.deliveryZip = OrderInfoList(9)           '12
            order.billingStreet = OrderInfoList(10)          '4
            order.billingCity = OrderInfoList(11)            '5
            order.billingState = OrderInfoList(12)           '6 
            order.billingZip = OrderInfoList(13)             '7
            '10

            'Store the detail
            order.details = OrderInfoList(14)

            'Check for errors
            If order.getError = "" Then
                'Process totals Order
                order.calculateOrder()
                colOrders.Add(order.ID, order)
                CDBSystem.openDatabase(CONNECTIONSTRING)
                'CDBSystem.openDatabase("Driver={SQL Native Client};Server=lt-it;Database=buckstar;Trusted_Connection=yes;")
                CDBSystem.DBSave(OrderInfoList)
                addError(CDBSystem.dbGetError)
            Else
                addError(order.getError)
            End If

        Catch ex As Exception

            'Add anything we haven't handled to our
            'Class error message
            addError(ex.Message)
        End Try
    End Sub
    Public Function loadMenu() As String

        Dim lstDBMenu As New ArrayList
        'connect to database
        CDBSystem.openDatabase(CONNECTIONSTRING)
        'retrieve all orders from database
        lstDBMenu = CDBSystem.dbLoadMenu

        For i As Integer = 0 To lstDBMenu.Count - 1
            Dim arrProduct As New ArrayList
            arrProduct = lstDBMenu(i)
            

            'menu sku = arrproduct holds nothing.
            Dim menu As New CMenu
            menu.SKU = arrProduct.Item(0)
            menu.description = arrProduct.Item(1)
            menu.price = arrProduct.Item(2)


            colMenu.Add(menu.SKU, menu)
        Next
        Return "Loaded " & lstDBMenu.Count & " Products"
    End Function


    Public Function loadOrders() As String
        'Clear the Class error variable
        strError = ""

        'Hold all database orders
        Dim lstDBOrders As New ArrayList

        'connect to database
        CDBSystem.openDatabase(CONNECTIONSTRING)

        'retrieve all orders from database
        lstDBOrders = CDBSystem.dbLoadOrders

        'Loop through database orders and get order info
        For i As Integer = 0 To lstDBOrders.Count - 1

            'List to hold all values for a single order
            Dim lstOrder As New ArrayList

            'Retrieve an order for the list of database orders
            lstOrder = lstDBOrders(i)

            'create the order object and populate it from the 
            'order we got from the database
            Dim anOrder As New COrder
            anOrder.ID = lstOrder.Item(0)
            anOrder.name = lstOrder.Item(1)
            anOrder.phone = lstOrder.Item(2)
            anOrder.orderDate = lstOrder.Item(3)
            anOrder.pickUp = lstOrder.Item(4)
            anOrder.sameAddress = lstOrder.Item(5)
            anOrder.deliveryStreet = lstOrder.Item(6)
            anOrder.deliveryCity = lstOrder.Item(7)
            anOrder.deliveryState = lstOrder.Item(8)
            anOrder.deliveryZip = lstOrder.Item(9)
            anOrder.billingStreet = lstOrder.Item(10)
            anOrder.billingCity = lstOrder.Item(11)
            anOrder.billingState = lstOrder.Item(12)
            anOrder.billingZip = lstOrder.Item(13) 



            'Retrieve the detail
            anOrder.details = lstOrder.Item(14)

            'Process the order to generate the totals
            anOrder.calculateOrder()

            Dim keys As String = lstOrder.Item(0)
            colOrders.Clear()
            colOrders.Add(keys, anOrder)
        Next

        Return "Loaded " & colOrders.Count & " Orders"
    End Function

    Public Function getOrdersInfo() As List(Of String())
        'get a summary of orders
        strError = ""
        Dim lstOrdersInfo As New List(Of String())
        For Each k As String In colOrders.Keys
            Dim anOrder As New COrder
            anOrder = colOrders.Item(k)
            lstOrdersInfo.Add({anOrder.ID, anOrder.name, anOrder.orderDate, anOrder.total})
        Next
        Return lstOrdersInfo
    End Function





    Public Function getOrder(ByVal anID As String) As ArrayList
        'Clear the Class error variable
        strError = ""

        Dim order As New COrder
        Dim lstOrder As New ArrayList

        If colOrders.Contains(anID) Then
            order = CType(colOrders.Item(anID), COrder)
            'Add order info
            lstOrder.Add(order.ID)
            lstOrder.Add(order.name)
            lstOrder.Add(order.phone)
            lstOrder.Add(order.orderDate)
            lstOrder.Add(order.pickUp)
            lstOrder.Add(order.sameAddress)
            lstOrder.Add(order.deliveryStreet)
            lstOrder.Add(order.deliveryCity)
            lstOrder.Add(order.deliveryState)
            lstOrder.Add(order.deliveryZip)
            lstOrder.Add(order.billingStreet)
            lstOrder.Add(order.billingCity)
            lstOrder.Add(order.billingState)
            lstOrder.Add(order.billingZip)

            lstOrder.Add(order.subtotal)
            lstOrder.Add(order.tax)
            lstOrder.Add(order.deliveryFee)
            lstOrder.Add(order.total)
            'Add Detail info
            lstOrder.Add(order.details)
            '''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''
            'ElseIf Not colOrders.Contains(anID) Then


            '    CDBSystem.openDatabase(CONNECTIONSTRING)
            '    lstOrder = CDBSystem.dbGetOrder(anID)


            '    For e As Integer = 0 To lstOrder.Count - 1

            '        order.ID = lstOrder.Item(0)
            '        order.name = lstOrder.Item(1)
            '        order.phone = lstOrder.Item(2)
            '        order.orderDate = lstOrder.Item(3)
            '        order.pickUp = lstOrder.Item(4)
            '        order.sameAddress = lstOrder.Item(5)
            '        order.deliveryStreet = lstOrder.Item(6)
            '        order.deliveryState = lstOrder.Item(7)
            '        order.deliveryStreet = lstOrder.Item(8)
            '        order.deliveryZip = lstOrder.Item(9)
            '        order.billingCity = lstOrder.Item(10)
            '        order.billingState = lstOrder.Item(11)
            '        order.billingStreet = lstOrder.Item(12)
            '        order.billingZip = lstOrder.Item(13)
            '        order.details = lstOrder.Item(14)
            '        order.calculateOrder()
            '        Return lstOrder

            '    Next










            '    '''''''''''''''''''''''''''''''''''''''''''''''''''
            '    ''''''''''''''''''''''''''''''''''''''''''''''''''
        Else
            addError("ID: No matching order found")
        End If
        Return lstOrder
    End Function
    Public Function getLineTotal(ByVal anID As String, ByVal iLine As Integer) As Decimal
        'get the line total
        If colOrders.Contains(anID) Then
            Dim myOrder As COrder = CType(colOrders.Item(anID), COrder)

            Return myOrder.getLineTotal(iLine)
        Else
            addError("ID: Cannot Retrieve Detail for Order")
            Return -1
        End If
    End Function
    Public Function getOrderSubTotal(ByVal anID As String) As Decimal
        'ge the order subtotal
        If colOrders.Contains(anID) Then
            Dim myOrder As COrder
            myOrder = CType(colOrders.Item(anID), COrder)
            Return myOrder.subtotal
        Else
            addError("ID: Cannot Retrieve Subtotal for Order")
            Return -1
        End If
    End Function
    Public Function getOrderTax(ByVal anID As String) As Decimal
        'get the order tax
        If colOrders.Contains(anID) Then
            Dim myOrder As COrder
            myOrder = CType(colOrders.Item(anID), COrder)
            Return myOrder.tax
        Else
            addError("ID: Cannot Retrieve Tax for Order")
            Return -1
        End If
    End Function
    Public Function getOrderDeliveryFee(ByVal anID As String) As Decimal
        'get the order delivery
        If colOrders.Contains(anID) Then
            Dim myOrder As COrder
            myOrder = CType(colOrders.Item(anID), COrder)
            Return myOrder.deliveryFee
        Else
            addError("ID: Cannot Retrieve Delivery Fee for Order")
            Return -1
        End If
    End Function
    Public Function getOrderTotal(ByVal anID As String) As Decimal
        'get the order total
        If colOrders.Contains(anID) Then
            Dim myOrder As COrder
            myOrder = CType(colOrders.Item(anID), COrder)
            Return myOrder.total
        Else
            addError("ID: Cannot Retrieve Total for Order")
            Return -1
        End If
    End Function
    Private Sub addError(ByVal s As String)
        'build error
        If strError = "" Then
            strError = s
        Else
            strError += vbCrLf & s
        End If
    End Sub
    Public Function getError() As String
        'return error
        Return strError
    End Function

End Class
