Imports System.Windows.Forms

Public Class promtForm
    'this is the prompt form for opening a saved file
    'this prompt opens and asks for an id number
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Tag = txtPromptIdInfo.Text
        Me.Close()
    End Sub
    ' cancel button cancels request
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
