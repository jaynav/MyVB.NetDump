Imports System.Data.common
Imports System.Data
Imports System.Data.SqlClient

Public Class CDBSystem

    Private Shared strConnection As String
    Private Shared cmd As SqlCommand
    Private Shared cn As SqlConnection
    Private Shared dbReader As SqlDataReader
    Private Shared sql As String
    Private Shared strError As String

    Public Sub New()
    End Sub
    Public Sub New(ByVal aConn As String)
    End Sub
    Public Shared Sub openDatabase(ByVal aConn As String)
        cn = New SqlConnection
        cn.ConnectionString = aConn
    End Sub
    Public Shared Sub dbConnect()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub
    Public Shared Sub dbClose()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub

    'save to database
    Public Shared Sub dbSave(ByVal OrderInfoList As ArrayList)
        'ADD CODE FOR THE SAVE YOU ARE BEING PASSED AN ARRAYLIST THAT HOLDS THE ORDER INFORMATION
        strError = ""

        Try
            Dim insertStatement As String =
               "INSERT INTO CustomerOrder" &
            "(OrderId, CustomerName, Phone, OrderDate, Pickup, SameAddress, DeliveryStreet, DeliveryCity, DeliveryState, DeliveryZip, BillStreet, BillCity, BillState, BillZip) " &
            "VALUES ('" & OrderInfoList(0) &
            "','" & OrderInfoList(1) &
            "','" & OrderInfoList(2) &
            "','" & OrderInfoList(3) &
            "','" & OrderInfoList(4) &
            "','" & OrderInfoList(5) &
            "','" & OrderInfoList(6) &
            "','" & OrderInfoList(7) &
            "','" & OrderInfoList(8) &
            "','" & OrderInfoList(9) &
            "','" & OrderInfoList(10) &
            "','" & OrderInfoList(11) &
            "','" & OrderInfoList(12) &
            "','" & OrderInfoList(13) & "')"

            dbConnect()
            Dim insertCommand As New SqlCommand(insertStatement, cn)

            insertCommand.ExecuteNonQuery()


            Dim orderDetailList As ArrayList = OrderInfoList(14)
            For i As Integer = 0 To orderDetailList.Count - 1
                Dim arrayItems(3) As String
                arrayItems = orderDetailList(i)

                If arrayItems(1) <> "" Then
                    Dim insertdetail As String =
                    "INSERT INTO CustomerOrderDetail" &
                     "(OrderId, LineId, Item, Price, Qty) " &
                      "VALUES('" & OrderInfoList(0) &
                       "','" & arrayItems(0) &
                       "','" & arrayItems(1) &
                       "','" & arrayItems(2) &
                       "','" & arrayItems(3) & "')"

                    Dim addDetail As New SqlCommand(insertdetail, cn)
                    addDetail.ExecuteNonQuery()
                End If


            Next







        Catch ex As SqlException

            dbAddError("can not save data" & vbCrLf & ex.Message)
        Finally
            dbClose()

        End Try

    End Sub
    'delete from database
    Public Shared Sub dbDelete(ByVal orderID As String)

        strError = ""
        Try
            Dim deleteStatement As String =
                        "DELETE FROM CustomerOrder " &
                        "WHERE OrderId = '" & orderID & "'"
            dbConnect()

            Dim deletionCommand As New SqlCommand(deleteStatement, cn)
            deletionCommand.ExecuteNonQuery()
            ''''''''''''''''''''deleting detail''''''''''''''''''''''''
            Dim deleteDetail As String =
                "DELETE FROM CustomerOrderDetail " &
                "WHERE OrderId = '" & orderID & "'"


            Dim deletionDetail As New SqlCommand(deleteDetail, cn)
            deletionDetail.ExecuteNonQuery()

        Catch ex As SqlException

            dbAddError("Deletion Failed " & vbCrLf & ex.Message)

        Finally
            dbClose()
        End Try
    End Sub
    'Return the order information
    Public Shared Function dbGetOrder(ByVal anID) As Object

        ' Dim orderInfo As New colmenu
        
        Dim getTheOrders As String =
         "SELECT * " &
            "FROM CustomerOrder " &
            "Where OrderId = '" & anID & "';" &
            "Select * " &
            "FROM CustomerOrderDetail" &
            "Where OrderId = '" & anID & "'"

        '"SELECT * " &
        ' "FROM CustomerOrder, CustomerOrderDetail " &
        '"Where CustomerOrder.OrderId = CustomerOrderDetail.OrderId " &
        '"And CustomerOrder.OrderId = '" & anID & "'"

        Dim selectedCommand As New SqlCommand(getTheOrders, cn)
        dbConnect()
        Dim reader As SqlDataReader = selectedCommand.ExecuteReader()
        Dim theWholeOrder As New ArrayList
        Try



            Do While reader.Read

                Dim getAllOrders As New ArrayList
                getAllOrders.Add(reader("OrderId"))
                getAllOrders.Add(reader("CustomerName"))
                getAllOrders.Add(reader("Phone"))
                getAllOrders.Add(reader("OrderDate"))
                getAllOrders.Add(reader("Pickup"))
                getAllOrders.Add(reader("SameAddress"))
                getAllOrders.Add(reader("DeliveryStreet"))
                getAllOrders.Add(reader("DeliveryCity"))
                getAllOrders.Add(reader("DeliveryState"))
                getAllOrders.Add(reader("DeliveryZip"))
                getAllOrders.Add(reader("BillStreet"))
                getAllOrders.Add(reader("BillCity"))
                getAllOrders.Add(reader("BillState"))
                getAllOrders.Add(reader("BillZip"))


                reader.NextResult()

                Dim getOrderDetail As New ArrayList

                Dim theArrayItems(4) As String
                theArrayItems(0) = (reader("OrderId"))
                theArrayItems(1) = (reader("LineId"))
                theArrayItems(2) = (reader("Item"))
                theArrayItems(3) = (reader("Price"))
                theArrayItems(4) = (reader("Qty"))
                getOrderDetail.Add(theArrayItems)


                getAllOrders.Add(getOrderDetail)
                theWholeOrder.Add(getAllOrders)
                Debug.WriteLine(theWholeOrder.Count)
            Loop

            'reader.Close()
            Return theWholeOrder
        Catch ex As SqlException
            Throw ex
        Finally
            dbClose()

        End Try

    End Function




    Public Shared Function dbLoadOrders() As ArrayList

        Dim myorders As New ArrayList
        Dim sql As String
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        strError = ""

        Try
            sql = "SELECT * From CustomerOrder, CustomerOrderDetail where " &
                "CustomerOrder.OrderId = CustomerOrderDetail.OrderId"

            dbConnect()

            cmd = New SqlCommand(sql, cn)
            cmd.CommandType = CommandType.Text
            reader = cmd.ExecuteReader()

            Do While reader.Read()
                Dim getAllOrders As New ArrayList
                getAllOrders.Add(reader("OrderId"))
                getAllOrders.Add(reader("CustomerName"))
                getAllOrders.Add(reader("Phone"))
                getAllOrders.Add(reader("OrderDate"))
                getAllOrders.Add(reader("Pickup"))
                getAllOrders.Add(reader("SameAddress"))
                getAllOrders.Add(reader("DeliveryStreet"))
                getAllOrders.Add(reader("DeliveryCity"))
                getAllOrders.Add(reader("DeliveryState"))
                getAllOrders.Add(reader("DeliveryZip"))
                getAllOrders.Add(reader("BillStreet"))
                getAllOrders.Add(reader("BillCity"))
                getAllOrders.Add(reader("BillState"))
                getAllOrders.Add(reader("BillZip"))




                'sql = "Select * from customerOrderDetail " &
                ' "Where OrderID = '" & reader("OrderID") & "'"

                ' cmd = New SqlCommand(sql, cn)
                'reader.Close()
                'readerdetail = cmd.ExecuteReader()

                'reader.NextResult()


                Dim getOrderDetail As New ArrayList
                Dim theArrayItems(4) As String
                While reader.Read()




                    theArrayItems(0) = (reader("OrderId"))
                    theArrayItems(1) = (reader("LineId"))
                    theArrayItems(2) = (reader("Item"))
                    theArrayItems(3) = (reader("Price"))
                    theArrayItems(4) = (reader("Qty"))
                    getOrderDetail.Add(theArrayItems)

                End While


                    getAllOrders.Add(getOrderDetail)
                    myorders.Add(getAllOrders)
                    Debug.WriteLine(myorders.Count)



                Return myorders
            Loop




        Catch ex As SqlException
            dbAddError(ex.Message)
            Return myorders
        Catch ex As Exception
            dbAddError(ex.Message)
            Return myorders
        End Try
        Return myorders
    End Function

    Public Shared Function dbLoadMenu() As ArrayList
        Dim selectedStatement As String =
            "SELECT Sku, Detail, Price " &
            "FROM MenuData"
        Dim selectedCommand As New SqlCommand(selectedStatement, cn)
        dbConnect()
        Dim reader As SqlDataReader = selectedCommand.ExecuteReader()

        Dim aMenu As New ArrayList
        Try


            Do While reader.Read
                Dim getMenuItems As New ArrayList
                getMenuItems.Add(reader("Sku"))
                getMenuItems.Add(reader("Detail"))
                getMenuItems.Add(reader("Price"))
                aMenu.Add(getMenuItems)
            Loop

            reader.Close()
            Return aMenu
        Catch ex As SqlException
            Throw ex
        Finally
            dbClose()
        End Try

    End Function
    Private Shared Sub dbAddError(ByVal s As String)
        If strError = "" Then
            strError = s
        Else
            strError += vbCrLf & s
        End If
    End Sub
    Public Shared Function dbGetError() As String
        Return strError
    End Function
End Class
