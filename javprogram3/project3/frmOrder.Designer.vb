<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.lblTotal0 = New System.Windows.Forms.Label()
        Me.lblPrice0 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboItems0 = New System.Windows.Forms.ComboBox()
        Me.lblLine0 = New System.Windows.Forms.Label()
        Me.txtQty0 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpBill = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBillZip = New System.Windows.Forms.TextBox()
        Me.txtBillState = New System.Windows.Forms.TextBox()
        Me.txtBillCity = New System.Windows.Forms.TextBox()
        Me.txtBillStreet = New System.Windows.Forms.TextBox()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.chkSameAsBilling = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeliveryZip = New System.Windows.Forms.TextBox()
        Me.txtDeliveryState = New System.Windows.Forms.TextBox()
        Me.txtDeliveryCity = New System.Windows.Forms.TextBox()
        Me.txtDeliveryStreet = New System.Windows.Forms.TextBox()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblOrderTotal = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.grpHeader = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrderDate = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.radDelivery = New System.Windows.Forms.RadioButton()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnAddLine = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grpBill.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        Me.grpHeader.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDetails
        '
        Me.pnlDetails.AutoScroll = True
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDetails.Controls.Add(Me.lblTotal0)
        Me.pnlDetails.Controls.Add(Me.lblPrice0)
        Me.pnlDetails.Controls.Add(Me.Label29)
        Me.pnlDetails.Controls.Add(Me.Label28)
        Me.pnlDetails.Controls.Add(Me.Label27)
        Me.pnlDetails.Controls.Add(Me.Label26)
        Me.pnlDetails.Controls.Add(Me.Label25)
        Me.pnlDetails.Controls.Add(Me.cboItems0)
        Me.pnlDetails.Controls.Add(Me.lblLine0)
        Me.pnlDetails.Controls.Add(Me.txtQty0)
        Me.pnlDetails.Location = New System.Drawing.Point(5, 48)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(491, 167)
        Me.pnlDetails.TabIndex = 1
        '
        'lblTotal0
        '
        Me.lblTotal0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal0.Location = New System.Drawing.Point(380, 21)
        Me.lblTotal0.Name = "lblTotal0"
        Me.lblTotal0.Size = New System.Drawing.Size(68, 20)
        Me.lblTotal0.TabIndex = 4
        Me.lblTotal0.Text = "0"
        Me.lblTotal0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice0
        '
        Me.lblPrice0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice0.Location = New System.Drawing.Point(306, 21)
        Me.lblPrice0.Name = "lblPrice0"
        Me.lblPrice0.Size = New System.Drawing.Size(68, 20)
        Me.lblPrice0.TabIndex = 3
        Me.lblPrice0.Text = "0"
        Me.lblPrice0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(377, 4)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(31, 13)
        Me.Label29.TabIndex = 73
        Me.Label29.Text = "Total"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(304, 4)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(31, 13)
        Me.Label28.TabIndex = 72
        Me.Label28.Text = "Price"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(267, 4)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(23, 13)
        Me.Label27.TabIndex = 71
        Me.Label27.Text = "Qty"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(35, 4)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(27, 13)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "Item"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(2, 4)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(27, 13)
        Me.Label25.TabIndex = 69
        Me.Label25.Text = "Line"
        '
        'cboItems0
        '
        Me.cboItems0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItems0.FormattingEnabled = True
        Me.cboItems0.Location = New System.Drawing.Point(30, 21)
        Me.cboItems0.Name = "cboItems0"
        Me.cboItems0.Size = New System.Drawing.Size(230, 21)
        Me.cboItems0.TabIndex = 1
        '
        'lblLine0
        '
        Me.lblLine0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine0.Location = New System.Drawing.Point(5, 21)
        Me.lblLine0.Name = "lblLine0"
        Me.lblLine0.Size = New System.Drawing.Size(22, 20)
        Me.lblLine0.TabIndex = 0
        Me.lblLine0.Text = "1"
        '
        'txtQty0
        '
        Me.txtQty0.Location = New System.Drawing.Point(266, 21)
        Me.txtQty0.Name = "txtQty0"
        Me.txtQty0.Size = New System.Drawing.Size(35, 20)
        Me.txtQty0.TabIndex = 2
        Me.txtQty0.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.grpBill)
        Me.Panel2.Controls.Add(Me.grpDelivery)
        Me.Panel2.Location = New System.Drawing.Point(6, 221)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 144)
        Me.Panel2.TabIndex = 3
        '
        'grpBill
        '
        Me.grpBill.Controls.Add(Me.Label9)
        Me.grpBill.Controls.Add(Me.Label10)
        Me.grpBill.Controls.Add(Me.Label11)
        Me.grpBill.Controls.Add(Me.Label12)
        Me.grpBill.Controls.Add(Me.txtBillZip)
        Me.grpBill.Controls.Add(Me.txtBillState)
        Me.grpBill.Controls.Add(Me.txtBillCity)
        Me.grpBill.Controls.Add(Me.txtBillStreet)
        Me.grpBill.Location = New System.Drawing.Point(7, 13)
        Me.grpBill.Name = "grpBill"
        Me.grpBill.Size = New System.Drawing.Size(203, 108)
        Me.grpBill.TabIndex = 0
        Me.grpBill.TabStop = False
        Me.grpBill.Text = "Billing Info"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Street:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(114, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "State:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(155, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Zip:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "City:"
        '
        'txtBillZip
        '
        Me.txtBillZip.Location = New System.Drawing.Point(149, 79)
        Me.txtBillZip.Name = "txtBillZip"
        Me.txtBillZip.Size = New System.Drawing.Size(48, 20)
        Me.txtBillZip.TabIndex = 3
        '
        'txtBillState
        '
        Me.txtBillState.Location = New System.Drawing.Point(115, 79)
        Me.txtBillState.Name = "txtBillState"
        Me.txtBillState.Size = New System.Drawing.Size(28, 20)
        Me.txtBillState.TabIndex = 2
        '
        'txtBillCity
        '
        Me.txtBillCity.Location = New System.Drawing.Point(9, 79)
        Me.txtBillCity.Name = "txtBillCity"
        Me.txtBillCity.Size = New System.Drawing.Size(101, 20)
        Me.txtBillCity.TabIndex = 1
        '
        'txtBillStreet
        '
        Me.txtBillStreet.Location = New System.Drawing.Point(7, 34)
        Me.txtBillStreet.Name = "txtBillStreet"
        Me.txtBillStreet.Size = New System.Drawing.Size(188, 20)
        Me.txtBillStreet.TabIndex = 0
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.chkSameAsBilling)
        Me.grpDelivery.Controls.Add(Me.Label8)
        Me.grpDelivery.Controls.Add(Me.Label7)
        Me.grpDelivery.Controls.Add(Me.Label6)
        Me.grpDelivery.Controls.Add(Me.Label5)
        Me.grpDelivery.Controls.Add(Me.txtDeliveryZip)
        Me.grpDelivery.Controls.Add(Me.txtDeliveryState)
        Me.grpDelivery.Controls.Add(Me.txtDeliveryCity)
        Me.grpDelivery.Controls.Add(Me.txtDeliveryStreet)
        Me.grpDelivery.Location = New System.Drawing.Point(7, 128)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(203, 111)
        Me.grpDelivery.TabIndex = 12
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Delivery Info"
        '
        'chkSameAsBilling
        '
        Me.chkSameAsBilling.AutoSize = True
        Me.chkSameAsBilling.Checked = True
        Me.chkSameAsBilling.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSameAsBilling.Location = New System.Drawing.Point(87, 10)
        Me.chkSameAsBilling.Name = "chkSameAsBilling"
        Me.chkSameAsBilling.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSameAsBilling.Size = New System.Drawing.Size(97, 17)
        Me.chkSameAsBilling.TabIndex = 0
        Me.chkSameAsBilling.Text = "Same as Billing"
        Me.chkSameAsBilling.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Street:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(156, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Zip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "City:"
        '
        'txtDeliveryZip
        '
        Me.txtDeliveryZip.Location = New System.Drawing.Point(150, 77)
        Me.txtDeliveryZip.Name = "txtDeliveryZip"
        Me.txtDeliveryZip.Size = New System.Drawing.Size(47, 20)
        Me.txtDeliveryZip.TabIndex = 4
        '
        'txtDeliveryState
        '
        Me.txtDeliveryState.Location = New System.Drawing.Point(116, 77)
        Me.txtDeliveryState.Name = "txtDeliveryState"
        Me.txtDeliveryState.Size = New System.Drawing.Size(28, 20)
        Me.txtDeliveryState.TabIndex = 3
        '
        'txtDeliveryCity
        '
        Me.txtDeliveryCity.Location = New System.Drawing.Point(10, 77)
        Me.txtDeliveryCity.Name = "txtDeliveryCity"
        Me.txtDeliveryCity.Size = New System.Drawing.Size(101, 20)
        Me.txtDeliveryCity.TabIndex = 2
        '
        'txtDeliveryStreet
        '
        Me.txtDeliveryStreet.Location = New System.Drawing.Point(8, 32)
        Me.txtDeliveryStreet.Name = "txtDeliveryStreet"
        Me.txtDeliveryStreet.Size = New System.Drawing.Size(188, 20)
        Me.txtDeliveryStreet.TabIndex = 1
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.Label30)
        Me.grpSummary.Controls.Add(Me.lblTax)
        Me.grpSummary.Controls.Add(Me.Label15)
        Me.grpSummary.Controls.Add(Me.Label14)
        Me.grpSummary.Controls.Add(Me.Label13)
        Me.grpSummary.Controls.Add(Me.lblOrderTotal)
        Me.grpSummary.Controls.Add(Me.lblDelivery)
        Me.grpSummary.Controls.Add(Me.lblSubTotal)
        Me.grpSummary.Location = New System.Drawing.Point(276, 259)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(220, 104)
        Me.grpSummary.TabIndex = 13
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Order Total"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(5, 41)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 13)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Tax: @ 7.25%"
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(90, 37)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(119, 20)
        Me.lblTax.TabIndex = 11
        Me.lblTax.Text = "0"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Order Total"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Delivery Charge:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "SubTotal:"
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderTotal.Location = New System.Drawing.Point(90, 77)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(119, 20)
        Me.lblOrderTotal.TabIndex = 2
        Me.lblOrderTotal.Text = "0"
        Me.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDelivery
        '
        Me.lblDelivery.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblDelivery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDelivery.Location = New System.Drawing.Point(90, 57)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(119, 20)
        Me.lblDelivery.TabIndex = 1
        Me.lblDelivery.Text = "0"
        Me.lblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(90, 17)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(119, 20)
        Me.lblSubTotal.TabIndex = 0
        Me.lblSubTotal.Text = "0"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpHeader
        '
        Me.grpHeader.Controls.Add(Me.Label4)
        Me.grpHeader.Controls.Add(Me.Label3)
        Me.grpHeader.Controls.Add(Me.Label2)
        Me.grpHeader.Controls.Add(Me.Label1)
        Me.grpHeader.Controls.Add(Me.txtOrderDate)
        Me.grpHeader.Controls.Add(Me.txtPhone)
        Me.grpHeader.Controls.Add(Me.txtName)
        Me.grpHeader.Controls.Add(Me.txtID)
        Me.grpHeader.Location = New System.Drawing.Point(5, -3)
        Me.grpHeader.Name = "grpHeader"
        Me.grpHeader.Size = New System.Drawing.Size(491, 45)
        Me.grpHeader.TabIndex = 0
        Me.grpHeader.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ID"
        '
        'txtOrderDate
        '
        Me.txtOrderDate.Location = New System.Drawing.Point(419, 14)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.Size = New System.Drawing.Size(63, 20)
        Me.txtOrderDate.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(309, 14)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(78, 20)
        Me.txtPhone.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(135, 14)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(133, 20)
        Me.txtName.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(25, 15)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(67, 20)
        Me.txtID.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.radDelivery)
        Me.GroupBox5.Controls.Add(Me.radPickup)
        Me.GroupBox5.Location = New System.Drawing.Point(276, 217)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(220, 42)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Delivery Option"
        '
        'radDelivery
        '
        Me.radDelivery.AutoSize = True
        Me.radDelivery.Location = New System.Drawing.Point(116, 19)
        Me.radDelivery.Name = "radDelivery"
        Me.radDelivery.Size = New System.Drawing.Size(93, 17)
        Me.radDelivery.TabIndex = 1
        Me.radDelivery.Text = "Delivery + $10"
        Me.radDelivery.UseVisualStyleBackColor = True
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Checked = True
        Me.radPickup.Location = New System.Drawing.Point(16, 19)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(58, 17)
        Me.radPickup.TabIndex = 0
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(433, 375)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(64, 28)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.Text = "&Save"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(352, 375)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 28)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(109, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 28)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "&Receipt"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnAddLine
        '
        Me.btnAddLine.Location = New System.Drawing.Point(28, 375)
        Me.btnAddLine.Name = "btnAddLine"
        Me.btnAddLine.Size = New System.Drawing.Size(64, 28)
        Me.btnAddLine.TabIndex = 7
        Me.btnAddLine.Text = "&Add Line"
        Me.btnAddLine.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(190, 375)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(64, 28)
        Me.btnRetrieve.TabIndex = 8
        Me.btnRetrieve.Text = "R&etrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(271, 375)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 28)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 415)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnAddLine)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.grpHeader)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOrder"
        Me.Text = "Order Form"
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.grpBill.ResumeLayout(False)
        Me.grpBill.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.grpHeader.ResumeLayout(False)
        Me.grpHeader.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents grpBill As System.Windows.Forms.GroupBox
    Friend WithEvents chkSameAsBilling As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBillZip As System.Windows.Forms.TextBox
    Friend WithEvents txtBillState As System.Windows.Forms.TextBox
    Friend WithEvents txtBillCity As System.Windows.Forms.TextBox
    Friend WithEvents txtBillStreet As System.Windows.Forms.TextBox
    Friend WithEvents grpDelivery As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDeliveryZip As System.Windows.Forms.TextBox
    Friend WithEvents txtDeliveryState As System.Windows.Forms.TextBox
    Friend WithEvents txtDeliveryCity As System.Windows.Forms.TextBox
    Friend WithEvents txtDeliveryStreet As System.Windows.Forms.TextBox
    Friend WithEvents grpSummary As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblOrderTotal As System.Windows.Forms.Label
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents grpHeader As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOrderDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents radDelivery As System.Windows.Forms.RadioButton
    Friend WithEvents radPickup As System.Windows.Forms.RadioButton
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents cboItems0 As System.Windows.Forms.ComboBox
    Friend WithEvents lblLine0 As System.Windows.Forms.Label
    Friend WithEvents txtQty0 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblTotal0 As System.Windows.Forms.Label
    Friend WithEvents lblPrice0 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents btnAddLine As System.Windows.Forms.Button
    Friend WithEvents btnRetrieve As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
