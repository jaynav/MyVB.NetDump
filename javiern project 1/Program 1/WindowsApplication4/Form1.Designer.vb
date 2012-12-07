<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HaloSlideshow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.slideshowbox = New System.Windows.Forms.PictureBox()
        Me.btnslideclose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtInfo = New System.Windows.Forms.RichTextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        CType(Me.slideshowbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'slideshowbox
        '
        Me.slideshowbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.slideshowbox.Location = New System.Drawing.Point(139, 12)
        Me.slideshowbox.Name = "slideshowbox"
        Me.slideshowbox.Size = New System.Drawing.Size(163, 167)
        Me.slideshowbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.slideshowbox.TabIndex = 0
        Me.slideshowbox.TabStop = False
        '
        'btnslideclose
        '
        Me.btnslideclose.Location = New System.Drawing.Point(227, 227)
        Me.btnslideclose.Name = "btnslideclose"
        Me.btnslideclose.Size = New System.Drawing.Size(75, 23)
        Me.btnslideclose.TabIndex = 1
        Me.btnslideclose.Text = "close me"
        Me.btnslideclose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(140, 227)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "start show"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'txtInfo
        '
        Me.txtInfo.Enabled = False
        Me.txtInfo.Location = New System.Drawing.Point(2, 73)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(122, 106)
        Me.txtInfo.TabIndex = 3
        Me.txtInfo.Text = "to start show, " & Global.Microsoft.VisualBasic.ChrW(10) & "press the start show button." & Global.Microsoft.VisualBasic.ChrW(10) & "slide show is timed delayed." & Global.Microsoft.VisualBasic.ChrW(10) & "takes 3" & _
            " seconds for each picture to load."
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Location = New System.Drawing.Point(149, 195)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 4
        '
        'HaloSlideshow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 269)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnslideclose)
        Me.Controls.Add(Me.slideshowbox)
        Me.Name = "HaloSlideshow"
        Me.Text = "Halo Slide Show"
        CType(Me.slideshowbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents slideshowbox As System.Windows.Forms.PictureBox
    Friend WithEvents btnslideclose As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
End Class
