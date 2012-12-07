<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resultBox
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
        Me.rtxtb1 = New System.Windows.Forms.RichTextBox()
        Me.btnResclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtxtb1
        '
        Me.rtxtb1.Location = New System.Drawing.Point(24, 24)
        Me.rtxtb1.Name = "rtxtb1"
        Me.rtxtb1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.rtxtb1.Size = New System.Drawing.Size(210, 171)
        Me.rtxtb1.TabIndex = 0
        Me.rtxtb1.Text = ""
        '
        'btnResclose
        '
        Me.btnResclose.Location = New System.Drawing.Point(183, 219)
        Me.btnResclose.Name = "btnResclose"
        Me.btnResclose.Size = New System.Drawing.Size(75, 23)
        Me.btnResclose.TabIndex = 1
        Me.btnResclose.Text = "close"
        Me.btnResclose.UseVisualStyleBackColor = True
        '
        'resultBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnResclose)
        Me.Controls.Add(Me.rtxtb1)
        Me.Name = "resultBox"
        Me.Text = "Results"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxtb1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnResclose As System.Windows.Forms.Button
End Class
