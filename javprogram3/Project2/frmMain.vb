Public Class frmMain

    Private x As Integer = 0
    Public controller As New clsController

    Private Sub mnuFileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNew.Click
        'Open new form
        Dim frm As frmChild
        frm = New frmChild
        x += 1
        frm.Text = "Child " & x
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        'Close the parent form
        Me.Close()
    End Sub

    Private Sub mnuFileClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileClose.Click
        'Close the application
        If Not Me.ActiveMdiChild Is Nothing Then
            Me.ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub mnuFile_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFile.DropDownOpening
        If Not Me.ActiveMdiChild Is Nothing Then
            mnuFileClose.Enabled = True
        Else
            mnuFileClose.Enabled = False
        End If
    End Sub

    Private Sub mnuEditCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditCut.Click
        Clipboard.SetText(CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText)
        CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText = ""
    End Sub

    Private Sub mnuEditCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditCopy.Click
        Clipboard.SetText(CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText)
    End Sub

    Private Sub mnuEditPaste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditPaste.Click
        CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText = Clipboard.GetText
    End Sub

    Private Sub mnuEdit_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEdit.DropDownOpening
        'Disable the menus
        mnuEditCut.Enabled = False
        mnuEditCopy.Enabled = False
        mnuEditPaste.Enabled = False

        'Re-enable the menus accordingly
        If Not Me.ActiveMdiChild Is Nothing Then
            If TypeOf Me.ActiveMdiChild.ActiveControl Is TextBox Then
                If CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText <> "" Then
                    mnuEditCut.Enabled = True
                    mnuEditCopy.Enabled = True
                End If
                If Clipboard.GetText <> "" Then
                    mnuEditPaste.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub mnuWindowCascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWindowCascade.Click
        'Arrange windows cascading
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuWindowHorizontal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWindowHorizontal.Click
        'Arrange windows tiled horizontally
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuWindowVertical_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWindowVertical.Click
        'Arrange windows tiled vertically
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub mnuFileDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles munFileDelete.Click
        'calls ative form and borrows its click event to delete current order on active form
        If TypeOf Me.ActiveMdiChild Is frmChild Then
            DirectCast(Me.ActiveMdiChild, frmChild).btnDelete.PerformClick()
            'direct cast is easier to use than the tag property

        End If

    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        'shows dialog for id input, opens a new form and populates the fields
        Dim selectedButton As DialogResult = promtForm.ShowDialog()

        If selectedButton = DialogResult.OK Then
            mnuFileNew.PerformClick()
            'sets prompt id = to txtId
            If TypeOf Me.ActiveMdiChild Is frmChild Then
                DirectCast(Me.ActiveMdiChild, frmChild).txtID.Text = promtForm.Tag.ToString
            End If
            'populates the fields
            If TypeOf Me.ActiveMdiChild Is frmChild Then
                DirectCast(Me.ActiveMdiChild, frmChild).btnRetrieve.PerformClick()
            End If


        End If
    End Sub


    Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        'calls ative form and borrows its  save click event to save active form
        If TypeOf Me.ActiveMdiChild Is frmChild Then
            DirectCast(Me.ActiveMdiChild, frmChild).btnSave.PerformClick()



        End If
    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' show a message box with about me info

        MessageBox.Show("Project Halo/ Project 2" & vbCrLf &
                        "Author: Javier Navarro" & vbCrLf &
                        "Email: Javiern@csupomona.edu")
    End Sub



End Class