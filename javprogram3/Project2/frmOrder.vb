Public Class frmChild

    'A comment for this class goes here.
    'The comment should describe the purpose of 
    'the class and anthing else that is relevant 
    'for future development.

    Private controller As clsController
    Private itemsMenu() As String
    Private itemsPrices() As String
    Private arrmenu() As String
    Dim isDataSaved As Boolean = True
    Dim counter As Integer = 0 'sets the counter of the array list

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save the order
        'Create an Arraylist to hold all the order Info
        Dim orderList As New ArrayList

        Try
            orderList.Add(txtID.Text)   'Add Order ID
            orderList.Add(txtName.Text) 'Add Customer Name
            orderList.Add(txtPhone.Text)
            orderList.Add(txtDate.Text)
            orderList.Add(txtBillStreet.Text)
            orderList.Add(txtBillCity.Text)
            orderList.Add(txtBillState.Text)
            orderList.Add(txtBillZip.Text)
            orderList.Add(txtShipStreet.Text)
            orderList.Add(txtShipCity.Text)
            orderList.Add(txtShipState.Text)
            orderList.Add(txtShipZip.Text)

            orderList.Add(txtDelivery.Text)

            'Create an ArrayList to hold all the order detail info

            Dim detailList As New ArrayList
            For i As Integer = 0 To counter
                'Create an Array to hold the information for each line item
                'Line Number, Item Description, Qty, Price
                Dim arrDetailItems(3) As String
                arrDetailItems(0) = Me.Panel1.Controls("lblLine" & (i + 1)).Text
                arrDetailItems(1) = Me.Panel1.Controls("cboItem" & (i + 1)).Text
                arrDetailItems(2) = Me.Panel1.Controls("txtQty" & (i + 1)).Text
                arrDetailItems(3) = Me.Panel1.Controls("txtPrice" & (i + 1)).Text

                'Add the array to our Detail arraylist
                detailList.Add(arrDetailItems)
            Next

            'Add the detail arraylist to the order arraylist
            orderList.Add(detailList)

            'Save the order
            controller.Save(orderList)

            'Check for errors
            If controller.getError <> "" Then

                'Display the list of all errors
                MessageBox.Show(controller.getError, "Error saving order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                'Loop through each detail line
                'and retrieve the total for that line
                'use the order ID and the line ID to identify
                'the order and the line item
                For i As Integer = 0 To 2
                    Me.Panel1.Controls("lblTotal" & (i + 1)).Text = controller.getLineTotal(txtID.Text, i + 1)
                Next

                '=== code below display totals
                txtTotal.Text = FormatCurrency(controller.getTotal(txtID.Text))

                txtTax.Text = FormatCurrency(controller.getTotalTax(txtID.Text))
                txtOrderTotal.Text = FormatCurrency(controller.getOrderTotal(txtID.Text))
            End If

        Catch ex As Exception
            'Catch Anything else that controller, and cls forms do not catch
            MessageBox.Show(ex.Message, "Error Saving Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        isDataSaved = True
    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        'Retrieve the order
        Dim orderinfo As ArrayList
        Dim orderDetailList As ArrayList
        Try
            orderinfo = controller.Retrieve(txtID.Text)
            txtID.Text = orderinfo(0)
            txtName.Text = orderinfo(1)
            txtPhone.Text = orderinfo(2)
            txtDate.Text = orderinfo(3)
            txtBillStreet.Text = orderinfo(4)
            txtBillCity.Text = orderinfo(5)
            txtBillState.Text = orderinfo(6)
            txtBillZip.Text = orderinfo(7)
            txtShipStreet.Text = orderinfo(8)
            txtShipCity.Text = orderinfo(9)
            txtShipState.Text = orderinfo(10)
            txtShipZip.Text = orderinfo(11)
            txtDelivery.Text = orderinfo(12)
            orderDetailList = orderinfo(13)

            Dim arrDetail As String()
            For i As Integer = 0 To orderDetailList.Count - 1
                arrDetail = orderDetailList.Item(i)
                Me.Panel1.Controls("cboItem" & (i + 1)).Text = arrDetail(1)
                Me.Panel1.Controls("txtQty" & (i + 1)).Text = arrDetail(2)
                Me.Panel1.Controls("txtPrice" & (i + 1)).Text = arrDetail(3)
                Me.Panel1.Controls("lblTotal" & (i + 1)).Text = arrDetail(4)
            Next
            txtTotal.Text = FormatCurrency(orderinfo(14))

            txtTax.Text = FormatCurrency(orderinfo(15))
            txtOrderTotal.Text = FormatCurrency(orderinfo(16))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        isDataSaved = True
    End Sub

    Private Sub frmChild_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Connect to the parent controller object
        'Child object doesn't create a new controller object
        'but instead uses the instace available in the parent form
        controller = CType(Me.ParentForm, frmMain).controller


        itemsMenu = controller.getMenu
        itemsPrices = controller.getPrices


        ' arrmenu = New String()() {itemsMenu, itemsPrices}


        cboItem1.Items.AddRange(itemsMenu)

        'Load menu into comboboxes

        ' itemsMenu = controller.getMenu()
        'itemsPrices = controller.getPrices()

        ' cboItem1.Items.AddRange(itemsMenu)
        'cboItem2.Items.AddRange(itemsMenu)
        'cboItem3.Items.AddRange(itemsMenu)
    End Sub

    

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Delete order using an ID

        'calls the clear event to clear form
        Try
            controller.Delete(txtID.Text)
            btnClear.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Deleting Item")
        End Try
        isDataSaved = True
    End Sub
    ' the following three sets the price depending on selected index


    Private Sub cboItem1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItem1.SelectedIndexChanged
        If cboItem1.SelectedIndex <> -1 Then
            '       txtPrice1.Text = itemsPrices(cboItem1.SelectedIndex)
        End If
    End Sub

    Private Sub cboItem2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItem2.SelectedIndexChanged
        If cboItem2.SelectedIndex <> -1 Then
            '      txtPrice2.Text = itemsPrices(cboItem2.SelectedIndex)
            counter += 1 'if not a negative index add one to counter
            'in order to add an additional detail line if needed

        End If
    End Sub

    Private Sub cboItem3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItem3.SelectedIndexChanged
        If cboItem3.SelectedIndex <> -1 Then
            '      txtPrice3.Text = itemsPrices(cboItem3.SelectedIndex)
            counter += 1
            'adds additional detail line if index is not -1
        End If
    End Sub
    Private Sub extraChargedChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoBtnPickup.CheckedChanged, rdoBtnDelivery.CheckedChanged
        'if delivery is checked, then 10 dollars are added if not 0/
        'also disables billing/shipping fields if order is pickup
        If rdoBtnDelivery.Checked Then
            txtShipCity.Enabled = True
            txtShipState.Enabled = True
            txtShipStreet.Enabled = True
            txtShipZip.Enabled = True
            txtBillCity.Enabled = True
            txtBillState.Enabled = True
            txtBillStreet.Enabled = True
            txtBillZip.Enabled = True
            txtShipCity.Text = ""
            txtShipState.Text = ""
            txtShipStreet.Text = ""
            txtShipZip.Text = ""
            txtBillCity.Text = ""
            txtBillState.Text = ""
            txtBillStreet.Text = ""
            txtBillZip.Text = ""
            txtDelivery.Text = "10.00"

        End If
        If rdoBtnPickup.Checked Then
            txtShipCity.Enabled = False
            txtShipState.Enabled = False
            txtShipStreet.Enabled = False
            txtShipZip.Enabled = False

            txtShipCity.Text = "N/A"
            txtShipState.Text = "NA"
            txtShipStreet.Text = "N/A"
            txtShipZip.Text = "N/A"
            txtDelivery.Text = "0.00"

        End If
    End Sub
    Private Sub chbxBilling_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbxBilling.CheckedChanged
        'if the same as billing is  checkbox is checked, 
        'then it sets the shipping info = to billing info
        If chbxBilling.Checked Then
            txtShipCity.Text = txtBillCity.Text
            txtShipState.Text = txtBillState.Text
            txtShipStreet.Text = txtBillStreet.Text
            txtShipZip.Text = txtBillZip.Text
            txtShipCity.Enabled = False
            txtShipState.Enabled = False
            txtShipStreet.Enabled = False
            txtShipZip.Enabled = False
        Else
            txtShipCity.Enabled = True
            txtShipState.Enabled = True
            txtShipStreet.Enabled = True
            txtShipZip.Enabled = True
            txtShipCity.Text = ""
            txtShipState.Text = ""
            txtShipStreet.Text = ""
            txtShipZip.Text = ""
        End If
    End Sub
    Private Sub DataChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItem1.SelectedIndexChanged,
        cboItem2.SelectedIndexChanged, cboItem3.SelectedIndexChanged, txtID.TextChanged, txtName.TextChanged, txtPhone.TextChanged, txtDate.TextChanged, txtQty1.TextChanged, txtQty2.TextChanged,
        txtQty3.TextChanged, txtBillStreet.TextChanged, txtBillCity.TextChanged, txtBillState.TextChanged, txtBillZip.TextChanged, txtShipCity.TextChanged,
        txtShipState.TextChanged, txtShipStreet.TextChanged, txtShipZip.TextChanged
        'if any change occurs on the fields, 
        'it sets isDataSaved to false
        isDataSaved = False
    End Sub

    Private Sub frmChild_FormClosing(ByVal sender As System.Object,
                ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'if field is set to false, 
        'then it asks if you want to save the active form prior to closing
        If isDataSaved = False Then
            Dim message As String =
                 "This form contains unsaved data." & vbCrLf & vbCrLf &
                 "Do you want to save it?"

            Dim button As DialogResult = MessageBox.Show(message, "Customer",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If button = DialogResult.Yes Then

                'Create an Arraylist to hold all the order Info
                Dim orderList As New ArrayList

                Try

                    btnSave.PerformClick()

                Catch ex As Exception
                    'Anything else
                    MessageBox.Show(ex.Message, "Error Saving Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Cancel = True
                End Try
            ElseIf button = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clears the form
        txtID.Text = ""
        txtName.Text = ""
        txtPhone.Text = ""
        txtDate.Text = ""
        txtPrice1.Text = ""
        txtPrice2.Text = ""
        txtPrice3.Text = ""
        txtQty1.Text = ""
        txtQty2.Text = ""
        txtQty3.Text = ""
        cboItem1.SelectedIndex = -1
        cboItem2.SelectedIndex = -1
        cboItem3.SelectedIndex = -1
        lblTotal1.Text = ""
        lblTotal2.Text = ""
        lblTotal3.Text = ""
        txtTotal.Text = ""
        txtDelivery.Text = ""
        txtTax.Text = ""
        txtOrderTotal.Text = ""
        txtBillStreet.Text = ""
        txtBillState.Text = ""
        txtBillCity.Text = ""
        txtBillZip.Text = ""
        txtShipCity.Text = ""
        txtShipState.Text = ""
        txtShipStreet.Text = ""
        txtShipZip.Text = ""
        rdoBtnDelivery.Checked = False
        chbxBilling.Checked = False
        rdoBtnPickup.Checked = False
        txtShipCity.Enabled = True
        txtShipState.Enabled = True
        txtShipStreet.Enabled = True
        txtShipZip.Enabled = True
        txtBillCity.Enabled = True
        txtBillState.Enabled = True
        txtBillStreet.Enabled = True
        txtBillZip.Enabled = True
        isDataSaved = True
    End Sub





End Class