Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        'Declare variable and get value for total amount
        Dim totalAmount As Decimal = 0
        totalAmount = Me.txtAmount.Text

        'variable to hohld discount percent
        Dim discountPercent As Decimal = 0

        'determine the discount rate
        If (totalAmount >= 500) Then
            discountPercent = 0.2
        ElseIf (totalAmount >= 250 And totalAmount < 500) Then
            discountPercent = 0.15
        ElseIf (totalAmount >= 100 And totalAmount < 250) Then
            discountPercent = 0.1
        Else
            discountPercent = 0
        End If

        'calculate the discount amount
        Dim discountAmount As Decimal = totalAmount * discountPercent

        'calculate the total amount
        Dim total As Decimal = totalAmount - discountAmount

        'display the values
        Me.txtAmount.Text = FormatCurrency(totalAmount, 2)
        Me.txtDiscount.Text = FormatPercent(discountPercent, 1)
        Me.lblDiscountValue.Text = FormatCurrency(discountAmount, 2)
        Me.txtTotal.Text = FormatCurrency(total, 2)


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
