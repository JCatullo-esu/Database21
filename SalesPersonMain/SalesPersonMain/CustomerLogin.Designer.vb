<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerLogin
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CUserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewSalesMan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(74, 292)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(202, 69)
        Me.SubmitButton.TabIndex = 11
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CPassword
        '
        Me.CPassword.Location = New System.Drawing.Point(59, 185)
        Me.CPassword.Name = "CPassword"
        Me.CPassword.Size = New System.Drawing.Size(230, 20)
        Me.CPassword.TabIndex = 12
        Me.CPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Enter a username and password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Username"
        '
        'CUserName
        '
        Me.CUserName.Location = New System.Drawing.Point(59, 123)
        Me.CUserName.Name = "CUserName"
        Me.CUserName.Size = New System.Drawing.Size(230, 20)
        Me.CUserName.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Login as a customer"
        '
        'NewSalesMan
        '
        Me.NewSalesMan.Location = New System.Drawing.Point(74, 228)
        Me.NewSalesMan.Name = "NewSalesMan"
        Me.NewSalesMan.Size = New System.Drawing.Size(202, 49)
        Me.NewSalesMan.TabIndex = 29
        Me.NewSalesMan.Text = "Customer Registration"
        Me.NewSalesMan.UseVisualStyleBackColor = True
        '
        'CustomerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 384)
        Me.Controls.Add(Me.NewSalesMan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CUserName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CPassword)
        Me.Controls.Add(Me.SubmitButton)
        Me.Name = "CustomerLogin"
        Me.Text = "CustomerLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents CPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CUserName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NewSalesMan As Button
End Class
