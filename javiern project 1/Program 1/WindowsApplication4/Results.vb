Public Class resultBox

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rtxtb1 As String = 0
        Dim testSummary As String
        testSummary = "Number of Tests:      " & MPFCCalculator.stestno &
            vbCrLf & "Vehicles Tested:       " & MPFCCalculator.vtested &
            vbCrLf & "Total Miles Travelled: " & FormatNumber(MPFCCalculator.mtravel, 0) &
            vbCrLf & "Total Fuel Cells Used: " & FormatNumber(MPFCCalculator.fcells, 0) &
            vbCrLf & "Total Cost:            " & FormatCurrency(MPFCCalculator.TCost, 2)
        Me.rtxtb1.Text = testSummary
    End Sub

    Private Sub btnResclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResclose.Click
        Me.Close()
    End Sub
End Class