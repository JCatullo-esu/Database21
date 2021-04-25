<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrevPurch
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
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SumLabel = New System.Windows.Forms.Label()
        Me.Refreshb = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(238, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(274, 31)
        Me.Label26.TabIndex = 292
        Me.Label26.Text = "Previous Purchase(s)"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(92, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(589, 318)
        Me.DataGridView1.TabIndex = 293
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 412)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 18)
        Me.Label1.TabIndex = 294
        Me.Label1.Text = "Total Amount Spent $"
        '
        'SumLabel
        '
        Me.SumLabel.AutoSize = True
        Me.SumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumLabel.Location = New System.Drawing.Point(270, 412)
        Me.SumLabel.Name = "SumLabel"
        Me.SumLabel.Size = New System.Drawing.Size(0, 18)
        Me.SumLabel.TabIndex = 296
        '
        'Refreshb
        '
        Me.Refreshb.Location = New System.Drawing.Point(457, 412)
        Me.Refreshb.Name = "Refreshb"
        Me.Refreshb.Size = New System.Drawing.Size(115, 39)
        Me.Refreshb.TabIndex = 297
        Me.Refreshb.Text = "Refresh"
        Me.Refreshb.UseVisualStyleBackColor = True
        '
        'PrevPurch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 487)
        Me.Controls.Add(Me.Refreshb)
        Me.Controls.Add(Me.SumLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label26)
        Me.Name = "PrevPurch"
        Me.Text = "PrevPurch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label26 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents SumLabel As Label
    Friend WithEvents Refreshb As Button
End Class
