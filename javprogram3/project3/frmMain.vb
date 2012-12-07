Imports BusinessLib
Public Class frmMain
    Private intFormCount As Integer = 0
    Private orderController As CController

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("BuckStar Cafe" & vbCrLf & "Author: Javier Navarro for CIS338" & vbCrLf & "Email: javiern@Csupomona.edu", "Contact Information", MessageBoxButtons.OK)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ArrangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        Dim ofrm As New frmOrder
        For Each ofrm In Me.MdiChildren
            ofrm.Close()
            intFormCount = 0
        Next
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Try
            Clipboard.SetText(CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText)
            CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText = ""
        Catch
        End Try
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            Clipboard.SetText(CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText)
        Catch
        End Try
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText = Clipboard.GetText
        Catch
        End Try
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        orderController = New CController
    End Sub

    Protected Overrides Sub Finalize()
        orderController = Nothing
        MyBase.Finalize()
    End Sub

    Public ReadOnly Property controller() As CController
        Get
            Return orderController
        End Get
    End Property

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim f As frmOrder = CType(Me.ActiveMdiChild, frmOrder)
        f.btnProcess.PerformClick()
    End Sub

    Private Sub NewOrderToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderToolStripMenuItem.Click
        Dim f As New frmOrder
        f.MdiParent = Me
        intFormCount = intFormCount + 1
        f.Text = "BuckStar Cafe Order Form " & intFormCount
        f.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click
        If IsNothing(Me.ActiveMdiChild) = False Then
            'enable menus
            DeleteToolStripMenuItem.Enabled = True
            SaveToolStripMenuItem.Enabled = True
            CloseToolStripMenuItem.Enabled = True
        Else
            'disable menus
            DeleteToolStripMenuItem.Enabled = False
            SaveToolStripMenuItem.Enabled = False
            CloseToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim anID As String = InputBox("Enter an Order ID", "Open Order", "Enter ID")
        If anID = "" Then Exit Sub

        Dim f As New frmOrder
        f.MdiParent = Me
        intFormCount = intFormCount + 1
        f.Text = "BuckStar Cafe Order Form " & intFormCount
        f.txtID.Text = anID
        f.Show()
        f.btnRetrieve.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim f As frmOrder = Me.ActiveMdiChild
        f.btnDelete.PerformClick()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Dim f As frmOrder = Me.ActiveMdiChild
        f.Close()
    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load our orders from DB
       
        Dim f As New frmSummary
        f.MdiParent = Me
        f.Show()


        MessageBox.Show(controller.getOrdersInfo.Count & vbCrLf & "orders loaded")
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click

        Dim f As New frmSummary
        f.MdiParent = Me
        f.Show()
        
    End Sub
End Class