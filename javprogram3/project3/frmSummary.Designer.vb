<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgOrdersSummary = New System.Windows.Forms.DataGridView()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgOrdersSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgOrdersSummary
        '
        Me.dtgOrdersSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOrdersSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderID, Me.OrderName, Me.OrderDate, Me.OrderTotal})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgOrdersSummary.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgOrdersSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOrdersSummary.Location = New System.Drawing.Point(0, 0)
        Me.dtgOrdersSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgOrdersSummary.Name = "dtgOrdersSummary"
        Me.dtgOrdersSummary.ReadOnly = True
        Me.dtgOrdersSummary.RowTemplate.Height = 24
        Me.dtgOrdersSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOrdersSummary.Size = New System.Drawing.Size(660, 374)
        Me.dtgOrdersSummary.TabIndex = 0
        '
        'OrderID
        '
        Me.OrderID.HeaderText = "ID"
        Me.OrderID.Name = "OrderID"
        Me.OrderID.ReadOnly = True
        '
        'OrderName
        '
        Me.OrderName.HeaderText = "Name"
        Me.OrderName.Name = "OrderName"
        Me.OrderName.ReadOnly = True
        '
        'OrderDate
        '
        Me.OrderDate.HeaderText = "Date"
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.ReadOnly = True
        '
        'OrderTotal
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.OrderTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.OrderTotal.HeaderText = "Total"
        Me.OrderTotal.Name = "OrderTotal"
        Me.OrderTotal.ReadOnly = True
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 374)
        Me.Controls.Add(Me.dtgOrdersSummary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSummary"
        Me.Text = "Orders Summary"
        CType(Me.dtgOrdersSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgOrdersSummary As System.Windows.Forms.DataGridView
    Friend WithEvents OrderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
