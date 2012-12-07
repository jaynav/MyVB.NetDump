Imports BusinessLib
Public Class frmSummary
    Private controller As CController
    Private Sub frmSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load all orders by using the controller
       
        controller = CType(Me.ParentForm, frmMain).controller




        Dim createAconnection As New CController()
        Dim getorderinfo As List(Of String())


        'clears, gets data from getordersinfo of the ccontroller
        Try
            dtgOrdersSummary.Rows.Clear()
            createAconnection.getOrdersInfo()
            getorderinfo = createAconnection.getOrdersInfo()



            ' counts all the rows in the database
            For aLetterI As Integer = 0 To getorderinfo.Count() - 1
                Dim TheRow() As String = getorderinfo(aLetterI)
                dtgOrdersSummary.Rows.Add(1)




                'sets the info in dtgorders
                For zz As Integer = 0 To 3
                    Dim theValueInCell As String = TheRow(zz)
                    dtgOrdersSummary(zz, aLetterI).Value = theValueInCell
                Next

                ' repeats untill the hash has been counted for
            Next


        Catch ex As Exception

            MessageBox.Show("an error occured downloading" & vbCrLf &
                            "the orders")
        End Try








       
    End Sub




   
End Class