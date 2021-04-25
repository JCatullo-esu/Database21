<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerreg
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
        Me.RePassBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.FNameBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usernamecheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RePassBox
        '
        Me.RePassBox.Location = New System.Drawing.Point(201, 180)
        Me.RePassBox.Name = "RePassBox"
        Me.RePassBox.Size = New System.Drawing.Size(100, 20)
        Me.RePassBox.TabIndex = 23
        Me.RePassBox.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Re-enter Password"
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(67, 180)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.Size = New System.Drawing.Size(100, 20)
        Me.PassBox.TabIndex = 21
        Me.PassBox.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Username"
        '
        'UserBox
        '
        Me.UserBox.Location = New System.Drawing.Point(266, 110)
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(100, 20)
        Me.UserBox.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Last Name"
        '
        'LNameBox
        '
        Me.LNameBox.Location = New System.Drawing.Point(142, 110)
        Me.LNameBox.Name = "LNameBox"
        Me.LNameBox.Size = New System.Drawing.Size(100, 20)
        Me.LNameBox.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Enter the following fields to register"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(93, 301)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(163, 45)
        Me.SubmitButton.TabIndex = 14
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'FNameBox
        '
        Me.FNameBox.Location = New System.Drawing.Point(19, 110)
        Me.FNameBox.Name = "FNameBox"
        Me.FNameBox.Size = New System.Drawing.Size(100, 20)
        Me.FNameBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "First Name"
        '
        'usernamecheck
        '
        Me.usernamecheck.Location = New System.Drawing.Point(93, 235)
        Me.usernamecheck.Name = "usernamecheck"
        Me.usernamecheck.Size = New System.Drawing.Size(163, 45)
        Me.usernamecheck.TabIndex = 24
        Me.usernamecheck.Text = "Check username availability"
        Me.usernamecheck.UseVisualStyleBackColor = True
        '
        'customerreg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 370)
        Me.Controls.Add(Me.usernamecheck)
        Me.Controls.Add(Me.RePassBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UserBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LNameBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.FNameBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "customerreg"
        Me.Text = "customerreg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RePassBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PassBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UserBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LNameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents FNameBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents usernamecheck As Button
End Class
