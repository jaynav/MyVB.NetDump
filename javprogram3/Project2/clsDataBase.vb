
Imports System.Data.SqlClient

'connection to database
Public Class clsDataBase




    Public Shared Function getAConnection() As SqlConnection
        Dim connectionString As String =
            "Data source = (local); Initial Catalog =javProgram3;" &
            "Integrated Security=True"
        Return New SqlConnection(connectionString)

    End Function

    'gets database menu from menudata table
    Public Shared Function getMenuList() As ArrayList

        Dim selectedStatement As String =
        "SELECT Sku, Description, Price " &
        "FROM MenuData"
        Dim selectedCommand As New SqlCommand(selectedStatement, getAConnection)
        Dim aMenu As New ArrayList
        Try
            getAConnection.Open()
            Dim reader As SqlDataReader = selectedCommand.ExecuteReader()
            Dim getMenuItems As New ArrayList


            Do While reader.Read

                getMenuItems.Add(reader("Sku"))
                getMenuItems.Add(reader("Description"))
                getMenuItems.Add(reader("Price"))
                aMenu.Add(getMenuItems)
            Loop

            reader.Close()

        Catch ex As SqlException
            Throw ex
        Finally
            getAConnection.Close()
        End Try
        Return aMenu
    End Function




    Public Shared Function addAnOrder(ByVal anId As clsOrder) As String
        Dim connection As SqlConnection = getAConnection()
        Dim AddOrder As String =
        "INSERT CustomerOrder" &
        "(OrderId, CustomerName, Phone, OrderDate, Pickup, SameAddress, DeliveryStreet, DeliveryCity, DeliveryState, DeliveryZip, BillStreet, BillCity, BillState, BillZip) " &
        "VALUES (@OrderId, @ CustomerName, @ Phone, @OrderDate, @Pickup, @SameAdress, @DeliveryStreet, @DelieveryCity, @DeliveryState, @DeliveryZip, @BillStreet, @BillCity, @BillState, @BillZip)"
        Dim insertCommand As New SqlCommand(AddOrder, connection)
        insertCommand.Parameters.AddWithValue("@OrderId", anId.ID)
        insertCommand.Parameters.AddWithValue("@CustomerName", anId.CustomerName)
        insertCommand.Parameters.AddWithValue("@Phone", anId.CustomerPhone)
        insertCommand.Parameters.AddWithValue("@OrderDate", anId.TheDate)


        insertCommand.Parameters.AddWithValue("@DeliveryStreet", anId.CustomerShipStreet)
        insertCommand.Parameters.AddWithValue("@DelieveryCity", anId.CustomerShipCity)
        insertCommand.Parameters.AddWithValue("@DeliveryState", anId.CustomerShipState)
        insertCommand.Parameters.AddWithValue("@DeliveryZip", anId.CustomerShipZip)
        insertCommand.Parameters.AddWithValue("@BillStreet", anId.CustomerBillStreet)
        insertCommand.Parameters.AddWithValue("@BillCity", anId.CustomerBillCity)
        insertCommand.Parameters.AddWithValue("@BillState", anId.CustomerBillState)
        insertCommand.Parameters.AddWithValue("@BillZip", anId.CustomerBillZip)

        Try
            connection.Open()
            insertCommand.ExecuteNonQuery()

            Dim selectStatement As String =
                "SELECT INDENT_CURRENT('CustomerOrder') FROM CustomerOrder"
            Dim selectedCommand As New SqlCommand(selectStatement, connection)
            Dim orderId As Integer = CInt(selectedCommand.ExecuteScalar)
            Return orderId


        Catch ex As SqlException
            Throw ex
        Finally
            connection.Close()

        End Try
    End Function

End Class
