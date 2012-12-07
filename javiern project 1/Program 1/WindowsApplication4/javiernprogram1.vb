Public Class MPFCCalculator
    Public stestno As Integer = 0
    Public vtested As Integer = 0
    Public mtravel As Integer = 0
    Public fcells As Integer = 0
    Public TCost As Integer = 0

    ' this is the start of the btn process
    Private Sub BtnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim strError As String = ""
        'this declares start and end mileage 
        Dim dataStmilage1 As Integer = 0
        Dim dataStmilage2 As Integer = 0
        Dim dataStmilage3 As Integer = 0
        Dim dataStmilage4 As Integer = 0
        Dim dataEdmilage1 As Integer = 0
        Dim dataEdmilage2 As Integer = 0
        Dim dataEdmilage3 As Integer = 0
        Dim dataEdmilage4 As Integer = 0
        'declares  test info inventor info, and driver info
        Dim testno As String = ""
        Dim testDate As String = ""
        Dim inventFName As String = ""
        Dim inventLName As String = ""

        ' this declares start and end fuel use
        Dim dataStartfuel1 As Integer = 0
        Dim dataStartfuel2 As Integer = 0
        Dim dataStartfuel3 As Integer = 0
        Dim dataStartfuel4 As Integer = 0
        Dim dataEndfuel1 As Integer = 0
        Dim dataEndfuel2 As Integer = 0
        Dim dataEndfuel3 As Integer = 0
        Dim dataEndfuel4 As Integer = 0
        ' this determines  miles traveled and fuel used
        Dim dataTotalMiles1 As Integer = 0
        Dim dataTotalMiles2 As Integer = 0
        Dim dataTotalMiles3 As Integer = 0
        Dim dataTotalMiles4 As Integer = 0
        Dim dataTotalFuel1 As Integer = 0
        Dim dataTotalFuel2 As Integer = 0
        Dim dataTotalFuel3 As Integer = 0
        Dim dataTotalFuel4 As Integer = 0
        Dim resMpg1 As Double = 0
        Dim resMpg2 As Double = 0
        Dim resMpg3 As Double = 0
        Dim resMpg4 As Double = 0
        Dim carcounter As Integer = 0
        'displays inventor info entered
        Try

            If (IsDate(txtDate.Text) = False) Then
                strError += "Invalid date" & vbCrLf
            End If
            If (cboBxDId.SelectedIndex = -1) Then
                strError += "no iD# selected" & vbCrLf
            End If
            If (cboBxV1.SelectedIndex = -1) Then
                strError += "no vehicle 1 selected" & vbCrLf
            End If
            If (cboBxV2.SelectedIndex = -1) Then
                strError += "no vehicle 2 slected" & vbCrLf
            End If
            If (cboBxV3.SelectedIndex = -1) Then
                strError += "no vehicle 3 slected" & vbCrLf
            End If
            If (cboBxV4.SelectedIndex = -1) Then
                strError += "no vehicle 4 slected" & vbCrLf
            End If

            If (txtTestNo.Text = Nothing) Then
                strError += "Test No" & vbCrLf
            End If
            If (txtFname.Text = Nothing) Then
                strError += "first name" & vbCrLf
            End If
            If (txtLname.Text = Nothing) Then
                strError += "last name" & vbCrLf
            End If


            If (IsNumeric(txtSmile1.Text) = True AndAlso Integer.TryParse(txtSmile1.Text, dataStmilage1) = True) AndAlso (dataStmilage1 >= 0) Then

            Else
                strError += "Start mile box 1 invalid" & vbCrLf
            End If
            If (IsNumeric(txtSmile2.Text) = True AndAlso Integer.TryParse(txtSmile2.Text, dataStmilage2) = True) AndAlso (dataStmilage2 >= 0) Then
            Else
                strError += "Start mile box 2 invalid" & vbCrLf
            End If
            If (IsNumeric(txtSmile3.Text) = True AndAlso Integer.TryParse(txtSmile3.Text, dataStmilage3) = True) AndAlso (dataStmilage3 >= 0) Then
            Else
                strError += "Start mile box 3 invalid" & vbCrLf
            End If
            If (IsNumeric(txtSmile4.Text) = True AndAlso Integer.TryParse(txtSmile4.Text, dataStmilage4) = True) AndAlso (dataStmilage4 >= 0) Then
            Else
                strError += "Start mile box 4 invalid" & vbCrLf
            End If


            If (IsNumeric(txtEmile1.Text) = True AndAlso Integer.TryParse(txtEmile1.Text, dataEdmilage1) = True) AndAlso (dataEdmilage1 >= 0) Then
            Else
                strError += "End mile box 1 invalid" & vbCrLf
            End If
            If (IsNumeric(txtEmile2.Text) = True AndAlso Integer.TryParse(txtEmile2.Text, dataEdmilage2) = True) AndAlso (dataEdmilage2 >= 0) Then
            Else
                strError += "End mile box 2 invalid" & vbCrLf
            End If
            If (IsNumeric(txtEmile3.Text) = True AndAlso Integer.TryParse(txtEmile3.Text, dataEdmilage3) = True) AndAlso (dataEdmilage3 >= 0) Then
            Else
                strError += "End mile box 3 invalid" & vbCrLf
            End If
            If (IsNumeric(txtEmile4.Text) = True AndAlso Integer.TryParse(txtEmile4.Text, dataEdmilage4) = True) AndAlso (dataEdmilage4 >= 0) Then
            Else
                strError += "End mile box 4 invalid" & vbCrLf
            End If




            If (IsNumeric(txtSfuel1.Text) = True AndAlso Integer.TryParse(txtSfuel1.Text, dataStartfuel1) = True) AndAlso (dataStartfuel1 >= 0) Then
            Else
                strError += "start fuel box 1 invalid" & vbCrLf
            End If
            If (IsNumeric(txtSfuel2.Text) = True AndAlso Integer.TryParse(txtSfuel2.Text, dataStartfuel2) = True) AndAlso (dataStartfuel2 >= 0) Then
            Else
                strError += "start fuel box 2 invalid" & vbCrLf
            End If
            If (IsNumeric(txtSfuel3.Text) = True AndAlso Integer.TryParse(txtSfuel3.Text, dataStartfuel3) = True) AndAlso (dataStartfuel3 >= 0) Then
            Else
                strError += "start fuel box 3 invalid" & vbCrLf
            End If
            If (IsNumeric(txtSfuel4.Text) = True AndAlso Integer.TryParse(txtSfuel4.Text, dataStartfuel4) = True) AndAlso (dataStartfuel4 >= 0) Then
            Else
                strError += "start fuel box 4 invalid" & vbCrLf
            End If



            If (IsNumeric(txtEfuel1.Text) = True AndAlso Integer.TryParse(txtEfuel1.Text, dataEndfuel1) = True) AndAlso (dataEndfuel1 >= 0) Then
            Else
                strError += "end fuel box 1 invalid" & vbCrLf
            End If
            If (IsNumeric(txtEfuel2.Text) = True AndAlso Integer.TryParse(txtEfuel2.Text, dataEndfuel2) = True) AndAlso (dataEndfuel2 >= 0) Then
            Else
                strError += "end fuel box 2 invalid" & vbCrLf
            End If
            If (IsNumeric(txtEfuel3.Text) = True AndAlso Integer.TryParse(txtEfuel3.Text, dataEndfuel3) = True) AndAlso (dataEndfuel3 >= 0) Then
            Else
                strError += "end fuel box 3 invalid" & vbCrLf
            End If
            If (IsNumeric(txtEfuel4.Text) = True AndAlso Integer.TryParse(txtEfuel4.Text, dataEndfuel4) = True) AndAlso (dataEndfuel4 >= 0) Then
            Else
                strError += "end fuel box 4 invalid" & vbCrLf
            End If



            If strError <> "" Then
                MessageBox.Show("fix the following:" & vbCrLf & vbCrLf & strError)

                ' none of this will execute untill all the required fields are met.
            Else


                'vehicle 1 selection
                If cboBxV1.Text = "Hornet" Then
                    txtResVehicle1.Text = "Hornet"
                    txtResFam1.Text = "Human"
                    carcounter += 1
                ElseIf cboBxV1.Text = "Ghost" Then
                    txtResVehicle1.Text = "Ghost"
                    txtResFam1.Text = "Covenant"
                    carcounter += 1
                ElseIf cboBxV1.Text = "Chopper" Then
                    txtResVehicle1.Text = "Chopper"
                    txtResFam1.Text = "Brute"
                    carcounter += 1
                ElseIf cboBxV1.Text = "Banshee" Then
                    txtResVehicle1.Text = "Banshee"
                    txtResFam1.Text = "Covenant"
                    carcounter += 1
                End If
                'vehicle 2 selection 
                If cboBxV2.Text = "Hornet" Then
                    txtResVehicle2.Text = "Hornet"
                    txtResFam2.Text = "Human"
                    carcounter += 1
                ElseIf cboBxV2.Text = "Ghost" Then
                    txtResVehicle2.Text = "Ghost"
                    txtResFam2.Text = "Covenant"
                    carcounter += 1
                ElseIf cboBxV2.Text = "Chopper" Then
                    txtResVehicle2.Text = "Chopper"
                    txtResFam2.Text = "Brute"
                    carcounter += 1
                ElseIf cboBxV2.Text = "Banshee" Then
                    txtResVehicle2.Text = "Banshee"
                    txtResFam2.Text = "Covenant"
                    carcounter += 1
                End If
                'vehicle 3 selection
                If cboBxV3.Text = "Hornet" Then
                    txtResVehicle3.Text = "Hornet"
                    txtResFam3.Text = "Human"
                    carcounter += 1
                ElseIf cboBxV3.Text = "Ghost" Then
                    txtResVehicle3.Text = "Ghost"
                    txtResFam3.Text = "Covenant"
                    carcounter += 1
                ElseIf cboBxV3.Text = "Chopper" Then
                    txtResVehicle3.Text = "Chopper"
                    txtResFam3.Text = "Brute"
                    carcounter += 1
                ElseIf cboBxV3.Text = "Banshee" Then
                    txtResVehicle3.Text = "Banshee"
                    txtResFam3.Text = "Covenant"
                    carcounter += 1
                End If
                'vehichle 4 selection
                If cboBxV4.Text = "Hornet" Then
                    txtResVehicle4.Text = "Hornet"
                    txtResFam4.Text = "Human"
                    carcounter += 1
                ElseIf cboBxV4.Text = "Ghost" Then
                    txtResVehicle4.Text = "Ghost"
                    txtResFam4.Text = "Covenant"
                    carcounter += 1
                ElseIf cboBxV4.Text = "Chopper" Then
                    txtResVehicle4.Text = "Chopper"
                    txtResFam4.Text = "Brute"
                    carcounter += 1
                ElseIf cboBxV4.Text = "Banshee" Then
                    txtResVehicle4.Text = "Banshee"
                    txtResFam4.Text = "Convenant"
                    carcounter += 1
                End If




                ' cal calculates total miles and total fuel

                dataTotalMiles1 = dataEdmilage1 - dataStmilage1
                dataTotalMiles2 = dataEdmilage2 - dataStmilage2
                dataTotalMiles3 = dataEdmilage3 - dataStmilage3
                dataTotalMiles4 = dataEdmilage4 - dataStmilage4
                dataTotalFuel1 = dataStartfuel1 - dataEndfuel1
                dataTotalFuel2 = dataStartfuel2 - dataEndfuel2
                dataTotalFuel3 = dataStartfuel3 - dataEndfuel3
                dataTotalFuel4 = dataStartfuel4 - dataEndfuel4

                'displays fuel used in fuel used box and mileage       
                Me.txtResFused1.Text = dataTotalFuel1
                Me.txtResFused2.Text = dataTotalFuel2
                Me.txtResFused3.Text = dataTotalFuel3
                Me.txtResFused4.Text = dataTotalFuel4
                Me.txtResMile1.Text = dataTotalMiles1
                Me.txtResMile2.Text = dataTotalMiles2
                Me.txtResMile3.Text = dataTotalMiles3
                Me.txtResMile4.Text = dataTotalMiles4

                ' displays fuel cell cost
                Me.txtResFCost1.Text = FormatCurrency(dataTotalFuel1 * 22.0, 2)
                Me.txtResFCost2.Text = FormatCurrency(dataTotalFuel2 * 22.0, 2)
                Me.txtResFCost3.Text = FormatCurrency(dataTotalFuel3 * 22.0, 2)
                Me.txtResFCost4.Text = FormatCurrency(dataTotalFuel4 * 22.0, 2)

                ' this gives the MPG rating 
                resMpg1 = dataTotalMiles1 / dataTotalFuel1
                resMpg2 = dataTotalMiles2 / dataTotalFuel2
                resMpg3 = dataTotalMiles3 / dataTotalFuel3
                resMpg4 = dataTotalMiles4 / dataTotalFuel4

                If resMpg1 <= 200 Then
                    Me.txtMPFC1.Text = "Guzzler"
                ElseIf resMpg1 >= 201 And resMpg1 <= 300 Then
                    Me.txtMPFC1.Text = "Economical"
                Else
                    Me.txtMPFC1.Text = "Amazing"
                End If
                If resMpg2 <= 200 Then
                    Me.txtMPFC2.Text = "Guzzler"
                ElseIf resMpg2 >= 201 And resMpg2 <= 300 Then
                    Me.txtMPFC2.Text = "Economical"
                Else
                    Me.txtMPFC2.Text = "Amazing"
                End If
                If resMpg3 <= 200 Then
                    Me.txtMPFC3.Text = "Guzzler"
                ElseIf resMpg3 >= 201 And resMpg3 <= 300 Then
                    Me.txtMPFC3.Text = "Economical"
                Else
                    Me.txtMPFC3.Text = "Amazing"
                End If
                If resMpg4 <= 200 Then
                    Me.txtMPFC4.Text = "Guzzler"
                ElseIf resMpg4 >= 201 And resMpg4 <= 300 Then
                    Me.txtMPFC4.Text = "Economical"
                Else
                    Me.txtMPFC4.Text = "Amazing"
                End If





                'this are counters for the summary All Test buttons
                stestno = stestno + 1
                vtested = vtested + carcounter
                mtravel = mtravel + dataTotalMiles1 + dataTotalMiles2 + dataTotalMiles3 + dataTotalMiles4
                fcells = fcells + dataTotalFuel1 + dataTotalFuel2 + dataTotalFuel3 + dataTotalFuel4
                TCost = TCost + (dataTotalFuel1 * 22.0) + (dataTotalFuel2 * 22.0) + (dataTotalFuel3 * 22.0) + (dataTotalFuel4 * 22.0)

            End If




        Catch ex As InvalidCastException
            MessageBox.Show(ex.Message & vbCrLf &
                      ex.GetType.ToString &
                         vbCrLf & ex.StackTrace, "No Data entered in  fields")

        Catch ex As Exception


            MessageBox.Show(ex.Message & vbCrLf &
                     ex.GetType.ToString &
                      vbCrLf & ex.StackTrace, "Exception")
        End Try



    End Sub


    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim Clr As Control
        For Each Clr In Me.Controls
            If TypeOf Clr Is TextBox Then
                Clr.Text = Nothing
            End If
            cboBxDId.SelectedIndex = -1
            cboBxV1.SelectedIndex = -1
            cboBxV2.SelectedIndex = -1
            cboBxV3.SelectedIndex = -1
            cboBxV4.SelectedIndex = -1
            pictureBox1.Image = Nothing
        Next
    End Sub
    Private Sub BtnAllTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllTest.Click

        resultBox.Show()




    End Sub
    Private Sub CboBxDId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBxDId.SelectedIndexChanged

        If cboBxDId.Text = "100" Then
            txtDFname.Text = "Bart"
            txtDLname.Text = "Simpson"
            txtDPhone.Text = "909-888-7777"

            'put image in bin file/ debug
            pictureBox1.Image = Image.FromFile("Bart.png")


        ElseIf cboBxDId.Text = "200" Then
            txtDFname.Text = "Homer"
            txtDLname.Text = "Simpson"
            txtDPhone.Text = "909-666-5555"
            pictureBox1.Image = Image.FromFile("homer.png")
        ElseIf cboBxDId.Text = "300" Then
            txtDFname.Text = "Marge"
            txtDLname.Text = "Simpson"
            txtDPhone.Text = "909-111-3333"
            pictureBox1.Image = Image.FromFile("Marge.png")
        ElseIf cboBxDId.Text = "400" Then
            txtDFname.Text = "Lisa"
            txtDLname.Text = "Simpson"
            txtDPhone.Text = "909-333-6666"
            pictureBox1.Image = Image.FromFile("Lisa.png")


        End If

    End Sub


   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlideshow.Click
        HaloSlideshow.Show()

    End Sub
End Class