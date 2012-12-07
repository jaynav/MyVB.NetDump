Public Class ChangeMaster
    Inherits System.Windows.Forms.Form
    Dim QtyChosen As Integer = 0
    Dim curType As Decimal = 0
    Dim curTotal As Double = 0
    Dim total As Double = 0
    Dim intTotal As Double = 0
    Dim modtotal As Double = 0
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReset As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProcess As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents cbxbills As System.Windows.Forms.CheckBox
    Friend WithEvents cbo1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblch2 As System.Windows.Forms.Label
    Friend WithEvents lblch7 As System.Windows.Forms.Label
    Friend WithEvents lblch8 As System.Windows.Forms.Label
    Friend WithEvents lblch6 As System.Windows.Forms.Label
    Friend WithEvents lblch5 As System.Windows.Forms.Label
    Friend WithEvents lblch4 As System.Windows.Forms.Label
    Friend WithEvents lblch3 As System.Windows.Forms.Label
    Friend WithEvents lblch1 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnuProcess = New System.Windows.Forms.MenuItem
        Me.mnuReset = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.cbxbills = New System.Windows.Forms.CheckBox
        Me.cbo1 = New System.Windows.Forms.ComboBox
        Me.cbo2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblChange = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblch1 = New System.Windows.Forms.Label
        Me.lblch3 = New System.Windows.Forms.Label
        Me.lblch4 = New System.Windows.Forms.Label
        Me.lblch5 = New System.Windows.Forms.Label
        Me.lblch6 = New System.Windows.Forms.Label
        Me.lblch8 = New System.Windows.Forms.Label
        Me.lblch7 = New System.Windows.Forms.Label
        Me.lblch2 = New System.Windows.Forms.Label
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.mnuAdd)
        Me.MainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'mnuAdd
        '
        Me.mnuAdd.Text = "Add"
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.mnuProcess)
        Me.MenuItem2.MenuItems.Add(Me.mnuReset)
        Me.MenuItem2.MenuItems.Add(Me.mnuExit)
        Me.MenuItem2.Text = "Menu"
        '
        'mnuProcess
        '
        Me.mnuProcess.Text = "Process"
        '
        'mnuReset
        '
        Me.mnuReset.Text = "Reset"
        '
        'mnuExit
        '
        Me.mnuExit.Text = "Exit"
        '
        'cbxbills
        '
        Me.cbxbills.Font = New System.Drawing.Font("Nina", 8.0!, System.Drawing.FontStyle.Regular)
        Me.cbxbills.Location = New System.Drawing.Point(0, 0)
        Me.cbxbills.Size = New System.Drawing.Size(117, 16)
        Me.cbxbills.Text = "Bills? (Or Change)"
        '
        'cbo1
        '
        Me.cbo1.Font = New System.Drawing.Font("Nina", 8.0!, System.Drawing.FontStyle.Regular)
        Me.cbo1.Location = New System.Drawing.Point(96, 8)
        Me.cbo1.Size = New System.Drawing.Size(80, 20)
        '
        'cbo2
        '
        Me.cbo2.Font = New System.Drawing.Font("Nina", 8.0!, System.Drawing.FontStyle.Regular)
        Me.cbo2.Location = New System.Drawing.Point(96, 24)
        Me.cbo2.Size = New System.Drawing.Size(80, 20)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Nina", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(0, 12)
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.Text = "Select Item:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Nina", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(0, 28)
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.Text = "Select Qty:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Nina", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(-1, 44)
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.Text = "Money:"
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Nina", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lbl1.Location = New System.Drawing.Point(3, 0)
        Me.lbl1.Size = New System.Drawing.Size(67, 121)
        '
        'lbltotal
        '
        Me.lbltotal.Font = New System.Drawing.Font("Nina", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lbltotal.Location = New System.Drawing.Point(39, 43)
        Me.lbltotal.Size = New System.Drawing.Size(44, 16)
        Me.lbltotal.Text = "0"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Nina", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(86, 43)
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.Text = "Change:"
        '
        'lblChange
        '
        Me.lblChange.Font = New System.Drawing.Font("Nina", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lblChange.Location = New System.Drawing.Point(132, 44)
        Me.lblChange.Size = New System.Drawing.Size(44, 16)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel1.Controls.Add(Me.lbl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Size = New System.Drawing.Size(80, 121)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel2.Controls.Add(Me.lblch2)
        Me.Panel2.Controls.Add(Me.lblch7)
        Me.Panel2.Controls.Add(Me.lblch8)
        Me.Panel2.Controls.Add(Me.lblch6)
        Me.Panel2.Controls.Add(Me.lblch5)
        Me.Panel2.Controls.Add(Me.lblch4)
        Me.Panel2.Controls.Add(Me.lblch3)
        Me.Panel2.Controls.Add(Me.lblch1)
        Me.Panel2.Location = New System.Drawing.Point(96, 59)
        Me.Panel2.Size = New System.Drawing.Size(80, 121)
        '
        'lblch1
        '
        Me.lblch1.Font = New System.Drawing.Font("Nina", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblch1.Location = New System.Drawing.Point(0, 0)
        Me.lblch1.Size = New System.Drawing.Size(77, 15)
        '
        'lblch3
        '
        Me.lblch3.Font = New System.Drawing.Font("Nina", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblch3.Location = New System.Drawing.Point(0, 30)
        Me.lblch3.Size = New System.Drawing.Size(77, 15)
        '
        'lblch4
        '
        Me.lblch4.Font = New System.Drawing.Font("Nina", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblch4.Location = New System.Drawing.Point(0, 45)
        Me.lblch4.Size = New System.Drawing.Size(80, 15)
        '
        'lblch5
        '
        Me.lblch5.Font = New System.Drawing.Font("Nina", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblch5.Location = New System.Drawing.Point(0, 61)
        Me.lblch5.Size = New System.Drawing.Size(77, 15)
        '
        'lblch6
        '
        Me.lblch6.Font = New System.Drawing.Font("Nina", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblch6.Location = New System.Drawing.Point(0, 76)
        Me.lblch6.Size = New System.Drawing.Size(77, 15)
        '
        'lblch8
        '
        Me.lblch8.Font = New System.Drawing.Font("Nina", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblch8.Location = New System.Drawing.Point(0, 106)
        Me.lblch8.Size = New System.Drawing.Size(77, 15)
        '
        'lblch7
        '
        Me.lblch7.Font = New System.Drawing.Font("Nina", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblch7.Location = New System.Drawing.Point(0, 91)
        Me.lblch7.Size = New System.Drawing.Size(77, 15)
        '
        'lblch2
        '
        Me.lblch2.Font = New System.Drawing.Font("Nina", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblch2.Location = New System.Drawing.Point(0, 15)
        Me.lblch2.Size = New System.Drawing.Size(80, 15)
        '
        'ChangeMaster
        '
        Me.ClientSize = New System.Drawing.Size(176, 180)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.cbo2)
        Me.Controls.Add(Me.cbo1)
        Me.Controls.Add(Me.cbxbills)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Menu = Me.MainMenu1
        Me.Text = "Change Master"

    End Sub

#End Region

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        ' closes the application when done using 
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' when the form loads, it add the following to combo box one and combo box 2

        cbo1.Items.Add("hundreds")
        cbo1.Items.Add("fifties")
        cbo1.Items.Add("Twenties")
        cbo1.Items.Add("Tens")
        cbo1.Items.Add("Fives")
        cbo1.Items.Add("Ones")

        cbo1.Items.Add("Quarters")
        cbo1.Items.Add("Dimes")
        cbo1.Items.Add("Nickels")
        cbo1.Items.Add("Pennies")
        cbo2.Items.Add("1")
        cbo2.Items.Add("2")
        cbo2.Items.Add("3")
        cbo2.Items.Add("4")
        cbo2.Items.Add("5")
        cbo2.Items.Add("6")
        cbo2.Items.Add("7")
        cbo2.Items.Add("8")
        cbo2.Items.Add("9")

    End Sub


    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        'when the user clicks add, it will convert the selected index item into the appropriate value for both values

        If cbo1.SelectedIndex = -1 Then
            MessageBox.Show("Please Select A denomination")
        ElseIf cbo1.Text = "Quarters" Then
            curType = 0.25
        ElseIf cbo1.Text = "Dimes" Then
            curType = 0.1
        ElseIf cbo1.Text = "Nickels" Then
            curType = 0.05
        ElseIf cbo1.Text = "Pennies" Then
            curType = 0.01
        ElseIf cbo1.Text = "Ones" Then
            curType = 1
        ElseIf cbo1.Text = "Fives" Then
            curType = 5
        ElseIf cbo1.Text = "Tens" Then
            curType = 10
        ElseIf cbo1.Text = "Twenties" Then
            curType = 20
        ElseIf cbo1.Text = "fifties" Then
            curType = 50
        ElseIf cbo1.Text = "hundreds" Then
            curType = 100
        End If

        If cbo2.SelectedIndex = -1 Then
            MessageBox.Show("Add a Qty from 1 to 9")

        ElseIf cbo2.Text = "1" Then
            QtyChosen = 1
        ElseIf cbo2.Text = "2" Then
            QtyChosen = 2
        ElseIf cbo2.Text = "3" Then
            QtyChosen = 3
        ElseIf cbo2.Text = "4" Then
            QtyChosen = 4
        ElseIf cbo2.Text = "5" Then
            QtyChosen = 5
        ElseIf cbo2.Text = "6" Then
            QtyChosen = 6
        ElseIf cbo2.Text = "7" Then
            QtyChosen = 7
        ElseIf cbo2.Text = "8" Then
            QtyChosen = 8
        ElseIf cbo2.Text = "9" Then
            QtyChosen = 9

        End If

        ' multiplies the  currency by qty  then adds to total and shows the total
        curTotal = QtyChosen * curType
        total += curTotal
        lbltotal.Text = FormatCurrency(total)


        lbl1.Text += FormatCurrency(curType) & " x " & QtyChosen & vbCrLf

    End Sub


    Private Sub mnuReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReset.Click

        ' it clears the whole form if user decides to reset the total
        lbl1.Text = ""

        lblch1.Text = ""
        lblch2.Text = ""
        lblch3.Text = ""
        lblch4.Text = ""
        lblch5.Text = ""
        lblch6.Text = ""
        lblch7.Text = ""
        lblch8.Text = ""
        cbo1.SelectedIndex = -1
        cbo2.SelectedIndex = -1
        cbxbills.CheckState = CheckState.Unchecked
        lbltotal.Text = "0"
        lblChange.Text = ""
        total = 0
    End Sub
    Private Sub mnuProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProcess.Click

        'if the user clicks process depending if he wants bills with change or change only, it figures out the the change to 
        'give out depending on the combobox checked state
        lblChange.Text = FormatCurrency(total)


        If cbxbills.Checked Then
            modtotal = total Mod 20
            intTotal = Math.Floor(total) \ 20
            lblch1.Text = "$20.00 x " & intTotal

            intTotal = modtotal
            modtotal = intTotal Mod 10
            intTotal = Math.Floor(intTotal) \ 10
            lblch2.Text = "$10.00 x " & intTotal

            intTotal = modtotal
            modtotal = intTotal Mod 5
            intTotal = Math.Floor(intTotal) \ 5
            lblch3.Text = "$5.00 x " & intTotal

            intTotal = modtotal
            modtotal = intTotal Mod 1
            intTotal = Math.Floor(intTotal) \ 1
            lblch4.Text = "$1.00 x " & intTotal

            intTotal = modtotal
            intTotal = intTotal * 100
            modtotal = intTotal Mod 25
            intTotal = intTotal \ 25
            lblch5.Text = "$0.25 x " & intTotal

            intTotal = modtotal
            modtotal = intTotal Mod 10
            intTotal = intTotal \ 10
            lblch6.Text = "$0.10 x " & intTotal

            intTotal = modtotal
            modtotal = intTotal Mod 5
            intTotal = intTotal \ 5
            lblch7.Text = "$0.05 x " & intTotal

            intTotal = modtotal
            modtotal = intTotal Mod 1
            intTotal = intTotal \ 1
            lblch8.Text = "$0.01 x " & intTotal
        Else

            intTotal = total * 100
            modtotal = intTotal Mod 25
            intTotal = Math.Floor(intTotal) \ 25
            lblch1.Text = "$0.25 x " & intTotal

            intTotal = modtotal
            modtotal = intTotal Mod 10
            intTotal = Math.Floor(intTotal) \ 10
            lblch2.Text = "$0.10 x " & intTotal

            intTotal = modtotal
            modtotal = intTotal Mod 5
            intTotal = Math.Floor(intTotal) \ 5
            lblch3.Text = "$0.05 x " & intTotal

            intTotal = modtotal
            modtotal = intTotal Mod 1
            intTotal = Math.Floor(intTotal) \ 1
            lblch4.Text = "$0.01 x " & intTotal

            lblch5.Text = ""
            lblch6.Text = ""
            lblch7.Text = ""
            lblch8.Text = ""
        End If

    End Sub
End Class