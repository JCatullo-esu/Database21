<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMakeModelColor
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
        Me.ModelText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MakeText = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ColorText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddNewMakeModel = New System.Windows.Forms.Button()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ModelText
        '
        Me.ModelText.Location = New System.Drawing.Point(169, 87)
        Me.ModelText.Name = "ModelText"
        Me.ModelText.Size = New System.Drawing.Size(96, 20)
        Me.ModelText.TabIndex = 243
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 242
        Me.Label2.Text = "Model"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Make"
        '
        'MakeText
        '
        Me.MakeText.Location = New System.Drawing.Point(54, 87)
        Me.MakeText.Name = "MakeText"
        Me.MakeText.Size = New System.Drawing.Size(96, 20)
        Me.MakeText.TabIndex = 240
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 25)
        Me.Label10.TabIndex = 259
        Me.Label10.Text = "Add New Make and Model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 261
        Me.Label4.Text = "Color"
        '
        'ColorText
        '
        Me.ColorText.Location = New System.Drawing.Point(104, 220)
        Me.ColorText.Name = "ColorText"
        Me.ColorText.Size = New System.Drawing.Size(96, 20)
        Me.ColorText.TabIndex = 260
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 25)
        Me.Label3.TabIndex = 262
        Me.Label3.Text = "Add a New Color"
        '
        'AddNewMakeModel
        '
        Me.AddNewMakeModel.Location = New System.Drawing.Point(293, 96)
        Me.AddNewMakeModel.Name = "AddNewMakeModel"
        Me.AddNewMakeModel.Size = New System.Drawing.Size(166, 48)
        Me.AddNewMakeModel.TabIndex = 270
        Me.AddNewMakeModel.Text = "Add New Make/Model "
        Me.AddNewMakeModel.UseVisualStyleBackColor = True
        '
        'ColorButton
        '
        Me.ColorButton.Location = New System.Drawing.Point(293, 192)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(166, 48)
        Me.ColorButton.TabIndex = 271
        Me.ColorButton.Text = "Add A New Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 48)
        Me.Button1.TabIndex = 272
        Me.Button1.Text = "Import from XML"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewMakeModelColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 252)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.AddNewMakeModel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ColorText)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ModelText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MakeText)
        Me.Name = "NewMakeModelColor"
        Me.Text = "NewMakeModelColor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ModelText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MakeText As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ColorText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddNewMakeModel As Button
    Friend WithEvents ColorButton As Button
    Friend WithEvents Button1 As Button
End Class
