Imports BusinessLib
Public Class frmOrder

    Private arrMenu()() As String
    Private arrMenuItems As String()
    Private arrMenuPrices As String()

    Private cboItemsList As New ArrayList
    Private lblLinesList As New ArrayList
    Private txtQtyList As New ArrayList
    Private lblPricesList As New ArrayList
    Private lblTotalsList As New ArrayList

    Private gstrSummary As String = ""

    Private controller As CController
    Private blnDirty As Boolean

    Private Sub addLine()
        addLabelLineNbr()
        addComboboxItem()
        addTextboxQty()
        addLabelPrice()
        addLabelTotal()
    End Sub

    Private Sub addComboboxItem()
        Dim i As Integer = cboItemsList.Count
        'Get the location from the existing control
        Dim iTop = lblLinesList(i - 1).Location.Y + lblLinesList(i - 1).height
        Dim iLeft = cboItemsList(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlCboItem As New ComboBox
        ctrlCboItem.Parent = Me.pnlDetails
        ctrlCboItem.DropDownStyle = ComboBoxStyle.DropDownList
        ctrlCboItem.Location = New Point(iLeft, iTop)
        ctrlCboItem.Width = cboItemsList(i - 1).Width
        ctrlCboItem.Height = cboItemsList(i - 1).Height
        ctrlCboItem.Items.AddRange(arrMenuItems)
        ctrlCboItem.Name = "cboItems" & i
        ctrlCboItem.Tag = i
        ctrlCboItem.Visible = True

        'Add the control to the panel
        Me.pnlDetails.Controls.Add(ctrlCboItem)

        'Add Handler
        AddHandler ctrlCboItem.SelectedIndexChanged, AddressOf SelectedIndexChangedHandler

        'Add control to our arraylist of controls
        cboItemsList.Add(ctrlCboItem)

    End Sub

    Private Sub addLabelLineNbr()
        Dim i As Integer = lblLinesList.Count
        'Get the location from the existing control
        Dim iTop = lblLinesList(i - 1).Location.Y + lblLinesList(i - 1).height
        Dim iLeft = lblLinesList(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlLblLine As New Label
        ctrlLblLine.Parent = Me.pnlDetails
        ctrlLblLine.Location = New Point(iLeft, iTop)
        ctrlLblLine.Width = lblLinesList(i - 1).Width
        ctrlLblLine.Height = lblLinesList(i - 1).Height
        ctrlLblLine.Text = i + 1
        ctrlLblLine.Name = "lblLine" & i
        ctrlLblLine.Tag = i
        ctrlLblLine.BorderStyle = CType(lblLinesList(i - 1), Label).BorderStyle
        ctrlLblLine.AutoSize = CType(lblLinesList(i - 1), Label).AutoSize
        ctrlLblLine.TextAlign = CType(lblLinesList(i - 1), Label).TextAlign
        ctrlLblLine.Visible = True

        'Add the control to the panel
        Me.pnlDetails.Controls.Add(ctrlLblLine)

        'Add control to our arraylist of controls
        lblLinesList.Add(ctrlLblLine)

    End Sub

    Private Sub addTextboxQty()
        Dim i As Integer = txtQtyList.Count
        'Get the location from the existing control
        Dim iTop = lblLinesList(i - 1).Location.Y + lblLinesList(i - 1).height
        Dim iLeft = txtQtyList(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlTxtQty As New TextBox
        ctrlTxtQty.Parent = Me.pnlDetails
        ctrlTxtQty.Location = New Point(iLeft, iTop)
        ctrlTxtQty.Width = txtQtyList(i - 1).Width
        ctrlTxtQty.Height = txtQtyList(i - 1).Height
        ctrlTxtQty.Text = 0
        ctrlTxtQty.Name = "txtQty" & i
        ctrlTxtQty.Tag = i
        ctrlTxtQty.Visible = True

        'Add the control to the panel
        Me.pnlDetails.Controls.Add(ctrlTxtQty)

        'Add control to our arraylist of controls
        txtQtyList.Add(ctrlTxtQty)

    End Sub

    Private Sub addLabelPrice()
        Dim i As Integer = lblPricesList.Count
        'Get the location from the existing control
        Dim iTop = lblLinesList(i - 1).Location.Y + lblLinesList(i - 1).height
        Dim iLeft = lblPricesList(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlLblPrice As New Label
        ctrlLblPrice.Parent = Me.pnlDetails
        ctrlLblPrice.Location = New Point(iLeft, iTop)
        ctrlLblPrice.Width = lblPricesList(i - 1).Width
        ctrlLblPrice.Height = lblPricesList(i - 1).Height
        ctrlLblPrice.Text = 0
        ctrlLblPrice.Name = "lblPrice" & i
        ctrlLblPrice.Tag = i
        ctrlLblPrice.BorderStyle = CType(lblPricesList(i - 1), Label).BorderStyle
        ctrlLblPrice.AutoSize = CType(lblPricesList(i - 1), Label).AutoSize
        ctrlLblPrice.TextAlign = CType(lblPricesList(i - 1), Label).TextAlign
        ctrlLblPrice.Visible = True

        'Add the control to the panel
        Me.pnlDetails.Controls.Add(ctrlLblPrice)

        'Add control to our arraylist of controls
        lblPricesList.Add(ctrlLblPrice)

    End Sub

    Private Sub addLabelTotal()
        Dim i As Integer = lblTotalsList.Count
        'Get the location from the existing control
        Dim iTop = lblLinesList(i - 1).Location.Y + lblLinesList(i - 1).height
        Dim iLeft = lblTotalsList(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlLblTotal As New Label
        ctrlLblTotal.Parent = Me.pnlDetails
        ctrlLblTotal.Location = New Point(iLeft, iTop)
        ctrlLblTotal.Width = lblTotalsList(i - 1).Width
        ctrlLblTotal.Height = lblTotalsList(i - 1).Height
        ctrlLblTotal.Text = 0
        ctrlLblTotal.Name = "lblTotal" & i
        ctrlLblTotal.Tag = i
        ctrlLblTotal.BorderStyle = CType(lblTotalsList(i - 1), Label).BorderStyle
        ctrlLblTotal.AutoSize = CType(lblTotalsList(i - 1), Label).AutoSize
        ctrlLblTotal.TextAlign = CType(lblTotalsList(i - 1), Label).TextAlign
        ctrlLblTotal.Visible = True

        'Add the control to the panel
        Me.pnlDetails.Controls.Add(ctrlLblTotal)

        'Add control to our arraylist of controls
        lblTotalsList.Add(ctrlLblTotal)

    End Sub

    Private Sub frmOrder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Add any initialization after the InitializeComponent() call.
        'Connect to the parent controller object
        'Child object doesn't create a new controller object
        'but instead uses the instance available in the parent form
        controller = CType(Me.ParentForm, frmMain).controller

        'Load our menu / prices
        arrMenuItems = controller.getMenus
        arrMenuPrices = controller.getPrices

        'put the menus / prices in a two dim array
        arrMenu = New String()() {arrMenuItems, arrMenuPrices}

        'Load the first control
        Me.cboItems0.Items.AddRange(arrMenuItems)

        'Add control to arraylist of controls
        cboItemsList.Add(Me.cboItems0)

        'ditto for the rest
        lblLinesList.Add(Me.lblLine0)
        txtQtyList.Add(Me.txtQty0)
        lblPricesList.Add(Me.lblPrice0)
        lblTotalsList.Add(Me.lblTotal0)

        'Add 5 lines
        For i As Integer = 0 To 3
            addLine()
        Next

        'Setup our dirty form handler
        Dirty_Handler()

        'Set our form to clean
        blnDirty = False
    End Sub


    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Try
            'Hold our Order Information
            Dim OrderInfoList As New ArrayList

            OrderInfoList.Add(Me.txtID.Text)                '0
            OrderInfoList.Add(Me.txtName.Text)              '1
            OrderInfoList.Add(Me.txtPhone.Text)             '2
            OrderInfoList.Add(Me.txtOrderDate.Text)
            OrderInfoList.Add(Me.radPickup.Checked)  '3
            OrderInfoList.Add(Me.chkSameAsBilling.Checked)  '8
            OrderInfoList.Add(Me.txtDeliveryStreet.Text)    '9
            OrderInfoList.Add(Me.txtDeliveryCity.Text)      '10
            OrderInfoList.Add(Me.txtDeliveryState.Text)     '11
            OrderInfoList.Add(Me.txtDeliveryZip.Text)       '12
            OrderInfoList.Add(Me.txtBillStreet.Text)        '4
            OrderInfoList.Add(Me.txtBillCity.Text)          '5
            OrderInfoList.Add(Me.txtBillState.Text)         '6
            OrderInfoList.Add(Me.txtBillZip.Text)           '7


            '13

            'Hold our Order Detail lines items
            Dim detailLinesList As New ArrayList
            For i As Integer = 0 To lblLinesList.Count - 1
                'hold info about a single line
                Dim arrItem(3) As String
                arrItem(0) = CType(lblLinesList(i), Label).Text
                arrItem(1) = CType(cboItemsList(i), ComboBox).Text
                arrItem(2) = CType(txtQtyList(i), TextBox).Text
                arrItem(3) = CType(lblPricesList(i), Label).Text
                detailLinesList.Add(arrItem)
            Next
            OrderInfoList.Add(detailLinesList)              '14

            controller.saveOrder(OrderInfoList)

            Do While controller.getError().Contains("Duplicate Order") = True
                If MessageBox.Show("Overwrite Order #" & txtID.Text & vbCrLf & vbCrLf & "This action cannot be undone", "Overwrite existing order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    controller.deleteOrder(txtID.Text)
                    controller.saveOrder(OrderInfoList)
                Else
                    Exit Sub
                End If
            Loop

            'Clear the provider (everything at once)
            ErrorProvider1.Clear()
            'Check for errors
            If controller.getError <> "" Then
                'Display the list of all errors
                MessageBox.Show(controller.getError, "Error saving order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                'Optional parse the errors and 
                'be more specific with the user
                parseError(controller.getError)
            Else
                'Display Totals
                With controller
                    For i As Integer = 0 To lblLinesList.Count - 1
                        CType(Me.lblTotalsList(i), Label).Text = .getLineTotal(txtID.Text, CType(lblLinesList(i), Label).Text)
                    Next
                    Me.lblSubTotal.Text = .getOrderSubTotal(txtID.Text)
                    Me.lblTax.Text = .getOrderTax(txtID.Text)
                    Me.lblDelivery.Text = .getOrderDeliveryFee(txtID.Text)
                    Me.lblOrderTotal.Text = .getOrderTotal(txtID.Text)

                    blnDirty = False
                End With


            End If
        Catch ex As Exception
            'Anything else
            MessageBox.Show(ex.Message, "Error Saving Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub parseError(ByVal s As String)
        'Quick parser
        'Error parser routine to display errors
        'specific to each control

        'Our error log is formatted as follow
        'For items on the order header
        'Control:Error Message
        '
        'for items on the order detail
        'Line:#:Control:Error Message

        'walk down the lines or errors and parse
        'them one line at a time
        Dim arrError() As String = Split(s, vbCrLf)
        For i As Integer = 0 To arrError.GetUpperBound(0)
            Dim arrErrorLine() As String = Split(arrError(i), ":")

            'Walk down the items in the error line and parse
            'them one item at a time
            For j As Integer = 0 To arrErrorLine.GetUpperBound(0)
                Dim iLine As Integer
                Dim ctrl As Control
                Dim sError As String

                'Check whether control or line item
                Select Case arrErrorLine(0)
                    Case "ID"           'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpHeader.Controls("txtID"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "Name"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpHeader.Controls("txtName"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "Phone"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpHeader.Controls("txtPhone"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "OrderDate"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpHeader.Controls("txtOrderDate"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "Detail"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.Controls("pnlDetails"), Panel)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "BillStreet"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpBill.Controls("txtBillStreet"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "BillCity"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpBill.Controls("txtBillCity"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "BillState"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpBill.Controls("txtBillState"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "BillZip"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpBill.Controls("txtBillZip"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "DeliveryStreet"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpDelivery.Controls("txtDeliveryStreet"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "DeliveryCity"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpDelivery.Controls("txtDeliveryCity"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "DeliveryState"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpDelivery.Controls("txtDeliveryState"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "DeliveryZip"         'Control
                        sError = arrErrorLine(1)
                        ctrl = CType(Me.grpDelivery.Controls("txtDeliveryZip"), TextBox)
                        ErrorProvider1.SetError(ctrl, sError)
                    Case "Line"         'Line Item
                        iLine = arrErrorLine(1)
                        sError = arrErrorLine(3)
                        Select Case arrErrorLine(2)
                            Case "Qty"  'Control
                                ctrl = CType(Me.pnlDetails.Controls("txtQty" & iLine - 1), TextBox)
                                ErrorProvider1.SetError(ctrl, sError)
                            Case "Item" 'Control
                                ctrl = CType(Me.pnlDetails.Controls("cboItems" & iLine - 1), ComboBox)
                                ErrorProvider1.SetError(ctrl, sError)
                            Case "Price" 'Control
                                ctrl = CType(Me.pnlDetails.Controls("lblPrice" & iLine - 1), Label)
                                ErrorProvider1.SetError(ctrl, sError)
                        End Select
                End Select
            Next
        Next
    End Sub

    Private Sub SelectedIndexChangedHandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItems0.SelectedIndexChanged
        If (sender.selectedindex > -1) Then
            lblPricesList(sender.tag).text = arrMenu(1)(sender.SelectedIndex)
            blnDirty = True
        End If
    End Sub

    Private Sub chkSameAsBilling_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSameAsBilling.CheckedChanged
        Dim blnChecked As Boolean = Not chkSameAsBilling.Checked
        txtDeliveryStreet.Enabled = blnChecked
        txtDeliveryCity.Enabled = blnChecked
        txtDeliveryState.Enabled = blnChecked
        txtDeliveryZip.Enabled = blnChecked

        If blnChecked = True Then
            txtDeliveryStreet.Text = ""
            txtDeliveryCity.Text = ""
            txtDeliveryState.Text = ""
            txtDeliveryZip.Text = ""
        End If

        blnDirty = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.lblOrderTotal.Text <> 0 AndAlso Me.lblOrderTotal.Text <> "$0.00" Then
            generateSummary()
            MessageBox.Show(gstrSummary, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show("No Receipt to print!", "Order Summary Receipt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub generateSummary()
        gstrSummary = ""
        gstrSummary += "Welcome to BuckStart Cafe" & vbCrLf & vbCrLf & _
        "Customer Name: " & txtName.Text & vbCrLf & _
        "Customer Phone: " & txtPhone.Text & vbCrLf & vbCrLf & _
        "Order ID: " & Me.txtID.Text & vbCrLf & _
        "Order Date: " & Me.txtOrderDate.Text & vbCrLf & vbCrLf & _
        "Subtotal: " & Me.lblSubTotal.Text & vbCrLf & _
        "Tax: " & Me.lblTax.Text & vbCrLf & _
        "Delivery: " & Me.lblDelivery.Text & vbCrLf & _
        "Total:" & Me.lblOrderTotal.Text & vbCrLf
    End Sub

    Private Sub btnAddLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLine.Click
        addLine()
    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        ' Clear_Controls()
        Retrieve_Order()
        blnDirty = False
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear_Controls()
    End Sub

    Private Sub Clear_Controls()
        Dim ctrl As Control
        'Clear Header
        For Each ctrl In Me.grpHeader.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""
                If ctrl.Name.Contains("Date") Then
                    ctrl.Text = Date.Today.ToString("d")
                End If
            End If
        Next
        'Clear Details
        For Each ctrl In pnlDetails.Controls
            If TypeOf (ctrl) Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
            End If
            If TypeOf (ctrl) Is TextBox And ctrl.Name.Contains("Qty") Then
                ctrl.Text = 0
            End If
            If TypeOf (ctrl) Is Label And (ctrl.Name.Contains("Price") Or ctrl.Name.Contains("Total")) Then
                ctrl.Text = 0
            End If
        Next
        'Clear Billing / Delivery
        For Each ctrl In Me.grpBill.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl In Me.grpDelivery.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        'Clear summary
        For Each ctrl In Me.grpSummary.Controls
            If TypeOf (ctrl) Is Label And ctrl.Name.Contains("lbl") Then
                ctrl.Text = "0"
            End If
        Next
        'Reset delivery
        radPickup.Checked = True
        'Reset same address
        chkSameAsBilling.Checked = True

        blnDirty = False
    End Sub

    Private Sub Retrieve_Order()
        Dim lstOrder As New ArrayList
        Dim lstOrderDetail As New ArrayList
        MessageBox.Show(txtID.Text)

        lstOrder = frmMain.controller.getOrder(txtID.Text)

        If frmMain.controller.getError <> "" Then
            MessageBox.Show(frmMain.controller.getError, "Error retrieving order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'Optional parse the errors and 
            'be more specific with the user
            parseError(frmMain.controller.getError)
        Else
            'Get order header info
            Me.txtID.Text = lstOrder(0)
            Me.txtName.Text = lstOrder(1)
            Me.txtPhone.Text = lstOrder(2)
            Me.txtOrderDate.Text = lstOrder(3)
            Me.radPickup.Checked = lstOrder(4)
            Me.chkSameAsBilling.Checked = lstOrder(5)
            Me.txtDeliveryStreet.Text = lstOrder(6)
            Me.txtDeliveryCity.Text = lstOrder(7)
            Me.txtDeliveryState.Text = lstOrder(8)
            Me.txtDeliveryZip.Text = lstOrder(9)

            Me.txtBillStreet.Text = lstOrder(10)
            Me.txtBillCity.Text = lstOrder(11)
            Me.txtBillState.Text = lstOrder(12)
            Me.txtBillZip.Text = lstOrder(13)
            'Me.radDelivery.Checked = Not lstOrder(14)
            Me.lblSubTotal.Text = lstOrder(14)
            Me.lblTax.Text = lstOrder(15)
            Me.lblDelivery.Text = lstOrder(16)
            Me.lblOrderTotal.Text = lstOrder(17)

            'get order detail info
            lstOrderDetail = lstOrder(18)

            For i As Integer = 0 To lstOrderDetail.Count - 1

                'store each item in the detail
                Dim arrItem() As String = lstOrderDetail(i)
                While (cboItemsList.Count < arrItem(0))
                    addLine()
                End While
                For j As Integer = 0 To lblLinesList.Count - 1
                    If CType(lblLinesList(j), Label).Text = arrItem(0) Then
                        'CType(lblLinesList(j), Label).Text = arrItem(0)
                        CType(cboItemsList(j), ComboBox).Text = arrItem(1)
                        CType(txtQtyList(j), TextBox).Text = arrItem(3)
                        CType(lblPricesList(j), Label).Text = arrItem(2)
                        CType(lblTotalsList(j), Label).Text = arrItem(4)
                    End If
                Next
            Next
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Clear_Controls()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete order (" & txtID.Text & ")" & vbCrLf & vbCrLf & "This action cannot be undone", "Delete order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            controller.deleteOrder(txtID.Text)
            If frmMain.controller.getError <> "" Then
                MessageBox.Show(frmMain.controller.getError, "Error retrieving order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                'Optional parse the errors and 
                'be more specific with the user
                parseError(frmMain.controller.getError)
            Else
                MessageBox.Show("Order Deleted!")
            End If
        End If
    End Sub

    Private Sub Track_Dirty(ByVal sender As System.Object, ByVal e As System.EventArgs)
        blnDirty = True
    End Sub

    Private Sub Dirty_Handler()
        'Add Handler
        Dim ctrl As Control
        'Clear Header
        For Each ctrl In Me.grpHeader.Controls
            If TypeOf (ctrl) Is TextBox Then
                AddHandler ctrl.TextChanged, AddressOf Track_Dirty
            End If
        Next
        'Clear Details
        For Each ctrl In pnlDetails.Controls
            If TypeOf (ctrl) Is TextBox And ctrl.Name.Contains("Qty") Then
                AddHandler ctrl.TextChanged, AddressOf Track_Dirty
            End If
        Next
        'Clear Billing / Delivery
        For Each ctrl In Me.grpBill.Controls
            If TypeOf (ctrl) Is TextBox Then
                AddHandler ctrl.TextChanged, AddressOf Track_Dirty
            End If
        Next
        For Each ctrl In Me.grpDelivery.Controls
            If TypeOf (ctrl) Is TextBox Then
                AddHandler ctrl.TextChanged, AddressOf Track_Dirty
            End If
        Next
        AddHandler radPickup.CheckedChanged, AddressOf Track_Dirty
    End Sub
    Private Sub frmOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnDirty = True Then
            If MessageBox.Show("Do you want to save your changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                btnProcess.PerformClick()
                e.Cancel = True
            End If
        End If
    End Sub
    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub

End Class