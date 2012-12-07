Public Class orderReports
    Private controller As clsController
    Private Sub orderReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        controller = CType(Me.ParentForm, frmMain).controller
    End Sub
End Class