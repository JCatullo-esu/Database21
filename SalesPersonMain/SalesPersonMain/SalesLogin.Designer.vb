<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SUserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SPassword = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.NewSalesMan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Password"
        '
        'SUserName
        '
        Me.SUserName.Location = New System.Drawing.Point(65, 94)
        Me.SUserName.Name = "SUserName"
        Me.SUserName.Size = New System.Drawing.Size(230, 20)
        Me.SUserName.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Enter a username and password"
        '
        'SPassword
        '
        Me.SPassword.Location = New System.Drawing.Point(65, 156)
        Me.SPassword.Name = "SPassword"
        Me.SPassword.Size = New System.Drawing.Size(230, 20)
        Me.SPassword.TabIndex = 23
        Me.SPassword.UseSystemPasswordChar = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(81, 269)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(202, 69)
        Me.SubmitButton.TabIndex = 22
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'NewSalesMan
        '
        Me.NewSalesMan.Location = New System.Drawing.Point(81, 205)
        Me.NewSalesMan.Name = "NewSalesMan"
        Me.NewSalesMan.Size = New System.Drawing.Size(202, 49)
        Me.NewSalesMan.TabIndex = 28
        Me.NewSalesMan.Text = "Salesman Registration"
        Me.NewSalesMan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 31)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Login as a salesman"
        '
        'SalesLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 367)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewSalesMan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SUserName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SPassword)
        Me.Controls.Add(Me.SubmitButton)
        Me.Name = "SalesLogin"
        Me.Text = "SalesLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents SUserName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SPassword As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents NewSalesMan As Button
    Friend WithEvents Label1 As Label
End Class
