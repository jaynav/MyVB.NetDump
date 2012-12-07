Public Class HaloSlideshow

    Private Sub btnslideclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnslideclose.Click
        Me.Close()
    End Sub


   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' create a number between a certain value and becomes the interval
        Dim max As Integer = 3000
        Dim rnd As New Random
        Dim rand As Integer = rnd.Next(10, max + 1)
        Dim i As Integer = 1
        Dim number(max - 1) As Integer

        For i = 0 To max - 1
            If number(i) = rand Then
                rand = rnd.Next(1, max + 1)
                i = -1
            ElseIf number(i) = 0 Then
                number(i) = rand
                rand = rnd.Next(1, max + 1)
                If i = max - 1 Then
                    Exit For
                End If
                i = -1
            End If
        Next
        Timer1.Interval = number(i)
        i += 1

        ChangeImage()
    End Sub

    Private Sub ChangeImage()

        Static Dim iImage1 As Integer

        Select Case iImage1
            Case 0

                slideshowbox.Visible = True
                slideshowbox.Image = Image.FromFile("banshee.gif")
                iImage1 += 1
                txtname.Text = "Banshee"
            Case 1

                slideshowbox.Visible = True
                slideshowbox.Image = Image.FromFile("ghost.gif")
                iImage1 += 1
                txtname.Text = "ghost"
            Case 2

                slideshowbox.Visible = True
                slideshowbox.Image = Image.FromFile("chopper.gif")
                iImage1 += 1
                txtname.Text = "chopper"
            Case 3

                slideshowbox.Visible = True
                slideshowbox.Image = Image.FromFile("hornet.gif")
                iImage1 += 1
                txtname.Text = "hornet"
            Case 4
                iImage1 = 0

        End Select
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Timer1.Start()
    End Sub

    
    
End Class