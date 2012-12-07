Public Class frmHelloWorld

    Private Sub btnGreet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreet.Click
        Dim name As String

        name = "Hello " & Me.txtFullName.Text & " Welcome to CIS338"

        MessageBox.Show(name, "Hello World Greeting")
    End Sub
End Class
