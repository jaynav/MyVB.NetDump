Public Class clsController

    'controller handels order information

    'Collection to hold our orders
    Private colOrders As New Hashtable
    Private anOrder As clsOrder
    Private strError As String

    Public Sub Save(ByVal OrderInfoList As ArrayList)
        'Check to see if order is already saved
        'prompts user if he wants to overwrite the order if order present
        If colOrders.Contains(OrderInfoList(0)) Then

            Dim message As String =
                    "This Order Already exist, overwrite the old values?"
            Dim button As DialogResult = MessageBox.Show(message, "Customer",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If button = DialogResult.Yes Then
                Delete(OrderInfoList(0))
                MessageBox.Show("order" & OrderInfoList(0) & "was sucessfully overwritten")

            ElseIf button = DialogResult.No Then
                MessageBox.Show("order not saved, you decided to keep the original order")
                Exit Sub

            End If

        End If

        'Create an order object an Order
        Dim order As New clsOrder

        'Clear the Class error variable
        strError = ""

        Try
            'Store the Order
            order.ID = OrderInfoList(0)                     '0
            order.CustomerName = OrderInfoList(1)           '1
            order.CustomerPhone = OrderInfoList(2)
            order.TheDate = OrderInfoList(3)
            order.CustomerBillStreet = OrderInfoList(4)
            order.CustomerBillCity = OrderInfoList(5)
            order.CustomerBillState = OrderInfoList(6)
            order.CustomerBillZip = OrderInfoList(7)
            order.CustomerShipStreet = OrderInfoList(8)
            order.CustomerShipCity = OrderInfoList(9)
            order.CustomerShipState = OrderInfoList(10)
            order.CustomerShipZip = OrderInfoList(11)



            order.CustomerExtraFee = OrderInfoList(12)
            'Store the order detail
            order.AddDetail(OrderInfoList(13))               '2

            'Check for errors
            If order.getError = "" Then
                colOrders.Add(order.ID, order)
            Else
                addError(order.getError)
            End If

        Catch ex As FormatException
            addError("invalid Quantity")
        Catch ex As Exception
            'catch errors that i forgot to catch in cls order/order detail
            addError(ex.Message)


        End Try
    End Sub

    Public Sub Delete(ByVal anID As String)
        'Delete an Order
        If colOrders.Contains(anID) = False Then
            Throw New ApplicationException("Item not found (ID:" & anID & ")")
        Else
            colOrders.Remove(anID)
        End If

    End Sub

    Public Function getLineTotal(ByVal anID As String, ByVal iLine As Integer) As Decimal
        'Check to see if the collection hold the order by using the order id
        If colOrders.Contains(anID) Then

            'Load the order into a myOrder object
            Dim myOrder As clsOrder = CType(colOrders.Item(anID), clsOrder)

            'execute the getLineTotal method of the Order
            Return myOrder.getLineTotal(iLine)
        Else
            addError("ID: Cannot Retrieve Detail for Order")
            Return -1
        End If
    End Function

    Public Function getTotal(ByVal anID As String) As Decimal
        'return the order sub total
        Dim order As New clsOrder
        order = colOrders.Item(anID)
        Return order.getTotal()
    End Function
    
    Public Function getTotalTax(ByVal anID As String) As Decimal
        'return the order tax total
        Dim order As New clsOrder
        order = colOrders.Item(anID)

        Return order.getTotalTax()
    End Function
    Public Function getOrderTotal(ByVal anID As String) As Decimal
        'return the order total with tax and shipping charge
        Dim order As New clsOrder
        order = colOrders.Item(anID)

        Return order.getOrderTotal()
    End Function
    Public Function Retrieve(ByVal anID As String) As ArrayList
        'Retrieve an Order
        Dim order As New clsOrder
        Dim orderInfo As New ArrayList
        Try
            'get the order object
            order = colOrders.Item(anID)

            'retrieve the order header info
            orderInfo.Add(order.ID)
            orderInfo.Add(order.CustomerName)
            orderInfo.Add(order.CustomerPhone)
            orderInfo.Add(order.TheDate)
            orderInfo.Add(order.CustomerBillStreet)
            orderInfo.Add(order.CustomerBillCity)
            orderInfo.Add(order.CustomerBillState)
            orderInfo.Add(order.CustomerBillZip)
            orderInfo.Add(order.CustomerShipStreet)
            orderInfo.Add(order.CustomerShipCity)
            orderInfo.Add(order.CustomerShipState)
            orderInfo.Add(order.CustomerShipZip)
            orderInfo.Add(order.CustomerExtraFee)
            'retrieve the order detail info
            orderInfo.Add(order.GetDetail())

            'retrieves the order total
            orderInfo.Add(order.getTotal())
            orderInfo.Add(order.getTotalTax())
            orderInfo.Add(order.getOrderTotal())

        Catch ex As Exception
            'If there is not matching order
            'return an error
            If IsNothing(order) Then
                Throw New ApplicationException("Item not found, ID: " & anID)
            Else
                'Any other error push back up the stack
                Throw
            End If
        End Try

        Return orderInfo
    End Function

    Public Function getMenu() As String()
        'return the menu
        Dim menu() As String = {"Chopper", "Hornet", "Ghost", "Banshee"}

        Return menu
    End Function

    Public Function getPrices() As String()
        'return the prices
        Dim prices() As String = {"1000.99", "2000.99", "3000.33", "4000.99"}

        Return prices
    End Function

    Private Sub addError(ByVal s As String)
        'Add an error to the error list
        If strError = "" Then
            strError = s
        Else
            strError += vbCrLf & s
        End If
    End Sub

    Public Function getError() As String
        'return all errors for this object
        Return strError
    End Function
End Class
